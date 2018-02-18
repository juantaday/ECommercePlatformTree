Imports System.Data.SqlClient

Public Class fProveedor

    Public Function mostrar() As DataTable

        Try
            conecta_sql()
            sql = "SELECT idProveedor, Ruc_Ci, Razon_social, Represent, Telefono , ivaSubTotal FROM Proveedores"
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql


            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Return dt
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conecta_sql()
        End Try

    End Function

    Public Function Tipo_Proveedor() As DataTable

        conecta_sql()
        Try


            sql = "SELECT * FROM ProveedorTypo"
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql


            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Return dt
            Else
                Return Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conecta_sql()
        End Try

    End Function

End Class

