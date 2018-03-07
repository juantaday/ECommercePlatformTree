Imports System.Data.SqlClient
Imports BrightIdeasSoftware
Imports CADsisVenta

Public Class frmProductConbined
    Private Barcode As String
    Private id_PresentInProduct As Integer
    Private id_NewProduct As Integer
    Private totalPrecioCompra As Double
    Private total_Cant_Present As Double
    Private operation As stateOperation
    Private PictureBoxCopy As Bitmap
    Private listItemProductCombined As List(Of ProductCombined)
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Try
            id_NewProduct = 0
            id_PresentInProduct = 0
            Using newDetail As New frm_detalle(stateOperation.Insert, 0, IdKind:=2)
                newDetail.PanelFood.Visible = True
                newDetail.AdminDateExpirateCheckBox.Enabled = False
                newDetail.ivaPreserminadoLinkLabel.Enabled = False
                newDetail.ShowDialog()
                If newDetail.DialogResult = DialogResult.OK Then
                    id_NewProduct = newDetail.Id_Producto
                    Me.PanelTools.Enabled = False
                    Me.PanelViewdata.Enabled = False
                    Me.PanelDetail.Enabled = True
                    View_Details(id_NewProduct)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmProductConbined_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SettingWithPanel()
        InitializeComponetControl()
        Load_dataProduct()
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.Transparent
        BunifuThinButton24.BackColor = System.Drawing.Color.Transparent
        BunifuThinButton25.BackColor = System.Drawing.Color.Transparent
    End Sub
    Private Sub InitializeComponetControl()
        Me.totalCompraClm.AspectGetter = Function(ByVal row As Object)
                                             If Not IsNothing(row) Then
                                                 Return row.Cant_Conbined * row.precioCompra
                                             End If
                                             Return 0
                                         End Function

        Me.totalVentaClm.AspectGetter = Function(ByVal row As Object)
                                            If Not IsNothing(row) Then
                                                Return row.Cant_Conbined * row.precioVenta
                                            End If
                                            Return 0
                                        End Function

        Me.ObjectListView1.AddDecoration(New EditingCellBorderDecoration(True))


    End Sub
    Private Sub SettingWithPanel()
        Me.PanelViewdata.Width = Me.Width * 0.6
        Me.PanelDetail.Enabled = False
    End Sub
    Private Sub Load_dataProduct()
        Try
            Me.Nom_ComercialLabel.Text = String.Empty
            Using db As New DataContext
                Dim listdata = (From p In db.Productos
                                Join pp In db.ProductoPresentacion On p.idProducto Equals pp.idProducto
                                Where p.IdKind = 2
                                Select New With {pp.idPresentacion, p.idProducto, p.Nom_Comercial,
                                  pp.Presentacion, pp.Cant_Present, pp.precioCompra, pp.precioVenta, pp.Barcode}).ToList()

                Me.ObjectListView1.SetObjects(listdata)

            End Using
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmProductConbined_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        'SettingWithPanel()
    End Sub



    Private Sub View_Details(idProduct As Integer)
        Try
            Using db As New DataContext
                Dim listdata = (From cb In db.ProductCombined
                                Join pp In db.ProductoPresentacion On cb.idPresent Equals pp.idPresentacion
                                Join p In db.Productos On p.idProducto Equals pp.idProducto
                                Where cb.idProducto = idProduct
                                Select New With {cb.idProductCombined, pp.idPresentacion, p.Nom_Comercial,
                                  pp.PresentacionPrint, cb.Cant_Conbined, pp.precioCompra, pp.precioVenta}).ToList()

                Me.DataListView1.DataSource = listdata
                DataListView1.UpdateObjects(Me.DataListView1.Objects)
                idPresentacionclmd.Width = 0
                idPresentacionclmd.IsVisible = False

                sumTotals()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub sumTotals()
        Try
            Dim list = Me.DataListView1.Objects

            If Not IsNothing(list) Then
                Dim item = CType(list, IList)
                If item.Count > 0 Then

                    totalPrecioCompra = Aggregate it In item
                          Into Sum(Double.Parse(it.precioCompra * it.Cant_Conbined))

                    Dim totalVenta = Aggregate it In item
                          Into Sum(Double.Parse(it.precioVenta * it.Cant_Conbined))

                    total_Cant_Present = Aggregate it In item
                          Into Sum(Double.Parse(it.Cant_Conbined))

                    totalCompraLabel.Text = String.Format("Total precio compra: {0}", totalPrecioCompra.ToString("C2"))
                    totalVentaLabel.Text = String.Format("Total al precio venta normal: {0}", totalVenta.ToString("C2"))
                End If
                'Total al precio venta normal: 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        retunrButton_Click(retunrButton, New EventArgs)
    End Sub

    Private Sub NewCombinedButton_Click(sender As Object, e As EventArgs) Handles NewCombinedButton.Click
        If Me.id_NewProduct = 0 Then
            MsgBox("No se ha determiando el producto", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        If AddNewItemConbined() Then
            Me.View_Details(Me.id_NewProduct)
        End If

    End Sub
    Private Function AddNewItemConbined() As Boolean
        Try
            Using newlist As New frmList_ProductoView()
                With newlist
                    .PanelAdmin.Visible = False
                    .SplitContainer1.Panel2.Visible = False
                    .SplitContainer1.SplitterDistance = .Width * 0.97
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If .id_Present > 0 Then
                            Using db As New DataContext

                                Dim item = (From d In db.ProductCombined
                                            Where d.idPresent = .id_Present And d.idProducto = id_NewProduct).FirstOrDefault()

                                If Not IsNothing(item) Then
                                    MsgBox("Este producto ya forma parte de la combinación")
                                    Return False
                                End If

                                Dim newData As New ProductCombined With
                                {
                                    .idPresent = newlist.id_Present,
                                    .idProducto = id_NewProduct,
                                    .Cant_Conbined = 1
                                }

                                db.ProductCombined.InsertOnSubmit(newData)
                                db.SubmitChanges()
                                Return True
                            End Using
                        End If
                    End If
                End With
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub CountButton_Click(sender As Object, e As EventArgs) Handles CountButton.Click
        If Me.DataListView1.SelectedIndices.Count = 1 Then
            Try
                Dim count As Double = DataListView1.SelectedObject.Cant_Conbined

                Using imdata As New frmImputData
                    imdata.txtNumber.Value = count
                    imdata.ShowDialog()
                    If imdata.DialogResult() = DialogResult.OK Then
                        DataListView1.SelectedObject.Cant_Conbined = imdata.txtNumber.Value
                    End If
                End Using

                DataListView1.RefreshObject(DataListView1.SelectedObject)
                sumTotals()
                DataListView1.Select()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Return
            End Try

        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ErrorProvider1.SetError(DeleteButton, String.Empty)
        If Not DataListView1.SelectedIndices.Count = 1 Then
            ErrorProvider1.SetError(DeleteButton, "Seleccione uno de la lista de detalle")
            Return
        End If
        If MsgBox("Está seguro de eliminar este producto", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            If DeleteItem(Integer.Parse(DataListView1.SelectedObject.idProductCombined)) Then
                View_Details(id_NewProduct)
            End If
        End If

    End Sub
    Private Function DeleteItem(idProductCombined As Integer)
        Try
            Using db As New DataContext
                Dim item = (From cb In db.ProductCombined
                            Where cb.idProductCombined = idProductCombined).FirstOrDefault()
                If Not IsNothing(item) Then
                    db.ProductCombined.DeleteOnSubmit(item)
                    db.SubmitChanges()
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        If operation = stateOperation.Insert Then

            If InsertInProdcutPresent() Then
                Load_dataProduct()
                Me.PanelDetail.Enabled = False
                Me.PanelViewdata.Enabled = True
                Me.DataListView1.Select()
            End If
        ElseIf operation = stateOperation.Update Then
            If UpdateInProdcutPresent() Then
                Load_dataProduct()
                Me.PanelDetail.Enabled = False
                Me.PanelViewdata.Enabled = True
                Me.DataListView1.Select()
            End If
        End If
    End Sub

    Private Function UpdateInProdcutPresent() As Boolean
        Try


            Dim transaction As System.Data.Common.DbTransaction

            Dim lis As List(Of itemDeleteble) = New List(Of itemDeleteble)

            For Each item As Object In DataListView1.Objects
                lis.Add(New itemDeleteble With {
                        .IdPresent = item.idPresentacion, .IdProductCombined = item.idProductCombined,
                        .Cant_Conbined = item.Cant_Conbined})
            Next

            Using db As New DataContext
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                For Each item In lis
                    Dim itemEdit = (From cm In db.ProductCombined
                                    Where cm.idProductCombined = item.IdProductCombined).FirstOrDefault()
                    If Not IsNothing(itemEdit) Then
                        itemEdit.Cant_Conbined = item.Cant_Conbined
                    Else
                        Dim newEdit As New ProductCombined With
                        {
                            .Cant_Conbined = item.Cant_Conbined,
                            .idPresent = item.IdPresent,
                            .idProducto = item.IdProducto
                        }
                        db.ProductCombined.InsertOnSubmit(newEdit)
                    End If
                    'update in presentacion
                    Dim itemPresentEdit = (From pp In db.ProductoPresentacion
                                           Where pp.idPresentacion = item.IdPresent).FirstOrDefault()

                    If Not IsNothing(itemPresentEdit) Then
                        itemPresentEdit.belongCombined = 1
                    End If
                Next
                db.SubmitChanges()

                Dim producPresen = (From pp In db.ProductoPresentacion
                                    Where pp.idPresentacion = Me.id_PresentInProduct).FirstOrDefault()
                If Not IsNothing(producPresen) Then
                    producPresen.Cant_Present = total_Cant_Present
                    producPresen.precioCompra = totalPrecioCompra
                Else
                    transaction.Rollback()
                    Return False
                End If
                Try
                    db.SubmitChanges()
                    transaction.Commit()
                Catch ex2 As Exception
                    transaction.Rollback()
                    Me.Cursor = Cursors.Default
                    MsgBox(ex2.Message & ex2.StackTrace, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function InsertInProdcutPresent() As Boolean
        Dim transaction As System.Data.Common.DbTransaction
        Try

            Dim lis As List(Of itemDeleteble) = New List(Of itemDeleteble)

            For Each item As Object In DataListView1.Objects
                lis.Add(New itemDeleteble With {
                        .IdPresent = item.idPresentacion, .IdProductCombined = item.idProductCombined,
                        .Cant_Conbined = item.Cant_Conbined})
            Next


            Using db As New DataContext
                'FIND THE ID EMPAQUETADO
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction

                Dim idEmpaq = db.ProductoUndMedida.Where(Function(x) x.Medida = "EM").FirstOrDefault().idProUndMed
                If IsNothing(idEmpaq) Then
                    MsgBox("No se encontro el idProUndMed para la medida del empaquetado requerido en esta opcion")
                    Return False
                End If

                For Each item2 In lis
                    Dim itemEdit = (From cm In db.ProductCombined
                                    Where cm.idProductCombined = item2.IdProductCombined).FirstOrDefault()
                    If Not IsNothing(itemEdit) Then
                        itemEdit.Cant_Conbined = item2.Cant_Conbined
                    Else
                        Dim newEdit As New ProductCombined With
                        {
                            .Cant_Conbined = item2.Cant_Conbined,
                            .idPresent = item2.IdPresent,
                            .idProducto = item2.IdProducto
                        }
                        db.ProductCombined.InsertOnSubmit(newEdit)
                    End If
                    'update in presentacion
                    Dim itemPresentEdit = (From pp In db.ProductoPresentacion
                                           Where pp.idPresentacion = item2.IdPresent).FirstOrDefault()

                    If Not IsNothing(itemPresentEdit) Then
                        itemPresentEdit.belongCombined = 1
                    End If
                Next
                db.SubmitChanges()

                Dim item As New ProductoPresentacion With
                {
                .Cant_Present = total_Cant_Present,
                .codProducto = Guid.NewGuid().ToString(),
                .CodUser = UsuarioActivo.codUser,
                .idProducto = id_NewProduct,
                .idProUndMed = idEmpaq,
                .idProUndReferen = idEmpaq,
                .Empaquetado = total_Cant_Present,
                .precioCompra = totalPrecioCompra,
                .precioVenta = 0,
                .isPresentFactory = 0
                  }
                db.ProductoPresentacion.InsertOnSubmit(item)
                db.SubmitChanges()
                id_PresentInProduct = item.idPresentacion
                transaction.Commit()
                Return True
            End Using
            Return False
        Catch ex As Exception
            If Not IsNothing(transaction) Then
                transaction.Rollback()
            End If

            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function DeleteNewProductConbinedCommand() As Boolean
        Try
            Dim transaction As System.Data.Common.DbTransaction

            Using db As New DataContext

                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()

                db.Transaction = transaction

                Dim deleteItem =
                        (From p In db.Productos
                         Where p.idProducto = Me.id_NewProduct
                         ).FirstOrDefault()

                Dim customersWithoutOrders As _
                        IEnumerable(Of ProductCombined) =
                        (From cb In db.ProductCombined
                         Where cb.idProducto = Me.id_NewProduct
                         Select cb).ToList()

                db.ProductCombined.DeleteAllOnSubmit(customersWithoutOrders)
                db.Productos.DeleteOnSubmit(deleteItem)

                Try
                    db.SubmitChanges()
                    transaction.Commit()
                Catch ex2 As Exception
                    transaction.Rollback()
                    Me.Cursor = Cursors.Default
                    MsgBox(ex2.Message & ex2.StackTrace, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
                Return True
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Function DeleteProductConbinedCommand() As Boolean
        Try
            Dim transaction As System.Data.Common.DbTransaction

            Dim lis As List(Of itemDeleteble) = New List(Of itemDeleteble)

            For Each item As Object In ObjectListView1.SelectedObjects
                lis.Add(New itemDeleteble With {.IdProducto = item.idProducto})
            Next

            Using db As New DataContext

                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()

                db.Transaction = transaction
                For Each item In lis
                    Dim deleteItem =
                        (From p In db.Productos
                         Where p.idProducto = item.IdProducto
                         ).FirstOrDefault()

                    Dim presentations As _
                        IEnumerable(Of ProductCombined) =
                        (From cb In db.ProductCombined
                         Where cb.idProducto = item.IdProducto
                         Select cb).ToList()

                    db.ProductCombined.DeleteAllOnSubmit(presentations)
                    db.Productos.DeleteOnSubmit(deleteItem)
                    db.SubmitChanges()
                Next
                Try
                    db.SubmitChanges()
                    transaction.Commit()
                Catch ex2 As Exception
                    transaction.Rollback()
                    Me.Cursor = Cursors.Default
                    MsgBox(ex2.Message & ex2.StackTrace, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
                Return True
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Class itemDeleteble
        Private _idProductCombined As Integer
        Public Property IdProductCombined() As Integer
            Get
                Return _idProductCombined
            End Get
            Set(ByVal value As Integer)
                _idProductCombined = value
            End Set
        End Property
        Private _idProduct As Integer
        Public Property IdProducto() As Integer
            Get
                Return _idProduct
            End Get
            Set(ByVal value As Integer)
                _idProduct = value
            End Set
        End Property
        Private _idPresent As Integer
        Public Property IdPresent() As Integer
            Get
                Return _idPresent
            End Get
            Set(ByVal value As Integer)
                _idPresent = value
            End Set
        End Property
        Private _Cant_Conbined As Double
        Public Property Cant_Conbined() As Double
            Get
                Return _Cant_Conbined
            End Get
            Set(ByVal value As Double)
                _Cant_Conbined = value
            End Set
        End Property
    End Class

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Try
            id_NewProduct = 0
            id_PresentInProduct = 0
            operation = stateOperation.Insert
            Using newDetail As New frm_detalle(stateOperation.Insert, 0, IdKind:=2)
                newDetail.PanelFood.Visible = True
                newDetail.AdminDateExpirateCheckBox.Enabled = False
                newDetail.ivaPreserminadoLinkLabel.Enabled = False
                newDetail.ShowDialog()
                If newDetail.DialogResult = DialogResult.OK Then
                    id_NewProduct = newDetail.Id_Producto
                    Me.PanelTools.Enabled = False
                    Me.PanelViewdata.Enabled = False
                    Me.PanelDetail.Enabled = True
                    View_Details(id_NewProduct)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If Me.ObjectListView1.SelectedObjects.Count > 0 Then
            If MsgBox("Está seguro de eliminar los productos seleccionados..",
                   MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                If DeleteProductConbinedCommand() Then
                    Me.Load_dataProduct()
                End If
            End If
        End If
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If Not Me.ObjectListView1.SelectedObjects.Count = 1 Then
                Return
            End If
            operation = stateOperation.Update

            Me.PanelDetail.Enabled = True
            Me.PanelViewdata.Enabled = False

            Dim item = ObjectListView1.SelectedObject

            Dim item2 As String() = Split(item.ToString, ",")
            If item2.Count = 0 Then
                Return
            End If
            id_NewProduct = Strings.Right(item2(1), item2(1).Length - Strings.InStr(item2(1), "="))
            id_PresentInProduct = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
            Me.Nom_ComercialLabel.Text = Strings.Right(item2(2), item2(2).Length - Strings.InStr(item2(2), "="))
            View_Details(id_NewProduct)
            DataListView1.Select()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub retunrButton_Click(sender As Object, e As EventArgs) Handles retunrButton.Click
        If operation = stateOperation.Insert Then
            If Me.id_PresentInProduct = 0 Then
                sql = "A un no se ha agregado productos para combinar." & vbCrLf & vbCrLf
                sql = sql & "En realidad desea cancelar la operación.?" & vbCrLf

                If MsgBox(sql, MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                          MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                    Me.DeleteNewProductConbinedCommand()
                Else
                    Return
                End If
            End If
        End If
        Me.PanelDetail.Enabled = False
        Me.PanelViewdata.Enabled = True
        Me.ObjectListView1.Select()
    End Sub

    Private Sub SettingSalesButton_Click(sender As Object, e As EventArgs) Handles SettingSalesButton.Click
        Try
            If Not ObjectListView1.SelectedObjects.Count = 1 Then
                MsgBox("Selecccione uno del listado ", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            'emviaamos el prodcuto a la tabla temporal
            Me.Cursor = Cursors.WaitCursor
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "Delete [tmp].[SelectMyProduct]  WHERE ((codUser=@codUser) AND (codTerminal=@codTerminal))"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    'eLIMINACION
                    cmd.Parameters.AddWithValue("@codUser", UsuarioActivo.codUser)
                    cmd.Parameters.AddWithValue("@codTerminal", TerminalActivo.codTerminal)
                    cmd.ExecuteNonQuery()
                    'agregaremos
                    sql = "Insert [tmp].[SelectMyProduct] (idProducto,codUser,codTerminal) "
                    sql = sql & "Values (@idProducto,@codUser,@codTerminal)"
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@idProducto", Me.id_NewProduct)
                    If Not (cmd.ExecuteNonQuery() = 1) Then
                        Return
                    End If
                End Using
            End Using

            Me.Cursor = Cursors.WaitCursor
            Using forAdminPrice As New frmAdministrarPrecios(stateLoad.Dialogo)
                With forAdminPrice
                    .Text = "Administradondo precios"
                    .txtProduc_Select.Text = Nom_ComercialLabel.Text
                    .StartPosition = FormStartPosition.CenterScreen
                    .FormBorderStyle = FormBorderStyle.Fixed3D
                    .WindowState = FormWindowState.Normal
                    .Height = 800
                    .Width = 3000
                    .Text = String.Format("Administrando precios de venta.")
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.Load_dataProduct()
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

    Private Sub ObjectListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ObjectListView1.SelectedIndexChanged
        If Not Me.ObjectListView1.SelectedObjects.Count = 1 Then
            Return
        End If
        Try
            Me.id_NewProduct = Me.ObjectListView1.SelectedObject.idProducto
            Me.id_PresentInProduct = Me.ObjectListView1.SelectedObject.idPresentacion
            Me.Nom_ComercialLabel.Text = Me.ObjectListView1.SelectedObject.Nom_Comercial
            If Not IsNothing(Me.ObjectListView1.SelectedObject.Barcode) Then
                Me.Barcode = Trim(Me.ObjectListView1.SelectedObject.Barcode)
                DrawCodBarr(Me.Barcode)
            Else
                Me.PictureBox1.Image = Nothing
                Me.barCodeTextBox.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SettingSalesButton_EnabledChanged(sender As Object, e As EventArgs) Handles SettingSalesButton.EnabledChanged
        SettingSalesButton.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        GeneratedBarCode()
    End Sub
    Private Sub GeneratedBarCode()
        Try
            If Not (Me.ObjectListView1.SelectedObjects.Count = 1) Then
                Return
            End If
            Using frmBarrCodes As New frmBarrCode
                With frmBarrCodes
                    .ProductoLabel.Text = Nom_ComercialLabel.Text
                    .PresentacionLabel.Text = String.Empty
                    .idPresent = Me.id_PresentInProduct
                    .barCodeTextBox.Text = Barcode
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        DrawCodBarr(.barCodeTextBox.Text)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DrawCodBarr(Optional barCodeNew As String = "")
        Try
            Dim codBarr As String = barCodeNew
            Dim labelProduct As String = Me.ObjectListView1.SelectedObject.Nom_Comercial
            Dim priceProduct As Double = Me.ObjectListView1.SelectedObject.precioVenta
            Dim empProduct As String = Me.ObjectListView1.SelectedObject.Presentacion
            PictureBoxCopy = DrawBarCode.DrawBarCodeAndLabel(Trim(codBarr), labelProduct, priceProduct, empProduct, 2, isPrintLabel:=True)
            Me.PictureBox1.Image = PictureBoxCopy
            Me.barCodeTextBox.Text = codBarr
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
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

    Private Sub textBoxFilterSimple_TextChanged(sender As Object, e As EventArgs) Handles textBoxFilterSimple.TextChanged
        Me.TimedFilter(Me.ObjectListView1, textBoxFilterSimple.Text)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String)
        Me.TimedFilter(olv, txt, 0)
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Try
            operation = stateOperation.Update
            Using newDetail As New frm_detalle(stateOperation.Update, _idProducto:=Me.id_NewProduct, IdKind:=2)
                newDetail.PanelFood.Visible = True
                newDetail.AdminDateExpirateCheckBox.Enabled = False
                newDetail.ivaPreserminadoLinkLabel.Enabled = False
                newDetail.ShowDialog()
                If newDetail.DialogResult = DialogResult.OK Then
                    id_NewProduct = newDetail.Id_Producto
                    Me.PanelTools.Enabled = False
                    Me.PanelViewdata.Enabled = False
                    Me.PanelDetail.Enabled = True
                    View_Details(id_NewProduct)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by Refactoring Essentials.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
