<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListFacturPurchases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListFacturPurchases))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDatepicker2 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.HastaLabel = New System.Windows.Forms.Label()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.ProveedorLabel = New System.Windows.Forms.Label()
        Me.FindProviderButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton9 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton10 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.panelView = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.DataListView1 = New BrightIdeasSoftware.DataListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Paneldata = New System.Windows.Forms.Panel()
        Me.FastDataListView1 = New BrightIdeasSoftware.FastDataListView()
        Me.idFacturaCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Razon_socialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.fechaCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_BodegaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.base00IvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.base12IvaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ivaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.TotalPedidoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelView.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Paneldata.SuspendLayout()
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuDatepicker2)
        Me.Panel1.Controls.Add(Me.HastaLabel)
        Me.Panel1.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel1.Controls.Add(Me.ProveedorLabel)
        Me.Panel1.Controls.Add(Me.FindProviderButton)
        Me.Panel1.Controls.Add(Me.FindButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 15, 2)
        Me.Panel1.Size = New System.Drawing.Size(999, 40)
        Me.Panel1.TabIndex = 0
        '
        'BunifuDatepicker2
        '
        Me.BunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker2.BorderRadius = 0
        Me.BunifuDatepicker2.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker2.FormatCustom = Nothing
        Me.BunifuDatepicker2.Location = New System.Drawing.Point(761, 7)
        Me.BunifuDatepicker2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuDatepicker2.Name = "BunifuDatepicker2"
        Me.BunifuDatepicker2.Size = New System.Drawing.Size(160, 24)
        Me.BunifuDatepicker2.TabIndex = 9
        Me.BunifuDatepicker2.Value = New Date(2018, 2, 27, 17, 37, 17, 333)
        Me.BunifuDatepicker2.Visible = False
        '
        'HastaLabel
        '
        Me.HastaLabel.AutoSize = True
        Me.HastaLabel.Location = New System.Drawing.Point(705, 12)
        Me.HastaLabel.Name = "HastaLabel"
        Me.HastaLabel.Size = New System.Drawing.Size(49, 17)
        Me.HastaLabel.TabIndex = 8
        Me.HastaLabel.Text = "Hasta:"
        Me.HastaLabel.Visible = False
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(540, 6)
        Me.BunifuDatepicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(158, 24)
        Me.BunifuDatepicker1.TabIndex = 9
        Me.BunifuDatepicker1.Value = New Date(2018, 2, 27, 17, 37, 17, 333)
        Me.BunifuDatepicker1.Visible = False
        '
        'ProveedorLabel
        '
        Me.ProveedorLabel.AutoSize = True
        Me.ProveedorLabel.Location = New System.Drawing.Point(483, 13)
        Me.ProveedorLabel.Name = "ProveedorLabel"
        Me.ProveedorLabel.Size = New System.Drawing.Size(53, 17)
        Me.ProveedorLabel.TabIndex = 8
        Me.ProveedorLabel.Text = "Desde:"
        Me.ProveedorLabel.Visible = False
        '
        'FindProviderButton
        '
        Me.FindProviderButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.ProviderDetail_48_Gif
        Me.FindProviderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FindProviderButton.Location = New System.Drawing.Point(432, 1)
        Me.FindProviderButton.Name = "FindProviderButton"
        Me.FindProviderButton.Size = New System.Drawing.Size(45, 37)
        Me.FindProviderButton.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.FindProviderButton, "Buscar proveedor")
        Me.FindProviderButton.UseVisualStyleBackColor = True
        Me.FindProviderButton.Visible = False
        '
        'FindButton
        '
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.fin_deudor_32
        Me.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindButton.Location = New System.Drawing.Point(939, 2)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(45, 36)
        Me.FindButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.FindButton, "Buscar")
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Opciones de busqueda:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ultimas compras (150)", "Proveedor", "Fecha"})
        Me.ComboBox1.Location = New System.Drawing.Point(174, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Ultimas compras (150)"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(129, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton2, "Configurar precio de venta")
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(90, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(39, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton1, "Eliminar compra")
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(627, 2)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton3.TabIndex = 3
        Me.BunifuImageButton3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton3, "Ver detalle")
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton4.ErrorImage = CType(resources.GetObject("BunifuImageButton4.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(46, 2)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton4.TabIndex = 4
        Me.BunifuImageButton4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton4, "Seleccionar todo")
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton5.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(2, 2)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton5.TabIndex = 5
        Me.BunifuImageButton5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton5, "Copiar")
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton6.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(2, 2)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton6.TabIndex = 3
        Me.BunifuImageButton6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton6, "Regresar al listado principal")
        Me.BunifuImageButton6.Zoom = 10
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(173, 2)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton7.TabIndex = 2
        Me.BunifuImageButton7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton7, "Cambiar candidad")
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton8.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton8.Image = CType(resources.GetObject("BunifuImageButton8.Image"), System.Drawing.Image)
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(134, 2)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(39, 35)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton8.TabIndex = 1
        Me.BunifuImageButton8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton8, "Cambiar producto")
        Me.BunifuImageButton8.Zoom = 10
        '
        'BunifuImageButton9
        '
        Me.BunifuImageButton9.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton9.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton9.ErrorImage = CType(resources.GetObject("BunifuImageButton9.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton9.Image = CType(resources.GetObject("BunifuImageButton9.Image"), System.Drawing.Image)
        Me.BunifuImageButton9.ImageActive = Nothing
        Me.BunifuImageButton9.Location = New System.Drawing.Point(90, 2)
        Me.BunifuImageButton9.Name = "BunifuImageButton9"
        Me.BunifuImageButton9.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton9.TabIndex = 4
        Me.BunifuImageButton9.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton9, "Seleccionar todo")
        Me.BunifuImageButton9.Zoom = 10
        '
        'BunifuImageButton10
        '
        Me.BunifuImageButton10.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton10.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton10.Image = CType(resources.GetObject("BunifuImageButton10.Image"), System.Drawing.Image)
        Me.BunifuImageButton10.ImageActive = Nothing
        Me.BunifuImageButton10.Location = New System.Drawing.Point(46, 2)
        Me.BunifuImageButton10.Name = "BunifuImageButton10"
        Me.BunifuImageButton10.Size = New System.Drawing.Size(44, 35)
        Me.BunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton10.TabIndex = 5
        Me.BunifuImageButton10.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton10, "Copiar")
        Me.BunifuImageButton10.Zoom = 10
        '
        'panelView
        '
        Me.panelView.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panelView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelView.Controls.Add(Me.PanelDetail)
        Me.panelView.Controls.Add(Me.Splitter1)
        Me.panelView.Controls.Add(Me.Paneldata)
        Me.panelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelView.Location = New System.Drawing.Point(5, 45)
        Me.panelView.Name = "panelView"
        Me.panelView.Padding = New System.Windows.Forms.Padding(2, 2, 2, 10)
        Me.panelView.Size = New System.Drawing.Size(999, 416)
        Me.panelView.TabIndex = 1
        '
        'PanelDetail
        '
        Me.PanelDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelDetail.Controls.Add(Me.DataListView1)
        Me.PanelDetail.Controls.Add(Me.Panel2)
        Me.PanelDetail.Controls.Add(Me.Panel5)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetail.Location = New System.Drawing.Point(697, 2)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelDetail.Size = New System.Drawing.Size(298, 402)
        Me.PanelDetail.TabIndex = 2
        '
        'DataListView1
        '
        Me.DataListView1.DataSource = Nothing
        Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataListView1.FullRowSelect = True
        Me.DataListView1.IncludeColumnHeadersInCopy = True
        Me.DataListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.DataListView1.Location = New System.Drawing.Point(3, 44)
        Me.DataListView1.Name = "DataListView1"
        Me.DataListView1.ShowGroups = False
        Me.DataListView1.Size = New System.Drawing.Size(292, 297)
        Me.DataListView1.TabIndex = 2
        Me.DataListView1.UseAlternatingBackColors = True
        Me.DataListView1.UseCompatibleStateImageBehavior = False
        Me.DataListView1.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BunifuImageButton7)
        Me.Panel2.Controls.Add(Me.BunifuImageButton8)
        Me.Panel2.Controls.Add(Me.BunifuImageButton9)
        Me.Panel2.Controls.Add(Me.BunifuImageButton10)
        Me.Panel2.Controls.Add(Me.BunifuImageButton6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(292, 41)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 341)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 58)
        Me.Panel5.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total item: 0"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Splitter1.Location = New System.Drawing.Point(692, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 402)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Paneldata
        '
        Me.Paneldata.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Paneldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paneldata.Controls.Add(Me.FastDataListView1)
        Me.Paneldata.Controls.Add(Me.Panel4)
        Me.Paneldata.Controls.Add(Me.Panel3)
        Me.Paneldata.Dock = System.Windows.Forms.DockStyle.Left
        Me.Paneldata.Location = New System.Drawing.Point(2, 2)
        Me.Paneldata.Name = "Paneldata"
        Me.Paneldata.Size = New System.Drawing.Size(690, 402)
        Me.Paneldata.TabIndex = 0
        '
        'FastDataListView1
        '
        Me.FastDataListView1.AllColumns.Add(Me.idFacturaCompraClm)
        Me.FastDataListView1.AllColumns.Add(Me.Razon_socialClm)
        Me.FastDataListView1.AllColumns.Add(Me.fechaCompraClm)
        Me.FastDataListView1.AllColumns.Add(Me.Nom_BodegaClm)
        Me.FastDataListView1.AllColumns.Add(Me.base00IvaClm)
        Me.FastDataListView1.AllColumns.Add(Me.base12IvaClm)
        Me.FastDataListView1.AllColumns.Add(Me.ivaClm)
        Me.FastDataListView1.AllColumns.Add(Me.TotalPedidoClm)
        Me.FastDataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idFacturaCompraClm, Me.Razon_socialClm, Me.fechaCompraClm, Me.Nom_BodegaClm, Me.base00IvaClm, Me.base12IvaClm, Me.ivaClm, Me.TotalPedidoClm})
        Me.FastDataListView1.DataSource = Nothing
        Me.FastDataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastDataListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FastDataListView1.FullRowSelect = True
        Me.FastDataListView1.GridLines = True
        Me.FastDataListView1.HeaderUsesThemes = True
        Me.FastDataListView1.IncludeColumnHeadersInCopy = True
        Me.FastDataListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.FastDataListView1.Location = New System.Drawing.Point(0, 41)
        Me.FastDataListView1.Name = "FastDataListView1"
        Me.FastDataListView1.ShowGroups = False
        Me.FastDataListView1.Size = New System.Drawing.Size(688, 301)
        Me.FastDataListView1.TabIndex = 1
        Me.FastDataListView1.UseAlternatingBackColors = True
        Me.FastDataListView1.UseCompatibleStateImageBehavior = False
        Me.FastDataListView1.View = System.Windows.Forms.View.Details
        Me.FastDataListView1.VirtualMode = True
        '
        'idFacturaCompraClm
        '
        Me.idFacturaCompraClm.AspectName = "idFacturaCompra"
        Me.idFacturaCompraClm.Text = "Id Interno"
        Me.idFacturaCompraClm.Width = 120
        '
        'Razon_socialClm
        '
        Me.Razon_socialClm.AspectName = "Razon_social"
        Me.Razon_socialClm.Text = "Proveedor"
        Me.Razon_socialClm.Width = 250
        '
        'fechaCompraClm
        '
        Me.fechaCompraClm.AspectName = "fechaCompra"
        Me.fechaCompraClm.AspectToStringFormat = "{0:d}"
        Me.fechaCompraClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fechaCompraClm.Text = "Fecha compra"
        Me.fechaCompraClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fechaCompraClm.Width = 120
        '
        'Nom_BodegaClm
        '
        Me.Nom_BodegaClm.AspectName = "Nom_Bodega"
        Me.Nom_BodegaClm.Text = "Bodega o local"
        Me.Nom_BodegaClm.Width = 120
        '
        'base00IvaClm
        '
        Me.base00IvaClm.AspectName = "base00Iva"
        Me.base00IvaClm.AspectToStringFormat = "{0:C2}"
        Me.base00IvaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.base00IvaClm.Text = "Exento iva"
        Me.base00IvaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.base00IvaClm.Width = 100
        '
        'base12IvaClm
        '
        Me.base12IvaClm.AspectName = "base12Iva"
        Me.base12IvaClm.AspectToStringFormat = "{0:C2}"
        Me.base12IvaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.base12IvaClm.Text = "Base iva"
        Me.base12IvaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ivaClm
        '
        Me.ivaClm.AspectName = "iva"
        Me.ivaClm.AspectToStringFormat = "{0:C2}"
        Me.ivaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ivaClm.Text = "Iva"
        Me.ivaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalPedidoClm
        '
        Me.TotalPedidoClm.AspectName = "TotalPedido"
        Me.TotalPedidoClm.AspectToStringFormat = "{0:C2}"
        Me.TotalPedidoClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPedidoClm.Text = "Total"
        Me.TotalPedidoClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPedidoClm.Width = 100
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BunifuImageButton3)
        Me.Panel4.Controls.Add(Me.BunifuImageButton2)
        Me.Panel4.Controls.Add(Me.BunifuImageButton1)
        Me.Panel4.Controls.Add(Me.BunifuImageButton4)
        Me.Panel4.Controls.Add(Me.BunifuImageButton5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2, 2, 15, 2)
        Me.Panel4.Size = New System.Drawing.Size(688, 41)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 342)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(688, 58)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total item: 0"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmListFacturPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 466)
        Me.Controls.Add(Me.panelView)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmListFacturPurchases"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Listado de compras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelView.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Paneldata.ResumeLayout(False)
        CType(Me.FastDataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FindButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents panelView As Panel
    Friend WithEvents Paneldata As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents FastDataListView1 As BrightIdeasSoftware.FastDataListView
    Friend WithEvents idFacturaCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Razon_socialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents fechaCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_BodegaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents base00IvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents base12IvaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ivaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents TotalPedidoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents FindProviderButton As Button
    Friend WithEvents ProveedorLabel As Label
    Friend WithEvents BunifuDatepicker2 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents HastaLabel As Label
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton9 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton10 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
