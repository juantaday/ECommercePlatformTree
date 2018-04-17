<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClosedTransactionsTerminal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClosedTransactionsTerminal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintTicketButton = New System.Windows.Forms.Button()
        Me.PrintListButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ByDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.DescriptionLabel = New System.Windows.Forms.RichTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.YesterdayRadioButton = New System.Windows.Forms.RadioButton()
        Me.NewRadioButton = New System.Windows.Forms.RadioButton()
        Me.dtg = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BeforeDayRadioButton = New System.Windows.Forms.RadioButton()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.virtualNameSelectTextBox = New System.Windows.Forms.TextBox()
        Me.NewExitDivisaButton = New System.Windows.Forms.Button()
        Me.VirtualBoxComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintTicketButton
        '
        Me.PrintTicketButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintTicketButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_16x16
        Me.PrintTicketButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintTicketButton.Location = New System.Drawing.Point(650, 16)
        Me.PrintTicketButton.Name = "PrintTicketButton"
        Me.PrintTicketButton.Size = New System.Drawing.Size(74, 24)
        Me.PrintTicketButton.TabIndex = 4
        Me.PrintTicketButton.Text = "Ticket"
        Me.PrintTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.PrintTicketButton, "Imprimir Ticket solo una operacion")
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
        Me.PrintListButton.Location = New System.Drawing.Point(732, 4)
        Me.PrintListButton.Margin = New System.Windows.Forms.Padding(5)
        Me.PrintListButton.Name = "PrintListButton"
        Me.PrintListButton.Size = New System.Drawing.Size(117, 44)
        Me.PrintListButton.TabIndex = 3
        Me.PrintListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.PrintListButton, "Imprimir toda la lista en pdf")
        '
        'ByDateRadioButton
        '
        Me.ByDateRadioButton.AutoSize = True
        Me.ByDateRadioButton.Location = New System.Drawing.Point(262, 16)
        Me.ByDateRadioButton.Name = "ByDateRadioButton"
        Me.ByDateRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.ByDateRadioButton.TabIndex = 2
        Me.ByDateRadioButton.Text = "Por fecha"
        Me.ToolTip1.SetToolTip(Me.ByDateRadioButton, "Determine fecha de busqueda cortas..")
        Me.ByDateRadioButton.UseVisualStyleBackColor = True
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
        Me.DescriptionLabel.Size = New System.Drawing.Size(836, 45)
        Me.DescriptionLabel.TabIndex = 0
        Me.DescriptionLabel.Text = ""
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DescriptionLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 393)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(856, 65)
        Me.Panel5.TabIndex = 8
        '
        'YesterdayRadioButton
        '
        Me.YesterdayRadioButton.AutoSize = True
        Me.YesterdayRadioButton.Location = New System.Drawing.Point(92, 16)
        Me.YesterdayRadioButton.Name = "YesterdayRadioButton"
        Me.YesterdayRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.YesterdayRadioButton.TabIndex = 2
        Me.YesterdayRadioButton.Text = "Ayer:"
        Me.YesterdayRadioButton.UseVisualStyleBackColor = True
        '
        'NewRadioButton
        '
        Me.NewRadioButton.AutoSize = True
        Me.NewRadioButton.Checked = True
        Me.NewRadioButton.Location = New System.Drawing.Point(12, 16)
        Me.NewRadioButton.Name = "NewRadioButton"
        Me.NewRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.NewRadioButton.TabIndex = 2
        Me.NewRadioButton.TabStop = True
        Me.NewRadioButton.Text = "Hoy día:"
        Me.NewRadioButton.UseVisualStyleBackColor = True
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        Me.dtg.AllowUserToOrderColumns = True
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
        Me.dtg.Location = New System.Drawing.Point(3, 3)
        Me.dtg.Name = "dtg"
        Me.dtg.ReadOnly = True
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
        Me.dtg.Size = New System.Drawing.Size(848, 249)
        Me.dtg.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BeforeDayRadioButton)
        Me.Panel4.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel4.Controls.Add(Me.PrintTicketButton)
        Me.Panel4.Controls.Add(Me.PrintListButton)
        Me.Panel4.Controls.Add(Me.ByDateRadioButton)
        Me.Panel4.Controls.Add(Me.YesterdayRadioButton)
        Me.Panel4.Controls.Add(Me.NewRadioButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(856, 47)
        Me.Panel4.TabIndex = 7
        '
        'BeforeDayRadioButton
        '
        Me.BeforeDayRadioButton.AutoSize = True
        Me.BeforeDayRadioButton.Location = New System.Drawing.Point(155, 16)
        Me.BeforeDayRadioButton.Name = "BeforeDayRadioButton"
        Me.BeforeDayRadioButton.Size = New System.Drawing.Size(93, 17)
        Me.BeforeDayRadioButton.TabIndex = 6
        Me.BeforeDayRadioButton.Text = "Antes de ayer:"
        Me.BeforeDayRadioButton.UseVisualStyleBackColor = True
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.BunifuDatepicker1.BorderRadius = 5
        Me.BunifuDatepicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(339, 5)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(164, 35)
        Me.BunifuDatepicker1.TabIndex = 5
        Me.BunifuDatepicker1.Value = New Date(2017, 10, 11, 19, 15, 39, 953)
        Me.BunifuDatepicker1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Local o bodega:"
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
        Me.Panel3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Caja Virtual:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListBodegaComboBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(3, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(856, 43)
        Me.Panel2.TabIndex = 6
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operaciones cerradas en terminales."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 43)
        Me.Panel1.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.dtg)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 136)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel6.Size = New System.Drawing.Size(856, 257)
        Me.Panel6.TabIndex = 10
        '
        'frmClosedTransactionsTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 461)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmClosedTransactionsTerminal"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "Opraciones cerradas "
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintTicketButton As Button
    Friend WithEvents PrintListButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ByDateRadioButton As RadioButton
    Friend WithEvents DescriptionLabel As RichTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents YesterdayRadioButton As RadioButton
    Friend WithEvents NewRadioButton As RadioButton
    Friend WithEvents dtg As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents virtualNameSelectTextBox As TextBox
    Friend WithEvents NewExitDivisaButton As Button
    Friend WithEvents VirtualBoxComboBox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BeforeDayRadioButton As RadioButton
End Class
