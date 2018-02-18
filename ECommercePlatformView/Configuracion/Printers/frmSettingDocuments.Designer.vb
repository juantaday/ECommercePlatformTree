<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingDocuments
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.VentaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.checListVentas = New System.Windows.Forms.CheckedListBox()
        Me.VentaListView = New System.Windows.Forms.ListView()
        Me.idclm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameSettingClm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNameTicketVentas = New System.Windows.Forms.TextBox()
        Me.ListDocumentVentas = New System.Windows.Forms.ListBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SaveVentasButton = New System.Windows.Forms.Button()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.namePrintEtiquetasTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListDocumentEtiquetas = New System.Windows.Forms.ListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Ok_EtiquetasButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListDocumentVarrios = New System.Windows.Forms.ListBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.RefreshListDocumentButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(518, 1)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(71, 34)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(589, 1)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 34)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(1, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(657, 36)
        Me.Panel1.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(1, 41)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(657, 383)
        Me.XtraTabControl1.TabIndex = 13
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Controls.Add(Me.Panel2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage1.Size = New System.Drawing.Size(651, 355)
        Me.XtraTabPage1.Tag = "ventas"
        Me.XtraTabPage1.Text = "Documentos de venta."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel20)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.ListDocumentVentas)
        Me.Panel3.Controls.Add(Me.PanelMenu)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(645, 316)
        Me.Panel3.TabIndex = 11
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.VentaComboBox)
        Me.Panel20.Controls.Add(Me.Label11)
        Me.Panel20.Controls.Add(Me.Label10)
        Me.Panel20.Controls.Add(Me.checListVentas)
        Me.Panel20.Controls.Add(Me.VentaListView)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(210, 78)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel20.Size = New System.Drawing.Size(435, 238)
        Me.Panel20.TabIndex = 13
        '
        'VentaComboBox
        '
        Me.VentaComboBox.FormattingEnabled = True
        Me.VentaComboBox.Location = New System.Drawing.Point(260, 83)
        Me.VentaComboBox.Name = "VentaComboBox"
        Me.VentaComboBox.Size = New System.Drawing.Size(150, 21)
        Me.VentaComboBox.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(260, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Tamaño de texto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Color de texto"
        '
        'checListVentas
        '
        Me.checListVentas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.checListVentas.CheckOnClick = True
        Me.checListVentas.ColumnWidth = 50
        Me.checListVentas.Items.AddRange(New Object() {"Negro", "Rojo"})
        Me.checListVentas.Location = New System.Drawing.Point(341, 6)
        Me.checListVentas.Name = "checListVentas"
        Me.checListVentas.Size = New System.Drawing.Size(76, 36)
        Me.checListVentas.TabIndex = 4
        '
        'VentaListView
        '
        Me.VentaListView.CheckBoxes = True
        Me.VentaListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idclm, Me.NameSettingClm})
        Me.VentaListView.Dock = System.Windows.Forms.DockStyle.Left
        Me.VentaListView.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.VentaListView.FullRowSelect = True
        Me.VentaListView.GridLines = True
        Me.VentaListView.HideSelection = False
        Me.VentaListView.Location = New System.Drawing.Point(2, 2)
        Me.VentaListView.MultiSelect = False
        Me.VentaListView.Name = "VentaListView"
        Me.VentaListView.Size = New System.Drawing.Size(249, 234)
        Me.VentaListView.TabIndex = 0
        Me.VentaListView.UseCompatibleStateImageBehavior = False
        Me.VentaListView.View = System.Windows.Forms.View.Details
        '
        'idclm
        '
        Me.idclm.Text = "ID"
        Me.idclm.Width = 40
        '
        'NameSettingClm
        '
        Me.NameSettingClm.Text = "Opciones"
        Me.NameSettingClm.Width = 200
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.txtNameTicketVentas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(210, 27)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel6.Size = New System.Drawing.Size(435, 51)
        Me.Panel6.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Impresora configurada"
        '
        'txtNameTicketVentas
        '
        Me.txtNameTicketVentas.Location = New System.Drawing.Point(9, 21)
        Me.txtNameTicketVentas.Name = "txtNameTicketVentas"
        Me.txtNameTicketVentas.ReadOnly = True
        Me.txtNameTicketVentas.Size = New System.Drawing.Size(400, 21)
        Me.txtNameTicketVentas.TabIndex = 0
        '
        'ListDocumentVentas
        '
        Me.ListDocumentVentas.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListDocumentVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDocumentVentas.FormattingEnabled = True
        Me.ListDocumentVentas.ItemHeight = 16
        Me.ListDocumentVentas.Location = New System.Drawing.Point(0, 27)
        Me.ListDocumentVentas.Name = "ListDocumentVentas"
        Me.ListDocumentVentas.Size = New System.Drawing.Size(210, 289)
        Me.ListDocumentVentas.TabIndex = 10
        '
        'PanelMenu
        '
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.PanelMenu.Size = New System.Drawing.Size(645, 27)
        Me.PanelMenu.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Selecciona uno del listado"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SaveVentasButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(3, 319)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(645, 33)
        Me.Panel2.TabIndex = 0
        '
        'SaveVentasButton
        '
        Me.SaveVentasButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveVentasButton.Location = New System.Drawing.Point(542, 2)
        Me.SaveVentasButton.Name = "SaveVentasButton"
        Me.SaveVentasButton.Size = New System.Drawing.Size(99, 27)
        Me.SaveVentasButton.TabIndex = 4
        Me.SaveVentasButton.Text = "Aplicar.."
        Me.SaveVentasButton.UseVisualStyleBackColor = True
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel11)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage2.Size = New System.Drawing.Size(651, 355)
        Me.XtraTabPage2.Tag = "compras"
        Me.XtraTabPage2.Text = "Documentos de compra"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel4)
        Me.Panel11.Controls.Add(Me.ListBox1)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(645, 349)
        Me.Panel11.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.namePrintEtiquetasTextBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(210, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(435, 51)
        Me.Panel4.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Impresora configurada"
        '
        'namePrintEtiquetasTextBox
        '
        Me.namePrintEtiquetasTextBox.Location = New System.Drawing.Point(9, 21)
        Me.namePrintEtiquetasTextBox.Name = "namePrintEtiquetasTextBox"
        Me.namePrintEtiquetasTextBox.ReadOnly = True
        Me.namePrintEtiquetasTextBox.Size = New System.Drawing.Size(400, 21)
        Me.namePrintEtiquetasTextBox.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 283)
        Me.ListBox1.TabIndex = 11
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Label7)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.Panel12.Size = New System.Drawing.Size(645, 27)
        Me.Panel12.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Selecciona uno del listado"
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.Button1)
        Me.Panel15.Controls.Add(Me.Button3)
        Me.Panel15.Controls.Add(Me.Button5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Panel15.Location = New System.Drawing.Point(0, 310)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel15.Size = New System.Drawing.Size(645, 39)
        Me.Panel15.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Opciones avanzadas.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Location = New System.Drawing.Point(446, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 33)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Aplicar.."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.Location = New System.Drawing.Point(545, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 33)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Cancelar.."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Panel8)
        Me.XtraTabPage3.Controls.Add(Me.ListDocumentEtiquetas)
        Me.XtraTabPage3.Controls.Add(Me.Panel5)
        Me.XtraTabPage3.Controls.Add(Me.Panel7)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage3.Size = New System.Drawing.Size(651, 355)
        Me.XtraTabPage3.Tag = "Etiquetas"
        Me.XtraTabPage3.Text = "Etiquetas"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.TextBox2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(213, 30)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel8.Size = New System.Drawing.Size(435, 51)
        Me.Panel8.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Impresora configurada"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(400, 21)
        Me.TextBox2.TabIndex = 0
        '
        'ListDocumentEtiquetas
        '
        Me.ListDocumentEtiquetas.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListDocumentEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDocumentEtiquetas.FormattingEnabled = True
        Me.ListDocumentEtiquetas.ItemHeight = 16
        Me.ListDocumentEtiquetas.Location = New System.Drawing.Point(3, 30)
        Me.ListDocumentEtiquetas.Name = "ListDocumentEtiquetas"
        Me.ListDocumentEtiquetas.Size = New System.Drawing.Size(210, 283)
        Me.ListDocumentEtiquetas.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button11)
        Me.Panel5.Controls.Add(Me.Ok_EtiquetasButton)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Panel5.Location = New System.Drawing.Point(3, 313)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel5.Size = New System.Drawing.Size(645, 39)
        Me.Panel5.TabIndex = 12
        '
        'Button11
        '
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button11.Location = New System.Drawing.Point(2, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(153, 33)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "Opciones avanzadas.."
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Ok_EtiquetasButton
        '
        Me.Ok_EtiquetasButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_EtiquetasButton.Location = New System.Drawing.Point(446, 2)
        Me.Ok_EtiquetasButton.Name = "Ok_EtiquetasButton"
        Me.Ok_EtiquetasButton.Size = New System.Drawing.Size(99, 33)
        Me.Ok_EtiquetasButton.TabIndex = 4
        Me.Ok_EtiquetasButton.Text = "Aplicar.."
        Me.Ok_EtiquetasButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button4.Location = New System.Drawing.Point(545, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 33)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Cancelar.."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.Panel7.Size = New System.Drawing.Size(645, 27)
        Me.Panel7.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Selecciona uno del listado"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Panel13)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.XtraTabPage4.Size = New System.Drawing.Size(651, 355)
        Me.XtraTabPage4.Tag = "varios"
        Me.XtraTabPage4.Text = "Reportes varios"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel9)
        Me.Panel13.Controls.Add(Me.ListDocumentVarrios)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Controls.Add(Me.Panel16)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(645, 349)
        Me.Panel13.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.TextBox3)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(210, 27)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel9.Size = New System.Drawing.Size(435, 51)
        Me.Panel9.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Impresora configurada"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(400, 21)
        Me.TextBox3.TabIndex = 0
        '
        'ListDocumentVarrios
        '
        Me.ListDocumentVarrios.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListDocumentVarrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDocumentVarrios.FormattingEnabled = True
        Me.ListDocumentVarrios.ItemHeight = 16
        Me.ListDocumentVarrios.Location = New System.Drawing.Point(0, 27)
        Me.ListDocumentVarrios.Name = "ListDocumentVarrios"
        Me.ListDocumentVarrios.Size = New System.Drawing.Size(210, 283)
        Me.ListDocumentVarrios.TabIndex = 11
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Label8)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(10, 2, 0, 2)
        Me.Panel14.Size = New System.Drawing.Size(645, 27)
        Me.Panel14.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Selecciona uno del listado"
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Button6)
        Me.Panel16.Controls.Add(Me.Button7)
        Me.Panel16.Controls.Add(Me.Button8)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Panel16.Location = New System.Drawing.Point(0, 310)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel16.Size = New System.Drawing.Size(645, 39)
        Me.Panel16.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.Location = New System.Drawing.Point(2, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 33)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Opciones avanzadas.."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button7.Location = New System.Drawing.Point(446, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 33)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Aplicar.."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button8.Location = New System.Drawing.Point(545, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 33)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Cancelar.."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Panel_660x40
        Me.Panel19.Controls.Add(Me.RefreshListDocumentButton)
        Me.Panel19.Controls.Add(Me.Label9)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(1, 1)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(657, 40)
        Me.Panel19.TabIndex = 14
        '
        'RefreshListDocumentButton
        '
        Me.RefreshListDocumentButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshListDocumentButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.RefreshListDocumentButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Refresh_32png
        Me.RefreshListDocumentButton.Location = New System.Drawing.Point(616, 0)
        Me.RefreshListDocumentButton.Name = "RefreshListDocumentButton"
        Me.RefreshListDocumentButton.Size = New System.Drawing.Size(41, 40)
        Me.RefreshListDocumentButton.TabIndex = 9
        Me.RefreshListDocumentButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Source Sans Pro", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Configuración de documentos"
        '
        'frmSettingDocuments
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(659, 461)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel19)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingDocuments"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSettingDocuments"
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNameTicketVentas As TextBox
    Friend WithEvents ListDocumentVentas As ListBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SaveVentasButton As Button
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents namePrintEtiquetasTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListDocumentEtiquetas As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button11 As Button
    Friend WithEvents Ok_EtiquetasButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListDocumentVarrios As ListBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents RefreshListDocumentButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents VentaListView As ListView
    Friend WithEvents idclm As ColumnHeader
    Friend WithEvents NameSettingClm As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents checListVentas As CheckedListBox
    Friend WithEvents VentaComboBox As ComboBox
End Class
