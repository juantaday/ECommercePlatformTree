Imports CADsisVenta
Public Class ItemProductTranfer
    Inherits ProductTransfer_Detail

    Private _idProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property
    Private _nomComercial As String
    Public Property Nom_Comercial() As String
        Get
            Return _nomComercial
        End Get
        Set(ByVal value As String)
            _nomComercial = value
        End Set
    End Property
    Private _codProducto As String
    Public Property codProducto() As String
        Get
            Return _codProducto
        End Get
        Set(ByVal value As String)
            _codProducto = value
        End Set
    End Property
    Private _PresentacionPrint As String
    Public Property PresentacionPrint() As String
        Get
            Return _PresentacionPrint
        End Get
        Set(ByVal value As String)
            _PresentacionPrint = value
        End Set
    End Property
End Class
