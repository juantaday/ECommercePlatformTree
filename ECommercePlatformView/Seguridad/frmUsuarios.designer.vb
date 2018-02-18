<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.btnModifUser = New System.Windows.Forms.Button()
        Me.btnAgreUser = New System.Windows.Forms.Button()
        Me.btnDeletUser = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dataGridGrupo = New System.Windows.Forms.DataGridView()
        Me.dataGridUser = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblnoExiste = New System.Windows.Forms.Label()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.btnOptAvanzado = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtlogin = New System.Windows.Forms.TextBox()
        Me.txtUltimoLogin = New System.Windows.Forms.TextBox()
        Me.Notificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.especialPerminButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.clearPasswordButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.oKButton = New System.Windows.Forms.Button()
        Me.acncelButton = New System.Windows.Forms.Button()
        CType(Me.dataGridGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModifUser
        '
        Me.btnModifUser.BackColor = System.Drawing.Color.SkyBlue
        Me.btnModifUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModifUser.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_24
        Me.btnModifUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifUser.Location = New System.Drawing.Point(182, 0)
        Me.btnModifUser.Name = "btnModifUser"
        Me.btnModifUser.Size = New System.Drawing.Size(84, 37)
        Me.btnModifUser.TabIndex = 10
        Me.btnModifUser.Text = "Mofificar"
        Me.btnModifUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModifUser.UseVisualStyleBackColor = False
        '
        'btnAgreUser
        '
        Me.btnAgreUser.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAgreUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgreUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAgreUser.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.btnAgreUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgreUser.Location = New System.Drawing.Point(0, 0)
        Me.btnAgreUser.Name = "btnAgreUser"
        Me.btnAgreUser.Size = New System.Drawing.Size(100, 37)
        Me.btnAgreUser.TabIndex = 11
        Me.btnAgreUser.Text = "Agregar"
        Me.btnAgreUser.UseVisualStyleBackColor = False
        '
        'btnDeletUser
        '
        Me.btnDeletUser.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDeletUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeletUser.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.btnDeletUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeletUser.Location = New System.Drawing.Point(100, 0)
        Me.btnDeletUser.Name = "btnDeletUser"
        Me.btnDeletUser.Size = New System.Drawing.Size(82, 37)
        Me.btnDeletUser.TabIndex = 12
        Me.btnDeletUser.Text = "Quitar"
        Me.btnDeletUser.UseVisualStyleBackColor = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 14)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(80, 13)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Buscar usuario:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(98, 10)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 23)
        Me.txtBuscar.TabIndex = 7
        '
        'dataGridGrupo
        '
        Me.dataGridGrupo.AllowUserToAddRows = False
        Me.dataGridGrupo.AllowUserToDeleteRows = False
        Me.dataGridGrupo.AllowUserToResizeColumns = False
        Me.dataGridGrupo.AllowUserToResizeRows = False
        Me.dataGridGrupo.BackgroundColor = System.Drawing.Color.White
        Me.dataGridGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridGrupo.GridColor = System.Drawing.Color.White
        Me.dataGridGrupo.Location = New System.Drawing.Point(0, 19)
        Me.dataGridGrupo.MultiSelect = False
        Me.dataGridGrupo.Name = "dataGridGrupo"
        Me.dataGridGrupo.ReadOnly = True
        Me.dataGridGrupo.RowHeadersVisible = False
        Me.dataGridGrupo.Size = New System.Drawing.Size(451, 179)
        Me.dataGridGrupo.TabIndex = 5
        '
        'dataGridUser
        '
        Me.dataGridUser.AllowUserToAddRows = False
        Me.dataGridUser.AllowUserToDeleteRows = False
        Me.dataGridUser.AllowUserToOrderColumns = True
        Me.dataGridUser.AllowUserToResizeColumns = False
        Me.dataGridUser.AllowUserToResizeRows = False
        Me.dataGridUser.BackgroundColor = System.Drawing.Color.White
        Me.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridUser.GridColor = System.Drawing.Color.White
        Me.dataGridUser.Location = New System.Drawing.Point(0, 37)
        Me.dataGridUser.MultiSelect = False
        Me.dataGridUser.Name = "dataGridUser"
        Me.dataGridUser.ReadOnly = True
        Me.dataGridUser.RowHeadersVisible = False
        Me.dataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridUser.Size = New System.Drawing.Size(557, 166)
        Me.dataGridUser.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(34, 235)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 8
        '
        'lblnoExiste
        '
        Me.lblnoExiste.AutoSize = True
        Me.lblnoExiste.Location = New System.Drawing.Point(36, 96)
        Me.lblnoExiste.Name = "lblnoExiste"
        Me.lblnoExiste.Size = New System.Drawing.Size(89, 13)
        Me.lblnoExiste.TabIndex = 8
        Me.lblnoExiste.Text = "No  se encontro.."
        Me.lblnoExiste.Visible = False
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAplicar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAplicar.Enabled = False
        Me.btnAplicar.Location = New System.Drawing.Point(351, 0)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(100, 32)
        Me.btnAplicar.TabIndex = 12
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'btnOptAvanzado
        '
        Me.btnOptAvanzado.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOptAvanzado.Location = New System.Drawing.Point(199, 0)
        Me.btnOptAvanzado.Name = "btnOptAvanzado"
        Me.btnOptAvanzado.Size = New System.Drawing.Size(152, 32)
        Me.btnOptAvanzado.TabIndex = 13
        Me.btnOptAvanzado.Text = "Opciones Avanzadas.."
        Me.btnOptAvanzado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Zoom
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBuscar.Location = New System.Drawing.Point(347, 10)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(29, 26)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtlogin
        '
        Me.txtlogin.Location = New System.Drawing.Point(421, 8)
        Me.txtlogin.Name = "txtlogin"
        Me.txtlogin.Size = New System.Drawing.Size(30, 20)
        Me.txtlogin.TabIndex = 14
        Me.txtlogin.Text = "0"
        Me.txtlogin.Visible = False
        '
        'txtUltimoLogin
        '
        Me.txtUltimoLogin.Location = New System.Drawing.Point(677, 11)
        Me.txtUltimoLogin.Name = "txtUltimoLogin"
        Me.txtUltimoLogin.Size = New System.Drawing.Size(30, 20)
        Me.txtUltimoLogin.TabIndex = 14
        Me.txtUltimoLogin.Text = "0"
        Me.txtUltimoLogin.Visible = False
        '
        'Notificacion
        '
        Me.Notificacion.Text = "NotifyIcon1"
        Me.Notificacion.Visible = True
        '
        'especialPerminButton
        '
        Me.especialPerminButton.BackColor = System.Drawing.Color.SkyBlue
        Me.especialPerminButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.especialPerminButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.especialPerminButton.Image = Global.ECommercePlatformView.My.Resources.Resources.permiso_24
        Me.especialPerminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.especialPerminButton.Location = New System.Drawing.Point(266, 0)
        Me.especialPerminButton.Name = "especialPerminButton"
        Me.especialPerminButton.Size = New System.Drawing.Size(136, 37)
        Me.especialPerminButton.TabIndex = 15
        Me.especialPerminButton.Text = "Permisos especiales"
        Me.especialPerminButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.especialPerminButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtlogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 43)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dataGridUser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lblnoExiste)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 205)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.clearPasswordButton)
        Me.Panel3.Controls.Add(Me.especialPerminButton)
        Me.Panel3.Controls.Add(Me.btnModifUser)
        Me.Panel3.Controls.Add(Me.txtUltimoLogin)
        Me.Panel3.Controls.Add(Me.btnDeletUser)
        Me.Panel3.Controls.Add(Me.btnAgreUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 37)
        Me.Panel3.TabIndex = 0
        '
        'clearPasswordButton
        '
        Me.clearPasswordButton.BackColor = System.Drawing.Color.SkyBlue
        Me.clearPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearPasswordButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.clearPasswordButton.Image = Global.ECommercePlatformView.My.Resources.Resources.clearPassword_24
        Me.clearPasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearPasswordButton.Location = New System.Drawing.Point(402, 0)
        Me.clearPasswordButton.Name = "clearPasswordButton"
        Me.clearPasswordButton.Size = New System.Drawing.Size(152, 37)
        Me.clearPasswordButton.TabIndex = 16
        Me.clearPasswordButton.Text = "Reiniciar la contraseña"
        Me.clearPasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clearPasswordButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dataGridGrupo)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 248)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(451, 230)
        Me.Panel4.TabIndex = 18
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnOptAvanzado)
        Me.Panel6.Controls.Add(Me.btnAplicar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 198)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(451, 32)
        Me.Panel6.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(451, 19)
        Me.Panel5.TabIndex = 14
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel7.Controls.Add(Me.oKButton)
        Me.Panel7.Controls.Add(Me.acncelButton)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 478)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(559, 39)
        Me.Panel7.TabIndex = 19
        '
        'oKButton
        '
        Me.oKButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.oKButton.Location = New System.Drawing.Point(346, 0)
        Me.oKButton.Name = "oKButton"
        Me.oKButton.Size = New System.Drawing.Size(109, 39)
        Me.oKButton.TabIndex = 1
        Me.oKButton.Text = "Aceptar"
        Me.oKButton.UseVisualStyleBackColor = True
        '
        'acncelButton
        '
        Me.acncelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.acncelButton.Location = New System.Drawing.Point(455, 0)
        Me.acncelButton.Name = "acncelButton"
        Me.acncelButton.Size = New System.Drawing.Size(104, 39)
        Me.acncelButton.TabIndex = 0
        Me.acncelButton.Text = "Cancelar"
        Me.acncelButton.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 517)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Usuarios.."
        CType(Me.dataGridGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModifUser As Button
    Friend WithEvents btnAgreUser As Button
    Friend WithEvents btnDeletUser As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dataGridGrupo As DataGridView
    Friend WithEvents dataGridUser As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblnoExiste As Label
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
    Friend WithEvents btnOptAvanzado As System.Windows.Forms.Button
    Friend WithEvents txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimoLogin As System.Windows.Forms.TextBox
    Friend WithEvents Notificacion As System.Windows.Forms.NotifyIcon
    Friend WithEvents especialPerminButton As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents oKButton As Button
    Friend WithEvents acncelButton As Button
    Friend WithEvents clearPasswordButton As Button
End Class
