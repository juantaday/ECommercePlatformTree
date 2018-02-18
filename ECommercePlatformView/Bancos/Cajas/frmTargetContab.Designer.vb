<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTargetContab
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
        Me.PanelTarget = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTarget.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTarget
        '
        Me.PanelTarget.Controls.Add(Me.Label1)
        Me.PanelTarget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTarget.Location = New System.Drawing.Point(0, 0)
        Me.PanelTarget.Name = "PanelTarget"
        Me.PanelTarget.Size = New System.Drawing.Size(269, 148)
        Me.PanelTarget.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disponible en la proxima versión."
        '
        'frmTargetContab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 148)
        Me.Controls.Add(Me.PanelTarget)
        Me.Name = "frmTargetContab"
        Me.Text = "frmTargetContab"
        Me.PanelTarget.ResumeLayout(False)
        Me.PanelTarget.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTarget As System.Windows.Forms.Panel
    Friend WithEvents Label1 As Label
End Class
