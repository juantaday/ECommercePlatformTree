Imports System.ComponentModel.DataAnnotations

Public Class ItemPerson
    Public Sub New(ByVal idperson As Integer, ByVal idClient As Integer, idEmployee As Integer, ByVal ruc_Cy As String,
                   ByVal apellid As String,
                   ByVal nombre As String, ByVal direccion As String, ByVal telefon As String, ByVal email As String,
                   ByVal idRates As Integer, ByVal description As String, ByVal _genero As Boolean, Optional montoMax As Double = 0,
                   Optional _image As Byte() = Nothing, Optional typePerson_ As Short = 0)
        _idPersona = idperson
        _idCliente = idClient
        _Apellidos = apellid
        _idEmployee = idEmployee
        _Nombre = nombre
        _Direccion = direccion
        _telefono = telefon
        _mail = email
        _idRates = idRates
        _Description = description
        _Ruc_Ci = ruc_Cy
        _isSelect = False
        _isUpdate = False
        _monto_Max = montoMax
        _Images = _image
        __Genero = _genero
        _TypePerson = typePerson_
    End Sub
    Private _monto_Max As Double

    Private _idEmployee As Integer
    Public Property IdEmployee() As Integer
        Get
            Return _idEmployee
        End Get
        Set(ByVal value As Integer)
            _idEmployee = value
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

    Private _isSelect As Boolean
    Public Property IsSelect() As Boolean
        Get
            Return _isSelect
        End Get
        Set(ByVal value As Boolean)
            _isSelect = value
        End Set
    End Property

    Public Property Tarifa() As String
        Get
            Return "(" & Me.idRates & ") " & Me.Description
        End Get
        Set(ByVal value As String)
        End Set
    End Property


    Public Property FullName() As String
        Get
            Return Me.Apellidos & " " & Me.Nombre
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Private _idPersona As Integer
    <Key>
    Public Property IdPersona() As Integer
        Get
            Return _idPersona
        End Get
        Set(ByVal value As Integer)
            _idPersona = value
        End Set
    End Property

    Private _idCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _Apellidos As String
    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Ruc_Ci As String
    Public Property Ruc_Ci() As String
        Get
            Return Trim(_Ruc_Ci)
        End Get
        Set(ByVal value As String)
            _Ruc_Ci = value
        End Set
    End Property

    Private _Direccion As String
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Private _mail As String
    Public Property mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property

    Private _idRates As Integer
    Public Property idRates() As Integer
        Get
            Return _idRates
        End Get
        Set(ByVal value As Integer)
            _idRates = value
        End Set
    End Property

    Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    Public Property Monto_Max As Double
        Get
            Return _monto_Max
        End Get
        Set(value As Double)
            _monto_Max = value
        End Set
    End Property

    Private _Images As Byte()
    Public Property Images() As Byte()
        Get
            Return _Images
        End Get
        Set(ByVal value As Byte())
            _Images = value
        End Set
    End Property
    Private __Genero As Boolean
    Public Property Genero() As Boolean
        Get
            Return __Genero
        End Get
        Set(ByVal value As Boolean)
            __Genero = value
        End Set
    End Property
    Private _TypePerson As Int16
    Public Property TypePerson() As Int16
        Get
            Return _TypePerson
        End Get
        Set(ByVal value As Int16)
            _TypePerson = value
        End Set
    End Property
End Class