<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUltDocument
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
        Me.PieTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ActualizaButton = New System.Windows.Forms.Button()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.ViewReportButton = New System.Windows.Forms.Button()
        Me.PrintTicketButton = New System.Windows.Forms.Button()
        Me.PrintMatricialButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PieTableLayout.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'PieTableLayout
        '
        Me.PieTableLayout.ColumnCount = 3
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.88669!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.11331!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.PieTableLayout.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.PieTableLayout.Controls.Add(Me.OK_Button, 1, 0)
        Me.PieTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PieTableLayout.Location = New System.Drawing.Point(0, 286)
        Me.PieTableLayout.Name = "PieTableLayout"
        Me.PieTableLayout.RowCount = 1
        Me.PieTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.PieTableLayout.Size = New System.Drawing.Size(587, 29)
        Me.PieTableLayout.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(510, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(418, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(65, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(587, 229)
        Me.DataGridView1.TabIndex = 1
        '
        'MenuTableLayout
        '
        Me.MenuTableLayout.ColumnCount = 5
        Me.MenuTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.55752!))
        Me.MenuTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.44248!))
        Me.MenuTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.MenuTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.MenuTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279.0!))
        Me.MenuTableLayout.Controls.Add(Me.ActualizaButton, 0, 0)
        Me.MenuTableLayout.Controls.Add(Me.SelectAllButton, 4, 0)
        Me.MenuTableLayout.Controls.Add(Me.ViewReportButton, 1, 0)
        Me.MenuTableLayout.Controls.Add(Me.PrintTicketButton, 3, 0)
        Me.MenuTableLayout.Controls.Add(Me.PrintMatricialButton, 2, 0)
        Me.MenuTableLayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.MenuTableLayout.Name = "MenuTableLayout"
        Me.MenuTableLayout.RowCount = 1
        Me.MenuTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MenuTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.MenuTableLayout.Size = New System.Drawing.Size(587, 57)
        Me.MenuTableLayout.TabIndex = 2
        '
        'ActualizaButton
        '
        Me.ActualizaButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActualizaButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Refresh_icon_48
        Me.ActualizaButton.Location = New System.Drawing.Point(0, 0)
        Me.ActualizaButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ActualizaButton.Name = "ActualizaButton"
        Me.ActualizaButton.Size = New System.Drawing.Size(85, 57)
        Me.ActualizaButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ActualizaButton, "Actualizar..")
        Me.ActualizaButton.UseVisualStyleBackColor = True
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectAllButton.Location = New System.Drawing.Point(312, 5)
        Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(5)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(270, 47)
        Me.SelectAllButton.TabIndex = 1
        Me.SelectAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.SelectAllButton, "Seleccionar todo")
        Me.SelectAllButton.UseVisualStyleBackColor = True
        '
        'ViewReportButton
        '
        Me.ViewReportButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewReportButton.Image = Global.ECommercePlatformView.My.Resources.Resources.fin_deudor_32
        Me.ViewReportButton.Location = New System.Drawing.Point(85, 0)
        Me.ViewReportButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ViewReportButton.Name = "ViewReportButton"
        Me.ViewReportButton.Size = New System.Drawing.Size(86, 57)
        Me.ViewReportButton.TabIndex = 2
        Me.ViewReportButton.UseVisualStyleBackColor = True
        '
        'PrintTicketButton
        '
        Me.PrintTicketButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintTicketButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Printing_Print_32x32
        Me.PrintTicketButton.Location = New System.Drawing.Point(247, 0)
        Me.PrintTicketButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintTicketButton.Name = "PrintTicketButton"
        Me.PrintTicketButton.Size = New System.Drawing.Size(60, 57)
        Me.PrintTicketButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.PrintTicketButton, "Imprimir documento en ticket")
        Me.PrintTicketButton.UseVisualStyleBackColor = True
        '
        'PrintMatricialButton
        '
        Me.PrintMatricialButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintMatricialButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printerMatricial_48
        Me.PrintMatricialButton.Location = New System.Drawing.Point(171, 0)
        Me.PrintMatricialButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintMatricialButton.Name = "PrintMatricialButton"
        Me.PrintMatricialButton.Size = New System.Drawing.Size(76, 57)
        Me.PrintMatricialButton.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.PrintMatricialButton, "Imprimir an A4")
        Me.PrintMatricialButton.UseVisualStyleBackColor = True
        '
        'frmUltDocument
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(587, 315)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuTableLayout)
        Me.Controls.Add(Me.PieTableLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUltDocument"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ultimos documentos generados"
        Me.PieTableLayout.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTableLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PieTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuTableLayout As TableLayoutPanel
    Friend WithEvents ActualizaButton As Button
    Friend WithEvents PrintTicketButton As Button
    Friend WithEvents PrintMatricialButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SelectAllButton As Button
    Friend WithEvents ViewReportButton As Button
End Class
