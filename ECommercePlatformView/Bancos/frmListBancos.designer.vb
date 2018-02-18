<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListBancos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNom_Persona = New System.Windows.Forms.Label()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.deleteBancosButton = New System.Windows.Forms.Button()
        Me.EditBancosButton = New System.Windows.Forms.Button()
        Me.addBancosButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.txtNom_Persona)
        Me.Panel2.Controls.Add(Me.Ok_Button)
        Me.Panel2.Controls.Add(Me.cancel_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 313)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 38)
        Me.Panel2.TabIndex = 4
        '
        'txtNom_Persona
        '
        Me.txtNom_Persona.AutoSize = True
        Me.txtNom_Persona.Location = New System.Drawing.Point(14, 16)
        Me.txtNom_Persona.Name = "txtNom_Persona"
        Me.txtNom_Persona.Size = New System.Drawing.Size(39, 13)
        Me.txtNom_Persona.TabIndex = 2
        Me.txtNom_Persona.Text = "Label1"
        Me.txtNom_Persona.Visible = False
        '
        'Ok_Button
        '
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.Location = New System.Drawing.Point(347, 0)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(115, 38)
        Me.Ok_Button.TabIndex = 1
        Me.Ok_Button.Text = "Aceptar"
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'cancel_Button
        '
        Me.cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancel_Button.Location = New System.Drawing.Point(462, 0)
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(115, 38)
        Me.cancel_Button.TabIndex = 0
        Me.cancel_Button.Text = "Cancelar"
        Me.cancel_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.deleteBancosButton)
        Me.Panel1.Controls.Add(Me.EditBancosButton)
        Me.Panel1.Controls.Add(Me.addBancosButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 42)
        Me.Panel1.TabIndex = 5
        '
        'deleteBancosButton
        '
        Me.deleteBancosButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.deleteBancosButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.deleteBancosButton.Location = New System.Drawing.Point(261, 0)
        Me.deleteBancosButton.Name = "deleteBancosButton"
        Me.deleteBancosButton.Size = New System.Drawing.Size(44, 40)
        Me.deleteBancosButton.TabIndex = 2
        Me.deleteBancosButton.UseVisualStyleBackColor = True
        '
        'EditBancosButton
        '
        Me.EditBancosButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditBancosButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edid_pencil_32
        Me.EditBancosButton.Location = New System.Drawing.Point(217, 0)
        Me.EditBancosButton.Name = "EditBancosButton"
        Me.EditBancosButton.Size = New System.Drawing.Size(44, 40)
        Me.EditBancosButton.TabIndex = 1
        Me.EditBancosButton.UseVisualStyleBackColor = True
        '
        'addBancosButton
        '
        Me.addBancosButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.addBancosButton.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.addBancosButton.Location = New System.Drawing.Point(173, 0)
        Me.addBancosButton.Name = "addBancosButton"
        Me.addBancosButton.Size = New System.Drawing.Size(44, 40)
        Me.addBancosButton.TabIndex = 0
        Me.addBancosButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de bancos.."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(577, 271)
        Me.DataGridView1.TabIndex = 6
        '
        'frmListBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 351)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Administrando Bancos..."
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Ok_Button As Button
    Friend WithEvents cancel_Button As Button
    Friend WithEvents txtNom_Persona As Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents deleteBancosButton As Button
    Friend WithEvents EditBancosButton As Button
    Friend WithEvents addBancosButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
