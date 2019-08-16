Imports System.Data.SqlClient
Public Class frmList_Proveedores
    Private stateLoad As stateLoad
    Private stateCliente As stateClient
    Protected Friend flag As String
    Protected Friend State As _state
    Protected Friend idProveedor As _state
    Private dt As New DataTable
    Private Dialogo As System.Windows.Forms.DialogResult
    Sub New(stateLoad As stateLoad, stateCliente As stateClient)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateLoad = stateLoad
        Me.stateCliente = stateCliente
    End Sub
    Private Sub frmListProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Mostrar()
        If stateCliente = stateClient.Cliente Then
            menuFlowLayoutPanel.Enabled = False
            MenuTables.Enabled = False
        End If
        Me.txtbuscar.Focus()
    End Sub

    Private Sub Mostrar()
        Try
            Dim func As New fProveedor
            dt = func.mostrar

            If IsNothing(dt) Then
                Exit Sub
            End If

            If dt.Rows.Count <> 0 Then
                Me.lblNoExiste.Visible = False
                Me.lblTotalListado.Text = "Total Listado: " & dt.Rows.Count
                dataListado.DataSource = dt
                dataListado.Columns(0).Visible = False
                dataListado.ColumnHeadersVisible = True
                dataListado.Columns(5).Visible = False
                dataListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Else
                dataListado.DataSource = Nothing
                dataListado.ColumnHeadersVisible = False
                Me.lblNoExiste.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        DefaultBnt(Me.bntBuscar)
    End Sub
    Private Sub DefaultBnt(bnt As Button)
        Me.AcceptButton = bnt
    End Sub

    Private Sub bntBuscar_Click(sender As Object, e As EventArgs) Handles bntBuscar.Click
        If Me.txtbuscar.Text.Length = 0 Then
            Mostrar()
        Else
            Mostrar_Selecion(Me.txtbuscar.Text)
        End If
        If dataListado.RowCount = 1 And (State = _state.Select_ Or State = _state.Admin) Then
            AcceptButton = btnOk
            txtbuscar.Focus()
        ElseIf dataListado.RowCount > 1 And (State = _state.Select_ Or State = _state.Admin) Then
            dataListado.Focus()
            AcceptButton = btnOk
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub Mostrar_Selecion(Buscardo As String)
        sql = "SELECt idProveedor, Ruc_Ci, Razon_social, Represent, Telefono, ivaSubTotal "
        sql = sql & "FROM dbo.Proveedores "
        sql = sql & "WHERE ((Ruc_Ci Like '%" & Buscardo & "%') or (Razon_social Like '%" & Buscardo & "%') or (Represent Like '%" & Buscardo & "%'))"

        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Me.lblNoExiste.Visible = False
                Me.dataListado.DataSource = dt
                Me.lblTotalListado.Text = "Total listado: " & dt.Rows.Count
                dataListado.Columns(0).Visible = False
                dataListado.ColumnHeadersVisible = True
                dataListado.Columns(5).Visible = False
            Else
                Me.lblNoExiste.Visible = True
                Me.dataListado.DataSource = Nothing
                Me.lblTotalListado.Text = "Total listado: 0"
            End If

        Catch ex As Exception
            Me.lblNoExiste.Visible = False
            Me.dataListado.DataSource = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar Proveedor")
        Finally
            desconecta_sql()
        End Try
    End Sub

    Private Function Elimina_Proveedor(idprovee As Integer) As Boolean
        sql = "Delete  Proveedores from Proveedores where idproveedor = " & idprovee & ""
        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Elimina_Proveedor")
            Return False
        Finally
            desconecta_sql()
        End Try
    End Function

    Private Sub Mostrar_PoId(idProveedor As Integer)
        sql = "SELECt idProveedor, Ruc_Ci, Razon_social, Represent, Telefono, ivaSubTotal "
        sql = sql & "FROM dbo.Proveedores "
        sql = sql & "WHERE idProveedor = " & idProveedor & ""
        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                Me.lblNoExiste.Visible = False
                Me.dataListado.DataSource = dt
                Me.lblTotalListado.Text = "Total listado: " & dt.Rows.Count
            Else
                Me.lblNoExiste.Visible = True
                Me.dataListado.DataSource = Nothing
                Me.lblTotalListado.Text = "Total listado: 0"
            End If

        Catch ex As Exception
            Me.lblNoExiste.Visible = False
            Me.dataListado.DataSource = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al buscar Proveedor")
        Finally
            desconecta_sql()
        End Try
    End Sub
    Private Sub dataListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellDoubleClick
        'cundo vengo en estado de dialogo
        If stateLoad = stateLoad.Dialogo Then
            btnOk.PerformClick()
        End If
    End Sub

    Private Sub btnVende_Click(sender As Object, e As EventArgs) Handles btnVende.Click
        Try
            If dataListado.SelectedRows.Count = 1 Then
                Using frm As New frmProduc_Proveedor
                    frm.txtidProveedor.Text = Me.dataListado.SelectedCells(0).Value
                    frm.lblTitulo.Text = Me.dataListado.SelectedCells(2).Value
                    frm.ShowDialog()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If dataListado.SelectedRows.Count = 1 Then
            Me.idProveedor = dataListado.SelectedCells.Item(dataListado.Columns("idProveedor").Index).Value
            DialogResult = DialogResult.OK
            Dialogo = DialogResult
        Else
            MsgBox("Selccione uno del listado", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub bntBuscar_TextChanged(sender As Object, e As EventArgs) Handles bntBuscar.TextChanged
        If bntBuscar.Text.Length > 2 Then
            AcceptButton = bntBuscar
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub DetailProviderButton_Click(sender As Object, e As EventArgs) Handles DetailProviderButton.Click
        Try
            Using forrnew As New frmAdd_Proveedor()
                With forrnew
                    .flag = "Ver"
                    .txtidProveedor.Text = dataListado.SelectedCells.Item(0).Value
                    .btnAcepter.Text = ""
                    .ShowDialog()
                End With
                Me.DialogResult = DialogResult.None
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NewProveedorButton_Click(sender As Object, e As EventArgs) Handles NewProveedorButton.Click
        Try
            Using addProvider As New frmAdd_Proveedor
                With addProvider
                    .flag = "Agregar"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        dataListado.DataSource = Nothing
                        Mostrar_Selecion(.RucMaskedTextBox.Text.Replace("-", ""))
                        Me.btnOk.PerformClick()
                    Else
                        Me.DialogResult = DialogResult.None
                    End If
                End With
            End Using
                Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Try
            If Me.dataListado.SelectedRows.Count = 1 Then
                If MsgBox("Esta seguro de eliminar?..", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..") = MsgBoxResult.Yes Then
                    If Elimina_Proveedor(dataListado.SelectedCells.Item(0).Value) Then
                        Mostrar_Selecion(Me.txtbuscar.Text)
                    Else
                        MsgBox("No se pudo eliminar", MsgBoxStyle.Information, "Al eliminar")
                    End If
                End If
                Me.DialogResult = DialogResult.None
            Else
                MsgBox("Seleccione el proveedor a aliminar", MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            Using forAddProvee As New frmAdd_Proveedor()
                With forAddProvee
                    .txtidProveedor.Text = dataListado.SelectedCells.Item(0).Value
                    .flag = "Modificar"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Mostrar_PoId(.txtidProveedor.Text)
                        Me.DialogResult = DialogResult.OK
                    End If
                End With
                Me.DialogResult = DialogResult.None
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub dataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellClick
        Me.idProveedor = 0
        If sender.SelectedRows.Count = 1 Then
            Me.idProveedor = dataListado.SelectedRows(0).Cells(sender.Columns("idProveedor").index).Value
            Admin_Controls()
        End If
    End Sub
    Private Sub Admin_Controls()
        Select Case stateCliente
            Case stateClient.Admin
                menuFlowLayoutPanel.Enabled = True
                MenuTables.Enabled = True
                btnOk.Enabled = True
            Case stateClient.User
                menuFlowLayoutPanel.Enabled = True
                MenuTables.Enabled = True
                btnOk.Enabled = True
                AcceptButton = btnOk
            Case stateClient.Cliente
                menuFlowLayoutPanel.Enabled = False
                MenuTables.Enabled = False
                btnOk.Enabled = False
        End Select
    End Sub
    Private Sub dataListado_KeyDown(sender As Object, e As KeyEventArgs) Handles dataListado.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            btnOk.PerformClick()
        End If
    End Sub
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmList_Proveedores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.DialogResult = DialogResult.None Then
            e.Cancel = True
        End If
    End Sub
End Class