<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.CodeProductSpanishLabel = New System.Windows.Forms.Label()
        Me.CodeProductEnglishLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(798, 211)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(15, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Editor: Taday Malan Juan"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.ForeColor = System.Drawing.Color.Black
        Me.Copyright.Location = New System.Drawing.Point(23, 104)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(58, 15)
        Me.Copyright.TabIndex = 9
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.Black
        Me.ApplicationTitle.Location = New System.Drawing.Point(9, 9)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(271, 29)
        Me.ApplicationTitle.TabIndex = 7
        Me.ApplicationTitle.Text = "Título de la aplicación"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Black
        Me.Version.Location = New System.Drawing.Point(23, 83)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(101, 15)
        Me.Version.TabIndex = 8
        Me.Version.Text = "Versión {0}.{1:00}"
        '
        'CodeProductSpanishLabel
        '
        Me.CodeProductSpanishLabel.AutoSize = True
        Me.CodeProductSpanishLabel.BackColor = System.Drawing.Color.Transparent
        Me.CodeProductSpanishLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeProductSpanishLabel.ForeColor = System.Drawing.Color.Black
        Me.CodeProductSpanishLabel.Location = New System.Drawing.Point(23, 132)
        Me.CodeProductSpanishLabel.Name = "CodeProductSpanishLabel"
        Me.CodeProductSpanishLabel.Size = New System.Drawing.Size(117, 15)
        Me.CodeProductSpanishLabel.TabIndex = 10
        Me.CodeProductSpanishLabel.Text = "Codido de producto:"
        '
        'CodeProductEnglishLabel
        '
        Me.CodeProductEnglishLabel.AutoSize = True
        Me.CodeProductEnglishLabel.BackColor = System.Drawing.Color.Transparent
        Me.CodeProductEnglishLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeProductEnglishLabel.ForeColor = System.Drawing.Color.Black
        Me.CodeProductEnglishLabel.Location = New System.Drawing.Point(23, 161)
        Me.CodeProductEnglishLabel.Name = "CodeProductEnglishLabel"
        Me.CodeProductEnglishLabel.Size = New System.Drawing.Size(117, 15)
        Me.CodeProductEnglishLabel.TabIndex = 11
        Me.CodeProductEnglishLabel.Text = "Codido de producto:"
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 404)
        Me.Controls.Add(Me.CodeProductEnglishLabel)
        Me.Controls.Add(Me.CodeProductSpanishLabel)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AboutBox"
        Me.Text = "AboutBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Copyright As Label
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents CodeProductSpanishLabel As Label
    Friend WithEvents CodeProductEnglishLabel As Label
End Class
