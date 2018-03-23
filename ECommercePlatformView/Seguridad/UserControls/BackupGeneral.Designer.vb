<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupGeneral
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TypeBackupComboBox = New System.Windows.Forms.ComboBox()
        Me.ModeRecoveryTextBox = New System.Windows.Forms.TextBox()
        Me.DataBaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ViewDetailButton = New System.Windows.Forms.Button()
        Me.DeleteFileButton = New System.Windows.Forms.Button()
        Me.AddNewFileButton = New System.Windows.Forms.Button()
        Me.CopyToComboBox = New System.Windows.Forms.ComboBox()
        Me.ListFileBox = New DevExpress.XtraEditors.ListBoxControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ListFileBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.TypeBackupComboBox)
        Me.GroupControl1.Controls.Add(Me.ModeRecoveryTextBox)
        Me.GroupControl1.Controls.Add(Me.DataBaseTextBox)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.FireScrollEventOnMouseWheel = True
        Me.GroupControl1.Location = New System.Drawing.Point(12, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(564, 141)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Origen"
        '
        'TypeBackupComboBox
        '
        Me.TypeBackupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TypeBackupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBackupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TypeBackupComboBox.FormattingEnabled = True
        Me.TypeBackupComboBox.Items.AddRange(New Object() {"Completa", "Diferencial", "Registro de transacciones"})
        Me.TypeBackupComboBox.Location = New System.Drawing.Point(187, 93)
        Me.TypeBackupComboBox.Name = "TypeBackupComboBox"
        Me.TypeBackupComboBox.Size = New System.Drawing.Size(358, 22)
        Me.TypeBackupComboBox.TabIndex = 3
        '
        'ModeRecoveryTextBox
        '
        Me.ModeRecoveryTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeRecoveryTextBox.Location = New System.Drawing.Point(187, 62)
        Me.ModeRecoveryTextBox.Name = "ModeRecoveryTextBox"
        Me.ModeRecoveryTextBox.ReadOnly = True
        Me.ModeRecoveryTextBox.Size = New System.Drawing.Size(358, 22)
        Me.ModeRecoveryTextBox.TabIndex = 2
        '
        'DataBaseTextBox
        '
        Me.DataBaseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataBaseTextBox.Location = New System.Drawing.Point(187, 31)
        Me.DataBaseTextBox.Name = "DataBaseTextBox"
        Me.DataBaseTextBox.ReadOnly = True
        Me.DataBaseTextBox.Size = New System.Drawing.Size(358, 22)
        Me.DataBaseTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base de datos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de copia de seguridad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modelo de recuperacón:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ViewDetailButton)
        Me.GroupControl2.Controls.Add(Me.DeleteFileButton)
        Me.GroupControl2.Controls.Add(Me.AddNewFileButton)
        Me.GroupControl2.Controls.Add(Me.CopyToComboBox)
        Me.GroupControl2.Controls.Add(Me.ListFileBox)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 158)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(564, 141)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Destino"
        '
        'ViewDetailButton
        '
        Me.ViewDetailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewDetailButton.Enabled = False
        Me.ViewDetailButton.Location = New System.Drawing.Point(485, 108)
        Me.ViewDetailButton.Name = "ViewDetailButton"
        Me.ViewDetailButton.Size = New System.Drawing.Size(71, 24)
        Me.ViewDetailButton.TabIndex = 6
        Me.ViewDetailButton.Text = "Contenido"
        Me.ToolTip1.SetToolTip(Me.ViewDetailButton, "Ver el contenido de la copia de seguridad.")
        Me.ViewDetailButton.UseVisualStyleBackColor = True
        '
        'DeleteFileButton
        '
        Me.DeleteFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteFileButton.Enabled = False
        Me.DeleteFileButton.Location = New System.Drawing.Point(485, 81)
        Me.DeleteFileButton.Name = "DeleteFileButton"
        Me.DeleteFileButton.Size = New System.Drawing.Size(71, 24)
        Me.DeleteFileButton.TabIndex = 5
        Me.DeleteFileButton.Text = "Quitar"
        Me.ToolTip1.SetToolTip(Me.DeleteFileButton, "Quitar de la lista.")
        Me.DeleteFileButton.UseVisualStyleBackColor = True
        '
        'AddNewFileButton
        '
        Me.AddNewFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddNewFileButton.Location = New System.Drawing.Point(485, 54)
        Me.AddNewFileButton.Name = "AddNewFileButton"
        Me.AddNewFileButton.Size = New System.Drawing.Size(71, 24)
        Me.AddNewFileButton.TabIndex = 4
        Me.AddNewFileButton.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.AddNewFileButton, "Agregar nueno archivo")
        Me.AddNewFileButton.UseVisualStyleBackColor = True
        '
        'CopyToComboBox
        '
        Me.CopyToComboBox.FormattingEnabled = True
        Me.CopyToComboBox.Items.AddRange(New Object() {"Disco", "Dirección URL"})
        Me.CopyToComboBox.Location = New System.Drawing.Point(74, 23)
        Me.CopyToComboBox.Name = "CopyToComboBox"
        Me.CopyToComboBox.Size = New System.Drawing.Size(258, 21)
        Me.CopyToComboBox.TabIndex = 3
        '
        'ListFileBox
        '
        Me.ListFileBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListFileBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListFileBox.HorizontalScrollbar = True
        Me.ListFileBox.ItemAutoHeight = True
        Me.ListFileBox.Location = New System.Drawing.Point(12, 51)
        Me.ListFileBox.Name = "ListFileBox"
        Me.ListFileBox.Size = New System.Drawing.Size(464, 85)
        Me.ListFileBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Copiar en:"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'BackupGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "BackupGeneral"
        Me.Size = New System.Drawing.Size(600, 310)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.ListFileBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TypeBackupComboBox As ComboBox
    Friend WithEvents ModeRecoveryTextBox As TextBox
    Friend WithEvents DataBaseTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteFileButton As Button
    Friend WithEvents AddNewFileButton As Button
    Friend WithEvents CopyToComboBox As ComboBox
    Friend WithEvents ListFileBox As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Label4 As Label
    Friend WithEvents ViewDetailButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
