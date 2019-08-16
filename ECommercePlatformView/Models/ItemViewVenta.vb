Imports System.ComponentModel.DataAnnotations
'this is colleccion the item sales for client
Public Class ItemViewVenta

    Public Sub New(ByVal idPresent As Integer, ByVal idProduct As Integer, ByVal codProducto As String,
                   ByVal nomComercial As String, ByVal presentationPrint As String,
                   ByVal cuantity As Double, ByVal unitPrice As Double, ByVal discount As Double,
                   ByVal rates As Double, ByVal ivaPercent As Double, ByVal lastPurcharsePrice As Double,
                   ByVal averagePrice As Double)
        _idPresent = idPresent
        _idProducto = idProduct
        _codProducto = codProducto
        _nomComercial = nomComercial
        _presentPrint = presentationPrint
        _cuantity = cuantity
        _unitPrice = unitPrice
        _discount = discount
        _rates = rates
        _ivaPercent = ivaPercent
        _lastPurchasePrice = lastPurcharsePrice
        _averagePrice = averagePrice
    End Sub
    Public Sub New()
    End Sub
    Private _Empaquetado As Decimal
    Private _isDefaultSales As Boolean

    Private _idPresent As Integer
    <Key>
    Public Property IdPresent() As Integer
        Get
            Return _idPresent
        End Get
        Set(ByVal value As Integer)
            _idPresent = value
        End Set
    End Property
    Private _idProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property
    Private _codProducto As String
    Public Property CodProducto() As String
        Get
            Return _codProducto
        End Get
        Set(ByVal value As String)
            _codProducto = value
        End Set
    End Property
    Private _nomComercial As String
    Public Property Nom_Comercial() As String
        Get
            Return _nomComercial
        End Get
        Set(ByVal value As String)
            _nomComercial = value
        End Set
    End Property
    Private _presentPrint As String
    Public Property PresentationPrint() As String
        Get
            Return _presentPrint
        End Get
        Set(ByVal value As String)
            _presentPrint = value
        End Set
    End Property
    Private _cuantity As Double
    Public Property Cuantity() As Double
        Get
            Return _cuantity
        End Get
        Set(ByVal value As Double)
            _cuantity = value
        End Set
    End Property
    Private _unitPrice As Double
    Public Property UnitPrice() As Double
        Get
            Return _unitPrice
        End Get
        Set(ByVal value As Double)
            _unitPrice = value
        End Set
    End Property
    Public Property PartialPrice() As Double
        Get
            Return Me.Cuantity * Me.UnitPrice
        End Get
        Set(ByVal value As Double)
        End Set
    End Property

    Private _discount As Double
    Public Property Discount() As Double
        Get
            Return _discount
        End Get
        Set(ByVal value As Double)
            _discount = value
        End Set
    End Property
    Private _rates As Double
    Public Property Rates() As Double
        Get
            Return _rates
        End Get
        Set(ByVal value As Double)
            _rates = value
        End Set
    End Property
    Private _ivaPercent As Double
    Public Property IvaPercent() As Double
        Get
            Return _ivaPercent
        End Get
        Set(ByVal value As Double)
            _ivaPercent = value
        End Set
    End Property
    'Rrecio de Iva
    Public Property PriceVat() As Double
        Get
            If Me.IvaPercent > 0 Then
                Return Me.TotalPrice - (Me.TotalPrice / (1 + Me.IvaPercent))
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Double)
        End Set
    End Property
    'base de iva
    Public Property BaseVat() As Double
        Get
            If Me.IvaPercent > 0 Then
                Return Me.TotalPrice / (1 + Me.IvaPercent)
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Double)
        End Set
    End Property
    Private _lastPurchasePrice As Double
    Public Property LastPurchasePrice() As Double
        Get
            Return _lastPurchasePrice
        End Get
        Set(ByVal value As Double)
            _lastPurchasePrice = value
        End Set
    End Property
    Private _averagePrice As Double
    Public Property AveragePrice() As Double
        Get
            Return _averagePrice
        End Get
        Set(ByVal value As Double)
            _averagePrice = value
        End Set
    End Property
    Public Property TotalPrice() As Double
        Get
            Return ((Me.PartialPrice + Me.Rates) - Me.Discount)
        End Get
        Set(ByVal value As Double)
        End Set
    End Property
    Private _DoNotUpdate As Boolean
    Public Property DoNotUpdate() As Boolean
        Get
            Return _DoNotUpdate
        End Get
        Set(ByVal value As Boolean)
            _DoNotUpdate = value
        End Set
    End Property
End Class
