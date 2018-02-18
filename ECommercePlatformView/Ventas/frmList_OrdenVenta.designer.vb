<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_OrdenVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_OrdenVenta))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.btnNotaVenta = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ChangedClientButton = New System.Windows.Forms.Button()
        Me.lblInformacion = New System.Windows.Forms.Label()
        Me.btnBuscarFech = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumber1 = New System.Windows.Forms.NumericUpDown()
        Me.txtNumber2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarOrden = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuVerDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ChekOrderList = New System.Windows.Forms.CheckedListBox()
        Me.btnNoselect = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SubmitToSalesButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSelect.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectAll_16x16
        Me.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelect.Location = New System.Drawing.Point(69, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(114, 25)
        Me.btnSelect.TabIndex = 24
        Me.btnSelect.Text = "Seleccionar todo"
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSelect, "Selecionar todo el listado")
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(305, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 25)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "  Print Ticket"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Imprimir PROFORMA en IMPRESORA DE TICKET")
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDetail.Image = Global.ECommercePlatformView.My.Resources.Resources.check_list_48
        Me.btnDetail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetail.Location = New System.Drawing.Point(3, 94)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(75, 65)
        Me.btnDetail.TabIndex = 25
        Me.btnDetail.Text = "Ver detalle"
        Me.btnDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnDetail, "Ver detalle de la  PROFORMA.")
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnNotaVenta
        '
        Me.btnNotaVenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNotaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNotaVenta.Image = Global.ECommercePlatformView.My.Resources.Resources.NoteSales_32
        Me.btnNotaVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNotaVenta.Location = New System.Drawing.Point(3, 165)
        Me.btnNotaVenta.Name = "btnNotaVenta"
        Me.btnNotaVenta.Size = New System.Drawing.Size(75, 68)
        Me.btnNotaVenta.TabIndex = 25
        Me.btnNotaVenta.Tag = "Nota de venta"
        Me.btnNotaVenta.Text = "Emitir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nota Venta"
        Me.btnNotaVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNotaVenta, "Facturar las ordenes seleccionadas")
        Me.btnNotaVenta.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(411, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 25)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Eliminar items seleccionaos..")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ChangedClientButton
        '
        Me.ChangedClientButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ChangedClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChangedClientButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Find_Employee_64
        Me.ChangedClientButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ChangedClientButton.Location = New System.Drawing.Point(3, 3)
        Me.ChangedClientButton.Name = "ChangedClientButton"
        Me.ChangedClientButton.Size = New System.Drawing.Size(75, 85)
        Me.ChangedClientButton.TabIndex = 26
        Me.ChangedClientButton.Tag = "Factura"
        Me.ChangedClientButton.Text = "Cambiar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente"
        Me.ChangedClientButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.ChangedClientButton, "Emitir un documento a nombre de otra persona..")
        Me.ChangedClientButton.UseVisualStyleBackColor = True
        '
        'lblInformacion
        '
        Me.lblInformacion.AutoSize = True
        Me.lblInformacion.BackColor = System.Drawing.Color.White
        Me.lblInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacion.Location = New System.Drawing.Point(28, 61)
        Me.lblInformacion.Name = "lblInformacion"
        Me.lblInformacion.Size = New System.Drawing.Size(159, 20)
        Me.lblInformacion.TabIndex = 26
        Me.lblInformacion.Text = "No exixte informacion"
        Me.lblInformacion.Visible = False
        '
        'btnBuscarFech
        '
        Me.btnBuscarFech.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarFech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscarFech.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarFech.Location = New System.Drawing.Point(229, 17)
        Me.btnBuscarFech.Name = "btnBuscarFech"
        Me.btnBuscarFech.Size = New System.Drawing.Size(97, 33)
        Me.btnBuscarFech.TabIndex = 1
        Me.btnBuscarFech.Text = "Buscar.."
        Me.btnBuscarFech.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarFech.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNumber1)
        Me.GroupBox2.Controls.Add(Me.txtNumber2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnBuscarOrden)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(488, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 58)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione y busque."
        Me.GroupBox2.Visible = False
        '
        'txtNumber1
        '
        Me.txtNumber1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber1.Location = New System.Drawing.Point(6, 23)
        Me.txtNumber1.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumber1.Size = New System.Drawing.Size(97, 23)
        Me.txtNumber1.TabIndex = 9
        Me.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumber2
        '
        Me.txtNumber2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber2.Location = New System.Drawing.Point(128, 21)
        Me.txtNumber2.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumber2.Size = New System.Drawing.Size(97, 23)
        Me.txtNumber2.TabIndex = 9
        Me.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Y"
        '
        'btnBuscarOrden
        '
        Me.btnBuscarOrden.Location = New System.Drawing.Point(229, 14)
        Me.btnBuscarOrden.Name = "btnBuscarOrden"
        Me.btnBuscarOrden.Size = New System.Drawing.Size(97, 36)
        Me.btnBuscarOrden.TabIndex = 2
        Me.btnBuscarOrden.Text = "Buscar.."
        Me.btnBuscarOrden.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuVerDetalle})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 26)
        '
        'menuVerDetalle
        '
        Me.menuVerDetalle.Name = "menuVerDetalle"
        Me.menuVerDetalle.Size = New System.Drawing.Size(202, 22)
        Me.menuVerDetalle.Text = "Ver detalle de esta orden"
        '
        'dtFecha1
        '
        Me.dtFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha1.Location = New System.Drawing.Point(6, 19)
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(97, 22)
        Me.dtFecha1.TabIndex = 5
        '
        'dtFecha2
        '
        Me.dtFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha2.Location = New System.Drawing.Point(126, 19)
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(97, 22)
        Me.dtFecha2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarFech)
        Me.GroupBox1.Controls.Add(Me.dtFecha1)
        Me.GroupBox1.Controls.Add(Me.dtFecha2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(153, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 58)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione y busque"
        Me.GroupBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Y"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitle.Location = New System.Drawing.Point(155, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 42)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "PEDIDOS"
        '
        'ChekOrderList
        '
        Me.ChekOrderList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ChekOrderList.CheckOnClick = True
        Me.ChekOrderList.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChekOrderList.FormattingEnabled = True
        Me.ChekOrderList.Items.AddRange(New Object() {"Todas", "Entre Fecha", "Entre Ordenes", "Por Cliente"})
        Me.ChekOrderList.Location = New System.Drawing.Point(344, 6)
        Me.ChekOrderList.MultiColumn = True
        Me.ChekOrderList.Name = "ChekOrderList"
        Me.ChekOrderList.Size = New System.Drawing.Size(309, 70)
        Me.ChekOrderList.TabIndex = 0
        '
        'btnNoselect
        '
        Me.btnNoselect.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNoselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNoselect.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectTable_16x16
        Me.btnNoselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNoselect.Location = New System.Drawing.Point(189, 3)
        Me.btnNoselect.Name = "btnNoselect"
        Me.btnNoselect.Size = New System.Drawing.Size(110, 25)
        Me.btnNoselect.TabIndex = 24
        Me.btnNoselect.Text = "Desseleccionar"
        Me.btnNoselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNoselect.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFactura.Image = Global.ECommercePlatformView.My.Resources.Resources.factura_32
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFactura.Location = New System.Drawing.Point(3, 239)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(75, 68)
        Me.btnFactura.TabIndex = 25
        Me.btnFactura.Tag = "Factura"
        Me.btnFactura.Text = "Emiitr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Factura"
        Me.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ChekOrderList)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 153)
        Me.Panel1.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(19, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 143)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCopy)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSelect)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNoselect)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrint)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(791, 30)
        Me.FlowLayoutPanel1.TabIndex = 31
        '
        'btnCopy
        '
        Me.btnCopy.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.Location = New System.Drawing.Point(3, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(60, 25)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "Copiar"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.ChangedClientButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnDetail)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNotaVenta)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnFactura)
        Me.FlowLayoutPanel2.Controls.Add(Me.SubmitToSalesButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(2, 155)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(84, 445)
        Me.FlowLayoutPanel2.TabIndex = 33
        '
        'SubmitToSalesButton
        '
        Me.SubmitToSalesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SubmitToSalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubmitToSalesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.luggage18
        Me.SubmitToSalesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SubmitToSalesButton.Location = New System.Drawing.Point(3, 313)
        Me.SubmitToSalesButton.Name = "SubmitToSalesButton"
        Me.SubmitToSalesButton.Size = New System.Drawing.Size(75, 98)
        Me.SubmitToSalesButton.TabIndex = 27
        Me.SubmitToSalesButton.Tag = "Factura"
        Me.SubmitToSalesButton.Text = "Envia a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ventas"
        Me.SubmitToSalesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SubmitToSalesButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(86, 563)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 37)
        Me.Panel2.TabIndex = 32
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.ECommercePlatformView.My.Resources.Resources.Close_32x32
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(715, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 37)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "&Cerrar"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(791, 372)
        Me.DataGridView1.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel3.Controls.Add(Me.lblInformacion)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(86, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(797, 408)
        Me.Panel3.TabIndex = 35
        '
        'frmList_OrdenVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(885, 602)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmList_OrdenVenta"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de pedidos y proformas.."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnNotaVenta As System.Windows.Forms.Button
    Friend WithEvents lblInformacion As System.Windows.Forms.Label
    Friend WithEvents btnBuscarFech As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumber1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNumber2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarOrden As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuVerDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ChekOrderList As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNoselect As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ChangedClientButton As Button
    Friend WithEvents SubmitToSalesButton As Button
    Friend WithEvents Panel3 As Panel
End Class
