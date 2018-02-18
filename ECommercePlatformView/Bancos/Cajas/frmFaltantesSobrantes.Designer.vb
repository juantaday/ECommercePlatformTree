<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFaltantesSobrantes
    Inherits System.Windows.Forms.Form

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
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelView
        '
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 0)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(676, 356)
        Me.PanelView.TabIndex = 1
        '
        'frmFaltantesSobrantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 356)
        Me.Controls.Add(Me.PanelView)
        Me.Name = "frmFaltantesSobrantes"
        Me.Text = "Faltantes y sobrantes en terminales"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend WithEvents PanelView As Panel
End Class
