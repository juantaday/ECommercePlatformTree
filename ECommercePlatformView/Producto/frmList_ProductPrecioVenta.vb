Imports CADsisVenta.DataSetVentas
Imports CADsisVenta.DataSetVentasTableAdapters
Imports ECommercePlatformView

Public Class frmList_ProductPrecioVenta
    Protected Friend idProducto As Integer
    Protected Friend idPresent As Integer
    Protected Friend flag As String
    Protected Friend State As _state

    Sub New(Optional _dataListado As List(Of PresentVendiblescollection) = Nothing)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmPreciosVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idProducto = 0
        idPresent = 0
        Try
            If txtProduc_Select.Text.Length > 0 Then
                btnBuscar.PerformClick()
            Else
                txtProduc_Select.TabIndex = 0
                txtProduc_Select.Focus()
                datalistado.TabIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
            If (txtProduc_Select.Text.Length = 0) Or (String.IsNullOrEmpty(txtProduc_Select.Text)) Then
                Return
            End If

            If (txtProduc_Select.Text.Length < 3) Then
                MsgBox("Pocos parámetros para buscar.", MsgBoxStyle.Information, "Aviso")
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            Me.datalistado.DataSource = Nothing

            '/Generate spliter for select and preparated statement in master id datalist equals cero
            Dim mySpliter As ResponseSpliter = GenerateSpliter(txtProduc_Select.Text, If(ListVendiblescollection.Count = 0, True, False))

            If ListVendiblescollection.Count > 0 Then
                Load_DataForLinq(mySpliter)
            Else
                Carga_ListProducto()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            If datalistado.RowCount = 0 Then
                txtProduc_Select.TabIndex = 0
                datalistado.TabIndex = 1
                txtProduc_Select.Focus()
            Else
                datalistado.TabIndex = 0
                txtProduc_Select.TabIndex = 1
                datalistado.Focus()
            End If
        End Try
    End Sub
    Private Sub Load_DataForLinq(mySpliter As ResponseSpliter)
        Dim dt As New pcdGetListProductVentaDataTable
        Dim ListGeneral As New List(Of PresentVendiblescollection)
        Try
            '/ si busca el dodigo de barra
            If mySpliter.IsNumeric Then
                Dim mylist = From l In ListVendiblescollection.Where(Function(x) x.Barcode = mySpliter.Spliter(0))

                For Each item In mylist
                    ListGeneral.Add(item)
                Next
                Return
            End If
            '/si busca el codigo de producto
            If mySpliter.IsCode Then
                Dim mylist = From l In ListVendiblescollection.Where(Function(x) x.CodProducto = mySpliter.Spliter(0))

                For Each item In mylist
                    ListGeneral.Add(item)
                Next
                Return
            End If
            '/si busca el codigo de nombre de procuto
            Select Case mySpliter.Spliter.Count
                Case 1
                    Dim mylist = From l In ListVendiblescollection.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(0).ToUpper()))

                    For Each item In mylist
                        ListGeneral.Add(item)
                    Next
                    Return
                Case 2
                    Dim mylist = From l In ListVendiblescollection.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(0).ToUpper()))

                    If mylist.Count > 0 Then
                        Dim mylist2 = From l In mylist.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(1).ToUpper()))
                        For Each item In mylist2
                            ListGeneral.Add(item)
                        Next
                        Return
                    End If
                Case 3
                    Dim mylist = From l In ListVendiblescollection.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(0).ToUpper()))

                    If mylist.Count > 0 Then
                        Dim mylist2 = From l In mylist.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(1).ToUpper()))
                        If mylist2.Count > 0 Then
                            Dim mylist3 = From l In mylist2.Where(Function(x) x.NomComercial.ToUpper().Contains(mySpliter.Spliter(2).ToUpper()))
                            For Each item In mylist3
                                ListGeneral.Add(item)
                            Next
                            Return
                        End If
                    End If
                Case > 5
                    MsgBox("Desbordamiento de datos", MsgBoxStyle.Exclamation, "Error por  usuario")
                    Return
                Case Else
                    Return
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            For Each item In ListGeneral
                dt.AddpcdGetListProductVentaRow(item.IdPresent, item.IdProducto, item.CodProducto, item.NomComercial,
                                                    item.Medida, item.PresentationPrint, item.Empaquetado, item.PrecioVenta, item.IsDefaultSales)
            Next
            ViewData(dt)
        End Try
    End Sub

    Private Sub Carga_ListProducto()
        Try
            Using adat As New pcdGetListProductVentaTableAdapter
                Using dt As New pcdGetListProductVentaDataTable
                    adat.Fill(dt, codUser:=UsuarioActivo.codUser, codTerminal:=TerminalActivo.codTerminal)
                    ViewData(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_ListProducto del " + Me.Name, MsgBoxStyle.Critical, "Error al cargar Proveedor")
        End Try
    End Sub
    Private Sub ViewData(ByVal dt As pcdGetListProductVentaDataTable)
        'esta funcion ordena y selecciona solo los configurados por en EcommerceSettingSales
        Try
            Dim idProducto As Integer = 0
            Dim dtView As New pcdGetListProductVentaDataTable

            Select Case EcommerceActive.idSettingSales
                Case 1, 0 'Todas las presentaciones.
                    Dim mySliet = From d In dt.OrderBy(Function(x) x.Nom_Comercial).ThenBy(Function(x) x.Empaquetado)

                    For Each item In mySliet
                        dtView.ImportRow(item)
                    Next

                Case 2  'Solo presentaciones predeterminadas.
                    Dim mySliet = From d In dt.OrderBy(Function(x) x.Nom_Comercial).Where(Function(x) x.isDefaultSales = True)
                    For Each item In mySliet
                        dtView.ImportRow(item)
                    Next

                Case 3  'Iguales y superiores a las predeterminadas.
                    Dim myLsitOrderBy = From d In dt.OrderBy(Function(x) x.Nom_Comercial)
                    Dim minEmpaquetado As Decimal = 0

                    For Each item In myLsitOrderBy
                        If Not item.idProducto = idProducto Then
                            Dim MyEmp = From d In dt.Where(Function(x) x.idProducto = item.idProducto And x.isDefaultSales = True)
                            For Each ite In MyEmp
                                minEmpaquetado = ite.Empaquetado
                            Next
                            Dim mySliet = From d In dt.OrderBy(Function(x) x.Empaquetado).Where(Function(x) x.idProducto = item.idProducto And x.Empaquetado >= minEmpaquetado)

                            For Each idOrde In mySliet
                                dtView.ImportRow(idOrde)
                            Next
                        End If
                        idProducto = item.idProducto
                        minEmpaquetado = 0
                    Next
            End Select

            'View data
            If dt.Rows.Count > 0 Then
                With datalistado
                    .DataSource = dtView
                    .AutoSizeColumnsMode =
                          DataGridViewAutoSizeColumnsMode.AllCells

                    .Columns("idPresentacion").Visible = False
                    .Columns("idProducto").Visible = False
                    .Columns("isDefaultSales").Visible = False
                    .Columns("Empaquetado").Visible = False

                    clm = .Columns("codProducto")
                    clm.HeaderText = "Código"

                    clm = .Columns("Nom_Comercial")
                    clm.HeaderText = "Producto"

                    clm = .Columns("Nom_Medida")
                    clm.HeaderText = "Presentanción"

                    clm = .Columns("Presentacion")
                    clm.HeaderText = "Empaque"

                    clm = .Columns("precioVenta")
                    clm.HeaderText = "Precio venta"
                    clm.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle _
                                 With {.NullValue = 0, .Format = "C5",
                                       .Alignment = DataGridViewContentAlignment.MiddleRight}
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmLista_Producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmLista_Producto_Load")
        End Try

        Me.txtProduc_Select.Focus()

    End Sub

    Private Sub cmbBucarPro_LostFocus(sender As Object, e As System.EventArgs)
        If sender.SelectedIndex < 0 Then
            MsgBox("Seleccione una de la lista despegable", MsgBoxStyle.Exclamation, "Por vafor")
        End If
    End Sub

    Private Sub txtProduc_Select_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProduc_Select.TextChanged
        SetButtonDefaul(Me.btnBuscar)
    End Sub
    Private Sub SetButtonDefaul(ByVal btn As Button)
        Me.AcceptButton = btn
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        If Not (idProducto = 0 Or idPresent = 0) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub


    Private Sub datalistado_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If flag = "Ventas" Then
            btnOk.PerformClick()
        End If
    End Sub
    Private Sub Admin_Controls()
        Try
            If Me.datalistado.SelectedRows.Count = 1 Then
                idProducto = datalistado.SelectedRows(0).Cells(datalistado.Columns("idProducto").Index).Value
                idPresent = datalistado.SelectedRows(0).Cells(datalistado.Columns("idPresentacion").Index).Value
                If Not IsDBNull(Me.datalistado.SelectedCells.Item(4).Value) Then
                    Me.btnEmpaque.Enabled = True
                Else
                    Me.btnEmpaque.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnOferta_Click(sender As Object, e As EventArgs) Handles btnEmpaque.Click
        Try
            If Not datalistado.SelectedRows.Count = 1 Then
                MsgBox(msgSelect_list, MsgBoxStyle.Critical, "Error")
                Return
            End If
            Using fornew As New frmProductoPresentacion()
                With fornew
                    .Text = "  UNIDAD DE MEDIDA Y OFERTAS DISPONIBLES"
                    .flag = "Operando"
                    .lblProducto.Text = datalistado.SelectedRows(0).Cells("Nom_Comercial").Value
                    .idproducto = datalistado.SelectedRows(0).Cells("idProducto").Value
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub datalistado_KeyDown(sender As Object, e As KeyEventArgs) Handles datalistado.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = False
                If datalistado.SelectedRows.Count = 1 Then
                    Admin_Controls()
                    btnOk.PerformClick()
                End If
            ElseIf e.KeyCode = Keys.Back Or e.KeyCode = Keys.Tab Then
                txtProduc_Select.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If sender.SelectedRows.Count = 1 Then
            Admin_Controls()
        End If
    End Sub

    Private Sub datalistado_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles datalistado.RowStateChanged
        Try
            If e.StateChanged = DataGridViewElementStates.Selected Then
                If datalistado.RowCount = 1 Then
                    If datalistado.SelectedRows.Count = 1 Then
                        idProducto = datalistado.SelectedRows(0).Cells(datalistado.Columns("idProducto").Index).Value
                        idPresent = datalistado.SelectedRows(0).Cells(datalistado.Columns("idPresentacion").Index).Value
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class