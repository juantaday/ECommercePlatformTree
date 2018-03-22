Public Class FileTypes
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _NameFile As String
    Public Property NameFile() As String
        Get
            Return _NameFile
        End Get
        Set(ByVal value As String)
            _NameFile = value
        End Set
    End Property
    Private _Extension As String
    Public Property Extension() As String
        Get
            Return _Extension
        End Get
        Set(ByVal value As String)
            _Extension = value
        End Set
    End Property
End Class
