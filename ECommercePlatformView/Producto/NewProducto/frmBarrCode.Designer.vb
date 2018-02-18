<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBarrCode
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarrCode))
        Me.deleteBarCodeButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.barCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoLabel = New System.Windows.Forms.Label()
        Me.PresentacionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EncodingTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AutoGenerateButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GenerateFromButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deleteBarCodeButton
        '
        Me.deleteBarCodeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.deleteBarCodeButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.deleteBarCodeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteBarCodeButton.Location = New System.Drawing.Point(129, 2)
        Me.deleteBarCodeButton.Name = "deleteBarCodeButton"
        Me.deleteBarCodeButton.Size = New System.Drawing.Size(142, 34)
        Me.deleteBarCodeButton.TabIndex = 3
        Me.deleteBarCodeButton.Text = "Eliminar codigo"
        Me.deleteBarCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deleteBarCodeButton.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(366, 2)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 34)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(271, 2)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(95, 34)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Guardar.."
        '
        'barCodeTextBox
        '
        Me.barCodeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.barCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barCodeTextBox.Location = New System.Drawing.Point(7, 222)
        Me.barCodeTextBox.Name = "barCodeTextBox"
        Me.barCodeTextBox.Size = New System.Drawing.Size(232, 29)
        Me.barCodeTextBox.TabIndex = 0
        '
        'ProductoLabel
        '
        Me.ProductoLabel.AutoSize = True
        Me.ProductoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductoLabel.Location = New System.Drawing.Point(3, 5)
        Me.ProductoLabel.Name = "ProductoLabel"
        Me.ProductoLabel.Size = New System.Drawing.Size(57, 20)
        Me.ProductoLabel.TabIndex = 3
        Me.ProductoLabel.Text = "Label2"
        '
        'PresentacionLabel
        '
        Me.PresentacionLabel.AutoSize = True
        Me.PresentacionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresentacionLabel.ForeColor = System.Drawing.Color.Red
        Me.PresentacionLabel.Location = New System.Drawing.Point(3, 28)
        Me.PresentacionLabel.Name = "PresentacionLabel"
        Me.PresentacionLabel.Size = New System.Drawing.Size(63, 20)
        Me.PresentacionLabel.TabIndex = 4
        Me.PresentacionLabel.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 150)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'GenerateButton
        '
        Me.GenerateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GenerateButton.Location = New System.Drawing.Point(252, 222)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(67, 29)
        Me.GenerateButton.TabIndex = 1
        Me.GenerateButton.Text = "Probar"
        Me.GenerateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.deleteBarCodeButton)
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 262)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(470, 40)
        Me.Panel1.TabIndex = 2
        '
        'EncodingTypeComboBox
        '
        Me.EncodingTypeComboBox.FormattingEnabled = True
        Me.EncodingTypeComboBox.Items.AddRange(New Object() {"EAN-8", "EAN-13"})
        Me.EncodingTypeComboBox.Location = New System.Drawing.Point(252, 86)
        Me.EncodingTypeComboBox.Name = "EncodingTypeComboBox"
        Me.EncodingTypeComboBox.Size = New System.Drawing.Size(171, 28)
        Me.EncodingTypeComboBox.TabIndex = 8
        Me.EncodingTypeComboBox.Text = "EAN-13"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(252, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Encoding Type:"
        '
        'AutoGenerateButton
        '
        Me.AutoGenerateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AutoGenerateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.AutoGenerateButton.Location = New System.Drawing.Point(252, 117)
        Me.AutoGenerateButton.Name = "AutoGenerateButton"
        Me.AutoGenerateButton.Size = New System.Drawing.Size(171, 32)
        Me.AutoGenerateButton.TabIndex = 6
        Me.AutoGenerateButton.Text = "Auto Generar"
        Me.AutoGenerateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AutoGenerateButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ProductoLabel)
        Me.Panel2.Controls.Add(Me.PresentacionLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(470, 58)
        Me.Panel2.TabIndex = 10
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(252, 152)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(39, 13)
        Me.ErrorLabel.TabIndex = 11
        Me.ErrorLabel.Text = "Label2"
        Me.ErrorLabel.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GenerateFromButton
        '
        Me.GenerateFromButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GenerateFromButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.GenerateFromButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.GenerateFromButton.Location = New System.Drawing.Point(325, 223)
        Me.GenerateFromButton.Name = "GenerateFromButton"
        Me.GenerateFromButton.Size = New System.Drawing.Size(133, 29)
        Me.GenerateFromButton.TabIndex = 12
        Me.GenerateFromButton.Text = "Generar apartir de.."
        Me.GenerateFromButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerateFromButton.UseVisualStyleBackColor = False
        '
        'frmBarrCode
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(470, 302)
        Me.Controls.Add(Me.GenerateFromButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EncodingTypeComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AutoGenerateButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.barCodeTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBarrCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando códigod de barra."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents barCodeTextBox As TextBox
    Friend WithEvents ProductoLabel As Label
    Friend WithEvents PresentacionLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents deleteBarCodeButton As Button
    Friend WithEvents GenerateButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EncodingTypeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AutoGenerateButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GenerateFromButton As Button
End Class
