Imports System.ComponentModel
Imports CADsisVenta

Public Class ItemCajaStado : Inherits CajaStado : Implements INotifyPropertyChanged
    Public Shadows Event PropertyChangedView As PropertyChangedEventHandler
    Private Event INotifyPropertyChanged_PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Sub New(ByVal item As CajaStado, ByVal _bodegas As String, ByVal _codTerminal As String)
        _Bodega = _bodegas
        Me.codUserClosed = item.codUserClosed
        Me.codUserOpen = item.codUserOpen
        Me.dateEnd = item.dateEnd
        Me.dateHiberna = item.dateHiberna
        Me.dateStar = item.dateStar
        Me.idCajaStado = item.idCajaStado
        Me.idTerminal = item.idTerminal
        Me.isAllUser = item.isAllUser
        Me.own_User = item.own_User
        Me.Qntt_difference = item.Qntt_difference
        Me.QuantityClosed = item.QuantityClosed
        Me.QuantityOpen = item.QuantityOpen
        Me.Saldo = item.Saldo
        Me._CodTerinal = _codTerminal
    End Sub
    Sub New()

    End Sub
    Private _Bodega As String
    Private _CodTerinal As String
    Public Property LocalBodega As String
        Get
            Return _Bodega
        End Get
        Set(value As String)
            _Bodega = value
        End Set
    End Property
    Public Property UserOwner As String
        Get
            If Me.isAllUser Then
                Return "Varios.."
            Else
                Return Me.own_User
            End If
        End Get
        Set(value As String)
        End Set
    End Property
    Public Property CodTerinal As String
        Get
            Return _CodTerinal
        End Get
        Set(value As String)
            _CodTerinal = value
        End Set
    End Property

    Public Property QnttyOpen As String
        Get
            Return Me.QuantityOpen.ToString("C2")
        End Get
        Set(value As String)
        End Set
    End Property
    Public Property QnttyClose As String
        Get
            Return Me.QuantityClosed.ToString("C2") 'Qntt_difference
        End Get
        Set(value As String)
        End Set
    End Property
    Public Property Qnty_diference As String
        Get
            Return Me.Qntt_difference.ToString("C2")
        End Get
        Set(value As String)
        End Set
    End Property
End Class
