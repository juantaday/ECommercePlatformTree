
Imports System.Drawing.Printing
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportNotaVenta
    Private viewStatReport As viewLoadReport
    Sub New(viewStatReport As viewLoadReport)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.viewStatReport = viewStatReport
    End Sub
    Private Sub frmReportNotaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Try
            Me.Cursor = Cursors.WaitCursor
            Using adt As New getDataReportFacturTableAdapter
                Select Case Me.viewStatReport
                    Case viewLoadReport.All
                        dt = adt.GetDataByAll(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                    Case viewLoadReport.Latest
                        dt = adt.GetDataByLast(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                    Case viewLoadReport.Select_
                End Select
            End Using
            If dt.Rows.Count > 0 Then
                Dim rpt As New ReportDocument()
                rpt.Load(file_rptNotaVentaBacha)
                rpt.SetDataSource(dt)
                Me.rptViewer.ReportSource = rpt
            Else
                MsgBox("No existe información", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            dt = Nothing
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub printDefaultButton_Click(sender As Object, e As EventArgs) Handles printDefaultButton.Click
        Try
            Dim printerSettings As New PrinterSettings
            LoadOptionsPrint("Nota de venta")
            printerSettings.PrinterName = myOptnsPrint.NamePrint
            If printerSettings.IsValid Then
                Dim pageSettings As New PageSettings(printerSettings)
                DirectCast(rptViewer.ReportSource, ReportDocument) _
               .PrintToPrinter(printerSettings, pageSettings, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub
End Class