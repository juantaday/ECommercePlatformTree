Imports CADsisVenta

Public Class frmChildPaymentProvider
    Private DateOrder As Date
    Private DateInvoice As Date
    Private IdProveedor As Integer
    Private MyParet As frmExitMoney
    Public Sub New(_myParent As frmExitMoney)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MyParet = _myParent
        Load_tipoDocumento()
        Load_typoPayment()
        Load_DefaultValues()

    End Sub
    Private Sub frmChildPaymentProvider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Load_DefaultValues()
        Try
            DateInvoice = Nothing
            Me.DateOrderDateTimePicker.Value = Date.Now
            DateOrderTextBox.Text = Date.Now.ToShortDateString()
            DatePaymentTextBox.Text = Date.Now.ToShortDateString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_typoPayment()
        Try
            Using db As New DataContext
                Dim _OrderStatus = From td In db.OrderStatus
                                   Where td.NameState = "Pago anticipado" _
                                       Or td.NameState = "Recibido y pagado"

                If _OrderStatus.Count > 0 Then
                    Me.OrderStatusComboBox.DataSource = _OrderStatus.ToList()
                    Me.OrderStatusComboBox.DisplayMember = "NameState"
                    Me.OrderStatusComboBox.ValueMember = "idOrderStatus"
                    Me.OrderStatusComboBox.SelectedIndex = -1
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_tipoDocumento()
        Try
            Using db As New DataContext
                Dim _typoDocument = From td In db.TypoDocumento

                If _typoDocument.Count > 0 Then
                    Me.TypeDocumentComboBox.DataSource = _typoDocument.ToList()
                    Me.TypeDocumentComboBox.DisplayMember = "Nom_Docu"
                    Me.TypeDocumentComboBox.ValueMember = "idTypoDocu"
                    Me.TypeDocumentComboBox.SelectedIndex = -1
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub DateTimePicker1_DropDown(sender As Object, e As EventArgs) Handles DateOrderDateTimePicker.DropDown
        Try
            If IsNothing(DateOrder) Then
                DateOrderDateTimePicker.Value = DateOrder
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateOrderDateTimePicker.CloseUp
        DateOrderTextBox.Text = DateOrderDateTimePicker.Value.ToShortDateString()
        DateOrder = DateOrderDateTimePicker.Value
    End Sub

    Private Sub DateOrderTextBox_Leave(sender As Object, e As EventArgs) Handles DateOrderTextBox.Leave
        If IsDate(Me.DateOrderTextBox.Text) Then
            DateOrder = Nothing
        End If
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Using listProvider As New frmList_Proveedores(stateLoad.Dialogo, stateClient.User)
                With listProvider
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.IdProveedor = .dataListado.SelectedCells.Item(.dataListado.Columns("idProveedor").Index).Value
                        sql = "(" & Convert.ToString(.dataListado.SelectedCells(.dataListado.Columns("Ruc_Ci").Index).Value) & ") "
                        sql = sql & Convert.ToString(.dataListado.SelectedCells(.dataListado.Columns("Razon_social").Index).Value)
                        ProviderTextBox.Text = sql
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateTimePicker2_DropDown(sender As Object, e As EventArgs) Handles DateInvoiceDateTimePicker.DropDown
        Try
            If IsNothing(DateInvoice) Then
                DateInvoiceDateTimePicker.Value = DateInvoice
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateTimePicker2_CloseUp(sender As Object, e As EventArgs) Handles DateInvoiceDateTimePicker.CloseUp
        DateInvoiceTextBox.Text = DateInvoiceDateTimePicker.Value.ToShortDateString()
        DateInvoice = DateInvoiceDateTimePicker.Value
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If Not Validated_Data() Then
            Return
        End If

        Dim destino As String
        Dim userAurization As String = String.Empty
        Using newform As New LoginForm(stateReturn._response, "Administrador de cajas")
            With newform
                .ShowDialog()
                If Not .DialogResult = DialogResult.OK Then
                    Return
                End If
                userAurization = .UsernameTextBox.Text
                destino = "Pago al proveedor: " & ProviderTextBox.Text & "/ "
                destino = destino & "Tipo de documento: " & TypeDocumentComboBox.Text & "/ "
                destino = destino & "Número de documento: " & NumDocumentTextBox.Text & "/ "
                destino = destino & "Fecha del documento: " & Me.DateInvoiceTextBox.Text & "/ "
                destino = destino & "Por concepto: " & OrderStatusComboBox.Text
            End With
        End Using

        If SavePaymentProvider(userAurization, destino) Then
            MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
            MyParet.DialogResult = DialogResult.OK
            MyParet.Close()
        End If
    End Sub

    Private Function SavePaymentProvider(_UserAutorization As String, _destino As String) As Boolean
        Try


            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim _saldoView = From cs In db.CajaStado
                                     Where cs.idCajaStado = Me.MyParet.IdCajaStado

                    Dim _saldo As Double = 0
                    For Each item In _saldoView
                        _saldo = item.Saldo
                    Next
                    Dim NewSaldo As Double = _saldo - MyParet.MontoDivisa
                    Dim _caja As New Cajas With
                    {
                            .codUserMovi = _UserAutorization,
                            .debe = 0,
                            .Descripcion = _destino,
                            .haber = MyParet.MontoDivisa,
                            .idCajaStado = MyParet.IdCajaStado,
                            .idFormaPago = MyParet.IdFormaPago,
                            .onControl = "IsAdmin",
                            .saldo = NewSaldo,
                            .TypoMovi = 1
                    }
                    db.Cajas.InsertOnSubmit(_caja)
                    db.SubmitChanges()
                    Select Case SatateSystemComboBox.Text
                        Case "A un no he ingresado"
                            Dim _Pedido As New Pedidos With
                            {
                            .base00Iva = 0,
                            .base12Iva = 0,
                            .codUser = UsuarioActivo.codUser,
                            .DateDelivered = Date.Now(),
                            .DateInvoice = DateInvoiceDateTimePicker.Value,
                            .DatePayment = Me.DatePaymentTimePicker.Value,
                            .descuento = 0,
                            .fechaPedido = DateOrderDateTimePicker.Value,
                            .idBodega = TerminalActivo.idBodega,
                            .idOrderStatus = OrderStatusComboBox.SelectedValue,
                            .idProveedor = Me.IdProveedor,
                            .iva = 0,
                            .TotalPedido = MyParet.MontoDivisa
                            }
                            db.Pedidos.InsertOnSubmit(_Pedido)
                            db.SubmitChanges()
                    End Select
                    MyParet.IdCaja = _caja.idCaja
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Validated_Data() As Boolean
        Try
            If Me.IdProveedor = 0 Then
                MsgBox("Seleccione el proveedor..", MsgBoxStyle.Exclamation, "Importante")
                Me.findButton.PerformClick()
                Return False
            End If

            If Me.TypeDocumentComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione  tipo de documento..", MsgBoxStyle.Exclamation, "Importante")
                TypeDocumentComboBox.DroppedDown = True
                TypeDocumentComboBox.Focus()
                Return False
            End If
            Me.NumDocumentTextBox.Text = Trim(Me.NumDocumentTextBox.Text)
            If String.IsNullOrEmpty(Me.NumDocumentTextBox.Text) Then
                MsgBox("Ingrese el número de documento..", MsgBoxStyle.Exclamation, "Importante")
                NumDocumentTextBox.Focus()
                Return False
            End If
            If Me.OrderStatusComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione por que esta pagando..", MsgBoxStyle.Exclamation, "Importante")
                OrderStatusComboBox.DroppedDown = True
                OrderStatusComboBox.Focus()
                Return False
            End If

            If IsNothing(DateOrder) Then
                MsgBox("Determine la fecha de pedido..", MsgBoxStyle.Exclamation, "Importante")
                DateOrderDateTimePicker.Show()
                Return False
            End If

            If OrderStatusComboBox.Text.Contains("Recibido y pagado") Then
                If DateInvoice.Year = 1 Then
                    MsgBox("Determine la fecha de factura..", MsgBoxStyle.Exclamation, "Importante")
                    DateInvoiceDateTimePicker.Show()
                    Return False
                End If
            End If

            If SatateSystemComboBox.SelectedIndex = -1 Then
                MsgBox("Determine el estado de docuemneto en nuestro sistema..", MsgBoxStyle.Exclamation, "Importante")
                SatateSystemComboBox.DroppedDown = True
                SatateSystemComboBox.Focus()
                Return False
            End If
            If Not SatateSystemComboBox.SelectedIndex = 0 Then
                If String.IsNullOrEmpty(NumTransferTextBox.Text) Then
                    MsgBox("Determine el estado de documento en nuestro sistema", MsgBoxStyle.Exclamation, "Importante")
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub DateInvoiceTextBox_Leave(sender As Object, e As EventArgs) Handles DateInvoiceTextBox.Leave
        If IsDate(Me.DateInvoiceTextBox.Text) Then
            DateInvoice = Nothing
        End If
    End Sub
    Private Sub OrderStatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderStatusComboBox.SelectedIndexChanged
        If OrderStatusComboBox.Text.Contains("Pago anticipado") Then
            Me.SatateSystemComboBox.Enabled = False
            Me.SatateSystemLabel.Enabled = False
            NumTransaacionLabel.Enabled = False
            NumTransaccionPanel.Enabled = False
        Else
            Me.SatateSystemComboBox.Enabled = True
            Me.SatateSystemLabel.Enabled = True
            NumTransaacionLabel.Enabled = True
            NumTransaccionPanel.Enabled = True
        End If
    End Sub

    Private Sub SatateSystemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SatateSystemComboBox.SelectedIndexChanged
        If SatateSystemComboBox.Text.Contains("A un no he ingresado") Then
            Me.NumTransaacionLabel.Enabled = False
            Me.NumTransaccionPanel.Enabled = False
        Else
            Me.NumTransaacionLabel.Enabled = True
            Me.NumTransaccionPanel.Enabled = True
        End If
    End Sub

    Private Sub FinTransaccionButton_Click(sender As Object, e As EventArgs) Handles FinTransaccionButton.Click
        Try
            Select Case SatateSystemComboBox.Text
                Case "Ingresado como pedido."
                    SetPedido()
                Case "Ya está contabilizado."
                    SetContabilizado()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SetPedido()
        Try
            Using newPedido As New frmListPedido
                With newPedido
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If Not SetValuesPedidoSeelct(.IdPedido) Then

                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SetValuesPedidoSeelct(_idPedido As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _Facturacompra = From p In db.Pedidos
                                     Join pr In db.Proveedores On p.idProveedor Equals pr.idProveedor
                                     Where p.idPedido = _idPedido
                                     Select New With {p, pr}

                For Each item In _Facturacompra
                    If Me.IdProveedor > 0 And Not (item.p.idProveedor = Me.IdProveedor) Then
                        sql = "El documento seleccionado pertenece o otro proveedor." & vbCrLf & vbCrLf
                        sql = sql & "Desea realizar el cambio.?"
                        If Not (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes) Then
                            Return False
                        End If
                    End If
                    Me.IdProveedor = item.p.idProveedor
                    ProviderTextBox.Text = item.pr.Ruc_Ci & " " & item.pr.Razon_social
                    TypeDocumentComboBox.SelectedIndex = -1

                    DateOrderTextBox.Text = item.p.fechaPedido
                    DateOrderDateTimePicker.Value = item.p.fechaPedido
                    DateOrder = item.p.fechaPedido

                    DateInvoiceTextBox.Text = String.Empty
                    DateInvoice = Nothing

                    OrderStatusComboBox.SelectedIndex = -1

                    NumTransferTextBox.Text = item.p.idPedido
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetValuesFacturSeelct(_idFacturacompra As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _Facturacompra = From f In db.FacturaCompra
                                     Join p In db.Proveedores On p.idProveedor Equals f.idProveedor
                                     Where f.idFacturaCompra = _idFacturacompra
                                     Select New With {f, p}

                For Each item In _Facturacompra
                    If Me.IdProveedor > 0 And Not (item.f.idProveedor = Me.IdProveedor) Then
                        sql = "El documento seleccionado pertenece o otro proveedor." & vbCrLf & vbCrLf
                        sql = sql & "Desea realizar el cambio.?"
                        If Not (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes) Then
                            Return False
                        End If
                    End If
                    Me.IdProveedor = item.f.idProveedor
                    ProviderTextBox.Text = item.p.Ruc_Ci & " " & item.p.Razon_social
                    TypeDocumentComboBox.SelectedValue = item.f.tipo_Doc

                    DateOrderTextBox.Text = item.f.fechaPedido
                    DateOrderDateTimePicker.Value = item.f.fechaPedido
                    DateOrder = item.f.fechaPedido

                    DateInvoiceTextBox.Text = item.f.fechaCompra
                    DateInvoiceDateTimePicker.Value = item.f.fechaCompra
                    DateInvoice = item.f.fechaCompra

                    OrderStatusComboBox.Text = "Recibido y pagado"

                    NumTransferTextBox.Text = item.f.idFacturaCompra
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub SetContabilizado()
        Try

            Using newPedido As New FrmFacturCompProvider(Me.IdProveedor, viewLoadReport.Select_)
                With newPedido
                    .DesProvider = ProviderTextBox.Text
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If Not SetValuesFacturSeelct(.idFacturaCompra) Then
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class