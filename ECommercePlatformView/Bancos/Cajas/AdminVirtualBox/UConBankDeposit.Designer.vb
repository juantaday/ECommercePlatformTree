<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UConBankDeposit
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UConBankDeposit))
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ResponsableDepositorTextBox = New System.Windows.Forms.TextBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnComboBox1 = New JTG.ColumnComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.Image = Global.ECommercePlatformView.My.Resources.Resources.transfer_Banck_Person_White_32
        Me.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.Location = New System.Drawing.Point(10, 311)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(424, 44)
        Me.SubmitButton.TabIndex = 11
        Me.SubmitButton.Text = "          Enviar"
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ResponsableDepositorTextBox)
        Me.Panel1.Controls.Add(Me.findButton)
        Me.Panel1.Location = New System.Drawing.Point(22, 162)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(369, 30)
        Me.Panel1.TabIndex = 10
        '
        'ResponsableDepositorTextBox
        '
        Me.ResponsableDepositorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResponsableDepositorTextBox.Location = New System.Drawing.Point(3, 2)
        Me.ResponsableDepositorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ResponsableDepositorTextBox.Multiline = True
        Me.ResponsableDepositorTextBox.Name = "ResponsableDepositorTextBox"
        Me.ResponsableDepositorTextBox.ReadOnly = True
        Me.ResponsableDepositorTextBox.Size = New System.Drawing.Size(324, 26)
        Me.ResponsableDepositorTextBox.TabIndex = 3
        '
        'findButton
        '
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.findButton.Location = New System.Drawing.Point(327, 2)
        Me.findButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(39, 26)
        Me.findButton.TabIndex = 2
        Me.findButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Persona encargada a llevar al banco."
        '
        'ColumnComboBox1
        '
        Me.ColumnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ColumnComboBox1.DropDownWidth = 17
        Me.ColumnComboBox1.FormattingEnabled = True
        Me.ColumnComboBox1.Location = New System.Drawing.Point(22, 77)
        Me.ColumnComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ColumnComboBox1.Name = "ColumnComboBox1"
        Me.ColumnComboBox1.Size = New System.Drawing.Size(369, 24)
        Me.ColumnComboBox1.TabIndex = 8
        Me.ColumnComboBox1.ViewColumn = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cuenta a depositar:"
        '
        'UConBankDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ColumnComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UConBankDeposit"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(444, 365)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ResponsableDepositorTextBox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnComboBox1 As JTG.ColumnComboBox
    Friend WithEvents Label1 As Label
End Class
