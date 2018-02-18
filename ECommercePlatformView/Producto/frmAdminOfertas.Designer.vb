<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminOfertas
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.descuenEnCadaLabel = New System.Windows.Forms.Label()
        Me.descuetoEnCadaUnoTextBox = New System.Windows.Forms.TextBox()
        Me.descuentoDeLabel = New System.Windows.Forms.Label()
        Me.apartirDeLabel = New System.Windows.Forms.Label()
        Me.aPartirDeNumeric = New System.Windows.Forms.NumericUpDown()
        Me.porCentageDescuentNumeric = New System.Windows.Forms.NumericUpDown()
        Me.totalDescuentoEnLabel = New System.Windows.Forms.Label()
        Me.precioOfertaEnLabel = New System.Windows.Forms.Label()
        Me.precioNormalEnLabel = New System.Windows.Forms.Label()
        Me.totalDecuantoEnTextBox = New System.Windows.Forms.TextBox()
        Me.precioNormalEnTextBox = New System.Windows.Forms.TextBox()
        Me.precioOfertaEnTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkExpira = New System.Windows.Forms.CheckBox()
        Me.paneLimite = New System.Windows.Forms.Panel()
        Me.expireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.precioNormalLabel = New System.Windows.Forms.Label()
        Me.precioNormalTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.productoLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.aPartirDeNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.porCentageDescuentNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.paneLimite.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(491, 352)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'descuenEnCadaLabel
        '
        Me.descuenEnCadaLabel.AutoSize = True
        Me.descuenEnCadaLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.descuenEnCadaLabel.Location = New System.Drawing.Point(310, 35)
        Me.descuenEnCadaLabel.Name = "descuenEnCadaLabel"
        Me.descuenEnCadaLabel.Size = New System.Drawing.Size(176, 33)
        Me.descuenEnCadaLabel.TabIndex = 24
        Me.descuenEnCadaLabel.Text = "Decuento en cada "
        '
        'descuetoEnCadaUnoTextBox
        '
        Me.descuetoEnCadaUnoTextBox.Enabled = False
        Me.descuetoEnCadaUnoTextBox.Location = New System.Drawing.Point(493, 38)
        Me.descuetoEnCadaUnoTextBox.Name = "descuetoEnCadaUnoTextBox"
        Me.descuetoEnCadaUnoTextBox.ReadOnly = True
        Me.descuetoEnCadaUnoTextBox.Size = New System.Drawing.Size(200, 30)
        Me.descuetoEnCadaUnoTextBox.TabIndex = 23
        '
        'descuentoDeLabel
        '
        Me.descuentoDeLabel.AutoSize = True
        Me.descuentoDeLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.descuentoDeLabel.Location = New System.Drawing.Point(40, 36)
        Me.descuentoDeLabel.Name = "descuentoDeLabel"
        Me.descuentoDeLabel.Size = New System.Drawing.Size(141, 34)
        Me.descuentoDeLabel.TabIndex = 22
        Me.descuentoDeLabel.Text = "Descuento de (%) "
        '
        'apartirDeLabel
        '
        Me.apartirDeLabel.AutoSize = True
        Me.apartirDeLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.apartirDeLabel.Location = New System.Drawing.Point(95, 1)
        Me.apartirDeLabel.Name = "apartirDeLabel"
        Me.apartirDeLabel.Size = New System.Drawing.Size(86, 34)
        Me.apartirDeLabel.TabIndex = 21
        Me.apartirDeLabel.Text = "A partir de "
        '
        'aPartirDeNumeric
        '
        Me.aPartirDeNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.aPartirDeNumeric.Increment = New Decimal(New Integer() {3, 0, 0, 0})
        Me.aPartirDeNumeric.Location = New System.Drawing.Point(188, 4)
        Me.aPartirDeNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.aPartirDeNumeric.Name = "aPartirDeNumeric"
        Me.aPartirDeNumeric.Size = New System.Drawing.Size(123, 26)
        Me.aPartirDeNumeric.TabIndex = 19
        Me.aPartirDeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.aPartirDeNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'porCentageDescuentNumeric
        '
        Me.porCentageDescuentNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.porCentageDescuentNumeric.DecimalPlaces = 2
        Me.porCentageDescuentNumeric.Location = New System.Drawing.Point(188, 39)
        Me.porCentageDescuentNumeric.Name = "porCentageDescuentNumeric"
        Me.porCentageDescuentNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.porCentageDescuentNumeric.Size = New System.Drawing.Size(123, 26)
        Me.porCentageDescuentNumeric.TabIndex = 20
        Me.porCentageDescuentNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totalDescuentoEnLabel
        '
        Me.totalDescuentoEnLabel.AutoSize = True
        Me.totalDescuentoEnLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.totalDescuentoEnLabel.Location = New System.Drawing.Point(302, 137)
        Me.totalDescuentoEnLabel.Name = "totalDescuentoEnLabel"
        Me.totalDescuentoEnLabel.Size = New System.Drawing.Size(184, 37)
        Me.totalDescuentoEnLabel.TabIndex = 27
        Me.totalDescuentoEnLabel.Text = "Total descuento en "
        '
        'precioOfertaEnLabel
        '
        Me.precioOfertaEnLabel.AutoSize = True
        Me.precioOfertaEnLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.precioOfertaEnLabel.Location = New System.Drawing.Point(328, 103)
        Me.precioOfertaEnLabel.Name = "precioOfertaEnLabel"
        Me.precioOfertaEnLabel.Size = New System.Drawing.Size(158, 33)
        Me.precioOfertaEnLabel.TabIndex = 26
        Me.precioOfertaEnLabel.Text = "Precio Oferta en "
        '
        'precioNormalEnLabel
        '
        Me.precioNormalEnLabel.AutoSize = True
        Me.precioNormalEnLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.precioNormalEnLabel.Location = New System.Drawing.Point(323, 69)
        Me.precioNormalEnLabel.Name = "precioNormalEnLabel"
        Me.precioNormalEnLabel.Size = New System.Drawing.Size(163, 33)
        Me.precioNormalEnLabel.TabIndex = 25
        Me.precioNormalEnLabel.Text = "Precio normal en "
        '
        'totalDecuantoEnTextBox
        '
        Me.totalDecuantoEnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDecuantoEnTextBox.Enabled = False
        Me.totalDecuantoEnTextBox.Location = New System.Drawing.Point(493, 140)
        Me.totalDecuantoEnTextBox.Name = "totalDecuantoEnTextBox"
        Me.totalDecuantoEnTextBox.ReadOnly = True
        Me.totalDecuantoEnTextBox.Size = New System.Drawing.Size(200, 30)
        Me.totalDecuantoEnTextBox.TabIndex = 29
        '
        'precioNormalEnTextBox
        '
        Me.precioNormalEnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.precioNormalEnTextBox.Enabled = False
        Me.precioNormalEnTextBox.Location = New System.Drawing.Point(493, 72)
        Me.precioNormalEnTextBox.Name = "precioNormalEnTextBox"
        Me.precioNormalEnTextBox.ReadOnly = True
        Me.precioNormalEnTextBox.Size = New System.Drawing.Size(200, 30)
        Me.precioNormalEnTextBox.TabIndex = 28
        '
        'precioOfertaEnTextBox
        '
        Me.precioOfertaEnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.precioOfertaEnTextBox.Enabled = False
        Me.precioOfertaEnTextBox.Location = New System.Drawing.Point(493, 106)
        Me.precioOfertaEnTextBox.Name = "precioOfertaEnTextBox"
        Me.precioOfertaEnTextBox.ReadOnly = True
        Me.precioOfertaEnTextBox.Size = New System.Drawing.Size(200, 30)
        Me.precioOfertaEnTextBox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkExpira)
        Me.GroupBox1.Controls.Add(Me.paneLimite)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 99)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "     Expiración  de oferta"
        '
        'ChkExpira
        '
        Me.ChkExpira.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkExpira.AutoSize = True
        Me.ChkExpira.Checked = True
        Me.ChkExpira.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkExpira.Location = New System.Drawing.Point(45, 20)
        Me.ChkExpira.Name = "ChkExpira"
        Me.ChkExpira.Size = New System.Drawing.Size(167, 24)
        Me.ChkExpira.TabIndex = 3
        Me.ChkExpira.Text = "Limite de expiración"
        Me.ChkExpira.UseVisualStyleBackColor = True
        '
        'paneLimite
        '
        Me.paneLimite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.paneLimite.Controls.Add(Me.expireDate)
        Me.paneLimite.Controls.Add(Me.Label1)
        Me.paneLimite.Location = New System.Drawing.Point(35, 45)
        Me.paneLimite.Name = "paneLimite"
        Me.paneLimite.Size = New System.Drawing.Size(263, 46)
        Me.paneLimite.TabIndex = 11
        '
        'expireDate
        '
        Me.expireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.expireDate.Location = New System.Drawing.Point(135, 10)
        Me.expireDate.Name = "expireDate"
        Me.expireDate.Size = New System.Drawing.Size(123, 26)
        Me.expireDate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Válido hasta:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.80057!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.19943!))
        Me.TableLayoutPanel2.Controls.Add(Me.precioNormalLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.precioNormalTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.descuetoEnCadaUnoTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.totalDecuantoEnTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.descuenEnCadaLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.totalDescuentoEnLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.precioOfertaEnTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.precioNormalEnTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.precioNormalEnLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.precioOfertaEnLabel, 0, 3)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 167)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(703, 175)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'precioNormalLabel
        '
        Me.precioNormalLabel.AutoSize = True
        Me.precioNormalLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.precioNormalLabel.Location = New System.Drawing.Point(349, 1)
        Me.precioNormalLabel.Name = "precioNormalLabel"
        Me.precioNormalLabel.Size = New System.Drawing.Size(137, 33)
        Me.precioNormalLabel.TabIndex = 34
        Me.precioNormalLabel.Text = "Precio normal:"
        '
        'precioNormalTextBox
        '
        Me.precioNormalTextBox.Enabled = False
        Me.precioNormalTextBox.Location = New System.Drawing.Point(493, 4)
        Me.precioNormalTextBox.Name = "precioNormalTextBox"
        Me.precioNormalTextBox.ReadOnly = True
        Me.precioNormalTextBox.Size = New System.Drawing.Size(200, 30)
        Me.precioNormalTextBox.TabIndex = 33
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.76923!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23077!))
        Me.TableLayoutPanel3.Controls.Add(Me.apartirDeLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.descuentoDeLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.aPartirDeNumeric, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.porCentageDescuentNumeric, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(7, 59)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(315, 71)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'productoLabel
        '
        Me.productoLabel.AutoSize = True
        Me.productoLabel.ForeColor = System.Drawing.Color.Blue
        Me.productoLabel.Location = New System.Drawing.Point(8, 11)
        Me.productoLabel.Name = "productoLabel"
        Me.productoLabel.Size = New System.Drawing.Size(57, 20)
        Me.productoLabel.TabIndex = 34
        Me.productoLabel.Text = "Label2"
        '
        'frmAdminOfertas
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(727, 412)
        Me.Controls.Add(Me.productoLabel)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdminOfertas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando  Ofertas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.aPartirDeNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.porCentageDescuentNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.paneLimite.ResumeLayout(False)
        Me.paneLimite.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents descuenEnCadaLabel As Label
    Friend WithEvents descuetoEnCadaUnoTextBox As TextBox
    Friend WithEvents descuentoDeLabel As Label
    Friend WithEvents apartirDeLabel As Label
    Friend WithEvents aPartirDeNumeric As NumericUpDown
    Friend WithEvents porCentageDescuentNumeric As NumericUpDown
    Friend WithEvents totalDescuentoEnLabel As Label
    Friend WithEvents precioOfertaEnLabel As Label
    Friend WithEvents precioNormalEnLabel As Label
    Friend WithEvents totalDecuantoEnTextBox As TextBox
    Friend WithEvents precioNormalEnTextBox As TextBox
    Friend WithEvents precioOfertaEnTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkExpira As CheckBox
    Friend WithEvents paneLimite As Panel
    Friend WithEvents expireDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents precioNormalLabel As Label
    Friend WithEvents precioNormalTextBox As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents productoLabel As Label
End Class
