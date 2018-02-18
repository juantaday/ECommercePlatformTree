Public Class frmFaltantesSobrantes
    Private Sub frmFaltantesSobrantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadView()
    End Sub
    Sub LoadView()
        Try
            Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
            'ElementHost1
            '
            Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ElementHost1.Location = New System.Drawing.Point(0, 0)
            Me.ElementHost1.Name = "ElementHost1"
            Me.ElementHost1.Size = New System.Drawing.Size(853, 315)
            Me.ElementHost1.TabIndex = 1
            Me.ElementHost1.Text = "ElementHost1"
            Me.PanelView.Controls.Add(Me.ElementHost1)
            'set the data
            Dim M_MoneyDetail As ViewFaltantesSobrantes
            M_MoneyDetail = New ECommercePlatformView.ViewFaltantesSobrantes
            Me.ElementHost1.Child = M_MoneyDetail
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class