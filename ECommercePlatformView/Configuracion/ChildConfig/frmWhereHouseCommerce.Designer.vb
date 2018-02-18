<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhereHouseCommerce
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
        Me.PanelViewWhereHouse = New System.Windows.Forms.Panel()
        Me.PanelConfig = New System.Windows.Forms.Panel()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.tabBanck = New System.Windows.Forms.TabPage()
        Me.BanckLisListView = New System.Windows.Forms.ListView()
        Me.idBanckWhereHouseClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OwnerClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BancoClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NumCuantaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeCuentaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bodegaSelectedLabel1 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.addNewBanckButton = New System.Windows.Forms.Button()
        Me.tabVirtualBox = New System.Windows.Forms.TabPage()
        Me.VirtualListView = New System.Windows.Forms.ListView()
        Me.idVirtualBoxClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameVirtualBoxClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.saldoClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RemarkClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idTypoCajaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BodegaSelectedLabel2 = New System.Windows.Forms.Label()
        Me.DeleteVirtualboxButton = New System.Windows.Forms.Button()
        Me.EditVirtualBoxButton = New System.Windows.Forms.Button()
        Me.AddVirtualboxButton = New System.Windows.Forms.Button()
        Me.TabPageRates = New System.Windows.Forms.TabPage()
        Me.Panelfilter = New System.Windows.Forms.Panel()
        Me.FindRatesTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteRatesButton = New System.Windows.Forms.Button()
        Me.findButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.idBodegaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BodegaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneBodegaClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DesctiptionLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AddWhereHouseButton = New System.Windows.Forms.Button()
        Me.EditWhereHouseButton = New System.Windows.Forms.Button()
        Me.DeleteWhereHouseButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelViewWhereHouse.SuspendLayout()
        Me.PanelConfig.SuspendLayout()
        Me.tabcontrol.SuspendLayout()
        Me.tabBanck.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabVirtualBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPageRates.SuspendLayout()
        Me.Panelfilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelViewWhereHouse
        '
        Me.PanelViewWhereHouse.AutoScroll = True
        Me.PanelViewWhereHouse.Controls.Add(Me.PanelConfig)
        Me.PanelViewWhereHouse.Controls.Add(Me.ListView1)
        Me.PanelViewWhereHouse.Controls.Add(Me.DesctiptionLabel)
        Me.PanelViewWhereHouse.Controls.Add(Me.Panel1)
        Me.PanelViewWhereHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelViewWhereHouse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelViewWhereHouse.Location = New System.Drawing.Point(13, 9)
        Me.PanelViewWhereHouse.Name = "PanelViewWhereHouse"
        Me.PanelViewWhereHouse.Size = New System.Drawing.Size(690, 440)
        Me.PanelViewWhereHouse.TabIndex = 1
        '
        'PanelConfig
        '
        Me.PanelConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelConfig.Controls.Add(Me.tabcontrol)
        Me.PanelConfig.Location = New System.Drawing.Point(18, 235)
        Me.PanelConfig.Name = "PanelConfig"
        Me.PanelConfig.Size = New System.Drawing.Size(660, 190)
        Me.PanelConfig.TabIndex = 13
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.tabBanck)
        Me.tabcontrol.Controls.Add(Me.tabVirtualBox)
        Me.tabcontrol.Controls.Add(Me.TabPageRates)
        Me.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrol.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcontrol.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(658, 188)
        Me.tabcontrol.TabIndex = 12
        '
        'tabBanck
        '
        Me.tabBanck.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.tabBanck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabBanck.Controls.Add(Me.BanckLisListView)
        Me.tabBanck.Controls.Add(Me.Panel3)
        Me.tabBanck.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.tabBanck.ForeColor = System.Drawing.Color.Maroon
        Me.tabBanck.Location = New System.Drawing.Point(4, 25)
        Me.tabBanck.Name = "tabBanck"
        Me.tabBanck.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBanck.Size = New System.Drawing.Size(650, 159)
        Me.tabBanck.TabIndex = 0
        Me.tabBanck.Text = "   Cuentas bancarias"
        '
        'BanckLisListView
        '
        Me.BanckLisListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idBanckWhereHouseClm, Me.OwnerClm, Me.BancoClm, Me.NumCuantaClm, Me.TypeCuentaClm})
        Me.BanckLisListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BanckLisListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.BanckLisListView.FullRowSelect = True
        Me.BanckLisListView.GridLines = True
        Me.BanckLisListView.Location = New System.Drawing.Point(3, 28)
        Me.BanckLisListView.Name = "BanckLisListView"
        Me.BanckLisListView.Size = New System.Drawing.Size(644, 128)
        Me.BanckLisListView.TabIndex = 8
        Me.BanckLisListView.UseCompatibleStateImageBehavior = False
        Me.BanckLisListView.View = System.Windows.Forms.View.Details
        '
        'idBanckWhereHouseClm
        '
        Me.idBanckWhereHouseClm.Text = "Código"
        '
        'OwnerClm
        '
        Me.OwnerClm.Text = "Propietario"
        Me.OwnerClm.Width = 200
        '
        'BancoClm
        '
        Me.BancoClm.Text = "Banco"
        Me.BancoClm.Width = 150
        '
        'NumCuantaClm
        '
        Me.NumCuantaClm.Text = "Cuenta"
        Me.NumCuantaClm.Width = 120
        '
        'TypeCuentaClm
        '
        Me.TypeCuentaClm.Text = "Tipo cuenta"
        Me.TypeCuentaClm.Width = 120
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel3.Controls.Add(Me.bodegaSelectedLabel1)
        Me.Panel3.Controls.Add(Me.DeleteButton)
        Me.Panel3.Controls.Add(Me.addNewBanckButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(644, 25)
        Me.Panel3.TabIndex = 7
        '
        'bodegaSelectedLabel1
        '
        Me.bodegaSelectedLabel1.AutoSize = True
        Me.bodegaSelectedLabel1.ForeColor = System.Drawing.Color.White
        Me.bodegaSelectedLabel1.Location = New System.Drawing.Point(77, 4)
        Me.bodegaSelectedLabel1.Name = "bodegaSelectedLabel1"
        Me.bodegaSelectedLabel1.Size = New System.Drawing.Size(0, 17)
        Me.bodegaSelectedLabel1.TabIndex = 6
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.DeleteButton.Location = New System.Drawing.Point(34, 0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(33, 25)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'addNewBanckButton
        '
        Me.addNewBanckButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.addNewBanckButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.addNewBanckButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.addNewBanckButton.Location = New System.Drawing.Point(0, 0)
        Me.addNewBanckButton.Name = "addNewBanckButton"
        Me.addNewBanckButton.Size = New System.Drawing.Size(34, 25)
        Me.addNewBanckButton.TabIndex = 3
        Me.addNewBanckButton.UseVisualStyleBackColor = False
        '
        'tabVirtualBox
        '
        Me.tabVirtualBox.Controls.Add(Me.VirtualListView)
        Me.tabVirtualBox.Controls.Add(Me.Panel2)
        Me.tabVirtualBox.Location = New System.Drawing.Point(4, 25)
        Me.tabVirtualBox.Name = "tabVirtualBox"
        Me.tabVirtualBox.Size = New System.Drawing.Size(650, 159)
        Me.tabVirtualBox.TabIndex = 2
        Me.tabVirtualBox.Text = "  Cajas virtuales"
        '
        'VirtualListView
        '
        Me.VirtualListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idVirtualBoxClm, Me.NameVirtualBoxClm, Me.saldoClm, Me.RemarkClm, Me.idTypoCajaClm})
        Me.VirtualListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VirtualListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.VirtualListView.FullRowSelect = True
        Me.VirtualListView.GridLines = True
        Me.VirtualListView.Location = New System.Drawing.Point(0, 25)
        Me.VirtualListView.Name = "VirtualListView"
        Me.VirtualListView.Size = New System.Drawing.Size(650, 134)
        Me.VirtualListView.TabIndex = 9
        Me.VirtualListView.UseCompatibleStateImageBehavior = False
        Me.VirtualListView.View = System.Windows.Forms.View.Details
        '
        'idVirtualBoxClm
        '
        Me.idVirtualBoxClm.Text = "Código"
        '
        'NameVirtualBoxClm
        '
        Me.NameVirtualBoxClm.Text = "Caja virtual"
        Me.NameVirtualBoxClm.Width = 200
        '
        'saldoClm
        '
        Me.saldoClm.Text = "Saldo"
        Me.saldoClm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.saldoClm.Width = 150
        '
        'RemarkClm
        '
        Me.RemarkClm.Text = "Nota"
        Me.RemarkClm.Width = 0
        '
        'idTypoCajaClm
        '
        Me.idTypoCajaClm.Text = "Typo de caja"
        Me.idTypoCajaClm.Width = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BodegaSelectedLabel2)
        Me.Panel2.Controls.Add(Me.DeleteVirtualboxButton)
        Me.Panel2.Controls.Add(Me.EditVirtualBoxButton)
        Me.Panel2.Controls.Add(Me.AddVirtualboxButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 25)
        Me.Panel2.TabIndex = 8
        '
        'BodegaSelectedLabel2
        '
        Me.BodegaSelectedLabel2.AutoSize = True
        Me.BodegaSelectedLabel2.ForeColor = System.Drawing.Color.White
        Me.BodegaSelectedLabel2.Location = New System.Drawing.Point(106, 5)
        Me.BodegaSelectedLabel2.Name = "BodegaSelectedLabel2"
        Me.BodegaSelectedLabel2.Size = New System.Drawing.Size(0, 17)
        Me.BodegaSelectedLabel2.TabIndex = 7
        '
        'DeleteVirtualboxButton
        '
        Me.DeleteVirtualboxButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.DeleteVirtualboxButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteVirtualboxButton.Enabled = False
        Me.DeleteVirtualboxButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.DeleteVirtualboxButton.Location = New System.Drawing.Point(67, 0)
        Me.DeleteVirtualboxButton.Name = "DeleteVirtualboxButton"
        Me.DeleteVirtualboxButton.Size = New System.Drawing.Size(33, 25)
        Me.DeleteVirtualboxButton.TabIndex = 6
        Me.DeleteVirtualboxButton.UseVisualStyleBackColor = False
        '
        'EditVirtualBoxButton
        '
        Me.EditVirtualBoxButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.EditVirtualBoxButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditVirtualBoxButton.Enabled = False
        Me.EditVirtualBoxButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Inline_Edit
        Me.EditVirtualBoxButton.Location = New System.Drawing.Point(34, 0)
        Me.EditVirtualBoxButton.Name = "EditVirtualBoxButton"
        Me.EditVirtualBoxButton.Size = New System.Drawing.Size(33, 25)
        Me.EditVirtualBoxButton.TabIndex = 5
        Me.EditVirtualBoxButton.UseVisualStyleBackColor = False
        '
        'AddVirtualboxButton
        '
        Me.AddVirtualboxButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.AddVirtualboxButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddVirtualboxButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.AddVirtualboxButton.Location = New System.Drawing.Point(0, 0)
        Me.AddVirtualboxButton.Name = "AddVirtualboxButton"
        Me.AddVirtualboxButton.Size = New System.Drawing.Size(34, 25)
        Me.AddVirtualboxButton.TabIndex = 3
        Me.AddVirtualboxButton.UseVisualStyleBackColor = False
        '
        'TabPageRates
        '
        Me.TabPageRates.Controls.Add(Me.Panelfilter)
        Me.TabPageRates.Controls.Add(Me.Label3)
        Me.TabPageRates.Location = New System.Drawing.Point(4, 25)
        Me.TabPageRates.Name = "TabPageRates"
        Me.TabPageRates.Size = New System.Drawing.Size(650, 159)
        Me.TabPageRates.TabIndex = 3
        Me.TabPageRates.Text = "  Tarifa predeterminada"
        Me.TabPageRates.UseVisualStyleBackColor = True
        '
        'Panelfilter
        '
        Me.Panelfilter.BackColor = System.Drawing.Color.White
        Me.Panelfilter.Controls.Add(Me.FindRatesTextBox)
        Me.Panelfilter.Controls.Add(Me.DeleteRatesButton)
        Me.Panelfilter.Controls.Add(Me.findButton)
        Me.Panelfilter.Location = New System.Drawing.Point(163, 9)
        Me.Panelfilter.Name = "Panelfilter"
        Me.Panelfilter.Padding = New System.Windows.Forms.Padding(1)
        Me.Panelfilter.Size = New System.Drawing.Size(369, 25)
        Me.Panelfilter.TabIndex = 11
        '
        'FindRatesTextBox
        '
        Me.FindRatesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FindRatesTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindRatesTextBox.Location = New System.Drawing.Point(1, 1)
        Me.FindRatesTextBox.Multiline = True
        Me.FindRatesTextBox.Name = "FindRatesTextBox"
        Me.FindRatesTextBox.ReadOnly = True
        Me.FindRatesTextBox.Size = New System.Drawing.Size(318, 23)
        Me.FindRatesTextBox.TabIndex = 7
        '
        'DeleteRatesButton
        '
        Me.DeleteRatesButton.BackColor = System.Drawing.Color.White
        Me.DeleteRatesButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeleteRatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteRatesButton.ForeColor = System.Drawing.Color.White
        Me.DeleteRatesButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_12x12
        Me.DeleteRatesButton.Location = New System.Drawing.Point(319, 1)
        Me.DeleteRatesButton.Name = "DeleteRatesButton"
        Me.DeleteRatesButton.Size = New System.Drawing.Size(18, 23)
        Me.DeleteRatesButton.TabIndex = 8
        Me.DeleteRatesButton.UseVisualStyleBackColor = False
        Me.DeleteRatesButton.Visible = False
        '
        'findButton
        '
        Me.findButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.findButton.Image = Global.ECommercePlatformView.My.Resources.Resources.find_with_16
        Me.findButton.Location = New System.Drawing.Point(337, 1)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(31, 23)
        Me.findButton.TabIndex = 6
        Me.findButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tarifa predeterminada:"
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idBodegaClm, Me.BodegaClm, Me.PhoneBodegaClm})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 49)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(664, 119)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'idBodegaClm
        '
        Me.idBodegaClm.Text = "Código"
        '
        'BodegaClm
        '
        Me.BodegaClm.Text = "Bodega o local"
        Me.BodegaClm.Width = 350
        '
        'PhoneBodegaClm
        '
        Me.PhoneBodegaClm.Text = "Teléfono"
        Me.PhoneBodegaClm.Width = 100
        '
        'DesctiptionLabel
        '
        Me.DesctiptionLabel.AutoSize = True
        Me.DesctiptionLabel.Location = New System.Drawing.Point(15, 180)
        Me.DesctiptionLabel.Name = "DesctiptionLabel"
        Me.DesctiptionLabel.Size = New System.Drawing.Size(0, 17)
        Me.DesctiptionLabel.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(690, 46)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.AddWhereHouseButton)
        Me.Panel4.Controls.Add(Me.EditWhereHouseButton)
        Me.Panel4.Controls.Add(Me.DeleteWhereHouseButton)
        Me.Panel4.Location = New System.Drawing.Point(408, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 28)
        Me.Panel4.TabIndex = 2
        '
        'AddWhereHouseButton
        '
        Me.AddWhereHouseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddWhereHouseButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.AddWhereHouseButton.Location = New System.Drawing.Point(150, 0)
        Me.AddWhereHouseButton.Name = "AddWhereHouseButton"
        Me.AddWhereHouseButton.Size = New System.Drawing.Size(43, 28)
        Me.AddWhereHouseButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.AddWhereHouseButton, "Agregar")
        Me.AddWhereHouseButton.UseVisualStyleBackColor = True
        '
        'EditWhereHouseButton
        '
        Me.EditWhereHouseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.EditWhereHouseButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Editar_24
        Me.EditWhereHouseButton.Location = New System.Drawing.Point(193, 0)
        Me.EditWhereHouseButton.Name = "EditWhereHouseButton"
        Me.EditWhereHouseButton.Size = New System.Drawing.Size(43, 28)
        Me.EditWhereHouseButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.EditWhereHouseButton, "Editar")
        Me.EditWhereHouseButton.UseVisualStyleBackColor = True
        '
        'DeleteWhereHouseButton
        '
        Me.DeleteWhereHouseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeleteWhereHouseButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteWhereHouseButton.Location = New System.Drawing.Point(236, 0)
        Me.DeleteWhereHouseButton.Name = "DeleteWhereHouseButton"
        Me.DeleteWhereHouseButton.Size = New System.Drawing.Size(43, 28)
        Me.DeleteWhereHouseButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DeleteWhereHouseButton, "Eliminar")
        Me.DeleteWhereHouseButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bodegas y locales"
        '
        'frmWhereHouseCommerce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 458)
        Me.Controls.Add(Me.PanelViewWhereHouse)
        Me.Name = "frmWhereHouseCommerce"
        Me.Text = "Bodegas y locales"
        Me.PanelViewWhereHouse.ResumeLayout(False)
        Me.PanelViewWhereHouse.PerformLayout()
        Me.PanelConfig.ResumeLayout(False)
        Me.tabcontrol.ResumeLayout(False)
        Me.tabBanck.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tabVirtualBox.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPageRates.ResumeLayout(False)
        Me.TabPageRates.PerformLayout()
        Me.Panelfilter.ResumeLayout(False)
        Me.Panelfilter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelViewWhereHouse As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents addNewBanckButton As Button
    Friend WithEvents DesctiptionLabel As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents idBodegaClm As ColumnHeader
    Friend WithEvents BodegaClm As ColumnHeader
    Friend WithEvents PhoneBodegaClm As ColumnHeader
    Friend WithEvents BanckLisListView As ListView
    Friend WithEvents idBanckWhereHouseClm As ColumnHeader
    Friend WithEvents BancoClm As ColumnHeader
    Friend WithEvents NumCuantaClm As ColumnHeader
    Friend WithEvents TypeCuentaClm As ColumnHeader
    Friend WithEvents tabcontrol As TabControl
    Friend WithEvents tabBanck As TabPage
    Friend WithEvents tabVirtualBox As TabPage
    Friend WithEvents VirtualListView As ListView
    Friend WithEvents idVirtualBoxClm As ColumnHeader
    Friend WithEvents NameVirtualBoxClm As ColumnHeader
    Friend WithEvents saldoClm As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EditVirtualBoxButton As Button
    Friend WithEvents AddVirtualboxButton As Button
    Friend WithEvents DeleteVirtualboxButton As Button
    Friend WithEvents bodegaSelectedLabel1 As Label
    Friend WithEvents BodegaSelectedLabel2 As Label
    Friend WithEvents RemarkClm As ColumnHeader
    Friend WithEvents idTypoCajaClm As ColumnHeader
    Friend WithEvents OwnerClm As ColumnHeader
    Friend WithEvents TabPageRates As TabPage
    Friend WithEvents Panelfilter As Panel
    Friend WithEvents FindRatesTextBox As TextBox
    Friend WithEvents findButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DeleteRatesButton As Button
    Friend WithEvents PanelConfig As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents AddWhereHouseButton As Button
    Friend WithEvents EditWhereHouseButton As Button
    Friend WithEvents DeleteWhereHouseButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
