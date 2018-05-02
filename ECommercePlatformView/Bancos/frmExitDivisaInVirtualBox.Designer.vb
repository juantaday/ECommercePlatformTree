<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExitDivisaInVirtualBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExitDivisaInVirtualBox))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.virtualNameSelectTextBox = New System.Windows.Forms.TextBox()
        Me.NewExitDivisaButton = New System.Windows.Forms.Button()
        Me.VirtualBoxComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PrintTicketButton = New System.Windows.Forms.Button()
        Me.PrintListButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ByDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.CreditRadioButton = New System.Windows.Forms.RadioButton()
        Me.DebitRadioButton = New System.Windows.Forms.RadioButton()
        Me.SaldoVirtualLabel = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DescriptionLabel = New System.Windows.Forms.RichTextBox()
        Me.dtg = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salida de divisas desde cajas virtuales."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListBodegaComboBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(819, 43)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.virtualNameSelectTextBox)
        Me.Panel3.Controls.Add(Me.NewExitDivisaButton)
        Me.Panel3.Controls.Add(Me.VirtualBoxComboBox)
        Me.Panel3.Location = New System.Drawing.Point(294, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(360, 29)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Caja Virtual:"
        '
        'virtualNameSelectTextBox
        '
        Me.virtualNameSelectTextBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.virtualNameSelectTextBox.Location = New System.Drawing.Point(79, 2)
        Me.virtualNameSelectTextBox.Name = "virtualNameSelectTextBox"
        Me.virtualNameSelectTextBox.Size = New System.Drawing.Size(153, 22)
        Me.virtualNameSelectTextBox.TabIndex = 2
        '
        'NewExitDivisaButton
        '
        Me.NewExitDivisaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewExitDivisaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.NewExitDivisaButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewExitDivisaButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.NewExitDivisaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.NewExitDivisaButton.FlatAppearance.BorderSize = 0
        Me.NewExitDivisaButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.NewExitDivisaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.NewExitDivisaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewExitDivisaButton.Location = New System.Drawing.Point(232, 2)
        Me.NewExitDivisaButton.Name = "NewExitDivisaButton"
        Me.NewExitDivisaButton.Size = New System.Drawing.Size(104, 25)
        Me.NewExitDivisaButton.TabIndex = 1
        Me.NewExitDivisaButton.Text = "Nueva salida."
        Me.NewExitDivisaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewExitDivisaButton.UseVisualStyleBackColor = False
        Me.NewExitDivisaButton.Visible = False
        '
        'VirtualBoxComboBox
        '
        Me.VirtualBoxComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.VirtualBoxComboBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.VirtualBoxComboBox.FormattingEnabled = True
        Me.VirtualBoxComboBox.Location = New System.Drawing.Point(336, 2)
        Me.VirtualBoxComboBox.Name = "VirtualBoxComboBox"
        Me.VirtualBoxComboBox.Size = New System.Drawing.Size(22, 24)
        Me.VirtualBoxComboBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Local o bodega:"
        '
        'ListBodegaComboBox
        '
        Me.ListBodegaComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ListBodegaComboBox.FormattingEnabled = True
        Me.ListBodegaComboBox.Location = New System.Drawing.Point(103, 8)
        Me.ListBodegaComboBox.Name = "ListBodegaComboBox"
        Me.ListBodegaComboBox.Size = New System.Drawing.Size(185, 24)
        Me.ListBodegaComboBox.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PrintTicketButton)
        Me.Panel4.Controls.Add(Me.PrintListButton)
        Me.Panel4.Controls.Add(Me.ByDateRadioButton)
        Me.Panel4.Controls.Add(Me.CreditRadioButton)
        Me.Panel4.Controls.Add(Me.DebitRadioButton)
        Me.Panel4.Controls.Add(Me.SaldoVirtualLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(819, 56)
        Me.Panel4.TabIndex = 2
        '
        'PrintTicketButton
        '
        Me.PrintTicketButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintTicketButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.PrintTicketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintTicketButton.Location = New System.Drawing.Point(617, 17)
        Me.PrintTicketButton.Name = "PrintTicketButton"
        Me.PrintTicketButton.Size = New System.Drawing.Size(74, 24)
        Me.PrintTicketButton.TabIndex = 4
        Me.PrintTicketButton.Text = "Print"
        Me.PrintTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.PrintTicketButton, "Imprimir Ticket solo el item")
        Me.PrintTicketButton.UseVisualStyleBackColor = True
        '
        'PrintListButton
        '
        Me.PrintListButton.ActiveBorderThickness = 1
        Me.PrintListButton.ActiveCornerRadius = 20
        Me.PrintListButton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PrintListButton.ActiveForecolor = System.Drawing.Color.White
        Me.PrintListButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.PrintListButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintListButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.PrintListButton.BackgroundImage = CType(resources.GetObject("PrintListButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintListButton.ButtonText = "Imprimir.."
        Me.PrintListButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintListButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintListButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PrintListButton.IdleBorderThickness = 1
        Me.PrintListButton.IdleCornerRadius = 20
        Me.PrintListButton.IdleFillColor = System.Drawing.Color.White
        Me.PrintListButton.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.PrintListButton.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.PrintListButton.Location = New System.Drawing.Point(697, 4)
        Me.PrintListButton.Margin = New System.Windows.Forms.Padding(5)
        Me.PrintListButton.Name = "PrintListButton"
        Me.PrintListButton.Size = New System.Drawing.Size(117, 43)
        Me.PrintListButton.TabIndex = 3
        Me.PrintListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.PrintListButton, "Imprimir toda la lista")
        '
        'ByDateRadioButton
        '
        Me.ByDateRadioButton.AutoSize = True
        Me.ByDateRadioButton.Location = New System.Drawing.Point(396, 33)
        Me.ByDateRadioButton.Name = "ByDateRadioButton"
        Me.ByDateRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.ByDateRadioButton.TabIndex = 2
        Me.ByDateRadioButton.Text = "Por fecha"
        Me.ToolTip1.SetToolTip(Me.ByDateRadioButton, "Determine fecha de busqueda cortas..")
        Me.ByDateRadioButton.UseVisualStyleBackColor = True
        '
        'CreditRadioButton
        '
        Me.CreditRadioButton.AutoSize = True
        Me.CreditRadioButton.Location = New System.Drawing.Point(193, 33)
        Me.CreditRadioButton.Name = "CreditRadioButton"
        Me.CreditRadioButton.Size = New System.Drawing.Size(183, 17)
        Me.CreditRadioButton.TabIndex = 2
        Me.CreditRadioButton.Text = "Créditos..(últimos 10 movimientos)"
        Me.CreditRadioButton.UseVisualStyleBackColor = True
        '
        'DebitRadioButton
        '
        Me.DebitRadioButton.AutoSize = True
        Me.DebitRadioButton.Checked = True
        Me.DebitRadioButton.Location = New System.Drawing.Point(6, 33)
        Me.DebitRadioButton.Name = "DebitRadioButton"
        Me.DebitRadioButton.Size = New System.Drawing.Size(181, 17)
        Me.DebitRadioButton.TabIndex = 2
        Me.DebitRadioButton.TabStop = True
        Me.DebitRadioButton.Text = "Débitos..(últimos 10 movimientos)"
        Me.DebitRadioButton.UseVisualStyleBackColor = True
        '
        'SaldoVirtualLabel
        '
        Me.SaldoVirtualLabel.AutoSize = True
        Me.SaldoVirtualLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaldoVirtualLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.SaldoVirtualLabel.Location = New System.Drawing.Point(3, 3)
        Me.SaldoVirtualLabel.Name = "SaldoVirtualLabel"
        Me.SaldoVirtualLabel.Size = New System.Drawing.Size(409, 29)
        Me.SaldoVirtualLabel.TabIndex = 1
        Me.SaldoVirtualLabel.Text = "Saldo de caja vitual 02: $23.36502"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DescriptionLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 271)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(819, 73)
        Me.Panel5.TabIndex = 3
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoWordSelection = True
        Me.DescriptionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.DescriptionLabel.Location = New System.Drawing.Point(10, 10)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(799, 53)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = ""
        '
        'dtg
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.DoubleBuffered = True
        Me.dtg.EnableHeadersVisualStyles = False
        Me.dtg.HeaderBgColor = System.Drawing.Color.Yellow
        Me.dtg.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.dtg.Location = New System.Drawing.Point(3, 142)
        Me.dtg.Name = "dtg"
        Me.dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg.Size = New System.Drawing.Size(819, 129)
        Me.dtg.TabIndex = 4
        '
        'frmExitDivisaInVirtualBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(825, 347)
        Me.Controls.Add(Me.dtg)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmExitDivisaInVirtualBox"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Text = "Salida de divisas desde cajas virtuales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents virtualNameSelectTextBox As TextBox
    Friend WithEvents NewExitDivisaButton As Button
    Friend WithEvents VirtualBoxComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ByDateRadioButton As RadioButton
    Friend WithEvents CreditRadioButton As RadioButton
    Friend WithEvents DebitRadioButton As RadioButton
    Friend WithEvents SaldoVirtualLabel As Label
    Friend WithEvents PrintListButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtg As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DescriptionLabel As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintTicketButton As Button
End Class
