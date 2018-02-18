Public Class frmbackup_Base
    Private NameArchiv As String
    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        If fileNameTextBox.Text.Length = 0 Or NameArchiv.ToString.Length = 0 Then
            MessageBox.Show("Debe seleccionar la rura del arcchivo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            Timer1.Start()
            Dim fun As New fbackup
            If fun.backupbase(fileNameTextBox.Text, NameArchiv) Then
                MessageBox.Show("Backup generado satisfactoriamente", "BACKUP BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Backup NO PUEDE SER GENERADO", "BACKUP BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        Finally
            Me.Cursor = Cursors.Default
            Timer1.Stop()
            ProgressBar1.Value = 0
        End Try
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        Try
            ' Displays an OpenFileDialog so the user can select a Cursor.
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Cursor Files|*.bak"
            openFileDialog1.Title = "Selecione la direccion del respaldo"

            ' Show the Dialog.
            ' If the user clicked OK in the dialog and 
            ' a .CUR file was selected, open it.
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                fileNameTextBox.Text = openFileDialog1.FileName
                Dim tes As String = openFileDialog1.SafeFileName
                Dim position As Integer = 0
                position = InStr(tes, ".")
                tes = tes.Substring(0, position.ToString.Length - (position.ToString.Length - position + 1))
                NameArchiv = tes
            End If 
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value = 100 Then
            Me.ProgressBar1.Value = 0
        Else
            Me.ProgressBar1.Value += 1
        End If
    End Sub
End Class