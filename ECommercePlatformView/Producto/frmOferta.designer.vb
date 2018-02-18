<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOferta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClnPorcenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmUsdUnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClnOferta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClnFechaExp = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.txtIndexRow = New System.Windows.Forms.TextBox()
        Me.txtIdPresent = New System.Windows.Forms.TextBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.presentacionDescLabel = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.precioNormalLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.4555!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.5445!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(590, 335)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(193, 37)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(94, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(88, 30)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 30)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClnCantidad, Me.ClnPorcenta, Me.ClmUsdUnd, Me.ClnOferta, Me.ClnFechaExp, Me.clnFecha})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 45
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(771, 224)
        Me.DataGridView1.TabIndex = 5
        '
        'ClnCantidad
        '
        Me.ClnCantidad.Frozen = True
        Me.ClnCantidad.HeaderText = "A partir de"
        Me.ClnCantidad.Name = "ClnCantidad"
        Me.ClnCantidad.ReadOnly = True
        Me.ClnCantidad.ToolTipText = "A pertir de esta cantidad hara el descueto"
        '
        'ClnPorcenta
        '
        Me.ClnPorcenta.Frozen = True
        Me.ClnPorcenta.HeaderText = "Descuento (%)"
        Me.ClnPorcenta.Name = "ClnPorcenta"
        Me.ClnPorcenta.ReadOnly = True
        '
        'ClmUsdUnd
        '
        Me.ClmUsdUnd.Frozen = True
        Me.ClmUsdUnd.HeaderText = "Descuento por Und. ($)"
        Me.ClmUsdUnd.Name = "ClmUsdUnd"
        Me.ClmUsdUnd.ReadOnly = True
        Me.ClmUsdUnd.ToolTipText = "Vavor de precio po unidad"
        Me.ClmUsdUnd.Width = 120
        '
        'ClnOferta
        '
        Me.ClnOferta.Frozen = True
        Me.ClnOferta.HeaderText = "Descuento total ($)"
        Me.ClnOferta.Name = "ClnOferta"
        Me.ClnOferta.ReadOnly = True
        Me.ClnOferta.Width = 170
        '
        'ClnFechaExp
        '
        Me.ClnFechaExp.Frozen = True
        Me.ClnFechaExp.HeaderText = "Expirable"
        Me.ClnFechaExp.Name = "ClnFechaExp"
        Me.ClnFechaExp.ReadOnly = True
        Me.ClnFechaExp.ToolTipText = "La promocion tiene una fecha de expiración"
        '
        'clnFecha
        '
        Me.clnFecha.Frozen = True
        Me.clnFecha.HeaderText = "Fecha de expiración"
        Me.clnFecha.Name = "clnFecha"
        Me.clnFecha.ReadOnly = True
        Me.clnFecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clnFecha.Width = 150
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edid_pencil_32
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(129, 58)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(95, 39)
        Me.EditButton.TabIndex = 4
        Me.EditButton.Text = "Modificar"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.EditButton, "Agregar o modificar la oferta")
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(227, 58)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(95, 39)
        Me.DeleteButton.TabIndex = 14
        Me.DeleteButton.Text = "Eliminar"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.DeleteButton, "Agregar o modificar la oferta")
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'txtIndexRow
        '
        Me.txtIndexRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIndexRow.Location = New System.Drawing.Point(94, 348)
        Me.txtIndexRow.Name = "txtIndexRow"
        Me.txtIndexRow.Size = New System.Drawing.Size(35, 20)
        Me.txtIndexRow.TabIndex = 7
        Me.txtIndexRow.Text = "-1"
        Me.txtIndexRow.Visible = False
        '
        'txtIdPresent
        '
        Me.txtIdPresent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIdPresent.Location = New System.Drawing.Point(53, 345)
        Me.txtIdPresent.Name = "txtIdPresent"
        Me.txtIdPresent.Size = New System.Drawing.Size(35, 20)
        Me.txtIdPresent.TabIndex = 7
        Me.txtIdPresent.Text = "0"
        Me.txtIdPresent.Visible = False
        '
        'txtflag
        '
        Me.txtflag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtflag.Location = New System.Drawing.Point(12, 345)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(35, 20)
        Me.txtflag.TabIndex = 7
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblProducto.Location = New System.Drawing.Point(3, 2)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(116, 29)
        Me.lblProducto.TabIndex = 13
        Me.lblProducto.Text = "Producto."
        '
        'presentacionDescLabel
        '
        Me.presentacionDescLabel.AutoSize = True
        Me.presentacionDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentacionDescLabel.ForeColor = System.Drawing.Color.Red
        Me.presentacionDescLabel.Location = New System.Drawing.Point(4, 31)
        Me.presentacionDescLabel.Name = "presentacionDescLabel"
        Me.presentacionDescLabel.Size = New System.Drawing.Size(73, 24)
        Me.presentacionDescLabel.TabIndex = 13
        Me.presentacionDescLabel.Text = "Medida"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(12, 58)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(114, 39)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nueva oferta"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(334, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Listado de ofertas para:"
        '
        'precioNormalLabel
        '
        Me.precioNormalLabel.AutoSize = True
        Me.precioNormalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precioNormalLabel.ForeColor = System.Drawing.Color.Red
        Me.precioNormalLabel.Location = New System.Drawing.Point(240, 31)
        Me.precioNormalLabel.Name = "precioNormalLabel"
        Me.precioNormalLabel.Size = New System.Drawing.Size(73, 24)
        Me.precioNormalLabel.TabIndex = 16
        Me.precioNormalLabel.Text = "Medida"
        '
        'frmOferta
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(795, 376)
        Me.Controls.Add(Me.precioNormalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.presentacionDescLabel)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.txtIdPresent)
        Me.Controls.Add(Me.txtIndexRow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOferta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   Administrando ofertas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents txtIndexRow As System.Windows.Forms.TextBox
    Friend WithEvents txtIdPresent As System.Windows.Forms.TextBox
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents presentacionDescLabel As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ClnCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ClnPorcenta As DataGridViewTextBoxColumn
    Friend WithEvents ClmUsdUnd As DataGridViewTextBoxColumn
    Friend WithEvents ClnOferta As DataGridViewTextBoxColumn
    Friend WithEvents ClnFechaExp As DataGridViewCheckBoxColumn
    Friend WithEvents clnFecha As DataGridViewTextBoxColumn
    Friend WithEvents precioNormalLabel As Label
End Class
