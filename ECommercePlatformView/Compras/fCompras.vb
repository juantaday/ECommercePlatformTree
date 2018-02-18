Imports System.Data.SqlClient
Module fCompras
    Dim idProUndReferen As Integer
    Dim idPresentacion As Integer
    Dim Cant_Present As Double

    Public Function Adquier_OrdenCompra() As Integer
        Dim Ult_Order As Integer = BuscarOrderCompra()


        If Ult_Order > 0 Then
            'calculo nueva orde en la variable sql 
            sql = Convert.ToString(Ult_Order + 1)
            If ActualizaOrderCompra(sql) Then
                Return Ult_Order
            Else
                Return 0
            End If
        Else
            Return 0
        End If

    End Function

    Private Function BuscarOrderCompra() As Integer
        sql = "Select TOP 1 [idOrden] From [Orden_Pedido] "
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return Integer.Parse(dt(0)(0).ToString)
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error :fCompras en el BuscarOrderCompra")
            Return 0
        End Try
    End Function

    Private Function ActualizaOrderCompra(ByVal NewOrder As String) As Boolean

        sql = "Update Orden_Pedido set [idOrden] ='" & NewOrder & "' "
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error :fCompras en el ActualizaOrderCompra")
            Return False

        End Try
    End Function


    Public Function ELimina_Pedido(ByVal IdPedido As Integer) As Boolean

        sql = "DELETE TOP (200) "
        sql = sql & "FROM Pedidos "
        sql = sql & "WHERE(idPedido = " & IdPedido & ") "

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error: fCompras en el ELimina_Pedido")
            Return False

        Finally
            desconecta_sql()
        End Try

    End Function
    Public Function Busca_New_NumDoc() As Integer
        If conecta_sql() Then
            Dim Ult_Docum As Integer = BuscaNum_Docum()
            If Ult_Docum > 0 Then
                'calculo nueva orde en la variable sql 
                sql = Convert.ToString(Ult_Docum + 1)
            Else
                sql = 1
            End If
            If ActualizaNumDocum(sql) Then
                Return Ult_Docum
            End If
        End If
        Return 0
    End Function

    Private Function BuscaNum_Docum() As Integer
        sql = "Select TOP 1 [Num_DocActual] From [Num_Documento] "
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return Integer.Parse(dt(0)(0).ToString)
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error :fCompras en el BuscaNum_Docum")
            Return 0
        End Try
    End Function

    Private Function ActualizaNumDocum(ByVal New_NumDco As String) As Boolean
        sql = "Update Num_Documento set [Num_DocActual] ='" & New_NumDco & "' "
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error :fCompras en el ActualizaOrderCompra")
            Return False
        End Try
    End Function
    Public Function Guarda_compraActual(ByVal idPedido As Integer) As Integer
        'INSERTO LA CABECERA DE COMPRA en la tabla Factura de compra

        Dim cnn As New SqlConnection
        cnn = New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
        cnn.Open()

        Try
            Dim cmd As New SqlCommand("[dbo].[prcFacturaCompra]", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            ' id de bodega
            cmd.Parameters.Add(New SqlParameter("@idBodega", SqlDbType.Int))
            cmd.Parameters("@idBodega").Value = FacturCompra.idBodega

            ' id de orden de pedido
            cmd.Parameters.Add(New SqlParameter("@idPedido", SqlDbType.Int))
            cmd.Parameters("@idPedido").Value = idPedido
            ' forma de pago 
            cmd.Parameters.Add(New SqlParameter("@idFormaPago", SqlDbType.Int))
            cmd.Parameters("@idFormaPago").Value = Pagos.idformaPago
            'fecha de compra
            cmd.Parameters.Add(New SqlParameter("@fechaCompra", SqlDbType.Date))
            cmd.Parameters("@fechaCompra").Value = FacturCompra.FechaComra
            'fecha de pago
            cmd.Parameters.Add(New SqlParameter("@fechaPago", SqlDbType.Date))
            cmd.Parameters("@fechaPago").Value = Pagos.fech_Pago
            'fecha de cheque
            cmd.Parameters.Add(New SqlParameter("@fech_cheq", SqlDbType.Date))
            cmd.Parameters("@fech_cheq").Value = Pagos.fech_Cheq
            'tipo de documento
            cmd.Parameters.Add(New SqlParameter("@tipo_Doc", SqlDbType.Int))
            cmd.Parameters("@tipo_Doc").Value = FacturCompra.Tipo_Doc
            'numero de factura
            cmd.Parameters.Add(New SqlParameter("@num_Doc", SqlDbType.Char, 13))
            cmd.Parameters("@num_Doc").Value = FacturCompra.Num_Doc
            'Numero de pago es uno solo asi pague varias facturas
            cmd.Parameters.Add(New SqlParameter("@num_Pago", SqlDbType.Char, 12))
            cmd.Parameters("@num_Pago").Value = Pagos.num_pago
            'numero de cheque
            cmd.Parameters.Add(New SqlParameter("@num_Cheq", SqlDbType.Char, 12))
            cmd.Parameters("@num_Cheq").Value = Pagos.Num_Documento
            'usuario la que realiza compra
            cmd.Parameters.Add(New SqlParameter("@codUserCompra", SqlDbType.Char, 8))
            cmd.Parameters("@codUserCompra").Value = UsuarioActivo.codUser
            ' tipo de consumo [alimentacion] [educacion] [salud] [PREVENTA]
            cmd.Parameters.Add(New SqlParameter("@idconsumo", SqlDbType.Int))
            cmd.Parameters("@idconsumo").Value = FacturCompra.idConsumo
            ' tipo de DECLARACION [MENSUAL] [TRIMESTRA] [ANUAL]
            cmd.Parameters.Add(New SqlParameter("@idDeclaracion", SqlDbType.Int))
            cmd.Parameters("@idDeclaracion").Value = FacturCompra.idDeclaracion
            ' CUENTA DE BANCO
            cmd.Parameters.Add(New SqlParameter("@idBancocuenta", SqlDbType.Int))
            cmd.Parameters("@idBancocuenta").Value = Pagos.idBancoCuenta

            'VALOR DE SALIDA EL ID QUE ACABA DE UNSERTAR
            cmd.Parameters.Add(New SqlParameter("@idFacturaCompra", SqlDbType.Int))
            cmd.Parameters("@idFacturaCompra").Direction = ParameterDirection.Output
            If cmd.ExecuteNonQuery Then
                Return CInt(cmd.Parameters("@idFacturaCompra").Value)
            Else
                Return 0
            End If

        Catch SqlEx As SqlException
            Dim myError As SqlError
            MsgBox("Cantida de errores: " & SqlEx.Errors.Count.ToString(), MsgBoxStyle.Critical, "Error")
            For Each myError In SqlEx.Errors
                MsgBox(myError.Number & " - " & myError.Message, MsgBoxStyle.Exclamation, "Error")
            Next
            Return 0
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn = Nothing
        End Try
    End Function

    Public Function Elimina_Factura(ByVal idFactura As Integer) As Boolean
        Try
            sql = "Delete facturacompra where idfacturacompra = " & idFactura & ""
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Busca_IdFacturCompra(ByVal idOrderPedido As Integer) As Integer

        sql = "SELECT idFacturaCompra "
        sql = sql & "FROM FacturaCompra "
        sql = sql & "WHERE idOrderPedido= " & idOrderPedido & " "

        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0).ToString()
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar Pedido")
            Return 0

        End Try

    End Function
End Module
