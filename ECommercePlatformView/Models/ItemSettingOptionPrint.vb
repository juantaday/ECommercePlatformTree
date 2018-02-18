Public Class ItemSettingOptionPrint
    Private _NameSetting As String
    Public Property NameSetting() As String
        Get
            Return _NameSetting
        End Get
        Set(ByVal value As String)
            _NameSetting = value
        End Set
    End Property
    Private _ForeColor As String
    Public Property ForeColor() As String
        Get
            Return _ForeColor
        End Get
        Set(ByVal value As String)
            _ForeColor = value
        End Set
    End Property
    Private _FontZise As String
    Public Property FontZise() As String
        Get
            Return _FontZise
        End Get
        Set(ByVal value As String)
            _FontZise = value
        End Set
    End Property
End Class
