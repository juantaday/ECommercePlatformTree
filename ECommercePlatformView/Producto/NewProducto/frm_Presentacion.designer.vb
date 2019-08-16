<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Presentacion
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
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panePresentacion = New System.Windows.Forms.Panel()
        Me.isPresentFabricCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCtlPresentacion = New System.Windows.Forms.Panel()
        Me.TableLayouButoonControl = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEdit_Present = New System.Windows.Forms.Button()
        Me.btnUpdatePresent = New System.Windows.Forms.Button()
        Me.btnAdd_Present = New System.Windows.Forms.Button()
        Me.btnCancelPresent = New System.Windows.Forms.Button()
        Me.btnDelet_Present = New System.Windows.Forms.Button()
        Me.lblvieneEn = New System.Windows.Forms.Label()
        Me.cmbPresentResult = New System.Windows.Forms.ComboBox()
        Me.cmbUndMedPresentRefery = New System.Windows.Forms.ComboBox()
        Me.lblPresentDeText = New System.Windows.Forms.Label()
        Me.lblIdPresentDe = New System.Windows.Forms.Label()
        Me.txtCant_Present = New System.Windows.Forms.NumericUpDown()
        Me.lblCNTpresent = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SiguientButton = New System.Windows.Forms.Button()
        Me.DataGridPresent = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panePresentacion.SuspendLayout()
        Me.pnlCtlPresentacion.SuspendLayout()
        Me.TableLayouButoonControl.SuspendLayout()
        CType(Me.txtCant_Present, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'panePresentacion
        '
        Me.panePresentacion.BackColor = System.Drawing.Color.GreenYellow
        Me.panePresentacion.Controls.Add(Me.isPresentFabricCheckedListBox)
        Me.panePresentacion.Controls.Add(Me.Label2)
        Me.panePresentacion.Controls.Add(Me.pnlCtlPresentacion)
        Me.panePresentacion.Controls.Add(Me.lblvieneEn)
        Me.panePresentacion.Controls.Add(Me.cmbPresentResult)
        Me.panePresentacion.Controls.Add(Me.cmbUndMedPresentRefery)
        Me.panePresentacion.Controls.Add(Me.lblPresentDeText)
        Me.panePresentacion.Controls.Add(Me.lblIdPresentDe)
        Me.panePresentacion.Controls.Add(Me.txtCant_Present)
        Me.panePresentacion.Controls.Add(Me.lblCNTpresent)
        Me.panePresentacion.Controls.Add(Me.lblCodigo)
        Me.panePresentacion.Controls.Add(Me.txtCodigo)
        Me.panePresentacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.panePresentacion.Location = New System.Drawing.Point(0, 0)
        Me.panePresentacion.Name = "panePresentacion"
        Me.panePresentacion.Size = New System.Drawing.Size(638, 101)
        Me.panePresentacion.TabIndex = 0
        '
        'isPresentFabricCheckedListBox
        '
        Me.isPresentFabricCheckedListBox.BackColor = System.Drawing.Color.GreenYellow
        Me.isPresentFabricCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isPresentFabricCheckedListBox.CheckOnClick = True
        Me.isPresentFabricCheckedListBox.FormattingEnabled = True
        Me.isPresentFabricCheckedListBox.Items.AddRange(New Object() {"De fábrica.", "Hecho por mí."})
        Me.isPresentFabricCheckedListBox.Location = New System.Drawing.Point(128, 64)
        Me.isPresentFabricCheckedListBox.Name = "isPresentFabricCheckedListBox"
        Me.isPresentFabricCheckedListBox.Size = New System.Drawing.Size(177, 32)
        Me.isPresentFabricCheckedListBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Tipo de presentación:"
        '
        'pnlCtlPresentacion
        '
        Me.pnlCtlPresentacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCtlPresentacion.BackColor = System.Drawing.Color.White
        Me.pnlCtlPresentacion.Controls.Add(Me.TableLayouButoonControl)
        Me.pnlCtlPresentacion.Location = New System.Drawing.Point(401, 34)
        Me.pnlCtlPresentacion.Margin = New System.Windows.Forms.Padding(15)
        Me.pnlCtlPresentacion.Name = "pnlCtlPresentacion"
        Me.pnlCtlPresentacion.Size = New System.Drawing.Size(229, 61)
        Me.pnlCtlPresentacion.TabIndex = 5
        '
        'TableLayouButoonControl
        '
        Me.TableLayouButoonControl.ColumnCount = 5
        Me.TableLayouButoonControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayouButoonControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayouButoonControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayouButoonControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayouButoonControl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayouButoonControl.Controls.Add(Me.btnEdit_Present, 2, 0)
        Me.TableLayouButoonControl.Controls.Add(Me.btnUpdatePresent, 3, 0)
        Me.TableLayouButoonControl.Controls.Add(Me.btnAdd_Present, 4, 0)
        Me.TableLayouButoonControl.Controls.Add(Me.btnCancelPresent, 0, 0)
        Me.TableLayouButoonControl.Controls.Add(Me.btnDelet_Present, 1, 0)
        Me.TableLayouButoonControl.Location = New System.Drawing.Point(13, 10)
        Me.TableLayouButoonControl.Margin = New System.Windows.Forms.Padding(12)
        Me.TableLayouButoonControl.Name = "TableLayouButoonControl"
        Me.TableLayouButoonControl.RowCount = 1
        Me.TableLayouButoonControl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayouButoonControl.Size = New System.Drawing.Size(199, 42)
        Me.TableLayouButoonControl.TabIndex = 50
        '
        'btnEdit_Present
        '
        Me.btnEdit_Present.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit_Present.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.edit_validat
        Me.btnEdit_Present.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit_Present.Enabled = False
        Me.btnEdit_Present.Location = New System.Drawing.Point(77, 1)
        Me.btnEdit_Present.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEdit_Present.Name = "btnEdit_Present"
        Me.btnEdit_Present.Size = New System.Drawing.Size(36, 40)
        Me.btnEdit_Present.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.btnEdit_Present, "Modificar")
        Me.btnEdit_Present.UseVisualStyleBackColor = True
        '
        'btnUpdatePresent
        '
        Me.btnUpdatePresent.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdatePresent.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Save_32x32
        Me.btnUpdatePresent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdatePresent.Enabled = False
        Me.btnUpdatePresent.Location = New System.Drawing.Point(115, 1)
        Me.btnUpdatePresent.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdatePresent.Name = "btnUpdatePresent"
        Me.btnUpdatePresent.Size = New System.Drawing.Size(36, 40)
        Me.btnUpdatePresent.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.btnUpdatePresent, "Guardar")
        Me.btnUpdatePresent.UseVisualStyleBackColor = True
        '
        'btnAdd_Present
        '
        Me.btnAdd_Present.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd_Present.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.AddItem_32x32
        Me.btnAdd_Present.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd_Present.Location = New System.Drawing.Point(153, 1)
        Me.btnAdd_Present.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAdd_Present.Name = "btnAdd_Present"
        Me.btnAdd_Present.Size = New System.Drawing.Size(44, 40)
        Me.btnAdd_Present.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnAdd_Present, "Agregar")
        Me.btnAdd_Present.UseVisualStyleBackColor = True
        '
        'btnCancelPresent
        '
        Me.btnCancelPresent.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelPresent.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Action_Cancel_32x32
        Me.btnCancelPresent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelPresent.Enabled = False
        Me.btnCancelPresent.Location = New System.Drawing.Point(1, 1)
        Me.btnCancelPresent.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelPresent.Name = "btnCancelPresent"
        Me.btnCancelPresent.Size = New System.Drawing.Size(36, 40)
        Me.btnCancelPresent.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnCancelPresent, "Cancelar")
        Me.btnCancelPresent.UseVisualStyleBackColor = True
        '
        'btnDelet_Present
        '
        Me.btnDelet_Present.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelet_Present.BackgroundImage = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        Me.btnDelet_Present.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelet_Present.Enabled = False
        Me.btnDelet_Present.Location = New System.Drawing.Point(39, 1)
        Me.btnDelet_Present.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDelet_Present.Name = "btnDelet_Present"
        Me.btnDelet_Present.Size = New System.Drawing.Size(36, 40)
        Me.btnDelet_Present.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.btnDelet_Present, "Eliminar")
        Me.btnDelet_Present.UseVisualStyleBackColor = True
        '
        'lblvieneEn
        '
        Me.lblvieneEn.AutoSize = True
        Me.lblvieneEn.Location = New System.Drawing.Point(6, 11)
        Me.lblvieneEn.Name = "lblvieneEn"
        Me.lblvieneEn.Size = New System.Drawing.Size(52, 13)
        Me.lblvieneEn.TabIndex = 28
        Me.lblvieneEn.Text = "Viene en:"
        Me.lblvieneEn.Visible = False
        '
        'cmbPresentResult
        '
        Me.cmbPresentResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPresentResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPresentResult.FormattingEnabled = True
        Me.cmbPresentResult.Location = New System.Drawing.Point(65, 7)
        Me.cmbPresentResult.Name = "cmbPresentResult"
        Me.cmbPresentResult.Size = New System.Drawing.Size(145, 21)
        Me.cmbPresentResult.TabIndex = 0
        Me.cmbPresentResult.Text = "Unidad"
        Me.cmbPresentResult.Visible = False
        '
        'cmbUndMedPresentRefery
        '
        Me.cmbUndMedPresentRefery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbUndMedPresentRefery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUndMedPresentRefery.FormattingEnabled = True
        Me.cmbUndMedPresentRefery.Location = New System.Drawing.Point(381, 7)
        Me.cmbUndMedPresentRefery.Name = "cmbUndMedPresentRefery"
        Me.cmbUndMedPresentRefery.Size = New System.Drawing.Size(146, 21)
        Me.cmbUndMedPresentRefery.TabIndex = 4
        Me.cmbUndMedPresentRefery.Text = "Unidad"
        Me.cmbUndMedPresentRefery.Visible = False
        '
        'lblPresentDeText
        '
        Me.lblPresentDeText.AutoSize = True
        Me.lblPresentDeText.Location = New System.Drawing.Point(378, 10)
        Me.lblPresentDeText.Name = "lblPresentDeText"
        Me.lblPresentDeText.Size = New System.Drawing.Size(55, 13)
        Me.lblPresentDeText.TabIndex = 27
        Me.lblPresentDeText.Text = "Unidad (s)"
        Me.lblPresentDeText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblIdPresentDe
        '
        Me.lblIdPresentDe.AutoSize = True
        Me.lblIdPresentDe.Location = New System.Drawing.Point(613, 11)
        Me.lblIdPresentDe.Name = "lblIdPresentDe"
        Me.lblIdPresentDe.Size = New System.Drawing.Size(13, 13)
        Me.lblIdPresentDe.TabIndex = 49
        Me.lblIdPresentDe.Text = "1"
        Me.lblIdPresentDe.Visible = False
        '
        'txtCant_Present
        '
        Me.txtCant_Present.DecimalPlaces = 2
        Me.txtCant_Present.Location = New System.Drawing.Point(305, 7)
        Me.txtCant_Present.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtCant_Present.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCant_Present.Name = "txtCant_Present"
        Me.txtCant_Present.Size = New System.Drawing.Size(69, 20)
        Me.txtCant_Present.TabIndex = 1
        Me.txtCant_Present.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCant_Present.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCNTpresent
        '
        Me.lblCNTpresent.AutoSize = True
        Me.lblCNTpresent.Location = New System.Drawing.Point(244, 11)
        Me.lblCNTpresent.Name = "lblCNTpresent"
        Me.lblCNTpresent.Size = New System.Drawing.Size(52, 13)
        Me.lblCNTpresent.TabIndex = 28
        Me.lblCNTpresent.Text = "Cantidad:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 42)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 29
        Me.lblCodigo.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(65, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(309, 22)
        Me.txtCodigo.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(103, 249)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(0, 0)
        Me.SaveButton.TabIndex = 50
        Me.SaveButton.Text = "Button1"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SiguientButton
        '
        Me.SiguientButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SiguientButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SiguientButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SiguientButton.Location = New System.Drawing.Point(19, 247)
        Me.SiguientButton.Name = "SiguientButton"
        Me.SiguientButton.Size = New System.Drawing.Size(0, 0)
        Me.SiguientButton.TabIndex = 39
        Me.SiguientButton.Text = "Sigiente ==>>"
        Me.SiguientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SiguientButton.UseVisualStyleBackColor = True
        '
        'DataGridPresent
        '
        Me.DataGridPresent.AllowUserToAddRows = False
        Me.DataGridPresent.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridPresent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridPresent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridPresent.BackgroundColor = System.Drawing.Color.White
        Me.DataGridPresent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPresent.Location = New System.Drawing.Point(6, 136)
        Me.DataGridPresent.MultiSelect = False
        Me.DataGridPresent.Name = "DataGridPresent"
        Me.DataGridPresent.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridPresent.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridPresent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPresent.Size = New System.Drawing.Size(624, 108)
        Me.DataGridPresent.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Listado de presenatciones en la que viene el producto"
        '
        'frm_Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(638, 259)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.panePresentacion)
        Me.Controls.Add(Me.SiguientButton)
        Me.Controls.Add(Me.DataGridPresent)
        Me.Name = "frm_Presentacion"
        Me.Text = "frm_Presentacion"
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panePresentacion.ResumeLayout(False)
        Me.panePresentacion.PerformLayout()
        Me.pnlCtlPresentacion.ResumeLayout(False)
        Me.TableLayouButoonControl.ResumeLayout(False)
        CType(Me.txtCant_Present, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPresent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents panePresentacion As System.Windows.Forms.Panel
    Friend WithEvents pnlCtlPresentacion As System.Windows.Forms.Panel
    Friend WithEvents btnUpdatePresent As System.Windows.Forms.Button
    Friend WithEvents btnCancelPresent As System.Windows.Forms.Button
    Friend WithEvents btnAdd_Present As System.Windows.Forms.Button
    Friend WithEvents btnEdit_Present As System.Windows.Forms.Button
    Friend WithEvents btnDelet_Present As System.Windows.Forms.Button
    Friend WithEvents lblvieneEn As System.Windows.Forms.Label
    Friend WithEvents cmbPresentResult As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUndMedPresentRefery As System.Windows.Forms.ComboBox
    Friend WithEvents lblPresentDeText As System.Windows.Forms.Label
    Friend WithEvents lblIdPresentDe As System.Windows.Forms.Label
    Friend WithEvents txtCant_Present As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCNTpresent As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents SiguientButton As System.Windows.Forms.Button
    Friend WithEvents DataGridPresent As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents TableLayouButoonControl As TableLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents isPresentFabricCheckedListBox As CheckedListBox
    Friend WithEvents Label2 As Label
End Class
