<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIcajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIcajas))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FaltantesButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BalanzaDivisaButton = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CollapPropertyButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ExitDivisaButton = New System.Windows.Forms.Button()
        Me.VirtualBoxBalanceButton = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CollapVirtualButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HabilitaTerminalButton = New System.Windows.Forms.Button()
        Me.ListOperacionButton = New System.Windows.Forms.Button()
        Me.SaldoEnCajasButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CollapAdminButton = New System.Windows.Forms.Button()
        Me.PanelUser = New System.Windows.Forms.Panel()
        Me.UltCierreButton = New System.Windows.Forms.Button()
        Me.MovimButton = New System.Windows.Forms.Button()
        Me.MySaldoButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CollapMycajaButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "Nuevo"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Abrir"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Guardar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Imprimir"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreviewToolStripButton.Text = "Vista previa de impresión"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Ayuda"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(232, 639)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(752, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'FaltantesButton
        '
        Me.FaltantesButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.FaltantesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.FaltantesButton.FlatAppearance.BorderSize = 0
        Me.FaltantesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FaltantesButton.Location = New System.Drawing.Point(13, 53)
        Me.FaltantesButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.FaltantesButton.Name = "FaltantesButton"
        Me.FaltantesButton.Size = New System.Drawing.Size(212, 25)
        Me.FaltantesButton.TabIndex = 4
        Me.FaltantesButton.Text = "Faltantes sobrantes."
        Me.FaltantesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.FaltantesButton, "Faltantes y sobrantes en terminales cerrados.")
        Me.FaltantesButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Location = New System.Drawing.Point(232, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 51)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(0, 614)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.PanelUser)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.White
        Me.PanelMenu.Location = New System.Drawing.Point(0, 25)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(227, 636)
        Me.PanelMenu.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Controls.Add(Me.Button5)
        Me.Panel6.Controls.Add(Me.BalanzaDivisaButton)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.CollapPropertyButton)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 387)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(225, 112)
        Me.Panel6.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(13, 78)
        Me.Button4.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(212, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Transacciones bancarias"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(13, 53)
        Me.Button5.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(212, 25)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Saldos bancarios"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'BalanzaDivisaButton
        '
        Me.BalanzaDivisaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.BalanzaDivisaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BalanzaDivisaButton.FlatAppearance.BorderSize = 0
        Me.BalanzaDivisaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BalanzaDivisaButton.Location = New System.Drawing.Point(13, 28)
        Me.BalanzaDivisaButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.BalanzaDivisaButton.Name = "BalanzaDivisaButton"
        Me.BalanzaDivisaButton.Size = New System.Drawing.Size(212, 25)
        Me.BalanzaDivisaButton.TabIndex = 0
        Me.BalanzaDivisaButton.Text = "Balance divisas"
        Me.BalanzaDivisaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BalanzaDivisaButton.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 28)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(13, 84)
        Me.Panel7.TabIndex = 2
        '
        'CollapPropertyButton
        '
        Me.CollapPropertyButton.BackColor = System.Drawing.Color.DimGray
        Me.CollapPropertyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CollapPropertyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollapPropertyButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CollapPropertyButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CollapPropertyButton.FlatAppearance.BorderSize = 0
        Me.CollapPropertyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollapPropertyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapPropertyButton.Image = CType(resources.GetObject("CollapPropertyButton.Image"), System.Drawing.Image)
        Me.CollapPropertyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapPropertyButton.Location = New System.Drawing.Point(0, 0)
        Me.CollapPropertyButton.Name = "CollapPropertyButton"
        Me.CollapPropertyButton.Size = New System.Drawing.Size(225, 28)
        Me.CollapPropertyButton.TabIndex = 1
        Me.CollapPropertyButton.Tag = "0"
        Me.CollapPropertyButton.Text = "      Propietarios"
        Me.CollapPropertyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapPropertyButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.ExitDivisaButton)
        Me.Panel4.Controls.Add(Me.VirtualBoxBalanceButton)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.CollapVirtualButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 270)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(225, 117)
        Me.Panel4.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(13, 78)
        Me.Button3.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Ultimo cierre"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ExitDivisaButton
        '
        Me.ExitDivisaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExitDivisaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExitDivisaButton.FlatAppearance.BorderSize = 0
        Me.ExitDivisaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitDivisaButton.Location = New System.Drawing.Point(13, 53)
        Me.ExitDivisaButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.ExitDivisaButton.Name = "ExitDivisaButton"
        Me.ExitDivisaButton.Size = New System.Drawing.Size(212, 25)
        Me.ExitDivisaButton.TabIndex = 3
        Me.ExitDivisaButton.Text = "Movimientos en cajas virtuales."
        Me.ExitDivisaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitDivisaButton.UseVisualStyleBackColor = False
        '
        'VirtualBoxBalanceButton
        '
        Me.VirtualBoxBalanceButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.VirtualBoxBalanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.VirtualBoxBalanceButton.FlatAppearance.BorderSize = 0
        Me.VirtualBoxBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VirtualBoxBalanceButton.Location = New System.Drawing.Point(13, 28)
        Me.VirtualBoxBalanceButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.VirtualBoxBalanceButton.Name = "VirtualBoxBalanceButton"
        Me.VirtualBoxBalanceButton.Size = New System.Drawing.Size(212, 25)
        Me.VirtualBoxBalanceButton.TabIndex = 0
        Me.VirtualBoxBalanceButton.Text = "Saldo en cajas virtuales"
        Me.VirtualBoxBalanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VirtualBoxBalanceButton.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 28)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(13, 89)
        Me.Panel5.TabIndex = 2
        '
        'CollapVirtualButton
        '
        Me.CollapVirtualButton.BackColor = System.Drawing.Color.DimGray
        Me.CollapVirtualButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CollapVirtualButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollapVirtualButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CollapVirtualButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CollapVirtualButton.FlatAppearance.BorderSize = 0
        Me.CollapVirtualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollapVirtualButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapVirtualButton.Image = CType(resources.GetObject("CollapVirtualButton.Image"), System.Drawing.Image)
        Me.CollapVirtualButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapVirtualButton.Location = New System.Drawing.Point(0, 0)
        Me.CollapVirtualButton.Name = "CollapVirtualButton"
        Me.CollapVirtualButton.Size = New System.Drawing.Size(225, 28)
        Me.CollapVirtualButton.TabIndex = 1
        Me.CollapVirtualButton.Tag = "0"
        Me.CollapVirtualButton.Text = "      Cajas virtuales"
        Me.CollapVirtualButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapVirtualButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HabilitaTerminalButton)
        Me.Panel1.Controls.Add(Me.ListOperacionButton)
        Me.Panel1.Controls.Add(Me.FaltantesButton)
        Me.Panel1.Controls.Add(Me.SaldoEnCajasButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CollapAdminButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 159)
        Me.Panel1.TabIndex = 1
        '
        'HabilitaTerminalButton
        '
        Me.HabilitaTerminalButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.HabilitaTerminalButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HabilitaTerminalButton.FlatAppearance.BorderSize = 0
        Me.HabilitaTerminalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HabilitaTerminalButton.Location = New System.Drawing.Point(13, 103)
        Me.HabilitaTerminalButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.HabilitaTerminalButton.Name = "HabilitaTerminalButton"
        Me.HabilitaTerminalButton.Size = New System.Drawing.Size(212, 25)
        Me.HabilitaTerminalButton.TabIndex = 3
        Me.HabilitaTerminalButton.Text = "Habilitar terminales."
        Me.HabilitaTerminalButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HabilitaTerminalButton.UseVisualStyleBackColor = False
        '
        'ListOperacionButton
        '
        Me.ListOperacionButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListOperacionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ListOperacionButton.FlatAppearance.BorderSize = 0
        Me.ListOperacionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ListOperacionButton.Location = New System.Drawing.Point(13, 78)
        Me.ListOperacionButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.ListOperacionButton.Name = "ListOperacionButton"
        Me.ListOperacionButton.Size = New System.Drawing.Size(212, 25)
        Me.ListOperacionButton.TabIndex = 5
        Me.ListOperacionButton.Text = "Operaciones cerradas"
        Me.ListOperacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListOperacionButton.UseVisualStyleBackColor = False
        '
        'SaldoEnCajasButton
        '
        Me.SaldoEnCajasButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaldoEnCajasButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaldoEnCajasButton.FlatAppearance.BorderSize = 0
        Me.SaldoEnCajasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaldoEnCajasButton.Location = New System.Drawing.Point(13, 28)
        Me.SaldoEnCajasButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.SaldoEnCajasButton.Name = "SaldoEnCajasButton"
        Me.SaldoEnCajasButton.Size = New System.Drawing.Size(212, 25)
        Me.SaldoEnCajasButton.TabIndex = 0
        Me.SaldoEnCajasButton.Text = "Saldo en terminales."
        Me.SaldoEnCajasButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.SaldoEnCajasButton, "Saldo en terminales (Solo abiertos e hibernados)")
        Me.SaldoEnCajasButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(13, 131)
        Me.Panel3.TabIndex = 2
        '
        'CollapAdminButton
        '
        Me.CollapAdminButton.BackColor = System.Drawing.Color.DimGray
        Me.CollapAdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CollapAdminButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollapAdminButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CollapAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CollapAdminButton.FlatAppearance.BorderSize = 0
        Me.CollapAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollapAdminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapAdminButton.Image = CType(resources.GetObject("CollapAdminButton.Image"), System.Drawing.Image)
        Me.CollapAdminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapAdminButton.Location = New System.Drawing.Point(0, 0)
        Me.CollapAdminButton.Name = "CollapAdminButton"
        Me.CollapAdminButton.Size = New System.Drawing.Size(225, 28)
        Me.CollapAdminButton.TabIndex = 1
        Me.CollapAdminButton.Tag = "0"
        Me.CollapAdminButton.Text = "      Administración (Terminal)"
        Me.CollapAdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.CollapAdminButton, "Administracion de terminales.")
        Me.CollapAdminButton.UseVisualStyleBackColor = False
        '
        'PanelUser
        '
        Me.PanelUser.Controls.Add(Me.UltCierreButton)
        Me.PanelUser.Controls.Add(Me.MovimButton)
        Me.PanelUser.Controls.Add(Me.MySaldoButton)
        Me.PanelUser.Controls.Add(Me.Panel2)
        Me.PanelUser.Controls.Add(Me.CollapMycajaButton)
        Me.PanelUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelUser.Location = New System.Drawing.Point(0, 0)
        Me.PanelUser.Name = "PanelUser"
        Me.PanelUser.Size = New System.Drawing.Size(225, 111)
        Me.PanelUser.TabIndex = 0
        '
        'UltCierreButton
        '
        Me.UltCierreButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltCierreButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UltCierreButton.FlatAppearance.BorderSize = 0
        Me.UltCierreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UltCierreButton.Location = New System.Drawing.Point(13, 78)
        Me.UltCierreButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.UltCierreButton.Name = "UltCierreButton"
        Me.UltCierreButton.Size = New System.Drawing.Size(212, 25)
        Me.UltCierreButton.TabIndex = 4
        Me.UltCierreButton.Text = "Ultimo cierre"
        Me.UltCierreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UltCierreButton.UseVisualStyleBackColor = False
        '
        'MovimButton
        '
        Me.MovimButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MovimButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MovimButton.FlatAppearance.BorderSize = 0
        Me.MovimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MovimButton.Location = New System.Drawing.Point(13, 53)
        Me.MovimButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.MovimButton.Name = "MovimButton"
        Me.MovimButton.Size = New System.Drawing.Size(212, 25)
        Me.MovimButton.TabIndex = 3
        Me.MovimButton.Text = "Movimientos"
        Me.MovimButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MovimButton.UseVisualStyleBackColor = False
        '
        'MySaldoButton
        '
        Me.MySaldoButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MySaldoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MySaldoButton.FlatAppearance.BorderSize = 0
        Me.MySaldoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MySaldoButton.Location = New System.Drawing.Point(13, 28)
        Me.MySaldoButton.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.MySaldoButton.Name = "MySaldoButton"
        Me.MySaldoButton.Size = New System.Drawing.Size(212, 25)
        Me.MySaldoButton.TabIndex = 0
        Me.MySaldoButton.Text = "Saldo.."
        Me.MySaldoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MySaldoButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(12, 3, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(13, 83)
        Me.Panel2.TabIndex = 2
        '
        'CollapMycajaButton
        '
        Me.CollapMycajaButton.BackColor = System.Drawing.Color.DimGray
        Me.CollapMycajaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CollapMycajaButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollapMycajaButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CollapMycajaButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CollapMycajaButton.FlatAppearance.BorderSize = 0
        Me.CollapMycajaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollapMycajaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapMycajaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.hamburger_22_Down_white
        Me.CollapMycajaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapMycajaButton.Location = New System.Drawing.Point(0, 0)
        Me.CollapMycajaButton.Name = "CollapMycajaButton"
        Me.CollapMycajaButton.Size = New System.Drawing.Size(225, 28)
        Me.CollapMycajaButton.TabIndex = 1
        Me.CollapMycajaButton.Tag = "1"
        Me.CollapMycajaButton.Text = "   Este terminal"
        Me.CollapMycajaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CollapMycajaButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(0, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Movimientos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ultimo cierre"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Blue
        Me.Splitter1.Location = New System.Drawing.Point(227, 25)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 636)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'MDIcajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.ToolStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIcajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando cajas..."
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelUser.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PanelUser As System.Windows.Forms.Panel
    Friend WithEvents CollapMycajaButton As System.Windows.Forms.Button
    Friend WithEvents UltCierreButton As System.Windows.Forms.Button
    Friend WithEvents MovimButton As System.Windows.Forms.Button
    Friend WithEvents MySaldoButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FaltantesButton As System.Windows.Forms.Button
    Friend WithEvents HabilitaTerminalButton As System.Windows.Forms.Button
    Friend WithEvents SaldoEnCajasButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CollapAdminButton As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ExitDivisaButton As System.Windows.Forms.Button
    Friend WithEvents VirtualBoxBalanceButton As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CollapVirtualButton As System.Windows.Forms.Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BalanzaDivisaButton As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CollapPropertyButton As Button
    Friend WithEvents ListOperacionButton As Button
    Friend WithEvents Splitter1 As Splitter
End Class
