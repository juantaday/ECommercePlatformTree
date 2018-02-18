Imports System.Drawing.Printing
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportFactura
    Private viewState As viewLoadReport
    Sub New(viewState As viewLoadReport)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.viewState = viewState
    End Sub

    Private Sub frmReportFactur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Dim dt As New DataTable
        Try
            Using adt As New getDataReportFacturTableAdapter
                Select Case viewState
                    Case viewLoadReport.All
                        dt = adt.GetDataByAll(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                    Case viewLoadReport.Select_
                    Case viewLoadReport.Latest
                        dt = adt.GetDataByLast(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                End Select
                If dt.Rows.Count > 0 Then
                    Dim rpt As New ReportDocument
                    rpt.Load(file_rptFacturaBacha)
                    rpt.SetDataSource(dt)
                    Me.rptViewer.ReportSource = rpt
                Else
                    MsgBox("No hay informacion", MsgBoxStyle.Information, "Aviso")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            dt = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles printDefaultButton.Click
        Try
            Dim printerSettings As New PrinterSettings
            LoadOptionsPrint("Factura")
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
