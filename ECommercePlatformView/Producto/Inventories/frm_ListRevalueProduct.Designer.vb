<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListRevalueProduct
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
        Me.PanelSelectBodega = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DescriptionBodegaLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBodegaComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ObservationRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PanelMenuNotFount = New System.Windows.Forms.Panel()
        Me.CloseListNotFountButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgNotFount = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalNotFountLabel = New System.Windows.Forms.Label()
        Me.dtgSelect = New System.Windows.Forms.DataGridView()
        Me.QuitarFiltroPanel = New System.Windows.Forms.Panel()
        Me.Panelfilter = New System.Windows.Forms.Panel()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.findButton = New System.Windows.Forms.Button()
        Me.QuitFilterButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CheckBoxSeelct = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.SaveStockButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SaveListButton = New System.Windows.Forms.Button()
        Me.AddNewListButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TotalItemLabel = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.ContextMenuAdd_new = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DesdeUnaCategoríaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodaLaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoloUnProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesdeLaListaDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesdeLaListraDeTransferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ContextMenuSaveAs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarObservacionesYGuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckItem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Nom_Comercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Und = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewPriceClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelSelectBodega.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelMenuNotFount.SuspendLayout()
        CType(Me.dtgNotFount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuitarFiltroPanel.SuspendLayout()
        Me.Panelfilter.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.ContextMenuAdd_new.SuspendLayout()
        Me.ContextMenuSaveAs.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSelectBodega
        '
        Me.PanelSelectBodega.BackColor = System.Drawing.Color.DarkTurquoise
        Me.PanelSelectBodega.Controls.Add(Me.Panel5)
        Me.PanelSelectBodega.Controls.Add(Me.Panel4)
        Me.PanelSelectBodega.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSelectBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSelectBodega.Location = New System.Drawing.Point(0, 0)
        Me.PanelSelectBodega.Name = "PanelSelectBodega"
        Me.PanelSelectBodega.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelSelectBodega.Size = New System.Drawing.Size(1108, 52)
        Me.PanelSelectBodega.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DescriptionBodegaLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(551, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(365, 42)
        Me.Panel5.TabIndex = 5
        '
        'DescriptionBodegaLabel
        '
        Me.DescriptionBodegaLabel.AutoSize = True
        Me.DescriptionBodegaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionBodegaLabel.Location = New System.Drawing.Point(5, 2)
        Me.DescriptionBodegaLabel.Name = "DescriptionBodegaLabel"
        Me.DescriptionBodegaLabel.Size = New System.Drawing.Size(0, 13)
        Me.DescriptionBodegaLabel.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.ListBodegaComboBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(546, 42)
        Me.Panel4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione el local o bodega:"
        '
        'ListBodegaComboBox
        '
        Me.ListBodegaComboBox.FormattingEnabled = True
        Me.ListBodegaComboBox.Location = New System.Drawing.Point(223, 7)
        Me.ListBodegaComboBox.Name = "ListBodegaComboBox"
        Me.ListBodegaComboBox.Size = New System.Drawing.Size(317, 28)
        Me.ListBodegaComboBox.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGreen
        Me.Panel2.Controls.Add(Me.ObservationRichTextBox)
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel2.Size = New System.Drawing.Size(1108, 402)
        Me.Panel2.TabIndex = 1
        '
        'ObservationRichTextBox
        '
        Me.ObservationRichTextBox.Location = New System.Drawing.Point(427, 6)
        Me.ObservationRichTextBox.Name = "ObservationRichTextBox"
        Me.ObservationRichTextBox.Size = New System.Drawing.Size(51, 15)
        Me.ObservationRichTextBox.TabIndex = 2
        Me.ObservationRichTextBox.Text = ""
        Me.ObservationRichTextBox.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel8)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtgSelect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.QuitarFiltroPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1092, 366)
        Me.SplitContainer1.SplitterDistance = 269
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.PanelMenuNotFount)
        Me.Panel8.Controls.Add(Me.dtgNotFount)
        Me.Panel8.Controls.Add(Me.totalNotFountLabel)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel8.Size = New System.Drawing.Size(269, 366)
        Me.Panel8.TabIndex = 7
        '
        'PanelMenuNotFount
        '
        Me.PanelMenuNotFount.Controls.Add(Me.CloseListNotFountButton)
        Me.PanelMenuNotFount.Controls.Add(Me.Label4)
        Me.PanelMenuNotFount.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuNotFount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenuNotFount.Location = New System.Drawing.Point(2, 2)
        Me.PanelMenuNotFount.Name = "PanelMenuNotFount"
        Me.PanelMenuNotFount.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelMenuNotFount.Size = New System.Drawing.Size(263, 23)
        Me.PanelMenuNotFount.TabIndex = 1
        '
        'CloseListNotFountButton
        '
        Me.CloseListNotFountButton.BackColor = System.Drawing.Color.LightGreen
        Me.CloseListNotFountButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseListNotFountButton.Location = New System.Drawing.Point(234, 1)
        Me.CloseListNotFountButton.Name = "CloseListNotFountButton"
        Me.CloseListNotFountButton.Size = New System.Drawing.Size(28, 21)
        Me.CloseListNotFountButton.TabIndex = 1
        Me.CloseListNotFountButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(1, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estos productos ya estan en la listado."
        '
        'dtgNotFount
        '
        Me.dtgNotFount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNotFount.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dtgNotFount.Cursor = System.Windows.Forms.Cursors.No
        Me.dtgNotFount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgNotFount.Location = New System.Drawing.Point(2, 2)
        Me.dtgNotFount.Name = "dtgNotFount"
        Me.dtgNotFount.Size = New System.Drawing.Size(263, 343)
        Me.dtgNotFount.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "CheckItem"
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom_Comercial"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Und"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Medida en stock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NewStock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nuevo stock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'totalNotFountLabel
        '
        Me.totalNotFountLabel.AutoSize = True
        Me.totalNotFountLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.totalNotFountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalNotFountLabel.Location = New System.Drawing.Point(2, 345)
        Me.totalNotFountLabel.Name = "totalNotFountLabel"
        Me.totalNotFountLabel.Size = New System.Drawing.Size(51, 17)
        Me.totalNotFountLabel.TabIndex = 6
        Me.totalNotFountLabel.Text = "Label2"
        '
        'dtgSelect
        '
        Me.dtgSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSelect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.CheckItem, Me.Nom_Comercial, Me.Und, Me.Stock, Me.NewStock, Me.NewPriceClm})
        Me.dtgSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgSelect.Location = New System.Drawing.Point(0, 81)
        Me.dtgSelect.Name = "dtgSelect"
        Me.dtgSelect.Size = New System.Drawing.Size(819, 285)
        Me.dtgSelect.TabIndex = 4
        '
        'QuitarFiltroPanel
        '
        Me.QuitarFiltroPanel.BackColor = System.Drawing.SystemColors.Window
        Me.QuitarFiltroPanel.Controls.Add(Me.Panelfilter)
        Me.QuitarFiltroPanel.Controls.Add(Me.QuitFilterButton)
        Me.QuitarFiltroPanel.Controls.Add(Me.DeleteButton)
        Me.QuitarFiltroPanel.Controls.Add(Me.CheckBoxSeelct)
        Me.QuitarFiltroPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.QuitarFiltroPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitarFiltroPanel.Location = New System.Drawing.Point(0, 52)
        Me.QuitarFiltroPanel.Name = "QuitarFiltroPanel"
        Me.QuitarFiltroPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.QuitarFiltroPanel.Size = New System.Drawing.Size(819, 29)
        Me.QuitarFiltroPanel.TabIndex = 6
        '
        'Panelfilter
        '
        Me.Panelfilter.BackColor = System.Drawing.Color.White
        Me.Panelfilter.Controls.Add(Me.FindTextBox)
        Me.Panelfilter.Controls.Add(Me.findButton)
        Me.Panelfilter.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panelfilter.Location = New System.Drawing.Point(509, 2)
        Me.Panelfilter.Name = "Panelfilter"
        Me.Panelfilter.Padding = New System.Windows.Forms.Padding(1)
        Me.Panelfilter.Size = New System.Drawing.Size(308, 25)
        Me.Panelfilter.TabIndex = 8
        '
        'FindTextBox
        '
        Me.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindTextBox.Location = New System.Drawing.Point(1, 1)
        Me.FindTextBox.Multiline = True
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(270, 23)
        Me.FindTextBox.TabIndex = 7
        '
        'findButton
        '
        Me.findButton.BackColor = System.Drawing.Color.LightGreen
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.Enabled = False
        Me.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.findButton.Location = New System.Drawing.Point(271, 1)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(36, 23)
        Me.findButton.TabIndex = 6
        Me.findButton.UseVisualStyleBackColor = False
        '
        'QuitFilterButton
        '
        Me.QuitFilterButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.QuitFilterButton.Image = Global.ECommercePlatformView.My.Resources.Resources.not_Filter_16
        Me.QuitFilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QuitFilterButton.Location = New System.Drawing.Point(284, 2)
        Me.QuitFilterButton.Name = "QuitFilterButton"
        Me.QuitFilterButton.Size = New System.Drawing.Size(144, 25)
        Me.QuitFilterButton.TabIndex = 5
        Me.QuitFilterButton.Text = "Quitar el filtro"
        Me.QuitFilterButton.UseVisualStyleBackColor = True
        Me.QuitFilterButton.Visible = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.ForeColor = System.Drawing.Color.Red
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(198, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(86, 25)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "Eliminar"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = True
        Me.DeleteButton.Visible = False
        '
        'CheckBoxSeelct
        '
        Me.CheckBoxSeelct.AutoSize = True
        Me.CheckBoxSeelct.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBoxSeelct.Location = New System.Drawing.Point(2, 2)
        Me.CheckBoxSeelct.Name = "CheckBoxSeelct"
        Me.CheckBoxSeelct.Padding = New System.Windows.Forms.Padding(50, 1, 5, 1)
        Me.CheckBoxSeelct.Size = New System.Drawing.Size(196, 25)
        Me.CheckBoxSeelct.TabIndex = 6
        Me.CheckBoxSeelct.Text = "Seleccionar todo.."
        Me.CheckBoxSeelct.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.SaveStockButton)
        Me.Panel6.Controls.Add(Me.PrintButton)
        Me.Panel6.Controls.Add(Me.SaveListButton)
        Me.Panel6.Controls.Add(Me.AddNewListButton)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(819, 52)
        Me.Panel6.TabIndex = 3
        '
        'SaveStockButton
        '
        Me.SaveStockButton.AutoSize = True
        Me.SaveStockButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SaveStockButton.Enabled = False
        Me.SaveStockButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Transfer_Data_32
        Me.SaveStockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveStockButton.Location = New System.Drawing.Point(369, 5)
        Me.SaveStockButton.Name = "SaveStockButton"
        Me.SaveStockButton.Size = New System.Drawing.Size(202, 40)
        Me.SaveStockButton.TabIndex = 4
        Me.SaveStockButton.Text = "Guardar el nuevo stock"
        Me.SaveStockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveStockButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_32
        Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.Location = New System.Drawing.Point(242, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(127, 40)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "Imprimir lista"
        Me.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'SaveListButton
        '
        Me.SaveListButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SaveListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_32
        Me.SaveListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveListButton.Location = New System.Drawing.Point(114, 5)
        Me.SaveListButton.Name = "SaveListButton"
        Me.SaveListButton.Size = New System.Drawing.Size(128, 40)
        Me.SaveListButton.TabIndex = 2
        Me.SaveListButton.Text = "Guardar lista"
        Me.SaveListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveListButton.UseVisualStyleBackColor = True
        '
        'AddNewListButton
        '
        Me.AddNewListButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewListButton.Image = Global.ECommercePlatformView.My.Resources.Resources.New_green_32
        Me.AddNewListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewListButton.Location = New System.Drawing.Point(5, 5)
        Me.AddNewListButton.Name = "AddNewListButton"
        Me.AddNewListButton.Size = New System.Drawing.Size(109, 40)
        Me.AddNewListButton.TabIndex = 5
        Me.AddNewListButton.Text = "Agregar.."
        Me.AddNewListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewListButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Productos en lista de modificación:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.closeButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 454)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(1108, 40)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.AutoSize = True
        Me.Panel7.Controls.Add(Me.TotalItemLabel)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(61, 30)
        Me.Panel7.TabIndex = 1
        '
        'TotalItemLabel
        '
        Me.TotalItemLabel.AutoSize = True
        Me.TotalItemLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalItemLabel.Location = New System.Drawing.Point(2, 2)
        Me.TotalItemLabel.Name = "TotalItemLabel"
        Me.TotalItemLabel.Size = New System.Drawing.Size(57, 17)
        Me.TotalItemLabel.TabIndex = 2
        Me.TotalItemLabel.Text = "Label2"
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Black
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(1015, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(88, 30)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "Cerrar."
        Me.closeButton.UseVisualStyleBackColor = False
        '
        'ContextMenuAdd_new
        '
        Me.ContextMenuAdd_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesdeUnaCategoríaToolStripMenuItem, Me.TodaLaListaToolStripMenuItem, Me.SoloUnProductoToolStripMenuItem, Me.DesdeLaListaDeComprasToolStripMenuItem, Me.DesdeLaListraDeTransferenciasToolStripMenuItem})
        Me.ContextMenuAdd_new.Name = "ContextMenuAdd_new"
        Me.ContextMenuAdd_new.Size = New System.Drawing.Size(239, 114)
        '
        'DesdeUnaCategoríaToolStripMenuItem
        '
        Me.DesdeUnaCategoríaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Category_32
        Me.DesdeUnaCategoríaToolStripMenuItem.Name = "DesdeUnaCategoríaToolStripMenuItem"
        Me.DesdeUnaCategoríaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DesdeUnaCategoríaToolStripMenuItem.Text = "Desde una categoría"
        '
        'TodaLaListaToolStripMenuItem
        '
        Me.TodaLaListaToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_list_32
        Me.TodaLaListaToolStripMenuItem.Name = "TodaLaListaToolStripMenuItem"
        Me.TodaLaListaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.TodaLaListaToolStripMenuItem.Text = "Toda la lista"
        '
        'SoloUnProductoToolStripMenuItem
        '
        Me.SoloUnProductoToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.producto_24
        Me.SoloUnProductoToolStripMenuItem.Name = "SoloUnProductoToolStripMenuItem"
        Me.SoloUnProductoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.SoloUnProductoToolStripMenuItem.Text = "Solo un producto."
        '
        'DesdeLaListaDeComprasToolStripMenuItem
        '
        Me.DesdeLaListaDeComprasToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.compra_32
        Me.DesdeLaListaDeComprasToolStripMenuItem.Name = "DesdeLaListaDeComprasToolStripMenuItem"
        Me.DesdeLaListaDeComprasToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DesdeLaListaDeComprasToolStripMenuItem.Text = "Desde la lista de compras"
        '
        'DesdeLaListraDeTransferenciasToolStripMenuItem
        '
        Me.DesdeLaListraDeTransferenciasToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Tansfer_32
        Me.DesdeLaListraDeTransferenciasToolStripMenuItem.Name = "DesdeLaListraDeTransferenciasToolStripMenuItem"
        Me.DesdeLaListraDeTransferenciasToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.DesdeLaListraDeTransferenciasToolStripMenuItem.Text = "Desde la listra de transferencias"
        '
        'ContextMenuSaveAs
        '
        Me.ContextMenuSaveAs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarObservacionesYGuardarToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.ContextMenuSaveAs.Name = "ContextMenuSaveAs"
        Me.ContextMenuSaveAs.Size = New System.Drawing.Size(254, 48)
        '
        'CambiarObservacionesYGuardarToolStripMenuItem
        '
        Me.CambiarObservacionesYGuardarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.saveAs_32
        Me.CambiarObservacionesYGuardarToolStripMenuItem.Name = "CambiarObservacionesYGuardarToolStripMenuItem"
        Me.CambiarObservacionesYGuardarToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CambiarObservacionesYGuardarToolStripMenuItem.Text = "Cambiar observaciones y guardar."
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_32
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar."
        '
        'idProducto
        '
        Me.idProducto.DataPropertyName = "idProducto"
        Me.idProducto.HeaderText = "Id Producto"
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        Me.idProducto.Visible = False
        '
        'CheckItem
        '
        Me.CheckItem.DataPropertyName = "CheckItem"
        Me.CheckItem.HeaderText = ""
        Me.CheckItem.Name = "CheckItem"
        Me.CheckItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CheckItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CheckItem.Width = 40
        '
        'Nom_Comercial
        '
        Me.Nom_Comercial.DataPropertyName = "Nom_Comercial"
        Me.Nom_Comercial.HeaderText = "Producto"
        Me.Nom_Comercial.Name = "Nom_Comercial"
        Me.Nom_Comercial.ReadOnly = True
        Me.Nom_Comercial.Width = 250
        '
        'Und
        '
        Me.Und.DataPropertyName = "Und"
        Me.Und.HeaderText = "Medida en stock"
        Me.Und.Name = "Und"
        Me.Und.ReadOnly = True
        Me.Und.Width = 150
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Stock"
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'NewStock
        '
        Me.NewStock.DataPropertyName = "NewStock"
        Me.NewStock.HeaderText = "Precio promedio"
        Me.NewStock.Name = "NewStock"
        Me.NewStock.ReadOnly = True
        Me.NewStock.ToolTipText = "Precio promedio en el local o bodega"
        '
        'NewPriceClm
        '
        Me.NewPriceClm.HeaderText = "Nuevo precio"
        Me.NewPriceClm.Name = "NewPriceClm"
        '
        'frm_ListRevalueProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 494)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelSelectBodega)
        Me.Name = "frm_ListRevalueProduct"
        Me.Text = "Lista de actualización de inventario."
        Me.PanelSelectBodega.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PanelMenuNotFount.ResumeLayout(False)
        Me.PanelMenuNotFount.PerformLayout()
        CType(Me.dtgNotFount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuitarFiltroPanel.ResumeLayout(False)
        Me.QuitarFiltroPanel.PerformLayout()
        Me.Panelfilter.ResumeLayout(False)
        Me.Panelfilter.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ContextMenuAdd_new.ResumeLayout(False)
        Me.ContextMenuSaveAs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSelectBodega As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBodegaComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DescriptionBodegaLabel As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PanelMenuNotFount As Panel
    Friend WithEvents CloseListNotFountButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PrintButton As Button
    Friend WithEvents SaveListButton As Button
    Friend WithEvents SaveStockButton As Button
    Friend WithEvents dtgSelect As DataGridView
    Friend WithEvents AddNewListButton As Button
    Friend WithEvents ContextMenuAdd_new As ContextMenuStrip
    Friend WithEvents DesdeUnaCategoríaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodaLaListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoloUnProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panelfilter As Panel
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents QuitFilterButton As Button
    Friend WithEvents QuitarFiltroPanel As Panel
    Friend WithEvents CheckBoxSeelct As CheckBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents dtgNotFount As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents closeButton As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TotalItemLabel As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents totalNotFountLabel As Label
    Friend WithEvents ObservationRichTextBox As RichTextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ContextMenuSaveAs As ContextMenuStrip
    Friend WithEvents CambiarObservacionesYGuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesdeLaListaDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesdeLaListraDeTransferenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents CheckItem As DataGridViewCheckBoxColumn
    Friend WithEvents Nom_Comercial As DataGridViewTextBoxColumn
    Friend WithEvents Und As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents NewStock As DataGridViewTextBoxColumn
    Friend WithEvents NewPriceClm As DataGridViewTextBoxColumn
End Class
