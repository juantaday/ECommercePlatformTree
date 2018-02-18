<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MarcarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeterminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesmarcarTotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarValorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoSeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanePie = New System.Windows.Forms.Panel()
        Me.PaneUltimoP = New System.Windows.Forms.Panel()
        Me.ListViewPago = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.PanePieUltimoPago = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelPago = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.datePago = New System.Windows.Forms.DateTimePicker()
        Me.PaneUltipado = New System.Windows.Forms.Panel()
        Me.btnViewDetailPago = New System.Windows.Forms.Button()
        Me.btnPrintPago = New System.Windows.Forms.Button()
        Me.lblultimoPago = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PaneCentral = New System.Windows.Forms.Panel()
        Me.ListViewDeuda = New System.Windows.Forms.ListView()
        Me.clmNumDoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPagada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmProceso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmIdCobro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanePieDetail = New System.Windows.Forms.Panel()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EnprocesoTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDeudaText = New System.Windows.Forms.TextBox()
        Me.PagadasTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoTextBox = New System.Windows.Forms.TextBox()
        Me.NuevoSaldoTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PanePie.SuspendLayout()
        Me.PaneUltimoP.SuspendLayout()
        Me.PanePieUltimoPago.SuspendLayout()
        Me.PaneUltipado.SuspendLayout()
        Me.PaneCentral.SuspendLayout()
        Me.PanePieDetail.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(835, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(167, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 34)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(86, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 34)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarTodoToolStripMenuItem, Me.DeterminarToolStripMenuItem, Me.DesmarcarTotoToolStripMenuItem, Me.CambiarValorToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1002, 41)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MarcarTodoToolStripMenuItem
        '
        Me.MarcarTodoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.MarcarTodoToolStripMenuItem.Name = "MarcarTodoToolStripMenuItem"
        Me.MarcarTodoToolStripMenuItem.Size = New System.Drawing.Size(93, 37)
        Me.MarcarTodoToolStripMenuItem.Text = "Pagar todo"
        '
        'DeterminarToolStripMenuItem
        '
        Me.DeterminarToolStripMenuItem.Image = CType(resources.GetObject("DeterminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeterminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeterminarToolStripMenuItem.Name = "DeterminarToolStripMenuItem"
        Me.DeterminarToolStripMenuItem.Size = New System.Drawing.Size(149, 37)
        Me.DeterminarToolStripMenuItem.Text = "Determinar monto"
        Me.DeterminarToolStripMenuItem.ToolTipText = "Determinar el monto de pago parcial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DesmarcarTotoToolStripMenuItem
        '
        Me.DesmarcarTotoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.check_not16
        Me.DesmarcarTotoToolStripMenuItem.Name = "DesmarcarTotoToolStripMenuItem"
        Me.DesmarcarTotoToolStripMenuItem.Size = New System.Drawing.Size(116, 37)
        Me.DesmarcarTotoToolStripMenuItem.Text = "Desmarcar toto"
        '
        'CambiarValorToolStripMenuItem
        '
        Me.CambiarValorToolStripMenuItem.Name = "CambiarValorToolStripMenuItem"
        Me.CambiarValorToolStripMenuItem.Size = New System.Drawing.Size(93, 37)
        Me.CambiarValorToolStripMenuItem.Text = "Cambiar valor"
        Me.CambiarValorToolStripMenuItem.ToolTipText = "Cambiar solo una parte a cobrar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarTodoToolStripMenuItem, Me.NoSeleccionarToolStripMenuItem, Me.CpiarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(90, 37)
        Me.EditarToolStripMenuItem.Text = "Herramientas"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'NoSeleccionarToolStripMenuItem
        '
        Me.NoSeleccionarToolStripMenuItem.Name = "NoSeleccionarToolStripMenuItem"
        Me.NoSeleccionarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NoSeleccionarToolStripMenuItem.Text = "No seleccionar"
        '
        'CpiarToolStripMenuItem
        '
        Me.CpiarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.CpiarToolStripMenuItem.Name = "CpiarToolStripMenuItem"
        Me.CpiarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CpiarToolStripMenuItem.Text = "Copiar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(81, 37)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'PanePie
        '
        Me.PanePie.BackColor = System.Drawing.SystemColors.Control
        Me.PanePie.Controls.Add(Me.TableLayoutPanel1)
        Me.PanePie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePie.Location = New System.Drawing.Point(0, 378)
        Me.PanePie.Name = "PanePie"
        Me.PanePie.Size = New System.Drawing.Size(1002, 40)
        Me.PanePie.TabIndex = 2
        '
        'PaneUltimoP
        '
        Me.PaneUltimoP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PaneUltimoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneUltimoP.Controls.Add(Me.ListViewPago)
        Me.PaneUltimoP.Controls.Add(Me.lblFormaPago)
        Me.PaneUltimoP.Controls.Add(Me.PanePieUltimoPago)
        Me.PaneUltimoP.Controls.Add(Me.PaneUltipado)
        Me.PaneUltimoP.Dock = System.Windows.Forms.DockStyle.Right
        Me.PaneUltimoP.Location = New System.Drawing.Point(694, 41)
        Me.PaneUltimoP.Name = "PaneUltimoP"
        Me.PaneUltimoP.Size = New System.Drawing.Size(308, 337)
        Me.PaneUltimoP.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.PaneUltimoP, "Informacion del ultimo pago")
        '
        'ListViewPago
        '
        Me.ListViewPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListViewPago.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewPago.FullRowSelect = True
        Me.ListViewPago.GridLines = True
        Me.ListViewPago.Location = New System.Drawing.Point(0, 65)
        Me.ListViewPago.Name = "ListViewPago"
        Me.ListViewPago.Size = New System.Drawing.Size(306, 213)
        Me.ListViewPago.TabIndex = 8
        Me.ListViewPago.UseCompatibleStateImageBehavior = False
        Me.ListViewPago.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Num Pago"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha Pago"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Letras"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 100
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.Location = New System.Drawing.Point(127, 209)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(77, 32)
        Me.lblFormaPago.TabIndex = 7
        Me.lblFormaPago.Text = "Label2"
        Me.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormaPago.Visible = False
        '
        'PanePieUltimoPago
        '
        Me.PanePieUltimoPago.BackColor = System.Drawing.Color.Goldenrod
        Me.PanePieUltimoPago.ColumnCount = 3
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7451!))
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2549!))
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.PanePieUltimoPago.Controls.Add(Me.btnCancelPago, 2, 0)
        Me.PanePieUltimoPago.Controls.Add(Me.btnPago, 1, 0)
        Me.PanePieUltimoPago.Controls.Add(Me.datePago, 0, 0)
        Me.PanePieUltimoPago.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePieUltimoPago.Location = New System.Drawing.Point(0, 278)
        Me.PanePieUltimoPago.Name = "PanePieUltimoPago"
        Me.PanePieUltimoPago.RowCount = 1
        Me.PanePieUltimoPago.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanePieUltimoPago.Size = New System.Drawing.Size(306, 57)
        Me.PanePieUltimoPago.TabIndex = 6
        Me.PanePieUltimoPago.Visible = False
        '
        'btnCancelPago
        '
        Me.btnCancelPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Cancel_32x32
        Me.btnCancelPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelPago.Location = New System.Drawing.Point(238, 3)
        Me.btnCancelPago.Name = "btnCancelPago"
        Me.btnCancelPago.Size = New System.Drawing.Size(65, 51)
        Me.btnCancelPago.TabIndex = 2
        Me.btnCancelPago.Text = "Cancelar"
        Me.btnCancelPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPago.UseVisualStyleBackColor = True
        '
        'btnPago
        '
        Me.btnPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Save_32x32
        Me.btnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPago.Location = New System.Drawing.Point(151, 3)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(81, 51)
        Me.btnPago.TabIndex = 1
        Me.btnPago.Text = "Efectuar"
        Me.btnPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'datePago
        '
        Me.datePago.Dock = System.Windows.Forms.DockStyle.Top
        Me.datePago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePago.Location = New System.Drawing.Point(3, 3)
        Me.datePago.Name = "datePago"
        Me.datePago.Size = New System.Drawing.Size(142, 23)
        Me.datePago.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.datePago, "Fecha de cobro")
        '
        'PaneUltipado
        '
        Me.PaneUltipado.BackColor = System.Drawing.Color.Gold
        Me.PaneUltipado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneUltipado.Controls.Add(Me.btnViewDetailPago)
        Me.PaneUltipado.Controls.Add(Me.btnPrintPago)
        Me.PaneUltipado.Controls.Add(Me.lblultimoPago)
        Me.PaneUltipado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneUltipado.Location = New System.Drawing.Point(0, 0)
        Me.PaneUltipado.Name = "PaneUltipado"
        Me.PaneUltipado.Size = New System.Drawing.Size(306, 65)
        Me.PaneUltipado.TabIndex = 4
        '
        'btnViewDetailPago
        '
        Me.btnViewDetailPago.BackColor = System.Drawing.Color.Orange
        Me.btnViewDetailPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnViewDetailPago.ForeColor = System.Drawing.Color.Black
        Me.btnViewDetailPago.Image = Global.ECommercePlatformView.My.Resources.Resources.ActionsInDetailView
        Me.btnViewDetailPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDetailPago.Location = New System.Drawing.Point(92, 25)
        Me.btnViewDetailPago.Name = "btnViewDetailPago"
        Me.btnViewDetailPago.Size = New System.Drawing.Size(91, 38)
        Me.btnViewDetailPago.TabIndex = 70
        Me.btnViewDetailPago.Text = "Detalle"
        Me.btnViewDetailPago.UseVisualStyleBackColor = False
        '
        'btnPrintPago
        '
        Me.btnPrintPago.BackColor = System.Drawing.Color.Orange
        Me.btnPrintPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrintPago.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.btnPrintPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintPago.Location = New System.Drawing.Point(0, 25)
        Me.btnPrintPago.Name = "btnPrintPago"
        Me.btnPrintPago.Size = New System.Drawing.Size(92, 38)
        Me.btnPrintPago.TabIndex = 70
        Me.btnPrintPago.Text = "Imprimir"
        Me.ToolTip1.SetToolTip(Me.btnPrintPago, "Imprimir Solo la factura selecionada")
        Me.btnPrintPago.UseVisualStyleBackColor = False
        '
        'lblultimoPago
        '
        Me.lblultimoPago.BackColor = System.Drawing.Color.Gold
        Me.lblultimoPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblultimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblultimoPago.Location = New System.Drawing.Point(0, 0)
        Me.lblultimoPago.Name = "lblultimoPago"
        Me.lblultimoPago.Size = New System.Drawing.Size(304, 25)
        Me.lblultimoPago.TabIndex = 10
        Me.lblultimoPago.Text = "-- Ultimos Pagos --"
        Me.lblultimoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaneCentral
        '
        Me.PaneCentral.Controls.Add(Me.ListViewDeuda)
        Me.PaneCentral.Controls.Add(Me.PanePieDetail)
        Me.PaneCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneCentral.Location = New System.Drawing.Point(0, 41)
        Me.PaneCentral.Name = "PaneCentral"
        Me.PaneCentral.Size = New System.Drawing.Size(694, 337)
        Me.PaneCentral.TabIndex = 4
        '
        'ListViewDeuda
        '
        Me.ListViewDeuda.CheckBoxes = True
        Me.ListViewDeuda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmNumDoc, Me.clmFecha, Me.clmTotal, Me.clmPagada, Me.clmSaldo, Me.clmProceso, Me.clmIdCobro})
        Me.ListViewDeuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewDeuda.FullRowSelect = True
        Me.ListViewDeuda.GridLines = True
        Me.ListViewDeuda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewDeuda.HideSelection = False
        Me.ListViewDeuda.Location = New System.Drawing.Point(0, 0)
        Me.ListViewDeuda.Name = "ListViewDeuda"
        Me.ListViewDeuda.Size = New System.Drawing.Size(694, 248)
        Me.ListViewDeuda.TabIndex = 0
        Me.ListViewDeuda.UseCompatibleStateImageBehavior = False
        Me.ListViewDeuda.View = System.Windows.Forms.View.Details
        '
        'clmNumDoc
        '
        Me.clmNumDoc.Text = "Num Documento"
        Me.clmNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmNumDoc.Width = 131
        '
        'clmFecha
        '
        Me.clmFecha.Text = "Fecha Compra"
        Me.clmFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmFecha.Width = 117
        '
        'clmTotal
        '
        Me.clmTotal.Text = "Total Deuda"
        Me.clmTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmTotal.Width = 100
        '
        'clmPagada
        '
        Me.clmPagada.Text = "Pagada"
        Me.clmPagada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmPagada.Width = 100
        '
        'clmSaldo
        '
        Me.clmSaldo.Text = "Saldo"
        Me.clmSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmSaldo.Width = 100
        '
        'clmProceso
        '
        Me.clmProceso.Text = "En proceso"
        Me.clmProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmProceso.Width = 100
        '
        'clmIdCobro
        '
        Me.clmIdCobro.Text = "idCobro"
        Me.clmIdCobro.Width = 0
        '
        'PanePieDetail
        '
        Me.PanePieDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanePieDetail.Controls.Add(Me.TableLayoutPanel2)
        Me.PanePieDetail.Controls.Add(Me.btnFormaPago)
        Me.PanePieDetail.Controls.Add(Me.Label1)
        Me.PanePieDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePieDetail.Location = New System.Drawing.Point(0, 248)
        Me.PanePieDetail.Name = "PanePieDetail"
        Me.PanePieDetail.Size = New System.Drawing.Size(694, 89)
        Me.PanePieDetail.TabIndex = 1
        '
        'btnFormaPago
        '
        Me.btnFormaPago.BackColor = System.Drawing.Color.Navy
        Me.btnFormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormaPago.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Pago_48gif
        Me.btnFormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaPago.Location = New System.Drawing.Point(585, 35)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(109, 54)
        Me.btnFormaPago.TabIndex = 2
        Me.btnFormaPago.Text = "Efectuar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pago"
        Me.btnFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFormaPago.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "     -- RESUMEN --"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.NuevoSaldoTextBox, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.SaldoTextBox, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PagadasTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TotalDeudaText, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EnprocesoTextBox, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 35)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(585, 54)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total deuda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pagadas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(234, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Saldo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(351, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "En proceso"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkGreen
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(468, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nuevo saldo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnprocesoTextBox
        '
        Me.EnprocesoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnprocesoTextBox.Enabled = False
        Me.EnprocesoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnprocesoTextBox.ForeColor = System.Drawing.Color.Olive
        Me.EnprocesoTextBox.Location = New System.Drawing.Point(352, 27)
        Me.EnprocesoTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.EnprocesoTextBox.Multiline = True
        Me.EnprocesoTextBox.Name = "EnprocesoTextBox"
        Me.EnprocesoTextBox.Size = New System.Drawing.Size(115, 26)
        Me.EnprocesoTextBox.TabIndex = 1
        Me.EnprocesoTextBox.TabStop = False
        Me.EnprocesoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalDeudaText
        '
        Me.TotalDeudaText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalDeudaText.Enabled = False
        Me.TotalDeudaText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeudaText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalDeudaText.Location = New System.Drawing.Point(1, 27)
        Me.TotalDeudaText.Margin = New System.Windows.Forms.Padding(1)
        Me.TotalDeudaText.Multiline = True
        Me.TotalDeudaText.Name = "TotalDeudaText"
        Me.TotalDeudaText.Size = New System.Drawing.Size(115, 26)
        Me.TotalDeudaText.TabIndex = 2
        Me.TotalDeudaText.TabStop = False
        Me.TotalDeudaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PagadasTextBox
        '
        Me.PagadasTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagadasTextBox.Enabled = False
        Me.PagadasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagadasTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PagadasTextBox.Location = New System.Drawing.Point(118, 27)
        Me.PagadasTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.PagadasTextBox.Multiline = True
        Me.PagadasTextBox.Name = "PagadasTextBox"
        Me.PagadasTextBox.Size = New System.Drawing.Size(115, 26)
        Me.PagadasTextBox.TabIndex = 3
        Me.PagadasTextBox.TabStop = False
        Me.PagadasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SaldoTextBox
        '
        Me.SaldoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaldoTextBox.Enabled = False
        Me.SaldoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaldoTextBox.Location = New System.Drawing.Point(235, 27)
        Me.SaldoTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.SaldoTextBox.Multiline = True
        Me.SaldoTextBox.Name = "SaldoTextBox"
        Me.SaldoTextBox.Size = New System.Drawing.Size(115, 26)
        Me.SaldoTextBox.TabIndex = 4
        Me.SaldoTextBox.TabStop = False
        Me.SaldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuevoSaldoTextBox
        '
        Me.NuevoSaldoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NuevoSaldoTextBox.Enabled = False
        Me.NuevoSaldoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoSaldoTextBox.ForeColor = System.Drawing.Color.Green
        Me.NuevoSaldoTextBox.Location = New System.Drawing.Point(469, 27)
        Me.NuevoSaldoTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.NuevoSaldoTextBox.Multiline = True
        Me.NuevoSaldoTextBox.Name = "NuevoSaldoTextBox"
        Me.NuevoSaldoTextBox.Size = New System.Drawing.Size(115, 26)
        Me.NuevoSaldoTextBox.TabIndex = 5
        Me.NuevoSaldoTextBox.TabStop = False
        Me.NuevoSaldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmPagos
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1002, 418)
        Me.Controls.Add(Me.PaneCentral)
        Me.Controls.Add(Me.PaneUltimoP)
        Me.Controls.Add(Me.PanePie)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PAGO DE DEUDAS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanePie.ResumeLayout(False)
        Me.PaneUltimoP.ResumeLayout(False)
        Me.PanePieUltimoPago.ResumeLayout(False)
        Me.PaneUltipado.ResumeLayout(False)
        Me.PaneCentral.ResumeLayout(False)
        Me.PanePieDetail.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PanePie As System.Windows.Forms.Panel
    Friend WithEvents PaneUltimoP As System.Windows.Forms.Panel
    Friend WithEvents lblultimoPago As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPrintPago As System.Windows.Forms.Button
    Friend WithEvents PaneUltipado As System.Windows.Forms.Panel
    Friend WithEvents btnViewDetailPago As System.Windows.Forms.Button
    Friend WithEvents PaneCentral As System.Windows.Forms.Panel
    Friend WithEvents ListViewDeuda As System.Windows.Forms.ListView
    Friend WithEvents clmIdCobro As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmNumDoc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPagada As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmSaldo As System.Windows.Forms.ColumnHeader
    Friend WithEvents PanePieDetail As System.Windows.Forms.Panel
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesmarcarTotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clmProceso As System.Windows.Forms.ColumnHeader
    Friend WithEvents CambiarValorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoSeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeterminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnFormaPago As System.Windows.Forms.Button
    Friend WithEvents PanePieUltimoPago As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnPago As System.Windows.Forms.Button
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
    Friend WithEvents ListViewPago As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancelPago As System.Windows.Forms.Button
    Friend WithEvents datePago As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents NuevoSaldoTextBox As System.Windows.Forms.TextBox
    Private WithEvents SaldoTextBox As System.Windows.Forms.TextBox
    Private WithEvents PagadasTextBox As System.Windows.Forms.TextBox
    Private WithEvents TotalDeudaText As System.Windows.Forms.TextBox
    Private WithEvents EnprocesoTextBox As System.Windows.Forms.TextBox

End Class
