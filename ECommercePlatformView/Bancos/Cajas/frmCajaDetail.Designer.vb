<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaDetail))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.userManupuleButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.totalDiferenciaArqueoLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListViewList = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelEfectico = New System.Windows.Forms.Panel()
        Me.CaragarALabel = New System.Windows.Forms.Label()
        Me.EfectivoButton = New System.Windows.Forms.Button()
        Me.CargarAComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DiferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ContarButton = New System.Windows.Forms.Button()
        Me.ArqueroTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaldoEfectivoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListVirtualComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelEfectico.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(450, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(222, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Enabled = False
        Me.OK_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(105, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(105, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.userManupuleButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 42)
        Me.Panel1.TabIndex = 1
        '
        'userManupuleButton
        '
        Me.userManupuleButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.userManupuleButton.Image = Global.ECommercePlatformView.My.Resources.user_bloqueo
        Me.userManupuleButton.Location = New System.Drawing.Point(621, 0)
        Me.userManupuleButton.Name = "userManupuleButton"
        Me.userManupuleButton.Size = New System.Drawing.Size(51, 42)
        Me.userManupuleButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.userManupuleButton, "Usuarios que manipularon este terminal.")
        Me.userManupuleButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 8)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(77, 26)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Controls.Add(Me.totalDiferenciaArqueoLabel)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 365)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 38)
        Me.Panel2.TabIndex = 2
        '
        'totalDiferenciaArqueoLabel
        '
        Me.totalDiferenciaArqueoLabel.AutoSize = True
        Me.totalDiferenciaArqueoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalDiferenciaArqueoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDiferenciaArqueoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.totalDiferenciaArqueoLabel.Location = New System.Drawing.Point(3, 7)
        Me.totalDiferenciaArqueoLabel.Name = "totalDiferenciaArqueoLabel"
        Me.totalDiferenciaArqueoLabel.Size = New System.Drawing.Size(193, 24)
        Me.totalDiferenciaArqueoLabel.TabIndex = 1
        Me.totalDiferenciaArqueoLabel.Text = "Total diferencia: $0.00"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListViewList)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelEfectico)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(672, 275)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 3
        '
        'ListViewList
        '
        Me.ListViewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewList.Location = New System.Drawing.Point(2, 2)
        Me.ListViewList.Name = "ListViewList"
        Me.ListViewList.Size = New System.Drawing.Size(207, 269)
        Me.ListViewList.SmallImageList = Me.ImageList1
        Me.ListViewList.TabIndex = 0
        Me.ListViewList.UseCompatibleStateImageBehavior = False
        Me.ListViewList.View = System.Windows.Forms.View.List
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ok_16_png")
        Me.ImageList1.Images.SetKeyName(1, "Ok_64.ico")
        '
        'PanelEfectico
        '
        Me.PanelEfectico.Controls.Add(Me.CaragarALabel)
        Me.PanelEfectico.Controls.Add(Me.EfectivoButton)
        Me.PanelEfectico.Controls.Add(Me.CargarAComboBox)
        Me.PanelEfectico.Controls.Add(Me.Label7)
        Me.PanelEfectico.Controls.Add(Me.DiferenciaTextBox)
        Me.PanelEfectico.Controls.Add(Me.Label6)
        Me.PanelEfectico.Controls.Add(Me.ContarButton)
        Me.PanelEfectico.Controls.Add(Me.ArqueroTextBox)
        Me.PanelEfectico.Controls.Add(Me.Label5)
        Me.PanelEfectico.Controls.Add(Me.SaldoEfectivoTextBox)
        Me.PanelEfectico.Controls.Add(Me.Label3)
        Me.PanelEfectico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEfectico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEfectico.Location = New System.Drawing.Point(2, 2)
        Me.PanelEfectico.Name = "PanelEfectico"
        Me.PanelEfectico.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelEfectico.Size = New System.Drawing.Size(449, 269)
        Me.PanelEfectico.TabIndex = 1
        '
        'CaragarALabel
        '
        Me.CaragarALabel.AutoSize = True
        Me.CaragarALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaragarALabel.Location = New System.Drawing.Point(26, 189)
        Me.CaragarALabel.Name = "CaragarALabel"
        Me.CaragarALabel.Size = New System.Drawing.Size(39, 13)
        Me.CaragarALabel.TabIndex = 10
        Me.CaragarALabel.Text = "Label1"
        '
        'EfectivoButton
        '
        Me.EfectivoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EfectivoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.EfectivoButton.ForeColor = System.Drawing.Color.White
        Me.EfectivoButton.Location = New System.Drawing.Point(271, 226)
        Me.EfectivoButton.Name = "EfectivoButton"
        Me.EfectivoButton.Size = New System.Drawing.Size(173, 38)
        Me.EfectivoButton.TabIndex = 9
        Me.EfectivoButton.Text = "Efectivo contavilizado"
        Me.EfectivoButton.UseVisualStyleBackColor = False
        '
        'CargarAComboBox
        '
        Me.CargarAComboBox.Enabled = False
        Me.CargarAComboBox.FormattingEnabled = True
        Me.CargarAComboBox.Location = New System.Drawing.Point(23, 156)
        Me.CargarAComboBox.Name = "CargarAComboBox"
        Me.CargarAComboBox.Size = New System.Drawing.Size(331, 28)
        Me.CargarAComboBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cargar a:"
        '
        'DiferenciaTextBox
        '
        Me.DiferenciaTextBox.Enabled = False
        Me.DiferenciaTextBox.Location = New System.Drawing.Point(108, 97)
        Me.DiferenciaTextBox.Name = "DiferenciaTextBox"
        Me.DiferenciaTextBox.Size = New System.Drawing.Size(150, 26)
        Me.DiferenciaTextBox.TabIndex = 6
        Me.DiferenciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diferencia:"
        '
        'ContarButton
        '
        Me.ContarButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ContarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContarButton.Location = New System.Drawing.Point(263, 48)
        Me.ContarButton.Name = "ContarButton"
        Me.ContarButton.Size = New System.Drawing.Size(133, 41)
        Me.ContarButton.TabIndex = 4
        Me.ContarButton.Text = "Contabilizar...."
        Me.ContarButton.UseVisualStyleBackColor = False
        '
        'ArqueroTextBox
        '
        Me.ArqueroTextBox.Enabled = False
        Me.ArqueroTextBox.Location = New System.Drawing.Point(88, 57)
        Me.ArqueroTextBox.Name = "ArqueroTextBox"
        Me.ArqueroTextBox.Size = New System.Drawing.Size(170, 26)
        Me.ArqueroTextBox.TabIndex = 3
        Me.ArqueroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Arqueo:"
        '
        'SaldoEfectivoTextBox
        '
        Me.SaldoEfectivoTextBox.Enabled = False
        Me.SaldoEfectivoTextBox.Location = New System.Drawing.Point(77, 18)
        Me.SaldoEfectivoTextBox.Name = "SaldoEfectivoTextBox"
        Me.SaldoEfectivoTextBox.Size = New System.Drawing.Size(181, 26)
        Me.SaldoEfectivoTextBox.TabIndex = 1
        Me.SaldoEfectivoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Saldo:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 48)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.ListVirtualComboBox)
        Me.Panel4.Location = New System.Drawing.Point(110, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel4.Size = New System.Drawing.Size(333, 28)
        Me.Panel4.TabIndex = 5
        '
        'ListVirtualComboBox
        '
        Me.ListVirtualComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListVirtualComboBox.FormattingEnabled = True
        Me.ListVirtualComboBox.Location = New System.Drawing.Point(2, 2)
        Me.ListVirtualComboBox.Name = "ListVirtualComboBox"
        Me.ListVirtualComboBox.Size = New System.Drawing.Size(329, 24)
        Me.ListVirtualComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enviar saldo a:"
        '
        'frmCajaDetail
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(672, 403)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCajaDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Arqueo de caja.."
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelEfectico.ResumeLayout(False)
        Me.PanelEfectico.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents totalDiferenciaArqueoLabel As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListViewList As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents userManupuleButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PanelEfectico As System.Windows.Forms.Panel
    Friend WithEvents EfectivoButton As System.Windows.Forms.Button
    Friend WithEvents CargarAComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DiferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ContarButton As System.Windows.Forms.Button
    Friend WithEvents ArqueroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SaldoEfectivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CaragarALabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListVirtualComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
