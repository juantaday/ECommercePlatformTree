Imports System.Data.SqlClient

Public Class frm_Presentacion
    Private idPresentacion As Integer
    Protected Friend Agregar As Boolean
    Private estado As Boolean
    Private idRowSelect, idColumnSelect As Integer
    Private myPadre As MDI_AddProductos
    Private isLoad As Boolean
    Private idMedidas As Integer

    Sub New(myPadre As MDI_AddProductos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialimyzación después de la llamada a InitializeComponent().
        Me.myPadre = myPadre
    End Sub
    Private Sub frm_Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me.myPadre
            estado = .Estado
        End With
        'cargamos datos
        Carga_ListPresent(myPadre.Id_Producto)
    End Sub

    Private Sub btnEdit_Present_Click(sender As Object, e As EventArgs) Handles btnEdit_Present.Click
        Try
            idMedidas = 0
            If Me.DataGridPresent.SelectedRows.Count > 1 Then
                MsgBox("Seleccione solo uno de para poder editar", MsgBoxStyle.Information, "Aviso")
            ElseIf Me.DataGridPresent.SelectedRows.Count = 0 Then
                MsgBox("Seleccione la presentacion que desea editar", MsgBoxStyle.Information, "Aviso")
            ElseIf Me.DataGridPresent.SelectedRows.Count = 1 Then
                'con el datagrid
                Me.DataGridPresent.Enabled = False
                Me.DataGridPresent.BackgroundColor = Color.Wheat

                'con los controles--------------------------------------------------------------------
                Blokea_Prensent(True)
                cmbUndMedPresentRefery.Visible = True
                Me.lblIdPresentDe.Visible = False
                Me.lblPresentDeText.Visible = False

                'carga los cuadros combinados
                isLoad = False
                Carga_cmbPresentResulModif()
                Carga_CmbPresentReferyModif()
                isLoad = True
                'En cada empaque
                'Copio los valores de datagrivie en los textos- Medida --------------------------------------------------------------------
                With DataGridPresent
                    idMedidas = .SelectedCells.Item(.Columns("idProUndMed").Index).Value
                    Dim idMediRefery As Integer = .SelectedCells.Item(.Columns("idProUndReferen").Index).Value
                    'si se refiere al mismo prodcuto
                    isPresentFabricCheckedListBox.Visible = True
                    If Not (idMedidas = idMediRefery) Then
                        Me.cmbUndMedPresentRefery.SelectedValue = (.SelectedCells.Item(.Columns("idProUndReferen").Index).Value)
                        Me.lblPresentDeText.Text = cmbUndMedPresentRefery.Items(cmbUndMedPresentRefery.SelectedIndex)("Nom_Medida").ToString
                    Else
                        isPresentFabricCheckedListBox.Visible = False
                    End If

                    Me.txtCodigo.Text = Convert.ToString(.SelectedCells.Item(.Columns("Codigo Producto").Index).Value)
                    Me.cmbPresentResult.Text = Convert.ToString(.SelectedCells.Item(.Columns("Nom_Medida").Index).Value)
                    Me.txtCant_Present.Value = Convert.ToDouble(.SelectedCells.Item(.Columns("Cant_Present").Index).Value)

                    If (idMedidas = idMediRefery) Then
                        Me.cmbUndMedPresentRefery.Visible = False
                        Me.lblPresentDeText.Visible = True
                        Me.lblPresentDeText.Text = .SelectedCells.Item(.Columns("Nom_Medida").Index).Value & " (s)"
                        Me.lblIdPresentDe.Text = .SelectedCells.Item(.Columns("idProUndReferen").Index).Value
                    End If
                    'para el tipo de presentacion...=======
                    If isPresentFabricCheckedListBox.Visible Then
                        isPresentFabricCheckedListBox.SetItemChecked(0, False)
                        isPresentFabricCheckedListBox.SetItemChecked(1, False)
                        If .SelectedCells.Item(.Columns("De fábrica?").Index).Value = True Then
                            isPresentFabricCheckedListBox.SetItemChecked(0, True)
                        ElseIf .SelectedCells.Item(.Columns("De fábrica?").Index).Value = False Then
                            isPresentFabricCheckedListBox.SetItemChecked(1, True)
                        End If
                    End If

                End With
                ActivaCmdPresentacion("Modificando")
                cmbPresentResult.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Blokea_Prensent(Status As Boolean)
        txtCodigo.Visible = Status
        txtCant_Present.Visible = Status
        cmbPresentResult.Visible = Status
        lblCNTpresent.Visible = Status
        lblCodigo.Visible = Status
        lblPresentDeText.Visible = Status
        lblvieneEn.Visible = Status
    End Sub
    Private Sub Carga_cmbPresentResulModif()
        Dim vlt As Integer = 0
        Dim MyWHERE As String = ""

        With DataGridPresent
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Selected = False Then
                    If vlt = 0 Then
                        MyWHERE = "(idProUndMed <>" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                    ElseIf vlt > 0 Then
                        MyWHERE = MyWHERE + " And (idProUndMed <>" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                    End If
                    vlt = vlt + 1
                End If
            Next
        End With

        sql = "SELECT * "
        sql = sql & " FROM dbo.ProductoUndMedida "

        If MyWHERE.Length > 0 Then
            MyWHERE = "WHERE " & MyWHERE
            sql = sql & MyWHERE
        End If

        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text
            Dim dat As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            dat.Fill(dt)
            If dt.Rows.Count > 0 Then
                With Me.cmbPresentResult
                    .DataSource = dt
                    .ValueMember = "idProUndMed"
                    .DisplayMember = "Nom_Medida"
                End With

            Else
                cmbPresentResult.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el CargarPresent")
        Finally
        End Try
    End Sub

    Private Sub ActivaCmdPresentacion(ByVal Situacion As String)
        Try
            Select Case Situacion
                Case "Nuevo"
                    Me.btnCancelPresent.Enabled = False
                    Me.btnUpdatePresent.Enabled = False
                    Me.btnEdit_Present.Enabled = False
                    Me.btnDelet_Present.Enabled = False
                    Me.btnAdd_Present.Enabled = True
                Case "Modificable"
                    Me.btnCancelPresent.Enabled = False
                    Me.btnUpdatePresent.Enabled = False
                    Me.btnEdit_Present.Enabled = True
                    Me.btnDelet_Present.Enabled = True
                    Me.btnAdd_Present.Enabled = False
                    Me.Label2.Visible = False
                    Me.isPresentFabricCheckedListBox.Visible = False
                Case "Agregando"
                    Me.btnCancelPresent.Enabled = True
                    Me.btnUpdatePresent.Enabled = False
                    Me.btnEdit_Present.Enabled = False
                    Me.btnDelet_Present.Enabled = False
                    Me.btnAdd_Present.Enabled = True
                    Me.Label2.Visible = True
                    Me.isPresentFabricCheckedListBox.Visible = True
                    isPresentFabricCheckedListBox.SetItemChecked(0, False)
                    isPresentFabricCheckedListBox.SetItemChecked(1, False)
                    Agregar = True
                Case "Modificando"
                    Me.btnCancelPresent.Enabled = True
                    Me.btnUpdatePresent.Enabled = True
                    Me.btnEdit_Present.Enabled = False
                    Me.btnDelet_Present.Enabled = False
                    Me.btnAdd_Present.Enabled = False
                Case "Ninguno"
                    Me.btnCancelPresent.Enabled = False
                    Me.btnUpdatePresent.Enabled = False
                    Me.btnEdit_Present.Enabled = False
                    Me.btnDelet_Present.Enabled = False
                    Me.btnAdd_Present.Enabled = False
                    Me.Label2.Visible = False
                    Me.isPresentFabricCheckedListBox.Visible = False
            End Select
            For Each cnt In TableLayouButoonControl.Controls
                If cnt.Enabled Then
                    cnt.BackColor = Color.Aqua
                Else
                    cnt.BackColor = Color.Wheat
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message + " al activar comandos", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_CmbPresentReferyModif()
        Dim vlt As Integer = 0
        Dim MyWHERE As String = ""
        '.Columns("idProUndMed").Index
        With DataGridPresent
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Selected = False Then
                    If vlt = 0 Then
                        MyWHERE = "(idProUndMed=" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                    ElseIf vlt > 0 Then
                        MyWHERE = MyWHERE + " OR (idProUndMed=" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                    End If
                    vlt = vlt + 1
                End If
            Next
        End With

        sql = "SELECT * "
        sql = sql & " FROM dbo.ProductoUndMedida "

        If MyWHERE.Length > 0 Then
            MyWHERE = "WHERE " & MyWHERE
            sql = sql & MyWHERE
        Else
            sql = sql & "WHERE idProUndMed  = 1"
        End If

        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text
            Dim dat As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            dat.Fill(dt)
            cmbUndMedPresentRefery.DataSource = Nothing
            If dt.Rows.Count > 0 Then
                With cmbUndMedPresentRefery
                    .DataSource = dt
                    .ValueMember = "idProUndMed"
                    .DisplayMember = "Nom_Medida"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frm_AddProducto en el sub Carga_CmbPresentRefery")
        End Try
    End Sub
    Private Sub btnNew_Present_Click()
        Try
            If Me.DataGridPresent.SelectedRows.Count = 1 Then
                'con el data grid view  --------------------------------------------
                Me.DataGridPresent.Enabled = False
                Me.DataGridPresent.BackgroundColor = Color.Wheat

                'cuadros de textos-------------------------------------------------------------
                Me.cmbUndMedPresentRefery.Visible = False
                Me.lblPresentDeText.Visible = True

                'aqui hay que agregar q id de presentacion ba ha referirise 
                Me.lblPresentDeText.Text = DataGridPresent.SelectedCells(DataGridPresent.Columns("Nom_Medida").Index).Value
                Me.lblIdPresentDe.Text = DataGridPresent.SelectedCells(DataGridPresent.Columns("idProUndMed").Index).Value
                Me.cmbPresentResult.Visible = True
                Me.lblvieneEn.Visible = True

                Carga_cmbPresentResult()
                Limpia_Presenatacion()
                Blokea_Prensent(True)
                Me.txtCant_Present.Focus()
                'con botonera
                ActivaCmdPresentacion("Agregando")
            ElseIf Me.DataGridPresent.SelectedRows.Count > 1 Then
                MsgBox("Seleccione solo uno del listado", MsgBoxStyle.Information, "Aviso")
                Me.DataGridPresent.Focus()
            Else
                MsgBox("Selecione una presentación del listado dispobible ", MsgBoxStyle.Information, "Aviso")
                Me.DataGridPresent.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdd_Producto en el btnNew_Present_Click")
        End Try
    End Sub

    Private Sub Limpia_Presenatacion()
        txtCodigo.Text = ""
        txtCant_Present.Value = 1
        cmbPresentResult.Text = "Seleccione.."
        cmbUndMedPresentRefery.Text = "Seleccione.."
    End Sub

    Private Function Carga_cmbPresentResult() As Boolean
        Dim MyWHERE As String = ""
        '.Columns("idProUndMed").Index
        With DataGridPresent
            For i = 0 To .Rows.Count - 1
                If i = 0 Then
                    MyWHERE = "(idProUndMed <>" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                ElseIf i > 0 Then
                    MyWHERE = MyWHERE + " And (idProUndMed <>" & .Item(.Columns("idProUndMed").Index, i).Value & ")"
                End If
            Next
        End With
        sql = "SELECT* "
        sql = sql & " FROM dbo.ProductoUndMedida "

        If MyWHERE.Length > 0 Then
            MyWHERE = "WHERE " & MyWHERE
            sql = sql & MyWHERE
        End If

        sql = sql & " order by  Nom_Medida "
        conecta_sql()
        Try
            Dim cmd As New SqlCommand(sql, Cnn_sql)
            cmd.CommandType = CommandType.Text
            Dim dat As New SqlDataAdapter(cmd)
            Dim dt As New DataTable

            dat.Fill(dt)
            If dt.Rows.Count > 0 Then
                With Me.cmbPresentResult
                    .DataSource = dt
                    .ValueMember = "idProUndMed"
                    .DisplayMember = "Nom_Medida"
                End With
                Return True
            Else
                cmbPresentResult.DataSource = Nothing
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_cmbPresentResult ", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub btnCancelPresent_Click(sender As Object, e As EventArgs) Handles btnCancelPresent.Click
        Me.DataGridPresent.Enabled = True
        Me.DataGridPresent.BackgroundColor = Color.Gray
        cmbUndMedPresentRefery.Visible = False
        If Me.DataGridPresent.SelectedRows.Count = 1 Then
            ActivaCmdPresentacion("Modificable")
        Else
            ActivaCmdPresentacion("Ninguno")
        End If
        Blokea_Prensent(False)
    End Sub

    Private Sub btnUpdatePresent_Click(sender As Object, e As EventArgs) Handles btnUpdatePresent.Click
        Me.myPadre.OkButton.Enabled = False
        If Valida_PresentModifi() Then
            If Modifica_Presentacion(DataGridPresent.SelectedCells.Item(DataGridPresent.Columns("idPresentacion").Index).Value) Then
                cmbUndMedPresentRefery.Visible = False
                Carga_ListPresent(myPadre.Id_Producto)
                If Not (Me.myPadre.lblProdcutodesc.Text.Contains("Agregando")) Then
                    Me.myPadre.OkButton.Enabled = True
                End If
            End If
        Else
            MsgBox("Falta ingresar algunos datos", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub Carga_ListPresent(idProducto As Integer)

        sql = "SELECT TOP (15) m.idProUndMed, m.Nom_Medida, pr.codProducto as [Codigo Producto],  "
        sql = sql & "Cast('' as varchar(25)) as  [En cada empaque], "
        sql = sql & "pr.idProUndReferen, pr.Cant_Present, pr.idPresentacion, "
        sql = sql & "m.Medida, up.Medida as MedidaReferi, pr.Barcode, "  ' se ocultra cualquiera las columnas
        sql = sql & "pr.isPresentFactory as [De fábrica?] "

        sql = sql & "From dbo.ProductoPresentacion AS pr "
        sql = sql & "INNER JOIN dbo.ProductoUndMedida AS m ON pr.idProUndMed = m.idProUndMed "
        sql = sql & "INNER JOIN dbo.ProductoUndMedida AS up ON pr.idProUndReferen = up.idProUndMed "
        sql = sql & "WHERE(pr.idProducto =" & idProducto & ") ORDER BY pr.idPresentacion "

        isLoad = False
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                DataGridPresent.Columns.Clear()
                DataGridPresent.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    With DataGridPresent
                        .DataSource = dt
                        .AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.AllCells
                        .RowHeadersWidth = 4
                        .Columns(0).Visible = False ' idProdMedi
                        .Columns(4).Visible = False 'idUndMediPreseRefery
                        .Columns(5).Visible = False 'Cantidad_Present
                        .Columns(6).Visible = False 'idPresentacion
                        .Columns(7).Visible = False 'Medida de la presentacion [UND]
                        .Columns(8).Visible = False 'Medida de referencia [KL]
                        .Columns(9).Visible = False 'Codigo de barra.
                        .Columns.Add(columncontrol)
                        .Columns.Add(columnBarrCode)
                        .Enabled = True
                        .BackgroundColor = Color.Gray

                        For i = 0 To .RowCount - 1
                            Dim Cantidad As Double = .Rows(i).Cells("Cant_Present").Value
                            Dim valor As String = Cantidad
                            valor = valor & " " & .Rows(i).Cells("MedidaReferi").Value
                            'si se refiere a la misma medida lo presentamos la del padre
                            If .Rows(i).Cells("idProUndMed").Value = .Rows(i).Cells("idProUndReferen").Value Then
                                .Rows(i).Cells("En cada empaque").Value = Me.myDescriptionEmpaque(idProducto)
                            Else
                                .Rows(i).Cells("En cada empaque").Value = valor
                            End If

                            .Rows(i).Cells("barrCodeButoon").Value = .Rows(i).Cells("Barcode").Value
                        Next
                    End With

                    ImpideOrdenamiento(DataGridPresent)
                    'pada determinar que si hay datos
                    CotrolsHayDatos()

                Else
                    lblCNTpresent.Visible = True
                    txtCant_Present.Visible = True
                    lblPresentDeText.Visible = True
                    lblPresentDeText.Text = "Unidad (s)"
                    lblCodigo.Visible = True
                    txtCodigo.Visible = True
                    btnAdd_Present.Enabled = True
                    btnAdd_Present.BackColor = Color.Aqua
                    Agregar = True
                    panePresentacion.TabIndex = 0
                    txtCodigo.TabIndex = 0
                    Label2.Visible = False
                    isPresentFabricCheckedListBox.Visible = False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + "en el modulo Mostrar_ListPresent del " + Me.Name, MsgBoxStyle.Critical)
            DataGridPresent.DataSource = Nothing
        Finally
            isLoad = True
            ActivaMenu()
        End Try
    End Sub

    Private Function myDescriptionEmpaque(id_producto As Integer) As String
        Try
            sql = "select p.Cant_minima, um.signo "
            sql = sql & "From Productos as p "
            sql = sql & "inner join ProductoUndMin as um on um.idUnidad =p.idUnidad "
            sql = sql & "where (p.idProducto = @idProducto) "
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@idProducto", id_producto)
                    Using data As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            data.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Dim cantidad As Double = dt.Rows(0)("Cant_minima")
                                Dim valor As String = cantidad
                                Return String.Format("{0}{1}", valor, dt.Rows(0)("signo"))
                            End If
                        End Using
                    End Using
                End Using
            End Using
            Return String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            Return String.Empty
        End Try
    End Function

    Private Function columncontrol() As DataGridViewButtonColumn
        Dim clm As New DataGridViewButtonColumn
        clm.Name = "NewButoon"
        clm.Text = "Nuevo"
        clm.HeaderText = ""
        clm.ToolTipText = "Agregar nuevo empaque para ésta presentación"
        clm.UseColumnTextForButtonValue = True
        clm.DisplayIndex = 0
        Return clm
    End Function
    Private Function columnBarrCode() As DataGridViewButtonColumn
        Dim clm As New DataGridViewButtonColumn
        clm.Name = "barrCodeButoon"
        clm.Text = String.Empty
        clm.HeaderText = "Código de barra"
        clm.ToolTipText = "Click para modificar el código de barra."
        clm.UseColumnTextForButtonValue = True
        clm.Width = 200
        clm.DisplayIndex = 15
        Return clm
    End Function

    Private Function Modifica_Presentacion(ByVal idPresent As Integer) As Boolean

        Dim idProUndMed As Integer = Me.cmbPresentResult.SelectedValue
        Dim idProUndReferen As Integer = 0
        Dim Cant_Present As Double = Me.txtCant_Present.Value
        Dim codProduct As String = Me.txtCodigo.Text
        If Me.cmbUndMedPresentRefery.Visible Then
            idProUndReferen = Me.cmbUndMedPresentRefery.SelectedValue
        Else
            idProUndReferen = Me.lblIdPresentDe.Text
        End If
        'determinar el tipo de presentacion
        Dim isPresentFactory As Short = 1
        If isPresentFabricCheckedListBox.Visible Then
            If isPresentFabricCheckedListBox.GetItemChecked(0) = True Then
                isPresentFactory = 1
            ElseIf isPresentFabricCheckedListBox.GetItemChecked(1) = True Then
                isPresentFactory = 0
            Else
                MsgBox("No se ha determinado el tipo de presentación.")
                Return False
            End If
        End If

        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New SqlCommand("[dbo].[UpdateProductoPresentacion]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@idPresent", SqlDbType.Int)
                    cmd.Parameters.Add("@codProducto", SqlDbType.VarChar, 40)
                    cmd.Parameters.Add("@idProUndMed", SqlDbType.Int)
                    cmd.Parameters.Add("@idProUndReferen", SqlDbType.Int)
                    cmd.Parameters.Add("@Cant_Present", SqlDbType.Decimal, 18, 2)
                    cmd.Parameters.Add("@CodUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@isPresentFactory", SqlDbType.Bit)

                    'set values @isPresentFactory
                    cmd.Parameters("@idPresent").Value = idPresent
                    cmd.Parameters("@codProducto").Value = codProduct
                    cmd.Parameters("@idProUndMed").Value = idProUndMed
                    cmd.Parameters("@idProUndReferen").Value = idProUndReferen
                    cmd.Parameters("@Cant_Present").Value = Cant_Present
                    cmd.Parameters("@CodUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@isPresentFactory").Value = isPresentFactory

                    If cmd.ExecuteNonQuery() Then
                        Return True
                    Else
                        Return False
                    End If
                End Using

            End Using

        Catch ex As Exception
            If ex.Message.Contains("UNIQUE") And ex.Message.Contains("UQ__Producto") Then
                MsgBox("El código " + codProduct + " ya existe.", MsgBoxStyle.Exclamation, "Aviso")
            ElseIf ex.Message.Contains("UK_Producto_Medidas") Then
                MsgBox("Esta presentacion ya esta ingresada", MsgBoxStyle.Exclamation, "Aviso")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdd_Producto Function Agrega_Present")
            End If
            Return False
        End Try
    End Function


    Private Function Valida_PresentModifi() As Boolean
        Dim Resul As Boolean = True

        Try
            'para codproducto
            If Me.txtCodigo.Text.Length > 0 Then
                Me.ErrorIcono.SetError(txtCodigo, "")
            Else
                Me.ErrorIcono.SetError(txtCodigo, "Sebe ingresar un codigo de producto..")
                Resul = False
            End If

            'para producto resultante
            If Me.cmbPresentResult.SelectedIndex >= 0 Then
                Me.ErrorIcono.SetError(cmbPresentResult, "")
            Else
                Me.ErrorIcono.SetError(cmbPresentResult, msgSelect_list)
                Resul = False
            End If

            'para cantidad de prokducto
            If Me.txtCant_Present.Value > 0 Then
                Me.ErrorIcono.SetError(txtCant_Present, "")
            Else
                Me.ErrorIcono.SetError(txtCant_Present, "Ingrese la cantiada de producto que viene en esta empaque")
                Resul = False
            End If

            'para producto producto al que se refiere.-------------------------------------------------------------------------------
            If Me.cmbUndMedPresentRefery.SelectedIndex >= 0 Or Me.cmbUndMedPresentRefery.Visible = False Then
                Me.ErrorIcono.SetError(cmbUndMedPresentRefery, "")
            Else
                Me.ErrorIcono.SetError(cmbUndMedPresentRefery, msgSelect_list)
                Resul = False
            End If

            'para el ripo de presentacion
            If isPresentFabricCheckedListBox.Visible Then
                If isPresentFabricCheckedListBox.GetItemChecked(0) = False And
               isPresentFabricCheckedListBox.GetItemChecked(1) = False Then
                    Me.ErrorIcono.SetError(isPresentFabricCheckedListBox, "Seleccione el tipo de presentación.")
                    Return False
                End If
            End If
            'valida si pertenece a formas de compra o bodega
            Using db As New DataContext
                Dim idCompra = (From pp In db.Productos
                                Where pp.idProducto = Integer.Parse(myPadre.Id_Producto)).FirstOrDefault().Deft_idPresenCompra

                If Not IsNothing(idCompra) Then
                    If idCompra = Me.idMedidas And Not (Me.idMedidas = Integer.Parse(Me.cmbPresentResult.SelectedValue)) Then
                        sql = "Esta presentacion esta definida como unidad de compra." & vbCrLf
                        sql = sql & "Primero cambielo para modificar."
                        MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                        Return False
                    End If
                End If

                Dim _Stock = From pp In db.ProductosStock
                             Where pp.idProducto = Integer.Parse(myPadre.Id_Producto)

                For Each item In _Stock
                    If item.idProUndMed = Me.idMedidas Then
                        If Not (Me.idMedidas = Integer.Parse(Me.cmbPresentResult.SelectedValue)) Then
                            sql = "Esta presentacion esta definida para ver el stock en bodega o almacen." & vbCrLf
                            sql = sql & "Primero cambielo para modificar."
                            MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                            Return False
                        End If
                    End If
                Next
            End Using
            Return Resul
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frm_addProducto en el sub Valida_PresentModifi")
            Return False
        End Try
        Return Resul
    End Function

    Private Sub btnDelet_Present_Click(sender As Object, e As EventArgs) Handles btnDelet_Present.Click
        If Me.DataGridPresent.SelectedRows.Count > 1 Then
            MsgBox("Seleccione solo uno de para poder Eliminar", MsgBoxStyle.Information, "Aviso")
        ElseIf Me.DataGridPresent.SelectedRows.Count = 0 Then
            MsgBox("Seleccione la presentacion que desea Eliminar", MsgBoxStyle.Information, "Aviso")
        ElseIf Me.DataGridPresent.SelectedRows.Count = 1 Then
            sql = "Está seguro de eliminar la presentación: "
            With DataGridPresent
                If MsgBox(sql & .SelectedCells.Item(.Columns("Nom_Medida").Index).Value, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                    If Elimina_presentacion(.SelectedCells.Item(.Columns("idPresentacion").Index).Value) Then
                        Carga_ListPresent(myPadre.Id_Producto)
                    Else
                        MsgBox("No se elimino Presenatacion", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            End With
        End If
    End Sub
    Private Sub btnAdd_Present_Click(sender As Object, e As EventArgs) Handles btnAdd_Present.Click
        If Valida_Presentacion() Then
            If Busca_idPresent(Me.txtCodigo.Text) > 0 Then
                sql = "El código de producto ya existe." & vbNewLine
                sql = sql & "Menú Listado de productos para saber a que prodcuto pertenece."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                Me.ErrorIcono.SetError(txtCodigo, "El codigo ya existe")
                Exit Sub
            Else
                Me.ErrorIcono.SetError(txtCodigo, "")
            End If
            'AGREGO LA PRESENTACION....
            If Agrega_Present() Then
                Carga_ListPresent(myPadre.Id_Producto)
            End If
        Else
            MsgBox("Falta ingresar algunos datos", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Function Agrega_Present() As Boolean

        Dim codProduct As String = Me.txtCodigo.Text

        Dim cantidad As Double = Me.txtCant_Present.Value
        Dim idProUndReferen As Integer = 0
        Dim idProUndMed As Integer = 0

        If Me.cmbPresentResult.Visible Then
            idProUndMed = Me.cmbPresentResult.SelectedValue
            idProUndReferen = lblIdPresentDe.Text
        Else
            idProUndReferen = 1
            idProUndMed = 1
        End If

        Dim isPresentFactory As Short = 1
        If isPresentFabricCheckedListBox.Visible Then
            If isPresentFabricCheckedListBox.GetItemChecked(0) = True Then
                isPresentFactory = 1
            ElseIf isPresentFabricCheckedListBox.GetItemChecked(1) = True Then
                isPresentFactory = 0
            Else
                MsgBox("No se ha determinado el tipo de presentación.")
                Return False
            End If
        End If
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New SqlCommand("InsertProductoPresentacion", cnn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.Add("@codProducto", SqlDbType.VarChar, 40)
                    cmd.Parameters.Add("@idProducto", SqlDbType.Int)
                    cmd.Parameters.Add("@idProUndMed", SqlDbType.Int)
                    cmd.Parameters.Add("@idProUndReferen", SqlDbType.Int)
                    cmd.Parameters.Add("@Cant_Present", SqlDbType.Decimal, 18, 2)
                    cmd.Parameters.Add("@CodUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@isPresentFactory", SqlDbType.Bit)

                    'set values @isPresentFactory
                    cmd.Parameters("@codProducto").Value = codProduct
                    cmd.Parameters("@idProducto").Value = myPadre.Id_Producto
                    cmd.Parameters("@idProUndMed").Value = idProUndMed
                    cmd.Parameters("@idProUndReferen").Value = idProUndReferen
                    cmd.Parameters("@Cant_Present").Value = Me.txtCant_Present.Value
                    cmd.Parameters("@CodUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@isPresentFactory").Value = isPresentFactory

                    If cmd.ExecuteNonQuery() Then
                        Return True
                    Else
                        Return False
                    End If
                End Using

            End Using

        Catch ex As Exception
            If ex.Message.Contains("UNIQUE") And ex.Message.Contains("UQ__Producto") Then
                MsgBox("El código " + codProduct + " ya existe.", MsgBoxStyle.Exclamation, "Aviso")
            ElseIf ex.Message.Contains("UK_Producto_Medidas") Then
                MsgBox("Esta presentacion ya esta ingresada", MsgBoxStyle.Exclamation, "Aviso")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmAdd_Producto Function Agrega_Present")
            End If
            Return False
        End Try
    End Function
    Public Function Valida_Presentacion() As Boolean
        Try

            'codigo de texto
            If Me.txtCodigo.Text.Length > 0 Then
                Me.ErrorIcono.SetError(txtCodigo, "")
            Else
                Me.ErrorIcono.SetError(txtCodigo, "Ingrese el codigo de Producto")
                Return False
            End If

            'cantidad de presentación
            If Me.txtCant_Present.Value > 0 Then
                Me.ErrorIcono.SetError(txtCant_Present, "")
            Else
                Me.ErrorIcono.SetError(txtCant_Present, "Indique cuantas unidades viene en  cada empaque")
                Return False
            End If


            'cmbinado presenatación
            If cmbPresentResult.Visible Then
                If cmbPresentResult.SelectedIndex >= 0 Then
                    If Me.cmbPresentResult.Text = Me.cmbPresentResult.Items(cmbPresentResult.SelectedIndex)("Nom_Medida").ToString Then
                        Me.ErrorIcono.SetError(cmbPresentResult, "")
                    Else
                        Me.ErrorIcono.SetError(cmbPresentResult, msgSelect_list)
                        Return False
                    End If
                Else
                    Me.ErrorIcono.SetError(cmbPresentResult, msgSelect_list)
                    Return False
                End If
            End If

            'para el ripo de presentacion
            If isPresentFabricCheckedListBox.Visible Then
                If isPresentFabricCheckedListBox.GetItemChecked(0) = False And
               isPresentFabricCheckedListBox.GetItemChecked(1) = False Then
                    Me.ErrorIcono.SetError(isPresentFabricCheckedListBox, "Seleccione el tipo de presentación.")
                    isPresentFabricCheckedListBox.Select()
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub DataGridPresent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPresent.CellClick
        ActivaCmdPresentacion("Modificable")
    End Sub

    Private Sub DataGridPresent_Enter(sender As Object, e As EventArgs) Handles DataGridPresent.Enter
        If Me.DataGridPresent.SelectedRows.Count = 1 Then
            ActivaCmdPresentacion("Modificable")
        End If
    End Sub

    Private Sub DataGridPresent_Leave(sender As Object, e As EventArgs) Handles DataGridPresent.Leave
        If Me.DataGridPresent.RowCount > 0 Then
            If Me.DataGridPresent.SelectedRows.Count = 0 Then
                ActivaCmdPresentacion("Ninguno")
            End If
        End If
    End Sub

    Private Sub btnSiguientePresent_Click(sender As Object, e As EventArgs) Handles SiguientButton.Click
        sender.Tag = 1
        Try
            If DataGridPresent.Rows.Count = 0 Then
                DataGridPresent.Focus()
                MsgBox("Ingrese las presentaciones del producto...", MsgBoxStyle.Critical, "Error")
                Return
            End If
            With Me.myPadre
                If .lblProdcutodesc.Text.Contains("Agregando") Then
                    .menuConfiguracion.Enabled = True
                    .menuConfiguracion.PerformClick()
                End If
                sender.Tag = 1
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DataGridPresent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPresent.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                If sender.columns(e.ColumnIndex).name = "NewButoon" Then
                    btnNew_Present_Click()
                    cmbPresentResult.Focus()
                ElseIf sender.columns(e.ColumnIndex).name = "barrCodeButoon" Then
                    Using frmBarrCodes As New frmBarrCode
                        With frmBarrCodes
                            .ProductoLabel.Text = Me.myPadre.lblProdcutodesc.Text
                            .PresentacionLabel.Text = DataGridPresent.SelectedCells(DataGridPresent.Columns("Nom_Medida").Index).Value
                            .idPresent = DataGridPresent.SelectedCells(DataGridPresent.Columns("idPresentacion").Index).Value
                            .barCodeTextBox.Text = DataGridPresent.SelectedCells(DataGridPresent.Columns("Barcode").Index).Value.ToString
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                If e.RowIndex >= 0 And DataGridPresent.Columns(e.ColumnIndex).Name = "barrCodeButoon" Then
                                    DataGridPresent.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = .barCodeTextBox.Text
                                    DataGridPresent.Rows(e.RowIndex).Cells(DataGridPresent.Columns("Barcode").Index).Value = .barCodeTextBox.Text
                                End If
                                If Not Me.myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                                    myPadre.OkButton.Enabled = True
                                End If
                            End If
                        End With
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ActivaMenu()

        Try
            If Not isLoad Then
                Return
            End If
            With myPadre
                If DataGridPresent.RowCount = 0 Then
                    .SiguienteButton.Enabled = False
                    .OkButton.Enabled = False
                    .SiguienteButton.Text = "Guardar"
                    Return
                End If
                If .lblProdcutodesc.Text.Contains("Agregando") Then
                    .SiguienteButton.Visible = True
                    .SiguienteButton.Enabled = True
                    .SiguienteButton.Text = "Siguiente=>"
                    .OkButton.Enabled = False
                    'nicicindo producto 
                Else
                    .SiguienteButton.Enabled = True
                    .SiguienteButton.Text = "Guardar"
                    .OkButton.Enabled = False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub CotrolsHayDatos()
        Borra_SelectRowDataGrip(Me.DataGridPresent)
        Limpia_Presenatacion()
        Blokea_Prensent(False)
        ActivaCmdPresentacion("Ninguno")
        Agregar = False
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If MsgBox(msgSave, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, msgRespond) = MsgBoxResult.Yes Then
            With Me.myPadre
                .SiguienteButton.Visible = False
                .OkButton.Enabled = True
            End With
            Me.myPadre.IdPresentacion = Me.idPresentacion
            Try
                sql = "Insert Into ProductoProveedor (idProveedor, idPresentacion) "
                sql = sql & "values(" & Me.myPadre.Id_Proveedor & ", " & Me.idPresentacion & ") "
                Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                    cnn.Open()
                    Using cmd As New SqlCommand(sql, cnn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.TextLength > 3 Then
            If Agregar Then
                Me.AcceptButton = btnAdd_Present
            Else
                Me.AcceptButton = btnUpdatePresent
            End If
        Else
            Me.AcceptButton = Nothing
        End If

    End Sub

    Private Sub cmbPresentResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresentResult.SelectedIndexChanged
        Try
            If Not isLoad Then
                Return
            End If
            Dim Medida As String = String.Empty
            txtCant_Present.Enabled = True
            If cmbPresentResult.SelectedIndex >= 0 Then
                If cmbPresentResult.DisplayMember.ToString().Length > 0 Then
                    Medida = cmbPresentResult.Items(cmbPresentResult.SelectedIndex)("Medida").ToString
                    If Medida.Equals("LB") Or Medida.Equals("KG") Then
                        If Not lblPresentDeText.Text.Equals("Unidad") Then
                            MsgBox("Este empaque se debe referirse solo a la unidad", MsgBoxStyle.Exclamation, "Importante")
                            cmbPresentResult.Focus()
                            Return
                        End If
                        Dim cant As Double = Convert.ToDouble(cmbPresentResult.Items(cmbPresentResult.SelectedIndex)("ConverMedida").ToString())
                        txtCant_Present.Value = cant
                        txtCant_Present.Enabled = False
                        txtCodigo.Focus()
                    ElseIf Medida.Equals("Q") Then
                        If cmbUndMedPresentRefery.Visible Then
                            If Not cmbUndMedPresentRefery.Text.Contains("Libra") Then
                                MsgBox("Convierta primero a libras.", MsgBoxStyle.Exclamation, "Importante")
                                cmbPresentResult.Focus()
                                Return
                            End If
                        Else
                            If Not lblPresentDeText.Text.Contains("Libra") Then
                                MsgBox("Convierta primero a libras.", MsgBoxStyle.Exclamation, "Importante")
                                cmbPresentResult.Focus()
                                Return
                            End If
                        End If
                        Dim cant As Double = Convert.ToDouble(cmbPresentResult.Items(cmbPresentResult.SelectedIndex)("ConverMedida").ToString())
                        txtCant_Present.Value = cant
                        txtCant_Present.Enabled = False
                        txtCodigo.Focus()
                    Else
                        txtCant_Present.Enabled = True
                        txtCant_Present.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub txtCant_Present_Enter(sender As Object, e As EventArgs) Handles txtCant_Present.Enter
        Try
            Dim valor As String = sender.Value
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                sql = Strings.Left(valor, posicion - 1)
                sender.Select(0, Len(sql) + 1 + sender.DecimalPlaces)
            Else
                sender.Select(0, Len(valor) + 1 + sender.DecimalPlaces)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "en le txtNumber_Enter del " + Name, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub txtCant_Present_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCant_Present.KeyPress
        If Asc(e.KeyChar) = 13 Then ' enter
            Me.txtCodigo.Focus()
        End If
    End Sub
    Private Sub isPresentFabricCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles isPresentFabricCheckedListBox.ItemCheck
        Try
            If isLoad Then
                isLoad = False
                If e.NewValue = CheckState.Checked Then
                    If e.Index = 0 Then
                        isPresentFabricCheckedListBox.SetItemChecked(1, False)
                    ElseIf e.Index = 1 Then
                        isPresentFabricCheckedListBox.SetItemChecked(0, False)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            isLoad = True
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then ' enter
            Me.isPresentFabricCheckedListBox.Focus()
        End If
    End Sub

    Private Sub DataGridPresent_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridPresent.CellFormatting
        If e.RowIndex >= 0 And DataGridPresent.Columns(e.ColumnIndex).Name = "barrCodeButoon" Then
            DataGridPresent.Columns(e.ColumnIndex).Width = 200
            e.Value = DataGridPresent.Rows(e.RowIndex).Cells(DataGridPresent.Columns("Barcode").Index).Value
        End If
    End Sub
End Class