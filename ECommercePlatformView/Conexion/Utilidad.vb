Imports System.Configuration
Imports CADsisVenta.GetConnectionStringCadSysytem
Namespace SimpleDataApp
    Public Class Utility
        Friend Shared Function GetConnectionString() As String
            ' Util-2 Assume failure.
            Dim returnValue As String = Nothing
            ' Util-3 Look for the name in the connectionStrings section.
            Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("JsofConneccionString")
            ' Dim settings As ConnectionStringSettings = DefaultStringSCadSysytem
            ' If found, return the connection string.
            If settings IsNot Nothing Then
                returnValue = settings.ConnectionString
            End If
            Return DefaultStringSCadSysytem()
        End Function
    End Class
End Namespace