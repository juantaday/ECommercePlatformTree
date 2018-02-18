Imports System.Drawing.Printing
Imports CADsisVenta.DataSetReport
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportCobroDeuda
    Private num_cobro As String
    Sub New(num_cobro As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.num_cobro = num_cobro
    End Sub
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
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

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmReportCobroDeuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Load_Report(Me.num_cobro)
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Load_Report(num_cobro As String)
        Try
            Using adat As New prcGetDataReportDeudaClientTableAdapter
                Using dt As New prcGetDataReportDeudaClientDataTable
                    adat.Fill(dt, num_cobro)
                    Dim mydt As New DataTable
                    mydt = dt
                    If dt.Rows.Count > 0 Then
                        Dim rpt As New ReportDocument
                        rpt.Load(file_rptCobroCliente)
                        rpt.SetDataSource(mydt)
                        rptViewer.ReportSource = rpt
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
