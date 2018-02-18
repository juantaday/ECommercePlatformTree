Public Class ItemAccessPanelUers
    Sub New()
    End Sub
    Private _idPermiso As Integer
    Public Property IdPermiso() As Integer
        Get
            Return _idPermiso
        End Get
        Set(ByVal value As Integer)
            _idPermiso = value
        End Set
    End Property
    Private _dropDownName As String

    Private _MenuStripName As String
    Public Property MenuStripName() As String
        Get
            Return _MenuStripName
        End Get
        Set(ByVal value As String)
            _MenuStripName = value
        End Set
    End Property
    Public Property DropDownName() As String
        Get
            Return _dropDownName
        End Get
        Set(ByVal value As String)
            _dropDownName = value
        End Set
    End Property
    Private _login As String
    Public Property Login() As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property
End Class
