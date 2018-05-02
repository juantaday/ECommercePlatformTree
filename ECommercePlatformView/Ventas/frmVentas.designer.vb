<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtExploret = New System.Windows.Forms.TextBox()
        Me.panelBodega = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuBodega = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambioBodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBodega = New System.Windows.Forms.Label()
        Me.btnOtroValor = New System.Windows.Forms.Button()
        Me.UltDocumentButton = New System.Windows.Forms.Button()
        Me.btnCancelFactur = New System.Windows.Forms.Button()
        Me.btnUpda_NumFactur = New System.Windows.Forms.Button()
        Me.btnEdd_NumFactur = New System.Windows.Forms.Button()
        Me.FacturaButton = New System.Windows.Forms.Button()
        Me.ProformaButton = New System.Windows.Forms.Button()
        Me.NotaVentaButton = New System.Windows.Forms.Button()
        Me.DetailPersonButton = New System.Windows.Forms.Button()
        Me.ListPersonButton = New System.Windows.Forms.Button()
        Me.deleteClienteButton = New System.Windows.Forms.Button()
        Me.btnActualiza = New System.Windows.Forms.Button()
        Me.btnEditCant = New System.Windows.Forms.Button()
        Me.btnPacketProdcut = New System.Windows.Forms.Button()
        Me.btnDeleteItems = New System.Windows.Forms.Button()
        Me.btnDow = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.PaneFacturacion = New System.Windows.Forms.Panel()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.TableFactur = New System.Windows.Forms.Panel()
        Me.F11Label = New System.Windows.Forms.Label()
        Me.F12Label = New System.Windows.Forms.Label()
        Me.pedidoButton = New System.Windows.Forms.Button()
        Me.lblVuelto = New System.Windows.Forms.Label()
        Me.PanefinalizFactur = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.txtNumFactur = New System.Windows.Forms.TextBox()
        Me.RatesButton = New System.Windows.Forms.Button()
        Me.ContextMenuDeleteRates = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AplicarTarifaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuCantidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.paneDetail = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.ObjectListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.IdPresent2Clm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IdProducto2Clm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CodProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentationPrintClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CuantityClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.UnitPriceClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PartialPriceClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DiscountClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.RatesClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TotalPriceClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.IvaPercentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PriceVatClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panelfoot = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcmdInferior = New System.Windows.Forms.Label()
        Me.lblNoexiste = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PanelHerramineItem = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFindInAdd = New MultiControls.Controls.TextBoxButton()
        Me.Panelultimo = New System.Windows.Forms.Panel()
        Me.UltimoIngresoLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrupCliente = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.NomClienteText = New System.Windows.Forms.TextBox()
        Me.CedulaTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FindClienteButton = New System.Windows.Forms.Button()
        Me.PanelTarifa = New System.Windows.Forms.Panel()
        Me.RatesTypeLabel = New System.Windows.Forms.Label()
        Me.TarifaLabel = New System.Windows.Forms.Label()
        Me.lblItemsTotal = New System.Windows.Forms.Label()
        Me.lblIva12 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbldescuento = New System.Windows.Forms.Label()
        Me.lblIva0 = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.paneTotal = New System.Windows.Forms.Panel()
        Me.lblOtrosValoresView = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtAutorizCredito = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtMontoMaxito = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelTerminal = New System.Windows.Forms.Panel()
        Me.ContextMenuCaja = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalidaDeEfecctivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaDeChequesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.User_operaLabel = New System.Windows.Forms.Label()
        Me.OperacionNumLabel = New System.Windows.Forms.Label()
        Me.labelTerminal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.creditoButton = New System.Windows.Forms.Button()
        Me.findDocumentButton = New System.Windows.Forms.Button()
        Me.ContextMenuOtroValor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemUnDolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDosDolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTresDolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemCuatroDolra = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemCincoDolar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemOtraValor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemNinguno = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHerramientas = New System.Windows.Forms.Panel()
        Me.panelBodega.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuBodega.SuspendLayout()
        Me.PaneFacturacion.SuspendLayout()
        Me.TableFactur.SuspendLayout()
        Me.PanefinalizFactur.SuspendLayout()
        Me.ContextMenuDeleteRates.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.paneDetail.SuspendLayout()
        Me.PanelView.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelfoot.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelHerramineItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panelultimo.SuspendLayout()
        Me.GrupCliente.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelTarifa.SuspendLayout()
        Me.paneTotal.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelTerminal.SuspendLayout()
        Me.ContextMenuCaja.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuOtroValor.SuspendLayout()
        Me.PanelHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(67, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(103, 26)
        Me.txtCantidad.TabIndex = 2
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCantidad, "La cantidad de compra")
        '
        'txtExploret
        '
        Me.txtExploret.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtExploret.Location = New System.Drawing.Point(9, 18)
        Me.txtExploret.Name = "txtExploret"
        Me.txtExploret.Size = New System.Drawing.Size(205, 26)
        Me.txtExploret.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtExploret, "Cantidad de producto  o Dódigo de producto")
        '
        'panelBodega
        '
        Me.panelBodega.BackColor = System.Drawing.Color.PeachPuff
        Me.panelBodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBodega.Controls.Add(Me.PictureBox2)
        Me.panelBodega.Controls.Add(Me.Label2)
        Me.panelBodega.Controls.Add(Me.lblBodega)
        Me.panelBodega.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelBodega.Location = New System.Drawing.Point(2, 2)
        Me.panelBodega.Name = "panelBodega"
        Me.panelBodega.Size = New System.Drawing.Size(143, 85)
        Me.panelBodega.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.panelBodega, "Este es el lugar (local de venta o bodega) de la que reducirá el STOCK")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SandyBrown
        Me.PictureBox2.ContextMenuStrip = Me.ContextMenuBodega
        Me.PictureBox2.Image = Global.ECommercePlatformView.My.Resources.Resources.whereHouse_48
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 52)
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'ContextMenuBodega
        '
        Me.ContextMenuBodega.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioBodegaToolStripMenuItem})
        Me.ContextMenuBodega.Name = "ContextMenuCaja"
        Me.ContextMenuBodega.Size = New System.Drawing.Size(214, 34)
        '
        'CambioBodegaToolStripMenuItem
        '
        Me.CambioBodegaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.WhereHouse_24
        Me.CambioBodegaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CambioBodegaToolStripMenuItem.Name = "CambioBodegaToolStripMenuItem"
        Me.CambioBodegaToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.CambioBodegaToolStripMenuItem.Text = "Cambiar local y bodega.."
        Me.CambioBodegaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SandyBrown
        Me.Label2.ContextMenuStrip = Me.ContextMenuBodega
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 34)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Local o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bodega:"
        '
        'lblBodega
        '
        Me.lblBodega.AutoEllipsis = True
        Me.lblBodega.BackColor = System.Drawing.Color.SandyBrown
        Me.lblBodega.ContextMenuStrip = Me.ContextMenuBodega
        Me.lblBodega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodega.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBodega.Location = New System.Drawing.Point(0, 0)
        Me.lblBodega.Name = "lblBodega"
        Me.lblBodega.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.lblBodega.Size = New System.Drawing.Size(141, 83)
        Me.lblBodega.TabIndex = 46
        Me.lblBodega.Text = "Salida de productos de: "
        Me.lblBodega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnOtroValor
        '
        Me.btnOtroValor.BackColor = System.Drawing.Color.Transparent
        Me.btnOtroValor.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.calculadora_48
        Me.btnOtroValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOtroValor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOtroValor.Location = New System.Drawing.Point(0, 0)
        Me.btnOtroValor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOtroValor.Name = "btnOtroValor"
        Me.btnOtroValor.Size = New System.Drawing.Size(43, 42)
        Me.btnOtroValor.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnOtroValor, "Incrementar otros valores a la factura")
        Me.btnOtroValor.UseVisualStyleBackColor = False
        '
        'UltDocumentButton
        '
        Me.UltDocumentButton.BackgroundImage = CType(resources.GetObject("UltDocumentButton.BackgroundImage"), System.Drawing.Image)
        Me.UltDocumentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UltDocumentButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltDocumentButton.Location = New System.Drawing.Point(43, 0)
        Me.UltDocumentButton.Margin = New System.Windows.Forms.Padding(0)
        Me.UltDocumentButton.Name = "UltDocumentButton"
        Me.UltDocumentButton.Size = New System.Drawing.Size(43, 42)
        Me.UltDocumentButton.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.UltDocumentButton, "Ultimos documentos")
        Me.UltDocumentButton.UseVisualStyleBackColor = True
        '
        'btnCancelFactur
        '
        Me.btnCancelFactur.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelFactur.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Cancel_32x32
        Me.btnCancelFactur.Location = New System.Drawing.Point(158, 0)
        Me.btnCancelFactur.Name = "btnCancelFactur"
        Me.btnCancelFactur.Size = New System.Drawing.Size(47, 67)
        Me.btnCancelFactur.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.btnCancelFactur, "Cancelar venta")
        Me.btnCancelFactur.UseVisualStyleBackColor = True
        '
        'btnUpda_NumFactur
        '
        Me.btnUpda_NumFactur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpda_NumFactur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpda_NumFactur.Image = Global.ECommercePlatformView.My.Resources.Resources.refresh_16
        Me.btnUpda_NumFactur.Location = New System.Drawing.Point(9, 36)
        Me.btnUpda_NumFactur.Name = "btnUpda_NumFactur"
        Me.btnUpda_NumFactur.Size = New System.Drawing.Size(26, 26)
        Me.btnUpda_NumFactur.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnUpda_NumFactur, "Actualizar numerador de factura..")
        Me.btnUpda_NumFactur.UseVisualStyleBackColor = True
        '
        'btnEdd_NumFactur
        '
        Me.btnEdd_NumFactur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdd_NumFactur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdd_NumFactur.Image = Global.ECommercePlatformView.My.Resources.Resources.Pencil_24
        Me.btnEdd_NumFactur.Location = New System.Drawing.Point(41, 36)
        Me.btnEdd_NumFactur.Name = "btnEdd_NumFactur"
        Me.btnEdd_NumFactur.Size = New System.Drawing.Size(26, 26)
        Me.btnEdd_NumFactur.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnEdd_NumFactur, "Modificar número de factura")
        Me.btnEdd_NumFactur.UseVisualStyleBackColor = True
        '
        'FacturaButton
        '
        Me.FacturaButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FacturaButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.FacturaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.factura_32
        Me.FacturaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FacturaButton.Location = New System.Drawing.Point(0, 2)
        Me.FacturaButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FacturaButton.Name = "FacturaButton"
        Me.FacturaButton.Size = New System.Drawing.Size(67, 56)
        Me.FacturaButton.TabIndex = 30
        Me.FacturaButton.Tag = "Factura"
        Me.FacturaButton.Text = "Factura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FacturaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.FacturaButton, "Documento por emitir")
        Me.FacturaButton.UseVisualStyleBackColor = True
        '
        'ProformaButton
        '
        Me.ProformaButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProformaButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProformaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProformaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.PageInfo_32x32
        Me.ProformaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProformaButton.Location = New System.Drawing.Point(141, 2)
        Me.ProformaButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ProformaButton.Name = "ProformaButton"
        Me.ProformaButton.Size = New System.Drawing.Size(64, 56)
        Me.ProformaButton.TabIndex = 28
        Me.ProformaButton.Tag = "Proforma"
        Me.ProformaButton.Text = "Proforma"
        Me.ProformaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.ProformaButton, "Documento por emitir")
        Me.ProformaButton.UseVisualStyleBackColor = True
        '
        'NotaVentaButton
        '
        Me.NotaVentaButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotaVentaButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.NotaVentaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaVentaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.NoteSales_32
        Me.NotaVentaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NotaVentaButton.Location = New System.Drawing.Point(67, 2)
        Me.NotaVentaButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NotaVentaButton.Name = "NotaVentaButton"
        Me.NotaVentaButton.Size = New System.Drawing.Size(74, 56)
        Me.NotaVentaButton.TabIndex = 29
        Me.NotaVentaButton.Tag = "Nota de venta"
        Me.NotaVentaButton.Text = "Nota venta"
        Me.NotaVentaButton.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.NotaVentaButton, "Documento por emitir")
        Me.NotaVentaButton.UseVisualStyleBackColor = True
        '
        'DetailPersonButton
        '
        Me.DetailPersonButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailPersonButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_user_24
        Me.DetailPersonButton.Location = New System.Drawing.Point(0, 31)
        Me.DetailPersonButton.Margin = New System.Windows.Forms.Padding(0)
        Me.DetailPersonButton.Name = "DetailPersonButton"
        Me.DetailPersonButton.Size = New System.Drawing.Size(42, 32)
        Me.DetailPersonButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DetailPersonButton, "Detalle del cliente")
        Me.DetailPersonButton.UseVisualStyleBackColor = True
        '
        'ListPersonButton
        '
        Me.ListPersonButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPersonButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_24
        Me.ListPersonButton.Location = New System.Drawing.Point(42, 31)
        Me.ListPersonButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ListPersonButton.Name = "ListPersonButton"
        Me.ListPersonButton.Size = New System.Drawing.Size(43, 32)
        Me.ListPersonButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ListPersonButton, "Listado de personas...")
        Me.ListPersonButton.UseVisualStyleBackColor = True
        '
        'deleteClienteButton
        '
        Me.deleteClienteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteClienteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.deleteClienteButton.Location = New System.Drawing.Point(42, 0)
        Me.deleteClienteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.deleteClienteButton.Name = "deleteClienteButton"
        Me.deleteClienteButton.Size = New System.Drawing.Size(43, 31)
        Me.deleteClienteButton.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.deleteClienteButton, "Borrar clinete")
        Me.deleteClienteButton.UseVisualStyleBackColor = True
        '
        'btnActualiza
        '
        Me.btnActualiza.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.UpdateTable_32x32
        Me.btnActualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualiza.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnActualiza.Location = New System.Drawing.Point(5, 17)
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(35, 41)
        Me.btnActualiza.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.btnActualiza, "Actalizar ....")
        Me.btnActualiza.UseVisualStyleBackColor = True
        '
        'btnEditCant
        '
        Me.btnEditCant.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit_32x32
        Me.btnEditCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditCant.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditCant.Enabled = False
        Me.btnEditCant.Location = New System.Drawing.Point(40, 17)
        Me.btnEditCant.Name = "btnEditCant"
        Me.btnEditCant.Size = New System.Drawing.Size(35, 41)
        Me.btnEditCant.TabIndex = 35
        Me.btnEditCant.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnEditCant, "Modificar cantidad")
        Me.btnEditCant.UseVisualStyleBackColor = True
        '
        'btnPacketProdcut
        '
        Me.btnPacketProdcut.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.PackageProduct_32x32
        Me.btnPacketProdcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPacketProdcut.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPacketProdcut.Enabled = False
        Me.btnPacketProdcut.Location = New System.Drawing.Point(180, 17)
        Me.btnPacketProdcut.Name = "btnPacketProdcut"
        Me.btnPacketProdcut.Size = New System.Drawing.Size(35, 41)
        Me.btnPacketProdcut.TabIndex = 33
        Me.btnPacketProdcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPacketProdcut, "Cambiar Empaque (y/o) Presentación")
        Me.btnPacketProdcut.UseVisualStyleBackColor = True
        '
        'btnDeleteItems
        '
        Me.btnDeleteItems.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.DeleteSheetRows_32x32
        Me.btnDeleteItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteItems.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteItems.Enabled = False
        Me.btnDeleteItems.Location = New System.Drawing.Point(75, 17)
        Me.btnDeleteItems.Name = "btnDeleteItems"
        Me.btnDeleteItems.Size = New System.Drawing.Size(35, 41)
        Me.btnDeleteItems.TabIndex = 42
        Me.btnDeleteItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnDeleteItems, "Eliminar item seleccionado.")
        Me.btnDeleteItems.UseVisualStyleBackColor = True
        '
        'btnDow
        '
        Me.btnDow.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Down_32x32
        Me.btnDow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDow.Enabled = False
        Me.btnDow.Location = New System.Drawing.Point(110, 17)
        Me.btnDow.Name = "btnDow"
        Me.btnDow.Size = New System.Drawing.Size(35, 41)
        Me.btnDow.TabIndex = 43
        Me.btnDow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnDow, "Cambiar de ubicación hacia abajo")
        Me.btnDow.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Up2_32x32
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUp.Enabled = False
        Me.btnUp.Location = New System.Drawing.Point(145, 17)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(35, 41)
        Me.btnUp.TabIndex = 42
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnUp, "Cambiar de ubicación hacia arriba")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'PaneFacturacion
        '
        Me.PaneFacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaneFacturacion.Controls.Add(Me.txtFormaPago)
        Me.PaneFacturacion.Controls.Add(Me.TableFactur)
        Me.PaneFacturacion.Controls.Add(Me.lblVuelto)
        Me.PaneFacturacion.Controls.Add(Me.PanefinalizFactur)
        Me.PaneFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneFacturacion.Location = New System.Drawing.Point(0, 184)
        Me.PaneFacturacion.Name = "PaneFacturacion"
        Me.PaneFacturacion.Size = New System.Drawing.Size(263, 343)
        Me.PaneFacturacion.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.PaneFacturacion, "Documento por emitir")
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPago.Location = New System.Drawing.Point(0, 60)
        Me.txtFormaPago.Multiline = True
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(263, 180)
        Me.txtFormaPago.TabIndex = 34
        '
        'TableFactur
        '
        Me.TableFactur.Controls.Add(Me.F11Label)
        Me.TableFactur.Controls.Add(Me.F12Label)
        Me.TableFactur.Controls.Add(Me.pedidoButton)
        Me.TableFactur.Controls.Add(Me.ProformaButton)
        Me.TableFactur.Controls.Add(Me.NotaVentaButton)
        Me.TableFactur.Controls.Add(Me.FacturaButton)
        Me.TableFactur.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableFactur.Location = New System.Drawing.Point(0, 0)
        Me.TableFactur.Name = "TableFactur"
        Me.TableFactur.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.TableFactur.Size = New System.Drawing.Size(263, 60)
        Me.TableFactur.TabIndex = 39
        '
        'F11Label
        '
        Me.F11Label.AutoSize = True
        Me.F11Label.BackColor = System.Drawing.SystemColors.Control
        Me.F11Label.Location = New System.Drawing.Point(69, 22)
        Me.F11Label.Name = "F11Label"
        Me.F11Label.Size = New System.Drawing.Size(25, 13)
        Me.F11Label.TabIndex = 33
        Me.F11Label.Text = "F11"
        '
        'F12Label
        '
        Me.F12Label.AutoSize = True
        Me.F12Label.BackColor = System.Drawing.SystemColors.Control
        Me.F12Label.Location = New System.Drawing.Point(5, 21)
        Me.F12Label.Name = "F12Label"
        Me.F12Label.Size = New System.Drawing.Size(25, 13)
        Me.F12Label.TabIndex = 32
        Me.F12Label.Text = "F12"
        '
        'pedidoButton
        '
        Me.pedidoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pedidoButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.pedidoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pedidoButton.Image = Global.ECommercePlatformView.My.Resources.Resources.TextBox_32x32
        Me.pedidoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pedidoButton.Location = New System.Drawing.Point(205, 2)
        Me.pedidoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.pedidoButton.Name = "pedidoButton"
        Me.pedidoButton.Size = New System.Drawing.Size(58, 56)
        Me.pedidoButton.TabIndex = 31
        Me.pedidoButton.Tag = "Pedido"
        Me.pedidoButton.Text = "Pedido"
        Me.pedidoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.pedidoButton, "Documento por emitir")
        Me.pedidoButton.UseVisualStyleBackColor = True
        '
        'lblVuelto
        '
        Me.lblVuelto.BackColor = System.Drawing.Color.Navy
        Me.lblVuelto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto.ForeColor = System.Drawing.Color.White
        Me.lblVuelto.Location = New System.Drawing.Point(0, 240)
        Me.lblVuelto.Name = "lblVuelto"
        Me.lblVuelto.Size = New System.Drawing.Size(263, 36)
        Me.lblVuelto.TabIndex = 38
        Me.lblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanefinalizFactur
        '
        Me.PanefinalizFactur.BackColor = System.Drawing.Color.Black
        Me.PanefinalizFactur.Controls.Add(Me.btnCancelFactur)
        Me.PanefinalizFactur.Controls.Add(Me.Label5)
        Me.PanefinalizFactur.Controls.Add(Me.btnPago)
        Me.PanefinalizFactur.Controls.Add(Me.txtNumFactur)
        Me.PanefinalizFactur.Controls.Add(Me.btnUpda_NumFactur)
        Me.PanefinalizFactur.Controls.Add(Me.btnEdd_NumFactur)
        Me.PanefinalizFactur.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanefinalizFactur.Enabled = False
        Me.PanefinalizFactur.Location = New System.Drawing.Point(0, 276)
        Me.PanefinalizFactur.Name = "PanefinalizFactur"
        Me.PanefinalizFactur.Size = New System.Drawing.Size(263, 67)
        Me.PanefinalizFactur.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Número de documento ha generar:"
        '
        'btnPago
        '
        Me.btnPago.BackColor = System.Drawing.Color.Red
        Me.btnPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPago.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPago.Location = New System.Drawing.Point(205, 0)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(58, 67)
        Me.btnPago.TabIndex = 28
        Me.btnPago.Text = "OK"
        Me.btnPago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPago.UseVisualStyleBackColor = False
        '
        'txtNumFactur
        '
        Me.txtNumFactur.Location = New System.Drawing.Point(3, 14)
        Me.txtNumFactur.Name = "txtNumFactur"
        Me.txtNumFactur.ReadOnly = True
        Me.txtNumFactur.Size = New System.Drawing.Size(180, 20)
        Me.txtNumFactur.TabIndex = 32
        '
        'RatesButton
        '
        Me.RatesButton.BackColor = System.Drawing.Color.Aquamarine
        Me.RatesButton.ContextMenuStrip = Me.ContextMenuDeleteRates
        Me.RatesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RatesButton.ForeColor = System.Drawing.Color.Black
        Me.RatesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Rates_Barr_24
        Me.RatesButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RatesButton.Location = New System.Drawing.Point(2, 2)
        Me.RatesButton.Name = "RatesButton"
        Me.RatesButton.Size = New System.Drawing.Size(74, 59)
        Me.RatesButton.TabIndex = 0
        Me.RatesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.RatesButton, "Tarifa")
        Me.RatesButton.UseVisualStyleBackColor = False
        '
        'ContextMenuDeleteRates
        '
        Me.ContextMenuDeleteRates.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicarTarifaToolStripMenuItem, Me.DeleteRatesToolStripMenuItem})
        Me.ContextMenuDeleteRates.Name = "ContextMenuAdd_new"
        Me.ContextMenuDeleteRates.Size = New System.Drawing.Size(156, 62)
        '
        'AplicarTarifaToolStripMenuItem
        '
        Me.AplicarTarifaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Rates_24
        Me.AplicarTarifaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AplicarTarifaToolStripMenuItem.Name = "AplicarTarifaToolStripMenuItem"
        Me.AplicarTarifaToolStripMenuItem.Size = New System.Drawing.Size(155, 30)
        Me.AplicarTarifaToolStripMenuItem.Text = "Aplicar tarifa.."
        '
        'DeleteRatesToolStripMenuItem
        '
        Me.DeleteRatesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteRatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeleteRatesToolStripMenuItem.Name = "DeleteRatesToolStripMenuItem"
        Me.DeleteRatesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.DeleteRatesToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.DeleteRatesToolStripMenuItem.Text = "Anular tarifa"
        Me.DeleteRatesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLabel
        '
        Me.txtLabel.AutoSize = True
        Me.txtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel.ForeColor = System.Drawing.Color.Blue
        Me.txtLabel.Location = New System.Drawing.Point(1145, 48)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(0, 39)
        Me.txtLabel.TabIndex = 32
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEliminar, Me.ToolStripSeparator1, Me.menuCantidad, Me.menuPTotal})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 76)
        '
        'menuEliminar
        '
        Me.menuEliminar.Name = "menuEliminar"
        Me.menuEliminar.Size = New System.Drawing.Size(190, 22)
        Me.menuEliminar.Text = "Emilinar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'menuCantidad
        '
        Me.menuCantidad.Name = "menuCantidad"
        Me.menuCantidad.Size = New System.Drawing.Size(190, 22)
        Me.menuCantidad.Text = "Modificar Cantidad"
        '
        'menuPTotal
        '
        Me.menuPTotal.Name = "menuPTotal"
        Me.menuPTotal.Size = New System.Drawing.Size(190, 22)
        Me.menuPTotal.Text = "Modificar Precio Total"
        '
        'paneDetail
        '
        Me.paneDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.paneDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.paneDetail.Controls.Add(Me.PanelView)
        Me.paneDetail.Controls.Add(Me.Panelfoot)
        Me.paneDetail.Controls.Add(Me.PanelHerramineItem)
        Me.paneDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneDetail.Location = New System.Drawing.Point(0, 89)
        Me.paneDetail.Name = "paneDetail"
        Me.paneDetail.Size = New System.Drawing.Size(1069, 478)
        Me.paneDetail.TabIndex = 0
        '
        'PanelView
        '
        Me.PanelView.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelView.Controls.Add(Me.ObjectListView1)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 60)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelView.Size = New System.Drawing.Size(1065, 359)
        Me.PanelView.TabIndex = 47
        '
        'ObjectListView1
        '
        Me.ObjectListView1.AllColumns.Add(Me.IdPresent2Clm)
        Me.ObjectListView1.AllColumns.Add(Me.IdProducto2Clm)
        Me.ObjectListView1.AllColumns.Add(Me.CodProductoClm)
        Me.ObjectListView1.AllColumns.Add(Me.Nom_ComercialClm)
        Me.ObjectListView1.AllColumns.Add(Me.PresentationPrintClm)
        Me.ObjectListView1.AllColumns.Add(Me.CuantityClm)
        Me.ObjectListView1.AllColumns.Add(Me.UnitPriceClm)
        Me.ObjectListView1.AllColumns.Add(Me.PartialPriceClm)
        Me.ObjectListView1.AllColumns.Add(Me.DiscountClm)
        Me.ObjectListView1.AllColumns.Add(Me.RatesClm)
        Me.ObjectListView1.AllColumns.Add(Me.TotalPriceClm)
        Me.ObjectListView1.AllColumns.Add(Me.IvaPercentClm)
        Me.ObjectListView1.AllColumns.Add(Me.PriceVatClm)
        Me.ObjectListView1.AllowColumnReorder = True
        Me.ObjectListView1.AllowDrop = True
        Me.ObjectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ObjectListView1.AutoGenerateColumns = False
        Me.ObjectListView1.BackColor = System.Drawing.Color.White
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPresent2Clm, Me.CodProductoClm, Me.Nom_ComercialClm, Me.PresentationPrintClm, Me.CuantityClm, Me.UnitPriceClm, Me.PartialPriceClm, Me.DiscountClm, Me.RatesClm, Me.TotalPriceClm})
        Me.ObjectListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ObjectListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView1.DataSource = Nothing
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.GridLines = True
        Me.ObjectListView1.HeaderWordWrap = True
        Me.ObjectListView1.HideSelection = False
        Me.ObjectListView1.IncludeColumnHeadersInCopy = True
        Me.ObjectListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.ObjectListView1.Location = New System.Drawing.Point(3, 3)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.OwnerDraw = True
        Me.ObjectListView1.SelectedColumnTint = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.ShowImagesOnSubItems = True
        Me.ObjectListView1.Size = New System.Drawing.Size(1059, 353)
        Me.ObjectListView1.SmallImageList = Me.ImageList1
        Me.ObjectListView1.TabIndex = 26
        Me.ObjectListView1.UnfocusedHighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ObjectListView1.UseAlternatingBackColors = True
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.UseFilterIndicator = True
        Me.ObjectListView1.UseFiltering = True
        Me.ObjectListView1.UseHotItem = True
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        Me.ObjectListView1.VirtualMode = True
        '
        'IdPresent2Clm
        '
        Me.IdPresent2Clm.AspectName = "IdPresent"
        Me.IdPresent2Clm.IsVisible = False
        Me.IdPresent2Clm.Text = "idPresent"
        Me.IdPresent2Clm.ToolTipText = "Se puede ver las 200 ultimas trasferencias.."
        Me.IdPresent2Clm.Width = 0
        '
        'IdProducto2Clm
        '
        Me.IdProducto2Clm.AspectName = "IdProducto"
        Me.IdProducto2Clm.DisplayIndex = 1
        Me.IdProducto2Clm.IsVisible = False
        Me.IdProducto2Clm.Text = "IdProducto"
        Me.IdProducto2Clm.Width = 0
        '
        'CodProductoClm
        '
        Me.CodProductoClm.AspectName = "CodProducto"
        Me.CodProductoClm.AspectToStringFormat = ""
        Me.CodProductoClm.Text = "Código"
        Me.CodProductoClm.ToolTipText = ""
        Me.CodProductoClm.Width = 90
        '
        'Nom_ComercialClm
        '
        Me.Nom_ComercialClm.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClm.Text = "Producto"
        Me.Nom_ComercialClm.ToolTipText = ""
        Me.Nom_ComercialClm.Width = 300
        '
        'PresentationPrintClm
        '
        Me.PresentationPrintClm.AspectName = "PresentationPrint"
        Me.PresentationPrintClm.Text = "Empaque"
        Me.PresentationPrintClm.Width = 100
        '
        'CuantityClm
        '
        Me.CuantityClm.AspectName = "Cuantity"
        Me.CuantityClm.AspectToStringFormat = "{0:N3}"
        Me.CuantityClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuantityClm.Text = "Cantidad"
        Me.CuantityClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuantityClm.Width = 80
        '
        'UnitPriceClm
        '
        Me.UnitPriceClm.AspectName = "UnitPrice"
        Me.UnitPriceClm.AspectToStringFormat = "{0:C5}"
        Me.UnitPriceClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Text = "Precio unitario"
        Me.UnitPriceClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPriceClm.Width = 90
        '
        'PartialPriceClm
        '
        Me.PartialPriceClm.AspectName = "PartialPrice"
        Me.PartialPriceClm.AspectToStringFormat = "{0:C5}"
        Me.PartialPriceClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PartialPriceClm.Text = "Sub total"
        Me.PartialPriceClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PartialPriceClm.Width = 120
        '
        'DiscountClm
        '
        Me.DiscountClm.AspectName = "Discount"
        Me.DiscountClm.AspectToStringFormat = "{0:C5}"
        Me.DiscountClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiscountClm.Text = "Descuento"
        Me.DiscountClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DiscountClm.Width = 80
        '
        'RatesClm
        '
        Me.RatesClm.AspectName = "Rates"
        Me.RatesClm.AspectToStringFormat = "{0:C5}"
        Me.RatesClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RatesClm.Text = "Adicional"
        Me.RatesClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RatesClm.Width = 100
        '
        'TotalPriceClm
        '
        Me.TotalPriceClm.AspectName = "TotalPrice"
        Me.TotalPriceClm.AspectToStringFormat = "{0:C5}"
        Me.TotalPriceClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPriceClm.Text = "Total"
        Me.TotalPriceClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPriceClm.Width = 120
        '
        'IvaPercentClm
        '
        Me.IvaPercentClm.AspectName = "IvaPercent"
        Me.IvaPercentClm.AspectToStringFormat = "{0:P2}"
        Me.IvaPercentClm.DisplayIndex = 10
        Me.IvaPercentClm.IsVisible = False
        Me.IvaPercentClm.Text = "Iva Porcentaje"
        Me.IvaPercentClm.Width = 0
        '
        'PriceVatClm
        '
        Me.PriceVatClm.AspectName = "PriceVat"
        Me.PriceVatClm.AspectToStringFormat = "{0:5}"
        Me.PriceVatClm.DisplayIndex = 11
        Me.PriceVatClm.IsVisible = False
        Me.PriceVatClm.Text = "Iva"
        Me.PriceVatClm.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "if_alert_17834 (1).png")
        Me.ImageList1.Images.SetKeyName(1, "if_alert_17834.png")
        '
        'Panelfoot
        '
        Me.Panelfoot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panelfoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelfoot.Controls.Add(Me.Label4)
        Me.Panelfoot.Controls.Add(Me.txtExploret)
        Me.Panelfoot.Controls.Add(Me.lblcmdInferior)
        Me.Panelfoot.Controls.Add(Me.lblNoexiste)
        Me.Panelfoot.Controls.Add(Me.Panel2)
        Me.Panelfoot.Controls.Add(Me.btnAgregar)
        Me.Panelfoot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelfoot.Location = New System.Drawing.Point(0, 419)
        Me.Panelfoot.Name = "Panelfoot"
        Me.Panelfoot.Padding = New System.Windows.Forms.Padding(2)
        Me.Panelfoot.Size = New System.Drawing.Size(1065, 55)
        Me.Panelfoot.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Código  o nombre de producto:"
        '
        'lblcmdInferior
        '
        Me.lblcmdInferior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcmdInferior.AutoSize = True
        Me.lblcmdInferior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcmdInferior.Location = New System.Drawing.Point(552, 11)
        Me.lblcmdInferior.Name = "lblcmdInferior"
        Me.lblcmdInferior.Size = New System.Drawing.Size(211, 30)
        Me.lblcmdInferior.TabIndex = 35
        Me.lblcmdInferior.Text = "Para cambiar cantidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingrese el número seguido del tecla *"
        '
        'lblNoexiste
        '
        Me.lblNoexiste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNoexiste.AutoSize = True
        Me.lblNoexiste.ForeColor = System.Drawing.Color.Red
        Me.lblNoexiste.Location = New System.Drawing.Point(220, 20)
        Me.lblNoexiste.Name = "lblNoexiste"
        Me.lblNoexiste.Size = New System.Drawing.Size(204, 20)
        Me.lblNoexiste.TabIndex = 36
        Me.lblNoexiste.Text = "No se encontró el producto."
        Me.lblNoexiste.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtCantidad)
        Me.Panel2.Location = New System.Drawing.Point(770, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 37)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Cantidad:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Green
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.ECommercePlatformView.My.Resources.Resources.AddItem_Black_32x32
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(954, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(107, 49)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PanelHerramineItem
        '
        Me.PanelHerramineItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelHerramineItem.Controls.Add(Me.GroupBox1)
        Me.PanelHerramineItem.Controls.Add(Me.Panelultimo)
        Me.PanelHerramineItem.Controls.Add(Me.btnPacketProdcut)
        Me.PanelHerramineItem.Controls.Add(Me.btnUp)
        Me.PanelHerramineItem.Controls.Add(Me.btnDow)
        Me.PanelHerramineItem.Controls.Add(Me.btnDeleteItems)
        Me.PanelHerramineItem.Controls.Add(Me.btnEditCant)
        Me.PanelHerramineItem.Controls.Add(Me.btnActualiza)
        Me.PanelHerramineItem.Controls.Add(Me.Label1)
        Me.PanelHerramineItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHerramineItem.Location = New System.Drawing.Point(0, 0)
        Me.PanelHerramineItem.Name = "PanelHerramineItem"
        Me.PanelHerramineItem.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.PanelHerramineItem.Size = New System.Drawing.Size(1065, 60)
        Me.PanelHerramineItem.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtFindInAdd)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(872, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 41)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Filter"
        '
        'txtFindInAdd
        '
        Me.txtFindInAdd.ButtonImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.txtFindInAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindInAdd.Location = New System.Drawing.Point(6, 15)
        Me.txtFindInAdd.Name = "txtFindInAdd"
        Me.txtFindInAdd.Size = New System.Drawing.Size(179, 23)
        Me.txtFindInAdd.TabIndex = 0
        Me.txtFindInAdd.VisibleButton = False
        '
        'Panelultimo
        '
        Me.Panelultimo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelultimo.Controls.Add(Me.UltimoIngresoLabel)
        Me.Panelultimo.Location = New System.Drawing.Point(215, 17)
        Me.Panelultimo.Name = "Panelultimo"
        Me.Panelultimo.Size = New System.Drawing.Size(651, 41)
        Me.Panelultimo.TabIndex = 46
        '
        'UltimoIngresoLabel
        '
        Me.UltimoIngresoLabel.AutoSize = True
        Me.UltimoIngresoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltimoIngresoLabel.ForeColor = System.Drawing.Color.Red
        Me.UltimoIngresoLabel.Location = New System.Drawing.Point(6, 10)
        Me.UltimoIngresoLabel.Name = "UltimoIngresoLabel"
        Me.UltimoIngresoLabel.Size = New System.Drawing.Size(0, 20)
        Me.UltimoIngresoLabel.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1058, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "F1:Agregar clientes; F2:Elimina cliente; F3:Busca cliente; F4:Productos;  F5:Actu" &
    "alizar costo;  F6:Eliminar ítem;  F8:Cambiar cantidad; F9:Cambiar presentación; " &
    "F12:Transferir venta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GrupCliente
        '
        Me.GrupCliente.BackColor = System.Drawing.Color.Teal
        Me.GrupCliente.Controls.Add(Me.Panel1)
        Me.GrupCliente.Controls.Add(Me.PanelTarifa)
        Me.GrupCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrupCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrupCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupCliente.ForeColor = System.Drawing.Color.White
        Me.GrupCliente.Location = New System.Drawing.Point(261, 2)
        Me.GrupCliente.Name = "GrupCliente"
        Me.GrupCliente.Size = New System.Drawing.Size(440, 85)
        Me.GrupCliente.TabIndex = 40
        Me.GrupCliente.TabStop = False
        Me.GrupCliente.Text = "Información del cliente:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.NomClienteText)
        Me.Panel1.Controls.Add(Me.CedulaTextBox)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(83, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 63)
        Me.Panel1.TabIndex = 57
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(3, 5)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(69, 17)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "C.I ó Ruc:"
        '
        'NomClienteText
        '
        Me.NomClienteText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomClienteText.Location = New System.Drawing.Point(3, 31)
        Me.NomClienteText.Name = "NomClienteText"
        Me.NomClienteText.ReadOnly = True
        Me.NomClienteText.Size = New System.Drawing.Size(262, 23)
        Me.NomClienteText.TabIndex = 1
        Me.NomClienteText.Tag = """"""
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CedulaTextBox.Location = New System.Drawing.Point(78, 3)
        Me.CedulaTextBox.MaxLength = 12
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(187, 23)
        Me.CedulaTextBox.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FindClienteButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DetailPersonButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListPersonButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.deleteClienteButton, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(269, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(85, 63)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'FindClienteButton
        '
        Me.FindClienteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindClienteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_Grin_24
        Me.FindClienteButton.Location = New System.Drawing.Point(0, 0)
        Me.FindClienteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FindClienteButton.Name = "FindClienteButton"
        Me.FindClienteButton.Size = New System.Drawing.Size(42, 31)
        Me.FindClienteButton.TabIndex = 3
        Me.FindClienteButton.UseVisualStyleBackColor = True
        '
        'PanelTarifa
        '
        Me.PanelTarifa.BackColor = System.Drawing.Color.Teal
        Me.PanelTarifa.Controls.Add(Me.RatesTypeLabel)
        Me.PanelTarifa.Controls.Add(Me.TarifaLabel)
        Me.PanelTarifa.Controls.Add(Me.RatesButton)
        Me.PanelTarifa.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTarifa.Location = New System.Drawing.Point(3, 19)
        Me.PanelTarifa.Name = "PanelTarifa"
        Me.PanelTarifa.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelTarifa.Size = New System.Drawing.Size(78, 63)
        Me.PanelTarifa.TabIndex = 56
        '
        'RatesTypeLabel
        '
        Me.RatesTypeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RatesTypeLabel.BackColor = System.Drawing.Color.Aquamarine
        Me.RatesTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatesTypeLabel.ForeColor = System.Drawing.Color.Black
        Me.RatesTypeLabel.Location = New System.Drawing.Point(6, 8)
        Me.RatesTypeLabel.Name = "RatesTypeLabel"
        Me.RatesTypeLabel.Size = New System.Drawing.Size(66, 25)
        Me.RatesTypeLabel.TabIndex = 2
        Me.RatesTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TarifaLabel
        '
        Me.TarifaLabel.AutoSize = True
        Me.TarifaLabel.BackColor = System.Drawing.Color.Aquamarine
        Me.TarifaLabel.Location = New System.Drawing.Point(6, 8)
        Me.TarifaLabel.Name = "TarifaLabel"
        Me.TarifaLabel.Size = New System.Drawing.Size(0, 17)
        Me.TarifaLabel.TabIndex = 1
        '
        'lblItemsTotal
        '
        Me.lblItemsTotal.AutoSize = True
        Me.lblItemsTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblItemsTotal.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblItemsTotal.ForeColor = System.Drawing.Color.White
        Me.lblItemsTotal.Location = New System.Drawing.Point(5, 63)
        Me.lblItemsTotal.Name = "lblItemsTotal"
        Me.lblItemsTotal.Size = New System.Drawing.Size(69, 19)
        Me.lblItemsTotal.TabIndex = 1
        Me.lblItemsTotal.Text = "Items: 0"
        '
        'lblIva12
        '
        Me.lblIva12.AutoSize = True
        Me.lblIva12.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lblIva12.Location = New System.Drawing.Point(5, 34)
        Me.lblIva12.Name = "lblIva12"
        Me.lblIva12.Size = New System.Drawing.Size(114, 23)
        Me.lblIva12.TabIndex = 2
        Me.lblIva12.Text = "Base iva%:0"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(0, 148)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(184, 36)
        Me.lbltotal.TabIndex = 0
        Me.lbltotal.Text = "Total: 0.00 $"
        '
        'lbldescuento
        '
        Me.lbldescuento.AutoSize = True
        Me.lbldescuento.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbldescuento.Location = New System.Drawing.Point(5, 88)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(139, 19)
        Me.lbldescuento.TabIndex = 3
        Me.lbldescuento.Text = "Descuento: 0.00 $"
        '
        'lblIva0
        '
        Me.lblIva0.AutoSize = True
        Me.lblIva0.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lblIva0.Location = New System.Drawing.Point(5, 5)
        Me.lblIva0.Name = "lblIva0"
        Me.lblIva0.Size = New System.Drawing.Size(113, 23)
        Me.lblIva0.TabIndex = 4
        Me.lblIva0.Text = "Base 0%  :0"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblIva.Location = New System.Drawing.Point(150, 63)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(88, 19)
        Me.lblIva.TabIndex = 5
        Me.lblIva.Text = "Iva: 0.00 $"
        '
        'paneTotal
        '
        Me.paneTotal.BackColor = System.Drawing.Color.Black
        Me.paneTotal.Controls.Add(Me.lblOtrosValoresView)
        Me.paneTotal.Controls.Add(Me.lblIva)
        Me.paneTotal.Controls.Add(Me.lblIva0)
        Me.paneTotal.Controls.Add(Me.lbldescuento)
        Me.paneTotal.Controls.Add(Me.lbltotal)
        Me.paneTotal.Controls.Add(Me.lblIva12)
        Me.paneTotal.Controls.Add(Me.lblItemsTotal)
        Me.paneTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneTotal.ForeColor = System.Drawing.Color.White
        Me.paneTotal.Location = New System.Drawing.Point(0, 0)
        Me.paneTotal.Name = "paneTotal"
        Me.paneTotal.Size = New System.Drawing.Size(263, 184)
        Me.paneTotal.TabIndex = 44
        '
        'lblOtrosValoresView
        '
        Me.lblOtrosValoresView.AutoSize = True
        Me.lblOtrosValoresView.BackColor = System.Drawing.Color.Red
        Me.lblOtrosValoresView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtrosValoresView.ForeColor = System.Drawing.Color.Black
        Me.lblOtrosValoresView.Location = New System.Drawing.Point(9, 113)
        Me.lblOtrosValoresView.Name = "lblOtrosValoresView"
        Me.lblOtrosValoresView.Size = New System.Drawing.Size(156, 17)
        Me.lblOtrosValoresView.TabIndex = 6
        Me.lblOtrosValoresView.Text = "Aplicando otros valores"
        Me.lblOtrosValoresView.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'txtAutorizCredito
        '
        Me.txtAutorizCredito.Location = New System.Drawing.Point(502, 572)
        Me.txtAutorizCredito.Name = "txtAutorizCredito"
        Me.txtAutorizCredito.Size = New System.Drawing.Size(56, 20)
        Me.txtAutorizCredito.TabIndex = 45
        Me.txtAutorizCredito.Text = "0"
        Me.txtAutorizCredito.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(400, 60)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(0, 29)
        Me.lblDescription.TabIndex = 47
        '
        'txtMontoMaxito
        '
        Me.txtMontoMaxito.Location = New System.Drawing.Point(438, 571)
        Me.txtMontoMaxito.Name = "txtMontoMaxito"
        Me.txtMontoMaxito.Size = New System.Drawing.Size(56, 20)
        Me.txtMontoMaxito.TabIndex = 45
        Me.txtMontoMaxito.Text = "0"
        Me.txtMontoMaxito.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PaneFacturacion)
        Me.Panel5.Controls.Add(Me.paneTotal)
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1069, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(263, 567)
        Me.Panel5.TabIndex = 50
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.ECommercePlatformView.My.Resources.Resources.Close_32x32
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(0, 527)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(263, 40)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "&Cerrar"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelTerminal
        '
        Me.PanelTerminal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelTerminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTerminal.ContextMenuStrip = Me.ContextMenuCaja
        Me.PanelTerminal.Controls.Add(Me.User_operaLabel)
        Me.PanelTerminal.Controls.Add(Me.OperacionNumLabel)
        Me.PanelTerminal.Controls.Add(Me.labelTerminal)
        Me.PanelTerminal.Controls.Add(Me.PictureBox1)
        Me.PanelTerminal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTerminal.Location = New System.Drawing.Point(145, 2)
        Me.PanelTerminal.Name = "PanelTerminal"
        Me.PanelTerminal.Size = New System.Drawing.Size(116, 85)
        Me.PanelTerminal.TabIndex = 54
        '
        'ContextMenuCaja
        '
        Me.ContextMenuCaja.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalidaDeEfecctivoToolStripMenuItem, Me.SalidaDeChequesToolStripMenuItem, Me.VerEstadoToolStripMenuItem})
        Me.ContextMenuCaja.Name = "ContextMenuCaja"
        Me.ContextMenuCaja.Size = New System.Drawing.Size(188, 118)
        '
        'SalidaDeEfecctivoToolStripMenuItem
        '
        Me.SalidaDeEfecctivoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Atm_32
        Me.SalidaDeEfecctivoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalidaDeEfecctivoToolStripMenuItem.Name = "SalidaDeEfecctivoToolStripMenuItem"
        Me.SalidaDeEfecctivoToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.SalidaDeEfecctivoToolStripMenuItem.Text = "Salida de efectivo"
        Me.SalidaDeEfecctivoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalidaDeChequesToolStripMenuItem
        '
        Me.SalidaDeChequesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Atm_Check_32
        Me.SalidaDeChequesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalidaDeChequesToolStripMenuItem.Name = "SalidaDeChequesToolStripMenuItem"
        Me.SalidaDeChequesToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.SalidaDeChequesToolStripMenuItem.Text = "Salida de cheques "
        '
        'VerEstadoToolStripMenuItem
        '
        Me.VerEstadoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_24
        Me.VerEstadoToolStripMenuItem.Name = "VerEstadoToolStripMenuItem"
        Me.VerEstadoToolStripMenuItem.Size = New System.Drawing.Size(187, 38)
        Me.VerEstadoToolStripMenuItem.Text = "Ver estado"
        '
        'User_operaLabel
        '
        Me.User_operaLabel.AutoSize = True
        Me.User_operaLabel.ContextMenuStrip = Me.ContextMenuCaja
        Me.User_operaLabel.Location = New System.Drawing.Point(1, 54)
        Me.User_operaLabel.Name = "User_operaLabel"
        Me.User_operaLabel.Size = New System.Drawing.Size(32, 13)
        Me.User_operaLabel.TabIndex = 3
        Me.User_operaLabel.Text = "Para:"
        '
        'OperacionNumLabel
        '
        Me.OperacionNumLabel.AutoSize = True
        Me.OperacionNumLabel.ForeColor = System.Drawing.Color.Red
        Me.OperacionNumLabel.Location = New System.Drawing.Point(39, 16)
        Me.OperacionNumLabel.Name = "OperacionNumLabel"
        Me.OperacionNumLabel.Size = New System.Drawing.Size(59, 13)
        Me.OperacionNumLabel.TabIndex = 2
        Me.OperacionNumLabel.Text = "Operación:"
        '
        'labelTerminal
        '
        Me.labelTerminal.AutoSize = True
        Me.labelTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTerminal.Location = New System.Drawing.Point(30, 1)
        Me.labelTerminal.Name = "labelTerminal"
        Me.labelTerminal.Size = New System.Drawing.Size(67, 17)
        Me.labelTerminal.TabIndex = 0
        Me.labelTerminal.Text = "Terminal:"
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuCaja
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Resources.Caja_regidter
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 48)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.creditoButton, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnOtroValor, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.UltDocumentButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.findDocumentButton, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(701, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 85)
        Me.TableLayoutPanel2.TabIndex = 55
        '
        'creditoButton
        '
        Me.creditoButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.finDocument
        Me.creditoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.creditoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creditoButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Credid_48
        Me.creditoButton.Location = New System.Drawing.Point(129, 0)
        Me.creditoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.creditoButton.Name = "creditoButton"
        Me.creditoButton.Size = New System.Drawing.Size(43, 42)
        Me.creditoButton.TabIndex = 55
        Me.creditoButton.UseVisualStyleBackColor = True
        '
        'findDocumentButton
        '
        Me.findDocumentButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.finDocument
        Me.findDocumentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findDocumentButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.findDocumentButton.Location = New System.Drawing.Point(86, 0)
        Me.findDocumentButton.Margin = New System.Windows.Forms.Padding(0)
        Me.findDocumentButton.Name = "findDocumentButton"
        Me.findDocumentButton.Size = New System.Drawing.Size(43, 42)
        Me.findDocumentButton.TabIndex = 54
        Me.findDocumentButton.UseVisualStyleBackColor = True
        '
        'ContextMenuOtroValor
        '
        Me.ContextMenuOtroValor.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.ContextMenuOtroValor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemUnDolar, Me.ToolStripMenuItemDosDolar, Me.ToolStripMenuItemTresDolar, Me.ToolStripMenuItemCuatroDolra, Me.ToolStripMenuItemCincoDolar, Me.ToolStripMenuItemOtraValor, Me.ToolStripMenuItemNinguno})
        Me.ContextMenuOtroValor.Name = "ContextMenuOtroValor"
        Me.ContextMenuOtroValor.Size = New System.Drawing.Size(128, 158)
        '
        'ToolStripMenuItemUnDolar
        '
        Me.ToolStripMenuItemUnDolar.Name = "ToolStripMenuItemUnDolar"
        Me.ToolStripMenuItemUnDolar.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemUnDolar.Text = "$ 1"
        '
        'ToolStripMenuItemDosDolar
        '
        Me.ToolStripMenuItemDosDolar.Name = "ToolStripMenuItemDosDolar"
        Me.ToolStripMenuItemDosDolar.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemDosDolar.Text = "$ 2"
        '
        'ToolStripMenuItemTresDolar
        '
        Me.ToolStripMenuItemTresDolar.Name = "ToolStripMenuItemTresDolar"
        Me.ToolStripMenuItemTresDolar.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemTresDolar.Text = "$ 3"
        '
        'ToolStripMenuItemCuatroDolra
        '
        Me.ToolStripMenuItemCuatroDolra.Name = "ToolStripMenuItemCuatroDolra"
        Me.ToolStripMenuItemCuatroDolra.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemCuatroDolra.Text = "$ 4"
        '
        'ToolStripMenuItemCincoDolar
        '
        Me.ToolStripMenuItemCincoDolar.Name = "ToolStripMenuItemCincoDolar"
        Me.ToolStripMenuItemCincoDolar.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemCincoDolar.Text = "$ 5"
        '
        'ToolStripMenuItemOtraValor
        '
        Me.ToolStripMenuItemOtraValor.Name = "ToolStripMenuItemOtraValor"
        Me.ToolStripMenuItemOtraValor.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemOtraValor.Text = "Otro valor"
        '
        'ToolStripMenuItemNinguno
        '
        Me.ToolStripMenuItemNinguno.Name = "ToolStripMenuItemNinguno"
        Me.ToolStripMenuItemNinguno.Size = New System.Drawing.Size(127, 22)
        Me.ToolStripMenuItemNinguno.Text = "Ninguno"
        '
        'PanelHerramientas
        '
        Me.PanelHerramientas.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelHerramientas.Controls.Add(Me.GrupCliente)
        Me.PanelHerramientas.Controls.Add(Me.PanelTerminal)
        Me.PanelHerramientas.Controls.Add(Me.panelBodega)
        Me.PanelHerramientas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.PanelHerramientas.Name = "PanelHerramientas"
        Me.PanelHerramientas.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelHerramientas.Size = New System.Drawing.Size(1069, 89)
        Me.PanelHerramientas.TabIndex = 56
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1332, 567)
        Me.Controls.Add(Me.paneDetail)
        Me.Controls.Add(Me.PanelHerramientas)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtMontoMaxito)
        Me.Controls.Add(Me.txtAutorizCredito)
        Me.Controls.Add(Me.txtLabel)
        Me.KeyPreview = True
        Me.Name = "frmVentas"
        Me.Text = "VENTAS"
        Me.panelBodega.ResumeLayout(False)
        Me.panelBodega.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuBodega.ResumeLayout(False)
        Me.PaneFacturacion.ResumeLayout(False)
        Me.PaneFacturacion.PerformLayout()
        Me.TableFactur.ResumeLayout(False)
        Me.TableFactur.PerformLayout()
        Me.PanefinalizFactur.ResumeLayout(False)
        Me.PanefinalizFactur.PerformLayout()
        Me.ContextMenuDeleteRates.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.paneDetail.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelfoot.ResumeLayout(False)
        Me.Panelfoot.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelHerramineItem.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panelultimo.ResumeLayout(False)
        Me.Panelultimo.PerformLayout()
        Me.GrupCliente.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelTarifa.ResumeLayout(False)
        Me.PanelTarifa.PerformLayout()
        Me.paneTotal.ResumeLayout(False)
        Me.paneTotal.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.PanelTerminal.ResumeLayout(False)
        Me.PanelTerminal.PerformLayout()
        Me.ContextMenuCaja.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ContextMenuOtroValor.ResumeLayout(False)
        Me.PanelHerramientas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnActualiza As System.Windows.Forms.Button
    Friend WithEvents btnPacketProdcut As System.Windows.Forms.Button
    Friend WithEvents btnEditCant As System.Windows.Forms.Button
    Friend WithEvents txtLabel As System.Windows.Forms.Label
    Friend WithEvents ProformaButton As System.Windows.Forms.Button
    Friend WithEvents NotaVentaButton As System.Windows.Forms.Button
    Friend WithEvents FacturaButton As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuCantidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents paneDetail As System.Windows.Forms.Panel
    Friend WithEvents GrupCliente As System.Windows.Forms.GroupBox
    Friend WithEvents NomClienteText As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtExploret As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNoexiste As System.Windows.Forms.Label
    Friend WithEvents lblcmdInferior As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDow As Button
    Friend WithEvents lblItemsTotal As System.Windows.Forms.Label
    Friend WithEvents lblIva12 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lbldescuento As Label
    Friend WithEvents lblIva0 As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents paneTotal As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteItems As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents lblBodega As Label
    Friend WithEvents txtAutorizCredito As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtMontoMaxito As TextBox
    Friend WithEvents PaneFacturacion As System.Windows.Forms.Panel
    Friend WithEvents btnUpda_NumFactur As System.Windows.Forms.Button
    Friend WithEvents txtNumFactur As System.Windows.Forms.TextBox
    Friend WithEvents btnPago As System.Windows.Forms.Button
    Friend WithEvents btnEdd_NumFactur As System.Windows.Forms.Button
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents panelBodega As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOtroValor As System.Windows.Forms.Button
    Friend WithEvents lblOtrosValoresView As System.Windows.Forms.Label
    Friend WithEvents PanefinalizFactur As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVuelto As System.Windows.Forms.Label
    Friend WithEvents btnCancelFactur As System.Windows.Forms.Button
    Friend WithEvents UltDocumentButton As Button
    Friend WithEvents FindClienteButton As System.Windows.Forms.Button
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetailPersonButton As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListPersonButton As System.Windows.Forms.Button
    Friend WithEvents PanelTerminal As System.Windows.Forms.Panel
    Friend WithEvents User_operaLabel As Label
    Friend WithEvents OperacionNumLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelTerminal As Label
    Friend WithEvents deleteClienteButton As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ContextMenuOtroValor As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemUnDolar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDosDolar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemTresDolar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemCuatroDolra As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemCincoDolar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemOtraValor As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemNinguno As ToolStripMenuItem
    Friend WithEvents findDocumentButton As Button
    Friend WithEvents creditoButton As Button
    Friend WithEvents UltimoIngresoLabel As Label
    Friend WithEvents pedidoButton As Button
    Friend WithEvents PanelHerramientas As Panel
    Friend WithEvents PanelTarifa As Panel
    Friend WithEvents TarifaLabel As Label
    Friend WithEvents RatesButton As Button
    Friend WithEvents RatesTypeLabel As Label
    Friend WithEvents ContextMenuDeleteRates As ContextMenuStrip
    Friend WithEvents DeleteRatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelView As Panel
    Friend WithEvents Panelfoot As Panel
    Friend WithEvents PanelHerramineItem As Panel
    Friend WithEvents Panelultimo As Panel
    Friend WithEvents ContextMenuCaja As ContextMenuStrip
    Friend WithEvents VerEstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaDeEfecctivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaDeChequesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicarTarifaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuBodega As ContextMenuStrip
    Friend WithEvents CambioBodegaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableFactur As Panel
    Friend WithEvents F11Label As Label
    Friend WithEvents F12Label As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtFindInAdd As MultiControls.Controls.TextBoxButton
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.FastDataListView
    Friend WithEvents IdPresent2Clm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CodProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PresentationPrintClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CuantityClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents UnitPriceClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents TotalPriceClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IdProducto2Clm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PartialPriceClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DiscountClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents RatesClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents IvaPercentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PriceVatClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ImageList1 As ImageList
End Class
