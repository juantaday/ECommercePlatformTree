Imports System.Threading

Partial Public Class WaitForTaskScreenWithCancellation
    Inherits System.Windows.Forms.Form

    Private Property IsClousable As Boolean

    Public Property Title As String

    Public Property Message As String

    Public Property Picture As Image

    Public ActionToExecute As Action(Of CancellationToken)
    Private _cancelTokenSource As CancellationTokenSource = New CancellationTokenSource

    Public Sub New(cancelTokenSource As CancellationTokenSource)
        InitializeComponent()
        _cancelTokenSource = cancelTokenSource

        AddHandler Me.Shown, AddressOf fSplashScreen_Shown
        AddHandler closeButton.Click, AddressOf closeButton_Click
    End Sub
    Sub Main()
        Try
            Using fwait As WaitForTaskScreenWithCancellation = New WaitForTaskScreenWithCancellation(_cancelTokenSource)
                fwait.Title = "Executing a looooong task..."
                fwait.Message = "This form will close when the task completes its work." & vbLf & "Just wait a few seconds... :-)"
                fwait.ActionToExecute = Sub() DoSomeHardWorkWithCancellation(_cancelTokenSource.Token)
                If fwait.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    MessageBox.Show("OK")
                Else
                    MessageBox.Show("Cancel or error")
                End If
                Return
            End Using
        Catch ex As Exception

        End Try



    End Sub
    Private Sub DoSomeHardWorkWithCancellation(ByVal cancelToken As CancellationToken)
        Try
            For i As Integer = 0 To 50 - 1
                cancelToken.ThrowIfCancellationRequested()
                Console.WriteLine(i)
                Thread.Sleep(100)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub closeButton_Click(sender As Object, e As EventArgs)
        DialogResult = DialogResult.Cancel
        _cancelTokenSource.Cancel()
        releaseCancellationTokenSource()
    End Sub

    Private Sub fSplashScreen_Shown(ByVal sender As Object, ByVal e As EventArgs)
        Task.Factory.StartNew(Sub() ActionToExecute(_cancelTokenSource.Token)).ContinueWith(Sub() TaskCompleted())
    End Sub

    Private Sub releaseCancellationTokenSource()
        If _cancelTokenSource IsNot Nothing Then
            _cancelTokenSource.Dispose()
            _cancelTokenSource = Nothing
        End If
    End Sub

    Private Sub TaskCompleted()
        If InvokeRequired Then
            Me.Invoke(CType((Function()
                                 Close()
                                 Me.DialogResult = System.Windows.Forms.DialogResult.OK
                             End Function), MethodInvoker))
        End If
        releaseCancellationTokenSource()
    End Sub

    Private Sub WaitForTaskScreenWithCancellation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Título de la aplicación
            If My.Application.Info.Title <> "" Then
                ApplicationTitle.Text = My.Application.Info.Title
            Else
                'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
                ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
            '
            Version.Text = System.String.Format("Version: {0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            'Información de Copyright
            Copyright.Text = String.Format("Copyright: {0}", My.Application.Info.Copyright)

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class