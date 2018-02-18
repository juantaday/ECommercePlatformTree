Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class ItemAcquisition
    Implements INotifyPropertyChanged
#Region "Atributes"
    Private idValue As Guid = Guid.NewGuid()
    Private _idPresent As Integer
    Private _producto As String
    Private _codigo As String
    Private _idProducto As Integer
    Private _count As Double
    Private _unitPrice As Double
    Private _discount As Double
    Private _iva As Double
    Private _totalParcial As Double
    Private _includeIva As Boolean
    Private _ivaPercent As Double
    Private _dateExpire As Date
    Private _isExpirate As Boolean
    Private _isIncludeDiscount As Boolean
#End Region

#Region "Constructor"
    Public Sub New(ByVal codigo As String, ByVal count As Double, ByVal dateExpire As Date, ByVal discount As Double,
            ByVal idPresent As Integer, ByVal idProducto As Integer, ByVal includeIva As Boolean, ByVal iva As Double,
            ByVal ivaPercent As Double, ByVal producto As String, ByVal unitPrice As Double, ByVal totalParcial As Double,
                   ByVal isExpirate As Boolean, ByVal isIncludeDiscount As Boolean)
        _codigo = codigo
        _count = count
        _dateExpire = dateExpire
        _discount = discount
        _idPresent = idPresent
        _idProducto = idProducto
        _includeIva = includeIva
        _iva = iva
        _ivaPercent = ivaPercent
        _producto = producto
        _unitPrice = unitPrice
        _totalParcial = totalParcial
        _isExpirate = isExpirate
        _isIncludeDiscount = isIncludeDiscount
    End Sub
    Public Sub New()

    End Sub
    Public Sub New(ByVal other As ItemAcquisition)
        Me.Codigo = other.Codigo
        Me.Count = other.Count
        Me.DateExpire = other.DateExpire
        Me.Discount = other.Discount
        Me.IdPresent = other.IdPresent
        Me.IdProducto = other.IdProducto
        Me.IsIncludeIva = other.IsIncludeIva
        Me.IvaPercent = other.IvaPercent
        Me.Producto = other.Producto
        Me.IsExpirate = other.IsExpirate
        Me.UnitPrice = other.UnitPrice
        Me.IsIncludeDiscount = other.IsIncludeDiscount
        Me.TotalParcial = other.TotalParcial
    End Sub
#End Region

#Region "Properties"
    Public IsValitedUnitPrice As Boolean = True
    Public IsRountIva As Boolean = False
    Public ReadOnly Property ID() As Guid
        Get
            Return Me.idValue
        End Get
    End Property

    <Key>
    Public Property IdPresent() As Integer
        Get
            Return _idPresent
        End Get
        Set(ByVal value As Integer)
            _idPresent = value
        End Set
    End Property
    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Public Property Producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal value As String)
            _producto = value
            OnPropertyChanged(NameOf(Producto))
        End Set
    End Property
    Public Property Count As Double
        Get
            Return _count
        End Get
        Set(value As Double)
            _count = value
        End Set
    End Property

    Public Property UnitPrice As Double
        Get
            Return _unitPrice
        End Get
        Set(value As Double)
            _unitPrice = value
        End Set
    End Property

    Public Property Discount As Double
        Get
            Return _discount
        End Get
        Set(value As Double)
            _discount = value
        End Set
    End Property

    Public ReadOnly Property Iva As Double
        Get
            If IsIncludeIva Then
                Return Me.TotalParcial - (TotalParcial / (1 + Me.IvaPercent))
            Else
                If IsRountIva Then
                    Return FormatNumber(Me.TotalParcial * Me.IvaPercent, 2)
                Else
                    Return Me.TotalParcial * Me.IvaPercent
                End If
            End If
        End Get
    End Property

    Public Property TotalParcial As Double
        Get
            If IsValitedUnitPrice Then
                Return UnitPrice * Count
            Else
                Return _totalParcial
            End If
        End Get
        Set(value As Double)
            If Not IsValitedUnitPrice Then
                _totalParcial = value
            End If
        End Set
    End Property

    Public Property IsIncludeIva As Boolean
        Get
            Return _includeIva
        End Get
        Set(value As Boolean)
            _includeIva = value
        End Set
    End Property

    Public Property IvaPercent As Double
        Get
            Return _ivaPercent
        End Get
        Set(value As Double)
            _ivaPercent = value
        End Set
    End Property

    Public Property DateExpire As Date
        Get
            Return _dateExpire
        End Get
        Set(value As Date)
            _dateExpire = value
        End Set
    End Property

    Public Property IsExpirate As Boolean
        Get
            Return _isExpirate
        End Get
        Set(value As Boolean)
            _isExpirate = value
        End Set
    End Property

    Public Property IsIncludeDiscount As Boolean
        Get
            Return _isIncludeDiscount
        End Get
        Set(value As Boolean)
            _isIncludeDiscount = value
        End Set
    End Property

#End Region

#Region "Events"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
#End Region

End Class
