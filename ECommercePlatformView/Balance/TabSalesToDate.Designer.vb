<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabSalesToDate
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PanelManagerView = New System.Windows.Forms.Panel()
        Me.PanelRadioButons = New System.Windows.Forms.Panel()
        Me.BeforeYesterdayRadioButton = New System.Windows.Forms.RadioButton()
        Me.YesterdayRadioButton = New System.Windows.Forms.RadioButton()
        Me.DetermineDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.NowRadioButton = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BodegasComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelManagerView.SuspendLayout()
        Me.PanelRadioButons.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelManagerView
        '
        Me.PanelManagerView.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.PanelManagerView.Controls.Add(Me.PanelRadioButons)
        Me.PanelManagerView.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelManagerView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelManagerView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.PanelManagerView.Location = New System.Drawing.Point(0, 0)
        Me.PanelManagerView.Name = "PanelManagerView"
        Me.PanelManagerView.Size = New System.Drawing.Size(659, 35)
        Me.PanelManagerView.TabIndex = 0
        '
        'PanelRadioButons
        '
        Me.PanelRadioButons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRadioButons.Controls.Add(Me.BeforeYesterdayRadioButton)
        Me.PanelRadioButons.Controls.Add(Me.YesterdayRadioButton)
        Me.PanelRadioButons.Controls.Add(Me.DetermineDateRadioButton)
        Me.PanelRadioButons.Controls.Add(Me.NowRadioButton)
        Me.PanelRadioButons.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelRadioButons.Location = New System.Drawing.Point(0, 0)
        Me.PanelRadioButons.Name = "PanelRadioButons"
        Me.PanelRadioButons.Size = New System.Drawing.Size(526, 35)
        Me.PanelRadioButons.TabIndex = 5
        '
        'BeforeYesterdayRadioButton
        '
        Me.BeforeYesterdayRadioButton.AutoSize = True
        Me.BeforeYesterdayRadioButton.Location = New System.Drawing.Point(207, 5)
        Me.BeforeYesterdayRadioButton.Name = "BeforeYesterdayRadioButton"
        Me.BeforeYesterdayRadioButton.Size = New System.Drawing.Size(134, 24)
        Me.BeforeYesterdayRadioButton.TabIndex = 2
        Me.BeforeYesterdayRadioButton.Text = "Antes de hayer"
        Me.BeforeYesterdayRadioButton.UseVisualStyleBackColor = True
        '
        'YesterdayRadioButton
        '
        Me.YesterdayRadioButton.AutoSize = True
        Me.YesterdayRadioButton.Location = New System.Drawing.Point(116, 5)
        Me.YesterdayRadioButton.Name = "YesterdayRadioButton"
        Me.YesterdayRadioButton.Size = New System.Drawing.Size(59, 24)
        Me.YesterdayRadioButton.TabIndex = 0
        Me.YesterdayRadioButton.Text = "Ayer"
        Me.YesterdayRadioButton.UseVisualStyleBackColor = True
        '
        'DetermineDateRadioButton
        '
        Me.DetermineDateRadioButton.AutoSize = True
        Me.DetermineDateRadioButton.Location = New System.Drawing.Point(366, 5)
        Me.DetermineDateRadioButton.Name = "DetermineDateRadioButton"
        Me.DetermineDateRadioButton.Size = New System.Drawing.Size(150, 24)
        Me.DetermineDateRadioButton.TabIndex = 3
        Me.DetermineDateRadioButton.Text = "Determinar fecha"
        Me.DetermineDateRadioButton.UseVisualStyleBackColor = True
        '
        'NowRadioButton
        '
        Me.NowRadioButton.AutoSize = True
        Me.NowRadioButton.Location = New System.Drawing.Point(11, 5)
        Me.NowRadioButton.Name = "NowRadioButton"
        Me.NowRadioButton.Size = New System.Drawing.Size(55, 24)
        Me.NowRadioButton.TabIndex = 1
        Me.NowRadioButton.Text = "Hoy"
        Me.NowRadioButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 23)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.UpdateButton)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BodegasComboBox)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 303)
        Me.Panel2.TabIndex = 1
        '
        'UpdateButton
        '
        Me.UpdateButton.Image = Global.ECommercePlatformView.My.Resources.Resources.refresh_16
        Me.UpdateButton.Location = New System.Drawing.Point(123, 109)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(39, 31)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local o bodega:"
        '
        'BodegasComboBox
        '
        Me.BodegasComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodegasComboBox.FormattingEnabled = True
        Me.BodegasComboBox.Location = New System.Drawing.Point(9, 41)
        Me.BodegasComboBox.Name = "BodegasComboBox"
        Me.BodegasComboBox.Size = New System.Drawing.Size(167, 24)
        Me.BodegasComboBox.TabIndex = 1
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.AutoSize = True
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptViewer.EnableRefresh = False
        Me.rptViewer.Location = New System.Drawing.Point(186, 35)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowCloseButton = False
        Me.rptViewer.Size = New System.Drawing.Size(473, 303)
        Me.rptViewer.TabIndex = 2
        Me.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TabSalesToDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelManagerView)
        Me.Name = "TabSalesToDate"
        Me.Size = New System.Drawing.Size(659, 338)
        Me.PanelManagerView.ResumeLayout(False)
        Me.PanelRadioButons.ResumeLayout(False)
        Me.PanelRadioButons.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelManagerView As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DetermineDateRadioButton As RadioButton
    Friend WithEvents BeforeYesterdayRadioButton As RadioButton
    Friend WithEvents NowRadioButton As RadioButton
    Friend WithEvents YesterdayRadioButton As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BodegasComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelRadioButons As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateButton As Button
End Class
