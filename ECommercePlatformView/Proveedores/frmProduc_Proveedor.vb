Imports System.Data.SqlClient
'Imports LibPrintTicketMatriz.PrintTicket


Public Class frmProduc_Proveedor
    Dim arrProveedor(,,) As Integer
    Private Property dr As SqlDataReader


    Private Sub frmLista_Proveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        'carga losprocutos 
        Mostrar_Productos(Me.txtidProveedor.Text)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub QuienesVenden(ByVal idProveedor As Integer, ByVal idPresent As Integer)

        sql = "select idProveedor from ProductoProveedor where (idPresentacion = " & idPresent & " and idProveedor <> " & idProveedor & ")"

        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                For i = 0 To dt.Rows.Count - 1
                    Dim band As Boolean = False

                    If IsNothing(arrProveedor) Then
                        ReDim arrProveedor(0, 1, 0)
                        arrProveedor(arrProveedor.GetLowerBound(0), 0, 0) = dt(i)(0).ToString
                        arrProveedor(arrProveedor.GetLowerBound(0), 1, 0) += 1
                    Else
                        For j = 0 To arrProveedor.GetLength(2) - 1
                            If arrProveedor(0, 0, j) = dt(i)(0).ToString Then
                                arrProveedor(0, 1, j) += 1
                                band = True
                            End If
                        Next
                        If band = False Then
                            ReDim Preserve arrProveedor(0, 1, arrProveedor.GetLength(2))
                            arrProveedor(0, 0, arrProveedor.GetUpperBound(2)) = dt(i)(0).ToString
                            arrProveedor(0, 1, arrProveedor.GetUpperBound(2)) += 1
                        End If

                    End If


                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el Motrar_Productos del " & Me.Name)

        End Try

    End Sub

    Private Sub Mostrar_Productos(ByVal idProveedor As Integer)

        sql = "SELECT        TOP (100) PERCENT pr.idPresentacion, p.Nom_Comun, m.Medida + 'x' + CAST(CAST(pr.Cant_Present AS int) AS varchar(20)) + dbo.ProductoUndMedida.Medida AS Empaque, "
        sql = sql + "CAST(pp.CostoTotal AS decimal(18, 2)) AS costo "
        sql = sql + "FROM            dbo.ProductoProveedor AS pp INNER JOIN "
        sql = sql + "dbo.ProductoPresentacion AS pr ON pp.idPresentacion = pr.idPresentacion INNER JOIN "
        sql = sql + "dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed INNER JOIN "
        sql = sql + "dbo.Productos AS p ON pr.idProducto = p.idProducto INNER JOIN "
        sql = sql + "dbo.ProductoUndMedida ON pr.idProUndReferen = dbo.ProductoUndMedida.idProUndMed "
        sql = sql + "WHERE        (p.Activo = 1) AND (pp.idProveedor = " & idProveedor & ") "
        sql = sql + "ORDER BY p.Nom_Comun"


        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)

                Me.dataListado.DataSource = Nothing
                lbltotal.Text = "Total :0"
                If dt.Rows.Count > 0 Then
                    With Me.dataListado
                        .DataSource = dt
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        .Columns(0).Visible = False
                        lbltotal.Text = "Total del listado: " & dt.Rows.Count
                    End With

                End If

                'If dar.HasRows Then
                '    While dar.Read()
                '        Quienes_Venden(dar(0).ToString, idProveedor)
                '    End While
                'End If

                'dar.Close()
            End Using
        Catch ex As Exception
            dataListado.DataSource = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el Motrar_Productos del " & Me.Name)

        End Try

    End Sub


    Private Sub sMenuEditar_Click(sender As Object, e As System.EventArgs) Handles sMenuEditar.Click

    End Sub

    Private Sub dataListado_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataListado.ColumnHeaderMouseClick

    End Sub


    Private Function LosMejoresProveedores() As Boolean
        Dim buel As Boolean = False

        If Not IsNothing(arrProveedor) Then
            OrdenaMatriz()
            For i = 0 To arrProveedor.GetLength(2) - 1
                sql = arrProveedor(0, 0, i)
                If arrProveedor(0, 0, i) > 0 Then
                    PonePrecios(arrProveedor(0, 0, i))
                    buel = True
                End If
            Next
            Return buel
        Else
            Return False
        End If

    End Function
    Private Sub OrdenaMatriz()


        If IsNothing(arrProveedor) Then
            Exit Sub
        End If


        Dim band As Boolean = False
        Dim auxP, auxC As Integer
        While (band = False)
            band = True
            For i = 0 To arrProveedor.GetLength(2) - 1
                If i <> arrProveedor.GetLength(2) - 1 Then
                    If arrProveedor(0, 1, i) < arrProveedor(0, 1, i + 1) Then
                        auxP = arrProveedor(0, 0, i + 1)
                        auxC = arrProveedor(0, 1, i + 1)

                        arrProveedor(0, 0, i + 1) = arrProveedor(0, 0, i)
                        arrProveedor(0, 1, i + 1) = arrProveedor(0, 1, i)

                        arrProveedor(0, 0, i) = auxP
                        arrProveedor(0, 1, i) = auxC
                        band = False
                    End If
                End If

            Next

        End While

        ReDim Preserve arrProveedor(0, 1, 3)

    End Sub

    Private Sub PonePrecios(ByVal idProveedor As Integer)
        Dim rowIndex As Integer


        dataListado.Columns.Add(dataListado.Columns.Count - 1, NombreProveedor(idProveedor))

        For i = 0 To Me.dataListado.Rows.Count - 1
            rowIndex = Me.dataListado.Rows(i).Cells(0).Value

            sql = "SELECT CAST(CostoTotal AS decimal(10, 2)) AS costo "
            sql += "FROM dbo.ProductoProveedor "
            sql += "WHERE  (idPresentacion = " & rowIndex & " ) AND (idProveedor = " & idProveedor & ") "

            conecta_sql()

            Try
                Using cmd As New SqlCommand(sql, Cnn_sql)
                    cmd.CommandType = CommandType.Text
                    Dim dat As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable

                    dat.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        Me.dataListado.Rows(i).Cells(dataListado.Columns.Count - 1).Value = dt(0)(0).ToString
                    Else
                        Me.dataListado.Rows(i).Cells(dataListado.Columns.Count - 1).Value = "-"
                    End If
                End Using

            Catch ex As Exception

            End Try

        Next

    End Sub



    Private Function NombreProveedor(ByVal idproveedor As Integer) As String
        conecta_sql()

        Try

            sql = "Select Razon_social from Proveedores where idProveedor  = " & idproveedor & ""

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Return dt(0)(0).ToString
                Else
                    Return "No hay"
                End If
            End Using



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
            Return "Error"
        End Try

    End Function

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPrintTicket.Click

    '        Dim Fecha = Convert.ToString(FormatDateTime(Now, DateFormat.ShortDate))
    '        Dim Hora = Convert.ToString(FormatDateTime(Now, DateFormat.ShortTime))



    '        If Me.dataListado.Rows.Count > 0 Then
    '            Dim ticket As New CreaTicket


    '            If ImpresoTicketName() Then
    '                ticket.PrinterName = optPrintFactur.NamePrint
    '                If optPrintFactur.Color = "Rojo" Then
    '                    ticket.ColorPrintCinta(ColorPrint.Rojo)
    '                Else
    '                    ticket.ColorPrintCinta(ColorPrint.Negro)
    '                End If
    '            Else
    '                If SeleccionarImpresora() Then
    '                    ticket.PrinterName = prtSettings.PrinterName
    '                Else
    '                    GoTo Salida
    '                End If
    '            End If

    '            ticket.FontZiseText(FontZise.l6cpp)
    '            ticket.TextoCentro(NombreProveedor(Me.txtidProveedor.Text), False)
    '            ticket.FontZiseText(FontZise.Default)
    '            ticket.TextoExtremos(Fecha + " " + Hora, UsuarioActivo.codUser)
    '            ticket.LineasGuion()
    '            For i = 0 To Me.dataListado.Rows.Count - 1
    '                If i = 0 Then
    '                    If Me.dataListado.ColumnCount = 4 Then
    '                        sql = "PRODUCTO                   EMP     COSTO"
    '                    ElseIf Me.dataListado.ColumnCount = 5 Then
    '                        sql = "PRODUCTO              EMP COSTO  " & TextoDiseñado(Me.dataListado.Columns.Item(4).HeaderText, Alinea.Izquierda, 7)
    '                    ElseIf Me.dataListado.ColumnCount = 6 Then
    '                        sql = "PRODUCTO    EMP COSTO " & TextoDiseñado(Me.dataListado.Columns.Item(4).HeaderText, Alinea.Izquierda, 7) & " " & _
    '                        TextoDiseñado(Me.dataListado.Columns.Item(5).HeaderText, Alinea.Izquierda, 7)
    '                    ElseIf Me.dataListado.ColumnCount > 6 Then
    '                        sql = "PRODUCTO   EMP COSTO  " & TextoDiseñado(Me.dataListado.Columns.Item(4).HeaderText, Alinea.Izquierda, 5) & " " & _
    '                        TextoDiseñado(Me.dataListado.Columns.Item(5).HeaderText, Alinea.Izquierda, 5) & " " & _
    '                        TextoDiseñado(Me.dataListado.Columns.Item(6).HeaderText, Alinea.Izquierda, 5)
    '                    End If
    '                    ticket.TextoCentro(sql, False)
    '                    ticket.LineasGuion()
    '                End If

    '                If Me.dataListado.ColumnCount = 4 Then
    '                    sql =
    '                          TextoDiseñado(dataListado.Item(1, i).Value, Alinea.Izquierda, 26) + " " +
    '                          TextoDiseñado(dataListado.Item(2, i).Value, Alinea.Izquierda, 6) + " " +
    '                          TextoDiseñado(dataListado.Item(3, i).Value, Alinea.Derecha, 6)
    '                ElseIf Me.dataListado.ColumnCount = 5 Then
    '                    sql =
    '                        TextoDiseñado(dataListado.Item(1, i).Value, Alinea.Izquierda, 19) + " " +
    '                        TextoDiseñado(dataListado.Item(2, i).Value, Alinea.Izquierda, 3) + " " +
    '                        TextoDiseñado(dataListado.Item(3, i).Value, Alinea.Derecha, 6) + " " +
    '                        TextoDiseñado(dataListado.Item(4, i).Value, Alinea.Derecha, 6)
    '                ElseIf Me.dataListado.ColumnCount = 6 Then
    '                    sql =
    '                        TextoDiseñado(dataListado.Item(1, i).Value, Alinea.Izquierda, 19) + " " +
    '                        TextoDiseñado(dataListado.Item(2, i).Value, Alinea.Izquierda, 2) + " " +
    '                        TextoDiseñado(dataListado.Item(3, i).Value, Alinea.Derecha, 5) + " " +
    '                        TextoDiseñado(dataListado.Item(4, i).Value, Alinea.Derecha, 5) + " " +
    '                        TextoDiseñado(dataListado.Item(5, i).Value, Alinea.Derecha, 5)
    '                ElseIf Me.dataListado.ColumnCount > 6 Then  'ghg
    '                    sql =
    '                      TextoDiseñado(dataListado.Item(1, i).Value, Alinea.Izquierda, 13) + " " +
    '                      TextoDiseñado(dataListado.Item(2, i).Value, Alinea.Izquierda, 2) + " " +
    '                      TextoDiseñado(dataListado.Item(3, i).Value, Alinea.Derecha, 5) + " " +
    '                      TextoDiseñado(dataListado.Item(4, i).Value, Alinea.Derecha, 5) + " " +
    '                      TextoDiseñado(dataListado.Item(5, i).Value, Alinea.Derecha, 5) + " " +
    '                      TextoDiseñado(dataListado.Item(6, i).Value, Alinea.Derecha, 5)
    '                End If
    '                ticket.TextoCentro(sql, False)
    '            Next
    '            ticket.CortaTicket()
    '        End If

    'salida:

    '    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuienVende.Click
        Me.Cursor = Cursors.WaitCursor
        'Busca quienes venden
        For i = 0 To Me.dataListado.Rows.Count - 1
            QuienesVenden(Me.txtidProveedor.Text, Me.dataListado.Rows(i).Cells(0).Value)
        Next
        'Seleciona los 4 mejoere
        If Not LosMejoresProveedores() Then
            MsgBox("No existe otros PROVEEDORES con que vendan estos productos", MsgBoxStyle.Information, "Aviso")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDeleteComp.Click
        If Me.dataListado.ColumnCount > 4 Then
            Me.dataListado.Columns.Remove(Me.dataListado.Columns(Me.dataListado.ColumnCount - 1).Name)
        End If
    End Sub

    Private Sub btnRefres_Click(sender As Object, e As EventArgs) Handles btnRefres.Click
        Mostrar_Productos(Me.txtidProveedor.Text)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class




