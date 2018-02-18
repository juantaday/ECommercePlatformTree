
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_CuentasXcobrar
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
        Me.PieTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me._CancelButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.todosClientButton = New System.Windows.Forms.Button()
        Me.CedulaBusButton = New System.Windows.Forms.Button()
        Me.BuscNomApelliButton = New System.Windows.Forms.Button()
        Me.AllDeudorButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TotalGeneralLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaneBusqueda = New System.Windows.Forms.Panel()
        Me.TabControlBusqueda = New System.Windows.Forms.TabControl()
        Me.PageXVenta = New System.Windows.Forms.TabPage()
        Me.panelView = New System.Windows.Forms.Panel()
        Me.PanelData = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NomApelliTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BuscCedulaTextBox = New System.Windows.Forms.TextBox()
        Me.ResumenFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.CobrarLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PageXTrabajador = New System.Windows.Forms.TabPage()
        Me.PanelViewEmployee = New System.Windows.Forms.Panel()
        Me.dtgEmployee = New System.Windows.Forms.DataGridView()
        Me.PanelTotalEmployee = New System.Windows.Forms.Panel()
        Me.CahrgeEmployeeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.totaDebitEmployeeLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PagexZona = New System.Windows.Forms.TabPage()
        Me.ParroquiaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SectorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CantonComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProvinciaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UbicatedCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.IdPersonClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RucCiClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitValueClm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PieTableLayout.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PaneBusqueda.SuspendLayout()
        Me.TabControlBusqueda.SuspendLayout()
        Me.PageXVenta.SuspendLayout()
        Me.PanelData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ResumenFlowLayout.SuspendLayout()
        Me.PageXTrabajador.SuspendLayout()
        Me.PanelViewEmployee.SuspendLayout()
        CType(Me.dtgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalEmployee.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PagexZona.SuspendLayout()
        Me.SuspendLayout()
        '
        'PieTableLayout
        '
        Me.PieTableLayout.BackColor = System.Drawing.SystemColors.Control
        Me.PieTableLayout.ColumnCount = 3
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.95381!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04619!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PieTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PieTableLayout.Controls.Add(Me._CancelButton, 2, 0)
        Me.PieTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PieTableLayout.Location = New System.Drawing.Point(0, 449)
        Me.PieTableLayout.Name = "PieTableLayout"
        Me.PieTableLayout.RowCount = 1
        Me.PieTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PieTableLayout.Size = New System.Drawing.Size(927, 41)
        Me.PieTableLayout.TabIndex = 1
        '
        '_CancelButton
        '
        Me._CancelButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me._CancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me._CancelButton.ForeColor = System.Drawing.Color.White
        Me._CancelButton.Location = New System.Drawing.Point(838, 3)
        Me._CancelButton.Name = "_CancelButton"
        Me._CancelButton.Size = New System.Drawing.Size(86, 35)
        Me._CancelButton.TabIndex = 0
        Me._CancelButton.Text = "Cancelar"
        Me._CancelButton.UseVisualStyleBackColor = False
        '
        'todosClientButton
        '
        Me.todosClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.todosClientButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.todosClientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todosClientButton.Image = Global.ECommercePlatformView.My.Resources.Resources.fin_deudor_32
        Me.todosClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.todosClientButton.Location = New System.Drawing.Point(824, 0)
        Me.todosClientButton.Margin = New System.Windows.Forms.Padding(0)
        Me.todosClientButton.Name = "todosClientButton"
        Me.todosClientButton.Size = New System.Drawing.Size(84, 44)
        Me.todosClientButton.TabIndex = 7
        Me.todosClientButton.Text = "Todos "
        Me.todosClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.todosClientButton, "Todos los clientes")
        Me.todosClientButton.UseVisualStyleBackColor = True
        '
        'CedulaBusButton
        '
        Me.CedulaBusButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_icon_24
        Me.CedulaBusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CedulaBusButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CedulaBusButton.Enabled = False
        Me.CedulaBusButton.Location = New System.Drawing.Point(194, 0)
        Me.CedulaBusButton.Name = "CedulaBusButton"
        Me.CedulaBusButton.Size = New System.Drawing.Size(38, 26)
        Me.CedulaBusButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CedulaBusButton, "Buscar")
        Me.CedulaBusButton.UseVisualStyleBackColor = False
        '
        'BuscNomApelliButton
        '
        Me.BuscNomApelliButton.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_icon_24
        Me.BuscNomApelliButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BuscNomApelliButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.BuscNomApelliButton.Enabled = False
        Me.BuscNomApelliButton.Location = New System.Drawing.Point(235, 0)
        Me.BuscNomApelliButton.Name = "BuscNomApelliButton"
        Me.BuscNomApelliButton.Size = New System.Drawing.Size(38, 26)
        Me.BuscNomApelliButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BuscNomApelliButton, "Buscar")
        Me.BuscNomApelliButton.UseVisualStyleBackColor = False
        '
        'AllDeudorButton
        '
        Me.AllDeudorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AllDeudorButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AllDeudorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllDeudorButton.Image = Global.ECommercePlatformView.My.Resources.Resources.fin_deudor_32
        Me.AllDeudorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AllDeudorButton.Location = New System.Drawing.Point(821, 0)
        Me.AllDeudorButton.Name = "AllDeudorButton"
        Me.AllDeudorButton.Size = New System.Drawing.Size(93, 35)
        Me.AllDeudorButton.TabIndex = 8
        Me.AllDeudorButton.Text = "Todos "
        Me.AllDeudorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.AllDeudorButton, "Todos los clientes")
        Me.AllDeudorButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_green_48icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(869, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 38)
        Me.Button1.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Button1, "Todos los clientes")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TotalGeneralLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 35)
        Me.Panel3.TabIndex = 2
        '
        'TotalGeneralLabel
        '
        Me.TotalGeneralLabel.AutoSize = True
        Me.TotalGeneralLabel.Font = New System.Drawing.Font("Source Sans Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalGeneralLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TotalGeneralLabel.Location = New System.Drawing.Point(20, 2)
        Me.TotalGeneralLabel.Name = "TotalGeneralLabel"
        Me.TotalGeneralLabel.Size = New System.Drawing.Size(266, 30)
        Me.TotalGeneralLabel.TabIndex = 0
        Me.TotalGeneralLabel.Text = "Total general por cobrar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(927, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OPCIONES DE BUSQUEDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaneBusqueda
        '
        Me.PaneBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaneBusqueda.Controls.Add(Me.Label1)
        Me.PaneBusqueda.Controls.Add(Me.Panel3)
        Me.PaneBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.PaneBusqueda.Name = "PaneBusqueda"
        Me.PaneBusqueda.Size = New System.Drawing.Size(927, 75)
        Me.PaneBusqueda.TabIndex = 5
        '
        'TabControlBusqueda
        '
        Me.TabControlBusqueda.Controls.Add(Me.PageXVenta)
        Me.TabControlBusqueda.Controls.Add(Me.PageXTrabajador)
        Me.TabControlBusqueda.Controls.Add(Me.PagexZona)
        Me.TabControlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlBusqueda.Location = New System.Drawing.Point(0, 75)
        Me.TabControlBusqueda.Name = "TabControlBusqueda"
        Me.TabControlBusqueda.SelectedIndex = 0
        Me.TabControlBusqueda.Size = New System.Drawing.Size(927, 374)
        Me.TabControlBusqueda.TabIndex = 6
        '
        'PageXVenta
        '
        Me.PageXVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageXVenta.Controls.Add(Me.panelView)
        Me.PageXVenta.Controls.Add(Me.PanelData)
        Me.PageXVenta.Controls.Add(Me.ResumenFlowLayout)
        Me.PageXVenta.Location = New System.Drawing.Point(4, 29)
        Me.PageXVenta.Name = "PageXVenta"
        Me.PageXVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.PageXVenta.Size = New System.Drawing.Size(919, 341)
        Me.PageXVenta.TabIndex = 0
        Me.PageXVenta.Text = "  General por venta producto."
        '
        'panelView
        '
        Me.panelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelView.Location = New System.Drawing.Point(3, 49)
        Me.panelView.Name = "panelView"
        Me.panelView.Size = New System.Drawing.Size(913, 228)
        Me.panelView.TabIndex = 8
        '
        'PanelData
        '
        Me.PanelData.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelData.Controls.Add(Me.Label2)
        Me.PanelData.Controls.Add(Me.Panel1)
        Me.PanelData.Controls.Add(Me.Label3)
        Me.PanelData.Controls.Add(Me.todosClientButton)
        Me.PanelData.Controls.Add(Me.Panel2)
        Me.PanelData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelData.Location = New System.Drawing.Point(3, 3)
        Me.PanelData.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelData.Name = "PanelData"
        Me.PanelData.Padding = New System.Windows.Forms.Padding(10, 0, 3, 0)
        Me.PanelData.Size = New System.Drawing.Size(913, 46)
        Me.PanelData.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellidos (y/o) Nombres:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.NomApelliTextBox)
        Me.Panel1.Controls.Add(Me.BuscNomApelliButton)
        Me.Panel1.Location = New System.Drawing.Point(189, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 26)
        Me.Panel1.TabIndex = 5
        '
        'NomApelliTextBox
        '
        Me.NomApelliTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NomApelliTextBox.Location = New System.Drawing.Point(0, 0)
        Me.NomApelliTextBox.Name = "NomApelliTextBox"
        Me.NomApelliTextBox.Size = New System.Drawing.Size(235, 26)
        Me.NomApelliTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(468, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cédula :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BuscCedulaTextBox)
        Me.Panel2.Controls.Add(Me.CedulaBusButton)
        Me.Panel2.Location = New System.Drawing.Point(541, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 26)
        Me.Panel2.TabIndex = 6
        '
        'BuscCedulaTextBox
        '
        Me.BuscCedulaTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuscCedulaTextBox.Location = New System.Drawing.Point(0, 0)
        Me.BuscCedulaTextBox.MaxLength = 10
        Me.BuscCedulaTextBox.Name = "BuscCedulaTextBox"
        Me.BuscCedulaTextBox.Size = New System.Drawing.Size(194, 26)
        Me.BuscCedulaTextBox.TabIndex = 1
        '
        'ResumenFlowLayout
        '
        Me.ResumenFlowLayout.Controls.Add(Me.totalLabel)
        Me.ResumenFlowLayout.Controls.Add(Me.CobrarLinkLabel)
        Me.ResumenFlowLayout.Controls.Add(Me.FlowLayoutPanel2)
        Me.ResumenFlowLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ResumenFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ResumenFlowLayout.Location = New System.Drawing.Point(3, 277)
        Me.ResumenFlowLayout.Name = "ResumenFlowLayout"
        Me.ResumenFlowLayout.Size = New System.Drawing.Size(913, 61)
        Me.ResumenFlowLayout.TabIndex = 8
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(4, 10)
        Me.totalLabel.Margin = New System.Windows.Forms.Padding(4, 10, 4, 2)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(0, 20)
        Me.totalLabel.TabIndex = 22
        '
        'CobrarLinkLabel
        '
        Me.CobrarLinkLabel.AutoSize = True
        Me.CobrarLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CobrarLinkLabel.Location = New System.Drawing.Point(4, 32)
        Me.CobrarLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CobrarLinkLabel.Name = "CobrarLinkLabel"
        Me.CobrarLinkLabel.Size = New System.Drawing.Size(0, 17)
        Me.CobrarLinkLabel.TabIndex = 21
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 52)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(2, 0)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'PageXTrabajador
        '
        Me.PageXTrabajador.BackColor = System.Drawing.Color.Cyan
        Me.PageXTrabajador.Controls.Add(Me.PanelViewEmployee)
        Me.PageXTrabajador.Controls.Add(Me.Panel4)
        Me.PageXTrabajador.Location = New System.Drawing.Point(4, 29)
        Me.PageXTrabajador.Name = "PageXTrabajador"
        Me.PageXTrabajador.Size = New System.Drawing.Size(919, 341)
        Me.PageXTrabajador.TabIndex = 2
        Me.PageXTrabajador.Text = "  Deudores varios."
        '
        'PanelViewEmployee
        '
        Me.PanelViewEmployee.Controls.Add(Me.dtgEmployee)
        Me.PanelViewEmployee.Controls.Add(Me.PanelTotalEmployee)
        Me.PanelViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelViewEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelViewEmployee.Location = New System.Drawing.Point(0, 37)
        Me.PanelViewEmployee.Name = "PanelViewEmployee"
        Me.PanelViewEmployee.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelViewEmployee.Size = New System.Drawing.Size(919, 304)
        Me.PanelViewEmployee.TabIndex = 10
        '
        'dtgEmployee
        '
        Me.dtgEmployee.AllowUserToAddRows = False
        Me.dtgEmployee.AllowUserToDeleteRows = False
        Me.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonClm, Me.RucCiClm, Me.EmployeeClm, Me.DebitValueClm})
        Me.dtgEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgEmployee.Location = New System.Drawing.Point(5, 5)
        Me.dtgEmployee.Name = "dtgEmployee"
        Me.dtgEmployee.ReadOnly = True
        Me.dtgEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgEmployee.Size = New System.Drawing.Size(909, 248)
        Me.dtgEmployee.TabIndex = 0
        '
        'PanelTotalEmployee
        '
        Me.PanelTotalEmployee.Controls.Add(Me.CahrgeEmployeeLinkLabel)
        Me.PanelTotalEmployee.Controls.Add(Me.totaDebitEmployeeLabel)
        Me.PanelTotalEmployee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotalEmployee.Location = New System.Drawing.Point(5, 253)
        Me.PanelTotalEmployee.Name = "PanelTotalEmployee"
        Me.PanelTotalEmployee.Size = New System.Drawing.Size(909, 46)
        Me.PanelTotalEmployee.TabIndex = 1
        '
        'CahrgeEmployeeLinkLabel
        '
        Me.CahrgeEmployeeLinkLabel.AutoSize = True
        Me.CahrgeEmployeeLinkLabel.Location = New System.Drawing.Point(13, 22)
        Me.CahrgeEmployeeLinkLabel.Name = "CahrgeEmployeeLinkLabel"
        Me.CahrgeEmployeeLinkLabel.Size = New System.Drawing.Size(71, 17)
        Me.CahrgeEmployeeLinkLabel.TabIndex = 1
        Me.CahrgeEmployeeLinkLabel.TabStop = True
        Me.CahrgeEmployeeLinkLabel.Text = "Cobrar a: "
        Me.CahrgeEmployeeLinkLabel.Visible = False
        '
        'totaDebitEmployeeLabel
        '
        Me.totaDebitEmployeeLabel.AutoSize = True
        Me.totaDebitEmployeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaDebitEmployeeLabel.Location = New System.Drawing.Point(13, 4)
        Me.totaDebitEmployeeLabel.Name = "totaDebitEmployeeLabel"
        Me.totaDebitEmployeeLabel.Size = New System.Drawing.Size(197, 17)
        Me.totaDebitEmployeeLabel.TabIndex = 0
        Me.totaDebitEmployeeLabel.Text = "Total deuda trabajadores:"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.AllDeudorButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10, 0, 5, 2)
        Me.Panel4.Size = New System.Drawing.Size(919, 37)
        Me.Panel4.TabIndex = 9
        '
        'PagexZona
        '
        Me.PagexZona.BackColor = System.Drawing.Color.Teal
        Me.PagexZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PagexZona.Controls.Add(Me.ParroquiaComboBox)
        Me.PagexZona.Controls.Add(Me.Label7)
        Me.PagexZona.Controls.Add(Me.SectorComboBox)
        Me.PagexZona.Controls.Add(Me.Label6)
        Me.PagexZona.Controls.Add(Me.CantonComboBox)
        Me.PagexZona.Controls.Add(Me.Label5)
        Me.PagexZona.Controls.Add(Me.ProvinciaComboBox)
        Me.PagexZona.Controls.Add(Me.Label4)
        Me.PagexZona.Controls.Add(Me.UbicatedCheckedListBox)
        Me.PagexZona.Controls.Add(Me.Button1)
        Me.PagexZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagexZona.ForeColor = System.Drawing.Color.White
        Me.PagexZona.Location = New System.Drawing.Point(4, 29)
        Me.PagexZona.Name = "PagexZona"
        Me.PagexZona.Padding = New System.Windows.Forms.Padding(3)
        Me.PagexZona.Size = New System.Drawing.Size(919, 341)
        Me.PagexZona.TabIndex = 1
        Me.PagexZona.Text = "  Por (ubicación - ruta)"
        '
        'ParroquiaComboBox
        '
        Me.ParroquiaComboBox.FormattingEnabled = True
        Me.ParroquiaComboBox.Location = New System.Drawing.Point(481, 20)
        Me.ParroquiaComboBox.Name = "ParroquiaComboBox"
        Me.ParroquiaComboBox.Size = New System.Drawing.Size(167, 21)
        Me.ParroquiaComboBox.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Parroquia:"
        '
        'SectorComboBox
        '
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.Location = New System.Drawing.Point(679, 20)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(167, 21)
        Me.SectorComboBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(676, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sector:"
        '
        'CantonComboBox
        '
        Me.CantonComboBox.FormattingEnabled = True
        Me.CantonComboBox.Location = New System.Drawing.Point(296, 20)
        Me.CantonComboBox.Name = "CantonComboBox"
        Me.CantonComboBox.Size = New System.Drawing.Size(165, 21)
        Me.CantonComboBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantón:"
        '
        'ProvinciaComboBox
        '
        Me.ProvinciaComboBox.FormattingEnabled = True
        Me.ProvinciaComboBox.Location = New System.Drawing.Point(93, 19)
        Me.ProvinciaComboBox.Name = "ProvinciaComboBox"
        Me.ProvinciaComboBox.Size = New System.Drawing.Size(170, 21)
        Me.ProvinciaComboBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Provincia:"
        '
        'UbicatedCheckedListBox
        '
        Me.UbicatedCheckedListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UbicatedCheckedListBox.CheckOnClick = True
        Me.UbicatedCheckedListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.UbicatedCheckedListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UbicatedCheckedListBox.FormattingEnabled = True
        Me.UbicatedCheckedListBox.Items.AddRange(New Object() {"Ubicación", "Ruta"})
        Me.UbicatedCheckedListBox.Location = New System.Drawing.Point(3, 3)
        Me.UbicatedCheckedListBox.Name = "UbicatedCheckedListBox"
        Me.UbicatedCheckedListBox.Size = New System.Drawing.Size(84, 335)
        Me.UbicatedCheckedListBox.TabIndex = 9
        '
        'IdPersonClm
        '
        Me.IdPersonClm.DataPropertyName = "IdPerson"
        Me.IdPersonClm.HeaderText = "IdPerson"
        Me.IdPersonClm.Name = "IdPersonClm"
        Me.IdPersonClm.ReadOnly = True
        Me.IdPersonClm.Visible = False
        '
        'RucCiClm
        '
        Me.RucCiClm.DataPropertyName = "RucCi"
        Me.RucCiClm.HeaderText = "Ruc-C.I."
        Me.RucCiClm.Name = "RucCiClm"
        Me.RucCiClm.ReadOnly = True
        '
        'EmployeeClm
        '
        Me.EmployeeClm.DataPropertyName = "FullName"
        Me.EmployeeClm.HeaderText = "Empleado"
        Me.EmployeeClm.Name = "EmployeeClm"
        Me.EmployeeClm.ReadOnly = True
        '
        'DebitValueClm
        '
        Me.DebitValueClm.DataPropertyName = "BalaceDebit"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DebitValueClm.DefaultCellStyle = DataGridViewCellStyle1
        Me.DebitValueClm.HeaderText = "Valor deuda"
        Me.DebitValueClm.Name = "DebitValueClm"
        Me.DebitValueClm.ReadOnly = True
        '
        'frmList_CuentasXcobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 490)
        Me.Controls.Add(Me.TabControlBusqueda)
        Me.Controls.Add(Me.PieTableLayout)
        Me.Controls.Add(Me.PaneBusqueda)
        Me.Name = "frmList_CuentasXcobrar"
        Me.Text = "Listado de deudores.."
        Me.PieTableLayout.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PaneBusqueda.ResumeLayout(False)
        Me.TabControlBusqueda.ResumeLayout(False)
        Me.PageXVenta.ResumeLayout(False)
        Me.PanelData.ResumeLayout(False)
        Me.PanelData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumenFlowLayout.ResumeLayout(False)
        Me.ResumenFlowLayout.PerformLayout()
        Me.PageXTrabajador.ResumeLayout(False)
        Me.PanelViewEmployee.ResumeLayout(False)
        CType(Me.dtgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalEmployee.ResumeLayout(False)
        Me.PanelTotalEmployee.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PagexZona.ResumeLayout(False)
        Me.PagexZona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PieTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents _CancelButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TotalGeneralLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PaneBusqueda As Panel
    Friend WithEvents TabControlBusqueda As TabControl
    Friend WithEvents PageXVenta As TabPage
    Friend WithEvents PanelData As Panel
    Friend WithEvents panelView As Panel
    Friend WithEvents ResumenFlowLayout As FlowLayoutPanel
    Friend WithEvents totalLabel As Label
    Friend WithEvents CobrarLinkLabel As LinkLabel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents todosClientButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BuscCedulaTextBox As TextBox
    Friend WithEvents CedulaBusButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NomApelliTextBox As TextBox
    Friend WithEvents BuscNomApelliButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PageXTrabajador As TabPage
    Friend WithEvents AllDeudorButton As Button
    Friend WithEvents PagexZona As TabPage
    Friend WithEvents ParroquiaComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SectorComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CantonComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ProvinciaComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UbicatedCheckedListBox As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelViewEmployee As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtgEmployee As DataGridView
    Friend WithEvents PanelTotalEmployee As Panel
    Friend WithEvents CahrgeEmployeeLinkLabel As LinkLabel
    Friend WithEvents totaDebitEmployeeLabel As Label
    Friend WithEvents IdPersonClm As DataGridViewTextBoxColumn
    Friend WithEvents RucCiClm As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeClm As DataGridViewTextBoxColumn
    Friend WithEvents DebitValueClm As DataGridViewTextBoxColumn
End Class
