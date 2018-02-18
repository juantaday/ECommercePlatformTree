Imports System.Data.SqlClient

Module FClientes
    Dim classname As String = "FClientes"
    Public dt_Persona As New DataTable
    Public Function Busca_Persona(Ruc_Ci As String) As Integer
        sql = "SELECT        dbo.Personas.* "
        sql = sql & "FROM dbo.Personas "
        sql = sql & "Where Ruc_Ci ='" & Ruc_Ci & "'"

        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text
            Dim dat As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            dat.Fill(dt)
            If dt.Rows.Count > 0 Then
                dt_Persona = dt
                Return dt(0)("idPersona").ToString
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el Busca_Persona del " + classname, MsgBoxStyle.Critical, "Error al buscar registro")
            Return 0

        End Try
    End Function

    Public Function Guarda_Persona(ByVal apellellidos As String, ByVal nombre As String, ByVal ruc_ci As String,
                                   ByVal direccion As String, ByVal telf As String, ByVal mail As String, genero As Byte) As Boolean

        conecta_sql()
        sql = "Insert Into Personas (Apellidos,Nombre,Ruc_Ci, Direccion,telefono, mail,genero) "
        sql = sql + "Values ('" & apellellidos & "','" & nombre & "', '" & ruc_ci & "','" & direccion & "', '" & telf & "', '" & mail & "'," & genero & ")"

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " en el Guarda_Persona del " + classname, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Public Function Edita_Persona(ByVal idpersona As Integer, ByVal apellellidos As String, ByVal nombre As String, ByVal ruc_ci As String, _
                               ByVal direccion As String, ByVal telf As String, ByVal mail As String) As Boolean

        conecta_sql()

        sql = "update Personas set Apellidos = '" & apellellidos & "', Nombre = '" & nombre & "', Ruc_Ci = '" & ruc_ci & "', "
        sql = sql + "Direccion = '" & direccion & "', telefono = '" & telf & "', mail = '" & mail & "' "
        sql = sql + "where idpersona = " & idpersona & " "

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " en el Edito_Persona del " + classname, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

End Module
