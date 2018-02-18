<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeContab
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
        Me.PanelData = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ResumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.PanelPie = New System.Windows.Forms.Panel()
        Me.DiferecCheqLabel = New System.Windows.Forms.Label()
        Me.TotalCountLabel = New System.Windows.Forms.Label()
        Me.ChequeContabButton = New System.Windows.Forms.Button()
        Me.TotalSaldoCheqLabel = New System.Windows.Forms.Label()
        Me.PanelData.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ResumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPie.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelData
        '
        Me.PanelData.Controls.Add(Me.TabControl1)
        Me.PanelData.Controls.Add(Me.PanelPie)
        Me.PanelData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelData.Location = New System.Drawing.Point(0, 0)
        Me.PanelData.Name = "PanelData"
        Me.PanelData.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelData.Size = New System.Drawing.Size(527, 223)
        Me.PanelData.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(523, 155)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ResumenDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(515, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resumen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ResumenDataGridView
        '
        Me.ResumenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResumenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResumenDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ResumenDataGridView.Name = "ResumenDataGridView"
        Me.ResumenDataGridView.Size = New System.Drawing.Size(509, 120)
        Me.ResumenDataGridView.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DetailDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(515, 126)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DetailDataGridView
        '
        Me.DetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DetailDataGridView.Name = "DetailDataGridView"
        Me.DetailDataGridView.Size = New System.Drawing.Size(509, 120)
        Me.DetailDataGridView.TabIndex = 0
        '
        'PanelPie
        '
        Me.PanelPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPie.Controls.Add(Me.DiferecCheqLabel)
        Me.PanelPie.Controls.Add(Me.TotalCountLabel)
        Me.PanelPie.Controls.Add(Me.ChequeContabButton)
        Me.PanelPie.Controls.Add(Me.TotalSaldoCheqLabel)
        Me.PanelPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPie.Location = New System.Drawing.Point(2, 157)
        Me.PanelPie.Name = "PanelPie"
        Me.PanelPie.Size = New System.Drawing.Size(523, 64)
        Me.PanelPie.TabIndex = 2
        '
        'DiferecCheqLabel
        '
        Me.DiferecCheqLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiferecCheqLabel.AutoSize = True
        Me.DiferecCheqLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiferecCheqLabel.ForeColor = System.Drawing.Color.Red
        Me.DiferecCheqLabel.Location = New System.Drawing.Point(4, 40)
        Me.DiferecCheqLabel.Name = "DiferecCheqLabel"
        Me.DiferecCheqLabel.Size = New System.Drawing.Size(101, 17)
        Me.DiferecCheqLabel.TabIndex = 12
        Me.DiferecCheqLabel.Text = "Diferencia: 0"
        '
        'TotalCountLabel
        '
        Me.TotalCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalCountLabel.AutoSize = True
        Me.TotalCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCountLabel.Location = New System.Drawing.Point(5, 21)
        Me.TotalCountLabel.Name = "TotalCountLabel"
        Me.TotalCountLabel.Size = New System.Drawing.Size(180, 17)
        Me.TotalCountLabel.TabIndex = 11
        Me.TotalCountLabel.Text = "Cantidad de cheques: 0"
        '
        'ChequeContabButton
        '
        Me.ChequeContabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChequeContabButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ChequeContabButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeContabButton.ForeColor = System.Drawing.Color.White
        Me.ChequeContabButton.Location = New System.Drawing.Point(339, 16)
        Me.ChequeContabButton.Name = "ChequeContabButton"
        Me.ChequeContabButton.Size = New System.Drawing.Size(173, 38)
        Me.ChequeContabButton.TabIndex = 10
        Me.ChequeContabButton.Text = "Cheque contabilizado"
        Me.ChequeContabButton.UseVisualStyleBackColor = False
        '
        'TotalSaldoCheqLabel
        '
        Me.TotalSaldoCheqLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalSaldoCheqLabel.AutoSize = True
        Me.TotalSaldoCheqLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSaldoCheqLabel.Location = New System.Drawing.Point(5, 4)
        Me.TotalSaldoCheqLabel.Name = "TotalSaldoCheqLabel"
        Me.TotalSaldoCheqLabel.Size = New System.Drawing.Size(122, 17)
        Me.TotalSaldoCheqLabel.TabIndex = 0
        Me.TotalSaldoCheqLabel.Text = "Total cheuqe: 0"
        '
        'frmChequeContab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 223)
        Me.Controls.Add(Me.PanelData)
        Me.Name = "frmChequeContab"
        Me.Text = "frmChequeContab"
        Me.PanelData.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ResumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPie.ResumeLayout(False)
        Me.PanelPie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelData As System.Windows.Forms.Panel
    Friend WithEvents PanelPie As System.Windows.Forms.Panel
    Friend WithEvents TotalSaldoCheqLabel As System.Windows.Forms.Label
    Friend WithEvents ChequeContabButton As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ResumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TotalCountLabel As Label
    Friend WithEvents DiferecCheqLabel As Label
End Class
