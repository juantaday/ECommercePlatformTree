Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Partial Public Class WaitForTaskScreenWithCancellation
    Inherits System.Windows.Forms.Form

    Private Property IsClousable As Boolean

    Public Property Title As String

    Public Property Message As String

    Public Property Picture As Image


#Region "Trial"
    <DllImport("Trial.dll", EntryPoint:="ReadSettingsStr", CharSet:=CharSet.Ansi)>
    Private Shared Function InitTrial(ByVal akeyCode As String, ByVal aHWnd As IntPtr) As UInteger
    End Function

    <DllImport("Trial.dll", EntryPoint:="DisplayRegistrationStr", CharSet:=CharSet.Ansi)>
    Private Shared Function DisplayRegistration(ByVal akeyCode As String, ByVal aHWnd As IntPtr) As UInteger
    End Function

    <DllImport("Trial.dll", EntryPoint:="DisplayRegistrationStr", CharSet:=CharSet.Ansi)>
    Private Shared Function GetPropertyValue(ByVal aPropName As String, ByVal aResult As StringBuilder,
      ByRef aResultLen As UInt32) As UInteger

    End Function

    Private Shared klibraryKey As String = "CBC1BE2B5A6F9A925C71A548C3918E671D5386C906D5EC0773731E25FC8F1892F110940BC30D"
    Private registered As Boolean
    Private Function OnInit() As Boolean
        Try
            Dim Process As Process = Process.GetCurrentProcess()
            InitTrial(klibraryKey, Process.MainWindowHandle)
            Return True
        Catch ex As DllNotFoundException
            MessageBox.Show(ex.ToString())
            Process.GetCurrentProcess().Kill()
            Return False
        Catch ex1 As Exception
            MessageBox.Show(ex1.ToString())
            Return False
        End Try
    End Function
#End Region


    Public ActionToExecute As Action(Of CancellationToken)
    Private _cancelTokenSource As CancellationTokenSource = New CancellationTokenSource

    Public Sub New(cancelTokenSource As CancellationTokenSource)
        InitializeComponent()
        _cancelTokenSource = cancelTokenSource

        AddHandler Me.Shown, AddressOf fSplashScreen_Shown
        AddHandler closeButton.Click, AddressOf closeButton_Click
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
                                 Me.Close()
                                 Me.DialogResult = System.Windows.Forms.DialogResult.OK
                                 Return vbOK
                             End Function), MethodInvoker))
        End If
        releaseCancellationTokenSource()
    End Sub

    Private Sub WaitForTaskScreenWithCancellation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'If Not Me.OnInit() Then
            '    Me.Close()
            'End If
            Task.Factory.StartNew(Sub() ActionToExecute(_cancelTokenSource.Token)).ContinueWith(Sub() TaskCompleted())

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


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