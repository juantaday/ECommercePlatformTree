Imports System.Data.SqlClient
Imports CADsisVenta.DataSetUsersTableAdapters

Public Class frmUsuarios
    Dim Buscardo As String
    Private login As String
    Private nameUser As String
    Private idPersonas As Integer
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaTodoUser()
    End Sub

    Private Sub CargaTodoUser()
        sql = "Select  Top(1000)  u.Login, p.Apellidos + '  ' + p.Nombre AS Usuario, "
        sql = sql & "Ruc_Ci, Apellidos, Nombre, p.idpersona,u.Estado,u.Iniciado "
        sql = sql + "From dbo.Usuarios AS u INNER Join "
        sql = sql + "dbo.Personas AS p ON u.IdPersona = p.idPersona"
        CargaUsuarios()
    End Sub
    Private Sub btnDeletUser_Click(sender As Object, e As EventArgs) Handles btnDeletUser.Click
        If Me.dataGridUser.SelectedRows.Count = 1 Then
            If MsgBox("Está seguro de Eliminar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = DialogResult.Yes Then
                If ELimina_Usuario(Me.dataGridUser.SelectedCells.Item(0).Value) Then
                    CargaTodoUser()
                End If
            End If
        Else
            MsgBox("Seleccione uno del listado", MsgBoxStyle.Critical, "Aviso")
        End If
    End Sub
    Private Function ELimina_Usuario(ByVal LoginUser As String) As Boolean

        If UsuarioActivo.codUser = LoginUser Then
            MsgBox("No se puede Eliminar Usted mismo", MsgBoxStyle.Exclamation, "Alerta")
            Return False
        End If

        sql = "Delete Usuarios from Usuarios where Login = '" & LoginUser & "'"

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en ELimina_Usuario en el frmUsuario ")
            Return False
        End Try
    End Function



    Private Sub CargaUsuarios()

        'sql viene de cada comando de acuerdo alo que quiere filtra
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                Me.dataGridUser.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With dataGridUser
                        .DataSource = dt
                        .AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells
                        .Columns(2).Visible = False
                        .Columns(3).Visible = False
                        .Columns(4).Visible = False
                        .Columns(5).Visible = False
                        .Columns(6).Visible = False
                        .Columns(7).Visible = False
                        Me.lblTotal.Text = "Total de registro: " & dt.Rows.Count
                        lblnoExiste.Visible = False
                    End With
                End If

            End Using
        Catch ex As Exception
            Me.dataGridUser.DataSource = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en CargaTodoUsuarios del " & Me.Name)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscardo = Trim(Me.txtBuscar.Text)
        sql = "Select  Top(100)  u.Login, p.Apellidos + '  ' + p.Nombre AS Usuario, "
        sql = sql & "Ruc_Ci, Apellidos, Nombre, p.idpersona,u.Estado,u.Iniciado "
        sql = sql + "From dbo.Usuarios AS u INNER Join "
        sql = sql + "dbo.Personas AS p ON u.IdPersona = p.idPersona "
        sql = sql & "WHERE ((Login Like '%" & Buscardo & "%') or (Apellidos Like '%" & Buscardo & "%') or (Nombre Like '%" & Buscardo & "%'))"
        CargaUsuarios()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If Me.txtBuscar.TextLength > 0 Then
            Me.AcceptButton = Me.btnBuscar
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub btnAgreUser_Click(sender As Object, e As EventArgs) Handles btnAgreUser.Click
        Using Form As New frmAdd_Usuarios(stateOperation.Insert, 0, 0)
            With Form
                .StartPosition = FormStartPosition.CenterScreen
                .Text = "Agragando Nuevo Usuario"
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    Me.Notificacion.ShowBalloonTip(2000, "Aviso", "Usuario agregado Correctamente", ToolTipIcon.Info)
                    CargaTodoUser()
                End If
            End With
        End Using
    End Sub


    Private Sub btnOptAvanzado_Click(sender As Object, e As EventArgs) Handles btnOptAvanzado.Click
        Try
            Using frmPermi As New frmPermisos() With {.StartPosition = FormStartPosition.CenterScreen}
                frmPermi.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnModifUser_Click(sender As Object, e As EventArgs) Handles btnModifUser.Click
        If Me.dataGridUser.SelectedRows.Count = 1 Then
            Using form As New frmAdd_Usuarios(stateOperation.Update, login:=login, idPersonas:=idPersonas)
                With form
                    .Text = "Modificando Usuario"
                    .txtApellidos.Text = Me.dataGridUser.SelectedCells.Item(3).Value
                    .txtNombre.Text = Me.dataGridUser.SelectedCells.Item(4).Value
                    .txtRuc_Ci.Text = Me.dataGridUser.SelectedCells.Item(2).Value
                    .txtLogin.Text = Me.dataGridUser.SelectedCells.Item(0).Value
                    .estadoCheckBox.Checked = Me.dataGridUser.SelectedCells.Item(dataGridUser.Columns("Estado").Index).Value
                    .iniciadoCheckBox.Checked = Me.dataGridUser.SelectedCells.Item(dataGridUser.Columns("Iniciado").Index).Value
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.Notificacion.Visible = True
                        Me.Notificacion.ShowBalloonTip(5000, "Aviso", "Usuario modificado correctamente", ToolTipIcon.Info)
                        CargaTodoUser()
                    End If
                End With
            End Using

        End If
    End Sub

    Private Function Carga_Grupo(ByVal Login As String) As Boolean

        sql = "SELECT idGrupo, G.Nom_Grupo, "
        sql = sql + "CAST( IIF(ISNULL((SELECT Id_UserGrup  "
        sql = sql + "FROM dbo.UsuarioGrupo AS UG "
        sql = sql + "WHERE  (login = U.Login) AND (idGrupo = G.idGrupo)),0)=0,0,1) AS bit) AS Pertenece "

        sql = sql + "FROM            dbo.Grupo AS G CROSS JOIN dbo.Usuarios AS U "

        sql = sql + " WHERE        (U.Login = '" & Login & "')"

        conecta_sql()

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                Me.dataGridGrupo.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With dataGridGrupo
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.AllCells
                        btnAplicar.Enabled = False
                        Me.txtUltimoLogin.Text = Login
                    End With
                End If
            End Using
            Return True

        Catch ex As Exception
            Me.dataGridUser.DataSource = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en Carga_Grupo del " & Me.Name)
            Return False
        End Try
    End Function


    Private Sub dataGridGrupo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridGrupo.CellContentClick

        If e.ColumnIndex = Me.dataGridGrupo.Columns.Item("Pertenece").Index And e.RowIndex >= 0 Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dataGridGrupo.Rows(e.RowIndex).Cells("Pertenece")
            chkcell.Value = Not chkcell.Value
            btnAplicar.Enabled = True
        End If


    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        ActualizaGrupo()
        btnAplicar.Enabled = False
    End Sub

    Private Function ActualizaGrupo() As Boolean

        'Eliminamos Todo del grupo para luego cargar solo los guarados

        EliminaGrupo()

        Try
            'cargamos los permisos
            For i = 0 To Me.dataGridGrupo.RowCount - 1
                Dim chkcell As DataGridViewCheckBoxCell = Me.dataGridGrupo.Rows(i).Cells("Pertenece")
                If chkcell.Value Then
                    sql = "INSERT INTO UsuarioGrupo (login, idGrupo) "
                    sql = sql + "Values ('" & Me.txtlogin.Text & "', " & Me.dataGridGrupo.Rows(i).Cells(0).Value & ")"
                    ExecuteComand(sql)
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el ActualizaGrupo del " & Me.Name)
            Return False
        End Try

    End Function

    Public Function EliminaGrupo() As Boolean

        sql = "Delete UsuarioGrupo from  UsuarioGrupo where Login = '" & Me.txtlogin.Text & "' "
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el EliminaGrupo del " & Me.Name)
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el ExecuteComand del " & Me.Name)
            Return False
        End Try
    End Function


    Private Sub dataGridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUser.CellClick
        ValdaSeleci_User()
    End Sub

    Private Sub ValdaSeleci_User()
        login = String.Empty
        nameUser = String.Empty
        If Me.dataGridUser.SelectedRows.Count = 1 Then
            Me.txtlogin.Text = Me.dataGridUser.SelectedCells.Item(0).Value
            login = Me.dataGridUser.SelectedCells.Item(0).Value
            nameUser = Me.dataGridUser.SelectedCells.Item(1).Value
            idPersonas = Me.dataGridUser.SelectedCells.Item(dataGridUser.Columns("IdPersona").Index).Value
            If Me.txtUltimoLogin.Text <> Me.txtlogin.Text Then
                Carga_Grupo(Me.txtlogin.Text)
            End If
        Else
            Me.txtlogin.Text = "0"
        End If

    End Sub

    Private Sub dataGridUser_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUser.RowEnter
        ValdaSeleci_User()
    End Sub

    Private Sub dataGridUser_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dataGridUser.RowsRemoved
        ValdaSeleci_User()
    End Sub


    Private Sub dataGridUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUser.CellContentClick
        ValdaSeleci_User()
    End Sub

    Private Sub acncelButton_Click(sender As Object, e As EventArgs) Handles acncelButton.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
    Private Sub clearPasswordButton_Click(sender As Object, e As EventArgs) Handles clearPasswordButton.Click
        If Not String.IsNullOrEmpty(Me.login) Then
            sql = "Esta opción ará que la contraseña del usuario: " & vbNewLine & nameUser
            sql = sql & vbNewLine & "sea la misma que el Login"
            If MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Importante") = MsgBoxResult.Yes Then
                If ChangePassword() Then
                    MsgBox("Se reinició la contraseña correctamente", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        End If
    End Sub
    Private Function ChangePassword() As Boolean
        Try
            Using cmd As New UsuariosTableAdapter
                If cmd.UpdatePassword(SHA1(login), login) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub oKButton_Click(sender As Object, e As EventArgs) Handles oKButton.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub especialPerminButton_Click(sender As Object, e As EventArgs) Handles especialPerminButton.Click
        Using specialUserPer As New frmPermososSpecial(Me.login)
            specialUserPer.StartPosition = FormStartPosition.CenterParent
            specialUserPer.ShowDialog()
        End Using
    End Sub
End Class