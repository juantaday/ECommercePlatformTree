<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_AddProductos
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
        Me.MenuStripTiple = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CancelButon = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPresentacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProdcutodesc = New System.Windows.Forms.Label()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ControlTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SiguienteButton = New System.Windows.Forms.Button()
        Me.AtrasButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStripTiple.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ControlTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripTiple
        '
        Me.MenuStripTiple.AutoSize = False
        Me.MenuStripTiple.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStripTiple.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripTiple.Name = "MenuStripTiple"
        Me.MenuStripTiple.Size = New System.Drawing.Size(997, 29)
        Me.MenuStripTiple.TabIndex = 5
        Me.MenuStripTiple.Text = "MenuStrip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 25)
        '
        'CancelButon
        '
        Me.CancelButon.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelButon.Location = New System.Drawing.Point(695, 3)
        Me.CancelButon.Name = "CancelButon"
        Me.CancelButon.Size = New System.Drawing.Size(82, 31)
        Me.CancelButon.TabIndex = 15
        Me.CancelButon.Text = "Cancelar"
        Me.ToolTip.SetToolTip(Me.CancelButon, "Cerrar el formulario")
        Me.CancelButon.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkButton.Enabled = False
        Me.OkButton.Location = New System.Drawing.Point(593, 3)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(96, 31)
        Me.OkButton.TabIndex = 15
        Me.OkButton.Text = "Aplicar"
        Me.ToolTip.SetToolTip(Me.OkButton, "Guardar toda la información..")
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDetalle, Me.menuCategory, Me.menuPresentacion, Me.menuConfiguracion, Me.menuProveedor})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 50)
        Me.MenuStrip1.MdiWindowListItem = Me.menuProveedor
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(168, 424)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.TabStop = True
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuDetalle
        '
        Me.menuDetalle.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.menuDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuDetalle.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.menuDetalle.Name = "menuDetalle"
        Me.menuDetalle.Size = New System.Drawing.Size(135, 36)
        Me.menuDetalle.Text = "&Descripción"
        Me.menuDetalle.ToolTipText = "Detalle del prodcuto..."
        '
        'menuCategory
        '
        Me.menuCategory.Image = Global.ECommercePlatformView.My.Resources.Resources.BO_Category_32x32
        Me.menuCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuCategory.Name = "menuCategory"
        Me.menuCategory.Size = New System.Drawing.Size(121, 36)
        Me.menuCategory.Text = "&Categoria"
        Me.menuCategory.ToolTipText = "Categoria en la que se encuentra en producto"
        '
        'menuPresentacion
        '
        Me.menuPresentacion.Image = Global.ECommercePlatformView.My.Resources.Resources.CrossbandBox_32x32
        Me.menuPresentacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuPresentacion.Name = "menuPresentacion"
        Me.menuPresentacion.Size = New System.Drawing.Size(143, 36)
        Me.menuPresentacion.Text = "&Presentación"
        Me.menuPresentacion.ToolTipText = "Cantidad en cada contenido.."
        '
        'menuConfiguracion
        '
        Me.menuConfiguracion.Image = Global.ECommercePlatformView.My.Resources.Resources.Herram_icon_32
        Me.menuConfiguracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuConfiguracion.Name = "menuConfiguracion"
        Me.menuConfiguracion.Size = New System.Drawing.Size(152, 36)
        Me.menuConfiguracion.Text = "Con&figuración"
        '
        'menuProveedor
        '
        Me.menuProveedor.Image = Global.ECommercePlatformView.My.Resources.Resources.Sales_32x32
        Me.menuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.menuProveedor.Name = "menuProveedor"
        Me.menuProveedor.Size = New System.Drawing.Size(141, 36)
        Me.menuProveedor.Text = "&Proveedores"
        Me.menuProveedor.ToolTipText = "Proveedores que venden este producto"
        '
        'lblProdcutodesc
        '
        Me.lblProdcutodesc.AutoSize = True
        Me.lblProdcutodesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdcutodesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProdcutodesc.Location = New System.Drawing.Point(10, 3)
        Me.lblProdcutodesc.Name = "lblProdcutodesc"
        Me.lblProdcutodesc.Size = New System.Drawing.Size(77, 26)
        Me.lblProdcutodesc.TabIndex = 11
        Me.lblProdcutodesc.Text = "Label1"
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(997, 21)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.AutoSize = False
        Me.NewToolStripButton.ForeColor = System.Drawing.Color.Blue
        Me.NewToolStripButton.Image = Global.ECommercePlatformView.My.Resources.Resources.List_32x32
        Me.NewToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(180, 25)
        Me.NewToolStripButton.Text = "Listado de productos.."
        Me.NewToolStripButton.ToolTipText = "Listado de productos"
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.Location = New System.Drawing.Point(168, 50)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(829, 40)
        Me.MenuStrip.TabIndex = 13
        Me.MenuStrip.Text = "MenuStrip2"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ControlTableLayout
        '
        Me.ControlTableLayout.BackColor = System.Drawing.SystemColors.Control
        Me.ControlTableLayout.ColumnCount = 6
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.ControlTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.ControlTableLayout.Controls.Add(Me.CancelButon, 4, 0)
        Me.ControlTableLayout.Controls.Add(Me.OkButton, 3, 0)
        Me.ControlTableLayout.Controls.Add(Me.SiguienteButton, 2, 0)
        Me.ControlTableLayout.Controls.Add(Me.AtrasButton, 1, 0)
        Me.ControlTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlTableLayout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlTableLayout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ControlTableLayout.Location = New System.Drawing.Point(168, 415)
        Me.ControlTableLayout.Name = "ControlTableLayout"
        Me.ControlTableLayout.RowCount = 1
        Me.ControlTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ControlTableLayout.Size = New System.Drawing.Size(829, 37)
        Me.ControlTableLayout.TabIndex = 17
        '
        'SiguienteButton
        '
        Me.SiguienteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SiguienteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiguienteButton.Location = New System.Drawing.Point(485, 3)
        Me.SiguienteButton.Name = "SiguienteButton"
        Me.SiguienteButton.Size = New System.Drawing.Size(102, 31)
        Me.SiguienteButton.TabIndex = 17
        Me.SiguienteButton.Text = "Siguiente=>"
        Me.SiguienteButton.UseVisualStyleBackColor = True
        '
        'AtrasButton
        '
        Me.AtrasButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AtrasButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AtrasButton.Location = New System.Drawing.Point(375, 3)
        Me.AtrasButton.Name = "AtrasButton"
        Me.AtrasButton.Size = New System.Drawing.Size(104, 31)
        Me.AtrasButton.TabIndex = 16
        Me.AtrasButton.Text = "<= Atrás"
        Me.AtrasButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(168, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(829, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MDI_AddProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelButon
        Me.ClientSize = New System.Drawing.Size(997, 474)
        Me.Controls.Add(Me.ControlTableLayout)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.lblProdcutodesc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStripTiple)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1013, 513)
        Me.Name = "MDI_AddProductos"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Administrando PRODUCTOS ...--"
        Me.TransparencyKey = System.Drawing.Color.YellowGreen
        Me.MenuStripTiple.ResumeLayout(False)
        Me.MenuStripTiple.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ControlTableLayout.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStripTiple As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPresentacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblProdcutodesc As System.Windows.Forms.Label
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents CancelButon As System.Windows.Forms.Button
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ControlTableLayout As TableLayoutPanel
    Friend WithEvents AtrasButton As Button
    Friend WithEvents SiguienteButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents menuConfiguracion As ToolStripMenuItem
End Class
