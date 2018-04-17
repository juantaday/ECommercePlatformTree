Public Class ItemCheqNotFount
    Private _id As Integer
    Private _val As Double
    Private _isArching As Boolean

    Sub New(id As Integer, _value As Double, isArching As Boolean)
        _id = id
        _val = _value
        _isArching = isArching
    End Sub

    Public Property valCheq() As Double
        Get
            Return _val
        End Get
        Set(ByVal value As Double)
            _val = value
        End Set
    End Property
    Public Property idCajaDetailCheque() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property isArching() As Boolean
        Get
            Return _isArching
        End Get
        Set(ByVal value As Boolean)
            _isArching = value
        End Set
    End Property
End Class
