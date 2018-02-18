<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIvaDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIvaDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ApliTodoButton = New System.Windows.Forms.Button()
        Me.AplicUnoButton = New System.Windows.Forms.Button()
        Me.txtiva = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ivaNumericUpDow = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ivaNumericUpDow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.4555!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.5445!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ApliTodoButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AplicUnoButton, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(195, 190)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(272, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(196, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'ApliTodoButton
        '
        Me.ApliTodoButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApliTodoButton.Location = New System.Drawing.Point(84, 3)
        Me.ApliTodoButton.Name = "ApliTodoButton"
        Me.ApliTodoButton.Size = New System.Drawing.Size(100, 23)
        Me.ApliTodoButton.TabIndex = 0
        Me.ApliTodoButton.Text = "Aplicar a todos"
        '
        'AplicUnoButton
        '
        Me.AplicUnoButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AplicUnoButton.Location = New System.Drawing.Point(7, 3)
        Me.AplicUnoButton.Name = "AplicUnoButton"
        Me.AplicUnoButton.Size = New System.Drawing.Size(67, 23)
        Me.AplicUnoButton.TabIndex = 0
        Me.AplicUnoButton.Text = "Aplicar"
        '
        'txtiva
        '
        Me.txtiva.DecimalPlaces = 2
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.Increment = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtiva.Location = New System.Drawing.Point(205, 12)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(70, 24)
        Me.txtiva.TabIndex = 7
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtiva.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 140)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ivaNumericUpDow
        '
        Me.ivaNumericUpDow.DecimalPlaces = 2
        Me.ivaNumericUpDow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ivaNumericUpDow.Location = New System.Drawing.Point(279, 149)
        Me.ivaNumericUpDow.Name = "ivaNumericUpDow"
        Me.ivaNumericUpDow.Size = New System.Drawing.Size(64, 24)
        Me.ivaNumericUpDow.TabIndex = 9
        Me.ivaNumericUpDow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ivaNumericUpDow.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "(%)"
        '
        'frmIvaDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(490, 226)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ivaNumericUpDow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIvaDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrando porcentaje de iva "
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.txtiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ivaNumericUpDow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ApliTodoButton As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents AplicUnoButton As Button
    Friend WithEvents txtiva As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ivaNumericUpDow As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
