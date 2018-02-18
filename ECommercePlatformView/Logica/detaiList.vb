Public Class DetailList
#Region "Variables"
    Inherits System.Windows.Forms.Panel

    Friend newGrid As New DataGridView
    Dim tiTle As New System.Windows.Forms.Label
#End Region

#Region "Populate Childview"
    Friend Sub Add()
        Dim tPage As New System.Windows.Forms.Panel With {.Dock = DockStyle.Fill}
        tiTle = New System.Windows.Forms.Label _
                  With {.Text = String.Empty, .Dock = DockStyle.Top, .Height = 17}
        Me.Controls.Add(tPage)

        newGrid = New DataGridView _
           With {.Dock = DockStyle.Fill, _
           .SelectionMode = DataGridViewSelectionMode.FullRowSelect}

        tPage.Controls.Add(newGrid)
        tPage.Controls.Add(tiTle)
        applyGridTheme(newGrid)
        setGridRowHeader(newGrid)
        If newGrid.Columns.Count > 0 Then
            'newGrid.Columns(0).Visible = False
        End If
        AddHandler newGrid.RowPostPaint, AddressOf rowPostPaint_HeaderCount
    End Sub
    Friend Sub setDataSource(ByVal dt As DataTable, ByVal pageCaption As String)
        If dt.Rows.Count > 0 Then
            tiTle.ForeColor = Color.Black
            Me.tiTle.Text = pageCaption
            Me.newGrid.DataSource = dt
            Me.newGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            Me.tiTle.Text = "No hay datos"
            tiTle.ForeColor = Color.Red
            Me.newGrid.DataSource = Nothing
        End If
    End Sub
#End Region
End Class
