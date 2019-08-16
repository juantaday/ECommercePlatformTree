<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd_Proveedor
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
        Me.cmbTipoEmp = New System.Windows.Forms.ComboBox()
        Me.dtFechaReg = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaActual = New System.Windows.Forms.TextBox()
        Me.txtUserActual = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAcepter = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RucMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.chekboxIva = New System.Windows.Forms.CheckBox()
        Me.cmbTiopo_razon = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoEmp
        '
        Me.cmbTipoEmp.AutoCompleteCustomSource.AddRange(New String() {"Companias", "Asociaciones", "Persona Natural"})
        Me.cmbTipoEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTipoEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoEmp.FormattingEnabled = True
        Me.cmbTipoEmp.Location = New System.Drawing.Point(129, 49)
        Me.cmbTipoEmp.Name = "cmbTipoEmp"
        Me.cmbTipoEmp.Size = New System.Drawing.Size(283, 27)
        Me.cmbTipoEmp.TabIndex = 0
        Me.cmbTipoEmp.Text = "Selecione...."
        '
        'dtFechaReg
        '
        Me.dtFechaReg.Enabled = False
        Me.dtFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaReg.Location = New System.Drawing.Point(129, 345)
        Me.dtFechaReg.Name = "dtFechaReg"
        Me.dtFechaReg.Size = New System.Drawing.Size(125, 27)
        Me.dtFechaReg.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha Registro:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Usuario:"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(546, 446)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 31)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(129, 312)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(250, 27)
        Me.txtUser.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Usuario:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaActual
        '
        Me.txtFechaActual.BackColor = System.Drawing.Color.White
        Me.txtFechaActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaActual.Enabled = False
        Me.txtFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaActual.Location = New System.Drawing.Point(72, 29)
        Me.txtFechaActual.Name = "txtFechaActual"
        Me.txtFechaActual.Size = New System.Drawing.Size(275, 11)
        Me.txtFechaActual.TabIndex = 11
        Me.txtFechaActual.TabStop = False
        '
        'txtUserActual
        '
        Me.txtUserActual.BackColor = System.Drawing.Color.White
        Me.txtUserActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserActual.Enabled = False
        Me.txtUserActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserActual.Location = New System.Drawing.Point(72, 10)
        Me.txtUserActual.Name = "txtUserActual"
        Me.txtUserActual.Size = New System.Drawing.Size(275, 11)
        Me.txtUserActual.TabIndex = 12
        Me.txtUserActual.TabStop = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Location = New System.Drawing.Point(129, 250)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(437, 27)
        Me.txtTelefono.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefono:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAcepter
        '
        Me.btnAcepter.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcepter.Location = New System.Drawing.Point(426, 446)
        Me.btnAcepter.Name = "btnAcepter"
        Me.btnAcepter.Size = New System.Drawing.Size(114, 31)
        Me.btnAcepter.TabIndex = 1
        Me.btnAcepter.Text = "&Guardar"
        Me.btnAcepter.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(129, 217)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(437, 27)
        Me.txtDireccion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Dirección:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRepresentante
        '
        Me.txtRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepresentante.Location = New System.Drawing.Point(129, 184)
        Me.txtRepresentante.MaxLength = 50
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.Size = New System.Drawing.Size(437, 27)
        Me.txtRepresentante.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RucMaskedTextBox)
        Me.Panel1.Controls.Add(Me.chekboxIva)
        Me.Panel1.Controls.Add(Me.cmbTiopo_razon)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmbTipoEmp)
        Me.Panel1.Controls.Add(Me.dtFechaReg)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtRepresentante)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRazon)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtidProveedor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Location = New System.Drawing.Point(18, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 384)
        Me.Panel1.TabIndex = 0
        '
        'RucMaskedTextBox
        '
        Me.RucMaskedTextBox.Location = New System.Drawing.Point(129, 82)
        Me.RucMaskedTextBox.Mask = "9999999999-999"
        Me.RucMaskedTextBox.Name = "RucMaskedTextBox"
        Me.RucMaskedTextBox.Size = New System.Drawing.Size(178, 27)
        Me.RucMaskedTextBox.TabIndex = 0
        Me.RucMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'chekboxIva
        '
        Me.chekboxIva.AutoSize = True
        Me.chekboxIva.Location = New System.Drawing.Point(131, 284)
        Me.chekboxIva.Name = "chekboxIva"
        Me.chekboxIva.Size = New System.Drawing.Size(308, 23)
        Me.chekboxIva.TabIndex = 6
        Me.chekboxIva.Text = "Al facturar en el sub total incluyen iva.?"
        Me.chekboxIva.UseVisualStyleBackColor = True
        '
        'cmbTiopo_razon
        '
        Me.cmbTiopo_razon.AutoCompleteCustomSource.AddRange(New String() {"Companias", "Asociaciones", "Persona Natural"})
        Me.cmbTiopo_razon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTiopo_razon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTiopo_razon.FormattingEnabled = True
        Me.cmbTiopo_razon.Items.AddRange(New Object() {"Persona Natural", "Compania", "Empresa"})
        Me.cmbTiopo_razon.Location = New System.Drawing.Point(131, 150)
        Me.cmbTiopo_razon.MaxLength = 20
        Me.cmbTiopo_razon.Name = "cmbTiopo_razon"
        Me.cmbTiopo_razon.Size = New System.Drawing.Size(269, 27)
        Me.cmbTiopo_razon.TabIndex = 2
        Me.cmbTiopo_razon.Text = "Empresa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 19)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Tipo de razón:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Representante:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRazon
        '
        Me.txtRazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazon.Location = New System.Drawing.Point(129, 115)
        Me.txtRazon.MaxLength = 100
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(437, 27)
        Me.txtRazon.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rozón Social:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "(Ruc.)  ( C.I.):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtidProveedor
        '
        Me.txtidProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidProveedor.Enabled = False
        Me.txtidProveedor.Location = New System.Drawing.Point(126, 16)
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.Size = New System.Drawing.Size(286, 27)
        Me.txtidProveedor.TabIndex = 1
        Me.txtidProveedor.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'frmAdd_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(672, 489)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFechaActual)
        Me.Controls.Add(Me.txtUserActual)
        Me.Controls.Add(Me.btnAcepter)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAdd_Proveedor"
        Me.Text = "frmAdd_Proveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoEmp As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFechaActual As System.Windows.Forms.TextBox
    Friend WithEvents txtUserActual As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAcepter As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbTiopo_razon As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chekboxIva As System.Windows.Forms.CheckBox
    Friend WithEvents RucMaskedTextBox As MaskedTextBox
End Class
