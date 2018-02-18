Imports System.Data.SqlClient


Public Class frmAdd_Proveedor
    Dim frmStateCancel As Boolean
    Protected Friend flag As String
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAdd_Proveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If IsNothing(flag) Then
            MsgBox("Falta el parametro del la variable flag")
            Close()
        End If
        llenarTipo_Proveedor()
        Me.dtFechaReg.Value = Now()
        If flag = "Modificar" Then
            Me.btnAcepter.Text = "Modificar"
            Carga_Amodificar(Me.txtidProveedor.Text)
        ElseIf flag = "Ver" Then
            Me.btnAcepter.Visible = False
            Carga_Amodificar(Me.txtidProveedor.Text)
        Else
            Me.btnAcepter.Text = "Guardar"
        End If
    End Sub

    Private Sub Carga_Amodificar(idProveedor As Integer)

        sql = "SELECT        dbo.Proveedores.* "
        sql = sql & "FROM dbo.Proveedores "
        sql = sql & "WHERE(idProveedor = " & idProveedor & ") "


        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql)
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Me.cmbTipoEmp.SelectedValue = dt(0)("idTypoProvee").ToString
                Me.txtRuc.Text = dt(0)("Ruc_Ci").ToString
                Me.txtRazon.Text = dt(0)("Razon_social").ToString
                Me.cmbTiopo_razon.SelectedValue = dt(0)("Razon_tipo").ToString
                Me.txtRepresentante.Text = dt(0)("Represent").ToString
                Me.txtDireccion.Text = dt(0)("Direccion").ToString
                Me.txtTelefono.Text = dt(0)("Telefono").ToString
                Me.txtUser.Text = dt(0)("codUser").ToString
                Me.chekboxIva.Checked = dt(0)("ivaSubtotal").ToString
            Else
                MsgBox("No se pudo cargar información", MsgBoxStyle.Information, "Aviso")
                Me.btnAcepter.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Carga_Amodificar")
        Finally
            desconecta_sql()
        End Try

    End Sub

    Private Sub llenarTipo_Proveedor()

        Dim func As New fProveedor
        Dim dt = func.Tipo_Proveedor

        If IsNothing(dt) Then Exit Sub

        If dt.Rows.Count > 0 Then
            With cmbTipoEmp
                .DataSource = dt
                .DisplayMember = "Nom_tipoProveedor"
                .ValueMember = "idTypoProvee"
            End With
        End If

    End Sub

    Private Function Execute_Dato() As Boolean
        Try
            Me.AcceptButton = Nothing
            If Not (Valida_Datos()) Then
                Return False
            End If
            Dim Id_Tipo As Integer = Me.cmbTipoEmp.Items(Me.cmbTipoEmp.SelectedIndex)(0).ToString
            Dim Tipo_Razon As String = Me.cmbTiopo_razon.Items(Me.cmbTipoEmp.SelectedIndex)(0).ToString

            Dim ivaSubtotal As Integer = 0
            If Me.chekboxIva.Checked Then
                ivaSubtotal = 1
            End If
            If flag = "Agregar" Then

                If Buscar_Ruc(Me.txtRuc.Text) Then
                    frmStateCancel = True
                    MsgBox("Ya existe el ruc: " & Me.txtRuc.Text, MsgBoxStyle.Information, "Aviso")
                    Return False
                End If
                sql = "Insert into Proveedores (idTypoProvee, Ruc_Ci, Razon_social, Razon_tipo, Represent, Direccion, Telefono, codUser, ivaSubtotal)"
                sql = sql & "Values (" & Id_Tipo & ", '" & txtRuc.Text & "','" & txtRazon.Text & "', '" & Tipo_Razon & "','" & txtRepresentante.Text & "',"
                sql = sql & "'" & txtDireccion.Text & "','" & txtTelefono.Text & "', '" & UsuarioActivo.codUser & "', " & ivaSubtotal & ")"
                'Busco si ya existe este ruc
            ElseIf flag = "Modificar" Then
                sql = "UPDATE Proveedores SET idTypoProvee=" & Id_Tipo & ", Ruc_Ci ='" & txtRuc.Text & "',Razon_social='" & txtRazon.Text & "',Razon_tipo= '" & Tipo_Razon & "',"
                sql = sql & "Represent='" & txtRepresentante.Text & "',Direccion ='" & Me.txtDireccion.Text & "',Telefono ='" & Me.txtTelefono.Text & "', codUser ='" & UsuarioActivo.codUser & "', ivaSubtotal=" & ivaSubtotal & " "
                sql = sql & "WHERE (((Proveedores.idProveedor)=" & Me.txtidProveedor.Text & "));"
            Else
                MsgBox("No se pudo validar el estado de boton [Modificar] y/o [Guardar]", MsgBoxStyle.Critical, "Error ")
                Return False
            End If
            conecta_sql()
            Try
                Dim cmd As New SqlCommand(sql)
                cmd.CommandType = CommandType.Text
                cmd.Connection = Cnn_sql
                If cmd.ExecuteNonQuery Then
                    If flag = "Agregar" Then
                        MsgBox("Agregado Exitosamente", MsgBoxStyle.Information, "Guardando proveedor")
                    ElseIf flag = "Modificar" Then
                        MsgBox("Modificado Exitosamente", MsgBoxStyle.Information, "Información")
                    End If
                    Return True
                Else
                    MsgBox("No se pudo ejecutar", MsgBoxStyle.Information, "Guardando proveedor")
                    frmStateCancel = True
                    Return False
                End If
            Catch ex As Exception
                frmStateCancel = True
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el btnAcepter_Click")
                Return False
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            desconecta_sql()
        End Try
    End Function

    Private Function Valida_Datos() As Boolean
        Try
            If Not (Me.cmbTipoEmp.SelectedIndex >= 0) Then
                ErrorIcono.SetError(cmbTipoEmp, "Seleccione uno del listado")
                Return False
            End If

            If Not (Me.txtRuc.Text.Length > 0) Then
                ErrorIcono.SetError(txtRuc, "Ingrese el Ruc")
                Return False
            End If
            If Not (Me.txtRazon.Text.Length > 0) Then
                ErrorIcono.SetError(txtRazon, "Ingrese razon social")
                Return False
            End If

            If Not (Me.txtRepresentante.Text.Length > 0) Then
                ErrorIcono.SetError(txtRepresentante, "Ingrese representante ")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub limpiar()
        Me.cmbTipoEmp.Text = "Selecione..."
        Me.cmbTipoEmp.SelectedIndex = -1
        Me.txtRazon.Text = ""
        Me.txtRuc.Text = ""
        Me.txtRepresentante.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtUser.Text = ""
    End Sub

    Private Sub txtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefono.TextChanged
        DefaultBtn(Me.btnAcepter)
    End Sub
    Private Sub DefaultBtn(ByVal btn As Button)
        Me.AcceptButton = btn
    End Sub

    Private Sub txtRuc_Leave(sender As Object, e As EventArgs) Handles txtRuc.Leave
        txtRuc.Text = LTrim(txtRuc.Text)
        If Len(Me.txtRuc.Text) <> 13 Then
            MsgBox("El Ruc deberia ser de 13 difitos", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub txtRuc_TextChanged(sender As Object, e As EventArgs) Handles txtRuc.TextChanged
        Me.CancelButton = Nothing
    End Sub

    Private Function Buscar_Ruc(ByVal strRuc As String) As Boolean
        sql = "SElect Top(1) idProveedor from Proveedores where Ruc_Ci ='" & strRuc & "'"
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "en el Buscar_Ruc del fproveedor")
            Return False
        End Try
    End Function
    Private Sub btnAcepter_Click(sender As Object, e As EventArgs) Handles btnAcepter.Click
        If Execute_Dato() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class