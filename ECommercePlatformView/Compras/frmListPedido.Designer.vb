<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListPedido
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComprarButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panelcontrol = New System.Windows.Forms.Panel()
        Me.PanelView = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PrintButton = New System.Windows.Forms.Button()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panelcontrol.SuspendLayout()
        Me.PanelView.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComprarButton
        '
        Me.ComprarButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComprarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComprarButton.Location = New System.Drawing.Point(2, 2)
        Me.ComprarButton.Name = "ComprarButton"
        Me.ComprarButton.Size = New System.Drawing.Size(178, 33)
        Me.ComprarButton.TabIndex = 30
        Me.ComprarButton.Text = "&Transferir ha compradas"
        Me.ComprarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComprarButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 33)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "&Ver Detalle"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.datalistado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado.DefaultCellStyle = DataGridViewCellStyle2
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.GridColor = System.Drawing.Color.Black
        Me.datalistado.Location = New System.Drawing.Point(10, 10)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(835, 290)
        Me.datalistado.TabIndex = 29
        '
        'btnEliminar
        '
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Delete_16x16
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(183, 2)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(126, 34)
        Me.btnEliminar.TabIndex = 35
        Me.btnEliminar.Text = "&Eliminar Pedido"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'CopyAllButton
        '
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CopyAllButton.ForeColor = System.Drawing.Color.Black
        Me.CopyAllButton.Image = Global.ECommercePlatformView.My.Resources.Resources.SelectAll_16x16
        Me.CopyAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopyAllButton.Location = New System.Drawing.Point(94, 2)
        Me.CopyAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(89, 34)
        Me.CopyAllButton.TabIndex = 36
        Me.CopyAllButton.Text = "Seleccionar"
        Me.CopyAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Seleccionar todo")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SelectAllButton.ForeColor = System.Drawing.Color.Black
        Me.SelectAllButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Action_Copy
        Me.SelectAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectAllButton.Location = New System.Drawing.Point(2, 2)
        Me.SelectAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(92, 34)
        Me.SelectAllButton.TabIndex = 37
        Me.SelectAllButton.Text = "Seleccionar"
        Me.SelectAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SelectAllButton, "Seleccionar todo")
        Me.SelectAllButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Ok_Button)
        Me.Panel1.Controls.Add(Me.Cancel_Button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(1039, 40)
        Me.Panel1.TabIndex = 37
        '
        'Ok_Button
        '
        Me.Ok_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Ok_Button.Location = New System.Drawing.Point(857, 2)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(107, 36)
        Me.Ok_Button.TabIndex = 1
        Me.Ok_Button.Text = "Seleccionar.."
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cancel_Button.Location = New System.Drawing.Point(964, 2)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(73, 36)
        Me.Cancel_Button.TabIndex = 0
        Me.Cancel_Button.Text = "Cancelar"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Panelcontrol
        '
        Me.Panelcontrol.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panelcontrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelcontrol.Controls.Add(Me.Button2)
        Me.Panelcontrol.Controls.Add(Me.ComprarButton)
        Me.Panelcontrol.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelcontrol.Location = New System.Drawing.Point(0, 40)
        Me.Panelcontrol.Name = "Panelcontrol"
        Me.Panelcontrol.Padding = New System.Windows.Forms.Padding(2)
        Me.Panelcontrol.Size = New System.Drawing.Size(184, 310)
        Me.Panelcontrol.TabIndex = 38
        '
        'PanelView
        '
        Me.PanelView.Controls.Add(Me.datalistado)
        Me.PanelView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelView.Location = New System.Drawing.Point(184, 40)
        Me.PanelView.Name = "PanelView"
        Me.PanelView.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelView.Size = New System.Drawing.Size(855, 310)
        Me.PanelView.TabIndex = 39
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.PrintButton)
        Me.PanelMenu.Controls.Add(Me.btnEliminar)
        Me.PanelMenu.Controls.Add(Me.CopyAllButton)
        Me.PanelMenu.Controls.Add(Me.SelectAllButton)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenu.ForeColor = System.Drawing.Color.Black
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Padding = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Size = New System.Drawing.Size(1039, 40)
        Me.PanelMenu.TabIndex = 40
        '
        'PrintButton
        '
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Image = Global.ECommercePlatformView.My.Resources.Resources.printMatrix_24
        Me.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.Location = New System.Drawing.Point(309, 2)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(135, 34)
        Me.PrintButton.TabIndex = 38
        Me.PrintButton.Text = "&Imprimir listado"
        Me.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'frmListPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 390)
        Me.Controls.Add(Me.PanelView)
        Me.Controls.Add(Me.Panelcontrol)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "frmListPedido"
        Me.Text = "Listado de ordenes de compras"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panelcontrol.ResumeLayout(False)
        Me.PanelView.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComprarButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PanelView As Panel
    Friend WithEvents Panelcontrol As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ok_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents SelectAllButton As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PrintButton As Button
End Class
