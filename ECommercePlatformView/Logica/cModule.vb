Module cModule
#Region "CustomGrid"
    Dim dateCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight}
    Dim amountCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight, .Format = "N2"}
    Dim gridCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With { _
       .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
       .BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer)),
       .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
       .ForeColor = System.Drawing.SystemColors.ControlLightLight,
       .SelectionBackColor = System.Drawing.SystemColors.Highlight,
       .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
       .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
    Dim gridCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With { _
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.SystemColors.ControlLightLight,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.ControlText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[False]}
    Dim gridCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With { _
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.Color.Lavender,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.WindowText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
    Sub applyGridTheme(ByRef grid As DataGridView)
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.BackgroundColor = System.Drawing.SystemColors.Window
        grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.ColumnHeadersDefaultCellStyle = gridCellStyle
        grid.ColumnHeadersHeight = 32
        grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grid.DefaultCellStyle = gridCellStyle2
        grid.EnableHeadersVisualStyles = False
        grid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        grid.ReadOnly = True
        grid.RowHeadersVisible = True
        grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.RowHeadersDefaultCellStyle = gridCellStyle3
        grid.Font = gridCellStyle.Font
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.BorderStyle = BorderStyle.FixedSingle
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Sub applyGridThemeEdit(ByRef grid As DataGridView)
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.BackgroundColor = System.Drawing.SystemColors.Window
        grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.ColumnHeadersDefaultCellStyle = gridCellStyle
        grid.ColumnHeadersHeight = 32
        grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grid.DefaultCellStyle = gridCellStyle2
        grid.EnableHeadersVisualStyles = False
        grid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        grid.ReadOnly = False
        grid.RowHeadersVisible = True
        grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        grid.RowHeadersDefaultCellStyle = gridCellStyle3
        grid.Font = gridCellStyle.Font
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Sub setGridRowHeader(ByRef dgv As DataGridView, Optional ByVal hSize As Boolean = False)
        dgv.TopLeftHeaderCell.Value = "NO "
        dgv.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders)
        For Each cCol As DataGridViewColumn In dgv.Columns
            If cCol.ValueType.ToString() = GetType(DateTime).ToString Then
                cCol.DefaultCellStyle = dateCellStyle
            ElseIf cCol.ValueType.ToString() = GetType(Decimal).ToString Or cCol.ValueType.ToString() = GetType(Double).ToString Then
                cCol.DefaultCellStyle = amountCellStyle
            End If
        Next
        If hSize Then
            dgv.RowHeadersWidth = dgv.RowHeadersWidth + 16
        End If
        dgv.AutoResizeColumns()
    End Sub
    Sub rowPostPaint_HeaderCount(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        'set rowheader count
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, _
            grid.RowHeadersWidth, e.RowBounds.Height - sender.rows(e.RowIndex).DividerHeight)
        e.Graphics.DrawString(rowIdx, grid.Font, SystemBrushes.ControlText, _
            headerBounds, centerFormat)
    End Sub
#End Region
End Module
