Imports System.Drawing.Printing
Imports CADsisVenta.DataSetProductos
Imports CADsisVenta.DataSetProductosTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportInventoriesUpdates
    Private idInventory As Integer
    Public Sub New(ByVal idInventory As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idInventory = idInventory
    End Sub
    Private Sub frmReportInventoriesUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Load_Report(Me.idInventory)
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Load_Report(idInventory As Integer)
        Try
            Using adat As New ReturnViewInventoriesUpdateTableAdapter
                Using dt As New ReturnViewInventoriesUpdateDataTable
                    adat.Fill(dt, idInventory)
                    Dim mydt As New DataTable
                    mydt = dt
                    If dt.Rows.Count > 0 Then
                        Dim rpt As New ReportDocument
                        rpt.Load(file_rptInventoriesUpdate)
                        rpt.SetDataSource(mydt)
                        rptViewer.ReportSource = rpt
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            Dim printerSettings As New PrinterSettings
            LoadOptionsPrint("Recibo cobro deuda cliente")
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
End Class