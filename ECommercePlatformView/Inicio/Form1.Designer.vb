<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FastObjectListView1 = New BrightIdeasSoftware.FastObjectListView()
        Me.olvColumn18 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvColumn31 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.olvColumn26 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ListView1 = New BrightIdeasSoftware.FastObjectListView()
        Me.IdPresentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CodigoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CantidadClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.UnitPriceClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DiscountClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TotalParcialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IncludeIvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IvaPercentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DateExpireClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PUnitarioClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DescuentoClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTotalClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IvaIncluyeClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IvaPorcentClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.FastObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FastObjectListView1
        '
        Me.FastObjectListView1.AllColumns.Add(Me.olvColumn18)
        Me.FastObjectListView1.AllColumns.Add(Me.olvColumn31)
        Me.FastObjectListView1.AllColumns.Add(Me.olvColumn26)
        Me.FastObjectListView1.CheckBoxes = True
        Me.FastObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.olvColumn18, Me.olvColumn31, Me.olvColumn26})
        Me.FastObjectListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastObjectListView1.FullRowSelect = True
        Me.FastObjectListView1.GridLines = True
        Me.FastObjectListView1.Location = New System.Drawing.Point(12, 12)
        Me.FastObjectListView1.Name = "FastObjectListView1"
        Me.FastObjectListView1.ShowGroups = False
        Me.FastObjectListView1.ShowImagesOnSubItems = True
        Me.FastObjectListView1.Size = New System.Drawing.Size(318, 112)
        Me.FastObjectListView1.TabIndex = 0
        Me.FastObjectListView1.UseCompatibleStateImageBehavior = False
        Me.FastObjectListView1.View = System.Windows.Forms.View.Details
        Me.FastObjectListView1.VirtualMode = True
        '
        'olvColumn31
        '
        Me.olvColumn31.Width = 137
        '
        'olvColumn26
        '
        Me.olvColumn26.AspectName = "CulinaryRating"
        Me.olvColumn26.Text = "Cooking skill"
        '
        'ListView1
        '
        Me.ListView1.AllColumns.Add(Me.IdPresentClm)
        Me.ListView1.AllColumns.Add(Me.idProductoClm)
        Me.ListView1.AllColumns.Add(Me.CodigoClm)
        Me.ListView1.AllColumns.Add(Me.ProductoClm)
        Me.ListView1.AllColumns.Add(Me.CantidadClm)
        Me.ListView1.AllColumns.Add(Me.UnitPriceClm)
        Me.ListView1.AllColumns.Add(Me.DiscountClm)
        Me.ListView1.AllColumns.Add(Me.IvaClm)
        Me.ListView1.AllColumns.Add(Me.TotalParcialClm)
        Me.ListView1.AllColumns.Add(Me.IncludeIvaClm)
        Me.ListView1.AllColumns.Add(Me.IvaPercentClm)
        Me.ListView1.AllColumns.Add(Me.DateExpireClm)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPresentClm, Me.idProductoClm, Me.CodigoClm, Me.ProductoClm, Me.CantidadClm, Me.UnitPriceClm, Me.DiscountClm, Me.IvaClm, Me.TotalParcialClm, Me.IncludeIvaClm, Me.IvaPercentClm, Me.DateExpireClm})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(38, 191)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowImagesOnSubItems = True
        Me.ListView1.Size = New System.Drawing.Size(517, 213)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.VirtualMode = True
        '
        'IdPresentClm
        '
        Me.IdPresentClm.Text = "IdPresent"
        Me.IdPresentClm.Width = 0
        '
        'idProductoClm
        '
        Me.idProductoClm.Text = "idProducto"
        Me.idProductoClm.Width = 0
        '
        'CodigoClm
        '
        Me.CodigoClm.Text = "Código"
        Me.CodigoClm.Width = 80
        '
        'ProductoClm
        '
        Me.ProductoClm.AspectName = ""
        Me.ProductoClm.Text = "Producto"
        Me.ProductoClm.Width = 220
        '
        'CantidadClm
        '
        Me.CantidadClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CantidadClm.Text = "Cantidad"
        Me.CantidadClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CantidadClm.Width = 100
        '
        'UnitPriceClm
        '
        Me.UnitPriceClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Text = "Precio Unitario"
        Me.UnitPriceClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Width = 100
        '
        'DiscountClm
        '
        Me.DiscountClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiscountClm.Text = "Descuento"
        Me.DiscountClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiscountClm.Width = 100
        '
        'IvaClm
        '
        Me.IvaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaClm.Text = "Iva"
        Me.IvaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaClm.Width = 100
        '
        'TotalParcialClm
        '
        Me.TotalParcialClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalParcialClm.Text = "Sub total"
        Me.TotalParcialClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalParcialClm.Width = 150
        '
        'IncludeIvaClm
        '
        Me.IncludeIvaClm.Text = "Incluido iva"
        Me.IncludeIvaClm.Width = 80
        '
        'IvaPercentClm
        '
        Me.IvaPercentClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaPercentClm.Text = "Iva porcentaje"
        Me.IvaPercentClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaPercentClm.Width = 0
        '
        'DateExpireClm
        '
        Me.DateExpireClm.AspectName = ""
        Me.DateExpireClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateExpireClm.Text = "Fecha expira"
        Me.DateExpireClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateExpireClm.Width = 100
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.PUnitarioClm, Me.DescuentoClm, Me.ColumnHeader4, Me.SubTotalClm, Me.IvaIncluyeClm, Me.ColumnHeader5, Me.ColumnHeader6, Me.IvaPorcentClm})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(351, 12)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(300, 165)
        Me.ListView2.TabIndex = 13
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Producto"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 80
        '
        'PUnitarioClm
        '
        Me.PUnitarioClm.Text = "P/Unitario"
        Me.PUnitarioClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PUnitarioClm.Width = 120
        '
        'DescuentoClm
        '
        Me.DescuentoClm.Text = "Descuento $"
        Me.DescuentoClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DescuentoClm.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Iva $"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'SubTotalClm
        '
        Me.SubTotalClm.Text = "Sub Total"
        Me.SubTotalClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubTotalClm.Width = 150
        '
        'IvaIncluyeClm
        '
        Me.IvaIncluyeClm.Text = "Incluye Iva"
        Me.IvaIncluyeClm.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "IdPresent"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "idPresentacion"
        '
        'IvaPorcentClm
        '
        Me.IvaPorcentClm.Text = "ivaPorcent"
        Me.IvaPorcentClm.Width = 0
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(583, 177)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(101, 62)
        Me.ChartControl1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 416)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.FastObjectListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FastObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FastObjectListView1 As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents olvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvColumn31 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvColumn26 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ListView1 As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents IdPresentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CodigoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CantidadClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents UnitPriceClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DiscountClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents TotalParcialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IncludeIvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IvaPercentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DateExpireClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents PUnitarioClm As ColumnHeader
    Friend WithEvents DescuentoClm As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents SubTotalClm As ColumnHeader
    Friend WithEvents IvaIncluyeClm As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents IvaPorcentClm As ColumnHeader
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
End Class
