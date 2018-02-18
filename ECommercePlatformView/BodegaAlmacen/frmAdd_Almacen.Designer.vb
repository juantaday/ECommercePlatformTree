<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd_Almacen
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
        Me.pnlEntrada = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.checkEmployeeText = New System.Windows.Forms.TextBox()
        Me.FinEmployee2Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.inChargeEmployTextbox = New System.Windows.Forms.TextBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateStarTextBox = New System.Windows.Forms.TextBox()
        Me.DateStarDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TypoBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.telefono3TextBox = New System.Windows.Forms.TextBox()
        Me.telefono2Text = New System.Windows.Forms.TextBox()
        Me.telefono1Text = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brnAddPesponsable = New System.Windows.Forms.Button()
        Me.DireccionText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescripcionBodegaText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomBodegaText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlEntrada.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlEntrada
        '
        Me.pnlEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.pnlEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEntrada.CausesValidation = False
        Me.pnlEntrada.Controls.Add(Me.Panel4)
        Me.pnlEntrada.Controls.Add(Me.Panel3)
        Me.pnlEntrada.Controls.Add(Me.Label6)
        Me.pnlEntrada.Controls.Add(Me.Panel2)
        Me.pnlEntrada.Controls.Add(Me.Label8)
        Me.pnlEntrada.Controls.Add(Me.TypoBodegaComboBox)
        Me.pnlEntrada.Controls.Add(Me.Label7)
        Me.pnlEntrada.Controls.Add(Me.Button1)
        Me.pnlEntrada.Controls.Add(Me.Label5)
        Me.pnlEntrada.Controls.Add(Me.telefono3TextBox)
        Me.pnlEntrada.Controls.Add(Me.telefono2Text)
        Me.pnlEntrada.Controls.Add(Me.telefono1Text)
        Me.pnlEntrada.Controls.Add(Me.Label4)
        Me.pnlEntrada.Controls.Add(Me.brnAddPesponsable)
        Me.pnlEntrada.Controls.Add(Me.DireccionText)
        Me.pnlEntrada.Controls.Add(Me.Label3)
        Me.pnlEntrada.Controls.Add(Me.DescripcionBodegaText)
        Me.pnlEntrada.Controls.Add(Me.Label2)
        Me.pnlEntrada.Controls.Add(Me.NomBodegaText)
        Me.pnlEntrada.Controls.Add(Me.Label1)
        Me.pnlEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.pnlEntrada.Location = New System.Drawing.Point(5, 5)
        Me.pnlEntrada.Name = "pnlEntrada"
        Me.pnlEntrada.Size = New System.Drawing.Size(562, 357)
        Me.pnlEntrada.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel4.Controls.Add(Me.checkEmployeeText)
        Me.Panel4.Controls.Add(Me.FinEmployee2Button)
        Me.Panel4.Location = New System.Drawing.Point(62, 316)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel4.Size = New System.Drawing.Size(410, 28)
        Me.Panel4.TabIndex = 26
        '
        'checkEmployeeText
        '
        Me.checkEmployeeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkEmployeeText.Location = New System.Drawing.Point(2, 2)
        Me.checkEmployeeText.Name = "checkEmployeeText"
        Me.checkEmployeeText.ReadOnly = True
        Me.checkEmployeeText.Size = New System.Drawing.Size(377, 23)
        Me.checkEmployeeText.TabIndex = 3
        '
        'FinEmployee2Button
        '
        Me.FinEmployee2Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.FinEmployee2Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FinEmployee2Button.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.FinEmployee2Button.Location = New System.Drawing.Point(379, 2)
        Me.FinEmployee2Button.Name = "FinEmployee2Button"
        Me.FinEmployee2Button.Size = New System.Drawing.Size(29, 24)
        Me.FinEmployee2Button.TabIndex = 2
        Me.FinEmployee2Button.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel3.Controls.Add(Me.inChargeEmployTextbox)
        Me.Panel3.Controls.Add(Me.findButton)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(60, 263)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(410, 28)
        Me.Panel3.TabIndex = 25
        '
        'inChargeEmployTextbox
        '
        Me.inChargeEmployTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inChargeEmployTextbox.Location = New System.Drawing.Point(2, 2)
        Me.inChargeEmployTextbox.Name = "inChargeEmployTextbox"
        Me.inChargeEmployTextbox.ReadOnly = True
        Me.inChargeEmployTextbox.Size = New System.Drawing.Size(377, 23)
        Me.inChargeEmployTextbox.TabIndex = 3
        '
        'findButton
        '
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_Black_16
        Me.findButton.Location = New System.Drawing.Point(379, 2)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(29, 24)
        Me.findButton.TabIndex = 2
        Me.findButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Fecha de apertura"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateStarTextBox)
        Me.Panel2.Controls.Add(Me.DateStarDateTimePicker)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(419, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 25)
        Me.Panel2.TabIndex = 23
        '
        'DateStarTextBox
        '
        Me.DateStarTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateStarTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DateStarTextBox.Name = "DateStarTextBox"
        Me.DateStarTextBox.ReadOnly = True
        Me.DateStarTextBox.Size = New System.Drawing.Size(116, 20)
        Me.DateStarTextBox.TabIndex = 8
        '
        'DateStarDateTimePicker
        '
        Me.DateStarDateTimePicker.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateStarDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateStarDateTimePicker.Location = New System.Drawing.Point(116, 0)
        Me.DateStarDateTimePicker.Name = "DateStarDateTimePicker"
        Me.DateStarDateTimePicker.Size = New System.Drawing.Size(11, 20)
        Me.DateStarDateTimePicker.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Tipo:"
        '
        'TypoBodegaComboBox
        '
        Me.TypoBodegaComboBox.FormattingEnabled = True
        Me.TypoBodegaComboBox.Location = New System.Drawing.Point(72, 7)
        Me.TypoBodegaComboBox.Name = "TypoBodegaComboBox"
        Me.TypoBodegaComboBox.Size = New System.Drawing.Size(235, 24)
        Me.TypoBodegaComboBox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Atorizado para emitir cheques"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(381, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 0)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Persona a cargo:"
        '
        'telefono3TextBox
        '
        Me.telefono3TextBox.Location = New System.Drawing.Point(350, 216)
        Me.telefono3TextBox.MaxLength = 12
        Me.telefono3TextBox.Name = "telefono3TextBox"
        Me.telefono3TextBox.Size = New System.Drawing.Size(120, 23)
        Me.telefono3TextBox.TabIndex = 10
        '
        'telefono2Text
        '
        Me.telefono2Text.Location = New System.Drawing.Point(202, 216)
        Me.telefono2Text.MaxLength = 12
        Me.telefono2Text.Name = "telefono2Text"
        Me.telefono2Text.Size = New System.Drawing.Size(127, 23)
        Me.telefono2Text.TabIndex = 10
        '
        'telefono1Text
        '
        Me.telefono1Text.Location = New System.Drawing.Point(72, 216)
        Me.telefono1Text.MaxLength = 12
        Me.telefono1Text.Name = "telefono1Text"
        Me.telefono1Text.Size = New System.Drawing.Size(120, 23)
        Me.telefono1Text.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Teléfeno:"
        '
        'brnAddPesponsable
        '
        Me.brnAddPesponsable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brnAddPesponsable.Location = New System.Drawing.Point(455, 258)
        Me.brnAddPesponsable.Name = "brnAddPesponsable"
        Me.brnAddPesponsable.Size = New System.Drawing.Size(68, 0)
        Me.brnAddPesponsable.TabIndex = 7
        Me.brnAddPesponsable.Text = "...."
        Me.brnAddPesponsable.UseVisualStyleBackColor = True
        '
        'DireccionText
        '
        Me.DireccionText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DireccionText.Location = New System.Drawing.Point(101, 159)
        Me.DireccionText.MaxLength = 500
        Me.DireccionText.Multiline = True
        Me.DireccionText.Name = "DireccionText"
        Me.DireccionText.Size = New System.Drawing.Size(434, 46)
        Me.DireccionText.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observación:"
        '
        'DescripcionBodegaText
        '
        Me.DescripcionBodegaText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionBodegaText.Location = New System.Drawing.Point(101, 91)
        Me.DescripcionBodegaText.MaxLength = 200
        Me.DescripcionBodegaText.Multiline = True
        Me.DescripcionBodegaText.Name = "DescripcionBodegaText"
        Me.DescripcionBodegaText.Size = New System.Drawing.Size(445, 60)
        Me.DescripcionBodegaText.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dirección:"
        '
        'NomBodegaText
        '
        Me.NomBodegaText.Location = New System.Drawing.Point(7, 59)
        Me.NomBodegaText.MaxLength = 20
        Me.NomBodegaText.Name = "NomBodegaText"
        Me.NomBodegaText.Size = New System.Drawing.Size(340, 23)
        Me.NomBodegaText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: Local, Sucursal, Bodega:"
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(460, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 43)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancelar..."
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAceptar.Location = New System.Drawing.Point(338, 2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(122, 43)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Guardar.."
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Guardar informacion")
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 5, 2)
        Me.Panel1.Size = New System.Drawing.Size(574, 47)
        Me.Panel1.TabIndex = 1
        '
        'frmAdd_Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 415)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlEntrada)
        Me.Name = "frmAdd_Almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando locales y bodegas"
        Me.pnlEntrada.ResumeLayout(False)
        Me.pnlEntrada.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlEntrada As System.Windows.Forms.Panel
    Friend WithEvents brnAddPesponsable As System.Windows.Forms.Button
    Friend WithEvents DireccionText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DescripcionBodegaText As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomBodegaText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents telefono1Text As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TypoBodegaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents telefono3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents telefono2Text As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateStarTextBox As TextBox
    Friend WithEvents DateStarDateTimePicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents inChargeEmployTextbox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents checkEmployeeText As TextBox
    Friend WithEvents FinEmployee2Button As Button
    Friend WithEvents Panel3 As Panel
End Class
