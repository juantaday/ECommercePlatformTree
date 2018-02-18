Public Class frmViewDataReset
    Private Sub frmViewDataReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BindingSource1.DataSource = Me.LocationTableAdapter1.GetData()
        Me.DataGridView1.DataSource = BindingSource1
    End Sub
End Class