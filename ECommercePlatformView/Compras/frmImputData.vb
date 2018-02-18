Public Class frmImputData
    Dim dato As Double
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter

        Try
            Dim valor As String = sender.Value
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                Sql = Strings.Left(valor, posicion - 1)
                sender.Select(0, Len(Sql) + 1 + sender.DecimalPlaces)
            Else
                sender.Select(0, Len(valor) + 1 + sender.DecimalPlaces)
            End If

        Catch ex As Exception
            MsgBox(ex.Message + "en le txtNumber_Enter del " + Name, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub

    Private Sub txtNumber_ValueChanged(sender As Object, e As EventArgs) Handles txtNumber.ValueChanged
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtNumber.Visible = True
    End Sub
End Class
