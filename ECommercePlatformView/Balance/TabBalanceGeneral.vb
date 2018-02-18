Imports CADsisVenta.DataSetGraficoTableAdapters

Public Class TabBalanceGeneral
    Sub New()

        InitializeComponent()

    End Sub

    Private Sub ChartControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabBalanceGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adat As New SalesYearTableAdapter
        Dim dt As New DataTable
        dt = adat.GetData()
        ChartControl2.DataSource = dt
    End Sub

End Class
