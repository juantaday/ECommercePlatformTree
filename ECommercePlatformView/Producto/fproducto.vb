
Imports System.Data.SqlClient
Module fProducto
    Private ClassName As String = "fProducto"
    Public Function Busca_IdProducto(ByVal Nom_Comerc As String, ByVal Nom_comun As String) As Integer
        sql = "select idproducto from Productos  "
        sql = sql & "Where (Nom_Comercial = '" & Nom_Comerc & "' or Nom_Comercial = '" & Nom_comun & "') "
        sql = sql & "or (Nom_Comun = '" & Nom_Comerc & "' or Nom_Comun = '" & Nom_comun & "') "

        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)

                If dt.Rows.Count = 1 Then
                    Return dt.Rows(0)("IDProducto").ToString()
                Else
                    Return 0
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message + " en el  Busca_IdProducto del " + ClassName, MsgBoxStyle.Critical, "Error al buscar Registro")
            Return 0
        End Try
    End Function

    Public Function Busca_IdSubCategory(ByVal idproducto As Integer) As Integer
        sql = "Select IdSubCategoria from Productos  "
        sql = sql & "Where idProducto = " & idproducto & " "

        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)

                If dt.Rows.Count = 1 Then
                    Return dt.Rows(0)("IdSubCategoria").ToString()
                Else
                    Return 0
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message + " en el  Busca_IdSubCategory del " + ClassName, MsgBoxStyle.Critical, "Error al buscar Registro")
            Return 0
        End Try
    End Function
    Public Function Elimina_Producto(IdProducto As Integer)
        sql = "Delete Productos Where idProducto =  " & IdProducto & ""
        conecta_sql()
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Elimina_Producto del modulo fProducto")
            Return False
        Finally
            desconecta_sql()
        End Try

    End Function
    Public Function Busca_idProductProveedor(ByVal idPresent As Integer, IdProveedor As Integer) As Integer

        sql = "Select  idProProveedor "
        sql = sql & "FROM dbo.ProductoProveedor "
        sql = sql & "WHERE  (idPresentacion = " & idPresent & ") And (idProveedor = " & IdProveedor & ") "
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return dt(0)(0).ToString
                Else
                    Return 0
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el fproducto en el Busca_idProductProveedor")
            Return 0
        Finally

        End Try
    End Function

    Public Function Busca_idPresent(codProduct As String) As Integer
        sql = "Select [idPresentacion] from [ProductoPresentacion]  "
        sql = sql & "Where codProducto=@codProduct"

        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@codProduct", SqlDbType.VarChar, 255)
                    cmd.Parameters("@codProduct").Value = codProduct
                    Using dat As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            dat.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Return dt.Rows(0)("idPresentacion")
                            Else
                                Return 0
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error EN fProdcuto en la funcion Busca_idPresent")
            Return 1
        End Try
    End Function
    Public Function Elimina_presentacion(ByVal _idPresentacion As Integer) As Boolean

        sql = "Delete ProductoPresentacion where idPresentacion=" & _idPresentacion & " "
        conecta_sql()
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el fproducto en la funcion Elimina_presentacion")
            Return False
        Finally
            desconecta_sql()
        End Try
    End Function
    Public Function Elimina_ProductoProveedor(ByVal idProProveedor As Integer)
        sql = "delete ProductoProveedor where idProProveedor='" & idProProveedor & " '"
        conecta_sql()
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el fproducto en la funcion Elimina_presentacion")
            Return False
        Finally
            desconecta_sql()
        End Try
    End Function
    Public Function CambiaIvaTodos(ivaPorcent As Double) As Boolean
        Try
            sql = "UPDATE p SET p.ivaPorcentaje =" & ivaPorcent & " "
            sql = sql & "From [dbo].[productos]  As p "
            sql = sql & "where  p.ivaPorcentaje > 0 "
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Function CargaIva() As Double
        Try
            If IsNothing(EcommerceActive) Then
                Return 0
            End If
            Return EcommerceActive.IvaPercent
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function
End Module