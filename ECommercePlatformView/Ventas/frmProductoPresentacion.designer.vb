<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoPresentacion
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
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEmpaque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOferta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmApartir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.65922!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.34078!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(378, 304)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 29)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Seleccionar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(102, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(65, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblProducto.Location = New System.Drawing.Point(4, 9)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(88, 20)
        Me.lblProducto.TabIndex = 2
        Me.lblProducto.Text = "lblProducto"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(5, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 257)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.clmPresentacion, Me.clmEmpaque, Me.clmOferta, Me.clmApartir, Me.clmPrecioVenta, Me.clmMedida, Me.clmPrecioUnitario})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(548, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'txtMedida
        '
        Me.txtMedida.Location = New System.Drawing.Point(51, 304)
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.Size = New System.Drawing.Size(41, 20)
        Me.txtMedida.TabIndex = 6
        Me.txtMedida.Text = """"""
        Me.txtMedida.Visible = False
        '
        'txtPrecioUnidad
        '
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(98, 305)
        Me.txtPrecioUnidad.Name = "txtPrecioUnidad"
        Me.txtPrecioUnidad.Size = New System.Drawing.Size(41, 20)
        Me.txtPrecioUnidad.TabIndex = 6
        Me.txtPrecioUnidad.Text = "0"
        Me.txtPrecioUnidad.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "clmIdPresent"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 5
        '
        'clmPresentacion
        '
        Me.clmPresentacion.HeaderText = "Presentación"
        Me.clmPresentacion.Name = "clmPresentacion"
        Me.clmPresentacion.ReadOnly = True
        '
        'clmEmpaque
        '
        Me.clmEmpaque.HeaderText = "Empaque"
        Me.clmEmpaque.Name = "clmEmpaque"
        Me.clmEmpaque.ReadOnly = True
        '
        'clmOferta
        '
        Me.clmOferta.HeaderText = "Oferta"
        Me.clmOferta.Name = "clmOferta"
        Me.clmOferta.ReadOnly = True
        '
        'clmApartir
        '
        Me.clmApartir.HeaderText = "A partir de"
        Me.clmApartir.Name = "clmApartir"
        Me.clmApartir.ReadOnly = True
        '
        'clmPrecioVenta
        '
        Me.clmPrecioVenta.HeaderText = "Precio Venta Und "
        Me.clmPrecioVenta.Name = "clmPrecioVenta"
        Me.clmPrecioVenta.ReadOnly = True
        '
        'clmMedida
        '
        Me.clmMedida.HeaderText = "Medida"
        Me.clmMedida.Name = "clmMedida"
        Me.clmMedida.ReadOnly = True
        Me.clmMedida.Visible = False
        Me.clmMedida.Width = 5
        '
        'clmPrecioUnitario
        '
        Me.clmPrecioUnitario.HeaderText = "PrecioUnitario"
        Me.clmPrecioUnitario.Name = "clmPrecioUnitario"
        Me.clmPrecioUnitario.ReadOnly = True
        Me.clmPrecioUnitario.Visible = False
        '
        'frmProductoPresentacion
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(559, 340)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPrecioUnidad)
        Me.Controls.Add(Me.txtMedida)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductoPresentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Presentaciones y ofertas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtMedida As TextBox
    Friend WithEvents txtPrecioUnidad As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents clmPresentacion As DataGridViewTextBoxColumn
    Friend WithEvents clmEmpaque As DataGridViewTextBoxColumn
    Friend WithEvents clmOferta As DataGridViewTextBoxColumn
    Friend WithEvents clmApartir As DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioVenta As DataGridViewTextBoxColumn
    Friend WithEvents clmMedida As DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioUnitario As DataGridViewTextBoxColumn
End Class
