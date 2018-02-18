Public Class Dproveedor
    Dim idProveedor, idTypo_Provee As Long
    Dim Ruc_Ci, Razon_social, Tipo_razon, Representante, Direccion, Telefono, User As String

    Public Property gidProveedor
        Get
            Return idProveedor
        End Get
        Set(value)
            idProveedor = value
        End Set
    End Property
    Public Property gidTypo_Provee
        Get
            Return idTypo_Provee
        End Get
        Set(value)
            idTypo_Provee = value
        End Set
    End Property
    Public Property gRuc_Ci
        Get
            Return Ruc_Ci
        End Get
        Set(value)
            Ruc_Ci = value
        End Set
    End Property
    Public Property gRazon_social
        Get
            Return Razon_social
        End Get
        Set(value)
            Razon_social = value
        End Set
    End Property
    Public Property gtipo_razon
        Get
            Return tipo_razon
        End Get
        Set(value)
            tipo_razon = value
        End Set
    End Property


    Public Property gRepresentante

        Get
            Return Representante
        End Get
        Set(value)
            Representante = value
        End Set
    End Property
    Public Property gDireccion

        Get
            Return Direccion
        End Get
        Set(value)
            Direccion = value
        End Set
    End Property
    Public Property gTelefono

        Get
            Return Telefono
        End Get
        Set(value)
            Telefono = value
        End Set
    End Property
    Public Property gUser

        Get
            Return User
        End Get
        Set(value)
            User = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(idProveedor As Long, idTypo_Provee As Long, Ruc_Ci As String, Razon_social As String, Tipo_razon As String, representante As String, direccion As String, telefono As String, use As String)
        gidProveedor = idProveedor
        gidTypo_Provee = idTypo_Provee
        gRuc_Ci = Ruc_Ci
        gRazon_social = Razon_social
        gtipo_razon = Tipo_razon
        gRepresentante = representante
        gDireccion = direccion
        gTelefono = telefono
        gUser = User
    End Sub

End Class
