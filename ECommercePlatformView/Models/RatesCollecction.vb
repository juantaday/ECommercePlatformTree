Imports System.ComponentModel.DataAnnotations
Imports CADsisVenta

Public Class RatesCollecction
    Inherits Rates
    Sub New(ByVal _rates As Rates)
        Me.idRates = _rates.idRates
        Me.Descriptions = _rates.Descriptions
        Me.codUserRaise = _rates.codUserRaise
        Me.DateStar = _rates.DateStar
        Me.Structure = _rates.Structure
        Me.TypeRate = _rates.TypeRate
    End Sub
    Public Property DescriptionType() As String
        Get
            If Me.TypeRate = 0 Then
                Return String.Format("Valor adicional")
            Else
                Return String.Format("Descuento......")
            End If
        End Get
        Set(ByVal value As String)
        End Set
    End Property
End Class
