Public Class BackupOverwrite
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.RadioGroup2.Enabled = RadioButton1.Checked
    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged

    End Sub
End Class
