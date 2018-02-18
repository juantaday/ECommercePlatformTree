<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditaValor
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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblmedida = New System.Windows.Forms.Label()
        Me.txtprecioCompra = New System.Windows.Forms.NumericUpDown()
        Me.txtprecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.txtUtilidad = New System.Windows.Forms.NumericUpDown()
        Me.txtporciento = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtprecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtprecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUtilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtporciento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(203, 291)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "Aceptar"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblProducto.Location = New System.Drawing.Point(10, 16)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(118, 16)
        Me.lblProducto.TabIndex = 12
        Me.lblProducto.Text = "Precio de compra:"
        '
        'lblmedida
        '
        Me.lblmedida.AutoSize = True
        Me.lblmedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedida.ForeColor = System.Drawing.Color.Black
        Me.lblmedida.Location = New System.Drawing.Point(10, 56)
        Me.lblmedida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedida.Name = "lblmedida"
        Me.lblmedida.Size = New System.Drawing.Size(118, 16)
        Me.lblmedida.TabIndex = 12
        Me.lblmedida.Text = "Precio de compra:"
        '
        'txtprecioCompra
        '
        Me.txtprecioCompra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprecioCompra.DecimalPlaces = 5
        Me.txtprecioCompra.InterceptArrowKeys = False
        Me.txtprecioCompra.Location = New System.Drawing.Point(150, 6)
        Me.txtprecioCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecioCompra.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtprecioCompra.Name = "txtprecioCompra"
        Me.txtprecioCompra.ReadOnly = True
        Me.txtprecioCompra.Size = New System.Drawing.Size(263, 26)
        Me.txtprecioCompra.TabIndex = 12
        Me.txtprecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtprecioVenta
        '
        Me.txtprecioVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtprecioVenta.DecimalPlaces = 5
        Me.txtprecioVenta.ForeColor = System.Drawing.Color.Green
        Me.txtprecioVenta.Location = New System.Drawing.Point(150, 43)
        Me.txtprecioVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecioVenta.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.txtprecioVenta.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtprecioVenta.Name = "txtprecioVenta"
        Me.txtprecioVenta.Size = New System.Drawing.Size(263, 26)
        Me.txtprecioVenta.TabIndex = 12
        Me.txtprecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUtilidad.DecimalPlaces = 5
        Me.txtUtilidad.ForeColor = System.Drawing.Color.Red
        Me.txtUtilidad.Location = New System.Drawing.Point(150, 80)
        Me.txtUtilidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUtilidad.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.txtUtilidad.Minimum = New Decimal(New Integer() {276447231, 23283, 0, -2147483648})
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(263, 26)
        Me.txtUtilidad.TabIndex = 2
        Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtporciento
        '
        Me.txtporciento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtporciento.DecimalPlaces = 2
        Me.txtporciento.ForeColor = System.Drawing.Color.Blue
        Me.txtporciento.Location = New System.Drawing.Point(150, 117)
        Me.txtporciento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtporciento.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.txtporciento.Minimum = New Decimal(New Integer() {276447231, 23283, 0, -2147483648})
        Me.txtporciento.Name = "txtporciento"
        Me.txtporciento.Size = New System.Drawing.Size(263, 26)
        Me.txtporciento.TabIndex = 3
        Me.txtporciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Precio de compra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(5, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio de Venta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Utilidad $:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(5, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rentabilidad %:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtprecioCompra, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtporciento, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtprecioVenta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUtilidad, 1, 2)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 98)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(418, 183)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'frmEditaValor
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(440, 342)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblmedida)
        Me.Controls.Add(Me.lblProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditaValor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "    Editando precios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txtprecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtprecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUtilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtporciento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblmedida As System.Windows.Forms.Label
    Friend WithEvents txtprecioCompra As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtprecioVenta As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUtilidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtporciento As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel

End Class
