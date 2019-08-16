Imports System.Data.SqlClient
Imports System.Net
Imports CADsisVenta
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Namespace GetInformationServices
    Public Class EcommerceInfo
        Public Shared Async Sub GetEccomerceInfo(LetMeKnow As Boolean)
            Try
                Await Inicia_EcommerceSetting(LetMeKnow)
            Catch ex As Exception
                processBackGround = False
                If LetMeKnow Then
                    MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End If
            End Try
        End Sub

        Private Shared Async Function Inicia_EcommerceSetting(LetMeKnow As Boolean) As Task(Of Boolean)
            Try
                EcommerceActive = New myCommerce
                Using db As New DataContext
                    Dim transaction As System.Data.Common.DbTransaction
                    db.Connection.ConnectionString = SimpleDataApp.Utility.GetConnectionString()
                    Await db.Connection.OpenAsync()
                    transaction = db.Connection.BeginTransaction()
                    db.Transaction = transaction
                    Dim query = (From c In db.myCommerce)
                    Dim result = Await Task(Of List(Of myCommerce)).Run(Function() query.ToList())
                    For Each item In result
                        EcommerceActive = item
                        Return True
                    Next
                End Using
                If LetMeKnow Then
                    MsgBox("No se encontro informacion de empresa", MsgBoxStyle.Exclamation, "Importante")
                End If
                Return False
            Catch ex As Exception
                processBackGround = False
                If LetMeKnow Then
                    MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End If
                Return False
            End Try
        End Function
    End Class
    Public Class GeneralInformation
        Public Shared Async Sub General()
            Cnn_sql = New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
            Await Cnn_sql.OpenAsync()
        End Sub

        Public Shared Async Sub Carga_DominioMaquina()

            Try

                Dominio = Nothing
                Dominio._HotName = Dns.GetHostName.ToString
                If IsNothing(Dominio) Then
                    MsgBox("No se pudo cargar el dominio  es posible que necesite internet..", MsgBoxStyle.Exclamation, "Importante")
                End If

                If String.IsNullOrWhiteSpace(Dominio._HotName) Then
                    MsgBox("No se pudo cargar el Dominio de este equipo", MsgBoxStyle.Exclamation, "Error")
                End If
                ' CARGAMO EL IP POR INTERNET ************************************************************************************
                Dim IPAddress_ As IPAddress = Nothing 'GetExternalIp()
                If Not IsNothing(IPAddress_) Then
                    Dominio._ip = IPAddress_.ToString
                    Dominio.isWep = True
                Else
                    Dominio.isWep = False
                    Dim ipHost As IPAddress()
                    ipHost = Await Dns.GetHostAddressesAsync(Dominio._HotName)
                    Dim i As Integer = 0

                    If ipHost.Length > 0 Then
                        For i = 0 To ipHost.Count - 1
                            If ipHost(i).ToString.Contains("192.") Then
                                Dominio._ip = ipHost(i).ToString
                                Exit For
                            ElseIf ipHost(i).ToString.Contains("255.") Then
                                Dominio._ip = ipHost(i).ToString
                                Exit For
                            End If
                        Next
                        If IsNothing(Dominio._ip) Then
                            If Dominio._ip = ipHost.Length > 0 Then
                                Dominio._ip = ipHost(0).ToString
                            Else
                                Dominio._ip = "No se pudo leer el ip"
                            End If
                        End If
                    Else
                        Dominio._ip = "No se pudo leer el ip"
                    End If
                End If
            Catch ex As Exception
                processBackGround = False
                MsgBox("Al intertar leer el ip de equipo" & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Sub

        Public Shared Async Function Inicia_Terminal(LetMeKnow As Boolean) As Task
            Dim terminal = Await Load_Terminal(LetMeKnow)

            TerminalActivo.codTerminal = terminal.codTerminal
            TerminalActivo.idBodega = terminal.idBodega
            TerminalActivo.Dominio = terminal.Dominio
            TerminalActivo.idTerminal = terminal.idTerminal
            TerminalActivo.Nom_Bodega = terminal.Nom_Bodega
            TerminalActivo.idRates = terminal.idRates

        End Function

        Private Shared Async Function Load_Terminal(LetMeKnow As Boolean) As Task(Of Terminal)
            Try
                If Not String.IsNullOrEmpty(Dominio._HotName) Then
                    Dim tapt As New TerminalTableAdapter
                    Dim dt As New TerminalDataTable
                    tapt.FillByDominio(dt, Dominio._HotName)
                    If IsNothing(dt) OrElse dt.Rows.Count = 0 Then
                        If LetMeKnow Then
                            sql = "Este Equipo navega como anónimo" + vbNewLine
                            sql = sql + "No tendrá acceso a ciertas opciones.."
                            MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                            Using newRegister As New frm_registerInTerminal
                                With newRegister
                                    .ShowDialog()
                                    If .DialogResult = DialogResult.OK Then
                                        Await Load_Terminal(LetMeKnow)
                                    Else
                                        Return New Terminal
                                    End If
                                End With
                                Return New Terminal
                            End Using
                        End If
                    End If
                    If dt.Rows.Count > 0 Then
                        Return New Terminal With {
                            .Dominio = Dominio._HotName,
                            .codTerminal = dt(0)("codTerminal"),
                            .idTerminal = dt(0)("idTerminal"),
                            .idBodega = dt(0)("idBodega"),
                            .Nom_Bodega = dt(0)("Nom_Bodega"),
                            .idRates = If(IsDBNull(dt(0)("idRates")), 0, dt(0)("idRates"))
                       }
                    End If
                End If
                If TerminalActivo.idTerminal = 0 And LetMeKnow Then
                    sql = "Este Equipo navega como anónimo" + vbNewLine
                    sql = sql + "No tendrá acceso a ciertas opciones.."
                    MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                End If
                Return New Terminal
            Catch ex As Exception
                processBackGround = False
                If LetMeKnow Then
                    MsgBox(ex.Message & vbLet & ex.StackTrace.ToString, MsgBoxStyle.Critical, "Error")
                End If
                Return New Terminal
            End Try
        End Function

    End Class
    Public Class AccessPanel
        Public Shared Async Sub GetListNenuAccess(LetMeKnow As Boolean)
            Try
                ListPanelAccessPermissions = Await GetlistMenu(LetMeKnow)
            Catch ex As Exception
                processBackGround = False
                If LetMeKnow Then
                    MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                End If
            End Try
        End Sub

        Private Shared Async Function GetlistMenu(LetMeKnow As Boolean) As Task(Of List(Of ItemAccessPanelUers))
            Try
                Dim list As New List(Of ItemAccessPanelUers)
                Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                    Await cnn.OpenAsync()
                    sql = "SELECT p.MenuStripName, P.DropDownName, P.idPermiso ,u.[login]
                            FROM   dbo.UsuarioGrupo AS U INNER JOIN 
                            dbo.Grupo AS G ON U.idGrupo = G.idGrupo INNER JOIN 
                            dbo.GrupoPermiso AS GU ON G.idGrupo = GU.idGrupo INNER JOIN 
                            dbo.Permisos AS P ON GU.idPermiso = P.idPermiso;"
                    Using cmd As New SqlCommand(sql, cnn)
                        Using dat As New SqlDataAdapter(cmd)
                            Using dt As New DataTable()
                                dat.Fill(dt)
                                For Each item As DataRow In dt.Rows

                                    list.Add(New ItemAccessPanelUers With
                                             {
                                                  .MenuStripName = item("MenuStripName").ToString,
                                                 .DropDownName = item("DropDownName").ToString,
                                                 .IdPermiso = item("IdPermiso").ToString,
                                                  .Login = item("Login").ToString
                                             })
                                Next
                            End Using
                        End Using
                    End Using
                End Using
                Return list
            Catch ex As Exception
                Throw New Exception(ex.Message, innerException:=ex.InnerException)
            End Try
        End Function

    End Class
End Namespace
