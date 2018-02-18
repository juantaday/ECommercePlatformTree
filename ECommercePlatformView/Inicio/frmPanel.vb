Public Class frmPanel
    Private Sub frmPanel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub frmPanel_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class