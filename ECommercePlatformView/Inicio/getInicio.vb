Public Class getInicio
    Implements IDisposable
    Dim Usuario, Contrasena, _password As String
    Public Sub New()
    End Sub
    Public Sub New(Usuario As String, Contrasena As String)
        GUsuario = Usuario
        gContrasena = Contrasena
    End Sub
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Public Property GUsuario
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property
    Public Property gContrasena
        Get
            Return SHA1(Contrasena)
        End Get
        Set(value)
            Contrasena = value
            _password = value
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
            End If

        End If
        disposedValue = True
    End Sub

    Protected Overrides Sub Finalize()
        ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ' Visual Basic agrega este código para implementar correctamente el patrón descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
