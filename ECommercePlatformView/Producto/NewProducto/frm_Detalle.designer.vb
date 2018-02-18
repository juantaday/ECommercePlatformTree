<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_detalle))
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Nom_Comercialtxt = New System.Windows.Forms.TextBox()
        Me.SigienteButton = New System.Windows.Forms.Button()
        Me.CantidadMinNumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UndMedComBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Descriptext = New System.Windows.Forms.TextBox()
        Me.NomComuntext = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.IvaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ivaGroupBox = New System.Windows.Forms.GroupBox()
        Me.ivaPreserminadoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ivaApliDesLabel = New System.Windows.Forms.Label()
        Me.StateCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantidadMinNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ivaGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Nom_Comercialtxt
        '
        Me.Nom_Comercialtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nom_Comercialtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_Comercialtxt.Location = New System.Drawing.Point(88, 21)
        Me.Nom_Comercialtxt.MaxLength = 40
        Me.Nom_Comercialtxt.Name = "Nom_Comercialtxt"
        Me.Nom_Comercialtxt.Size = New System.Drawing.Size(476, 24)
        Me.Nom_Comercialtxt.TabIndex = 0
        '
        'SigienteButton
        '
        Me.SigienteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SigienteButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.SigienteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SigienteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SigienteButton.Location = New System.Drawing.Point(16, 250)
        Me.SigienteButton.Name = "SigienteButton"
        Me.SigienteButton.Size = New System.Drawing.Size(0, 0)
        Me.SigienteButton.TabIndex = 8
        Me.SigienteButton.Text = "Sigiente ==>>"
        Me.SigienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SigienteButton.UseVisualStyleBackColor = True
        '
        'CantidadMinNumeric
        '
        Me.CantidadMinNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadMinNumeric.Location = New System.Drawing.Point(116, 213)
        Me.CantidadMinNumeric.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.CantidadMinNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CantidadMinNumeric.Name = "CantidadMinNumeric"
        Me.CantidadMinNumeric.Size = New System.Drawing.Size(130, 24)
        Me.CantidadMinNumeric.TabIndex = 3
        Me.CantidadMinNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CantidadMinNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(4, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 18)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Cantidad x Und:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 36)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comercial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 36)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a imprimir:"
        '
        'UndMedComBox
        '
        Me.UndMedComBox.AutoCompleteCustomSource.AddRange(New String() {"Gramos", "Milititros", "Centimetros³", "Unidades"})
        Me.UndMedComBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.UndMedComBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UndMedComBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UndMedComBox.FormattingEnabled = True
        Me.UndMedComBox.Location = New System.Drawing.Point(116, 182)
        Me.UndMedComBox.Name = "UndMedComBox"
        Me.UndMedComBox.Size = New System.Drawing.Size(184, 26)
        Me.UndMedComBox.TabIndex = 5
        Me.UndMedComBox.Text = "Seleccione..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Medible:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Descripcion:"
        '
        'Descriptext
        '
        Me.Descriptext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descriptext.BackColor = System.Drawing.SystemColors.Window
        Me.Descriptext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descriptext.Location = New System.Drawing.Point(116, 89)
        Me.Descriptext.Multiline = True
        Me.Descriptext.Name = "Descriptext"
        Me.Descriptext.Size = New System.Drawing.Size(448, 87)
        Me.Descriptext.TabIndex = 2
        '
        'NomComuntext
        '
        Me.NomComuntext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomComuntext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomComuntext.Location = New System.Drawing.Point(102, 55)
        Me.NomComuntext.MaxLength = 19
        Me.NomComuntext.Name = "NomComuntext"
        Me.NomComuntext.Size = New System.Drawing.Size(445, 24)
        Me.NomComuntext.TabIndex = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(4, 213)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(0, 0)
        Me.SaveButton.TabIndex = 52
        Me.SaveButton.Text = "Button1"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'IvaCheckBox
        '
        Me.IvaCheckBox.AutoSize = True
        Me.IvaCheckBox.Location = New System.Drawing.Point(11, 24)
        Me.IvaCheckBox.Name = "IvaCheckBox"
        Me.IvaCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IvaCheckBox.TabIndex = 53
        Me.IvaCheckBox.UseVisualStyleBackColor = True
        '
        'ivaGroupBox
        '
        Me.ivaGroupBox.Controls.Add(Me.ivaPreserminadoLinkLabel)
        Me.ivaGroupBox.Controls.Add(Me.IvaCheckBox)
        Me.ivaGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ivaGroupBox.Location = New System.Drawing.Point(317, 183)
        Me.ivaGroupBox.Name = "ivaGroupBox"
        Me.ivaGroupBox.Size = New System.Drawing.Size(246, 48)
        Me.ivaGroupBox.TabIndex = 55
        Me.ivaGroupBox.TabStop = False
        Me.ivaGroupBox.Text = "Aplica IVA."
        '
        'ivaPreserminadoLinkLabel
        '
        Me.ivaPreserminadoLinkLabel.AutoSize = True
        Me.ivaPreserminadoLinkLabel.Location = New System.Drawing.Point(32, 20)
        Me.ivaPreserminadoLinkLabel.Name = "ivaPreserminadoLinkLabel"
        Me.ivaPreserminadoLinkLabel.Size = New System.Drawing.Size(145, 17)
        Me.ivaPreserminadoLinkLabel.TabIndex = 54
        Me.ivaPreserminadoLinkLabel.TabStop = True
        Me.ivaPreserminadoLinkLabel.Text = "IVA. predeterminado. "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ivaApliDesLabel)
        Me.GroupBox1.Controls.Add(Me.StateCheckBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(317, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 52)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'ivaApliDesLabel
        '
        Me.ivaApliDesLabel.AutoSize = True
        Me.ivaApliDesLabel.Location = New System.Drawing.Point(110, 21)
        Me.ivaApliDesLabel.Name = "ivaApliDesLabel"
        Me.ivaApliDesLabel.Size = New System.Drawing.Size(119, 17)
        Me.ivaApliDesLabel.TabIndex = 54
        Me.ivaApliDesLabel.Text = "IVA Aplicada: 0 %"
        '
        'StateCheckBox
        '
        Me.StateCheckBox.AutoSize = True
        Me.StateCheckBox.Location = New System.Drawing.Point(11, 22)
        Me.StateCheckBox.Name = "StateCheckBox"
        Me.StateCheckBox.Size = New System.Drawing.Size(90, 21)
        Me.StateCheckBox.TabIndex = 53
        Me.StateCheckBox.Text = "Habilitado"
        Me.StateCheckBox.UseVisualStyleBackColor = True
        '
        'frm_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(588, 314)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ivaGroupBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Nom_Comercialtxt)
        Me.Controls.Add(Me.SigienteButton)
        Me.Controls.Add(Me.CantidadMinNumeric)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UndMedComBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Descriptext)
        Me.Controls.Add(Me.NomComuntext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_detalle"
        Me.Text = "  DETALLE"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantidadMinNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ivaGroupBox.ResumeLayout(False)
        Me.ivaGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents Nom_Comercialtxt As System.Windows.Forms.TextBox
    Friend WithEvents SigienteButton As System.Windows.Forms.Button
    Friend WithEvents CantidadMinNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UndMedComBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Descriptext As System.Windows.Forms.TextBox
    Friend WithEvents NomComuntext As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents SaveButton As Button
    Friend WithEvents ivaGroupBox As GroupBox
    Friend WithEvents IvaCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StateCheckBox As CheckBox
    Friend WithEvents ivaPreserminadoLinkLabel As LinkLabel
    Friend WithEvents ivaApliDesLabel As Label
End Class
