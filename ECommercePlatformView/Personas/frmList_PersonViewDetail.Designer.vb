<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_PersonViewDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_PersonViewDetail))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.adminEmployeePanel = New System.Windows.Forms.Panel()
        Me.DeletePersonButton = New System.Windows.Forms.Button()
        Me.EdidPersonButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelList = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.idPersonaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idClienteclm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmployeeClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsSelectClm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ruc_CiClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mailClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRatesClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypePerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelPieList = New System.Windows.Forms.Panel()
        Me.TotalListLabel = New System.Windows.Forms.Label()
        Me.PanelMenuList = New System.Windows.Forms.Panel()
        Me.PanelBusq = New System.Windows.Forms.Panel()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.QuitFilterButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.ToolsButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AdminPayMentPanel = New System.Windows.Forms.Panel()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.NameEmployeeLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolsContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PersonasNaturalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompaniasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.adminEmployeePanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelList.SuspendLayout()
        Me.PanelView.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPieList.SuspendLayout()
        Me.PanelMenuList.SuspendLayout()
        Me.PanelBusq.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.AdminPayMentPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolsContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(915, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(81, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(996, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(83, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 521)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(1084, 40)
        Me.Panel1.TabIndex = 1
        '
        'adminEmployeePanel
        '
        Me.adminEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminEmployeePanel.Controls.Add(Me.DeletePersonButton)
        Me.adminEmployeePanel.Controls.Add(Me.EdidPersonButton)
        Me.adminEmployeePanel.Controls.Add(Me.AddNewButton)
        Me.adminEmployeePanel.Controls.Add(Me.Label1)
        Me.adminEmployeePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.adminEmployeePanel.Location = New System.Drawing.Point(0, 0)
        Me.adminEmployeePanel.Name = "adminEmployeePanel"
        Me.adminEmployeePanel.Size = New System.Drawing.Size(1084, 33)
        Me.adminEmployeePanel.TabIndex = 2
        '
        'DeletePersonButton
        '
        Me.DeletePersonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeletePersonButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeletePersonButton.ForeColor = System.Drawing.Color.White
        Me.DeletePersonButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeletePersonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeletePersonButton.Location = New System.Drawing.Point(433, 0)
        Me.DeletePersonButton.Name = "DeletePersonButton"
        Me.DeletePersonButton.Size = New System.Drawing.Size(80, 31)
        Me.DeletePersonButton.TabIndex = 10
        Me.DeletePersonButton.Text = "Eliminar"
        Me.DeletePersonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeletePersonButton.UseVisualStyleBackColor = False
        '
        'EdidPersonButton
        '
        Me.EdidPersonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EdidPersonButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EdidPersonButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_24
        Me.EdidPersonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EdidPersonButton.Location = New System.Drawing.Point(370, 0)
        Me.EdidPersonButton.Name = "EdidPersonButton"
        Me.EdidPersonButton.Size = New System.Drawing.Size(63, 31)
        Me.EdidPersonButton.TabIndex = 8
        Me.EdidPersonButton.Text = "Editar"
        Me.EdidPersonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EdidPersonButton.UseVisualStyleBackColor = False
        '
        'AddNewButton
        '
        Me.AddNewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddNewButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.AddNewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewButton.Location = New System.Drawing.Point(293, 0)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(77, 31)
        Me.AddNewButton.TabIndex = 7
        Me.AddNewButton.Text = "Agregar"
        Me.AddNewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "LISTADO DE PERSONAS"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelList)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1084, 488)
        Me.SplitContainer1.SplitterDistance = 624
        Me.SplitContainer1.TabIndex = 66
        '
        'PanelList
        '
        Me.PanelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelList.Controls.Add(Me.PanelView)
        Me.PanelList.Controls.Add(Me.PanelPieList)
        Me.PanelList.Controls.Add(Me.PanelMenuList)
        Me.PanelList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelList.Location = New System.Drawing.Point(2, 2)
        Me.PanelList.Name = "PanelList"
        Me.PanelList.Size = New System.Drawing.Size(620, 484)
        Me.PanelList.TabIndex = 59
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.dtg)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 32)
        Me.PanelView.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(618, 428)
        Me.PanelView.TabIndex = 44
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPersonaClm, Me.idClienteclm, Me.IdEmployeeClm, Me.ApellidosClm, Me.NombreClm, Me.IsSelectClm, Me.Ruc_CiClm, Me.ClienteClm, Me.DireccionClm, Me.telefonoClm, Me.mailClm, Me.idRatesClm, Me.DescriptionClm, Me.TarifaClm, Me.ImageClm, Me.Genero, Me.TypePerson})
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(618, 428)
        Me.dtg.TabIndex = 21
        '
        'idPersonaClm
        '
        Me.idPersonaClm.DataPropertyName = "IdPersona"
        Me.idPersonaClm.HeaderText = "id Persona"
        Me.idPersonaClm.Name = "idPersonaClm"
        Me.idPersonaClm.ReadOnly = True
        Me.idPersonaClm.Visible = False
        '
        'idClienteclm
        '
        Me.idClienteclm.DataPropertyName = "IdCliente"
        Me.idClienteclm.HeaderText = "id Cliente"
        Me.idClienteclm.Name = "idClienteclm"
        Me.idClienteclm.ReadOnly = True
        Me.idClienteclm.Visible = False
        '
        'IdEmployeeClm
        '
        Me.IdEmployeeClm.DataPropertyName = "IdEmployee"
        Me.IdEmployeeClm.HeaderText = "Id empleado"
        Me.IdEmployeeClm.Name = "IdEmployeeClm"
        Me.IdEmployeeClm.ReadOnly = True
        Me.IdEmployeeClm.Visible = False
        '
        'ApellidosClm
        '
        Me.ApellidosClm.DataPropertyName = "Apellido"
        Me.ApellidosClm.HeaderText = "Apellido"
        Me.ApellidosClm.Name = "ApellidosClm"
        Me.ApellidosClm.ReadOnly = True
        Me.ApellidosClm.Visible = False
        '
        'NombreClm
        '
        Me.NombreClm.DataPropertyName = "Nombre"
        Me.NombreClm.HeaderText = "Nombre"
        Me.NombreClm.Name = "NombreClm"
        Me.NombreClm.ReadOnly = True
        Me.NombreClm.Visible = False
        '
        'IsSelectClm
        '
        Me.IsSelectClm.DataPropertyName = "IsSelect"
        Me.IsSelectClm.HeaderText = " "
        Me.IsSelectClm.Name = "IsSelectClm"
        Me.IsSelectClm.Visible = False
        '
        'Ruc_CiClm
        '
        Me.Ruc_CiClm.DataPropertyName = "Ruc_Ci"
        Me.Ruc_CiClm.HeaderText = "Ruc (o) C.I."
        Me.Ruc_CiClm.Name = "Ruc_CiClm"
        Me.Ruc_CiClm.ReadOnly = True
        Me.Ruc_CiClm.Width = 120
        '
        'ClienteClm
        '
        Me.ClienteClm.DataPropertyName = "FullName"
        Me.ClienteClm.HeaderText = "Nombres"
        Me.ClienteClm.Name = "ClienteClm"
        Me.ClienteClm.ReadOnly = True
        Me.ClienteClm.Width = 250
        '
        'DireccionClm
        '
        Me.DireccionClm.DataPropertyName = "Direccion"
        Me.DireccionClm.HeaderText = "Dirección"
        Me.DireccionClm.Name = "DireccionClm"
        Me.DireccionClm.ReadOnly = True
        Me.DireccionClm.Visible = False
        '
        'telefonoClm
        '
        Me.telefonoClm.DataPropertyName = "Telefono"
        Me.telefonoClm.HeaderText = "Télefono"
        Me.telefonoClm.Name = "telefonoClm"
        Me.telefonoClm.ReadOnly = True
        '
        'mailClm
        '
        Me.mailClm.DataPropertyName = "mail"
        Me.mailClm.HeaderText = "E-mail"
        Me.mailClm.Name = "mailClm"
        Me.mailClm.ReadOnly = True
        '
        'idRatesClm
        '
        Me.idRatesClm.DataPropertyName = "idRates"
        Me.idRatesClm.HeaderText = "id Rates"
        Me.idRatesClm.Name = "idRatesClm"
        Me.idRatesClm.ReadOnly = True
        Me.idRatesClm.Visible = False
        '
        'DescriptionClm
        '
        Me.DescriptionClm.DataPropertyName = "Description"
        Me.DescriptionClm.HeaderText = "Descripción tarifa"
        Me.DescriptionClm.Name = "DescriptionClm"
        Me.DescriptionClm.ReadOnly = True
        Me.DescriptionClm.Visible = False
        '
        'TarifaClm
        '
        Me.TarifaClm.DataPropertyName = "Tarifa"
        Me.TarifaClm.HeaderText = "Tarifa"
        Me.TarifaClm.Name = "TarifaClm"
        Me.TarifaClm.ReadOnly = True
        Me.TarifaClm.Visible = False
        '
        'ImageClm
        '
        Me.ImageClm.DataPropertyName = "Images"
        Me.ImageClm.HeaderText = "Imagen"
        Me.ImageClm.Name = "ImageClm"
        Me.ImageClm.Visible = False
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.Visible = False
        '
        'TypePerson
        '
        Me.TypePerson.DataPropertyName = "TypePerson"
        Me.TypePerson.HeaderText = "TypePerson"
        Me.TypePerson.Name = "TypePerson"
        Me.TypePerson.ReadOnly = True
        Me.TypePerson.Visible = False
        '
        'PanelPieList
        '
        Me.PanelPieList.Controls.Add(Me.TotalListLabel)
        Me.PanelPieList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPieList.Location = New System.Drawing.Point(0, 460)
        Me.PanelPieList.Name = "PanelPieList"
        Me.PanelPieList.Size = New System.Drawing.Size(618, 22)
        Me.PanelPieList.TabIndex = 42
        '
        'TotalListLabel
        '
        Me.TotalListLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalListLabel.Location = New System.Drawing.Point(0, 0)
        Me.TotalListLabel.Name = "TotalListLabel"
        Me.TotalListLabel.Size = New System.Drawing.Size(194, 22)
        Me.TotalListLabel.TabIndex = 0
        Me.TotalListLabel.Text = "Label1"
        Me.TotalListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelMenuList
        '
        Me.PanelMenuList.Controls.Add(Me.PanelBusq)
        Me.PanelMenuList.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenuList.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuList.Name = "PanelMenuList"
        Me.PanelMenuList.Size = New System.Drawing.Size(618, 32)
        Me.PanelMenuList.TabIndex = 43
        '
        'PanelBusq
        '
        Me.PanelBusq.Controls.Add(Me.PanelFind)
        Me.PanelBusq.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBusq.Location = New System.Drawing.Point(164, 0)
        Me.PanelBusq.Name = "PanelBusq"
        Me.PanelBusq.Size = New System.Drawing.Size(454, 32)
        Me.PanelBusq.TabIndex = 64
        '
        'PanelFind
        '
        Me.PanelFind.BackColor = System.Drawing.Color.LightGreen
        Me.PanelFind.Controls.Add(Me.QuitFilterButton)
        Me.PanelFind.Controls.Add(Me.FindButton)
        Me.PanelFind.Controls.Add(Me.FindTextBox)
        Me.PanelFind.Controls.Add(Me.ToolsButton)
        Me.PanelFind.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelFind.Location = New System.Drawing.Point(70, 0)
        Me.PanelFind.Name = "PanelFind"
        Me.PanelFind.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelFind.Size = New System.Drawing.Size(384, 32)
        Me.PanelFind.TabIndex = 9
        '
        'QuitFilterButton
        '
        Me.QuitFilterButton.BackColor = System.Drawing.Color.White
        Me.QuitFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QuitFilterButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.QuitFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QuitFilterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.QuitFilterButton.Location = New System.Drawing.Point(247, 1)
        Me.QuitFilterButton.Name = "QuitFilterButton"
        Me.QuitFilterButton.Size = New System.Drawing.Size(17, 30)
        Me.QuitFilterButton.TabIndex = 9
        Me.QuitFilterButton.UseVisualStyleBackColor = False
        Me.QuitFilterButton.Visible = False
        '
        'FindButton
        '
        Me.FindButton.BackColor = System.Drawing.Color.LightGreen
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.Enabled = False
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.FindButton.Location = New System.Drawing.Point(264, 1)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(36, 30)
        Me.FindButton.TabIndex = 6
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox.Location = New System.Drawing.Point(1, 1)
        Me.FindTextBox.Multiline = True
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(299, 30)
        Me.FindTextBox.TabIndex = 7
        '
        'ToolsButton
        '
        Me.ToolsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsButton.Location = New System.Drawing.Point(300, 1)
        Me.ToolsButton.Name = "ToolsButton"
        Me.ToolsButton.Size = New System.Drawing.Size(83, 30)
        Me.ToolsButton.TabIndex = 8
        Me.ToolsButton.Text = "Herraminetas"
        Me.ToolsButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 138)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(452, 348)
        Me.ListBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(2, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HISTORIAL..."
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AdminPayMentPanel)
        Me.Panel3.Controls.Add(Me.EmailLabel)
        Me.Panel3.Controls.Add(Me.PhoneLabel)
        Me.Panel3.Controls.Add(Me.NameEmployeeLabel)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 123)
        Me.Panel3.TabIndex = 0
        '
        'AdminPayMentPanel
        '
        Me.AdminPayMentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.AdminPayMentPanel.Controls.Add(Me.BunifuThinButton24)
        Me.AdminPayMentPanel.Controls.Add(Me.BunifuThinButton23)
        Me.AdminPayMentPanel.Controls.Add(Me.BunifuThinButton22)
        Me.AdminPayMentPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdminPayMentPanel.Location = New System.Drawing.Point(125, 85)
        Me.AdminPayMentPanel.Name = "AdminPayMentPanel"
        Me.AdminPayMentPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.AdminPayMentPanel.Size = New System.Drawing.Size(325, 36)
        Me.AdminPayMentPanel.TabIndex = 66
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuThinButton24.ButtonText = "Retiro"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.Location = New System.Drawing.Point(185, 2)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(83, 32)
        Me.BunifuThinButton24.TabIndex = 64
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Navy
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.Navy
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuThinButton23.ButtonText = "Pagos"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.Navy
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.Navy
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.Navy
        Me.BunifuThinButton23.Location = New System.Drawing.Point(98, 2)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(87, 32)
        Me.BunifuThinButton23.TabIndex = 64
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuThinButton22.ButtonText = "Estado"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.Location = New System.Drawing.Point(2, 2)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(96, 32)
        Me.BunifuThinButton22.TabIndex = 64
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(129, 51)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(51, 17)
        Me.EmailLabel.TabIndex = 65
        Me.EmailLabel.Text = "Label4"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLabel.Location = New System.Drawing.Point(129, 30)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(51, 17)
        Me.PhoneLabel.TabIndex = 65
        Me.PhoneLabel.Text = "Label4"
        '
        'NameEmployeeLabel
        '
        Me.NameEmployeeLabel.AutoSize = True
        Me.NameEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameEmployeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameEmployeeLabel.Location = New System.Drawing.Point(128, 7)
        Me.NameEmployeeLabel.Name = "NameEmployeeLabel"
        Me.NameEmployeeLabel.Size = New System.Drawing.Size(164, 22)
        Me.NameEmployeeLabel.TabIndex = 63
        Me.NameEmployeeLabel.Text = "Taday Malan Jyuan"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(125, 121)
        Me.Panel4.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 119)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'ToolsContextMenuStrip
        '
        Me.ToolsContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasNaturalesToolStripMenuItem, Me.CompaniasToolStripMenuItem})
        Me.ToolsContextMenuStrip.Name = "ToolsContextMenuStrip"
        Me.ToolsContextMenuStrip.Size = New System.Drawing.Size(173, 48)
        '
        'PersonasNaturalesToolStripMenuItem
        '
        Me.PersonasNaturalesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Client_32
        Me.PersonasNaturalesToolStripMenuItem.Name = "PersonasNaturalesToolStripMenuItem"
        Me.PersonasNaturalesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PersonasNaturalesToolStripMenuItem.Text = "Personas naturales"
        '
        'CompaniasToolStripMenuItem
        '
        Me.CompaniasToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Company_32
        Me.CompaniasToolStripMenuItem.Name = "CompaniasToolStripMenuItem"
        Me.CompaniasToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CompaniasToolStripMenuItem.Text = "Companias"
        '
        'frmList_PersonViewDetail
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1084, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.adminEmployeePanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmList_PersonViewDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de personas..."
        Me.Panel1.ResumeLayout(False)
        Me.adminEmployeePanel.ResumeLayout(False)
        Me.adminEmployeePanel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelList.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPieList.ResumeLayout(False)
        Me.PanelMenuList.ResumeLayout(False)
        Me.PanelBusq.ResumeLayout(False)
        Me.PanelFind.ResumeLayout(False)
        Me.PanelFind.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.AdminPayMentPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolsContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminEmployeePanel As Panel
    Friend WithEvents DeletePersonButton As Button
    Friend WithEvents EdidPersonButton As Button
    Friend WithEvents AddNewButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelList As Panel
    Friend WithEvents PanelView As Panel
    Friend WithEvents dtg As DataGridView
    Friend WithEvents PanelPieList As Panel
    Friend WithEvents TotalListLabel As Label
    Friend WithEvents PanelMenuList As Panel
    Friend WithEvents PanelBusq As Panel
    Friend WithEvents PanelFind As Panel
    Friend WithEvents QuitFilterButton As Button
    Friend WithEvents FindButton As Button
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents ToolsButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AdminPayMentPanel As Panel
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents NameEmployeeLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolsContextMenuStrip As ContextMenuStrip
    Friend WithEvents PersonasNaturalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompaniasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idPersonaClm As DataGridViewTextBoxColumn
    Friend WithEvents idClienteclm As DataGridViewTextBoxColumn
    Friend WithEvents IdEmployeeClm As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosClm As DataGridViewTextBoxColumn
    Friend WithEvents NombreClm As DataGridViewTextBoxColumn
    Friend WithEvents IsSelectClm As DataGridViewCheckBoxColumn
    Friend WithEvents Ruc_CiClm As DataGridViewTextBoxColumn
    Friend WithEvents ClienteClm As DataGridViewTextBoxColumn
    Friend WithEvents DireccionClm As DataGridViewTextBoxColumn
    Friend WithEvents telefonoClm As DataGridViewTextBoxColumn
    Friend WithEvents mailClm As DataGridViewTextBoxColumn
    Friend WithEvents idRatesClm As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionClm As DataGridViewTextBoxColumn
    Friend WithEvents TarifaClm As DataGridViewTextBoxColumn
    Friend WithEvents ImageClm As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents TypePerson As DataGridViewTextBoxColumn
End Class
