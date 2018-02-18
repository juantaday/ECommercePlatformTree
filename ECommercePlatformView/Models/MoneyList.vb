Imports System.Windows.Media.Imaging
Imports System.ComponentModel
Public Class MoneyList
    Implements INotifyPropertyChanged
    Sub New()
    End Sub
    Sub New(idMonedaDetail As Integer, moneda As String,
            value_moneda As Double, quantity As Double,
            isSelect As Boolean, isChecken As Boolean,
            img As BitmapImage)
        m_IdMonedaDetail = idMonedaDetail
        m_Description = moneda
        m_Value_Moneda = value_moneda
        m_ImageMoneda = img
        m_Quantity = quantity
        m_IsSelect = isSelect
        m_IsChecken = isChecken
    End Sub
    Public Property IdMonedaDetail() As Integer
        Get
            Return m_IdMonedaDetail
        End Get
        Set
            m_IdMonedaDetail = Value
        End Set
    End Property
    Private m_IdMonedaDetail As Integer

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set
            m_Description = Value
        End Set
    End Property
    Private m_Description As String

    Public Property Value_Moneda() As Double
        Get
            Return m_Value_Moneda
        End Get
        Set
            m_Value_Moneda = Value
        End Set
    End Property
    Private m_Value_Moneda As Double
    Public Property Quantity() As Double
        Get
            Return m_Quantity
        End Get
        Set
            m_Quantity = Value
        End Set
    End Property
    Private m_Quantity As Double
    Public Property IsSelect() As Boolean
        Get
            Return m_IsSelect
        End Get
        Set
            m_IsSelect = Value
        End Set
    End Property
    Private m_IsSelect As Boolean
    Public Property IsChecken() As Boolean
        Get
            Return m_IsChecken
        End Get
        Set
            m_IsChecken = Value
        End Set
    End Property
    Private m_IsChecken As Boolean
    Public Property ImageMoneda() As BitmapImage
        Get
            Return m_ImageMoneda
        End Get
        Set
            m_ImageMoneda = Value
        End Set
    End Property
    Private m_ImageMoneda As BitmapImage
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class