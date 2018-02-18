<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBalanceGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceGeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AnualBunifuFlatButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MensulBunifuFlatButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SalesToDateBunifuFlatButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgressbar3 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuCircleProgressbar2 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.Controls.Add(Me.AnualBunifuFlatButton)
        Me.Panel2.Controls.Add(Me.MensulBunifuFlatButton)
        Me.Panel2.Controls.Add(Me.SalesToDateBunifuFlatButton)
        Me.Panel2.Controls.Add(Me.BunifuSeparator2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'AnualBunifuFlatButton
        '
        Me.AnualBunifuFlatButton.Activecolor = System.Drawing.Color.Blue
        Me.AnualBunifuFlatButton.BackColor = System.Drawing.Color.Gainsboro
        resources.ApplyResources(Me.AnualBunifuFlatButton, "AnualBunifuFlatButton")
        Me.AnualBunifuFlatButton.BorderRadius = 7
        Me.AnualBunifuFlatButton.ButtonText = "  Balance General"
        Me.AnualBunifuFlatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnualBunifuFlatButton.DisabledColor = System.Drawing.Color.Gray
        Me.AnualBunifuFlatButton.ForeColor = System.Drawing.Color.LightGray
        Me.AnualBunifuFlatButton.Iconcolor = System.Drawing.Color.Transparent
        Me.AnualBunifuFlatButton.Iconimage = CType(resources.GetObject("AnualBunifuFlatButton.Iconimage"), System.Drawing.Image)
        Me.AnualBunifuFlatButton.Iconimage_right = Nothing
        Me.AnualBunifuFlatButton.Iconimage_right_Selected = Nothing
        Me.AnualBunifuFlatButton.Iconimage_Selected = Nothing
        Me.AnualBunifuFlatButton.IconMarginLeft = 0
        Me.AnualBunifuFlatButton.IconMarginRight = 0
        Me.AnualBunifuFlatButton.IconRightVisible = True
        Me.AnualBunifuFlatButton.IconRightZoom = 0R
        Me.AnualBunifuFlatButton.IconVisible = True
        Me.AnualBunifuFlatButton.IconZoom = 50.0R
        Me.AnualBunifuFlatButton.IsTab = True
        Me.AnualBunifuFlatButton.Name = "AnualBunifuFlatButton"
        Me.AnualBunifuFlatButton.Normalcolor = System.Drawing.Color.Gainsboro
        Me.AnualBunifuFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AnualBunifuFlatButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.AnualBunifuFlatButton.selected = False
        Me.AnualBunifuFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AnualBunifuFlatButton.Textcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AnualBunifuFlatButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MensulBunifuFlatButton
        '
        Me.MensulBunifuFlatButton.Activecolor = System.Drawing.Color.Blue
        Me.MensulBunifuFlatButton.BackColor = System.Drawing.Color.Gainsboro
        resources.ApplyResources(Me.MensulBunifuFlatButton, "MensulBunifuFlatButton")
        Me.MensulBunifuFlatButton.BorderRadius = 7
        Me.MensulBunifuFlatButton.ButtonText = "  Balance General"
        Me.MensulBunifuFlatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MensulBunifuFlatButton.DisabledColor = System.Drawing.Color.Gray
        Me.MensulBunifuFlatButton.ForeColor = System.Drawing.Color.LightGray
        Me.MensulBunifuFlatButton.Iconcolor = System.Drawing.Color.Transparent
        Me.MensulBunifuFlatButton.Iconimage = CType(resources.GetObject("MensulBunifuFlatButton.Iconimage"), System.Drawing.Image)
        Me.MensulBunifuFlatButton.Iconimage_right = Nothing
        Me.MensulBunifuFlatButton.Iconimage_right_Selected = Nothing
        Me.MensulBunifuFlatButton.Iconimage_Selected = Nothing
        Me.MensulBunifuFlatButton.IconMarginLeft = 0
        Me.MensulBunifuFlatButton.IconMarginRight = 0
        Me.MensulBunifuFlatButton.IconRightVisible = True
        Me.MensulBunifuFlatButton.IconRightZoom = 0R
        Me.MensulBunifuFlatButton.IconVisible = True
        Me.MensulBunifuFlatButton.IconZoom = 50.0R
        Me.MensulBunifuFlatButton.IsTab = True
        Me.MensulBunifuFlatButton.Name = "MensulBunifuFlatButton"
        Me.MensulBunifuFlatButton.Normalcolor = System.Drawing.Color.Gainsboro
        Me.MensulBunifuFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MensulBunifuFlatButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.MensulBunifuFlatButton.selected = False
        Me.MensulBunifuFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MensulBunifuFlatButton.Textcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MensulBunifuFlatButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SalesToDateBunifuFlatButton
        '
        Me.SalesToDateBunifuFlatButton.Activecolor = System.Drawing.Color.Blue
        Me.SalesToDateBunifuFlatButton.BackColor = System.Drawing.Color.Gainsboro
        resources.ApplyResources(Me.SalesToDateBunifuFlatButton, "SalesToDateBunifuFlatButton")
        Me.SalesToDateBunifuFlatButton.BorderRadius = 7
        Me.SalesToDateBunifuFlatButton.ButtonText = "Ventas por fecha"
        Me.SalesToDateBunifuFlatButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalesToDateBunifuFlatButton.DisabledColor = System.Drawing.Color.Gray
        Me.SalesToDateBunifuFlatButton.ForeColor = System.Drawing.Color.LightGray
        Me.SalesToDateBunifuFlatButton.Iconcolor = System.Drawing.Color.Transparent
        Me.SalesToDateBunifuFlatButton.Iconimage = CType(resources.GetObject("SalesToDateBunifuFlatButton.Iconimage"), System.Drawing.Image)
        Me.SalesToDateBunifuFlatButton.Iconimage_right = Nothing
        Me.SalesToDateBunifuFlatButton.Iconimage_right_Selected = Nothing
        Me.SalesToDateBunifuFlatButton.Iconimage_Selected = Nothing
        Me.SalesToDateBunifuFlatButton.IconMarginLeft = 0
        Me.SalesToDateBunifuFlatButton.IconMarginRight = 0
        Me.SalesToDateBunifuFlatButton.IconRightVisible = True
        Me.SalesToDateBunifuFlatButton.IconRightZoom = 0R
        Me.SalesToDateBunifuFlatButton.IconVisible = True
        Me.SalesToDateBunifuFlatButton.IconZoom = 50.0R
        Me.SalesToDateBunifuFlatButton.IsTab = True
        Me.SalesToDateBunifuFlatButton.Name = "SalesToDateBunifuFlatButton"
        Me.SalesToDateBunifuFlatButton.Normalcolor = System.Drawing.Color.Gainsboro
        Me.SalesToDateBunifuFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SalesToDateBunifuFlatButton.OnHoverTextColor = System.Drawing.Color.Black
        Me.SalesToDateBunifuFlatButton.selected = False
        Me.SalesToDateBunifuFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalesToDateBunifuFlatButton.Textcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalesToDateBunifuFlatButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        resources.ApplyResources(Me.BunifuSeparator2, "BunifuSeparator2")
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Edd_client_48
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Name = "Label1"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuSeparator1, "BunifuSeparator1")
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel4.Controls.Add(Me.BunifuSeparator5)
        Me.Panel4.Controls.Add(Me.BunifuSeparator4)
        Me.Panel4.Controls.Add(Me.BunifuSeparator3)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BunifuCircleProgressbar3)
        Me.Panel4.Controls.Add(Me.BunifuCircleProgressbar2)
        Me.Panel4.Controls.Add(Me.BunifuCircleProgressbar1)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'BunifuCustomLabel6
        '
        resources.ApplyResources(Me.BunifuCustomLabel6, "BunifuCustomLabel6")
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        '
        'BunifuCustomLabel4
        '
        resources.ApplyResources(Me.BunifuCustomLabel4, "BunifuCustomLabel4")
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        '
        'BunifuCustomLabel2
        '
        resources.ApplyResources(Me.BunifuCustomLabel2, "BunifuCustomLabel2")
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        resources.ApplyResources(Me.BunifuSeparator5, "BunifuSeparator5")
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        resources.ApplyResources(Me.BunifuSeparator4, "BunifuSeparator4")
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        resources.ApplyResources(Me.BunifuSeparator3, "BunifuSeparator3")
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuCustomLabel5
        '
        resources.ApplyResources(Me.BunifuCustomLabel5, "BunifuCustomLabel5")
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        '
        'BunifuCustomLabel3
        '
        resources.ApplyResources(Me.BunifuCustomLabel3, "BunifuCustomLabel3")
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        '
        'BunifuCustomLabel1
        '
        resources.ApplyResources(Me.BunifuCustomLabel1, "BunifuCustomLabel1")
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Name = "Label2"
        '
        'BunifuCircleProgressbar3
        '
        Me.BunifuCircleProgressbar3.animated = False
        Me.BunifuCircleProgressbar3.animationIterval = 5
        Me.BunifuCircleProgressbar3.animationSpeed = 300
        Me.BunifuCircleProgressbar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        resources.ApplyResources(Me.BunifuCircleProgressbar3, "BunifuCircleProgressbar3")
        Me.BunifuCircleProgressbar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCircleProgressbar3.LabelVisible = True
        Me.BunifuCircleProgressbar3.LineProgressThickness = 5
        Me.BunifuCircleProgressbar3.LineThickness = 2
        Me.BunifuCircleProgressbar3.MaxValue = 100
        Me.BunifuCircleProgressbar3.Name = "BunifuCircleProgressbar3"
        Me.BunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuCircleProgressbar3.Value = 80
        '
        'BunifuCircleProgressbar2
        '
        Me.BunifuCircleProgressbar2.animated = False
        Me.BunifuCircleProgressbar2.animationIterval = 5
        Me.BunifuCircleProgressbar2.animationSpeed = 300
        Me.BunifuCircleProgressbar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        resources.ApplyResources(Me.BunifuCircleProgressbar2, "BunifuCircleProgressbar2")
        Me.BunifuCircleProgressbar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuCircleProgressbar2.LabelVisible = True
        Me.BunifuCircleProgressbar2.LineProgressThickness = 5
        Me.BunifuCircleProgressbar2.LineThickness = 2
        Me.BunifuCircleProgressbar2.MaxValue = 100
        Me.BunifuCircleProgressbar2.Name = "BunifuCircleProgressbar2"
        Me.BunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BunifuCircleProgressbar2.Value = 80
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = False
        Me.BunifuCircleProgressbar1.animationIterval = 5
        Me.BunifuCircleProgressbar1.animationSpeed = 300
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer))
        resources.ApplyResources(Me.BunifuCircleProgressbar1, "BunifuCircleProgressbar1")
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 5
        Me.BunifuCircleProgressbar1.LineThickness = 2
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BunifuCircleProgressbar1.Value = 80
        '
        'PanelView
        '
        resources.ApplyResources(Me.PanelView, "PanelView")
        Me.PanelView.Name = "PanelView"
        '
        'frmBalanceGeneral
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBalanceGeneral"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents SalesToDateBunifuFlatButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCircleProgressbar3 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuCircleProgressbar2 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents AnualBunifuFlatButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MensulBunifuFlatButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelView As Panel
End Class
