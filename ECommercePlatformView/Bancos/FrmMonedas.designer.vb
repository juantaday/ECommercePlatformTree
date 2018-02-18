<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonedas
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
        Me.TypoMondaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.AccepButton = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.PanelInformation = New System.Windows.Forms.Panel()
        Me.GroupBoxInputData = New System.Windows.Forms.GroupBox()
        Me.ConfimButton = New System.Windows.Forms.Button()
        Me.ValorManualTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TableData = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelPie = New System.Windows.Forms.Panel()
        Me.Cancel_Butoon = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelInformation.SuspendLayout()
        Me.GroupBoxInputData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelPie.SuspendLayout()
        Me.SuspendLayout()
        '
        'TypoMondaComboBox
        '
        Me.TypoMondaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TypoMondaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TypoMondaComboBox.FormattingEnabled = True
        Me.TypoMondaComboBox.Location = New System.Drawing.Point(159, 6)
        Me.TypoMondaComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TypoMondaComboBox.Name = "TypoMondaComboBox"
        Me.TypoMondaComboBox.Size = New System.Drawing.Size(393, 28)
        Me.TypoMondaComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Moneda"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Navy
        Me.PanelMenu.Controls.Add(Me.FindButton)
        Me.PanelMenu.Controls.Add(Me.TypoMondaComboBox)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(875, 40)
        Me.PanelMenu.TabIndex = 3
        '
        'FindButton
        '
        Me.FindButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_icon_24
        Me.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindButton.Location = New System.Drawing.Point(559, 6)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(30, 25)
        Me.FindButton.TabIndex = 3
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.PowderBlue
        Me.LinkLabel2.ForeColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(5, 7)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(128, 20)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Agregar modeda"
        '
        'AccepButton
        '
        Me.AccepButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccepButton.Location = New System.Drawing.Point(672, 4)
        Me.AccepButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AccepButton.Name = "AccepButton"
        Me.AccepButton.Size = New System.Drawing.Size(97, 27)
        Me.AccepButton.TabIndex = 1
        Me.AccepButton.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.AccepButton, "Aplicar")
        Me.AccepButton.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.PowderBlue
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(144, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(117, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Agregar villetes"
        '
        'TotalLabel
        '
        Me.TotalLabel.BackColor = System.Drawing.Color.Red
        Me.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.White
        Me.TotalLabel.Location = New System.Drawing.Point(688, 0)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(185, 68)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "0.00"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PanelInformation
        '
        Me.PanelInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInformation.Controls.Add(Me.GroupBoxInputData)
        Me.PanelInformation.Controls.Add(Me.Label2)
        Me.PanelInformation.Controls.Add(Me.GroupBox1)
        Me.PanelInformation.Controls.Add(Me.TotalLabel)
        Me.PanelInformation.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInformation.Location = New System.Drawing.Point(0, 40)
        Me.PanelInformation.Name = "PanelInformation"
        Me.PanelInformation.Size = New System.Drawing.Size(875, 70)
        Me.PanelInformation.TabIndex = 9
        '
        'GroupBoxInputData
        '
        Me.GroupBoxInputData.Controls.Add(Me.ConfimButton)
        Me.GroupBoxInputData.Controls.Add(Me.ValorManualTextBox)
        Me.GroupBoxInputData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInputData.Location = New System.Drawing.Point(255, 1)
        Me.GroupBoxInputData.Name = "GroupBoxInputData"
        Me.GroupBoxInputData.Size = New System.Drawing.Size(243, 62)
        Me.GroupBoxInputData.TabIndex = 8
        Me.GroupBoxInputData.TabStop = False
        Me.GroupBoxInputData.Text = "Determine el valor total"
        Me.GroupBoxInputData.Visible = False
        '
        'ConfimButton
        '
        Me.ConfimButton.Image = Global.ECommercePlatformView.My.Resources.Resources.ok_16
        Me.ConfimButton.Location = New System.Drawing.Point(201, 20)
        Me.ConfimButton.Name = "ConfimButton"
        Me.ConfimButton.Size = New System.Drawing.Size(28, 24)
        Me.ConfimButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ConfimButton, "Confirmar el valor")
        Me.ConfimButton.UseVisualStyleBackColor = True
        '
        'ValorManualTextBox
        '
        Me.ValorManualTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorManualTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ValorManualTextBox.Name = "ValorManualTextBox"
        Me.ValorManualTextBox.Size = New System.Drawing.Size(189, 26)
        Me.ValorManualTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(627, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total $:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 62)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de ingreso"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(130, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cálculo  por detalle"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Conteo manual"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TableData
        '
        Me.TableData.AutoScroll = True
        Me.TableData.AutoScrollMargin = New System.Drawing.Size(1, 1)
        Me.TableData.AutoScrollMinSize = New System.Drawing.Size(12, 20)
        Me.TableData.AutoSize = True
        Me.TableData.BackColor = System.Drawing.Color.White
        Me.TableData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableData.ColumnCount = 2
        Me.TableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableData.Location = New System.Drawing.Point(0, 110)
        Me.TableData.Name = "TableData"
        Me.TableData.RowCount = 1
        Me.TableData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableData.Size = New System.Drawing.Size(875, 339)
        Me.TableData.TabIndex = 10
        '
        'PanelPie
        '
        Me.PanelPie.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelPie.Controls.Add(Me.Cancel_Butoon)
        Me.PanelPie.Controls.Add(Me.LinkLabel2)
        Me.PanelPie.Controls.Add(Me.LinkLabel1)
        Me.PanelPie.Controls.Add(Me.AccepButton)
        Me.PanelPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPie.Location = New System.Drawing.Point(0, 449)
        Me.PanelPie.Name = "PanelPie"
        Me.PanelPie.Size = New System.Drawing.Size(875, 35)
        Me.PanelPie.TabIndex = 11
        '
        'Cancel_Butoon
        '
        Me.Cancel_Butoon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Butoon.Location = New System.Drawing.Point(776, 4)
        Me.Cancel_Butoon.Name = "Cancel_Butoon"
        Me.Cancel_Butoon.Size = New System.Drawing.Size(83, 27)
        Me.Cancel_Butoon.TabIndex = 8
        Me.Cancel_Butoon.Text = "Cancelar"
        Me.Cancel_Butoon.UseVisualStyleBackColor = True
        '
        'FrmMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 484)
        Me.Controls.Add(Me.TableData)
        Me.Controls.Add(Me.PanelInformation)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelPie)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMonedas"
        Me.Text = "Administración de monedas"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelInformation.ResumeLayout(False)
        Me.PanelInformation.PerformLayout()
        Me.GroupBoxInputData.ResumeLayout(False)
        Me.GroupBoxInputData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelPie.ResumeLayout(False)
        Me.PanelPie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TypoMondaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents AccepButton As System.Windows.Forms.Button
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents PanelInformation As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TableData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanelPie As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxInputData As System.Windows.Forms.GroupBox
    Friend WithEvents ConfimButton As System.Windows.Forms.Button
    Friend WithEvents ValorManualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cancel_Butoon As System.Windows.Forms.Button
End Class
