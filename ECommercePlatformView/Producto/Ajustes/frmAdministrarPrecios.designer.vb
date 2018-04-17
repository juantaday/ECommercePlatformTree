<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrarPrecios
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
        Me.paneDatos = New System.Windows.Forms.Panel()
        Me.PanelAdmininPrice = New System.Windows.Forms.Panel()
        Me.btnOfertas = New System.Windows.Forms.Button()
        Me.btnEditaCosto = New System.Windows.Forms.Button()
        Me.detailButton = New System.Windows.Forms.Button()
        Me.newButtonPrice = New System.Windows.Forms.Button()
        Me.PanelAdminState = New System.Windows.Forms.Panel()
        Me.stockButton = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActiva = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.newButtonState = New System.Windows.Forms.Button()
        Me.paneListView = New System.Windows.Forms.Panel()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProduc_Select = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.okButton = New System.Windows.Forms.Button()
        Me.cancel_Button = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevosProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosSinCostoDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosSinCostoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenadosDeMenorUtilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosDemayorUtilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.paneDatos.SuspendLayout()
        Me.PanelAdmininPrice.SuspendLayout()
        Me.PanelAdminState.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'paneDatos
        '
        Me.paneDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneDatos.Controls.Add(Me.PanelAdmininPrice)
        Me.paneDatos.Controls.Add(Me.PanelAdminState)
        Me.paneDatos.Controls.Add(Me.paneListView)
        Me.paneDatos.Controls.Add(Me.PanelControls)
        Me.paneDatos.Location = New System.Drawing.Point(6, 0)
        Me.paneDatos.Name = "paneDatos"
        Me.paneDatos.Size = New System.Drawing.Size(930, 362)
        Me.paneDatos.TabIndex = 0
        '
        'PanelAdmininPrice
        '
        Me.PanelAdmininPrice.Controls.Add(Me.btnOfertas)
        Me.PanelAdmininPrice.Controls.Add(Me.btnEditaCosto)
        Me.PanelAdmininPrice.Controls.Add(Me.detailButton)
        Me.PanelAdmininPrice.Controls.Add(Me.newButtonPrice)
        Me.PanelAdmininPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAdmininPrice.Location = New System.Drawing.Point(5, 114)
        Me.PanelAdmininPrice.Name = "PanelAdmininPrice"
        Me.PanelAdmininPrice.Size = New System.Drawing.Size(723, 41)
        Me.PanelAdmininPrice.TabIndex = 18
        '
        'btnOfertas
        '
        Me.btnOfertas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOfertas.Enabled = False
        Me.btnOfertas.Image = Global.ECommercePlatformView.My.Resources.Resources.Offers_32
        Me.btnOfertas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOfertas.Location = New System.Drawing.Point(318, 0)
        Me.btnOfertas.Name = "btnOfertas"
        Me.btnOfertas.Size = New System.Drawing.Size(133, 41)
        Me.btnOfertas.TabIndex = 3
        Me.btnOfertas.Text = "Administrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ofertas"
        Me.btnOfertas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnOfertas, "Administrar Ofertas")
        Me.btnOfertas.UseVisualStyleBackColor = True
        '
        'btnEditaCosto
        '
        Me.btnEditaCosto.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditaCosto.Enabled = False
        Me.btnEditaCosto.Image = Global.ECommercePlatformView.My.Resources.Resources.confirCost_32
        Me.btnEditaCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditaCosto.Location = New System.Drawing.Point(194, 0)
        Me.btnEditaCosto.Name = "btnEditaCosto"
        Me.btnEditaCosto.Size = New System.Drawing.Size(124, 41)
        Me.btnEditaCosto.TabIndex = 3
        Me.btnEditaCosto.Text = "Ajustar precio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "venta."
        Me.btnEditaCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnEditaCosto, "Modificar costo de Venta")
        Me.btnEditaCosto.UseCompatibleTextRendering = True
        Me.btnEditaCosto.UseVisualStyleBackColor = True
        '
        'detailButton
        '
        Me.detailButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.detailButton.Enabled = False
        Me.detailButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.detailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.detailButton.Location = New System.Drawing.Point(98, 0)
        Me.detailButton.Name = "detailButton"
        Me.detailButton.Size = New System.Drawing.Size(96, 41)
        Me.detailButton.TabIndex = 6
        Me.detailButton.Text = "Detalle."
        Me.detailButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.detailButton, "Detalle del producto")
        Me.detailButton.UseVisualStyleBackColor = True
        '
        'newButtonPrice
        '
        Me.newButtonPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.newButtonPrice.Image = Global.ECommercePlatformView.My.Resources.Resources.new_32
        Me.newButtonPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.newButtonPrice.Location = New System.Drawing.Point(0, 0)
        Me.newButtonPrice.Name = "newButtonPrice"
        Me.newButtonPrice.Size = New System.Drawing.Size(98, 41)
        Me.newButtonPrice.TabIndex = 5
        Me.newButtonPrice.Text = "Nuevos"
        Me.newButtonPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.newButtonPrice, "Ultimos productos ingresados.")
        Me.newButtonPrice.UseVisualStyleBackColor = True
        '
        'PanelAdminState
        '
        Me.PanelAdminState.Controls.Add(Me.stockButton)
        Me.PanelAdminState.Controls.Add(Me.btnEliminar)
        Me.PanelAdminState.Controls.Add(Me.btnActiva)
        Me.PanelAdminState.Controls.Add(Me.btnDetalle)
        Me.PanelAdminState.Controls.Add(Me.newButtonState)
        Me.PanelAdminState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAdminState.Location = New System.Drawing.Point(3, 65)
        Me.PanelAdminState.Name = "PanelAdminState"
        Me.PanelAdminState.Size = New System.Drawing.Size(547, 43)
        Me.PanelAdminState.TabIndex = 13
        '
        'stockButton
        '
        Me.stockButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.stockButton.Enabled = False
        Me.stockButton.Image = Global.ECommercePlatformView.My.Resources.Resources.stock_Bodega_32
        Me.stockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stockButton.Location = New System.Drawing.Point(395, 0)
        Me.stockButton.Name = "stockButton"
        Me.stockButton.Size = New System.Drawing.Size(87, 43)
        Me.stockButton.TabIndex = 5
        Me.stockButton.Text = "&Stock"
        Me.stockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.stockButton, "Eliminar prodcuto")
        Me.stockButton.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(297, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 43)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar prodcuto")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActiva
        '
        Me.btnActiva.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnActiva.Enabled = False
        Me.btnActiva.Image = Global.ECommercePlatformView.My.Resources.Resources.notLike_32
        Me.btnActiva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActiva.Location = New System.Drawing.Point(194, 0)
        Me.btnActiva.Name = "btnActiva"
        Me.btnActiva.Size = New System.Drawing.Size(103, 43)
        Me.btnActiva.TabIndex = 3
        Me.btnActiva.Text = "&Activar.."
        Me.btnActiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnActiva, "Activar o desactivar el prodcuto.")
        Me.btnActiva.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDetalle.Enabled = False
        Me.btnDetalle.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalle.Location = New System.Drawing.Point(98, 0)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(96, 43)
        Me.btnDetalle.TabIndex = 3
        Me.btnDetalle.Text = "Detalle."
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnDetalle, "Detalle del producto")
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'newButtonState
        '
        Me.newButtonState.Dock = System.Windows.Forms.DockStyle.Left
        Me.newButtonState.Image = Global.ECommercePlatformView.My.Resources.Resources.new_32
        Me.newButtonState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.newButtonState.Location = New System.Drawing.Point(0, 0)
        Me.newButtonState.Name = "newButtonState"
        Me.newButtonState.Size = New System.Drawing.Size(98, 43)
        Me.newButtonState.TabIndex = 4
        Me.newButtonState.Text = "Nuevos"
        Me.newButtonState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.newButtonState, "Ultimo productos ingresados")
        Me.newButtonState.UseVisualStyleBackColor = True
        '
        'paneListView
        '
        Me.paneListView.BackColor = System.Drawing.Color.White
        Me.paneListView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.paneListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneListView.Location = New System.Drawing.Point(0, 170)
        Me.paneListView.Name = "paneListView"
        Me.paneListView.Size = New System.Drawing.Size(928, 190)
        Me.paneListView.TabIndex = 12
        '
        'PanelControls
        '
        Me.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelControls.Controls.Add(Me.PanelFind)
        Me.PanelControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControls.Location = New System.Drawing.Point(0, 0)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(928, 54)
        Me.PanelControls.TabIndex = 0
        '
        'PanelFind
        '
        Me.PanelFind.Controls.Add(Me.Label2)
        Me.PanelFind.Controls.Add(Me.txtProduc_Select)
        Me.PanelFind.Controls.Add(Me.btnBuscar)
        Me.PanelFind.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelFind.Location = New System.Drawing.Point(0, 0)
        Me.PanelFind.Name = "PanelFind"
        Me.PanelFind.Size = New System.Drawing.Size(523, 52)
        Me.PanelFind.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Buscar producto:"
        '
        'txtProduc_Select
        '
        Me.txtProduc_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduc_Select.Location = New System.Drawing.Point(111, 17)
        Me.txtProduc_Select.Name = "txtProduc_Select"
        Me.txtProduc_Select.Size = New System.Drawing.Size(331, 24)
        Me.txtProduc_Select.TabIndex = 0
        Me.txtProduc_Select.Tag = "0"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(448, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(65, 29)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.okButton)
        Me.Panel2.Controls.Add(Me.cancel_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(945, 36)
        Me.Panel2.TabIndex = 17
        '
        'okButton
        '
        Me.okButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.okButton.Location = New System.Drawing.Point(732, 0)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(114, 36)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "Aceptar"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'cancel_Button
        '
        Me.cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancel_Button.Location = New System.Drawing.Point(846, 0)
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(99, 36)
        Me.cancel_Button.TabIndex = 0
        Me.cancel_Button.Text = "Cancelar"
        Me.cancel_Button.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ListadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.AutoSize = False
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Administrar precio de venta.", "Administrar estado"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(180, 23)
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevosProductosToolStripMenuItem, Me.ProductosSinCostoDeCompraToolStripMenuItem, Me.ProductosSinCostoDeVentaToolStripMenuItem, Me.OrdenadosDeMenorUtilidadToolStripMenuItem, Me.ProductosDemayorUtilidadToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.ListadosToolStripMenuItem.Text = "Listado"
        '
        'NuevosProductosToolStripMenuItem
        '
        Me.NuevosProductosToolStripMenuItem.Name = "NuevosProductosToolStripMenuItem"
        Me.NuevosProductosToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.NuevosProductosToolStripMenuItem.Text = "Nuevos productos"
        '
        'ProductosSinCostoDeCompraToolStripMenuItem
        '
        Me.ProductosSinCostoDeCompraToolStripMenuItem.Name = "ProductosSinCostoDeCompraToolStripMenuItem"
        Me.ProductosSinCostoDeCompraToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ProductosSinCostoDeCompraToolStripMenuItem.Text = "Productos sin costo de compra"
        '
        'ProductosSinCostoDeVentaToolStripMenuItem
        '
        Me.ProductosSinCostoDeVentaToolStripMenuItem.Name = "ProductosSinCostoDeVentaToolStripMenuItem"
        Me.ProductosSinCostoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ProductosSinCostoDeVentaToolStripMenuItem.Text = "Productos sin costo de venta"
        '
        'OrdenadosDeMenorUtilidadToolStripMenuItem
        '
        Me.OrdenadosDeMenorUtilidadToolStripMenuItem.Name = "OrdenadosDeMenorUtilidadToolStripMenuItem"
        Me.OrdenadosDeMenorUtilidadToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.OrdenadosDeMenorUtilidadToolStripMenuItem.Text = "Produc de menor utilidad"
        '
        'ProductosDemayorUtilidadToolStripMenuItem
        '
        Me.ProductosDemayorUtilidadToolStripMenuItem.Name = "ProductosDemayorUtilidadToolStripMenuItem"
        Me.ProductosDemayorUtilidadToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ProductosDemayorUtilidadToolStripMenuItem.Text = "Productos demayor utilidad"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmAdministrarPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(945, 404)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.paneDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdministrarPrecios"
        Me.Text = "Administrando Productos: Precio de venta, Ofertas y Promociones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.paneDatos.ResumeLayout(False)
        Me.PanelAdmininPrice.ResumeLayout(False)
        Me.PanelAdminState.ResumeLayout(False)
        Me.PanelControls.ResumeLayout(False)
        Me.PanelFind.ResumeLayout(False)
        Me.PanelFind.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paneDatos As System.Windows.Forms.Panel
    Friend WithEvents paneListView As System.Windows.Forms.Panel
    Friend WithEvents btnEditaCosto As System.Windows.Forms.Button
    Friend WithEvents btnActiva As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnOfertas As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProduc_Select As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelAdminState As System.Windows.Forms.Panel
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents okButton As Button
    Friend WithEvents cancel_Button As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevosProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosSinCostoDeCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosSinCostoDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenadosDeMenorUtilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosDemayorUtilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents PanelAdmininPrice As Panel
    Friend WithEvents PanelControls As Panel
    Friend WithEvents PanelFind As Panel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents newButtonState As Button
    Friend WithEvents detailButton As Button
    Friend WithEvents newButtonPrice As Button
    Friend WithEvents stockButton As Button
End Class
