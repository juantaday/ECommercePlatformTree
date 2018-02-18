<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.paneProveedor = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddProveedor = New System.Windows.Forms.Button()
        Me.btnDeleteProveedor = New System.Windows.Forms.Button()
        Me.datalist_ProveeVende = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridComprables = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.paneProveedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalist_ProveeVende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridComprables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paneProveedor
        '
        Me.paneProveedor.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.paneProveedor.Controls.Add(Me.GroupBox1)
        Me.paneProveedor.Controls.Add(Me.Label1)
        Me.paneProveedor.Controls.Add(Me.DataGridComprables)
        Me.paneProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneProveedor.Location = New System.Drawing.Point(0, 0)
        Me.paneProveedor.Name = "paneProveedor"
        Me.paneProveedor.Size = New System.Drawing.Size(428, 316)
        Me.paneProveedor.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAddProveedor)
        Me.GroupBox1.Controls.Add(Me.btnDeleteProveedor)
        Me.GroupBox1.Controls.Add(Me.datalist_ProveeVende)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 168)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 26)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Listado de proveedores de esta presentación:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detalle de la última compra."
        '
        'btnAddProveedor
        '
        Me.btnAddProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProveedor.Location = New System.Drawing.Point(226, 15)
        Me.btnAddProveedor.Name = "btnAddProveedor"
        Me.btnAddProveedor.Size = New System.Drawing.Size(82, 25)
        Me.btnAddProveedor.TabIndex = 32
        Me.btnAddProveedor.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnAddProveedor, "Agregar nuevo proveedor de este producto")
        Me.btnAddProveedor.UseVisualStyleBackColor = True
        Me.btnAddProveedor.Visible = False
        '
        'btnDeleteProveedor
        '
        Me.btnDeleteProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProveedor.Location = New System.Drawing.Point(314, 16)
        Me.btnDeleteProveedor.Name = "btnDeleteProveedor"
        Me.btnDeleteProveedor.Size = New System.Drawing.Size(82, 25)
        Me.btnDeleteProveedor.TabIndex = 31
        Me.btnDeleteProveedor.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.btnDeleteProveedor, "Eliminar como vendedor de este producto")
        Me.btnDeleteProveedor.UseVisualStyleBackColor = True
        '
        'datalist_ProveeVende
        '
        Me.datalist_ProveeVende.AllowUserToAddRows = False
        Me.datalist_ProveeVende.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalist_ProveeVende.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalist_ProveeVende.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalist_ProveeVende.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datalist_ProveeVende.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datalist_ProveeVende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalist_ProveeVende.GridColor = System.Drawing.Color.White
        Me.datalist_ProveeVende.Location = New System.Drawing.Point(10, 49)
        Me.datalist_ProveeVende.Name = "datalist_ProveeVende"
        Me.datalist_ProveeVende.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalist_ProveeVende.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datalist_ProveeVende.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalist_ProveeVende.Size = New System.Drawing.Size(386, 113)
        Me.datalist_ProveeVende.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Presentaciones en la que se compra"
        '
        'DataGridComprables
        '
        Me.DataGridComprables.AllowUserToAddRows = False
        Me.DataGridComprables.AllowUserToDeleteRows = False
        Me.DataGridComprables.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridComprables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridComprables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridComprables.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridComprables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridComprables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridComprables.GridColor = System.Drawing.Color.White
        Me.DataGridComprables.Location = New System.Drawing.Point(19, 26)
        Me.DataGridComprables.MultiSelect = False
        Me.DataGridComprables.Name = "DataGridComprables"
        Me.DataGridComprables.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridComprables.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridComprables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridComprables.Size = New System.Drawing.Size(397, 104)
        Me.DataGridComprables.TabIndex = 29
        '
        'frm_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 316)
        Me.Controls.Add(Me.paneProveedor)
        Me.Name = "frm_Proveedor"
        Me.Text = "PROVEEDORES"
        Me.paneProveedor.ResumeLayout(False)
        Me.paneProveedor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalist_ProveeVende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridComprables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents paneProveedor As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddProveedor As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDeleteProveedor As System.Windows.Forms.Button
    Friend WithEvents datalist_ProveeVende As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridComprables As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
