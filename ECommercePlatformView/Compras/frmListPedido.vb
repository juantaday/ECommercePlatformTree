Imports System.Data.SqlClient
Public Class frmListPedido
    Protected Friend IdPedido As Integer
    Private Sub frmListPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Carga_ListPedido()
    End Sub

    Private Sub Carga_ListPedido()

        Try
            Using db As New DataContext
                Dim QreLinq = From p In db.Pedidos
                              Join b In db.Bodegas On p.idBodega Equals b.idBodega
                              Join pr In db.Proveedores On pr.idProveedor Equals p.idProveedor
                              Select Orden = p.idPedido, p.fechaPedido, Proveedor = pr.Razon_social,
                             p.base00Iva, p.base12Iva, p.iva, p.TotalPedido, Bodega = b.Nom_Bodega

                If QreLinq.Count > 0 Then
                    datalistado.DataSource = QreLinq.ToList()
                    datalistado.AutoSizeColumnsMode =
                                     DataGridViewAutoSizeColumnsMode.AllCells
                Else
                    datalistado.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar Listado")
            datalistado.DataSource = Nothing
        Finally
            desconecta_sql()
        End Try

    End Sub
    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If Len(datalistado.SelectedRows.Count) = 0 Then
            MsgBox("Seleccione uno de la lista", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        If (MsgBox("Está seguro de eliminar el pedido", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..")) = DialogResult.Yes Then
            Dim RowSelect As DataGridViewSelectedRowCollection = datalistado.SelectedRows
            Dim Rows As DataGridViewRow
            For Each Rows In RowSelect
                ELimina_Pedido(Rows.Cells(0).Value)
            Next
            Carga_ListPedido()
        End If
    End Sub


    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles ComprarButton.Click
        If Me.datalistado.SelectedRows.Count = 1 Then
            With frmAdquisicion
                .txtOrden.Text = Me.datalistado.SelectedCells.Item(0).Value
                .TotalPediText.Text = datalistado.SelectedCells.Item(6).Value
                .dtFechaPedido.Value = Me.datalistado.SelectedCells.Item(1).Value
                .dtFechaCompra.Value = Me.datalistado.SelectedCells.Item(1).Value
                .txtFalg.Text = 2
                .Carga_Tipo_Consumo()
                .Carga_Declaracion()

                .Width = 500
                .Height = 500
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
            frmAdquisicion = Nothing
            Carga_ListPedido()
        Else
            MsgBox("No existe informacion en el listado", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles CopyAllButton.Click

    End Sub

    Private Sub SelectAllButton_Click_1(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        cmdSelectAll(datalistado)
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        If Me.datalistado.SelectedRows.Count = 1 Then
            IdPedido = datalistado.SelectedRows(0).Cells("Orden").Value
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Seleccione uno de la lista", MsgBoxStyle.Exclamation, "Importante")
        End If
    End Sub
End Class