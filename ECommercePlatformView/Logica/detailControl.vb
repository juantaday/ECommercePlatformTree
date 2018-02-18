Public Class detailControl
    Inherits TabControl
#Region "Variables"
    Friend childGrid As New List(Of DataGridView)
    Friend _cDataset As DataSet
#End Region
#Region "Populate Childview"
    Friend Sub Add(ByVal tableName As String, ByVal pageCaption As String)
        Dim tPage As New TabPage With {.Text = pageCaption}
        Me.TabPages.Add(tPage)
        Dim newGrid As New DataGridView With {.Dock = DockStyle.Fill, .DataSource = New DataView(_cDataset.Tables(tableName)), .SelectionMode = DataGridViewSelectionMode.FullRowSelect}
        tPage.Controls.Add(newGrid)
        applyGridTheme(newGrid)
        setGridRowHeader(newGrid)
        If newGrid.Columns.Count > 0 Then
            newGrid.Columns(0).Visible = False
        End If
        AddHandler newGrid.RowPostPaint, AddressOf rowPostPaint_HeaderCount
        childGrid.Add(newGrid)
    End Sub
#End Region
End Class
