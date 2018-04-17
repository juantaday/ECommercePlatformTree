<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSaldo_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldo_caja))
        Me.NameCajaLabel = New System.Windows.Forms.Label()
        Me.CajaNameLabel = New System.Windows.Forms.Label()
        Me.PanelCajaDesck = New System.Windows.Forms.Panel()
        Me.MaxiDetailButton = New System.Windows.Forms.Button()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.TitleDeatailInformationLabel = New System.Windows.Forms.Label()
        Me.TitleDetailLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArqueoDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HibernarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PanelCajaDesck.SuspendLayout()
        Me.PanelMaster.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameCajaLabel
        '
        Me.NameCajaLabel.AutoSize = True
        Me.NameCajaLabel.Location = New System.Drawing.Point(5, 5)
        Me.NameCajaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameCajaLabel.Name = "NameCajaLabel"
        Me.NameCajaLabel.Size = New System.Drawing.Size(45, 20)
        Me.NameCajaLabel.TabIndex = 0
        Me.NameCajaLabel.Text = "Caja:"
        '
        'CajaNameLabel
        '
        Me.CajaNameLabel.AutoSize = True
        Me.CajaNameLabel.Location = New System.Drawing.Point(50, 5)
        Me.CajaNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CajaNameLabel.Name = "CajaNameLabel"
        Me.CajaNameLabel.Size = New System.Drawing.Size(0, 20)
        Me.CajaNameLabel.TabIndex = 0
        '
        'PanelCajaDesck
        '
        Me.PanelCajaDesck.BackColor = System.Drawing.Color.Green
        Me.PanelCajaDesck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCajaDesck.Controls.Add(Me.MaxiDetailButton)
        Me.PanelCajaDesck.Controls.Add(Me.NameCajaLabel)
        Me.PanelCajaDesck.Controls.Add(Me.CajaNameLabel)
        Me.PanelCajaDesck.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCajaDesck.ForeColor = System.Drawing.Color.White
        Me.PanelCajaDesck.Location = New System.Drawing.Point(2, 12)
        Me.PanelCajaDesck.Name = "PanelCajaDesck"
        Me.PanelCajaDesck.Size = New System.Drawing.Size(667, 29)
        Me.PanelCajaDesck.TabIndex = 1
        '
        'MaxiDetailButton
        '
        Me.MaxiDetailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaxiDetailButton.Location = New System.Drawing.Point(623, 15)
        Me.MaxiDetailButton.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MaxiDetailButton.Name = "MaxiDetailButton"
        Me.MaxiDetailButton.Size = New System.Drawing.Size(43, 14)
        Me.MaxiDetailButton.TabIndex = 2
        Me.MaxiDetailButton.Text = "....."
        Me.MaxiDetailButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.MaxiDetailButton, "Minimizar o maximizar detalle")
        Me.MaxiDetailButton.UseVisualStyleBackColor = False
        '
        'PanelMaster
        '
        Me.PanelMaster.Controls.Add(Me.PanelView)
        Me.PanelMaster.Controls.Add(Me.PanelDetail)
        Me.PanelMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMaster.Location = New System.Drawing.Point(2, 41)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(667, 239)
        Me.PanelMaster.TabIndex = 3
        '
        'PanelView
        '
        Me.PanelView.AutoScroll = True
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 0)
        Me.PanelView.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(520, 239)
        Me.PanelView.TabIndex = 1
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.TitleDeatailInformationLabel)
        Me.PanelDetail.Controls.Add(Me.TitleDetailLabel)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDetail.Location = New System.Drawing.Point(520, 0)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(147, 239)
        Me.PanelDetail.TabIndex = 0
        '
        'TitleDeatailInformationLabel
        '
        Me.TitleDeatailInformationLabel.AutoSize = True
        Me.TitleDeatailInformationLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleDeatailInformationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDeatailInformationLabel.Location = New System.Drawing.Point(0, 24)
        Me.TitleDeatailInformationLabel.Name = "TitleDeatailInformationLabel"
        Me.TitleDeatailInformationLabel.Size = New System.Drawing.Size(0, 13)
        Me.TitleDeatailInformationLabel.TabIndex = 1
        '
        'TitleDetailLabel
        '
        Me.TitleDetailLabel.AutoSize = True
        Me.TitleDetailLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleDetailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDetailLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleDetailLabel.Name = "TitleDetailLabel"
        Me.TitleDetailLabel.Size = New System.Drawing.Size(0, 24)
        Me.TitleDetailLabel.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirCajaToolStripMenuItem, Me.ArqueoDeCajaToolStripMenuItem, Me.HibernarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 10)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirCajaToolStripMenuItem
        '
        Me.AbrirCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AbrirCajaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Open_
        Me.AbrirCajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AbrirCajaToolStripMenuItem.Name = "AbrirCajaToolStripMenuItem"
        Me.AbrirCajaToolStripMenuItem.Size = New System.Drawing.Size(100, 6)
        Me.AbrirCajaToolStripMenuItem.Text = "Nuevo.."
        Me.AbrirCajaToolStripMenuItem.ToolTipText = "Habilitar nueva operación"
        '
        'ArqueoDeCajaToolStripMenuItem
        '
        Me.ArqueoDeCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ArqueoDeCajaToolStripMenuItem.Enabled = False
        Me.ArqueoDeCajaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Caja_regidter
        Me.ArqueoDeCajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArqueoDeCajaToolStripMenuItem.Name = "ArqueoDeCajaToolStripMenuItem"
        Me.ArqueoDeCajaToolStripMenuItem.Size = New System.Drawing.Size(98, 6)
        Me.ArqueoDeCajaToolStripMenuItem.Text = "Arqueo"
        Me.ArqueoDeCajaToolStripMenuItem.ToolTipText = "Arqueo de caja"
        '
        'HibernarToolStripMenuItem
        '
        Me.HibernarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HibernarToolStripMenuItem.Enabled = False
        Me.HibernarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Hiberna_x40
        Me.HibernarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HibernarToolStripMenuItem.Name = "HibernarToolStripMenuItem"
        Me.HibernarToolStripMenuItem.Size = New System.Drawing.Size(114, 6)
        Me.HibernarToolStripMenuItem.Text = "Suspender"
        Me.HibernarToolStripMenuItem.ToolTipText = "Suspender o hiberbar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Enabled = False
        Me.EliminarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_48
        Me.EliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(110, 6)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.printerMatricial_48
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(119, 6)
        Me.PrintToolStripMenuItem.Text = "Imprimir.."
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'FrmSaldo_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(671, 282)
        Me.Controls.Add(Me.PanelMaster)
        Me.Controls.Add(Me.PanelCajaDesck)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSaldo_caja"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.Text = "Saldo en caja."
        Me.PanelCajaDesck.ResumeLayout(False)
        Me.PanelCajaDesck.PerformLayout()
        Me.PanelMaster.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelDetail.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameCajaLabel As System.Windows.Forms.Label
    Friend WithEvents CajaNameLabel As System.Windows.Forms.Label
    Friend WithEvents PanelCajaDesck As System.Windows.Forms.Panel
    Friend WithEvents PanelMaster As System.Windows.Forms.Panel
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents TitleDeatailInformationLabel As Label
    Friend WithEvents TitleDetailLabel As Label
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArqueoDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaxiDetailButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HibernarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
