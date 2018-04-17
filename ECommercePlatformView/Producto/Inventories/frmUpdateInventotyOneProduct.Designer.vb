<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateInventotyOneProduct
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.AffectTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MedidaStockTextBox = New System.Windows.Forms.TextBox()
        Me.NewStockTextBox = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pvpTextBox = New System.Windows.Forms.TextBox()
        Me.nom_ComercialTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DescriptionBodegaLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservationRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.NewStockTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(621, 326)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 43)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(122, 37)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(131, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(122, 37)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18391!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.81609!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.StockTextBox, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.AffectTextBox, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.MedidaStockTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NewStockTextBox, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.pvpTextBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.nom_ComercialTextBox, 1, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 81)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(435, 217)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nuevo stock"
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(143, 99)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.ReadOnly = True
        Me.StockTextBox.Size = New System.Drawing.Size(289, 26)
        Me.StockTextBox.TabIndex = 5
        '
        'AffectTextBox
        '
        Me.AffectTextBox.Location = New System.Drawing.Point(143, 171)
        Me.AffectTextBox.Name = "AffectTextBox"
        Me.AffectTextBox.ReadOnly = True
        Me.AffectTextBox.Size = New System.Drawing.Size(289, 26)
        Me.AffectTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Medida en stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad en stock:"
        '
        'MedidaStockTextBox
        '
        Me.MedidaStockTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MedidaStockTextBox.Location = New System.Drawing.Point(143, 35)
        Me.MedidaStockTextBox.Name = "MedidaStockTextBox"
        Me.MedidaStockTextBox.ReadOnly = True
        Me.MedidaStockTextBox.Size = New System.Drawing.Size(289, 26)
        Me.MedidaStockTextBox.TabIndex = 3
        '
        'NewStockTextBox
        '
        Me.NewStockTextBox.DecimalPlaces = 3
        Me.NewStockTextBox.Enabled = False
        Me.NewStockTextBox.Location = New System.Drawing.Point(143, 139)
        Me.NewStockTextBox.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NewStockTextBox.Name = "NewStockTextBox"
        Me.NewStockTextBox.ReadOnly = True
        Me.NewStockTextBox.Size = New System.Drawing.Size(235, 26)
        Me.NewStockTextBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Monto afectado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Precio Promedio:"
        '
        'pvpTextBox
        '
        Me.pvpTextBox.Location = New System.Drawing.Point(143, 67)
        Me.pvpTextBox.Name = "pvpTextBox"
        Me.pvpTextBox.ReadOnly = True
        Me.pvpTextBox.Size = New System.Drawing.Size(289, 26)
        Me.pvpTextBox.TabIndex = 10
        '
        'nom_ComercialTextBox
        '
        Me.nom_ComercialTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nom_ComercialTextBox.Location = New System.Drawing.Point(143, 3)
        Me.nom_ComercialTextBox.Name = "nom_ComercialTextBox"
        Me.nom_ComercialTextBox.ReadOnly = True
        Me.nom_ComercialTextBox.Size = New System.Drawing.Size(289, 26)
        Me.nom_ComercialTextBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(889, 65)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DescriptionBodegaLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(461, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(420, 55)
        Me.Panel5.TabIndex = 5
        '
        'DescriptionBodegaLabel
        '
        Me.DescriptionBodegaLabel.AutoSize = True
        Me.DescriptionBodegaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionBodegaLabel.Location = New System.Drawing.Point(8, 7)
        Me.DescriptionBodegaLabel.Name = "DescriptionBodegaLabel"
        Me.DescriptionBodegaLabel.Size = New System.Drawing.Size(0, 13)
        Me.DescriptionBodegaLabel.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.ListBodegaComboBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(456, 55)
        Me.Panel4.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 40)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Seleccione el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "local o bodega:"
        '
        'ListBodegaComboBox
        '
        Me.ListBodegaComboBox.FormattingEnabled = True
        Me.ListBodegaComboBox.Location = New System.Drawing.Point(125, 7)
        Me.ListBodegaComboBox.Name = "ListBodegaComboBox"
        Me.ListBodegaComboBox.Size = New System.Drawing.Size(317, 28)
        Me.ListBodegaComboBox.TabIndex = 0
        '
        'ObservationRichTextBox
        '
        Me.ObservationRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObservationRichTextBox.BackColor = System.Drawing.Color.White
        Me.ObservationRichTextBox.Enabled = False
        Me.ObservationRichTextBox.Location = New System.Drawing.Point(461, 108)
        Me.ObservationRichTextBox.Name = "ObservationRichTextBox"
        Me.ObservationRichTextBox.ReadOnly = True
        Me.ObservationRichTextBox.Size = New System.Drawing.Size(400, 190)
        Me.ObservationRichTextBox.TabIndex = 1
        Me.ObservationRichTextBox.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(463, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Motivo por la que se actualiza el stock."
        '
        'frmUpdateInventotyOneProduct
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(889, 381)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ObservationRichTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateInventotyOneProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificando inventario."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.NewStockTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents AffectTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MedidaStockTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nom_ComercialTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DescriptionBodegaLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents ObservationRichTextBox As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NewStockTextBox As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents pvpTextBox As TextBox
End Class
