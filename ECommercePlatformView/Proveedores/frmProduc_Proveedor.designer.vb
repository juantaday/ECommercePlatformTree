<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduc_Proveedor
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SmenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.sMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.sMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnDeleteComp = New System.Windows.Forms.Button()
        Me.btnQuienVende = New System.Windows.Forms.Button()
        Me.btnRefres = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.BtnPrintTicket = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmenuNuevo, Me.sMenuEditar, Me.sMenuEliminar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'SmenuNuevo
        '
        Me.SmenuNuevo.Name = "SmenuNuevo"
        Me.SmenuNuevo.Size = New System.Drawing.Size(117, 22)
        Me.SmenuNuevo.Text = "Nuevo"
        '
        'sMenuEditar
        '
        Me.sMenuEditar.Name = "sMenuEditar"
        Me.sMenuEditar.Size = New System.Drawing.Size(117, 22)
        Me.sMenuEditar.Text = "Editar"
        '
        'sMenuEliminar
        '
        Me.sMenuEliminar.Name = "sMenuEliminar"
        Me.sMenuEliminar.Size = New System.Drawing.Size(117, 22)
        Me.sMenuEliminar.Text = "Eliminar"
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataListado.BackgroundColor = System.Drawing.Color.White
        Me.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataListado.Location = New System.Drawing.Point(12, 107)
        Me.dataListado.MultiSelect = False
        Me.dataListado.Name = "dataListado"
        Me.dataListado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataListado.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(845, 390)
        Me.dataListado.TabIndex = 16
        '
        'txtidProveedor
        '
        Me.txtidProveedor.Location = New System.Drawing.Point(683, 12)
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.Size = New System.Drawing.Size(91, 20)
        Me.txtidProveedor.TabIndex = 17
        Me.txtidProveedor.Text = "0"
        Me.txtidProveedor.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(175, 37)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Ninguno..."
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(12, 503)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(43, 13)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "Total: 0"
        '
        'btnDeleteComp
        '
        Me.btnDeleteComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteComp.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_Column_icon_48
        Me.btnDeleteComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteComp.Location = New System.Drawing.Point(686, 49)
        Me.btnDeleteComp.Name = "btnDeleteComp"
        Me.btnDeleteComp.Size = New System.Drawing.Size(170, 52)
        Me.btnDeleteComp.TabIndex = 8
        Me.btnDeleteComp.Text = "Eliminar Comparatico"
        Me.btnDeleteComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteComp.UseVisualStyleBackColor = True
        '
        'btnQuienVende
        '
        Me.btnQuienVende.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuienVende.Image = Global.ECommercePlatformView.My.Resources.Resources.Money_Calculator_icon_48
        Me.btnQuienVende.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuienVende.Location = New System.Drawing.Point(558, 49)
        Me.btnQuienVende.Name = "btnQuienVende"
        Me.btnQuienVende.Size = New System.Drawing.Size(125, 52)
        Me.btnQuienVende.TabIndex = 7
        Me.btnQuienVende.Text = "Comparativo"
        Me.btnQuienVende.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnQuienVende, "Comparativo de  costos con otros proveedores")
        Me.btnQuienVende.UseVisualStyleBackColor = True
        '
        'btnRefres
        '
        Me.btnRefres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefres.Image = Global.ECommercePlatformView.My.Resources.Resources.Refresh_icon_48
        Me.btnRefres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefres.Location = New System.Drawing.Point(294, 49)
        Me.btnRefres.Name = "btnRefres"
        Me.btnRefres.Size = New System.Drawing.Size(126, 52)
        Me.btnRefres.TabIndex = 6
        Me.btnRefres.Text = "Actualizar.."
        Me.btnRefres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefres.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.Image = Global.ECommercePlatformView.My.Resources.Resources.printer_icon_48
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(153, 49)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(135, 52)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Imprimir..."
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Imprimir en una impresora de tinta")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'BtnPrintTicket
        '
        Me.BtnPrintTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrintTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrintTicket.Image = Global.ECommercePlatformView.My.Resources.Resources.Ticket_icon
        Me.BtnPrintTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrintTicket.Location = New System.Drawing.Point(12, 49)
        Me.BtnPrintTicket.Name = "BtnPrintTicket"
        Me.BtnPrintTicket.Size = New System.Drawing.Size(135, 52)
        Me.BtnPrintTicket.TabIndex = 6
        Me.BtnPrintTicket.Text = "Impr.. Ticket"
        Me.BtnPrintTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnPrintTicket, "Impreme en impresona de ticket")
        Me.BtnPrintTicket.UseVisualStyleBackColor = True
        '
        'frmProduc_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 533)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtidProveedor)
        Me.Controls.Add(Me.dataListado)
        Me.Controls.Add(Me.btnDeleteComp)
        Me.Controls.Add(Me.btnQuienVende)
        Me.Controls.Add(Me.btnRefres)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.BtnPrintTicket)
        Me.Name = "frmProduc_Proveedor"
        Me.Text = "frmProduc_Proveedor"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteComp As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SmenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnQuienVende As System.Windows.Forms.Button
    Friend WithEvents BtnPrintTicket As System.Windows.Forms.Button
    Friend WithEvents dataListado As System.Windows.Forms.DataGridView
    Friend WithEvents txtidProveedor As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents btnRefres As System.Windows.Forms.Button
End Class
