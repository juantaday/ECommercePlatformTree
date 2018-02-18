<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_Facturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_Facturas))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.printTicket = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.detailButton = New System.Windows.Forms.Button()
        Me.selectAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.anulaButton = New System.Windows.Forms.Button()
        Me.setIsPrinterButton = New System.Windows.Forms.Button()
        Me.devolucionButton = New System.Windows.Forms.Button()
        Me.printMatricialButton = New System.Windows.Forms.Button()
        Me.viewReportButton = New System.Windows.Forms.Button()
        Me.PrintSelectButton = New System.Windows.Forms.Button()
        Me.ListViewCabecera = New System.Windows.Forms.ListView()
        Me.IdFactureColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FacturColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nom_Docu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClienteColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fecDesColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FecHastColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Base0Colum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Base12Column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IvaColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmOtroValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DireccColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TipVentcolumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RucColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewDetail = New System.Windows.Forms.ListView()
        Me.CantidadColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEmpaque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nom_ProductColm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pvpColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ivaColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalDecimalColm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdPresentacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCommands = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmSEparador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDevuellto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDisponible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDisponibleDecimal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pvpDecimalColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCountItem = New System.Windows.Forms.Label()
        Me.bntBuscar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.CmbOptionSelect = New System.Windows.Forms.ComboBox()
        Me.paneTitulo = New System.Windows.Forms.Panel()
        Me.PanePie = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbltotalFactur = New System.Windows.Forms.Label()
        Me.lblNoInforcion = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNoselect = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelImputDate = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerStar = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.PaneCentral = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControls = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OperacionNumLabel = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.User_operaLabel = New System.Windows.Forms.Label()
        Me.saveDevolucionButton = New System.Windows.Forms.Button()
        Me.CancelDevolucionButton = New System.Windows.Forms.Button()
        Me.PanelnformacionFactura = New System.Windows.Forms.Panel()
        Me.lblTituloDetalle = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PaneDetalle = New System.Windows.Forms.Panel()
        Me.PanelViewDevol = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListViewDevueltos = New System.Windows.Forms.ListView()
        Me.idPresentPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CantidadPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmpaquePrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nom_ProductPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pvpUnitPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalDecimalPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cantidadDecimalPrevio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TotalDevolverLabel = New System.Windows.Forms.Label()
        Me.paneTitulo.SuspendLayout()
        Me.PanePie.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.PanelImputDate.SuspendLayout()
        Me.PaneCentral.SuspendLayout()
        Me.PanelView.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelControls.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelnformacionFactura.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PaneDetalle.SuspendLayout()
        Me.PanelViewDevol.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(574, 36)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Facturas, notas de venta y proformas"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'printTicket
        '
        Me.printTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.printTicket.Dock = System.Windows.Forms.DockStyle.Left
        Me.printTicket.Image = Global.ECommercePlatformView.My.Resources.Resources.PrintList_24
        Me.printTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printTicket.Location = New System.Drawing.Point(338, 0)
        Me.printTicket.Name = "printTicket"
        Me.printTicket.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.printTicket.Size = New System.Drawing.Size(47, 42)
        Me.printTicket.TabIndex = 23
        Me.printTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.printTicket, "Imprimir 12 item en ticket")
        Me.printTicket.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Saltar espacios ...."
        Me.ToolTip1.SetToolTip(Me.Label1, "Espacios en blanco a saltar antes de imprimir la primera linea")
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSelectAll.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectAll_16x16
        Me.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectAll.Location = New System.Drawing.Point(3, 3)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(114, 25)
        Me.btnSelectAll.TabIndex = 24
        Me.btnSelectAll.Text = "Seleccionar todo"
        Me.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnSelectAll, "Selecionar todo el listado")
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'detailButton
        '
        Me.detailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detailButton.Location = New System.Drawing.Point(550, 22)
        Me.detailButton.Name = "detailButton"
        Me.detailButton.Size = New System.Drawing.Size(66, 19)
        Me.detailButton.TabIndex = 27
        Me.detailButton.Text = "........"
        Me.ToolTip1.SetToolTip(Me.detailButton, "Ver detalle de Documento")
        Me.detailButton.UseVisualStyleBackColor = True
        '
        'selectAllCheckBox
        '
        Me.selectAllCheckBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.selectAllCheckBox.Location = New System.Drawing.Point(8, 0)
        Me.selectAllCheckBox.Name = "selectAllCheckBox"
        Me.selectAllCheckBox.Size = New System.Drawing.Size(25, 42)
        Me.selectAllCheckBox.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.selectAllCheckBox, "Seleccionar todo..")
        Me.selectAllCheckBox.UseVisualStyleBackColor = True
        '
        'anulaButton
        '
        Me.anulaButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.anulaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.NullDocument_32
        Me.anulaButton.Location = New System.Drawing.Point(217, 0)
        Me.anulaButton.Name = "anulaButton"
        Me.anulaButton.Size = New System.Drawing.Size(60, 42)
        Me.anulaButton.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.anulaButton, "Anular documento")
        Me.anulaButton.UseVisualStyleBackColor = True
        '
        'setIsPrinterButton
        '
        Me.setIsPrinterButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.setIsPrinterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.ok_32
        Me.setIsPrinterButton.Location = New System.Drawing.Point(163, 0)
        Me.setIsPrinterButton.Name = "setIsPrinterButton"
        Me.setIsPrinterButton.Size = New System.Drawing.Size(54, 42)
        Me.setIsPrinterButton.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.setIsPrinterButton, "Establecer como documentos ya impresos.")
        Me.setIsPrinterButton.UseVisualStyleBackColor = True
        '
        'devolucionButton
        '
        Me.devolucionButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.devolucionButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Product_return_32
        Me.devolucionButton.Location = New System.Drawing.Point(277, 0)
        Me.devolucionButton.Name = "devolucionButton"
        Me.devolucionButton.Size = New System.Drawing.Size(61, 42)
        Me.devolucionButton.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.devolucionButton, "Devolución de productos.")
        Me.devolucionButton.UseVisualStyleBackColor = True
        '
        'printMatricialButton
        '
        Me.printMatricialButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.printMatricialButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.printMatricialButton.Location = New System.Drawing.Point(53, 0)
        Me.printMatricialButton.Name = "printMatricialButton"
        Me.printMatricialButton.Size = New System.Drawing.Size(63, 42)
        Me.printMatricialButton.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.printMatricialButton, "Imprimir en matricial.")
        Me.printMatricialButton.UseVisualStyleBackColor = True
        '
        'viewReportButton
        '
        Me.viewReportButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.viewReportButton.Image = Global.ECommercePlatformView.My.Resources.Resources.fin_deudor_32
        Me.viewReportButton.Location = New System.Drawing.Point(0, 0)
        Me.viewReportButton.Name = "viewReportButton"
        Me.viewReportButton.Size = New System.Drawing.Size(53, 42)
        Me.viewReportButton.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.viewReportButton, "Vista previa del documento.")
        Me.viewReportButton.UseVisualStyleBackColor = True
        '
        'PrintSelectButton
        '
        Me.PrintSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PrintSelectButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintSelectButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_32x32
        Me.PrintSelectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintSelectButton.Location = New System.Drawing.Point(116, 0)
        Me.PrintSelectButton.Name = "PrintSelectButton"
        Me.PrintSelectButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrintSelectButton.Size = New System.Drawing.Size(47, 42)
        Me.PrintSelectButton.TabIndex = 29
        Me.PrintSelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.PrintSelectButton, "Imprimir en ticket.")
        Me.PrintSelectButton.UseVisualStyleBackColor = True
        '
        'ListViewCabecera
        '
        Me.ListViewCabecera.CheckBoxes = True
        Me.ListViewCabecera.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdFactureColum, Me.FacturColum, Me.Nom_Docu, Me.ClienteColumn, Me.fecDesColum, Me.FecHastColumn, Me.Base0Colum, Me.Base12Column, Me.IvaColum, Me.clmOtroValor, Me.TotalColum, Me.DireccColumn, Me.TipVentcolumn, Me.RucColumn})
        Me.ListViewCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewCabecera.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewCabecera.FullRowSelect = True
        Me.ListViewCabecera.GridLines = True
        Me.ListViewCabecera.HideSelection = False
        Me.ListViewCabecera.Location = New System.Drawing.Point(0, 0)
        Me.ListViewCabecera.Name = "ListViewCabecera"
        Me.ListViewCabecera.Size = New System.Drawing.Size(618, 416)
        Me.ListViewCabecera.TabIndex = 66
        Me.ListViewCabecera.UseCompatibleStateImageBehavior = False
        Me.ListViewCabecera.View = System.Windows.Forms.View.Details
        '
        'IdFactureColum
        '
        Me.IdFactureColum.Text = "ID"
        Me.IdFactureColum.Width = 150
        '
        'FacturColum
        '
        Me.FacturColum.Text = "Num documeto"
        Me.FacturColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FacturColum.Width = 188
        '
        'Nom_Docu
        '
        Me.Nom_Docu.Text = "Tipo documento"
        Me.Nom_Docu.Width = 180
        '
        'ClienteColumn
        '
        Me.ClienteColumn.Text = "Cliente"
        Me.ClienteColumn.Width = 150
        '
        'fecDesColum
        '
        Me.fecDesColum.Text = "Fecha Desde"
        Me.fecDesColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fecDesColum.Width = 100
        '
        'FecHastColumn
        '
        Me.FecHastColumn.Text = "Fecha Hasta "
        Me.FecHastColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FecHastColumn.Width = 100
        '
        'Base0Colum
        '
        Me.Base0Colum.Text = "Exento de IVA"
        Me.Base0Colum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Base0Colum.Width = 70
        '
        'Base12Column
        '
        Me.Base12Column.Text = "Base IVA"
        Me.Base12Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Base12Column.Width = 81
        '
        'IvaColum
        '
        Me.IvaColum.Text = "IVA"
        Me.IvaColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'clmOtroValor
        '
        Me.clmOtroValor.Text = "OtrosValores"
        Me.clmOtroValor.Width = 95
        '
        'TotalColum
        '
        Me.TotalColum.Text = "Total"
        Me.TotalColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalColum.Width = 104
        '
        'DireccColumn
        '
        Me.DireccColumn.Text = "Direccion"
        Me.DireccColumn.Width = 0
        '
        'TipVentcolumn
        '
        Me.TipVentcolumn.Text = "tipoVenta"
        Me.TipVentcolumn.Width = 0
        '
        'RucColumn
        '
        Me.RucColumn.Text = "Ruc"
        Me.RucColumn.Width = 0
        '
        'ListViewDetail
        '
        Me.ListViewDetail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CantidadColum, Me.clmEmpaque, Me.nom_ProductColm, Me.pvpColumn, Me.TotalColumn, Me.ivaColumn, Me.TotalDecimalColm, Me.IdPresentacion, Me.ColumnCommands, Me.clmSEparador, Me.ColumnDevuellto, Me.ColumnDisponible, Me.ColumnDisponibleDecimal, Me.pvpDecimalColumn})
        Me.ListViewDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewDetail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDetail.FullRowSelect = True
        Me.ListViewDetail.GridLines = True
        Me.ListViewDetail.Location = New System.Drawing.Point(0, 20)
        Me.ListViewDetail.Name = "ListViewDetail"
        Me.ListViewDetail.Size = New System.Drawing.Size(310, 350)
        Me.ListViewDetail.SmallImageList = Me.ImageList1
        Me.ListViewDetail.TabIndex = 67
        Me.ListViewDetail.UseCompatibleStateImageBehavior = False
        Me.ListViewDetail.View = System.Windows.Forms.View.Details
        '
        'CantidadColum
        '
        Me.CantidadColum.Text = "Cantidad vendida"
        Me.CantidadColum.Width = 100
        '
        'clmEmpaque
        '
        Me.clmEmpaque.Text = "Epm"
        Me.clmEmpaque.Width = 50
        '
        'nom_ProductColm
        '
        Me.nom_ProductColm.Text = "Articulo"
        Me.nom_ProductColm.Width = 180
        '
        'pvpColumn
        '
        Me.pvpColumn.Text = "P.Und"
        Me.pvpColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalColumn
        '
        Me.TotalColumn.Text = "Total"
        Me.TotalColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalColumn.Width = 70
        '
        'ivaColumn
        '
        Me.ivaColumn.Text = "Iva"
        Me.ivaColumn.Width = 0
        '
        'TotalDecimalColm
        '
        Me.TotalDecimalColm.Text = "total2Dijitos"
        Me.TotalDecimalColm.Width = 0
        '
        'IdPresentacion
        '
        Me.IdPresentacion.DisplayIndex = 8
        Me.IdPresentacion.Text = "Id Presentacion"
        Me.IdPresentacion.Width = 0
        '
        'ColumnCommands
        '
        Me.ColumnCommands.DisplayIndex = 7
        Me.ColumnCommands.Text = ""
        Me.ColumnCommands.Width = 90
        '
        'clmSEparador
        '
        Me.clmSEparador.Text = "sepadador"
        Me.clmSEparador.Width = 0
        '
        'ColumnDevuellto
        '
        Me.ColumnDevuellto.Text = "Cantidad devuelto"
        Me.ColumnDevuellto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnDevuellto.Width = 100
        '
        'ColumnDisponible
        '
        Me.ColumnDisponible.Text = "Cantidad disponible"
        Me.ColumnDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnDisponible.Width = 100
        '
        'ColumnDisponibleDecimal
        '
        Me.ColumnDisponibleDecimal.Width = 0
        '
        'pvpDecimalColumn
        '
        Me.pvpDecimalColumn.Text = "pvp decimal"
        Me.pvpDecimalColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pvpDecimalColumn.Width = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Move_next_16x16.png")
        '
        'lblCountItem
        '
        Me.lblCountItem.AutoSize = True
        Me.lblCountItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountItem.Location = New System.Drawing.Point(3, 6)
        Me.lblCountItem.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCountItem.Name = "lblCountItem"
        Me.lblCountItem.Size = New System.Drawing.Size(105, 16)
        Me.lblCountItem.TabIndex = 24
        Me.lblCountItem.Text = "Total articulos :0"
        '
        'bntBuscar
        '
        Me.bntBuscar.BackColor = System.Drawing.Color.Transparent
        Me.bntBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bntBuscar.Enabled = False
        Me.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bntBuscar.Location = New System.Drawing.Point(996, 3)
        Me.bntBuscar.Name = "bntBuscar"
        Me.bntBuscar.Size = New System.Drawing.Size(78, 26)
        Me.bntBuscar.TabIndex = 70
        Me.bntBuscar.Text = "Buscar...."
        Me.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntBuscar.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.Location = New System.Drawing.Point(210, 3)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(431, 26)
        Me.txtbuscar.TabIndex = 0
        '
        'CmbOptionSelect
        '
        Me.CmbOptionSelect.FormattingEnabled = True
        Me.CmbOptionSelect.Items.AddRange(New Object() {"ID", "Cliente", "Número de Factura", "Ruc (o) C.I", "Fecha del documento", "No Impresas"})
        Me.CmbOptionSelect.Location = New System.Drawing.Point(3, 3)
        Me.CmbOptionSelect.Name = "CmbOptionSelect"
        Me.CmbOptionSelect.Size = New System.Drawing.Size(201, 24)
        Me.CmbOptionSelect.TabIndex = 71
        Me.CmbOptionSelect.Text = "Número de Factura"
        '
        'paneTitulo
        '
        Me.paneTitulo.BackColor = System.Drawing.Color.Gainsboro
        Me.paneTitulo.Controls.Add(Me.lblTitle)
        Me.paneTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneTitulo.Location = New System.Drawing.Point(0, 0)
        Me.paneTitulo.Name = "paneTitulo"
        Me.paneTitulo.Size = New System.Drawing.Size(1215, 39)
        Me.paneTitulo.TabIndex = 77
        '
        'PanePie
        '
        Me.PanePie.BackColor = System.Drawing.SystemColors.Control
        Me.PanePie.Controls.Add(Me.btnClose)
        Me.PanePie.Controls.Add(Me.lbltotalFactur)
        Me.PanePie.Controls.Add(Me.lblNoInforcion)
        Me.PanePie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePie.Location = New System.Drawing.Point(0, 564)
        Me.PanePie.Name = "PanePie"
        Me.PanePie.Size = New System.Drawing.Size(1215, 42)
        Me.PanePie.TabIndex = 78
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.ECommercePlatformView.My.Resources.Resources.Close_32x32
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1133, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 42)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "&Cerrar"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lbltotalFactur
        '
        Me.lbltotalFactur.AutoSize = True
        Me.lbltotalFactur.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalFactur.Location = New System.Drawing.Point(30, 13)
        Me.lbltotalFactur.Name = "lbltotalFactur"
        Me.lbltotalFactur.Size = New System.Drawing.Size(101, 16)
        Me.lbltotalFactur.TabIndex = 24
        Me.lbltotalFactur.Text = "Total factura : 0"
        '
        'lblNoInforcion
        '
        Me.lblNoInforcion.AutoSize = True
        Me.lblNoInforcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoInforcion.ForeColor = System.Drawing.Color.Red
        Me.lblNoInforcion.Location = New System.Drawing.Point(10, 9)
        Me.lblNoInforcion.Name = "lblNoInforcion"
        Me.lblNoInforcion.Size = New System.Drawing.Size(237, 24)
        Me.lblNoInforcion.TabIndex = 73
        Me.lblNoInforcion.Text = "No existe información...."
        Me.lblNoInforcion.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSelectAll)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNoselect)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCopy)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 39)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1215, 32)
        Me.FlowLayoutPanel1.TabIndex = 79
        '
        'btnNoselect
        '
        Me.btnNoselect.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNoselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNoselect.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectTable_16x16
        Me.btnNoselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNoselect.Location = New System.Drawing.Point(123, 3)
        Me.btnNoselect.Name = "btnNoselect"
        Me.btnNoselect.Size = New System.Drawing.Size(143, 25)
        Me.btnNoselect.TabIndex = 24
        Me.btnNoselect.Text = "No seleccionar ninguno"
        Me.btnNoselect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNoselect.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.Location = New System.Drawing.Point(272, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(60, 25)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "Copiar"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel4.Controls.Add(Me.CmbOptionSelect)
        Me.FlowLayoutPanel4.Controls.Add(Me.txtbuscar)
        Me.FlowLayoutPanel4.Controls.Add(Me.PanelImputDate)
        Me.FlowLayoutPanel4.Controls.Add(Me.bntBuscar)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 71)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1215, 33)
        Me.FlowLayoutPanel4.TabIndex = 81
        '
        'PanelImputDate
        '
        Me.PanelImputDate.Controls.Add(Me.Label5)
        Me.PanelImputDate.Controls.Add(Me.Label4)
        Me.PanelImputDate.Controls.Add(Me.DateTimePickerStar)
        Me.PanelImputDate.Controls.Add(Me.DateTimePickerEnd)
        Me.PanelImputDate.Location = New System.Drawing.Point(647, 3)
        Me.PanelImputDate.Name = "PanelImputDate"
        Me.PanelImputDate.Size = New System.Drawing.Size(343, 27)
        Me.PanelImputDate.TabIndex = 74
        Me.PanelImputDate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Hasta: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Desde: "
        '
        'DateTimePickerStar
        '
        Me.DateTimePickerStar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerStar.Location = New System.Drawing.Point(60, 3)
        Me.DateTimePickerStar.Name = "DateTimePickerStar"
        Me.DateTimePickerStar.Size = New System.Drawing.Size(99, 23)
        Me.DateTimePickerStar.TabIndex = 73
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(234, 3)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(99, 23)
        Me.DateTimePickerEnd.TabIndex = 72
        '
        'PaneCentral
        '
        Me.PaneCentral.Controls.Add(Me.PanelView)
        Me.PaneCentral.Controls.Add(Me.Panel1)
        Me.PaneCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneCentral.Location = New System.Drawing.Point(0, 0)
        Me.PaneCentral.Name = "PaneCentral"
        Me.PaneCentral.Size = New System.Drawing.Size(618, 460)
        Me.PaneCentral.TabIndex = 82
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.ListViewCabecera)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 44)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(618, 416)
        Me.PanelView.TabIndex = 68
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PanelControls)
        Me.Panel1.Controls.Add(Me.detailButton)
        Me.Panel1.Controls.Add(Me.selectAllCheckBox)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 44)
        Me.Panel1.TabIndex = 67
        '
        'PanelControls
        '
        Me.PanelControls.Controls.Add(Me.printTicket)
        Me.PanelControls.Controls.Add(Me.devolucionButton)
        Me.PanelControls.Controls.Add(Me.anulaButton)
        Me.PanelControls.Controls.Add(Me.setIsPrinterButton)
        Me.PanelControls.Controls.Add(Me.PrintSelectButton)
        Me.PanelControls.Controls.Add(Me.printMatricialButton)
        Me.PanelControls.Controls.Add(Me.viewReportButton)
        Me.PanelControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControls.Location = New System.Drawing.Point(33, 0)
        Me.PanelControls.Name = "PanelControls"
        Me.PanelControls.Size = New System.Drawing.Size(482, 42)
        Me.PanelControls.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 42)
        Me.Panel3.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.OperacionNumLabel)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.User_operaLabel)
        Me.Panel2.Controls.Add(Me.saveDevolucionButton)
        Me.Panel2.Controls.Add(Me.CancelDevolucionButton)
        Me.Panel2.Controls.Add(Me.PanelnformacionFactura)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(593, 40)
        Me.Panel2.TabIndex = 68
        '
        'OperacionNumLabel
        '
        Me.OperacionNumLabel.AutoSize = True
        Me.OperacionNumLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.OperacionNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperacionNumLabel.Location = New System.Drawing.Point(480, 3)
        Me.OperacionNumLabel.Name = "OperacionNumLabel"
        Me.OperacionNumLabel.Size = New System.Drawing.Size(51, 17)
        Me.OperacionNumLabel.TabIndex = 82
        Me.OperacionNumLabel.Text = "Label4"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(531, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 34)
        Me.Panel7.TabIndex = 84
        '
        'User_operaLabel
        '
        Me.User_operaLabel.AutoSize = True
        Me.User_operaLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.User_operaLabel.Location = New System.Drawing.Point(551, 3)
        Me.User_operaLabel.Name = "User_operaLabel"
        Me.User_operaLabel.Size = New System.Drawing.Size(39, 13)
        Me.User_operaLabel.TabIndex = 83
        Me.User_operaLabel.Text = "Label4"
        '
        'saveDevolucionButton
        '
        Me.saveDevolucionButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.saveDevolucionButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Save_16x16
        Me.saveDevolucionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveDevolucionButton.Location = New System.Drawing.Point(331, 3)
        Me.saveDevolucionButton.Name = "saveDevolucionButton"
        Me.saveDevolucionButton.Size = New System.Drawing.Size(94, 34)
        Me.saveDevolucionButton.TabIndex = 81
        Me.saveDevolucionButton.Text = "Guardar"
        Me.saveDevolucionButton.UseVisualStyleBackColor = True
        '
        'CancelDevolucionButton
        '
        Me.CancelDevolucionButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CancelDevolucionButton.Image = Global.ECommercePlatformView.My.Resources.Resources.MovePrevio_16x16
        Me.CancelDevolucionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelDevolucionButton.Location = New System.Drawing.Point(231, 3)
        Me.CancelDevolucionButton.Name = "CancelDevolucionButton"
        Me.CancelDevolucionButton.Size = New System.Drawing.Size(100, 34)
        Me.CancelDevolucionButton.TabIndex = 79
        Me.CancelDevolucionButton.Text = "Cancelar"
        Me.CancelDevolucionButton.UseVisualStyleBackColor = True
        '
        'PanelnformacionFactura
        '
        Me.PanelnformacionFactura.AutoSize = True
        Me.PanelnformacionFactura.Controls.Add(Me.lblTituloDetalle)
        Me.PanelnformacionFactura.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelnformacionFactura.Location = New System.Drawing.Point(3, 3)
        Me.PanelnformacionFactura.Name = "PanelnformacionFactura"
        Me.PanelnformacionFactura.Size = New System.Drawing.Size(228, 34)
        Me.PanelnformacionFactura.TabIndex = 80
        '
        'lblTituloDetalle
        '
        Me.lblTituloDetalle.AutoSize = True
        Me.lblTituloDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDetalle.Location = New System.Drawing.Point(12, 8)
        Me.lblTituloDetalle.Name = "lblTituloDetalle"
        Me.lblTituloDetalle.Size = New System.Drawing.Size(213, 20)
        Me.lblTituloDetalle.TabIndex = 78
        Me.lblTituloDetalle.Text = "Detalle de la factura: 000035"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 104)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PaneCentral)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PaneDetalle)
        Me.SplitContainer1.Panel2.Margin = New System.Windows.Forms.Padding(3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1215, 460)
        Me.SplitContainer1.SplitterDistance = 618
        Me.SplitContainer1.TabIndex = 82
        '
        'PaneDetalle
        '
        Me.PaneDetalle.Controls.Add(Me.PanelViewDevol)
        Me.PaneDetalle.Controls.Add(Me.Panel2)
        Me.PaneDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneDetalle.Location = New System.Drawing.Point(0, 0)
        Me.PaneDetalle.Name = "PaneDetalle"
        Me.PaneDetalle.Size = New System.Drawing.Size(593, 460)
        Me.PaneDetalle.TabIndex = 0
        '
        'PanelViewDevol
        '
        Me.PanelViewDevol.Controls.Add(Me.SplitContainer2)
        Me.PanelViewDevol.Controls.Add(Me.Panel6)
        Me.PanelViewDevol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewDevol.Location = New System.Drawing.Point(0, 40)
        Me.PanelViewDevol.Name = "PanelViewDevol"
        Me.PanelViewDevol.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelViewDevol.Size = New System.Drawing.Size(593, 420)
        Me.PanelViewDevol.TabIndex = 69
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(587, 370)
        Me.SplitContainer2.SplitterDistance = 310
        Me.SplitContainer2.TabIndex = 83
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListViewDetail)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(310, 370)
        Me.Panel5.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Listado de compra (productos)"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListViewDevueltos)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(273, 370)
        Me.Panel4.TabIndex = 70
        '
        'ListViewDevueltos
        '
        Me.ListViewDevueltos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPresentPrevio, Me.CantidadPrevio, Me.EmpaquePrevio, Me.Nom_ProductPrevio, Me.pvpUnitPrevio, Me.TotalPrevio, Me.totalDecimalPrevio, Me.cantidadDecimalPrevio})
        Me.ListViewDevueltos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewDevueltos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDevueltos.FullRowSelect = True
        Me.ListViewDevueltos.GridLines = True
        Me.ListViewDevueltos.Location = New System.Drawing.Point(0, 20)
        Me.ListViewDevueltos.Name = "ListViewDevueltos"
        Me.ListViewDevueltos.Size = New System.Drawing.Size(273, 350)
        Me.ListViewDevueltos.TabIndex = 68
        Me.ListViewDevueltos.UseCompatibleStateImageBehavior = False
        Me.ListViewDevueltos.View = System.Windows.Forms.View.Details
        '
        'idPresentPrevio
        '
        Me.idPresentPrevio.Text = "Id Presentacion"
        Me.idPresentPrevio.Width = 0
        '
        'CantidadPrevio
        '
        Me.CantidadPrevio.Text = "Cantidad"
        Me.CantidadPrevio.Width = 50
        '
        'EmpaquePrevio
        '
        Me.EmpaquePrevio.Text = "Empaque"
        '
        'Nom_ProductPrevio
        '
        Me.Nom_ProductPrevio.Text = "Articulo"
        Me.Nom_ProductPrevio.Width = 164
        '
        'pvpUnitPrevio
        '
        Me.pvpUnitPrevio.Text = "P.Und"
        Me.pvpUnitPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalPrevio
        '
        Me.TotalPrevio.Text = "Total"
        Me.TotalPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalPrevio.Width = 100
        '
        'totalDecimalPrevio
        '
        Me.totalDecimalPrevio.Text = "total2Dijitos"
        Me.totalDecimalPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalDecimalPrevio.Width = 0
        '
        'cantidadDecimalPrevio
        '
        Me.cantidadDecimalPrevio.Width = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 20)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Listado de productos en devolución:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblCountItem)
        Me.Panel6.Controls.Add(Me.TotalDevolverLabel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 373)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(587, 44)
        Me.Panel6.TabIndex = 84
        '
        'TotalDevolverLabel
        '
        Me.TotalDevolverLabel.AutoSize = True
        Me.TotalDevolverLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TotalDevolverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDevolverLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalDevolverLabel.Location = New System.Drawing.Point(582, 5)
        Me.TotalDevolverLabel.Name = "TotalDevolverLabel"
        Me.TotalDevolverLabel.Size = New System.Drawing.Size(0, 24)
        Me.TotalDevolverLabel.TabIndex = 25
        '
        'frmList_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1215, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PanePie)
        Me.Controls.Add(Me.paneTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmList_Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de facturas, notas de venta, proformas."
        Me.paneTitulo.ResumeLayout(False)
        Me.paneTitulo.PerformLayout()
        Me.PanePie.ResumeLayout(False)
        Me.PanePie.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.PanelImputDate.ResumeLayout(False)
        Me.PanelImputDate.PerformLayout()
        Me.PaneCentral.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelControls.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelnformacionFactura.ResumeLayout(False)
        Me.PanelnformacionFactura.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PaneDetalle.ResumeLayout(False)
        Me.PanelViewDevol.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents printTicket As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListViewCabecera As System.Windows.Forms.ListView
    Friend WithEvents IdFactureColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents FacturColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClienteColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecDesColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents FecHastColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Base0Colum As System.Windows.Forms.ColumnHeader
    Friend WithEvents Base12Column As System.Windows.Forms.ColumnHeader
    Friend WithEvents IvaColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents DireccColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TipVentcolumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents RucColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewDetail As System.Windows.Forms.ListView
    Friend WithEvents CantidadColum As System.Windows.Forms.ColumnHeader
    Friend WithEvents nom_ProductColm As System.Windows.Forms.ColumnHeader
    Friend WithEvents pvpColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ivaColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCountItem As System.Windows.Forms.Label
    Friend WithEvents bntBuscar As System.Windows.Forms.Button
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents CmbOptionSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents paneTitulo As System.Windows.Forms.Panel
    Friend WithEvents PanePie As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnNoselect As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PaneCentral As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTituloDetalle As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents clmEmpaque As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltotalFactur As System.Windows.Forms.Label
    Friend WithEvents lblNoInforcion As System.Windows.Forms.Label
    Friend WithEvents clmOtroValor As System.Windows.Forms.ColumnHeader
    Friend WithEvents PaneDetalle As System.Windows.Forms.Panel
    Friend WithEvents TotalDecimalColm As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nom_Docu As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents anulaButton As Button
    Friend WithEvents printMatricialButton As Button
    Friend WithEvents viewReportButton As Button
    Friend WithEvents PanelView As Panel
    Friend WithEvents detailButton As Button
    Friend WithEvents PanelControls As Panel
    Friend WithEvents setIsPrinterButton As Button
    Friend WithEvents selectAllCheckBox As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents devolucionButton As Button
    Friend WithEvents CancelDevolucionButton As Button
    Friend WithEvents PanelnformacionFactura As Panel
    Friend WithEvents PanelViewDevol As Panel
    Friend WithEvents ListViewDevueltos As ListView
    Friend WithEvents idPresentPrevio As ColumnHeader
    Friend WithEvents CantidadPrevio As ColumnHeader
    Friend WithEvents Nom_ProductPrevio As ColumnHeader
    Friend WithEvents pvpUnitPrevio As ColumnHeader
    Friend WithEvents TotalPrevio As ColumnHeader
    Friend WithEvents totalDecimalPrevio As ColumnHeader
    Friend WithEvents saveDevolucionButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnCommands As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents IdPresentacion As ColumnHeader
    Friend WithEvents clmSEparador As ColumnHeader
    Friend WithEvents ColumnDevuellto As ColumnHeader
    Friend WithEvents ColumnDisponible As ColumnHeader
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents EmpaquePrevio As ColumnHeader
    Friend WithEvents cantidadDecimalPrevio As ColumnHeader
    Friend WithEvents ColumnDisponibleDecimal As ColumnHeader
    Friend WithEvents pvpDecimalColumn As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TotalDevolverLabel As Label
    Friend WithEvents OperacionNumLabel As Label
    Friend WithEvents User_operaLabel As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PrintSelectButton As Button
    Friend WithEvents PanelImputDate As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePickerStar As DateTimePicker
    Friend WithEvents DateTimePickerEnd As DateTimePicker
End Class
