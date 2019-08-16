<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd_Empleados))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sueldoTextBox = New System.Windows.Forms.NumericUpDown()
        Me.btnRepot = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtFecha_Ingreso = New System.Windows.Forms.DateTimePicker()
        Me.txtNameReportto = New System.Windows.Forms.TextBox()
        Me.SalariosComboBox = New System.Windows.Forms.ComboBox()
        Me.tituloCombobox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddcargo = New System.Windows.Forms.Button()
        Me.btnEddCargo = New System.Windows.Forms.Button()
        Me.CargoBombox = New System.Windows.Forms.ComboBox()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.notificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.descriptionEmployeeLabel = New System.Windows.Forms.Label()
        Me.rucEmployeeLabel = New System.Windows.Forms.Label()
        Me.NameEmployeeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.sueldoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sueldoTextBox)
        Me.GroupBox2.Controls.Add(Me.btnRepot)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtFecha_Ingreso)
        Me.GroupBox2.Controls.Add(Me.txtNameReportto)
        Me.GroupBox2.Controls.Add(Me.SalariosComboBox)
        Me.GroupBox2.Controls.Add(Me.tituloCombobox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(0, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 103)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Opcionales"
        '
        'sueldoTextBox
        '
        Me.sueldoTextBox.DecimalPlaces = 2
        Me.sueldoTextBox.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sueldoTextBox.Location = New System.Drawing.Point(560, 70)
        Me.sueldoTextBox.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.sueldoTextBox.Name = "sueldoTextBox"
        Me.sueldoTextBox.Size = New System.Drawing.Size(83, 24)
        Me.sueldoTextBox.TabIndex = 9
        Me.sueldoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRepot
        '
        Me.btnRepot.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_Grin_24
        Me.btnRepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRepot.Location = New System.Drawing.Point(348, 67)
        Me.btnRepot.Name = "btnRepot"
        Me.btnRepot.Size = New System.Drawing.Size(28, 24)
        Me.btnRepot.TabIndex = 10
        Me.btnRepot.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(414, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha Ingreso:"
        '
        'dtFecha_Ingreso
        '
        Me.dtFecha_Ingreso.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha_Ingreso.Location = New System.Drawing.Point(519, 12)
        Me.dtFecha_Ingreso.Name = "dtFecha_Ingreso"
        Me.dtFecha_Ingreso.ShowCheckBox = True
        Me.dtFecha_Ingreso.Size = New System.Drawing.Size(123, 24)
        Me.dtFecha_Ingreso.TabIndex = 10
        '
        'txtNameReportto
        '
        Me.txtNameReportto.Location = New System.Drawing.Point(12, 67)
        Me.txtNameReportto.Name = "txtNameReportto"
        Me.txtNameReportto.ReadOnly = True
        Me.txtNameReportto.Size = New System.Drawing.Size(330, 23)
        Me.txtNameReportto.TabIndex = 9
        '
        'SalariosComboBox
        '
        Me.SalariosComboBox.FormattingEnabled = True
        Me.SalariosComboBox.Items.AddRange(New Object() {"Salario", "Sueldo", "Honorarios", "Comisión"})
        Me.SalariosComboBox.Location = New System.Drawing.Point(440, 44)
        Me.SalariosComboBox.Name = "SalariosComboBox"
        Me.SalariosComboBox.Size = New System.Drawing.Size(205, 24)
        Me.SalariosComboBox.TabIndex = 8
        '
        'tituloCombobox
        '
        Me.tituloCombobox.FormattingEnabled = True
        Me.tituloCombobox.Items.AddRange(New Object() {"Abg.", "Arq.", "C.P.", "C.P.T.", "Dr.", "Dra.", "I.G.", "Ing.", "LAE.", "Lcdo.", "Psic.", "Sr.", "Sra.", "Srta."})
        Me.tituloCombobox.Location = New System.Drawing.Point(174, 15)
        Me.tituloCombobox.Name = "tituloCombobox"
        Me.tituloCombobox.Size = New System.Drawing.Size(168, 24)
        Me.tituloCombobox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Sueldo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Profeción: (Ing. ; Sr. ; etc)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(249, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Jefe inmediato superior al que se reporta:"
        '
        'imgFoto
        '
        Me.imgFoto.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.user_nothing_72
        Me.imgFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgFoto.Location = New System.Drawing.Point(0, 0)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(183, 188)
        Me.imgFoto.TabIndex = 6
        Me.imgFoto.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddcargo)
        Me.GroupBox1.Controls.Add(Me.btnEddCargo)
        Me.GroupBox1.Controls.Add(Me.CargoBombox)
        Me.GroupBox1.Controls.Add(Me.LblLogin)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 67)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Obligatorios"
        '
        'btnAddcargo
        '
        Me.btnAddcargo.Image = Global.ECommercePlatformView.My.Resources.Resources.Add_Folder_16
        Me.btnAddcargo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddcargo.Location = New System.Drawing.Point(541, 22)
        Me.btnAddcargo.Name = "btnAddcargo"
        Me.btnAddcargo.Size = New System.Drawing.Size(22, 28)
        Me.btnAddcargo.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btnAddcargo, "Agregar nuevo cargo")
        Me.btnAddcargo.UseVisualStyleBackColor = True
        '
        'btnEddCargo
        '
        Me.btnEddCargo.Enabled = False
        Me.btnEddCargo.Image = Global.ECommercePlatformView.My.Resources.Resources.Pencil_24
        Me.btnEddCargo.Location = New System.Drawing.Point(565, 22)
        Me.btnEddCargo.Name = "btnEddCargo"
        Me.btnEddCargo.Size = New System.Drawing.Size(22, 28)
        Me.btnEddCargo.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btnEddCargo, "Modificar cargo")
        Me.btnEddCargo.UseVisualStyleBackColor = True
        '
        'CargoBombox
        '
        Me.CargoBombox.FormattingEnabled = True
        Me.CargoBombox.Location = New System.Drawing.Point(127, 27)
        Me.CargoBombox.Name = "CargoBombox"
        Me.CargoBombox.Size = New System.Drawing.Size(405, 24)
        Me.CargoBombox.TabIndex = 12
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Location = New System.Drawing.Point(63, 30)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(58, 17)
        Me.LblLogin.TabIndex = 0
        Me.LblLogin.Text = "CARGO:"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'btnCancel
        '
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(563, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Salir....")
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(473, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Aceptar")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'notificacion
        '
        Me.notificacion.Text = "NotifyIcon1"
        Me.notificacion.Visible = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(651, 32)
        Me.Panel2.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.descriptionEmployeeLabel)
        Me.Panel1.Controls.Add(Me.rucEmployeeLabel)
        Me.Panel1.Controls.Add(Me.NameEmployeeLinkLabel)
        Me.Panel1.Controls.Add(Me.imgFoto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 204)
        Me.Panel1.TabIndex = 13
        '
        'descriptionEmployeeLabel
        '
        Me.descriptionEmployeeLabel.AutoSize = True
        Me.descriptionEmployeeLabel.Location = New System.Drawing.Point(193, 53)
        Me.descriptionEmployeeLabel.Name = "descriptionEmployeeLabel"
        Me.descriptionEmployeeLabel.Size = New System.Drawing.Size(39, 13)
        Me.descriptionEmployeeLabel.TabIndex = 9
        Me.descriptionEmployeeLabel.Text = "Label2"
        '
        'rucEmployeeLabel
        '
        Me.rucEmployeeLabel.AutoSize = True
        Me.rucEmployeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rucEmployeeLabel.Location = New System.Drawing.Point(189, 32)
        Me.rucEmployeeLabel.Name = "rucEmployeeLabel"
        Me.rucEmployeeLabel.Size = New System.Drawing.Size(57, 20)
        Me.rucEmployeeLabel.TabIndex = 8
        Me.rucEmployeeLabel.Text = "Label1"
        '
        'NameEmployeeLinkLabel
        '
        Me.NameEmployeeLinkLabel.AutoSize = True
        Me.NameEmployeeLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameEmployeeLinkLabel.Location = New System.Drawing.Point(189, 1)
        Me.NameEmployeeLinkLabel.Name = "NameEmployeeLinkLabel"
        Me.NameEmployeeLinkLabel.Size = New System.Drawing.Size(145, 31)
        Me.NameEmployeeLinkLabel.TabIndex = 7
        Me.NameEmployeeLinkLabel.TabStop = True
        Me.NameEmployeeLinkLabel.Text = "LinkLabel1"
        '
        'frmAdd_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 406)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdd_Empleados"
        Me.Text = "Detalle de empleados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.sueldoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblLogin As Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sueldoTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CargoBombox As System.Windows.Forms.ComboBox
    Friend WithEvents dtFecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents imgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAddcargo As System.Windows.Forms.Button
    Friend WithEvents btnEddCargo As System.Windows.Forms.Button
    Friend WithEvents tituloCombobox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNameReportto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnRepot As System.Windows.Forms.Button
    Friend WithEvents notificacion As System.Windows.Forms.NotifyIcon
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents descriptionEmployeeLabel As Label
    Friend WithEvents rucEmployeeLabel As Label
    Friend WithEvents NameEmployeeLinkLabel As LinkLabel
    Friend WithEvents SalariosComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
