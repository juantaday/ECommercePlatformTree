<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewDateExpir
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton1si = New System.Windows.Forms.RadioButton()
        Me.RadioButton2no = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrdenCompraTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.nomComercialLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(240, 2)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(329, 2)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(7, 232)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(423, 34)
        Me.Panel1.TabIndex = 1
        '
        'RadioButton1si
        '
        Me.RadioButton1si.AutoSize = True
        Me.RadioButton1si.Checked = True
        Me.RadioButton1si.Location = New System.Drawing.Point(40, 23)
        Me.RadioButton1si.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1si.Name = "RadioButton1si"
        Me.RadioButton1si.Size = New System.Drawing.Size(38, 21)
        Me.RadioButton1si.TabIndex = 2
        Me.RadioButton1si.TabStop = True
        Me.RadioButton1si.Text = "Sí"
        Me.RadioButton1si.UseVisualStyleBackColor = True
        '
        'RadioButton2no
        '
        Me.RadioButton2no.AutoSize = True
        Me.RadioButton2no.Location = New System.Drawing.Point(102, 24)
        Me.RadioButton2no.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2no.Name = "RadioButton2no"
        Me.RadioButton2no.Size = New System.Drawing.Size(44, 21)
        Me.RadioButton2no.TabIndex = 3
        Me.RadioButton2no.Text = "Nó"
        Me.RadioButton2no.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2no)
        Me.GroupBox1.Controls.Add(Me.RadioButton1si)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(230, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conosco orden de compra.?"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Orden de compra:"
        '
        'OrdenCompraTextBox
        '
        Me.OrdenCompraTextBox.Location = New System.Drawing.Point(264, 76)
        Me.OrdenCompraTextBox.Name = "OrdenCompraTextBox"
        Me.OrdenCompraTextBox.Size = New System.Drawing.Size(163, 23)
        Me.OrdenCompraTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Bodega o local:"
        '
        'ListBodegaComboBox
        '
        Me.ListBodegaComboBox.FormattingEnabled = True
        Me.ListBodegaComboBox.Location = New System.Drawing.Point(6, 146)
        Me.ListBodegaComboBox.Name = "ListBodegaComboBox"
        Me.ListBodegaComboBox.Size = New System.Drawing.Size(369, 24)
        Me.ListBodegaComboBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Feha de expiracion"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 192)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 23)
        Me.DateTimePicker1.TabIndex = 12
        '
        'nomComercialLabel
        '
        Me.nomComercialLabel.AutoSize = True
        Me.nomComercialLabel.Font = New System.Drawing.Font("Lucida Sans", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomComercialLabel.Location = New System.Drawing.Point(5, 5)
        Me.nomComercialLabel.Name = "nomComercialLabel"
        Me.nomComercialLabel.Size = New System.Drawing.Size(59, 17)
        Me.nomComercialLabel.TabIndex = 13
        Me.nomComercialLabel.Text = "Label4"
        '
        'frmAddNewDateExpir
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(437, 272)
        Me.Controls.Add(Me.nomComercialLabel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBodegaComboBox)
        Me.Controls.Add(Me.OrdenCompraTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddNewDateExpir"
        Me.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva fecha de expiración"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1si As RadioButton
    Friend WithEvents RadioButton2no As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OrdenCompraTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents nomComercialLabel As Label
End Class
