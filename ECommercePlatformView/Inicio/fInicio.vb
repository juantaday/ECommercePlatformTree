Imports System.Threading
Module fInicio
    Private Property LoginForm As UserControl
    Private _cancelTokenSource As CancellationTokenSource = New CancellationTokenSource()

    Public Function SHA1(ByVal strToHash As String) As String
        Using sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider()
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
            bytesToHash = sha1Obj.ComputeHash(bytesToHash)
            Dim strResult As String = ""
            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next
            Return strResult
        End Using
    End Function



    Public Sub Main()
        Try


            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)


            Using fwait As WaitForTaskScreenWithCancellation = New WaitForTaskScreenWithCancellation(_cancelTokenSource)
                fwait.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.spliterEcommerce
                fwait.Title = "Executing a looooong task..."
                fwait.Message = "This form will close when the task completes its work." & vbLf & "Just wait a few seconds... :-)"
                fwait.ActionToExecute = Sub() DoSomeHardWorkWithCancellation(_cancelTokenSource.Token)
                If fwait.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Else
                    Return
                End If
            End Using

            If My.Forms.LoginForm.ShowDialog = DialogResult.OK Then
                If (IsNothing(Dominio)) And (Not String.IsNullOrEmpty(Dominio._HotName)) Then
                    GetInformationServices.GeneralInformation.Carga_DominioMaquina()
                    If Not (IsNothing(Dominio)) And (Not String.IsNullOrEmpty(Dominio._HotName)) Then
                        sql = "No se pudo cargar el host name del equipo." & vbCrLf
                        sql = sql & "En el Main linea 19"
                        MsgBox(sql, MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    GoTo GenerateAplication
                End If
            End If
            Exit Sub

GenerateAplication:
            Application.DoEvents()
            Using aplication As New MDIPareInicio
                aplication.ShowDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Application.Exit()
        End Try
    End Sub 'Main

    Private Sub DoSomeHardWorkWithCancellation(ByVal cancelToken As CancellationToken)
        Try
            cancelToken.ThrowIfCancellationRequested()
            GetInformationServices.GeneralInformation.Carga_DominioMaquina()
            GetInformationServices.GeneralInformation.Inicia_Terminal(False)
            GetInformationServices.AccessPanel.GetListNenuAccess(False)
            GetInformationServices.EcommerceInfo.GetEccomerceInfo(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Module
