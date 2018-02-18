Imports System.Data.SqlClient
Imports ECommercePlatformView.DebitEmployeeNameSpace

Public Class frmCobroEmpleado
    Private IdPeople As Integer
    Private _tasks As DebitEmployeeCollection

    Protected Friend idPago As Integer
    Protected Friend flag As String
    Protected Friend Operation As Boolean
    Private Deuda, Pagada, Saldo, EnProceso, NewSaldo As Double
    Private iniciada As Boolean
    Sub New(ByVal _idPeople As Integer, ByVal _data As List(Of DebitEmployee))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.IdPeople = _idPeople
        _tasks = New DebitEmployeeCollection
        If Not IsNothing(_data) Then
            For Each item In _data
                _tasks.Add(New DebitEmployee With
                           {
                           .Document = item.Document,
                           .Apellidos = item.Apellidos,
                           .DebitDate = item.DebitDate,
                           .DebitValue = item.DebitValue,
                           .IdEmpleadoDeuda = item.IdEmpleadoDeuda,
                           .IdPerson = item.IdPerson,
                           .IsUpdate = item.IsUpdate,
                           .Nombres = item.Nombres,
                           .PaymentDebit = item.PaymentDebit,
                           .RucCi = item.RucCi,
                           .TypeDebit = item.TypeDebit
                           })

            Next
        Else
            Reload_DataDebit()
        End If
    End Sub
    Private Sub frmCobroEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciada = False
        ViewDebit()
        Carga_UltimosPagos()
        iniciada = True
    End Sub
    Private Sub Reload_DataDebit()

        Try
            _tasks.Clear()

            Using db As New DataContext
                Dim _debitEmployee = From debit In db.GetDebitEmployee(Me.IdPeople)

                For Each item In _debitEmployee
                    _tasks.Add(New DebitEmployee() With
                                {
                                  .IdEmpleadoDeuda = item.idEmpleadoDeuda,
                                  .TypeDebit = "Responsabilidades",
                                  .Document = item.idEmpleadoDeuda,
                                  .Apellidos = item.Apellidos,
                                  .DebitDate = item.DebitDate,
                                  .DebitValue = item.DevitValue,
                                  .IdPerson = item.idPersona,
                                  .Nombres = item.Nombre,
                                  .RucCi = item.Ruc_Ci,
                                  .PaymentDebit = item.valCobrado
                                })
                Next
            End Using
            ViewDebit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ViewDebit()
        Try
            iniciada = False
            EnceraDatos()
            ListViewDeuda.Items.Clear()
            Dim fila As Integer = 0
            For Each item In _tasks
                With ListViewDeuda
                    fila = ListViewDeuda.Items.Count
                    .Items.Add(item.Document)
                    .Items(fila).SubItems.Add(item.DebitDate.ToShortDateString() & " " & item.DebitDate.ToShortTimeString())
                    .Items(fila).SubItems.Add(item.DebitValue)
                    .Items(fila).SubItems.Add(item.PaymentDebit)

                    'aqui saldo
                    .Items(fila).SubItems.Add(FormatNumber(item.DebitValue - item.PaymentDebit, 2))
                    .Items(fila).UseItemStyleForSubItems = False
                    .Items(fila).SubItems(4).BackColor = Color.Aqua
                    .Items(fila).SubItems(4).ForeColor = Color.Blue
                    .Items(fila).SubItems.Add("0.00") ' para datos en proceso
                    .Items(fila).SubItems.Add(item.IdEmpleadoDeuda)
                    'sumamos totales
                    Deuda += item.DebitValue
                    Pagada += item.PaymentDebit
                    Saldo = Deuda - Pagada
                End With
            Next
            MostrarResumen()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            iniciada = True
        End Try
    End Sub
    Private Sub Carga_UltimosPagos()
        Try
            ListViewPago.Items.Clear()
            Dim fila As Integer = 0
            Dim _cobradas As Double = 0
            Using db As New DataContext
                Dim _listPaymentEmployee = From l In db.GetListPaymentEmployee(Me.IdPeople)
                With ListViewPago
                    For Each item In _listPaymentEmployee
                        fila = .Items.Count
                        .Items.Add(item.num_cobro)
                        .Items(fila).SubItems.Add(item.fechaCobro.ToShortDateString() & " " & item.fechaCobro.ToShortTimeString())
                        .Items(fila).SubItems.Add(item.Letras)
                        Double.TryParse(item.Cobradas, _cobradas)
                        .Items(fila).SubItems.Add(_cobradas.ToString("C2"))
                    Next
                End With
            End Using
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
        saltoTotalLabel.Text = String.Format("Saldo actual: {0}", Saldo.ToString("C2"))
    End Sub
    Private Sub DesmarcarTotoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DesmarcarTotoToolStripMenuItem.Click
        Try
            For i = 0 To ListViewDeuda.Items.Count - 1
                ListViewDeuda.Items(i).Checked = False
            Next
            ListViewDeuda.Focus()
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
                btnFormaPago.PerformClick()
            End If
            SumaEnProseso()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        Try
            Using fornew As New frmFormaPago()
                With fornew
                    .flag = "Clientes"
                    .idcliente = IdPeople
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
                            SplitContainer1.Panel1.Enabled = False
                            PrintTicketPago.Visible = False
                            PrintMatricialPago.Visible = False
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Try
            Cursor = Cursors.WaitCursor
            If Efectiza_Pago() Then
                Operation = True
                btnCancelPago.PerformClick()
                Reload_DataDebit()
                Carga_UltimosPagos()
                Me.Cursor = Cursors.Default
                MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                If LoadOptionsPrint("Recibo cobro deuda cliente") Then
                    If MsgBox("Desea imprimir el recibo en " & myOptnsPrint.NamePrint, MsgBoxStyle.Information + MsgBoxStyle.YesNo +
                              MsgBoxStyle.DefaultButton1, "Aviso") = MsgBoxResult.Yes Then
                        PrintReciboCobro(Pagos.num_pago, myOptnsPrint)
                    End If
                End If
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, " en el btnPago_Click del " + Me.Name)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Function Efectiza_Pago() As Boolean
        Try
            'validamos en terminal 
            If String.IsNullOrWhiteSpace(TerminalActivo.codTerminal) Then
                MsgBox("No este determidado el terminal " + vbNewLine + "Reinicie la aplicacion", MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If
            Dim i As Integer = 0
            ' eliminamos los datos temporates
            Elimina_DatoTemporal()
            Pagos.num_pago = Busca_New_NumDoc()
            Pagos.fech_Pago = datePago.Value
            Pagos.idPago = idPago
            Pagos.loginUser = UsuarioActivo.codUser
            Pagos.idCliente = IdPeople
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
            sql = "Insert into [tmp].[CobroTmp] (codUser,codTerminal,idCobro,val_Cobrado,idBanco,Num_Documento) "
            sql = sql & "Values (@codUser,@codTerminal, @idCobro, @val_Cobrado,@idBanco,@Num_Documento) "
            Using cnn As New SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser

                    cmd.Parameters.Add("@codTerminal", SqlDbType.VarChar, 8)
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal

                    cmd.Parameters.Add("@idCobro", SqlDbType.Int)
                    cmd.Parameters("@idCobro").Value = idFactur

                    cmd.Parameters.Add("@val_Cobrado", SqlDbType.Decimal, 18, 2)
                    cmd.Parameters("@val_Cobrado").Value = Pagos.val_Pagado

                    cmd.Parameters.Add("@idBanco", SqlDbType.Int)
                    cmd.Parameters("@idBanco").Value = Pagos.idBancoCuenta  'Num_Documento

                    cmd.Parameters.Add("@Num_Documento", SqlDbType.VarChar, 15)
                    cmd.Parameters("@Num_Documento").Value = Pagos.Num_Documento 'Num_Documento
                    If cmd.ExecuteNonQuery() = 1 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
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
    Private Function TrasfierePago() As Boolean
        Try
            Dim cn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
            AddHandler cn.InfoMessage, AddressOf cn_InfoMessage
            Try
                cn.Open()
                TerminalActivo.idCajaStado = 0

                Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
                If myTerminalActivo.Success Then
                    TerminalActivo.idCajaStado = myTerminalActivo.IdStadoCaja
                Else
                    Return False
                End If

                If TerminalActivo.idCajaStado = 0 Then
                    MsgBox("No se obtubo el terminal Habil..", MsgBoxStyle.Exclamation, "Importante")
                    Return False
                End If
                Using cmd As New SqlCommand("prcCobroEmployee", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    ' -- numero de pago
                    cmd.Parameters.Add("@NumCobro", SqlDbType.VarChar, 25)
                    cmd.Parameters("@NumCobro").Value = Pagos.num_pago
                    ' -- fecha d
                    cmd.Parameters.Add("@Fech_Pago", SqlDbType.Date)
                    cmd.Parameters("@Fech_Pago").Value = Pagos.fech_Pago
                    ' -- fecha d
                    cmd.Parameters.Add("@Fech_cheq", SqlDbType.Date)
                    cmd.Parameters("@Fech_cheq").Value = Pagos.fech_Cheq
                    ' -- forma de pago
                    cmd.Parameters.Add("@tipo_Pago", SqlDbType.Int)
                    cmd.Parameters("@tipo_Pago").Value = Pagos.idformaPago
                    ' -- persona que cobro
                    cmd.Parameters.Add("@codUser", SqlDbType.VarChar, 8)
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    ' -- cliente a quien se está cobrando
                    cmd.Parameters.Add("@idPeople", SqlDbType.Int)
                    cmd.Parameters("@idPeople").Value = Me.IdPeople
                    ' -- equipo de la que se realizó la operación
                    cmd.Parameters.Add("@codTerminal", SqlDbType.VarChar, 50)
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    ' -- idCajaStado
                    cmd.Parameters.Add("@idCajaStado", SqlDbType.Int)
                    cmd.Parameters("@idCajaStado").Value = TerminalActivo.idCajaStado
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                    sql = cmd.ExecuteNonQuery()
                End Using
                Return False
            Catch ex As SqlException
                MsgBox(ex.Message + " en el modulo TrasfierePago del " + Name, MsgBoxStyle.Critical, "Error")
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

    Private Sub btnCancelPago_Click(sender As Object, e As EventArgs) Handles btnCancelPago.Click
        idPago = 0
        MenuStrip1.Enabled = True
        PanePie.Enabled = True
        SplitContainer1.Panel1.Enabled = True
        PrintTicketPago.Visible = True
        PrintMatricialPago.Visible = True
        lblultimoPago.Dock = DockStyle.Top
        lblultimoPago.Text = "-- Ultimos Pagos --"
        ListViewPago.Visible = True
        lblFormaPago.Visible = False
        lblFormaPago.Dock = DockStyle.None
        PanePieUltimoPago.Visible = False
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PrintTicketPago_Click(sender As Object, e As EventArgs) Handles PrintTicketPago.Click

    End Sub

    Private Sub CambiarValorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CambiarValorToolStripMenuItem.Click
        Try
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
    Private Sub MostrarResumen()
        Try
            With ListViewResum
                .Items(0).UseItemStyleForSubItems = False
                .Items(0).Text = Deuda
                .Items(0).SubItems(1).Text = Pagada
                .Items(0).SubItems(2).Text = Saldo
                .Items(0).SubItems(2).BackColor = System.Drawing.Color.Red
                .Items(0).SubItems(2).Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .Items(0).SubItems(2).ForeColor = System.Drawing.Color.White
                .Items(0).SubItems(3).Text = EnProceso
                .Items(0).SubItems(3).BackColor = Color.Yellow
                .Items(0).SubItems(4).Text = NewSaldo
                .Items(0).SubItems(4).BackColor = Color.GreenYellow
                saltoTotalLabel.Text = String.Format("Saldo actual: {0}", Saldo.ToString("C2"))
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class
