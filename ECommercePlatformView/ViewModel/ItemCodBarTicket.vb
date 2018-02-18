Imports System.ComponentModel

Public Class ItemCodBarTicket
    Inherits BarCodeTicket
    Implements INotifyPropertyChanged
    ' These fields hold the values for the public properties.
    Private idValue As Guid = Guid.NewGuid()

    Private _BarCod As String

    Public Event PropertyChanged As PropertyChangedEventHandler _
      Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub


    ' The constructor is private to enforce the factory pattern.
    Public Sub New()
        Me.Generated = True
    End Sub 'New
    Private _stated As Bitmap
    Public ReadOnly Property Stated() As Bitmap
        Get
            If DrawBarCode.IsValidCode(BarCod) Then
                Return ECommercePlatformView.My.Resources.ok_16
            Else
                Return ECommercePlatformView.My.Resources.Action_Delete_16x16
            End If
        End Get
    End Property
    Public Property BarCod() As String
        Get
            Return Trim(_BarCod)
        End Get
        Set
            If Value <> Me._BarCod Then
                Me._BarCod = Value
                NotifyPropertyChanged("BarCod")
                NotifyPropertyChanged("Stated")
            End If
        End Set
    End Property
    Private _ItenCount As Integer
    Public Property CountTicket() As Integer
        Get
            Return Trim(_ItenCount)
        End Get
        Set
            If Value <> Me._ItenCount Then
                Me._ItenCount = Value
                NotifyPropertyChanged("ItenCount")
            End If
        End Set
    End Property
    ' This is the public factory method.
    Public Shared Function CreateNewCustomer() As BarCodeTicket
        Return New BarCodeTicket()
    End Function
    ' This property represents an ID, suitable
    ' for use as a primary key in a database.
    Public ReadOnly Property ID() As Guid
        Get
            Return Me.idValue
        End Get
    End Property
End Class
