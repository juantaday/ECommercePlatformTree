<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewCombinedDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewCombinedDetail))
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.DataListView1 = New BrightIdeasSoftware.DataListView()
        Me.idPresentacionclmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Nom_ComercialClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PresentacionPrintClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Cant_PresentClmD = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioCompraClmd = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalCompraClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.precioVentaClmD = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.totalVentaClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.totalVentaLabel = New System.Windows.Forms.Label()
        Me.totalCompraLabel = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New System.Windows.Forms.Panel()
        Me.CountButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.NewCombinedButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nom_ComercialLabel = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelDetail.SuspendLayout()
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDetail
        '
        Me.PanelDetail.BackgroundImage = CType(resources.GetObject("PanelDetail.BackgroundImage"), System.Drawing.Image)
        Me.PanelDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.DataListView1)
        Me.PanelDetail.Controls.Add(Me.Panel2)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel2)
        Me.PanelDetail.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetail.Location = New System.Drawing.Point(0, 0)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PanelDetail.Size = New System.Drawing.Size(712, 361)
        Me.PanelDetail.TabIndex = 4
        '
        'DataListView1
        '
        Me.DataListView1.AllColumns.Add(Me.idPresentacionclmd)
        Me.DataListView1.AllColumns.Add(Me.Nom_ComercialClmd)
        Me.DataListView1.AllColumns.Add(Me.PresentacionPrintClmd)
        Me.DataListView1.AllColumns.Add(Me.Cant_PresentClmD)
        Me.DataListView1.AllColumns.Add(Me.precioCompraClmd)
        Me.DataListView1.AllColumns.Add(Me.totalCompraClm)
        Me.DataListView1.AllColumns.Add(Me.precioVentaClmD)
        Me.DataListView1.AllColumns.Add(Me.totalVentaClm)
        Me.DataListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataListView1.AutoGenerateColumns = False
        Me.DataListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick
        Me.DataListView1.CellEditTabChangesRows = True
        Me.DataListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idPresentacionclmd, Me.Nom_ComercialClmd, Me.PresentacionPrintClmd, Me.Cant_PresentClmD, Me.precioCompraClmd, Me.totalCompraClm, Me.precioVentaClmD, Me.totalVentaClm})
        Me.DataListView1.DataSource = Nothing
        Me.DataListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListView1.EmptyListMsg = "No existe informacion Sugerimos que agrege nuevos productos"
        Me.DataListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataListView1.FullRowSelect = True
        Me.DataListView1.HeaderMaximumHeight = 80
        Me.DataListView1.HeaderWordWrap = True
        Me.DataListView1.HideSelection = False
        Me.DataListView1.IncludeColumnHeadersInCopy = True
        Me.DataListView1.IncludeHiddenColumnsInDataTransfer = True
        Me.DataListView1.Location = New System.Drawing.Point(2, 62)
        Me.DataListView1.Name = "DataListView1"
        Me.DataListView1.OwnerDraw = True
        Me.DataListView1.ShowGroups = False
        Me.DataListView1.ShowItemToolTips = True
        Me.DataListView1.Size = New System.Drawing.Size(706, 193)
        Me.DataListView1.TabIndex = 2
        Me.DataListView1.UseAlternatingBackColors = True
        Me.DataListView1.UseCompatibleStateImageBehavior = False
        Me.DataListView1.View = System.Windows.Forms.View.Details
        '
        'idPresentacionclmd
        '
        Me.idPresentacionclmd.AspectName = "idPresentacion"
        Me.idPresentacionclmd.IsVisible = False
        Me.idPresentacionclmd.Text = "idPresentacion"
        Me.idPresentacionclmd.Width = 0
        '
        'Nom_ComercialClmd
        '
        Me.Nom_ComercialClmd.AspectName = "Nom_Comercial"
        Me.Nom_ComercialClmd.Text = "Nom_Comercial"
        Me.Nom_ComercialClmd.Width = 250
        '
        'PresentacionPrintClmd
        '
        Me.PresentacionPrintClmd.AspectName = "PresentacionPrint"
        Me.PresentacionPrintClmd.Text = "Empaque"
        Me.PresentacionPrintClmd.Width = 100
        '
        'Cant_PresentClmD
        '
        Me.Cant_PresentClmD.AspectName = "Cant_Conbined"
        Me.Cant_PresentClmD.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Cant_PresentClmD.Text = "Cantidad"
        Me.Cant_PresentClmD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cant_PresentClmD.Width = 80
        '
        'precioCompraClmd
        '
        Me.precioCompraClmd.AspectName = "precioCompra"
        Me.precioCompraClmd.AspectToStringFormat = "{0:C5}"
        Me.precioCompraClmd.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioCompraClmd.Text = "Precio compra Unit"
        Me.precioCompraClmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioCompraClmd.Width = 150
        '
        'totalCompraClm
        '
        Me.totalCompraClm.AspectToStringFormat = "{0:C5}"
        Me.totalCompraClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalCompraClm.Text = "Total Compra"
        Me.totalCompraClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalCompraClm.Width = 120
        '
        'precioVentaClmD
        '
        Me.precioVentaClmD.AspectName = "precioVenta"
        Me.precioVentaClmD.AspectToStringFormat = "{0:C5}"
        Me.precioVentaClmD.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioVentaClmD.Text = "Precio venta Unit"
        Me.precioVentaClmD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.precioVentaClmD.Width = 120
        '
        'totalVentaClm
        '
        Me.totalVentaClm.AspectToStringFormat = "{0:C5}"
        Me.totalVentaClm.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalVentaClm.Text = "Total Venta"
        Me.totalVentaClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalVentaClm.Width = 120
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.totalVentaLabel)
        Me.Panel2.Controls.Add(Me.totalCompraLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(2, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(706, 66)
        Me.Panel2.TabIndex = 6
        '
        'totalVentaLabel
        '
        Me.totalVentaLabel.AutoSize = True
        Me.totalVentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalVentaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalVentaLabel.Location = New System.Drawing.Point(5, 34)
        Me.totalVentaLabel.Name = "totalVentaLabel"
        Me.totalVentaLabel.Size = New System.Drawing.Size(250, 20)
        Me.totalVentaLabel.TabIndex = 1
        Me.totalVentaLabel.Text = "Total al precio venta normal: 0"
        '
        'totalCompraLabel
        '
        Me.totalCompraLabel.AutoSize = True
        Me.totalCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCompraLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalCompraLabel.Location = New System.Drawing.Point(5, 5)
        Me.totalCompraLabel.Name = "totalCompraLabel"
        Me.totalCompraLabel.Size = New System.Drawing.Size(187, 20)
        Me.totalCompraLabel.TabIndex = 0
        Me.totalCompraLabel.Text = "Total precio compra: 0"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel2.Controls.Add(Me.Button1)
        Me.BunifuGradientPanel2.Controls.Add(Me.Button2)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(2, 321)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(706, 38)
        Me.BunifuGradientPanel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(541, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aplicar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(612, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 34)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel1.Controls.Add(Me.CountButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.DeleteButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.NewCombinedButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(2, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(706, 62)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'CountButton
        '
        Me.CountButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CountButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Count_201
        Me.CountButton.Location = New System.Drawing.Point(104, 30)
        Me.CountButton.Name = "CountButton"
        Me.CountButton.Size = New System.Drawing.Size(37, 28)
        Me.CountButton.TabIndex = 3
        Me.CountButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.Location = New System.Drawing.Point(67, 30)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(37, 28)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'NewCombinedButton
        '
        Me.NewCombinedButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.NewCombinedButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.NewCombinedButton.Location = New System.Drawing.Point(30, 30)
        Me.NewCombinedButton.Name = "NewCombinedButton"
        Me.NewCombinedButton.Size = New System.Drawing.Size(37, 28)
        Me.NewCombinedButton.TabIndex = 1
        Me.NewCombinedButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(2, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 28)
        Me.Panel4.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Nom_ComercialLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 28)
        Me.Panel1.TabIndex = 0
        '
        'Nom_ComercialLabel
        '
        Me.Nom_ComercialLabel.AutoSize = True
        Me.Nom_ComercialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_ComercialLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Nom_ComercialLabel.Location = New System.Drawing.Point(2, 5)
        Me.Nom_ComercialLabel.Name = "Nom_ComercialLabel"
        Me.Nom_ComercialLabel.Size = New System.Drawing.Size(57, 17)
        Me.Nom_ComercialLabel.TabIndex = 0
        Me.Nom_ComercialLabel.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmViewCombinedDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 361)
        Me.Controls.Add(Me.PanelDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewCombinedDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de productos combindos.."
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.DataListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents DataListView1 As BrightIdeasSoftware.DataListView
    Friend WithEvents idPresentacionclmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Nom_ComercialClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PresentacionPrintClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Cant_PresentClmD As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioCompraClmd As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalCompraClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents precioVentaClmD As BrightIdeasSoftware.OLVColumn
    Friend WithEvents totalVentaClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents totalVentaLabel As Label
    Friend WithEvents totalCompraLabel As Label
    Friend WithEvents BunifuGradientPanel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BunifuGradientPanel1 As Panel
    Friend WithEvents CountButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewCombinedButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nom_ComercialLabel As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
