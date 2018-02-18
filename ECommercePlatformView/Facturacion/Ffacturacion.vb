'Imports LibPrintTicketMatriz.PrintTicket
Imports System.Data.SqlClient
Module FfacturacionVenta
    Public idOrderVenta As Integer
    Public codRecupa As Byte = 255
    Dim VuelActual As Integer = 0
    Private Err_code As Integer
    Public Function Procesa_Venta() As Boolean
        Try
            Dim cn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
            cn.FireInfoMessageEventOnUserErrors = True
            AddHandler cn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)
            cn.Open()
            Dim cmd As New SqlCommand("prcFacturaVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            ' tipo de documento
            cmd.Parameters.Add("@NameDocumento", SqlDbType.VarChar, 50) '
            cmd.Parameters("@NameDocumento").Value = FacturVenta.nameDocunt
            '  equipo de la que se envia la trasferencia de datos
            cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
            cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
            '  [ID] de clinete a la que se carga el costo
            cmd.Parameters.Add("@idCliente", SqlDbType.Int)
            cmd.Parameters("@idCliente").Value = Pagos.idCliente
            '  forma de pago
            cmd.Parameters.Add("@idFormaPago", SqlDbType.Int)
            cmd.Parameters("@idFormaPago").Value = Pagos.idformaPago
            '  banco con la que paga
            cmd.Parameters.Add("@idBanco", SqlDbType.Int)
            cmd.Parameters("@idBanco").Value = Pagos.idBancoCuenta
            '  fecha desde
            cmd.Parameters.Add("@fech_desde", SqlDbType.Date)
            cmd.Parameters("@fech_desde").Value = FacturVenta.fechDesde
            'fecha hasta
            cmd.Parameters.Add("@fech_hasta", SqlDbType.Date)
            cmd.Parameters("@fech_hasta").Value = FacturVenta.fechHasta
            '  fehca de pago en casos de cheque
            cmd.Parameters.Add("@fech_Cobro", SqlDbType.Date)
            cmd.Parameters("@fech_Cobro").Value = Pagos.fech_Pago
            ' numero de cobro en caso de pago con chequ
            cmd.Parameters.Add("@num_Cobro", SqlDbType.VarChar, 12)
            cmd.Parameters("@num_Cobro").Value = Pagos.num_pago
            ' numero de cheque
            cmd.Parameters.Add("@num_cheq", SqlDbType.VarChar, 15)
            cmd.Parameters("@num_cheq").Value = Pagos.Num_Documento
            ' codigo de usuario
            cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
            cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
            ' bodega a la que se compra
            cmd.Parameters.Add("@idBodega", SqlDbType.Int, 32)
            cmd.Parameters("@idBodega").Value = FacturVenta.idBodega
            ' otros Valores
            cmd.Parameters.Add("@OtroValor", SqlDbType.Decimal, 18, 2)
            cmd.Parameters("@OtroValor").Value = FacturVenta.OtroValor
            ' ID STADO CAJA
            cmd.Parameters.Add("@idCajaStado", SqlDbType.Int, 32)
            cmd.Parameters("@idCajaStado").Value = TerminalActivo.idCajaStado
            'Err_code
            Err_code = 0
            sql = ""

            Dim buffer As New System.Text.StringBuilder
            For i = 0 To cmd.Parameters.Count - 1
                buffer.Append(cmd.Parameters(i).ParameterName)
                buffer.Append(vbTab)
                buffer.Append("=")
                buffer.Append(vbTab)
                buffer.Append(cmd.Parameters(i).Value)
                buffer.Append(vbNewLine)
            Next

            If cmd.ExecuteNonQuery() >= 0 Then
                If Err_code > 0 Then
                    Return False
                End If
                Return True
            Else
                Return False
            End If
        Catch SqlEx As SqlException
            MsgBox(SqlEx.Number & " - " & SqlEx.Message, MsgBoxStyle.Exclamation, "Error")
            Return False
        End Try
    End Function
    Private Sub OnInfoMessage(sender As Object, args As SqlInfoMessageEventArgs)
        Err_code = args.Errors.Item(0).Number
        Dim err As SqlError
        For Each err In args.Errors
            MsgBox(err.Message, MsgBoxStyle.Exclamation, "Error")
        Next
    End Sub
    Public Function Order_Proceso(idProforma As Integer, cn As SqlConnection, tr As SqlTransaction) As Boolean
        'solo a las ventas listas para facturar cambiará al codigo 10 
        Try
            Using cmd As New SqlCommand("[dbo].[prcProforma_a_Factura]", cn, tr)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
                cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal

                cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                cmd.Parameters("@codUser").Value = UsuarioActivo.codUser

                cmd.Parameters.Add("@idProforma", SqlDbType.Int)
                cmd.Parameters("@idProforma").Value = idProforma
                If cmd.ExecuteNonQuery() Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Function Medida(ByVal idPresent As Integer) As DataTable
        Try
            Dim cmd = New SqlCommand("[dbo].[returnMedida]", Cnn_sql)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@idPresent", idPresent)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return dt
                Else
                    Return Nothing
                End If
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Al validar Usuario")
            Return Nothing
        End Try
    End Function


End Module

Public Module PROFORMA
    Public Function Procesa_Proforma() As Integer
        Dim cn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
        AddHandler cn.InfoMessage, AddressOf cn_InfoMessage
        Try
            cn.Open()
            Using cmd As New SqlCommand("[dbo].[prcProforma]", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                cmd.Parameters("@codUser").Value = UsuarioActivo.codUser

                cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
                cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal

                cmd.Parameters.Add("@otrosValores", SqlDbType.Decimal, 18, 2)
                cmd.Parameters("@otrosValores").Value = FacturVenta.OtroValor

                cmd.Parameters.Add("@idCliente", SqlDbType.Int)
                cmd.Parameters("@idCliente").Value = FacturVenta.idCliente

                cmd.Parameters.Add("@NameDocumento", SqlDbType.VarChar, 50)
                cmd.Parameters("@NameDocumento").Value = FacturVenta.nameDocunt

                cmd.Parameters.Add("@idProforma", SqlDbType.Int)
                cmd.Parameters("@idProforma").Direction = ParameterDirection.Output
                If cmd.ExecuteNonQuery() Then
                    If IsDBNull(cmd.Parameters("@idProforma").Value) Then
                        MsgBox("El procedimiento [dbo].[prcProforma] no retorno ningun valor..", MsgBoxStyle.Exclamation, "Error")
                        Return 0
                    End If
                    Return Integer.Parse(cmd.Parameters("@idProforma").Value)
                Else
                    Return 0
                End If
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            If Not IsNothing(cn) Then
                cn = Nothing
            End If
        End Try
    End Function
    Public Sub cn_InfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
        MsgBox("Ocurrio algo inesparado: " & e.Message, MsgBoxStyle.Critical, "Alerta")
    End Sub
    Public Function itemsXFactur(Optional ByVal idDocument As Integer = 0, Optional ByVal nameDocument As String = "") As Boolean
        Dim dt As New DataTable
        Try
            If idDocument = 0 And String.IsNullOrWhiteSpace(nameDocument) Then
                Return False
            End If

            If idDocument = 0 Then
                If LoadOptionsPrint(nameDocument) Then
                    sql = "Select f.NumFact01 +'-'+f.NumFact02+'-'+f.NumFact03++f.NumFact04 as [num], itemsPrintTicket  "
                    sql = sql & "from [stm].[terminalConfi] as f "
                    sql = sql & "inner join [stm].[terminal] as t on f.idTerminal = t.idTerminal "
                    sql = sql & "inner join [stm].[TypoDocumento] as d on d.idTypoDocu = f.idTypoDocumento "
                    sql = sql & "where ((t.codterminal = '" & TerminalActivo.codTerminal & "') and (d.Nom_Docu ='" & nameDocument & "')) "
                    Dim cmd As New ClassCargadorProducto()
                    dt = cmd.RetornaTabla(sql)
                End If
            ElseIf nameDocument.Length = 0 Then
                If LoadOptionsPrint(idDocument) Then
                    sql = "Select f.NumFact01 +'-'+f.NumFact02+'-'+f.NumFact03++f.NumFact04 as [num], itemsPrintTicket  "
                    sql = sql & "from [stm].[terminalConfi] as f "
                    sql = sql & "inner join [stm].[terminal] as t on f.idTerminal = t.idTerminal "
                    sql = sql & "where ((t.codterminal = '" & TerminalActivo.codTerminal & "') and (f.idTypoDocumento = " & idDocument & ")) "
                    Dim cmd As New ClassCargadorProducto()
                    dt = cmd.RetornaTabla(sql)
                End If
            End If

            sql = String.Empty
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    sql = dt.Rows(0)("num") & "  de " & dt.Rows(0)("itemsPrintTicket") & " Items por página"
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Module


