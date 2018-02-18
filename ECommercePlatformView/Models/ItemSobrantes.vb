Imports System.ComponentModel

Public Class ItemSobrantes : Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler
    Private Event INotifyPropertyChanged_PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Sub New()
    End Sub
    Private _CodTerminal As String
    Private _idTerminal As Integer
    Private _diferencia As Double
    Private _dateTimeStar As DateTime
    Private _dateTimeEnd As DateTime

    Public Property IdTerminal() As Integer
        Get
            Return _idTerminal
        End Get
        Set(ByVal value As Integer)
            _idTerminal = value
        End Set
    End Property
    Public Property Diferencia As Double
        Get
            Return _diferencia.ToString("C2")
        End Get
        Set(value As Double)
            _diferencia = value
        End Set
    End Property

    Public Property CodTerminal As String
        Get
            Return _CodTerminal
        End Get
        Set(value As String)
            _CodTerminal = value
        End Set
    End Property

    Public Property DateTimeStar As Date
        Get
            Return _dateTimeStar
        End Get
        Set(value As Date)
            _dateTimeStar = value
        End Set
    End Property

    Public Property DateTimeEnd As Date
        Get
            Return _dateTimeEnd
        End Get
        Set(value As Date)
            _dateTimeEnd = value
        End Set
    End Property
End Class
