<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiltExitDocumentBanck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiltExitDocumentBanck))
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResponsableDepositorTextBox = New System.Windows.Forms.TextBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnComboBox1 = New JTG.ColumnComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelView.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.SubmitButton)
        Me.PanelView.Controls.Add(Me.Panel2)
        Me.PanelView.Controls.Add(Me.Label2)
        Me.PanelView.Controls.Add(Me.ColumnComboBox1)
        Me.PanelView.Controls.Add(Me.Label1)
        Me.PanelView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelView.Location = New System.Drawing.Point(12, 12)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(370, 200)
        Me.PanelView.TabIndex = 2
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.Image = Global.ECommercePlatformView.My.Resources.Resources.transfer_Banck_Person_White_32
        Me.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.Location = New System.Drawing.Point(10, 142)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(346, 36)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "          Enviar"
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ResponsableDepositorTextBox)
        Me.Panel2.Controls.Add(Me.findButton)
        Me.Panel2.Location = New System.Drawing.Point(7, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(351, 28)
        Me.Panel2.TabIndex = 5
        '
        'ResponsableDepositorTextBox
        '
        Me.ResponsableDepositorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResponsableDepositorTextBox.Location = New System.Drawing.Point(2, 2)
        Me.ResponsableDepositorTextBox.Name = "ResponsableDepositorTextBox"
        Me.ResponsableDepositorTextBox.ReadOnly = True
        Me.ResponsableDepositorTextBox.Size = New System.Drawing.Size(318, 23)
        Me.ResponsableDepositorTextBox.TabIndex = 3
        '
        'findButton
        '
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.findButton.Location = New System.Drawing.Point(320, 2)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(29, 24)
        Me.findButton.TabIndex = 2
        Me.findButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Persona encargada a llevar al banco."
        '
        'ColumnComboBox1
        '
        Me.ColumnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ColumnComboBox1.DropDownWidth = 17
        Me.ColumnComboBox1.FormattingEnabled = True
        Me.ColumnComboBox1.Location = New System.Drawing.Point(7, 38)
        Me.ColumnComboBox1.Name = "ColumnComboBox1"
        Me.ColumnComboBox1.Size = New System.Drawing.Size(351, 24)
        Me.ColumnComboBox1.TabIndex = 2
        Me.ColumnComboBox1.ViewColumn = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta a depositar:"
        '
        'frmChiltExitDocumentBanck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 238)
        Me.Controls.Add(Me.PanelView)
        Me.Name = "frmChiltExitDocumentBanck"
        Me.Text = "frmChiltExitDocumentBanck"
        Me.PanelView.ResumeLayout(False)
        Me.PanelView.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelView As Panel
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResponsableDepositorTextBox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnComboBox1 As JTG.ColumnComboBox
    Friend WithEvents Label1 As Label
End Class
