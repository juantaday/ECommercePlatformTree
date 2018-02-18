<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_DeudaProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList_DeudaProveedor))
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.TableLayoutPie = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.pagarLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.dtl = New System.Windows.Forms.DataGridView()
        Me.ButtonClm = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.idProveedorClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_FacturClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_documentClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompraClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPie.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        CType(Me.dtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelButton1.ForeColor = System.Drawing.Color.White
        Me.CancelButton1.Location = New System.Drawing.Point(637, 0)
        Me.CancelButton1.Margin = New System.Windows.Forms.Padding(4, 0, 13, 0)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(138, 41)
        Me.CancelButton1.TabIndex = 0
        Me.CancelButton1.Text = "Cancelar"
        Me.CancelButton1.UseVisualStyleBackColor = False
        '
        'TableLayoutPie
        '
        Me.TableLayoutPie.BackColor = System.Drawing.Color.Gainsboro
        Me.TableLayoutPie.ColumnCount = 3
        Me.TableLayoutPie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.62098!))
        Me.TableLayoutPie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75127!))
        Me.TableLayoutPie.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.62775!))
        Me.TableLayoutPie.Controls.Add(Me.CancelButton1, 2, 0)
        Me.TableLayoutPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPie.Location = New System.Drawing.Point(0, 547)
        Me.TableLayoutPie.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPie.Name = "TableLayoutPie"
        Me.TableLayoutPie.RowCount = 1
        Me.TableLayoutPie.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPie.Size = New System.Drawing.Size(788, 41)
        Me.TableLayoutPie.TabIndex = 17
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.84264!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08968!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.06768!))
        Me.TableLayoutPanel1.Controls.Add(Me.SelectAllButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CopyButton, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(788, 43)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'SelectAllButton
        '
        Me.SelectAllButton.BackColor = System.Drawing.Color.Black
        Me.SelectAllButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectAllButton.ForeColor = System.Drawing.Color.White
        Me.SelectAllButton.Image = CType(resources.GetObject("SelectAllButton.Image"), System.Drawing.Image)
        Me.SelectAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectAllButton.Location = New System.Drawing.Point(7, 0)
        Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(173, 43)
        Me.SelectAllButton.TabIndex = 0
        Me.SelectAllButton.Text = "Seleccionar"
        Me.SelectAllButton.UseVisualStyleBackColor = False
        '
        'CopyButton
        '
        Me.CopyButton.BackColor = System.Drawing.Color.Black
        Me.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CopyButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CopyButton.ForeColor = System.Drawing.Color.White
        Me.CopyButton.Image = CType(resources.GetObject("CopyButton.Image"), System.Drawing.Image)
        Me.CopyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopyButton.Location = New System.Drawing.Point(180, 0)
        Me.CopyButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(134, 43)
        Me.CopyButton.TabIndex = 1
        Me.CopyButton.Text = "Copiar"
        Me.CopyButton.UseVisualStyleBackColor = False
        '
        'pagarLinkLabel
        '
        Me.pagarLinkLabel.AutoSize = True
        Me.pagarLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagarLinkLabel.Location = New System.Drawing.Point(4, 32)
        Me.pagarLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pagarLinkLabel.Name = "pagarLinkLabel"
        Me.pagarLinkLabel.Size = New System.Drawing.Size(0, 17)
        Me.pagarLinkLabel.TabIndex = 19
        Me.pagarLinkLabel.Tag = "LinkLabel1"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(4, 10)
        Me.totalLabel.Margin = New System.Windows.Forms.Padding(4, 10, 4, 2)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(63, 20)
        Me.totalLabel.TabIndex = 20
        Me.totalLabel.Text = "Label1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.totalLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.pagarLinkLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(40, 471)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(724, 76)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(40, 504)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(764, 43)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(24, 504)
        Me.Panel2.TabIndex = 22
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.dtl)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDatos.Location = New System.Drawing.Point(40, 43)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(724, 428)
        Me.PanelDatos.TabIndex = 23
        '
        'dtl
        '
        Me.dtl.AllowUserToAddRows = False
        Me.dtl.AllowUserToDeleteRows = False
        Me.dtl.BackgroundColor = System.Drawing.Color.White
        Me.dtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonClm, Me.idProveedorClm, Me.ProveedorClm, Me.Cant_FacturClm, Me.Num_documentClm, Me.FechaCompraClm, Me.TotalClm})
        Me.dtl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtl.Location = New System.Drawing.Point(0, 0)
        Me.dtl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtl.Name = "dtl"
        Me.dtl.ReadOnly = True
        Me.dtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtl.Size = New System.Drawing.Size(724, 428)
        Me.dtl.TabIndex = 17
        '
        'ButtonClm
        '
        Me.ButtonClm.HeaderText = ""
        Me.ButtonClm.Name = "ButtonClm"
        Me.ButtonClm.ReadOnly = True
        '
        'idProveedorClm
        '
        Me.idProveedorClm.HeaderText = "IdProveedor"
        Me.idProveedorClm.Name = "idProveedorClm"
        Me.idProveedorClm.ReadOnly = True
        '
        'ProveedorClm
        '
        Me.ProveedorClm.HeaderText = "Proveedor"
        Me.ProveedorClm.Name = "ProveedorClm"
        Me.ProveedorClm.ReadOnly = True
        '
        'Cant_FacturClm
        '
        Me.Cant_FacturClm.HeaderText = "N° Facturas"
        Me.Cant_FacturClm.Name = "Cant_FacturClm"
        Me.Cant_FacturClm.ReadOnly = True
        '
        'Num_documentClm
        '
        Me.Num_documentClm.HeaderText = "Num. Documento"
        Me.Num_documentClm.Name = "Num_documentClm"
        Me.Num_documentClm.ReadOnly = True
        '
        'FechaCompraClm
        '
        Me.FechaCompraClm.HeaderText = "Fecha y Tota Factura"
        Me.FechaCompraClm.Name = "FechaCompraClm"
        Me.FechaCompraClm.ReadOnly = True
        '
        'TotalClm
        '
        Me.TotalClm.HeaderText = "Total Deuda"
        Me.TotalClm.Name = "TotalClm"
        Me.TotalClm.ReadOnly = True
        '
        'frmList_DeudaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 588)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPie)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmList_DeudaProveedor"
        Me.Text = "     ..Listado de deuda a proveedores"
        Me.TableLayoutPie.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.PanelDatos.ResumeLayout(False)
        CType(Me.dtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelButton1 As Button
    Friend WithEvents TableLayoutPie As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SelectAllButton As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents pagarLinkLabel As LinkLabel
    Friend WithEvents totalLabel As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelDatos As System.Windows.Forms.Panel
    Friend WithEvents dtl As DataGridView
    Friend WithEvents ButtonClm As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents idProveedorClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant_FacturClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_documentClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCompraClm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalClm As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
