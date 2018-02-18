Public Class ItemWhereHouse
    Private m_IdBodega As Integer
    Public Property NewProperty() As Integer
        Get
            Return m_IdBodega
        End Get
        Set(ByVal value As Integer)
            m_IdBodega = value
        End Set
    End Property
End Class
