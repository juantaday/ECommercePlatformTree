Imports System.Data.SqlClient

Public Class frmPagos
    Protected Friend idProveedor As Integer
    Protected Friend idPago As Integer
    Protected Friend flag As String
    Protected Friend Operation As Boolean
    Private Deuda, Pagada, Saldo, EnProceso, NewSaldo As Double
    Private iniciada As Boolean


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Carga_DatosDeuda()
        Try
            iniciada = False
            ListViewDeuda.Items.Clear()
            EnceraDatos()
            sql = "select p.idPago, p.idFacturaCompra as [Num_Docu],CONVERT(date, p.fech_Factura) as [fecha], p.val_Factura, "
            sql = sql & "Case when sum(pd.val_Pagado) is not null then sum(pd.val_Pagado) else 0 end as [Pagado]  "
            sql = sql & " From Pagos As p "
            sql = sql & "left outer Join PagoDetail As pd On pd.idPago  = p.idPago "
            sql = sql & "Where p.idproveedor = " & idProveedor & " And p.statePago = 0  "
            sql = sql & "group by p.idPago, p.idFacturaCompra, p.fech_Factura ,p.val_Factura "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim fila As Integer
                    Dim total, pagadalines As Double
                    For i = 0 To dt.Rows.Count - 1
                        With ListViewDeuda
                            fila = ListViewDeuda.Items.Count
                            .Items.Add(dt.Rows(i)("Num_Docu"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("fecha"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("val_Factura"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("Pagado"))
                            total = dt.Rows(i)("val_Factura")
                            pagadalines = dt.Rows(i)("Pagado")
                            'aqui saldo
                            .Items(fila).SubItems.Add(FormatNumber(total - pagadalines, 2))
                            .Items(fila).UseItemStyleForSubItems = False
                            .Items(fila).SubItems(4).BackColor = Color.Aqua
                            .Items(fila).SubItems(4).ForeColor = Color.Blue
                            .Items(fila).SubItems.Add("0.00") ' para datos en proceso
                            .Items(fila).SubItems.Add(dt.Rows(i)("idPago"))
                            'sumamos totales
                            Deuda += dt.Rows(i)("val_Factura")
                            Pagada += dt.Rows(i)("Pagado")
                            Saldo = Deuda - Pagada
                        End With
                    Next
                    MostrarResumen()
                End If
            End If
            cmd = Nothing
            dt = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            iniciada = True
        End Try
    End Sub
    Private Sub MostrarResumen()
        Try
            TotalDeudaText.Text = FormatNumber(Deuda, 2)
            PagadasTextBox.Text = FormatNumber(Pagada, 2)
            SaldoTextBox.Text = FormatNumber(Saldo, 2)
            EnprocesoTextBox.Text = FormatNumber(EnProceso, 2)
            NuevoSaldoTextBox.Text = FormatNumber(NewSaldo, 2)
            If EnProceso = 0 Then
                NuevoSaldoTextBox.Text = FormatNumber(0, 2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub EnceraDatos()
        Deuda = 0
        Pagada = 0
        Saldo = 0
        EnProceso = 0
        NewSaldo = 0
    End Sub
    Private Sub frmCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciada = False
        If Not IsNothing(idProveedor) Then
            Carga_DatosDeuda()
            Carga_UltimosPagos()
        End If
        iniciada = True
        Operation = False 'indica si se realiza pagos o nó
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdSelectAll(ListViewDeuda)
        ListViewDeuda.Focus()
    End Sub

    Private Sub NoSeleccionarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cmdNotSelect(ListViewDeuda)
        ListViewDeuda.Focus()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        cmdCopy(ListViewDeuda)
        ListViewDeuda.Focus()
    End Sub

    Private Sub MarcarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcarTodoToolStripMenuItem.Click
        Try
            With ListViewDeuda
                EnProceso = 0
                ' del saldo pasamos toto ha proceso para sumar
                For i = 0 To .Items.Count - 1
                    .Items(i).SubItems(5).Text = .Items(i).SubItems(4).Text
                    EnProceso += Convert.ToDouble(.Items(i).SubItems(5).Text)
                Next
                EnProceso = Double.Parse(FormatNumber(EnProceso, 2))
                NewSaldo = FormatNumber(Saldo - EnProceso, 2)
            End With
            If EnProceso > 0 Then
                btnFormaPago.Enabled = True
                btnFormaPago.PerformClick()
            End If
            SumaEnProseso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DesmarcarTotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesmarcarTotoToolStripMenuItem.Click
        Try
            For i = 0 To ListViewDeuda.Items.Count - 1
                ListViewDeuda.Items(i).Checked = False
            Next
            ListViewDeuda.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ListViewDeuda_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListViewDeuda.ItemChecked
        Try
            If iniciada Then
                e.Item.UseItemStyleForSubItems = False
                If e.Item.Checked = True Then
                    e.Item.SubItems(5).Text = e.Item.SubItems(4).Text
                    e.Item.SubItems(5).BackColor = Color.Yellow
                Else
                    e.Item.SubItems(5).Text = "0.00"
                    e.Item.SubItems(5).BackColor = Color.White
                End If
                SumaEnProseso()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SumaEnProseso()
        Try
            EnProceso = 0
            With ListViewDeuda
                For i = 0 To .Items.Count - 1
                    EnProceso += Double.Parse(.Items(i).SubItems(5).Text)
                Next
                NewSaldo = FormatNumber(Saldo - EnProceso, 2)
            End With
            MostrarResumen()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeterminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeterminarToolStripMenuItem.Click
        Using Newfor As New frmImputData()
            With Newfor
                .Text = "Determine el monto"
                .ShowDialog()
                If .DialogResult = DialogResult.OK And .txtNumber.Value > 0 Then
                    Automatic_Pago(.txtNumber.Value)
                    btnFormaPago.PerformClick()
                End If
            End With
        End Using
    End Sub
    Private Sub Automatic_Pago(ByVal Valor As Double)
        Try
            'Cancelamos todo pago en proceso para deaudar
            EnProceso = 0
            iniciada = False
            Dim Linea As Double
            With ListViewDeuda
                'ponemos todo proceso en cero
                For i = 0 To .Items.Count - 1
                    .Items(i).SubItems(5).Text = "0.00"
                Next

                For i = 0 To .Items.Count - 1
                    Linea = Double.Parse(.Items(i).SubItems(4).Text)   'tomaos el saldo
                    EnProceso += Linea 'acomulamos
                    If Valor >= EnProceso Then
                        .Items(i).SubItems(5).Text = FormatNumber(Linea, 2)
                    ElseIf Valor >= (EnProceso - Linea) Then
                        Linea = Valor - (EnProceso - Linea)
                        .Items(i).SubItems(5).Text = FormatNumber(Linea, 2)
                        EnProceso += Linea
                    End If
                Next
                iniciada = True
                SumaEnProseso()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ModificaValor(items As ListViewItem, ByVal ValorNew As Double)
        Try
            items.SubItems(5).Text = FormatNumber(ValorNew, 2)
            SumaEnProseso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CambiarValorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarValorToolStripMenuItem.Click
        With ListViewDeuda
            If .SelectedItems.Count = 0 Then
                MsgBox("Seleccione un item del listado", MsgBoxStyle.Exclamation, "Importante")
            ElseIf .SelectedItems.Count > 1 Then
                MsgBox("Seleccione solo un item a modificar", MsgBoxStyle.Exclamation, "Importante")
            ElseIf .SelectedItems.Count = 1 Then
                Using fornew As New frmImputData()
                    With fornew
                        .Text = "Ingrese el valor"
                        .txtNumber.Maximum = Double.Parse(ListViewDeuda.SelectedItems(0).SubItems(4).Text)
                        .txtNumber.Value = .txtNumber.Maximum
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK And .txtNumber.Value > 0 Then
                            iniciada = False : ListViewDeuda.SelectedItems(0).Checked = False : iniciada = True
                            ListViewDeuda.SelectedItems(0).Checked = True
                            ModificaValor(ListViewDeuda.SelectedItems(0), .txtNumber.Value)
                        End If
                    End With
                End Using
            End If
        End With
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        Using fornew As New frmFormaPago()
            With fornew
                .flag = "Compras"
                .id_proveedor = idProveedor
                .txtTotal.Text = FormatNumber(EnProceso, 2)
                .txtPaga.Value = Convert.ToDouble(.txtTotal.Text)
                .ValCaheqtxt.Text = .txtPaga.Value
                If .InitialityMenu Then
                    .ToolStripMenuCredito.Enabled = False
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        datePago.Value = Now()
                        idPago = .idFormaPago
                        MenuStrip1.Enabled = False
                        PanePie.Enabled = False
                        PaneCentral.Enabled = False
                        btnPrintPago.Visible = False
                        btnViewDetailPago.Visible = False
                        lblultimoPago.Dock = DockStyle.Fill
                        sql = "Está a punto de realizar una operación" & vbNewLine
                        sql = sql & "no reversible "
                        lblultimoPago.Text = sql
                        ListViewPago.Visible = False
                        lblFormaPago.Visible = True
                        lblFormaPago.Text = .MsgBoxRetur
                        lblFormaPago.Dock = DockStyle.Fill
                        PanePieUltimoPago.Visible = True
                    End If
                End If
            End With
        End Using
    End Sub
    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        If Efectiza_Pago() Then
            btnCancelPago.PerformClick()
            Carga_DatosDeuda()
            Carga_UltimosPagos()
            sql = "Operación Exitosa " + vbNewLine
            sql = sql & "Desea imprimir el comprobante  en ticket..?"
            Operation = True
            If ListViewPago.Items.Count > 0 Then
                If MsgBox(sql, MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Aviso") = MsgBoxResult.Yes Then
                    ListViewPago.Items(0).Selected = True
                    btnPrintPago.PerformClick()
                End If
            End If
        End If
    End Sub
    Private Function Efectiza_Pago() As Boolean
        Try

            Dim i As Integer = 0
                ' eliminamos los datos temporates
                Elimina_DatoTemporal()
                Pagos.num_pago = Busca_New_NumDoc()
                Pagos.fech_Pago = datePago.Value
                Pagos.idPago = idPago
                Pagos.loginUser = UsuarioActivo.codUser
                Pagos.idProveedor = idProveedor
                If IsNothing(Pagos.idBancoCuenta) Then Pagos.idBancoCuenta = 0
                If IsNothing(Pagos.Num_Documento) Then Pagos.Num_Documento = String.Empty
                With ListViewDeuda
                    For i = 0 To .Items.Count - 1
                        Pagos.val_Pagado = Convert.ToDouble(.Items(i).SubItems(5).Text)
                        If Pagos.val_Pagado > 0 Then
                            If Not Agrega_DatoTemporal(Convert.ToInt32(.Items(i).SubItems(6).Text)) Then
                                Return False
                            End If
                        End If
                    Next
                End With
                If i > 0 Then
                    Return TrasfierePago()  'ejecuto el procedmineto si pude cargar a la tabla temporal
                End If

            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Agrega_DatoTemporal(idFactur As Integer) As Boolean
        Try
            sql = "insert into [tmp].[CobroTmp] (codUser,codTerminal,idCobro,val_Cobrado,idBanco,Num_Documento) "
            sql = sql & "Values ('" & UsuarioActivo.codUser & "','" & TerminalActivo.codTerminal & "', " & idFactur & ", " & Pagos.val_Pagado & ", " & Pagos.idBancoCuenta & ", '" & Pagos.Num_Documento & "') "
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return True
        End Try
    End Function
    Private Function Elimina_DatoTemporal() As Boolean
        If conecta_sql() Then
            Try
                sql = "DELETE  [tmp].[CobroTmp] where (CodTerminal = '" & TerminalActivo.codTerminal & "' and codUser = '" & UsuarioActivo.codUser & "') "
                Dim cmd As New ClassCargadorProducto()
                Return cmd.ExecuteComand(sql)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return True
            End Try
        End If
        Return False
    End Function
    Private Sub Carga_UltimosPagos()
        Try
            ListViewPago.Items.Clear()
            sql = " Select Top(4) cd.num_pago, cd.fech_Pago,COUNT(cd.idPagoDetail) As letras,sum(cd.val_Pagado) As total "
            sql = sql & "From PagoDetail As cd  "
            sql = sql & " inner Join Pagos  as c on c.idPago  = cd.idPago "
            sql = sql & "where c.idProveedor = " & idProveedor & ""
            sql = sql & "group by cd.num_pago, cd.fech_Pago "
            sql = sql & "ORDER BY MIN(CD.idPagoDetail) DESC "

            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim fila As Integer
                    With ListViewPago
                        For i = 0 To dt.Rows.Count - 1
                            fila = .Items.Count
                            .Items.Add(dt.Rows(i)("num_pago"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("fech_Pago"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("letras"))
                            .Items(fila).SubItems.Add(dt.Rows(i)("total"))
                        Next
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function TrasfierePago() As Boolean
        Try
            Dim cn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
            AddHandler cn.InfoMessage, AddressOf cn_InfoMessage
            Try
                '  @NumCobro varchar (25),
                '@Fech_Pago date,
                '@Fech_cheq date,
                '@tipo_Pago int,
                '@codUser varchar(8),
                '@idCliente int,
                '@codTerminal varchar (8)

                cn.Open()
                Using cmd As New SqlCommand("prcPagoProveedor", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' -- numero de pago
                    cmd.Parameters.Add("@NumCobro", SqlDbType.VarChar, 25)
                    cmd.Parameters("@NumCobro").Value = Pagos.num_pago
                    ' -- fecha de pago
                    cmd.Parameters.Add("@Fech_Pago", SqlDbType.Date)
                    cmd.Parameters("@Fech_Pago").Value = Pagos.fech_Pago
                    ' -- fecha de cheque
                    cmd.Parameters.Add("@Fech_cheq", SqlDbType.Date)
                    cmd.Parameters("@Fech_cheq").Value = Pagos.fech_Cheq
                    ' -- forma de pago
                    cmd.Parameters.Add("@tipo_Pago", SqlDbType.Int)
                    cmd.Parameters("@tipo_Pago").Value = Pagos.idformaPago
                    ' -- persona que cobro
                    cmd.Parameters.Add("@codUser", SqlDbType.VarChar, 8)
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    ' -- cliente a quien se está cobrando
                    cmd.Parameters.Add("@idCliente", SqlDbType.Int)
                    cmd.Parameters("@idCliente").Value = Pagos.idCliente
                    ' -- equipo de la que se realizó la operación
                    cmd.Parameters.Add("@codTerminal", SqlDbType.VarChar, 8)
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
                Return False
            Catch ex As SqlException
                MsgBox(ex.Message + " en ele modulo TrasfierePago del " + Name, MsgBoxStyle.Critical, "Error")
                Return False
            Finally
                If Not (IsNothing(cn)) Then
                    cn = Nothing
                End If
            End Try
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Function
    Public Sub cn_InfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
        MsgBox("Ocurio algo inesparado: " & e.Message, MsgBoxStyle.Critical, "Alerta")
    End Sub

    Private Sub btnCancelPago_Click_1(sender As Object, e As EventArgs) Handles btnCancelPago.Click
        idPago = 0
        MenuStrip1.Enabled = True
        PanePie.Enabled = True
        PaneCentral.Enabled = True
        btnPrintPago.Visible = True
        btnViewDetailPago.Visible = True
        lblultimoPago.Dock = DockStyle.Top
        lblultimoPago.Text = "-- Ultimos Pagos --"
        ListViewPago.Visible = True
        lblFormaPago.Visible = False
        lblFormaPago.Dock = DockStyle.None
        PanePieUltimoPago.Visible = False
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        cmdSelectAll(ListViewDeuda)
    End Sub

    Private Sub NoSeleccionarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NoSeleccionarToolStripMenuItem.Click
        cmdNotSelect(ListViewDeuda)
    End Sub

    Private Sub CpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CpiarToolStripMenuItem.Click
        cmdCopy(ListViewDeuda)
    End Sub

    Private Sub EnprocesoTextBox_TextChanged(sender As Object, e As EventArgs) Handles EnprocesoTextBox.TextChanged
        Try
            btnFormaPago.Enabled = False
            If IsNumeric(EnprocesoTextBox.Text) Then
                If Double.Parse(EnprocesoTextBox.Text) > 0 Then
                    btnFormaPago.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class

