Imports System.Data.SqlClient
Public Class frm_Proveedor
    Private myPadre As MDI_AddProductos
    Protected Friend id_PresentCompra As Integer
    Protected Friend id_Proveedor As Integer
    Protected Friend id_producto As Integer
    Protected Friend id_SeCompra As Integer
    Sub New(myPadre As MDI_AddProductos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.myPadre = myPadre
    End Sub
    Private Sub frm_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.myPadre
            id_SeCompra = .Id_seCompra
            id_PresentCompra = RetornaIdCompra(.Id_seCompra)
            id_Proveedor = .Id_Proveedor
        End With
        CargaControlProveedor()
    End Sub
    Private Sub CargaControlProveedor()
        Try
            Me.Cursor = Cursors.WaitCursor
            If id_PresentCompra > 0 Then
                If id_Proveedor > 0 And (Busca_idProductProveedor(id_PresentCompra, id_Proveedor) = 0) Then
                    Guarda_Prod_Vendedor(id_PresentCompra, id_Proveedor)
                End If
                Carga_Present_Vendible(id_producto)
            Else
                MsgBox("Determine las presentaciones mas utiles para la compra y venta ", MsgBoxStyle.Exclamation, "Aviso")
                Me.myPadre.menuPresentacion.PerformClick()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function RetornaIdCompra(ByVal idMedida As Integer) As Integer
        Try
            sql = "select pp.idPresentacion from ProductoPresentacion as pp "
            sql = sql & "where pp.idProducto = " & id_producto & " and pp.idProUndMed = " & idMedida & " "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Function Carga_Present_Vendible(ByVal idProducto As Integer) As Boolean
        'a qie cojo la presentacion especifica en que acaba de poner como opcion de compra
        sql = "SELECT  pr.idPresentacion, m.Nom_Medida, CAST('' AS varchar(30)) AS Empaque, pr.Cant_Present,pm.Medida as MedRefery "
        sql = sql & "FROM dbo.ProductoPresentacion AS pr INNER JOIN "
        sql = sql & "dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed INNER JOIN "
        sql = sql & "dbo.ProductoUndMedida AS pm ON pr.idProUndReferen = pm.idProUndMed "
        sql = sql & "WHERE (pr.idPresentacion = " & id_PresentCompra & ") "
        Try
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            Me.DataGridComprables.DataSource = Nothing
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    'aqui la presentacion que ya se usó como predetermiando de compr
                    sql = "SELECT        pr.idPresentacion, m.Nom_Medida, CAST('' AS varchar(30)) AS Empaque, pr.Cant_Present,pm.Medida as MedRefery "
                    sql = sql & "FROM   dbo.ProductoProveedor as pp   "
                    sql = sql & "inner JOIN  dbo.ProductoPresentacion AS pr on pp.idPresentacion = pr.idPresentacion "
                    sql = sql & "INNER JOIN  dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed "
                    sql = sql & "INNER JOIN  dbo.ProductoUndMedida AS pm ON pr.idProUndReferen = pm.idProUndMed "
                    sql = sql & "WHERE       (pr.idProducto = " & idProducto & ") AND  (pr.idPresentacion <> " & id_PresentCompra & ") "
                    Dim newcmd As New ClassCargadorProducto()
                    Dim newdt As New DataTable
                    newdt = newcmd.RetornaTabla(sql)
                    If Not IsNothing(newdt) Then
                        Dim NewDato = newdt.Rows(0).ItemArray
                        dt.Rows.Add(NewDato)
                    End If
                End If
                'aqui modifico los datos de la tabla
                Dim cat As Double = 0
                With Me.DataGridComprables
                    .DataSource = dt
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .Columns(0).Visible = False 'idPresent
                    .Columns(3).Visible = False  'Cantidad en present
                    .Columns(4).Visible = False  'nom Refery  [kl]
                    For i = 0 To .Rows.Count - 1
                        cat = .Rows(i).Cells("Cant_Present").Value
                        sql = Convert.ToString(cat)
                        .Rows(i).Cells("Empaque").Value = sql & " " & .Rows(i).Cells("MedRefery").Value
                    Next
                End With

                Return True
            End If

            Return False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdd_Producto en el sub Carga_Present")
            Return False
        End Try
    End Function


    Private Function Guarda_Prod_Vendedor(ByVal idPresent As Integer, ByVal idProveedor As Integer) As Boolean
        sql = "Insert INTO ProductoProveedor(idPresentacion, idProveedor) "
        sql = sql & "Values (" & idPresent & "," & idProveedor & ")"
        If Not id_Proveedor > 0 Then
            'esto es en caso de no tener proveedor
            With Me.myPadre
                .Id_Proveedor = idProveedor
            End With
        End If
        Try
            Dim cmd As New ClassCargadorProducto()
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error sistema")
            Return False
        End Try
    End Function



    Private Sub CargaQuie_Vende(ByVal id_Present As Integer)

        sql = "SELECT TOP (100) PERCENT ppr.idProProveedor,  ppr.idPresentacion, prov.idProveedor, prov.Razon_social, ppr.CostoTotal, ppr.Num_Doc, ppr.Fech_Compra "

        sql = sql & "FROM dbo.ProductoPresentacion AS pp INNER JOIN "
        sql = sql & "dbo.ProductoProveedor AS ppr ON pp.idPresentacion = ppr.idPresentacion INNER JOIN "
        sql = sql & "dbo.Proveedores AS prov ON ppr.idProveedor = prov.idProveedor "

        sql = sql & "WHERE (pp.idPresentacion  = '" & id_Present & "') "

        sql = sql & "ORDER BY ppr.Fech_Compra DESC "

        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            datalist_ProveeVende.DataSource = Nothing
            With Me.myPadre
                If dt.Rows.Count > 0 Then
                    With datalist_ProveeVende
                        .DataSource = dt
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                        .Columns(0).Visible = False  'idProductoProveedor
                        .Columns(1).Visible = False   'idPresentacion
                        .Columns(2).Visible = False   'idProveedor 
                    End With
                    If (Me.myPadre.lblProdcutodesc.Text.Contains("Agregando")) Then
                        .OkButton.Enabled = True
                    End If
                Else
                    .OkButton.Enabled = False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdd_Producto en sl sub CargaQuien_Vende")
        End Try
    End Sub


    Private Sub DataGridListPresent_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridComprables.RowEnter
        If Me.DataGridComprables.SelectedRows.Count = 1 Then
            Me.btnAddProveedor.Visible = True
            CargaQuie_Vende(DataGridComprables.SelectedCells.Item(0).Value)
        Else
        End If
    End Sub
    Private Sub btnAddProveedor_Click(sender As Object, e As EventArgs) Handles btnAddProveedor.Click
        Using Newform As New frmList_Proveedores(stateLoad.Dialogo, stateClient.Admin)
            With Newform
                .btnOk.Visible = True
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    If Guarda_Prod_Vendedor(DataGridComprables.SelectedCells.Item(0).Value, .dataListado.SelectedCells.Item(0).Value) Then
                        CargaQuie_Vende(DataGridComprables.SelectedCells.Item(0).Value)
                        With Me.myPadre
                            .OkButton.Enabled = True
                        End With
                    End If
                End If
            End With
        End Using
    End Sub
    Private Sub btnDeleteProveedor_Click(sender As Object, e As EventArgs) Handles btnDeleteProveedor.Click
        Try
            If datalist_ProveeVende.SelectedRows.Count = 1 Then
                If MsgBox("Está seguro como proveedor de este producto..?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes Then
                    If Elimina_ProductoProveedor(Me.datalist_ProveeVende.SelectedCells.Item(0).Value) Then
                        CargaQuie_Vende(DataGridComprables.SelectedCells.Item(0).Value)
                        If datalist_ProveeVende.RowCount > 0 Then
                            With Me.myPadre
                                .OkButton.Enabled = True
                            End With
                        End If
                    End If
                End If
            Else
                MsgBox("Seleccione uno del listado para poser eliminar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class