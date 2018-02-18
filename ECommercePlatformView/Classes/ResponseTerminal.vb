Public Class Response
    Private _messague As String
    Private _success As Boolean
    Public Property Messague() As String
        Get
            Return _messague
        End Get
        Set(ByVal value As String)
            _messague = value
        End Set
    End Property
    Public Property Success() As Boolean
        Get
            Return _success
        End Get
        Set(ByVal value As Boolean)
            _success = value
        End Set
    End Property
End Class
