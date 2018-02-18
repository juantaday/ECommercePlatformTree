<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMyCommerce
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
        Me.menuDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropietariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuWhereHouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelFood = New System.Windows.Forms.Panel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PanelViewData = New System.Windows.Forms.Panel()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelFood.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDetalle, Me.PropietariosToolStripMenuItem, Me.menuConfiguracion, Me.EmpleadosToolStripMenuItem, Me.menuWhereHouse, Me.menuProveedor})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip1.MdiWindowListItem = Me.menuProveedor
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(186, 440)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuDetalle
        '
        Me.menuDetalle.AutoSize = False
        Me.menuDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.menuDetalle.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_Whit24
        Me.menuDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuDetalle.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.menuDetalle.Name = "menuDetalle"
        Me.menuDetalle.Size = New System.Drawing.Size(180, 33)
        Me.menuDetalle.Text = "   &Detalle"
        Me.menuDetalle.ToolTipText = "Detalle del prodcuto..."
        '
        'PropietariosToolStripMenuItem
        '
        Me.PropietariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PropietariosToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Onwer_32
        Me.PropietariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PropietariosToolStripMenuItem.Name = "PropietariosToolStripMenuItem"
        Me.PropietariosToolStripMenuItem.Size = New System.Drawing.Size(138, 36)
        Me.PropietariosToolStripMenuItem.Text = "Propietarios"
        '
        'menuConfiguracion
        '
        Me.menuConfiguracion.AutoSize = False
        Me.menuConfiguracion.ForeColor = System.Drawing.Color.White
        Me.menuConfiguracion.Image = Global.ECommercePlatformView.My.Resources.Resources.Herram_icon_32
        Me.menuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuConfiguracion.Name = "menuConfiguracion"
        Me.menuConfiguracion.Size = New System.Drawing.Size(180, 33)
        Me.menuConfiguracion.Text = "Con&figuración"
        '
        'menuWhereHouse
        '
        Me.menuWhereHouse.AutoSize = False
        Me.menuWhereHouse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.menuWhereHouse.Image = Global.ECommercePlatformView.My.Resources.Resources.WhereHouse_Whit_24
        Me.menuWhereHouse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuWhereHouse.Name = "menuWhereHouse"
        Me.menuWhereHouse.Size = New System.Drawing.Size(180, 33)
        Me.menuWhereHouse.Text = "  &Locales y bodegas"
        Me.menuWhereHouse.ToolTipText = "Cantidad en cada contenido.."
        '
        'menuProveedor
        '
        Me.menuProveedor.AutoSize = False
        Me.menuProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.menuProveedor.Image = Global.ECommercePlatformView.My.Resources.Resources.Sales_32x32
        Me.menuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuProveedor.Name = "menuProveedor"
        Me.menuProveedor.Size = New System.Drawing.Size(180, 33)
        Me.menuProveedor.Text = "&Proveedores"
        Me.menuProveedor.ToolTipText = "Proveedores que venden este producto"
        '
        'PanelFood
        '
        Me.PanelFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFood.Controls.Add(Me.Cancel_Button)
        Me.PanelFood.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelFood.Location = New System.Drawing.Point(2, 442)
        Me.PanelFood.Name = "PanelFood"
        Me.PanelFood.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelFood.Size = New System.Drawing.Size(880, 37)
        Me.PanelFood.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(742, 2)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(134, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cerrar"
        '
        'PanelViewData
        '
        Me.PanelViewData.AutoScroll = True
        Me.PanelViewData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewData.Location = New System.Drawing.Point(188, 2)
        Me.PanelViewData.Name = "PanelViewData"
        Me.PanelViewData.Size = New System.Drawing.Size(694, 440)
        Me.PanelViewData.TabIndex = 5
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpleadosToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Empleado_24
        Me.EmpleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'frmMyCommerce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(884, 481)
        Me.Controls.Add(Me.PanelViewData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelFood)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 520)
        Me.MinimizeBox = False
        Me.Name = "frmMyCommerce"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mi negocio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelFood.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuConfiguracion As ToolStripMenuItem
    Friend WithEvents menuDetalle As ToolStripMenuItem
    Friend WithEvents menuWhereHouse As ToolStripMenuItem
    Friend WithEvents menuProveedor As ToolStripMenuItem
    Friend WithEvents PanelFood As Panel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents PanelViewData As Panel
    Friend WithEvents PropietariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
