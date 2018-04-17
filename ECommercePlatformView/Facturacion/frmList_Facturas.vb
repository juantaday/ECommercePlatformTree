Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports LibPrintTicket.PrintTicket
Imports ECommercePlatformView
Imports CADsisVenta

Public Class frmList_Facturas
    Dim Num_Factura, Cliente, TipoVent, Cajero, Fechades, FechaHast, Direccion, Telefono, fechaReal, Ruc As String
    Dim Base0, Base12, ivaTotal, otroValor, Total, totalDevolver As Double

    Private document As String
    Private prtSettings As PrinterSettings
    Private prtDoc As PrintDocument
    Private prtFont As System.Drawing.Font
    Private isLoad As Boolean
    Private documentName As String
    Private idTerminal As Integer
    Private idVenta As Integer
    Private listDevolucion As New List(Of ItemListDevolucion)
    Private UserAutorization As String
    Protected Friend flag As String

    Private Sub frmListFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePickerEnd.Value = Date.Now
        Me.DateTimePickerStar.Value = Date.Now.AddDays(-3)
        InitializeComponents()
        Initializa_Load_Base()
    End Sub

    Private Sub InitializeComponents()
        Me.PanelData.Controls.Clear()
        Me.PanelData.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer1.Dock = DockStyle.Fill
        Me.PanelData.Dock = DockStyle.Fill
        Me.PanelFavority.Visible = False
    End Sub

    Private Sub Initializa_Load_Base()
        If IsNothing(flag) Then
            flag = "Visualizar"
        End If
        If Not IsNothing(flag) Then
            Select Case flag.ToString()
                Case "Generar"
                    If IniciaProseso() Then
                        flag = "Visualizar"
                        Call Initializa_Load_Base()
                    Else
                        Close()
                    End If
                Case "GenerarImprimir"
                Case "Imprimir"
                    sql = "WHERE  (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "') and (fv.Estado = 255) "
                    MostarFactura_Select(sql)
                    If PrinterTodo() Then
                        Close()
                    End If
                Case "ImprimirSelect"
                    sql = "WHERE  fv.idFactVenta  = " & id & ""
                    MostarFactura_Select(sql)
                    If PrinterSelect() Then
                        Close()
                    End If
                Case "ImprimirList"
                    sql = "INNER Join [tmp].[DocumentULT] AS t ON fv.idFactVenta = t.idDocument "
                    sql = sql & "where t.codTerminal  = '" & TerminalActivo.codTerminal & "' and t.codUser  = '" & UsuarioActivo.codUser & "' "
                    MostarFactura_Select(sql)
                    If PrinterSelect() Then
                        Close()
                    End If
                Case "Visualizar"
                    sql = "WHERE  (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "') "
                    MostarFactura_Select(sql)
            End Select
        End If
        SplitContainer1.Panel2Collapsed = True
        WindowState = FormWindowState.Maximized
    End Sub
    Private Function IniciaProseso() As Boolean
        Return True
    End Function

    Private Function BuscandoFecha() As Boolean
        sql = "SELECT Min(v.fechaVenta) AS fecha1, Max(v.fechaVenta) AS Fecha2 "
        sql = sql & "FROM Ventas as v "
        sql = sql & "WHERE (v.tipoVenta=" & codRecupa & ") and (v.codUser = '" & UsuarioActivo.codUser & "') "
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    FacturVenta.fechDesde = FormatDateTime(dt.Rows(0)("fecha1").ToString, DateFormat.ShortDate)
                    FacturVenta.fechHasta = FormatDateTime(dt.Rows(0)("Fecha2").ToString, DateFormat.ShortDate)
                    Return True
                Else
                    Return False
                End If
                dt = Nothing
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el BuscandoFecha")
            Return False
        End Try
    End Function

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If flag = "Generar" Then
            Me.Cursor = Cursors.WaitCursor
            IniciaProseso()
            sql = "WHERE  (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "')"
            MostarFactura_Select(sql)
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub btnPrint1_Click(sender As System.Object, e As System.EventArgs) Handles printTicket.Click
        If PrinterTodo() Then
            Initializa_Load_Base()
        End If
    End Sub
    Private Function PrinterSelect() As Boolean
        Try
            'si  no tengo determidado mi vandera salgo
            If IsNothing(flag) Then
                Return False
            End If
            If flag.Equals(String.Empty) Then
                Return False
            End If
            If flag.Equals("ImprimirSelect") Then
                ListViewCabecera.Items(0).Selected = True
                Return imprimir_Factura()
            ElseIf flag.Equals("ImprimirList") Then
                Dim i As Integer
                For i = 0 To ListViewCabecera.Items.Count - 1
                    ListViewCabecera.Items(i).Selected = True
                    imprimir_Factura()
                Next
                If i > 0 Then
                    Return True
                Else
                    Return False
                End If
            ElseIf ListViewCabecera.SelectedItems.Count = 1 Then
                If Not (MsgBox("Va imprimir esta factura en TICKET.?", MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes) Then
                    Return False
                Else
                    Return imprimir_Factura()
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function PrinterTodo() As Boolean
        Try
            Dim vueltas As Integer = 0
            If ListViewCabecera.Items.Count > 0 Then
                If MsgBox("Está seguro de imprimir algunos documentos consecutivos", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes Then
                    Me.ListViewCabecera.MultiSelect = False
                    For i = 0 To Me.ListViewCabecera.Items.Count - 1
                        ListViewCabecera.Items(i).Selected = True
                        Print_Ticket(ListViewCabecera.SelectedItems(0).SubItems(0).Text)
                        If i = 12 Then
                            Exit For
                        End If
                    Next
                    MarqImpreso()
                    Return True
                Else
                    Return False
                End If
            Else
                MsgBox("No hay información para imprimir", MsgBoxStyle.Information, "Aviso")
                printTicket.Enabled = False
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function PrinterSelectInTicket() As Boolean
        Try
            If ListViewCabecera.CheckedItems.Count > 0 Then
                If MsgBox("Está seguro de imprimir los documentos seleccionados.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes Then
                    For Each item As ListViewItem In Me.ListViewCabecera.CheckedItems
                        Print_Ticket(item.Text)
                    Next
                    Return True
                Else
                    Return False
                End If
            Else
                MsgBox("Selccione para imprimir.", MsgBoxStyle.Information, "Aviso")
                printTicket.Enabled = False
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function MarqImpreso() As Boolean
        Try
            SeleccionaImpreso()
            Dim breakfast As System.Windows.Forms.ListView.CheckedListViewItemCollection = ListViewCabecera.CheckedItems
            Dim item As System.Windows.Forms.ListViewItem
            Dim resul As Boolean = False
            conecta_sql()
            For Each item In breakfast
                resul = True
                Dim idFactur As Integer = Integer.Parse(item.SubItems(0).Text)
                '  *************************************** pono como ya impreso
                sql = "update FacturaVenta set Impreso  = 1 "
                sql = sql & "Where idFactVenta  = " & idFactur & " "
                Try
                    Using cmd As New SqlCommand(sql, Cnn_sql)
                        cmd.CommandType = CommandType.Text
                        If cmd.ExecuteNonQuery Then
                        Else
                            resul = False
                            Exit For
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el MarqImpreso")
                    Return False
                End Try

                '    **************************** si esta en cola de impresion lo retira
                sql = "update FacturaVenta set Estado  = 1 "
                sql = sql & "Where (idFactVenta  = " & idFactur & ")  and (Estado = 255) "
                Try
                    Using cmd As New SqlCommand(sql, Cnn_sql)
                        cmd.CommandType = CommandType.Text
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MsgBox("No se retiro de la cola se impresión", MsgBoxStyle.Critical, "Error en el MarqImpreso")
                End Try
            Next
            Return resul
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SeleccionaImpreso() As Boolean
        For i = 0 To Me.ListViewCabecera.Items.Count - 1

            If Me.ListViewCabecera.Items(i).Selected = True Then
                SelecionaImp(i)
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub SelecionaImp(ByVal List As Integer)
        Me.ListViewCabecera.MultiSelect = True
        For i = 0 To List
            Me.ListViewCabecera.Items(i).Selected = True
        Next
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        imprimir_Factura()
    End Sub

    Public Function Carga_Cabera() As Boolean
        Try
            If (ListViewCabecera.SelectedItems.Count = 1) Then
                Dim coleecionItem As System.Windows.Forms.ListView.SelectedListViewItemCollection =
                        ListViewCabecera.SelectedItems
                Dim item As New System.Windows.Forms.ListViewItem
                For Each item In coleecionItem
                    FacturVenta.NumFactur = item.SubItems(1).Text
                    Cliente = item.SubItems(2).Text
                    Fechades = item.SubItems(3).Text
                    FechaHast = item.SubItems(4).Text
                    Base0 = item.SubItems(5).Text
                    Base12 = item.SubItems(6).Text
                    ivaTotal = item.SubItems(7).Text
                    otroValor = item.SubItems(8).Text
                    Total = item.SubItems(9).Text
                    Direccion = item.SubItems(10).Text
                    TipoVent = item.SubItems(11).Text
                    Ruc = item.SubItems(12).Text
                    If Fechades = FechaHast Then  'berificamos las fecha decompra facturadas
                        fechaReal = Convert.ToString(FormatDateTime(Fechades, DateFormat.ShortDate))
                    Else
                        fechaReal = Convert.ToString(FormatDateTime(Fechades, DateFormat.ShortDate) _
                                    & "-" & FormatDateTime(FechaHast, DateFormat.ShortDate))
                    End If
                    Return True
                Next
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error:" & Me.Name & " en el CargaDatosCabera")
            Return False
        End Try
    End Function

    Private Sub detailButton_Click(sender As Object, e As EventArgs) Handles detailButton.Click
        Try
            If Not SplitContainer1.Panel2Collapsed Then
                SplitContainer1.Panel2Collapsed = True
                Return
            End If
            If ListViewCabecera.SelectedItems.Count = 1 Then
                lblTituloDetalle.Text = " Detalle del documento: " & ListViewCabecera.SelectedItems(0).SubItems(FacturColum.Index).Text
                If Carga_DetalleFactur(Me.ListViewCabecera.SelectedItems(IdFactureColum.Index).Text) Then
                    SplitContainer1.Panel2Collapsed = False
                    SplitContainer2.Panel2Collapsed = True
                    SplitContainer2.Panel1Collapsed = False
                    ListViewDetail.Columns(ColumnCommands.Index).Width = 0
                    ListViewDetail.Columns(ColumnDisponible.Index).Width = 0
                    ListViewDetail.Columns(ColumnDevuellto.Index).Width = 0
                    CancelDevolucionButton.Visible = False
                    saveDevolucionButton.Visible = False
                End If
            Else
                MsgBox("Seleccione uno del listado..", MsgBoxStyle.Exclamation, "Importante")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListViewCabecera_Click(sender As Object, e As EventArgs) Handles ListViewCabecera.Click
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles setIsPrinterButton.Click
        Try
            If ListViewCabecera.CheckedItems.Count > 0 Then
                sql = "Esta opción desaparecerá la lista de documentos aún no impresos." & vbNewLine
                sql = sql & "Desea continuar...?"
                If MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..") = MsgBoxResult.Yes Then
                    If MarqImpreso() Then
                        sql = "WHERE  (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "')"
                        MostarFactura_Select(sql)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub viewReportButton_Click_1(sender As Object, e As EventArgs) Handles viewReportButton.Click
        Try
            If preparateViewData() Then
                Select Case Me.documentName
                    Case "Factura"
                        Using viewReport As New frmReportFactura(viewLoadReport.All)
                            viewReport.ShowDialog()
                        End Using
                    Case "Nota de venta"
                        Using viewReport As New frmReportNotaVenta(viewLoadReport.All)
                            viewReport.ShowDialog()
                        End Using
                    Case "Proforma"
                        Using viewReport As New frmReportProforma(viewLoadReport.All)
                            viewReport.ShowDialog()
                        End Using
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Function preparateViewData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim breakfast As System.Windows.Forms.ListView.CheckedListViewItemCollection = ListViewCabecera.CheckedItems
            Dim item As System.Windows.Forms.ListViewItem
            Me.documentName = String.Empty

            Dim laps As Integer = 0
            For Each item In breakfast
                If laps = 0 Then
                    Me.documentName = item.SubItems(Nom_Docu.Index).Text
                Else
                    If Not (documentName.ToString.Equals(item.SubItems(Nom_Docu.Index).Text)) Then
                        MsgBox("Seleccione solo un tipo de documento.", MsgBoxStyle.Exclamation, "Importante")
                        Return False
                    End If
                End If
                laps += 1
            Next
            Return printViewDocument()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function


    Private Function printViewDocument() As Boolean
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Dim command As SqlCommand = cnn.CreateCommand()
                Dim transaction As SqlTransaction

                ' Start a local transaction
                transaction = cnn.BeginTransaction("SampleTransaction")

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = cnn
                command.Transaction = transaction
                command.CommandType = CommandType.Text
                'sql intruccion for delete
                sql = "delete [tmp].[DocumentSelectUser]  "
                sql = sql & "WHERE((codUser = @codUser)And (codTerminal =@codTerminal)) "
                command.CommandText = sql
                command.Parameters.Add("@codUser", SqlDbType.Char, 8)
                command.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
                'set value
                command.Parameters("@codUser").Value = UsuarioActivo.codUser
                command.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                'delete temp datd
                command.ExecuteNonQuery()
                'Add data

                Dim breakfast As System.Windows.Forms.ListView.CheckedListViewItemCollection = ListViewCabecera.CheckedItems
                Dim item As System.Windows.Forms.ListViewItem
                Dim laps As Integer = 0
                'data sql string

                sql = "Insert into [tmp].[DocumentSelectUser] "
                sql = sql & "(codTerminal,codUser,idFactVenta) "
                sql = sql & "Values(@codTerminal,@codUser,@idFactVenta)"

                command.CommandText = sql
                For Each item In breakfast
                    If laps = 0 Then
                        command.Parameters.Add("@idFactVenta", SqlDbType.Int)
                    End If
                    command.Parameters("@codUser").Value = UsuarioActivo.codUser
                    command.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    command.Parameters("@idFactVenta").Value = item.Text
                    If Not (command.ExecuteNonQuery() = 1) Then
                        Return False
                    End If
                    laps += 1
                Next
                transaction.Commit()
            End Using

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub printMatricialButton_Click(sender As Object, e As EventArgs) Handles printMatricialButton.Click
        Try
            If preparateViewData() Then
                Select Case Me.documentName
                    Case "Factura"
                        Using viewReport As New frmReportFactura(viewLoadReport.All)
                            viewReport.Show()
                            viewReport.printDefaultButton.PerformClick()
                        End Using
                    Case "Nota de venta"
                        Using viewReport As New frmReportNotaVenta(viewLoadReport.All)
                            viewReport.Show()
                            viewReport.printDefaultButton.PerformClick()
                        End Using
                    Case "Proforma"
                        Using viewReport As New frmReportProforma(viewLoadReport.All)
                            viewReport.Show()
                            viewReport.printDefaultButton.PerformClick()
                        End Using

                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub devolucionButton_Click(sender As Object, e As EventArgs) Handles devolucionButton.Click
        Try
            UserAutorization = ""
            idTerminal = 0
            totalDevolver = 0
            idVenta = 0
            listDevolucion.Clear()
            Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
            If Not myTerminalActivo.Success Then
                Return
            End If
            If myTerminalActivo.IDterminal = 0 Then
                MsgBox("No se pudo obtenet el IdTerminal,", MsgBoxStyle.Exclamation, "Importante.")
                Return
            End If
            If Not Carga_idStadoCaja(myTerminalActivo.DataDb) Then
                Return
            End If

            idTerminal = myTerminalActivo.IDterminal

            If ListViewCabecera.CheckedItems.Count = 1 Then
                idVenta = Me.ListViewCabecera.CheckedItems(IdFactureColum.Index).Text
                Using newform As New LoginForm(stateReturn._response, "Ventas")
                    With newform
                        .Text = "Validando para midificar"
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            UserAutorization = .UsernameTextBox.Text
                            SplitContainer1.Panel1Collapsed = True
                            SplitContainer1.Panel2Collapsed = False
                            lblTituloDetalle.Text = " Detalle del documento: " & ListViewCabecera.CheckedItems(0).SubItems(FacturColum.Index).Text
                            If Carga_DetalleFactur(idVenta) Then
                                SplitContainer2.Panel2Collapsed = False
                                CancelDevolucionButton.Visible = True
                                saveDevolucionButton.Visible = True
                                ListViewDetail.Columns(ColumnCommands.Index).Width = 90
                                ListViewDetail.Columns(ColumnDisponible.Index).Width = 120
                                ListViewDetail.Columns(ColumnDevuellto.Index).Width = 120
                            End If
                        End If
                    End With
                End Using
            Else
                MsgBox("Seleccione solo uno de la lista.", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function Carga_idStadoCaja(dt As DataTable) As Boolean
        Try
            If Not (dt.Rows.Count = 1) Then
                sql = "Hay varias operaciones abierta" & vbNewLine
                sql = sql & "Habilite solo una..."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If

            If Not IsDBNull(dt.Rows(0)("own_User")) Then
                If Not UsuarioActivo.codUser.Equals(dt.Rows(0)("own_User")) Then
                    sql = "La operacion abierta pertenece a: " & dt.Rows(0)("own_User") & vbNewLine
                    sql = sql & "Habilite una para este usuario..."
                    MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                    Return False
                End If
            End If
            OperacionNumLabel.Text = "Operación:" & vbNewLine & dt.Rows(0)("idCajaStado")
            OperacionNumLabel.Tag = dt.Rows(0)("idCajaStado")
            Dim _user As String = Convert.ToString(dt.Rows(0)("own_User"))
            If String.IsNullOrEmpty(_user) Then
                User_operaLabel.Text = "Para: Todos" & vbNewLine & "los usuarios"
            Else
                User_operaLabel.Text = "Para: " & vbNewLine & _user
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub anulaButton_Click(sender As Object, e As EventArgs) Handles anulaButton.Click

    End Sub

    Private Sub saveDevolucionButton_Click_1(sender As Object, e As EventArgs) Handles saveDevolucionButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If ListViewDevueltos.Items.Count > 0 Then
                'armamos la lista
                Dim isRegister As Boolean = False
                listDevolucion = New List(Of ItemListDevolucion)
                For Each item As ListViewItem In ListViewDevueltos.Items
                    isRegister = False
                    For Each list As ItemListDevolucion In listDevolucion
                        If Integer.Parse(item.Text) = list.IdPresent Then
                            list.Cantidad += Double.Parse(item.SubItems(cantidadDecimalPrevio.Index).Text)
                            list.PrecioVenta += Double.Parse(item.SubItems(totalDecimalPrevio.Index).Text)
                            isRegister = True
                            Exit For
                        End If
                    Next
                    If Not isRegister Then
                        listDevolucion.Add(New ItemListDevolucion(item.Text, item.SubItems(cantidadDecimalPrevio.Index).Text, item.SubItems(totalDecimalPrevio.Index).Text))
                    End If
                Next

                If listDevolucion.Count = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("No se pudo enlistar información para guardar.", MsgBoxStyle.Exclamation, "Importante")
                    Return
                End If
                'transfiere informacion
                If Tranfer_Devolucion(listDevolucion) Then
                    Me.Cursor = Cursors.Default
                    MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No hay información para guardar.", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function Tranfer_Devolucion(listDevolucion As List(Of ItemListDevolucion)) As Boolean
        Try
            Dim saldo As Double = 0
            Dim Base0 As Double = 0
            Dim Base12 As Double = 0
            Dim Iva As Double = 0
            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction

                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()

                db.Transaction = transaction
                Try
                    'berificamos si tenemos saldo

                    Dim _saldo = Aggregate item In db.CajaStado
                                     Where item.idCajaStado = Me.idTerminal
                                  Into Sum(item.Saldo)

                    If Not IsNothing(_saldo) Then
                        saldo = _saldo
                    End If
                    'si no hay saldo suficiente salimos
                    If Not saldo >= totalDevolver Then
                        sql = "En esta caja no existe saldo suficiente para devolver" & vbCrLf & "Solo se registra: " & saldo.ToString("C2") & " de saldo."
                        transaction.Rollback()
                        Return False
                    End If

                    For Each list As ItemListDevolucion In listDevolucion

                        Dim _FacturaVentaDevolucion As New FacturaVentaDevolucion With
                           {
                           .idFacturaVenta = Me.ListViewCabecera.CheckedItems(IdFactureColum.Index).Text,
                           .idPresent = list.IdPresent,
                           .Cantidad = list.Cantidad,
                           .Prec_Venta = list.PrecioVenta,
                           .UserAutoritation = UserAutorization
                          }

                        Dim itemVentaReal = From v In db.FacturaVentaDetail
                                            Where v.idFacturaVenta = _FacturaVentaDevolucion.idFacturaVenta _
                                            And v.idPresent = list.IdPresent

                        'calculos de bases para el total
                        For Each item In itemVentaReal
                            If item.Iva > 0 Then
                                Base12 += (item.Prec_Venta / item.Cantidad) * _FacturaVentaDevolucion.Cantidad
                                Iva += (item.Iva / item.Cantidad) * _FacturaVentaDevolucion.Cantidad
                            Else
                                Base0 += (item.Prec_Venta / item.Cantidad) * _FacturaVentaDevolucion.Cantidad
                            End If
                        Next


                        Dim _FacturaVentaDetail As New FacturaVentaDetail With
                            {
                            .idFacturaVenta = _FacturaVentaDevolucion.idFacturaVenta,
                            .idPresent = _FacturaVentaDevolucion.idPresent,
                            .Cantidad = _FacturaVentaDevolucion.Cantidad * -1,
                            .Prec_Venta = _FacturaVentaDevolucion.Prec_Venta * -1,
                            .Iva = If(itemVentaReal.Count > 0, (itemVentaReal.FirstOrDefault().Iva /
                                  itemVentaReal.FirstOrDefault().Cantidad) * _FacturaVentaDevolucion.Cantidad, 0),
                            .Prec_Compra = If(itemVentaReal.Count > 0, itemVentaReal.FirstOrDefault().Prec_Compra, 0)
                        }
                        db.FacturaVentaDetail.InsertOnSubmit(_FacturaVentaDetail)
                        db.FacturaVentaDevolucion.InsertOnSubmit(_FacturaVentaDevolucion)
                    Next
                    'MODIFICANDO LA CABECERA
                    Dim _FacturaVenta = From f In db.FacturaVenta
                                        Where f.idFactVenta =
                                        Integer.Parse(Me.ListViewCabecera.CheckedItems(IdFactureColum.Index).Text)

                    For Each item In _FacturaVenta
                        item.Total -= Redondear(totalDevolver, 2)
                        item.Base00Iva -= Redondear(Base0, 2)
                        item.Base12Iva -= Redondear(Base12 - Iva, 2)
                        item.Iva = item.Total - (item.Base00Iva + item.Base12Iva)
                    Next

                    'modificamos las cajas.....
                    Dim _cajas As New Cajas With
                    {
                            .idCajaStado = Me.idTerminal,
                            .codUserMovi = UsuarioActivo.codUser,
                            .Descripcion = "Devolución:  " & Me.idVenta & "/Devolución de productos/Pagó:Efectivo",
                            .idFormaPago = 1,
                            .debe = 0,
                            .haber = totalDevolver,
                            .saldo = saldo - totalDevolver,
                            .onControl = "isSystem",
                            .TypoMovi = 1
                        }
                    db.Cajas.InsertOnSubmit(_cajas)
                    db.SubmitChanges()
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                Finally
                    If Not IsNothing(transaction) Then
                        transaction = Nothing
                    End If
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ListViewDetail_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewDetail.MouseClick
        Try
            'obtenemos el listview
            Dim listvie As ListView = ListViewDetail
            If listvie.SelectedItems.Count = 1 Then
                Dim info As ListViewHitTestInfo = sender.HitTest(e.X, e.Y)
                Dim coleecionItem As ListView.SelectedListViewItemCollection =
                    ListViewDetail.SelectedItems
                Dim item As ListViewItem
                For Each item In coleecionItem
                    If info.SubItem.Text = (item.SubItems(ColumnCommands.Index).Text) Then 'al hacer click en el agregar
                        Dim cantidad As Double = 0

                        cantidad = ListViewDetail.SelectedItems(0).SubItems(ColumnDevuellto.Index).Text
                        If cantidad > 0 Then
                            sql = "Este producto ya se hizo la devolución." & vbCrLf & "Imposible realizarlo otra vez."
                            MsgBox(sql, MsgBoxStyle.Exclamation, "importante")
                            Return
                        End If

                        cantidad = ListViewDetail.SelectedItems(0).SubItems(ColumnDisponibleDecimal.Index).Text
                        If Not cantidad > 0 Then
                            MsgBox("No existe candidad disponible.", MsgBoxStyle.Exclamation, "importante")
                            Return
                        End If

                        If Not MsgBox("Está seguro de hacer la devolución de este producto.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                            Return
                        End If



                        Using newdata As New frmImputData
                            With newdata
                                .Text = "Ingrese la cantidad a devolver."
                                .txtNumber.Maximum = cantidad
                                .txtNumber.Value = cantidad
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    cantidad = .txtNumber.Value
                                Else
                                    Return
                                End If
                            End With
                        End Using
                        If cantidad = 0 Then
                            Return
                        End If
                        Add_List_Previo(listvie.SelectedItems(0), cantidad)
                    End If
                Next
            Else
                MsgBox("Seleccione solo uno del listado", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Add_List_Previo(item As ListViewItem, cantidad As Double)
        Try
            Dim ultimo As Integer = 0
            Dim valor As Double = 0
            Dim disponible As Double = 0

            ListViewDevueltos.Items.Add(item.SubItems(IdPresentacion.Index).Text)    '0
            ultimo = ListViewDevueltos.Items.Count - 1
            ListViewDevueltos.Items(ultimo).SubItems.Add(cantidad.ToString("N2"))    '1
            ListViewDevueltos.Items(ultimo).SubItems.Add(item.SubItems(clmEmpaque.Index).Text)   '2
            ListViewDevueltos.Items(ultimo).SubItems.Add(item.SubItems(nom_ProductColm.Index).Text)  '3
            ListViewDevueltos.Items(ultimo).SubItems.Add(item.SubItems(pvpColumn.Index).Text)   '4

            valor = Decimal.Parse(ListViewDetail.SelectedItems(0).SubItems(pvpDecimalColumn.Index).Text) * cantidad

            ListViewDevueltos.Items(ultimo).SubItems.Add(valor.ToString("C2"))  '5
            ListViewDevueltos.Items(ultimo).SubItems.Add(valor)         '6
            ListViewDevueltos.Items(ultimo).SubItems.Add(cantidad)      '7
            'actualizamos la disponibilidad
            disponible = ListViewDetail.SelectedItems(0).SubItems(ColumnDisponibleDecimal.Index).Text
            disponible = disponible - cantidad
            ListViewDetail.SelectedItems(0).SubItems(ColumnDisponible.Index).Text = disponible.ToString("N2")    '8
            ListViewDetail.SelectedItems(0).SubItems(ColumnDisponibleDecimal.Index).Text = disponible     '9

            totalDevolver += valor
            TotalDevolverLabel.Text = "Total a devolver: " & totalDevolver.ToString("C2")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CancelDevolucionButton_Click(sender As Object, e As EventArgs) Handles CancelDevolucionButton.Click
        Try
            If Not SplitContainer1.Panel2Collapsed Then
                SplitContainer1.Panel2Collapsed = True
                ListViewDevueltos.Items.Clear()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ListViewDetail.Columns(ColumnCommands.Index).ImageIndex = 0
    End Sub
    Sub MessageBoxTimer()
        Dim AckTime As Integer, InfoBox As Object
        InfoBox = CreateObject("WScript.Shell")
        'Set the message box to close after 10 seconds
        AckTime = 1
        Select Case InfoBox.Popup("Click OK (this window closes automatically after 10 seconds).",
    AckTime, "This is your Message Box", 0)
            Case 1, -1
                Exit Sub
        End Select
    End Sub


    Private Sub ChangedClientButton_Click(sender As Object, e As EventArgs) Handles ChangedClientButton.Click
        Dim idPerson As Integer = 0
        Dim idcliente As Integer = 0
        Try
            If Not ListViewCabecera.SelectedItems.Count = 1 Then
                'MessageBoxTimer()
                MsgBox("Seleccione un documento", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Using VewLogin As New LoginForm(stateReturn._response, "Supervisor de ventas")
                VewLogin.Text = "Validando usuario"
                VewLogin.ShowDialog()
                If Not VewLogin.DialogResult = DialogResult.OK Then
                    Return
                End If
            End Using
            Using listclien As New frmList_PersonViewTarget(stateLoad.Dialogo)
                listclien.StartPosition = FormStartPosition.CenterScreen
                listclien.Text = "Seleccione el nuevo propietario del documento"
                listclien.ShowDialog()
                If Not listclien.DialogResult = DialogResult.OK Then
                    Return
                End If
                idPerson = listclien.idPersona
            End Using

            If idPerson > 0 Then
                If Not MsgBox("Esta seguro de cambiar el cliente...",
                          +MsgBoxStyle.Question _
                          + MsgBoxStyle.YesNo _
                          + MsgBoxStyle.DefaultButton2 _
                          , "Responda...") = MsgBoxResult.Yes Then
                    Return
                End If
                idcliente = ClsClientes.isClinteBypersonAdmin(idPerson)
            End If
            If idcliente > 0 Then
                If ChangedClient(idcliente,
                              Integer.Parse(ListViewCabecera.SelectedItems(0).Text)) Then
                    Me.NotifyIcon1.BalloonTipText = "Operacion Exitosa"
                    Me.NotifyIcon1.Text = "JMTSystem Software"
                    Me.NotifyIcon1.BalloonTipTitle = "Mensaje.."
                    Me.NotifyIcon1.ShowBalloonTip(4000)
                    Me.bntBuscar.PerformClick()
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ChangedClient(idcliente As Integer, idFactur As Integer) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "update FacturaVenta set idCliente = " & idcliente & "
                       Where idFactVenta = " & idFactur & ""
                Using cmd As New SqlCommand(sql, cnn)
                    If cmd.ExecuteNonQuery() Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ViewListFavorityButton_Click(sender As Object, e As EventArgs) Handles ViewListFavorityButton.Click
        Me.PanelData.Controls.Clear()
        Me.PanelData.Controls.Add(Me.PanelFavority)
        Me.PanelFavority.Visible = True
        Me.PanelFavority.Dock = DockStyle.Fill
        SplitContainer1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub BackArrow_Button_Click(sender As Object, e As EventArgs) Handles BackArrow_Button.Click
        Me.PanelData.Controls.Clear()
        Me.PanelData.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer1.Visible = True
        Me.SplitContainer1.Dock = DockStyle.Fill
    End Sub

    Private Sub PrintSelectButton_Click(sender As Object, e As EventArgs) Handles PrintSelectButton.Click
        If PrinterSelectInTicket() Then
        End If
    End Sub

    Private Sub selectAllCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles selectAllCheckBox.CheckedChanged
        Try
            Me.isLoad = False
            For i = 0 To Me.ListViewCabecera.Items.Count - 1
                ListViewCabecera.Items(i).Checked = selectAllCheckBox.CheckState
            Next
            If selectAllCheckBox.CheckState = CheckState.Checked Then
                PanelControls.Enabled = True
            Else
                PanelControls.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.isLoad = True
        End Try


    End Sub

    Private Sub ListViewCabecera_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListViewCabecera.ItemChecked
        If Me.isLoad Then
            If ListViewCabecera.CheckedItems.Count > 0 Then
                PanelControls.Enabled = True
            Else
                PanelControls.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.bntBuscar.Enabled = True
            Me.AcceptButton = Me.bntBuscar
        Else
            Me.bntBuscar.Enabled = False
        End If
    End Sub

    Private Sub bntBuscar_Click(sender As Object, e As EventArgs) Handles bntBuscar.Click
        sql = ""
        Select Case CmbOptionSelect.Text
            Case "Número de Factura"
                sql = "WHERE  (fv.Num_Factu Like '%" + Me.txtbuscar.Text + "%') "
            Case "Cliente"
                sql = "WHERE  (c.Nombres LIKE '%" + Me.txtbuscar.Text + "%') "
            Case "Ruc (o) C.I"
                sql = "WHERE  (c.Ruc_Ci LIKE '%" + Me.txtbuscar.Text + "%') "
            Case "No Impresas"
                sql = "WHERE (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "')"
            Case "Fecha del documento"
                Dim dateFind As Date = DateTimePickerEnd.Value.Date
                Dim dateStar As Date = DateTimePickerStar.Value.Date
                sql = "WHERE (fv.fechaDesde >= '" & dateStar & "') AND (fv.fechaDesde < dateadd(day, 1, '" & dateFind & "')) "
            Case "ID"
                sql = "WHERE (fv.idFactVenta >= " & Me.txtbuscar.Text & ") AND (fv.idFactVenta <= " & Me.txtbuscar.Text & ") "
        End Select

        If sql.Length > 0 Then
            If MostarFactura_Select(sql) Then
                lbltotalFactur.Visible = True
            Else
                lblNoInforcion.Visible = True
            End If
        Else
            MsgBox("Seleccione una de las opciones de consulta...", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Function MostarFactura_Select(ByVal SrtWhere As String) As Boolean
        Me.isLoad = False

        sql = "Select Top(150) fv.idFactVenta,fv.Num_Factu,c.Nombres As[Cliente], fv.fechaDesde, fv.fechaHasta,  "
        sql = sql & "FV.Base00Iva, FV.Base12Iva, FV.Iva, cast(FV.OtroValor + FV.Total As Decimal(18, 2))  as [Total],  "
        sql = sql & "c.Direccion, fp.formaPago, c.Ruc_Ci, FV.Impreso, FV.codUser, FV.estado, FV.OtroValor, td.Nom_Docu "

        sql = sql & "From [dbo].[FacturaVenta] AS fv "
        sql = sql & "INNER Join [dbo].[ClienteName] AS c ON fv.idCliente = c.idCliente "
        sql = sql & "INNER Join [stm].[FormaPago] AS fp ON fv.idFormaPago = fp.idformaPago "
        sql = sql & "INNER Join [stm].[TypoDocumento] AS td on td.idTypoDocu = fv.idTypoDocument "
        sql = sql & SrtWhere
        SplitContainer1.Panel2Collapsed = True
        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim data As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                data.Fill(dt)
                ListViewCabecera.Items.Clear()
                If dt.Rows.Count > 0 Then
                    Dim subTotalFila As Double = 0
                    With Me.ListViewCabecera
                        lbltotalFactur.Text = "Total factura:" & 0
                        For i = 0 To dt.Rows.Count - 1
                            Dim Filas As Integer = .Items.Count
                            .Items.Add(dt(i)("idFactVenta").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("Num_Factu").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("Nom_Docu").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("Cliente").ToString)
                            .Items.Item(Filas).SubItems.Add(FormatDateTime(dt(i)("fechaDesde").ToString, DateFormat.ShortDate))
                            .Items.Item(Filas).SubItems.Add(FormatDateTime(dt(i)("fechaHasta").ToString, DateFormat.ShortDate))
                            .Items.Item(Filas).SubItems.Add(dt(i)("Base00Iva").ToString)  'Format((Precio), "###,##0.00")
                            .Items.Item(Filas).SubItems.Add(dt(i)("Base12Iva").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("Iva"))

                            subTotalFila = dt(i)("OtroValor")
                            .Items.Item(Filas).SubItems.Add(subTotalFila.ToString("C2"))

                            subTotalFila = dt(i)("Total")

                            .Items.Item(Filas).SubItems.Add(subTotalFila.ToString("C2"))
                            .Items.Item(Filas).SubItems.Add(dt(i)("Direccion").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("formaPago").ToString)
                            .Items.Item(Filas).SubItems.Add(dt(i)("Ruc_Ci").ToString)

                            'cambio el color del total
                            .Items(Filas).UseItemStyleForSubItems = False
                            .Items(Filas).SubItems(TotalColum.Index).BackColor = Color.Aqua
                            .Items(Filas).SubItems(TotalColum.Index).ForeColor = Color.Blue

                            lbltotalFactur.Text = "Total documentos: " & i + 1
                            lblNoInforcion.Visible = False
                        Next
                        ListViewCabecera.Focus()
                    End With
                    Return True
                End If
                Return False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: frmlistFactura en el MostarFactura_Select")
            ListViewCabecera.Items.Clear()
            Return False
        Finally
            Me.isLoad = True
            Me.PanelControls.Enabled = False
            If ListViewCabecera.Items.Count > 0 Then
                Me.selectAllCheckBox.Enabled = True
            Else
                Me.selectAllCheckBox.Enabled = False
            End If
        End Try
    End Function

    Private Sub CmbOptionSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOptionSelect.SelectedIndexChanged
        ListViewCabecera.Items.Clear()
        Me.PanelControls.Enabled = False
        lbltotalFactur.Visible = False
        lblNoInforcion.Visible = False
        Me.PanelImputDate.Visible = False
        txtbuscar.Visible = True
        If CmbOptionSelect.SelectedIndex > -1 Then
            If CmbOptionSelect.Text.Contains("No Impresas") Then 'No Impresas
                txtbuscar.Enabled = False
                bntBuscar.Enabled = False
                sql = "WHERE  (fv.Impreso = 0) AND (fv.codUser = '" + UsuarioActivo.codUser + "') "
                sql = sql & "ORDER BY fv.Num_Factu "
                If MostarFactura_Select(sql) Then
                    lbltotalFactur.Visible = True
                End If
            ElseIf CmbOptionSelect.Text.Contains("Fecha del documento") Then
                txtbuscar.Visible = False
                Me.PanelImputDate.Visible = True
            Else
                txtbuscar.Enabled = True
                bntBuscar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Function Carga_DetalleFactur(ByVal IdFactur As Integer) As Boolean
        Try
            sql = "select fvd.Cantidad, pp.Presentacion, p.Nom_Comun,
                    fvd.Prec_Venta/fvd.Cantidad as pvp , fvd.Prec_Venta,fvd.Iva,
                    fvd.idPresent, 
                    (CASE WHEN (dv.Cantidad)  IS NULL then 0 
	                     else (dv.Cantidad) 
                    end)
                    as devuelto
                    from FacturaVentaDetail  as fvd
                    inner join ProductoPresentacion as pp on fvd.idPresent = pp.idPresentacion
                    inner join Productos as p on p.idProducto  = pp.idProducto
                    left outer join FacturaVentaDevolucion as dv on dv.idFacturaVenta = fvd.idFacturaVenta 
	                and dv.idPresent  = fvd.idPresent
                    where fvd. idFacturaVenta = @idFacturaVenta"
            Dim Filas As Integer = 0

            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@idFacturaVenta", SqlDbType.Int)
                    cmd.Parameters("@idFacturaVenta").Value = IdFactur
                    Dim Data As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    Dim disponible As Double = 0
                    Data.Fill(dt)

                    With Me.ListViewDetail
                        .Items.Clear()
                        For i = 0 To dt.Rows.Count - 1
                            Filas = .Items.Count
                            .Items.Add(dt(i)("Cantidad").ToString)                       '[0]cantidad
                            .Items.Item(Filas).SubItems.Add(dt.Rows(i)("Presentacion"))       '[1]'empaque
                            .Items.Item(Filas).SubItems.Add(dt.Rows(i)("Nom_Comun"))      '[2] nombre
                            disponible = dt(i)("pvp")
                            .Items.Item(Filas).SubItems.Add(disponible.ToString("C2"))       '[3] nombre    
                            disponible = dt(i)("Prec_Venta")
                            .Items.Item(Filas).SubItems.Add(disponible.ToString("C2"))    '[4] Precio total 
                            .Items.Item(Filas).SubItems.Add(dt(i)("Iva").ToString)         '[5] nombre 
                            .Items.Item(Filas).SubItems.Add(dt(i)("Prec_Venta").ToString) '[6] nombre 
                            .Items.Item(Filas).SubItems.Add(dt(i)("idPresent")) '[7] id presentacion 

                            .Items.Item(Filas).SubItems.Add("Agregar ==>") '[8] commads 
                            .Items(Filas).UseItemStyleForSubItems = False
                            .Items.Item(Filas).SubItems(8).BackColor = Color.White
                            .Items.Item(Filas).SubItems(8).ForeColor = Color.Blue

                            disponible = dt(i)("Cantidad") - dt(i)("devuelto")
                            .Items.Item(Filas).SubItems.Add(disponible) '[9] disponible numerico 
                            .Items.Item(Filas).SubItems.Add(dt(i)("devuelto").ToString) '[10] devuelto
                            If dt(i)("devuelto") > 0 Then
                                .Items(Filas).UseItemStyleForSubItems = False
                                .Items.Item(Filas).SubItems(10).BackColor = Color.Red
                                .Items.Item(Filas).SubItems(10).ForeColor = Color.White
                            End If


                            .Items.Item(Filas).SubItems.Add(disponible.ToString("N2")) '[11] dsiponible visual 
                            .Items.Item(Filas).SubItems.Add(disponible) '[12] dsiponible dijito 
                            .Items.Item(Filas).SubItems.Add(dt(i)("pvp")) '[13] pvp decimal
                        Next
                        If Filas >= 0 Then
                            Me.lblCountItem.Text = "Total de Articulos: " & Filas + 1
                            Me.lblCountItem.Visible = True
                            .Columns(5).Width = 0
                            .Columns(6).Width = 0  'precioTotal a dos cecimales
                            ListViewDetail.Columns(ColumnCommands.Index).ImageIndex = 0
                            Return True
                        Else
                            Me.lblCountItem.Visible = False
                            Return False
                        End If
                    End With

                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: " & Me.Name & "en el frmTicket_Load")
            Return False
        End Try
    End Function
    Private Function imprimir_Factura() As Boolean

        'impreson en tcket 
        Try
            Dim i, VueltaItem As Integer
            Dim iva, Cant As Double
            Dim cantStg, Descp, SimIva, pvp, Empaq, TotalStri As String
            Dim Hora As String
            Hora = DateTime.Now.ToString("h:mm:ss")

            'carga nombre de la impresora configurada si no esta  va ha panel de opciones
cargaNuevo:
            If IsNothing(myOptnsPrint.NamePrint) Then
                If Not LoadOptionsPrint(1) Then
                    MsgBox("No se encuentra la impresora configurada", MsgBoxStyle.Information, "Aviso")
                    Using form As New frmOptionPrint
                        With form
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                If i = 0 Then
                                    i = 1
                                    GoTo cargaNuevo
                                Else
                                    Return False
                                End If
                            End If
                        End With
                    End Using
                    Return False  'si ya da 2 vueltas y no pudo configurar sale
                End If
                If Not PrinterNametInstol(myOptnsPrint.NamePrint) Then
                    MsgBox("La impresora" + myOptnsPrint.NamePrint + " no está instalada", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If Not PrinterNametInstol(myOptnsPrint.NamePrint) Then
                    MsgBox("La impresora" + myOptnsPrint.NamePrint + " no está instalada", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If

            Dim Ticket1 As New CreaTicket()

            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona
            'caega color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            Else
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            End If

            Ticket1.FontZiseText(FontZise.Default)
            If Not Carga_Cabera() Then 'informacion para imprimir como cabecera
                MsgBox("No se pudo leer la cabecera del listview ", MsgBoxStyle.Information, "Aviso")
                Return False
            End If

            Ticket1.AbreCajon()
            Ticket1.AvanzaEncabezado()                      'AVANZA 28 LINEAS
            Ticket1.isAvanzaLinea = False                     'Impide avanzar a la sigiente lines
            Ticket1.TextoDerecha(FacturVenta.NumFactur, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("CLIENTE:" + Cliente, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoExtremos("CI/RUC:" + Ruc, "User:" + UsuarioActivo.codUser)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("DIRECCION:" + Direccion, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoExtremos("FECH:" + Trim(fechaReal) + "H:" + Hora, "Term:" + TerminalActivo.codTerminal)
            Ticket1.Avanza2Lines()
            Ticket1.isAvanzaLinea = True
            Ticket1.TextoIzquierda("FORMA DE PAGO: " + TipoVent, False)
            Ticket1.isAvanzaLinea = False
            Ticket1.LineasIgual()
            Ticket1.Avanza2Lines()
            Ticket1.EncabezadoVenta()
            Ticket1.Avanza2Lines()
            Ticket1.LineasIgual()
            Ticket1.isAvanzaLinea = True
            VueltaItem = 0
            For i = 0 To Me.ListViewDetail.Items.Count - 1
                Cant = Me.ListViewDetail.Items.Item(i).SubItems(0).Text
                Empaq = Me.ListViewDetail.Items.Item(i).SubItems(1).Text
                Descp = (Me.ListViewDetail.Items.Item(i).SubItems(2).Text)
                TotalStri = Me.ListViewDetail.Items.Item(i).SubItems(6).Text       'Precio total del item
                pvp = Me.ListViewDetail.Items.Item(i).SubItems(3).Text             'precio unidad

                iva = Double.Parse(Me.ListViewDetail.Items.Item(i).SubItems(5).Text) 'Rebiso si tengo iva
                If iva > 0 Then
                    SimIva = "*"
                Else
                    SimIva = ""
                End If
                cantStg = Cant
                cantStg += Empaq
                cantStg = TextoDiseñado(cantStg, Alinea.Derecha, 6)
                Ticket1.AgregaArticulo(SimIva, cantStg, Descp, pvp, TotalStri) 'imprime una linea de descripcion
                VueltaItem += 1
                If VueltaItem = myOptnsPrint.items Then Exit For
            Next

            For i = 1 To (myOptnsPrint.items - VueltaItem)
                Ticket1.AvanzaRollo(1)
            Next
            Ticket1.isAvanzaLinea = False
            Ticket1.LineasIgual()
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("BASE TARIFA IVA 0%:", FormatNumber(Base0, 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("BASE TARIFA IVA 12%:", FormatNumber(Base12, 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("SUB TOTAL:", FormatNumber(Base0 + Base12, 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("IVA 12%", FormatNumber(ivaTotal, 2))
            Ticket1.isAvanzaLinea = False
            'Ticket1.LineasTotales()
            If otroValor > 0 Then
                Ticket1.AgregaTotales("*TOTAL A PAGAR", FormatNumber(Total, 2))
            Else
                Ticket1.AgregaTotales("TOTAL A PAGAR", FormatNumber(Total, 2))
            End If
            Ticket1.AvanzaPiePagina()
            Ticket1.AvanzaRollo(2)
            Ticket1.CortaTicket()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        cmdSelectAll(ListViewCabecera)
        ListViewCabecera.Focus()
    End Sub

    Private Sub btnNoselect_Click(sender As Object, e As EventArgs) Handles btnNoselect.Click
        cmdNotSelect(ListViewCabecera)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        cmdCopy(ListViewCabecera)
    End Sub
#Region "models"
    Private Class ItemListDevolucion
        Public Sub New(ByVal idPresent As Integer, ByVal cantidad As Double,
            ByVal precioVenta As Decimal)
            _idPresent = idPresent
            _cantidad = cantidad
            _precioVenta = precioVenta
        End Sub

        Private _idPresent As Integer
        Public Property IdPresent() As Integer
            Get
                Return _idPresent
            End Get
            Set(ByVal value As Integer)
                _idPresent = value
            End Set
        End Property

        Private _cantidad As String
        Public Property Cantidad() As Double
            Get
                Return _cantidad
            End Get
            Set(ByVal value As Double)
                _cantidad = value
            End Set
        End Property

        Private _precioVenta As Double
        Public Property PrecioVenta() As Double
            Get
                Return _precioVenta
            End Get
            Set(ByVal value As Double)
                _precioVenta = value
            End Set
        End Property
    End Class
#End Region

End Class