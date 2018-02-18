Public Class MasterControl
    Inherits DataGridView
#Region "Variables"
    Friend rowCurrent As New List(Of Integer)
    Friend rowDefaultHeight = 22
    Friend rowExpandedHeight = 250
    Friend rowDefaultDivider = 0
    Friend rowExpandedDivider = 300 - 22
    Friend rowDividerMargin = 5
    Friend collapseRow As Boolean
    Friend childView As New detailControl With {.Height = rowExpandedDivider - rowDividerMargin * 2, .Visible = False}
    '
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    '
    Dim _cDataset As DataSet
    Dim _foreignKey As String
    Dim _filterFormat As String
    Enum rowHeaderIcons
        expand = 0
        collapse = 1
    End Enum
#End Region
#Region "Initialze and Display"
    Sub New(cDataset As DataSet)
        Me.Controls.Add(childView)
        InitializeComponent()
        _cDataset = cDataset
        childView._cDataset = cDataset
        applyGridTheme(Me)
        Dock = DockStyle.Fill

    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.RowHeaderIconList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowHeaderIconList
        '
        Me.RowHeaderIconList.ImageStream = CType(resources.GetObject("RowHeaderIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RowHeaderIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.RowHeaderIconList.Images.SetKeyName(0, "expand.png")
        Me.RowHeaderIconList.Images.SetKeyName(1, "collapse.png")
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '
        'MasterControl
        '
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "DataControl"
    Friend Sub setParentSource(ByVal tableName As String, ByVal foreignKey As String)
        Me.DataSource = New DataView(_cDataset.Tables(tableName))
        setGridRowHeader(Me)
        If String.IsNullOrEmpty(foreignKey) Then
            Return
        End If
        _foreignKey = foreignKey
        If _cDataset.Tables(tableName).Columns(foreignKey).GetType.ToString = GetType(Integer).ToString _
             Or _cDataset.Tables(tableName).Columns(foreignKey).GetType.ToString = GetType(Double).ToString _
            Or _cDataset.Tables(tableName).Columns(foreignKey).GetType.ToString = GetType(Decimal).ToString _
        Then
            _filterFormat = foreignKey & "={0}"
        Else
            _filterFormat = foreignKey & "='{0}'"
        End If
    End Sub
#End Region
#Region "GridEvents"
    Private Sub MasterControl_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MyBase.RowHeaderMouseClick
        Dim rect As Rectangle = New Rectangle((rowDefaultHeight - 16) / 2, (rowDefaultHeight - 16) / 2, 16, 16)
        If rect.Contains(e.Location) Then
            If rowCurrent.Contains(e.RowIndex) Then
                rowCurrent.Clear()
                Me.Rows(e.RowIndex).Height = rowDefaultHeight
                Me.Rows(e.RowIndex).DividerHeight = rowDefaultDivider
            Else
                If Not rowCurrent.Count = 0 Then
                    Dim eRow = rowCurrent(0)
                    rowCurrent.Clear()
                    Me.Rows(eRow).Height = rowDefaultHeight
                    Me.Rows(eRow).DividerHeight = rowDefaultDivider
                    Me.ClearSelection()
                    collapseRow = True
                    Me.Rows(eRow).Selected = True
                End If
                rowCurrent.Add(e.RowIndex)
                Me.Rows(e.RowIndex).Height = rowExpandedHeight
                Me.Rows(e.RowIndex).DividerHeight = rowExpandedDivider
            End If
            Me.ClearSelection()
            collapseRow = True
            Me.Rows(e.RowIndex).Selected = True
        Else
            collapseRow = False
        End If
    End Sub
    Private Sub MasterControl_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MyBase.RowPostPaint
        'set childview control
        Dim rect = New Rectangle(e.RowBounds.X + ((rowDefaultHeight - 16) / 2), e.RowBounds.Y + ((rowDefaultHeight - 16) / 2), 16, 16)
        If collapseRow Then
            If rowCurrent.Contains(e.RowIndex) Then
                sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                childView.Visible = True
            Else
                childView.Visible = False
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
            End If
            collapseRow = False
        Else
            If rowCurrent.Contains(e.RowIndex) Then
                sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                childView.Visible = True
            Else
                e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
            End If
        End If
        rowPostPaint_HeaderCount(sender, e)
    End Sub
    Private Sub MasterControl_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        If Not rowCurrent.Count = 0 Then
            collapseRow = True
            Me.ClearSelection()
            Me.Rows(rowCurrent(0)).Selected = True
        End If
    End Sub
    Private Sub MasterControl_SelectionChanged(sender As Object, e As EventArgs) Handles MyBase.SelectionChanged
        If Not Me.RowCount = 0 Then
            If rowCurrent.Contains(Me.CurrentRow.Index) Then
                For Each cGrid As DataGridView In childView.childGrid
                    CType(cGrid.DataSource, DataView).RowFilter = String.Format(_filterFormat, Me(_foreignKey, Me.CurrentRow.Index).Value)
                Next
            End If
        End If
    End Sub
#End Region
End Class
