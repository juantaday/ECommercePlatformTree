<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormaPago))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuEfectivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCredito = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCheque = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuCreditCar = New System.Windows.Forms.ToolStripMenuItem()
        Me.paneEfectivo = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPaga = New System.Windows.Forms.NumericUpDown()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.paneCheque = New System.Windows.Forms.Panel()
        Me.ValCaheqtxt = New System.Windows.Forms.TextBox()
        Me.fecha_cheqDatatime = New System.Windows.Forms.DateTimePicker()
        Me.fech_chelbl = New System.Windows.Forms.Label()
        Me.btnBancos = New System.Windows.Forms.Button()
        Me.cmbCuenta = New System.Windows.Forms.ComboBox()
        Me.cmbPropietario = New System.Windows.Forms.ComboBox()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Num_cheqTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.paneCredito = New System.Windows.Forms.Panel()
        Me.txtMontoMaximo = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtCreditoActual = New System.Windows.Forms.TextBox()
        Me.txtTotalDeuda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNom_Persona = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.paneEfectivo.SuspendLayout()
        CType(Me.txtPaga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneCheque.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneCredito.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(386, 705)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuEfectivo, Me.ToolStripMenuCredito, Me.ToolStripMenuCheque, Me.ToolStripMenuCreditCar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(163, 740)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuEfectivo
        '
        Me.ToolStripMenuEfectivo.Image = CType(resources.GetObject("ToolStripMenuEfectivo.Image"), System.Drawing.Image)
        Me.ToolStripMenuEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuEfectivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuEfectivo.Name = "ToolStripMenuEfectivo"
        Me.ToolStripMenuEfectivo.Size = New System.Drawing.Size(150, 52)
        Me.ToolStripMenuEfectivo.Text = "Efectivo"
        '
        'ToolStripMenuCredito
        '
        Me.ToolStripMenuCredito.Image = Global.ECommercePlatformView.My.Resources.Resources.Credid_48
        Me.ToolStripMenuCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuCredito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuCredito.Name = "ToolStripMenuCredito"
        Me.ToolStripMenuCredito.Size = New System.Drawing.Size(150, 52)
        Me.ToolStripMenuCredito.Text = "Crédito"
        '
        'ToolStripMenuCheque
        '
        Me.ToolStripMenuCheque.Image = Global.ECommercePlatformView.My.Resources.Resources.check_48png
        Me.ToolStripMenuCheque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuCheque.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuCheque.Name = "ToolStripMenuCheque"
        Me.ToolStripMenuCheque.Size = New System.Drawing.Size(150, 52)
        Me.ToolStripMenuCheque.Text = "Cheque"
        '
        'ToolStripMenuCreditCar
        '
        Me.ToolStripMenuCreditCar.Image = Global.ECommercePlatformView.My.Resources.Resources.credit_card48png
        Me.ToolStripMenuCreditCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuCreditCar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuCreditCar.Name = "ToolStripMenuCreditCar"
        Me.ToolStripMenuCreditCar.Size = New System.Drawing.Size(150, 52)
        Me.ToolStripMenuCreditCar.Text = "Tarjeta Crédito"
        '
        'paneEfectivo
        '
        Me.paneEfectivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneEfectivo.Controls.Add(Me.txtTotal)
        Me.paneEfectivo.Controls.Add(Me.txtPaga)
        Me.paneEfectivo.Controls.Add(Me.lblActual)
        Me.paneEfectivo.Controls.Add(Me.lblSaldo)
        Me.paneEfectivo.Location = New System.Drawing.Point(166, 10)
        Me.paneEfectivo.Name = "paneEfectivo"
        Me.paneEfectivo.Size = New System.Drawing.Size(368, 180)
        Me.paneEfectivo.TabIndex = 0
        Me.paneEfectivo.TabStop = True
        Me.paneEfectivo.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(7, 59)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(346, 61)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaga
        '
        Me.txtPaga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaga.DecimalPlaces = 2
        Me.txtPaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaga.Location = New System.Drawing.Point(143, 140)
        Me.txtPaga.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.txtPaga.Name = "txtPaga"
        Me.txtPaga.Size = New System.Drawing.Size(219, 29)
        Me.txtPaga.TabIndex = 0
        Me.txtPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(13, 137)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(114, 33)
        Me.lblActual.TabIndex = 1
        Me.lblActual.Text = "Pagó $:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(20, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(112, 33)
        Me.lblSaldo.TabIndex = 1
        Me.lblSaldo.Text = "Total $:"
        '
        'paneCheque
        '
        Me.paneCheque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneCheque.Controls.Add(Me.ValCaheqtxt)
        Me.paneCheque.Controls.Add(Me.fecha_cheqDatatime)
        Me.paneCheque.Controls.Add(Me.fech_chelbl)
        Me.paneCheque.Controls.Add(Me.btnBancos)
        Me.paneCheque.Controls.Add(Me.cmbCuenta)
        Me.paneCheque.Controls.Add(Me.cmbPropietario)
        Me.paneCheque.Controls.Add(Me.cmbBanco)
        Me.paneCheque.Controls.Add(Me.Num_cheqTxt)
        Me.paneCheque.Controls.Add(Me.Label4)
        Me.paneCheque.Controls.Add(Me.Label1)
        Me.paneCheque.Controls.Add(Me.Label17)
        Me.paneCheque.Controls.Add(Me.Label2)
        Me.paneCheque.Controls.Add(Me.Label3)
        Me.paneCheque.Location = New System.Drawing.Point(166, 197)
        Me.paneCheque.Name = "paneCheque"
        Me.paneCheque.Size = New System.Drawing.Size(368, 236)
        Me.paneCheque.TabIndex = 4
        Me.paneCheque.TabStop = True
        Me.paneCheque.Visible = False
        '
        'ValCaheqtxt
        '
        Me.ValCaheqtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValCaheqtxt.Location = New System.Drawing.Point(190, 205)
        Me.ValCaheqtxt.Name = "ValCaheqtxt"
        Me.ValCaheqtxt.ReadOnly = True
        Me.ValCaheqtxt.Size = New System.Drawing.Size(110, 23)
        Me.ValCaheqtxt.TabIndex = 8
        Me.ValCaheqtxt.Text = "0.00"
        Me.ValCaheqtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fecha_cheqDatatime
        '
        Me.fecha_cheqDatatime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_cheqDatatime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_cheqDatatime.Location = New System.Drawing.Point(6, 201)
        Me.fecha_cheqDatatime.Name = "fecha_cheqDatatime"
        Me.fecha_cheqDatatime.Size = New System.Drawing.Size(120, 23)
        Me.fecha_cheqDatatime.TabIndex = 7
        Me.fecha_cheqDatatime.Value = New Date(2015, 11, 16, 16, 28, 9, 0)
        '
        'fech_chelbl
        '
        Me.fech_chelbl.AutoSize = True
        Me.fech_chelbl.Location = New System.Drawing.Point(6, 183)
        Me.fech_chelbl.Name = "fech_chelbl"
        Me.fech_chelbl.Size = New System.Drawing.Size(100, 13)
        Me.fech_chelbl.TabIndex = 6
        Me.fech_chelbl.Text = "Fecha de cheque..."
        '
        'btnBancos
        '
        Me.btnBancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBancos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBancos.Location = New System.Drawing.Point(226, 1)
        Me.btnBancos.Name = "btnBancos"
        Me.btnBancos.Size = New System.Drawing.Size(131, 35)
        Me.btnBancos.TabIndex = 5
        Me.btnBancos.Text = "Agregar cuentas.."
        Me.btnBancos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnBancos, "Administrar Bancos")
        Me.btnBancos.UseVisualStyleBackColor = True
        '
        'cmbCuenta
        '
        Me.cmbCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuenta.FormattingEnabled = True
        Me.cmbCuenta.Location = New System.Drawing.Point(6, 125)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Size = New System.Drawing.Size(303, 24)
        Me.cmbCuenta.TabIndex = 4
        '
        'cmbPropietario
        '
        Me.cmbPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPropietario.FormattingEnabled = True
        Me.cmbPropietario.Location = New System.Drawing.Point(6, 38)
        Me.cmbPropietario.Name = "cmbPropietario"
        Me.cmbPropietario.Size = New System.Drawing.Size(303, 24)
        Me.cmbPropietario.TabIndex = 4
        '
        'cmbBanco
        '
        Me.cmbBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(6, 81)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(303, 24)
        Me.cmbBanco.TabIndex = 4
        '
        'Num_cheqTxt
        '
        Me.Num_cheqTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Num_cheqTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_cheqTxt.Location = New System.Drawing.Point(135, 152)
        Me.Num_cheqTxt.Name = "Num_cheqTxt"
        Me.Num_cheqTxt.Size = New System.Drawing.Size(202, 22)
        Me.Num_cheqTxt.TabIndex = 2
        Me.Num_cheqTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Valor de cheque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Cheque"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Propietario de la cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Banco:"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(5, 85)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(327, 23)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(5, 30)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(327, 23)
        Me.ComboBox4.TabIndex = 4
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(5, 198)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(191, 26)
        Me.NumericUpDown2.TabIndex = 0
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(5, 133)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(191, 26)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Valor de cheque"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Número de Cheque"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cuenta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Banco:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(234, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(5, 85)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(327, 23)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(5, 30)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(327, 23)
        Me.ComboBox6.TabIndex = 4
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.Location = New System.Drawing.Point(5, 198)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(191, 26)
        Me.NumericUpDown3.TabIndex = 0
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(5, 133)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(191, 26)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Valor de cheque"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 18)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Número de Cheque"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Cuenta:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 18)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Banco:"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(234, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 36)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Aceptar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'paneCredito
        '
        Me.paneCredito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneCredito.Controls.Add(Me.txtMontoMaximo)
        Me.paneCredito.Controls.Add(Me.txtSaldo)
        Me.paneCredito.Controls.Add(Me.txtCreditoActual)
        Me.paneCredito.Controls.Add(Me.txtTotalDeuda)
        Me.paneCredito.Controls.Add(Me.Label6)
        Me.paneCredito.Controls.Add(Me.Label5)
        Me.paneCredito.Controls.Add(Me.Label7)
        Me.paneCredito.Controls.Add(Me.Label8)
        Me.paneCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paneCredito.Location = New System.Drawing.Point(166, 439)
        Me.paneCredito.Name = "paneCredito"
        Me.paneCredito.Size = New System.Drawing.Size(368, 200)
        Me.paneCredito.TabIndex = 5
        Me.paneCredito.TabStop = True
        Me.paneCredito.Visible = False
        '
        'txtMontoMaximo
        '
        Me.txtMontoMaximo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoMaximo.Enabled = False
        Me.txtMontoMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoMaximo.ForeColor = System.Drawing.Color.Red
        Me.txtMontoMaximo.Location = New System.Drawing.Point(105, 2)
        Me.txtMontoMaximo.Name = "txtMontoMaximo"
        Me.txtMontoMaximo.Size = New System.Drawing.Size(219, 23)
        Me.txtMontoMaximo.TabIndex = 2
        Me.txtMontoMaximo.Text = "0"
        Me.txtMontoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(105, 28)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(219, 23)
        Me.txtSaldo.TabIndex = 2
        Me.txtSaldo.Text = "0"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCreditoActual
        '
        Me.txtCreditoActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCreditoActual.BackColor = System.Drawing.SystemColors.Control
        Me.txtCreditoActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCreditoActual.Enabled = False
        Me.txtCreditoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditoActual.ForeColor = System.Drawing.Color.Red
        Me.txtCreditoActual.Location = New System.Drawing.Point(5, 75)
        Me.txtCreditoActual.Name = "txtCreditoActual"
        Me.txtCreditoActual.Size = New System.Drawing.Size(346, 53)
        Me.txtCreditoActual.TabIndex = 2
        Me.txtCreditoActual.Text = "0"
        Me.txtCreditoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalDeuda
        '
        Me.txtTotalDeuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDeuda.Enabled = False
        Me.txtTotalDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeuda.Location = New System.Drawing.Point(8, 162)
        Me.txtTotalDeuda.Name = "txtTotalDeuda"
        Me.txtTotalDeuda.Size = New System.Drawing.Size(219, 26)
        Me.txtTotalDeuda.TabIndex = 2
        Me.txtTotalDeuda.Text = "0"
        Me.txtTotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Deuda $:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Monto  autorizado $:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Importe Actual $:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Saldo Anterior $:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtNom_Persona
        '
        Me.txtNom_Persona.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNom_Persona.Location = New System.Drawing.Point(206, 691)
        Me.txtNom_Persona.Name = "txtNom_Persona"
        Me.txtNom_Persona.Size = New System.Drawing.Size(34, 20)
        Me.txtNom_Persona.TabIndex = 5
        Me.txtNom_Persona.Visible = False
        '
        'frmFormaPago
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(544, 740)
        Me.Controls.Add(Me.paneCredito)
        Me.Controls.Add(Me.paneCheque)
        Me.Controls.Add(Me.txtNom_Persona)
        Me.Controls.Add(Me.paneEfectivo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFormaPago"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Determine la forma de pago"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.paneEfectivo.ResumeLayout(False)
        Me.paneEfectivo.PerformLayout()
        CType(Me.txtPaga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneCheque.ResumeLayout(False)
        Me.paneCheque.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneCredito.ResumeLayout(False)
        Me.paneCredito.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuEfectivo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCredito As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCheque As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCreditCar As ToolStripMenuItem
    Friend WithEvents paneEfectivo As System.Windows.Forms.Panel
    Friend WithEvents txtPaga As NumericUpDown
    Friend WithEvents lblActual As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents paneCheque As System.Windows.Forms.Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbCuenta As ComboBox
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents Num_cheqTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents paneCredito As System.Windows.Forms.Panel
    Friend WithEvents txtMontoMaximo As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtCreditoActual As TextBox
    Friend WithEvents txtTotalDeuda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnBancos As Button
    Friend WithEvents txtNom_Persona As System.Windows.Forms.TextBox
    Friend WithEvents cmbPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents fecha_cheqDatatime As DateTimePicker
    Friend WithEvents fech_chelbl As Label
    Friend WithEvents ValCaheqtxt As TextBox
End Class
