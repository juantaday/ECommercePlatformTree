<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackup_Base
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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fileNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.MediumBlue
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Location = New System.Drawing.Point(12, 130)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(195, 31)
        Me.btnbackup.TabIndex = 1
        Me.btnbackup.Text = "Backup base"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'fileNameTextBox
        '
        Me.fileNameTextBox.Location = New System.Drawing.Point(12, 57)
        Me.fileNameTextBox.Name = "fileNameTextBox"
        Me.fileNameTextBox.ReadOnly = True
        Me.fileNameTextBox.Size = New System.Drawing.Size(542, 20)
        Me.fileNameTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ruta de respaldo:"
        '
        'FileButton
        '
        Me.FileButton.Image = Global.ECommercePlatformView.My.Resources.Resources.zoom_green_48icon
        Me.FileButton.Location = New System.Drawing.Point(560, 38)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Size = New System.Drawing.Size(62, 54)
        Me.FileButton.TabIndex = 4
        Me.FileButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 167)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(620, 13)
        Me.ProgressBar1.TabIndex = 5
        '
        'Timer1
        '
        '
        'frmbackup_Base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 207)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FileButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fileNameTextBox)
        Me.Controls.Add(Me.btnbackup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbackup_Base"
        Me.Text = "Backup de la base de datos...."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents fileNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FileButton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
