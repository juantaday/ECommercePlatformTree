<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDateExpir
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelGraf = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelViewControlGrafic = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.addNewDateExpirButton = New System.Windows.Forms.Button()
        Me.GetDataFillButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.Panel()
        Me.PanelListControl = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelBarrControl = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFilter = New System.Windows.Forms.Panel()
        Me.ListViewProducto = New BrightIdeasSoftware.FastDataListView()
        Me.idProductoClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FindTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.deletefilterButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Paneldata = New System.Windows.Forms.Panel()
        Me.ListViewSelectProduct = New BrightIdeasSoftware.FastDataListView()
        Me.Nom_Bodegaclm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClm2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.stockClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.UndClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.DateExpirateClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.idFacturaCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Nom_ComercialLabel = New System.Windows.Forms.Label()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelGraf.SuspendLayout()
        Me.PanelViewControlGrafic.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelListControl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarrControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFilter.SuspendLayout()
        CType(Me.ListViewProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Paneldata.SuspendLayout()
        CType(Me.ListViewSelectProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administración de fecha de expiración"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LabelDescription)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(57, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(852, 106)
        Me.Panel2.TabIndex = 1
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(16, 8)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(0, 17)
        Me.LabelDescription.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Splitter1.Location = New System.Drawing.Point(57, 43)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 231)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'PanelGraf
        '
        Me.PanelGraf.BackColor = System.Drawing.Color.White
        Me.PanelGraf.Controls.Add(Me.Panel4)
        Me.PanelGraf.Controls.Add(Me.PanelViewControlGrafic)
        Me.PanelGraf.Location = New System.Drawing.Point(62, 71)
        Me.PanelGraf.Name = "PanelGraf"
        Me.PanelGraf.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelGraf.Size = New System.Drawing.Size(146, 176)
        Me.PanelGraf.TabIndex = 4
        Me.PanelGraf.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 132)
        Me.Panel4.TabIndex = 0
        '
        'PanelViewControlGrafic
        '
        Me.PanelViewControlGrafic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelViewControlGrafic.Controls.Add(Me.Label2)
        Me.PanelViewControlGrafic.Controls.Add(Me.ListBodegaComboBox)
        Me.PanelViewControlGrafic.Controls.Add(Me.UpdateButton)
        Me.PanelViewControlGrafic.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelViewControlGrafic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelViewControlGrafic.Location = New System.Drawing.Point(2, 2)
        Me.PanelViewControlGrafic.Name = "PanelViewControlGrafic"
        Me.PanelViewControlGrafic.Size = New System.Drawing.Size(142, 40)
        Me.PanelViewControlGrafic.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bodega o local:"
        '
        'ListBodegaComboBox
        '
        Me.ListBodegaComboBox.FormattingEnabled = True
        Me.ListBodegaComboBox.Location = New System.Drawing.Point(217, 8)
        Me.ListBodegaComboBox.Name = "ListBodegaComboBox"
        Me.ListBodegaComboBox.Size = New System.Drawing.Size(259, 24)
        Me.ListBodegaComboBox.TabIndex = 1
        '
        'UpdateButton
        '
        Me.UpdateButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.UpdateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.refresh_16
        Me.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateButton.Location = New System.Drawing.Point(0, 0)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(99, 38)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Actualizar"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'addNewDateExpirButton
        '
        Me.addNewDateExpirButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.addNewDateExpirButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.addNewDateExpirButton.Location = New System.Drawing.Point(2, 2)
        Me.addNewDateExpirButton.Name = "addNewDateExpirButton"
        Me.addNewDateExpirButton.Size = New System.Drawing.Size(43, 32)
        Me.addNewDateExpirButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.addNewDateExpirButton, "Agregar nueva fecha de caducidad")
        Me.addNewDateExpirButton.UseVisualStyleBackColor = True
        '
        'GetDataFillButton
        '
        Me.GetDataFillButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.GetDataFillButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_Grin_24
        Me.GetDataFillButton.Location = New System.Drawing.Point(488, 2)
        Me.GetDataFillButton.Name = "GetDataFillButton"
        Me.GetDataFillButton.Size = New System.Drawing.Size(39, 32)
        Me.GetDataFillButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.GetDataFillButton, "Buscar entre las fechas")
        Me.GetDataFillButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.Location = New System.Drawing.Point(45, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(43, 32)
        Me.DeleteButton.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Agregar nueva fecha de caducidad")
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Controls.Add(Me.PanelListControl)
        Me.MenuStrip1.Controls.Add(Me.PanelBarrControl)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 43)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(52, 337)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PanelListControl
        '
        Me.PanelListControl.Controls.Add(Me.Label4)
        Me.PanelListControl.Controls.Add(Me.PictureBox2)
        Me.PanelListControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelListControl.Location = New System.Drawing.Point(0, 54)
        Me.PanelListControl.Name = "PanelListControl"
        Me.PanelListControl.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelListControl.Size = New System.Drawing.Size(52, 54)
        Me.PanelListControl.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Lista de datos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.ECommercePlatformView.My.Resources.Resources.ViewList_48
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelBarrControl
        '
        Me.PanelBarrControl.Controls.Add(Me.Label3)
        Me.PanelBarrControl.Controls.Add(Me.PictureBox1)
        Me.PanelBarrControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarrControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarrControl.Name = "PanelBarrControl"
        Me.PanelBarrControl.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelBarrControl.Size = New System.Drawing.Size(52, 54)
        Me.PanelBarrControl.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(51, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Análices grafico"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Resources.ViewBarr_48
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelFilter
        '
        Me.PanelFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelFilter.Controls.Add(Me.ListViewProducto)
        Me.PanelFilter.Controls.Add(Me.Panel3)
        Me.PanelFilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelFilter.Location = New System.Drawing.Point(832, 43)
        Me.PanelFilter.Name = "PanelFilter"
        Me.PanelFilter.Padding = New System.Windows.Forms.Padding(20, 10, 0, 0)
        Me.PanelFilter.Size = New System.Drawing.Size(77, 231)
        Me.PanelFilter.TabIndex = 6
        '
        'ListViewProducto
        '
        Me.ListViewProducto.AllColumns.Add(Me.idProductoClm)
        Me.ListViewProducto.AllColumns.Add(Me.Nom_ComercialClm)
        Me.ListViewProducto.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ListViewProducto.AutoGenerateColumns = False
        Me.ListViewProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ListViewProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idProductoClm, Me.Nom_ComercialClm})
        Me.ListViewProducto.DataSource = Nothing
        Me.ListViewProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewProducto.ForeColor = System.Drawing.Color.White
        Me.ListViewProducto.FullRowSelect = True
        Me.ListViewProducto.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListViewProducto.HeaderWordWrap = True
        Me.ListViewProducto.HideSelection = False
        Me.ListViewProducto.Location = New System.Drawing.Point(20, 43)
        Me.ListViewProducto.Name = "ListViewProducto"
        Me.ListViewProducto.ShowGroups = False
        Me.ListViewProducto.Size = New System.Drawing.Size(57, 188)
        Me.ListViewProducto.TabIndex = 3
        Me.ListViewProducto.UnfocusedHighlightBackgroundColor = System.Drawing.Color.Black
        Me.ListViewProducto.UnfocusedHighlightForegroundColor = System.Drawing.Color.White
        Me.ListViewProducto.UseCompatibleStateImageBehavior = False
        Me.ListViewProducto.View = System.Windows.Forms.View.Details
        Me.ListViewProducto.VirtualMode = True
        '
        'idProductoClm
        '
        Me.idProductoClm.AspectName = "idProducto"
        Me.idProductoClm.IsTileViewColumn = True
        Me.idProductoClm.IsVisible = False
        Me.idProductoClm.Text = "ID"
        Me.idProductoClm.Width = 0
        '
        'Nom_ComercialClm
        '
        Me.Nom_ComercialClm.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClm.IsTileViewColumn = True
        Me.Nom_ComercialClm.Text = "Producto"
        Me.Nom_ComercialClm.Width = 500
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.FindTextBox1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.deletefilterButton)
        Me.Panel3.Controls.Add(Me.FindButton)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 2, 2, 2)
        Me.Panel3.Size = New System.Drawing.Size(57, 33)
        Me.Panel3.TabIndex = 2
        '
        'FindTextBox1
        '
        Me.FindTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FindTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindTextBox1.Location = New System.Drawing.Point(7, 7)
        Me.FindTextBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.FindTextBox1.Name = "FindTextBox1"
        Me.FindTextBox1.Size = New System.Drawing.Size(0, 19)
        Me.FindTextBox1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(7, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(0, 5)
        Me.Panel5.TabIndex = 3
        '
        'deletefilterButton
        '
        Me.deletefilterButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.deletefilterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.deletefilterButton.Location = New System.Drawing.Point(0, 2)
        Me.deletefilterButton.Name = "deletefilterButton"
        Me.deletefilterButton.Size = New System.Drawing.Size(19, 29)
        Me.deletefilterButton.TabIndex = 2
        Me.deletefilterButton.UseVisualStyleBackColor = False
        Me.deletefilterButton.Visible = False
        '
        'FindButton
        '
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_Grin_24
        Me.FindButton.Location = New System.Drawing.Point(19, 2)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(36, 29)
        Me.FindButton.TabIndex = 1
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(5, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(2, 29)
        Me.Panel6.TabIndex = 4
        '
        'Paneldata
        '
        Me.Paneldata.BackColor = System.Drawing.Color.White
        Me.Paneldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paneldata.Controls.Add(Me.ListViewSelectProduct)
        Me.Paneldata.Controls.Add(Me.Panel7)
        Me.Paneldata.Controls.Add(Me.Panel8)
        Me.Paneldata.Location = New System.Drawing.Point(282, 53)
        Me.Paneldata.Name = "Paneldata"
        Me.Paneldata.Padding = New System.Windows.Forms.Padding(2)
        Me.Paneldata.Size = New System.Drawing.Size(535, 193)
        Me.Paneldata.TabIndex = 7
        Me.Paneldata.Visible = False
        '
        'ListViewSelectProduct
        '
        Me.ListViewSelectProduct.AllColumns.Add(Me.Nom_Bodegaclm)
        Me.ListViewSelectProduct.AllColumns.Add(Me.Nom_ComercialClm2)
        Me.ListViewSelectProduct.AllColumns.Add(Me.stockClm)
        Me.ListViewSelectProduct.AllColumns.Add(Me.UndClm)
        Me.ListViewSelectProduct.AllColumns.Add(Me.DateExpirateClm)
        Me.ListViewSelectProduct.AllColumns.Add(Me.idFacturaCompraClm)
        Me.ListViewSelectProduct.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListViewSelectProduct.AutoGenerateColumns = False
        Me.ListViewSelectProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom_Bodegaclm, Me.Nom_ComercialClm2, Me.stockClm, Me.UndClm, Me.DateExpirateClm, Me.idFacturaCompraClm})
        Me.ListViewSelectProduct.DataSource = Nothing
        Me.ListViewSelectProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewSelectProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ListViewSelectProduct.FullRowSelect = True
        Me.ListViewSelectProduct.GridLines = True
        Me.ListViewSelectProduct.Location = New System.Drawing.Point(2, 71)
        Me.ListViewSelectProduct.Name = "ListViewSelectProduct"
        Me.ListViewSelectProduct.ShowGroups = False
        Me.ListViewSelectProduct.Size = New System.Drawing.Size(529, 118)
        Me.ListViewSelectProduct.TabIndex = 0
        Me.ListViewSelectProduct.UseAlternatingBackColors = True
        Me.ListViewSelectProduct.UseCompatibleStateImageBehavior = False
        Me.ListViewSelectProduct.View = System.Windows.Forms.View.Details
        Me.ListViewSelectProduct.VirtualMode = True
        '
        'Nom_Bodegaclm
        '
        Me.Nom_Bodegaclm.AspectName = "Nom_Bodega"
        Me.Nom_Bodegaclm.Text = "Bodega o local"
        Me.Nom_Bodegaclm.Width = 150
        '
        'Nom_ComercialClm2
        '
        Me.Nom_ComercialClm2.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClm2.Text = "Producto"
        Me.Nom_ComercialClm2.Width = 200
        '
        'stockClm
        '
        Me.stockClm.AspectName = "stock"
        Me.stockClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.stockClm.Text = "Stock"
        Me.stockClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.stockClm.Width = 100
        '
        'UndClm
        '
        Me.UndClm.AspectName = "Und"
        Me.UndClm.Text = "Medida stock"
        Me.UndClm.Width = 200
        '
        'DateExpirateClm
        '
        Me.DateExpirateClm.AspectName = "DateExpirate"
        Me.DateExpirateClm.AspectToStringFormat = "{0:d}"
        Me.DateExpirateClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateExpirateClm.Text = "Fecha de Expiración"
        Me.DateExpirateClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateExpirateClm.Width = 120
        '
        'idFacturaCompraClm
        '
        Me.idFacturaCompraClm.AspectName = "idFacturaCompra"
        Me.idFacturaCompraClm.Text = "Orden de compra"
        Me.idFacturaCompraClm.Width = 120
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DeleteButton)
        Me.Panel7.Controls.Add(Me.GetDataFillButton)
        Me.Panel7.Controls.Add(Me.addNewDateExpirButton)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.DateTimePicker2)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.DateTimePicker1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(2, 35)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(529, 36)
        Me.Panel7.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hasta:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(345, 11)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Desde:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 10)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Nom_ComercialLabel)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.Panel8.Size = New System.Drawing.Size(529, 33)
        Me.Panel8.TabIndex = 2
        '
        'Nom_ComercialLabel
        '
        Me.Nom_ComercialLabel.AutoSize = True
        Me.Nom_ComercialLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Nom_ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_ComercialLabel.Location = New System.Drawing.Point(10, 5)
        Me.Nom_ComercialLabel.Name = "Nom_ComercialLabel"
        Me.Nom_ComercialLabel.Size = New System.Drawing.Size(116, 24)
        Me.Nom_ComercialLabel.TabIndex = 0
        Me.Nom_ComercialLabel.Tag = "0"
        Me.Nom_ComercialLabel.Text = "PRODUCTO"
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(827, 43)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(5, 231)
        Me.Splitter2.TabIndex = 8
        Me.Splitter2.TabStop = False
        '
        'frmAdminDateExpir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 385)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Paneldata)
        Me.Controls.Add(Me.PanelGraf)
        Me.Controls.Add(Me.PanelFilter)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAdminDateExpir"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Adminstrando fecha de caducidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelGraf.ResumeLayout(False)
        Me.PanelViewControlGrafic.ResumeLayout(False)
        Me.PanelViewControlGrafic.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.PanelListControl.ResumeLayout(False)
        Me.PanelListControl.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarrControl.ResumeLayout(False)
        Me.PanelBarrControl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFilter.ResumeLayout(False)
        CType(Me.ListViewProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Paneldata.ResumeLayout(False)
        CType(Me.ListViewSelectProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelGraf As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelDescription As Label
    Friend WithEvents MenuStrip1 As Panel
    Friend WithEvents PanelBarrControl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelListControl As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelFilter As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FindTextBox1 As TextBox
    Friend WithEvents FindButton As Button
    Friend WithEvents deletefilterButton As Button
    Friend WithEvents ListViewProducto As BrightIdeasSoftware.FastDataListView
    Friend WithEvents idProductoClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Paneldata As Panel
    Friend WithEvents ListViewSelectProduct As BrightIdeasSoftware.FastDataListView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents addNewDateExpirButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Nom_ComercialLabel As Label
    Friend WithEvents Nom_Bodegaclm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents stockClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents UndClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents DateExpirateClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents idFacturaCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelViewControlGrafic As Panel
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents GetDataFillButton As Button
    Friend WithEvents Nom_ComercialClm2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents DeleteButton As Button
End Class
