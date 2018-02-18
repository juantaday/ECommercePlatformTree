Imports Bunifu

Public Class frmBalanceGeneral

    Private Sub frmBalanceGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GeneralBunifuFlatButton_Click(sender As Object, e As EventArgs) Handles AnualBunifuFlatButton.Click, MensulBunifuFlatButton.Click
        SetSelectForeColor(DirectCast(sender, Framework.UI.BunifuFlatButton))
        Try
            PanelView.Controls.Clear()
            Dim TabBalanceGeneral1 = New ECommercePlatformView.TabBalanceGeneral
            TabBalanceGeneral1.Dock = DockStyle.Fill
            PanelView.Controls.Add(TabBalanceGeneral1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub SetSelectForeColor(sender As Framework.UI.BunifuFlatButton)
        Try
            Me.SalesToDateBunifuFlatButton.Textcolor = Color.DimGray
            Me.MensulBunifuFlatButton.Textcolor = Color.DimGray
            Me.AnualBunifuFlatButton.Textcolor = Color.DimGray

            Me.SalesToDateBunifuFlatButton.selected = False
            Me.MensulBunifuFlatButton.selected = False
            Me.AnualBunifuFlatButton.selected = False


            Me.SalesToDateBunifuFlatButton.Normalcolor = Color.Gainsboro
            Me.MensulBunifuFlatButton.Normalcolor = Color.Gainsboro
            Me.AnualBunifuFlatButton.Normalcolor = Color.Gainsboro
            sender.selected = True
            If sender.selected Then
                sender.Textcolor = Color.White
                sender.BackColor = sender.Activecolor
                sender.Normalcolor = sender.Activecolor
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub MensulBunifuFlatButton_Click(sender As Object, e As EventArgs)
        SetSelectForeColor(DirectCast(sender, Framework.UI.BunifuFlatButton))
    End Sub

    Private Sub AnualBunifuFlatButton_Click(sender As Object, e As EventArgs)
        SetSelectForeColor(DirectCast(sender, Framework.UI.BunifuFlatButton))
    End Sub

    Private Sub SalesToDateBunifuFlatButton_Click(sender As Object, e As EventArgs) Handles SalesToDateBunifuFlatButton.Click
        SetSelectForeColor(DirectCast(sender, Framework.UI.BunifuFlatButton))
        Try
            Me.Cursor = Cursors.WaitCursor
            PanelView.Controls.Clear()
            Dim TabBalanceGeneral1 = New ECommercePlatformView.TabSalesToDate
            TabBalanceGeneral1.Dock = DockStyle.Fill
            PanelView.Controls.Add(TabBalanceGeneral1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class