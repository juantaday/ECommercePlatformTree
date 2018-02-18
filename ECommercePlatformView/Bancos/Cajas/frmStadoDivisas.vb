Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmStadoDivisas
    Private Sub frmStadoDivisas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Dim dtTipo As New DataTable
        Dim dtLocalidad As New DataTable

        Dim subRpt As New ReportDocument
        Try
            Using adt As New prcBalanceLocalidadTableAdapter
                dtLocalidad = adt.GetData()
            End Using
            Using adt2 As New prcBalanceTipoTableAdapter
                dtTipo = adt2.GetData()
            End Using

            Dim rptInforme As New ReportDocument
            rptInforme.Load(file_rptSaldoDivisas)
            rptInforme.Subreports(1).SetDataSource(dtTipo)
            rptInforme.Subreports(0).SetDataSource(dtLocalidad)

            Me.rptViewer.ReportSource = rptInforme
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & vbCrLf & " LUGAR:" & ex.StackTrace & vbCrLf & " Direccion reporte:" & file_rptViewSalesByDate, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class