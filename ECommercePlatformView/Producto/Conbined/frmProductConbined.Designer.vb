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
        Me.PanelTools = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PanelViewdata = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ObjectListView1 = New BrightIdeasSoftware.ObjectListView()
        Me.idPresentacionClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentacionPrintClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Cant_PresentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioVentaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.barCodeClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.barCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.textBoxFilterSimple = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SettingSalesButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuThinButton21 = New System.Windows.Forms.Button()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataListView1 = New BrightIdeasSoftware.DataListView()
        Me.idPresentacionclmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentacionPrintClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Cant_PresentClmD = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioCompraClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioVentaClmD = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalVentaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductCombinedClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PanelDetail = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.totalVentaLabel = New System.Windows.Forms.Label()
        Me.totalCompraLabel = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.CountButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.NewCombinedButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nom_ComercialLabel = New System.Windows.Forms.Label()
        Me.retunrButton = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelViewdata.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTools
        '
        Me.PanelTools.BackgroundImage = CType(resources.GetObject("PanelTools.BackgroundImage"), System.Drawing.Image)
        Me.PanelTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTools.GradientBottomLeft = System.Drawing.Color.Navy
        Me.PanelTools.GradientBottomRight = System.Drawing.Color.White
        Me.PanelTools.GradientTopLeft = System.Drawing.Color.White
        Me.PanelTools.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelTools.Location = New System.Drawing.Point(0, 0)
        Me.PanelTools.Name = "PanelTools"
        Me.PanelTools.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.PanelTools.Quality = 20
        Me.PanelTools.Size = New System.Drawing.Size(1087, 22)
        Me.PanelTools.TabIndex = 0
        '
        'PanelViewdata
        '
        Me.PanelViewdata.BackgroundImage = CType(resources.GetObject("PanelViewdata.BackgroundImage"), System.Drawing.Image)
        Me.PanelViewdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelViewdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelViewdata.Controls.Add(Me.ObjectListView1)
        Me.PanelViewdata.Controls.Add(Me.Panel3)
        Me.PanelViewdata.Controls.Add(Me.BunifuGradientPanel3)
        Me.PanelViewdata.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelViewdata.GradientBottomLeft = System.Drawing.Color.Navy
        Me.PanelViewdata.GradientBottomRight = System.Drawing.Color.White
        Me.PanelViewdata.GradientTopLeft = System.Drawing.Color.White
        Me.PanelViewdata.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelViewdata.Location = New System.Drawing.Point(0, 22)
        Me.PanelViewdata.Name = "PanelViewdata"
        Me.PanelViewdata.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.PanelViewdata.Quality = 20
        Me.PanelViewdata.Size = New System.Drawing.Size(861, 439)
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
        Me.ObjectListView1.AllowColumnReorder = True
        Me.ObjectListView1.AllowDrop = True
        Me.ObjectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPresentacionClm, Me.Nom_ComercialClm, Me.PresentacionPrintClm, Me.Cant_PresentClm, Me.precioCompraClm, Me.precioVentaClm})
        Me.ObjectListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.GridLines = True
        Me.ObjectListView1.HeaderWordWrap = True
        Me.ObjectListView1.HideSelection = False
        Me.ObjectListView1.IncludeColumnHeadersInCopy = True
        Me.ObjectListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.ObjectListView1.Location = New System.Drawing.Point(10, 47)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.OwnerDraw = True
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.Size = New System.Drawing.Size(839, 195)
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
        Me.idPresentacionClm.AspectName = "idPresentacion"
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
        Me.Cant_PresentClm.AspectName = "Cant_Present"
        Me.Cant_PresentClm.Text = "Cantidad"
        Me.Cant_PresentClm.Width = 80
        '
        'precioCompraClm
        '
        Me.precioCompraClm.AspectName = "precioCompra"
        Me.precioCompraClm.AspectToStringFormat = "{0:C5}"
        Me.precioCompraClm.Text = "Precio Compra"
        Me.precioCompraClm.Width = 120
        '
        'precioVentaClm
        '
        Me.precioVentaClm.AspectName = "precioVenta"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.barCodeTextBox)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 242)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(839, 185)
        Me.Panel3.TabIndex = 2
        '
        'barCodeTextBox
        '
        Me.barCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barCodeTextBox.Location = New System.Drawing.Point(111, 130)
        Me.barCodeTextBox.Name = "barCodeTextBox"
        Me.barCodeTextBox.ReadOnly = True
        Me.barCodeTextBox.Size = New System.Drawing.Size(229, 23)
        Me.barCodeTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(111, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel3.Controls.Add(Me.groupBox9)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuFlatButton1)
        Me.BunifuGradientPanel3.Controls.Add(Me.SettingSalesButton)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton23)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton24)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton25)
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(10, 0)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.BunifuGradientPanel3.Quality = 20
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(839, 47)
        Me.BunifuGradientPanel3.TabIndex = 1
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.textBoxFilterSimple)
        Me.groupBox9.Dock = System.Windows.Forms.DockStyle.Right
        Me.groupBox9.Location = New System.Drawing.Point(587, 2)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(182, 41)
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
        Me.BunifuFlatButton1.ButtonText = "codigo de barra"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(414, 2)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(112, 41)
        Me.BunifuFlatButton1.TabIndex = 6
        Me.BunifuFlatButton1.Text = "codigo de barra"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.BunifuFlatButton1, "Configurar precio venta")
        '
        'SettingSalesButton
        '
        Me.SettingSalesButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingSalesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingSalesButton.BorderRadius = 0
        Me.SettingSalesButton.ButtonText = "Precio venta"
        Me.SettingSalesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingSalesButton.DisabledColor = System.Drawing.Color.Gray
        Me.SettingSalesButton.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.SettingSalesButton.Location = New System.Drawing.Point(289, 2)
        Me.SettingSalesButton.Name = "SettingSalesButton"
        Me.SettingSalesButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.SettingSalesButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SettingSalesButton.OnHoverTextColor = System.Drawing.Color.White
        Me.SettingSalesButton.selected = False
        Me.SettingSalesButton.Size = New System.Drawing.Size(125, 41)
        Me.SettingSalesButton.TabIndex = 5
        Me.SettingSalesButton.Text = "Precio venta"
        Me.SettingSalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingSalesButton.Textcolor = System.Drawing.Color.White
        Me.SettingSalesButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.SettingSalesButton, "Configurar precio venta")
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Image = Global.ECommercePlatformView.My.Resources.Resources.Arrow_Forward_48
        Me.BunifuThinButton21.Location = New System.Drawing.Point(769, 2)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(68, 41)
        Me.BunifuThinButton21.TabIndex = 4
        Me.BunifuThinButton21.UseVisualStyleBackColor = False
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
        Me.BunifuThinButton23.Size = New System.Drawing.Size(102, 41)
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
        Me.BunifuThinButton24.Size = New System.Drawing.Size(88, 41)
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
        Me.BunifuThinButton25.Size = New System.Drawing.Size(89, 41)
        Me.BunifuThinButton25.TabIndex = 1
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataListView1
        '
        Me.DataListView1.AllColumns.Add(Me.idPresentacionclmd)
        Me.DataListView1.AllColumns.Add(Me.Nom_ComercialClmd)
        Me.DataListView1.AllColumns.Add(Me.PresentacionPrintClmd)
        Me.DataListView1.AllColumns.Add(Me.Cant_PresentClmD)
        Me.DataListView1.AllColumns.Add(Me.precioCompraClmd)
        Me.DataListView1.AllColumns.Add(Me.totalCompraClm)
        Me.DataListView1.AllColumns.Add(Me.precioVentaClmD)
        Me.DataListView1.AllColumns.Add(Me.totalVentaClm)
        Me.DataListView1.AllColumns.Add(Me.idProductCombinedClm)
        Me.DataListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataListView1.AutoGenerateColumns = False
        Me.DataListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick
        Me.DataListView1.CellEditTabChangesRows = True
        Me.DataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPresentacionclmd, Me.Nom_ComercialClmd, Me.PresentacionPrintClmd, Me.Cant_PresentClmD, Me.precioCompraClmd, Me.totalCompraClm, Me.precioVentaClmD, Me.totalVentaClm})
        Me.DataListView1.DataSource = Nothing
        Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListView1.EmptyListMsg = "No existe informacion Sugerimos que agrege nuevos productos"
        Me.DataListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataListView1.FullRowSelect = True
        Me.DataListView1.HeaderMaximumHeight = 80
        Me.DataListView1.HeaderWordWrap = True
        Me.DataListView1.HideSelection = False
        Me.DataListView1.IncludeColumnHeadersInCopy = True
        Me.DataListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.DataListView1.Location = New System.Drawing.Point(2, 62)
        Me.DataListView1.Name = "DataListView1"
        Me.DataListView1.OwnerDraw = True
        Me.DataListView1.ShowGroups = False
        Me.DataListView1.ShowItemToolTips = True
        Me.DataListView1.Size = New System.Drawing.Size(215, 224)
        Me.DataListView1.TabIndex = 2
        Me.DataListView1.UseAlternatingBackColors = True
        Me.DataListView1.UseCompatibleStateImageBehavior = False
        Me.DataListView1.View = System.Windows.Forms.View.Details
        '
        'idPresentacionclmd
        '
        Me.idPresentacionclmd.AspectName = "idPresentacion"
        Me.idPresentacionclmd.IsVisible = False
        Me.idPresentacionclmd.Text = "idPresentacion"
        Me.idPresentacionclmd.Width = 0
        '
        'Nom_ComercialClmd
        '
        Me.Nom_ComercialClmd.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClmd.Text = "Nom_Comercial"
        Me.Nom_ComercialClmd.Width = 250
        '
        'PresentacionPrintClmd
        '
        Me.PresentacionPrintClmd.AspectName = "PresentacionPrint"
        Me.PresentacionPrintClmd.Text = "Empaque"
        Me.PresentacionPrintClmd.Width = 100
        '
        'Cant_PresentClmD
        '
        Me.Cant_PresentClmD.AspectName = "Cant_Conbined"
        Me.Cant_PresentClmD.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cant_PresentClmD.Text = "Cantidad"
        Me.Cant_PresentClmD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cant_PresentClmD.Width = 80
        '
        'precioCompraClmd
        '
        Me.precioCompraClmd.AspectName = "precioCompra"
        Me.precioCompraClmd.AspectToStringFormat = "{0:C5}"
        Me.precioCompraClmd.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioCompraClmd.Text = "Precio compra Unit"
        Me.precioCompraClmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioCompraClmd.Width = 150
        '
        'totalCompraClm
        '
        Me.totalCompraClm.AspectToStringFormat = "{0:C5}"
        Me.totalCompraClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalCompraClm.Text = "Total Compra"
        Me.totalCompraClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalCompraClm.Width = 120
        '
        'precioVentaClmD
        '
        Me.precioVentaClmD.AspectName = "precioVenta"
        Me.precioVentaClmD.AspectToStringFormat = "{0:C5}"
        Me.precioVentaClmD.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioVentaClmD.Text = "Precio venta Unit"
        Me.precioVentaClmD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioVentaClmD.Width = 120
        '
        'totalVentaClm
        '
        Me.totalVentaClm.AspectToStringFormat = "{0:C5}"
        Me.totalVentaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalVentaClm.Text = "Total Venta"
        Me.totalVentaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalVentaClm.Width = 120
        '
        'idProductCombinedClm
        '
        Me.idProductCombinedClm.AspectName = "idProductCombined"
        Me.idProductCombinedClm.IsVisible = False
        Me.idProductCombinedClm.Text = "idProductCombined"
        Me.idProductCombinedClm.Width = 0
        '
        'PanelDetail
        '
        Me.PanelDetail.BackgroundImage = CType(resources.GetObject("PanelDetail.BackgroundImage"), System.Drawing.Image)
        Me.PanelDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.DataListView1)
        Me.PanelDetail.Controls.Add(Me.Panel2)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel2)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetail.GradientBottomLeft = System.Drawing.Color.Olive
        Me.PanelDetail.GradientBottomRight = System.Drawing.Color.White
        Me.PanelDetail.GradientTopLeft = System.Drawing.Color.White
        Me.PanelDetail.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelDetail.Location = New System.Drawing.Point(866, 22)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Padding = New System.Windows.Forms.Padding(2, 0, 2, 10)
        Me.PanelDetail.Quality = 20
        Me.PanelDetail.Size = New System.Drawing.Size(221, 439)
        Me.PanelDetail.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.totalVentaLabel)
        Me.Panel2.Controls.Add(Me.totalCompraLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 103)
        Me.Panel2.TabIndex = 6
        '
        'totalVentaLabel
        '
        Me.totalVentaLabel.AutoSize = True
        Me.totalVentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalVentaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalVentaLabel.Location = New System.Drawing.Point(5, 34)
        Me.totalVentaLabel.Name = "totalVentaLabel"
        Me.totalVentaLabel.Size = New System.Drawing.Size(250, 20)
        Me.totalVentaLabel.TabIndex = 1
        Me.totalVentaLabel.Text = "Total al precio venta normal: 0"
        '
        'totalCompraLabel
        '
        Me.totalCompraLabel.AutoSize = True
        Me.totalCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCompraLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalCompraLabel.Location = New System.Drawing.Point(5, 5)
        Me.totalCompraLabel.Name = "totalCompraLabel"
        Me.totalCompraLabel.Size = New System.Drawing.Size(187, 20)
        Me.totalCompraLabel.TabIndex = 0
        Me.totalCompraLabel.Text = "Total precio compra: 0"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel2.Controls.Add(Me.Ok_Button)
        Me.BunifuGradientPanel2.Controls.Add(Me.Cancel_Button)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(2, 389)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.BunifuGradientPanel2.Quality = 20
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(215, 38)
        Me.BunifuGradientPanel2.TabIndex = 5
        '
        'Ok_Button
        '
        Me.Ok_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.ForeColor = System.Drawing.Color.White
        Me.Ok_Button.Location = New System.Drawing.Point(50, 1)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(71, 34)
        Me.Ok_Button.TabIndex = 1
        Me.Ok_Button.Text = "Aplicar"
        Me.Ok_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Location = New System.Drawing.Point(121, 1)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(91, 34)
        Me.Cancel_Button.TabIndex = 0
        Me.Cancel_Button.Text = "Cancelar"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel1.Controls.Add(Me.CountButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.DeleteButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.NewCombinedButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.retunrButton)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Olive
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(2, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.BunifuGradientPanel1.Quality = 20
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(215, 62)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'CountButton
        '
        Me.CountButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CountButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Count_201
        Me.CountButton.Location = New System.Drawing.Point(171, 30)
        Me.CountButton.Name = "CountButton"
        Me.CountButton.Size = New System.Drawing.Size(37, 28)
        Me.CountButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CountButton, "Cambiar cantidad en el componente")
        Me.CountButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.Location = New System.Drawing.Point(134, 30)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(37, 28)
        Me.DeleteButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Eliminar componente")
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'NewCombinedButton
        '
        Me.NewCombinedButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewCombinedButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.NewCombinedButton.Location = New System.Drawing.Point(97, 30)
        Me.NewCombinedButton.Name = "NewCombinedButton"
        Me.NewCombinedButton.Size = New System.Drawing.Size(37, 28)
        Me.NewCombinedButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NewCombinedButton, "Agregar nuevo componente")
        Me.NewCombinedButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(69, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 28)
        Me.Panel4.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Nom_ComercialLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(69, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 28)
        Me.Panel1.TabIndex = 0
        '
        'Nom_ComercialLabel
        '
        Me.Nom_ComercialLabel.AutoSize = True
        Me.Nom_ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_ComercialLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nom_ComercialLabel.Location = New System.Drawing.Point(2, 5)
        Me.Nom_ComercialLabel.Name = "Nom_ComercialLabel"
        Me.Nom_ComercialLabel.Size = New System.Drawing.Size(57, 17)
        Me.Nom_ComercialLabel.TabIndex = 0
        Me.Nom_ComercialLabel.Text = "Label1"
        '
        'retunrButton
        '
        Me.retunrButton.BackColor = System.Drawing.Color.Transparent
        Me.retunrButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Arrow_Back_48
        Me.retunrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.retunrButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.retunrButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.retunrButton.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retunrButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.retunrButton.Location = New System.Drawing.Point(2, 2)
        Me.retunrButton.Margin = New System.Windows.Forms.Padding(5)
        Me.retunrButton.Name = "retunrButton"
        Me.retunrButton.Size = New System.Drawing.Size(67, 56)
        Me.retunrButton.TabIndex = 5
        Me.retunrButton.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Blue
        Me.Splitter1.Location = New System.Drawing.Point(861, 22)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 439)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmProductConbined
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 461)
        Me.Controls.Add(Me.PanelDetail)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelViewdata)
        Me.Controls.Add(Me.PanelTools)
        Me.Name = "frmProductConbined"
        Me.Text = "Administración de productos combinados"
        Me.PanelViewdata.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTools As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PanelViewdata As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.ObjectListView
    Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
    Friend WithEvents PanelDetail As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Ok_Button As Button
    Friend WithEvents idPresentacionClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PresentacionPrintClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Cant_PresentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioVentaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CountButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewCombinedButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nom_ComercialLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents idPresentacionclmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PresentacionPrintClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Cant_PresentClmD As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioCompraClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioVentaClmD As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalVentaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalCompraLabel As Label
    Friend WithEvents totalVentaLabel As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As System.Windows.Forms.Button
    Friend WithEvents retunrButton As System.Windows.Forms.Button
    Friend WithEvents idProductCombinedClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents SettingSalesButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents barCodeTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barCodeClm As BrightIdeasSoftware.OLVColumn
    Private WithEvents groupBox9 As GroupBox
    Private WithEvents textBoxFilterSimple As TextBox
    Friend WithEvents Panel4 As Panel
End Class
