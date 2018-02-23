<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmList_ProductoView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_ProductoView))
        Me.menuQuienVende = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ContextMenuLectura = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuDetalleLect = New System.Windows.Forms.ToolStripMenuItem()
        Me.nemuQuienVendeLect = New System.Windows.Forms.ToolStripMenuItem()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.menuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtProduc_Select = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.menuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuAdministra = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.ExpirateButton = New System.Windows.Forms.Button()
        Me.EtiquetasButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EditPriceSalesButton = New System.Windows.Forms.Button()
        Me.AgregarButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FolderBrouserButton = New System.Windows.Forms.Button()
        Me.FolderFileTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuAdminCodeBarr = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirCodBarrToolStripMenuI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnviarMyListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarAUnaRutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.barCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DeleteBarCodButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImprimirCodigo = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuSettingCodBarr = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GenerarCodigoDeBarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarCodigoDeBarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerADosPixelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerA1PixelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaCompraDocumentoTableAdapter1 = New CADsisVenta.DataSetComprasTableAdapters.FacturaCompraDocumentoTableAdapter()
        Me.ContextMenuLectura.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuAdministra.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuAdminCodeBarr.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuSettingCodBarr.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuQuienVende
        '
        Me.menuQuienVende.Name = "menuQuienVende"
        Me.menuQuienVende.Size = New System.Drawing.Size(141, 22)
        Me.menuQuienVende.Text = "Quien vende"
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(904, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(94, 29)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "&Aceptar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'ContextMenuLectura
        '
        Me.ContextMenuLectura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDetalleLect, Me.nemuQuienVendeLect})
        Me.ContextMenuLectura.Name = "ContextMenuAdministra"
        Me.ContextMenuLectura.Size = New System.Drawing.Size(142, 48)
        '
        'menuDetalleLect
        '
        Me.menuDetalleLect.Name = "menuDetalleLect"
        Me.menuDetalleLect.Size = New System.Drawing.Size(141, 22)
        Me.menuDetalleLect.Text = "Ver detalle..."
        '
        'nemuQuienVendeLect
        '
        Me.nemuQuienVendeLect.Name = "nemuQuienVendeLect"
        Me.nemuQuienVendeLect.Size = New System.Drawing.Size(141, 22)
        Me.nemuQuienVendeLect.Text = "Quien vende"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datalistado.Location = New System.Drawing.Point(3, 3)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(808, 401)
        Me.datalistado.TabIndex = 8
        '
        'menuEditar
        '
        Me.menuEditar.Name = "menuEditar"
        Me.menuEditar.Size = New System.Drawing.Size(141, 22)
        Me.menuEditar.Text = "Editar"
        '
        'btnPrint
        '
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.Location = New System.Drawing.Point(810, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 29)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Imprimir"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Imprimir el listdo actual")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(565, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 30)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscar, "Buscar el producto")
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtProduc_Select
        '
        Me.txtProduc_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduc_Select.Location = New System.Drawing.Point(172, 5)
        Me.txtProduc_Select.Name = "txtProduc_Select"
        Me.txtProduc_Select.Size = New System.Drawing.Size(387, 26)
        Me.txtProduc_Select.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtProduc_Select, "Escribe el produco o odigos o barra de producto a buscar")
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelar.Location = New System.Drawing.Point(998, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 29)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Producto buscado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total Listado: 0"
        '
        'menuNuevo
        '
        Me.menuNuevo.Name = "menuNuevo"
        Me.menuNuevo.Size = New System.Drawing.Size(141, 22)
        Me.menuNuevo.Text = "Nuevo"
        '
        'ContextMenuAdministra
        '
        Me.ContextMenuAdministra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuNuevo, Me.menuEditar, Me.menuQuienVende})
        Me.ContextMenuAdministra.Name = "ContextMenuAdministra"
        Me.ContextMenuAdministra.Size = New System.Drawing.Size(142, 70)
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelAdmin.Controls.Add(Me.ExpirateButton)
        Me.PanelAdmin.Controls.Add(Me.EtiquetasButton)
        Me.PanelAdmin.Controls.Add(Me.Button1)
        Me.PanelAdmin.Controls.Add(Me.EditPriceSalesButton)
        Me.PanelAdmin.Controls.Add(Me.AgregarButton)
        Me.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAdmin.Location = New System.Drawing.Point(2, 2)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Padding = New System.Windows.Forms.Padding(20, 2, 0, 2)
        Me.PanelAdmin.Size = New System.Drawing.Size(1094, 49)
        Me.PanelAdmin.TabIndex = 17
        '
        'ExpirateButton
        '
        Me.ExpirateButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpirateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Expirate_32
        Me.ExpirateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExpirateButton.Location = New System.Drawing.Point(650, 2)
        Me.ExpirateButton.Name = "ExpirateButton"
        Me.ExpirateButton.Size = New System.Drawing.Size(122, 45)
        Me.ExpirateButton.TabIndex = 4
        Me.ExpirateButton.Text = "Expiración"
        Me.ExpirateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ExpirateButton, "Administrar fechas de caducidad")
        Me.ExpirateButton.UseVisualStyleBackColor = True
        '
        'EtiquetasButton
        '
        Me.EtiquetasButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EtiquetasButton.Image = Global.ECommercePlatformView.My.Resources.Resources.barcode_48
        Me.EtiquetasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EtiquetasButton.Location = New System.Drawing.Point(515, 2)
        Me.EtiquetasButton.Name = "EtiquetasButton"
        Me.EtiquetasButton.Size = New System.Drawing.Size(135, 45)
        Me.EtiquetasButton.TabIndex = 3
        Me.EtiquetasButton.Text = "Etiquetas"
        Me.EtiquetasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EtiquetasButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = Global.ECommercePlatformView.My.Resources.Resources.edid_pencil_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(388, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Modificar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditPriceSalesButton
        '
        Me.EditPriceSalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EditPriceSalesButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditPriceSalesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPriceSalesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.confirCost_32
        Me.EditPriceSalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditPriceSalesButton.Location = New System.Drawing.Point(181, 2)
        Me.EditPriceSalesButton.Name = "EditPriceSalesButton"
        Me.EditPriceSalesButton.Size = New System.Drawing.Size(207, 45)
        Me.EditPriceSalesButton.TabIndex = 0
        Me.EditPriceSalesButton.Text = "Ajustar precio de venta"
        Me.EditPriceSalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditPriceSalesButton.UseVisualStyleBackColor = True
        '
        'AgregarButton
        '
        Me.AgregarButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AgregarButton.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgregarButton.Location = New System.Drawing.Point(20, 2)
        Me.AgregarButton.Name = "AgregarButton"
        Me.AgregarButton.Size = New System.Drawing.Size(161, 45)
        Me.AgregarButton.TabIndex = 1
        Me.AgregarButton.Text = "Nuevo producto"
        Me.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AgregarButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnOk)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(1094, 33)
        Me.Panel2.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtProduc_Select)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 39)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 90)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.datalistado)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1094, 409)
        Me.SplitContainer1.SplitterDistance = 816
        Me.SplitContainer1.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.FolderBrouserButton)
        Me.Panel5.Controls.Add(Me.FolderFileTextBox)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.barCodeTextBox)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel5.Size = New System.Drawing.Size(266, 401)
        Me.Panel5.TabIndex = 2
        '
        'FolderBrouserButton
        '
        Me.FolderBrouserButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.FolderBrouserButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FolderBrouserButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.FolderBrouserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FolderBrouserButton.Location = New System.Drawing.Point(189, 268)
        Me.FolderBrouserButton.Name = "FolderBrouserButton"
        Me.FolderBrouserButton.Size = New System.Drawing.Size(70, 24)
        Me.FolderBrouserButton.TabIndex = 10
        Me.FolderBrouserButton.Text = "Ubicar..  "
        Me.FolderBrouserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FolderBrouserButton.UseVisualStyleBackColor = False
        '
        'FolderFileTextBox
        '
        Me.FolderFileTextBox.Location = New System.Drawing.Point(5, 292)
        Me.FolderFileTextBox.Multiline = True
        Me.FolderFileTextBox.Name = "FolderFileTextBox"
        Me.FolderFileTextBox.ReadOnly = True
        Me.FolderFileTextBox.Size = New System.Drawing.Size(254, 94)
        Me.FolderFileTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ruta a enviar las imagenes:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuAdminCodeBarr
        Me.PictureBox1.Location = New System.Drawing.Point(5, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 150)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuAdminCodeBarr
        '
        Me.ContextMenuAdminCodeBarr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.ImprimirCodBarrToolStripMenuI, Me.ToolStripMenuItem4, Me.ToolStripSeparator1, Me.EnviarMyListToolStripMenuItem, Me.EnviarAUnaRutaToolStripMenuItem})
        Me.ContextMenuAdminCodeBarr.Name = "ContextMenuAdministra"
        Me.ContextMenuAdminCodeBarr.Size = New System.Drawing.Size(202, 120)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'ImprimirCodBarrToolStripMenuI
        '
        Me.ImprimirCodBarrToolStripMenuI.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.ImprimirCodBarrToolStripMenuI.Name = "ImprimirCodBarrToolStripMenuI"
        Me.ImprimirCodBarrToolStripMenuI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImprimirCodBarrToolStripMenuI.Size = New System.Drawing.Size(201, 22)
        Me.ImprimirCodBarrToolStripMenuI.Text = "&Imprimir"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Save_16x16
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(201, 22)
        Me.ToolStripMenuItem4.Text = "&Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'EnviarMyListToolStripMenuItem
        '
        Me.EnviarMyListToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.EviarList_16
        Me.EnviarMyListToolStripMenuItem.Name = "EnviarMyListToolStripMenuItem"
        Me.EnviarMyListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EnviarMyListToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EnviarMyListToolStripMenuItem.Text = "&Enviar a mi listas"
        '
        'EnviarAUnaRutaToolStripMenuItem
        '
        Me.EnviarAUnaRutaToolStripMenuItem.Image = CType(resources.GetObject("EnviarAUnaRutaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnviarAUnaRutaToolStripMenuItem.Name = "EnviarAUnaRutaToolStripMenuItem"
        Me.EnviarAUnaRutaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EnviarAUnaRutaToolStripMenuItem.Text = "Enviar a una ruta."
        '
        'barCodeTextBox
        '
        Me.barCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barCodeTextBox.Location = New System.Drawing.Point(5, 236)
        Me.barCodeTextBox.Name = "barCodeTextBox"
        Me.barCodeTextBox.ReadOnly = True
        Me.barCodeTextBox.Size = New System.Drawing.Size(232, 29)
        Me.barCodeTextBox.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.DeleteBarCodButton)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(2, 39)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 35)
        Me.Panel4.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 35)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Archivo"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DeleteBarCodButton
        '
        Me.DeleteBarCodButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DeleteBarCodButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeleteBarCodButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBarCodButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DeleteBarCodButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.DeleteBarCodButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBarCodButton.Location = New System.Drawing.Point(99, 0)
        Me.DeleteBarCodButton.Name = "DeleteBarCodButton"
        Me.DeleteBarCodButton.Size = New System.Drawing.Size(119, 35)
        Me.DeleteBarCodButton.TabIndex = 0
        Me.DeleteBarCodButton.Text = "Borrar codigo"
        Me.DeleteBarCodButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBarCodButton.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.ECommercePlatformView.My.Resources.Resources.ic_settings_white_32
        Me.Button3.Location = New System.Drawing.Point(218, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 35)
        Me.Button3.TabIndex = 1
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 37)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo de Barra"
        '
        'ImprimirCodigo
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuSettingCodBarr
        '
        Me.ContextMenuSettingCodBarr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarCodigoDeBarraToolStripMenuItem, Me.CambiarCodigoDeBarraToolStripMenuItem, Me.VerADosPixelesToolStripMenuItem, Me.VerA1PixelToolStripMenuItem})
        Me.ContextMenuSettingCodBarr.Name = "ContextMenuSettingCodBarr"
        Me.ContextMenuSettingCodBarr.Size = New System.Drawing.Size(209, 92)
        '
        'GenerarCodigoDeBarraToolStripMenuItem
        '
        Me.GenerarCodigoDeBarraToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.BarrCode_16
        Me.GenerarCodigoDeBarraToolStripMenuItem.Name = "GenerarCodigoDeBarraToolStripMenuItem"
        Me.GenerarCodigoDeBarraToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GenerarCodigoDeBarraToolStripMenuItem.Text = "Generar codigo de barra"
        '
        'CambiarCodigoDeBarraToolStripMenuItem
        '
        Me.CambiarCodigoDeBarraToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.BarCodeScan_16
        Me.CambiarCodigoDeBarraToolStripMenuItem.Name = "CambiarCodigoDeBarraToolStripMenuItem"
        Me.CambiarCodigoDeBarraToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CambiarCodigoDeBarraToolStripMenuItem.Text = "Cambiar codigo de barra."
        '
        'VerADosPixelesToolStripMenuItem
        '
        Me.VerADosPixelesToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.TwoPixcel_16
        Me.VerADosPixelesToolStripMenuItem.Name = "VerADosPixelesToolStripMenuItem"
        Me.VerADosPixelesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.VerADosPixelesToolStripMenuItem.Text = "Ver a 2 pixeles."
        '
        'VerA1PixelToolStripMenuItem
        '
        Me.VerA1PixelToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.OnePicxel
        Me.VerA1PixelToolStripMenuItem.Name = "VerA1PixelToolStripMenuItem"
        Me.VerA1PixelToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.VerA1PixelToolStripMenuItem.Text = "Ver a 1 pixel."
        '
        'FacturaCompraDocumentoTableAdapter1
        '
        Me.FacturaCompraDocumentoTableAdapter1.ClearBeforeFill = True
        '
        'frmList_ProductoView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 534)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmList_ProductoView"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de productos."
        Me.ContextMenuLectura.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuAdministra.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuAdminCodeBarr.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ContextMenuSettingCodBarr.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menuQuienVende As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ContextMenuLectura As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuDetalleLect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nemuQuienVendeLect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents menuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtProduc_Select As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents menuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuAdministra As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents EditPriceSalesButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AgregarButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EtiquetasButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DeleteBarCodButton As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImprimirCodigo As Printing.PrintDocument
    Friend WithEvents Button4 As Button
    Friend WithEvents ContextMenuAdminCodeBarr As ContextMenuStrip
    Public WithEvents ImprimirCodBarrToolStripMenuI As ToolStripMenuItem
    Public WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents barCodeTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EnviarMyListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuSettingCodBarr As ContextMenuStrip
    Friend WithEvents GenerarCodigoDeBarraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarCodigoDeBarraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerADosPixelesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerA1PixelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarAUnaRutaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrouserButton As Button
    Friend WithEvents FolderFileTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents FacturaCompraDocumentoTableAdapter1 As CADsisVenta.DataSetComprasTableAdapters.FacturaCompraDocumentoTableAdapter
    Friend WithEvents ExpirateButton As Button
End Class
