Imports System.Windows.Forms
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CADsisVenta.DataSetPersonTableAdapters

Public Class frmAdd_Cuenta
    Private idBancoCuenta As Integer
    Private idBanco As Integer
    Private idPersona As Integer
    Private tipoCuenta As String
    Private numCuenta As String
    Private state As stateOperation
    Sub New(state As stateOperation, idBancoCuenta As Integer,
            idPersona As Integer, idBanco As Integer,
            tipoCuenta As String, numCuenta As String, namePerson As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idBancoCuenta = idBancoCuenta
        Me.idPersona = idPersona
        Me.idBanco = idBanco
        Me.tipoCuenta = tipoCuenta
        Me.numCuenta = numCuenta
        Me.state = state
        Me.Label1.Text = namePerson
        Select Case state
            Case stateOperation.Delete
                If Me.DeleteCuenta() Then
                    Me.DialogResult = DialogResult.OK
                Else
                    Me.DialogResult = DialogResult.No
                End If
        End Select
    End Sub
    Private Sub frmAdd_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Bancos()
        Select Case state
            Case stateOperation.Insert

            Case stateOperation.Update
                Me.BancosComboBox.SelectedValue = idBanco
                Me.cmbTipocuenta.SelectedText = Me.tipoCuenta
                Me.NumCuentaTextBox.Text = Me.numCuenta
            Case stateOperation.Delete
        End Select
    End Sub
    Private Sub Carga_Bancos()
        Try
            Dim dat As New BancosTableAdapter
            Dim dt As DataTable = dat.GetData()
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    BancosComboBox.DataSource = dt
                    BancosComboBox.DisplayMember = "nom_Banco"
                    BancosComboBox.ValueMember = "idBanco"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en le Carga_Bancos ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim response As Boolean = False
            Select Case state
                Case stateOperation.Insert
                    response = SaveCuenta()
                Case stateOperation.Update
                    response = EditCuenta()
                Case stateOperation.Delete
                    response = DeleteCuenta()
            End Select
            If response Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function DeleteCuenta() As Boolean
        Try
            Dim dat As New BancosCuentasTableAdapter
            Dim response As Integer = dat.DeleteBancosCuentas(idBancoCuenta)
            If response = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.Message.Contains("REFERENCES") Then
                MsgBox("", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try
    End Function

    Private Function EditCuenta() As Boolean
        If Not valida_Datos() Then
            Return False
        End If
        Try
            Dim dat As New BancosCuentasTableAdapter
            Dim response As Integer = dat.UpdateBancosCuentas(
                BancosComboBox.SelectedValue,
                idPersona, NumCuentaTextBox.Text,
                 cmbTipocuenta.Items(cmbTipocuenta.SelectedIndex).ToString,
                idBancoCuenta)
            If response = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Function SaveCuenta() As Boolean
        If Not valida_Datos() Then
            Return False
        End If
        Try
            Dim dat As New BancosCuentasTableAdapter
            sql = cmbTipocuenta.Items(cmbTipocuenta.SelectedIndex).ToString
            Dim response As Integer = dat.InsertBancosCuentas(BancosComboBox.SelectedValue,
                                    idPersona,
                                    Me.NumCuentaTextBox.Text,
                                     cmbTipocuenta.Items(cmbTipocuenta.SelectedIndex).ToString)
            If response = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function valida_Datos() As Boolean
        Try
            If BancosComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione un banco", MsgBoxStyle.Exclamation, "Importante")
                BancosComboBox.Focus()
                Return False
            End If

            If cmbTipocuenta.SelectedIndex = -1 Then
                MsgBox("Seleccione tipo de cuenta", MsgBoxStyle.Exclamation, "Importante")
                cmbTipocuenta.Focus()
                Return False
            End If

            If String.IsNullOrEmpty(NumCuentaTextBox.Text) Then
                MsgBox("Ingrese el número de cuenta", MsgBoxStyle.Exclamation, "Importante")
                NumCuentaTextBox.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub NumCuentaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumCuentaTextBox.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub AddBankButton_Click(sender As Object, e As EventArgs) Handles AddBankButton.Click
        Try
            Using listBank As New frmListBancos
                With listBank
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Bancos()
                    End If
                End With
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
