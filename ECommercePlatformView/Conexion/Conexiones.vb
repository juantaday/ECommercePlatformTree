Imports System.Data.SqlClient
Module Conexiones
    Public Cnn_sql As New SqlConnection
    Public Function conecta_sql() As Boolean
        Try
            If Cnn_sql.State = ConnectionState.Open Then
                Return True
            Else
                Cnn_sql = New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                Cnn_sql.Open()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el moduo Conexiones de la funcion conecta_sql", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Function desconecta_sql()
        Try
            If Cnn_sql.State = ConnectionState.Open Then
                Cnn_sql.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
