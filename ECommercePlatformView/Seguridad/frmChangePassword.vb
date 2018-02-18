Imports System.Windows.Forms
Imports CADsisVenta.DataSetUsersTableAdapters

Public Class frmChangePassword
    Private state As stateOperation
    Private dts As New getInicio
    Sub New(state As stateOperation, dts As getInicio)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.state = state
        Me.dts = dts
    End Sub
    Public Enum stateOperation
        runAplicatio = 0
        changePassword = 1
    End Enum

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuarioTextBox.Text = String.Format("{0} {1}", UsuarioActivo.Apellido, UsuarioActivo.Nombre)
        Select Case state
            Case stateOperation.runAplicatio
                currentPaswordTextBox.Text = Me.dts.Password
                currentPaswordTextBox.Enabled = False
            Case stateOperation.changePassword
        End Select
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidaDatos() Then
            If Not Me.ChangePassword() Then
                Return
            End If
            MsgBox("Cotraseña modificada correctamente", MsgBoxStyle.Exclamation, msgExsito)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ChangePassword() As Boolean
        Try
            Using cmd As New UsuariosTableAdapter
                If cmd.UpdatePassword(SHA1(newPasswordTextBox.Text), dts.GUsuario) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaDatos() As Boolean
        If String.IsNullOrEmpty(currentPaswordTextBox.Text) Then
            MsgBox("Ingrese la contraseña actual", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If

        If String.IsNullOrEmpty(newPasswordTextBox.Text) Then
            MsgBox("Ingrese la nueva contraseña", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If

        If String.IsNullOrEmpty(confirmPasswordTextBox.Text) Then
            MsgBox("Ingrese la confirmación de contraseña", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If

        If newPasswordTextBox.Text.Equals(currentPaswordTextBox.Text) Then
            MsgBox("La nueva contraseña debe ser diferente a la actual", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If

        If Not newPasswordTextBox.Text.Equals(confirmPasswordTextBox.Text) Then
            MsgBox("La contraseña de confirmación es incorrecto", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If
        'valida secion
        Dim response As Response = PruevaSecion()
        If Not response.Success Then
            MsgBox(response.Messague, MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If
        Return True
    End Function

    Private Function PruevaSecion() As Response
        Dim dts As New getInicio
        Dim func As New FunInicio
        Dim response As New Response
        Try
            dts.GUsuario = (UsuarioActivo.codUser)
            dts.gContrasena = currentPaswordTextBox.Text
            If conecta_sql() Then
                Dim loginREsponse As New Response
                loginREsponse = func.PruevaSecion(dts)
                If loginREsponse.Success Then
                    response.Success = True
                Else
                    response.Messague = loginREsponse.Messague
                    response.Success = False
                End If
                Return response
            End If
            response.Success = True
            Return response
        Catch ex As Exception
            response.Success = ex.Message
            response.Success = False
            Return response
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
