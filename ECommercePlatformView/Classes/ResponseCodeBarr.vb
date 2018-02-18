Public Class ResponseCodeBarr
    Private _IsSusscess As Boolean
    Public Property Success() As Boolean
        Get
            Return _IsSusscess
        End Get
        Set(ByVal value As Boolean)
            _IsSusscess = value
        End Set
    End Property
    Private _CodeBarr As String
    Public Property CodeBarrResult() As String
        Get
            Return _CodeBarr
        End Get
        Set(ByVal value As String)
            _CodeBarr = value
        End Set
    End Property
End Class
