<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmbackup_SimpleClearLog
    Inherits System.Windows.Forms.UserControl

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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fileNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.FileButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.MediumBlue
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Location = New System.Drawing.Point(301, 161)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(0, 0)
        Me.btnbackup.TabIndex = 1
        Me.btnbackup.Text = "Backup base"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'fileNameTextBox
        '
        Me.fileNameTextBox.Location = New System.Drawing.Point(9, 228)
        Me.fileNameTextBox.Name = "fileNameTextBox"
        Me.fileNameTextBox.ReadOnly = True
        Me.fileNameTextBox.Size = New System.Drawing.Size(590, 20)
        Me.fileNameTextBox.TabIndex = 2
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(10, 269)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(599, 19)
        Me.ProgressBar2.TabIndex = 6
        '
        'FileButton
        '
        Me.FileButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_green_48icon
        Me.FileButton.Location = New System.Drawing.Point(520, 161)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(79, 61)
        Me.FileButton.TabIndex = 4
        Me.FileButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ruta de respaldo:"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 184)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = ""
        '
        'frmbackup_SimpleClearLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.fileNameTextBox)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmbackup_SimpleClearLog"
        Me.Size = New System.Drawing.Size(630, 310)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FileButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents fileNameTextBox As TextBox
    Private WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As RichTextBox
End Class
