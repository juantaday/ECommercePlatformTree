Imports System.Data.SqlClient
Imports CADsisVenta.DataSetMonedasTableAdapters
Public Class FrmMonedas
    Public callOpen As callShow
    Public callId As Integer
    Protected Friend indexMoney As Integer
    Protected Friend total As Double
    Private RowAdd As Integer
    Private ColumnAdd As Integer
    Private isInizialityMoney As Boolean
    Private isInizialityVillete As Boolean
    Private estaCargado As Boolean
    Private dtMoneda As DataTable
    Private selectIndex, indexVill As Integer
    Private contador As Integer
    Public Enum callShow
        arqueoTerminal = 1
    End Enum
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Carga_TypoMoneda()
        Select Case callOpen
            Case callShow.arqueoTerminal
                Carga_ArqueoView(callId)
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Carga_ArqueoView(callId As Integer)
        Try
            sql = "SELECT *  FROM [CajaDetailMoney] "
            sql = sql & "WHERE idcajastado= " & callId & ""

            Dim cmd As New ClassCargadorProducto
            Dim dt As New DataTable
            dt = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Me.View_Arqueo(dt)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub View_Arqueo(dt As DataTable)
        Dim idMonedaDeatil As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            For Each tableLista In TableData.Controls
                For Each panel_master In tableLista.Controls
                    If panel_master.name = "PanelMaster" Then
                        If dt.Rows(i)("idMonedaDetail") = panel_master.tag Then
                            For Each Panel_Edit In panel_master.Controls
                                If Panel_Edit.name = "PanelEdit" Then
                                    For Each cantidadTextBox In Panel_Edit.Controls
                                        If cantidadTextBox.name = "CantidadTextBox" Then
                                            cantidadTextBox.Text = dt.Rows(i)("Quantity")
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub Initializa_Modedas()
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_ControlTable(tableName As String)
        Dim myTabla As New System.Windows.Forms.TableLayoutPanel
        myTabla = Nothing
        If Not isInizialityTable(tableName) Then
            TableMoney = Initializa_Table(tableName)
            TableData.SuspendLayout()
            If tableName.ToString.Contains("Moneda") Then
                TableData.Controls.Add(TableMoney, 0, 0)
            Else
                TableData.Controls.Add(TableMoney, 1, 0)
            End If
            TableData.ResumeLayout(True)
            getInitilizeTable(tableName)
        End If
        For Each Control In Me.TableData.Controls
            If Control.name = tableName Then
                myTabla = Control
                Exit For
            End If
        Next
        If Not IsNothing(myTabla) Then
            Add_View(myTabla)
            ResumenControls(myTabla)
        End If
    End Sub
    Private Sub Carga_Datos()
        Try
            'limpiamos ----------------------------------------------------
            TableData.Controls.Clear()
            isInizialityMoney = False
            isInizialityVillete = False
            selectIndex = 0
            '------------------------------------------------------------------------
            Dim tapt As New MonedaDetailTableAdapter
            'dtMoneda  tapt.GetDataByIdTipoMoney(TypoMondaComboBox.SelectedValue)
            If Not IsNothing(dtMoneda) Then
                For i = 0 To dtMoneda.Rows.Count - 1
                    If dtMoneda.Rows(selectIndex)("isFraccion") Then
                        Carga_ControlTable("TableMoneda")
                    Else
                        Carga_ControlTable("TableVillete")
                    End If
                    selectIndex += 1
                Next
            End If
            Contabiliza()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ResumenControls(xTabla As Object)
        TableData.ResumeLayout(True)
        PanelMaster.ResumeLayout(True)
        PanelEdit.ResumeLayout(True)
        PanelCommand.ResumeLayout(True)
        PictureMoney.ResumeLayout(True)
        xTabla.ResumeLayout(True)
        Select Case xTabla.name
            Case "TableMoneda"
                indexMoney += 1
            Case "TableVillete"
                indexVill += 1
        End Select
        Me.ResumeLayout(True)
    End Sub
    Private Function Initializa_Table(nameControl As String) As System.Windows.Forms.TableLayoutPanel
        Return New System.Windows.Forms.TableLayoutPanel With {
                    .Name = nameControl,
                    .AutoSize = True,
                    .ColumnCount = 2,
                    .Dock = DockStyle.None,
                    .CellBorderStyle = TableLayoutPanelCellBorderStyle.Single}
    End Function
    Private Sub Add_View(myTabla As Object)
        Try
            myTabla.SuspendLayout()
            Me.PanelMaster = New System.Windows.Forms.Panel() With {.BackColor = Color.Snow,
                                                                   .Dock = DockStyle.Fill,
                                                                   .Margin = New System.Windows.Forms.Padding(4, 4, 4, 4),
                                                                   .Height = 125,
                                                                   .Name = "PanelMaster"}

            Me.PanelCommand = New System.Windows.Forms.Panel() With {.Dock = DockStyle.Top, .Height = 20,
                                                                     .Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))}
            Me.PanelEdit = New System.Windows.Forms.Panel() With {.Dock = DockStyle.Bottom, .Height = 20,
                                                            .Name = "PanelEdit"}

            Me.PictureMoney = New System.Windows.Forms.PictureBox With {.Height = 80, .Width = 66,
                                                              .Location = New System.Drawing.Point(1, 21),
                                                              .Dock = DockStyle.Fill,
                                                              .BorderStyle = BorderStyle.FixedSingle,
                                                              .Cursor = Cursors.Hand,
                                                              .Name = "ImagenMoney"}

            Me.Cant_TextBox = New System.Windows.Forms.TextBox With {.Text = "0",
                                                                 .Name = "CantidadTextBox",
                                                                 .TextAlign = HorizontalAlignment.Right,
                                                                 .Width = 120,
                                                                 .TabIndex = 0,
                                                                 .Dock = DockStyle.Right}


            Me.Cant_Label = New System.Windows.Forms.Label With {.Text = "Cantidad:",
                                                                .Size = New System.Drawing.Size(77, 20),
                                                                .Location = New System.Drawing.Point(1, 1),
                                                                 .TabIndex = 1}



            Me.Edit_LinkLabel = New System.Windows.Forms.LinkLabel With {.Text = "     Editar", .Dock = DockStyle.Left,
                                                                 .Image = My.Resources.edir_16,
                                                                 .ImageAlign = ContentAlignment.MiddleLeft}
            Me.Delete_LinkLabel = New System.Windows.Forms.LinkLabel With {.Text = "     Eliminar", .Dock = DockStyle.Left,
                                                                  .Image = My.Resources.Action_Delete_16x16,
                                                                  .ImageAlign = ContentAlignment.MiddleLeft}

            'cargado de datos.-....******************************************************************'
            '[IMEGEN]
            Dim img() As Byte = Nothing
            If IsArray(dtMoneda(selectIndex)("imageMoney")) Then
                img = dtMoneda(selectIndex)("imageMoney")
            End If

            If Not IsNothing(img) Then
                If img.Length > 0 Then
                    Dim ms As New IO.MemoryStream(img)
                    PictureMoney.Image = Image.FromStream(ms)
                    PictureMoney.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
            sql = dtMoneda(selectIndex)("Moneda")

            Me.ToolTip1.SetToolTip(Me.PictureMoney, dtMoneda(selectIndex)("Moneda"))
            '[VALOR]
            Edit_LinkLabel.Tag = dtMoneda(selectIndex)("idMonedaDeatil")
            Delete_LinkLabel.Tag = dtMoneda(selectIndex)("idMonedaDeatil")
            PanelMaster.Tag = dtMoneda(selectIndex)("idMonedaDeatil")
            '[determin a que grupo pertenece]
            PanelCommand.Tag = dtMoneda(selectIndex)("isFraccion")
            Cant_TextBox.Tag = dtMoneda(selectIndex)("Value_Moneda")

            'supecionde diseño ******************************************************************
            Me.PanelMaster.SuspendLayout()
            Me.Cant_Label.SuspendLayout()
            Me.PictureMoney.SuspendLayout()
            Me.Cant_TextBox.SuspendLayout()
            Me.Edit_LinkLabel.SuspendLayout()
            Me.Delete_LinkLabel.SuspendLayout()
            Me.PanelCommand.SuspendLayout()
            Me.PanelEdit.SuspendLayout()

            'Agregando controls a la tabla principal'
            myTabla.Controls.Add(PanelMaster)

            'en ele panel central
            PanelMaster.Controls.Add(PictureMoney)
            PanelMaster.Controls.Add(PanelEdit)
            PanelMaster.Controls.Add(PanelCommand)

            ' en le panel de editar
            PanelEdit.Controls.Add(Cant_TextBox)
            PanelEdit.Controls.Add(Cant_Label)
            ' en le panel de comando
            PanelCommand.Controls.Add(Edit_LinkLabel)
            PanelCommand.Controls.Add(Delete_LinkLabel)
            '********************************************** EVENTOS
            AddHandler PictureMoney.Click, AddressOf PictureMoney_Click
            AddHandler Cant_TextBox.Enter, AddressOf CantidadTextBox_Enter
            AddHandler Edit_LinkLabel.Enter, AddressOf CantidadTextBox_Enter
            AddHandler Delete_LinkLabel.Enter, AddressOf CantidadTextBox_Enter
            'on click control.....
            AddHandler Edit_LinkLabel.LinkClicked, AddressOf Edit_LinkLabel_Click
            AddHandler Delete_LinkLabel.LinkClicked, AddressOf Delete_LinkLabel_Click
            'on value chage
            AddHandler Cant_TextBox.KeyPress, AddressOf CantidadTextBox_KeyPress
            AddHandler Cant_TextBox.TextChanged, AddressOf CantidadTextBox_TextChanged
        Catch ex As Exception
            MsgBox(ex.Message + "..En el Initializa_Controls ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CantidadTextBox_TextChanged(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrWhiteSpace(DirectCast(sender, TextBox).Text) Then
                sender.Text = 0
            End If
            Contabiliza()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Carga_Datos()
    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypoMondaComboBox.SelectedIndexChanged
        If TypoMondaComboBox.SelectedIndex > 0 And
            TypoMondaComboBox.ValueMember.Length > 0 Then
            'limpiamos los datos 
            Carga_Datos()
        End If
    End Sub




    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If TypoMondaComboBox.SelectedIndex < 0 Then
            MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Importante")
            TypoMondaComboBox.Focus()
            Return
        End If

    End Sub

    Private Sub Edit_LinkLabel_Click(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            Dim pane As System.Windows.Forms.Panel = Nothing
            pane = sender.Parent
            Dim isMoney As Boolean = pane.Tag

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TypoMondaComboBox.SelectedIndex < 0 Then
            MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Importante")
            TypoMondaComboBox.Focus()
            Return
        End If
    End Sub
    Private Sub Contabiliza()
        Try
            Dim _Total As Double = 0

            For Each tableLista In TableData.Controls
                For Each panel_master In tableLista.Controls
                    If panel_master.name = "PanelMaster" Then
                        For Each Panel_Edit In panel_master.Controls
                            If Panel_Edit.name = "PanelEdit" Then
                                For Each cantidadTextBox In Panel_Edit.Controls
                                    If cantidadTextBox.name = "CantidadTextBox" Then
                                        _Total += Convert.ToDouble(cantidadTextBox.Text) * Convert.ToDouble(cantidadTextBox.tag)
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            Next
            total = _Total
            TotalLabel.Text = FormatNumber(_Total, 2)
            TotalLabel.AutoSize = True
            If total > 0 Then
                AccepButton.Enabled = True
            Else
                AccepButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Delete_LinkLabel_Click(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try
            Dim idMoneyDetail As Nullable(Of Integer) = sender.tag
            If MsgBox("Está eguro de eliminar..?", MsgBoxStyle.Exclamation +
                      MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2,
                      "Responda..") = MsgBoxResult.Yes Then
                Dim tapt As New MonedaDetailTableAdapter
                If tapt.DeleteByIdMoneyDetail(idMoneyDetail) = 1 Then
                    Carga_Datos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ConfimButton_Click(sender As Object, e As EventArgs) Handles ConfimButton.Click
        Try
            If Not String.IsNullOrWhiteSpace(ValorManualTextBox.Text) Then
                If IsNumeric(ValorManualTextBox.Text) Then
                    TotalLabel.Text = FormatNumber(ValorManualTextBox.Text, 2)
                    AccepButton.Enabled = True
                    AccepButton.Focus()
                    GroupBoxInputData.Visible = False
                    total = ValorManualTextBox.Text
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ControlRadioBoton(sender)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ControlRadioBoton(sender)
    End Sub
    Private Sub ControlRadioBoton(sender As Object)
        Dim MyControlName As String = sender.name

        If MyControlName.ToString.ToString.Contains("2") Then
            If Not RadioButton1.Checked Then
                Return
            End If
            GroupBoxInputData.Visible = True
            If String.IsNullOrWhiteSpace(ValorManualTextBox.Text) Then ValorManualTextBox.Text = "0.00"
            ValorManualTextBox.Focus()
            TableData.Enabled = False
            FindButton.Enabled = False
        ElseIf MyControlName.ToString.ToString.Contains("1") Then
            If Not RadioButton2.Checked Then
                Return
            End If
            GroupBoxInputData.Visible = False
            TableData.Enabled = True
            FindButton.Enabled = True
        End If

        'For Each padit In sender.Parent.controls

        'Next


    End Sub
    Private Sub Carga_TypoMoneda()
        Try
            indexMoney = 44
            estaCargado = False
            Dim tapd As New TypoMonedaTableAdapter
            TypoMondaComboBox.DataSource = tapd.GetData()
            TypoMondaComboBox.ValueMember = "idMoneda"
            TypoMondaComboBox.DisplayMember = "Nom_Moneda"
            TypoMondaComboBox.SelectedValue = indexMoney
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub
    Private Function isInizialityTable(tableName As String) As Boolean
        Select Case tableName
            Case "TableMoneda"
                Return isInizialityMoney
            Case "TableVillete"
                Return isInizialityVillete
        End Select
        Return Nothing
    End Function
    Private Sub getInitilizeTable(tableName As String)
        Select Case tableName
            Case "TableMoneda"
                isInizialityMoney = True
                indexMoney = 0
            Case "TableVillete"
                isInizialityVillete = True
                indexVill = 0
        End Select
    End Sub

    Private Sub PictureMoney_Click(sender As Object, e As EventArgs)
        Try
            Dim padre As System.Windows.Forms.Panel = sender.Parent
            Dim panel_hijo As New System.Windows.Forms.Panel
            Cancel_Butoon.Focus()
            For Each control In padre.Controls
                sql = control.name
                If control.name = "PanelEdit" Then
                    For Each control_hijo In control.Controls
                        If control_hijo.name = "CantidadTextBox" Then
                            control_hijo.focus()
                            Exit Try
                        End If
                    Next
                End If
            Next
            padre = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CantidadTextBox_Enter(sender As Object, e As EventArgs)
        Try
            For Each tableList In TableData.Controls
                For Each panel_master In tableList.Controls
                    If panel_master.name = "PanelMaster" Then
                        panel_master.BackColor = Color.Snow()
                    End If
                Next
            Next

            Dim PaneEdit As Object = sender.Parent
            Dim paneMaster As System.Windows.Forms.Panel

            paneMaster = PaneEdit.Parent
            paneMaster.BackColor = Color.Aqua
            Try
                If sender.name = "CantidadTextBox" Then
                    sender.Select(0, sender.TextLength)
                End If
            Catch ex As Exception
                MsgBox(ex.Message + "en le txtNumber_Enter del " + Name, MsgBoxStyle.Critical, "Error")
            End Try

        Catch ex As Exception
            MsgBox(ex.Message + "en le txtNumber_Enter del " + Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Friend WithEvents TableMoney As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableVillete As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelMaster As System.Windows.Forms.Panel
    Friend WithEvents PanelCommand As System.Windows.Forms.Panel
    Friend WithEvents PanelEdit As System.Windows.Forms.Panel
    Friend WithEvents PictureMoney As System.Windows.Forms.PictureBox
    Friend WithEvents Cant_Label As System.Windows.Forms.Label
    Friend WithEvents Cant_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Edit_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Delete_LinkLabel As System.Windows.Forms.LinkLabel

    Private Sub CantidadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
        'Ascii 
        '8  = Retroceso 
        '58 = dos Puntos Decimales 
        '46 = Punto Decimal 
    End Sub

    Private Sub AccepButton_Click(sender As Object, e As EventArgs) Handles AccepButton.Click
        Me.Cursor = Cursors.WaitCursor
        If IsNumeric(TotalLabel.Text) Then
            total = TotalLabel.Text
            If Not total = 0 Then
                Select Case callOpen
                    Case callShow.arqueoTerminal
                        If Me.UpdateArqueo(callId) Then
                            Me.DialogResult = system.Windows.Forms.DialogResult.OK
                            Close()
                        End If
                End Select

                Me.DialogResult = system.Windows.Forms.DialogResult.OK
                Close()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function UpdateArqueo(callId As Integer) As Boolean
        Using connection As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try
                command.CommandText =
                      "Delete [CajaDetailMoney] WHERE (idCajaStado=" & callId & ") "
                command.ExecuteNonQuery()

                Dim idModedaDetail As Integer = 0
                Dim quantity As Integer
                contador = 0
                For Each tableLista In TableData.Controls
                    For Each panel_master In tableLista.Controls
                        If panel_master.name = "PanelMaster" Then
                            idModedaDetail = panel_master.tag
                            For Each Panel_Edit In panel_master.Controls
                                If Panel_Edit.name = "PanelEdit" Then
                                    For Each cantidadTextBox In Panel_Edit.Controls
                                        If cantidadTextBox.name = "CantidadTextBox" Then
                                            quantity = cantidadTextBox.Text
                                            If quantity > 0 Then
                                                Me.transferArqueo(command, callId, idModedaDetail, Integer.Parse(cantidadTextBox.Text))
                                                contador += 1
                                            End If
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                Next
                ' Attempt to commit the transaction.
                transaction.Commit()
                Return True
            Catch ex As Exception
                Try
                    transaction.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Try
        End Using
    End Function
    Private Sub transferArqueo(command As SqlCommand, callId As Integer, idModedaDetail As Integer, Quantity As Integer)

        If contador = 0 Then
            command.CommandText =
            "insert into CajaDetailMoney (idCajaStado,idMonedaDetail,Quantity,onState) 
             values(@idCajaStado,@idMonedaDetail,@Quantity,@onState) "

            command.Parameters.Add("@idCajaStado", SqlDbType.Int)
            command.Parameters.Add("@idMonedaDetail", SqlDbType.Int)
            command.Parameters.Add("@Quantity", SqlDbType.Int)
            command.Parameters.Add("@onState", SqlDbType.Bit)
        End If
        command.Parameters("@idCajaStado").Value = callId
            command.Parameters("@idMonedaDetail").Value = idModedaDetail
            command.Parameters("@Quantity").Value = Quantity
            command.Parameters("@onState").Value = 0

            command.ExecuteNonQuery()
    End Sub

    Private Sub Cancel_Butoon_Click(sender As Object, e As EventArgs) Handles Cancel_Butoon.Click
        Me.Close()
    End Sub
End Class
'para que registre solamente números
