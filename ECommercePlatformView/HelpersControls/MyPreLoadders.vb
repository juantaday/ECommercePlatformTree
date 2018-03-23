Public Class MyPreLoadders
    Private dir As Integer
    Private Sub Stretcht_Tick(sender As Object, e As EventArgs) Handles Stretcht.Tick
        If Me.BunifuCircleProgressbar1.Value = 90 Then
            dir = -1
            BunifuCircleProgressbar1.animationIterval = 4
        ElseIf (Me.BunifuCircleProgressbar1.Value = 10) Then
            dir = +1
            BunifuCircleProgressbar1.animationIterval = 2
        End If

        Me.BunifuCircleProgressbar1.Value += dir
    End Sub

    Private Sub MyPreLoadders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dir = 1
        Me.StopRunnig()
    End Sub
    Public Sub StopRunnig()
        Stretcht.Stop()
        BunifuCircleProgressbar1.animated = False
        BunifuCircleProgressbar1.Value = 0
    End Sub
    Public Sub StartRunnig()
        Stretcht.Start()
        BunifuCircleProgressbar1.animated = True
        BunifuCircleProgressbar1.Value = 20
    End Sub

End Class
