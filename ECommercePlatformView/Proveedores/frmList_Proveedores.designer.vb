<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_Proveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.lblTotalListado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.lblNoExiste = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EditButton = New System.Windows.Forms.Button()
        Me.NewProveedorButton = New System.Windows.Forms.Button()
        Me.DetailProviderButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnExporExcel = New System.Windows.Forms.Button()
        Me.btnVende = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.MenuTables = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HerramFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.menuFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BuscaFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CentralPanel = New System.Windows.Forms.Panel()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTables.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HerramFlowLayoutPanel.SuspendLayout()
        Me.menuFlowLayoutPanel.SuspendLayout()
        Me.BuscaFlowLayoutPanel.SuspendLayout()
        Me.CentralPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.BackgroundColor = System.Drawing.Color.White
        Me.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataListado.Location = New System.Drawing.Point(0, 0)
        Me.dataListado.MultiSelect = False
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(739, 278)
        Me.dataListado.TabIndex = 15
        '
        'lblTotalListado
        '
        Me.lblTotalListado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalListado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalListado.Location = New System.Drawing.Point(0, 278)
        Me.lblTotalListado.Name = "lblTotalListado"
        Me.lblTotalListado.Size = New System.Drawing.Size(739, 19)
        Me.lblTotalListado.TabIndex = 13
        Me.lblTotalListado.Text = "Total Listado : 0"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(905, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LISTADO  DE PROVEEDORES..."
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(3, 3)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(364, 26)
        Me.txtbuscar.TabIndex = 0
        '
        'lblNoExiste
        '
        Me.lblNoExiste.AutoSize = True
        Me.lblNoExiste.BackColor = System.Drawing.Color.Transparent
        Me.lblNoExiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoExiste.Location = New System.Drawing.Point(16, 13)
        Me.lblNoExiste.Name = "lblNoExiste"
        Me.lblNoExiste.Size = New System.Drawing.Size(184, 20)
        Me.lblNoExiste.TabIndex = 18
        Me.lblNoExiste.Text = "No existe informacion......"
        Me.lblNoExiste.Visible = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.Black
        Me.EditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Edd_client_48
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(98, 1)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(1)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(111, 48)
        Me.EditButton.TabIndex = 23
        Me.EditButton.Text = "Editar"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.EditButton, "Editar el proveedor")
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'NewProveedorButton
        '
        Me.NewProveedorButton.BackColor = System.Drawing.Color.Black
        Me.NewProveedorButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewProveedorButton.ForeColor = System.Drawing.Color.White
        Me.NewProveedorButton.Image = Global.ECommercePlatformView.My.Resources.Resources.newProvider_48_Gif
        Me.NewProveedorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewProveedorButton.Location = New System.Drawing.Point(1, 1)
        Me.NewProveedorButton.Margin = New System.Windows.Forms.Padding(1)
        Me.NewProveedorButton.Name = "NewProveedorButton"
        Me.NewProveedorButton.Size = New System.Drawing.Size(95, 48)
        Me.NewProveedorButton.TabIndex = 21
        Me.NewProveedorButton.Text = "Nuevo"
        Me.NewProveedorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.NewProveedorButton, "Nuevo proveedor")
        Me.NewProveedorButton.UseVisualStyleBackColor = False
        '
        'DetailProviderButton
        '
        Me.DetailProviderButton.BackColor = System.Drawing.Color.Black
        Me.DetailProviderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DetailProviderButton.ForeColor = System.Drawing.Color.White
        Me.DetailProviderButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.DetailProviderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DetailProviderButton.Location = New System.Drawing.Point(211, 1)
        Me.DetailProviderButton.Margin = New System.Windows.Forms.Padding(1)
        Me.DetailProviderButton.Name = "DetailProviderButton"
        Me.DetailProviderButton.Size = New System.Drawing.Size(105, 48)
        Me.DetailProviderButton.TabIndex = 22
        Me.DetailProviderButton.Text = "Detalle"
        Me.DetailProviderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.DetailProviderButton, "Detalle del proveedor")
        Me.DetailProviderButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Wheat
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ECommercePlatformView.My.Resources.Resources.printer_icon_48
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.Location = New System.Drawing.Point(3, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 55)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Imprimir.."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button2, "Imprime en impresona de  tinta")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnExporExcel
        '
        Me.btnExporExcel.BackColor = System.Drawing.Color.Wheat
        Me.btnExporExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExporExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporExcel.Image = Global.ECommercePlatformView.My.Resources.Resources.document_excel_icon_48
        Me.btnExporExcel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnExporExcel.Location = New System.Drawing.Point(3, 210)
        Me.btnExporExcel.Name = "btnExporExcel"
        Me.btnExporExcel.Size = New System.Drawing.Size(148, 55)
        Me.btnExporExcel.TabIndex = 10
        Me.btnExporExcel.Text = "Exportar Excel"
        Me.btnExporExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnExporExcel, "Exporta el listado actual a una hoja de Excel")
        Me.btnExporExcel.UseVisualStyleBackColor = False
        '
        'btnVende
        '
        Me.btnVende.BackColor = System.Drawing.Color.Wheat
        Me.btnVende.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVende.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVende.ForeColor = System.Drawing.Color.Black
        Me.btnVende.Image = Global.ECommercePlatformView.My.Resources.Resources.calendar_list_icon_48
        Me.btnVende.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnVende.Location = New System.Drawing.Point(3, 271)
        Me.btnVende.Name = "btnVende"
        Me.btnVende.Size = New System.Drawing.Size(148, 55)
        Me.btnVende.TabIndex = 11
        Me.btnVende.Text = "Que Vende..?"
        Me.btnVende.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnVende, "Listado de productos que Venden")
        Me.btnVende.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Black
        Me.deleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.deleteButton.ForeColor = System.Drawing.Color.White
        Me.deleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_48
        Me.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteButton.Location = New System.Drawing.Point(318, 1)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(1)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(117, 48)
        Me.deleteButton.TabIndex = 24
        Me.deleteButton.Text = "Eliminar"
        Me.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.deleteButton, "Eliminar el provedor")
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Black
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(660, 7)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(129, 32)
        Me.btnOk.TabIndex = 21
        Me.btnOk.Text = "Selccionar.."
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.Black
        Me.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel_btn.ForeColor = System.Drawing.Color.White
        Me.cancel_btn.Location = New System.Drawing.Point(795, 7)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(3, 7, 15, 3)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(95, 32)
        Me.cancel_btn.TabIndex = 21
        Me.cancel_btn.Text = "Cancelar"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'MenuTables
        '
        Me.MenuTables.BackColor = System.Drawing.Color.Wheat
        Me.MenuTables.ColumnCount = 1
        Me.MenuTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MenuTables.Controls.Add(Me.Button2, 0, 1)
        Me.MenuTables.Controls.Add(Me.btnExporExcel, 0, 2)
        Me.MenuTables.Controls.Add(Me.btnVende, 0, 3)
        Me.MenuTables.Controls.Add(Me.PictureBox1, 0, 0)
        Me.MenuTables.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuTables.Location = New System.Drawing.Point(0, 29)
        Me.MenuTables.Name = "MenuTables"
        Me.MenuTables.RowCount = 5
        Me.MenuTables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MenuTables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MenuTables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MenuTables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MenuTables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MenuTables.Size = New System.Drawing.Size(154, 383)
        Me.MenuTables.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Resources.Proveedor
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 140)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'HerramFlowLayoutPanel
        '
        Me.HerramFlowLayoutPanel.BackColor = System.Drawing.Color.Wheat
        Me.HerramFlowLayoutPanel.Controls.Add(Me.cancel_btn)
        Me.HerramFlowLayoutPanel.Controls.Add(Me.btnOk)
        Me.HerramFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HerramFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.HerramFlowLayoutPanel.Location = New System.Drawing.Point(0, 412)
        Me.HerramFlowLayoutPanel.Name = "HerramFlowLayoutPanel"
        Me.HerramFlowLayoutPanel.Size = New System.Drawing.Size(905, 45)
        Me.HerramFlowLayoutPanel.TabIndex = 23
        '
        'menuFlowLayoutPanel
        '
        Me.menuFlowLayoutPanel.BackColor = System.Drawing.Color.Navy
        Me.menuFlowLayoutPanel.Controls.Add(Me.NewProveedorButton)
        Me.menuFlowLayoutPanel.Controls.Add(Me.EditButton)
        Me.menuFlowLayoutPanel.Controls.Add(Me.DetailProviderButton)
        Me.menuFlowLayoutPanel.Controls.Add(Me.deleteButton)
        Me.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuFlowLayoutPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuFlowLayoutPanel.Location = New System.Drawing.Point(154, 29)
        Me.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel"
        Me.menuFlowLayoutPanel.Size = New System.Drawing.Size(751, 50)
        Me.menuFlowLayoutPanel.TabIndex = 24
        '
        'BuscaFlowLayoutPanel
        '
        Me.BuscaFlowLayoutPanel.BackColor = System.Drawing.Color.Wheat
        Me.BuscaFlowLayoutPanel.Controls.Add(Me.txtbuscar)
        Me.BuscaFlowLayoutPanel.Controls.Add(Me.bntBuscar)
        Me.BuscaFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BuscaFlowLayoutPanel.Location = New System.Drawing.Point(154, 79)
        Me.BuscaFlowLayoutPanel.Name = "BuscaFlowLayoutPanel"
        Me.BuscaFlowLayoutPanel.Size = New System.Drawing.Size(751, 36)
        Me.BuscaFlowLayoutPanel.TabIndex = 0
        '
        'bntBuscar
        '
        Me.bntBuscar.BackColor = System.Drawing.Color.Wheat
        Me.bntBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntBuscar.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_icon_24
        Me.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntBuscar.Location = New System.Drawing.Point(373, 3)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(93, 31)
        Me.bntBuscar.TabIndex = 17
        Me.bntBuscar.Text = "Buscar...."
        Me.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntBuscar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(893, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(12, 297)
        Me.Panel1.TabIndex = 26
        '
        'CentralPanel
        '
        Me.CentralPanel.Controls.Add(Me.dataListado)
        Me.CentralPanel.Controls.Add(Me.lblTotalListado)
        Me.CentralPanel.Controls.Add(Me.lblNoExiste)
        Me.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CentralPanel.Location = New System.Drawing.Point(154, 115)
        Me.CentralPanel.Name = "CentralPanel"
        Me.CentralPanel.Size = New System.Drawing.Size(739, 297)
        Me.CentralPanel.TabIndex = 27
        '
        'frmList_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.CancelButton = Me.cancel_btn
        Me.ClientSize = New System.Drawing.Size(905, 457)
        Me.Controls.Add(Me.CentralPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BuscaFlowLayoutPanel)
        Me.Controls.Add(Me.menuFlowLayoutPanel)
        Me.Controls.Add(Me.MenuTables)
        Me.Controls.Add(Me.HerramFlowLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmList_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de proveedores.."
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTables.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HerramFlowLayoutPanel.ResumeLayout(False)
        Me.menuFlowLayoutPanel.ResumeLayout(False)
        Me.BuscaFlowLayoutPanel.ResumeLayout(False)
        Me.BuscaFlowLayoutPanel.PerformLayout()
        Me.CentralPanel.ResumeLayout(False)
        Me.CentralPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataListado As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalListado As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents bntBuscar As System.Windows.Forms.Button
    Friend WithEvents lblNoExiste As System.Windows.Forms.Label
    Friend WithEvents btnVende As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnExporExcel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents MenuTables As TableLayoutPanel
    Friend WithEvents HerramFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents menuFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents NewProveedorButton As Button
    Friend WithEvents DetailProviderButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents BuscaFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CentralPanel As System.Windows.Forms.Panel
    Friend WithEvents deleteButton As Button
End Class
