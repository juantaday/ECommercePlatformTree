Imports System.Windows.Forms

Public Class frmCahgedNameTranfer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        NewNameTransferTextBox.Text = Trim(NewNameTransferTextBox.Text)
        If String.IsNullOrWhiteSpace(Me.NewNameTransferTextBox.Text) Then
            MsgBox("Debe ingresar el motivo del traslado", MsgBoxStyle.Exclamation, "Importante..")
            Return
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
