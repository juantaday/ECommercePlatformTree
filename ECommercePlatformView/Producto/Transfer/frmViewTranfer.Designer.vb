<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewTranfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewTranfer))
        Me.PanelList = New System.Windows.Forms.Panel()
        Me.ObjectListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.IdTransferClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DateTransferClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.NameTranferClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idBodegaOrigenClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idbodegaDestinoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalPrecioCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalPrecioVentaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel3 = New System.Windows.Forms.Panel()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.textBoxFilterSimple = New MultiControls.Controls.TextBoxButton()
        Me.BunifuThinButton21 = New System.Windows.Forms.Button()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelTools = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFindInAdd = New MultiControls.Controls.TextBoxButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.NewCombinedButton = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Nom_ComercialLabel = New System.Windows.Forms.Label()
        Me.ArrowBackButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DestinoComboBox = New System.Windows.Forms.ComboBox()
        Me.OrigenComboBox = New System.Windows.Forms.ComboBox()
        Me.totalVentaLabel = New System.Windows.Forms.Label()
        Me.totalCompraLabel = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.NameTranferTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.ListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.IdPresentClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CodigoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentacionPrint2Clm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.CountClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioComora2Clm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PrecioVenta2Clm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.FastDataListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.BunifuGradientPanel4 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.totalVentaDetailsLabel = New System.Windows.Forms.Label()
        Me.totalCompraDetailsLabel = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel5 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelList.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelList
        '
        Me.PanelList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelList.Controls.Add(Me.ObjectListView1)
        Me.PanelList.Controls.Add(Me.Panel3)
        Me.PanelList.Controls.Add(Me.BunifuGradientPanel3)
        Me.PanelList.Location = New System.Drawing.Point(9, 411)
        Me.PanelList.Name = "PanelList"
        Me.PanelList.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.PanelList.Size = New System.Drawing.Size(810, 111)
        Me.PanelList.TabIndex = 3
        '
        'ObjectListView1
        '
        Me.ObjectListView1.AllColumns.Add(Me.IdTransferClm)
        Me.ObjectListView1.AllColumns.Add(Me.DateTransferClm)
        Me.ObjectListView1.AllColumns.Add(Me.NameTranferClm)
        Me.ObjectListView1.AllColumns.Add(Me.idBodegaOrigenClm)
        Me.ObjectListView1.AllColumns.Add(Me.idbodegaDestinoClm)
        Me.ObjectListView1.AllColumns.Add(Me.totalPrecioCompraClm)
        Me.ObjectListView1.AllColumns.Add(Me.totalPrecioVentaClm)
        Me.ObjectListView1.AllowColumnReorder = True
        Me.ObjectListView1.AllowDrop = True
        Me.ObjectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ObjectListView1.AutoGenerateColumns = False
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdTransferClm, Me.DateTransferClm, Me.NameTranferClm, Me.idBodegaOrigenClm, Me.idbodegaDestinoClm, Me.totalPrecioCompraClm, Me.totalPrecioVentaClm})
        Me.ObjectListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ObjectListView1.DataSource = Nothing
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
        Me.ObjectListView1.Size = New System.Drawing.Size(788, 18)
        Me.ObjectListView1.TabIndex = 0
        Me.ObjectListView1.UseAlternatingBackColors = True
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.UseFilterIndicator = True
        Me.ObjectListView1.UseFiltering = True
        Me.ObjectListView1.UseHotItem = True
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        Me.ObjectListView1.VirtualMode = True
        '
        'IdTransferClm
        '
        Me.IdTransferClm.AspectName = "trans.IdTransfer"
        Me.IdTransferClm.IsVisible = False
        Me.IdTransferClm.Text = "Num transferencia"
        Me.IdTransferClm.ToolTipText = "Se puede ver las 200 ultimas trasferencias.."
        Me.IdTransferClm.Width = 80
        '
        'DateTransferClm
        '
        Me.DateTransferClm.AspectName = "trans.DateTransfer"
        Me.DateTransferClm.AspectToStringFormat = "{0:dd/MM/yyyy HH:mm:ss t}"
        Me.DateTransferClm.Text = "Fecha"
        Me.DateTransferClm.ToolTipText = "Fecha de transferencia"
        Me.DateTransferClm.Width = 120
        '
        'NameTranferClm
        '
        Me.NameTranferClm.AspectName = "trans.NameTranfer"
        Me.NameTranferClm.Text = "Motivo"
        Me.NameTranferClm.ToolTipText = "Motivo de transferencia"
        Me.NameTranferClm.Width = 300
        '
        'idBodegaOrigenClm
        '
        Me.idBodegaOrigenClm.AspectName = "origen"
        Me.idBodegaOrigenClm.Text = "Desde"
        Me.idBodegaOrigenClm.Width = 150
        '
        'idbodegaDestinoClm
        '
        Me.idbodegaDestinoClm.AspectName = "destino"
        Me.idbodegaDestinoClm.Text = "Destino"
        Me.idbodegaDestinoClm.Width = 150
        '
        'totalPrecioCompraClm
        '
        Me.totalPrecioCompraClm.AspectName = "trans.totalPrecioCompra"
        Me.totalPrecioCompraClm.AspectToStringFormat = "{0:C5}"
        Me.totalPrecioCompraClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalPrecioCompraClm.Text = "Precio Compra"
        Me.totalPrecioCompraClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalPrecioCompraClm.Width = 120
        '
        'totalPrecioVentaClm
        '
        Me.totalPrecioVentaClm.AspectName = "trans.totalPrecioVenta"
        Me.totalPrecioVentaClm.AspectToStringFormat = "{0:C5}"
        Me.totalPrecioVentaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalPrecioVentaClm.Text = "Precio Venta"
        Me.totalPrecioVentaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalPrecioVentaClm.Width = 120
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(788, 34)
        Me.Panel3.TabIndex = 2
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel3.Controls.Add(Me.groupBox9)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton23)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton24)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuThinButton25)
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(10, 0)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(788, 47)
        Me.BunifuGradientPanel3.TabIndex = 1
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.textBoxFilterSimple)
        Me.groupBox9.Dock = System.Windows.Forms.DockStyle.Right
        Me.groupBox9.Location = New System.Drawing.Point(494, 2)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(224, 41)
        Me.groupBox9.TabIndex = 18
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Filter"
        '
        'textBoxFilterSimple
        '
        Me.textBoxFilterSimple.ButtonImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.textBoxFilterSimple.Location = New System.Drawing.Point(7, 13)
        Me.textBoxFilterSimple.Name = "textBoxFilterSimple"
        Me.textBoxFilterSimple.Size = New System.Drawing.Size(209, 20)
        Me.textBoxFilterSimple.TabIndex = 0
        Me.textBoxFilterSimple.VisibleButton = False
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(718, 2)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(68, 41)
        Me.BunifuThinButton21.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BunifuThinButton21, "Ver detalle de transferencia...")
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
        Me.BunifuThinButton23.ButtonText = "Imprimir"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(243, 2)
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
        Me.BunifuThinButton24.ButtonText = "Cambiar motivo"
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
        Me.BunifuThinButton24.Size = New System.Drawing.Size(144, 41)
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
        Me.PanelTools.Location = New System.Drawing.Point(2, 2)
        Me.PanelTools.Name = "PanelTools"
        Me.PanelTools.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.PanelTools.Quality = 20
        Me.PanelTools.Size = New System.Drawing.Size(882, 26)
        Me.PanelTools.TabIndex = 2
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel1.Controls.Add(Me.GroupBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.ArrowBackButton)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(4, 4)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(795, 76)
        Me.BunifuGradientPanel1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFindInAdd)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(611, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 70)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'txtFindInAdd
        '
        Me.txtFindInAdd.ButtonImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.txtFindInAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFindInAdd.Location = New System.Drawing.Point(6, 19)
        Me.txtFindInAdd.Name = "txtFindInAdd"
        Me.txtFindInAdd.Size = New System.Drawing.Size(167, 23)
        Me.txtFindInAdd.TabIndex = 0
        Me.txtFindInAdd.VisibleButton = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.UpdateButton)
        Me.Panel5.Controls.Add(Me.DeleteButton)
        Me.Panel5.Controls.Add(Me.NewCombinedButton)
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(69, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(536, 70)
        Me.Panel5.TabIndex = 10
        '
        'UpdateButton
        '
        Me.UpdateButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.UpdateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.UpdateTable_32x32
        Me.UpdateButton.Location = New System.Drawing.Point(102, 28)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(37, 42)
        Me.UpdateButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.UpdateButton, "Actualizar precios de compra y venta..")
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.Location = New System.Drawing.Point(65, 28)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(37, 42)
        Me.DeleteButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Eliminar item")
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'NewCombinedButton
        '
        Me.NewCombinedButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewCombinedButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.NewCombinedButton.Location = New System.Drawing.Point(28, 28)
        Me.NewCombinedButton.Name = "NewCombinedButton"
        Me.NewCombinedButton.Size = New System.Drawing.Size(37, 42)
        Me.NewCombinedButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NewCombinedButton, "Agregar nuevo item")
        Me.NewCombinedButton.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 28)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(28, 42)
        Me.Panel9.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Nom_ComercialLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 28)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(34, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 28)
        Me.Panel4.TabIndex = 6
        '
        'Nom_ComercialLabel
        '
        Me.Nom_ComercialLabel.AutoSize = True
        Me.Nom_ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_ComercialLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nom_ComercialLabel.Location = New System.Drawing.Point(2, 5)
        Me.Nom_ComercialLabel.Name = "Nom_ComercialLabel"
        Me.Nom_ComercialLabel.Size = New System.Drawing.Size(276, 17)
        Me.Nom_ComercialLabel.TabIndex = 0
        Me.Nom_ComercialLabel.Text = "Agregando productos para tranferir.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ArrowBackButton
        '
        Me.ArrowBackButton.BackColor = System.Drawing.Color.Transparent
        Me.ArrowBackButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Arrow_Back_48
        Me.ArrowBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ArrowBackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ArrowBackButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ArrowBackButton.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrowBackButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.ArrowBackButton.Location = New System.Drawing.Point(2, 2)
        Me.ArrowBackButton.Margin = New System.Windows.Forms.Padding(5)
        Me.ArrowBackButton.Name = "ArrowBackButton"
        Me.ArrowBackButton.Size = New System.Drawing.Size(67, 70)
        Me.ArrowBackButton.TabIndex = 5
        Me.ArrowBackButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.totalVentaLabel)
        Me.Panel2.Controls.Add(Me.totalCompraLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(4, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 71)
        Me.Panel2.TabIndex = 8
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.DestinoComboBox)
        Me.Panel10.Controls.Add(Me.OrigenComboBox)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(500, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(295, 71)
        Me.Panel10.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Destino:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Origen:"
        '
        'DestinoComboBox
        '
        Me.DestinoComboBox.FormattingEnabled = True
        Me.DestinoComboBox.Location = New System.Drawing.Point(55, 35)
        Me.DestinoComboBox.Name = "DestinoComboBox"
        Me.DestinoComboBox.Size = New System.Drawing.Size(226, 21)
        Me.DestinoComboBox.TabIndex = 2
        '
        'OrigenComboBox
        '
        Me.OrigenComboBox.FormattingEnabled = True
        Me.OrigenComboBox.Location = New System.Drawing.Point(55, 7)
        Me.OrigenComboBox.Name = "OrigenComboBox"
        Me.OrigenComboBox.Size = New System.Drawing.Size(226, 21)
        Me.OrigenComboBox.TabIndex = 2
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
        Me.totalCompraLabel.Size = New System.Drawing.Size(206, 20)
        Me.totalCompraLabel.TabIndex = 0
        Me.totalCompraLabel.Text = "Total al precio compra: 0"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel2.Controls.Add(Me.NameTranferTextBox)
        Me.BunifuGradientPanel2.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel2.Controls.Add(Me.Ok_Button)
        Me.BunifuGradientPanel2.Controls.Add(Me.Cancel_Button)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(4, 186)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.BunifuGradientPanel2.Quality = 20
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(795, 38)
        Me.BunifuGradientPanel2.TabIndex = 7
        '
        'NameTranferTextBox
        '
        Me.NameTranferTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTranferTextBox.Location = New System.Drawing.Point(170, 4)
        Me.NameTranferTextBox.Name = "NameTranferTextBox"
        Me.NameTranferTextBox.Size = New System.Drawing.Size(444, 23)
        Me.NameTranferTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Motivo de transferencia:"
        '
        'Ok_Button
        '
        Me.Ok_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.ForeColor = System.Drawing.Color.White
        Me.Ok_Button.Location = New System.Drawing.Point(630, 1)
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
        Me.Cancel_Button.Location = New System.Drawing.Point(701, 1)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(91, 34)
        Me.Cancel_Button.TabIndex = 0
        Me.Cancel_Button.Text = "Cancelar"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'PanelAdd
        '
        Me.PanelAdd.Controls.Add(Me.ListView1)
        Me.PanelAdd.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelAdd.Controls.Add(Me.Panel2)
        Me.PanelAdd.Controls.Add(Me.BunifuGradientPanel2)
        Me.PanelAdd.Location = New System.Drawing.Point(5, 34)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Padding = New System.Windows.Forms.Padding(4)
        Me.PanelAdd.Size = New System.Drawing.Size(803, 228)
        Me.PanelAdd.TabIndex = 9
        '
        'ListView1
        '
        Me.ListView1.AllColumns.Add(Me.IdPresentClm)
        Me.ListView1.AllColumns.Add(Me.idProductoClm)
        Me.ListView1.AllColumns.Add(Me.CodigoClm)
        Me.ListView1.AllColumns.Add(Me.ProductoClm)
        Me.ListView1.AllColumns.Add(Me.PresentacionPrint2Clm)
        Me.ListView1.AllColumns.Add(Me.CountClm)
        Me.ListView1.AllColumns.Add(Me.precioComora2Clm)
        Me.ListView1.AllColumns.Add(Me.PrecioVenta2Clm)
        Me.ListView1.AllowDrop = True
        Me.ListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick
        Me.ListView1.CellEditEnterChangesRows = True
        Me.ListView1.CellEditTabChangesRows = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPresentClm, Me.CodigoClm, Me.ProductoClm, Me.PresentacionPrint2Clm, Me.CountClm, Me.precioComora2Clm, Me.PrecioVenta2Clm})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.DataSource = Nothing
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.EmptyListMsg = "No hay informacion"
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderMaximumHeight = 50
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HighlightBackgroundColor = System.Drawing.Color.Navy
        Me.ListView1.HighlightForegroundColor = System.Drawing.Color.White
        Me.ListView1.IncludeColumnHeadersInCopy = True
        Me.ListView1.Location = New System.Drawing.Point(4, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.ListView1.ShowCommandMenuOnRightClick = True
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowImagesOnSubItems = True
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(795, 35)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UnfocusedHighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListView1.UnfocusedHighlightForegroundColor = System.Drawing.Color.Black
        Me.ListView1.UseAlternatingBackColors = True
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseFilterIndicator = True
        Me.ListView1.UseFiltering = True
        Me.ListView1.UseHotItem = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.VirtualMode = True
        '
        'IdPresentClm
        '
        Me.IdPresentClm.AspectName = "idPresent"
        Me.IdPresentClm.IsEditable = False
        Me.IdPresentClm.IsVisible = False
        Me.IdPresentClm.Text = "idPresent"
        Me.IdPresentClm.Width = 0
        '
        'idProductoClm
        '
        Me.idProductoClm.AspectName = "IdProducto"
        Me.idProductoClm.DisplayIndex = 1
        Me.idProductoClm.IsEditable = False
        Me.idProductoClm.IsVisible = False
        Me.idProductoClm.Text = "idProducto"
        Me.idProductoClm.Width = 0
        '
        'CodigoClm
        '
        Me.CodigoClm.AspectName = "codProducto"
        Me.CodigoClm.IsEditable = False
        Me.CodigoClm.Text = "Código"
        Me.CodigoClm.Width = 80
        '
        'ProductoClm
        '
        Me.ProductoClm.AspectName = "Nom_Comercial"
        Me.ProductoClm.IsEditable = False
        Me.ProductoClm.Text = "Producto"
        Me.ProductoClm.Width = 260
        '
        'PresentacionPrint2Clm
        '
        Me.PresentacionPrint2Clm.AspectName = "PresentacionPrint"
        Me.PresentacionPrint2Clm.IsEditable = False
        Me.PresentacionPrint2Clm.Text = "Presentación"
        Me.PresentacionPrint2Clm.Width = 150
        '
        'CountClm
        '
        Me.CountClm.AspectName = "count_Tranfer"
        Me.CountClm.AspectToStringFormat = "{0:N2}"
        Me.CountClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountClm.Text = "Cantidad"
        Me.CountClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CountClm.Width = 100
        '
        'precioComora2Clm
        '
        Me.precioComora2Clm.AspectName = "PrecioCompra"
        Me.precioComora2Clm.AspectToStringFormat = "{0:C5}"
        Me.precioComora2Clm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioComora2Clm.IsEditable = False
        Me.precioComora2Clm.Text = "Precio Compra"
        Me.precioComora2Clm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioComora2Clm.ToolTipText = "Al precio de compora unitario"
        Me.precioComora2Clm.Width = 110
        '
        'PrecioVenta2Clm
        '
        Me.PrecioVenta2Clm.AspectName = "PrecioVenta"
        Me.PrecioVenta2Clm.AspectToStringFormat = "{0:C5}"
        Me.PrecioVenta2Clm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioVenta2Clm.IsEditable = False
        Me.PrecioVenta2Clm.Text = "Precio venta"
        Me.PrecioVenta2Clm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioVenta2Clm.ToolTipText = "Al precio de venta unitario"
        Me.PrecioVenta2Clm.Width = 150
        '
        'PanelDetail
        '
        Me.PanelDetail.Controls.Add(Me.FastDataListView1)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel4)
        Me.PanelDetail.Controls.Add(Me.Panel8)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel5)
        Me.PanelDetail.Location = New System.Drawing.Point(12, 286)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelDetail.Size = New System.Drawing.Size(826, 115)
        Me.PanelDetail.TabIndex = 11
        '
        'FastDataListView1
        '
        Me.FastDataListView1.AllowColumnReorder = True
        Me.FastDataListView1.AllowDrop = True
        Me.FastDataListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FastDataListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.FastDataListView1.DataSource = Nothing
        Me.FastDataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastDataListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastDataListView1.FullRowSelect = True
        Me.FastDataListView1.GridLines = True
        Me.FastDataListView1.HasCollapsibleGroups = False
        Me.FastDataListView1.HeaderWordWrap = True
        Me.FastDataListView1.HideSelection = False
        Me.FastDataListView1.IncludeColumnHeadersInCopy = True
        Me.FastDataListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.FastDataListView1.Location = New System.Drawing.Point(3, 57)
        Me.FastDataListView1.Name = "FastDataListView1"
        Me.FastDataListView1.OwnerDraw = True
        Me.FastDataListView1.ShowGroups = False
        Me.FastDataListView1.Size = New System.Drawing.Size(820, 0)
        Me.FastDataListView1.TabIndex = 9
        Me.FastDataListView1.UseAlternatingBackColors = True
        Me.FastDataListView1.UseCompatibleStateImageBehavior = False
        Me.FastDataListView1.UseFilterIndicator = True
        Me.FastDataListView1.UseFiltering = True
        Me.FastDataListView1.UseHotItem = True
        Me.FastDataListView1.View = System.Windows.Forms.View.Details
        Me.FastDataListView1.VirtualMode = True
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel4.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel4.Controls.Add(Me.Button4)
        Me.BunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Olive
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(3, 3)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Padding = New System.Windows.Forms.Padding(2, 0, 0, 2)
        Me.BunifuGradientPanel4.Quality = 20
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(820, 54)
        Me.BunifuGradientPanel4.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(72, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle de la transferencia..."
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Arrow_Back_48
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button4.Location = New System.Drawing.Point(2, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 50)
        Me.Button4.TabIndex = 5
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.totalVentaDetailsLabel)
        Me.Panel8.Controls.Add(Me.totalCompraDetailsLabel)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 37)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(820, 55)
        Me.Panel8.TabIndex = 8
        '
        'totalVentaDetailsLabel
        '
        Me.totalVentaDetailsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalVentaDetailsLabel.AutoSize = True
        Me.totalVentaDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalVentaDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalVentaDetailsLabel.Location = New System.Drawing.Point(5, 29)
        Me.totalVentaDetailsLabel.Name = "totalVentaDetailsLabel"
        Me.totalVentaDetailsLabel.Size = New System.Drawing.Size(250, 20)
        Me.totalVentaDetailsLabel.TabIndex = 1
        Me.totalVentaDetailsLabel.Text = "Total al precio venta normal: 0"
        '
        'totalCompraDetailsLabel
        '
        Me.totalCompraDetailsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalCompraDetailsLabel.AutoSize = True
        Me.totalCompraDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCompraDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalCompraDetailsLabel.Location = New System.Drawing.Point(5, 2)
        Me.totalCompraDetailsLabel.Name = "totalCompraDetailsLabel"
        Me.totalCompraDetailsLabel.Size = New System.Drawing.Size(187, 20)
        Me.totalCompraDetailsLabel.TabIndex = 0
        Me.totalCompraDetailsLabel.Text = "Total precio compra: 0"
        '
        'BunifuGradientPanel5
        '
        Me.BunifuGradientPanel5.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(3, 92)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.BunifuGradientPanel5.Quality = 20
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(820, 20)
        Me.BunifuGradientPanel5.TabIndex = 7
        '
        'PanelView
        '
        Me.PanelView.Location = New System.Drawing.Point(5, 539)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelView.Size = New System.Drawing.Size(833, 17)
        Me.PanelView.TabIndex = 12
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmViewTranfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 561)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.PanelDetail)
        Me.Controls.Add(Me.PanelAdd)
        Me.Controls.Add(Me.PanelList)
        Me.Controls.Add(Me.PanelTools)
        Me.Name = "frmViewTranfer"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Administracion de transferencia de productos...."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelList.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.PanelAdd.ResumeLayout(False)
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.BunifuGradientPanel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelList As System.Windows.Forms.Panel
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.FastDataListView
    Friend WithEvents IdTransferClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DateTransferClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents NameTranferClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalPrecioCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalPrecioVentaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuGradientPanel3 As New System.Windows.Forms.Panel
    Private WithEvents groupBox9 As GroupBox
    Private WithEvents textBoxFilterSimple As New MultiControls.Controls.TextBoxButton
    Friend WithEvents BunifuThinButton21 As Button
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PanelTools As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Windows.Forms.Panel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewCombinedButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nom_ComercialLabel As Label
    Friend WithEvents ArrowBackButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents totalVentaLabel As Label
    Friend WithEvents totalCompraLabel As Label
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Ok_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents BunifuGradientPanel4 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents totalVentaDetailsLabel As Label
    Friend WithEvents totalCompraDetailsLabel As Label
    Friend WithEvents BunifuGradientPanel5 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ListView1 As BrightIdeasSoftware.FastDataListView
    Friend WithEvents IdPresentClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CodigoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CountClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioComora2Clm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PrecioVenta2Clm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PanelView As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PresentacionPrint2Clm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents txtFindInAdd As MultiControls.Controls.TextBoxButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents OrigenComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DestinoComboBox As ComboBox
    Friend WithEvents NameTranferTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents idBodegaOrigenClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idbodegaDestinoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents FastDataListView1 As BrightIdeasSoftware.FastDataListView
End Class
