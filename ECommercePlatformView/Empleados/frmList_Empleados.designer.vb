<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_Empleados))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.notificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.EditDetailButton = New System.Windows.Forms.Button()
        Me.EdidEmployeeCliente = New System.Windows.Forms.Button()
        Me.AddNewEmplToList = New System.Windows.Forms.Button()
        Me.deleteEmployeeButton = New System.Windows.Forms.Button()
        Me.EditCardButton = New System.Windows.Forms.Button()
        Me.EstadoBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PagosBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RetirosBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panelpie = New System.Windows.Forms.Panel()
        Me.PaneMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelPieList = New System.Windows.Forms.Panel()
        Me.TotalListLabel = New System.Windows.Forms.Label()
        Me.PanelMenuList = New System.Windows.Forms.Panel()
        Me.PanelBusq = New System.Windows.Forms.Panel()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.QuitFilterButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.adminEmployeePanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.deleteContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminPayMentPanel = New System.Windows.Forms.Panel()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.NameEmployeeLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelpie.SuspendLayout()
        Me.PaneMenu.SuspendLayout()
        Me.PanelPieList.SuspendLayout()
        Me.PanelMenuList.SuspendLayout()
        Me.PanelBusq.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.adminEmployeePanel.SuspendLayout()
        Me.PanelList.SuspendLayout()
        Me.PanelView.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.deleteContextMenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.AdminPayMentPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(-10, 706)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 20)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.Text = "Label2"
        '
        'notificacion
        '
        Me.notificacion.Icon = CType(resources.GetObject("notificacion.Icon"), System.Drawing.Icon)
        Me.notificacion.Text = "NotifyIcon1"
        Me.notificacion.Visible = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(1186, 14)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(10, 26)
        Me.txtIdCliente.TabIndex = 44
        Me.txtIdCliente.Text = "0"
        Me.txtIdCliente.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1006, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(111, 32)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cerrar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancelar..")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'EditDetailButton
        '
        Me.EditDetailButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditDetailButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_Employee_64
        Me.EditDetailButton.Location = New System.Drawing.Point(76, 2)
        Me.EditDetailButton.Margin = New System.Windows.Forms.Padding(5)
        Me.EditDetailButton.Name = "EditDetailButton"
        Me.EditDetailButton.Size = New System.Drawing.Size(72, 35)
        Me.EditDetailButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.EditDetailButton, "Editar información del empleado")
        Me.EditDetailButton.UseVisualStyleBackColor = True
        '
        'EdidEmployeeCliente
        '
        Me.EdidEmployeeCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EdidEmployeeCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EdidEmployeeCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.EdidEmployeeCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.EdidEmployeeCliente.Enabled = False
        Me.EdidEmployeeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdidEmployeeCliente.ForeColor = System.Drawing.Color.Blue
        Me.EdidEmployeeCliente.Image = Global.ECommercePlatformView.My.Resources.Resources.edid_pencil_32
        Me.EdidEmployeeCliente.Location = New System.Drawing.Point(56, 2)
        Me.EdidEmployeeCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EdidEmployeeCliente.Name = "EdidEmployeeCliente"
        Me.EdidEmployeeCliente.Size = New System.Drawing.Size(48, 38)
        Me.EdidEmployeeCliente.TabIndex = 40
        Me.EdidEmployeeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.EdidEmployeeCliente, "Editar información personal")
        Me.EdidEmployeeCliente.UseVisualStyleBackColor = True
        '
        'AddNewEmplToList
        '
        Me.AddNewEmplToList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddNewEmplToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddNewEmplToList.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewEmplToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewEmplToList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddNewEmplToList.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.AddNewEmplToList.Location = New System.Drawing.Point(2, 2)
        Me.AddNewEmplToList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddNewEmplToList.Name = "AddNewEmplToList"
        Me.AddNewEmplToList.Size = New System.Drawing.Size(54, 38)
        Me.AddNewEmplToList.TabIndex = 35
        Me.AddNewEmplToList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.AddNewEmplToList, "Agregar Nuevos Usuarios")
        Me.AddNewEmplToList.UseVisualStyleBackColor = False
        '
        'deleteEmployeeButton
        '
        Me.deleteEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deleteEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteEmployeeButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.deleteEmployeeButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.deleteEmployeeButton.Enabled = False
        Me.deleteEmployeeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteEmployeeButton.ForeColor = System.Drawing.Color.Blue
        Me.deleteEmployeeButton.Image = Global.ECommercePlatformView.My.Resources.Resources.delete_red_32
        Me.deleteEmployeeButton.Location = New System.Drawing.Point(104, 2)
        Me.deleteEmployeeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteEmployeeButton.Name = "deleteEmployeeButton"
        Me.deleteEmployeeButton.Size = New System.Drawing.Size(57, 38)
        Me.deleteEmployeeButton.TabIndex = 42
        Me.deleteEmployeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.deleteEmployeeButton, "Editar información personal")
        Me.deleteEmployeeButton.UseVisualStyleBackColor = True
        '
        'EditCardButton
        '
        Me.EditCardButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditCardButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditCardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCardButton.ForeColor = System.Drawing.Color.Red
        Me.EditCardButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Edit_cart_Employee_64
        Me.EditCardButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditCardButton.Location = New System.Drawing.Point(2, 2)
        Me.EditCardButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditCardButton.Name = "EditCardButton"
        Me.EditCardButton.Size = New System.Drawing.Size(74, 35)
        Me.EditCardButton.TabIndex = 42
        Me.EditCardButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.EditCardButton, "Ver detalle de la lista seleccionada")
        Me.EditCardButton.UseVisualStyleBackColor = True
        '
        'EstadoBunifuThinButton
        '
        Me.EstadoBunifuThinButton.ActiveBorderThickness = 1
        Me.EstadoBunifuThinButton.ActiveCornerRadius = 20
        Me.EstadoBunifuThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstadoBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.EstadoBunifuThinButton.ActiveLineColor = System.Drawing.Color.Red
        Me.EstadoBunifuThinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.EstadoBunifuThinButton.BackgroundImage = CType(resources.GetObject("EstadoBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.EstadoBunifuThinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EstadoBunifuThinButton.ButtonText = "Estado deuda"
        Me.EstadoBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EstadoBunifuThinButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EstadoBunifuThinButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoBunifuThinButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.EstadoBunifuThinButton.IdleBorderThickness = 1
        Me.EstadoBunifuThinButton.IdleCornerRadius = 30
        Me.EstadoBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.EstadoBunifuThinButton.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstadoBunifuThinButton.IdleLineColor = System.Drawing.Color.Red
        Me.EstadoBunifuThinButton.Location = New System.Drawing.Point(2, 2)
        Me.EstadoBunifuThinButton.Margin = New System.Windows.Forms.Padding(5)
        Me.EstadoBunifuThinButton.Name = "EstadoBunifuThinButton"
        Me.EstadoBunifuThinButton.Size = New System.Drawing.Size(150, 46)
        Me.EstadoBunifuThinButton.TabIndex = 64
        Me.EstadoBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.EstadoBunifuThinButton, "Estado deuda")
        '
        'PagosBunifuThinButton
        '
        Me.PagosBunifuThinButton.ActiveBorderThickness = 1
        Me.PagosBunifuThinButton.ActiveCornerRadius = 20
        Me.PagosBunifuThinButton.ActiveFillColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.PagosBunifuThinButton.ActiveLineColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PagosBunifuThinButton.BackgroundImage = CType(resources.GetObject("PagosBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.PagosBunifuThinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PagosBunifuThinButton.ButtonText = "Pagos"
        Me.PagosBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PagosBunifuThinButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PagosBunifuThinButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosBunifuThinButton.ForeColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.IdleBorderThickness = 1
        Me.PagosBunifuThinButton.IdleCornerRadius = 30
        Me.PagosBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.PagosBunifuThinButton.IdleForecolor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.IdleLineColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.Location = New System.Drawing.Point(152, 2)
        Me.PagosBunifuThinButton.Margin = New System.Windows.Forms.Padding(5)
        Me.PagosBunifuThinButton.Name = "PagosBunifuThinButton"
        Me.PagosBunifuThinButton.Size = New System.Drawing.Size(84, 46)
        Me.PagosBunifuThinButton.TabIndex = 64
        Me.PagosBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.PagosBunifuThinButton, "Pagos, sueldos salarios bonificaciones")
        '
        'RetirosBunifuThinButton
        '
        Me.RetirosBunifuThinButton.ActiveBorderThickness = 1
        Me.RetirosBunifuThinButton.ActiveCornerRadius = 20
        Me.RetirosBunifuThinButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.RetirosBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.RetirosBunifuThinButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.RetirosBunifuThinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.RetirosBunifuThinButton.BackgroundImage = CType(resources.GetObject("RetirosBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.RetirosBunifuThinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RetirosBunifuThinButton.ButtonText = "Retiro"
        Me.RetirosBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RetirosBunifuThinButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.RetirosBunifuThinButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetirosBunifuThinButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.RetirosBunifuThinButton.IdleBorderThickness = 1
        Me.RetirosBunifuThinButton.IdleCornerRadius = 30
        Me.RetirosBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.RetirosBunifuThinButton.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.RetirosBunifuThinButton.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.RetirosBunifuThinButton.Location = New System.Drawing.Point(236, 2)
        Me.RetirosBunifuThinButton.Margin = New System.Windows.Forms.Padding(5)
        Me.RetirosBunifuThinButton.Name = "RetirosBunifuThinButton"
        Me.RetirosBunifuThinButton.Size = New System.Drawing.Size(90, 46)
        Me.RetirosBunifuThinButton.TabIndex = 64
        Me.RetirosBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.RetirosBunifuThinButton, "Retiros")
        '
        'Panelpie
        '
        Me.Panelpie.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panelpie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelpie.Controls.Add(Me.btnCancel)
        Me.Panelpie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelpie.Location = New System.Drawing.Point(0, 428)
        Me.Panelpie.Name = "Panelpie"
        Me.Panelpie.Size = New System.Drawing.Size(1119, 34)
        Me.Panelpie.TabIndex = 57
        '
        'PaneMenu
        '
        Me.PaneMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneMenu.Controls.Add(Me.deleteEmployeeButton)
        Me.PaneMenu.Controls.Add(Me.EdidEmployeeCliente)
        Me.PaneMenu.Controls.Add(Me.AddNewEmplToList)
        Me.PaneMenu.Controls.Add(Me.Label1)
        Me.PaneMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PaneMenu.Location = New System.Drawing.Point(2, 2)
        Me.PaneMenu.Name = "PaneMenu"
        Me.PaneMenu.Padding = New System.Windows.Forms.Padding(2)
        Me.PaneMenu.Size = New System.Drawing.Size(168, 59)
        Me.PaneMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Informacion personal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelPieList
        '
        Me.PanelPieList.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.PanelPieList.Controls.Add(Me.TotalListLabel)
        Me.PanelPieList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPieList.Location = New System.Drawing.Point(0, 335)
        Me.PanelPieList.Name = "PanelPieList"
        Me.PanelPieList.Size = New System.Drawing.Size(640, 22)
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
        Me.PanelMenuList.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PanelMenuList.Controls.Add(Me.PanelBusq)
        Me.PanelMenuList.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenuList.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuList.Name = "PanelMenuList"
        Me.PanelMenuList.Size = New System.Drawing.Size(640, 32)
        Me.PanelMenuList.TabIndex = 43
        '
        'PanelBusq
        '
        Me.PanelBusq.Controls.Add(Me.PanelFind)
        Me.PanelBusq.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBusq.Location = New System.Drawing.Point(186, 0)
        Me.PanelBusq.Name = "PanelBusq"
        Me.PanelBusq.Size = New System.Drawing.Size(454, 32)
        Me.PanelBusq.TabIndex = 64
        '
        'PanelFind
        '
        Me.PanelFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PanelFind.Controls.Add(Me.QuitFilterButton)
        Me.PanelFind.Controls.Add(Me.FindButton)
        Me.PanelFind.Controls.Add(Me.FindTextBox)
        Me.PanelFind.Controls.Add(Me.SettingButton)
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
        Me.FindButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
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
        'SettingButton
        '
        Me.SettingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingButton.Location = New System.Drawing.Point(300, 1)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(83, 30)
        Me.SettingButton.TabIndex = 8
        Me.SettingButton.Text = "Herraminetas"
        Me.SettingButton.UseVisualStyleBackColor = False
        '
        'adminEmployeePanel
        '
        Me.adminEmployeePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adminEmployeePanel.Controls.Add(Me.EditDetailButton)
        Me.adminEmployeePanel.Controls.Add(Me.EditCardButton)
        Me.adminEmployeePanel.Controls.Add(Me.Label2)
        Me.adminEmployeePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.adminEmployeePanel.Location = New System.Drawing.Point(170, 2)
        Me.adminEmployeePanel.Name = "adminEmployeePanel"
        Me.adminEmployeePanel.Padding = New System.Windows.Forms.Padding(2)
        Me.adminEmployeePanel.Size = New System.Drawing.Size(154, 59)
        Me.adminEmployeePanel.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Informacion empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PanelList.Size = New System.Drawing.Size(642, 359)
        Me.PanelList.TabIndex = 59
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.dtg)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 32)
        Me.PanelView.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(640, 303)
        Me.PanelView.TabIndex = 44
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPersonaClm, Me.idClienteclm, Me.IdEmployeeClm, Me.ApellidosClm, Me.NombreClm, Me.IsSelectClm, Me.Ruc_CiClm, Me.ClienteClm, Me.DireccionClm, Me.telefonoClm, Me.mailClm, Me.idRatesClm, Me.DescriptionClm, Me.TarifaClm, Me.ImageClm, Me.Genero})
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(640, 303)
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
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'deleteContextMenuStrip
        '
        Me.deleteContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem, Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem})
        Me.deleteContextMenuStrip.Name = "deleteContextMenuStrip"
        Me.deleteContextMenuStrip.Size = New System.Drawing.Size(318, 48)
        '
        'BorrarDeLaListaDeEmpleadosToolStripMenuItem
        '
        Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.delete_card_32
        Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem.Name = "BorrarDeLaListaDeEmpleadosToolStripMenuItem"
        Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.BorrarDeLaListaDeEmpleadosToolStripMenuItem.Text = "Borrar de la lista de empleados."
        '
        'EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem
        '
        Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem.Name = "EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem"
        Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem.Text = "Eliminar tota la informacion de este empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.adminEmployeePanel)
        Me.Panel1.Controls.Add(Me.PaneMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(1119, 65)
        Me.Panel1.TabIndex = 64
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 65)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelList)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1119, 363)
        Me.SplitContainer1.SplitterDistance = 646
        Me.SplitContainer1.TabIndex = 65
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(2, 145)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(465, 216)
        Me.ListBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(2, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HISTORIAL..."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AdminPayMentPanel)
        Me.Panel2.Controls.Add(Me.EmailLabel)
        Me.Panel2.Controls.Add(Me.PhoneLabel)
        Me.Panel2.Controls.Add(Me.NameEmployeeLabel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(465, 123)
        Me.Panel2.TabIndex = 0
        '
        'AdminPayMentPanel
        '
        Me.AdminPayMentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.AdminPayMentPanel.Controls.Add(Me.RetirosBunifuThinButton)
        Me.AdminPayMentPanel.Controls.Add(Me.PagosBunifuThinButton)
        Me.AdminPayMentPanel.Controls.Add(Me.EstadoBunifuThinButton)
        Me.AdminPayMentPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdminPayMentPanel.Location = New System.Drawing.Point(125, 71)
        Me.AdminPayMentPanel.Name = "AdminPayMentPanel"
        Me.AdminPayMentPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.AdminPayMentPanel.Size = New System.Drawing.Size(338, 50)
        Me.AdminPayMentPanel.TabIndex = 66
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
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 121)
        Me.Panel3.TabIndex = 0
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
        'frmList_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1119, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Panelpie)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmList_Empleados"
        Me.Text = "Listado de empleados.."
        Me.Panelpie.ResumeLayout(False)
        Me.PaneMenu.ResumeLayout(False)
        Me.PanelPieList.ResumeLayout(False)
        Me.PanelMenuList.ResumeLayout(False)
        Me.PanelBusq.ResumeLayout(False)
        Me.PanelFind.ResumeLayout(False)
        Me.PanelFind.PerformLayout()
        Me.adminEmployeePanel.ResumeLayout(False)
        Me.PanelList.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.deleteContextMenuStrip.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.AdminPayMentPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents notificacion As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AddNewEmplToList As System.Windows.Forms.Button
    Friend WithEvents EdidEmployeeCliente As System.Windows.Forms.Button
    Friend WithEvents txtIdCliente As System.Windows.Forms.TextBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panelpie As System.Windows.Forms.Panel
    Friend WithEvents EditDetailButton As System.Windows.Forms.Button
    Friend WithEvents PaneMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelMenuList As System.Windows.Forms.Panel
    Friend WithEvents PanelPieList As System.Windows.Forms.Panel
    Friend WithEvents TotalListLabel As System.Windows.Forms.Label
    Friend WithEvents PanelList As System.Windows.Forms.Panel
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents deleteEmployeeButton As Button
    Friend WithEvents adminEmployeePanel As System.Windows.Forms.Panel
    Friend WithEvents EditCardButton As Button
    Friend WithEvents deleteContextMenuStrip As ContextMenuStrip
    Friend WithEvents BorrarDeLaListaDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelBusq As Panel
    Friend WithEvents PanelFind As Panel
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents FindButton As Button
    Friend WithEvents SettingButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtg As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NameEmployeeLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox1 As ListBox
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
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents RetirosBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PagosBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EstadoBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents QuitFilterButton As Button
    Friend WithEvents AdminPayMentPanel As Panel
End Class
