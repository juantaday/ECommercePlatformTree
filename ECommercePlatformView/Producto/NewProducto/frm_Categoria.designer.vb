<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Categoria
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
        Me.txtNameCategoria = New System.Windows.Forms.TextBox()
        Me.btnAcepCategoria = New System.Windows.Forms.Button()
        Me.btnCancelCategory = New System.Windows.Forms.Button()
        Me.SiguientButton = New System.Windows.Forms.Button()
        Me.TreeViewCatgoria = New System.Windows.Forms.TreeView()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.MenuStripCatego = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.lblnodes = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PanelMenuAdd = New System.Windows.Forms.Panel()
        Me.PanelDesciption = New System.Windows.Forms.Panel()
        Me.PanelComannSelect = New System.Windows.Forms.Panel()
        Me.lblNodes2 = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.PanelExpantTreeView = New System.Windows.Forms.Panel()
        Me.ExpantButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStripCatego.SuspendLayout()
        Me.PanelMenuAdd.SuspendLayout()
        Me.PanelDesciption.SuspendLayout()
        Me.PanelComannSelect.SuspendLayout()
        Me.PanelExpantTreeView.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNameCategoria
        '
        Me.txtNameCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameCategoria.Location = New System.Drawing.Point(12, 11)
        Me.txtNameCategoria.Name = "txtNameCategoria"
        Me.txtNameCategoria.Size = New System.Drawing.Size(417, 22)
        Me.txtNameCategoria.TabIndex = 0
        Me.txtNameCategoria.Visible = False
        '
        'btnAcepCategoria
        '
        Me.btnAcepCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcepCategoria.Location = New System.Drawing.Point(465, 10)
        Me.btnAcepCategoria.Name = "btnAcepCategoria"
        Me.btnAcepCategoria.Size = New System.Drawing.Size(77, 24)
        Me.btnAcepCategoria.TabIndex = 1
        Me.btnAcepCategoria.Text = "&Aceptar"
        Me.btnAcepCategoria.UseVisualStyleBackColor = True
        Me.btnAcepCategoria.Visible = False
        '
        'btnCancelCategory
        '
        Me.btnCancelCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCategory.Location = New System.Drawing.Point(541, 10)
        Me.btnCancelCategory.Name = "btnCancelCategory"
        Me.btnCancelCategory.Size = New System.Drawing.Size(77, 24)
        Me.btnCancelCategory.TabIndex = 1
        Me.btnCancelCategory.Text = "&Canelar"
        Me.btnCancelCategory.UseVisualStyleBackColor = True
        Me.btnCancelCategory.Visible = False
        '
        'SiguientButton
        '
        Me.SiguientButton.AccessibleDescription = ""
        Me.SiguientButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiguientButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SiguientButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SiguientButton.Location = New System.Drawing.Point(159, 314)
        Me.SiguientButton.Name = "SiguientButton"
        Me.SiguientButton.Size = New System.Drawing.Size(0, 0)
        Me.SiguientButton.TabIndex = 41
        Me.SiguientButton.Text = "Sigiente ==>>"
        Me.SiguientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SiguientButton.UseVisualStyleBackColor = True
        Me.SiguientButton.Visible = False
        '
        'TreeViewCatgoria
        '
        Me.TreeViewCatgoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewCatgoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewCatgoria.FullRowSelect = True
        Me.TreeViewCatgoria.HideSelection = False
        Me.TreeViewCatgoria.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewCatgoria.Name = "TreeViewCatgoria"
        Me.TreeViewCatgoria.ShowNodeToolTips = True
        Me.TreeViewCatgoria.Size = New System.Drawing.Size(642, 190)
        Me.TreeViewCatgoria.TabIndex = 0
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'MenuStripCatego
        '
        Me.MenuStripCatego.AutoSize = False
        Me.MenuStripCatego.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStripCatego.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuStripCatego.Location = New System.Drawing.Point(0, 337)
        Me.MenuStripCatego.Name = "MenuStripCatego"
        Me.MenuStripCatego.Size = New System.Drawing.Size(642, 27)
        Me.MenuStripCatego.TabIndex = 9
        Me.MenuStripCatego.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.SubCategoríaToolStripMenuItem})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 23)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoría"
        '
        'SubCategoríaToolStripMenuItem
        '
        Me.SubCategoríaToolStripMenuItem.Name = "SubCategoríaToolStripMenuItem"
        Me.SubCategoríaToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SubCategoríaToolStripMenuItem.Text = "Sub categoría"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 23)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(163, 171)
        '
        'lblnodes
        '
        Me.lblnodes.AutoSize = True
        Me.lblnodes.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblnodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnodes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblnodes.Location = New System.Drawing.Point(5, 5)
        Me.lblnodes.Name = "lblnodes"
        Me.lblnodes.Size = New System.Drawing.Size(49, 16)
        Me.lblnodes.TabIndex = 42
        Me.lblnodes.Text = "Label1"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(5, 5)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(0, 16)
        Me.lblCategoria.TabIndex = 43
        Me.lblCategoria.Visible = False
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(13, 309)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(0, 0)
        Me.SaveButton.TabIndex = 44
        Me.SaveButton.Text = "Button1"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'PanelMenuAdd
        '
        Me.PanelMenuAdd.Controls.Add(Me.txtNameCategoria)
        Me.PanelMenuAdd.Controls.Add(Me.btnCancelCategory)
        Me.PanelMenuAdd.Controls.Add(Me.btnAcepCategoria)
        Me.PanelMenuAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuAdd.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuAdd.Name = "PanelMenuAdd"
        Me.PanelMenuAdd.Size = New System.Drawing.Size(642, 44)
        Me.PanelMenuAdd.TabIndex = 45
        '
        'PanelDesciption
        '
        Me.PanelDesciption.Controls.Add(Me.lblnodes)
        Me.PanelDesciption.Controls.Add(Me.lblCategoria)
        Me.PanelDesciption.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDesciption.Location = New System.Drawing.Point(0, 269)
        Me.PanelDesciption.Name = "PanelDesciption"
        Me.PanelDesciption.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelDesciption.Size = New System.Drawing.Size(642, 25)
        Me.PanelDesciption.TabIndex = 46
        '
        'PanelComannSelect
        '
        Me.PanelComannSelect.Controls.Add(Me.lblNodes2)
        Me.PanelComannSelect.Controls.Add(Me.okButton)
        Me.PanelComannSelect.Controls.Add(Me.closeButton)
        Me.PanelComannSelect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelComannSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelComannSelect.Location = New System.Drawing.Point(0, 294)
        Me.PanelComannSelect.Name = "PanelComannSelect"
        Me.PanelComannSelect.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelComannSelect.Size = New System.Drawing.Size(642, 43)
        Me.PanelComannSelect.TabIndex = 47
        '
        'lblNodes2
        '
        Me.lblNodes2.AutoSize = True
        Me.lblNodes2.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblNodes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNodes2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNodes2.Location = New System.Drawing.Point(5, 5)
        Me.lblNodes2.Name = "lblNodes2"
        Me.lblNodes2.Size = New System.Drawing.Size(0, 16)
        Me.lblNodes2.TabIndex = 43
        '
        'okButton
        '
        Me.okButton.BackColor = System.Drawing.Color.Black
        Me.okButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.okButton.ForeColor = System.Drawing.Color.White
        Me.okButton.Location = New System.Drawing.Point(412, 5)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(116, 33)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "Seleccionar.."
        Me.okButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Black
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(528, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(109, 33)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar"
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'PanelExpantTreeView
        '
        Me.PanelExpantTreeView.Controls.Add(Me.ExpantButton)
        Me.PanelExpantTreeView.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelExpantTreeView.Location = New System.Drawing.Point(0, 44)
        Me.PanelExpantTreeView.Name = "PanelExpantTreeView"
        Me.PanelExpantTreeView.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.PanelExpantTreeView.Size = New System.Drawing.Size(642, 35)
        Me.PanelExpantTreeView.TabIndex = 49
        '
        'ExpantButton
        '
        Me.ExpantButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpantButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Expant_Treeview_24
        Me.ExpantButton.Location = New System.Drawing.Point(8, 3)
        Me.ExpantButton.Name = "ExpantButton"
        Me.ExpantButton.Size = New System.Drawing.Size(29, 29)
        Me.ExpantButton.TabIndex = 0
        Me.ExpantButton.Tag = "0"
        Me.ExpantButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TreeViewCatgoria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(642, 190)
        Me.Panel2.TabIndex = 0
        '
        'frm_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 364)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelExpantTreeView)
        Me.Controls.Add(Me.PanelDesciption)
        Me.Controls.Add(Me.PanelComannSelect)
        Me.Controls.Add(Me.PanelMenuAdd)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.SiguientButton)
        Me.Controls.Add(Me.MenuStripCatego)
        Me.MainMenuStrip = Me.MenuStripCatego
        Me.Name = "frm_Categoria"
        Me.Text = "  CATEGORIA  "
        Me.MenuStripCatego.ResumeLayout(False)
        Me.MenuStripCatego.PerformLayout()
        Me.PanelMenuAdd.ResumeLayout(False)
        Me.PanelMenuAdd.PerformLayout()
        Me.PanelDesciption.ResumeLayout(False)
        Me.PanelDesciption.PerformLayout()
        Me.PanelComannSelect.ResumeLayout(False)
        Me.PanelComannSelect.PerformLayout()
        Me.PanelExpantTreeView.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNameCategoria As System.Windows.Forms.TextBox
    Friend WithEvents btnAcepCategoria As System.Windows.Forms.Button
    Friend WithEvents btnCancelCategory As System.Windows.Forms.Button
    Friend WithEvents SiguientButton As System.Windows.Forms.Button
    Friend WithEvents TreeViewCatgoria As System.Windows.Forms.TreeView
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents MenuStripCatego As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCategoríaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents lblnodes As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents PanelMenuAdd As Panel
    Friend WithEvents PanelDesciption As Panel
    Friend WithEvents PanelComannSelect As Panel
    Friend WithEvents okButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents lblNodes2 As Label
    Friend WithEvents PanelExpantTreeView As Panel
    Friend WithEvents ExpantButton As Button
    Friend WithEvents Panel2 As Panel
End Class
