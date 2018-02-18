Public Class BarCodeTicket
    Private _IdPresent As Integer
    Private _BarCod As String
    Private _nameProducto As String
    Private _presentation As String
    Private _unitPrice As Double
    Private _generated As Boolean
    Sub New()
    End Sub

    Public Property Generated() As Boolean
        Get
            Return _generated
        End Get
        Set(ByVal value As Boolean)
            _generated = value
        End Set
    End Property

    Public Property UnitPrice() As Double
        Get
            Return _unitPrice
        End Get
        Set(ByVal value As Double)
            _unitPrice = value
        End Set
    End Property

    Public ReadOnly Property UnitPriceString() As String
        Get
            Return Me._unitPrice.ToString("C2")
        End Get
    End Property
    Public Property Presentation() As String
        Get
            Return _presentation
        End Get
        Set(ByVal value As String)
            _presentation = value
        End Set
    End Property
    Public Property NameProduct() As String
        Get
            Return _nameProducto
        End Get
        Set(ByVal value As String)
            _nameProducto = value
        End Set
    End Property
    Public Property IdPresent() As Integer
        Get
            Return _IdPresent
        End Get
        Set(ByVal value As Integer)
            _IdPresent = value
        End Set
    End Property
End Class
