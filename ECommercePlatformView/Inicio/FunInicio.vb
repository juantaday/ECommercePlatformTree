Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports CADsisVenta.DataSetSecurityTableAdapters
Imports CADsisVenta.DataSetSecurity

Public Class FunInicio
    Implements IDisposable
    Protected Friend connecction As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
    Sub New()
        Try
            connecction.Open()
            UsuarioActivo.DataSource = connecction.DataSource.ToString()
        Catch ex As Exception
            MsgBox(ex.Message & " Intentando conectar al " & connecction.DataSource.ToString(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function IniciarUsuario(ByVal data As getInicio, isSetUser As Boolean) As Boolean
        Try
            Using da As New ValidaUsuarioTableAdapter()
                Using dt = New ValidaUsuarioDataTable
                    da.Fill(dt, data.GUsuario, SHA1(data.Password))
                    If dt.Rows.Count > 0 Then
                        If Not (dt.Rows(0)("Estado")) Then
                            sql = "Es usuario está inhabilitado, consulte a su administrador."
                            MsgBox(sql, MsgBoxStyle.Exclamation, "Al Iniciar Secion")
                            Return False
                        End If
                        'solo si hay que grabar al usuario.
                        If isSetUser Then
                            With UsuarioActivo
                                .Apellido = dt.Rows(0)("Apellidos")
                                .Nombre = dt.Rows(0)("Nombre")
                                .codUser = dt.Rows(0)("Login")
                                .IdUsuario = dt.Rows(0)("idPersona")
                            End With
                        End If
                        Return True ' InitialityUser(data)
                    Else
                        MsgBox("Usuario y/o contraseña incorrecto ", MsgBoxStyle.Exclamation, "Al Iniciar Secion")
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Al validar Usuario")
            Return False
        End Try
    End Function
    Public Function PruevaSecion(ByVal data As getInicio) As Response
        Dim response As New Response()
        Try
            Dim cmd = New SqlCommand("ValidaUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connecction
            cmd.Parameters.AddWithValue("@Login", data.GUsuario)
            cmd.Parameters.AddWithValue("@Password", data.gContrasena)

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    response.Success = True
                    Return response
                Else
                    response.Messague = "Contraseña actual Incorrecta"
                    response.Success = False
                    Return response
                End If
            End If
            response.Messague = "Contraseña actual Incorrecta"
            response.Success = False
            Return response
        Catch ex As Exception
            response.Messague = ex.Message
            response.Success = False
            Return response
        End Try
    End Function

    Private Sub InitialityUser(ByVal data As getInicio)
        Try
            If Not (Me.connecction.State = ConnectionState.Open) Then
                Return
            End If
            sql = "Update Usuarios Set [Iniciado] = 1 "
            sql = sql + "Where [Usuarios].[Login] = @CodUser And [Iniciado] = 0 "
            Using cmd = New SqlCommand(sql, Me.connecction)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@CodUser", data.GUsuario)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Return
        End Try
    End Sub
    Public Function CierraSecion(ByVal LoGinUser As String) As Boolean
        Try
            If Not (connecction.State = ConnectionState.Open) Then
                Return False
            End If
            sql = "Update Usuarios Set [Iniciado] = 0 "
            sql = sql + "Where [Usuarios].[Login] = '" & LoGinUser & "' "
            Using cmd = New SqlCommand(sql, connecction)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery() Then
                    UsuarioActivo = Nothing
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Function UserAccesoResponse(ByVal data As getInicio, setValueFilter As String) As Boolean
        Try
            If Not (connecction.State = ConnectionState.Open) Then
                Return False
            End If
            Using cmd = New SqlCommand("getUserSpecial", connecction)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodUser", data.GUsuario)
                cmd.Parameters.AddWithValue("@SetValue", String.Format("%{0}%", setValueFilter))

                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                If dt.Rows.Count Then
                    Return True
                Else
                    MsgBox("No tiene permiso para esta opción", MsgBoxStyle.Critical, "Al Valida Usuario")
                    Return False
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message + " en le UserAccesoEdid de ", MsgBoxStyle.Critical, "Al validar Usuario")
            Return False
        End Try
    End Function
    Public Function WhatIsMyIP() As String

        Dim WhatIsMyIPUrl As String = "http://whatismyip.com/automation/n09230945.asp"
        Dim req As HttpWebRequest
        Dim res As HttpWebResponse
        Dim Stream As IO.Stream
        Dim PublicIP As String = String.Empty
        Dim sr As StreamReader

        Try
            req = WebRequest.Create(WhatIsMyIPUrl)
            res = req.GetResponse()
            Stream = res.GetResponseStream()
            sr = New StreamReader(Stream)
            PublicIP = sr.ReadToEnd()
            sr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return PublicIP
    End Function

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
    Public Sub Dispose() Implements IDisposable.Dispose
        If Me.connecction.State = ConnectionState.Open Then
            Me.connecction.Close()
        End If
    End Sub
#End Region
End Class
