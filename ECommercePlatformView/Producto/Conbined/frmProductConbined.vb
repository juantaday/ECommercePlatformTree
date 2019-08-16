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

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ObjectListView1.AddDecoration(New EditingCellBorderDecoration(True))
    End Sub

    Private Sub Load_dataProduct()
        Try

            Using db As New DataContext
                Dim listdata = (From p In db.Productos
                                Join pp In db.ProductoPresentacion On p.idProducto Equals pp.idProducto
                                Where p.IdKind = 2
                                Select New ItemViewProductCombined With {.idPresent = pp.idPresentacion, .idProducto = p.idProducto, .Nom_Comercial = p.Nom_Comercial,
                                  .Presentacion = pp.Presentacion, .Cant_Conbined = pp.Cant_Present,
                                  .PrecioCompra = pp.precioCompra, .PrecioVenta = pp.precioVenta,
                                  .Barcode = pp.Barcode, .Button = "Ver detalle"}).ToList()

                Me.ObjectListView1.SetObjects(listdata)

            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemViewProductCombined
        Inherits ProductCombined
        Private _Nom_Comercial As String
        Public Property Nom_Comercial() As String
            Get
                Return _Nom_Comercial
            End Get
            Set(ByVal value As String)
                _Nom_Comercial = value
            End Set
        End Property
        Private _Prsentacion As String
        Public Property Presentacion() As String
            Get
                Return _Prsentacion
            End Get
            Set(ByVal value As String)
                _Prsentacion = value
            End Set
        End Property
        Private _precioCompra As Double
        Public Property PrecioCompra() As Double
            Get
                Return _precioCompra
            End Get
            Set(ByVal value As Double)
                _precioCompra = value
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
        Private _barcode As String
        Public Property Barcode() As String
            Get
                Return _barcode
            End Get
            Set(ByVal value As String)
                _barcode = value
            End Set
        End Property

        Public ReadOnly Property Utilidad() As Double
            Get
                Return Me.PrecioVenta - Me.PrecioCompra
            End Get
        End Property
        Public ReadOnly Property Rentabilidad() As String
            Get
                If Me.PrecioCompra > 0 Then
                    Return ((Me.PrecioVenta - Me.PrecioCompra) / Me.PrecioCompra).ToString("P2")
                Else
                    Return "- %"
                End If

            End Get
        End Property
        Private _button As String
        Public Property Button() As String
            Get
                Return _button
            End Get
            Set(ByVal value As String)
                _button = value
            End Set
        End Property
    End Class

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
                    View_Details(id_NewProduct)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub View_Details(id As Integer)
        Try
            Using ViewDetail As New frmViewCombinedDetail(stateOperation.Update,
                   id, Me.id_PresentInProduct)

                ViewDetail.ShowDialog()
                If ViewDetail.DialogResult = DialogResult.OK Then
                    Load_dataProduct()
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, vbCritical, "Error")
        End Try
    End Sub

    Private Sub frmProductConbined_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_dataProduct()
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.Transparent
        BunifuThinButton24.BackColor = System.Drawing.Color.Transparent
        BunifuThinButton25.BackColor = System.Drawing.Color.Transparent
    End Sub


    Private Sub NewCombinedButton_Click(sender As Object, e As EventArgs)
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
            Using newlist As New frmList_ProductoView(stateLoad.Dialogo)
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


    Private Function DeleteProductConbinedCommand(Optional idNewProduct As Integer = 0) As Boolean
        Try
            Dim transaction As System.Data.Common.DbTransaction

            Dim lis As List(Of itemDeleteble) = New List(Of itemDeleteble)

            If idNewProduct > 0 Then
                lis.Add(New itemDeleteble With {.IdProducto = idNewProduct})
            Else
                For Each item As Object In ObjectListView1.SelectedObjects
                    lis.Add(New itemDeleteble With {.IdProducto = item.idProducto})
                Next
            End If


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
                    Return True
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
                    Me.id_NewProduct = newDetail.Id_Producto

                    Using ViewDetail As New frmViewCombinedDetail(operation, Me.id_NewProduct)
                        ViewDetail.Nom_ComercialLabel.Text = newDetail.Nom_Comercialtxt.Text
                        ViewDetail.ShowDialog()
                        If ViewDetail.DialogResult = DialogResult.OK Then
                            Me.Load_dataProduct()
                        Else
                            DeleteProductConbinedCommand(Me.id_NewProduct)
                        End If
                    End Using
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


    Private Sub retunrButton_Click(sender As Object, e As EventArgs)
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
                    .txtProduc_Select.Text = Me.ObjectListView1.SelectedObject.Nom_Comercial
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
            Me.id_PresentInProduct = Me.ObjectListView1.SelectedObject.idPresent 'idPresent
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
            Barcode = String.Empty
            If Not (Me.ObjectListView1.SelectedObjects.Count = 1) Then
                Return
            End If
            Using frmBarrCodes As New frmBarrCode
                With frmBarrCodes
                    .ProductoLabel.Text = Me.ObjectListView1.SelectedObject.Nom_Comercial
                    .PresentacionLabel.Text = String.Empty
                    .idPresent = Me.id_PresentInProduct
                    .barCodeTextBox.Text = Me.ObjectListView1.SelectedObject.Barcode
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        DrawCodBarr(.barCodeTextBox.Text)
                        Dim detail = DirectCast(ObjectListView1.SelectedObject, ItemViewProductCombined)
                        If detail IsNot Nothing Then
                            detail.Barcode = frmBarrCodes.barCodeTextBox.Text
                            ObjectListView1.RefreshObject(ObjectListView1.SelectedObject)
                        End If
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
                    Dim detail = DirectCast(ObjectListView1.SelectedObject, ItemViewProductCombined)
                    If detail IsNot Nothing Then
                        detail.Nom_Comercial = newDetail.Nom_Comercialtxt.Text
                        ObjectListView1.RefreshObject(ObjectListView1.SelectedObject)
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ObjectListView1_CellClick(sender As Object, e As CellClickEventArgs) Handles ObjectListView1.CellClick


        If e.RowIndex >= 0 AndAlso e.Column.AspectName = "Button" Then 'VerButtonColumn
            Try
                Me.id_NewProduct = Me.ObjectListView1.SelectedObject.idProducto
                Me.id_PresentInProduct = Me.ObjectListView1.SelectedObject.idPresent
                Using ViewDetail As New frmViewCombinedDetail(stateOperation.Update,
                    Me.id_NewProduct, Me.id_PresentInProduct)
                    ViewDetail.Nom_ComercialLabel.Text = Me.ObjectListView1.SelectedObject.Nom_Comercial
                    ViewDetail.ShowDialog()
                    If ViewDetail.DialogResult = DialogResult.OK Then
                        Load_dataProduct()
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, vbCritical, "Error")
            End Try

        End If
    End Sub


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


    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by Refactoring Essentials.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
