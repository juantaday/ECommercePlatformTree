Imports System.Data.SqlClient
Imports CADsisVenta
Imports CADsisVenta.DataSetMonedas
Imports CADsisVenta.DataSetMonedasTableAdapters
Imports CADsisVenta.DataSetVentas
Imports ECommercePlatformView.FrmMonedas

Public Class frmCajaDetail
    Protected Friend idCajaStado As Integer
    Protected Friend ListCheqNotFount As List(Of ItemCheqNotFount)
    Private totalSaldoEfectivo As Double
    Private totalArqueoEfectivo As Double
    Private cuenta As String
    Private IdPersona As Integer

    Protected Friend totalDifereniaEfectivo As Double
    Protected Friend totalDiferenciaCaheque As Double
    Protected Friend totalTargeta As Double
    Protected Friend totalDiferenciaGeneral As Double
    Protected Friend totalSaldoSistema As Double
    Sub New(idCajaStado As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ListCheqNotFount = New List(Of ItemCheqNotFount)
        Me.idCajaStado = idCajaStado
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        totalDifereniaEfectivo = 0
        totalDiferenciaCaheque = 0
        totalTargeta = 0
        totalDiferenciaGeneral = 0
        totalSaldoSistema = 0
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim codUserClose As String = String.Empty
            If Me.ListVirtualComboBox.SelectedIndex = -1 Then
                MsgBox("Determine el destino de divisa.", MsgBoxStyle.Exclamation, "Importante")
                ListVirtualComboBox.Focus()
                Return
            End If

            Using forlogin As New LoginForm(stateReturn._response, "cajas")
                With forlogin
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                    If (.DialogResult = DialogResult.OK) Then
                        If closeTerminal(.UsernameTextBox.Text) Then
                            MsgBox("Cierre de caja efectuado correctament", MsgBoxStyle.Information, "Aviso")
                            If LoadOptionsPrint("Reporte de cierre de caja") Then
                                sql = "Desea imprimir el Reporte de cierre de caja" & vbNewLine
                                sql = sql & "En impresora " & myOptnsPrint.typePrint & " " & myOptnsPrint.NamePrint
                                If (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Responda")) = MsgBoxResult.Yes Then
                                    PrintArqueoTerminal(Me.idCajaStado, myOptnsPrint)
                                End If
                            End If
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End With

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function closeTerminal(codUserClose As String) As Boolean
        Dim response As Boolean = False

        Try
            Using db As New DataContext
                Dim _Saldo As Double = 0

                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction

                Try

                    Dim _dateTimeclose = db.getDateServer.FirstOrDefault.Column1
                    If IsNothing(_dateTimeclose) Then
                        _dateTimeclose = DateTime.Now
                    End If

                    Dim _cajaStado = From c In db.CajaStado
                                     Where c.idCajaStado = Me.idCajaStado

                    For Each item In _cajaStado
                        item.Stado = 0
                        item.codUserClosed = codUserClose
                        item.QuantityClosed = Me.totalSaldoSistema
                        item.Qntt_difference = Me.totalDiferenciaGeneral
                        item.dateEnd = _dateTimeclose
                        response = True
                    Next

                    If CargarAComboBox.Text.Contains("Por cobrar a trabajador.") And response Then
                        Dim newSaldo As Double = 0
                        Dim _Person = From p In db.Personas
                                      Where p.idPersona = Me.IdPersona

                        For Each item In _Person
                            newSaldo = item.Balance
                        Next
                        If Not totalDifereniaEfectivo > 0 Then
                            totalDifereniaEfectivo *= -1
                        End If
                        newSaldo += totalDifereniaEfectivo

                        Dim _EmpleadoDeuda As New EmpleadoDeuda With
                                {
                                .Cuenta = Me.cuenta,
                                .idPersona = Me.IdPersona,
                                .Tipo = "D",
                                .Valor = totalDifereniaEfectivo,
                                .IdTypoTransaction = 7,
                                .Saldo = newSaldo,
                                .IsWaxed = 0
                                }
                        db.EmpleadoDeuda.InsertOnSubmit(_EmpleadoDeuda)
                        db.SubmitChanges()
                    End If
                    db.SubmitChanges()
                    'this is validate for exit 

                    Dim LastSaldo = (From s In db.VirtualBox
                                     Where s.idVirtualBox = Integer.Parse(Me.ListVirtualComboBox.SelectedValue)).FirstOrDefault().Saldo

                    If IsNothing(LastSaldo) Then
                        MsgBox("No pude obtener el saldo de la caja virtua " & Me.ListVirtualComboBox.SelectedValue.ToString(), MsgBoxStyle.Exclamation, "Error")
                        Return False
                    End If

                    Dim newSaldoVirtual As Double = LastSaldo + totalArqueoEfectivo
                    Dim _VirtualBoxDetails As New VirtualBoxDetails With
                            {
                                .idVirtualBox = Me.ListVirtualComboBox.SelectedValue,
                                .debe = totalArqueoEfectivo,
                                .Descripcion = "Depósito por arqueo: /Operación: " & idCajaStado & "/ Autorizado por: " & codUserClose,
                                .haber = 0,
                                .saldo = newSaldoVirtual
                            }
                    db.VirtualBoxDetails.InsertOnSubmit(_VirtualBoxDetails)
                    db.SubmitChanges()

                    'set the terminal 
                    LastSaldo = 0
                    Dim __CajaStado = From s In db.CajaStado
                                      Where s.idCajaStado = idCajaStado

                    For Each item In __CajaStado
                        LastSaldo = item.Saldo
                    Next


                    Dim _newSaldo As Double = LastSaldo - totalArqueoEfectivo
                    Dim _Cajas As New Cajas With
                            {
                                    .idCajaStado = idCajaStado,
                                    .codUserMovi = codUserClose,
                                    .debe = 0,
                                    .haber = totalArqueoEfectivo,
                                    .Descripcion = "Arqueo de caja:",
                                    .saldo = _newSaldo,
                                    .idFormaPago = 1,
                                    .onControl = "isAdmin",
                                    .TypoMovi = 1
                            }
                    db.Cajas.InsertOnSubmit(_Cajas)
                    db.SubmitChanges()

                    'arqueo de documentos  cheques  y  bouches  .......
                    Dim archingdocument = From d In db.CajaDetailDocument
                                          Where d.idCajaStado = Me.idCajaStado And d.isArching = 0

                    For Each item In archingdocument
                        If Not IsNothing(Me.ListCheqNotFount) Then
                            For Each index In Me.ListCheqNotFount
                                If item.idCajaDetailCheque = index.idCajaDetailCheque Then
                                    item.isArching = 0
                                Else
                                    item.isArching = 1
                                End If
                            Next
                        Else
                            item.isArching = 1
                        End If
                    Next
                    db.SubmitChanges()

                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using
        Catch ex2 As Exception
            MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Anular_Button_Click(sender As Object, e As EventArgs)
        Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmCajaDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Carga_ListDatos()
        Me.Carga_SaldoSytema()
        SplitContainer1.Panel2.Controls.Clear()
        Me.TitleLabel.Text = "Arqueo del terminal: " & Me.MyTerminalDescrip(Me.idCajaStado) & " Registra un saldo de: " & totalSaldoSistema.ToString("C2")
    End Sub
    Private Sub Load_Data()

        Using db As New DataContext
            Dim _idbodega As Integer = (From cs In db.CajaStado
                                        Join t In db.Terminal On cs.idTerminal Equals t.idTerminal).FirstOrDefault.t.idBodega
            If IsNothing(_idbodega) Then
                MsgBox("No se pudo determinar la bodega.", MsgBoxStyle.Exclamation, "Error")
                Return
            End If

            Dim milist = From c In db.CajaTypo
                         Join v In db.VirtualBox On c.IDCajaTypo Equals v.TypeVirtualBox
                         Join b In db.Bodegas On b.idBodega Equals v.idBodega
                         Where v.idBodega = _idbodega
                         Select NameVirtual = b.Nom_Bodega + " " + v.NameVirtualBox, v.idVirtualBox
            If milist.Count > 0 Then
                ListVirtualComboBox.DataSource = milist.ToList()
                ListVirtualComboBox.DisplayMember = "NameVirtual"
                ListVirtualComboBox.ValueMember = "idVirtualBox"
                ListVirtualComboBox.SelectedIndex = -1
            End If
        End Using
    End Sub

    Private Sub Carga_SaldoSytema()
        Try

            Using cmd As New SaldoCajaTableAdapter
                Using dt As New SaldoCajaDataTable
                    cmd.Fill(dt, Me.idCajaStado)
                    For Each rowSaldo As DataRow In dt.Rows
                        Me.totalSaldoSistema += (rowSaldo("SaldoInicial") + rowSaldo("Debe")) - rowSaldo("Haber")
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function MyTerminalDescrip(idCajaStado As Integer) As String
        Try
            Using cmd As New CajaDescripTableAdapter
                Using dt As New CajaDescripDataTable
                    cmd.Fill(dt, Me.idCajaStado)
                    If dt.Rows.Count > 0 Then
                        userManupuleButton.Tag = dt.Rows(0)("idTerminal").ToString
                        Me.TitleLabel.Tag = dt.Rows(0)("idTerminal").ToString
                        Return dt.Rows(0)("codTerminal").ToString
                    Else
                        Return String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return String.Empty
        End Try
    End Function

    Private Sub Carga_ListDatos()
        Try
            ListViewList.View = View.Details
            ListViewList.Columns.Add("Arquear", 300)
            ListViewList.GridLines = True
            ListViewList.FullRowSelect = True
            sql = "select * from stm.FormaPago  where Not (FormaPago = 'Crédito')"
            If conecta_sql() Then
                Dim cmd As New ClassCargadorProducto()
                Dim dt As DataTable = cmd.RetornaTabla(sql)
                For i = 0 To dt.Rows.Count - 1
                    Dim item As New ListViewItem
                    item.Text = dt.Rows(i)("formaPago")
                    item.SubItems.Add(dt.Rows(i)("idformaPago"))
                    item.SubItems.Add(dt.Rows(i)("formaPago"))
                    ListViewList.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListViewList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewList.SelectedIndexChanged
        If ListViewList.SelectedItems.Count > 0 Then
            Dim response As ListViewItem = ListViewList.SelectedItems(0)
            Select Case response.SubItems(2).Text
                Case "Efectivo"
                    Carga_Efectivo(Integer.Parse(response.SubItems(1).Text))
                Case "Cheque"
                    Carga_Cheche(Integer.Parse(response.SubItems(1).Text))
                Case "Tarjeta Crédito"
                    Carga_Tarjeta(Integer.Parse(response.SubItems(1).Text))
            End Select
        End If
    End Sub
    Private Sub Carga_Efectivo(id As Integer)
        Try
            sql = "SELECT "
            sql = sql & "(sum(Debe)- sum(Haber)) as saldo "
            sql = sql & "FROM Cajas "
            sql = sql & "where idCajaStado =" & idCajaStado & " And idFormaPago = " & id & " "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If dt.Rows.Count > 0 Then
                SplitContainer1.Panel2.Controls.Clear()
                Dim myPanelEfective As New System.Windows.Forms.Panel
                myPanelEfective = PanelEfectico
                myPanelEfective.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(myPanelEfective)
                If Not IsNothing(IsNumeric(dt.Rows(0)("saldo"))) AndAlso IsNumeric(dt.Rows(0)("saldo")) Then
                    totalSaldoEfectivo = dt.Rows(0)("saldo")
                Else
                    totalSaldoEfectivo = 0
                End If

                SaldoEfectivoTextBox.Text = totalSaldoEfectivo.ToString("C2")
            End If
            EfectivoButton.Tag = id
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_Cheche(p1 As Integer)
        Try
            Dim forms As New frmChequeContab(Me)
            Dim palecheche As New System.Windows.Forms.Panel
            SplitContainer1.Panel2.Controls.Clear()
            If forms.Load_Cheque(idCajaStado) Then
                palecheche = forms.PanelData
                palecheche.Parent = Me
                palecheche.Dock = DockStyle.Fill
                For Each control In palecheche.Controls
                    If control.Name.ToString.Equals("PanelPie") Then
                        For Each control2 In control.Controls
                            If control2.Name.ToString.Equals("ChequeContabButton") Then
                                control2.tag = p1
                            End If
                        Next
                    End If
                Next
                SplitContainer1.Panel2.Controls.Add(palecheche)
            End If
            forms = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Carga_Tarjeta(p1 As Integer)
        Try
            Dim forms As New frmTargetContab()
            Dim palecheche As New System.Windows.Forms.Panel With {.Dock = DockStyle.Fill}
            SplitContainer1.Panel2.Controls.Clear()
            If forms.Load_Cheque(idCajaStado) Then
                palecheche = forms.PanelTarget
                SplitContainer1.Panel2.Controls.Add(palecheche)
            End If
            Ok_List(p1, "0.00")
            forms = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EfectivoButton_Click(sender As Object, e As EventArgs) Handles EfectivoButton.Click

        ListViewList.AutoResizeColumns(
        ColumnHeaderAutoResizeStyle.HeaderSize)

        ' Resize the second column to the column content.
        If IsNumeric(sender.tag) Then
            If String.IsNullOrEmpty(DiferenciaTextBox.Text) Then
                MsgBox("Determine la cantidad de efectivo encotrado en la caja.", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            If totalDifereniaEfectivo <> 0 And CargarAComboBox.SelectedIndex = -1 Then
                MsgBox("Determine la cuenta a la que ba a cargar la diferencia.", MsgBoxStyle.Exclamation, "Importante.")
                Return
            End If

            Ok_List(sender.tag, DiferenciaTextBox.Text)
        End If
    End Sub
    Private Sub Ok_List(id As Integer, stotal As String)
        Try
            For i = 0 To ListViewList.Items.Count - 1
                If Integer.Parse(ListViewList.Items(i).SubItems(1).Text) = id Then
                    ListViewList.Items(i).ImageKey = "ok_16_png"
                    ListViewList.Items(i).Text = String.Format("{0} ({1})", ListViewList.Items(i).SubItems(2).Text, stotal)
                    ListViewList.Refresh()
                End If
            Next
            Dim isArquedototo As Boolean = True
            For i = 0 To ListViewList.Items.Count - 1
                If String.IsNullOrEmpty(ListViewList.Items(i).ImageKey.ToString()) Then
                    isArquedototo = False
                End If
            Next
            Me.totalDiferenciaGeneral = Me.totalDiferenciaCaheque + Me.totalDifereniaEfectivo + Me.totalTargeta
            Me.OK_Button.Enabled = isArquedototo
            Me.totalDiferenciaArqueoLabel.Text = String.Format("Diferencia General: {0:C2}", Me.totalDiferenciaGeneral)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ContarButton_Click(sender As Object, e As EventArgs) Handles ContarButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Using frmmoney As New frmAdminMoney
                With frmmoney
                    .idCajaStada = idCajaStado
                    .callOpen = callShow.arqueoTerminal
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        CaragarALabel.Text = String.Empty
                        CargarAComboBox.Text = String.Empty
                        CargarAComboBox.Enabled = False

                        totalArqueoEfectivo = .TotalMoney
                        totalDifereniaEfectivo = totalArqueoEfectivo - totalSaldoEfectivo
                        ArqueroTextBox.Text = FormatCurrency(totalArqueoEfectivo, 2)
                        DiferenciaTextBox.Text = totalDifereniaEfectivo.ToString("C2")
                        CargarAComboBoxItems(totalDifereniaEfectivo)
                    End If
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarAComboBoxItems(valor As Double)
        EfectivoButton.Enabled = False
        CargarAComboBox.Items.Clear()

        If valor = 0 Then
            EfectivoButton.Enabled = True
            Return
        ElseIf valor < 0 Then
            CargarAComboBox.Items.Add("Considerar como PÉRDIDA DEL EJERCICIO.")
            CargarAComboBox.Items.Add("Por cobrar a trabajador.")
            CargarAComboBox.Enabled = True
            EfectivoButton.Enabled = True
        ElseIf valor > 0 Then
            CargarAComboBox.Items.Add("UTILIDAD DEL EJERCICIO")
            CargarAComboBox.Items.Add("ACREEDORES VARIOS")
            CargarAComboBox.Enabled = True
            EfectivoButton.Enabled = True
        End If
    End Sub

    Private Sub userManupuleButton_Click(sender As Object, e As EventArgs) Handles userManupuleButton.Click
        Try
            Using cmd As New UserMoviInTerminalTableAdapter
                Using dt As New UserMoviInTerminalDataTable
                    cmd.Fill(dt, Me.idCajaStado)
                    If dt.Rows.Count > 0 Then
                        DeleteUserLisControl()
                        Dim panelList As New System.Windows.Forms.Panel _
                        With {.Dock = DockStyle.Right,
                             .Name = "panelListUser",
                             .BorderStyle = BorderStyle.FixedSingle,
                             .Width = 300}
                        Dim dtg As New System.Windows.Forms.DataGridView _
                             With {.Dock = DockStyle.Fill,
                              .DataSource = dt}

                        Dim closeButton As New System.Windows.Forms.Button _
                            With {.Dock = DockStyle.Top,
                              .Text = "Cerrar",
                              .TextAlign = ContentAlignment.MiddleCenter,
                              .Image = My.Resources.Arrow_Forward_48,
                              .ImageAlign = ContentAlignment.MiddleRight,
                              .Height = 45
                                }
                        AddHandler closeButton.Click, AddressOf loseButton_Click

                        applyGridTheme(dtg)
                        panelList.Controls.Add(dtg)
                        panelList.Controls.Add(closeButton)
                        Me.SplitContainer1.Panel2.Controls.Add(panelList)
                    Else
                        MsgBox("No se registra Usuarios en el idStadoCaja: " & sender.tag, MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub loseButton_Click(sender As Object, e As EventArgs)
        DeleteUserLisControl()
    End Sub
    Private Sub DeleteUserLisControl()
        Try
            For Each control In Me.SplitContainer1.Panel2.Controls
                If control.name.Equals("panelListUser") Then
                    Me.SplitContainer1.Panel2.Controls.Remove(control)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CargarAComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CargarAComboBox.SelectedIndexChanged
        Try
            If CargarAComboBox.SelectedIndex >= 0 Then
                Select Case CargarAComboBox.Text
                    Case "Considerar como PÉRDIDA DEL EJERCICIO."
                        sql = "Cuenta: 361005" & vbCrLf
                        sql = sql & "Descripcion: Pérdida del ejercicio" & vbCrLf
                        sql = sql & "Valor: " & totalDifereniaEfectivo.ToString("C2")
                        CaragarALabel.Text = sql
                        EfectivoButton.Enabled = True
                    Case "Por cobrar a trabajador."
                        Using ListClient As New frmListEmployeeView(stateLoad.Dialogo)
                            With ListClient
                                .StartPosition = FormStartPosition.CenterScreen
                                .CancelButton = .closeButton
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    Me.IdPersona = ._ItemPerson.IdPersona
                                    Me.cuenta = 136595
                                    sql = "Cuenta: 136595" & vbCrLf
                                    sql = sql & "Descripcion: CUENTAS POR COBRAR A TRABAJADORES" & vbCrLf
                                    sql = sql & "Cargara a: " & ._ItemPerson.Ruc_Ci & "  - " & ._ItemPerson.FullName & vbCrLf
                                    sql = sql & "Valor: " & totalDifereniaEfectivo.ToString("C2")
                                    CaragarALabel.Text = sql
                                    EfectivoButton.Enabled = True
                                End If
                            End With
                        End Using
                    Case "UTILIDAD DEL EJERCICIO"
                        sql = "Cuenta: 3605" & vbCrLf
                        sql = sql & "Descripcion: UTILIDAD DEL EJERCICIO" & vbCrLf
                        sql = sql & "Valor: " & totalDifereniaEfectivo.ToString("C2")
                        CaragarALabel.Text = sql
                        EfectivoButton.Enabled = True
                    Case "ACREEDORES VARIOS"
                        sql = "Cuenta: 233595" & vbCrLf
                        sql = sql & "Descripcion:  CUENTAS POR PAGAR" & vbCrLf
                        sql = sql & "Valor: " & totalDifereniaEfectivo.ToString("C2")
                        CaragarALabel.Text = sql
                        EfectivoButton.Enabled = True
                End Select
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class
