<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChildPaymentProvider
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
        Me.NumTransaccionPanel = New System.Windows.Forms.Panel()
        Me.NumTransferTextBox = New System.Windows.Forms.TextBox()
        Me.FinTransaccionButton = New System.Windows.Forms.Button()
        Me.NumTransaacionLabel = New System.Windows.Forms.Label()
        Me.SatateSystemLabel = New System.Windows.Forms.Label()
        Me.SatateSystemComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumDocumentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProviderTextBox = New System.Windows.Forms.TextBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateInvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.DateInvoiceDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TypeDocumentComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DatePaymentTextBox = New System.Windows.Forms.TextBox()
        Me.DatePaymentTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateOrderTextBox = New System.Windows.Forms.TextBox()
        Me.DateOrderDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelView.SuspendLayout()
        Me.NumTransaccionPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.NumTransaccionPanel)
        Me.PanelView.Controls.Add(Me.NumTransaacionLabel)
        Me.PanelView.Controls.Add(Me.SatateSystemLabel)
        Me.PanelView.Controls.Add(Me.SatateSystemComboBox)
        Me.PanelView.Controls.Add(Me.Label7)
        Me.PanelView.Controls.Add(Me.Label6)
        Me.PanelView.Controls.Add(Me.Label5)
        Me.PanelView.Controls.Add(Me.NumDocumentTextBox)
        Me.PanelView.Controls.Add(Me.Panel1)
        Me.PanelView.Controls.Add(Me.Label2)
        Me.PanelView.Controls.Add(Me.Panel4)
        Me.PanelView.Controls.Add(Me.TypeDocumentComboBox)
        Me.PanelView.Controls.Add(Me.OrderStatusComboBox)
        Me.PanelView.Controls.Add(Me.Panel3)
        Me.PanelView.Controls.Add(Me.Label4)
        Me.PanelView.Controls.Add(Me.Label3)
        Me.PanelView.Controls.Add(Me.Panel2)
        Me.PanelView.Controls.Add(Me.SubmitButton)
        Me.PanelView.Controls.Add(Me.Label1)
        Me.PanelView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelView.Location = New System.Drawing.Point(2, 2)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(461, 281)
        Me.PanelView.TabIndex = 3
        '
        'NumTransaccionPanel
        '
        Me.NumTransaccionPanel.BackColor = System.Drawing.Color.White
        Me.NumTransaccionPanel.Controls.Add(Me.NumTransferTextBox)
        Me.NumTransaccionPanel.Controls.Add(Me.FinTransaccionButton)
        Me.NumTransaccionPanel.Location = New System.Drawing.Point(258, 186)
        Me.NumTransaccionPanel.Name = "NumTransaccionPanel"
        Me.NumTransaccionPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.NumTransaccionPanel.Size = New System.Drawing.Size(184, 28)
        Me.NumTransaccionPanel.TabIndex = 7
        '
        'NumTransferTextBox
        '
        Me.NumTransferTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumTransferTextBox.Location = New System.Drawing.Point(2, 2)
        Me.NumTransferTextBox.Name = "NumTransferTextBox"
        Me.NumTransferTextBox.ReadOnly = True
        Me.NumTransferTextBox.Size = New System.Drawing.Size(151, 23)
        Me.NumTransferTextBox.TabIndex = 3
        '
        'FinTransaccionButton
        '
        Me.FinTransaccionButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FinTransaccionButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.FinTransaccionButton.Location = New System.Drawing.Point(153, 2)
        Me.FinTransaccionButton.Name = "FinTransaccionButton"
        Me.FinTransaccionButton.Size = New System.Drawing.Size(29, 24)
        Me.FinTransaccionButton.TabIndex = 2
        Me.FinTransaccionButton.UseVisualStyleBackColor = False
        '
        'NumTransaacionLabel
        '
        Me.NumTransaacionLabel.AutoSize = True
        Me.NumTransaacionLabel.Location = New System.Drawing.Point(95, 192)
        Me.NumTransaacionLabel.Name = "NumTransaacionLabel"
        Me.NumTransaacionLabel.Size = New System.Drawing.Size(159, 17)
        Me.NumTransaacionLabel.TabIndex = 6
        Me.NumTransaacionLabel.Text = "Número de transacción:"
        '
        'SatateSystemLabel
        '
        Me.SatateSystemLabel.AutoSize = True
        Me.SatateSystemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SatateSystemLabel.Location = New System.Drawing.Point(14, 160)
        Me.SatateSystemLabel.Name = "SatateSystemLabel"
        Me.SatateSystemLabel.Size = New System.Drawing.Size(98, 13)
        Me.SatateSystemLabel.TabIndex = 20
        Me.SatateSystemLabel.Text = "El documento está:"
        '
        'SatateSystemComboBox
        '
        Me.SatateSystemComboBox.FormattingEnabled = True
        Me.SatateSystemComboBox.Items.AddRange(New Object() {"A un no he ingresado", "Ingresado como pedido.", "Ya está contabilizado."})
        Me.SatateSystemComboBox.Location = New System.Drawing.Point(118, 154)
        Me.SatateSystemComboBox.Name = "SatateSystemComboBox"
        Me.SatateSystemComboBox.Size = New System.Drawing.Size(324, 24)
        Me.SatateSystemComboBox.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 26)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Se paga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "documento."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(225, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fecha de pedido:"
        '
        'NumDocumentTextBox
        '
        Me.NumDocumentTextBox.Location = New System.Drawing.Point(85, 89)
        Me.NumDocumentTextBox.Name = "NumDocumentTextBox"
        Me.NumDocumentTextBox.Size = New System.Drawing.Size(134, 23)
        Me.NumDocumentTextBox.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ProviderTextBox)
        Me.Panel1.Controls.Add(Me.findButton)
        Me.Panel1.Location = New System.Drawing.Point(76, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(382, 28)
        Me.Panel1.TabIndex = 5
        '
        'ProviderTextBox
        '
        Me.ProviderTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProviderTextBox.Location = New System.Drawing.Point(2, 2)
        Me.ProviderTextBox.Name = "ProviderTextBox"
        Me.ProviderTextBox.ReadOnly = True
        Me.ProviderTextBox.Size = New System.Drawing.Size(349, 23)
        Me.ProviderTextBox.TabIndex = 3
        '
        'findButton
        '
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.findButton.Location = New System.Drawing.Point(351, 2)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(29, 24)
        Me.findButton.TabIndex = 2
        Me.findButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Proveedor:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DateInvoiceTextBox)
        Me.Panel4.Controls.Add(Me.DateInvoiceDateTimePicker)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(318, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 25)
        Me.Panel4.TabIndex = 13
        '
        'DateInvoiceTextBox
        '
        Me.DateInvoiceTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateInvoiceTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DateInvoiceTextBox.Name = "DateInvoiceTextBox"
        Me.DateInvoiceTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DateInvoiceTextBox.TabIndex = 8
        '
        'DateInvoiceDateTimePicker
        '
        Me.DateInvoiceDateTimePicker.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateInvoiceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateInvoiceDateTimePicker.Location = New System.Drawing.Point(124, 0)
        Me.DateInvoiceDateTimePicker.Name = "DateInvoiceDateTimePicker"
        Me.DateInvoiceDateTimePicker.Size = New System.Drawing.Size(11, 20)
        Me.DateInvoiceDateTimePicker.TabIndex = 7
        '
        'TypeDocumentComboBox
        '
        Me.TypeDocumentComboBox.FormattingEnabled = True
        Me.TypeDocumentComboBox.Location = New System.Drawing.Point(10, 51)
        Me.TypeDocumentComboBox.Name = "TypeDocumentComboBox"
        Me.TypeDocumentComboBox.Size = New System.Drawing.Size(209, 24)
        Me.TypeDocumentComboBox.TabIndex = 14
        '
        'OrderStatusComboBox
        '
        Me.OrderStatusComboBox.FormattingEnabled = True
        Me.OrderStatusComboBox.Location = New System.Drawing.Point(76, 124)
        Me.OrderStatusComboBox.Name = "OrderStatusComboBox"
        Me.OrderStatusComboBox.Size = New System.Drawing.Size(219, 24)
        Me.OrderStatusComboBox.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DatePaymentTextBox)
        Me.Panel3.Controls.Add(Me.DatePaymentTimePicker)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(318, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 25)
        Me.Panel3.TabIndex = 12
        '
        'DatePaymentTextBox
        '
        Me.DatePaymentTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatePaymentTextBox.Enabled = False
        Me.DatePaymentTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DatePaymentTextBox.Name = "DatePaymentTextBox"
        Me.DatePaymentTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DatePaymentTextBox.TabIndex = 8
        '
        'DatePaymentTimePicker
        '
        Me.DatePaymentTimePicker.Dock = System.Windows.Forms.DockStyle.Right
        Me.DatePaymentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePaymentTimePicker.Location = New System.Drawing.Point(124, 0)
        Me.DatePaymentTimePicker.Name = "DatePaymentTimePicker"
        Me.DatePaymentTimePicker.Size = New System.Drawing.Size(11, 20)
        Me.DatePaymentTimePicker.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha de pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(227, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha de factura"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateOrderTextBox)
        Me.Panel2.Controls.Add(Me.DateOrderDateTimePicker)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(318, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 25)
        Me.Panel2.TabIndex = 9
        '
        'DateOrderTextBox
        '
        Me.DateOrderTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateOrderTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DateOrderTextBox.Name = "DateOrderTextBox"
        Me.DateOrderTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DateOrderTextBox.TabIndex = 8
        '
        'DateOrderDateTimePicker
        '
        Me.DateOrderDateTimePicker.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateOrderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOrderDateTimePicker.Location = New System.Drawing.Point(124, 0)
        Me.DateOrderDateTimePicker.Name = "DateOrderDateTimePicker"
        Me.DateOrderDateTimePicker.Size = New System.Drawing.Size(11, 20)
        Me.DateOrderDateTimePicker.TabIndex = 7
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.Image = Global.ECommercePlatformView.My.Resources.Resources.transfer_Banck_Person_White_32
        Me.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.Location = New System.Drawing.Point(16, 230)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(398, 36)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "        Pagar.."
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de documento:"
        '
        'frmChildPaymentProvider
        '
        Me.ClientSize = New System.Drawing.Size(493, 288)
        Me.Controls.Add(Me.PanelView)
        Me.Name = "frmChildPaymentProvider"
        Me.PanelView.ResumeLayout(False)
        Me.PanelView.PerformLayout()
        Me.NumTransaccionPanel.ResumeLayout(False)
        Me.NumTransaccionPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelView As Panel
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProviderTextBox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateOrderDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateOrderTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DatePaymentTimePicker As DateTimePicker
    Friend WithEvents DatePaymentTextBox As TextBox
    Friend WithEvents OrderStatusComboBox As ComboBox
    Friend WithEvents TypeDocumentComboBox As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateInvoiceDateTimePicker As DateTimePicker
    Friend WithEvents DateInvoiceTextBox As TextBox
    Friend WithEvents NumDocumentTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SatateSystemLabel As Label
    Friend WithEvents SatateSystemComboBox As ComboBox
    Friend WithEvents NumTransaccionPanel As Panel
    Friend WithEvents NumTransferTextBox As TextBox
    Friend WithEvents FinTransaccionButton As Button
    Friend WithEvents NumTransaacionLabel As Label
End Class
