<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ivaCheckBox = New System.Windows.Forms.CheckBox()
        Me.descCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PegarButton = New System.Windows.Forms.Button()
        Me.IdClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPresentClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalParcialClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.66534!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33466!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 377)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(760, 30)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(684, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(586, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClm, Me.idPresentClm, Me.ProductoClm, Me.CountClm, Me.UnitPriceClm, Me.TotalParcialClm})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 40)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(760, 308)
        Me.DataGridView1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ivaCheckBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.descCheckBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TotalTextBox)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 348)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(760, 29)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'ivaCheckBox
        '
        Me.ivaCheckBox.AutoSize = True
        Me.ivaCheckBox.Enabled = False
        Me.ivaCheckBox.Location = New System.Drawing.Point(10, 3)
        Me.ivaCheckBox.Margin = New System.Windows.Forms.Padding(10, 3, 8, 3)
        Me.ivaCheckBox.Name = "ivaCheckBox"
        Me.ivaCheckBox.Size = New System.Drawing.Size(97, 21)
        Me.ivaCheckBox.TabIndex = 0
        Me.ivaCheckBox.Text = "Incluye iva."
        Me.ivaCheckBox.UseVisualStyleBackColor = True
        '
        'descCheckBox
        '
        Me.descCheckBox.AutoSize = True
        Me.descCheckBox.Enabled = False
        Me.descCheckBox.Location = New System.Drawing.Point(118, 3)
        Me.descCheckBox.Name = "descCheckBox"
        Me.descCheckBox.Size = New System.Drawing.Size(145, 21)
        Me.descCheckBox.TabIndex = 0
        Me.descCheckBox.Text = "Incluye descuento."
        Me.descCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sub tota:l"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(352, 3)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 23)
        Me.TotalTextBox.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.PegarButton)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(760, 40)
        Me.PanelMenu.TabIndex = 3
        '
        'PegarButton
        '
        Me.PegarButton.Location = New System.Drawing.Point(76, 3)
        Me.PegarButton.Name = "PegarButton"
        Me.PegarButton.Size = New System.Drawing.Size(106, 27)
        Me.PegarButton.TabIndex = 0
        Me.PegarButton.Text = "Pegar"
        Me.PegarButton.UseVisualStyleBackColor = True
        '
        'IdClm
        '
        Me.IdClm.DataPropertyName = "ID"
        Me.IdClm.HeaderText = "KeyCode"
        Me.IdClm.Name = "IdClm"
        '
        'idPresentClm
        '
        Me.idPresentClm.DataPropertyName = "IdPresent"
        Me.idPresentClm.HeaderText = "idPresent"
        Me.idPresentClm.Name = "idPresentClm"
        Me.idPresentClm.ReadOnly = True
        '
        'ProductoClm
        '
        Me.ProductoClm.DataPropertyName = "Producto"
        Me.ProductoClm.HeaderText = "Producto"
        Me.ProductoClm.Name = "ProductoClm"
        Me.ProductoClm.ReadOnly = True
        Me.ProductoClm.Width = 300
        '
        'CountClm
        '
        Me.CountClm.DataPropertyName = "Count"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = "0"
        Me.CountClm.DefaultCellStyle = DataGridViewCellStyle2
        Me.CountClm.HeaderText = "Cantidad"
        Me.CountClm.Name = "CountClm"
        Me.CountClm.ReadOnly = True
        '
        'UnitPriceClm
        '
        Me.UnitPriceClm.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = "0"
        Me.UnitPriceClm.DefaultCellStyle = DataGridViewCellStyle3
        Me.UnitPriceClm.HeaderText = "Precio unitario"
        Me.UnitPriceClm.Name = "UnitPriceClm"
        Me.UnitPriceClm.ReadOnly = True
        '
        'TotalParcialClm
        '
        Me.TotalParcialClm.DataPropertyName = "TotalParcial"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = "0"
        Me.TotalParcialClm.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalParcialClm.HeaderText = "Sub Total"
        Me.TotalParcialClm.Name = "TotalParcialClm"
        Me.TotalParcialClm.ReadOnly = True
        '
        'frmEditCompra
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(760, 407)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCompra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editando la lista de compra"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ivaCheckBox As CheckBox
    Friend WithEvents descCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PegarButton As System.Windows.Forms.Button
    Friend WithEvents IdClm As DataGridViewTextBoxColumn
    Friend WithEvents idPresentClm As DataGridViewTextBoxColumn
    Friend WithEvents ProductoClm As DataGridViewTextBoxColumn
    Friend WithEvents CountClm As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceClm As DataGridViewTextBoxColumn
    Friend WithEvents TotalParcialClm As DataGridViewTextBoxColumn
End Class
