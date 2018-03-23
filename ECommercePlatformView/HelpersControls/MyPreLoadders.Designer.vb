<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyPreLoadders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyPreLoadders))
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Stretcht = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.AllowDrop = True
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 2
        Me.BunifuCircleProgressbar1.animationSpeed = 1
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCircleProgressbar1.LabelVisible = False
        Me.BunifuCircleProgressbar1.LineProgressThickness = 8
        Me.BunifuCircleProgressbar1.LineThickness = 5
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(3, 3)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(124, 124)
        Me.BunifuCircleProgressbar1.TabIndex = 0
        Me.BunifuCircleProgressbar1.Value = 10
        '
        'Stretcht
        '
        Me.Stretcht.Enabled = True
        Me.Stretcht.Interval = 10
        '
        'MyPreLoadders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Name = "MyPreLoadders"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(130, 130)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Private WithEvents Stretcht As Timer
End Class
