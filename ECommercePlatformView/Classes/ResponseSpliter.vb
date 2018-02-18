Public Class ResponseSpliter
    Private _isNumeric As Boolean
    Private _isCode As Boolean
    Private _Spliter As String()
    Private _isSucces As Boolean

    Public Property IsNumeric As Boolean
        Get
            Return _isNumeric
        End Get
        Set(value As Boolean)
            _isNumeric = value
        End Set
    End Property

    Public Property Spliter As String()
        Get
            Return _Spliter
        End Get
        Set(value As String())
            _Spliter = value
        End Set
    End Property

    Public Property IsSucces As Boolean
        Get
            Return _isSucces
        End Get
        Set(value As Boolean)
            _isSucces = value
        End Set
    End Property

    Public Property IsCode As Boolean
        Get
            Return _isCode
        End Get
        Set(value As Boolean)
            _isCode = value
        End Set
    End Property
End Class
