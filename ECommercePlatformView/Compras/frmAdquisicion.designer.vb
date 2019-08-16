<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdquisicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdquisicion))
        Me.ContextMenuListCompra = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuEmilinar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCantidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDescuento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPtotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFalg = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.tabItem = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New BrightIdeasSoftware.FastObjectListView()
        Me.IDClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IdPresentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CodigoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CountClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.UnitPriceClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DiscountClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TotalParcialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IsIncludeIvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IvaPercentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DateExpireClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PaneMove = New System.Windows.Forms.Panel()
        Me.MoveDowButton = New System.Windows.Forms.Button()
        Me.MoveUPButton = New System.Windows.Forms.Button()
        Me.PaneMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TotalItemsLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TotalEdidListButton = New System.Windows.Forms.Button()
        Me.PunitarioEddButton = New System.Windows.Forms.Button()
        Me.EditCountListButton = New System.Windows.Forms.Button()
        Me.AddNewListButton = New System.Windows.Forms.Button()
        Me.TableMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalEditButton = New System.Windows.Forms.Button()
        Me.DescuenEddButton = New System.Windows.Forms.Button()
        Me.CantiEddButton = New System.Windows.Forms.Button()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteDateButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.AtrasButton = New System.Windows.Forms.Button()
        Me.ActualizarButton = New System.Windows.Forms.Button()
        Me.PanelAddItems = New System.Windows.Forms.Panel()
        Me.cmbItemProducto = New System.Windows.Forms.ComboBox()
        Me.btnAddListaProduc = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerProducto = New System.Windows.Forms.Button()
        Me.btnNuevoProducto = New System.Windows.Forms.Button()
        Me.btnListProducto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.Label()
        Me.TotalGroupBox = New System.Windows.Forms.GroupBox()
        Me.RountIvaCheckBox = New System.Windows.Forms.CheckBox()
        Me.txtLugarDecimal = New System.Windows.Forms.NumericUpDown()
        Me.IsValitedUnitPriceCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsIncludeDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsIncludeIvaCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxRedondSin = New System.Windows.Forms.CheckBox()
        Me.CalculaTotalBtn = New System.Windows.Forms.Button()
        Me.cbxRedondCon = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DescBase0Text = New System.Windows.Forms.TextBox()
        Me.TotalBasText = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DescBase12Text = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bas12text = New System.Windows.Forms.TextBox()
        Me.Bas0text = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalBase = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PaneTotal = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.IvaText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalPediText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardaPedido = New System.Windows.Forms.Button()
        Me.lblDetalleItema = New System.Windows.Forms.RichTextBox()
        Me.tabPago = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtFechaPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.NumDocumenLabel = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.btnAlternativo = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbDeclaracion = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbItmTipconsumo = New System.Windows.Forms.ComboBox()
        Me.BodegaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.AtrasButtonFactur = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelCompra = New System.Windows.Forms.Button()
        Me.btnGuardarCompra = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.txtDetailpago = New System.Windows.Forms.TextBox()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.txtIdFormaPago = New System.Windows.Forms.TextBox()
        Me.tabDocumento = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAcepProveedor = New System.Windows.Forms.Button()
        Me.txtidAutorzCheque = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProveedorDetail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBodega2 = New System.Windows.Forms.Label()
        Me.lblbodega = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnListProveedor = New System.Windows.Forms.Button()
        Me.FechaPedidoDatatime = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuListCompra.SuspendLayout()
        Me.tabItem.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneMove.SuspendLayout()
        Me.PaneMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TableMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.PanelAddItems.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
        Me.TotalGroupBox.SuspendLayout()
        CType(Me.txtLugarDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PaneTotal.SuspendLayout()
        Me.tabPago.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabDocumento.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabcontrol.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuListCompra
        '
        Me.ContextMenuListCompra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEmilinar, Me.ToolStripSeparator1, Me.menuModificar})
        Me.ContextMenuListCompra.Name = "ContextMenuListCompra"
        Me.ContextMenuListCompra.Size = New System.Drawing.Size(172, 54)
        '
        'menuEmilinar
        '
        Me.menuEmilinar.Name = "menuEmilinar"
        Me.menuEmilinar.Size = New System.Drawing.Size(171, 22)
        Me.menuEmilinar.Text = "Eliminar Fila.."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'menuModificar
        '
        Me.menuModificar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCantidad, Me.menuDescuento, Me.menuPtotal})
        Me.menuModificar.Name = "menuModificar"
        Me.menuModificar.Size = New System.Drawing.Size(171, 22)
        Me.menuModificar.Text = "Modificar Valores.."
        '
        'menuCantidad
        '
        Me.menuCantidad.Name = "menuCantidad"
        Me.menuCantidad.Size = New System.Drawing.Size(136, 22)
        Me.menuCantidad.Text = "Cantidad"
        '
        'menuDescuento
        '
        Me.menuDescuento.Name = "menuDescuento"
        Me.menuDescuento.Size = New System.Drawing.Size(136, 22)
        Me.menuDescuento.Text = "Descuento"
        '
        'menuPtotal
        '
        Me.menuPtotal.Name = "menuPtotal"
        Me.menuPtotal.Size = New System.Drawing.Size(136, 22)
        Me.menuPtotal.Text = "Precio Total"
        '
        'txtFalg
        '
        Me.txtFalg.Location = New System.Drawing.Point(1207, 3)
        Me.txtFalg.Name = "txtFalg"
        Me.txtFalg.Size = New System.Drawing.Size(49, 20)
        Me.txtFalg.TabIndex = 13
        Me.txtFalg.Text = "0"
        Me.txtFalg.Visible = False
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Blue
        Me.lblProducto.Location = New System.Drawing.Point(105, 9)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(0, 37)
        Me.lblProducto.TabIndex = 11
        '
        'tabItem
        '
        Me.tabItem.Controls.Add(Me.Panel2)
        Me.tabItem.Controls.Add(Me.PaneMenu)
        Me.tabItem.Controls.Add(Me.PanelAddItems)
        Me.tabItem.Controls.Add(Me.PanelTotal)
        Me.tabItem.Location = New System.Drawing.Point(4, 28)
        Me.tabItem.Name = "tabItem"
        Me.tabItem.Size = New System.Drawing.Size(1128, 564)
        Me.tabItem.TabIndex = 2
        Me.tabItem.Text = "Items de Producto......"
        Me.tabItem.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.PaneMove)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(178, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 410)
        Me.Panel2.TabIndex = 20
        '
        'ListView1
        '
        Me.ListView1.AllColumns.Add(Me.IDClm)
        Me.ListView1.AllColumns.Add(Me.IdPresentClm)
        Me.ListView1.AllColumns.Add(Me.idProductoClm)
        Me.ListView1.AllColumns.Add(Me.CodigoClm)
        Me.ListView1.AllColumns.Add(Me.ProductoClm)
        Me.ListView1.AllColumns.Add(Me.CountClm)
        Me.ListView1.AllColumns.Add(Me.UnitPriceClm)
        Me.ListView1.AllColumns.Add(Me.DiscountClm)
        Me.ListView1.AllColumns.Add(Me.IvaClm)
        Me.ListView1.AllColumns.Add(Me.TotalParcialClm)
        Me.ListView1.AllColumns.Add(Me.IsIncludeIvaClm)
        Me.ListView1.AllColumns.Add(Me.IvaPercentClm)
        Me.ListView1.AllColumns.Add(Me.DateExpireClm)
        Me.ListView1.AllowDrop = True
        Me.ListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDClm, Me.IdPresentClm, Me.idProductoClm, Me.CodigoClm, Me.ProductoClm, Me.CountClm, Me.UnitPriceClm, Me.DiscountClm, Me.IvaClm, Me.TotalParcialClm, Me.IsIncludeIvaClm, Me.IvaPercentClm, Me.DateExpireClm})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.EmptyListMsg = "No hay informacion"
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HighlightBackgroundColor = System.Drawing.Color.Navy
        Me.ListView1.HighlightForegroundColor = System.Drawing.Color.White
        Me.ListView1.IncludeColumnHeadersInCopy = True
        Me.ListView1.LargeImageList = Me.imageList2
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.ListView1.ShowCommandMenuOnRightClick = True
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowImagesOnSubItems = True
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(919, 408)
        Me.ListView1.SmallImageList = Me.imageList1
        Me.ListView1.TabIndex = 3
        Me.ListView1.UnfocusedHighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListView1.UnfocusedHighlightForegroundColor = System.Drawing.Color.Black
        Me.ListView1.UseAlternatingBackColors = True
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseHotItem = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.VirtualMode = True
        '
        'IDClm
        '
        Me.IDClm.AspectName = "ID"
        Me.IDClm.IsVisible = False
        Me.IDClm.Text = "Cod Key"
        Me.IDClm.Width = 0
        '
        'IdPresentClm
        '
        Me.IdPresentClm.AspectName = "IdPresent"
        Me.IdPresentClm.Text = "IdPresent"
        Me.IdPresentClm.Width = 0
        '
        'idProductoClm
        '
        Me.idProductoClm.AspectName = "IdProducto"
        Me.idProductoClm.Text = "idProducto"
        Me.idProductoClm.Width = 0
        '
        'CodigoClm
        '
        Me.CodigoClm.AspectName = "Codigo"
        Me.CodigoClm.Text = "Código"
        Me.CodigoClm.Width = 80
        '
        'ProductoClm
        '
        Me.ProductoClm.AspectName = "Producto"
        Me.ProductoClm.Text = "Producto"
        Me.ProductoClm.Width = 260
        '
        'CountClm
        '
        Me.CountClm.AspectName = "Count"
        Me.CountClm.AspectToStringFormat = "{0:N3}"
        Me.CountClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountClm.Text = "Cantidad"
        Me.CountClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountClm.Width = 100
        '
        'UnitPriceClm
        '
        Me.UnitPriceClm.AspectName = "UnitPrice"
        Me.UnitPriceClm.AspectToStringFormat = "{0:C5}"
        Me.UnitPriceClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Text = "Precio Unitario"
        Me.UnitPriceClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Width = 100
        '
        'DiscountClm
        '
        Me.DiscountClm.AspectName = "Discount"
        Me.DiscountClm.AspectToStringFormat = "{0:C3}"
        Me.DiscountClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiscountClm.Text = "Descuento"
        Me.DiscountClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DiscountClm.Width = 100
        '
        'IvaClm
        '
        Me.IvaClm.AspectName = "Iva"
        Me.IvaClm.AspectToStringFormat = "{0:C5}"
        Me.IvaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaClm.Text = "Iva"
        Me.IvaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaClm.Width = 100
        '
        'TotalParcialClm
        '
        Me.TotalParcialClm.AspectName = "TotalParcial"
        Me.TotalParcialClm.AspectToStringFormat = "{0:C5}"
        Me.TotalParcialClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalParcialClm.Text = "Sub total"
        Me.TotalParcialClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalParcialClm.Width = 150
        '
        'IsIncludeIvaClm
        '
        Me.IsIncludeIvaClm.AspectName = ""
        Me.IsIncludeIvaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IsIncludeIvaClm.Text = "Incluido iva"
        Me.IsIncludeIvaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IsIncludeIvaClm.Width = 100
        '
        'IvaPercentClm
        '
        Me.IvaPercentClm.AspectName = "IvaPercent"
        Me.IvaPercentClm.AspectToStringFormat = "{0:P2}"
        Me.IvaPercentClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaPercentClm.Text = "Iva porcentaje"
        Me.IvaPercentClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IvaPercentClm.Width = 0
        '
        'DateExpireClm
        '
        Me.DateExpireClm.AspectName = "DateExpire"
        Me.DateExpireClm.AspectToStringFormat = "{0:d}"
        Me.DateExpireClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateExpireClm.Text = "Fecha expira"
        Me.DateExpireClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateExpireClm.Width = 100
        '
        'imageList2
        '
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList2.Images.SetKeyName(0, "user")
        Me.imageList2.Images.SetKeyName(1, "compass")
        Me.imageList2.Images.SetKeyName(2, "down")
        Me.imageList2.Images.SetKeyName(3, "find")
        Me.imageList2.Images.SetKeyName(4, "folder")
        Me.imageList2.Images.SetKeyName(5, "movie")
        Me.imageList2.Images.SetKeyName(6, "music")
        Me.imageList2.Images.SetKeyName(7, "no")
        Me.imageList2.Images.SetKeyName(8, "readonly")
        Me.imageList2.Images.SetKeyName(9, "public")
        Me.imageList2.Images.SetKeyName(10, "recycle")
        Me.imageList2.Images.SetKeyName(11, "spanner")
        Me.imageList2.Images.SetKeyName(12, "star")
        Me.imageList2.Images.SetKeyName(13, "tick")
        Me.imageList2.Images.SetKeyName(14, "archive")
        Me.imageList2.Images.SetKeyName(15, "system")
        Me.imageList2.Images.SetKeyName(16, "hidden")
        Me.imageList2.Images.SetKeyName(17, "temporary")
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "compass")
        Me.imageList1.Images.SetKeyName(1, "down")
        Me.imageList1.Images.SetKeyName(2, "user")
        Me.imageList1.Images.SetKeyName(3, "find")
        Me.imageList1.Images.SetKeyName(4, "folder")
        Me.imageList1.Images.SetKeyName(5, "movie")
        Me.imageList1.Images.SetKeyName(6, "music")
        Me.imageList1.Images.SetKeyName(7, "no")
        Me.imageList1.Images.SetKeyName(8, "readonly")
        Me.imageList1.Images.SetKeyName(9, "public")
        Me.imageList1.Images.SetKeyName(10, "recycle")
        Me.imageList1.Images.SetKeyName(11, "spanner")
        Me.imageList1.Images.SetKeyName(12, "star")
        Me.imageList1.Images.SetKeyName(13, "tick")
        Me.imageList1.Images.SetKeyName(14, "archive")
        Me.imageList1.Images.SetKeyName(15, "system")
        Me.imageList1.Images.SetKeyName(16, "hidden")
        Me.imageList1.Images.SetKeyName(17, "temporary")
        Me.imageList1.Images.SetKeyName(18, "ok_16.png")
        Me.imageList1.Images.SetKeyName(19, "isIva_16.png")
        '
        'PaneMove
        '
        Me.PaneMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneMove.Controls.Add(Me.MoveDowButton)
        Me.PaneMove.Controls.Add(Me.MoveUPButton)
        Me.PaneMove.Dock = System.Windows.Forms.DockStyle.Right
        Me.PaneMove.Location = New System.Drawing.Point(919, 0)
        Me.PaneMove.Name = "PaneMove"
        Me.PaneMove.Size = New System.Drawing.Size(29, 408)
        Me.PaneMove.TabIndex = 0
        '
        'MoveDowButton
        '
        Me.MoveDowButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MoveDowButton.Location = New System.Drawing.Point(0, 370)
        Me.MoveDowButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MoveDowButton.Name = "MoveDowButton"
        Me.MoveDowButton.Size = New System.Drawing.Size(27, 36)
        Me.MoveDowButton.TabIndex = 21
        Me.MoveDowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.MoveDowButton, "Mover el item")
        Me.MoveDowButton.UseVisualStyleBackColor = True
        '
        'MoveUPButton
        '
        Me.MoveUPButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MoveUPButton.Location = New System.Drawing.Point(0, 0)
        Me.MoveUPButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MoveUPButton.Name = "MoveUPButton"
        Me.MoveUPButton.Size = New System.Drawing.Size(27, 35)
        Me.MoveUPButton.TabIndex = 20
        Me.MoveUPButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.MoveUPButton, "Mover el item")
        Me.MoveUPButton.UseVisualStyleBackColor = True
        '
        'PaneMenu
        '
        Me.PaneMenu.Controls.Add(Me.Panel4)
        Me.PaneMenu.Controls.Add(Me.TotalItemsLabel)
        Me.PaneMenu.Controls.Add(Me.Panel5)
        Me.PaneMenu.Controls.Add(Me.TableMenu)
        Me.PaneMenu.Controls.Add(Me.Panel3)
        Me.PaneMenu.Controls.Add(Me.TableLayoutPanel4)
        Me.PaneMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaneMenu.Location = New System.Drawing.Point(0, 0)
        Me.PaneMenu.Name = "PaneMenu"
        Me.PaneMenu.Size = New System.Drawing.Size(178, 410)
        Me.PaneMenu.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 32)
        Me.Panel4.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_24
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 27)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "     Detalle del producto selec"
        Me.ToolTip1.SetToolTip(Me.Button2, "Modificar todo el listado de la columna de precio unitario")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TotalItemsLabel
        '
        Me.TotalItemsLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalItemsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalItemsLabel.Location = New System.Drawing.Point(0, 391)
        Me.TotalItemsLabel.Name = "TotalItemsLabel"
        Me.TotalItemsLabel.Size = New System.Drawing.Size(178, 19)
        Me.TotalItemsLabel.TabIndex = 21
        Me.TotalItemsLabel.Text = "Total items: 0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel5.Controls.Add(Me.TotalEdidListButton)
        Me.Panel5.Controls.Add(Me.PunitarioEddButton)
        Me.Panel5.Controls.Add(Me.EditCountListButton)
        Me.Panel5.Controls.Add(Me.AddNewListButton)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 147)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(178, 104)
        Me.Panel5.TabIndex = 25
        '
        'TotalEdidListButton
        '
        Me.TotalEdidListButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.TotalEdidListButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEdidListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Edit_SubTotal_20
        Me.TotalEdidListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TotalEdidListButton.Location = New System.Drawing.Point(1, 82)
        Me.TotalEdidListButton.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalEdidListButton.Name = "TotalEdidListButton"
        Me.TotalEdidListButton.Size = New System.Drawing.Size(176, 26)
        Me.TotalEdidListButton.TabIndex = 19
        Me.TotalEdidListButton.Text = "Modificar el sub total"
        Me.ToolTip1.SetToolTip(Me.TotalEdidListButton, "Modificar todo el listado de la columna del precio total")
        Me.TotalEdidListButton.UseVisualStyleBackColor = True
        '
        'PunitarioEddButton
        '
        Me.PunitarioEddButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PunitarioEddButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PunitarioEddButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Edit_UnitPrice_20
        Me.PunitarioEddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PunitarioEddButton.Location = New System.Drawing.Point(1, 55)
        Me.PunitarioEddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PunitarioEddButton.Name = "PunitarioEddButton"
        Me.PunitarioEddButton.Size = New System.Drawing.Size(176, 27)
        Me.PunitarioEddButton.TabIndex = 18
        Me.PunitarioEddButton.Text = "Modif. Precio Unt (List)"
        Me.ToolTip1.SetToolTip(Me.PunitarioEddButton, "Modificar todo el listado de la columna de precio unitario")
        Me.PunitarioEddButton.UseVisualStyleBackColor = True
        '
        'EditCountListButton
        '
        Me.EditCountListButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditCountListButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCountListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Count_20
        Me.EditCountListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditCountListButton.Location = New System.Drawing.Point(1, 29)
        Me.EditCountListButton.Margin = New System.Windows.Forms.Padding(0)
        Me.EditCountListButton.Name = "EditCountListButton"
        Me.EditCountListButton.Size = New System.Drawing.Size(176, 26)
        Me.EditCountListButton.TabIndex = 21
        Me.EditCountListButton.Text = "Modificar cantidad (List)"
        Me.ToolTip1.SetToolTip(Me.EditCountListButton, "Modificar todo el listado de la columna del precio total")
        Me.EditCountListButton.UseVisualStyleBackColor = True
        '
        'AddNewListButton
        '
        Me.AddNewListButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddNewListButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.AddList_20
        Me.AddNewListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewListButton.Location = New System.Drawing.Point(1, 1)
        Me.AddNewListButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddNewListButton.Name = "AddNewListButton"
        Me.AddNewListButton.Size = New System.Drawing.Size(176, 28)
        Me.AddNewListButton.TabIndex = 20
        Me.AddNewListButton.Text = "Agregar desde una list"
        Me.ToolTip1.SetToolTip(Me.AddNewListButton, "Modificar todo el listado de la columna del precio total")
        Me.AddNewListButton.UseVisualStyleBackColor = True
        '
        'TableMenu
        '
        Me.TableMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableMenu.ColumnCount = 2
        Me.TableMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42529!))
        Me.TableMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57471!))
        Me.TableMenu.Controls.Add(Me.TotalEditButton, 1, 2)
        Me.TableMenu.Controls.Add(Me.DescuenEddButton, 1, 1)
        Me.TableMenu.Controls.Add(Me.CantiEddButton, 1, 0)
        Me.TableMenu.Controls.Add(Me.SelectAllButton, 0, 0)
        Me.TableMenu.Controls.Add(Me.DeleteButton, 0, 2)
        Me.TableMenu.Controls.Add(Me.CopyButton, 0, 1)
        Me.TableMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableMenu.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableMenu.Location = New System.Drawing.Point(0, 62)
        Me.TableMenu.Name = "TableMenu"
        Me.TableMenu.Padding = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableMenu.RowCount = 3
        Me.TableMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableMenu.Size = New System.Drawing.Size(178, 85)
        Me.TableMenu.TabIndex = 16
        '
        'TotalEditButton
        '
        Me.TotalEditButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalEditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Editar_24
        Me.TotalEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TotalEditButton.Location = New System.Drawing.Point(88, 56)
        Me.TotalEditButton.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalEditButton.Name = "TotalEditButton"
        Me.TotalEditButton.Size = New System.Drawing.Size(88, 29)
        Me.TotalEditButton.TabIndex = 19
        Me.TotalEditButton.Text = "P. Total "
        Me.TotalEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TotalEditButton.UseVisualStyleBackColor = True
        '
        'DescuenEddButton
        '
        Me.DescuenEddButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescuenEddButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Rates_24
        Me.DescuenEddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DescuenEddButton.Location = New System.Drawing.Point(88, 29)
        Me.DescuenEddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DescuenEddButton.Name = "DescuenEddButton"
        Me.DescuenEddButton.Size = New System.Drawing.Size(88, 27)
        Me.DescuenEddButton.TabIndex = 18
        Me.DescuenEddButton.Text = "Descuento"
        Me.DescuenEddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescuenEddButton.UseVisualStyleBackColor = True
        '
        'CantiEddButton
        '
        Me.CantiEddButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CantiEddButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_24
        Me.CantiEddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CantiEddButton.Location = New System.Drawing.Point(88, 2)
        Me.CantiEddButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CantiEddButton.Name = "CantiEddButton"
        Me.CantiEddButton.Size = New System.Drawing.Size(88, 27)
        Me.CantiEddButton.TabIndex = 17
        Me.CantiEddButton.Text = "Cantidad"
        Me.CantiEddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CantiEddButton.UseVisualStyleBackColor = True
        '
        'SelectAllButton
        '
        Me.SelectAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SelectAllButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectAllButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAllButton.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectAll_16x16
        Me.SelectAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectAllButton.Location = New System.Drawing.Point(2, 2)
        Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(86, 27)
        Me.SelectAllButton.TabIndex = 15
        Me.SelectAllButton.Text = "   Seleccionar"
        Me.ToolTip1.SetToolTip(Me.SelectAllButton, "Seleccionar todo el listado")
        Me.SelectAllButton.UseCompatibleTextRendering = True
        Me.SelectAllButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(2, 56)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(86, 29)
        Me.DeleteButton.TabIndex = 20
        Me.DeleteButton.Text = "Eliminar.."
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.CopyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopyButton.Location = New System.Drawing.Point(2, 29)
        Me.CopyButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(86, 27)
        Me.CopyButton.TabIndex = 15
        Me.CopyButton.Text = "Copiar"
        Me.ToolTip1.SetToolTip(Me.CopyButton, "Copiar los Items seleccionados")
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DeleteDateButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(178, 32)
        Me.Panel3.TabIndex = 23
        '
        'DeleteDateButton
        '
        Me.DeleteDateButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteDateButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteDateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.DeleteDate_20
        Me.DeleteDateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteDateButton.Location = New System.Drawing.Point(1, 1)
        Me.DeleteDateButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DeleteDateButton.Name = "DeleteDateButton"
        Me.DeleteDateButton.Size = New System.Drawing.Size(176, 29)
        Me.DeleteDateButton.TabIndex = 18
        Me.DeleteDateButton.Text = "  Eliminar fecha expiración"
        Me.ToolTip1.SetToolTip(Me.DeleteDateButton, "Eliminar fecha de caducidad.")
        Me.DeleteDateButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.67816!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.32184!))
        Me.TableLayoutPanel4.Controls.Add(Me.AtrasButton, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ActualizarButton, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(178, 30)
        Me.TableLayoutPanel4.TabIndex = 22
        '
        'AtrasButton
        '
        Me.AtrasButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AtrasButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtrasButton.Image = Global.ECommercePlatformView.My.Resources.Resources.MovePrevio_16x16
        Me.AtrasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AtrasButton.Location = New System.Drawing.Point(3, 3)
        Me.AtrasButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AtrasButton.Name = "AtrasButton"
        Me.AtrasButton.Size = New System.Drawing.Size(74, 24)
        Me.AtrasButton.TabIndex = 20
        Me.AtrasButton.Text = "      Atrás"
        Me.AtrasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.AtrasButton, "Actualizar toda la lista")
        Me.AtrasButton.UseVisualStyleBackColor = True
        '
        'ActualizarButton
        '
        Me.ActualizarButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActualizarButton.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarButton.Image = Global.ECommercePlatformView.My.Resources.Resources.UpdateTable_16x16
        Me.ActualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarButton.Location = New System.Drawing.Point(78, 3)
        Me.ActualizarButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ActualizarButton.Name = "ActualizarButton"
        Me.ActualizarButton.Size = New System.Drawing.Size(97, 24)
        Me.ActualizarButton.TabIndex = 19
        Me.ActualizarButton.Text = "  Actualizar"
        Me.ToolTip1.SetToolTip(Me.ActualizarButton, "Actualizar toda la lista")
        Me.ActualizarButton.UseVisualStyleBackColor = True
        '
        'PanelAddItems
        '
        Me.PanelAddItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelAddItems.Controls.Add(Me.cmbItemProducto)
        Me.PanelAddItems.Controls.Add(Me.btnAddListaProduc)
        Me.PanelAddItems.Controls.Add(Me.txtCantidad)
        Me.PanelAddItems.Controls.Add(Me.Label3)
        Me.PanelAddItems.Controls.Add(Me.btnVerProducto)
        Me.PanelAddItems.Controls.Add(Me.btnNuevoProducto)
        Me.PanelAddItems.Controls.Add(Me.btnListProducto)
        Me.PanelAddItems.Controls.Add(Me.Label2)
        Me.PanelAddItems.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAddItems.Location = New System.Drawing.Point(0, 410)
        Me.PanelAddItems.Name = "PanelAddItems"
        Me.PanelAddItems.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelAddItems.Size = New System.Drawing.Size(1128, 45)
        Me.PanelAddItems.TabIndex = 2
        '
        'cmbItemProducto
        '
        Me.cmbItemProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbItemProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbItemProducto.DropDownHeight = 150
        Me.cmbItemProducto.DropDownWidth = 450
        Me.cmbItemProducto.FormattingEnabled = True
        Me.cmbItemProducto.IntegralHeight = False
        Me.cmbItemProducto.Location = New System.Drawing.Point(118, 11)
        Me.cmbItemProducto.Name = "cmbItemProducto"
        Me.cmbItemProducto.Size = New System.Drawing.Size(463, 27)
        Me.cmbItemProducto.TabIndex = 0
        '
        'btnAddListaProduc
        '
        Me.btnAddListaProduc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddListaProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddListaProduc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddListaProduc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddListaProduc.Image = CType(resources.GetObject("btnAddListaProduc.Image"), System.Drawing.Image)
        Me.btnAddListaProduc.Location = New System.Drawing.Point(1068, 2)
        Me.btnAddListaProduc.Name = "btnAddListaProduc"
        Me.btnAddListaProduc.Size = New System.Drawing.Size(58, 41)
        Me.btnAddListaProduc.TabIndex = 7
        Me.btnAddListaProduc.Tag = ""
        Me.btnAddListaProduc.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.btnAddListaProduc, "Agregar el producto a la lista")
        Me.btnAddListaProduc.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(933, 8)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(125, 27)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(856, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad"
        '
        'btnVerProducto
        '
        Me.btnVerProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerProducto.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.btnVerProducto.Location = New System.Drawing.Point(667, 3)
        Me.btnVerProducto.Name = "btnVerProducto"
        Me.btnVerProducto.Size = New System.Drawing.Size(40, 40)
        Me.btnVerProducto.TabIndex = 10
        Me.btnVerProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnVerProducto, "Modificar el detalle del producto seleccionado")
        Me.btnVerProducto.UseVisualStyleBackColor = True
        '
        'btnNuevoProducto
        '
        Me.btnNuevoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoProducto.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.btnNuevoProducto.Location = New System.Drawing.Point(587, 3)
        Me.btnNuevoProducto.Name = "btnNuevoProducto"
        Me.btnNuevoProducto.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevoProducto.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnNuevoProducto, "Agregar nuevo producto")
        Me.btnNuevoProducto.UseVisualStyleBackColor = True
        '
        'btnListProducto
        '
        Me.btnListProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnListProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListProducto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListProducto.Image = Global.ECommercePlatformView.My.Resources.Resources.List_32x32
        Me.btnListProducto.Location = New System.Drawing.Point(627, 3)
        Me.btnListProducto.Name = "btnListProducto"
        Me.btnListProducto.Size = New System.Drawing.Size(40, 40)
        Me.btnListProducto.TabIndex = 10
        Me.btnListProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnListProducto, "Seleccionar desde el listado de producto")
        Me.btnListProducto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRODUCTO"
        '
        'PanelTotal
        '
        Me.PanelTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelTotal.Controls.Add(Me.toolStripStatusLabel1)
        Me.PanelTotal.Controls.Add(Me.TotalGroupBox)
        Me.PanelTotal.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelTotal.Controls.Add(Me.Panel6)
        Me.PanelTotal.Controls.Add(Me.lblDetalleItema)
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotal.Location = New System.Drawing.Point(0, 455)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelTotal.Size = New System.Drawing.Size(1128, 109)
        Me.PanelTotal.TabIndex = 18
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.AutoSize = True
        Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStripStatusLabel1.Location = New System.Drawing.Point(3, 14)
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(44, 13)
        Me.toolStripStatusLabel1.TabIndex = 14
        Me.toolStripStatusLabel1.Text = "Label10"
        Me.toolStripStatusLabel1.Visible = False
        '
        'TotalGroupBox
        '
        Me.TotalGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalGroupBox.Controls.Add(Me.RountIvaCheckBox)
        Me.TotalGroupBox.Controls.Add(Me.txtLugarDecimal)
        Me.TotalGroupBox.Controls.Add(Me.IsValitedUnitPriceCheckBox)
        Me.TotalGroupBox.Controls.Add(Me.IsIncludeDiscountCheckBox)
        Me.TotalGroupBox.Controls.Add(Me.IsIncludeIvaCheckBox)
        Me.TotalGroupBox.Controls.Add(Me.Label1)
        Me.TotalGroupBox.Controls.Add(Me.cbxRedondSin)
        Me.TotalGroupBox.Controls.Add(Me.CalculaTotalBtn)
        Me.TotalGroupBox.Controls.Add(Me.cbxRedondCon)
        Me.TotalGroupBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.TotalGroupBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalGroupBox.ForeColor = System.Drawing.Color.Blue
        Me.TotalGroupBox.Location = New System.Drawing.Point(118, 2)
        Me.TotalGroupBox.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalGroupBox.Name = "TotalGroupBox"
        Me.TotalGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.TotalGroupBox.Size = New System.Drawing.Size(446, 105)
        Me.TotalGroupBox.TabIndex = 11
        Me.TotalGroupBox.TabStop = False
        Me.TotalGroupBox.Text = "Herramientas de cálculo"
        '
        'RountIvaCheckBox
        '
        Me.RountIvaCheckBox.AutoSize = True
        Me.RountIvaCheckBox.BackColor = System.Drawing.Color.Aqua
        Me.RountIvaCheckBox.Location = New System.Drawing.Point(290, 30)
        Me.RountIvaCheckBox.Name = "RountIvaCheckBox"
        Me.RountIvaCheckBox.Size = New System.Drawing.Size(79, 56)
        Me.RountIvaCheckBox.TabIndex = 16
        Me.RountIvaCheckBox.Text = "Redondear" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a dos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "díjitos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el Iva"
        Me.RountIvaCheckBox.UseVisualStyleBackColor = False
        '
        'txtLugarDecimal
        '
        Me.txtLugarDecimal.Location = New System.Drawing.Point(389, 31)
        Me.txtLugarDecimal.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txtLugarDecimal.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtLugarDecimal.Name = "txtLugarDecimal"
        Me.txtLugarDecimal.Size = New System.Drawing.Size(53, 20)
        Me.txtLugarDecimal.TabIndex = 15
        Me.txtLugarDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtLugarDecimal, "Decimal en el sub total")
        Me.txtLugarDecimal.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'IsValitedUnitPriceCheckBox
        '
        Me.IsValitedUnitPriceCheckBox.AutoSize = True
        Me.IsValitedUnitPriceCheckBox.BackColor = System.Drawing.Color.Aqua
        Me.IsValitedUnitPriceCheckBox.Checked = True
        Me.IsValitedUnitPriceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.IsValitedUnitPriceCheckBox.Location = New System.Drawing.Point(9, 21)
        Me.IsValitedUnitPriceCheckBox.Name = "IsValitedUnitPriceCheckBox"
        Me.IsValitedUnitPriceCheckBox.Size = New System.Drawing.Size(80, 69)
        Me.IsValitedUnitPriceCheckBox.TabIndex = 14
        Me.IsValitedUnitPriceCheckBox.Text = "Calcular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de acuerdo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "precio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uitario"
        Me.IsValitedUnitPriceCheckBox.UseVisualStyleBackColor = False
        '
        'IsIncludeDiscountCheckBox
        '
        Me.IsIncludeDiscountCheckBox.AutoSize = True
        Me.IsIncludeDiscountCheckBox.BackColor = System.Drawing.Color.Aqua
        Me.IsIncludeDiscountCheckBox.Location = New System.Drawing.Point(189, 46)
        Me.IsIncludeDiscountCheckBox.Name = "IsIncludeDiscountCheckBox"
        Me.IsIncludeDiscountCheckBox.Size = New System.Drawing.Size(95, 43)
        Me.IsIncludeDiscountCheckBox.TabIndex = 13
        Me.IsIncludeDiscountCheckBox.Text = "En el Sub total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ya incluye" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descuento"
        Me.IsIncludeDiscountCheckBox.UseVisualStyleBackColor = False
        '
        'IsIncludeIvaCheckBox
        '
        Me.IsIncludeIvaCheckBox.AutoSize = True
        Me.IsIncludeIvaCheckBox.BackColor = System.Drawing.Color.Aqua
        Me.IsIncludeIvaCheckBox.Location = New System.Drawing.Point(95, 46)
        Me.IsIncludeIvaCheckBox.Name = "IsIncludeIvaCheckBox"
        Me.IsIncludeIvaCheckBox.Size = New System.Drawing.Size(95, 43)
        Me.IsIncludeIvaCheckBox.TabIndex = 12
        Me.IsIncludeIvaCheckBox.Text = "En el Sub total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ya incluye" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IVA"
        Me.IsIncludeIvaCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lugar Decimal"
        '
        'cbxRedondSin
        '
        Me.cbxRedondSin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxRedondSin.AutoSize = True
        Me.cbxRedondSin.BackColor = System.Drawing.Color.Lime
        Me.cbxRedondSin.Location = New System.Drawing.Point(189, 17)
        Me.cbxRedondSin.Name = "cbxRedondSin"
        Me.cbxRedondSin.Size = New System.Drawing.Size(92, 17)
        Me.cbxRedondSin.TabIndex = 5
        Me.cbxRedondSin.Text = "Sin Redondeo"
        Me.cbxRedondSin.UseVisualStyleBackColor = False
        '
        'CalculaTotalBtn
        '
        Me.CalculaTotalBtn.BackColor = System.Drawing.Color.Blue
        Me.CalculaTotalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CalculaTotalBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculaTotalBtn.Image = Global.ECommercePlatformView.My.Resources.Resources.CalculateNow_32x32
        Me.CalculaTotalBtn.Location = New System.Drawing.Point(393, 52)
        Me.CalculaTotalBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CalculaTotalBtn.Name = "CalculaTotalBtn"
        Me.CalculaTotalBtn.Size = New System.Drawing.Size(49, 48)
        Me.CalculaTotalBtn.TabIndex = 2
        Me.CalculaTotalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CalculaTotalBtn.UseVisualStyleBackColor = False
        '
        'cbxRedondCon
        '
        Me.cbxRedondCon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxRedondCon.AutoSize = True
        Me.cbxRedondCon.BackColor = System.Drawing.Color.Lime
        Me.cbxRedondCon.Checked = True
        Me.cbxRedondCon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxRedondCon.Location = New System.Drawing.Point(95, 17)
        Me.cbxRedondCon.Name = "cbxRedondCon"
        Me.cbxRedondCon.Size = New System.Drawing.Size(94, 17)
        Me.cbxRedondCon.TabIndex = 5
        Me.cbxRedondCon.Text = "Con redondeo"
        Me.cbxRedondCon.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.06122!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.93877!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DescBase0Text, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalBasText, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label26, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DescBase12Text, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Bas12text, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Bas0text, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalBase, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(564, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11037!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(343, 105)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'DescBase0Text
        '
        Me.DescBase0Text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescBase0Text.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescBase0Text.Location = New System.Drawing.Point(53, 2)
        Me.DescBase0Text.Margin = New System.Windows.Forms.Padding(0)
        Me.DescBase0Text.Multiline = True
        Me.DescBase0Text.Name = "DescBase0Text"
        Me.DescBase0Text.ReadOnly = True
        Me.DescBase0Text.Size = New System.Drawing.Size(128, 32)
        Me.DescBase0Text.TabIndex = 14
        Me.DescBase0Text.Text = "0"
        Me.DescBase0Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.DescBase0Text, "Base0%  y descuento")
        '
        'TotalBasText
        '
        Me.TotalBasText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalBasText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBasText.ForeColor = System.Drawing.Color.Navy
        Me.TotalBasText.Location = New System.Drawing.Point(214, 69)
        Me.TotalBasText.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalBasText.Multiline = True
        Me.TotalBasText.Name = "TotalBasText"
        Me.TotalBasText.ReadOnly = True
        Me.TotalBasText.Size = New System.Drawing.Size(127, 34)
        Me.TotalBasText.TabIndex = 7
        Me.TotalBasText.Text = "0"
        Me.TotalBasText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TotalBasText, "Sub Total")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(185, 69)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 34)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "="
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 34)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Total"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescBase12Text
        '
        Me.DescBase12Text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescBase12Text.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescBase12Text.Location = New System.Drawing.Point(53, 35)
        Me.DescBase12Text.Margin = New System.Windows.Forms.Padding(0)
        Me.DescBase12Text.Multiline = True
        Me.DescBase12Text.Name = "DescBase12Text"
        Me.DescBase12Text.ReadOnly = True
        Me.DescBase12Text.Size = New System.Drawing.Size(128, 33)
        Me.DescBase12Text.TabIndex = 3
        Me.DescBase12Text.Text = "0"
        Me.DescBase12Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.DescBase12Text, "Base12% y descuento")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(185, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 33)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "="
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Exento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 33)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Base Iva"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bas12text
        '
        Me.Bas12text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bas12text.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bas12text.Location = New System.Drawing.Point(214, 35)
        Me.Bas12text.Margin = New System.Windows.Forms.Padding(0)
        Me.Bas12text.Multiline = True
        Me.Bas12text.Name = "Bas12text"
        Me.Bas12text.ReadOnly = True
        Me.Bas12text.Size = New System.Drawing.Size(127, 33)
        Me.Bas12text.TabIndex = 1
        Me.Bas12text.Text = "0"
        Me.Bas12text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Bas12text, "Total Base12%")
        '
        'Bas0text
        '
        Me.Bas0text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bas0text.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bas0text.Location = New System.Drawing.Point(214, 2)
        Me.Bas0text.Margin = New System.Windows.Forms.Padding(0)
        Me.Bas0text.Multiline = True
        Me.Bas0text.Name = "Bas0text"
        Me.Bas0text.ReadOnly = True
        Me.Bas0text.Size = New System.Drawing.Size(127, 32)
        Me.Bas0text.TabIndex = 1
        Me.Bas0text.Text = "0"
        Me.Bas0text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Bas0text, "Total de Base0%")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(185, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "="
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalBase
        '
        Me.TotalBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalBase.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBase.ForeColor = System.Drawing.Color.Navy
        Me.TotalBase.Location = New System.Drawing.Point(53, 69)
        Me.TotalBase.Margin = New System.Windows.Forms.Padding(0)
        Me.TotalBase.Multiline = True
        Me.TotalBase.Name = "TotalBase"
        Me.TotalBase.ReadOnly = True
        Me.TotalBase.Size = New System.Drawing.Size(128, 34)
        Me.TotalBase.TabIndex = 5
        Me.TotalBase.Text = "0"
        Me.TotalBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TotalBase, "Total Base y total descuento")
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PaneTotal)
        Me.Panel6.Controls.Add(Me.btnGuardaPedido)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(907, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel6.Size = New System.Drawing.Size(219, 105)
        Me.Panel6.TabIndex = 14
        '
        'PaneTotal
        '
        Me.PaneTotal.BackColor = System.Drawing.Color.Aqua
        Me.PaneTotal.Controls.Add(Me.Label25)
        Me.PaneTotal.Controls.Add(Me.IvaText)
        Me.PaneTotal.Controls.Add(Me.Label8)
        Me.PaneTotal.Controls.Add(Me.TotalPediText)
        Me.PaneTotal.Controls.Add(Me.Label7)
        Me.PaneTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.PaneTotal.Location = New System.Drawing.Point(9, 2)
        Me.PaneTotal.Name = "PaneTotal"
        Me.PaneTotal.Size = New System.Drawing.Size(127, 101)
        Me.PaneTotal.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(127, 20)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Total Iva"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IvaText
        '
        Me.IvaText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IvaText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IvaText.Location = New System.Drawing.Point(0, 20)
        Me.IvaText.Margin = New System.Windows.Forms.Padding(0)
        Me.IvaText.Multiline = True
        Me.IvaText.Name = "IvaText"
        Me.IvaText.ReadOnly = True
        Me.IvaText.Size = New System.Drawing.Size(127, 23)
        Me.IvaText.TabIndex = 8
        Me.IvaText.Text = "0"
        Me.IvaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total a Pedido"
        '
        'TotalPediText
        '
        Me.TotalPediText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TotalPediText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPediText.Location = New System.Drawing.Point(0, 63)
        Me.TotalPediText.Multiline = True
        Me.TotalPediText.Name = "TotalPediText"
        Me.TotalPediText.ReadOnly = True
        Me.TotalPediText.Size = New System.Drawing.Size(127, 28)
        Me.TotalPediText.TabIndex = 1
        Me.TotalPediText.Text = "0"
        Me.TotalPediText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Location = New System.Drawing.Point(0, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 10)
        Me.Label7.TabIndex = 0
        '
        'btnGuardaPedido
        '
        Me.btnGuardaPedido.BackColor = System.Drawing.Color.Navy
        Me.btnGuardaPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardaPedido.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGuardaPedido.ForeColor = System.Drawing.Color.White
        Me.btnGuardaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardaPedido.Location = New System.Drawing.Point(136, 2)
        Me.btnGuardaPedido.Name = "btnGuardaPedido"
        Me.btnGuardaPedido.Size = New System.Drawing.Size(81, 101)
        Me.btnGuardaPedido.TabIndex = 10
        Me.btnGuardaPedido.Text = "Guardar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pedido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   [F12] "
        Me.btnGuardaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardaPedido.UseVisualStyleBackColor = False
        '
        'lblDetalleItema
        '
        Me.lblDetalleItema.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDetalleItema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetalleItema.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDetalleItema.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleItema.Location = New System.Drawing.Point(2, 2)
        Me.lblDetalleItema.Name = "lblDetalleItema"
        Me.lblDetalleItema.ReadOnly = True
        Me.lblDetalleItema.Size = New System.Drawing.Size(194, 105)
        Me.lblDetalleItema.TabIndex = 19
        Me.lblDetalleItema.Text = ""
        '
        'tabPago
        '
        Me.tabPago.Controls.Add(Me.FlowLayoutPanel1)
        Me.tabPago.Controls.Add(Me.Panel1)
        Me.tabPago.Controls.Add(Me.TableLayoutPanel1)
        Me.tabPago.Controls.Add(Me.GroupBox1)
        Me.tabPago.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabPago.Location = New System.Drawing.Point(4, 28)
        Me.tabPago.Name = "tabPago"
        Me.tabPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPago.Size = New System.Drawing.Size(1128, 564)
        Me.tabPago.TabIndex = 1
        Me.tabPago.Text = "Número de factura y forma de pago."
        Me.tabPago.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtOrden)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel1.Controls.Add(Me.dtFechaPedido)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label18)
        Me.FlowLayoutPanel1.Controls.Add(Me.dtFechaCompra)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmbTipoDocumento)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumDocumenLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtNumDoc)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAlternativo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmbDeclaracion)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label23)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmbItmTipconsumo)
        Me.FlowLayoutPanel1.Controls.Add(Me.BodegaLinkLabel)
        Me.FlowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 30)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(231, 489)
        Me.FlowLayoutPanel1.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Orden N°:"
        '
        'txtOrden
        '
        Me.txtOrden.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtOrden.Enabled = False
        Me.txtOrden.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Location = New System.Drawing.Point(75, 3)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(107, 23)
        Me.txtOrden.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 16)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Fecha de pedido:"
        '
        'dtFechaPedido
        '
        Me.dtFechaPedido.Enabled = False
        Me.dtFechaPedido.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPedido.Location = New System.Drawing.Point(116, 32)
        Me.dtFechaPedido.Name = "dtFechaPedido"
        Me.dtFechaPedido.Size = New System.Drawing.Size(103, 23)
        Me.dtFechaPedido.TabIndex = 11
        Me.dtFechaPedido.Value = New Date(2014, 1, 19, 16, 25, 39, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 19)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "FECHA DE COMPRA"
        '
        'dtFechaCompra
        '
        Me.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCompra.Location = New System.Drawing.Point(3, 80)
        Me.dtFechaCompra.Name = "dtFechaCompra"
        Me.dtFechaCompra.Size = New System.Drawing.Size(192, 27)
        Me.dtFechaCompra.TabIndex = 11
        Me.dtFechaCompra.Value = New Date(2014, 1, 19, 16, 25, 39, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(180, 19)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "TIPO DE DOCUMENTO:"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(3, 132)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(220, 27)
        Me.cmbTipoDocumento.TabIndex = 5
        '
        'NumDocumenLabel
        '
        Me.NumDocumenLabel.AutoSize = True
        Me.NumDocumenLabel.Location = New System.Drawing.Point(3, 165)
        Me.NumDocumenLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.NumDocumenLabel.Name = "NumDocumenLabel"
        Me.NumDocumenLabel.Size = New System.Drawing.Size(202, 19)
        Me.NumDocumenLabel.TabIndex = 6
        Me.NumDocumenLabel.Text = "NUMERO DE DOCUMENTO"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(3, 190)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(162, 27)
        Me.txtNumDoc.TabIndex = 12
        '
        'btnAlternativo
        '
        Me.btnAlternativo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlternativo.Location = New System.Drawing.Point(171, 190)
        Me.btnAlternativo.Name = "btnAlternativo"
        Me.btnAlternativo.Size = New System.Drawing.Size(52, 26)
        Me.btnAlternativo.TabIndex = 19
        Me.btnAlternativo.Text = "....."
        Me.btnAlternativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlternativo.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(3, 220)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(160, 17)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "TIPO DE DECLARACION:"
        '
        'cmbDeclaracion
        '
        Me.cmbDeclaracion.Enabled = False
        Me.cmbDeclaracion.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbDeclaracion.FormattingEnabled = True
        Me.cmbDeclaracion.Location = New System.Drawing.Point(3, 240)
        Me.cmbDeclaracion.Name = "cmbDeclaracion"
        Me.cmbDeclaracion.Size = New System.Drawing.Size(216, 24)
        Me.cmbDeclaracion.TabIndex = 20
        Me.cmbDeclaracion.Text = "Mensual"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 267)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 16)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "TIPO DE CONSUMO:"
        '
        'cmbItmTipconsumo
        '
        Me.cmbItmTipconsumo.Enabled = False
        Me.cmbItmTipconsumo.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmbItmTipconsumo.FormattingEnabled = True
        Me.cmbItmTipconsumo.Location = New System.Drawing.Point(3, 286)
        Me.cmbItmTipconsumo.Name = "cmbItmTipconsumo"
        Me.cmbItmTipconsumo.Size = New System.Drawing.Size(162, 24)
        Me.cmbItmTipconsumo.TabIndex = 21
        Me.cmbItmTipconsumo.Text = "Ventas"
        '
        'BodegaLinkLabel
        '
        Me.BodegaLinkLabel.AutoSize = True
        Me.BodegaLinkLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodegaLinkLabel.Location = New System.Drawing.Point(3, 313)
        Me.BodegaLinkLabel.Name = "BodegaLinkLabel"
        Me.BodegaLinkLabel.Size = New System.Drawing.Size(71, 17)
        Me.BodegaLinkLabel.TabIndex = 24
        Me.BodegaLinkLabel.TabStop = True
        Me.BodegaLinkLabel.Text = "LinkLabel1"
        Me.ToolTip1.SetToolTip(Me.BodegaLinkLabel, "Cambiar la bodega a la que se adquiere el producto")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.AtrasButtonFactur)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1122, 27)
        Me.Panel1.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(133, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(585, 23)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Si ya realizó la compra llene la siguiente documentacion y guardelo.."
        '
        'AtrasButtonFactur
        '
        Me.AtrasButtonFactur.Dock = System.Windows.Forms.DockStyle.Left
        Me.AtrasButtonFactur.Location = New System.Drawing.Point(0, 0)
        Me.AtrasButtonFactur.Name = "AtrasButtonFactur"
        Me.AtrasButtonFactur.Size = New System.Drawing.Size(133, 27)
        Me.AtrasButtonFactur.TabIndex = 27
        Me.AtrasButtonFactur.Text = "Atrás"
        Me.AtrasButtonFactur.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.68162!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.31839!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelCompra, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGuardarCompra, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 519)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1122, 42)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'btnCancelCompra
        '
        Me.btnCancelCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCompra.Location = New System.Drawing.Point(1033, 4)
        Me.btnCancelCompra.Name = "btnCancelCompra"
        Me.btnCancelCompra.Size = New System.Drawing.Size(86, 35)
        Me.btnCancelCompra.TabIndex = 13
        Me.btnCancelCompra.Text = "Cancelar"
        Me.btnCancelCompra.UseVisualStyleBackColor = True
        '
        'btnGuardarCompra
        '
        Me.btnGuardarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarCompra.BackColor = System.Drawing.Color.Navy
        Me.btnGuardarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarCompra.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCompra.Location = New System.Drawing.Point(776, 4)
        Me.btnGuardarCompra.Name = "btnGuardarCompra"
        Me.btnGuardarCompra.Size = New System.Drawing.Size(195, 35)
        Me.btnGuardarCompra.TabIndex = 13
        Me.btnGuardarCompra.Text = "Cuardar Compa  [F12]"
        Me.btnGuardarCompra.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(432, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "[F1] Auto número de documento [F4] Forma de pago [F12] Guardar."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.btnFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtDetailpago)
        Me.GroupBox1.Controls.Add(Me.lblFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtIdFormaPago)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(250, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 389)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormaPago.Location = New System.Drawing.Point(0, 0)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(136, 37)
        Me.btnFormaPago.TabIndex = 15
        Me.btnFormaPago.Text = "Forma de pago"
        Me.btnFormaPago.UseVisualStyleBackColor = False
        '
        'txtDetailpago
        '
        Me.txtDetailpago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetailpago.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtDetailpago.Location = New System.Drawing.Point(17, 59)
        Me.txtDetailpago.Multiline = True
        Me.txtDetailpago.Name = "txtDetailpago"
        Me.txtDetailpago.ReadOnly = True
        Me.txtDetailpago.Size = New System.Drawing.Size(482, 314)
        Me.txtDetailpago.TabIndex = 5
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.ForeColor = System.Drawing.Color.Red
        Me.lblFormaPago.Location = New System.Drawing.Point(13, 420)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(232, 19)
        Me.lblFormaPago.TabIndex = 4
        Me.lblFormaPago.Text = "Ninguna forma Selecionada"
        '
        'txtIdFormaPago
        '
        Me.txtIdFormaPago.Location = New System.Drawing.Point(140, 16)
        Me.txtIdFormaPago.Name = "txtIdFormaPago"
        Me.txtIdFormaPago.Size = New System.Drawing.Size(83, 27)
        Me.txtIdFormaPago.TabIndex = 14
        Me.txtIdFormaPago.Text = "0"
        Me.txtIdFormaPago.Visible = False
        '
        'tabDocumento
        '
        Me.tabDocumento.BackColor = System.Drawing.Color.White
        Me.tabDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabDocumento.Controls.Add(Me.TableLayoutPanel3)
        Me.tabDocumento.Controls.Add(Me.txtidAutorzCheque)
        Me.tabDocumento.Controls.Add(Me.GroupBox2)
        Me.tabDocumento.Controls.Add(Me.PictureBox1)
        Me.tabDocumento.Controls.Add(Me.lblBodega2)
        Me.tabDocumento.Controls.Add(Me.lblbodega)
        Me.tabDocumento.Controls.Add(Me.Label22)
        Me.tabDocumento.Controls.Add(Me.btnListProveedor)
        Me.tabDocumento.Controls.Add(Me.FechaPedidoDatatime)
        Me.tabDocumento.Controls.Add(Me.Label14)
        Me.tabDocumento.Controls.Add(Me.Label9)
        Me.tabDocumento.Location = New System.Drawing.Point(4, 28)
        Me.tabDocumento.Name = "tabDocumento"
        Me.tabDocumento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocumento.Size = New System.Drawing.Size(1128, 564)
        Me.tabDocumento.TabIndex = 0
        Me.tabDocumento.Text = "Documentación...."
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.20454!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.79545!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAcepProveedor, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 512)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1122, 49)
        Me.TableLayoutPanel3.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(977, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(360, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "[F4] Listado de proveedores[F12] Agrerar item de pedido."
        '
        'btnAcepProveedor
        '
        Me.btnAcepProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAcepProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAcepProveedor.Image = Global.ECommercePlatformView.My.Resources.Resources.VentasCarro_32
        Me.btnAcepProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcepProveedor.Location = New System.Drawing.Point(775, 3)
        Me.btnAcepProveedor.Name = "btnAcepProveedor"
        Me.btnAcepProveedor.Size = New System.Drawing.Size(196, 43)
        Me.btnAcepProveedor.TabIndex = 11
        Me.btnAcepProveedor.Text = "Agregar Articulos"
        Me.btnAcepProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcepProveedor.UseVisualStyleBackColor = True
        '
        'txtidAutorzCheque
        '
        Me.txtidAutorzCheque.Location = New System.Drawing.Point(299, 348)
        Me.txtidAutorzCheque.Name = "txtidAutorzCheque"
        Me.txtidAutorzCheque.Size = New System.Drawing.Size(53, 27)
        Me.txtidAutorzCheque.TabIndex = 18
        Me.txtidAutorzCheque.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtProveedorDetail)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 232)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de documentación"
        '
        'txtProveedorDetail
        '
        Me.txtProveedorDetail.BackColor = System.Drawing.Color.White
        Me.txtProveedorDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProveedorDetail.Location = New System.Drawing.Point(21, 33)
        Me.txtProveedorDetail.Multiline = True
        Me.txtProveedorDetail.Name = "txtProveedorDetail"
        Me.txtProveedorDetail.ReadOnly = True
        Me.txtProveedorDetail.Size = New System.Drawing.Size(371, 177)
        Me.txtProveedorDetail.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Resources.Proveedor_450x270_Jpg
        Me.PictureBox1.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 239)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblBodega2
        '
        Me.lblBodega2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblBodega2.AutoSize = True
        Me.lblBodega2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodega2.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblBodega2.Location = New System.Drawing.Point(6, 299)
        Me.lblBodega2.Name = "lblBodega2"
        Me.lblBodega2.Size = New System.Drawing.Size(134, 17)
        Me.lblBodega2.TabIndex = 13
        Me.lblBodega2.Text = "ORDEN DE COMPRA"
        '
        'lblbodega
        '
        Me.lblbodega.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.lblbodega.AutoSize = True
        Me.lblbodega.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbodega.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblbodega.Location = New System.Drawing.Point(6, 253)
        Me.lblbodega.Name = "lblbodega"
        Me.lblbodega.Size = New System.Drawing.Size(202, 23)
        Me.lblbodega.TabIndex = 13
        Me.lblbodega.Text = "ORDEN DE COMPRA"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(462, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(337, 39)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "ORDEN DE COMPRA"
        '
        'btnListProveedor
        '
        Me.btnListProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListProveedor.Image = Global.ECommercePlatformView.My.Resources.Resources.Group_Black_Folder_icon
        Me.btnListProveedor.Location = New System.Drawing.Point(871, 85)
        Me.btnListProveedor.Name = "btnListProveedor"
        Me.btnListProveedor.Size = New System.Drawing.Size(98, 96)
        Me.btnListProveedor.TabIndex = 12
        Me.btnListProveedor.UseVisualStyleBackColor = True
        '
        'FechaPedidoDatatime
        '
        Me.FechaPedidoDatatime.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaPedidoDatatime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaPedidoDatatime.Location = New System.Drawing.Point(700, 345)
        Me.FechaPedidoDatatime.Name = "FechaPedidoDatatime"
        Me.FechaPedidoDatatime.Size = New System.Drawing.Size(184, 30)
        Me.FechaPedidoDatatime.TabIndex = 9
        Me.FechaPedidoDatatime.Value = New Date(2014, 1, 19, 16, 25, 39, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(494, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 23)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "FECHA DE PEDIDO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(343, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "PROVEEDOR:"
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tabDocumento)
        Me.tabcontrol.Controls.Add(Me.tabItem)
        Me.tabcontrol.Controls.Add(Me.tabPago)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrol.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcontrol.Location = New System.Drawing.Point(5, 5)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(1136, 596)
        Me.tabcontrol.TabIndex = 10
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'frmAdquisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 611)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.txtFalg)
        Me.Controls.Add(Me.lblProducto)
        Me.KeyPreview = True
        Me.Name = "frmAdquisicion"
        Me.Padding = New System.Windows.Forms.Padding(5, 5, 5, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de productos."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuListCompra.ResumeLayout(False)
        Me.tabItem.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneMove.ResumeLayout(False)
        Me.PaneMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TableMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.PanelAddItems.ResumeLayout(False)
        Me.PanelAddItems.PerformLayout()
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelTotal.PerformLayout()
        Me.TotalGroupBox.ResumeLayout(False)
        Me.TotalGroupBox.PerformLayout()
        CType(Me.txtLugarDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.PaneTotal.ResumeLayout(False)
        Me.PaneTotal.PerformLayout()
        Me.tabPago.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabDocumento.ResumeLayout(False)
        Me.tabDocumento.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabcontrol.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuListCompra As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuEmilinar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCantidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDescuento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPtotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFalg As System.Windows.Forms.TextBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents tabItem As System.Windows.Forms.TabPage
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxRedondSin As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRedondCon As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardaPedido As System.Windows.Forms.Button
    Friend WithEvents CalculaTotalBtn As System.Windows.Forms.Button
    Friend WithEvents TotalPediText As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Bas12text As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bas0text As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnListProducto As System.Windows.Forms.Button
    Friend WithEvents btnNuevoProducto As System.Windows.Forms.Button
    Friend WithEvents btnAddListaProduc As System.Windows.Forms.Button
    Friend WithEvents btnVerProducto As System.Windows.Forms.Button
    Friend WithEvents tabPago As System.Windows.Forms.TabPage
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbItmTipconsumo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeclaracion As System.Windows.Forms.ComboBox
    Friend WithEvents btnAlternativo As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFormaPago As System.Windows.Forms.Button
    Friend WithEvents txtDetailpago As System.Windows.Forms.TextBox
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents txtIdFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnCancelCompra As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCompra As System.Windows.Forms.Button
    Friend WithEvents dtFechaPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents NumDocumenLabel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tabDocumento As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProveedorDetail As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnListProveedor As System.Windows.Forms.Button
    Friend WithEvents btnAcepProveedor As System.Windows.Forms.Button
    Friend WithEvents FechaPedidoDatatime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tabcontrol As System.Windows.Forms.TabControl
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label12 As Label
    Friend WithEvents lblbodega As System.Windows.Forms.Label
    Friend WithEvents lblBodega2 As System.Windows.Forms.Label
    Friend WithEvents txtidAutorzCheque As System.Windows.Forms.TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SelectAllButton As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents TableMenu As TableLayoutPanel
    Friend WithEvents TotalEditButton As Button
    Friend WithEvents DescuenEddButton As Button
    Friend WithEvents CantiEddButton As Button
    Friend WithEvents MoveDowButton As Button
    Friend WithEvents MoveUPButton As Button
    Friend WithEvents PanelTotal As System.Windows.Forms.Panel
    Friend WithEvents TotalGroupBox As GroupBox
    Friend WithEvents IsIncludeIvaCheckBox As CheckBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents PaneTotal As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PaneMove As System.Windows.Forms.Panel
    Friend WithEvents PaneMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelAddItems As System.Windows.Forms.Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ActualizarButton As Button
    Friend WithEvents IsIncludeDiscountCheckBox As CheckBox
    Friend WithEvents TotalBasText As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TotalBase As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents IvaText As TextBox
    Friend WithEvents DescBase0Text As TextBox
    Friend WithEvents DescBase12Text As TextBox
    Friend WithEvents AtrasButton As Button
    Friend WithEvents AtrasButtonFactur As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BodegaLinkLabel As LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TotalItemsLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cmbItemProducto As ComboBox
    Friend WithEvents ListView1 As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents IdPresentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CodigoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CountClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents UnitPriceClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DiscountClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents TotalParcialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IsIncludeIvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IvaPercentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DateExpireClm As BrightIdeasSoftware.OLVColumn
    Private WithEvents imageList1 As ImageList
    Private WithEvents imageList2 As ImageList
    Friend WithEvents toolStripStatusLabel1 As Label
    Friend WithEvents IDClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IsValitedUnitPriceCheckBox As CheckBox
    Friend WithEvents DeleteDateButton As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtLugarDecimal As NumericUpDown
    Friend WithEvents lblDetalleItema As RichTextBox
    Friend WithEvents RountIvaCheckBox As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TotalEdidListButton As Button
    Friend WithEvents PunitarioEddButton As Button
    Friend WithEvents AddNewListButton As Button
    Friend WithEvents EditCountListButton As Button
End Class
