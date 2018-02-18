<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmchilVirtualBox
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
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListVirtualComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelView.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.SubmitButton)
        Me.PanelView.Controls.Add(Me.Panel1)
        Me.PanelView.Controls.Add(Me.Label1)
        Me.PanelView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelView.Location = New System.Drawing.Point(12, 29)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(478, 258)
        Me.PanelView.TabIndex = 0
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.Image = Global.ECommercePlatformView.My.Resources.Resources.transfer_White_black_32
        Me.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.Location = New System.Drawing.Point(16, 104)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(333, 36)
        Me.SubmitButton.TabIndex = 7
        Me.SubmitButton.Text = "          Enviar"
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ListVirtualComboBox)
        Me.Panel1.Location = New System.Drawing.Point(16, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(333, 28)
        Me.Panel1.TabIndex = 3
        '
        'ListVirtualComboBox
        '
        Me.ListVirtualComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListVirtualComboBox.FormattingEnabled = True
        Me.ListVirtualComboBox.Location = New System.Drawing.Point(2, 2)
        Me.ListVirtualComboBox.Name = "ListVirtualComboBox"
        Me.ListVirtualComboBox.Size = New System.Drawing.Size(329, 24)
        Me.ListVirtualComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Caja virtual:"
        '
        'frmchilVirtualBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 334)
        Me.Controls.Add(Me.PanelView)
        Me.Name = "frmchilVirtualBox"
        Me.Text = "frmchilVirtualBox"
        Me.PanelView.ResumeLayout(False)
        Me.PanelView.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelView As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListVirtualComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SubmitButton As Button
End Class
