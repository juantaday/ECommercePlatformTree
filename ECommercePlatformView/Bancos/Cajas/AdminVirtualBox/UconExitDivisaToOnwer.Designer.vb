<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UconExitDivisaToOnwer
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PanelBusq = New System.Windows.Forms.Panel()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.PanelFind = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.QuitFilterButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.SettingButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.idPersonClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RucCiClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullNameClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelBusq.SuspendLayout()
        Me.PanelFind.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.SubmitButton.Image = Global.ECommercePlatformView.My.Resources.Resources.transfer_Banck_Person_White_32
        Me.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.Location = New System.Drawing.Point(11, 255)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(531, 41)
        Me.SubmitButton.TabIndex = 9
        Me.SubmitButton.Text = "          Transferir.."
        Me.SubmitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'PanelBusq
        '
        Me.PanelBusq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBusq.Controls.Add(Me.updateButton)
        Me.PanelBusq.Controls.Add(Me.PanelFind)
        Me.PanelBusq.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBusq.Location = New System.Drawing.Point(11, 11)
        Me.PanelBusq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelBusq.Name = "PanelBusq"
        Me.PanelBusq.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelBusq.Size = New System.Drawing.Size(531, 35)
        Me.PanelBusq.TabIndex = 65
        '
        'updateButton
        '
        Me.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.updateButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.updateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.refresh_16
        Me.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateButton.Location = New System.Drawing.Point(3, 3)
        Me.updateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(97, 27)
        Me.updateButton.TabIndex = 10
        Me.updateButton.Text = "Actualizar.."
        Me.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'PanelFind
        '
        Me.PanelFind.BackColor = System.Drawing.Color.Blue
        Me.PanelFind.Controls.Add(Me.Panel1)
        Me.PanelFind.Controls.Add(Me.SettingButton)
        Me.PanelFind.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelFind.Location = New System.Drawing.Point(168, 3)
        Me.PanelFind.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelFind.Name = "PanelFind"
        Me.PanelFind.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelFind.Size = New System.Drawing.Size(358, 27)
        Me.PanelFind.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FindTextBox)
        Me.Panel1.Controls.Add(Me.QuitFilterButton)
        Me.Panel1.Controls.Add(Me.FindButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(4, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(255, 25)
        Me.Panel1.TabIndex = 10
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox.Location = New System.Drawing.Point(3, 2)
        Me.FindTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FindTextBox.Multiline = True
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(199, 19)
        Me.FindTextBox.TabIndex = 7
        '
        'QuitFilterButton
        '
        Me.QuitFilterButton.BackColor = System.Drawing.Color.White
        Me.QuitFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QuitFilterButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.QuitFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.QuitFilterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.QuitFilterButton.Location = New System.Drawing.Point(202, 2)
        Me.QuitFilterButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuitFilterButton.Name = "QuitFilterButton"
        Me.QuitFilterButton.Size = New System.Drawing.Size(20, 19)
        Me.QuitFilterButton.TabIndex = 9
        Me.QuitFilterButton.UseVisualStyleBackColor = False
        Me.QuitFilterButton.Visible = False
        '
        'FindButton
        '
        Me.FindButton.BackColor = System.Drawing.Color.Blue
        Me.FindButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.FindButton.Enabled = False
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.FindButton.Location = New System.Drawing.Point(222, 2)
        Me.FindButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(28, 19)
        Me.FindButton.TabIndex = 6
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'SettingButton
        '
        Me.SettingButton.BackColor = System.Drawing.Color.Blue
        Me.SettingButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingButton.Location = New System.Drawing.Point(259, 1)
        Me.SettingButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(98, 25)
        Me.SettingButton.TabIndex = 8
        Me.SettingButton.Text = "Herraminetas"
        Me.SettingButton.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPersonClm, Me.RucCiClm, Me.FullNameClm, Me.Position})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(11, 46)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(531, 209)
        Me.ListView1.TabIndex = 66
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'idPersonClm
        '
        Me.idPersonClm.Text = "IdPerson"
        Me.idPersonClm.Width = 0
        '
        'RucCiClm
        '
        Me.RucCiClm.Text = "Ruc. C.I."
        Me.RucCiClm.Width = 80
        '
        'FullNameClm
        '
        Me.FullNameClm.Text = "Propietario"
        Me.FullNameClm.Width = 180
        '
        'Position
        '
        Me.Position.Text = "Posicion"
        Me.Position.Width = 100
        '
        'UconExitDivisaToOnwer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PanelBusq)
        Me.Controls.Add(Me.SubmitButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UconExitDivisaToOnwer"
        Me.Padding = New System.Windows.Forms.Padding(11, 11, 11, 11)
        Me.Size = New System.Drawing.Size(553, 307)
        Me.PanelBusq.ResumeLayout(False)
        Me.PanelFind.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents PanelBusq As Panel
    Friend WithEvents updateButton As Button
    Friend WithEvents PanelFind As Panel
    Friend WithEvents QuitFilterButton As Button
    Friend WithEvents FindButton As Button
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents SettingButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents idPersonClm As ColumnHeader
    Friend WithEvents RucCiClm As ColumnHeader
    Friend WithEvents FullNameClm As ColumnHeader
    Friend WithEvents Position As ColumnHeader
    Friend WithEvents Panel1 As Panel
End Class
