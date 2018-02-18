'Imports LibPrintTicketMatriz.PrintTicket

Public Class frmDetailOrderVenta
    Private Iniciada As Boolean
    Private txtTotalGeneral As Double
    Protected Friend flag As String
    Protected Friend Ruc As String
    Protected Friend NameCliente As String
    Protected Friend OtroValor As Double
    Protected Friend idOrden As Integer
    Protected Friend NameDocument As String
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs)
        Close()
    End Sub

    Private Sub frmDetailOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'cargo la orden y si ya mada a imprimir lo imprimo
        Cursor = Cursors.WaitCursor
        cargarOrden()
        Cursor = Cursors.Default
    End Sub
    Private Sub cargarOrden()
        Iniciada = True
        sql = "select  vd.idVentaDetail, vd.idPresent,pp.codProducto,p.Nom_Comercial,vd.Cant_Vent as Cantidad ,vd.Vent_Total  as Total, pp.idProducto from Ventas_Detail  as vd "
        sql = sql & "inner join ProductoPresentacion  as pp on pp.idPresentacion = vd.idPresent "
        sql = sql & "inner join Productos as p on p.idProducto = pp.idProducto  "
        sql = sql & "where vd.idVenta = " & idOrden & " "
        Try
            DataGridView1.DataSource = Nothing
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Me.DataGridView1.DataSource = dt
                    DataGridView1.Columns(0).Visible = False
                    DataGridView1.Columns(1).Visible = False
                    Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Me.DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Me.DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    DataGridView1.Columns(6).Visible = False
                End If
                dt = Nothing
                lblTotal.Text = "Costo Total : $ " & Sumatotal() + OtroValor
            End If
            cmd = Nothing
            Iniciada = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar detalle de orden")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("Está seguro de eliminar el registro", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..") = MsgBoxResult.Yes Then
            If Elimina_Registro() Then
                cargarOrden()
            End If
        End If
    End Sub
    Private Function Elimina_Registro() As Boolean
        Try
            sql = "Delete Ventas_Detail from Ventas_Detail "
            sql = sql & "Where Ventas_Detail.idVentaDetail = " & DataGridView1.SelectedCells.Item(0).Value & " "
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Sumatotal() As Double
        txtTotalGeneral = 0
        Try
            sql = "SELECT SUM(vd.Vent_Total) AS total FROM dbo.Ventas_Detail AS vd "
            sql = sql & "WHERE (vd.idVenta =" & idOrden & ") "

            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    txtTotalGeneral = dt.Rows(0)("total")
                    Return dt.Rows(0)("total")
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEddCantidad.Click
        Using fornew As New frmImputData()
            With fornew
                .txtNumber.Value = DataGridView1.SelectedCells.Item(4).Value
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    If Edita_Cantidad(.txtNumber.Value) Then
                        cargarOrden()
                    End If
                End If
            End With
        End Using
    End Sub
    Private Function Edita_Cantidad(ByVal Cantidad As Double) As Boolean
        'PrecTotal / cantidad
        If Cantidad <= 0 Then
            sql = "Imposible modifcicar sifras menores a cero.. " & vbNewLine & ""
            sql = sql & "Puede tomar la opción de Eliminar.." & vbNewLine & ""
            MsgBox(sql, MsgBoxStyle.Information, "Eviso")
            Return False
        End If
        Dim Precio_Und As Double = DataGridView1.SelectedCells.Item(5).Value / DataGridView1.SelectedCells.Item(4).Value
        Precio_Und = Redondear(Precio_Und * Cantidad, 5)
        Try
            sql = "Update vd set vd.Cant_Vent = " & Cantidad & ", vd.Vent_Total =" & Precio_Und & " "
            sql = sql & "from Ventas_Detail  as vd "
            sql = sql & "Where vd.idVentaDetail = " & DataGridView1.SelectedCells.Item(0).Value & " "
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        If Not Iniciada Then
            If DataGridView1.SelectedRows.Count = 1 Then
                btnEliminar.Enabled = True
                btnEddCantidad.Enabled = True
            Else
                btnEliminar.Enabled = False
                btnEddCantidad.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DataGridView1.RowCount > 0 Then
            Print_Proforma(idOrden, Me.NameDocument)
        End If
    End Sub


    Private Sub btnNoselect_Click(sender As Object, e As EventArgs) Handles btnNoselect.Click
        cmdNotSelect(DataGridView1)
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        cmdSelectAll(DataGridView1)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        cmdCopy(DataGridView1)
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class