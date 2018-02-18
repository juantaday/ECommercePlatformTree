<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd_Zonas
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
        Me.Panelpei = New System.Windows.Forms.Panel()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageProvincias = New System.Windows.Forms.TabPage()
        Me.PanelViewProvince = New System.Windows.Forms.Panel()
        Me.dtGridViewProvincia = New System.Windows.Forms.DataGridView()
        Me.butoonViewCanton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuProvincia = New System.Windows.Forms.FlowLayoutPanel()
        Me.Add_NewProvinLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Edit_ProvincinLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Delet_ProvinceLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TabPageCanton = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtGridCanton = New System.Windows.Forms.DataGridView()
        Me.butoonViewParroquia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.new_cantonLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.UpdateCanton_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Delete_CantonLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LisProvincia_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.canton_des_Label = New System.Windows.Forms.Label()
        Me.TabPageParroq = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtGridViewParroquia = New System.Windows.Forms.DataGridView()
        Me.ButtonViewSector = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.New_ParroquiaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Update_ParroquiaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DeleteParroquiaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.List_CantonesLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Parroquia_desc_Label = New System.Windows.Forms.Label()
        Me.TabPageSector = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtGridViewSector = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.new_sectorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Update_sectorLinkLabe = New System.Windows.Forms.LinkLabel()
        Me.Delete_sectorLinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.List_ParroquiaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Sector_des_label = New System.Windows.Forms.Label()
        Me.PanePais = New System.Windows.Forms.Panel()
        Me.Pais_DeleteButton = New System.Windows.Forms.Button()
        Me.Edd_PaisButton = New System.Windows.Forms.Button()
        Me.Pais_newButton = New System.Windows.Forms.Button()
        Me.PaisComboBox = New System.Windows.Forms.ComboBox()
        Me._CancelButton = New System.Windows.Forms.Button()
        Me.Panelpei.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageProvincias.SuspendLayout()
        Me.PanelViewProvince.SuspendLayout()
        CType(Me.dtGridViewProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuProvincia.SuspendLayout()
        Me.TabPageCanton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridCanton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabPageParroq.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtGridViewParroquia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.TabPageSector.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtGridViewSector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.PanePais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelpei
        '
        Me.Panelpei.Controls.Add(Me.CancelButton)
        Me.Panelpei.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelpei.Location = New System.Drawing.Point(0, 441)
        Me.Panelpei.Name = "Panelpei"
        Me.Panelpei.Size = New System.Drawing.Size(520, 32)
        Me.Panelpei.TabIndex = 0
        '
        'CancelButton
        '
        Me._CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me._CancelButton.Location = New System.Drawing.Point(414, 0)
        Me._CancelButton.Name = "CancelButton"
        Me._CancelButton.Size = New System.Drawing.Size(106, 32)
        Me._CancelButton.TabIndex = 0
        Me._CancelButton.Text = "Cancelar"
        Me._CancelButton.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageProvincias)
        Me.TabControl.Controls.Add(Me.TabPageCanton)
        Me.TabControl.Controls.Add(Me.TabPageParroq)
        Me.TabControl.Controls.Add(Me.TabPageSector)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Enabled = False
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 53)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(520, 388)
        Me.TabControl.TabIndex = 1
        '
        'TabPageProvincias
        '
        Me.TabPageProvincias.Controls.Add(Me.PanelViewProvince)
        Me.TabPageProvincias.Controls.Add(Me.MenuProvincia)
        Me.TabPageProvincias.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProvincias.Name = "TabPageProvincias"
        Me.TabPageProvincias.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageProvincias.Size = New System.Drawing.Size(512, 359)
        Me.TabPageProvincias.TabIndex = 0
        Me.TabPageProvincias.Text = "     Provincias"
        Me.TabPageProvincias.UseVisualStyleBackColor = True
        '
        'PanelViewProvince
        '
        Me.PanelViewProvince.Controls.Add(Me.dtGridViewProvincia)
        Me.PanelViewProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewProvince.Location = New System.Drawing.Point(3, 65)
        Me.PanelViewProvince.Name = "PanelViewProvince"
        Me.PanelViewProvince.Size = New System.Drawing.Size(506, 291)
        Me.PanelViewProvince.TabIndex = 1
        '
        'dtGridViewProvincia
        '
        Me.dtGridViewProvincia.AllowUserToAddRows = False
        Me.dtGridViewProvincia.AllowUserToDeleteRows = False
        Me.dtGridViewProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridViewProvincia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.butoonViewCanton})
        Me.dtGridViewProvincia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridViewProvincia.Location = New System.Drawing.Point(0, 0)
        Me.dtGridViewProvincia.Name = "dtGridViewProvincia"
        Me.dtGridViewProvincia.ReadOnly = True
        Me.dtGridViewProvincia.Size = New System.Drawing.Size(506, 291)
        Me.dtGridViewProvincia.TabIndex = 0
        '
        'butoonViewCanton
        '
        Me.butoonViewCanton.Frozen = True
        Me.butoonViewCanton.HeaderText = "Ver cantones"
        Me.butoonViewCanton.Name = "butoonViewCanton"
        Me.butoonViewCanton.ReadOnly = True
        '
        'MenuProvincia
        '
        Me.MenuProvincia.Controls.Add(Me.Add_NewProvinLinkLabel)
        Me.MenuProvincia.Controls.Add(Me.Edit_ProvincinLinkLabel)
        Me.MenuProvincia.Controls.Add(Me.Delet_ProvinceLinkLabel)
        Me.MenuProvincia.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuProvincia.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MenuProvincia.Location = New System.Drawing.Point(3, 3)
        Me.MenuProvincia.Name = "MenuProvincia"
        Me.MenuProvincia.Size = New System.Drawing.Size(506, 62)
        Me.MenuProvincia.TabIndex = 0
        '
        'Add_NewProvinLinkLabel
        '
        Me.Add_NewProvinLinkLabel.AutoSize = True
        Me.Add_NewProvinLinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.Add_NewProvinLinkLabel.Name = "Add_NewProvinLinkLabel"
        Me.Add_NewProvinLinkLabel.Size = New System.Drawing.Size(167, 17)
        Me.Add_NewProvinLinkLabel.TabIndex = 0
        Me.Add_NewProvinLinkLabel.TabStop = True
        Me.Add_NewProvinLinkLabel.Text = "Agregar nueva provincia."
        '
        'Edit_ProvincinLinkLabel
        '
        Me.Edit_ProvincinLinkLabel.AutoSize = True
        Me.Edit_ProvincinLinkLabel.Enabled = False
        Me.Edit_ProvincinLinkLabel.Location = New System.Drawing.Point(3, 17)
        Me.Edit_ProvincinLinkLabel.Name = "Edit_ProvincinLinkLabel"
        Me.Edit_ProvincinLinkLabel.Size = New System.Drawing.Size(69, 17)
        Me.Edit_ProvincinLinkLabel.TabIndex = 1
        Me.Edit_ProvincinLinkLabel.TabStop = True
        Me.Edit_ProvincinLinkLabel.Text = "Modificar."
        '
        'Delet_ProvinceLinkLabel
        '
        Me.Delet_ProvinceLinkLabel.AutoSize = True
        Me.Delet_ProvinceLinkLabel.Enabled = False
        Me.Delet_ProvinceLinkLabel.Location = New System.Drawing.Point(3, 34)
        Me.Delet_ProvinceLinkLabel.Name = "Delet_ProvinceLinkLabel"
        Me.Delet_ProvinceLinkLabel.Size = New System.Drawing.Size(58, 17)
        Me.Delet_ProvinceLinkLabel.TabIndex = 2
        Me.Delet_ProvinceLinkLabel.TabStop = True
        Me.Delet_ProvinceLinkLabel.Text = "Eliminar"
        '
        'TabPageCanton
        '
        Me.TabPageCanton.Controls.Add(Me.Panel1)
        Me.TabPageCanton.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPageCanton.Controls.Add(Me.canton_des_Label)
        Me.TabPageCanton.Location = New System.Drawing.Point(4, 25)
        Me.TabPageCanton.Name = "TabPageCanton"
        Me.TabPageCanton.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCanton.Size = New System.Drawing.Size(512, 359)
        Me.TabPageCanton.TabIndex = 1
        Me.TabPageCanton.Text = "    Cantones.."
        Me.TabPageCanton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtGridCanton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 274)
        Me.Panel1.TabIndex = 3
        '
        'dtGridCanton
        '
        Me.dtGridCanton.AllowUserToAddRows = False
        Me.dtGridCanton.AllowUserToDeleteRows = False
        Me.dtGridCanton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridCanton.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.butoonViewParroquia})
        Me.dtGridCanton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridCanton.Location = New System.Drawing.Point(0, 0)
        Me.dtGridCanton.Name = "dtGridCanton"
        Me.dtGridCanton.ReadOnly = True
        Me.dtGridCanton.Size = New System.Drawing.Size(506, 274)
        Me.dtGridCanton.TabIndex = 1
        '
        'butoonViewParroquia
        '
        Me.butoonViewParroquia.Frozen = True
        Me.butoonViewParroquia.HeaderText = "Ver parroquias"
        Me.butoonViewParroquia.Name = "butoonViewParroquia"
        Me.butoonViewParroquia.ReadOnly = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.new_cantonLinkLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.UpdateCanton_LinkLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.Delete_CantonLinkLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.LisProvincia_LinkLabel)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 23)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(506, 59)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'new_cantonLinkLabel
        '
        Me.new_cantonLinkLabel.AutoSize = True
        Me.new_cantonLinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.new_cantonLinkLabel.Name = "new_cantonLinkLabel"
        Me.new_cantonLinkLabel.Size = New System.Drawing.Size(153, 17)
        Me.new_cantonLinkLabel.TabIndex = 0
        Me.new_cantonLinkLabel.TabStop = True
        Me.new_cantonLinkLabel.Text = "Agregar nuevo cantón."
        '
        'UpdateCanton_LinkLabel
        '
        Me.UpdateCanton_LinkLabel.AutoSize = True
        Me.UpdateCanton_LinkLabel.Enabled = False
        Me.UpdateCanton_LinkLabel.Location = New System.Drawing.Point(3, 17)
        Me.UpdateCanton_LinkLabel.Name = "UpdateCanton_LinkLabel"
        Me.UpdateCanton_LinkLabel.Size = New System.Drawing.Size(69, 17)
        Me.UpdateCanton_LinkLabel.TabIndex = 1
        Me.UpdateCanton_LinkLabel.TabStop = True
        Me.UpdateCanton_LinkLabel.Text = "Modificar."
        '
        'Delete_CantonLinkLabel
        '
        Me.Delete_CantonLinkLabel.AutoSize = True
        Me.Delete_CantonLinkLabel.Enabled = False
        Me.Delete_CantonLinkLabel.Location = New System.Drawing.Point(3, 34)
        Me.Delete_CantonLinkLabel.Name = "Delete_CantonLinkLabel"
        Me.Delete_CantonLinkLabel.Size = New System.Drawing.Size(58, 17)
        Me.Delete_CantonLinkLabel.TabIndex = 2
        Me.Delete_CantonLinkLabel.TabStop = True
        Me.Delete_CantonLinkLabel.Text = "Eliminar"
        '
        'LisProvincia_LinkLabel
        '
        Me.LisProvincia_LinkLabel.AutoSize = True
        Me.LisProvincia_LinkLabel.Location = New System.Drawing.Point(162, 0)
        Me.LisProvincia_LinkLabel.Name = "LisProvincia_LinkLabel"
        Me.LisProvincia_LinkLabel.Size = New System.Drawing.Size(163, 17)
        Me.LisProvincia_LinkLabel.TabIndex = 3
        Me.LisProvincia_LinkLabel.TabStop = True
        Me.LisProvincia_LinkLabel.Text = "Ver listado de provincias"
        '
        'canton_des_Label
        '
        Me.canton_des_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.canton_des_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canton_des_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.canton_des_Label.Location = New System.Drawing.Point(3, 3)
        Me.canton_des_Label.Name = "canton_des_Label"
        Me.canton_des_Label.Size = New System.Drawing.Size(506, 20)
        Me.canton_des_Label.TabIndex = 3
        Me.canton_des_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageParroq
        '
        Me.TabPageParroq.Controls.Add(Me.Panel2)
        Me.TabPageParroq.Controls.Add(Me.FlowLayoutPanel3)
        Me.TabPageParroq.Controls.Add(Me.Parroquia_desc_Label)
        Me.TabPageParroq.Location = New System.Drawing.Point(4, 25)
        Me.TabPageParroq.Name = "TabPageParroq"
        Me.TabPageParroq.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageParroq.Size = New System.Drawing.Size(512, 359)
        Me.TabPageParroq.TabIndex = 2
        Me.TabPageParroq.Text = "    Parroquias"
        Me.TabPageParroq.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtGridViewParroquia)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 274)
        Me.Panel2.TabIndex = 5
        '
        'dtGridViewParroquia
        '
        Me.dtGridViewParroquia.AllowUserToAddRows = False
        Me.dtGridViewParroquia.AllowUserToDeleteRows = False
        Me.dtGridViewParroquia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridViewParroquia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonViewSector})
        Me.dtGridViewParroquia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridViewParroquia.Location = New System.Drawing.Point(0, 0)
        Me.dtGridViewParroquia.Name = "dtGridViewParroquia"
        Me.dtGridViewParroquia.ReadOnly = True
        Me.dtGridViewParroquia.Size = New System.Drawing.Size(506, 274)
        Me.dtGridViewParroquia.TabIndex = 2
        '
        'ButtonViewSector
        '
        Me.ButtonViewSector.Frozen = True
        Me.ButtonViewSector.HeaderText = "Ver sectores"
        Me.ButtonViewSector.Name = "ButtonViewSector"
        Me.ButtonViewSector.ReadOnly = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.New_ParroquiaLinkLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.Update_ParroquiaLinkLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.DeleteParroquiaLinkLabel)
        Me.FlowLayoutPanel3.Controls.Add(Me.List_CantonesLinkLabel)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 23)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(506, 59)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'New_ParroquiaLinkLabel
        '
        Me.New_ParroquiaLinkLabel.AutoSize = True
        Me.New_ParroquiaLinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.New_ParroquiaLinkLabel.Name = "New_ParroquiaLinkLabel"
        Me.New_ParroquiaLinkLabel.Size = New System.Drawing.Size(171, 17)
        Me.New_ParroquiaLinkLabel.TabIndex = 0
        Me.New_ParroquiaLinkLabel.TabStop = True
        Me.New_ParroquiaLinkLabel.Text = "Agregar nueva parroquia."
        '
        'Update_ParroquiaLinkLabel
        '
        Me.Update_ParroquiaLinkLabel.AutoSize = True
        Me.Update_ParroquiaLinkLabel.Enabled = False
        Me.Update_ParroquiaLinkLabel.Location = New System.Drawing.Point(3, 17)
        Me.Update_ParroquiaLinkLabel.Name = "Update_ParroquiaLinkLabel"
        Me.Update_ParroquiaLinkLabel.Size = New System.Drawing.Size(69, 17)
        Me.Update_ParroquiaLinkLabel.TabIndex = 1
        Me.Update_ParroquiaLinkLabel.TabStop = True
        Me.Update_ParroquiaLinkLabel.Text = "Modificar."
        '
        'DeleteParroquiaLinkLabel
        '
        Me.DeleteParroquiaLinkLabel.AutoSize = True
        Me.DeleteParroquiaLinkLabel.Enabled = False
        Me.DeleteParroquiaLinkLabel.Location = New System.Drawing.Point(3, 34)
        Me.DeleteParroquiaLinkLabel.Name = "DeleteParroquiaLinkLabel"
        Me.DeleteParroquiaLinkLabel.Size = New System.Drawing.Size(58, 17)
        Me.DeleteParroquiaLinkLabel.TabIndex = 2
        Me.DeleteParroquiaLinkLabel.TabStop = True
        Me.DeleteParroquiaLinkLabel.Text = "Eliminar"
        '
        'List_CantonesLinkLabel
        '
        Me.List_CantonesLinkLabel.AutoSize = True
        Me.List_CantonesLinkLabel.Location = New System.Drawing.Point(180, 0)
        Me.List_CantonesLinkLabel.Name = "List_CantonesLinkLabel"
        Me.List_CantonesLinkLabel.Size = New System.Drawing.Size(77, 17)
        Me.List_CantonesLinkLabel.TabIndex = 3
        Me.List_CantonesLinkLabel.TabStop = True
        Me.List_CantonesLinkLabel.Text = "LinkLabel1"
        '
        'Parroquia_desc_Label
        '
        Me.Parroquia_desc_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Parroquia_desc_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parroquia_desc_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Parroquia_desc_Label.Location = New System.Drawing.Point(3, 3)
        Me.Parroquia_desc_Label.Name = "Parroquia_desc_Label"
        Me.Parroquia_desc_Label.Size = New System.Drawing.Size(506, 20)
        Me.Parroquia_desc_Label.TabIndex = 6
        Me.Parroquia_desc_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPageSector
        '
        Me.TabPageSector.Controls.Add(Me.Panel3)
        Me.TabPageSector.Controls.Add(Me.FlowLayoutPanel4)
        Me.TabPageSector.Controls.Add(Me.Sector_des_label)
        Me.TabPageSector.Location = New System.Drawing.Point(4, 25)
        Me.TabPageSector.Name = "TabPageSector"
        Me.TabPageSector.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSector.Size = New System.Drawing.Size(512, 359)
        Me.TabPageSector.TabIndex = 3
        Me.TabPageSector.Text = "     Sector..."
        Me.TabPageSector.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtGridViewSector)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(506, 274)
        Me.Panel3.TabIndex = 5
        '
        'dtGridViewSector
        '
        Me.dtGridViewSector.AllowUserToAddRows = False
        Me.dtGridViewSector.AllowUserToDeleteRows = False
        Me.dtGridViewSector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridViewSector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridViewSector.Location = New System.Drawing.Point(0, 0)
        Me.dtGridViewSector.Name = "dtGridViewSector"
        Me.dtGridViewSector.ReadOnly = True
        Me.dtGridViewSector.Size = New System.Drawing.Size(506, 274)
        Me.dtGridViewSector.TabIndex = 3
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.new_sectorLinkLabel)
        Me.FlowLayoutPanel4.Controls.Add(Me.Update_sectorLinkLabe)
        Me.FlowLayoutPanel4.Controls.Add(Me.Delete_sectorLinkLabel1)
        Me.FlowLayoutPanel4.Controls.Add(Me.List_ParroquiaLinkLabel)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 23)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(506, 59)
        Me.FlowLayoutPanel4.TabIndex = 4
        '
        'new_sectorLinkLabel
        '
        Me.new_sectorLinkLabel.AutoSize = True
        Me.new_sectorLinkLabel.Location = New System.Drawing.Point(3, 0)
        Me.new_sectorLinkLabel.Name = "new_sectorLinkLabel"
        Me.new_sectorLinkLabel.Size = New System.Drawing.Size(149, 17)
        Me.new_sectorLinkLabel.TabIndex = 0
        Me.new_sectorLinkLabel.TabStop = True
        Me.new_sectorLinkLabel.Text = "Agregar nueva sector."
        '
        'Update_sectorLinkLabe
        '
        Me.Update_sectorLinkLabe.AutoSize = True
        Me.Update_sectorLinkLabe.Enabled = False
        Me.Update_sectorLinkLabe.Location = New System.Drawing.Point(3, 17)
        Me.Update_sectorLinkLabe.Name = "Update_sectorLinkLabe"
        Me.Update_sectorLinkLabe.Size = New System.Drawing.Size(69, 17)
        Me.Update_sectorLinkLabe.TabIndex = 1
        Me.Update_sectorLinkLabe.TabStop = True
        Me.Update_sectorLinkLabe.Text = "Modificar."
        '
        'Delete_sectorLinkLabel1
        '
        Me.Delete_sectorLinkLabel1.AutoSize = True
        Me.Delete_sectorLinkLabel1.Enabled = False
        Me.Delete_sectorLinkLabel1.Location = New System.Drawing.Point(3, 34)
        Me.Delete_sectorLinkLabel1.Name = "Delete_sectorLinkLabel1"
        Me.Delete_sectorLinkLabel1.Size = New System.Drawing.Size(58, 17)
        Me.Delete_sectorLinkLabel1.TabIndex = 2
        Me.Delete_sectorLinkLabel1.TabStop = True
        Me.Delete_sectorLinkLabel1.Text = "Eliminar"
        '
        'List_ParroquiaLinkLabel
        '
        Me.List_ParroquiaLinkLabel.AutoSize = True
        Me.List_ParroquiaLinkLabel.Location = New System.Drawing.Point(158, 0)
        Me.List_ParroquiaLinkLabel.Name = "List_ParroquiaLinkLabel"
        Me.List_ParroquiaLinkLabel.Size = New System.Drawing.Size(175, 17)
        Me.List_ParroquiaLinkLabel.TabIndex = 3
        Me.List_ParroquiaLinkLabel.TabStop = True
        Me.List_ParroquiaLinkLabel.Text = "Ver listade de parroquias.."
        '
        'Sector_des_label
        '
        Me.Sector_des_label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Sector_des_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sector_des_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sector_des_label.Location = New System.Drawing.Point(3, 3)
        Me.Sector_des_label.Name = "Sector_des_label"
        Me.Sector_des_label.Size = New System.Drawing.Size(506, 20)
        Me.Sector_des_label.TabIndex = 6
        Me.Sector_des_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanePais
        '
        Me.PanePais.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanePais.Controls.Add(Me.Pais_DeleteButton)
        Me.PanePais.Controls.Add(Me.Edd_PaisButton)
        Me.PanePais.Controls.Add(Me.Pais_newButton)
        Me.PanePais.Controls.Add(Me.PaisComboBox)
        Me.PanePais.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanePais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanePais.Location = New System.Drawing.Point(0, 0)
        Me.PanePais.Name = "PanePais"
        Me.PanePais.Size = New System.Drawing.Size(520, 53)
        Me.PanePais.TabIndex = 2
        '
        'Pais_DeleteButton
        '
        Me.Pais_DeleteButton.Enabled = False
        Me.Pais_DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.Pais_DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pais_DeleteButton.Location = New System.Drawing.Point(423, 13)
        Me.Pais_DeleteButton.Name = "Pais_DeleteButton"
        Me.Pais_DeleteButton.Size = New System.Drawing.Size(87, 30)
        Me.Pais_DeleteButton.TabIndex = 2
        Me.Pais_DeleteButton.Text = "Eliminar"
        Me.Pais_DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pais_DeleteButton.UseVisualStyleBackColor = True
        '
        'Edd_PaisButton
        '
        Me.Edd_PaisButton.Enabled = False
        Me.Edd_PaisButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edir_16
        Me.Edd_PaisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Edd_PaisButton.Location = New System.Drawing.Point(346, 13)
        Me.Edd_PaisButton.Name = "Edd_PaisButton"
        Me.Edd_PaisButton.Size = New System.Drawing.Size(71, 30)
        Me.Edd_PaisButton.TabIndex = 2
        Me.Edd_PaisButton.Text = "Editar"
        Me.Edd_PaisButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Edd_PaisButton.UseVisualStyleBackColor = True
        '
        'Pais_newButton
        '
        Me.Pais_newButton.Image = Global.ECommercePlatformView.My.Resources.new_32
        Me.Pais_newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pais_newButton.Location = New System.Drawing.Point(261, 13)
        Me.Pais_newButton.Name = "Pais_newButton"
        Me.Pais_newButton.Size = New System.Drawing.Size(79, 30)
        Me.Pais_newButton.TabIndex = 1
        Me.Pais_newButton.Text = "Nuevo"
        Me.Pais_newButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Pais_newButton.UseVisualStyleBackColor = True
        '
        'PaisComboBox
        '
        Me.PaisComboBox.FormattingEnabled = True
        Me.PaisComboBox.Location = New System.Drawing.Point(7, 12)
        Me.PaisComboBox.Name = "PaisComboBox"
        Me.PaisComboBox.Size = New System.Drawing.Size(248, 28)
        Me.PaisComboBox.TabIndex = 0
        '
        'frmAdd_Zonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 473)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Panelpei)
        Me.Controls.Add(Me.PanePais)
        Me.Name = "frmAdd_Zonas"
        Me.Text = "Adminidtrando zonas..."
        Me.Panelpei.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPageProvincias.ResumeLayout(False)
        Me.PanelViewProvince.ResumeLayout(False)
        CType(Me.dtGridViewProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuProvincia.ResumeLayout(False)
        Me.MenuProvincia.PerformLayout()
        Me.TabPageCanton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtGridCanton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TabPageParroq.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtGridViewParroquia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.TabPageSector.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtGridViewSector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.PanePais.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelpei As System.Windows.Forms.Panel
    Friend WithEvents _CancelButton As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPageProvincias As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCanton As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSector As System.Windows.Forms.TabPage
    Friend WithEvents PanelViewProvince As System.Windows.Forms.Panel
    Friend WithEvents MenuProvincia As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Add_NewProvinLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Edit_ProvincinLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Delet_ProvinceLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents new_cantonLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents UpdateCanton_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Delete_CantonLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents canton_des_Label As System.Windows.Forms.Label
    Friend WithEvents TabPageParroq As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents New_ParroquiaLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Update_ParroquiaLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteParroquiaLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Parroquia_desc_Label As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents new_sectorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Update_sectorLinkLabe As System.Windows.Forms.LinkLabel
    Friend WithEvents Delete_sectorLinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Sector_des_label As System.Windows.Forms.Label
    Friend WithEvents dtGridViewProvincia As System.Windows.Forms.DataGridView
    Friend WithEvents butoonViewCanton As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dtGridCanton As System.Windows.Forms.DataGridView
    Friend WithEvents butoonViewParroquia As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents LisProvincia_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents List_CantonesLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents dtGridViewParroquia As System.Windows.Forms.DataGridView
    Friend WithEvents dtGridViewSector As System.Windows.Forms.DataGridView
    Friend WithEvents List_ParroquiaLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ButtonViewSector As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PanePais As System.Windows.Forms.Panel
    Friend WithEvents Edd_PaisButton As System.Windows.Forms.Button
    Friend WithEvents Pais_newButton As System.Windows.Forms.Button
    Friend WithEvents PaisComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Pais_DeleteButton As System.Windows.Forms.Button
End Class
