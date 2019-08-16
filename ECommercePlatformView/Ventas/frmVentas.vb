Imports System.Text
Imports System.Threading
Imports BrightIdeasSoftware

Public Class frmVentas
    'Para sumar totales
    Private vueltas As Integer
    Private idRates As Integer
    Private clientRate As Integer
    Private idRateUser As Integer

    Private RatesStruccture As String
    Private RatesTyPe As Boolean
    Private _Rates As Double
    Private isDeleteRates As Boolean
    Private clientPerfilRates As Boolean
    Private ListItemVenta As List(Of ItemViewVenta)


    Dim Cant, PUnt, Descuen, totalFact As Double
    Dim nonNumberEntered As Boolean = False
    Dim Item_Select As Integer = -1

    'para determinar cual es el ultimo ingreso
    Dim counUltimo As Double
    Dim nameProductUltimo As String
    Dim itemUltimoIngreso As Integer
    Dim dtProducItem As DataTable

    'miembros peotegidos
    Protected Friend idPersona As Integer
    Protected Friend idcliente As Integer
    Protected Friend vuelto As Double
    Protected Friend otrosValores As Double
    Public Sub New(Optional _ListItemVenta As List(Of ItemViewVenta) = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not IsNothing(_ListItemVenta) Then
            ListItemVenta = _ListItemVenta
        Else
            ListItemVenta = New List(Of ItemViewVenta)
        End If
        InitializeComponests()
    End Sub
    Private Sub InitializeComponests()
        Dim rbd As RowBorderDecoration = New RowBorderDecoration()
        rbd.BorderPen = New Pen(Color.FromArgb(128, Color.LightSeaGreen), 1)
        rbd.BoundsPadding = New Size(1, 1)
        rbd.CornerRounding = 4.0F

        ''// Put the decoration onto the hot item
        Me.ObjectListView1.HotItemStyle = New HotItemStyle()
        Me.ObjectListView1.HotItemStyle.Decoration = rbd

        TotalPriceClm.ImageGetter = Function(ByVal row As Object)
                                        Dim p As ItemViewVenta = CType(row, ItemViewVenta)
                                        If Not IsNothing(p) Then
                                            If p.TotalPrice = 0 Then
                                                Return 0
                                            Else
                                                Return -1
                                            End If
                                        Else
                                            Return -1
                                        End If
                                    End Function
    End Sub


    Private Sub frmVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'carga de lista de productos y tarifas
            GetListDataProduct()
            'cargamos bodega en la que manejará el stock

            'caraga cliente predeterminado
            CargaConsumidFinal()
            'oculta tarifario de otros valores

            Mays()
            'initializa properties
            Me.ObjectListView1.SetObjects(Me.ListItemVenta)
            If Me.ListItemVenta.Count > 0 Then
                SumatoriaTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el frmDiario_Load del " + Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Async Sub GetListDataProduct()
        Await GetRates(TerminalActivo.idRates)
        Await GetListVendibles(DeFaultRates.RatesStruccture, DeFaultRates.IDRates)
        View_Bodega()
        ViewRates()
    End Sub

    Private Sub View_Bodega()
        Try
            If TerminalActivo.idBodega > 0 Then
                lblBodega.Text = "Despachar desde:" & vbCrLf & TerminalActivo.Nom_Bodega
                OperacionNumLabel.Text = "Operacion:" & vbCrLf & TerminalActivo.idCajaStado
                User_operaLabel.Text = "Para:" & TerminalActivo.Onwer
            Else
                MsgBox("Es posible que este equipo no esté registrado o no tenga asignado una Bodega o Local a la que debe manejar el Stock.", MsgBoxStyle.Exclamation, "Importante")
                FacturaButton.Enabled = False
                NotaVentaButton.Enabled = False
                ProformaButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " En " + ex.StackTrace.ToString(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CargaConsumidFinal()
        Try
            Me.idPersona = 0
            Me.idcliente = 0
            Using db As New DataContext
                Dim _client = (From p In db.Personas
                               Join c In db.Clientes On p.idPersona Equals c.idPersona
                               Where p.Ruc_Ci = "9999999999999").Take(1)

                For Each item In _client
                    Me.idcliente = item.c.idCliente
                    CedulaTextBox.Text = String.Empty
                    NomClienteText.Text = item.p.Apellidos & " " & item.p.Nombre
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SumatoriaTotal()
        Try
            Call MostrarTotal()
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Agrega_Fila() As Boolean
        Dim totalCantidad As Double = 0
        Dim descuento As Double = 0
        Dim tarifa As Double = 0
        Dim fila As Integer = 0
        Try
            Dim Cantidad As Double = Double.Parse(txtCantidad.Text)
            If Cantidad = 0 Then
                Cantidad = 1
            End If

            'rebisamos si no es codigo munerico entonces es barra de codigo
            Dim isnumric As Boolean = True
            Dim isCoode As Boolean = False
            For Each texto In txtExploret.Text
                If InStr("0123456789", texto) = False Then
                    isnumric = False
                    Exit For
                End If
            Next
            'si es codigo de barra busco  ************
            Dim listData As New List(Of PresentVendiblescollection)
            If isnumric Then
                listData = ListVendiblescollection.Where(Function(x) x.Barcode.Trim() = txtExploret.Text.Trim()).ToList()
            ElseIf isCoode Then
                listData = ListVendiblescollection.Where(Function(x) x.CodProducto = txtExploret.Text).ToList()
            End If

            If Not (listData.Count = 1) Then
                Using fornew As New frmList_ProductPrecioVenta()
                    With fornew
                        .flag = "Ventas"
                        .txtProduc_Select.Text = Me.txtExploret.Text
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            listData = ListVendiblescollection.
                               Where(Function(x) x.IdPresent = .idPresent).ToList()
                            If listData.Count = 1 Then
                                GoTo Agrega_Item
                            Else
                                sql = "El producto no esta en la lista de vendibles" & vbCrLf & vbCrLf
                                sql = sql & "Es posible que este desactivado."
                                MsgBox(sql, MsgBoxStyle.Information, "Aviso")
                                Return False
                            End If
                        Else
                            Return False
                        End If
                    End With
                End Using
            End If
Agrega_Item:
            'Buscamos si ya emos ingreasado el idPresentacion para modificar la cantidad *********************************************************************
            Dim i As Integer = 0
            Dim item = Me.ListItemVenta.Where(Function(x) x.IdPresent =
                       listData.FirstOrDefault().IdPresent).FirstOrDefault()
            ' modificao y salgo....
            If Not IsNothing(item) Then
                Dim index = ObjectListView1.IndexOf(item)

                item.Cuantity += Cantidad
                item.UnitPrice = listData.FirstOrDefault().PrecioVenta
                If Me.idRates > 0 Then
                    If item.Cuantity >= listData.FirstOrDefault().FromC Then
                        If Me.RatesTyPe Then
                            item.Discount = Redondear((item.Cuantity * item.UnitPrice) * listData.FirstOrDefault().RatesPercent, 2, True)
                        Else
                            item.Rates = Redondear((item.Cuantity * item.UnitPrice) * listData.FirstOrDefault().RatesPercent, 2, True)
                        End If
                    End If
                End If
                'ulltima cantidad
                counUltimo = item.Cuantity
                nameProductUltimo = item.Nom_Comercial
                itemUltimoIngreso = index

                If Not (Me.idRates > 0) Then
                    CalOfertas(item)
                End If
                Me.ObjectListView1.SetObjects(Me.ListItemVenta)
                Return True
            End If

            ' a qui se agraga  un nuevo producto (solo si no encontre)
            If Me.idRates > 0 Then
                If Cantidad >= listData.FirstOrDefault().FromC Then
                    If Me.RatesTyPe Then
                        descuento = Redondear((Cantidad * listData.FirstOrDefault().PrecioVenta) * listData.FirstOrDefault().RatesPercent, 2, True)
                    Else
                        tarifa = Redondear((Cantidad * listData.FirstOrDefault().PrecioVenta) * listData.FirstOrDefault().RatesPercent, 2, True)
                    End If
                End If
            End If

            Dim item2 As New ItemViewVenta(listData.FirstOrDefault().IdPresent,
                                                listData.FirstOrDefault().IdProducto,
                                                listData.FirstOrDefault().CodProducto,
                                                listData.FirstOrDefault().NomComercial,
                                                listData.FirstOrDefault().PresentationPrint,
                                                Cantidad,
                                                listData.FirstOrDefault().PrecioVenta,
                                                descuento,
                                                tarifa,
                                                listData.FirstOrDefault().IvaPercent,
                                                listData.FirstOrDefault().PrecioCompra,
                                                listData.FirstOrDefault().PrecioCompra)
CalculaOfertas:
            If Not (Me.idRates > 0) Then
                CalOfertas(item2)
            End If
            'add to list
            ListItemVenta.Add(item2)
            'add to view
            counUltimo = item2.Cuantity
            nameProductUltimo = item2.Nom_Comercial
            itemUltimoIngreso = Me.ListItemVenta.Count - 1
            Me.ObjectListView1.SetObjects(ListItemVenta)

PintaRepedidas:
            'PintaRepetido(fila, Color.Bisque)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error al calcular los costos")
            Return False
        End Try
    End Function
    Private Function CalOfertas(item As ItemViewVenta) As Boolean
        Try
            item.Discount = 0

            Dim _ofertas = From o In ListOfertas
                           Where o.idPresent = item.IdPresent And o.CantOferta <= item.Cuantity
            If _ofertas.Count > 0 Then
                For Each itemOfer In _ofertas
                    'si el valor de oferta es mayo de 0 para que no produsca erro al dividir
                    If itemOfer.valor_Oferta > 0 Then
                        If itemOfer.Caducidad = True Then
                            Dim ahora As Date = FormatDateTime(Now(), DateFormat.ShortDate)
                            If Date.Parse(itemOfer.fech_Caduce) >= Date.Parse(ahora) Then
                                GoTo Aplicando
                            End If
                        Else
                            GoTo Aplicando
                        End If
                    End If
                Next
                Return True
Aplicando:
                'bamos aplicar el descuento ******************************************************************************************
                item.Discount = Redondear((item.Cuantity * item.UnitPrice) * _ofertas.FirstOrDefault().valor_Oferta, 2, True)
                Beep()
                Return True
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al calcular OFERTAS")
            Return False
        End Try
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtExploret.Text = Trim(txtExploret.Text)
        'si  no tengo nada regreso
        If Not (txtExploret.Text.Length > 2) Then
            Return
        End If
        'preparamos el texto
        Dim isSpace As Boolean = False
        sql = ""
        For Each stri In txtExploret.Text
            If Not isSpace Then
                sql += stri
                isSpace = False
            End If
            If String.IsNullOrWhiteSpace(stri) Then
                isSpace = True
            Else
                If isSpace Then
                    sql += stri
                End If
                isSpace = False
            End If
        Next
        txtExploret.Text = sql
        If Agrega_Fila() Then
            SumatoriaTotal()
            txtCantidad.Text = 0
            txtExploret.Text = ""
            ObjectListView1.MultiSelect = False
            ObjectListView1.Items(itemUltimoIngreso).EnsureVisible()
            ObjectListView1.Items(itemUltimoIngreso).Selected = True
            ObjectListView1.MultiSelect = True
            txtExploret.Focus()
            ProformaButton.Enabled = True
            PanefinalizFactur.Enabled = False
            Me.UltimoIngresoLabel.Text = String.Format("Ultimo ingreso: {0} | {1}", Me.counUltimo.ToString("N2"), Me.nameProductUltimo)
            '  Beep()   ' Sound a tone.
        End If
    End Sub
    Private Sub MostrarTotal()
        Try
            Dim _totalPriceVat = Aggregate item In ListItemVenta
                          Into Sum(item.PriceVat)

            Dim _totalDiscount = Aggregate item In ListItemVenta
                          Into Sum(item.Discount)

            Dim _totalBase0 = Aggregate item In ListItemVenta
                                  Where (item.IvaPercent = 0)
                                   Into Sum(item.TotalPrice)

            Dim _totalBase12 = Aggregate item In ListItemVenta
                                   Into Sum(item.BaseVat)

            _Rates = Aggregate item In ListItemVenta
                                   Into Sum(item.Rates)

            totalFact = 0
            For Each item In ListItemVenta
                totalFact += Redondear(item.TotalPrice, 2, True)
            Next
            If otrosValores > 0 Then
                totalFact += otrosValores
                Me.lblOtrosValoresView.Visible = True
            Else
                Me.lblOtrosValoresView.Visible = False
            End If

            lblItemsTotal.Text = "Total items:  " & ListItemVenta.Count
            lblIva.Text = "Iva: " & _totalPriceVat.ToString("C2")
            lbldescuento.Text = "Total descuento: " & _totalDiscount.ToString("C2")
            lblIva0.Text = "Base 0%  : " & _totalBase0.ToString("C2")
            lblIva12.Text = lblIva12.Tag & _totalBase12.ToString("C2")
            lbltotal.Text = "Total: " & totalFact.ToString("C2")

            If _Rates > 0 Or otrosValores > 0 Then
                Dim newRates As Double = _Rates + otrosValores
                lblOtrosValoresView.Visible = True
                lblOtrosValoresView.Text = String.Format("Aplicando valor adicional: {0}", newRates.ToString("C2"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtCantidad_GotFocus(sender As Object, e As System.EventArgs) Handles txtCantidad.GotFocus
        sender.Select(0, Len(sender.Text))
    End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As System.EventArgs) Handles txtCantidad.LostFocus
        LostDefaulBnt(Me.btnAgregar)

    End Sub 'textBox1_KeyPress


    Private Sub txtCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidad.TextChanged
        Me.AcceptButton = Me.btnAgregar
    End Sub
    Private Sub LostDefaulBnt(ByVal myDefaultBtn As Button)
        Me.AcceptButton = Nothing
    End Sub
    Private Sub btnAddFactura_Click(sender As System.Object, e As System.EventArgs) Handles FacturaButton.Click, ProformaButton.Click, NotaVentaButton.Click, pedidoButton.Click
        Try
            Color_Control()
            If Procesa_Datos(sender.tag) Then
                PanefinalizFactur.Enabled = True
                sender.backColor = Color.Yellow
                btnPago.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Color_Control()
        Try
            SumatoriaTotal()
            For Each con In TableFactur.Controls
                If TypeOf (con) Is Button Then
                    con.UseVisualStyleBackColor = True
                ElseIf TypeOf (con) Is Label Then
                    con.Backcolor = Color.FromName("Control")
                End If
            Next
            Me.txtFormaPago.Text = String.Empty
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function Procesa_Datos(documento As String) As Boolean
        Try
            FacturVenta.nameDocunt = documento
            If itemsXFactur(nameDocument:=documento) Then
                txtNumFactur.Text = sql
            End If

            If Not documento.ToString.Contains("Pedido") Then
                If Determina_formaPago(documento) Then

                End If
            End If
            Return PreviewFactura()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Sub menuEliminar_Click(sender As Object, e As System.EventArgs) Handles menuEliminar.Click
        btnDeleteItems.PerformClick()
    End Sub

    Private Sub ObjectListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ObjectListView1.SelectedIndexChanged
        Try
            If Me.ObjectListView1.SelectedObjects.Count = 1 Then
                btnEditCant.Enabled = True
                btnPacketProdcut.Enabled = True
                btnUp.Enabled = True
                btnDow.Enabled = True
            Else
                btnEditCant.Enabled = False
                btnPacketProdcut.Enabled = False
                btnUp.Enabled = False
                btnDow.Enabled = False
            End If
            'para boton eliminar
            If Me.ObjectListView1.SelectedObjects.Count > 0 Then
                btnDeleteItems.Enabled = True
            Else
                btnDeleteItems.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub menuCantidad_Click(sender As Object, e As System.EventArgs) Handles menuCantidad.Click
        btnEditCant.PerformClick()
    End Sub

    Private Sub menuPTotal_Click(sender As Object, e As System.EventArgs) Handles menuPTotal.Click
        Try
            If Not (Me.ObjectListView1.SelectedObjects.Count = 1) Then
                Return
            End If

            Dim item = CType(ObjectListView1.SelectedObject, ItemViewVenta)

            Dim index As Integer = 0
            If IsNothing(item) Then
                Return
            End If
            index = ObjectListView1.IndexOf(item)

            Using newform As New LoginForm(stateReturn._response, "Ventas")
                With newform
                    .Text = "Validando para midificar"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Using newfom2 As New frmImputData()
                            With newfom2
                                .txtNumber.Value = item.TotalPrice
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    item.UnitPrice = (.txtNumber.Value - item.Discount + item.Rates) / item.Cuantity
                                    item.DoNotUpdate = True
                                    Me.ObjectListView1.SetObjects(Me.ListItemVenta)
                                    Me.ObjectListView1.SelectObject(item, True)
                                    SumatoriaTotal()
                                End If
                            End With
                        End Using
                    End If
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = DefaultCursor
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmVentaDiario_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.ListItemVenta.Count > 0 Then
            If MsgBox("Existe información sin guardar." & vbCrLf &
                      "Desea salir de todas maneras", MsgBoxStyle.Exclamation +
                      MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Alerta") = MsgBoxResult.Yes Then
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub btnPacketProdcut_Click(sender As Object, e As EventArgs) Handles btnPacketProdcut.Click
        Try
            If Not ObjectListView1.SelectedObjects.Count = 1 Then
                Return
            End If

            Dim itemSelect = CType(ObjectListView1.SelectedObject, ItemViewVenta)

            If IsNothing(itemSelect) Then
                Return
            End If

            Dim index = ObjectListView1.IndexOf(itemSelect)

            Using fornew As New frmProductoPresentacion()
                With fornew
                    .flag = "Operando"
                    .lblProducto.Text = itemSelect.Nom_Comercial
                    .idproducto = itemSelect.IdProducto
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        Dim listData As PresentVendiblescollection =
                             ListVendiblescollection.Where(Function(x) x.IdPresent = .idpresentacion).FirstOrDefault()
                        If listData.IdPresent = .idpresentacion Then
                            itemSelect.AveragePrice = listData.PrecioCompra
                            itemSelect.CodProducto = listData.CodProducto
                            itemSelect.IdPresent = listData.IdPresent
                            itemSelect.IdProducto = listData.IdProducto
                            itemSelect.IvaPercent = listData.IvaPercent
                            itemSelect.LastPurchasePrice = listData.PrecioCompra
                            itemSelect.Nom_Comercial = listData.NomComercial
                            itemSelect.PresentationPrint = listData.PresentationPrint
                            itemSelect.UnitPrice = listData.PrecioVenta
                        End If
                        If Me.idRates > 0 Then
                            Me.ApplicationRates(itemSelect)
                        Else
                            CalOfertas(itemSelect)
                        End If
                        Me.ObjectListView1.SetObjects(Me.ListItemVenta)
                        Me.ObjectListView1.SelectedIndex = index
                        SumatoriaTotal()
                    End If
                End With
            End Using

        Catch ex As Exception
            MsgBox(ex.Message + " " + ex.Source.ToString, MsgBoxStyle.Critical, "Error")
        Finally
            Me.ObjectListView1.Focus()
        End Try
    End Sub
    Private Sub btnDeleteItems_Click(sender As Object, e As EventArgs) Handles btnDeleteItems.Click
        Try

            If Me.ObjectListView1.SelectedObjects.Count = 0 Then
                MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Dim isConfirmate As Boolean
            If EcommerceActive.RequestSalesAuthorization Then
                Using newform As New LoginForm(stateReturn._response, "Ventas")
                    With newform
                        .Text = "Validando para Eliminar.."
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            isConfirmate = True
                        End If
                    End With
                End Using
            Else
                isConfirmate = True
            End If
            If isConfirmate Then
                If MsgBox("Está seguro de eliminar Items seleccionados.?",
                                         MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo +
                                         MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then


                    For Each item In Me.ObjectListView1.SelectedObjects
                        Dim obj = CType(item, ItemViewVenta)
                        If Not IsNothing(obj) Then
                            Me.ListItemVenta.Remove(obj)
                        End If
                    Next
                    SumatoriaTotal()
                    Me.ObjectListView1.SetObjects(Me.ListItemVenta)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEditLine_Click(sender As Object, e As EventArgs) Handles btnEditCant.Click
        Try
            If Not ObjectListView1.SelectedObjects.Count = 1 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Dim itemSelect = CType(Me.ObjectListView1.SelectedObject, ItemViewVenta)
            If IsNothing(itemSelect) Then
                Return
            End If


            Dim index = ObjectListView1.IndexOf(itemSelect)

            Using newform As New frmImputData()
                With newform
                    .txtNumber.Value = itemSelect.Cuantity
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If .txtNumber.Value = 0 Then
                            MsgBox("No se puede modificar la canidad a cero." & vbCrLf &
                                   "Puede tomar la opción de Eliminar..", MsgBoxStyle.Exclamation, "Aviso")
                            Return
                        Else
                            itemSelect.Cuantity = .txtNumber.Value
                            If Me.idRates > 0 Then
                                Me.ApplicationRates(itemSelect)
                            Else
                                CalOfertas(itemSelect)
                            End If
                            Me.ObjectListView1.SetObjects(Me.ListItemVenta)
                            Me.ObjectListView1.SelectedIndex = index
                            SumatoriaTotal()
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Me.ObjectListView1.Focus()
        End Try
    End Sub

    Private Sub frmVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            FindClienteButton.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            Call CargaConsumidFinal()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.ListPersonButton.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            Me.btnActualiza.PerformClick()
        ElseIf e.KeyCode = Keys.F6 Then
            btnDeleteItems.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            btnEditCant.PerformClick()
        ElseIf e.KeyCode = Keys.F9 Then
            btnPacketProdcut.PerformClick()
        ElseIf e.KeyCode = Keys.F11 Then
            NotaVentaButton.PerformClick()
        ElseIf e.KeyCode = Keys.F12 Then
            FacturaButton.PerformClick()
        End If
    End Sub
    Private Sub txtExploret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExploret.KeyPress
        If Asc(e.KeyChar) = 42 Then 'solo cuando ingresa * para cambiar cantidad
            Try
                If IsNumeric(Me.txtExploret.Text) Then
                    Dim Cant As Double = Me.txtExploret.Text
                    Me.txtCantidad.Text = Cant
                    txtExploret.Text = ""
                    txtExploret.Focus()
                    e.Handled = True
                Else
                    MsgBox("Para considerar como cantidad deben ser valores numéricos", MsgBoxStyle.Exclamation, "Importante")
                    txtExploret.Focus()
                    e.Handled = True
                End If

            Catch ex As Exception
                MsgBox(ex.Message + " en el btnCantidad_Click del " + Me.Name, MsgBoxStyle.Critical, "Revise que todo sea número")
                txtExploret.Focus()
            End Try
        End If
    End Sub

    Private Sub txtExploret_TextChanged(sender As Object, e As EventArgs) Handles txtExploret.TextChanged
        If txtExploret.TextLength > 0 Then
            AcceptButton = btnAgregar
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Try
            If Not ObjectListView1.SelectedObjects.Count = 1 Then
                Return
            End If

            Dim item As ItemViewVenta = CType(ObjectListView1.SelectedObject, ItemViewVenta)
            If IsNothing(item) Then
                Return
            End If
            Dim index = ObjectListView1.IndexOf(item)

            If index = 0 Then
                ObjectListView1.Focus()
                Return
            End If


            Dim pos As Integer = index - 1
            Me.ListItemVenta.RemoveAt(index)
            Me.ListItemVenta.Insert(pos, item)

            ObjectListView1.SetObjects(Me.ListItemVenta)
            ObjectListView1.SelectObject(item, True)
            ObjectListView1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDow_Click(sender As Object, e As EventArgs) Handles btnDow.Click
        Try
            If Not ObjectListView1.SelectedObjects.Count = 1 Then
                Return
            End If

            Dim item As ItemViewVenta = CType(ObjectListView1.SelectedObject, ItemViewVenta)
            If IsNothing(item) Then
                Return
            End If
            Dim index = ObjectListView1.IndexOf(item)

            If index = (ObjectListView1.GetItemCount - 1) Then
                ObjectListView1.Focus()
                Return
            End If

            Dim pos As Integer = index + 1

            Me.ListItemVenta.RemoveAt(index)
            Me.ListItemVenta.Insert(pos, item)

            ObjectListView1.SetObjects(Me.ListItemVenta)
            ObjectListView1.SelectObject(item, True)
            ObjectListView1.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Async Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If isDeleteRates Then
                Await GetRates(idRateUser)
            ElseIf clientPerfilRates Then
                Await GetRates(clientRate)
            Else
                Me.idRates = TerminalActivo.idRates
                Await GetRates(TerminalActivo.idRates)
            End If

            Await GetListVendibles(DeFaultRates.RatesStruccture, DeFaultRates.IDRates)

            View_Bodega()
            ViewRates()

            ApplicationRates(Me.idRates)
            SumatoriaTotal()
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.ObjectListView1.Focus()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub menuPTotal_Paint(sender As Object, e As PaintEventArgs) Handles menuPTotal.Paint
        If ObjectListView1.SelectedObjects.Count = 1 Then
            sender.enabled = True
        Else
            sender.enabled = False
        End If
    End Sub

    Private Sub menuCantidad_Paint(sender As Object, e As PaintEventArgs) Handles menuCantidad.Paint
        If ObjectListView1.SelectedObjects.Count = 1 Then
            sender.enabled = True
        Else
            sender.enabled = False
        End If
    End Sub
    Private Sub menuEliminar_Paint(sender As Object, e As PaintEventArgs) Handles menuEliminar.Paint
        If Me.ObjectListView1.SelectedObjects.Count > 0 Then
            sender.enabled = True
        Else
            sender.enabled = False
        End If
    End Sub

    Private Sub btnEdd_NumFactur_Click(sender As Object, e As EventArgs) Handles btnEdd_NumFactur.Click
        Try
            Using fornew As New frmConfFactura()
                With fornew
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        btnUpda_NumFactur.PerformClick()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Determina_formaPago(documento As String) As Boolean
        Try
            totalFact = FormatCurrency(totalFact + otrosValores, 2)
            MostrarTotal()
            If otrosValores > 0 Or _Rates > 0 Then
                Dim newRates As Double = otrosValores + _Rates
                lblOtrosValoresView.Text = String.Format("Aplicando valor adicional: {0}", newRates.ToString("C2"))
                lblOtrosValoresView.Visible = True
            Else
                lblOtrosValoresView.Visible = False
            End If

            If Not Integer.Parse(idcliente) > 0 Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Information, "Aviso")
                Return False
            End If
            'acualizo informcion para creditos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        Try
            If Me.ObjectListView1.Items.Count > 0 Then
                Using fornew As New frmFormaPago()
                    FacturVenta.OtroValor = 0
                    With fornew
                        .flag = "Clientes"
                        .idcliente = idcliente
                        .txtNom_Persona.Text = NomClienteText.Text
                        .txtMontoMaximo.Text = txtMontoMaxito.Text
                        .txtTotal.Text = totalFact
                        .txtPaga.Value = totalFact
                        .ValCaheqtxt.Text = totalFact
                        .txtCreditoActual.Text = totalFact
                        If .InitialityMenu Then
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                FacturVenta.OtroValor = Me.otrosValores
                                Pagos.idformaPago = .idFormaPago
                                txtFormaPago.Text = .MsgBoxRetur.ToString()
                                lblVuelto.Text = "Cambio $: " & .Vuelto
                                Return True
                            End If
                        End If
                    End With
                End Using
            Else
                MsgBox("No existe items para determinar pago ", MsgBoxStyle.Information, "Aviso")
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub btnOtroValor_Click(sender As Object, e As EventArgs) Handles btnOtroValor.Click
        '  Me.ContextMenuOtroValor.Show()
    End Sub
    Private Sub OtroValorSelect(selectItem As String)
        Try
            otrosValores = 0
            Select Case selectItem.ToString
                Case "Ninguno"
                    otrosValores = 0
                Case "Otro valor"
                    Using fornew As New frmImputData
                        With fornew
                            .txtNumber.Value = otrosValores
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                otrosValores = .txtNumber.Value
                            End If
                        End With
                    End Using
                Case Else
                    otrosValores = Strings.Right(selectItem.ToString, 1)
            End Select
            SumatoriaTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub UltDocumentButton_Click(sender As Object, e As EventArgs) Handles UltDocumentButton.Click
        Using frm As New frmUltDocument(frmUltDocument.stateLoad.PrintNot)
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnCancelFactur_Click(sender As Object, e As EventArgs) Handles btnCancelFactur.Click
        Color_Control()
        TableFactur.Enabled = True
        txtFormaPago.Text = String.Empty
        lblVuelto.Text = String.Empty
        PanefinalizFactur.Enabled = False
        AcceptButton = Nothing
        CancelButton = Nothing
    End Sub
    Private Function PreviewFactura() As Boolean
        Try
            If Not Me.ObjectListView1.Items.Count > 0 Then
                MsgBox("No hay información para guardar", MsgBoxStyle.Exclamation, "Error")
                Return False
            End If
            Using db As New DataContext
                Dim _ventasTmp = From v In db.VentasTmp
                                 Where v.codTerminal = TerminalActivo.codTerminal _
                                 And v.codUser = UsuarioActivo.codUser

                For Each item In _ventasTmp
                    db.VentasTmp.DeleteOnSubmit(item)
                Next

                For Each item In ListItemVenta
                    Dim _ventas As New VentasTmp With
                        {
                            .cant = item.Cuantity,
                            .codTerminal = TerminalActivo.codTerminal,
                            .codUser = UsuarioActivo.codUser,
                            .descuento = item.Discount,
                            .idPresent = item.IdPresent,
                            .ivaPorcentaje = item.IvaPercent,
                            .prec_Compra = item.LastPurchasePrice,
                            .prec_Venta = Redondear(item.TotalPrice, 2),
                            .tarifa = item.Rates
                        }
                    db.VentasTmp.InsertOnSubmit(_ventas)
                Next
                db.SubmitChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + " en el PreviewFacturDatos " + Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub PreviewFacturControl()
        TableFactur.Enabled = False
        PanefinalizFactur.Enabled = True
        AcceptButton = btnPago
        CancelButton = btnCancelFactur
    End Sub
    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        'si tengo terminal habierto
        Dim responTerminal As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
        If Not responTerminal.Success Then
            Return
        Else
            TerminalActivo.idCajaStado = responTerminal.IdStadoCaja
        End If
        responTerminal = Nothing

        If Genera_Venta() Then
            clientPerfilRates = False
            isDeleteRates = False
            GetListDataProduct()
            ObjectListView1.ClearObjects()
            ListItemVenta.Clear()
            Me.UltimoIngresoLabel.Text = String.Empty
            MostrarTotal()
            txtFormaPago.Text = String.Empty
            lblVuelto.Text = String.Empty
            PanefinalizFactur.Enabled = False
            Color_Control()
            Me.Cursor = Cursors.Default
            txtExploret.Focus()
        End If

    End Sub
    Private Function Genera_Venta() As Boolean
        Try
            Dim identity As Integer = 0
            Cursor = Cursors.WaitCursor
            FacturVenta.fechDesde = Now
            FacturVenta.fechHasta = Now
            FacturVenta.idBodega = TerminalActivo.idBodega
            FacturVenta.idCliente = idcliente
            ' determino el tipo de proceso
            If FacturVenta.nameDocunt = "Pedido" Or FacturVenta.nameDocunt = "Proforma" Then
                identity = Procesa_Proforma()
                If identity > 0 Then
                    sql = "!.. " & FacturVenta.nameDocunt & " generada correctamente..!" & vbNewLine
                    sql = sql & "Desea imprimir el documento en Impresora de Ticket..?"
                    Me.Cursor = Cursors.WaitCursor
                    'SET THE DATA CLIENT
                    ClienteActivo.Ruc = CedulaTextBox.Text
                    ClienteActivo.Nombres = NomClienteText.Text
                    ClienteActivo.Direcc = NomClienteText.Tag
                    If (MsgBox(sql, MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1) = vbYes) Then
                        Print_Proforma(identity, FacturVenta.nameDocunt)
                    End If
                    Return True
                End If
            Else  'si es venta o nota de venta
                'reviso si tiene numero de operación 
                Dim stado As Boolean = False
                If IsNumeric(OperacionNumLabel.Tag) Then
                    If Not (Convert.ToInt32(OperacionNumLabel.Tag) = 0) Then
                        stado = True
                    End If
                End If

                If Not (Procesa_Venta()) Then
                    Return False
                End If
                sql = "!..Proceso ejecutado correctamente..!" & vbNewLine
                sql = sql & "Desea imprimir el documento en Impresora " & myOptnsPrint.typePrint & " " & myOptnsPrint.NamePrint
                If Not (MsgBox(sql, MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1) = vbYes) Then
                    Return True
                End If
                Me.Cursor = Cursors.WaitCursor
                Select Case myOptnsPrint.typePrint
                    Case "Ticket"
                        Dim print As New PrintTicketAsync(New CancellationTokenSource)
                        print.ActionToExecute = Sub() print.Print_Ticket(0, True,
                              "",
                              isInvoiceElectronic:=False)
                        print.Star()
                    Case "Matricial"
                        printMatricial(FacturVenta.nameDocunt, idDocument:=0, isLatest:=True)
                    Case "Tinta"
                End Select
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindClienteButton.Click
        Try
            Dim st1 As String = String.Empty
            Dim st2 As String = String.Empty
            Dim st3 As String = String.Empty
            Dim isInsert As Boolean = False
            Dim isEmpy As Boolean = False
            Dim count As Integer = 0
            For Each texto In CedulaTextBox.Text
                If Not String.IsNullOrWhiteSpace(texto) Then
                    If isInsert And isEmpy Then
                        count += 1
                    End If

                    If count > 2 Then count = 2
                    isInsert = False
                    isEmpy = False
                    Select Case count
                        Case 0
                            st1 = st1 & texto
                            isInsert = True
                        Case 1
                            st2 = st2 & texto
                            isInsert = True
                        Case 2
                            st3 = st3 & texto
                            isInsert = True
                    End Select
                Else
                    isEmpy = True
                End If
            Next
            Dim dt As DataTable = ClsPerson.getDataLikePerson(st1, st2, st3)
            If Not IsNothing(dt) Then
                If dt.Rows.Count = 1 Then
                    idPersona = dt.Rows(0)("idPersona")
                    idcliente = ClsClientes.isClinteBypersonAdmin(idPersona)
                    Carga_Cliente(idcliente)
                    txtExploret.Focus()
                    Return
                End If
                Using ListClient As New frmList_PersonViewTarget(stateLoad.Dialogo)
                    With ListClient
                        .dtPersonas = dt
                        .FindTextBox.Text = CedulaTextBox.Text
                        .StartPosition = FormStartPosition.CenterScreen
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            idPersona = .idPersona
                            idcliente = ClsClientes.isClinteBypersonAdmin(idPersona)
                            Carga_Cliente(idcliente)
                            txtExploret.Focus()
                            Return
                        End If
                        CedulaTextBox.Focus()
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CedulaTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CedulaTextBox.KeyDown
        nonNumberEntered = True
        'SI VIENE NUMEROS
        If e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9 Then
            nonNumberEntered = False
            Return
        End If
        'SI VIENE DEL TECLADO NUMERICO
        If e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9 Then
            nonNumberEntered = False
            Return
        End If

        If e.KeyCode >= Keys.A And e.KeyCode <= Keys.Z Then
            nonNumberEntered = False
            Return
        End If
        'SI VIENE Ñ
        If e.KeyCode = 192 Then
            nonNumberEntered = False
            Return
        End If

        If e.KeyCode = 37 Then
            nonNumberEntered = False
            Return
        End If

        If e.KeyCode = Keys.Back Then
            nonNumberEntered = False
            Return
        End If

        If e.KeyCode = Keys.Space Then
            nonNumberEntered = False
            Return
        End If

    End Sub 'textBox1_KeyDown

    Private Sub CedulaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CedulaTextBox.KeyPress
        If nonNumberEntered Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles deleteClienteButton.Click
        If Not NomClienteText.Text.Contains("CONSUMIDOR FINAL") Then
            Call CargaConsumidFinal()
            Carga_Cliente(Me.idcliente)
        End If
    End Sub

    Private Sub btnOtroValor_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOtroValor.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuOtroValor()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub CedulaTextBox_Leave(sender As Object, e As EventArgs) Handles CedulaTextBox.Leave
        sender.Text = Trim(sender.Text)
    End Sub

    Private Sub CedulaTextBox_TextChanged(sender As Object, e As EventArgs) Handles CedulaTextBox.TextChanged
        If CedulaTextBox.TextLength > 2 Then
            AcceptButton = FindClienteButton
        End If
    End Sub
    Sub Mays()
        CedulaTextBox.CharacterCasing = CharacterCasing.Upper
        Dim labelFac As New Label With {
            .BackColor = Color.Transparent,
            .AutoSize = True,
            .Text = "F10",
            .Location = New Point With {.X = 2, .Y = 2}
        }
        AddHandler labelFac.Click, AddressOf btnAddFactura_Click

        FacturaButton.Controls.Add(labelFac)
        Dim labelNota As New Label With {
           .BackColor = Color.Transparent,
           .AutoSize = True,
           .Text = "F11",
           .Location = New Point With {.X = 2, .Y = 2}
       }
        AddHandler labelNota.Click, AddressOf btnAddFactura_Click

        NotaVentaButton.Controls.Add(labelNota)
        lblIva12.Text = String.Format("Base {0:P0}:", EcommerceActive.IvaPercent)
        lblIva12.Tag = lblIva12.Text
    End Sub

    Private Sub DetailPersonButton_Click(sender As Object, e As EventArgs) Handles DetailPersonButton.Click
        Try
            If Not IsNothing(idPersona) Then
                If idPersona > 0 Then
                    Using addperso As New frmAdd_Personas(stateOperation.Update, idPersona)
                        With addperso
                            .StartPosition = FormStartPosition.CenterScreen
                            .ShowDialog()
                            If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                                idcliente = ClsClientes.isClinteBypersonAdmin(.idPersona)
                                Carga_Cliente(idcliente)
                            End If
                        End With
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ListPersonButton_Click(sender As Object, e As EventArgs) Handles ListPersonButton.Click
        Try
            Using ListClient As New frmList_PersonViewTarget(stateLoad.Dialogo)
                With ListClient
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        idPersona = .PersonClickNamaLabel.Tag
                        idcliente = ClsClientes.isClinteBypersonAdmin(.idPersona)
                        CedulaTextBox.Text = .PersonVisibleNemuClicLabel.Tag
                        NomClienteText.Text = .PersonVisibleNemuClicLabel.Text
                        txtExploret.Focus()
                        Return
                    End If
                    CedulaTextBox.Focus()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Cliente(_idCliente As Integer)
        Dim _idRates As Integer
        clientPerfilRates = False
        Try
            Using db As New DataContext
                Dim client = (From c In db.Clientes
                              Join p In db.Personas On p.idPersona Equals c.idPersona
                              Group Join r In db.ClientesRate On c.idCliente Equals r.idCliente
                                 Into PetList = Group
                              From pet In PetList.DefaultIfEmpty()
                              Where c.idCliente = _idCliente
                              Select p.Apellidos, p.Nombre, p.Ruc_Ci, p.Direccion,
                              IdRates =
                                 If(pet Is Nothing, 0, pet.IdRates))

                If client.Count > 0 Then
                    _idRates = client.FirstOrDefault().IdRates
                    CedulaTextBox.Text = client.FirstOrDefault().Ruc_Ci
                    NomClienteText.Text = client.FirstOrDefault().Apellidos & " " & client.FirstOrDefault().Nombre
                    NomClienteText.Tag = client.FirstOrDefault().Direccion
                End If

                If Not isDeleteRates Or _idRates > 0 Then
                    Dim _rates = (From r In db.Rates Where r.idRates = _idRates)
                    If _rates.Count > 0 Then
                        clientRate = _idRates
                        DeFaultRates.IDRates = Me.idRates
                        DeFaultRates.RatesStruccture = _rates.FirstOrDefault().Structure
                        DeFaultRates.RatesTyPe = _rates.FirstOrDefault().TypeRate
                        clientPerfilRates = True
                    Else
                        clientRate = 0
                        DeFaultRates.IDRates = 0
                        DeFaultRates.RatesStruccture = ""
                        DeFaultRates.RatesTyPe = False
                    End If
                    btnActualiza.PerformClick()
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub findDocumentButton_Click(sender As Object, e As EventArgs) Handles findDocumentButton.Click
        Using Form As New frmList_Facturas()
            With Form
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub creditoButton_Click(sender As Object, e As EventArgs) Handles creditoButton.Click
        Try
            Using newListDebit As New frmList_EmployeeDebit(idPersona)
                With newListDebit
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If InStr(".0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
        'Ascii 
        '8  = Retroceso 
        '58 = dos Puntos Decimales 
        '46 = Punto Decimal 
    End Sub

    Private Sub NomClienteText_TextChanged(sender As Object, e As EventArgs) Handles NomClienteText.TextChanged
        Me.Text = String.Format("VENTAS: {0}", NomClienteText.Text)
    End Sub

    Private Sub BorrarTarifa()
        Me.idRates = 0
        Me.RatesTypeLabel.Text = "Ninguna"
        Me.ApplicationRates(Me.idRates)
        SumatoriaTotal()
    End Sub
    Private Function ApplicationRates(ByVal _idRates As Integer) As Boolean
        Try
            Me.idRates = _idRates
            Dim notUpdate As StringBuilder = New StringBuilder()
            For Each item As ItemViewVenta In ListItemVenta.Where(Function(x) x.DoNotUpdate = False)
                Dim listData = (From l In ListVendiblescollection
                                Where l.IdPresent = item.IdPresent).FirstOrDefault()
                If listData IsNot Nothing Then
                    If item.IdPresent = listData.IdPresent Then
                        item.AveragePrice = listData.PrecioCompra
                        item.CodProducto = listData.CodProducto
                        item.IvaPercent = listData.IvaPercent()
                        item.LastPurchasePrice = listData.PrecioCompra
                        item.Nom_Comercial = listData.NomComercial
                        item.PresentationPrint = listData.PresentationPrint
                        item.UnitPrice = listData.PrecioVenta
                        item.Discount = 0
                        item.Rates = 0
                        If Me.idRates > 0 Then
                            If item.Cuantity >= listData.FromC Then
                                If Me.RatesTyPe Then
                                    item.Discount = Redondear((item.Cuantity * item.UnitPrice) * listData.RatesPercent, 2, True)
                                Else
                                    item.Rates = Redondear((item.Cuantity * item.UnitPrice) * listData.RatesPercent, 2, True)
                                End If
                            End If
                        Else
                            CalOfertas(item)
                        End If
                    End If
                Else
                    notUpdate.Append(vbCrLf)
                    notUpdate.Append(item.Nom_Comercial)
                End If

            Next
            If Not String.IsNullOrEmpty(notUpdate.ToString()) Then
                sql = "Hay productos que ya no esta en la lista de Vendibles." & vbCrLf
                MsgBox(sql & notUpdate.ToString() & vbCrLf &
                      "A estos no se pudo actualizar.", MsgBoxStyle.Information, "Aviso..")
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.ObjectListView1.SetObjects(Me.ListItemVenta)
        End Try
    End Function

    Private Function ApplicationRates(ByVal item As ItemViewVenta) As Boolean
        Try
            Dim listData = (From l In ListVendiblescollection
                            Where l.IdPresent = item.IdPresent).FirstOrDefault()
            If item.IdPresent = listData.IdPresent Then
                item.AveragePrice = listData.PrecioCompra
                item.CodProducto = listData.CodProducto
                item.IvaPercent = listData.IvaPercent()
                item.LastPurchasePrice = listData.PrecioCompra
                item.Nom_Comercial = listData.NomComercial
                item.PresentationPrint = listData.PresentationPrint
                item.UnitPrice = listData.PrecioVenta
                item.Discount = 0
                item.Rates = 0

                If item.Cuantity >= listData.FromC Then
                    If Me.RatesTyPe Then
                        item.Discount = Redondear((item.Cuantity * item.UnitPrice) * listData.RatesPercent, 2, True)
                    Else
                        item.Rates = Redondear((item.Cuantity * item.UnitPrice) * listData.RatesPercent, 2, True)
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub DeleteRatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRatesToolStripMenuItem.Click
        Try
            Using newform As New LoginForm(stateReturn._response, "Ventas")
                With newform
                    .Text = "Validando para eliminar tarifa.."
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        idRateUser = 0
                        isDeleteRates = True
                        BorrarTarifa()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub RatesTypeLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RatesTypeLabel.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Right) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuDeleteRates()
            Menu.Show(Cursor.Position)
        End If
    End Sub
    Private Sub ToolStripMenuItemUnDolar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemUnDolar.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub
    Private Sub ToolStripMenuItemDos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemDosDolar.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub
    Private Sub ToolStripMenuItemTres_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTresDolar.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub
    Private Sub ToolStripMenuItemCuatro_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemCuatroDolra.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub

    Private Sub VerEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerEstadoToolStripMenuItem.Click
        Try
            Dim idCajastado As Integer = 0
            Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
            If myTerminalActivo.Success Then
                Dim myidCajaStado As ResponseTerminal
                myidCajaStado = Carga_idCajaStado(myTerminalActivo.DataDb)
                If Not myidCajaStado.Success Then
                    Return
                End If
                idCajastado = myidCajaStado.IdStadoCaja
                myidCajaStado = Nothing
            End If

            If idCajastado > 0 Then
                Using mycaja As New MDIcajas(idCajastado, viewLoadReport.Select_)
                    With mycaja
                        .ShowDialog()
                    End With
                End Using
            End If
            myTerminalActivo = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SalidaDeEfecctivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeEfecctivoToolStripMenuItem.Click
        Try
            Cursor = Cursors.WaitCursor
            If PerfilesSalida("Efectivo") Then
                Using frmAdminmonedas As New frmAdminMoney
                    With frmAdminmonedas
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            Using frmExltmoney As New frmExitMoney(TerminalActivo.idBodega, .TotalMoney,
                                                                   TerminalActivo.idCajaStado, Pagos.idformaPago)
                                With frmExltmoney
                                    .ShowDialog()
                                    If .DialogResult = DialogResult.OK Then
                                        If LoadOptionsPrint("Recibo salida divisas") Then
                                            If MsgBox("Desea imprimir el recibo en " & myOptnsPrint.NamePrint, MsgBoxStyle.Information + MsgBoxStyle.YesNo +
                                                 MsgBoxStyle.DefaultButton1, "Aviso") = MsgBoxResult.Yes Then
                                                PrintReciboTerminal(.IdCaja, myOptnsPrint)
                                            End If
                                        End If
                                    End If
                                End With
                            End Using
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Function PerfilesSalida(formaPafo As String) As Boolean
        Try
            If Not GetIdFormaPago(formaPafo) Then
                Return False
            End If

            TerminalActivo.idCajaStado = 0
            Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
            If myTerminalActivo.Success Then
                Dim myidCajaStado As ResponseTerminal
                myidCajaStado = Carga_idCajaStado(myTerminalActivo.DataDb)
                If Not myidCajaStado.Success Then
                    Return False
                End If
                TerminalActivo.idCajaStado = myidCajaStado.IdStadoCaja
                myidCajaStado = Nothing
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function GetIdFormaPago(v As String) As Boolean
        Try
            Using db As New DataContext
                Dim pago = From p In db.FormaPago
                           Where p.formaPago = v
                For Each item In pago
                    Pagos.idformaPago = item.idformaPago
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub SalidaDeChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeChequesToolStripMenuItem.Click
        Try
            If PerfilesSalida("Cheque") Then

                Using frmExltmoney As New frmExitDocument(TerminalActivo.idBodega, 0,
                                   TerminalActivo.idCajaStado, Pagos.idformaPago)
                    With frmExltmoney
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            If LoadOptionsPrint("Recibo salida divisas") Then
                                If MsgBox("Desea imprimir el recibo en " & myOptnsPrint.NamePrint, MsgBoxStyle.Information + MsgBoxStyle.YesNo +
                                     MsgBoxStyle.DefaultButton1, "Aviso") = MsgBoxResult.Yes Then
                                    PrintReciboTerminal(.IdCaja, myOptnsPrint)
                                End If
                            End If
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AplicarTarifaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicarTarifaToolStripMenuItem.Click

        Try
            Using newform As New LoginForm(stateReturn._response, "Supervisor de ventas")
                With newform
                    .Text = "Validando para midificar"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Using newfom2 As New frmList_RatesSelect()
                            With newfom2
                                .OK_Button.Text = "Seleccionar.."
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    Me.idRateUser = .idRates
                                    isDeleteRates = True
                                    btnActualiza.PerformClick()
                                End If
                            End With
                        End Using
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function ViewRates() As Boolean
        Try
            If DeFaultRates.IDRates = 0 Then
                Me.RatesTypeLabel.Text = "Ninguna.."
                Return True
            End If
            Me.idRates = DeFaultRates.IDRates
            Me.RatesStruccture = DeFaultRates.RatesStruccture
            Me.RatesTyPe = DeFaultRates.RatesTyPe
            RatesTypeLabel.Text = "Tarifa:" & vbCrLf & Me.idRates
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub CambioBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioBodegaToolStripMenuItem.Click
        Try
            Using newform As New LoginForm
                With newform
                    .Text = "Validando para midificar"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Using newfom2 As New frmBodegas()
                            With newfom2
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
                                    If myTerminalActivo.Success Then
                                        Carga_idCajaStado(myTerminalActivo.DataDb)
                                        View_Bodega()
                                    End If
                                    myTerminalActivo = Nothing
                                End If
                            End With
                        End Using
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtFindInAdd_TextChanged(sender As Object, e As EventArgs) Handles txtFindInAdd.TextChanged
        txtFindInAdd.VisibleButton = Not String.IsNullOrWhiteSpace(txtFindInAdd.Text)
        Me.TimedFilter(Me.ObjectListView1, txtFindInAdd.Text)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String)
        Me.TimedFilter(olv, txt, 0)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String, ByVal matchKind As Integer)
        Dim filter As TextMatchFilter = Nothing
        If Not String.IsNullOrEmpty(txt) Then
            Select Case matchKind
                Case 0
                    filter = TextMatchFilter.Contains(olv, txt)
                Case 1
                    filter = TextMatchFilter.Prefix(olv, txt)
                Case 2
                    filter = TextMatchFilter.Regex(olv, txt)
            End Select
        End If

        If filter Is Nothing Then olv.DefaultRenderer = Nothing Else olv.DefaultRenderer = New HighlightTextRenderer(filter)
        Dim highlightingRenderer As HighlightTextRenderer = TryCast(olv.GetColumn(0).Renderer, HighlightTextRenderer)
        If highlightingRenderer IsNot Nothing Then highlightingRenderer.Filter = filter
        Dim stopWatch As Stopwatch = New Stopwatch()
        stopWatch.Start()
        olv.AdditionalFilter = filter
        stopWatch.[Stop]()
        Dim objects As IList = TryCast(olv.Objects, IList)
        If objects Is Nothing Then Me.Text = String.Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds) Else Me.Text = String.Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
    End Sub


    Private Sub txtFindInAdd_ButtonClick(sender As Object, e As EventArgs) Handles txtFindInAdd.ButtonClick
        txtFindInAdd.Text = String.Empty
    End Sub
    Private Sub ToolStripMenuItemCinco_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemCincoDolar.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub
    Private Sub ToolStripMenuItemNinguno_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemNinguno.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub
    Private Sub ToolStripMenuItemOtras_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemOtraValor.Click
        OtroValorSelect(DirectCast(sender, ToolStripMenuItem).Text)
    End Sub

End Class
