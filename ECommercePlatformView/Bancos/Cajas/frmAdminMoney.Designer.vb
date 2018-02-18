<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMoney
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VilleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboMenu = New System.Windows.Forms.ToolStripComboBox()
        Me.TitleMenu = New System.Windows.Forms.ToolStripTextBox()
        Me.RealizedMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.cancel_Button = New System.Windows.Forms.Button()
        Me.PanelData = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.ValorManualTextBox = New System.Windows.Forms.TextBox()
        Me.ConfimButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelData.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.GroupBoxInputData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionMenu, Me.ComboMenu, Me.TitleMenu, Me.RealizedMenu, Me.DeleteMenu, Me.EditMenu, Me.ReturToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 54)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Realizar"
        '
        'OptionMenu
        '
        Me.OptionMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditMenuItem, Me.EliminarToolStripMenuItem})
        Me.OptionMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.men_punto_48x48
        Me.OptionMenu.Name = "OptionMenu"
        Me.OptionMenu.Size = New System.Drawing.Size(28, 50)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.VilleteToolStripMenuItem})
        Me.AddToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Tag = "0"
        Me.AddToolStripMenuItem.Text = "Agregar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripMenuItem1.Text = "Modeda"
        '
        'VilleteToolStripMenuItem
        '
        Me.VilleteToolStripMenuItem.Name = "VilleteToolStripMenuItem"
        Me.VilleteToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.VilleteToolStripMenuItem.Text = "Villete"
        '
        'EditMenuItem
        '
        Me.EditMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EditMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditMenuItem.Tag = "0"
        Me.EditMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ComboMenu
        '
        Me.ComboMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ComboMenu.Name = "ComboMenu"
        Me.ComboMenu.Size = New System.Drawing.Size(350, 50)
        '
        'TitleMenu
        '
        Me.TitleMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TitleMenu.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.TitleMenu.ForeColor = System.Drawing.Color.White
        Me.TitleMenu.HideSelection = False
        Me.TitleMenu.Name = "TitleMenu"
        Me.TitleMenu.ReadOnly = True
        Me.TitleMenu.Size = New System.Drawing.Size(350, 50)
        Me.TitleMenu.Text = "Administracion de monedas"
        Me.TitleMenu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RealizedMenu
        '
        Me.RealizedMenu.AutoSize = False
        Me.RealizedMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RealizedMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.checkbox_notChecked_16
        Me.RealizedMenu.Name = "RealizedMenu"
        Me.RealizedMenu.Size = New System.Drawing.Size(40, 50)
        Me.RealizedMenu.Tag = "0"
        Me.RealizedMenu.Visible = False
        '
        'DeleteMenu
        '
        Me.DeleteMenu.BackColor = System.Drawing.Color.Red
        Me.DeleteMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteMenu.ForeColor = System.Drawing.Color.White
        Me.DeleteMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteMenu.Name = "DeleteMenu"
        Me.DeleteMenu.Size = New System.Drawing.Size(86, 50)
        Me.DeleteMenu.Text = "Eliminar"
        Me.DeleteMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DeleteMenu.Visible = False
        '
        'EditMenu
        '
        Me.EditMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EditMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit_32x32
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(65, 50)
        Me.EditMenu.Text = "Editar"
        Me.EditMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.EditMenu.Visible = False
        '
        'ReturToolStripMenuItem
        '
        Me.ReturToolStripMenuItem.AutoSize = False
        Me.ReturToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.arrow_left_48x48
        Me.ReturToolStripMenuItem.Name = "ReturToolStripMenuItem"
        Me.ReturToolStripMenuItem.Size = New System.Drawing.Size(60, 50)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OkButton)
        Me.Panel1.Controls.Add(Me.cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 47)
        Me.Panel1.TabIndex = 1
        '
        'OkButton
        '
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.OkButton.Location = New System.Drawing.Point(601, 0)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(110, 47)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "Aceptar"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'cancel_Button
        '
        Me.cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancel_Button.Location = New System.Drawing.Point(711, 0)
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(110, 47)
        Me.cancel_Button.TabIndex = 1
        Me.cancel_Button.Text = "Cancelar"
        Me.cancel_Button.UseVisualStyleBackColor = True
        '
        'PanelData
        '
        Me.PanelData.Controls.Add(Me.PanelView)
        Me.PanelData.Controls.Add(Me.PanelTop)
        Me.PanelData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelData.Location = New System.Drawing.Point(0, 54)
        Me.PanelData.Name = "PanelData"
        Me.PanelData.Size = New System.Drawing.Size(821, 379)
        Me.PanelData.TabIndex = 0
        '
        'PanelView
        '
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 65)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(821, 314)
        Me.PanelView.TabIndex = 1
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.GroupBoxInputData)
        Me.PanelTop.Controls.Add(Me.GroupBox1)
        Me.PanelTop.Controls.Add(Me.TotalLabel)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(821, 65)
        Me.PanelTop.TabIndex = 0
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.ValorManualTextBox)
        Me.GroupBoxInputData.Controls.Add(Me.ConfimButton)
        Me.GroupBoxInputData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInputData.Location = New System.Drawing.Point(155, 1)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(235, 62)
        Me.GroupBoxInputData.TabIndex = 0
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Determine el valor total"
        Me.GroupBoxInputData.Visible = False
        '
        'ValorManualTextBox
        '
        Me.ValorManualTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorManualTextBox.Location = New System.Drawing.Point(6, 23)
        Me.ValorManualTextBox.Name = "ValorManualTextBox"
        Me.ValorManualTextBox.Size = New System.Drawing.Size(189, 26)
        Me.ValorManualTextBox.TabIndex = 0
        Me.ValorManualTextBox.Text = "0.00"
        Me.ValorManualTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ConfimButton
        '
        Me.ConfimButton.Image = Global.ECommercePlatformView.My.Resources.Resources.ok_16
        Me.ConfimButton.Location = New System.Drawing.Point(201, 20)
        Me.ConfimButton.Name = "ConfimButton"
        Me.ConfimButton.Size = New System.Drawing.Size(30, 29)
        Me.ConfimButton.TabIndex = 1
        Me.ConfimButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 62)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de ingreso"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cálculo  por detalle"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 19)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "Conteo manual"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.BackColor = System.Drawing.Color.Red
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.White
        Me.TotalLabel.Location = New System.Drawing.Point(673, 0)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(148, 71)
        Me.TotalLabel.TabIndex = 6
        Me.TotalLabel.Text = "0.00"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmAdminMoney
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 480)
        Me.Controls.Add(Me.PanelData)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmAdminMoney"
        Me.Text = "Administración de monedas."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelData.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionMenu As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleMenu As ToolStripTextBox
    Friend WithEvents ReturToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboMenu As ToolStripComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelData As System.Windows.Forms.Panel
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents TotalLabel As Label
    Friend WithEvents GroupBoxInputData As GroupBox
    Friend WithEvents ConfimButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents OkButton As Button
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents EditMenuItem As ToolStripMenuItem
    Friend WithEvents RealizedMenu As ToolStripMenuItem
    Friend WithEvents DeleteMenu As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ValorManualTextBox As TextBox
    Friend WithEvents cancel_Button As Button
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VilleteToolStripMenuItem As ToolStripMenuItem
End Class