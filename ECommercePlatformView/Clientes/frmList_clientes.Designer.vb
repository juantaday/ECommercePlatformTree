<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_clientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_clientes))
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnCobro = New System.Windows.Forms.Button()
        Me.lblnoExiste = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblformaPago = New System.Windows.Forms.Label()
        Me.FlowMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.PaneBusca = New System.Windows.Forms.Panel()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.PanePie = New System.Windows.Forms.Panel()
        Me.TotalListLabel = New System.Windows.Forms.Label()
        Me.ContextMenuAdd_new = New System.Windows.Forms.ContextMenuStrip()
        Me.NuevosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CereditAutorizationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebtbalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowMenu.SuspendLayout()
        Me.PaneBusca.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.PanePie.SuspendLayout()
        Me.ContextMenuAdd_new.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtg.BackgroundColor = System.Drawing.Color.White
        Me.dtg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(0, 114)
        Me.dtg.MultiSelect = False
        Me.dtg.Name = "dtg"
        Me.dtg.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtg.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg.Size = New System.Drawing.Size(948, 326)
        Me.dtg.TabIndex = 18
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = Global.ECommercePlatformView.My.Resources.Resources.add_client_48
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(227, 1)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(66, 68)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "Agregar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Agregar Nuevos Clientes")
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnEditarCliente.Image = Global.ECommercePlatformView.My.Resources.Resources.Edd_client_48
        Me.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditarCliente.Location = New System.Drawing.Point(295, 1)
        Me.btnEditarCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(66, 68)
        Me.btnEditarCliente.TabIndex = 24
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEditarCliente, "Editar cliente")
        Me.btnEditarCliente.UseVisualStyleBackColor = False
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.Red
        Me.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCliente.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_cliente_48
        Me.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarCliente.Location = New System.Drawing.Point(363, 1)
        Me.btnEliminarCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(66, 68)
        Me.btnEliminarCliente.TabIndex = 25
        Me.btnEliminarCliente.Text = "Elimina"
        Me.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEliminarCliente, "Eliminar el cliente selecionado")
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'btnCredit
        '
        Me.btnCredit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCredit.BackColor = System.Drawing.Color.White
        Me.btnCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredit.ForeColor = System.Drawing.Color.Black
        Me.btnCredit.Image = Global.ECommercePlatformView.My.Resources.Resources.Monto_48
        Me.btnCredit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCredit.Location = New System.Drawing.Point(525, 1)
        Me.btnCredit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(66, 68)
        Me.btnCredit.TabIndex = 25
        Me.btnCredit.Text = "Monto"
        Me.btnCredit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCredit, "Determinar el monto de crédito.....")
        Me.btnCredit.UseVisualStyleBackColor = False
        '
        'btnCobro
        '
        Me.btnCobro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCobro.BackColor = System.Drawing.Color.White
        Me.btnCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobro.ForeColor = System.Drawing.Color.Black
        Me.btnCobro.Image = Global.ECommercePlatformView.My.Resources.Resources.cobro_48
        Me.btnCobro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCobro.Location = New System.Drawing.Point(593, 1)
        Me.btnCobro.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(66, 68)
        Me.btnCobro.TabIndex = 25
        Me.btnCobro.Text = "Cobro"
        Me.btnCobro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnCobro, "Estado de cuenta (deudas)")
        Me.btnCobro.UseVisualStyleBackColor = False
        '
        'lblnoExiste
        '
        Me.lblnoExiste.AutoSize = True
        Me.lblnoExiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoExiste.ForeColor = System.Drawing.Color.Red
        Me.lblnoExiste.Location = New System.Drawing.Point(12, 143)
        Me.lblnoExiste.Name = "lblnoExiste"
        Me.lblnoExiste.Size = New System.Drawing.Size(183, 20)
        Me.lblnoExiste.TabIndex = 32
        Me.lblnoExiste.Text = "No Existe información"
        Me.lblnoExiste.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(865, 0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(83, 42)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(789, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(76, 42)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'lblformaPago
        '
        Me.lblformaPago.AutoSize = True
        Me.lblformaPago.BackColor = System.Drawing.Color.SpringGreen
        Me.lblformaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformaPago.Location = New System.Drawing.Point(605, 292)
        Me.lblformaPago.Name = "lblformaPago"
        Me.lblformaPago.Size = New System.Drawing.Size(0, 20)
        Me.lblformaPago.TabIndex = 32
        Me.lblformaPago.Visible = False
        '
        'FlowMenu
        '
        Me.FlowMenu.BackColor = System.Drawing.SystemColors.HotTrack
        Me.FlowMenu.Controls.Add(Me.Label5)
        Me.FlowMenu.Controls.Add(Me.btnNuevo)
        Me.FlowMenu.Controls.Add(Me.btnEditarCliente)
        Me.FlowMenu.Controls.Add(Me.btnEliminarCliente)
        Me.FlowMenu.Controls.Add(Me.Label4)
        Me.FlowMenu.Controls.Add(Me.btnDetail)
        Me.FlowMenu.Controls.Add(Me.btnCredit)
        Me.FlowMenu.Controls.Add(Me.btnCobro)
        Me.FlowMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowMenu.Location = New System.Drawing.Point(0, 0)
        Me.FlowMenu.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowMenu.Name = "FlowMenu"
        Me.FlowMenu.Size = New System.Drawing.Size(948, 74)
        Me.FlowMenu.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 29)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Listado de clientes."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Location = New System.Drawing.Point(433, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 70)
        Me.Label4.TabIndex = 30
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetail.BackColor = System.Drawing.Color.White
        Me.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.Image = Global.ECommercePlatformView.My.Resources.Resources.detail_user_48
        Me.btnDetail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetail.Location = New System.Drawing.Point(457, 1)
        Me.btnDetail.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(66, 68)
        Me.btnDetail.TabIndex = 25
        Me.btnDetail.Text = "Detalle"
        Me.btnDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetail.UseVisualStyleBackColor = False
        '
        'PaneBusca
        '
        Me.PaneBusca.BackColor = System.Drawing.Color.AliceBlue
        Me.PaneBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneBusca.Controls.Add(Me.PanelFind)
        Me.PaneBusca.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneBusca.Location = New System.Drawing.Point(0, 74)
        Me.PaneBusca.Name = "PaneBusca"
        Me.PaneBusca.Padding = New System.Windows.Forms.Padding(2)
        Me.PaneBusca.Size = New System.Drawing.Size(948, 40)
        Me.PaneBusca.TabIndex = 39
        '
        'PanelFind
        '
        Me.PanelFind.BackColor = System.Drawing.Color.LightGreen
        Me.PanelFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFind.Controls.Add(Me.FindTextBox)
        Me.PanelFind.Controls.Add(Me.FindButton)
        Me.PanelFind.Controls.Add(Me.SettingButton)
        Me.PanelFind.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelFind.Location = New System.Drawing.Point(478, 2)
        Me.PanelFind.Name = "PanelFind"
        Me.PanelFind.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelFind.Size = New System.Drawing.Size(466, 34)
        Me.PanelFind.TabIndex = 9
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindTextBox.Location = New System.Drawing.Point(1, 1)
        Me.FindTextBox.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.FindTextBox.Multiline = True
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(343, 30)
        Me.FindTextBox.TabIndex = 7
        '
        'FindButton
        '
        Me.FindButton.BackColor = System.Drawing.Color.LightGreen
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.FindButton.Location = New System.Drawing.Point(344, 1)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(36, 30)
        Me.FindButton.TabIndex = 6
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'SettingButton
        '
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingButton.Location = New System.Drawing.Point(380, 1)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(83, 30)
        Me.SettingButton.TabIndex = 8
        Me.SettingButton.Text = "Herraminetas"
        Me.SettingButton.UseVisualStyleBackColor = False
        '
        'PanePie
        '
        Me.PanePie.Controls.Add(Me.OK_Button)
        Me.PanePie.Controls.Add(Me.Cancel_Button)
        Me.PanePie.Controls.Add(Me.TotalListLabel)
        Me.PanePie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePie.Location = New System.Drawing.Point(0, 440)
        Me.PanePie.Name = "PanePie"
        Me.PanePie.Size = New System.Drawing.Size(948, 42)
        Me.PanePie.TabIndex = 40
        '
        'TotalListLabel
        '
        Me.TotalListLabel.AutoSize = True
        Me.TotalListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalListLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalListLabel.Location = New System.Drawing.Point(12, 12)
        Me.TotalListLabel.Name = "TotalListLabel"
        Me.TotalListLabel.Size = New System.Drawing.Size(69, 20)
        Me.TotalListLabel.TabIndex = 31
        Me.TotalListLabel.Text = "Total: 0"
        '
        'ContextMenuAdd_new
        '
        Me.ContextMenuAdd_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevosClientesToolStripMenuItem, Me.AllToolStripMenuItem, Me.CereditAutorizationToolStripMenuItem, Me.DebtbalanceToolStripMenuItem})
        Me.ContextMenuAdd_new.Name = "ContextMenuAdd_new"
        Me.ContextMenuAdd_new.Size = New System.Drawing.Size(263, 122)
        '
        'NuevosClientesToolStripMenuItem
        '
        Me.NuevosClientesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.New_People_24
        Me.NuevosClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevosClientesToolStripMenuItem.Name = "NuevosClientesToolStripMenuItem"
        Me.NuevosClientesToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.NuevosClientesToolStripMenuItem.Text = "Clientes nuevos"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_24
        Me.AllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(262, 28)
        Me.AllToolStripMenuItem.Text = "Todos los clientes...."
        '
        'CereditAutorizationToolStripMenuItem
        '
        Me.CereditAutorizationToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Credit_User_24
        Me.CereditAutorizationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CereditAutorizationToolStripMenuItem.Name = "CereditAutorizationToolStripMenuItem"
        Me.CereditAutorizationToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.CereditAutorizationToolStripMenuItem.Text = "Clinetes autorizados para creditos."
        '
        'DebtbalanceToolStripMenuItem
        '
        Me.DebtbalanceToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.deuda_24
        Me.DebtbalanceToolStripMenuItem.Name = "DebtbalanceToolStripMenuItem"
        Me.DebtbalanceToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.DebtbalanceToolStripMenuItem.Text = "Clientes con saldos pendientes."
        '
        'frmList_clientes
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(948, 482)
        Me.Controls.Add(Me.lblnoExiste)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.PaneBusca)
        Me.Controls.Add(Me.FlowMenu)
        Me.Controls.Add(Me.lblformaPago)
        Me.Controls.Add(Me.PanePie)
        Me.Name = "frmList_clientes"
        Me.Text = "Listado de Clientes"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowMenu.ResumeLayout(False)
        Me.FlowMenu.PerformLayout()
        Me.PaneBusca.ResumeLayout(False)
        Me.PanelFind.ResumeLayout(False)
        Me.PanelFind.PerformLayout()
        Me.PanePie.ResumeLayout(False)
        Me.PanePie.PerformLayout()
        Me.ContextMenuAdd_new.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditarCliente As System.Windows.Forms.Button
    Friend WithEvents btnEliminarCliente As System.Windows.Forms.Button
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents lblnoExiste As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblformaPago As System.Windows.Forms.Label
    Friend WithEvents FlowMenu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PaneBusca As System.Windows.Forms.Panel
    Friend WithEvents PanePie As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnCredit As System.Windows.Forms.Button
    Friend WithEvents btnCobro As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalListLabel As Label
    Friend WithEvents PanelFind As Panel
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents FindButton As Button
    Friend WithEvents SettingButton As Button
    Friend WithEvents ContextMenuAdd_new As ContextMenuStrip
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CereditAutorizationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebtbalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevosClientesToolStripMenuItem As ToolStripMenuItem
End Class
