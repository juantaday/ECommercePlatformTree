<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventoriesExplorer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListProductComboBox = New System.Windows.Forms.ComboBox()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FindClienteButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.PanePie = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExplorarStockToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStockToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewListToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateListToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateOneProductToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PaneData = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.findFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelControl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanePie.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PaneData.SuspendLayout()
        Me.findFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(691, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto:"
        '
        'ListProductComboBox
        '
        Me.ListProductComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListProductComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListProductComboBox.FormattingEnabled = True
        Me.ListProductComboBox.Location = New System.Drawing.Point(691, 34)
        Me.ListProductComboBox.Margin = New System.Windows.Forms.Padding(5)
        Me.ListProductComboBox.Name = "ListProductComboBox"
        Me.ListProductComboBox.Size = New System.Drawing.Size(374, 24)
        Me.ListProductComboBox.TabIndex = 0
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelControl.Controls.Add(Me.PictureBox1)
        Me.PanelControl.Controls.Add(Me.FindClienteButton)
        Me.PanelControl.Controls.Add(Me.Label1)
        Me.PanelControl.Controls.Add(Me.ListProductComboBox)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1137, 82)
        Me.PanelControl.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.stock_Product_128
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 74)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FindClienteButton
        '
        Me.FindClienteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindClienteButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Product_Icon_64
        Me.FindClienteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindClienteButton.Location = New System.Drawing.Point(1073, 26)
        Me.FindClienteButton.Name = "FindClienteButton"
        Me.FindClienteButton.Size = New System.Drawing.Size(41, 39)
        Me.FindClienteButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.FindClienteButton, "Buscar producto")
        Me.FindClienteButton.UseVisualStyleBackColor = True
        '
        'FindButton
        '
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_icon_24
        Me.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindButton.Location = New System.Drawing.Point(0, 0)
        Me.FindButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(96, 30)
        Me.FindButton.TabIndex = 5
        Me.FindButton.Text = "Buscar"
        Me.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.FindButton, "Extraer informacion de venta..")
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'PanePie
        '
        Me.PanePie.Controls.Add(Me.MenuStrip1)
        Me.PanePie.Controls.Add(Me.CloseButton)
        Me.PanePie.Controls.Add(Me.TotalLabel)
        Me.PanePie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanePie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanePie.Location = New System.Drawing.Point(0, 272)
        Me.PanePie.Margin = New System.Windows.Forms.Padding(4)
        Me.PanePie.Name = "PanePie"
        Me.PanePie.Size = New System.Drawing.Size(1137, 27)
        Me.PanePie.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplorarStockToolStrip, Me.UpdateStockToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(397, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExplorarStockToolStrip
        '
        Me.ExplorarStockToolStrip.Image = Global.ECommercePlatformView.My.Resources.Resources.stock_Bodega_32
        Me.ExplorarStockToolStrip.Name = "ExplorarStockToolStrip"
        Me.ExplorarStockToolStrip.Size = New System.Drawing.Size(111, 20)
        Me.ExplorarStockToolStrip.Text = "Explorar stock."
        '
        'UpdateStockToolStrip
        '
        Me.UpdateStockToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewListToolStrip, Me.UpdateListToolStrip, Me.UpdateOneProductToolStrip})
        Me.UpdateStockToolStrip.Image = Global.ECommercePlatformView.My.Resources.Resources.update_reload_refresh_32
        Me.UpdateStockToolStrip.Name = "UpdateStockToolStrip"
        Me.UpdateStockToolStrip.Size = New System.Drawing.Size(121, 20)
        Me.UpdateStockToolStrip.Text = "Actualizar stock."
        '
        'NewListToolStrip
        '
        Me.NewListToolStrip.Image = Global.ECommercePlatformView.My.Resources.Resources.New_list65x65
        Me.NewListToolStrip.Name = "NewListToolStrip"
        Me.NewListToolStrip.Size = New System.Drawing.Size(268, 22)
        Me.NewListToolStrip.Text = "Crear nueva lista para actualizar."
        '
        'UpdateListToolStrip
        '
        Me.UpdateListToolStrip.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_list_32
        Me.UpdateListToolStrip.Name = "UpdateListToolStrip"
        Me.UpdateListToolStrip.Size = New System.Drawing.Size(268, 22)
        Me.UpdateListToolStrip.Text = "Modificar mediante listado existente."
        '
        'UpdateOneProductToolStrip
        '
        Me.UpdateOneProductToolStrip.Image = Global.ECommercePlatformView.My.Resources.Resources.Edit_32
        Me.UpdateOneProductToolStrip.Name = "UpdateOneProductToolStrip"
        Me.UpdateOneProductToolStrip.Size = New System.Drawing.Size(268, 22)
        Me.UpdateOneProductToolStrip.Text = "Modificar solo un producto."
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(1059, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(78, 27)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Cerrar"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TotalLabel
        '
        Me.TotalLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.Red
        Me.TotalLabel.Location = New System.Drawing.Point(0, 0)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(397, 27)
        Me.TotalLabel.TabIndex = 0
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaneData
        '
        Me.PaneData.BackColor = System.Drawing.Color.White
        Me.PaneData.Controls.Add(Me.PanelView)
        Me.PaneData.Controls.Add(Me.findFlowLayoutPanel)
        Me.PaneData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneData.Location = New System.Drawing.Point(0, 82)
        Me.PaneData.Name = "PaneData"
        Me.PaneData.Size = New System.Drawing.Size(1137, 190)
        Me.PaneData.TabIndex = 10
        '
        'PanelView
        '
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 33)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(1137, 157)
        Me.PanelView.TabIndex = 1
        '
        'findFlowLayoutPanel
        '
        Me.findFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.findFlowLayoutPanel.Controls.Add(Me.FindButton)
        Me.findFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.findFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.findFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.findFlowLayoutPanel.Name = "findFlowLayoutPanel"
        Me.findFlowLayoutPanel.Size = New System.Drawing.Size(1137, 33)
        Me.findFlowLayoutPanel.TabIndex = 0
        '
        'frmInventoriesExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 299)
        Me.Controls.Add(Me.PaneData)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanePie)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInventoriesExplorer"
        Me.Text = "frmStocProductos"
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanePie.ResumeLayout(False)
        Me.PanePie.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PaneData.ResumeLayout(False)
        Me.findFlowLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListProductComboBox As ComboBox
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FindClienteButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FindButton As Button
    Friend WithEvents PanePie As System.Windows.Forms.Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents PaneData As System.Windows.Forms.Panel
    Friend WithEvents findFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExplorarStockToolStrip As ToolStripMenuItem
    Friend WithEvents UpdateStockToolStrip As ToolStripMenuItem
    Friend WithEvents NewListToolStrip As ToolStripMenuItem
    Friend WithEvents UpdateListToolStrip As ToolStripMenuItem
    Friend WithEvents UpdateOneProductToolStrip As ToolStripMenuItem
End Class
