<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExitMoney
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
        Me.montoDivisaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.AccountEmployeeRadioButton = New System.Windows.Forms.RadioButton()
        Me.PaymentProviderRadioButton = New System.Windows.Forms.RadioButton()
        Me.BankAccountRadioButton = New System.Windows.Forms.RadioButton()
        Me.virtualBoxRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelViewData = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.92683!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.07317!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 395)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(742, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(628, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'montoDivisaLabel
        '
        Me.montoDivisaLabel.AutoSize = True
        Me.montoDivisaLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.montoDivisaLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.montoDivisaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.montoDivisaLabel.ForeColor = System.Drawing.Color.Blue
        Me.montoDivisaLabel.Location = New System.Drawing.Point(5, 5)
        Me.montoDivisaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.montoDivisaLabel.Name = "montoDivisaLabel"
        Me.montoDivisaLabel.Size = New System.Drawing.Size(442, 46)
        Me.montoDivisaLabel.TabIndex = 1
        Me.montoDivisaLabel.Text = "Monto divisa: 125.36 $"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Blue
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.AccountEmployeeRadioButton)
        Me.GroupBox1.Controls.Add(Me.PaymentProviderRadioButton)
        Me.GroupBox1.Controls.Add(Me.BankAccountRadioButton)
        Me.GroupBox1.Controls.Add(Me.virtualBoxRadioButton)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 333)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destino de divisa:"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(17, 190)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(65, 21)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Otros."
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(17, 163)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Pago servicios."
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(17, 136)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(164, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Devolución al cliente.."
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'AccountEmployeeRadioButton
        '
        Me.AccountEmployeeRadioButton.AutoSize = True
        Me.AccountEmployeeRadioButton.Location = New System.Drawing.Point(17, 109)
        Me.AccountEmployeeRadioButton.Name = "AccountEmployeeRadioButton"
        Me.AccountEmployeeRadioButton.Size = New System.Drawing.Size(200, 21)
        Me.AccountEmployeeRadioButton.TabIndex = 3
        Me.AccountEmployeeRadioButton.Text = "Cuenta cajero o empleado.."
        Me.AccountEmployeeRadioButton.UseVisualStyleBackColor = True
        '
        'PaymentProviderRadioButton
        '
        Me.PaymentProviderRadioButton.AutoSize = True
        Me.PaymentProviderRadioButton.Location = New System.Drawing.Point(17, 82)
        Me.PaymentProviderRadioButton.Name = "PaymentProviderRadioButton"
        Me.PaymentProviderRadioButton.Size = New System.Drawing.Size(144, 21)
        Me.PaymentProviderRadioButton.TabIndex = 2
        Me.PaymentProviderRadioButton.Text = "Pago a proveedor."
        Me.PaymentProviderRadioButton.UseVisualStyleBackColor = True
        '
        'BankAccountRadioButton
        '
        Me.BankAccountRadioButton.AutoSize = True
        Me.BankAccountRadioButton.Location = New System.Drawing.Point(17, 55)
        Me.BankAccountRadioButton.Name = "BankAccountRadioButton"
        Me.BankAccountRadioButton.Size = New System.Drawing.Size(118, 21)
        Me.BankAccountRadioButton.TabIndex = 1
        Me.BankAccountRadioButton.Text = "Cuenta banco."
        Me.BankAccountRadioButton.UseVisualStyleBackColor = True
        '
        'virtualBoxRadioButton
        '
        Me.virtualBoxRadioButton.AutoSize = True
        Me.virtualBoxRadioButton.Location = New System.Drawing.Point(17, 28)
        Me.virtualBoxRadioButton.Name = "virtualBoxRadioButton"
        Me.virtualBoxRadioButton.Size = New System.Drawing.Size(100, 21)
        Me.virtualBoxRadioButton.TabIndex = 0
        Me.virtualBoxRadioButton.Text = "Caja virtual."
        Me.virtualBoxRadioButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.montoDivisaLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(742, 57)
        Me.Panel1.TabIndex = 11
        '
        'PanelViewData
        '
        Me.PanelViewData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelViewData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewData.Location = New System.Drawing.Point(228, 62)
        Me.PanelViewData.Name = "PanelViewData"
        Me.PanelViewData.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelViewData.Size = New System.Drawing.Size(519, 333)
        Me.PanelViewData.TabIndex = 12
        '
        'frmExitMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(752, 436)
        Me.Controls.Add(Me.PanelViewData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExitMoney"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salida de divisas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents montoDivisaLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents AccountEmployeeRadioButton As RadioButton
    Friend WithEvents PaymentProviderRadioButton As RadioButton
    Friend WithEvents BankAccountRadioButton As RadioButton
    Friend WithEvents virtualBoxRadioButton As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelViewData As Panel
End Class
