<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom_Grup = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dataGridGrupo = New System.Windows.Forms.DataGridView()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnElimi = New System.Windows.Forms.Button()
        Me.GrupList = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRestableceMenu = New System.Windows.Forms.Button()
        Me.txtIdPermiso = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.GropMunuList = New System.Windows.Forms.GroupBox()
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtIdUltimo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDenegar = New System.Windows.Forms.Button()
        Me.btnPermitir = New System.Windows.Forms.Button()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.txtIdGrupo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AccepButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.dataGridGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupList.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GropMunuList.SuspendLayout()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo:"
        '
        'txtNom_Grup
        '
        Me.txtNom_Grup.Enabled = False
        Me.txtNom_Grup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNom_Grup.Location = New System.Drawing.Point(68, 6)
        Me.txtNom_Grup.Name = "txtNom_Grup"
        Me.txtNom_Grup.Size = New System.Drawing.Size(294, 23)
        Me.txtNom_Grup.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevo.Location = New System.Drawing.Point(2, 21)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 31)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo.."
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCancela.Location = New System.Drawing.Point(2, 83)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(67, 31)
        Me.btnCancela.TabIndex = 5
        Me.btnCancela.Text = "Cancelar"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGuardar.Location = New System.Drawing.Point(2, 52)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 31)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar.."
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dataGridGrupo
        '
        Me.dataGridGrupo.AllowUserToAddRows = False
        Me.dataGridGrupo.AllowUserToDeleteRows = False
        Me.dataGridGrupo.AllowUserToOrderColumns = True
        Me.dataGridGrupo.AllowUserToResizeColumns = False
        Me.dataGridGrupo.AllowUserToResizeRows = False
        Me.dataGridGrupo.BackgroundColor = System.Drawing.Color.White
        Me.dataGridGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridGrupo.GridColor = System.Drawing.Color.White
        Me.dataGridGrupo.Location = New System.Drawing.Point(3, 59)
        Me.dataGridGrupo.MultiSelect = False
        Me.dataGridGrupo.Name = "dataGridGrupo"
        Me.dataGridGrupo.ReadOnly = True
        Me.dataGridGrupo.RowHeadersVisible = False
        Me.dataGridGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridGrupo.Size = New System.Drawing.Size(304, 258)
        Me.dataGridGrupo.TabIndex = 7
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnModif.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModif.Enabled = False
        Me.btnModif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnModif.Location = New System.Drawing.Point(87, 2)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(85, 35)
        Me.btnModif.TabIndex = 5
        Me.btnModif.Text = "Modificar.."
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnElimi
        '
        Me.btnElimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnElimi.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnElimi.Enabled = False
        Me.btnElimi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnElimi.Location = New System.Drawing.Point(2, 2)
        Me.btnElimi.Name = "btnElimi"
        Me.btnElimi.Size = New System.Drawing.Size(85, 35)
        Me.btnElimi.TabIndex = 5
        Me.btnElimi.Text = "Eliminar.."
        Me.btnElimi.UseVisualStyleBackColor = False
        '
        'GrupList
        '
        Me.GrupList.Controls.Add(Me.dataGridGrupo)
        Me.GrupList.Controls.Add(Me.Panel6)
        Me.GrupList.Controls.Add(Me.Panel5)
        Me.GrupList.Controls.Add(Me.Panel7)
        Me.GrupList.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrupList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GrupList.Location = New System.Drawing.Point(5, 26)
        Me.GrupList.Name = "GrupList"
        Me.GrupList.Size = New System.Drawing.Size(383, 361)
        Me.GrupList.TabIndex = 8
        Me.GrupList.TabStop = False
        Me.GrupList.Text = "Listado de grupos"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnCancela)
        Me.Panel6.Controls.Add(Me.btnGuardar)
        Me.Panel6.Controls.Add(Me.btnNuevo)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(307, 59)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel6.Size = New System.Drawing.Size(73, 258)
        Me.Panel6.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(67, 19)
        Me.Panel8.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnModif)
        Me.Panel5.Controls.Add(Me.btnElimi)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 317)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel5.Size = New System.Drawing.Size(377, 41)
        Me.Panel5.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.txtNom_Grup)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 17)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(377, 42)
        Me.Panel7.TabIndex = 10
        '
        'btnRestableceMenu
        '
        Me.btnRestableceMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnRestableceMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRestableceMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRestableceMenu.Location = New System.Drawing.Point(2, 2)
        Me.btnRestableceMenu.Name = "btnRestableceMenu"
        Me.btnRestableceMenu.Size = New System.Drawing.Size(189, 27)
        Me.btnRestableceMenu.TabIndex = 5
        Me.btnRestableceMenu.Text = "Copiar los Menus de este sistema"
        Me.btnRestableceMenu.UseVisualStyleBackColor = False
        '
        'txtIdPermiso
        '
        Me.txtIdPermiso.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtIdPermiso.Enabled = False
        Me.txtIdPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIdPermiso.Location = New System.Drawing.Point(684, 2)
        Me.txtIdPermiso.Name = "txtIdPermiso"
        Me.txtIdPermiso.Size = New System.Drawing.Size(61, 23)
        Me.txtIdPermiso.TabIndex = 3
        Me.txtIdPermiso.Text = "0"
        Me.txtIdPermiso.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEstado.Location = New System.Drawing.Point(745, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(61, 23)
        Me.txtEstado.TabIndex = 3
        Me.txtEstado.Text = "0"
        Me.txtEstado.Visible = False
        '
        'GropMunuList
        '
        Me.GropMunuList.Controls.Add(Me.DataGridMenu)
        Me.GropMunuList.Controls.Add(Me.Panel3)
        Me.GropMunuList.Controls.Add(Me.Panel2)
        Me.GropMunuList.Dock = System.Windows.Forms.DockStyle.Right
        Me.GropMunuList.Location = New System.Drawing.Point(407, 26)
        Me.GropMunuList.Name = "GropMunuList"
        Me.GropMunuList.Size = New System.Drawing.Size(406, 361)
        Me.GropMunuList.TabIndex = 8
        Me.GropMunuList.TabStop = False
        Me.GropMunuList.Text = "Listado de Menu en el sistema"
        '
        'DataGridMenu
        '
        Me.DataGridMenu.AllowUserToAddRows = False
        Me.DataGridMenu.AllowUserToDeleteRows = False
        Me.DataGridMenu.AllowUserToResizeColumns = False
        Me.DataGridMenu.AllowUserToResizeRows = False
        Me.DataGridMenu.BackgroundColor = System.Drawing.Color.White
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridMenu.GridColor = System.Drawing.Color.White
        Me.DataGridMenu.Location = New System.Drawing.Point(3, 49)
        Me.DataGridMenu.MultiSelect = False
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.ReadOnly = True
        Me.DataGridMenu.RowHeadersVisible = False
        Me.DataGridMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMenu.Size = New System.Drawing.Size(400, 266)
        Me.DataGridMenu.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtIdUltimo)
        Me.Panel3.Controls.Add(Me.btnRestableceMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(400, 33)
        Me.Panel3.TabIndex = 10
        '
        'txtIdUltimo
        '
        Me.txtIdUltimo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtIdUltimo.Enabled = False
        Me.txtIdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIdUltimo.Location = New System.Drawing.Point(191, 2)
        Me.txtIdUltimo.Name = "txtIdUltimo"
        Me.txtIdUltimo.Size = New System.Drawing.Size(61, 23)
        Me.txtIdUltimo.TabIndex = 3
        Me.txtIdUltimo.Text = "0"
        Me.txtIdUltimo.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnDenegar)
        Me.Panel2.Controls.Add(Me.btnPermitir)
        Me.Panel2.Controls.Add(Me.btnAplicar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 315)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(400, 43)
        Me.Panel2.TabIndex = 9
        '
        'btnDenegar
        '
        Me.btnDenegar.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnDenegar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDenegar.Enabled = False
        Me.btnDenegar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnDenegar.Location = New System.Drawing.Point(140, 2)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(104, 37)
        Me.btnDenegar.TabIndex = 5
        Me.btnDenegar.Text = "Denegar todo"
        Me.btnDenegar.UseVisualStyleBackColor = False
        '
        'btnPermitir
        '
        Me.btnPermitir.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnPermitir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPermitir.Enabled = False
        Me.btnPermitir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnPermitir.Location = New System.Drawing.Point(244, 2)
        Me.btnPermitir.Name = "btnPermitir"
        Me.btnPermitir.Size = New System.Drawing.Size(83, 37)
        Me.btnPermitir.TabIndex = 5
        Me.btnPermitir.Text = "Permitir todo"
        Me.btnPermitir.UseVisualStyleBackColor = False
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnAplicar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAplicar.Location = New System.Drawing.Point(327, 2)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(69, 37)
        Me.btnAplicar.TabIndex = 8
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtIdGrupo.Enabled = False
        Me.txtIdGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIdGrupo.Location = New System.Drawing.Point(623, 2)
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(61, 23)
        Me.txtIdGrupo.TabIndex = 3
        Me.txtIdGrupo.Text = "0"
        Me.txtIdGrupo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AccepButton)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(5, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 38)
        Me.Panel1.TabIndex = 9
        '
        'AccepButton
        '
        Me.AccepButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.AccepButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AccepButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccepButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.AccepButton.Location = New System.Drawing.Point(572, 0)
        Me.AccepButton.Name = "AccepButton"
        Me.AccepButton.Size = New System.Drawing.Size(117, 36)
        Me.AccepButton.TabIndex = 1
        Me.AccepButton.Text = "Aceptar"
        Me.AccepButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(689, 0)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(117, 36)
        Me.CancelButton.TabIndex = 0
        Me.CancelButton.Text = "Cancelar"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtIdGrupo)
        Me.Panel4.Controls.Add(Me.txtIdPermiso)
        Me.Panel4.Controls.Add(Me.txtEstado)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel4.Size = New System.Drawing.Size(808, 21)
        Me.Panel4.TabIndex = 10
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(818, 430)
        Me.Controls.Add(Me.GropMunuList)
        Me.Controls.Add(Me.GrupList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPermisos"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Administrando Permisos  para grupos.."
        CType(Me.dataGridGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupList.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GropMunuList.ResumeLayout(False)
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom_Grup As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dataGridGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents btnElimi As System.Windows.Forms.Button
    Friend WithEvents GrupList As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdPermiso As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnRestableceMenu As System.Windows.Forms.Button
    Friend WithEvents GropMunuList As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridMenu As System.Windows.Forms.DataGridView
    Friend WithEvents btnDenegar As System.Windows.Forms.Button
    Friend WithEvents btnPermitir As System.Windows.Forms.Button
    Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdUltimo As System.Windows.Forms.TextBox
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AccepButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Panel4 As Panel
End Class
