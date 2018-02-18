<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_ProductoComprable
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.PiePanel = New System.Windows.Forms.Panel()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.AcepButton = New System.Windows.Forms.Button()
        Me._CancelButton = New System.Windows.Forms.Button()
        Me.BuscarPanel = New System.Windows.Forms.Panel()
        Me.DetailButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.MenuPanel.SuspendLayout()
        Me.PiePanel.SuspendLayout()
        Me.BuscarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.Label1)
        Me.MenuPanel.Controls.Add(Me.FindTextBox)
        Me.MenuPanel.Controls.Add(Me.FindButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(800, 56)
        Me.MenuPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar producto:"
        '
        'FindTextBox
        '
        Me.FindTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindTextBox.Location = New System.Drawing.Point(393, 13)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(352, 26)
        Me.FindTextBox.TabIndex = 0
        '
        'FindButton
        '
        Me.FindButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_green_48icon
        Me.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindButton.Location = New System.Drawing.Point(756, 11)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(33, 31)
        Me.FindButton.TabIndex = 1
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'PiePanel
        '
        Me.PiePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PiePanel.Controls.Add(Me.TotalLabel)
        Me.PiePanel.Controls.Add(Me.AcepButton)
        Me.PiePanel.Controls.Add(Me.CancelButton)
        Me.PiePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PiePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PiePanel.Location = New System.Drawing.Point(0, 412)
        Me.PiePanel.Name = "PiePanel"
        Me.PiePanel.Size = New System.Drawing.Size(800, 39)
        Me.PiePanel.TabIndex = 1
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(11, 9)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 20)
        Me.TotalLabel.TabIndex = 2
        '
        'AcepButton
        '
        Me.AcepButton.BackColor = System.Drawing.Color.Black
        Me.AcepButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AcepButton.ForeColor = System.Drawing.Color.White
        Me.AcepButton.Location = New System.Drawing.Point(566, 0)
        Me.AcepButton.Name = "AcepButton"
        Me.AcepButton.Size = New System.Drawing.Size(116, 37)
        Me.AcepButton.TabIndex = 1
        Me.AcepButton.Text = "Seleccionar"
        Me.AcepButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me._CancelButton.BackColor = System.Drawing.Color.Black
        Me._CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me._CancelButton.ForeColor = System.Drawing.Color.White
        Me._CancelButton.Location = New System.Drawing.Point(682, 0)
        Me._CancelButton.Name = "CancelButton"
        Me._CancelButton.Size = New System.Drawing.Size(116, 37)
        Me._CancelButton.TabIndex = 0
        Me._CancelButton.Text = "Cancelar"
        Me._CancelButton.UseVisualStyleBackColor = False
        '
        'BuscarPanel
        '
        Me.BuscarPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.BuscarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BuscarPanel.Controls.Add(Me.DetailButton)
        Me.BuscarPanel.Controls.Add(Me.DeleteButton)
        Me.BuscarPanel.Controls.Add(Me.EditButton)
        Me.BuscarPanel.Controls.Add(Me.NewButton)
        Me.BuscarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BuscarPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarPanel.Location = New System.Drawing.Point(0, 56)
        Me.BuscarPanel.Name = "BuscarPanel"
        Me.BuscarPanel.Size = New System.Drawing.Size(800, 38)
        Me.BuscarPanel.TabIndex = 2
        '
        'DetailButton
        '
        Me.DetailButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DetailButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Detail_32
        Me.DetailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DetailButton.Location = New System.Drawing.Point(254, 0)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(98, 36)
        Me.DetailButton.TabIndex = 3
        Me.DetailButton.Text = "Detalle"
        Me.DetailButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.DetailButton, "Agregar nuevo producto..")
        Me.DetailButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Action_Delete_16x16
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(169, 0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(85, 36)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Eliminar"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Agregar nuevo producto..")
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(78, 0)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(91, 36)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Modificar"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.EditButton, "Agregar nuevo producto..")
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton.Location = New System.Drawing.Point(0, 0)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(78, 36)
        Me.NewButton.TabIndex = 0
        Me.NewButton.Text = "Nuevo"
        Me.NewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.NewButton, "Agregar nuevo producto..")
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'PanelView
        '
        Me.PanelView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 94)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(800, 318)
        Me.PanelView.TabIndex = 3
        '
        'frmList_ProductoComprable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.BuscarPanel)
        Me.Controls.Add(Me.PiePanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Name = "frmList_ProductoComprable"
        Me.Text = "   Lista de productos.."
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.PiePanel.ResumeLayout(False)
        Me.PiePanel.PerformLayout()
        Me.BuscarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FindTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents PiePanel As System.Windows.Forms.Panel
    Friend WithEvents AcepButton As System.Windows.Forms.Button
    Friend WithEvents _CancelButton As System.Windows.Forms.Button
    Friend WithEvents BuscarPanel As System.Windows.Forms.Panel
    Friend WithEvents DetailButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
End Class
