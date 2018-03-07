Imports System.Data.SqlClient
Imports CADsisVenta.DataSetSystemTableAdapters
Imports CADsisVenta.DataSetCompras
Imports CADsisVenta.DataSetComprasTableAdapters
Imports CADsisVenta.ClsSystem
Imports CADsisVenta
Imports MultiColumnComboSuggestionBox.Funtions
Imports BrightIdeasSoftware

Public Class frmAdquisicion
#Region "Atributes"
    Private ListProductProvider As List(Of ProductosByProviderRow)
    Private listAcquisition As List(Of ItemAcquisition)
    Private isSystemController As Boolean
    Private takeNoticeOfSelectionEvent As Boolean
    Private ItemSelectIndex As Integer
    Private dt As ProductosByProviderDataTable
    Private lastedFindText As String
    Private isLoated As Boolean
#End Region
    Public Enum state
        gasto_Personal = 1
        Negocio = 2
        View = 3
    End Enum

    Dim nonNumberEntered As Boolean
    Dim validado, typoCosto As Boolean
    Dim idPresent, id_proveedor, tipoIva, id_Form_Pago, NewPedido, id_Bodega As Integer
    Dim Cant, PUnt, Ptotals, IvaPor, IvaReal, Descuen As Double
    Private Const ivaSi = "Sí"
    Private Const ivaNo = "Nó"
    Protected Friend iniciado As state
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ListProductProvider = New List(Of ProductosByProviderRow)
        listAcquisition = New List(Of ItemAcquisition)

        cmbItemProducto.Tag = 0
    End Sub

    Private Sub frmAdquisicion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If IsNothing(iniciado) Then
            MsgBox("No se ha determinado forma de iniciado ", MsgBoxStyle.Information, "Importante")
            Me.Close()
            Return
        End If

        Inicia_Catalogo()
        Carga_Bodega()
        InitializaComponet()
        isLoated = True
    End Sub

    Private Sub InitializaComponet()

        ListView1.CellEditActivation = ObjectListView.CellEditActivateMode.DoubleClick


        Me.CountClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).Count
        Me.UnitPriceClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).UnitPrice

        idProductoClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).IdProducto

        DiscountClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).Discount
        IvaClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).Iva


        IvaPercentClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).IvaPercent

        TotalParcialClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).TotalParcial

        ProductoClm.AspectGetter = Function(ByVal x As Object) (CType(x, ItemAcquisition)).Producto

        ProductoClm.ImageGetter = Function(ByVal row As Object)
                                      Dim p As ItemAcquisition = CType(row, ItemAcquisition)
                                      If Not IsNothing(p) Then
                                          If p.IvaPercent > 0 Then
                                              Return 19
                                          Else
                                              Return -1
                                          End If
                                      Else
                                          Return -1
                                      End If
                                  End Function


        DateExpireClm.DataType = GetType(Date)
        DateExpireClm.AspectGetter = Function(ByVal row As Object)
                                         Dim p As ItemAcquisition = CType(row, ItemAcquisition)
                                         If Not IsNothing(p) Then
                                             If Not (Date.MinValue = p.DateExpire) Then
                                                 Return p.DateExpire
                                             End If
                                         End If
                                         Return Nothing
                                     End Function

        DateExpireClm.ImageGetter = Function(ByVal row As Object)
                                        Dim p As ItemAcquisition = CType(row, ItemAcquisition)
                                        If Not IsNothing(p) Then
                                            If p.IsExpirate Then
                                                Return 3
                                            Else
                                                Return -1
                                            End If
                                        Else
                                            Return -1
                                        End If
                                    End Function


        IsIncludeIvaClm.ImageGetter = Function(ByVal row As Object)
                                          Dim p As ItemAcquisition = CType(row, ItemAcquisition)
                                          If Not IsNothing(p) Then
                                              If p.IsIncludeIva Then
                                                  Return 18
                                              Else
                                                  Return 7
                                              End If
                                          Else
                                              Return -1
                                          End If
                                      End Function


        Me.ListView1.SetObjects(Me.listAcquisition)

    End Sub

    Public Function Register_inTerminal() As Boolean
inicia:
        Try
            If Not isRegisterInTerminal(Dominio._HotName) Then
                sql = "Equipo no registrado en una estación" & vbNewLine
                sql = sql & "Solicite a su administrador.."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Carga_Bodega() As Boolean
        Try

            Dim tapt As New TerminalTableAdapter
            Dim dt As New DataTable
            dt = tapt.GetDataByDominio(Dominio._HotName)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    id_Bodega = dt.Rows(0)("idBodega")
                    'cargamos terminal
                    With TerminalActivo
                        .idTerminal = dt.Rows(0)("idTerminal")
                        .idBodega = id_Bodega
                        .codTerminal = dt.Rows(0)("CodTerminal")
                        .Dominio = Dominio._HotName
                    End With
                    '//cargamos informcion de la bodega
                    Dim tap_bod As New BodegasTableAdapter
                    dt = tap_bod.GetDataByIdBodega(TerminalActivo.idBodega)
                    If dt.Rows.Count > 0 Then
                        If IsNumeric(dt.Rows(0)("Resp2_idEmpleado")) Then
                            txtidAutorzCheque.Text = dt.Rows(0)("Resp2_idEmpleado")
                        Else
                            txtidAutorzCheque.Text = 0
                        End If
                        lblbodega.Text = "Adquiriendo productos para: " & vbNewLine & dt.Rows(0)("Nom_Bodega")
                        sql = dt.Rows(0)("Des_Bodega") & vbNewLine
                        sql = sql & "Dirección: " & dt.Rows(0)("Direc_Bodega") & vbNewLine
                        sql = sql & "Teléfono: " & dt.Rows(0)("Telef1_Bodega")
                        lblBodega2.Text = sql
                        BodegaLinkLabel.Text = lblbodega.Text + sql
                    End If
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Bodega del " + Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub Inicia_Catalogo()

        If Me.txtFalg.Text = 1 Or iniciado = state.gasto_Personal Then ' Para realizar Pedidos
            tabcontrol.SelectedIndex = 0
            tabcontrol.TabPages(0).Enabled = True
            tabcontrol.TabPages(1).Enabled = False
            tabcontrol.TabPages(2).Enabled = False
        ElseIf Me.txtFalg.Text = 2 Then 'Para comprar pediso
            tabcontrol.TabPages(0).Enabled = False
            tabcontrol.TabPages(1).Enabled = False
            tabcontrol.TabPages(2).Enabled = True
            tabcontrol.SelectedIndex = 2

            Carga_Tipo_Doc()
            Me.cmbTipoDocumento.SelectedIndex = -1
            cmbTipoDocumento.Text = "Selecione...."
        ElseIf Me.txtFalg.Text = 3 Then 'Ver Lista de Pedido
        End If
    End Sub

    Private Sub Carga_Item_Productos(ByVal idProveedor As Integer, Optional idPresentacion As Integer = 0)
        Try
            isSystemController = True
            cmbItemProducto.DataSource = Nothing
            Using dat As New ProductosByProviderTableAdapter
                Using dt As New ProductosByProviderDataTable
                    dat.Fill(dt, Me.id_proveedor)
                    Me.dt = dt
                    ListProductProvider = dt.ToList()
                End Using
            End Using
            With cmbItemProducto
                .DataSource = dt
                .ValueMember = "idPresentacion"
                .DisplayMember = "NomComercial"
            End With
            If idPresentacion > 0 Then
                cmbItemProducto.SelectedValue = idPresentacion
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar Proveedor")

        Finally
            isSystemController = False
        End Try
    End Sub


    Private Sub btnVerProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnVerProducto.Click
        validaItem_Producto()
        If validado Then
            Try
                Dim idProducto As Integer = cmbItemProducto.Items(cmbItemProducto.SelectedIndex).item("idProducto").ToString
                Dim idPresent As Integer = cmbItemProducto.Items(cmbItemProducto.SelectedIndex).item("idPresentacion").ToString
                Using adminProduct As New MDI_AddProductos(stateOperation.Update, idProducto, idProveedor:=id_proveedor)

                    adminProduct.ShowDialog()
                    If adminProduct.DialogResult = DialogResult.OK Then
                        Carga_Item_Productos(id_proveedor, adminProduct.IdPresent_SeCompra)
                        If adminProduct.IdPresent_SeCompra = 0 Then
                            cmbItemProducto.SelectedValue = idPresent
                        Else
                            cmbItemProducto.SelectedValue = adminProduct.IdPresent_SeCompra
                        End If
                        If Me.cmbItemProducto.SelectedIndex >= 0 Then
                            txtCantidad.Focus()
                        End If
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If
    End Sub

    Private Sub validaItem_Producto()
        If cmbItemProducto.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar un producto", MsgBoxStyle.Exclamation, "Alerta")
            cmbItemProducto.Focus()
            validado = False
        ElseIf cmbItemProducto.SelectedIndex >= 0 Then
            validado = True
            idPresent = cmbItemProducto.Items(cmbItemProducto.SelectedIndex).item("idPresentacion").ToString
        Else
            MsgBox("Debe seleccionar un producto", MsgBoxStyle.Exclamation, "Alerta")
            cmbItemProducto.Focus()
            validado = False
        End If
    End Sub
    Private Sub btnNuevoProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoProducto.Click
        Try
            Using frmProductos As New MDI_AddProductos(stateOperation.Insert, 0, id_proveedor)
                frmProductos.ShowDialog()
                If frmProductos.DialogResult = DialogResult.OK Then
                    Carga_Item_Productos(id_proveedor)
                    Me.cmbItemProducto.SelectedValue = frmProductos.IdPresent_SeCompra
                    If Me.cmbItemProducto.SelectedIndex >= 0 Then
                        txtCantidad.Focus()
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnListProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnListProducto.Click
        Try
            Using frmnew As New frmList_ProductoComprable()
                frmnew.idProveedor = id_proveedor
                frmnew.State = _state.Select_
                frmnew.StartPosition = FormStartPosition.CenterScreen
                frmnew.ShowDialog()
                If frmnew.DialogResult = DialogResult.OK Then
                    Carga_Item_Productos(id_proveedor)
                    If frmnew.idPresent > 0 Then
                        cmbItemProducto.SelectedValue = frmnew.idPresent
                        If IsNothing(cmbItemProducto.SelectedValue) Then
                            IsertDefaultPresentProvider(id_proveedor, frmnew.idPresent)
                            If Me.cmbItemProducto.SelectedIndex >= 0 Then
                                txtCantidad.Focus()
                            End If
                        End If
                    End If
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub IsertDefaultPresentProvider(_idPorveedor As Integer, idPresent As Integer)
        Try
            Cursor = Cursors.WaitCursor
            Using db As New DataContext()
                Dim _ProductoProveedor As New ProductoProveedor With
                    {
                        .CostoTotal = 0,
                        .Fech_Compra = Date.Now(),
                        .idPresentacion = idPresent,
                        .idProveedor = _idPorveedor
                   }

                db.ProductoProveedor.InsertOnSubmit(_ProductoProveedor)
                db.SubmitChanges()
                Carga_Item_Productos(_idPorveedor, idPresent)
            End Using
        Catch ex As Exception
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Function Selecion_producto(ByVal iPresentacion As Integer) As Integer
        Try
            Dim dt As DataTable = cmbItemProducto.DataSource
            Dim id As Integer = 0
            For i = 0 To dt.Rows.Count
                If dt.Rows(i)("idPresentacion") = iPresentacion Then
                    Return Integer.Parse(id = dt.Rows(i)("idPresentacion"))
                End If
            Next
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Selecion_producto del frmAdquisicion")
            Return 0
        End Try
    End Function

    Public Sub Carga_Declaracion()
        sql = "select * from Declaracion Order By Nom_declaracion"
        conecta_sql()

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)

                cmbDeclaracion.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With cmbDeclaracion
                        .DataSource = dt
                        .DisplayMember = "Nom_declaracion"
                        .ValueMember = "iddeclaracion"
                    End With
                    dt = Nothing
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el: Carga_Declaracion ")
        End Try
    End Sub


    Private Sub btnAddListaProduc_Click(sender As System.Object, e As System.EventArgs) Handles btnAddListaProduc.Click
        If IsNumeric(txtCantidad.Text) Then
            If Agrega_Items2() Then
                Calcula_Total()
                ListView1.Select()
                ListView1.MultiSelect = False
                If ListView1.Items.Count > 0 Then
                    ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
                    ListView1.Items(ListView1.Items.Count - 1).Selected = True
                    Me.TotalItemsLabel.Text = String.Format("Total items: {0}", ListView1.Items.Count)
                End If
                ListView1.MultiSelect = False
                cmbItemProducto.Select()
                AcceptButton = Nothing
            End If
        End If
    End Sub

    Private Sub menuEmilinar_Click(sender As Object, e As System.EventArgs) Handles menuEmilinar.Click
        Me.DeleteButton.PerformClick()
    End Sub

    Private Sub menuCantidad_Click(sender As Object, e As System.EventArgs) Handles menuCantidad.Click
        If ListView1.SelectedIndices.Count = 1 Then
            Dim count? As Double = CType(ListView1.SelectedObject, ItemAcquisition).Count

            Using formnew As New frmImputData
                With formnew
                    .Text = "Ingrese la CANTIDAD"
                    .txtFlag.Text = 1
                    .txtNumber.Value = count
                    .txtNumber.Visible = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        CType(ListView1.SelectedObject, ItemAcquisition).Count = .txtNumber.Value
                        ListView1.RefreshObjects(Me.listAcquisition)
                        Calcula_Total()
                    End If
                End With
            End Using
        End If
    End Sub



    Private Sub menuDescuento_Click(sender As Object, e As System.EventArgs) Handles menuDescuento.Click
        If ListView1.SelectedIndices.Count = 1 Then
            Dim discount? As Double = CType(ListView1.SelectedObject, ItemAcquisition).Discount
            Using formnew As New frmImputData
                With formnew
                    .Text = "Ingrese el DESCUENTO"
                    .txtFlag.Text = 1
                    .txtNumber.Value = discount
                    .txtNumber.Visible = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        CType(ListView1.SelectedObject, ItemAcquisition).Discount = .txtNumber.Value
                        Calcula_Total()
                        ListView1.RefreshObjects(Me.listAcquisition)
                    End If
                End With

            End Using
        End If

    End Sub
    Private Sub Cambiatotal()
        If ListView1.SelectedIndices.Count = 1 Then
            Using Form As New frmImputData()
                Dim total As Double = CType(Me.ListView1.SelectedObject, ItemAcquisition).TotalParcial
                CType(Me.ListView1.SelectedObject, ItemAcquisition).IsValitedUnitPrice = False
                With Form
                    .Text = "Ingrese el PRECIO TOTAL"
                    .txtFlag.Text = 1
                    .txtNumber.Value = total
                    .txtNumber.Visible = True
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        CType(Me.ListView1.SelectedObject, ItemAcquisition).TotalParcial = .txtNumber.Value
                        Calcula_Total()
                        ListView1.RefreshObjects(Me.listAcquisition)
                    End If
                End With
            End Using
        End If
    End Sub

    Private Sub menuPtotal_Click(sender As Object, e As System.EventArgs) Handles menuPtotal.Click
        Cambiatotal()
    End Sub
    Private Function Agrega_Items2() As Boolean
        Try

            Cant = txtCantidad.Text
            PUnt = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("CostoTotal").ToString()
            IvaPor = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("ivaPorcentaje").ToString()
            Ptotals = FormatNumber(Cant * PUnt, 5)

            If IsIncludeIvaCheckBox.Checked Then
                IvaReal = FormatNumber(Ptotals - (FormatNumber(Ptotals / (1 + IvaPor), 5)), 5)
            Else
                PUnt -= FormatNumber(PUnt - (FormatNumber(PUnt / (1 + IvaPor), 5)), 5)
                Ptotals = FormatNumber(Cant * PUnt, 5)
                IvaReal = Ptotals * IvaPor
            End If


            Me.listAcquisition.Add(New ItemAcquisition With
            {
                .IdPresent = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("idPresentacion").ToString(),
                .Discount = 0,
                .DateExpire = Nothing,
                .Count = txtCantidad.Text,
                .Codigo = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("codProducto").ToString(),
                .IdProducto = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("idProducto").ToString(),
                .IsIncludeIva = IsIncludeIvaCheckBox.Checked,
                .IsRountIva = Me.RountIvaCheckBox.Checked,
                .IsValitedUnitPrice = Me.IsValitedUnitPriceCheckBox.Checked,
                .IsExpirate = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("ItIsExpirable").ToString(),'ItIsExpirable
                .IvaPercent = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("ivaPorcentaje").ToString(),
                .Producto = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("NomComercial").ToString(),
                .TotalParcial = Ptotals,
                .UnitPrice = PUnt
            })


            Try
                Me.ListView1.SetObjects(listAcquisition)
                Me.Cursor = Cursors.WaitCursor
                Return True
            Finally
                Me.Cursor = Cursors.Default
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Agrega_Items() As Boolean
        Dim idProProveedor As Integer = 0

        'validamos informacion para poder agaregar
        Try
            'si no está selecionado un item salgo de esta funcion
            If Not (cmbItemProducto.SelectedIndex >= 0) Then
                MsgBox("Seleccione del listado", MsgBoxStyle.Information, "Aviso..")
                cmbItemProducto.Focus()
                Return False
            End If

            'cojo el codigo para validar costos 
            'idProProveedor = cmbItemProducto.Items(cmbItemProducto.SelectedIndex).Item("idProProveedor").ToString
            'exijo que ingrese cantidad de compra
            If Double.Parse(txtCantidad.Text) <= 0 Then
                MsgBox("Cantidad de producto comprado no puede ser cero", MsgBoxStyle.Information, "Aviso..")
                txtCantidad.Focus()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdquisicion en el sub Calcula_Cost_LineaAdd")
            Return False
        End Try

        Try
            'AGREGO EL REGISTRA AL LISTADO DE COMPRAS -------------------------------------------------------------------------------------------------------     -
            '
            'agregamos itemas
            'El items es el fila
            Dim Filas As Integer = Me.ListView1.Items.Count

            'carga % de IVA de la base en la CostoTotal 
            IvaPor = Double.Parse(cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("ivaPorcentaje").ToString())

            IvaReal = 0

            'codigo de producto [0]
            Me.ListView1.Items.Add(cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("codProducto").ToString)

            'Nombre e producto [1]
            ListView1.Items.Item(Filas).SubItems.Add(cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("NomComercial").ToString)
            'cantidad  [2]
            Me.ListView1.Items.Item(Filas).SubItems.Add(txtCantidad.Text)
            Cant = txtCantidad.Text

            'precio unitario  [3] CostoTotal
            PUnt = cmbItemProducto.Items(cmbItemProducto.SelectedIndex)("CostoTotal").ToString
            If Not IsIncludeIvaCheckBox.Checked Then
                PUnt = FormatNumber(PUnt / (1 + IvaPor), 5)
            End If
            Me.ListView1.Items.Item(Filas).SubItems.Add(PUnt)

            'Descuento  [4]
            ListView1.Items.Item(Filas).SubItems.Add(0)

            'EL COSTO YA INCLUYE IVA
            Ptotals = FormatNumber(Cant * PUnt, 5)
            If IsIncludeIvaCheckBox.Checked Then
                'valor de iva  [5]
                ListView1.Items.Item(Filas).SubItems.Add(FormatNumber(Ptotals - (Ptotals / (1 + IvaPor)), 2))
                'P/Total   [6]
                ListView1.Items.Item(Filas).SubItems.Add(Ptotals)
                ListView1.Items.Item(Filas).SubItems.Add(ivaSi)
            Else
                If IvaPor > 0 Then
                    'agrego el valor de iva  [5]
                    IvaReal = Ptotals * IvaPor
                    ListView1.Items.Item(Filas).SubItems.Add(IvaReal)
                    'agrego el valor TOTAL de fila sin incluir el precio de iva [6]
                    ListView1.Items.Item(Filas).SubItems.Add(Ptotals)
                    ListView1.Items.Item(Filas).SubItems.Add(ivaNo)
                Else
                    'valor de iva  [5]
                    ListView1.Items.Item(Filas).SubItems.Add(0)
                    'valor total incluido iva [6]
                    ListView1.Items.Item(Filas).SubItems.Add(Cant * PUnt)
                    ListView1.Items.Item(Filas).SubItems.Add(ivaNo)
                End If
            End If
            'agrego el idPresentacion y lo oculto [8]
            ListView1.Items.Item(Filas).SubItems.Add(cmbItemProducto.Items(cmbItemProducto.SelectedIndex).item("idPresentacion").ToString())
            ListView1.Columns(8).Width = 0
            'agrego idProducto y lo oculto [9]
            ListView1.Items.Item(Filas).SubItems.Add(cmbItemProducto.Items(cmbItemProducto.SelectedIndex).item("idProducto").ToString())
            ListView1.Columns(9).Width = 0
            'Porcentaje de iva [10]
            ListView1.Items.Item(Filas).SubItems.Add(IvaPor)
            ListView1.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Cargar_dtCosto(ByVal idProProveedor As Integer) As DataTable

        sql = "select pv.idPresentacion, p.IvaPorcentaje , pv.CostoTotal, pp.codProducto "
        sql = sql & "from Productos as p "
        sql = sql & "inner join ProductoPresentacion as pp on p.idProducto  = pp.idProducto "
        sql = sql & "inner join ProductoProveedor as pv on pv.idPresentacion = pp.idPresentacion "
        sql = sql & "inner join Proveedores as pr on pr.idProveedor = pv.idProveedor "
        sql = sql & "where pv.idProProveedor = " & idProProveedor & " "
        Try
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Return dt
                End If
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdquisicion en el Cargar_dtCosto")
            Return Nothing
        End Try
    End Function

    Private Sub Calcula_Linea(ByVal items As Integer)
        'EL COSTO TOTAL ES LA QUE NO SE BA HA CAMBIAR
        Try
            With ListView1
                IvaPor = .Items(items).SubItems(IvaPercentClm.Index).Text
                Ptotals = .Items(items).SubItems(TotalParcialClm.Index).Text
                If Not IsIncludeDiscountCheckBox.Checked Then
                    Ptotals -= .Items(items).SubItems(DiscountClm.Index).Text
                End If
                If IsIncludeIvaCheckBox.Checked Then
                    .Items(items).SubItems(IvaClm.Index).Text = FormatNumber(Ptotals - (Ptotals / (1 + IvaPor)), 5)
                Else
                    .Items(items).SubItems(IvaClm.Index).Text = FormatNumber(Ptotals * IvaPor, 5)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message + "en el Calculando_Precios_Linea", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub txtCantidad_GotFocus(sender As Object, e As System.EventArgs) Handles txtCantidad.GotFocus
        txtCantidad.Select(0, Len(txtCantidad.Text))
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            If InStr(".0123456789", e.KeyChar) = 0 Then
                If Asc(e.KeyChar) <> 8 Then
                    e.Handled = True
                End If
            Else
                If Asc(e.KeyChar) = 46 Then
                    If Not (txtCantidad.SelectedText.Length = txtCantidad.Text.Length) Then
                        If InStr(txtCantidad.Text, ".") > 0 Then
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidad.TextChanged
        AcceptButton = Nothing
        If IsNumeric(txtCantidad.Text) Then
            If Double.Parse(txtCantidad.Text) > 0 Then
                AcceptButton = btnAddListaProduc
            End If
        End If
    End Sub

    Private Sub Calcula_Total()
        Dim Bas0 As Double = 0
        Dim Bas12 As Double = 0
        Dim Desc0 As Double = 0
        Dim Desc12 As Double = 0
        Dim SubLine As Double = 0
        IvaReal = 0

        Try

            Dim myIList = ListView1.Objects

            Dim cleated As List(Of Object) = New List(Of Object)(myIList.OfType(Of Object)())

            ' Dim cleated As List(Of ItemAcquisition) = New List(Of ItemAcquisition)(myIList)

            IvaReal = Aggregate item In listAcquisition
                          Into Sum(item.Iva)

            Bas0 = Aggregate item In listAcquisition
                       Where item.IvaPercent = 0
                          Into Sum(item.TotalParcial)

            Bas12 = Aggregate item In listAcquisition
                       Where item.IvaPercent > 0
                          Into Sum(item.TotalParcial)

            Desc0 = Aggregate item In listAcquisition
                       Where item.IvaPercent = 0
                          Into Sum(item.Discount)

            Desc12 = Aggregate item In listAcquisition
                       Where item.IvaPercent > 0
                          Into Sum(item.Discount)

            If Not IsIncludeDiscountCheckBox.Checked Then
                Bas0 -= Desc0
                Bas12 -= Desc12
            End If


            If IsIncludeIvaCheckBox.Checked Then
                Bas12 -= IvaReal
            End If


            IvaReal = FormatNumber(IvaReal, 2)

            Bas0 = FormatNumber(Bas0, 2)

            Bas12 = FormatNumber(Bas12, 2)

            Desc0 = FormatNumber(Desc0, 2)

            Desc12 = FormatNumber(Desc12, 2)


            Bas0text.Text = FormatNumber(Bas0, 2)
            Bas12text.Text = FormatNumber(Bas12, 2)
            TotalBasText.Text = FormatNumber(Bas0 + Bas12, 2)
            ' en los detalles
            DescBase0Text.Text = "[" & Bas0 + Desc0 & "] - [Desc:" & Desc0 & "]"
            DescBase12Text.Text = "[" & Bas12 + Desc12 & "] - [Desc:" & Desc12 & "]"
            TotalBase.Text = "[" & Bas0 + Bas12 + Desc0 + Desc12 & "] - [Desc:" & Desc0 + Desc12 & "]"
            '-----total
            IvaText.Text = FormatNumber(IvaReal, 2)
            TotalPediText.Text = FormatNumber(Bas0 + Bas12 + IvaReal, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Guarda_Pedido() As Boolean
        Try
            If Not (Guarda_PedidoTmp()) Then 'si no puedo guardar detalle salgo
                Return False
            End If
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd = New SqlCommand("[dbo].[prcOrdenCompra]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    'bodega
                    cmd.Parameters.Add(New SqlParameter("@idBodega", SqlDbType.Int))
                    cmd.Parameters("@idBodega").Value = FacturCompra.idBodega  'esto de obtiene en el load
                    'fecha de pedido
                    cmd.Parameters.Add(New SqlParameter("@FechaPedido", SqlDbType.Date))
                    cmd.Parameters("@FechaPedido").Value = FechaPedidoDatatime.Value
                    'id proveedor
                    cmd.Parameters.Add(New SqlParameter("@IdProveedor", SqlDbType.Int))
                    cmd.Parameters("@IdProveedor").Value = FacturCompra.idProveedor
                    'codigo de uduario
                    cmd.Parameters.Add(New SqlParameter("@codUser", SqlDbType.Char, 8))
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    'codigo de terminal
                    cmd.Parameters.Add(New SqlParameter("@codTerminal", SqlDbType.Char, 8))
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    'salida de [id] automumerico
                    cmd.Parameters.Add(New SqlParameter("@idPedido", SqlDbType.Int))
                    cmd.Parameters("@idPedido").Direction = ParameterDirection.Output
                    If cmd.ExecuteNonQuery() > 0 Then
                        FacturCompra.idPedido = 0
                        txtOrden.Text = CInt(cmd.Parameters("@idPedido").Value)
                        FacturCompra.idPedido = txtOrden.Text
                        Return True
                    End If
                End Using

            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: frmAdquisicion en el Guarda_Pedido")
            Return False
        End Try
    End Function
    Private Function Guarda_PedidoTmp() As Boolean
        Try
            'verifico las fecha de caducidad de exigencia
            For Each item In Me.listAcquisition
                If item.IsExpirate Then
                    If item.DateExpire = Date.MinValue Then
                        MsgBox("Debe ingresar fecha de caducidad", MsgBoxStyle.Exclamation, "Importante")
                        Return False
                    End If
                End If
            Next

            Dim i As Integer = 0
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                '--Elimino los dato temporles
                sql = "Delete [tmp].[PedidosTmp] where codUser =@codUser and codTerminal = @codTerminal "
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@codUser", UsuarioActivo.codUser)
                    cmd.Parameters.AddWithValue("@codTerminal", TerminalActivo.codTerminal)
                    cmd.ExecuteNonQuery()
                End Using

                sql = "Insert into [tmp].[PedidosTmp] (codUser, codTerminal, idPresent, Cant, Descuento, iva, SubTotal, Total,DateExpire,idProducto)"
                sql = sql & "Values (@codUser, @codTerminal, @idPresent, @Cant, @Descuento, @iva, @SubTotal, @Total,@DateExpire, @idProducto)"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@idPresent", SqlDbType.Int)
                    cmd.Parameters.Add("@Cant", SqlDbType.Decimal, 18, 3)
                    cmd.Parameters.Add("@Descuento", SqlDbType.Decimal, 12, 5)
                    cmd.Parameters.Add("@iva", SqlDbType.Decimal, 18, 5)
                    cmd.Parameters.Add("@SubTotal", SqlDbType.Decimal, 30, 5)
                    cmd.Parameters.Add("@Total", SqlDbType.Decimal, 30, 5)
                    cmd.Parameters.Add("@DateExpire", SqlDbType.Date)
                    cmd.Parameters.Add("@idProducto", SqlDbType.Int)

                    For Each item In Me.listAcquisition
                        IvaReal = item.Iva
                        Descuen = item.Discount
                        Ptotals = item.TotalParcial

                        cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                        cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                        cmd.Parameters("@idPresent").Value = item.IdPresent
                        cmd.Parameters("@Cant").Value = item.Count
                        cmd.Parameters("@Descuento").Value = item.Discount
                        cmd.Parameters("@iva").Value = item.Iva
                        cmd.Parameters("@idProducto").Value = item.IdProducto
                        cmd.Parameters("@DateExpire").Value = If(item.DateExpire = Date.MinValue, DBNull.Value, item.DateExpire)


                        If IsIncludeIvaCheckBox.Checked Then
                            cmd.Parameters("@SubTotal").Value = (Ptotals + Descuen) - IvaReal
                            cmd.Parameters("@Total").Value = Ptotals
                        Else
                            cmd.Parameters("@SubTotal").Value = Ptotals
                            cmd.Parameters("@Total").Value = (Ptotals + IvaReal) - Descuen
                        End If

                        Try
                            If Not cmd.ExecuteNonQuery() > 0 Then
                                Return False
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Exclamation, "Error")
                            Return False
                        End Try
                        i += 1
                    Next
                End Using

            End Using

            If i > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Sub btnGuardaPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardaPedido.Click
        Try
            If ListView1.Items.Count > 0 Then
                Me.Cursor = Cursors.WaitCursor
                FacturCompra.idProveedor = id_proveedor
                FacturCompra.idBodega = id_Bodega
                If Guarda_Pedido() Then
                    tabcontrol.TabPages(0).Enabled = False
                    tabcontrol.TabPages(1).Enabled = False
                    tabcontrol.SelectedIndex = 2
                    tabcontrol.TabPages(2).Enabled = True
                    Carga_Tipo_Doc()
                    If Not (iniciado = state.gasto_Personal) Then
                        Carga_Declaracion()
                        cmbDeclaracion.SelectedValue = 1
                        Carga_Tipo_Consumo()
                        cmbItmTipconsumo.SelectedValue = 1
                    End If
                    dtFechaPedido.Value = Me.FechaPedidoDatatime.Value
                    Me.dtFechaCompra.Value = Me.dtFechaPedido.Value
                    Me.txtNumDoc.Text = ""
                    Me.txtNumDoc.Focus()
                End If
            Else
                MsgBox("No existe items para guardar..", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub Carga_Tipo_Consumo()

        conecta_sql()
        Try
            sql = "Select * from Consumo "
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            cmbItmTipconsumo.DataSource = Nothing
            If dt.Rows.Count > 0 Then
                With cmbItmTipconsumo
                    .DataSource = dt
                    .ValueMember = "idconsumo"
                    .DisplayMember = "Nom_Consumo"
                End With
                dt = Nothing
                cmbItmTipconsumo.SelectedValue = 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: frmAdquisicion en el  cargar Carga_Tipo_Consumo")
        End Try

    End Sub

    Private Sub cbxRedondSin_Click(sender As Object, e As System.EventArgs) Handles cbxRedondSin.Click
        cbxRedondSin.Checked = True
        cbxRedondCon.Checked = False
    End Sub

    Private Sub cbxRedondCon_Click(sender As Object, e As System.EventArgs) Handles cbxRedondCon.Click
        cbxRedondSin.Checked = False
        cbxRedondCon.Checked = True
    End Sub

    Private Sub btnCalTotal_Click(sender As System.Object, e As System.EventArgs) Handles CalculaTotalBtn.Click
        Calcula_Total()
    End Sub

    Private Sub txtLugarDecimal_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim i As Long

        ' elimino espacios en blanco al principio
        Me.txtLugarDecimal.Text = Trim(Me.txtLugarDecimal.Text)
        ' me aseguro de que la IP solo contiene números y puntos y en caso contrario salgo
        For i = 1 To Len(Me.txtLugarDecimal.Text)
            If Not IsNumeric(Mid(Me.txtLugarDecimal.Text, i, 1)) Then
                If Mid(Me.txtLugarDecimal.Text, i, 1) <> "." Then
                    MsgBox("Ingrese solo numeros enteros" & Chr(34) & Me.txtLugarDecimal.Text & Chr(34), vbOKOnly + vbCritical, "ATENCION")
                    Me.txtLugarDecimal.Text = 2
                    Me.txtLugarDecimal.Focus()
                    Exit Sub
                End If
            End If
        Next i
    End Sub

    Private Sub btnCancelCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelCompra.Click
        tabPago.Parent = Nothing
        tabDocumento.Parent = tabcontrol
        tabItem.Parent = Nothing
    End Sub

    Private Sub btnAcepProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnAcepProveedor.Click
        If id_proveedor > 0 Then
            nonNumberEntered = True  'para decir a los controles que recien estoy cargando datos
            sql = FechaPedidoDatatime.Value.ToString("D")
            If MsgBox("La fecha es correcta:  " & sql, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.No Then Exit Sub

            tabcontrol.SelectedIndex = 1
            tabcontrol.TabPages(0).Enabled = False
            tabcontrol.TabPages(1).Enabled = True
            tabcontrol.TabPages(2).Enabled = False
            Carga_Item_Productos(id_proveedor)
            cmbItemProducto.Focus()
            nonNumberEntered = False
            sql = txtProveedorDetail.Text & vbNewLine
            sql = sql & "Fecha :" & FechaPedidoDatatime.Text
            lblDetalleItema.Text = sql
        Else
            MsgBox("Seleccione un proveedor [F4]", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub
    Private Sub btnGuardarCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardarCompra.Click
        Try
            Dim idFactur As Integer = 0
            Cursor = Cursors.WaitCursor
            FacturCompra.idBodega = id_Bodega
            FacturCompra.idPedido = Integer.Parse(txtOrden.Text)
            FacturCompra.Tipo_Doc = cmbTipoDocumento.SelectedValue
            FacturCompra.Num_Doc = txtNumDoc.Text
            FacturCompra.idConsumo = cmbItmTipconsumo.SelectedValue
            FacturCompra.idDeclaracion = cmbDeclaracion.SelectedValue
            FacturCompra.FechaComra = dtFechaCompra.Value
            'comprobamos si podemos grabar compra
            idFactur = Guarda_compraActual(FacturCompra.idPedido)
            If idFactur > 0 Then
                MsgBox("Compra Guardada Exitosamente Número de transferencia: " & idFactur, MsgBoxStyle.Information, "Aviso")
                If Me.txtFalg.Text = "2" Then  'Cuando vengo desde listado de pedidos frmListPedido
                    Me.Close()
                    Exit Sub
                End If
                txtIdFormaPago.Text = 0
                txtDetailpago.Text = ""
                Me.ListView1.RemoveObjects(Me.listAcquisition)
                Me.listAcquisition.Clear()
                Inicia_Catalogo()
                Me.FechaPedidoDatatime.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Carga_Tipo_Doc()
        conecta_sql()
        Try
            sql = "Select * from [STM].[TypoDocumento] "
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cmbTipoDocumento
                    .DataSource = dt
                    .ValueMember = "idTypoDocu"
                    .DisplayMember = "Nom_Docu"
                End With
                dt = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: frmAdquisicion en el  cargar Carga_Tipo_Doc")
        End Try

    End Sub


    Private Sub cmbTipoDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbTipoDocumento.Validating

        If DirectCast(sender, ComboBox).SelectedIndex < 0 Then
            Me.ErrorIcono.SetError(sender, "Seleccione uno de la lista deplegable")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub txtNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumDoc.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 Then
            Me.ErrorIcono.SetError(sender, "Ingrese el numero de Factura o puede buscar un numero con el comando alternativo para recibos y notas de venta")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub

    Private Sub dtFechaCompra_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtFechaCompra.Validating, dtFechaPedido.Validating

        If FormatDateTime(DirectCast(sender, DateTimePicker).Value, DateFormat.ShortDate) < FormatDateTime(Me.dtFechaPedido.Value, DateFormat.ShortDate) Then
            Me.ErrorIcono.SetError(sender, "La fecha de compra no puede ser menor que la de PEDIDO")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub ListFormaPago_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If Me.txtIdFormaPago.Text = 0 Then
            Me.ErrorIcono.SetError(sender, "Click derecho y Seleccione una forma de pagar la compra")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub txtIdPedido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOrden.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "No existe el numedo de pedido")
        End If

    End Sub
    Private Sub btnListProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnListProveedor.Click
        Try
            Using frmListProveedor As New frmList_Proveedores(stateLoad.Dialogo, stateClient.User)
                With frmListProveedor
                    .btnOk.Visible = True
                    .txtbuscar.Focus()
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.Text = String.Format("Compra de productos: {0}", .dataListado.SelectedCells.Item(2).Value)
                        id_proveedor = .dataListado.SelectedCells.Item(0).Value
                        sql = "Proveedor :" & .dataListado.SelectedCells.Item(2).Value & vbNewLine
                        sql = sql & "Ruc :" & .dataListado.SelectedCells.Item(1).Value & vbNewLine
                        sql = sql & "Representante :" & .dataListado.SelectedCells.Item(3).Value & vbNewLine
                        sql = sql & "Teléfono:" & .dataListado.SelectedCells.Item(4).Value & vbNewLine
                        txtProveedorDetail.Text = sql
                        ListView1.Items.Clear()
                        IsIncludeIvaCheckBox.Checked = .dataListado.SelectedCells.Item(5).Value
                    End If
                    Me.FechaPedidoDatatime.Focus()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If ListView1.SelectedIndices.Count = 0 Then
                MsgBox("Seleccione uno de la lista", MsgBoxStyle.Information, "Aviso")
                Return
            End If
            If (MsgBox("Está seguro de eliminar..", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..")) = DialogResult.Yes Then
                Dim myIList = ListView1.SelectedObjects

                Dim cleated As List(Of Object) = New List(Of Object)(myIList.OfType(Of Object)())
                For Each item In cleated
                    Me.listAcquisition.Remove(item)
                Next

                ListView1.RemoveObjects(ListView1.SelectedObjects)
                Calcula_Total()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ListView1.Select()
        End Try

    End Sub

    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        cmdSelectAll(ListView1)
        ListView1.Focus()
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        ListView1.CopySelectionOnControlC = True
        ListView1.IncludeColumnHeadersInCopy = True
        ListView1.CopyObjectsToClipboard(ListView1.SelectedObjects)
        ListView1.Focus()
    End Sub
    Private Sub CantiEddButton_Click(sender As Object, e As EventArgs) Handles CantiEddButton.Click
        menuCantidad.PerformClick()
        ListView1.Focus()
    End Sub

    Private Sub TotalEditButton_Click(sender As Object, e As EventArgs) Handles TotalEditButton.Click
        menuPtotal.PerformClick()
        ListView1.Focus()
    End Sub

    Private Sub MoveDowButton_Click(sender As Object, e As EventArgs) Handles MoveDowButton.Click
    
    End Sub

    Private Sub IvaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsIncludeIvaCheckBox.CheckedChanged

        For Each item In Me.listAcquisition
            item.IsIncludeIva = IsIncludeIvaCheckBox.Checked
        Next
        Me.ListView1.SetObjects(listAcquisition)
        ' Calcula_Total()
    End Sub

    Private Sub PunitarioEddButton_Click(sender As Object, e As EventArgs) Handles PunitarioEddButton.Click
        Try
            For Each item In Me.listAcquisition
                item.IsValitedUnitPrice = True
            Next
            Using fornew As New frmEditCompra(Me.listAcquisition, Me.id_proveedor)
                With fornew
                    ._flag = frmEditCompra.Estado.Unitario
                    .ivaCheckBox.Checked = IsIncludeIvaCheckBox.Checked
                    .descCheckBox.Checked = IsIncludeDiscountCheckBox.Checked
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Copio_DatosdelLidtado(.DataGridView1)
                        Me.ListView1.Select()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub cbxRedondCon_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRedondCon.CheckedChanged
        If isLoated Then
            Calcula_Total()
        End If
    End Sub

    Private Sub cbxRedondSin_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRedondSin.CheckedChanged
        If isLoated Then
            Calcula_Total()
        End If
    End Sub

    Private Sub DescueCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsIncludeDiscountCheckBox.CheckedChanged
        For Each item In Me.listAcquisition
            If IsIncludeDiscountCheckBox.Checked Then

            End If
        Next
        'Calcula_Total

    End Sub

    Private Sub frmAdquisicion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ListView1.Items.Count > 0 Then
            If Not (MsgBox("Existe información sin guardara...!" + vbNewLine + "Desea salir de todas maneras..?",
                      MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = DialogResult.Yes) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub TotalEdidListButton_Click(sender As Object, e As EventArgs) Handles TotalEdidListButton.Click
        Try
            For Each item In Me.listAcquisition
                item.IsValitedUnitPrice = False
            Next

            Using fornew As New frmEditCompra(Me.listAcquisition, Me.id_proveedor)
                With fornew
                    ._flag = frmEditCompra.Estado.Total
                    .ivaCheckBox.Checked = IsIncludeIvaCheckBox.Checked
                    .descCheckBox.Checked = IsIncludeDiscountCheckBox.Checked
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Copio_DatosdelLidtado(fornew.DataGridView1)
                        Me.ListView1.RefreshObject(Me.listAcquisition)
                        IsValitedUnitPriceCheckBox.Checked = False
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Copio_DatosdelLidtado(dt As DataGridView)
        Try

            Dim lis = New List(Of ItemAcquisition)
            For Each itm In dt.DataSource
                lis.Add(itm)
            Next

            For Each item In Me.listAcquisition
                Dim itemdata = lis.Where(Function(x) x.ID = item.ID).FirstOrDefault()
                If Not itemdata Is Nothing Then
                    item.Count = itemdata.Count
                    item.UnitPrice = itemdata.UnitPrice
                    item.TotalParcial = itemdata.TotalParcial
                End If
            Next
            Calcula_Total()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AtrasButton_Click(sender As Object, e As EventArgs) Handles AtrasButton.Click
        sql = "Se puede cambiar la fecha de compra." & vbNewLine & "Pero sí cambia el proveedor se perderá los artículos ingresados.." & vbNewLine
        sql = sql & vbNewLine & "¿De todas formas desea regresar..?"
        If MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") Then
            tabcontrol.TabPages(0).Enabled = True
            tabcontrol.SelectedIndex = 0
            tabcontrol.TabPages(1).Enabled = False
            tabcontrol.TabPages(2).Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ActualizarButton_Click(sender As Object, e As EventArgs) Handles ActualizarButton.Click
        Cursor = Cursors.WaitCursor
        Carga_Item_Productos(Me.id_proveedor)

        Try
            Dim list = CType(cmbItemProducto.DataSource, ProductosByProviderDataTable)
            For Each item As ItemAcquisition In Me.listAcquisition
                Dim data = list.Where(Function(x) x.idPresentacion = item.IdPresent).FirstOrDefault()
                If Not IsNothing(data) Then
                    item.IsExpirate = data.ItIsExpirable
                    item.Codigo = data.codProducto
                    item.Producto = data.NomComercial
                    item.IvaPercent = data.ivaPorcentaje
                End If
            Next
            Me.ListView1.RefreshObjects(Me.listAcquisition)
            Calcula_Total()
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListView1_Enter(sender As Object, e As EventArgs)
        Me.TotalItemsLabel.Text = String.Format("Total items: {0}", ListView1.Items.Count)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If ListView1.SelectedIndices.Count = 1 Then
                Dim item = CType(ListView1.SelectedObject, ItemAcquisition)
                If item Is Nothing Then
                    Return
                End If
                Using adminProduc As New MDI_AddProductos(stateOperation.Update, item.IdProducto, Me.id_proveedor)
                    adminProduc.ShowDialog()
                    If adminProduc.DialogResult = DialogResult.OK Then
                        ActualizarButton.PerformClick()
                    End If
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCantidad_Enter(sender As Object, e As EventArgs) Handles txtCantidad.Enter
        cmbItemProducto.DroppedDown = False
    End Sub

    Private Sub txtCantidad_Leave(sender As Object, e As EventArgs) Handles txtCantidad.Leave
        Me.AcceptButton = Nothing
    End Sub

    Private Function SetDataFilter(text As String) As Object
        Dim lit As New List(Of ProductosByProviderRow)
        Try
            Dim response = GenerateSpliter(text)
            If response.IsSucces Then
                Select Case response.Spliter.Count
                    Case 1
                        lit = ListProductProvider.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                    Case 2
                        Dim li1 = ListProductProvider.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                        lit = li1.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(1).ToUpper())).ToList()
                    Case 3
                        Dim li1 = ListProductProvider.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                        Dim li2 = li1.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(1).ToUpper())).ToList()
                        lit = li2.Where(Function(x) x.NomComercial.ToUpper().Contains(response.Spliter(2).ToUpper())).ToList()
                    Case Else

                End Select
            End If
            Return lit
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            Me.Cursor = DefaultCursor
        End Try

    End Function

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles cmbItemProducto.TextChanged
        Dim combo As System.Windows.Forms.ComboBox = sender
        If isSystemController Then
            Return
        End If
        If combo.Text = lastedFindText Then
            Return
        End If
        Try
            isSystemController = True
            lastedFindText = combo.Text
            If String.IsNullOrEmpty(combo.Text) Then
                If Not combo.Items.Count = ListProductProvider.Count Then
                    combo.DataSource = ListProductProvider
                    combo.SelectedIndex = -1
                    Return
                End If
            End If

            If combo.Text.Length > 3 Then
                Dim textOriginal = combo.Text
                If String.IsNullOrWhiteSpace(Strings.Right(combo.Text, 1)) Then
                    If combo.DroppedDown Then
                        combo.DroppedDown = False
                    End If
                    combo.DataSource = SetDataFilter(combo.Text)
                    combo.SelectedIndex = -1
                    If Not combo.Items.Count = 0 Then
                        combo.DroppedDown = True
                        combo.Text = textOriginal
                        combo.SelectionStart = textOriginal.Length
                        combo.SelectionLength = 0
                    Else
                        combo.Text = textOriginal
                        combo.SelectionStart = textOriginal.Length
                        combo.SelectionLength = 0
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally

            isSystemController = False
        End Try
    End Sub

    Private Sub ListView1_SelectionChanged(sender As Object, e As EventArgs) Handles ListView1.SelectionChanged
        If (takeNoticeOfSelectionEvent) Then
            HandleSelectionChanged(CType(sender, ObjectListView))
        End If

        Me.takeNoticeOfSelectionEvent = True
    End Sub

    Private Sub HandleSelectionChanged(ByVal listView As ObjectListView)
        Dim msg As String
        Dim p As ItemAcquisition = CType(listView.SelectedObject, ItemAcquisition)
        If p Is Nothing Then msg = listView.SelectedIndices.Count.ToString() Else msg = String.Format("'{0}'", p.Producto)
        Dim focused As ItemAcquisition = If(listView.FocusedItem Is Nothing, Nothing, TryCast(((CType(listView.FocusedItem, OLVListItem)).RowObject), ItemAcquisition))
        Me.toolStripStatusLabel1.Text = String.Format("Selected {0} of {1} items", msg, listView.GetItemCount())
    End Sub

    Private Sub DeleteDateButton_Click(sender As Object, e As EventArgs) Handles DeleteDateButton.Click
        If Not ListView1.SelectedIndices.Count = 1 Then
            MsgBox("Seleccione uno de la lista", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        Try
            CType(ListView1.SelectedObject, ItemAcquisition).DateExpire = Nothing
            Me.ListView1.RefreshObjects(Me.listAcquisition)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbItemProducto_DropDownClosed(sender As Object, e As EventArgs) Handles cmbItemProducto.DropDownClosed
        If Not cmbItemProducto.SelectedIndex = -1 Then
            If cmbItemProducto.SelectedText = cmbItemProducto.Text Then
                txtCantidad.Focus()
            End If
        End If
    End Sub

    Private Sub RountIvaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RountIvaCheckBox.CheckedChanged
        For Each item In Me.listAcquisition
            item.IsRountIva = RountIvaCheckBox.Checked
        Next
    End Sub

    Private Sub PunitarioEddButton_Click_1(sender As Object, e As EventArgs) Handles PunitarioEddButton.Click

    End Sub

    Private Sub TotalEdidListButton_Click_1(sender As Object, e As EventArgs) Handles TotalEdidListButton.Click

    End Sub

    Private Sub AddNewListButton_Click(sender As Object, e As EventArgs) Handles AddNewListButton.Click
        Try
            Using fornew As New frmEditCompra(Me.listAcquisition, Me.id_proveedor)
                With fornew
                    ._flag = frmEditCompra.Estado.AddNew
                    .ivaCheckBox.Checked = IsIncludeIvaCheckBox.Checked
                    .descCheckBox.Checked = IsIncludeDiscountCheckBox.Checked
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.listAcquisition.Clear()
                        For Each itm In .DataGridView1.DataSource
                            listAcquisition.Add(itm)
                        Next
                        For Each itm In listAcquisition
                            itm.IsIncludeIva = Me.IsIncludeIvaCheckBox.Checked
                            itm.IsIncludeDiscount = Me.IsIncludeDiscountCheckBox.Checked
                            itm.IsValitedUnitPrice = Me.IsValitedUnitPriceCheckBox.Checked
                            itm.IsRountIva = Me.RountIvaCheckBox.Checked
                            If Not IsIncludeIvaCheckBox.Checked Then
                                IvaReal = FormatNumber(itm.UnitPrice - (FormatNumber(itm.UnitPrice / (1 + itm.IvaPercent), 5)), 5)
                                itm.UnitPrice -= IvaReal
                            End If
                        Next
                        Me.ListView1.SetObjects(Me.listAcquisition)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub EditCountListButton_Click(sender As Object, e As EventArgs) Handles EditCountListButton.Click
        Try
            Using fornew As New frmEditCompra(Me.listAcquisition, Me.id_proveedor)
                With fornew
                    ._flag = frmEditCompra.Estado.EditCount
                    .ivaCheckBox.Checked = IsIncludeIvaCheckBox.Checked
                    .descCheckBox.Checked = IsIncludeDiscountCheckBox.Checked
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Copio_DatosdelLidtado(.DataGridView1)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub AtrasButtonFactur_Click(sender As Object, e As EventArgs) Handles AtrasButtonFactur.Click
        tabcontrol.TabPages(0).Enabled = False
        tabcontrol.TabPages(1).Enabled = True
        tabcontrol.SelectedIndex = 1
        tabcontrol.TabPages(2).Enabled = False
    End Sub

    Private Sub BodegaLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BodegaLinkLabel.LinkClicked
        Using newfor As New frmList_Bodega()
            With newfor
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    id_Bodega = .DataGridView1.SelectedCells(0).Value
                    sql = "Adquiriendo productos para: " & vbNewLine
                    sql = sql & .DataGridView1.SelectedCells(1).Value & vbNewLine
                    sql = sql & .DataGridView1.SelectedCells(2).Value & vbNewLine
                    sql = sql & "Teléfono" & .DataGridView1.SelectedCells(4).Value & vbNewLine
                    BodegaLinkLabel.Text = sql
                End If
            End With
        End Using
    End Sub
    Private Sub DescuenEddButton_Click(sender As Object, e As EventArgs) Handles DescuenEddButton.Click
        menuDescuento.PerformClick()
        ListView1.Focus()
    End Sub

    Private Sub MoveUPButton_Click(sender As Object, e As EventArgs) Handles MoveUPButton.Click

    End Sub


    Private Sub btnAlternativo_Click(sender As Object, e As EventArgs) Handles btnAlternativo.Click
        Me.txtNumDoc.Text = Busca_New_NumDoc()
        Me.cmbTipoDocumento.SelectedValue = 3
    End Sub
    Private Sub cmbTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoDocumento.SelectedIndexChanged
        If cmbTipoDocumento.SelectedIndex >= 0 Then
            If cmbTipoDocumento.DisplayMember.Length > 0 Then
                NumDocumenLabel.Text = "Número de  " & cmbTipoDocumento.Text
            End If
        End If
    End Sub
    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs)
    End Sub

    Private Sub TabControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles tabcontrol.KeyDown
        If Me.tabcontrol.TabPages(tabcontrol.SelectedIndex).Name = "tabItem" Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
                Dim ctlCurrentControl As Control
                Dim strControlName As String
                ctlCurrentControl = Me.ActiveControl
                strControlName = ctlCurrentControl.Name
                If Not strControlName.Contains("cmbItemProducto") Then
                    Me.ListView1.Focus()
                End If

            ElseIf e.KeyCode = Keys.F12 Then
                btnGuardaPedido.PerformClick()
            ElseIf e.KeyCode = Keys.F1 Then
                Cambiatotal()
            End If
        ElseIf Me.tabcontrol.TabPages(tabcontrol.SelectedIndex).Name = "tabPago" Then
            If e.KeyCode = Keys.F12 Then
                btnGuardarCompra.PerformClick()
            ElseIf e.KeyCode = Keys.F1 Then
                btnAlternativo.PerformClick()
            ElseIf e.KeyCode = Keys.F4 Then
                btnFormaPago.PerformClick()
            End If
        ElseIf Me.tabcontrol.TabPages(tabcontrol.SelectedIndex).Name = "tabDocumento" Then
            If e.KeyCode = Keys.F12 Then
                btnAcepProveedor.PerformClick()
            ElseIf e.KeyCode = Keys.F4 Then
                btnListProveedor.PerformClick()
            End If
        End If
    End Sub
    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        Try
            Using newfor As New frmFormaPago()
                With newfor
                    .id_proveedor = id_proveedor
                    .flag = "Compras"
                    .txtTotal.Text = TotalPediText.Text
                    .txtPaga.Maximum = TotalPediText.Text
                    .txtPaga.Value = TotalPediText.Text
                    .idcliente = txtidAutorzCheque.Text
                    .ValCaheqtxt.Text = TotalPediText.Text
                    If .InitialityMenu() Then
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            txtIdFormaPago.Text = .idFormaPago
                            txtDetailpago.Text = .MsgBoxRetur
                        End If
                    Else
                        MsgBox("Menú fuera de control no se pudo controlar", MsgBoxStyle.Information, "Alerta")
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtIdFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtIdFormaPago.TextChanged, txtNumDoc.TextChanged
        If Integer.Parse(txtIdFormaPago.Text) > 0 And txtNumDoc.TextLength > 0 Then
            btnGuardarCompra.Enabled = True
        Else
            btnGuardarCompra.Enabled = False
        End If
    End Sub

    Private Sub menuPtotal_DisplayStyleChanged(sender As Object, e As EventArgs) Handles menuPtotal.DisplayStyleChanged

    End Sub
End Class