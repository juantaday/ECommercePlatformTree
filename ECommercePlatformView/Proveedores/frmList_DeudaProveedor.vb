Public Class frmList_DeudaProveedor
    Private Enum ButMax
        No = 0
        si = 1
    End Enum
    Private stateBut As ButMax
    Private cargado As Boolean
    Private Sub frmList_DeudaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagarLinkLabel.Text = String.Empty
        Carga_datos()
        ocultaDetalle()
    End Sub
    Private Sub Carga_datos()
        Dim total As Double = 0
        cargado = False
        Try
            sql = "select t.idProveedor,t.Razon_social,t.documentos, "
            sql = sql & "case when t.[pagado] is not null then t.Total-t.[pagado] else t.Total end as [saldo] "
            sql = sql & "from ( "
            sql = sql & "select p.idProveedor,r.Razon_social  ,count(p.idPago) as [documentos], sum( p.val_Factura) as [Total], "
            sql = sql & "sum(pd.val_Pagado) as [pagado] "
            sql = sql & "From Pagos as p "
            sql = sql & "inner join Proveedores  as r on p.idProveedor = r.idProveedor "
            sql = sql & "left outer join PagoDetail  as pd on pd.idPago  = p.idPago "
            sql = sql & "where p.statePago = 0 "
            sql = sql & "group by p.idProveedor,r.Razon_social "
            sql = sql & ") as T "
            sql = sql & "order by t.Razon_social "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                Dim dd As New DataTable()
                If dt.Rows.Count > 0 Then
                    Dim fila As Integer = 0
                    With dtl
                        .Rows.Clear()
                        For i = 0 To dt.Rows.Count - 1
                            .Rows.Add()
                            fila = .Rows.Count - 1
                            .Rows(fila).Cells(ButtonClm.Index).Value = "+"
                            .Rows(fila).Cells(idProveedorClm.Index).Value = dt.Rows(i)("idProveedor")
                            .Rows(fila).Cells(ProveedorClm.Index).Value = dt.Rows(i)("Razon_social")
                            .Rows(fila).Cells(Cant_FacturClm.Index).Value = dt.Rows(i)("documentos")
                            total += dt.Rows(i)("saldo")
                            .Rows(fila).Cells(TotalClm.Index).Value = FormatNumber(dt.Rows(i)("saldo"), 2)
                            .Rows(fila).Cells(TotalClm.Index).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                            dd = Carga_detalle(.Rows(fila).Cells(idProveedorClm.Index).Value)
                            .Rows(fila).DefaultCellStyle.BackColor = Color.Gray
                            .Rows(fila).DefaultCellStyle.ForeColor = Color.White
                            If Not IsNothing(dd) Then
                                If dd.Rows.Count > 0 Then
                                    For x = 0 To dd.Rows.Count - 1
                                        .Rows.Add()
                                        fila = .Rows.Count - 1
                                        .Rows(fila).Cells(ButtonClm.Index).Value = String.Empty
                                        .Rows(fila).Cells(idProveedorClm.Index).Value = dt.Rows(i)("idProveedor")
                                        .Rows(fila).Cells(Num_documentClm.Index).Value = dd.Rows(x)("Num_Docu")
                                        sql = FormatDateTime(dd.Rows(x)("fecha"), DateFormat.ShortDate) & " ($"
                                        sql = sql & FormatNumber(dd.Rows(x)("val_Factura"), 2) & ")"
                                        .Rows(fila).Cells(FechaCompraClm.Index).Value = sql
                                        .Rows(fila).Cells(TotalClm.Index).Value = FormatNumber(dd.Rows(x)("saldo"), 2)
                                        .Rows(fila).Cells(TotalClm.Index).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                                        .Rows(fila).Visible = False
                                    Next
                                End If
                            End If
                        Next
                        .RowHeadersVisible = False
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        .Columns(ButtonClm.Index).Width = 30
                        .Columns(idProveedorClm.Index).Visible = False
                        .Columns(FechaCompraClm.Index).Visible = False
                        .Columns(Num_documentClm.Index).Visible = False
                        .ScrollBars = 3
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            totalLabel.Text = "Total deuda: " & FormatNumber(total, 2)
            cargado = True
            ImpideOrdenamiento(dtl)
        End Try
    End Sub
    Private Function Carga_detalle(idProveedor As Integer) As DataTable
        Try
            sql = "select p.idFacturaCompra as [Num_Docu],CONVERT(date, p.fech_Factura) as [fecha], p.val_Factura, "
            sql = sql & "case when pd.val_Pagado is not null then p.val_Factura - pd.val_Pagado else p.val_Factura end as [saldo] "
            sql = sql & "from Pagos as p "
            sql = sql & "left outer join PagoDetail  as pd on pd.idPago  = p.idPago "
            sql = sql & "where p.idProveedor = " & idProveedor & " And p.statePago = 0  "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Return dt
                End If
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Private Sub ocultaDetalle()
        Try
            With dtl
                For i = 0 To .Rows.Count - 1
                    If Not .Rows(i).Cells(ButtonClm.Index).Value.Equals("+") Then
                        .Rows(i).Height = 0
                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message + " en el ocultar deltalle", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub dtl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtl.CellContentClick
        Try
            If e.ColumnIndex = ButtonClm.Index Then
                Dim idProveedor As Integer = dtl.Rows(e.RowIndex).Cells(idProveedorClm.Index).Value
                Dim i As Integer = e.RowIndex
                Dim est As Boolean = True
                If dtl.SelectedCells.Item(e.ColumnIndex).Value = "+" Then
                    dtl.SelectedCells.Item(e.ColumnIndex).Value = "-"
                    Do While est
                        i += 1
                        If Not dtl.Rows(i).Cells(idProveedorClm.Index).Value = idProveedor Then
                            Exit Do
                        End If
                        dtl.Rows(i).Visible = True
                        dtl.Rows(i).Height = 30
                        dtl.Columns(Num_documentClm.Index).Visible = True
                        dtl.Columns(FechaCompraClm.Index).Visible = True
                        For c = 0 To dtl.ColumnCount - 1
                            dtl.Rows(i).Cells(c).Style.BackColor = Color.White
                        Next
                        If i = dtl.RowCount - 1 Then
                            Exit Do
                        End If
                    Loop
                ElseIf dtl.SelectedCells.Item(e.ColumnIndex).Value = "-" Then
                    dtl.SelectedCells.Item(e.ColumnIndex).Value = "+"
                    Do While est
                        i += 1
                        If Not dtl.Rows(i).Cells(idProveedorClm.Index).Value = idProveedor Then
                            Exit Do
                        End If
                        dtl.Rows(i).Visible = False
                        dtl.Columns(Num_documentClm.Index).Visible = False
                        dtl.Columns(FechaCompraClm.Index).Visible = False
                        If i = dtl.RowCount - 1 Then
                            est = False
                        End If
                    Loop
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtl_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtl.RowEnter
        Try
            If cargado Then
                If dtl.SelectedRows.Count = 1 Then
                    If IsNothing(dtl.SelectedCells.Item(ProveedorClm.Index).Value) Then
                        pagarLinkLabel.Visible = False
                        Return
                    End If
                    If dtl.SelectedCells.Item(ProveedorClm.Index).Value.Equals(String.Empty) Then
                        pagarLinkLabel.Visible = False
                        Return
                    End If
                    pagarLinkLabel.Visible = True
                    pagarLinkLabel.Text = "Realizar pago al proveedor : " + dtl.SelectedCells.Item(ProveedorClm.Index).Value
                Else
                    pagarLinkLabel.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub pagarLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles pagarLinkLabel.LinkClicked
        Using fornew As New frmPagos
            With fornew
                .Text = "Gestión de deuda del proveedor: " & dtl.SelectedCells.Item(ProveedorClm.Index).Value
                .idProveedor = dtl.SelectedCells.Item(idProveedorClm.Index).Value
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
                If .Operation Then
                    Carga_datos()
                End If
            End With
        End Using
    End Sub
    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        cmdSelectAll(dtl)
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        cmdCopy(dtl)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub

    Private Sub dtl_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dtl.CellPainting
        Try
            If (e.ColumnIndex = ProveedorClm.Index Or e.ColumnIndex = Cant_FacturClm.Index) And e.RowIndex >= 0 Then
                If IsNothing(e.Value) Then
                    e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
                End If
                If e.ColumnIndex = Cant_FacturClm.Index Then
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class