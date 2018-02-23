Imports System.Data.SqlClient

Public Class frmPermisos

    Dim MenuPrincipalName As String
    Dim SubMenuName As String

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ControlesNuevo()
    End Sub

    Private Sub ControlesNuevo()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancela.Enabled = True
        Me.txtNom_Grup.Enabled = True
        Me.txtEstado.Text = 1
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        ControlCancel()
    End Sub

    Private Sub ControlCancel()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancela.Enabled = False
        Me.txtNom_Grup.Enabled = False

        'txtnull
        Me.txtNom_Grup.Text = ""
        Me.AcceptButton = Nothing
    End Sub


    Private Sub dataGridGrup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridGrupo.CellContentClick
        ValidaSelecionGrup()
    End Sub

    Private Sub ValidaSelecionGrup()
        If Me.dataGridGrupo.SelectedRows.Count = 1 Then
            Me.txtIdGrupo.Text = Me.dataGridGrupo.SelectedCells.Item(0).Value
            Me.btnElimi.Enabled = True
            Me.btnModif.Enabled = True
        Else
            Me.txtIdGrupo.Text = 0
            Me.btnElimi.Enabled = False
            Me.btnModif.Enabled = False
        End If

        If txtIdGrupo.Text <> Me.txtIdUltimo.Text Then
            Carga_Menus(Me.txtIdGrupo.Text)
        End If

    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        If Me.dataGridGrupo.SelectedRows.Count = 1 Then
            If CopiaalTxt(Me.txtIdGrupo.Text) Then
                ControlesNuevo()
                Me.txtEstado.Text = 2
            End If
        End If
    End Sub

    Private Function CopiaalTxt(ByVal idPermiso As Integer) As Boolean

        Try
            Me.txtIdGrupo.Text = Me.dataGridGrupo.SelectedCells.Item(0).Value
            Me.txtNom_Grup.Text = Me.dataGridGrupo.SelectedCells.Item(1).Value
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "en el CopiaalTxt " & Me.Name)
            Return False
        End Try

    End Function


    Private Function Elimina_MenuObsoleto() As Boolean
        Try
            sql = "DElete  From Permisos where ValueMenu =0"
            Using cmd As New SqlCommand(sql, Cnn_sql)
                Return cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Elimina_Grupo() As Boolean
        sql = "DElete  From Grupo where idGrupo  =" & Me.txtIdGrupo.Text & " "
        Return ExecuteComand(sql)
    End Function


    Private Function Carga_Grupos()
        sql = "Select idGrupo, Nom_Grupo [Grupos] from Grupo "
        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                dataGridGrupo.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With dataGridGrupo
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells
                    End With
                    Return True
                Else
                    Return False
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "en el Carga_Permisos del " & Me.Name)
            Return False
        End Try
    End Function

    Private Sub frmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Carga_Grupos() Then
            ControlCancel()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.txtEstado.Text = 1 Then  ' nuevo informacion
            sql = "Insert into Grupo (Nom_Grupo ) "
            sql = sql + "Values ('" & Me.txtNom_Grup.Text & "')"

        ElseIf Me.txtEstado.Text = 2 Then  ' Modificando informcion
            sql = "Update Grupo set Nom_Grupo = '" & Me.txtNom_Grup.Text & "' "
            sql = sql + "Where idGrupo = " & Me.txtIdGrupo.Text & ""
        Else  'Ninguno de las dos
            Exit Sub
        End If


        If Guarda_ModificaPermisos() Then
            Carga_Grupos()
            ControlCancel()
        End If

    End Sub

    Private Function Carga_Menus(ByVal IdGrupo As Integer)

        sql = " SELECT P.idPermiso, p.Nom_Menu, p.Nom_SubMenu, "
        sql = sql + "CAST( IIF(ISNULL((SELECT GP.idGrupoPermiso  "
        sql = sql + "FROM dbo.GrupoPermiso AS GP WHERE  (idGrupo = G.idGrupo) AND (idPermiso = P.idPermiso)),0)=0,0,1) AS bit) AS Permiso "
        sql = sql + "FROM  dbo.Permisos AS P CROSS JOIN dbo.Grupo AS G  WHERE (G.idGrupo = " & Me.txtIdGrupo.Text & ") "
        sql = sql + "ORDER BY P.Orden"

        conecta_sql()

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                DataGridMenu.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With DataGridMenu
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells
                        Me.btnAplicar.Enabled = False
                    End With
                    Me.txtIdUltimo.Text = IdGrupo
                    Return True
                Else
                    Return False
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "en el Carga_Menus del " & Me.Name)
            Return False
        End Try


    End Function

    Private Function Guarda_ModificaPermisos() As Boolean
        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                If cmd.ExecuteNonQuery Then
                    MsgBox("Guardado Exitosamente", MsgBoxStyle.Information, "Aviso")
                    Return True
                Else
                    MsgBox("No se guardo informacion", MsgBoxStyle.Information, "Aviso")
                    Return False
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el Guarda_ModificaPermisos del " & Me.Name)
            Return False
        End Try

    End Function

    Private Sub dataGridPermiso_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridGrupo.RowEnter
        ValidaSelecionGrup()
    End Sub

    Private Sub dataGridPermiso_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dataGridGrupo.RowsRemoved
        ValidaSelecionGrup()
    End Sub

    Private Sub btnRestableceMenu_Click(sender As Object, e As EventArgs) Handles btnRestableceMenu.Click
        Dim Enumer_Menu As Integer = 0
        Dim Ordena As Integer = 0
        Me.Cursor = Cursors.WaitCursor


        'es para sqber a cuales solo modifico
        Establece_0Menu()

        On Error GoTo ControErr
        Using frmTmp As New MDIPareInicio
            For Each MenuPrincipal In frmTmp.MenuStrip1.Items
                If Not (MenuPrincipal.Name.Contains("ToolStripSeparator")) Then
                    Enumer_Menu = 0
                    MenuPrincipalName = MenuPrincipal.Name
                    For Each SubMenu In MenuPrincipal.DropDownItems
                        SubMenuName = SubMenu.Name
                        If Not (SubMenuName.Contains("ToolStripSeparator")) Then
                            Enumer_Menu = Enumer_Menu + 1
                            Ordena = Ordena + 1
                            Me.txtIdPermiso.Text = (BuscaSubMenu())
                            If Me.txtIdPermiso.Text = "0" Then
                                If Me.txtIdPermiso.Text = "80" Then
                                    sql = sql
                                End If
                                AgregaSubMenu(Ordena, MenuPrincipal.Text, SubMenu.Text)
                            Else
                                ModificaSubMenu(Ordena, MenuPrincipal.Text, SubMenu.Text)
                            End If
                        End If
                    Next

                    If Enumer_Menu = 0 Then
                        Ordena = Ordena + 1
                        Me.txtIdPermiso.Text = BuscaMenu()
                        If Me.txtIdPermiso.Text = "0" Then
                            AgregaMenu(Ordena, MenuPrincipal.Text)
                        Else
                            ModificaMenu(Ordena, MenuPrincipal.Text)
                        End If
                    End If
                End If
            Next
        End Using
        Elimina_MenuObsoleto()
        Carga_Menus(Me.txtIdGrupo.Text)
        Me.Cursor = Cursors.Default
        Return
ControErr:
        If ErrorToString.Contains("ToolStripSeparator") Then
            sql = ErrorToString()
            Resume Next
        Else
            MsgBox(ErrorToString, MsgBoxStyle.Critical, "Error")
        End If
    End Sub



    Public Function ModificaSubMenu(ByVal orden As Integer, ByVal MenuPrincipalText As String, ByVal SubMenuText As String) As Boolean

        sql = "UPDATE Permisos set Orden = " & orden & ", MenuStripName = '" & MenuPrincipalName & "', DropDownName =  '" & SubMenuName & "',Nom_Menu = '" & MenuPrincipalText & "', "
        sql = sql + "Nom_SubMenu = '" & SubMenuText & "' ,ValueMenu =1 "
        sql = sql + "Where idPermiso = " & Me.txtIdPermiso.Text & " and ValueMenu =0 "

        'executamos la instrucion anterior
        Return ExecuteComand(sql)


    End Function

    Public Function AgregaSubMenu(ByVal orden As Integer, ByVal MenuPrincipalText As String, ByVal SubMenuText As String) As Boolean

        sql = "INSERT INTO Permisos (Orden, MenuStripName,DropDownName ,Nom_Menu,Nom_SubMenu ,ValueMenu) "
        sql = sql + "Values(" & orden & ", '" & MenuPrincipalName & "', '" & SubMenuName & "','" & MenuPrincipalText & "','" & SubMenuText & "',1)"

        'executamos la instrucion anterior
        Return ExecuteComand(sql)
    End Function


    Public Function AgregaMenu(ByVal orden As Integer, ByVal MenuPrincipalText As String) As Boolean

        sql = "INSERT INTO Permisos (orden, MenuStripName,DropDownName ,Nom_Menu, ValueMenu) "
        sql = sql + "Values(" & orden & ", '" & MenuPrincipalName & "', '" & SubMenuName & "','" & MenuPrincipalText & "',1)"

        'executamos la instrucion anterior
        Return ExecuteComand(sql)
    End Function


    Public Function ModificaMenu(ByVal orden As Integer, ByVal MenuPrincipalText As String) As Boolean

        sql = "INSERT INTO Permisos (orden, MenuStripName, Nom_Menu, ValueMenu) "
        sql = sql + "Values(" & orden & ", '" & MenuPrincipalName & "','" & MenuPrincipalText & "',1)"

        'executamos la instrucion anterior
        Return ExecuteComand(sql)
    End Function


    Private Function BuscaSubMenu() As Integer
        sql = "Select idPermiso from permisos where DropDownName = '" & SubMenuName & "' and ValueMenu  = 0"
        Return BuscaExecute()
    End Function

    Private Function BuscaMenu() As Integer
        sql = "Select idPermiso from permisos where MenuStripName = '" & MenuPrincipalName & "' and ValueMenu =0"
        Return BuscaExecute()
    End Function





    Private Function BuscaExecute() As Integer

        conecta_sql()

        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Return dt(0)(0).ToString
                Else
                    Return 0
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "en el BuscaSubNemu del " & Me.Name)
            Return False
        End Try

    End Function

    Private Function Establece_0Menu() As Boolean
        sql = "Update Permisos set ValueMenu  = 0"
        Return ExecuteComand(sql)
    End Function

    Public Function EliminaMenu() As Boolean

        sql = "Delete GrupoPermiso from  GrupoPermiso where idGrupo = " & Me.txtIdGrupo.Text & " "
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el Guarda_ModificaPermisos del " & Me.Name)
            Return False
        End Try
    End Function


    Public Function ExecuteComand(ByVal StrinSql As String) As Boolean
        conecta_sql()
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    MsgBox("No se realizo la operación ", MsgBoxStyle.Information, "Aviso")
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el Guarda_ModificaPermisos del " & Me.Name)
            Return False
        End Try
    End Function

   
    Private Sub btnElimi_Click(sender As Object, e As EventArgs) Handles btnElimi.Click
        If MsgBox("Esta seguro de eliminar grupo ", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes Then
            If Elimina_Grupo() Then
                Carga_Grupos()
            End If
        End If

    End Sub

    Private Sub txtNom_Grup_TextChanged(sender As Object, e As EventArgs) Handles txtNom_Grup.TextChanged
        If Me.txtIdGrupo.TextLength > 0 Then
            Me.AcceptButton = Me.btnGuardar
        Else
            Me.AcceptButton = Nothing

        End If
    End Sub

    Private Sub DataGridMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMenu.CellContentClick
        If (e.ColumnIndex = Me.DataGridMenu.Columns.Item("Permiso").Index) And e.RowIndex >= 0 Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridMenu.Rows(e.RowIndex).Cells("Permiso")
            chkcell.Value = Not chkcell.Value
            btnAplicar.Enabled = True
        End If
    End Sub

    Private Function ActualizaMenuGrupo() As Boolean

        'Eliminamos Todo del grupo para luego cargar solo los guarados

        EliminaMenu()

        Try
            'cargamos los permisos
            For i = 0 To Me.DataGridMenu.RowCount - 1
                Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridMenu.Rows(i).Cells("Permiso")
                If chkcell.Value Then
                    sql = "INSERT INTO GrupoPermiso (idGrupo, idPermiso) "
                    sql = sql + "Values (" & Me.txtIdGrupo.Text & ", " & Me.DataGridMenu.Rows(i).Cells(0).Value & ")"
                    ExecuteComand(sql)
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el ActualizaMenuGrupo del " & Me.Name)
            Return False
        End Try

    End Function



    Private Sub MarcaDesmarcaTodo(ByVal Respond As Boolean)
        For i = 0 To Me.DataGridMenu.RowCount - 1
            Dim chkcell As DataGridViewCheckBoxCell = Me.DataGridMenu.Rows(i).Cells("Permiso")
            chkcell.Value = Respond
            Me.btnAplicar.Enabled = True
        Next

    End Sub
    Private Sub DataGridMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMenu.CellClick
        ValidaSelecionMenu()
    End Sub
    Private Sub ValidaSelecionMenu()
        If DataGridMenu.SelectedRows.Count = 1 Then
            Me.txtIdPermiso.Text = Me.DataGridMenu.SelectedCells.Item(0).Value
        Else
            Me.txtIdPermiso.Text = 0
        End If

        If DataGridMenu.RowCount > 0 Then
            Me.btnPermitir.Enabled = True
            Me.btnDenegar.Enabled = True
        Else
            Me.btnPermitir.Enabled = False
            Me.btnDenegar.Enabled = False
        End If
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        ActualizaMenuGrupo()
        btnAplicar.Enabled = False
    End Sub

    Private Sub btnPermitir_Click(sender As Object, e As EventArgs) Handles btnPermitir.Click
        MarcaDesmarcaTodo(True)
    End Sub

    Private Sub btnDenegar_Click(sender As Object, e As EventArgs) Handles btnDenegar.Click
        MarcaDesmarcaTodo(False)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub AccepButton_Click(sender As Object, e As EventArgs) Handles AccepButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
