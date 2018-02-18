Imports System.Data.SqlClient

Public Class fbackup

    Dim cmd As SqlCommand

    Public Function backupbase(fileName As String, NameArchiv As String)
        Try
            If conecta_sql() Then
                cmd = New SqlCommand("backup_base")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Direcions", SqlDbType.VarChar)
                cmd.Parameters.Add("@NameArchiv", SqlDbType.VarChar)

                cmd.Parameters("@Direcions").Value = fileName
                cmd.Parameters("@NameArchiv").Value = NameArchiv

                cmd.Connection = Cnn_sql
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en ele backup")
            Return False
        Finally
            desconecta_sql()
        End Try
    End Function

End Class
