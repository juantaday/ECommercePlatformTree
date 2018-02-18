<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmList_ClientRates
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Panelfoot = New System.Windows.Forms.Panel()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.TotalListLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.PanelSetting = New System.Windows.Forms.Panel()
        Me.QuitFilterButton = New System.Windows.Forms.Button()
        Me.CreditButton = New System.Windows.Forms.Button()
        Me.SetRatesButton = New System.Windows.Forms.Button()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.DeleteRatesButton = New System.Windows.Forms.Button()
        Me.CheckBoxSeelct = New System.Windows.Forms.CheckBox()
        Me.ContextMenuAdd_new = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotRatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.idPersonaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idClienteclm = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PanelMenu.SuspendLayout()
        Me.Panelfoot.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelView.SuspendLayout()
        Me.PanelSetting.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.ContextMenuAdd_new.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.PrintAllButton)
        Me.PanelMenu.Controls.Add(Me.Save_Button)
        Me.PanelMenu.Controls.Add(Me.UpdateButton)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(8, 8)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1072, 42)
        Me.PanelMenu.TabIndex = 10
        '
        'PrintAllButton
        '
        Me.PrintAllButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintAllButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.PrintAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintAllButton.Location = New System.Drawing.Point(196, 0)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(122, 40)
        Me.PrintAllButton.TabIndex = 13
        Me.PrintAllButton.Text = "Imprimir todo.."
        Me.PrintAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'Save_Button
        '
        Me.Save_Button.Dock = System.Windows.Forms.DockStyle.Left
        Me.Save_Button.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_32
        Me.Save_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save_Button.Location = New System.Drawing.Point(105, 0)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(91, 40)
        Me.Save_Button.TabIndex = 12
        Me.Save_Button.Text = "Guardar.."
        Me.Save_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.UpdateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Update_32
        Me.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateButton.Location = New System.Drawing.Point(0, 0)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(105, 40)
        Me.UpdateButton.TabIndex = 11
        Me.UpdateButton.Text = "Actualizar.."
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Panelfoot
        '
        Me.Panelfoot.Controls.Add(Me.DireccionLabel)
        Me.Panelfoot.Controls.Add(Me.TotalListLabel)
        Me.Panelfoot.Controls.Add(Me.OkButton)
        Me.Panelfoot.Controls.Add(Me.closeButton)
        Me.Panelfoot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelfoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelfoot.Location = New System.Drawing.Point(8, 425)
        Me.Panelfoot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panelfoot.Name = "Panelfoot"
        Me.Panelfoot.Padding = New System.Windows.Forms.Padding(8, 3, 8, 0)
        Me.Panelfoot.Size = New System.Drawing.Size(1072, 36)
        Me.Panelfoot.TabIndex = 19
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(168, 12)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(0, 17)
        Me.DireccionLabel.TabIndex = 5
        '
        'TotalListLabel
        '
        Me.TotalListLabel.AutoSize = True
        Me.TotalListLabel.Location = New System.Drawing.Point(5, 12)
        Me.TotalListLabel.Name = "TotalListLabel"
        Me.TotalListLabel.Size = New System.Drawing.Size(0, 17)
        Me.TotalListLabel.TabIndex = 4
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Black
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.OkButton.ForeColor = System.Drawing.Color.White
        Me.OkButton.Location = New System.Drawing.Point(841, 3)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(118, 33)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "Aceptar."
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Black
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(959, 3)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(105, 33)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar."
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPersonaClm, Me.idClienteclm, Me.ApellidosClm, Me.NombreClm, Me.IsSelectClm, Me.Ruc_CiClm, Me.ClienteClm, Me.DireccionClm, Me.telefonoClm, Me.mailClm, Me.idRatesClm, Me.DescriptionClm, Me.TarifaClm})
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(3, 42)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(1066, 330)
        Me.dtg.TabIndex = 20
        '
        'PanelView
        '
        Me.PanelView.BackColor = System.Drawing.Color.LightGreen
        Me.PanelView.Controls.Add(Me.dtg)
        Me.PanelView.Controls.Add(Me.PanelSetting)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(8, 50)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelView.Size = New System.Drawing.Size(1072, 375)
        Me.PanelView.TabIndex = 20
        '
        'PanelSetting
        '
        Me.PanelSetting.BackColor = System.Drawing.Color.LightGreen
        Me.PanelSetting.Controls.Add(Me.QuitFilterButton)
        Me.PanelSetting.Controls.Add(Me.CreditButton)
        Me.PanelSetting.Controls.Add(Me.SetRatesButton)
        Me.PanelSetting.Controls.Add(Me.PanelFind)
        Me.PanelSetting.Controls.Add(Me.DeleteRatesButton)
        Me.PanelSetting.Controls.Add(Me.CheckBoxSeelct)
        Me.PanelSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSetting.Location = New System.Drawing.Point(3, 3)
        Me.PanelSetting.Name = "PanelSetting"
        Me.PanelSetting.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelSetting.Size = New System.Drawing.Size(1066, 39)
        Me.PanelSetting.TabIndex = 7
        '
        'QuitFilterButton
        '
        Me.QuitFilterButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.QuitFilterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.not_Filter_16
        Me.QuitFilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitFilterButton.Location = New System.Drawing.Point(508, 2)
        Me.QuitFilterButton.Name = "QuitFilterButton"
        Me.QuitFilterButton.Size = New System.Drawing.Size(144, 35)
        Me.QuitFilterButton.TabIndex = 5
        Me.QuitFilterButton.Text = "Quitar el filtro"
        Me.QuitFilterButton.UseVisualStyleBackColor = False
        Me.QuitFilterButton.Visible = False
        '
        'CreditButton
        '
        Me.CreditButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CreditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditButton.ForeColor = System.Drawing.Color.Green
        Me.CreditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Credid_48
        Me.CreditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreditButton.Location = New System.Drawing.Point(460, 2)
        Me.CreditButton.Name = "CreditButton"
        Me.CreditButton.Size = New System.Drawing.Size(48, 35)
        Me.CreditButton.TabIndex = 10
        Me.CreditButton.Text = "Determinar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "monto crédito."
        Me.CreditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CreditButton.UseVisualStyleBackColor = False
        Me.CreditButton.Visible = False
        '
        'SetRatesButton
        '
        Me.SetRatesButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SetRatesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetRatesButton.ForeColor = System.Drawing.Color.Green
        Me.SetRatesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Rates_24
        Me.SetRatesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SetRatesButton.Location = New System.Drawing.Point(316, 2)
        Me.SetRatesButton.Name = "SetRatesButton"
        Me.SetRatesButton.Size = New System.Drawing.Size(144, 35)
        Me.SetRatesButton.TabIndex = 9
        Me.SetRatesButton.Text = "Aplicar tarifa"
        Me.SetRatesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SetRatesButton.UseVisualStyleBackColor = False
        Me.SetRatesButton.Visible = False
        '
        'PanelFind
        '
        Me.PanelFind.BackColor = System.Drawing.Color.LightGreen
        Me.PanelFind.Controls.Add(Me.FindTextBox)
        Me.PanelFind.Controls.Add(Me.FindButton)
        Me.PanelFind.Controls.Add(Me.SettingButton)
        Me.PanelFind.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelFind.Location = New System.Drawing.Point(675, 2)
        Me.PanelFind.Name = "PanelFind"
        Me.PanelFind.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelFind.Size = New System.Drawing.Size(389, 35)
        Me.PanelFind.TabIndex = 8
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox.Location = New System.Drawing.Point(1, 1)
        Me.FindTextBox.Multiline = True
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(268, 33)
        Me.FindTextBox.TabIndex = 7
        '
        'FindButton
        '
        Me.FindButton.BackColor = System.Drawing.Color.LightGreen
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.Enabled = False
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.FindButton.Location = New System.Drawing.Point(269, 1)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(36, 33)
        Me.FindButton.TabIndex = 6
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'SettingButton
        '
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingButton.Location = New System.Drawing.Point(305, 1)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(83, 33)
        Me.SettingButton.TabIndex = 8
        Me.SettingButton.Text = "Herraminetas"
        Me.SettingButton.UseVisualStyleBackColor = False
        '
        'DeleteRatesButton
        '
        Me.DeleteRatesButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteRatesButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteRatesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteRatesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteRatesButton.Location = New System.Drawing.Point(198, 2)
        Me.DeleteRatesButton.Name = "DeleteRatesButton"
        Me.DeleteRatesButton.Size = New System.Drawing.Size(118, 35)
        Me.DeleteRatesButton.TabIndex = 7
        Me.DeleteRatesButton.Text = "Eliminar tarifa"
        Me.DeleteRatesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteRatesButton.UseVisualStyleBackColor = False
        Me.DeleteRatesButton.Visible = False
        '
        'CheckBoxSeelct
        '
        Me.CheckBoxSeelct.AutoSize = True
        Me.CheckBoxSeelct.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBoxSeelct.Location = New System.Drawing.Point(2, 2)
        Me.CheckBoxSeelct.Name = "CheckBoxSeelct"
        Me.CheckBoxSeelct.Padding = New System.Windows.Forms.Padding(50, 1, 5, 1)
        Me.CheckBoxSeelct.Size = New System.Drawing.Size(196, 35)
        Me.CheckBoxSeelct.TabIndex = 6
        Me.CheckBoxSeelct.Text = "Seleccionar todo.."
        Me.CheckBoxSeelct.UseVisualStyleBackColor = True
        '
        'ContextMenuAdd_new
        '
        Me.ContextMenuAdd_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RatesToolStripMenuItem, Me.NotRatesToolStripMenuItem, Me.SelectToolStripMenuItem})
        Me.ContextMenuAdd_new.Name = "ContextMenuAdd_new"
        Me.ContextMenuAdd_new.Size = New System.Drawing.Size(239, 92)
        '
        'RatesToolStripMenuItem
        '
        Me.RatesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Rates_24
        Me.RatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RatesToolStripMenuItem.Name = "RatesToolStripMenuItem"
        Me.RatesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.RatesToolStripMenuItem.Size = New System.Drawing.Size(238, 28)
        Me.RatesToolStripMenuItem.Text = "Agrupra los que tienen tarifa"
        '
        'NotRatesToolStripMenuItem
        '
        Me.NotRatesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.RatesNot_24
        Me.NotRatesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NotRatesToolStripMenuItem.Name = "NotRatesToolStripMenuItem"
        Me.NotRatesToolStripMenuItem.Size = New System.Drawing.Size(238, 30)
        Me.NotRatesToolStripMenuItem.Text = "Filtrar a los que no tiene tarifa"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.check_16
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(238, 30)
        Me.SelectToolStripMenuItem.Text = "Filtrar los seleccionados."
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
        Me.IsSelectClm.Width = 20
        '
        'Ruc_CiClm
        '
        Me.Ruc_CiClm.DataPropertyName = "Ruc_Ci"
        Me.Ruc_CiClm.HeaderText = "Ruc (o )C.I."
        Me.Ruc_CiClm.Name = "Ruc_CiClm"
        Me.Ruc_CiClm.ReadOnly = True
        '
        'ClienteClm
        '
        Me.ClienteClm.DataPropertyName = "FullName"
        Me.ClienteClm.HeaderText = "Cliente"
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
        '
        'FrmList_ClientRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 469)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.Panelfoot)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FrmList_ClientRates"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Tarifas aplicadas a clientes"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panelfoot.ResumeLayout(False)
        Me.Panelfoot.PerformLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelView.ResumeLayout(False)
        Me.PanelSetting.ResumeLayout(False)
        Me.PanelSetting.PerformLayout()
        Me.PanelFind.ResumeLayout(False)
        Me.PanelFind.PerformLayout()
        Me.ContextMenuAdd_new.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents Save_Button As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Panelfoot As Panel
    Friend WithEvents OkButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents dtg As DataGridView
    Friend WithEvents PanelView As Panel
    Friend WithEvents PanelSetting As Panel
    Friend WithEvents PanelFind As Panel
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents FindButton As Button
    Friend WithEvents QuitFilterButton As Button
    Friend WithEvents DeleteRatesButton As Button
    Friend WithEvents CheckBoxSeelct As CheckBox
    Friend WithEvents TotalListLabel As Label
    Friend WithEvents DireccionLabel As Label
    Friend WithEvents SetRatesButton As Button
    Friend WithEvents CreditButton As Button
    Friend WithEvents SettingButton As Button
    Friend WithEvents ContextMenuAdd_new As ContextMenuStrip
    Friend WithEvents RatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotRatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idPersonaClm As DataGridViewTextBoxColumn
    Friend WithEvents idClienteclm As DataGridViewTextBoxColumn
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
End Class
