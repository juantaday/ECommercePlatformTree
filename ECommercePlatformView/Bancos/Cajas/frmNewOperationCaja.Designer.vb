<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOperationCaja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codTerminalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateStar = New System.Windows.Forms.DateTimePicker()
        Me.TimeStar = New System.Windows.Forms.DateTimePicker()
        Me.TimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.isAllUserCheckBox = New System.Windows.Forms.CheckBox()
        Me.ListUserComboBox = New System.Windows.Forms.ComboBox()
        Me.MontoInicio_TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gotoSaldo_Button = New System.Windows.Forms.Button()
        Me.ImputInicio_Button = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.findUser_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(192, 231)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código terminal:"
        '
        'codTerminalTextBox
        '
        Me.codTerminalTextBox.Enabled = False
        Me.codTerminalTextBox.Location = New System.Drawing.Point(141, 4)
        Me.codTerminalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.codTerminalTextBox.Name = "codTerminalTextBox"
        Me.codTerminalTextBox.Size = New System.Drawing.Size(178, 23)
        Me.codTerminalTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Inicio de operación:"
        '
        'DateStar
        '
        Me.DateStar.Enabled = False
        Me.DateStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateStar.Location = New System.Drawing.Point(132, 39)
        Me.DateStar.Name = "DateStar"
        Me.DateStar.Size = New System.Drawing.Size(102, 20)
        Me.DateStar.TabIndex = 6
        '
        'TimeStar
        '
        Me.TimeStar.CustomFormat = "hh:mm tt"
        Me.TimeStar.Enabled = False
        Me.TimeStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeStar.Location = New System.Drawing.Point(240, 39)
        Me.TimeStar.Name = "TimeStar"
        Me.TimeStar.Size = New System.Drawing.Size(62, 20)
        Me.TimeStar.TabIndex = 7
        '
        'TimeEnd
        '
        Me.TimeEnd.CustomFormat = "hh:mm tt"
        Me.TimeEnd.Enabled = False
        Me.TimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TimeEnd.Location = New System.Drawing.Point(240, 69)
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.Size = New System.Drawing.Size(62, 20)
        Me.TimeEnd.TabIndex = 10
        '
        'DateEnd
        '
        Me.DateEnd.Enabled = False
        Me.DateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEnd.Location = New System.Drawing.Point(132, 69)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(102, 20)
        Me.DateEnd.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fin de operación:"
        '
        'isAllUserCheckBox
        '
        Me.isAllUserCheckBox.AutoSize = True
        Me.isAllUserCheckBox.Checked = True
        Me.isAllUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.isAllUserCheckBox.Location = New System.Drawing.Point(34, 108)
        Me.isAllUserCheckBox.Name = "isAllUserCheckBox"
        Me.isAllUserCheckBox.Size = New System.Drawing.Size(195, 21)
        Me.isAllUserCheckBox.TabIndex = 11
        Me.isAllUserCheckBox.Text = "Es para todos los usuarios"
        Me.isAllUserCheckBox.UseVisualStyleBackColor = True
        '
        'ListUserComboBox
        '
        Me.ListUserComboBox.FormattingEnabled = True
        Me.ListUserComboBox.Location = New System.Drawing.Point(43, 132)
        Me.ListUserComboBox.Name = "ListUserComboBox"
        Me.ListUserComboBox.Size = New System.Drawing.Size(306, 24)
        Me.ListUserComboBox.TabIndex = 12
        '
        'MontoInicio_TextBox
        '
        Me.MontoInicio_TextBox.Enabled = False
        Me.MontoInicio_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoInicio_TextBox.Location = New System.Drawing.Point(7, 32)
        Me.MontoInicio_TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MontoInicio_TextBox.Name = "MontoInicio_TextBox"
        Me.MontoInicio_TextBox.Size = New System.Drawing.Size(161, 26)
        Me.MontoInicio_TextBox.TabIndex = 14
        Me.MontoInicio_TextBox.Text = "0"
        Me.MontoInicio_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gotoSaldo_Button)
        Me.GroupBox1.Controls.Add(Me.MontoInicio_TextBox)
        Me.GroupBox1.Controls.Add(Me.ImputInicio_Button)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 67)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monto inicial $:"
        '
        'gotoSaldo_Button
        '
        Me.gotoSaldo_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gotoSaldo_Button.Image = Global.ECommercePlatformView.My.Resources.Resources.Moneda_saldo_28
        Me.gotoSaldo_Button.Location = New System.Drawing.Point(227, 16)
        Me.gotoSaldo_Button.Name = "gotoSaldo_Button"
        Me.gotoSaldo_Button.Size = New System.Drawing.Size(48, 46)
        Me.gotoSaldo_Button.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.gotoSaldo_Button, "Tomar el último saldo")
        Me.gotoSaldo_Button.UseVisualStyleBackColor = True
        '
        'ImputInicio_Button
        '
        Me.ImputInicio_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImputInicio_Button.Image = Global.ECommercePlatformView.My.Resources.Resources.Villetes_44
        Me.ImputInicio_Button.Location = New System.Drawing.Point(175, 16)
        Me.ImputInicio_Button.Name = "ImputInicio_Button"
        Me.ImputInicio_Button.Size = New System.Drawing.Size(51, 46)
        Me.ImputInicio_Button.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.ImputInicio_Button, "Determinar monto")
        Me.ImputInicio_Button.UseVisualStyleBackColor = True
        '
        'findUser_Button
        '
        Me.findUser_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findUser_Button.Image = Global.ECommercePlatformView.My.Resources.Resources.FindCustomers_16x16
        Me.findUser_Button.Location = New System.Drawing.Point(356, 129)
        Me.findUser_Button.Name = "findUser_Button"
        Me.findUser_Button.Size = New System.Drawing.Size(29, 30)
        Me.findUser_Button.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.findUser_Button, "Buscar usuarios..")
        Me.findUser_Button.UseVisualStyleBackColor = True
        '
        'frmNewOperationCaja
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(393, 274)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.findUser_Button)
        Me.Controls.Add(Me.ListUserComboBox)
        Me.Controls.Add(Me.isAllUserCheckBox)
        Me.Controls.Add(Me.TimeEnd)
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeStar)
        Me.Controls.Add(Me.DateStar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codTerminalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewOperationCaja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apertura de operación"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents codTerminalTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateStar As DateTimePicker
    Friend WithEvents TimeStar As DateTimePicker
    Friend WithEvents TimeEnd As DateTimePicker
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents isAllUserCheckBox As CheckBox
    Friend WithEvents ListUserComboBox As ComboBox
    Friend WithEvents MontoInicio_TextBox As TextBox
    Friend WithEvents findUser_Button As Button
    Friend WithEvents ImputInicio_Button As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gotoSaldo_Button As System.Windows.Forms.Button
End Class
