Public Class BackupMediaOption
    Private Sub BackupMediaOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.CompresionComboBox.Items.Count > 0 Then
            CompresionComboBox.SelectedIndex = 0
        End If
    End Sub
End Class
