<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetthingCommerce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetthingCommerce))
        Me.PanelViewSetthing = New System.Windows.Forms.Panel()
        Me.ExecuteIvaConfigBunifuThinButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PercentageIvaTextBox = New System.Windows.Forms.TextBox()
        Me.PercentDecimalIvaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.SalesTabPage = New System.Windows.Forms.TabPage()
        Me.SettingDefaultPrinter = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RequestSalesAutorizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.SettingSalesComboBox = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PurchaseTabPage = New System.Windows.Forms.TabPage()
        Me.EnableEditPurchaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.moneyColumnComboBox = New MultiControls.Controls.ColumnComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelViewSetthing.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PercentDecimalIvaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SalesTabPage.SuspendLayout()
        Me.PurchaseTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelViewSetthing
        '
        Me.PanelViewSetthing.AutoScroll = True
        Me.PanelViewSetthing.Controls.Add(Me.ExecuteIvaConfigBunifuThinButton)
        Me.PanelViewSetthing.Controls.Add(Me.Panel3)
        Me.PanelViewSetthing.Controls.Add(Me.Label3)
        Me.PanelViewSetthing.Controls.Add(Me.Panel2)
        Me.PanelViewSetthing.Controls.Add(Me.SaveButton)
        Me.PanelViewSetthing.Controls.Add(Me.moneyColumnComboBox)
        Me.PanelViewSetthing.Controls.Add(Me.Panel1)
        Me.PanelViewSetthing.Controls.Add(Me.Label1)
        Me.PanelViewSetthing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelViewSetthing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PanelViewSetthing.Location = New System.Drawing.Point(8, 4)
        Me.PanelViewSetthing.Name = "PanelViewSetthing"
        Me.PanelViewSetthing.Size = New System.Drawing.Size(690, 440)
        Me.PanelViewSetthing.TabIndex = 0
        '
        'ExecuteIvaConfigBunifuThinButton
        '
        Me.ExecuteIvaConfigBunifuThinButton.ActiveBorderThickness = 1
        Me.ExecuteIvaConfigBunifuThinButton.ActiveCornerRadius = 20
        Me.ExecuteIvaConfigBunifuThinButton.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.ExecuteIvaConfigBunifuThinButton.ActiveForecolor = System.Drawing.Color.White
        Me.ExecuteIvaConfigBunifuThinButton.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.ExecuteIvaConfigBunifuThinButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExecuteIvaConfigBunifuThinButton.BackgroundImage = CType(resources.GetObject("ExecuteIvaConfigBunifuThinButton.BackgroundImage"), System.Drawing.Image)
        Me.ExecuteIvaConfigBunifuThinButton.ButtonText = "Ejecutar cambio de iva."
        Me.ExecuteIvaConfigBunifuThinButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExecuteIvaConfigBunifuThinButton.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExecuteIvaConfigBunifuThinButton.ForeColor = System.Drawing.Color.SeaGreen
        Me.ExecuteIvaConfigBunifuThinButton.IdleBorderThickness = 1
        Me.ExecuteIvaConfigBunifuThinButton.IdleCornerRadius = 20
        Me.ExecuteIvaConfigBunifuThinButton.IdleFillColor = System.Drawing.Color.White
        Me.ExecuteIvaConfigBunifuThinButton.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.ExecuteIvaConfigBunifuThinButton.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.ExecuteIvaConfigBunifuThinButton.Location = New System.Drawing.Point(386, 89)
        Me.ExecuteIvaConfigBunifuThinButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExecuteIvaConfigBunifuThinButton.Name = "ExecuteIvaConfigBunifuThinButton"
        Me.ExecuteIvaConfigBunifuThinButton.Size = New System.Drawing.Size(168, 34)
        Me.ExecuteIvaConfigBunifuThinButton.TabIndex = 12
        Me.ExecuteIvaConfigBunifuThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PercentageIvaTextBox)
        Me.Panel3.Controls.Add(Me.PercentDecimalIvaNumericUpDown)
        Me.Panel3.Location = New System.Drawing.Point(249, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(131, 27)
        Me.Panel3.TabIndex = 11
        '
        'PercentageIvaTextBox
        '
        Me.PercentageIvaTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PercentageIvaTextBox.Location = New System.Drawing.Point(2, 2)
        Me.PercentageIvaTextBox.Name = "PercentageIvaTextBox"
        Me.PercentageIvaTextBox.ReadOnly = True
        Me.PercentageIvaTextBox.Size = New System.Drawing.Size(112, 23)
        Me.PercentageIvaTextBox.TabIndex = 10
        Me.PercentageIvaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PercentDecimalIvaNumericUpDown
        '
        Me.PercentDecimalIvaNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PercentDecimalIvaNumericUpDown.Dock = System.Windows.Forms.DockStyle.Right
        Me.PercentDecimalIvaNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentDecimalIvaNumericUpDown.Location = New System.Drawing.Point(114, 2)
        Me.PercentDecimalIvaNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentDecimalIvaNumericUpDown.Name = "PercentDecimalIvaNumericUpDown"
        Me.PercentDecimalIvaNumericUpDown.Size = New System.Drawing.Size(15, 23)
        Me.PercentDecimalIvaNumericUpDown.TabIndex = 9
        Me.PercentDecimalIvaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Porcentage de iva predeterminado:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl)
        Me.Panel2.Location = New System.Drawing.Point(15, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(660, 210)
        Me.Panel2.TabIndex = 7
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.SalesTabPage)
        Me.TabControl.Controls.Add(Me.PurchaseTabPage)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(2, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(654, 204)
        Me.TabControl.TabIndex = 6
        '
        'SalesTabPage
        '
        Me.SalesTabPage.Controls.Add(Me.SettingDefaultPrinter)
        Me.SalesTabPage.Controls.Add(Me.RequestSalesAutorizeCheckBox)
        Me.SalesTabPage.Controls.Add(Me.SettingSalesComboBox)
        Me.SalesTabPage.Controls.Add(Me.BunifuCustomLabel1)
        Me.SalesTabPage.Location = New System.Drawing.Point(4, 25)
        Me.SalesTabPage.Name = "SalesTabPage"
        Me.SalesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SalesTabPage.Size = New System.Drawing.Size(646, 175)
        Me.SalesTabPage.TabIndex = 0
        Me.SalesTabPage.Text = " Sección ventas"
        Me.SalesTabPage.UseVisualStyleBackColor = True
        '
        'SettingDefaultPrinter
        '
        Me.SettingDefaultPrinter.ActiveBorderThickness = 1
        Me.SettingDefaultPrinter.ActiveCornerRadius = 20
        Me.SettingDefaultPrinter.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.SettingDefaultPrinter.ActiveForecolor = System.Drawing.Color.White
        Me.SettingDefaultPrinter.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.SettingDefaultPrinter.BackColor = System.Drawing.Color.Transparent
        Me.SettingDefaultPrinter.BackgroundImage = CType(resources.GetObject("SettingDefaultPrinter.BackgroundImage"), System.Drawing.Image)
        Me.SettingDefaultPrinter.ButtonText = "Opiones avanzadas.."
        Me.SettingDefaultPrinter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingDefaultPrinter.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingDefaultPrinter.ForeColor = System.Drawing.Color.SeaGreen
        Me.SettingDefaultPrinter.IdleBorderThickness = 1
        Me.SettingDefaultPrinter.IdleCornerRadius = 20
        Me.SettingDefaultPrinter.IdleFillColor = System.Drawing.Color.White
        Me.SettingDefaultPrinter.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.SettingDefaultPrinter.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.SettingDefaultPrinter.Location = New System.Drawing.Point(11, 121)
        Me.SettingDefaultPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.SettingDefaultPrinter.Name = "SettingDefaultPrinter"
        Me.SettingDefaultPrinter.Size = New System.Drawing.Size(168, 34)
        Me.SettingDefaultPrinter.TabIndex = 15
        Me.SettingDefaultPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RequestSalesAutorizeCheckBox
        '
        Me.RequestSalesAutorizeCheckBox.AutoSize = True
        Me.RequestSalesAutorizeCheckBox.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.RequestSalesAutorizeCheckBox.ForeColor = System.Drawing.Color.DimGray
        Me.RequestSalesAutorizeCheckBox.Location = New System.Drawing.Point(8, 10)
        Me.RequestSalesAutorizeCheckBox.Name = "RequestSalesAutorizeCheckBox"
        Me.RequestSalesAutorizeCheckBox.Size = New System.Drawing.Size(351, 19)
        Me.RequestSalesAutorizeCheckBox.TabIndex = 14
        Me.RequestSalesAutorizeCheckBox.Text = "Pedir autorización para eliminar los items en venta.."
        Me.RequestSalesAutorizeCheckBox.UseVisualStyleBackColor = True
        '
        'SettingSalesComboBox
        '
        Me.SettingSalesComboBox.FormattingEnabled = True
        Me.SettingSalesComboBox.Location = New System.Drawing.Point(218, 36)
        Me.SettingSalesComboBox.Name = "SettingSalesComboBox"
        Me.SettingSalesComboBox.Size = New System.Drawing.Size(410, 24)
        Me.SettingSalesComboBox.TabIndex = 13
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(8, 41)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(204, 15)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Al buscar productos presentar:"
        '
        'PurchaseTabPage
        '
        Me.PurchaseTabPage.Controls.Add(Me.EnableEditPurchaseCheckBox)
        Me.PurchaseTabPage.Location = New System.Drawing.Point(4, 25)
        Me.PurchaseTabPage.Name = "PurchaseTabPage"
        Me.PurchaseTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PurchaseTabPage.Size = New System.Drawing.Size(646, 175)
        Me.PurchaseTabPage.TabIndex = 1
        Me.PurchaseTabPage.Text = " Sección compras"
        Me.PurchaseTabPage.UseVisualStyleBackColor = True
        '
        'EnableEditPurchaseCheckBox
        '
        Me.EnableEditPurchaseCheckBox.AutoSize = True
        Me.EnableEditPurchaseCheckBox.Font = New System.Drawing.Font("Lucida Sans", 9.75!)
        Me.EnableEditPurchaseCheckBox.ForeColor = System.Drawing.Color.DimGray
        Me.EnableEditPurchaseCheckBox.Location = New System.Drawing.Point(7, 11)
        Me.EnableEditPurchaseCheckBox.Name = "EnableEditPurchaseCheckBox"
        Me.EnableEditPurchaseCheckBox.Size = New System.Drawing.Size(340, 19)
        Me.EnableEditPurchaseCheckBox.TabIndex = 15
        Me.EnableEditPurchaseCheckBox.Text = "Habilitar modificación rápida en precio de compra."
        Me.EnableEditPurchaseCheckBox.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SaveButton.ForeColor = System.Drawing.Color.White
        Me.SaveButton.Image = Global.ECommercePlatformView.My.Resources.Resources.Save_White_32
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(15, 374)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(349, 36)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "        Guardar.."
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'moneyColumnComboBox
        '
        Me.moneyColumnComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.moneyColumnComboBox.DropDownWidth = 17
        Me.moneyColumnComboBox.FormattingEnabled = True
        Me.moneyColumnComboBox.Location = New System.Drawing.Point(185, 58)
        Me.moneyColumnComboBox.Name = "moneyColumnComboBox"
        Me.moneyColumnComboBox.Size = New System.Drawing.Size(369, 24)
        Me.moneyColumnComboBox.TabIndex = 4
        Me.moneyColumnComboBox.ViewColumn = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(690, 46)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Configuraciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Moneda predeterminada:"
        '
        'frmSetthingCommerce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 458)
        Me.Controls.Add(Me.PanelViewSetthing)
        Me.Name = "frmSetthingCommerce"
        Me.Text = "frmSetthingCommerce"
        Me.PanelViewSetthing.ResumeLayout(False)
        Me.PanelViewSetthing.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PercentDecimalIvaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.SalesTabPage.ResumeLayout(False)
        Me.SalesTabPage.PerformLayout()
        Me.PurchaseTabPage.ResumeLayout(False)
        Me.PurchaseTabPage.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelViewSetthing As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents moneyColumnComboBox As MultiControls.Controls.ColumnComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl As TabControl
    Friend WithEvents SalesTabPage As TabPage
    Friend WithEvents PurchaseTabPage As TabPage
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SettingSalesComboBox As ComboBox
    Friend WithEvents PercentDecimalIvaNumericUpDown As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PercentageIvaTextBox As TextBox
    Friend WithEvents RequestSalesAutorizeCheckBox As CheckBox
    Friend WithEvents ExecuteIvaConfigBunifuThinButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents EnableEditPurchaseCheckBox As CheckBox
    Friend WithEvents SettingDefaultPrinter As Bunifu.Framework.UI.BunifuThinButton2
End Class
