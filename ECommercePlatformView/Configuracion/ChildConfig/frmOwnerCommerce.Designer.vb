<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOwnerCommerce
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
        Me.PanelViewOwner = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IdPropietariosClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RucCIClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NamePersonClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NamePositionsClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelViewOwner.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelViewOwner
        '
        Me.PanelViewOwner.Controls.Add(Me.Panel2)
        Me.PanelViewOwner.Controls.Add(Me.Panel1)
        Me.PanelViewOwner.Controls.Add(Me.Panel4)
        Me.PanelViewOwner.Location = New System.Drawing.Point(12, 7)
        Me.PanelViewOwner.Name = "PanelViewOwner"
        Me.PanelViewOwner.Size = New System.Drawing.Size(690, 440)
        Me.PanelViewOwner.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(690, 350)
        Me.Panel2.TabIndex = 10
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPropietariosClm, Me.RucCIClm, Me.NamePersonClm, Me.PhoneClm, Me.EmailClm, Me.NamePositionsClm})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(684, 309)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'IdPropietariosClm
        '
        Me.IdPropietariosClm.Text = "codigo"
        '
        'RucCIClm
        '
        Me.RucCIClm.Text = "Ruc (o) C.I"
        Me.RucCIClm.Width = 100
        '
        'NamePersonClm
        '
        Me.NamePersonClm.Text = "Propietario"
        Me.NamePersonClm.Width = 250
        '
        'PhoneClm
        '
        Me.PhoneClm.Text = "Teléfono"
        Me.PhoneClm.Width = 80
        '
        'EmailClm
        '
        Me.EmailClm.Text = "Email"
        '
        'NamePositionsClm
        '
        Me.NamePositionsClm.Text = "Cargo"
        Me.NamePositionsClm.Width = 120
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DeleteButton)
        Me.Panel3.Controls.Add(Me.EditButton)
        Me.Panel3.Controls.Add(Me.AddNewButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(684, 35)
        Me.Panel3.TabIndex = 10
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.delete_Black_32
        Me.DeleteButton.Location = New System.Drawing.Point(104, 0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(52, 35)
        Me.DeleteButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Eliminar de la lista de propietarios.")
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditButton.Enabled = False
        Me.EditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_black_32
        Me.EditButton.Location = New System.Drawing.Point(52, 0)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(52, 35)
        Me.EditButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EditButton, "Modificar cargo")
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddNewButton
        '
        Me.AddNewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddNewButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewButton.Image = Global.ECommercePlatformView.My.Resources.Resources.add_circle_Black_32
        Me.AddNewButton.Location = New System.Drawing.Point(0, 0)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(52, 35)
        Me.AddNewButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.AddNewButton, "Agregar nuevo propietario")
        Me.AddNewButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(690, 46)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Propietarios (Accionistas)"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SaveButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 396)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(20, 2, 2, 2)
        Me.Panel4.Size = New System.Drawing.Size(690, 44)
        Me.Panel4.TabIndex = 11
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_White_32
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(20, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(349, 40)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "        Guardar.."
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'frmOwnerCommerce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 458)
        Me.Controls.Add(Me.PanelViewOwner)
        Me.Name = "frmOwnerCommerce"
        Me.Text = "frmChildOWnerCommerce"
        Me.PanelViewOwner.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelViewOwner As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddNewButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IdPropietariosClm As ColumnHeader
    Friend WithEvents RucCIClm As ColumnHeader
    Friend WithEvents NamePersonClm As ColumnHeader
    Friend WithEvents PhoneClm As ColumnHeader
    Friend WithEvents EmailClm As ColumnHeader
    Friend WithEvents NamePositionsClm As ColumnHeader
    Friend WithEvents ToolTip1 As ToolTip
End Class
