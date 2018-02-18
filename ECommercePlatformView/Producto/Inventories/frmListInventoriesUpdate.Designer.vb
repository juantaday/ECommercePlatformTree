<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListInventoriesUpdate
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Panelfilter = New System.Windows.Forms.Panel()
        Me.ListModeFindComboBox = New System.Windows.Forms.ComboBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditConinueButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panelfilter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(744, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 7)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 7)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PrintButton)
        Me.Panel1.Controls.Add(Me.Panelfilter)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.EditConinueButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel1.Size = New System.Drawing.Size(892, 52)
        Me.Panel1.TabIndex = 1
        '
        'PrintButton
        '
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.Location = New System.Drawing.Point(279, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(129, 44)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "Imprimir"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Panelfilter
        '
        Me.Panelfilter.BackColor = System.Drawing.Color.White
        Me.Panelfilter.Controls.Add(Me.ListModeFindComboBox)
        Me.Panelfilter.Controls.Add(Me.findButton)
        Me.Panelfilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panelfilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panelfilter.Location = New System.Drawing.Point(569, 3)
        Me.Panelfilter.Name = "Panelfilter"
        Me.Panelfilter.Padding = New System.Windows.Forms.Padding(1)
        Me.Panelfilter.Size = New System.Drawing.Size(311, 44)
        Me.Panelfilter.TabIndex = 9
        '
        'ListModeFindComboBox
        '
        Me.ListModeFindComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListModeFindComboBox.FormattingEnabled = True
        Me.ListModeFindComboBox.Items.AddRange(New Object() {"En proceso de actualización.", "Finalizado (Historial)."})
        Me.ListModeFindComboBox.Location = New System.Drawing.Point(1, 1)
        Me.ListModeFindComboBox.Name = "ListModeFindComboBox"
        Me.ListModeFindComboBox.Size = New System.Drawing.Size(273, 24)
        Me.ListModeFindComboBox.TabIndex = 7
        '
        'findButton
        '
        Me.findButton.BackColor = System.Drawing.Color.LightGreen
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.findButton.Location = New System.Drawing.Point(274, 1)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(36, 42)
        Me.findButton.TabIndex = 6
        Me.findButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.delete_red_32
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(150, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(129, 44)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Eliminar"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditConinueButton
        '
        Me.EditConinueButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditConinueButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit_32x32
        Me.EditConinueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditConinueButton.Location = New System.Drawing.Point(10, 3)
        Me.EditConinueButton.Name = "EditConinueButton"
        Me.EditConinueButton.Size = New System.Drawing.Size(140, 44)
        Me.EditConinueButton.TabIndex = 0
        Me.EditConinueButton.Text = "Seguir modificado."
        Me.EditConinueButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditConinueButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 343)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(892, 40)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtgList)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(892, 291)
        Me.Panel3.TabIndex = 3
        '
        'dtgList
        '
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgList.Location = New System.Drawing.Point(5, 5)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.Size = New System.Drawing.Size(882, 281)
        Me.dtgList.TabIndex = 0
        '
        'frmListInventoriesUpdate
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(892, 383)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListInventoriesUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de inventarios en proceso de modificación"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panelfilter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditConinueButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtgList As System.Windows.Forms.DataGridView
    Friend WithEvents Panelfilter As System.Windows.Forms.Panel
    Friend WithEvents ListModeFindComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents findButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
End Class
