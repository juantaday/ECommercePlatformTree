Imports System.ComponentModel.DataAnnotations
'this is colleccion the select for view for sales......
Public Class PresentVendiblescollection
    Public Sub New(ByVal idPresent As Integer, ByVal idProduct As Integer, ByVal codProducto As String,
                  ByVal barcode As String, ByVal nomComercial As String,
                   ByVal presentPrint As String, ByVal pryceCompra As Double, pryceVenta As Double,
                   ByVal ivaPercent As Double, ByVal ratesPercent As Double, ByVal fromC As Double,
                   ByVal medida As String, ByVal empaquetado As Decimal, ByVal isDefaultSales As Boolean)

        _idPresent = idPresent
        _idProducto = idProduct
        _CodProducto = codProducto
        _BarCode = barcode
        _NomComercial = nomComercial
        _PresentationPrint = presentPrint
        _PrecioCompra = pryceCompra
        _PrecioVenta = pryceVenta
        _ivaPorcentage = ivaPercent
        _RatesPercent = ratesPercent
        _FromC = fromC
        _medida = medida
        _empaquetado = empaquetado
        _isDefaultSales = isDefaultSales
    End Sub
    Private _empaquetado As Decimal
    Private _isDefaultSales As Boolean
    Private _medida As String
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
    Private _CodProducto As String
    Public Property CodProducto() As String
        Get
            Return Trim(_CodProducto)
        End Get
        Set(ByVal value As String)
            _CodProducto = value
        End Set
    End Property
    Private _BarCode As String
    Public Property Barcode() As String
        Get
            Return Trim(_BarCode)
        End Get
        Set(ByVal value As String)
            _BarCode = value
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
    Private _PresentationPrint As String
    Public Property PresentationPrint() As String
        Get
            Return _PresentationPrint
        End Get
        Set(ByVal value As String)
            _PresentationPrint = value
        End Set
    End Property
    Private _PrecioCompra As Double
    Public Property PrecioCompra() As Double
        Get
            Return _PrecioCompra
        End Get
        Set(ByVal value As Double)
            _PrecioCompra = value
        End Set
    End Property
    Private _PrecioVenta As Double
    Public Property PrecioVenta() As Double
        Get
            Return _PrecioVenta
        End Get
        Set(ByVal value As Double)
            _PrecioVenta = value
        End Set
    End Property
    Private _ivaPorcentage As Double
    Public Property IvaPercent() As Double
        Get
            Return _ivaPorcentage
        End Get
        Set(ByVal value As Double)
            _ivaPorcentage = value
        End Set
    End Property
    Private _RatesPercent As Double
    Public Property RatesPercent() As Double
        Get
            Return _RatesPercent
        End Get
        Set(ByVal value As Double)
            _RatesPercent = value
        End Set
    End Property
    Private _FromC As Double
    Public Property FromC() As Double
        Get
            Return _FromC
        End Get
        Set(ByVal value As Double)
            _FromC = value
        End Set
    End Property

    Public Property Medida As String
        Get
            Return _medida
        End Get
        Set(value As String)
            _medida = value
        End Set
    End Property
    Public Property Empaquetado As Decimal
        Get
            Return _empaquetado
        End Get
        Set(value As Decimal)
            _empaquetado = value
        End Set
    End Property
    Public Property IsDefaultSales As Boolean
        Get
            Return _isDefaultSales
        End Get
        Set(value As Boolean)
            _isDefaultSales = value
        End Set
    End Property

End Class
