<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductConbined
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductConbined))
        Me.PanelTools = New System.Windows.Forms.Panel()
        Me.PanelViewdata = New System.Windows.Forms.Panel()
        Me.ObjectListView1 = New BrightIdeasSoftware.ObjectListView()
        Me.idPresentacionClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentacionPrintClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Cant_PresentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioVentaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.barCodeClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.VerButtonColumn = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.BunifuGradientPanel3 = New System.Windows.Forms.Panel()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.textBoxFilterSimple = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SettingSalesButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.barCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.idProductCombinedClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelViewdata.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTools
        '
        Me.PanelTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTools.Location = New System.Drawing.Point(0, 0)
        Me.PanelTools.Name = "PanelTools"
        Me.PanelTools.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.PanelTools.Size = New System.Drawing.Size(937, 22)
        Me.PanelTools.TabIndex = 0
        '
        'PanelViewdata
        '
        Me.PanelViewdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelViewdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelViewdata.Controls.Add(Me.ObjectListView1)
        Me.PanelViewdata.Controls.Add(Me.BunifuGradientPanel3)
        Me.PanelViewdata.Controls.Add(Me.Panel3)
        Me.PanelViewdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewdata.Location = New System.Drawing.Point(0, 22)
        Me.PanelViewdata.Name = "PanelViewdata"
        Me.PanelViewdata.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.PanelViewdata.Size = New System.Drawing.Size(937, 439)
        Me.PanelViewdata.TabIndex = 1
        '
        'ObjectListView1
        '
        Me.ObjectListView1.AllColumns.Add(Me.idPresentacionClm)
        Me.ObjectListView1.AllColumns.Add(Me.idProductoClm)
        Me.ObjectListView1.AllColumns.Add(Me.Nom_ComercialClm)
        Me.ObjectListView1.AllColumns.Add(Me.PresentacionPrintClm)
        Me.ObjectListView1.AllColumns.Add(Me.Cant_PresentClm)
        Me.ObjectListView1.AllColumns.Add(Me.precioCompraClm)
        Me.ObjectListView1.AllColumns.Add(Me.precioVentaClm)
        Me.ObjectListView1.AllColumns.Add(Me.barCodeClm)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn1)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn2)
        Me.ObjectListView1.AllColumns.Add(Me.VerButtonColumn)
        Me.ObjectListView1.AllowColumnReorder = True
        Me.ObjectListView1.AllowDrop = True
        Me.ObjectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPresentacionClm, Me.Nom_ComercialClm, Me.PresentacionPrintClm, Me.Cant_PresentClm, Me.precioCompraClm, Me.precioVentaClm, Me.OlvColumn1, Me.OlvColumn2, Me.VerButtonColumn})
        Me.ObjectListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.GridLines = True
        Me.ObjectListView1.HeaderWordWrap = True
        Me.ObjectListView1.HideSelection = False
        Me.ObjectListView1.IncludeColumnHeadersInCopy = True
        Me.ObjectListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.ObjectListView1.Location = New System.Drawing.Point(10, 65)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.OwnerDraw = True
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.Size = New System.Drawing.Size(668, 362)
        Me.ObjectListView1.TabIndex = 0
        Me.ObjectListView1.UseAlternatingBackColors = True
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.UseFilterIndicator = True
        Me.ObjectListView1.UseFiltering = True
        Me.ObjectListView1.UseHotItem = True
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        '
        'idPresentacionClm
        '
        Me.idPresentacionClm.AspectName = "idPresent"
        Me.idPresentacionClm.IsVisible = False
        Me.idPresentacionClm.Text = "idPresentacion"
        Me.idPresentacionClm.Width = 0
        '
        'idProductoClm
        '
        Me.idProductoClm.AspectName = "idProducto"
        Me.idProductoClm.DisplayIndex = 1
        Me.idProductoClm.IsVisible = False
        Me.idProductoClm.Text = "idProducto"
        '
        'Nom_ComercialClm
        '
        Me.Nom_ComercialClm.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClm.Text = "Producto"
        Me.Nom_ComercialClm.Width = 250
        '
        'PresentacionPrintClm
        '
        Me.PresentacionPrintClm.AspectName = "Presentacion"
        Me.PresentacionPrintClm.Text = "Empaque"
        Me.PresentacionPrintClm.Width = 150
        '
        'Cant_PresentClm
        '
        Me.Cant_PresentClm.AspectName = "Cant_Conbined"
        Me.Cant_PresentClm.Text = "Cantidad"
        Me.Cant_PresentClm.Width = 80
        '
        'precioCompraClm
        '
        Me.precioCompraClm.AspectName = "PrecioCompra"
        Me.precioCompraClm.AspectToStringFormat = "{0:C5}"
        Me.precioCompraClm.Text = "Precio Compra"
        Me.precioCompraClm.Width = 120
        '
        'precioVentaClm
        '
        Me.precioVentaClm.AspectName = "PrecioVenta"
        Me.precioVentaClm.AspectToStringFormat = "{0:C5}"
        Me.precioVentaClm.Text = "Precio Venta"
        Me.precioVentaClm.Width = 120
        '
        'barCodeClm
        '
        Me.barCodeClm.AspectName = "barCode"
        Me.barCodeClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.barCodeClm.IsVisible = False
        Me.barCodeClm.Text = "Codigo de barra"
        Me.barCodeClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.barCodeClm.Width = 0
        '
        'VerButtonColumn
        '
        Me.VerButtonColumn.AspectName = "Button"
        Me.VerButtonColumn.Text = ""
        Me.VerButtonColumn.Width = 110
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel3.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel3.Controls.Add(Me.groupBox9)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton23)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton24)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton25)
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(10, 0)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(668, 65)
        Me.BunifuGradientPanel3.TabIndex = 1
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.textBoxFilterSimple)
        Me.groupBox9.Dock = System.Windows.Forms.DockStyle.Right
        Me.groupBox9.Location = New System.Drawing.Point(607, 2)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(59, 59)
        Me.groupBox9.TabIndex = 18
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Filter"
        '
        'textBoxFilterSimple
        '
        Me.textBoxFilterSimple.Location = New System.Drawing.Point(7, 13)
        Me.textBoxFilterSimple.Name = "textBoxFilterSimple"
        Me.textBoxFilterSimple.Size = New System.Drawing.Size(167, 20)
        Me.textBoxFilterSimple.TabIndex = 0
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Código de barra"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ErrorProvider1.SetIconAlignment(Me.BunifuFlatButton1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 50.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 45.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(126, 0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(118, 59)
        Me.BunifuFlatButton1.TabIndex = 6
        Me.BunifuFlatButton1.Text = "Código de barra"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton1, "Configurar precio venta")
        '
        'SettingSalesButton
        '
        Me.SettingSalesButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingSalesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SettingSalesButton.BorderRadius = 0
        Me.SettingSalesButton.ButtonText = "Precio venta"
        Me.SettingSalesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingSalesButton.DisabledColor = System.Drawing.Color.Gray
        Me.SettingSalesButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ErrorProvider1.SetIconAlignment(Me.SettingSalesButton, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.SettingSalesButton.Iconcolor = System.Drawing.Color.Transparent
        Me.SettingSalesButton.Iconimage = CType(resources.GetObject("SettingSalesButton.Iconimage"), System.Drawing.Image)
        Me.SettingSalesButton.Iconimage_right = Nothing
        Me.SettingSalesButton.Iconimage_right_Selected = Nothing
        Me.SettingSalesButton.Iconimage_Selected = Nothing
        Me.SettingSalesButton.IconMarginLeft = 0
        Me.SettingSalesButton.IconMarginRight = 0
        Me.SettingSalesButton.IconRightVisible = True
        Me.SettingSalesButton.IconRightZoom = 50.0R
        Me.SettingSalesButton.IconVisible = True
        Me.SettingSalesButton.IconZoom = 50.0R
        Me.SettingSalesButton.IsTab = False
        Me.SettingSalesButton.Location = New System.Drawing.Point(15, 0)
        Me.SettingSalesButton.Name = "SettingSalesButton"
        Me.SettingSalesButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SettingSalesButton.OnHoverTextColor = System.Drawing.Color.White
        Me.SettingSalesButton.selected = False
        Me.SettingSalesButton.Size = New System.Drawing.Size(111, 59)
        Me.SettingSalesButton.TabIndex = 5
        Me.SettingSalesButton.Text = "Precio venta"
        Me.SettingSalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingSalesButton.Textcolor = System.Drawing.Color.White
        Me.SettingSalesButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.SettingSalesButton, "Configurar precio venta")
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Eliminar"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(187, 2)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(102, 59)
        Me.BunifuThinButton23.TabIndex = 3
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Editar"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.Location = New System.Drawing.Point(99, 2)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(88, 59)
        Me.BunifuThinButton24.TabIndex = 2
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Nuevo"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(10, 2)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Padding = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Size = New System.Drawing.Size(89, 59)
        Me.BunifuThinButton25.TabIndex = 1
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.barCodeTextBox)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(678, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 427)
        Me.Panel3.TabIndex = 2
        '
        'barCodeTextBox
        '
        Me.barCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barCodeTextBox.Location = New System.Drawing.Point(8, 141)
        Me.barCodeTextBox.Name = "barCodeTextBox"
        Me.barCodeTextBox.ReadOnly = True
        Me.barCodeTextBox.Size = New System.Drawing.Size(229, 23)
        Me.barCodeTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(8, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'idProductCombinedClm
        '
        Me.idProductCombinedClm.AspectName = "idProductCombined"
        Me.idProductCombinedClm.IsVisible = False
        Me.idProductCombinedClm.Text = "idProductCombined"
        Me.idProductCombinedClm.Width = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "Utilidad"
        Me.OlvColumn1.Text = "Utilidad"
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Rentabilidad"
        Me.OlvColumn2.Text = "Rentabilidad"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.SettingSalesButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(289, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(294, 59)
        Me.Panel1.TabIndex = 19
        '
        'frmProductConbined
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 461)
        Me.Controls.Add(Me.PanelViewdata)
        Me.Controls.Add(Me.PanelTools)
        Me.Name = "frmProductConbined"
        Me.Text = "Administración de productos combinados"
        Me.PanelViewdata.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTools As Windows.Forms.Panel
    Friend WithEvents PanelViewdata As Windows.Forms.Panel
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.ObjectListView
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idPresentacionClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PresentacionPrintClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Cant_PresentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioVentaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BunifuGradientPanel3 As Windows.Forms.Panel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents idProductCombinedClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents SettingSalesButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents barCodeTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barCodeClm As BrightIdeasSoftware.OLVColumn
    Private WithEvents groupBox9 As GroupBox
    Private WithEvents textBoxFilterSimple As TextBox
    Friend WithEvents VerButtonColumn As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel1 As Panel
End Class
