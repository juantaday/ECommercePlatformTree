<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportFactura
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
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.printDefaultButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptViewer.Location = New System.Drawing.Point(0, 41)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.Size = New System.Drawing.Size(713, 235)
        Me.rptViewer.TabIndex = 0
        Me.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.printDefaultButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 41)
        Me.Panel1.TabIndex = 1
        '
        'Close_Button
        '
        Me.Close_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_Button.Image = Global.ECommercePlatformView.My.Resources.Resources.Close_32x32
        Me.Close_Button.Location = New System.Drawing.Point(649, 0)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(64, 41)
        Me.Close_Button.TabIndex = 1
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'printDefaultButton
        '
        Me.printDefaultButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.printDefaultButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.printDefaultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printDefaultButton.Location = New System.Drawing.Point(0, 0)
        Me.printDefaultButton.Name = "printDefaultButton"
        Me.printDefaultButton.Size = New System.Drawing.Size(296, 41)
        Me.printDefaultButton.TabIndex = 0
        Me.printDefaultButton.Text = "Imprimir en impresora predeterminada"
        Me.printDefaultButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.printDefaultButton.UseVisualStyleBackColor = True
        '
        'frmReportFactura
        '
        Me.ClientSize = New System.Drawing.Size(713, 276)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReportFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de factura..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents printDefaultButton As Button
    Friend WithEvents Close_Button As Button
End Class
