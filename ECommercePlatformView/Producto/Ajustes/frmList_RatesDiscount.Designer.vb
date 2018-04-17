<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_RatesDiscount
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.DeleteTaresButton = New System.Windows.Forms.Button()
        Me.EditTypeButton = New System.Windows.Forms.Button()
        Me.EditRatesButton = New System.Windows.Forms.Button()
        Me.AddNewListButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuAdd_new = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TotalItemLabel = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.ContextMenuAdd_new.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.PrintButton)
        Me.Panel6.Controls.Add(Me.DeleteTaresButton)
        Me.Panel6.Controls.Add(Me.EditTypeButton)
        Me.Panel6.Controls.Add(Me.EditRatesButton)
        Me.Panel6.Controls.Add(Me.AddNewListButton)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 24)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(800, 52)
        Me.Panel6.TabIndex = 4
        '
        'PrintButton
        '
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.Location = New System.Drawing.Point(729, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(127, 40)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "Imprimir lista"
        Me.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'DeleteTaresButton
        '
        Me.DeleteTaresButton.AutoSize = True
        Me.DeleteTaresButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteTaresButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.DeleteTaresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteTaresButton.Location = New System.Drawing.Point(594, 5)
        Me.DeleteTaresButton.Name = "DeleteTaresButton"
        Me.DeleteTaresButton.Size = New System.Drawing.Size(135, 40)
        Me.DeleteTaresButton.TabIndex = 4
        Me.DeleteTaresButton.Text = "Eliminar tarifa"
        Me.DeleteTaresButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteTaresButton.UseVisualStyleBackColor = True
        '
        'EditTypeButton
        '
        Me.EditTypeButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditTypeButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Edit
        Me.EditTypeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditTypeButton.Location = New System.Drawing.Point(385, 5)
        Me.EditTypeButton.Name = "EditTypeButton"
        Me.EditTypeButton.Size = New System.Drawing.Size(209, 40)
        Me.EditTypeButton.TabIndex = 6
        Me.EditTypeButton.Text = "Modificar tipo de tarifa."
        Me.EditTypeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditTypeButton.UseVisualStyleBackColor = True
        '
        'EditRatesButton
        '
        Me.EditRatesButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditRatesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edid_pencil_32
        Me.EditRatesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditRatesButton.Location = New System.Drawing.Point(233, 5)
        Me.EditRatesButton.Name = "EditRatesButton"
        Me.EditRatesButton.Size = New System.Drawing.Size(152, 40)
        Me.EditRatesButton.TabIndex = 2
        Me.EditRatesButton.Text = "Modificar detalle."
        Me.EditRatesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditRatesButton.UseVisualStyleBackColor = True
        '
        'AddNewListButton
        '
        Me.AddNewListButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.AddNewListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewListButton.Location = New System.Drawing.Point(124, 5)
        Me.AddNewListButton.Name = "AddNewListButton"
        Me.AddNewListButton.Size = New System.Drawing.Size(109, 40)
        Me.AddNewListButton.TabIndex = 5
        Me.AddNewListButton.Text = "Agregar.."
        Me.AddNewListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewListButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = Global.ECommercePlatformView.My.Resources.Resources.Update_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Actualizar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuAdd_new
        '
        Me.ContextMenuAdd_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriaToolStripMenuItem, Me.SubCategoryToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.PresentToolStripMenuItem})
        Me.ContextMenuAdd_new.Name = "ContextMenuAdd_new"
        Me.ContextMenuAdd_new.Size = New System.Drawing.Size(236, 122)
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Category_TreeView24
        Me.CategoriaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(235, 28)
        Me.CategoriaToolStripMenuItem.Text = "Basado en categoría."
        '
        'SubCategoryToolStripMenuItem
        '
        Me.SubCategoryToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Expant_Treeview_Black_24
        Me.SubCategoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SubCategoryToolStripMenuItem.Name = "SubCategoryToolStripMenuItem"
        Me.SubCategoryToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.SubCategoryToolStripMenuItem.Text = "Basado en sub categoría."
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.producto_24
        Me.ProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.ProductoToolStripMenuItem.Text = "Basado en cada producto."
        '
        'PresentToolStripMenuItem
        '
        Me.PresentToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Present_24
        Me.PresentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PresentToolStripMenuItem.Name = "PresentToolStripMenuItem"
        Me.PresentToolStripMenuItem.Size = New System.Drawing.Size(235, 30)
        Me.PresentToolStripMenuItem.Text = "Basado en cada presentación"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.closeButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 328)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(800, 40)
        Me.Panel3.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.Controls.Add(Me.TotalItemLabel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(61, 30)
        Me.Panel7.TabIndex = 1
        '
        'TotalItemLabel
        '
        Me.TotalItemLabel.AutoSize = True
        Me.TotalItemLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemLabel.Location = New System.Drawing.Point(2, 2)
        Me.TotalItemLabel.Name = "TotalItemLabel"
        Me.TotalItemLabel.Size = New System.Drawing.Size(57, 17)
        Me.TotalItemLabel.TabIndex = 2
        Me.TotalItemLabel.Text = "Label2"
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Black
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(707, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(88, 30)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar."
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(800, 252)
        Me.Panel1.TabIndex = 0
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(10, 10)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(780, 232)
        Me.dtg.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tarifas de descuentos aplicables para ventas."
        '
        'frmList_RatesDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 368)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmList_RatesDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas de descuentos...."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ContextMenuAdd_new.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents DeleteTaresButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents EditRatesButton As Button
    Friend WithEvents AddNewListButton As Button
    Friend WithEvents ContextMenuAdd_new As ContextMenuStrip
    Friend WithEvents SubCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TotalItemLabel As Label
    Friend WithEvents closeButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents EditTypeButton As Button
    Friend WithEvents Button1 As Button
End Class
