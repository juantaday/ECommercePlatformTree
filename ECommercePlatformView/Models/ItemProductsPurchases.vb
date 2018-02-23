Imports CADsisVenta.DataSetCompras

Public Class ItemProductsPurchases
    Public Sub New()

    End Sub

    Private _codProducto As String
    Public Property CodProducto() As String
        Get
            Return _codProducto
        End Get
        Set(ByVal value As String)
            _codProducto = value
        End Set
    End Property
    Private _CostoTotal As Double
    Public Property CostoTotal() As Double
        Get
            Return _CostoTotal
        End Get
        Set(ByVal value As Double)
            _CostoTotal = value
        End Set
    End Property
    Private _idPresentacion As Integer
    Public Property idPresentacion() As Integer
        Get
            Return _idPresentacion
        End Get
        Set(ByVal value As Integer)
            _idPresentacion = value
        End Set
    End Property
    Private _idProducto As Integer
    Public Property idProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property
    Private _ItIsExpirable As Boolean
    Public Property ItIsExpirable() As Boolean
        Get
            Return _ItIsExpirable
        End Get
        Set(ByVal value As Boolean)
            _ItIsExpirable = value
        End Set
    End Property
    Private _ivaPorcentaje As Double
    Public Property ivaPorcentaje() As Double
        Get
            Return _ivaPorcentaje
        End Get
        Set(ByVal value As Double)
            _ivaPorcentaje = value
        End Set
    End Property
    Private _NomComercial As String
    Public Property NomComercial() As String
        Get
            Return _NomComercial
        End Get
        Set(ByVal value As String)
            _NomComercial = value
        End Set
    End Property
End Class
