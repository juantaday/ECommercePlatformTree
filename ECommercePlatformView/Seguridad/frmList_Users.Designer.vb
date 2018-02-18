<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList_Users
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
        Me.Panelpie = New System.Windows.Forms.Panel()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PaneMenu = New System.Windows.Forms.Panel()
        Me.PanelBusq = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmple_Busca = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PanelPieList = New System.Windows.Forms.Panel()
        Me.Total_listLabel = New System.Windows.Forms.Label()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.Panelpie.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneMenu.SuspendLayout()
        Me.PanelBusq.SuspendLayout()
        Me.PanelPieList.SuspendLayout()
        Me.PanelView.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelpie
        '
        Me.Panelpie.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panelpie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelpie.Controls.Add(Me.btnok)
        Me.Panelpie.Controls.Add(Me.btnCancel)
        Me.Panelpie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelpie.Location = New System.Drawing.Point(0, 368)
        Me.Panelpie.Name = "Panelpie"
        Me.Panelpie.Size = New System.Drawing.Size(827, 34)
        Me.Panelpie.TabIndex = 58
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.Black
        Me.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnok.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnok.Enabled = False
        Me.btnok.ForeColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(625, 0)
        Me.btnok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(125, 32)
        Me.btnok.TabIndex = 50
        Me.btnok.Text = "Seleccionar.."
        Me.btnok.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(750, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 32)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cerrar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PanelDetail
        '
        Me.PanelDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.btnDetalle)
        Me.PanelDetail.Controls.Add(Me.PictureBox1)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDetail.Enabled = False
        Me.PanelDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDetail.Location = New System.Drawing.Point(0, 0)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(193, 368)
        Me.PanelDetail.TabIndex = 59
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.Color.Red
        Me.btnDetalle.Image = Global.ECommercePlatformView.My.Resources.Resources.detail_user_48
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetalle.Location = New System.Drawing.Point(33, 189)
        Me.btnDetalle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(55, 55)
        Me.btnDetalle.TabIndex = 41
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 178)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'PaneMenu
        '
        Me.PaneMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaneMenu.Controls.Add(Me.PanelBusq)
        Me.PaneMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneMenu.Location = New System.Drawing.Point(193, 0)
        Me.PaneMenu.Name = "PaneMenu"
        Me.PaneMenu.Size = New System.Drawing.Size(634, 69)
        Me.PaneMenu.TabIndex = 60
        '
        'PanelBusq
        '
        Me.PanelBusq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBusq.Controls.Add(Me.Label3)
        Me.PanelBusq.Controls.Add(Me.txtEmple_Busca)
        Me.PanelBusq.Controls.Add(Me.btnBuscar)
        Me.PanelBusq.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBusq.Location = New System.Drawing.Point(237, 0)
        Me.PanelBusq.Name = "PanelBusq"
        Me.PanelBusq.Size = New System.Drawing.Size(395, 67)
        Me.PanelBusq.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Buscar empleado:"
        '
        'txtEmple_Busca
        '
        Me.txtEmple_Busca.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmple_Busca.Location = New System.Drawing.Point(4, 23)
        Me.txtEmple_Busca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmple_Busca.Name = "txtEmple_Busca"
        Me.txtEmple_Busca.Size = New System.Drawing.Size(288, 24)
        Me.txtEmple_Busca.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.zoom_Grin_24
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(300, 19)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 38)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'PanelPieList
        '
        Me.PanelPieList.Controls.Add(Me.Total_listLabel)
        Me.PanelPieList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPieList.Location = New System.Drawing.Point(193, 330)
        Me.PanelPieList.Name = "PanelPieList"
        Me.PanelPieList.Size = New System.Drawing.Size(634, 38)
        Me.PanelPieList.TabIndex = 62
        '
        'Total_listLabel
        '
        Me.Total_listLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Total_listLabel.Location = New System.Drawing.Point(0, 0)
        Me.Total_listLabel.Name = "Total_listLabel"
        Me.Total_listLabel.Size = New System.Drawing.Size(194, 38)
        Me.Total_listLabel.TabIndex = 0
        Me.Total_listLabel.Text = "Label1"
        Me.Total_listLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.dtg)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(193, 69)
        Me.PanelView.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Size = New System.Drawing.Size(634, 261)
        Me.PanelView.TabIndex = 63
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(0, 0)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(634, 261)
        Me.dtg.TabIndex = 0
        '
        'frmList_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 402)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.PanelPieList)
        Me.Controls.Add(Me.PaneMenu)
        Me.Controls.Add(Me.PanelDetail)
        Me.Controls.Add(Me.Panelpie)
        Me.Name = "frmList_Users"
        Me.Text = "Lista de usuarios"
        Me.Panelpie.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneMenu.ResumeLayout(False)
        Me.PanelBusq.ResumeLayout(False)
        Me.PanelBusq.PerformLayout()
        Me.PanelPieList.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelpie As System.Windows.Forms.Panel
    Friend WithEvents btnok As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents PaneMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelBusq As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmple_Busca As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents PanelPieList As System.Windows.Forms.Panel
    Friend WithEvents Total_listLabel As System.Windows.Forms.Label
    Friend WithEvents PanelView As System.Windows.Forms.Panel
    Friend WithEvents dtg As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
