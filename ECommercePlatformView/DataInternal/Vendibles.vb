Module Vendibles
    Private RatesStruccture As String
    Private IDRates As Integer
    Public Async Function GetListVendibles(ByVal ratesStruccture As String, ByVal idRates As Integer) As Task
        Vendibles.RatesStruccture = ratesStruccture
        Vendibles.IDRates = idRates
        Await Task.Factory.StartNew(Sub() GetDataExternal())
    End Function

    Public Async Function GetRates(idRate As Integer) As Task
        Await Task.Factory.StartNew(Sub() SetRates(idRate))
    End Function
    Private Function GetDataExternal()
        Try
            If Not ListVendiblescollection IsNot Nothing Then
                ListVendiblescollection = New List(Of PresentVendiblescollection)
            End If
            ListOfertas = New List(Of Ofertas)

            ListVendiblescollection.Clear()

            Using db As New DataContext
                Dim mylist = From pp In db.ProductoPresentacion
                             Join p In db.Productos On p.idProducto Equals pp.idProducto
                             Join sc In db.ProductoSubCategoria On sc.idSubCategoria Equals p.IdSubCategoria
                             Join m In db.ProductoUndMedida On pp.idProUndMed Equals m.idProUndMed
                             Where p.Activo = True
                             Select New With {pp, p.Nom_Comercial, sc.idSubCategoria, sc.idCategoria, m.Nom_Medida, p.ivaPorcentaje}

                Dim myVendible As IQueryable

                Select Case RatesStruccture
                    Case "Categoría"
                        Dim ratesDetail = (From r In db.RatesCategoryDetail Where r.idRates = IDRates)

                        myVendible = From d In mylist
                                     Group Join c In ratesDetail On d.idCategoria Equals c.idCategory
                                     Into PetList = Group
                                     From Pet In PetList.DefaultIfEmpty()
                                     Select New With {d, Key .Fromc = If(Pet Is Nothing, 0, Pet.FromC), Key .PercentC = If(Pet Is Nothing, 0, Pet.PercentC)}

                    Case "Sub Categoría"
                        Dim ratesDetail = (From r In db.RatesSubCategoryDetail Where r.idRates = idRates)

                        myVendible = From d In mylist
                                     Group Join c In ratesDetail On d.idSubCategoria Equals c.idSubCategory
                                         Into PetList = Group
                                     From Pet In PetList.DefaultIfEmpty()
                                     Select New With {d, Key .Fromc = If(Pet Is Nothing, 0, Pet.FromC), Key .PercentC = If(Pet Is Nothing, 0, Pet.PercentC)}

                    Case "Producto"
                        Dim ratesDetail = (From r In db.RatesProductoDetail Where r.idRates = idRates)

                        myVendible = From d In mylist
                                     Group Join c In ratesDetail On d.pp.idProducto Equals c.idProducto
                                         Into PetList = Group
                                     From Pet In PetList.DefaultIfEmpty()
                                     Select New With {d, Key .Fromc = If(Pet Is Nothing, 0, Pet.FromC), Key .PercentC = If(Pet Is Nothing, 0, Pet.PercentC)}

                    Case "Presentacion"
                        Dim ratesDetail = (From r In db.RatesPresentantionDetail Where r.idRates = idRates)

                        myVendible = From d In mylist
                                     Group Join c In ratesDetail On d.pp.idPresentacion Equals c.idPresentacion
                                             Into PetList = Group
                                     From Pet In PetList.DefaultIfEmpty()
                                     Select New With {d, Key .Fromc = If(Pet Is Nothing, 0, Pet.FromC), Key .PercentC = If(Pet Is Nothing, 0, Pet.PercentC)}
                    Case Else
                        myVendible = From d In mylist
                                     Select New With {d, Key .Fromc = 0, Key .PercentC = 0}

                End Select

                For Each item In myVendible
                    ListVendiblescollection.Add(New PresentVendiblescollection(item.d.pp.idPresentacion,
                                                                                     item.d.pp.idProducto,
                                                                                     item.d.pp.codProducto,
                                                                                     item.d.pp.Barcode,
                                                                                     item.d.Nom_Comercial,
                                                                                     item.d.pp.PresentacionPrint,
                                                                                     item.d.pp.precioCompra,
                                                                                     item.d.pp.precioVenta,
                                                                                     item.d.ivaPorcentaje,
                                                                                     item.PercentC,
                                                                                     item.Fromc,
                                                                                     item.d.Nom_Medida,
                                                                                     item.d.pp.Empaquetado,
                                                                                     item.d.pp.isDefaultSales))
                Next

                ListOfertas = (From o In db.Ofertas).ToList()
            End Using

            Return ListVendiblescollection.Count > 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar Item Producto")
            Return False
        End Try
    End Function

    Private Sub SetRates(_IdRates As Integer)
        Try
            DeFaultRates = New _RateDefault()
            Using db As New DataContext
                Dim _rates = From r In db.Rates
                             Where r.idRates = _IdRates

                For Each item In _rates
                    DeFaultRates.IDRates = item.idRates
                    DeFaultRates.RatesStruccture = item.Structure
                    DeFaultRates.RatesTyPe = item.TypeRate
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

End Module
