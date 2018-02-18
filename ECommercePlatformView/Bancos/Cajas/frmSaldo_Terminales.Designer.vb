<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaldo_Terminales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.TotalSaldoLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArqueoDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HibernarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MivimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dtg)
        Me.Panel1.Controls.Add(Me.TotalSaldoLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(559, 152)
        Me.Panel1.TabIndex = 0
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(5, 25)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(549, 122)
        Me.dtg.TabIndex = 1
        '
        'TotalSaldoLabel
        '
        Me.TotalSaldoLabel.AutoSize = True
        Me.TotalSaldoLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TotalSaldoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSaldoLabel.Location = New System.Drawing.Point(5, 5)
        Me.TotalSaldoLabel.Name = "TotalSaldoLabel"
        Me.TotalSaldoLabel.Size = New System.Drawing.Size(165, 20)
        Me.TotalSaldoLabel.TabIndex = 0
        Me.TotalSaldoLabel.Text = "Saldo en terminales...."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirCajaToolStripMenuItem, Me.ArqueoDeCajaToolStripMenuItem, Me.HibernarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.MivimientosToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 17)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirCajaToolStripMenuItem
        '
        Me.AbrirCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AbrirCajaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Details_24
        Me.AbrirCajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AbrirCajaToolStripMenuItem.Name = "AbrirCajaToolStripMenuItem"
        Me.AbrirCajaToolStripMenuItem.Size = New System.Drawing.Size(82, 13)
        Me.AbrirCajaToolStripMenuItem.Text = " Detalle"
        Me.AbrirCajaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AbrirCajaToolStripMenuItem.ToolTipText = "Habilitar nueva operación"
        '
        'ArqueoDeCajaToolStripMenuItem
        '
        Me.ArqueoDeCajaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ArqueoDeCajaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Cash_Counter_32
        Me.ArqueoDeCajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArqueoDeCajaToolStripMenuItem.Name = "ArqueoDeCajaToolStripMenuItem"
        Me.ArqueoDeCajaToolStripMenuItem.Size = New System.Drawing.Size(93, 13)
        Me.ArqueoDeCajaToolStripMenuItem.Text = "Arquear"
        Me.ArqueoDeCajaToolStripMenuItem.ToolTipText = "Arqueo de caja"
        '
        'HibernarToolStripMenuItem
        '
        Me.HibernarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HibernarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Power_32
        Me.HibernarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HibernarToolStripMenuItem.Name = "HibernarToolStripMenuItem"
        Me.HibernarToolStripMenuItem.Size = New System.Drawing.Size(106, 13)
        Me.HibernarToolStripMenuItem.Text = "Suspender"
        Me.HibernarToolStripMenuItem.ToolTipText = "Suspender o hiberbar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.EliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(94, 13)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'MivimientosToolStripMenuItem
        '
        Me.MivimientosToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Atm_32
        Me.MivimientosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MivimientosToolStripMenuItem.Name = "MivimientosToolStripMenuItem"
        Me.MivimientosToolStripMenuItem.Size = New System.Drawing.Size(125, 13)
        Me.MivimientosToolStripMenuItem.Text = "Transacciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 13)
        '
        'frmSaldo_Terminales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 176)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmSaldo_Terminales"
        Me.Text = "Saldo en terminales...."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtg As DataGridView
    Friend WithEvents TotalSaldoLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArqueoDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HibernarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MivimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
