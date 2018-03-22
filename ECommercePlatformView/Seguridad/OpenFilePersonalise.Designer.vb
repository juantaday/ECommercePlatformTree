Imports BrightIdeasSoftware

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpenFilePersonalise
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TypeFileComboBox = New System.Windows.Forms.ComboBox()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.FileRelativeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MytreeListView = New BrightIdeasSoftware.TreeListView()
        Me.treeColumnName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnCreated = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnModified = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnSize = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnFileType = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnAttributes = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.treeColumnFileExtension = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.hotItemStyle1 = New BrightIdeasSoftware.HotItemStyle()
        Me.hotItemStyle3 = New BrightIdeasSoftware.HotItemStyle()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.MytreeListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.OK_Button.Location = New System.Drawing.Point(387, 0)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(99, 33)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(486, 0)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(85, 33)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OK_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 33)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TypeFileComboBox)
        Me.Panel2.Controls.Add(Me.FileNameTextBox)
        Me.Panel2.Controls.Add(Me.FileRelativeTextBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 331)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 10, 5)
        Me.Panel2.Size = New System.Drawing.Size(583, 127)
        Me.Panel2.TabIndex = 3
        '
        'TypeFileComboBox
        '
        Me.TypeFileComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeFileComboBox.FormattingEnabled = True
        Me.TypeFileComboBox.Location = New System.Drawing.Point(139, 30)
        Me.TypeFileComboBox.Name = "TypeFileComboBox"
        Me.TypeFileComboBox.Size = New System.Drawing.Size(435, 21)
        Me.TypeFileComboBox.TabIndex = 5
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileNameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FileNameTextBox.Location = New System.Drawing.Point(139, 58)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(204, 20)
        Me.FileNameTextBox.TabIndex = 4
        '
        'FileRelativeTextBox
        '
        Me.FileRelativeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileRelativeTextBox.Location = New System.Drawing.Point(139, 3)
        Me.FileRelativeTextBox.Name = "FileRelativeTextBox"
        Me.FileRelativeTextBox.ReadOnly = True
        Me.FileRelativeTextBox.Size = New System.Drawing.Size(435, 20)
        Me.FileRelativeTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre de archivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de archivo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ruta relativa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Seleccion archivo:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(5, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Colapzar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 44)
        Me.Panel3.TabIndex = 6
        '
        'MytreeListView
        '
        Me.MytreeListView.AllColumns.Add(Me.treeColumnName)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnCreated)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnModified)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnSize)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnFileType)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnAttributes)
        Me.MytreeListView.AllColumns.Add(Me.treeColumnFileExtension)
        Me.MytreeListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.treeColumnName, Me.treeColumnCreated, Me.treeColumnModified, Me.treeColumnSize, Me.treeColumnFileType, Me.treeColumnAttributes, Me.treeColumnFileExtension})
        Me.MytreeListView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MytreeListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MytreeListView.EmptyListMsg = "This folder is completely empty!"
        Me.MytreeListView.EmptyListMsgFont = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MytreeListView.ForeColor = System.Drawing.Color.Black
        Me.MytreeListView.HideSelection = False
        Me.MytreeListView.HotItemStyle = Me.hotItemStyle1
        Me.MytreeListView.IsSimpleDragSource = True
        Me.MytreeListView.IsSimpleDropSink = True
        Me.MytreeListView.Location = New System.Drawing.Point(3, 47)
        Me.MytreeListView.Name = "MytreeListView"
        Me.MytreeListView.OwnerDraw = True
        Me.MytreeListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu
        Me.MytreeListView.ShowCommandMenuOnRightClick = True
        Me.MytreeListView.ShowGroups = False
        Me.MytreeListView.ShowImagesOnSubItems = True
        Me.MytreeListView.ShowItemToolTips = True
        Me.MytreeListView.Size = New System.Drawing.Size(583, 284)
        Me.MytreeListView.TabIndex = 13
        Me.MytreeListView.UseCompatibleStateImageBehavior = False
        Me.MytreeListView.UseFilterIndicator = True
        Me.MytreeListView.UseFiltering = True
        Me.MytreeListView.UseHotItem = True
        Me.MytreeListView.View = System.Windows.Forms.View.Details
        Me.MytreeListView.VirtualMode = True
        '
        'treeColumnName
        '
        Me.treeColumnName.AspectName = "Name"
        Me.treeColumnName.IsTileViewColumn = True
        Me.treeColumnName.Text = "Name"
        Me.treeColumnName.UseInitialLetterForGroup = True
        Me.treeColumnName.Width = 400
        Me.treeColumnName.WordWrap = True
        '
        'treeColumnCreated
        '
        Me.treeColumnCreated.AspectName = "CreationTime"
        Me.treeColumnCreated.Text = "Created"
        Me.treeColumnCreated.Width = 131
        '
        'treeColumnModified
        '
        Me.treeColumnModified.AspectName = "LastWriteTime"
        Me.treeColumnModified.IsTileViewColumn = True
        Me.treeColumnModified.Text = "Modified"
        Me.treeColumnModified.Width = 145
        '
        'treeColumnSize
        '
        Me.treeColumnSize.AspectName = "Extension"
        Me.treeColumnSize.Text = "Size"
        '
        'treeColumnFileType
        '
        Me.treeColumnFileType.Text = "File Type"
        '
        'treeColumnAttributes
        '
        Me.treeColumnAttributes.Text = "Attributes"
        '
        'treeColumnFileExtension
        '
        Me.treeColumnFileExtension.AspectName = "Extension"
        Me.treeColumnFileExtension.Text = "Extension"
        '
        'hotItemStyle1
        '
        Me.hotItemStyle1.BackColor = System.Drawing.Color.PeachPuff
        Me.hotItemStyle1.ForeColor = System.Drawing.Color.MediumBlue
        '
        'hotItemStyle3
        '
        Me.hotItemStyle3.ForeColor = System.Drawing.Color.DarkGreen
        '
        'OpenFilePersonalise
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(589, 461)
        Me.Controls.Add(Me.MytreeListView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenFilePersonalise"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find the file"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.MytreeListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents MytreeListView As BrightIdeasSoftware.TreeListView
    Friend WithEvents treeColumnName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnCreated As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnModified As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnSize As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnFileType As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnAttributes As BrightIdeasSoftware.OLVColumn
    Friend WithEvents treeColumnFileExtension As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TypeFileComboBox As ComboBox
    Friend WithEvents FileNameTextBox As TextBox
    Friend WithEvents FileRelativeTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel3 As Panel
    Private WithEvents hotItemStyle1 As HotItemStyle
    Private WithEvents hotItemStyle3 As HotItemStyle
End Class
