Public Class ResponseTerminal
    Protected Friend IDterminal As Integer
    Protected Friend IdStadoCaja As Integer
    Private _data As DataTable
    Private _success As Boolean
    Public Sub New()

    End Sub


    Public Property DataDb() As DataTable
        Get
            IDterminal = _data.Rows(0)("idCajaStado")
            IdStadoCaja = _data.Rows(0)("idCajaStado")
            Return _data
        End Get
        Set(ByVal value As DataTable)
            _data = value
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
