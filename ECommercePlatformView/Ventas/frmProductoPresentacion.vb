Imports System.Data.SqlClient

Public Class frmProductoPresentacion
    Protected Friend idproducto As Integer
    Protected Friend idpresentacion As Integer
    Protected Friend flag As String

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            idpresentacion = DataGridView1.SelectedCells.Item(0).Value
            txtMedida.Text = DataGridView1.SelectedCells.Item(2).Value
            txtPrecioUnidad.Text = DataGridView1.SelectedCells.Item(7).Value
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmProductoPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ImpideOrdenamiento()
            Carga_Datos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImpideOrdenamiento()
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
        Next i
    End Sub

    Private Sub Carga_Datos()
        sql = " SELECT  pr.idPresentacion ,  m.Nom_Medida as Presentación, "
        sql = sql & "pr.Presentacion  as [detalle], "
        sql = sql & "pr.precioVenta as [Precio Venta],  m.Medida, pum.signo as signo, pr.Cant_Present, mp.Medida as medRefery "
        sql = sql & "FROM dbo.ProductoPresentacion AS pr INNER JOIN "
        sql = sql & "dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed INNER JOIN "
        sql = sql & "dbo.ProductoUndMedida AS mp ON pr.idProUndReferen = mp.idProUndMed INNER JOIN "
        sql = sql & "dbo.Productos AS p ON pr.idProducto = p.idProducto INNER JOIN "
        sql = sql & "dbo.ProductoUndMin AS pum ON p.idUnidad = pum.idUnidad "
        sql = sql & "WHERE(pr.idProducto = " & idproducto & ") "
        Dim cmd As New ClassCargadorProducto()
        Dim fila As Integer = 0

        Try
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Dim dtg As DataGridView = Me.DataGridView1
                    dtg.Columns(0).Visible = False  'oculto idpresent
                    dtg.Columns(6).Visible = False  'oculto medida
                    dtg.Columns(7).Visible = False  'oculto Precio Unitario de cada presentacion

                    For i = 0 To dt.Rows.Count - 1
                        dtg.Rows.Add()
                        dtg.Item(0, fila).Value = dt.Rows(i)("idPresentacion")   'idPresent
                        dtg.Item(1, fila).Value = dt.Rows(i)(1)   'Presenatción

                        dtg.Item(2, fila).Value = dt.Rows(i)("detalle")
                        dtg.Item(3, fila).Value = "--------"      '# de oferta
                        dtg.Item(4, fila).Value = "=====>"        'a partir de 
                        dtg.Item(5, fila).Value = dt.Rows(i)(3)   'precio venta 
                        dtg.Item(5, fila).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        dtg.Item(6, fila).Value = dt.Rows(i)(4)   'Medida
                        dtg.Item(7, fila).Value = dt.Rows(i)(3)   'precio venta en cada presentación

                        dtg.Rows(fila).DefaultCellStyle.BackColor = Color.Silver
                        dtg.Rows(fila).DefaultCellStyle.Font = New Drawing.Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point)
                        dtg.Rows(fila).DefaultCellStyle.ForeColor = Color.Blue

                        'DETALLE DE ofertas si existen
                        sql = "Select  o.CantOferta,o.valor_Oferta, o.Caducidad,o.fech_Caduce from ofertas As o "
                        sql = sql & "where o.idPresent = " & dt.Rows(i)("idPresentacion") & " "
                        sql = sql & "Order by o.orden "

                        Dim sqlpro As New SqlDataAdapter(sql, Cnn_sql)
                        Dim dtOfer As New DataTable
                        sqlpro.Fill(dtOfer)
                        If dtOfer.Rows.Count > 0 Then
                            For o = 0 To dtOfer.Rows.Count - 1
                                fila += 1
                                dtg.Rows.Add()
                                'agrego codigos ocultos
                                dtg.Item(0, fila).Value = dt.Rows(i)("idPresentacion")   'idPresent
                                dtg.Item(6, fila).Value = dt.Rows(i)(4)   'Medida
                                dtg.Item(7, fila).Value = dt.Rows(i)(3)   'precio venta en cada presentación

                                'verifico si ya está caducado 
                                If Boolean.Parse(dtOfer.Rows(o)("Caducidad").ToString) Then
                                    Dim ahora As Date = FormatDateTime(Now(), DateFormat.ShortDate)
                                    Dim evaluar As Date = Date.Parse(dtOfer.Rows(o)("fech_Caduce").ToString)

                                    If Date.Parse(evaluar) < Date.Parse(ahora) Then
                                        dtg.Item(3, fila).Value = "Caducada =>"
                                        dtg.Item(3, fila).Style.Font = New Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                                        dtg.Item(3, fila).Style.ForeColor = Color.Red
                                    Else
                                        dtg.Item(3, fila).Value = "Oferta " & o + 1
                                    End If

                                Else
                                    dtg.Item(3, fila).Value = "Oferta " & o + 1
                                End If
                                dtg.Item(4, fila).Value = dtOfer.Rows(o)("CantOferta").ToString
                                'precio de venta
                                Dim pventas As Double = 0
                                pventas = (Double.Parse(dtOfer.Rows(o)("valor_Oferta").ToString)) * Double.Parse(dt.Rows(i)(3))
                                dtg.Item(5, fila).Value = Redondear(Double.Parse(dt.Rows(i)(3)) - pventas, 5)
                                dtg.Item(5, fila).Style.Alignment = DataGridViewContentAlignment.MiddleRight  'alineamos acia la derecha
                            Next
                        End If
                        fila += 1
                    Next
                    Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Datos del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        Try
            If (e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2) And e.RowIndex >= 0 Then
                If e.Value = "" Then
                    e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
                End If
                If e.ColumnIndex = 2 Then
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmProductoPresentacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.PerformClick()
        End If
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If DataGridView1.Item(4, e.RowIndex).Value = "=====>" And flag = "Operando" Then
            OK_Button.Enabled = True
        Else
            OK_Button.Enabled = False
        End If
    End Sub
End Class
