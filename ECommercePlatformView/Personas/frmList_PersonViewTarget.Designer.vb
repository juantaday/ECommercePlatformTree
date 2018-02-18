<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_PersonViewTarget
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
        Me.Panelpie = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.PersonVisibleNemuClicLabel = New System.Windows.Forms.Label()
        Me.PanelBusqueda = New System.Windows.Forms.Panel()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.TableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TotalIndexLabel = New System.Windows.Forms.Label()
        Me.NextLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PreviuLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PersonClickNamaLabel = New System.Windows.Forms.Label()
        Me.SelectPersonButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelBusqueda.SuspendLayout()
        Me.PanelDatos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panelpie
        '
        Me.Panelpie.BackColor = System.Drawing.Color.Black
        Me.Panelpie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelpie.Location = New System.Drawing.Point(0, 358)
        Me.Panelpie.Name = "Panelpie"
        Me.Panelpie.Size = New System.Drawing.Size(978, 38)
        Me.Panelpie.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.DeleteButton)
        Me.PanelMenu.Controls.Add(Me.DetailsButton)
        Me.PanelMenu.Controls.Add(Me.EditButton)
        Me.PanelMenu.Controls.Add(Me.AddNewButton)
        Me.PanelMenu.Controls.Add(Me.PersonVisibleNemuClicLabel)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(978, 39)
        Me.PanelMenu.TabIndex = 1
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(606, 0)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(80, 39)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Eliminar"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'DetailsButton
        '
        Me.DetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DetailsButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DetailsButton.ForeColor = System.Drawing.Color.Black
        Me.DetailsButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.DetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DetailsButton.Location = New System.Drawing.Point(526, 0)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(80, 39)
        Me.DetailsButton.TabIndex = 5
        Me.DetailsButton.Text = "Detalle"
        Me.DetailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EditButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.EditButton.Image = Global.ECommercePlatformView.My.Resources.Resources.edit_24
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(445, 0)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(81, 39)
        Me.EditButton.TabIndex = 4
        Me.EditButton.Text = "Editar"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddNewButton
        '
        Me.AddNewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AddNewButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.AddNewButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_New
        Me.AddNewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewButton.Location = New System.Drawing.Point(354, 0)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(91, 39)
        Me.AddNewButton.TabIndex = 0
        Me.AddNewButton.Text = "Agregar"
        Me.AddNewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddNewButton.UseVisualStyleBackColor = False
        '
        'PersonVisibleNemuClicLabel
        '
        Me.PersonVisibleNemuClicLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PersonVisibleNemuClicLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.PersonVisibleNemuClicLabel.Location = New System.Drawing.Point(0, 0)
        Me.PersonVisibleNemuClicLabel.Name = "PersonVisibleNemuClicLabel"
        Me.PersonVisibleNemuClicLabel.Size = New System.Drawing.Size(354, 39)
        Me.PersonVisibleNemuClicLabel.TabIndex = 2
        Me.PersonVisibleNemuClicLabel.Tag = "0"
        '
        'PanelBusqueda
        '
        Me.PanelBusqueda.Controls.Add(Me.FindTextBox)
        Me.PanelBusqueda.Controls.Add(Me.FindButton)
        Me.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBusqueda.Location = New System.Drawing.Point(0, 39)
        Me.PanelBusqueda.Name = "PanelBusqueda"
        Me.PanelBusqueda.Size = New System.Drawing.Size(978, 46)
        Me.PanelBusqueda.TabIndex = 0
        '
        'FindTextBox
        '
        Me.FindTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindTextBox.Location = New System.Drawing.Point(17, 11)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(340, 26)
        Me.FindTextBox.TabIndex = 0
        '
        'FindButton
        '
        Me.FindButton.Image = Global.ECommercePlatformView.My.Resources.Resources.FindCustomers_32x32
        Me.FindButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindButton.Location = New System.Drawing.Point(363, 4)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(102, 38)
        Me.FindButton.TabIndex = 2
        Me.FindButton.Text = "Buscar"
        Me.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindButton.UseVisualStyleBackColor = True
        '
        'TableLayout
        '
        Me.TableLayout.AutoScroll = True
        Me.TableLayout.AutoScrollMargin = New System.Drawing.Size(1, 1)
        Me.TableLayout.AutoScrollMinSize = New System.Drawing.Size(12, 20)
        Me.TableLayout.ColumnCount = 4
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayout.Location = New System.Drawing.Point(3, 3)
        Me.TableLayout.Name = "TableLayout"
        Me.TableLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.TableLayout.RowCount = 2
        Me.TableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayout.Size = New System.Drawing.Size(970, 237)
        Me.TableLayout.TabIndex = 0
        '
        'PanelDatos
        '
        Me.PanelDatos.BackColor = System.Drawing.Color.White
        Me.PanelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDatos.Controls.Add(Me.TableLayout)
        Me.PanelDatos.Controls.Add(Me.Panel3)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatos.Location = New System.Drawing.Point(0, 85)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelDatos.Size = New System.Drawing.Size(978, 273)
        Me.PanelDatos.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TotalIndexLabel)
        Me.Panel3.Controls.Add(Me.NextLinkLabel)
        Me.Panel3.Controls.Add(Me.PreviuLinkLabel)
        Me.Panel3.Controls.Add(Me.PersonClickNamaLabel)
        Me.Panel3.Controls.Add(Me.SelectPersonButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 28)
        Me.Panel3.TabIndex = 0
        '
        'TotalIndexLabel
        '
        Me.TotalIndexLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TotalIndexLabel.Location = New System.Drawing.Point(76, 0)
        Me.TotalIndexLabel.Name = "TotalIndexLabel"
        Me.TotalIndexLabel.Size = New System.Drawing.Size(315, 28)
        Me.TotalIndexLabel.TabIndex = 4
        Me.TotalIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NextLinkLabel
        '
        Me.NextLinkLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.NextLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextLinkLabel.Location = New System.Drawing.Point(38, 0)
        Me.NextLinkLabel.Name = "NextLinkLabel"
        Me.NextLinkLabel.Size = New System.Drawing.Size(38, 28)
        Me.NextLinkLabel.TabIndex = 3
        Me.NextLinkLabel.TabStop = True
        Me.NextLinkLabel.Text = ">>"
        Me.NextLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.NextLinkLabel, "Página siguiente")
        '
        'PreviuLinkLabel
        '
        Me.PreviuLinkLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.PreviuLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviuLinkLabel.Location = New System.Drawing.Point(0, 0)
        Me.PreviuLinkLabel.Name = "PreviuLinkLabel"
        Me.PreviuLinkLabel.Size = New System.Drawing.Size(38, 28)
        Me.PreviuLinkLabel.TabIndex = 2
        Me.PreviuLinkLabel.TabStop = True
        Me.PreviuLinkLabel.Text = "<<"
        Me.PreviuLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.PreviuLinkLabel, "Página anterior")
        '
        'PersonClickNamaLabel
        '
        Me.PersonClickNamaLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PersonClickNamaLabel.Location = New System.Drawing.Point(624, 0)
        Me.PersonClickNamaLabel.Name = "PersonClickNamaLabel"
        Me.PersonClickNamaLabel.Size = New System.Drawing.Size(243, 28)
        Me.PersonClickNamaLabel.TabIndex = 1
        Me.PersonClickNamaLabel.Tag = "0"
        '
        'SelectPersonButton
        '
        Me.SelectPersonButton.BackColor = System.Drawing.Color.Silver
        Me.SelectPersonButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SelectPersonButton.Location = New System.Drawing.Point(867, 0)
        Me.SelectPersonButton.Name = "SelectPersonButton"
        Me.SelectPersonButton.Size = New System.Drawing.Size(103, 28)
        Me.SelectPersonButton.TabIndex = 0
        Me.SelectPersonButton.Text = "Seleccionar.."
        Me.SelectPersonButton.UseVisualStyleBackColor = False
        '
        'frmList_PersonViewTarget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 396)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.Panelpie)
        Me.Name = "frmList_PersonViewTarget"
        Me.Text = "List People"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.PanelDatos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelpie As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelBusqueda As System.Windows.Forms.Panel
    Friend WithEvents TableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelMaster As System.Windows.Forms.Panel
    Friend WithEvents PanelTible As System.Windows.Forms.Panel
    Friend WithEvents NomLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents telefLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox 'PicturImageCard
    Friend WithEvents PicturImageCard As System.Windows.Forms.PictureBox
    Friend WithEvents PicturImageTelf As System.Windows.Forms.PictureBox
    Friend WithEvents PanelCard As System.Windows.Forms.Panel
    Friend WithEvents cedulaLabel As System.Windows.Forms.Label
    Friend WithEvents PanelDatos As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents TotalIndexLabel As System.Windows.Forms.Label
    Friend WithEvents NextLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PreviuLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PersonClickNamaLabel As System.Windows.Forms.Label
    Friend WithEvents SelectPersonButton As System.Windows.Forms.Button
    Friend WithEvents PersonVisibleNemuClicLabel As System.Windows.Forms.Label
    Friend WithEvents DetailsButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents AddNewButton As System.Windows.Forms.Button
    Friend WithEvents FindTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
