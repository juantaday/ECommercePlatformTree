Imports System.Windows.Forms
Imports BrightIdeasSoftware

Public Class frmViewCombinedDetail
    Private id_NewProduct As Integer
    Private Barcode As String
    Private id_PresentInProduct As Integer
    Private totalPrecioCompra As Double
    Private total_Cant_Present As Double
    Private operation As stateOperation
    Private PictureBoxCopy As Bitmap
    Private listItemProductCombined As List(Of ProductCombined)
    Sub New(_operation As stateOperation, idProduct As Integer, Optional idPresentInProduct As Integer = 0)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.operation = _operation
        id_NewProduct = idProduct
        Me.id_PresentInProduct = idPresentInProduct
        InitializeComponetControl()
    End Sub
    Private Sub FrmViewCombinedDEtail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_Details(id_NewProduct)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ErrorProvider1.SetError(DeleteButton, String.Empty)
        If Not DataListView1.SelectedIndices.Count = 1 Then
            ErrorProvider1.SetError(DeleteButton, "Seleccione uno de la lista de detalle")
            Return
        End If
        If MsgBox("Está seguro de eliminar este producto", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            DataListView1.RemoveObject(DataListView1.SelectedObject)
            DataListView1.RefreshObjects(DataListView1.Objects)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidarDatos() Then
            If operation = stateOperation.Insert Then
                If InsertInProdcutPresent() Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            ElseIf operation = stateOperation.Update Then
                If UpdateInProdcutPresent() Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            Dim i As Integer = 0
            For Each item As Object In DataListView1.Objects
                i += 1
            Next
            If i < 2 Then
                MsgBox("Para que sea un producto combinado al menos debe contener dos productos..", MsgBoxStyle.Exclamation, "Import..")
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

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
                    Return True
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
        Dim transaction As System.Data.Common.DbTransaction = Nothing
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


End Class
