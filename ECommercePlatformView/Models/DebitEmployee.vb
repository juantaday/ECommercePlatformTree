
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports System.Windows.Data

Namespace DebitEmployeeNameSpace
    Public Class DebitEmployee
        Implements INotifyPropertyChanged, IEditableObject
        ' The Task class implements INotifyPropertyChanged and IEditableObject 
        ' so that the datagrid can properly respond to changes to the 
        ' data collection and edits made in the DataGrid.
#Region "Atributes"
        Private m_TypeDebit As String = String.Empty
        Private m_DebitDate As DateTime = Date.Now
        Private m_IsUpdate As Boolean = False
        Private m_IdPerson As Integer = 0
        Private m_Document As String = String.Empty
        Private m_Apellidos As String = String.Empty
        Private m_Nombres As String = String.Empty
        Private m_RucCI As String = String.Empty

        ' Data for undoing canceled edits.
        Private temp_Task As DebitEmployee = Nothing
        Private m_Editing As Boolean = False
        Private m_DebitValue As Double = 0
        Private m_PaymentDebit As Double = 0
#End Region

#Region "Properties"
        ' Public properties.
        Private m_idEmpleadoDeuda As Integer
        Public Property IdEmpleadoDeuda() As Integer
            Get
                Return m_idEmpleadoDeuda
            End Get
            Set(ByVal value As Integer)
                m_idEmpleadoDeuda = value
            End Set
        End Property
        <Key>
        Public Property IdPerson() As Integer
            Get
                Return m_IdPerson
            End Get
            Set(ByVal value As Integer)
                m_IdPerson = value
            End Set
        End Property
        Public Property RucCi() As String
            Get
                Return m_RucCI
            End Get
            Set(ByVal value As String)
                m_RucCI = value
            End Set
        End Property

        Public Property Apellidos() As String
            Get
                Return m_Apellidos
            End Get
            Set(ByVal value As String)
                m_Apellidos = value
            End Set
        End Property

        Public Property Nombres() As String
            Get
                Return m_Nombres
            End Get
            Set(ByVal value As String)
                m_Nombres = value
            End Set
        End Property

        Public Property FullName() As String
            Get
                Return Me.Apellidos & " " & Me.Nombres
            End Get
            Set(ByVal value As String)
            End Set
        End Property

        Public Property TypeDebit() As String
            Get
                Return Me.m_TypeDebit
            End Get
            Set(ByVal value As String)
                If Not value = Me.m_TypeDebit Then
                    Me.m_TypeDebit = value
                    NotifyPropertyChanged("TypeDebit")
                End If
            End Set
        End Property

        Public Property Document() As String
            Get
                Return m_Document
            End Get
            Set(ByVal value As String)
                m_Document = value
            End Set
        End Property

        Public Property DebitDate() As DateTime
            Get
                Return Me.m_DebitDate
            End Get
            Set(ByVal value As Date)
                If Not value = Me.m_DebitDate Then
                    Me.m_DebitDate = value
                    NotifyPropertyChanged("DueDate")
                End If
            End Set
        End Property

        Public Property IsUpdate() As Boolean
            Get
                Return Me.m_IsUpdate
            End Get
            Set(ByVal value As Boolean)
                If Not value = Me.m_IsUpdate Then
                    Me.m_IsUpdate = value
                    NotifyPropertyChanged("IsUpdate")
                End If
            End Set
        End Property

        Public Property DebitValue() As Double
            Get
                Return m_DebitValue
            End Get
            Set(ByVal value As Double)
                If Not value = Me.m_DebitValue Then
                    Me.m_DebitValue = value
                    NotifyPropertyChanged("DebitValue")
                End If
            End Set
        End Property
        Public Property PaymentDebit() As Double
            Get
                Return m_PaymentDebit
            End Get
            Set(ByVal value As Double)
                m_PaymentDebit = value
            End Set
        End Property
        Public Property BalaceDebit() As Double
            Get
                Return Me.DebitValue - Me.PaymentDebit
            End Get
            Set(ByVal value As Double)
            End Set
        End Property
#End Region

#Region "Events"
        ' Implement INotifyPropertyChanged interface. 
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Public Sub NotifyPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
#End Region

#Region "Editable"

        ' Implement IEditableObject interface.
        Public Sub BeginEdit() Implements IEditableObject.BeginEdit
            If Not Me.m_Editing Then
                Me.temp_Task = Me.MemberwiseClone()
                Me.m_Editing = True
            End If
        End Sub

        Public Sub CancelEdit() Implements IEditableObject.CancelEdit
            If m_Editing = True Then
                Me.TypeDebit = Me.temp_Task.TypeDebit
                Me.DebitDate = Me.temp_Task.DebitDate
                Me.IsUpdate = Me.temp_Task.IsUpdate
                Me.m_Editing = False
            End If
        End Sub

        Public Sub EndEdit() Implements IEditableObject.EndEdit
            If m_Editing = True Then
                Me.temp_Task = Nothing
                Me.m_Editing = False
            End If
        End Sub
#End Region

    End Class

    ' Requires Imports System.Collections.ObjectModel
    Public Class DebitEmployeeCollection
        Inherits ObservableCollection(Of DebitEmployee)
        ' Creating the Tasks collection in this way enables data binding from XAML.
    End Class

    Public Class CompleteConverter
        Implements IValueConverter
        ' This converter changes the value of a Tasks Complete status from true/false to a string value of
        ' "Complete"/"Active" for use in the row group header.
        Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
            Dim complete As Boolean = value
            If complete = True Then
                Return "Complete"
            Else
                Return "Active"
            End If
        End Function

        Public Function ConvertBack1(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Dim strComplete As String = value
            If strComplete = "Complete" Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

    Public Class TotalSumConverter
        Implements IValueConverter
        Private Function IValueConverter_Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim sum As Double = 0
            Dim _DebitEmployee = TryCast(value, IEnumerable(Of Object))
            If _DebitEmployee Is Nothing Then
                Return sum.ToString("C2")
            End If
            For Each u As DebitEmployee In _DebitEmployee
                sum += DirectCast(u, DebitEmployee).BalaceDebit
            Next
            Return sum.ToString("C2")
        End Function
        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class VisiviliteConverter
        Implements IValueConverter
        Private Function IValueConverter_Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim users = TryCast(value, IEnumerable(Of Object))
            If users Is Nothing Then
                Return False
            End If
            If users.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace
