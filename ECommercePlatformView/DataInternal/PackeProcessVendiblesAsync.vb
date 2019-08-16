Imports System.Threading

Public Class PackeProcessVendiblesAsync
    Private _claveAcceso As String
    Private _cancelTokenSource As CancellationTokenSource
    Public ActionToExecute As Action(Of CancellationToken)
    Sub New(cancelTokenSource As CancellationTokenSource)
        _cancelTokenSource = cancelTokenSource
    End Sub
    Public Async Sub Execute()
        Await GetInformationServices.GeneralInformation.Inicia_Terminal(True)
        Await GetRates(TerminalActivo.idRates)
        Await GetListVendibles(DeFaultRates.RatesStruccture, DeFaultRates.IDRates)
    End Sub

    Public Sub Star()
        Try

            Task.Factory.StartNew(Sub() _
                ActionToExecute(_cancelTokenSource.Token)) _
                .ContinueWith(Sub() TaskCompleted())

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub TaskCompleted()
        releaseCancellationTokenSource()
        System.Diagnostics.Debug.WriteLine(Date.Now.ToLongTimeString() & " Termine llenamdo tabla")
    End Sub
    Private Sub releaseCancellationTokenSource()
        If _cancelTokenSource IsNot Nothing Then
            _cancelTokenSource.Dispose()
            _cancelTokenSource = Nothing
        End If
    End Sub
End Class
