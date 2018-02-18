<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfFactura
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
        Me.DetailNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.StarNumberButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumfactur4 = New System.Windows.Forms.TextBox()
        Me.txtnumfactur1 = New System.Windows.Forms.TextBox()
        Me.txtnumfactur2 = New System.Windows.Forms.TextBox()
        Me.txtnumfactur3 = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IsValidatedWepTextBox = New System.Windows.Forms.TextBox()
        Me.IpTextBox = New System.Windows.Forms.TextBox()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DocumentListBox = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DetailNumberGroupBox.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailNumberGroupBox
        '
        Me.DetailNumberGroupBox.Controls.Add(Me.StarNumberButton)
        Me.DetailNumberGroupBox.Controls.Add(Me.saveButton)
        Me.DetailNumberGroupBox.Controls.Add(Me.Label1)
        Me.DetailNumberGroupBox.Controls.Add(Me.txtnumfactur4)
        Me.DetailNumberGroupBox.Controls.Add(Me.txtnumfactur1)
        Me.DetailNumberGroupBox.Controls.Add(Me.txtnumfactur2)
        Me.DetailNumberGroupBox.Controls.Add(Me.txtnumfactur3)
        Me.DetailNumberGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailNumberGroupBox.Location = New System.Drawing.Point(232, 111)
        Me.DetailNumberGroupBox.Name = "DetailNumberGroupBox"
        Me.DetailNumberGroupBox.Size = New System.Drawing.Size(325, 140)
        Me.DetailNumberGroupBox.TabIndex = 1
        Me.DetailNumberGroupBox.TabStop = False
        Me.DetailNumberGroupBox.Text = "Detallle de numeración de documento."
        '
        'StarNumberButton
        '
        Me.StarNumberButton.Image = Global.ECommercePlatformView.My.Resources.Resources.refresh_16
        Me.StarNumberButton.Location = New System.Drawing.Point(248, 62)
        Me.StarNumberButton.Name = "StarNumberButton"
        Me.StarNumberButton.Size = New System.Drawing.Size(32, 28)
        Me.StarNumberButton.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.StarNumberButton, "Iniciar la numeración")
        Me.StarNumberButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Save_16x16
        Me.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveButton.Location = New System.Drawing.Point(86, 95)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(158, 32)
        Me.saveButton.TabIndex = 8
        Me.saveButton.Text = "Guardar.."
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(28, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Número de documento ha generar"
        '
        'txtnumfactur4
        '
        Me.txtnumfactur4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnumfactur4.Location = New System.Drawing.Point(145, 63)
        Me.txtnumfactur4.MaxLength = 7
        Me.txtnumfactur4.Name = "txtnumfactur4"
        Me.txtnumfactur4.Size = New System.Drawing.Size(99, 26)
        Me.txtnumfactur4.TabIndex = 7
        '
        'txtnumfactur1
        '
        Me.txtnumfactur1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnumfactur1.Location = New System.Drawing.Point(29, 63)
        Me.txtnumfactur1.MaxLength = 3
        Me.txtnumfactur1.Name = "txtnumfactur1"
        Me.txtnumfactur1.Size = New System.Drawing.Size(43, 26)
        Me.txtnumfactur1.TabIndex = 4
        '
        'txtnumfactur2
        '
        Me.txtnumfactur2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnumfactur2.Location = New System.Drawing.Point(70, 63)
        Me.txtnumfactur2.MaxLength = 3
        Me.txtnumfactur2.Name = "txtnumfactur2"
        Me.txtnumfactur2.Size = New System.Drawing.Size(39, 26)
        Me.txtnumfactur2.TabIndex = 5
        '
        'txtnumfactur3
        '
        Me.txtnumfactur3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtnumfactur3.Location = New System.Drawing.Point(108, 63)
        Me.txtnumfactur3.MaxLength = 2
        Me.txtnumfactur3.Name = "txtnumfactur3"
        Me.txtnumfactur3.Size = New System.Drawing.Size(39, 26)
        Me.txtnumfactur3.TabIndex = 6
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(429, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(199, 37)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 31)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aplicar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(94, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IsValidatedWepTextBox)
        Me.GroupBox2.Controls.Add(Me.IpTextBox)
        Me.GroupBox2.Controls.Add(Me.DominioTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(388, 103)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mi equipo"
        '
        'IsValidatedWepTextBox
        '
        Me.IsValidatedWepTextBox.Location = New System.Drawing.Point(127, 77)
        Me.IsValidatedWepTextBox.Name = "IsValidatedWepTextBox"
        Me.IsValidatedWepTextBox.Size = New System.Drawing.Size(124, 20)
        Me.IsValidatedWepTextBox.TabIndex = 5
        '
        'IpTextBox
        '
        Me.IpTextBox.Location = New System.Drawing.Point(85, 48)
        Me.IpTextBox.Name = "IpTextBox"
        Me.IpTextBox.Size = New System.Drawing.Size(257, 20)
        Me.IpTextBox.TabIndex = 4
        '
        'DominioTextBox
        '
        Me.DominioTextBox.Location = New System.Drawing.Point(85, 19)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(296, 20)
        Me.DominioTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Validated Wep:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 105)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(628, 37)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DocumentListBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 179)
        Me.Panel3.TabIndex = 17
        '
        'DocumentListBox
        '
        Me.DocumentListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentListBox.FormattingEnabled = True
        Me.DocumentListBox.ItemHeight = 20
        Me.DocumentListBox.Location = New System.Drawing.Point(0, 0)
        Me.DocumentListBox.Name = "DocumentListBox"
        Me.DocumentListBox.Size = New System.Drawing.Size(226, 179)
        Me.DocumentListBox.TabIndex = 18
        '
        'frmConfFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(628, 321)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DetailNumberGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfFactura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando numeración de documentos"
        Me.DetailNumberGroupBox.ResumeLayout(False)
        Me.DetailNumberGroupBox.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailNumberGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtnumfactur4 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumfactur1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumfactur2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumfactur3 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IsValidatedWepTextBox As TextBox
    Friend WithEvents IpTextBox As TextBox
    Friend WithEvents DominioTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DocumentListBox As ListBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents saveButton As Button
    Friend WithEvents StarNumberButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
