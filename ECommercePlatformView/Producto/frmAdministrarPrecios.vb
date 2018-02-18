Imports System.Data.SqlClient
Imports CADsisVenta

Public Class frmAdministrarPrecios
    Dim selectIntem As Integer = -1
    Dim isLoad As Boolean
    Dim Sorting As SortOrder = SortOrder.Ascending
    Private stateLoad As stateLoad
    Private idProducto As Integer
    Private nomProducto As String
    Sub New(stateLoad As stateLoad)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateLoad = stateLoad

    End Sub
    Private Sub frmAdministrarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case stateLoad
            Case stateLoad.Dialogo
                ToolStripComboBox1.SelectedIndex = 0
                Me.PanelControls.Controls.Clear()
                Me.PanelControls.Controls.Add(PanelAdmininPrice())
                PanelAdmininPrice.Dock = DockStyle.Left
                detailButton.Visible = False
                PanelFind.Visible = False
                newButtonPrice.Visible = False
                paneListView.Dock = DockStyle.Fill
                Me.CancelButton = Me.cancel_Button
                Me.Carga_datosAdminPrice()
            Case stateLoad.List
                Me.PanelControls.Controls.Clear()
                ToolStripComboBox1.SelectedIndex = 0

                Me.PanelControls.Controls.Add(PanelAdmininPrice())
                PanelAdmininPrice.Dock = DockStyle.Left
                Me.PanelControls.Controls.Add(Me.PanelAdminState)
                PanelAdminState.Dock = DockStyle.Left
                Me.PanelControls.Controls.Add(Me.PanelFind)
                PanelFind.Dock = DockStyle.Left
                paneListView.Dock = DockStyle.Fill
            Case Else
                Me.PanelControls.Controls.Clear()
                ToolStripComboBox1.SelectedIndex = 0

                Me.PanelControls.Controls.Add(PanelAdmininPrice())
                PanelAdmininPrice.Dock = DockStyle.Left
                Me.PanelControls.Controls.Add(Me.PanelAdminState)
                PanelAdminState.Dock = DockStyle.Left
                Me.PanelControls.Controls.Add(Me.PanelFind)
                PanelFind.Dock = DockStyle.Left
                paneListView.Dock = DockStyle.Fill
        End Select
    End Sub
    Public Function Carga_datosAdminPrice() As Boolean
        Dim dt As New DataTable
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand("[dbo].[pcdGetListProductAdminPrice]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)

                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    Using Data As New SqlDataAdapter(cmd)
                        Data.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return ViewAdminPrici(dt)
                        End If
                    End Using
                End Using
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message + "en el Carga_datos del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ViewAdminPrici(dt As DataTable) As Boolean
        Try
            Me.paneListView.Controls.Clear()
            Me.detailButton.Enabled = False
            Me.btnEditaCosto.Enabled = False
            Me.btnOfertas.Enabled = False

            Dim listView1 As New ListView()
            listView1.View = View.Details
            listView1.HideSelection = False
            listView1.GridLines = True
            listView1.Dock = DockStyle.Fill
            listView1.FullRowSelect = True
            listView1.Sorting = SortOrder.Ascending
            listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


            Dim columnHeader0 As ColumnHeader
            Dim Grupo As Integer = 0
            Dim GrupoUltimo As Integer = 0
            If dt.Rows.Count Then
                For i = 0 To dt.Rows.Count - 1
                    Grupo = dt(i)("idProducto").ToString
                    'creamos las columnas
                    If i = 0 Then
                        For col = 0 To dt.Columns.Count - 1
                            columnHeader0 = New ColumnHeader()
                            columnHeader0.Name = "Columna" & col
                            columnHeader0.Text = dt.Columns(col).ColumnName

                            If col > 7 Then
                                columnHeader0.TextAlign = HorizontalAlignment.Right
                            End If

                            If col = 0 Or col = 1 Or col = 2 Or col = 3 Or col = 4 Or col = 5 Then
                                columnHeader0.Width = 0
                            Else
                                columnHeader0.Width = 140
                            End If
                            listView1.Columns.AddRange(New ColumnHeader() _
                                {columnHeader0})
                        Next
                    End If

                    'aqui agrego los datos
                    Dim myValue As Double = 0
                    For col = 0 To dt.Columns.Count - 1
                        If col = 0 Then
                            listView1.Items.Add(dt(i)(col).ToString)
                        Else
                            If col = 8 Then
                                myValue = dt(i)(col)
                                listView1.Items(i).SubItems.Add(myValue.ToString("C5"))
                                listView1.Items(i).SubItems(col).Tag = "PrecioCompra"

                            ElseIf col = 9 Then
                                myValue = dt(i)(col)
                                listView1.Items(i).SubItems.Add(myValue.ToString("C5"))
                                listView1.Items(i).SubItems(col).Tag = "Precio"

                            ElseIf col = 10 Then
                                myValue = dt(i)(col)
                                listView1.Items(i).SubItems.Add(myValue.ToString("C5"))
                                listView1.Items(i).SubItems(col).Tag = "Utilidad"

                            ElseIf col = 11 Then
                                myValue = dt(i)(col)
                                listView1.Items(i).SubItems.Add(myValue.ToString("P2"))
                                listView1.Items(i).SubItems(col).Tag = "Porcentaje"

                            ElseIf col = 12 Then
                                listView1.Items(i).SubItems.Add("Ver ofertas")
                                listView1.Items(i).SubItems(col).Tag = "Oferta"

                            Else
                                listView1.Items(i).SubItems.Add(dt(i)(col).ToString)
                            End If
                        End If
                    Next

                    'agrego que grupo pertenescon si no es dialogo 
                    If Grupo = GrupoUltimo Then
                        listView1.Items(i).Group = listView1.Groups(listView1.Groups.Count - 1)
                    Else
                        listView1.Groups.Add(New ListViewGroup(dt(i)("Nom_Comercial").ToString + " [Se compra: " +
                               dt(i)("Compra").ToString + "]  [Se vende: " + dt(i)("Venta").ToString + "]", HorizontalAlignment.Left))
                        listView1.Items(i).Group = listView1.Groups(listView1.Groups.Count - 1)
                    End If
                    GrupoUltimo = dt(i)("idProducto").ToString
                Next
                'agregamos eventos
                AddHandler listView1.MouseDoubleClick, AddressOf ListView_MouseDoubleClick
                AddHandler listView1.SelectedIndexChanged, AddressOf ListView_SelectedIndexChanged

                Me.paneListView.Controls.Clear()
                Me.paneListView.Controls.Add(listView1)
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If Me.paneListView.Controls.Count > 0 Then
                Dim listvie As ListView = paneListView.Controls(0)
                If listvie.SelectedItems.Count = 1 Then
                    Me.detailButton.Enabled = True
                    btnEditaCosto.Enabled = True
                    btnOfertas.Enabled = True
                    btnDetalle.Enabled = True
                Else
                    Me.detailButton.Enabled = False
                    btnEditaCosto.Enabled = False
                    btnOfertas.Enabled = False
                    btnDetalle.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "en el ListView_SelectedIndexChanged del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            idProducto = 0
            nomProducto = String.Empty
            If Not isLoad Then
                If Me.paneListView.Controls.Count > 0 Then
                    Dim listvie As ListView = paneListView.Controls(0)
                    If listvie.SelectedItems.Count = 1 Then
                        Me.idProducto = listvie.SelectedItems(0).Text
                        nomProducto = listvie.SelectedItems(0).SubItems(1).Text
                        Me.stockButton.Enabled = True
                        Me.btnActiva.Enabled = True
                        Me.btnEliminar.Enabled = True
                        Me.btnDetalle.Enabled = True
                        If listvie.SelectedItems(0).Checked Then
                            btnActiva.Image = My.Resources.notLike_32
                        Else
                            btnActiva.Image = My.Resources.Like_32
                        End If
                    Else
                        Me.btnActiva.Enabled = False
                        Me.btnEliminar.Enabled = False
                        Me.btnDetalle.Enabled = False
                        Me.stockButton.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "en el ListView_SelectedIndexChanged del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ListView_MouseDoubleClick(sender As Object, e As MouseEventArgs)

        If paneListView.Controls.Count = 0 Then
            Return
        End If

        Dim info As ListViewHitTestInfo = sender.HitTest(e.X, e.Y)
        If IsNothing(info.SubItem.Tag) Then
            Return
        End If

        Try
            'obtenemos el listview

            Dim listvie As ListView = paneListView.Controls(0)
            Dim operation As String = String.Empty
            If listvie.SelectedItems.Count = 1 Then
                operation = info.SubItem.Tag

                Dim coleecionItem As ListView.SelectedListViewItemCollection =
                    listvie.SelectedItems
                Dim item As ListViewItem = listvie.SelectedItems(0)
                Select Case operation
                    Case "PrecioCompra"
                        ManipulaPrecioCompra(listvie, item, operation)
                    Case "Precio", "Utilidad", "Porcentaje"
                        ManipulaDatos(item, operation)
                    Case "Oferta"
                        btnOfertas.PerformClick()
                End Select
            Else
                MsgBox("Seleccione solo uno del listado", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ManipulaPrecioCompra(ByVal ObjectListView As ListView, ByVal item As ListViewItem, ByVal txtFlag As String)
        Try
            If Not (EcommerceActive.EnableEditPurchase) Then
                Return
            End If

            Dim idPresentacion? As Integer = item.SubItems(2).Text ' idPresentacion
            Dim idProducto? As Integer = item.Text  ' idProducto
            Dim preciocompra As Decimal = DecimalFromString(item.SubItems(8).Text) ' precio de compra
            Dim precioVenta As Decimal = 0
            Dim utilidad As Decimal = 0
            Dim porcent As Double = 0
            Dim isRegistration As Boolean
            Using ViewDataEdit = New frmImputData
                ViewDataEdit.Text = "Determine el precio de compra"
                ViewDataEdit.txtNumber.Value = preciocompra
                ViewDataEdit.ShowDialog()
                If Not (ViewDataEdit.DialogResult = DialogResult.OK) Then
                    Return
                End If
                preciocompra = ViewDataEdit.txtNumber.Value
            End Using

            Using db = New DataContext
CheckRegister:
                For Each DataItem In (db.ProductoProveedor.Where(Function(x) x.idPresentacion = idPresentacion)).ToList()
                    DataItem.CostoTotal = preciocompra
                    DataItem.Fech_Compra = DateTime.Now()
                    db.SubmitChanges()
                    isRegistration = True
                    Exit For
                Next
                If Not (isRegistration) Then
                    Dim _ProductoProveedor As New ProductoProveedor With
                    {
                        .idProveedor = db.Proveedores.FirstOrDefault().idProveedor,
                        .CostoTotal = 0,
                        .idPresentacion = idPresentacion,
                        .Fech_Compra = Date.Now()
                    }
                    db.ProductoProveedor.InsertOnSubmit(_ProductoProveedor)
                    db.SubmitChanges()
                    GoTo CheckRegister
                End If
                'View data edit
                For Each itemPresent In (db.ProductoPresentacion.Where(Function(x) x.idProducto = idProducto)).ToList()
                    For Each itemGroup As ListViewItem In ObjectListView.Items(item.Index).Group.Items
                        If itemPresent.idPresentacion = Integer.Parse(itemGroup.SubItems(2).Text) Then
                            utilidad = 0
                            porcent = 0
                            itemGroup.SubItems(8).Text = itemPresent.precioCompra.ToString("C5")
                            preciocompra = itemPresent.precioCompra 'precio compra
                            precioVenta = itemPresent.precioVenta   'precio venta
                            If precioVenta > 0 Then
                                utilidad = precioVenta - preciocompra
                                porcent = utilidad / preciocompra
                            End If
                            itemGroup.SubItems(10).Text = utilidad.ToString("C5") 'Utilidad
                            itemGroup.SubItems(11).Text = porcent.ToString("P2") 'Rentabilidad
                        End If
                    Next
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ManipulaDatos(ByVal item As ListViewItem, ByVal txtFlag As String)
        Try
            Dim porciento As Decimal = DecimalFromString(item.SubItems(11).Text)
            Dim preciocompra As Decimal = DecimalFromString(item.SubItems(8).Text)
            Dim precioVenta As Decimal = DecimalFromString(item.SubItems(9).Text)
            Dim utilidad As Decimal = DecimalFromString(item.SubItems(10).Text)
            Using fornew As New frmEditaValor
                With fornew
                    .txtprecioCompra.Value = preciocompra
                    .txtprecioVenta.Value = precioVenta
                    .txtUtilidad.Value = utilidad
                    .txtporciento.Value = porciento
                    .lblmedida.Text = item.SubItems(6).Text + "==> " + item.SubItems(7).Text
                    .lblProducto.Text = item.SubItems(3).Text
                    .txtflag = txtFlag
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If EditaCosto((item.SubItems(2).Text), .txtprecioVenta.Value) Then
                            Dim porcent As Double = .txtporciento.Value / 100
                            item.SubItems(9).Text = .txtprecioVenta.Value.ToString("C5")  'precio venta
                            item.SubItems(10).Text = .txtUtilidad.Value.ToString("C5") 'Utilidad
                            item.SubItems(11).Text = porcent.ToString("P2") 'Rentabilidad
                        End If
                    End If
                End With
            End Using
            Me.paneListView.Controls(0).Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Function CamciaEstadoProducto(ByVal item As ListViewItem) As Boolean

        Try
            Dim idproduc As Integer = item.Text
            Dim NomProduct As String = item.SubItems(1).Text
            Dim Estado As Boolean = item.Checked
            Dim stado As Integer = 0
            If Estado Then
                stado = 1
            End If
            sql = "Update Productos set Activo = " & stado & " where idProducto = " & idproduc & " "

            Dim cmd As New ClassCargadorProducto
            If cmd.ExecuteComand(sql) Then
                If item.Checked Then
                    Me.NotifyIcon1.Text = NomProduct & " Activado."
                Else
                    Me.NotifyIcon1.Text = NomProduct & " Desactivado."
                End If
                NotifyIcon1.ShowBalloonTip(1000, "yy", "Aviso", ToolTipIcon.Info)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Function EditaCosto(ByVal idPresent As Integer, ByVal Valor As Double) As Boolean
        sql = "Update ProductoPresentacion set precioVenta = " & Valor & " where idPresentacion = " & idPresent & " "
        Try
            Dim cmd As New ClassCargadorProducto
            Return cmd.ExecuteComand(sql)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function


    Private Sub btnEditaCosto_Click(sender As Object, e As EventArgs) Handles btnEditaCosto.Click
        Try
            Dim listvie As ListView = paneListView.Controls(0)
            If listvie.SelectedItems.Count = 1 Then
                Dim coleecionItem As ListView.SelectedListViewItemCollection =
                    listvie.SelectedItems
                Dim item As ListViewItem
                For Each item In coleecionItem
                    ManipulaDatos(item, "")
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub cmbBucarPro_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.txtProduc_Select.Focus()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Me.paneListView.Controls.Clear()
            Me.isLoad = True
            Dim mySpliter As ResponseSpliter = GenerateSpliter(txtProduc_Select.Text, True)

            If preparatedStatement(mySpliter) Then
                If ToolStripComboBox1.SelectedIndex = 0 Then
                    Me.Carga_datosAdminPrice()
                ElseIf ToolStripComboBox1.SelectedIndex = 1 Then
                    Me.Carga_ListProductoStado()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            Me.isLoad = False
        End Try
    End Sub
    Private Function Carga_ListProductoStado() As Boolean
        Dim dt As New DataTable
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand("[dbo].[pcdGetListProductAdminState]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)

                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    Using Data As New SqlDataAdapter(cmd)
                        Data.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return ViewListProductSate(dt)
                        Else
                            Return False
                        End If
                    End Using
                End Using
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ViewListProductSate(dt As DataTable) As Boolean
        Try
            Me.Cursor = Cursors.Default
            Me.paneListView.Controls.Clear()
            Me.btnActiva.Enabled = False
            Me.btnDetalle.Enabled = False
            Me.btnEliminar.Enabled = False


            isLoad = True
            Dim listView1 As New ListView()
            'listView1.Dock = DockStyle.Fill
            listView1.View = View.Details
            listView1.HideSelection = False
            listView1.GridLines = True
            listView1.Dock = DockStyle.Fill
            listView1.FullRowSelect = True
            listView1.CheckBoxes = True
            listView1.Sorting = SortOrder.Ascending

            listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Dim columnHeader0 As ColumnHeader
            If dt.Rows.Count Then
                For i = 0 To dt.Rows.Count - 1
                    'creamos las columnas
                    If i = 0 Then
                        For col = 0 To dt.Columns.Count - 1
                            columnHeader0 = New ColumnHeader()
                            columnHeader0.Name = "Columna" & col
                            columnHeader0.Text = dt.Columns(col).ColumnName

                            If columnHeader0.Text.Equals("Activo") Then
                                columnHeader0.Width = 0
                            Else
                                columnHeader0.Width = -1
                            End If
                            listView1.Columns.AddRange(New ColumnHeader() _
                                {columnHeader0})
                        Next
                    End If
                    'aqui agrego los datos

                    For col = 0 To dt.Columns.Count - 1
                        If col = 0 Then
                            listView1.Items.Add(dt(i)(col).ToString)
                            'Marco Activo o inactivo
                            If dt(i)("Activo").ToString = "True" Then
                                listView1.Items(listView1.Items.Count - 1).Checked = True
                            End If
                        Else
                            listView1.Items(listView1.Items.Count - 1).SubItems.Add(dt(i)(col).ToString)
                        End If
                    Next
                Next

                AddHandler listView1.ItemChecked, AddressOf ListView_ItemChecked
                AddHandler listView1.SelectedIndexChanged, AddressOf ListView2_SelectedIndexChanged
                AddHandler listView1.ColumnClick, AddressOf listView1_ColumnClick
                AddHandler listView1.ItemCheck, AddressOf listView1_ItemCheck

                Me.paneListView.Controls.Add(listView1)
            Else
                Dim located As New Point
                located.X = 15
                located.Y = 20
                Dim labelnot As New System.Windows.Forms.Label With {.Location = located, .Text = "No hay información"}
                Me.paneListView.Controls.Add(labelnot)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub txtProduc_Select_TextChanged(sender As Object, e As EventArgs) Handles txtProduc_Select.TextChanged
        If Me.txtProduc_Select.TextLength > 3 Then
            Me.AcceptButton = Me.btnBuscar
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub
    Private Sub listView1_ItemCheck(sender As Object, e As ItemCheckEventArgs)
        If Not isLoad Then
            e.NewValue = e.CurrentValue
        End If
    End Sub
    Private Sub listView1_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs)
        Try
            If Not (e.Column = 3 Or e.Column = 0) Then
                Exit Sub
            End If
            isLoad = True
            ' Crear una instancia de la clase que realizará la comparación
            Dim oCompare As New ListViewColumnSort()
            '
            ' Asignar el orden de clasificación
            If Sorting = SortOrder.Ascending Then
                oCompare.Sorting = SortOrder.Descending
            Else
                oCompare.Sorting = SortOrder.Ascending
            End If
            Sorting = oCompare.Sorting
            '
            ' La columna en la que se ha pulsado
            oCompare.ColumnIndex = e.Column

            If oCompare.ColumnIndex = 0 Then
                oCompare.ColumnIndex = 4
            End If
            ' El tipo de datos de la columna en la que se ha pulsado
            Select Case e.Column
                Case 0
                    oCompare.CompararPor = ListViewColumnSort.TipoCompare.Numero
                Case 1
                    oCompare.CompararPor = ListViewColumnSort.TipoCompare.Cadena
                Case 2
                    oCompare.CompararPor = ListViewColumnSort.TipoCompare.Fecha
                Case 3
                    oCompare.CompararPor = ListViewColumnSort.TipoCompare.Cadena
                Case 4
                    oCompare.CompararPor = ListViewColumnSort.TipoCompare.Cadena
            End Select
            ' Asignar la clase que implementa IComparer
            ' y que se usará para realizar la comparación de cada elemento
            sender.ListViewItemSorter = oCompare
            '
            ' Cuando se asigna ListView
            isLoad = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub ListView_ItemChecked(sender As Object, e As ItemCheckedEventArgs)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnActiva_Click(sender As Object, e As EventArgs) Handles btnActiva.Click
        Try
            Dim listview As ListView = Me.paneListView.Controls(0)
            If listview.SelectedItems.Count = 1 Then
                Dim coleecionItem As ListView.SelectedListViewItemCollection =
                                   listview.SelectedItems
                Dim item As ListViewItem
                For Each item In coleecionItem
                    isLoad = True
                    item.Checked = Not item.Checked
                    CamciaEstadoProducto(item)
                    isLoad = False
                Next
            Else
                MsgBox("Selecciona uno de la lista", MsgBoxStyle.Information, "Aviso")
            End If
            listview.Focus()
        Catch ex As Exception
            MsgBox(ex.Message + "en el btnActiva_Click del " + Me.Name, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim listview As ListView = Me.paneListView.Controls(0)
            If listview.SelectedItems.Count = 1 Then
                Dim coleecionItem As ListView.SelectedListViewItemCollection =
                                   listview.SelectedItems
                Dim item As ListViewItem
                For Each item In coleecionItem
                    If MsgBox("Está seguro de eliminar el producto: " + item.SubItems(1).Text, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                        If Elimina_Producto(item.Text) Then
                            item.Remove()
                        End If
                    End If
                Next
            Else
                MsgBox("Selecciona uno de la lista", MsgBoxStyle.Information, "Aviso")
            End If
            listview.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnOfertas_Click(sender As Object, e As EventArgs) Handles btnOfertas.Click
        Try
            If paneListView.Controls.Count > 0 Then
                Dim listvie As ListView = paneListView.Controls(0)
                If listvie.SelectedItems.Count = 1 Then
                    Dim coleecionItem As ListView.SelectedListViewItemCollection =
                        listvie.SelectedItems
                    Dim item As ListViewItem
                    For Each item In coleecionItem
                        Ofertas(item)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "En el btnOfertas_Click del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub Ofertas(ByVal item As ListViewItem)
        Try
            Dim precioVenta As Double = DecimalFromString(item.SubItems(9).Text)
            If precioVenta = 0 Then
                MsgBox("Primero determine al precio  de venta a publico.", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Using newform As New frmOferta(item.SubItems(6).Text)
                With newform
                    .precioNormal = precioVenta
                    .txtIdPresent.Text = item.SubItems(2).Text
                    .lblProducto.Text = item.SubItems(3).Text
                    .presentacionDescLabel.Text = item.SubItems(6).Text + " (" + item.SubItems(7).Text + ") "
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click, detailButton.Click
        Dim item As ListViewItem
        Try
            If paneListView.Controls.Count > 0 Then
                Dim listvie As ListView = paneListView.Controls(0)
                If listvie.SelectedItems.Count = 1 Then
                    Dim coleecionItem As ListView.SelectedListViewItemCollection =
                        listvie.SelectedItems

                    For Each item In coleecionItem
                        Dim idproducto As Integer = item.SubItems(0).Text
                        Using MDI_AddProductos As New MDI_AddProductos(stateOperation.Update, idproducto, 0)
                            With MDI_AddProductos
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    btnBuscar.PerformClick()
                                End If
                                Exit For
                            End With
                        End Using
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Me.paneListView.Controls.Clear()
            If ToolStripComboBox1.ComboBox.SelectedIndex = 0 Then
                PanelAdminState.Visible = False
                PanelAdmininPrice.Visible = True
            ElseIf ToolStripComboBox1.ComboBox.SelectedIndex = 1 Then
                PanelAdminState.Visible = True
                PanelAdmininPrice.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ultButton_Click(sender As Object, e As EventArgs) Handles newButtonState.Click
        Try
            Me.isLoad = True
            Me.Cursor = Cursors.WaitCursor
            sql = " SELECT p.idProducto, p.Nom_Comercial,
              p.Activo, p.fecha_reg
              FROM dbo.Productos AS P  
               inner join View_Ultimo50Prodcutos as ult on ult.idProducto = p.idProducto "
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                Using cmd As New SqlCommand(sql, cnn)
                    Using adt As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            adt.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Me.ViewListProductSate(dt)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            Me.isLoad = False
        End Try
    End Sub
    Private Sub newButtonPrice_Click(sender As Object, e As EventArgs) Handles newButtonPrice.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            sql = " SELECT p.idProducto, p.Activo,
        pr.idPresentacion, p.Nom_Comercial,
		(select med.Nom_Medida from  dbo.ProductoUndMedida as med where med.idProUndMed = p.Deft_idPresenCompra) as Compra, 
		(select med.Nom_Medida from  dbo.ProductoUndMedida as med where med.idProUndMed = p.Deft_idPresenVenta) as Venta,
		 md.Nom_Medida as [Presentación],
         pr.Presentacion AS [Empaque], 
         pr.precioCompra as [Precio Compra], 
		 pr.precioVenta as [Precio Venta], 
         pr.precioVenta - pr.precioCompra AS [$ Utilidad] , 
         IIF(pr.precioCompra > 0 ,((pr.precioVenta-pr.precioCompra)/pr.precioCompra),0) as  [% Rentabilidad], 
		 'Ver oferta' as Oferta 
         FROM dbo.ProductoPresentacion AS pr 
		 INNER JOIN dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed 
		 INNER JOIN dbo.productos AS p ON pr.idProducto = p.idProducto
		 INNER JOIN DBO.ProductoUndMedida as md on md.idProUndMed = pr.idProUndMed 
         INNER JOIN View_Ultimo50Prodcutos as ult on ult.idProducto = p.idProducto "
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                Using cmd As New SqlCommand(sql, cnn)
                    Using adt As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            adt.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Me.ViewAdminPrici(dt)
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub stockButton_Click(sender As Object, e As EventArgs) Handles stockButton.Click
        Try
            If idProducto > 0 Then
                Using frmStock As New frmInventoriesExplorer
                    With frmStock
                        .PanelControl.Visible = False
                        .findFlowLayoutPanel.Visible = False
                        .idProducto = idProducto
                        .Height = 500
                        .Width = 700
                        .CancelButton = .CloseButton
                        .StartPosition = FormStartPosition.CenterScreen
                        .FormBorderStyle = FormBorderStyle.Fixed3D
                        .Text = String.Format("Stock del producto: {0}", nomProducto)
                        .ShowDialog()

                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class