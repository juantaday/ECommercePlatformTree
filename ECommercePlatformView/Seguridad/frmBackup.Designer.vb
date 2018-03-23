<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelLefth = New System.Windows.Forms.Panel()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.ListView1 = New BrightIdeasSoftware.FastObjectListView()
        Me.IDClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.PropertiesClm = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.PreViewButton = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.SettingControls = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.PanelLefth.SuspendLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl1.SuspendLayout()
        Me.AccordionContentContainer1.SuspendLayout()
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(696, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(93, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(789, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(84, 26)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 357)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(878, 34)
        Me.Panel1.TabIndex = 1
        '
        'PanelLefth
        '
        Me.PanelLefth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLefth.Controls.Add(Me.AccordionControl1)
        Me.PanelLefth.Controls.Add(Me.Panel4)
        Me.PanelLefth.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLefth.Location = New System.Drawing.Point(3, 3)
        Me.PanelLefth.Name = "PanelLefth"
        Me.PanelLefth.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelLefth.Size = New System.Drawing.Size(239, 354)
        Me.PanelLefth.TabIndex = 2
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer1)
        Me.AccordionControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1, Me.AccordionControlElement2, Me.AccordionControlElement4})
        Me.AccordionControl1.Location = New System.Drawing.Point(3, 27)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.Size = New System.Drawing.Size(231, 322)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.Text = "AccordionControl1"
        '
        'AccordionContentContainer1
        '
        Me.AccordionContentContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.AccordionContentContainer1.Appearance.Options.UseBackColor = True
        Me.AccordionContentContainer1.Controls.Add(Me.ListView1)
        Me.AccordionContentContainer1.Name = "AccordionContentContainer1"
        Me.AccordionContentContainer1.Size = New System.Drawing.Size(214, 170)
        Me.AccordionContentContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.AllColumns.Add(Me.IDClm)
        Me.ListView1.AllColumns.Add(Me.PropertiesClm)
        Me.ListView1.AllowDrop = True
        Me.ListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDClm, Me.PropertiesClm})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.EmptyListMsg = "No hay informacion"
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.HideSelection = False
        Me.ListView1.HighlightBackgroundColor = System.Drawing.Color.Navy
        Me.ListView1.HighlightForegroundColor = System.Drawing.Color.White
        Me.ListView1.IncludeColumnHeadersInCopy = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.ListView1.ShowCommandMenuOnRightClick = True
        Me.ListView1.ShowGroups = False
        Me.ListView1.ShowImagesOnSubItems = True
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(214, 170)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 4
        Me.ListView1.UnfocusedHighlightBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListView1.UnfocusedHighlightForegroundColor = System.Drawing.Color.Black
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseHotItem = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.VirtualMode = True
        '
        'IDClm
        '
        Me.IDClm.AspectName = "ID"
        Me.IDClm.IsVisible = False
        Me.IDClm.Text = "Cod Key"
        Me.IDClm.Width = 0
        '
        'PropertiesClm
        '
        Me.PropertiesClm.AspectName = "NameDescription"
        Me.PropertiesClm.Text = "Properties"
        Me.PropertiesClm.Width = 300
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "DataBase_16.png")
        Me.ImageList1.Images.SetKeyName(1, "if_5_2739115.png")
        Me.ImageList1.Images.SetKeyName(2, "if_file-download_326639.png")
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.PreViewButton})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Básico"
        '
        'PreViewButton
        '
        Me.PreViewButton.Appearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.PreViewButton.Appearance.Normal.Options.UseBackColor = True
        Me.PreViewButton.Appearance.Pressed.Options.UseBackColor = True
        Me.PreViewButton.Appearance.Pressed.Options.UseBorderColor = True
        Me.PreViewButton.Appearance.Pressed.Options.UseForeColor = True
        Me.PreViewButton.Name = "PreViewButton"
        Me.PreViewButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.PreViewButton.Text = "Solo copia de serguriad."
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.SettingControls})
        Me.AccordionControlElement2.Expanded = True
        Me.AccordionControlElement2.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Text = "Avanzado"
        '
        'SettingControls
        '
        Me.SettingControls.ContentContainer = Me.AccordionContentContainer1
        Me.SettingControls.Name = "SettingControls"
        Me.SettingControls.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.SettingControls.Text = "Configuar"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement3})
        Me.AccordionControlElement4.Expanded = True
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Text = "Limpiar transacciones"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "Detalle de limpiaza"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(231, 24)
        Me.Panel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione un página"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(247, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 40)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Respaldo de base de datos"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Navy
        Me.Splitter1.Location = New System.Drawing.Point(242, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 354)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'PanelView
        '
        Me.PanelView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(247, 43)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(634, 314)
        Me.PanelView.TabIndex = 5
        '
        'frmBackup
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(884, 394)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelLefth)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dackup and recovery the database...."
        Me.Panel1.ResumeLayout(False)
        Me.PanelLefth.ResumeLayout(False)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl1.ResumeLayout(False)
        Me.AccordionContentContainer1.ResumeLayout(False)
        CType(Me.ListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLefth As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents PreViewButton As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents SettingControls As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents PanelView As Panel
    Friend WithEvents ListView1 As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents IDClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents PropertiesClm As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
