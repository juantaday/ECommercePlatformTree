<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_EmployeeDebit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_EmployeeDebit))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdminPayMentPanel = New System.Windows.Forms.Panel()
        Me.PagosBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.EstadoBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.NamePeopleLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.Panel1.SuspendLayout()
        Me.AdminPayMentPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelView.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(493, 2)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 31)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(586, 2)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(84, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.AdminPayMentPanel)
        Me.Panel1.Controls.Add(Me.NamePeopleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 79)
        Me.Panel1.TabIndex = 1
        '
        'AdminPayMentPanel
        '
        Me.AdminPayMentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.AdminPayMentPanel.Controls.Add(Me.PagosBunifuThinButton)
        Me.AdminPayMentPanel.Controls.Add(Me.EstadoBunifuThinButton)
        Me.AdminPayMentPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AdminPayMentPanel.Location = New System.Drawing.Point(0, 36)
        Me.AdminPayMentPanel.Name = "AdminPayMentPanel"
        Me.AdminPayMentPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.AdminPayMentPanel.Size = New System.Drawing.Size(680, 43)
        Me.AdminPayMentPanel.TabIndex = 67
        '
        'PagosBunifuThinButton
        '
        Me.PagosBunifuThinButton.ActiveBorderThickness = 1
        Me.PagosBunifuThinButton.ActiveCornerRadius = 20
        Me.PagosBunifuThinButton.ActiveFillColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.PagosBunifuThinButton.ActiveLineColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PagosBunifuThinButton.BackgroundImage = CType(resources.GetObject("PagosBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.PagosBunifuThinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PagosBunifuThinButton.ButtonText = "Determinar moto."
        Me.PagosBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PagosBunifuThinButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PagosBunifuThinButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagosBunifuThinButton.ForeColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.IdleBorderThickness = 1
        Me.PagosBunifuThinButton.IdleCornerRadius = 30
        Me.PagosBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.PagosBunifuThinButton.IdleForecolor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.IdleLineColor = System.Drawing.Color.Navy
        Me.PagosBunifuThinButton.Location = New System.Drawing.Point(135, 2)
        Me.PagosBunifuThinButton.Margin = New System.Windows.Forms.Padding(5)
        Me.PagosBunifuThinButton.Name = "PagosBunifuThinButton"
        Me.PagosBunifuThinButton.Size = New System.Drawing.Size(156, 39)
        Me.PagosBunifuThinButton.TabIndex = 64
        Me.PagosBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EstadoBunifuThinButton
        '
        Me.EstadoBunifuThinButton.ActiveBorderThickness = 1
        Me.EstadoBunifuThinButton.ActiveCornerRadius = 20
        Me.EstadoBunifuThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstadoBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.EstadoBunifuThinButton.ActiveLineColor = System.Drawing.Color.Red
        Me.EstadoBunifuThinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EstadoBunifuThinButton.BackgroundImage = CType(resources.GetObject("EstadoBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.EstadoBunifuThinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EstadoBunifuThinButton.ButtonText = "Cobrar todo"
        Me.EstadoBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EstadoBunifuThinButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EstadoBunifuThinButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoBunifuThinButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.EstadoBunifuThinButton.IdleBorderThickness = 1
        Me.EstadoBunifuThinButton.IdleCornerRadius = 30
        Me.EstadoBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.EstadoBunifuThinButton.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstadoBunifuThinButton.IdleLineColor = System.Drawing.Color.Red
        Me.EstadoBunifuThinButton.Location = New System.Drawing.Point(2, 2)
        Me.EstadoBunifuThinButton.Margin = New System.Windows.Forms.Padding(5)
        Me.EstadoBunifuThinButton.Name = "EstadoBunifuThinButton"
        Me.EstadoBunifuThinButton.Size = New System.Drawing.Size(133, 39)
        Me.EstadoBunifuThinButton.TabIndex = 64
        Me.EstadoBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NamePeopleLabel
        '
        Me.NamePeopleLabel.AutoSize = True
        Me.NamePeopleLabel.Font = New System.Drawing.Font("Source Sans Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamePeopleLabel.Location = New System.Drawing.Point(12, 9)
        Me.NamePeopleLabel.Name = "NamePeopleLabel"
        Me.NamePeopleLabel.Size = New System.Drawing.Size(389, 24)
        Me.NamePeopleLabel.TabIndex = 0
        Me.NamePeopleLabel.Text = "TADAY NALAN JUAN  ==>Total deuda:  $ 23.36"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.OK_Button)
        Me.Panel2.Controls.Add(Me.Cancel_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 426)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 2, 10, 2)
        Me.Panel2.Size = New System.Drawing.Size(680, 35)
        Me.Panel2.TabIndex = 2
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.ElementHost1)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(0, 79)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelView.Size = New System.Drawing.Size(680, 347)
        Me.PanelView.TabIndex = 3
        '
        'ElementHost1
        '
        Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElementHost1.Location = New System.Drawing.Point(2, 2)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(676, 343)
        Me.ElementHost1.TabIndex = 0
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Nothing
        '
        'frmList_EmployeeDebit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(680, 461)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmList_EmployeeDebit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de deuda de trabajadores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AdminPayMentPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelView As Panel
    Friend WithEvents NamePeopleLabel As Label
    Friend WithEvents AdminPayMentPanel As Panel
    Friend WithEvents PagosBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EstadoBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend ItemBebitEmployee1 As ItemBebitEmployee
End Class
