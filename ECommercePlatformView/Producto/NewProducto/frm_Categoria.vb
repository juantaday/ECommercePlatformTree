Imports System.Data.SqlClient
Public Class frm_Categoria
    Private myPadre As MDI_AddProductos
    Protected Friend SelectedNode As TreeNode
    Dim Nodes As String()
    Dim categoria As String
    Protected Friend id_producto As Integer
    Protected Friend id_subCategory As Integer
    Protected Friend isSubCategory As Boolean
    Private estado As Boolean

    Sub New(myPadre As MDI_AddProductos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.myPadre = myPadre
    End Sub
    Private Sub frm_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(id_producto) Then
            id_producto = 0
        End If
        If Not IsNothing(Me.myPadre) Then
            With Me.myPadre
                estado = .Estado
                SiguientButton.Visible = .Estado
                SaveButton.Enabled = Not estado
            End With
            PanelComannSelect.Visible = False
            PanelDesciption.Visible = True
            PanelMenuAdd.Visible = True
            PanelExpantTreeView.Visible = False
        Else
            Me.MenuStripCatego.Visible = False
            Me.lblCategoria.Visible = False
            Me.lblnodes.Visible = False
            PanelComannSelect.Visible = True
            PanelDesciption.Visible = False
            PanelMenuAdd.Visible = False
            PanelExpantTreeView.Visible = True
        End If
        CargaControlCategoria()
        SelectedNode = Nothing
    End Sub
    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        AvilitaDialogo()
        categoria = "Categoria"
    End Sub
    Private Sub AvilitaDialogo()
        Me.TreeViewCatgoria.Enabled = False
        Me.txtNameCategoria.Visible = True
        btnCancelCategory.Visible = True
        btnAcepCategoria.Visible = True
        MenuStripCatego.Enabled = False
        txtNameCategoria.Text = ""
        Me.txtNameCategoria.Focus()
    End Sub
    Private Function Cargar_Categorias()

        sql = "Select idCategoria, Nom_Categoria from ProductoCategoria order by Nom_Categoria "
        Try
            TreeViewCatgoria.Nodes.Clear()
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)

                    Using dar As SqlDataReader = cmd.ExecuteReader()
                        While dar.Read()
                            Dim trynode As New TreeNode
                            trynode.Tag = dar(0).ToString
                            trynode.Text = dar(1).ToString
                            trynode.BackColor = Color.AliceBlue

                            TreeViewCatgoria.Nodes.Add(trynode)
                        End While
                    End Using
                End Using
            End Using
            Return TreeViewCatgoria.Nodes.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
            Return False
        End Try
    End Function

    Private Sub Cargar_SubCategorias()
        Try
            sql = "Select  sc.idSubCategoria, sc.Nom_SubCategoria 
                                 From dbo.ProductoCategoria AS ct INNER Join 
                                dbo.ProductoSubCategoria As sc On ct.idCategoria = sc.idCategoria 
                                Where (ct.idCategoria =@idCategoria)
                                ORDER BY sc.Nom_SubCategoria"
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@idCategoria", SqlDbType.Int)
                    For r = 0 To Me.TreeViewCatgoria.Nodes.Count - 1
                        SelectedNode = Me.TreeViewCatgoria.Nodes.Item(r)
                        cmd.Parameters("@idCategoria").Value = Integer.Parse(SelectedNode.Tag)
                        Using dar As SqlDataReader = cmd.ExecuteReader()
                            While dar.Read()
                                Dim tvRoot As TreeNode
                                Dim tvNode As New TreeNode

                                tvNode.Tag = (dar(0).ToString)
                                tvNode.Text = (dar(1).ToString)
                                tvNode.BackColor = Color.AntiqueWhite

                                tvRoot = Me.TreeViewCatgoria.Nodes.Item(r)
                                tvRoot.Nodes.Add(tvNode)
                                tvNode.Checked = True
                            End While
                        End Using
                    Next
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + "en el del Cargar_SubCategorias " + Me.Name, MsgBoxStyle.Critical, "Aviso")
        End Try

    End Sub
    Private Sub btnAcepCategoria_Click(sender As Object, e As EventArgs) Handles btnAcepCategoria.Click
        If txtNameCategoria.TextLength > 0 Then
            If Agregar_Categoria(categoria) Then
                Cargar_Categorias()
                Cargar_SubCategorias()
                SeleccionaCategoria(txtNameCategoria.Text)
                btnCancelCategory.PerformClick()
            End If
        Else
            MsgBox("Ingrese los datos", MsgBoxStyle.Information, "Aviso")
            txtNameCategoria.Focus()
        End If
    End Sub

    Private Function Agregar_Categoria(ByVal Tipo As String) As Boolean
        conecta_sql()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.Connection = Cnn_sql
        Try
            Select Case Tipo
                Case "Categoria"
                    sql = "Insert into ProductoCategoria (Nom_Categoria) "
                    sql = sql & "Values ('" & Me.txtNameCategoria.Text & "') "
                    sql = sql & "SET @identity = SCOPE_IDENTITY() "

                    cmd.CommandText = sql
                    cmd.Parameters.Add(New SqlParameter("@identity", SqlDbType.Int))
                    cmd.Parameters("@identity").Direction = ParameterDirection.Output
                    If cmd.ExecuteNonQuery Then
                        id_subCategory = (cmd.Parameters("@identity").Value)
                        Return True
                    End If
                Case "SubCategoria"

                    sql = "Insert into ProductoSubCategoria (idCategoria, Nom_SubCategoria) "
                    sql = sql & "Values ((Select idCategoria from ProductoCategoria where Nom_Categoria = '" & Nodes(0).ToString() & "'),'" & Me.txtNameCategoria.Text & "') "
                    sql = sql & "SET @identity = SCOPE_IDENTITY() "

                    cmd.CommandText = sql
                    cmd.Parameters.Add(New SqlParameter("@identity", SqlDbType.Int))
                    cmd.Parameters("@identity").Direction = ParameterDirection.Output
                    If cmd.ExecuteNonQuery Then
                        id_subCategory = (cmd.Parameters("@identity").Value)
                        Return True
                    End If
                Case "Modifica"
                    Select Case Nodes.Length
                        Case 1
                            sql = "Update ProductoCategoria set Nom_Categoria = '" & Me.txtNameCategoria.Text & "' where  Nom_Categoria = '" & Nodes(0).ToString & "' "
                            cmd.CommandText = sql

                            If cmd.ExecuteNonQuery Then
                                Return True
                            End If
                        Case 2
                            sql = "Update ProductoSubCategoria set "
                            sql = sql & "Nom_SubCategoria = '" & Me.txtNameCategoria.Text & "' "
                            sql = sql & "where  ((Nom_SubCategoria = '" & Nodes(1).ToString & "') and "
                            sql = sql & " (idCategoria = (Select idCategoria from ProductoCategoria where Nom_Categoria = '" & Nodes(0).ToString & "'))) "

                            cmd.CommandText = sql
                            If cmd.ExecuteNonQuery Then
                                Return True
                            End If
                    End Select
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Sub TreeViewCatgoria_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewCatgoria.AfterSelect

        Try
            If Not IsNothing(Me.myPadre) Then
                With Me.myPadre
                    Nodes = Split(TreeViewCatgoria.SelectedNode.FullPath, "\")
                    If Not IsNothing(Nodes) Then
                        If Nodes.Length > 1 Then
                            Dim idSelected As Integer = idSelectdCategory(Nodes(0).ToString, Nodes(1).ToString)
                            id_subCategory = Busca_IdSubCategory(id_producto)
                            lblnodes.Location = lblCategoria.Location
                            lblnodes.Text = "Designar a: " + TreeViewCatgoria.SelectedNode.FullPath
                            .SiguienteButton.Enabled = True
                            If Not estado And id_subCategory <> idSelected Then
                                .SiguienteButton.Visible = True
                                .SiguienteButton.Enabled = True
                                .SiguienteButton.Text = "Guardar"
                            ElseIf Not estado And id_subCategory = idSelected Then
                                .SiguienteButton.Visible = False
                            End If
                        Else
                            .SiguienteButton.Enabled = False
                            lblnodes.Text = ""
                            If Not estado Then
                                .SiguienteButton.Visible = False
                            End If
                        End If
                    End If
                End With
            Else
                lblNodes2.Text = TreeViewCatgoria.SelectedNode.FullPath
                lblNodes2.Visible = True
                SelectedNode = TreeViewCatgoria.SelectedNode
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function idSelectdCategory(nameCate As String, nameSubCate As String) As Integer
        Try
            sql = "Select  s.idSubCategoria from ProductoCategoria  As c "
            sql = sql & "inner Join ProductoSubCategoria as s on  c.idCategoria  = s.idCategoria "
            sql = sql & "where c.Nom_Categoria ='" & nameCate & "' and s.Nom_SubCategoria ='" & nameSubCate & "' "
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

    Private Sub btnCancelCategory_Click(sender As Object, e As EventArgs) Handles btnCancelCategory.Click
        Me.TreeViewCatgoria.Enabled = True
        Me.txtNameCategoria.Visible = False
        btnCancelCategory.Visible = False
        btnAcepCategoria.Visible = False
        categoria = "SubCategoria"
        MenuStripCatego.Enabled = True
        Me.lblCategoria.Visible = False
        Me.CancelButton = Nothing
        SiguientButton.Enabled = True
    End Sub
    Private Sub txtNameCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtNameCategoria.TextChanged
        If Me.txtNameCategoria.TextLength > 0 Then
            Me.AcceptButton = btnAcepCategoria
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If Not IsNothing(Nodes) Then
            If Nodes.Length > 0 Then
                AvilitaDialogo()
                categoria = "Modifica"
                lblCategoria.Visible = True
                SiguientButton.Enabled = False
                lblCategoria.Text = "Modificando: " + Me.TreeViewCatgoria.SelectedNode.FullPath
                txtNameCategoria.Text = Nodes(Nodes.Length - 1).ToString
            End If
        End If
    End Sub
    Private Sub CargaControlCategoria()
        'cargamos todas las categorias posibles
        If Cargar_Categorias() Then
            Cargar_SubCategorias()

        End If
        If id_producto > 0 Then
            Dim Nom_Category As String = Default_CategoryName(Busca_IdSubCategory(id_producto))
            SeleccionaCategoria(Nom_Category)
        End If
    End Sub
    Private Function Default_CategoryName(ByVal idCategory As Integer) As String
        Try
            sql = "Select c.Nom_SubCategoria from ProductoSubCategoria as c where c.idSubCategoria = " & idCategory & "	"
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Nom_SubCategoria")
                End If
            End If
            Return ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return ""
        End Try
    End Function

    Private Sub SeleccionaCategoria(ByVal nameCategory As String)
        Try
            For i = 0 To Me.TreeViewCatgoria.Nodes.Count - 1
                Dim Nodeshi As TreeNode = TreeViewCatgoria.Nodes(i)
                For r = 0 To Nodeshi.Nodes.Count - 1
                    If Nodeshi.Nodes(r).Text = nameCategory Then
                        TreeViewCatgoria.Nodes(i).Expand()
                        TreeViewCatgoria.SelectedNode = Nodeshi.Nodes.Item(r)
                        Return
                    End If
                Next
            Next

            For i = 0 To Me.TreeViewCatgoria.Nodes.Count - 1
                Dim Nodeshi As TreeNode = TreeViewCatgoria.Nodes(i)
                If TreeViewCatgoria.Nodes(i).Text = nameCategory Then
                    TreeViewCatgoria.SelectedNode = Nodeshi
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message + " al tratar  de selecionar el node ", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub SubCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoríaToolStripMenuItem.Click
        If Not IsNothing(Nodes) Then
            If Nodes.Length > 0 Then
                AvilitaDialogo()
                categoria = "SubCategoria"
                lblCategoria.Text = "[" + Nodes(0).ToString + "] Sub categoría"
                Exit Sub
            End If
        Else
            'si no salio antes dice lo siguiente
            MsgBox("Seleccione dentro de que categoría va agregar", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If Elimina_Categoria() Then
            Cargar_Categorias()
            Cargar_SubCategorias()
            btnCancelCategory.PerformClick()
        End If
    End Sub
    Private Function Elimina_Categoria() As Boolean

        Dim cmd As New ClassCargadorProducto
        Try
            If Not IsNothing(Nodes) Then
                If Nodes.Length > 0 Then
                    If MsgBox("Esta seguro de eliminar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                        Select Case Nodes.Length
                            Case 1
                                sql = "Delete ProductoCategoria where Nom_Categoria = '" & Nodes(0).ToString & "'"
                                Return cmd.ExecuteComand(sql)
                            Case 2
                                sql = "Delete ProductoSubCategoria where Nom_SubCategoria = '" & Nodes(1).ToString & "' and  "
                                sql = sql & "idCategoria = (Select idCategoria from ProductoCategoria where Nom_Categoria = '" & Nodes(0).ToString & "') "
                                Return cmd.ExecuteComand(sql)
                        End Select
                    End If
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Sub btnSiguientCategor_Click(sender As Object, e As EventArgs) Handles SiguientButton.Click
        Try
            If Not IsNothing(Nodes) Then
                If Nodes.Length > 1 Then
                    If Modifica_Categor_delProdcuto() Then
                        With Me.myPadre
                            .menuPresentacion.Enabled = True
                        End With
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Function Modifica_Categor_delProdcuto() As Boolean
        Dim cmd As New ClassCargadorProducto

        Try
            sql = "Update Productos set IdSubCategoria =(SELECT sc.idSubCategoria "
            sql = sql & "FROM ProductoCategoria AS ct INNER JOIN "
            sql = sql & "ProductoSubCategoria AS sc ON ct.idCategoria = sc.idCategoria "
            sql = sql & "WHERE (ct.Nom_Categoria = '" & Nodes(0).ToString & "') AND (sc.Nom_SubCategoria = '" & Nodes(1).ToString & "')) "
            sql = sql & "where idProducto = " & id_producto & " " ' " & Me.txtIdProducto.Text & "
            Return cmd.ExecuteComand(sql)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If Not IsNothing(Nodes) Then
            If Nodes.Length > 1 Then
                If MsgBox(msgSave, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, msgRespond) = MsgBoxResult.Yes Then
                    If Modifica_Categor_delProdcuto() Then
                        With Me.myPadre
                            .SiguienteButton.Visible = False
                            .OkButton.Enabled = True
                        End With
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TreeViewCatgoria_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TreeViewCatgoria.MouseDoubleClick
        Try
            okButton.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        SelectedNode = Nothing
        isSubCategory = Nothing
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        If Not IsNothing(SelectedNode) Then
            isSubCategory = False
            If SelectedNode.BackColor = Color.AntiqueWhite Then
                isSubCategory = True
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub ExpantButton_Click(sender As Object, e As EventArgs) Handles ExpantButton.Click
        Try
            Dim expant As Boolean = ExpantButton.Tag
            If ExpantButton.Tag = 0 Then
                ExpantButton.Tag = 1
                ExpantButton.Image = My.Resources.Contraint_Treeview_24
                For Each nodes As TreeNode In TreeViewCatgoria.Nodes
                    nodes.Expand()
                Next
            Else
                ExpantButton.Tag = 0
                ExpantButton.Image = My.Resources.Expant_Treeview_24
                For Each nodes As TreeNode In TreeViewCatgoria.Nodes
                    nodes.Collapse()
                Next
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class