Imports System.ComponentModel.DataAnnotations

Public Class ItemOwner
    Public Sub New()

    End Sub
    Public Sub New(ByVal idPropietarios As Int32, ByVal idPerson As Int32, ByVal namePerson As String,
                  ByVal ruc As String, ByVal phone As String, ByVal email As String,
                  ByVal idPosition As Int32, ByVal namePosition As String)
        _idPropietarios = idPropietarios
        _idPerson = idPerson
        _NamePerson = namePerson
        _RucCI = ruc
        _Phone = phone
        _email = email
        _idPositions = idPosition
        _NamePositions = namePosition
    End Sub

    Private _idPropietarios As Integer
    <Key>
    Public Property IdPropietarios() As Integer
        Get
            Return _idPropietarios
        End Get
        Set(ByVal value As Integer)
            _idPropietarios = value
        End Set
    End Property
    Private _idPerson As Integer
    Public Property IdPerson() As Integer
        Get
            Return _idPerson
        End Get
        Set(ByVal value As Integer)
            _idPerson = value
        End Set
    End Property
    Private _NamePerson As String
    Public Property NamePerson() As String
        Get
            Return _NamePerson
        End Get
        Set(ByVal value As String)
            _NamePerson = value
        End Set
    End Property
    Private _RucCI As String
    Public Property RucCI() As String
        Get
            Return _RucCI
        End Get
        Set(ByVal value As String)
            _RucCI = value
        End Set
    End Property
    Private _Phone As String
    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
        End Set
    End Property
    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Private _idPositions As String
    Public Property IdPositions() As String
        Get
            Return _idPositions
        End Get
        Set(ByVal value As String)
            _idPositions = value
        End Set
    End Property
    Private _NamePositions As String
    Public Property NamePositions() As String
        Get
            Return _NamePositions
        End Get
        Set(ByVal value As String)
            _NamePositions = value
        End Set
    End Property
    Private _isUpdate As Boolean
    Public Property IsUpdate() As Boolean
        Get
            Return _isUpdate
        End Get
        Set(ByVal value As Boolean)
            _isUpdate = value
        End Set
    End Property
    Public Property FullName() As String
        Get
            Return Me.NamePerson
        End Get
        Set(ByVal value As String)
        End Set
    End Property
End Class
