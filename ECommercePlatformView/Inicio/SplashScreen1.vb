Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Partial Public Class SplashScreen1

    Private Sub fSplashScreen_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Me.Text = ""

    End Sub


    Private Sub releaseCancellationTokenSource()

    End Sub



    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'Título de la aplicación
            If My.Application.Info.Title <> "" Then
                ApplicationTitle.Text = My.Application.Info.Title
            Else
                'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
                ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
            '
            Version.Text = System.String.Format("{0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            'Información de Copyright
            Copyright.Text = String.Format("Copyright: {0}", My.Application.Info.Copyright)

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SplashScreen1_Deactivate(sender As Object, e As EventArgs)
        'Me.Timer1.Dispose()
    End Sub

End Class
