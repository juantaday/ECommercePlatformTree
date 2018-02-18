<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DetailEcommerce
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
        Me.PanelViewDetail = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelViewBanck = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IdBancocuentaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BancoClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumCuentaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypoCuentaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdBancoClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelSetting = New System.Windows.Forms.Panel()
        Me.DeleteBanckButton = New System.Windows.Forms.Button()
        Me.EditBanckButton = New System.Windows.Forms.Button()
        Me.AddNewBanckButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxDateStar = New System.Windows.Forms.CheckBox()
        Me.DateStarTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FindRepresentanteButton = New System.Windows.Forms.Button()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.representanteTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.razonSoacialTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lemaTextBox = New System.Windows.Forms.TextBox()
        Me.rucTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CompaniaTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelViewDetail.SuspendLayout()
        Me.PanelViewBanck.SuspendLayout()
        Me.PanelSetting.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelViewDetail
        '
        Me.PanelViewDetail.AutoScroll = True
        Me.PanelViewDetail.Controls.Add(Me.CompaniaTextBox)
        Me.PanelViewDetail.Controls.Add(Me.Label9)
        Me.PanelViewDetail.Controls.Add(Me.Label7)
        Me.PanelViewDetail.Controls.Add(Me.PanelViewBanck)
        Me.PanelViewDetail.Controls.Add(Me.Panel1)
        Me.PanelViewDetail.Controls.Add(Me.FindRepresentanteButton)
        Me.PanelViewDetail.Controls.Add(Me.NoteTextBox)
        Me.PanelViewDetail.Controls.Add(Me.SaveButton)
        Me.PanelViewDetail.Controls.Add(Me.representanteTextBox)
        Me.PanelViewDetail.Controls.Add(Me.DomicilioTextBox)
        Me.PanelViewDetail.Controls.Add(Me.Label1)
        Me.PanelViewDetail.Controls.Add(Me.Label6)
        Me.PanelViewDetail.Controls.Add(Me.Label4)
        Me.PanelViewDetail.Controls.Add(Me.razonSoacialTextBox)
        Me.PanelViewDetail.Controls.Add(Me.Label3)
        Me.PanelViewDetail.Controls.Add(Me.lemaTextBox)
        Me.PanelViewDetail.Controls.Add(Me.rucTextBox)
        Me.PanelViewDetail.Controls.Add(Me.Label2)
        Me.PanelViewDetail.Controls.Add(Me.phoneTextBox)
        Me.PanelViewDetail.Controls.Add(Me.Label8)
        Me.PanelViewDetail.Controls.Add(Me.Label5)
        Me.PanelViewDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelViewDetail.Location = New System.Drawing.Point(5, 5)
        Me.PanelViewDetail.Name = "PanelViewDetail"
        Me.PanelViewDetail.Size = New System.Drawing.Size(690, 440)
        Me.PanelViewDetail.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cuentas empresarial:"
        '
        'PanelViewBanck
        '
        Me.PanelViewBanck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelViewBanck.Controls.Add(Me.ListView1)
        Me.PanelViewBanck.Controls.Add(Me.PanelSetting)
        Me.PanelViewBanck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelViewBanck.Location = New System.Drawing.Point(168, 249)
        Me.PanelViewBanck.Name = "PanelViewBanck"
        Me.PanelViewBanck.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelViewBanck.Size = New System.Drawing.Size(506, 143)
        Me.PanelViewBanck.TabIndex = 19
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdBancocuentaClm, Me.BancoClm, Me.NumCuentaClm, Me.TypoCuentaClm, Me.IdBancoClm})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(2, 31)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(500, 108)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'IdBancocuentaClm
        '
        Me.IdBancocuentaClm.Text = "Código"
        '
        'BancoClm
        '
        Me.BancoClm.Text = "Banco"
        Me.BancoClm.Width = 200
        '
        'NumCuentaClm
        '
        Me.NumCuentaClm.Text = "Cuenta"
        Me.NumCuentaClm.Width = 120
        '
        'TypoCuentaClm
        '
        Me.TypoCuentaClm.Text = "Tipo cuneta"
        Me.TypoCuentaClm.Width = 120
        '
        'IdBancoClm
        '
        Me.IdBancoClm.Text = "Id Banco"
        Me.IdBancoClm.Width = 0
        '
        'PanelSetting
        '
        Me.PanelSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.PanelSetting.Controls.Add(Me.DeleteBanckButton)
        Me.PanelSetting.Controls.Add(Me.EditBanckButton)
        Me.PanelSetting.Controls.Add(Me.AddNewBanckButton)
        Me.PanelSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSetting.Location = New System.Drawing.Point(2, 2)
        Me.PanelSetting.Name = "PanelSetting"
        Me.PanelSetting.Size = New System.Drawing.Size(500, 29)
        Me.PanelSetting.TabIndex = 0
        '
        'DeleteBanckButton
        '
        Me.DeleteBanckButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DeleteBanckButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteBanckButton.Enabled = False
        Me.DeleteBanckButton.Image = Global.ECommercePlatformView.My.Resources.Resources.delete_Black_32
        Me.DeleteBanckButton.Location = New System.Drawing.Point(104, 0)
        Me.DeleteBanckButton.Name = "DeleteBanckButton"
        Me.DeleteBanckButton.Size = New System.Drawing.Size(52, 29)
        Me.DeleteBanckButton.TabIndex = 5
        Me.DeleteBanckButton.UseVisualStyleBackColor = False
        '
        'EditBanckButton
        '
        Me.EditBanckButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.EditBanckButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditBanckButton.Enabled = False
        Me.EditBanckButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_black_32
        Me.EditBanckButton.Location = New System.Drawing.Point(52, 0)
        Me.EditBanckButton.Name = "EditBanckButton"
        Me.EditBanckButton.Size = New System.Drawing.Size(52, 29)
        Me.EditBanckButton.TabIndex = 4
        Me.EditBanckButton.UseVisualStyleBackColor = False
        '
        'AddNewBanckButton
        '
        Me.AddNewBanckButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.AddNewBanckButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewBanckButton.Image = Global.ECommercePlatformView.My.Resources.Resources.add_circle_Black_32
        Me.AddNewBanckButton.Location = New System.Drawing.Point(0, 0)
        Me.AddNewBanckButton.Name = "AddNewBanckButton"
        Me.AddNewBanckButton.Size = New System.Drawing.Size(52, 29)
        Me.AddNewBanckButton.TabIndex = 3
        Me.AddNewBanckButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBoxDateStar)
        Me.Panel1.Controls.Add(Me.DateStarTimePicker)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(514, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(159, 58)
        Me.Panel1.TabIndex = 17
        '
        'CheckBoxDateStar
        '
        Me.CheckBoxDateStar.AutoSize = True
        Me.CheckBoxDateStar.Location = New System.Drawing.Point(4, 3)
        Me.CheckBoxDateStar.Name = "CheckBoxDateStar"
        Me.CheckBoxDateStar.Size = New System.Drawing.Size(148, 21)
        Me.CheckBoxDateStar.TabIndex = 9
        Me.CheckBoxDateStar.Text = "Fecha de apertura:"
        Me.CheckBoxDateStar.UseVisualStyleBackColor = True
        '
        'DateStarTimePicker
        '
        Me.DateStarTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateStarTimePicker.Location = New System.Drawing.Point(4, 28)
        Me.DateStarTimePicker.Name = "DateStarTimePicker"
        Me.DateStarTimePicker.Size = New System.Drawing.Size(88, 23)
        Me.DateStarTimePicker.TabIndex = 8
        '
        'FindRepresentanteButton
        '
        Me.FindRepresentanteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.FindRepresentanteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FindRepresentanteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.FindRepresentanteButton.Location = New System.Drawing.Point(560, 113)
        Me.FindRepresentanteButton.Name = "FindRepresentanteButton"
        Me.FindRepresentanteButton.Size = New System.Drawing.Size(45, 29)
        Me.FindRepresentanteButton.TabIndex = 16
        Me.FindRepresentanteButton.UseVisualStyleBackColor = False
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.NoteTextBox.Location = New System.Drawing.Point(59, 195)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(615, 50)
        Me.NoteTextBox.TabIndex = 15
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_White_32
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(7, 395)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(349, 36)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "        Guardar.."
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'representanteTextBox
        '
        Me.representanteTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.representanteTextBox.Location = New System.Drawing.Point(161, 116)
        Me.representanteTextBox.Name = "representanteTextBox"
        Me.representanteTextBox.ReadOnly = True
        Me.representanteTextBox.Size = New System.Drawing.Size(393, 23)
        Me.representanteTextBox.TabIndex = 13
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(141, 87)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(533, 23)
        Me.DomicilioTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RAZON SOCIAL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nota:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Representante Legal:"
        '
        'razonSoacialTextBox
        '
        Me.razonSoacialTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.razonSoacialTextBox.Location = New System.Drawing.Point(126, 2)
        Me.razonSoacialTextBox.Name = "razonSoacialTextBox"
        Me.razonSoacialTextBox.Size = New System.Drawing.Size(548, 23)
        Me.razonSoacialTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio comercial:"
        '
        'lemaTextBox
        '
        Me.lemaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lemaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lemaTextBox.Location = New System.Drawing.Point(59, 147)
        Me.lemaTextBox.Multiline = True
        Me.lemaTextBox.Name = "lemaTextBox"
        Me.lemaTextBox.Size = New System.Drawing.Size(615, 42)
        Me.lemaTextBox.TabIndex = 10
        '
        'rucTextBox
        '
        Me.rucTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.rucTextBox.Location = New System.Drawing.Point(126, 57)
        Me.rucTextBox.MaxLength = 13
        Me.rucTextBox.Name = "rucTextBox"
        Me.rucTextBox.Size = New System.Drawing.Size(195, 23)
        Me.rucTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(80, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RUC:"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.phoneTextBox.Location = New System.Drawing.Point(327, 58)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(177, 23)
        Me.phoneTextBox.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(385, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lema:"
        '
        'CompaniaTextBox
        '
        Me.CompaniaTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CompaniaTextBox.Location = New System.Drawing.Point(126, 28)
        Me.CompaniaTextBox.MaxLength = 13
        Me.CompaniaTextBox.Name = "CompaniaTextBox"
        Me.CompaniaTextBox.Size = New System.Drawing.Size(238, 23)
        Me.CompaniaTextBox.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(38, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "COMPANIA:"
        '
        'Frm_DetailEcommerce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 458)
        Me.Controls.Add(Me.PanelViewDetail)
        Me.Name = "Frm_DetailEcommerce"
        Me.Text = "Frm_DetailCommerce"
        Me.PanelViewDetail.ResumeLayout(False)
        Me.PanelViewDetail.PerformLayout()
        Me.PanelViewBanck.ResumeLayout(False)
        Me.PanelSetting.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelViewDetail As Panel
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents representanteTextBox As TextBox
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents DateStarTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents razonSoacialTextBox As TextBox
    Friend WithEvents rucTextBox As TextBox
    Friend WithEvents lemaTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxDateStar As CheckBox
    Friend WithEvents FindRepresentanteButton As Button
    Friend WithEvents PanelViewBanck As Panel
    Friend WithEvents PanelSetting As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents DeleteBanckButton As Button
    Friend WithEvents EditBanckButton As Button
    Friend WithEvents AddNewBanckButton As Button
    Friend WithEvents IdBancocuentaClm As ColumnHeader
    Friend WithEvents BancoClm As ColumnHeader
    Friend WithEvents NumCuentaClm As ColumnHeader
    Friend WithEvents TypoCuentaClm As ColumnHeader
    Friend WithEvents IdBancoClm As ColumnHeader
    Friend WithEvents CompaniaTextBox As TextBox
    Friend WithEvents Label9 As Label
End Class
