<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCobroEmpleado
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0.00", System.Drawing.Color.Navy, System.Drawing.SystemColors.ControlDark, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0.00", System.Drawing.Color.Red, System.Drawing.SystemColors.ButtonFace, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0.00", System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.SystemColors.ControlDark, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0.00", System.Drawing.Color.Green, System.Drawing.SystemColors.ControlDark, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0.00")}, -1)
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
        Me.saltoTotalLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListViewDeuda = New System.Windows.Forms.ListView()
        Me.clmNumDoc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPagada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmProceso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmIdCobro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListViewResum = New System.Windows.Forms.ListView()
        Me.clmRTotalPagada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmRPagada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmrSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEnLista = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmRNSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.ListViewPago = New System.Windows.Forms.ListView()
        Me.NumPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanePieUltimoPago = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelPago = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.datePago = New System.Windows.Forms.DateTimePicker()
        Me.PaneUltipado = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintMatricialPago = New System.Windows.Forms.Button()
        Me.PrintTicketPago = New System.Windows.Forms.Button()
        Me.lblultimoPago = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanePie.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanePieUltimoPago.SuspendLayout()
        Me.PaneUltipado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarTodoToolStripMenuItem, Me.DeterminarToolStripMenuItem, Me.DesmarcarTotoToolStripMenuItem, Me.CambiarValorToolStripMenuItem, Me.EditarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 41)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MarcarTodoToolStripMenuItem
        '
        Me.MarcarTodoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.check_16
        Me.MarcarTodoToolStripMenuItem.Name = "MarcarTodoToolStripMenuItem"
        Me.MarcarTodoToolStripMenuItem.Size = New System.Drawing.Size(99, 37)
        Me.MarcarTodoToolStripMenuItem.Text = "Cobrar todo"
        '
        'DeterminarToolStripMenuItem
        '
        Me.DeterminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeterminarToolStripMenuItem.Name = "DeterminarToolStripMenuItem"
        Me.DeterminarToolStripMenuItem.Size = New System.Drawing.Size(117, 37)
        Me.DeterminarToolStripMenuItem.Text = "Determinar monto"
        Me.DeterminarToolStripMenuItem.ToolTipText = "Esta acción permitirá fijar automáticamente las facturas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que deben estas en proc" &
    "eso, para ajustar al monto solicitado por cliente." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.PanePie.Controls.Add(Me.saltoTotalLabel)
        Me.PanePie.Controls.Add(Me.TableLayoutPanel1)
        Me.PanePie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePie.Location = New System.Drawing.Point(0, 352)
        Me.PanePie.Name = "PanePie"
        Me.PanePie.Size = New System.Drawing.Size(874, 40)
        Me.PanePie.TabIndex = 3
        '
        'saltoTotalLabel
        '
        Me.saltoTotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saltoTotalLabel.AutoSize = True
        Me.saltoTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saltoTotalLabel.ForeColor = System.Drawing.Color.Red
        Me.saltoTotalLabel.Location = New System.Drawing.Point(1, 1)
        Me.saltoTotalLabel.Name = "saltoTotalLabel"
        Me.saltoTotalLabel.Size = New System.Drawing.Size(92, 29)
        Me.saltoTotalLabel.TabIndex = 1
        Me.saltoTotalLabel.Text = "Label2"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(707, 0)
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblFormaPago)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListViewPago)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanePieUltimoPago)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PaneUltipado)
        Me.SplitContainer1.Size = New System.Drawing.Size(874, 311)
        Me.SplitContainer1.SplitterDistance = 600
        Me.SplitContainer1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListViewDeuda)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(600, 224)
        Me.Panel2.TabIndex = 2
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
        Me.ListViewDeuda.Location = New System.Drawing.Point(2, 2)
        Me.ListViewDeuda.Name = "ListViewDeuda"
        Me.ListViewDeuda.Size = New System.Drawing.Size(596, 220)
        Me.ListViewDeuda.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListViewResum)
        Me.Panel1.Controls.Add(Me.btnFormaPago)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(600, 87)
        Me.Panel1.TabIndex = 0
        '
        'ListViewResum
        '
        Me.ListViewResum.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ListViewResum.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmRTotalPagada, Me.clmRPagada, Me.clmrSaldo, Me.clmEnLista, Me.clmRNSaldo})
        Me.ListViewResum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewResum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewResum.ForeColor = System.Drawing.Color.Red
        Me.ListViewResum.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListViewResum.Location = New System.Drawing.Point(2, 23)
        Me.ListViewResum.Name = "ListViewResum"
        Me.ListViewResum.Size = New System.Drawing.Size(519, 62)
        Me.ListViewResum.TabIndex = 4
        Me.ListViewResum.TabStop = False
        Me.ListViewResum.UseCompatibleStateImageBehavior = False
        Me.ListViewResum.View = System.Windows.Forms.View.Details
        '
        'clmRTotalPagada
        '
        Me.clmRTotalPagada.Text = "Deuda"
        Me.clmRTotalPagada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmRTotalPagada.Width = 68
        '
        'clmRPagada
        '
        Me.clmRPagada.Text = "Pagada"
        Me.clmRPagada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmRPagada.Width = 75
        '
        'clmrSaldo
        '
        Me.clmrSaldo.Text = "Saldo"
        Me.clmrSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmrSaldo.Width = 78
        '
        'clmEnLista
        '
        Me.clmEnLista.Text = "En Proceso"
        Me.clmEnLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmEnLista.Width = 115
        '
        'clmRNSaldo
        '
        Me.clmRNSaldo.Text = "Nuevo Saldo"
        Me.clmRNSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmRNSaldo.Width = 114
        '
        'btnFormaPago
        '
        Me.btnFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormaPago.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaPago.Location = New System.Drawing.Point(521, 23)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(77, 62)
        Me.btnFormaPago.TabIndex = 3
        Me.btnFormaPago.Text = "Efectuar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cobro"
        Me.btnFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFormaPago.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(596, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "     -- RESUMEN --"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.Location = New System.Drawing.Point(106, 147)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(77, 43)
        Me.lblFormaPago.TabIndex = 10
        Me.lblFormaPago.Text = "Label2"
        Me.lblFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormaPago.Visible = False
        '
        'ListViewPago
        '
        Me.ListViewPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListViewPago.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumPago, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewPago.FullRowSelect = True
        Me.ListViewPago.GridLines = True
        Me.ListViewPago.Location = New System.Drawing.Point(0, 65)
        Me.ListViewPago.Name = "ListViewPago"
        Me.ListViewPago.Size = New System.Drawing.Size(270, 180)
        Me.ListViewPago.TabIndex = 9
        Me.ListViewPago.UseCompatibleStateImageBehavior = False
        Me.ListViewPago.View = System.Windows.Forms.View.Details
        '
        'NumPago
        '
        Me.NumPago.Text = "Num Pago"
        Me.NumPago.Width = 100
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
        'PanePieUltimoPago
        '
        Me.PanePieUltimoPago.BackColor = System.Drawing.Color.Goldenrod
        Me.PanePieUltimoPago.ColumnCount = 3
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7451!))
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2549!))
        Me.PanePieUltimoPago.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.PanePieUltimoPago.Controls.Add(Me.btnCancelPago, 2, 0)
        Me.PanePieUltimoPago.Controls.Add(Me.btnPago, 1, 0)
        Me.PanePieUltimoPago.Controls.Add(Me.datePago, 0, 0)
        Me.PanePieUltimoPago.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePieUltimoPago.Location = New System.Drawing.Point(0, 245)
        Me.PanePieUltimoPago.Name = "PanePieUltimoPago"
        Me.PanePieUltimoPago.RowCount = 1
        Me.PanePieUltimoPago.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PanePieUltimoPago.Size = New System.Drawing.Size(270, 66)
        Me.PanePieUltimoPago.TabIndex = 7
        Me.PanePieUltimoPago.Visible = False
        '
        'btnCancelPago
        '
        Me.btnCancelPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Cancel_32x32
        Me.btnCancelPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelPago.Location = New System.Drawing.Point(195, 3)
        Me.btnCancelPago.Name = "btnCancelPago"
        Me.btnCancelPago.Size = New System.Drawing.Size(72, 60)
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
        Me.btnPago.Location = New System.Drawing.Point(124, 3)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(65, 60)
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
        Me.datePago.Size = New System.Drawing.Size(115, 23)
        Me.datePago.TabIndex = 3
        '
        'PaneUltipado
        '
        Me.PaneUltipado.BackColor = System.Drawing.Color.Gold
        Me.PaneUltipado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneUltipado.Controls.Add(Me.Button1)
        Me.PaneUltipado.Controls.Add(Me.PrintMatricialPago)
        Me.PaneUltipado.Controls.Add(Me.PrintTicketPago)
        Me.PaneUltipado.Controls.Add(Me.lblultimoPago)
        Me.PaneUltipado.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneUltipado.Location = New System.Drawing.Point(0, 0)
        Me.PaneUltipado.Name = "PaneUltipado"
        Me.PaneUltipado.Size = New System.Drawing.Size(270, 65)
        Me.PaneUltipado.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.ECommercePlatformView.My.Resources.Resources.ActionsInDetailView
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(128, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 38)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Detalle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintMatricialPago
        '
        Me.PrintMatricialPago.BackColor = System.Drawing.Color.Orange
        Me.PrintMatricialPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintMatricialPago.ForeColor = System.Drawing.Color.Black
        Me.PrintMatricialPago.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.PrintMatricialPago.Location = New System.Drawing.Point(67, 25)
        Me.PrintMatricialPago.Name = "PrintMatricialPago"
        Me.PrintMatricialPago.Size = New System.Drawing.Size(61, 38)
        Me.PrintMatricialPago.TabIndex = 70
        Me.PrintMatricialPago.UseVisualStyleBackColor = False
        '
        'PrintTicketPago
        '
        Me.PrintTicketPago.BackColor = System.Drawing.Color.Orange
        Me.PrintTicketPago.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintTicketPago.ForeColor = System.Drawing.Color.Black
        Me.PrintTicketPago.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_32x32
        Me.PrintTicketPago.Location = New System.Drawing.Point(0, 25)
        Me.PrintTicketPago.Name = "PrintTicketPago"
        Me.PrintTicketPago.Size = New System.Drawing.Size(67, 38)
        Me.PrintTicketPago.TabIndex = 70
        Me.PrintTicketPago.UseVisualStyleBackColor = False
        '
        'lblultimoPago
        '
        Me.lblultimoPago.BackColor = System.Drawing.Color.Gold
        Me.lblultimoPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblultimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblultimoPago.Location = New System.Drawing.Point(0, 0)
        Me.lblultimoPago.Name = "lblultimoPago"
        Me.lblultimoPago.Size = New System.Drawing.Size(268, 25)
        Me.lblultimoPago.TabIndex = 10
        Me.lblultimoPago.Text = "-- Ultimos Pagos --"
        Me.lblultimoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCobroEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 392)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanePie)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobroEmpleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cobro deuda empleados.."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanePie.ResumeLayout(False)
        Me.PanePie.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanePieUltimoPago.ResumeLayout(False)
        Me.PaneUltipado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MarcarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeterminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesmarcarTotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarValorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoSeleccionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanePie As Panel
    Friend WithEvents saltoTotalLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PaneUltipado As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintMatricialPago As Button
    Friend WithEvents PrintTicketPago As Button
    Friend WithEvents lblultimoPago As Label
    Friend WithEvents PanePieUltimoPago As TableLayoutPanel
    Friend WithEvents btnCancelPago As Button
    Friend WithEvents btnPago As Button
    Friend WithEvents datePago As DateTimePicker
    Friend WithEvents ListViewPago As ListView
    Friend WithEvents NumPago As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents ListViewResum As ListView
    Friend WithEvents clmRTotalPagada As ColumnHeader
    Friend WithEvents clmRPagada As ColumnHeader
    Friend WithEvents clmrSaldo As ColumnHeader
    Friend WithEvents clmEnLista As ColumnHeader
    Friend WithEvents clmRNSaldo As ColumnHeader
    Friend WithEvents ListViewDeuda As ListView
    Friend WithEvents clmNumDoc As ColumnHeader
    Friend WithEvents clmFecha As ColumnHeader
    Friend WithEvents clmTotal As ColumnHeader
    Friend WithEvents clmPagada As ColumnHeader
    Friend WithEvents clmSaldo As ColumnHeader
    Friend WithEvents clmProceso As ColumnHeader
    Friend WithEvents clmIdCobro As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFormaPago As Label
End Class
