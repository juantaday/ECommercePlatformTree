<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCategoryRates
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.IdCategoryClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSubCategoriaClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_Cantegoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromcClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalleLabel = New System.Windows.Forms.Label()
        Me.totalSunCategoriaLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.OkButton)
        Me.Panel3.Controls.Add(Me.closeButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 444)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8, 3, 8, 3)
        Me.Panel3.Size = New System.Drawing.Size(851, 41)
        Me.Panel3.TabIndex = 12
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Black
        Me.OkButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.OkButton.ForeColor = System.Drawing.Color.White
        Me.OkButton.Location = New System.Drawing.Point(620, 3)
        Me.OkButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(118, 35)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "Aceptar."
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Black
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(738, 3)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(105, 35)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar."
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(8, 22)
        Me.DescriptionRichTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(833, 53)
        Me.DescriptionRichTextBox.TabIndex = 9
        Me.DescriptionRichTextBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Descripción de la tarifa:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8, 2, 8, 3)
        Me.Panel2.Size = New System.Drawing.Size(851, 364)
        Me.Panel2.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.SplitContainer1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(8, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(833, 338)
        Me.Panel5.TabIndex = 10
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.detalleLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.totalSunCategoriaLabel)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 296)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 9
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 10)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(246, 284)
        Me.TreeView1.TabIndex = 0
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoryClm, Me.idSubCategoriaClm, Me.nom_Cantegoria, Me.FromcClm, Me.PercentClm})
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(5, 22)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(547, 254)
        Me.dtg.TabIndex = 10
        Me.dtg.VirtualMode = True
        '
        'IdCategoryClm
        '
        Me.IdCategoryClm.DataPropertyName = "IdCategory"
        Me.IdCategoryClm.HeaderText = "Id Categoria"
        Me.IdCategoryClm.Name = "IdCategoryClm"
        Me.IdCategoryClm.ReadOnly = True
        Me.IdCategoryClm.Visible = False
        '
        'idSubCategoriaClm
        '
        Me.idSubCategoriaClm.DataPropertyName = "IdSubCategory"
        Me.idSubCategoriaClm.HeaderText = "id Sub Categoria"
        Me.idSubCategoriaClm.Name = "idSubCategoriaClm"
        Me.idSubCategoriaClm.ReadOnly = True
        Me.idSubCategoriaClm.Visible = False
        '
        'nom_Cantegoria
        '
        Me.nom_Cantegoria.DataPropertyName = "Nom_Category"
        Me.nom_Cantegoria.HeaderText = "Sub Categoría"
        Me.nom_Cantegoria.Name = "nom_Cantegoria"
        Me.nom_Cantegoria.ReadOnly = True
        Me.nom_Cantegoria.Width = 250
        '
        'FromcClm
        '
        Me.FromcClm.DataPropertyName = "FromC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FromcClm.DefaultCellStyle = DataGridViewCellStyle1
        Me.FromcClm.HeaderText = "A partir de:"
        Me.FromcClm.Name = "FromcClm"
        Me.FromcClm.Width = 120
        '
        'PercentClm
        '
        Me.PercentClm.DataPropertyName = "Percent"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PercentClm.DefaultCellStyle = DataGridViewCellStyle2
        Me.PercentClm.HeaderText = "Porcentage (%)"
        Me.PercentClm.Name = "PercentClm"
        Me.PercentClm.Width = 150
        '
        'detalleLabel
        '
        Me.detalleLabel.AutoSize = True
        Me.detalleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.detalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detalleLabel.Location = New System.Drawing.Point(5, 5)
        Me.detalleLabel.Name = "detalleLabel"
        Me.detalleLabel.Size = New System.Drawing.Size(154, 17)
        Me.detalleLabel.TabIndex = 0
        Me.detalleLabel.Text = "Detalle de la categoría:"
        '
        'totalSunCategoriaLabel
        '
        Me.totalSunCategoriaLabel.AutoSize = True
        Me.totalSunCategoriaLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.totalSunCategoriaLabel.Location = New System.Drawing.Point(5, 276)
        Me.totalSunCategoriaLabel.Name = "totalSunCategoriaLabel"
        Me.totalSunCategoriaLabel.Size = New System.Drawing.Size(0, 13)
        Me.totalSunCategoriaLabel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Estructura de la tarifa:"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(8, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(833, 19)
        Me.Panel4.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DescriptionRichTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8, 2, 8, 3)
        Me.Panel1.Size = New System.Drawing.Size(851, 80)
        Me.Panel1.TabIndex = 13
        '
        'frmSubCategoryRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 485)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.MinimumSize = New System.Drawing.Size(724, 511)
        Me.Name = "frmSubCategoryRates"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración de tarifas por sub categorias."
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents OkButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents detalleLabel As Label
    Friend WithEvents totalSunCategoriaLabel As Label
    Friend WithEvents dtg As DataGridView
    Friend WithEvents IdCategoryClm As DataGridViewTextBoxColumn
    Friend WithEvents idSubCategoriaClm As DataGridViewTextBoxColumn
    Friend WithEvents nom_Cantegoria As DataGridViewTextBoxColumn
    Friend WithEvents FromcClm As DataGridViewTextBoxColumn
    Friend WithEvents PercentClm As DataGridViewTextBoxColumn
End Class
