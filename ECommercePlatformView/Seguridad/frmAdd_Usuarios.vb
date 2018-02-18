Imports System.Data.SqlClient
Imports CADsisVenta.DataSetUsers
Imports CADsisVenta.DataSetUsersTableAdapters
Public Class frmAdd_Usuarios
    Private state As stateOperation
    Private login As String
    Private idPersonas As Integer
    Private tiempo As Integer
    Sub New(state As stateOperation, login As String, idPersonas As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.state = state
        Me.login = login
        Me.idPersonas = idPersonas
        tiempo = 0
    End Sub
    Private Sub frmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.CharacterCasing = CharacterCasing.Upper
        Select Case state
            Case stateOperation.Insert
                estadoCheckBox.Checked = True
                estadoCheckBox.Enabled = False
                iniciadoCheckBox.Checked = False
                iniciadoCheckBox.Enabled = False
            Case stateOperation.Update
                txtLogin.Enabled = False
                FinPersonButton.Text = "Datos personales"
        End Select
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtApellidos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtApellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese los apellidos")
        End If
    End Sub
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre")
        End If
    End Sub

    Private Sub txtRuc_Ci_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRuc_Ci.Validating, txtLogin.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ruc o cedula de identidad")
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            btnGuardar.Enabled = False
            btnCancel.Enabled = False
            If Not Me.ValidateUser() Then
                Return
            End If
            Dim response As Boolean = False
            Select Case state
                Case stateOperation.Insert
                    response = add_Usuario()
                Case stateOperation.Update
                    response = Edit_Usuario()
            End Select


            If response Then
                Select Case state
                    Case stateOperation.Insert
                        Timer1.Start()
                    Case stateOperation.Update
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            btnGuardar.Enabled = True
            btnCancel.Enabled = True
        End Try
    End Sub

    Private Function ValidateUser() As Boolean
        Try
            Dim messageLogin As String = String.Empty
            Dim messageIdperson As String = String.Empty

            If IsNothing(idPersonas) Then
                messageIdperson = "No se ha determinado ningun usuario"
                GoTo ErrorIdperson
            End If

            If idPersonas = 0 Then
                messageIdperson = "No se ha determinado ningun usuario"
                GoTo ErrorIdperson
            End If
            If String.IsNullOrEmpty(txtLogin.Text) Then
                messageLogin = "Debe ingresar un código para el Usuario"
                GoTo ErrorLogin
            End If

            Select Case state
                Case stateOperation.Insert
                    'buscamos si este ligin ya existe
                    Using dat As New UsuariosTableAdapter
                        Using dt As New UsuariosDataTable()
                            dat.FillByLogin(dt, Me.txtLogin.Text)
                            If dt.Rows.Count > 0 Then
                                messageLogin = "Ya exsiste otro Usuario con este Login"
                                GoTo ErrorLogin
                            End If
                            dat.FillByIdPersona(dt, idPersonas)
                            If dt.Rows.Count > 0 Then
                                messageIdperson = "Esta persona ya consta como usuario."
                                GoTo ErrorIdperson
                            End If
                        End Using
                    End Using
            End Select
            Return True

ErrorIdperson:
            Me.ErrorIcono.SetError(FinPersonButton, messageIdperson)
            Me.ErrorIcono.SetError(txtApellidos, messageIdperson)
            Me.ErrorIcono.SetError(txtNombre, messageIdperson)
            Return False

ErrorLogin:
            Me.ErrorIcono.SetError(txtLogin, messageLogin)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Edit_Usuario() As Boolean
        Try
            Dim state As Int16 = 0
            If estadoCheckBox.Checked Then
                state = 1
            End If
            Using data As New UsuariosTableAdapter
                If data.UpdateEstado(state, txtLogin.Text) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function add_Usuario() As Boolean
        Try
            Dim data As New UsuariosTableAdapter
            If (data.InsertUser(txtLogin.Text, idPersonas, SHA1(txtLogin.Text), txtLogin.Text, Date.Now(), 0, 1, 0)) = 1 Then
                MsgBox("La contraseña de este usuario es el mismo login", MsgBoxStyle.Information, "Aviso")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el addUsuario del " + Me.Name, MsgBoxStyle.Critical, "Error al guardar como Usuarios")
            Return False
        End Try
    End Function

    Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
        Me.txtLogin.Text = UCase(Trim(Me.txtLogin.Text))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblInfoamcion.Visible = Not Me.lblInfoamcion.Visible
        tiempo += 1
        If tiempo = 3 Then
            Timer1.Interval = 200
        End If
        If tiempo = 8 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub FinPersonButton_Click(sender As Object, e As EventArgs) Handles FinPersonButton.Click
        Try
            Select Case state
                Case stateOperation.Insert
                    Using listPerson As New frmList_PersonViewTarget(stateLoad.Dialogo)
                        With listPerson
                            .StartPosition = FormStartPosition.CenterScreen
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                idPersonas = .idPersona
                                Carga_Persona(idPersonas)
                            End If
                        End With
                    End Using
                Case stateOperation.Update
                    Using listPerson As New frmAdd_Personas(stateOperation.Update, idPersona:=idPersonas)
                        With listPerson
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                idPersonas = .idPersona
                                Carga_Persona(idPersonas)
                            End If
                        End With
                    End Using
                Case stateOperation.View
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Persona(idPersona As Integer)
        Try
            Dim dat As New PersonasTableAdapter
            Dim dt As New DataTable
            dt = dat.GetDataByIdPersona(idPersona)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    txtApellidos.Text = dt.Rows(0)("Apellidos")
                    txtNombre.Text = dt.Rows(0)("Nombre")
                    Me.txtRuc_Ci.Text = dt.Rows(0)("Ruc_Ci")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
Private Sub txtLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLogin.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
        End If
    End Sub
End Class