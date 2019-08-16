Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports System.Drawing

Public Class PrintTicketUsbAsync
    Implements IDisposable

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private Function LoadSalesData() As DataTable
        Dim dataSet As DataSet = New DataSet()
        dataSet.ReadXml("..\..\data.xml")
        Return dataSet.Tables(0)
    End Function

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = "<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>"
        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As Metafile = New Metafile(m_streams(m_currentPageIndex))
        Dim adjustedRect As Rectangle = New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX), ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY), ev.PageBounds.Width, ev.PageBounds.Height)
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)
        ev.Graphics.DrawImage(pageImage, adjustedRect)
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print()
        If m_streams Is Nothing OrElse m_streams.Count = 0 Then Throw New Exception("Error: no stream to print.")
        Dim printDoc As PrintDocument = New PrintDocument()

        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, New PrintPageEventHandler(AddressOf PrintPage)
            m_currentPageIndex = 0
            printDoc.Print()
        End If
    End Sub

    Private Sub Run()
        Dim report As LocalReport = New LocalReport()
        report.ReportPath = "..\..\Report.rdlc"
        report.DataSources.Add(New ReportDataSource("Sales", LoadSalesData()))
        Export(report)
        Print()
    End Sub

    Public Sub Dispose()
        If m_streams IsNot Nothing Then

            For Each stream As Stream In m_streams
                stream.Close()
            Next

            m_streams = Nothing
        End If
    End Sub

    Public Shared Sub Main(ByVal args As String())
        Using demo As Demo = New Demo()
            demo.Run()
        End Using
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub
End Class
