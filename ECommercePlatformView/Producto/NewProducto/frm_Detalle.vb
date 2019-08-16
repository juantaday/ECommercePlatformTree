Imports System.Data.SqlClient

Public Class frm_detalle
    Private myPadre As MDI_AddProductos
    Private Operation As stateOperation
    Public Id_Producto As Integer
    Private IdKind As Int16
    Dim Facturable, Activo As Byte
    Protected Friend ivaPorcentaje As Double
    Private cargado As Boolean
    Private Structure Detail
        Public Nom_Comer As String
        Public NomComu As String
        Public Descrip As String
        Public undMed As Int16
        Public Cant As Double
        Public ivaEstate As Boolean
        Public state As Boolean
        Public ivaDescription As String
        Public AdminDatexpirate As Boolean
    End Structure
    Private Detalle As Detail


    Sub New(myPadre As MDI_AddProductos, _operation As stateOperation, _idProducto As Integer, IdKind As Int16)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.myPadre = myPadre
        Me.Operation = _operation
        Me.IdKind = IdKind
        Id_Producto = _idProducto
    End Sub
    Sub New(_operation As stateOperation, _idProducto As Integer, IdKind As Int16)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Operation = _operation
        Me.IdKind = IdKind
        Id_Producto = _idProducto
    End Sub
    Private Sub frm_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ivaPorcentaje = CargaIva()
        Me.ivaPreserminadoLinkLabel.Text = String.Format("IVA. predeterminado. {0}", Me.ivaPorcentaje.ToString("P2"))
        Nom_Comercialtxt.CharacterCasing = CharacterCasing.Upper
        NomComuntext.CharacterCasing = CharacterCasing.Upper
        CargaUndMinima()
        If Not IsNothing(Id_Producto) Then
            If Id_Producto > 0 Then
                Carga_Producto(Id_Producto)
            End If
        End If
        CargaMemoria()
    End Sub
    Private Sub txtNom_Comun_TextChanged(sender As Object, e As EventArgs) Handles NomComuntext.Validating, Nom_Comercialtxt.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "Datos obligatorios..")
        End If
    End Sub
    Private Sub txtNom_Comercial_Leave(sender As Object, e As EventArgs) Handles Nom_Comercialtxt.Leave
        Me.Nom_Comercialtxt.Text = UCase(Trim(Me.Nom_Comercialtxt.Text))
    End Sub

    Private Sub Carga_Producto(ByVal idProdcuto As Integer)
        cargado = False
        sql = " SELECT        p.* "
        sql = sql & "FROM            dbo.productos AS p "
        sql = sql & "WHERE(p.idProducto = " & idProdcuto & ") "
        Try
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Me.Nom_Comercialtxt.Text = dt.Rows(0)("Nom_Comercial")
                    Me.NomComuntext.Text = dt.Rows(0)("Nom_Comun")
                    Me.Descriptext.Text = dt.Rows(0)("Descripcion")
                    Me.CantidadMinNumeric.Value = dt.Rows(0)("Cant_Minima")
                    Me.UndMedComBox.SelectedValue = dt.Rows(0)("idUnidad")
                    'calculo para iva....
                    Dim iva As Double = Double.Parse(dt.Rows(0)("IvaPorcentaje"))
                    IvaCheckBox.Checked = Boolean.Parse(iva > 0)
                    Me.ivaApliDesLabel.Text = String.Format("IVA Aplicado. {0}", iva.ToString("P2"))

                    StateCheckBox.Checked = Boolean.Parse(dt.Rows(0)("Activo"))
                    StateCheckBox.Enabled = False

                    Me.AdminDateExpirateCheckBox.Checked = Boolean.Parse(dt.Rows(0)("ItIsExpirable"))

                    If IsNothing(Me.myPadre) Then
                        Return
                    End If
                    With Me.myPadre
                        If .Estado = True Then
                            .lblProdcutodesc.BackColor = Color.Red
                            .lblProdcutodesc.Text = "Agregando Nuevo :" & dt.Rows(0)("Nom_Comercial")
                        Else
                            .lblProdcutodesc.Text = dt.Rows(0)("Nom_Comercial")
                        End If
                        .Nom_Comerial = dt.Rows(0)("Nom_Comercial")
                        .Id_seCompra = dt.Rows(0)("Deft_idPresenCompra")
                        .Id_seVende = dt.Rows(0)("Deft_idPresenVenta")
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Carga_Producto")
        Finally
            cargado = True
        End Try
    End Sub
    Private Sub CargaUndMinima()
        Try
            sql = "Select * from ProductoUndMin Order By Nom_Unidad "
            Dim CMD As New ClassCargadorProducto()
            Dim DT As DataTable = CMD.RetornaTabla(sql)
            If Not IsNothing(DT) Then
                If DT.Rows.Count > 0 Then
                    With UndMedComBox
                        .ValueMember = "idUnidad"
                        .DataSource = DT
                        .DisplayMember = "Nom_Unidad"
                        .SelectedValue = 4
                    End With
                Else
                    UndMedComBox.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar CargaUndMinima")
            UndMedComBox.DataSource = Nothing
        End Try
    End Sub

    Private Function ValidateProducto() As Boolean
        Try
            If ValidateChildren() And Nom_Comercialtxt.TextLength > 0 And NomComuntext.TextLength > 0 And UndMedComBox.SelectedIndex >= 0 Then
                'solo si voy abgregar como nuevo
                If Me.Operation = stateOperation.Insert And Me.Id_Producto > 0 Then
                    Return True
                ElseIf Me.Id_Producto = 0 Then
                    If Busca_IdProducto(Me.Nom_Comercialtxt.Text, Me.NomComuntext.Text) > 0 Then
                        MsgBox("Ya existe producto con este nombre revise el listado", MsgBoxStyle.Information, "Aviso")
                        Return False
                    Else
                        Return True
                    End If
                Else
                    'DOTO AGGREFAL SI NO ESTA PONIENTO LA MISMA DESCIOCO
                    Return True
                End If
            Else
                MsgBox("Falta de ingresar datos", MsgBoxStyle.Information, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "en el ValidateProducto del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Agrega_Producto() As Boolean

        Try
            Dim Nom_Comercial As String = Convert.ToString(Me.Nom_Comercialtxt.Text)
            Dim Nom_Comun As String = Convert.ToString(Me.NomComuntext.Text)
            Dim Descripcion As String = Convert.ToString(Me.Descriptext.Text)
            Dim Cant_minima As Double = (Me.CantidadMinNumeric.Value)
            Dim idUnidad As Integer = Me.UndMedComBox.SelectedValue
            Dim IdSubCategoria As Integer = 1
            Dim Deft_idPresenCompra As Integer = 0
            Dim Deft_idPresenVenta As Integer = 0
            Dim IvaPorcent As Double = 0
            Dim coduser As String = UsuarioActivo.codUser
            Dim AdminDateExpirate? As Int16 = If(Me.AdminDateExpirateCheckBox.Checked, 1, 0)

            Activo = If(StateCheckBox.Checked, 1, 0)
            IvaPorcent = If(IvaCheckBox.Checked, ivaPorcentaje, 0)


            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.Connection = Cnn_sql
            If Me.Id_Producto > 0 Then
                Me.Operation = stateOperation.Update
            End If


            If Me.Operation = stateOperation.Insert Then ' si boy agregar

                sql = "Insert into Productos(Nom_Comercial,Nom_Comun,Descripcion,Cant_minima,idUnidad,IdSubCategoria,Deft_idPresenCompra, "
                sql = sql & "Deft_idPresenVenta,IvaPorcentaje,coduser,Facturable,ItIsExpirable, IdKind) "
                sql = sql & "Values('" & Nom_Comercial & "', '" & Nom_Comun & "','" & Descripcion & "', " & Cant_minima & ", " & idUnidad & ", " & IdSubCategoria & "," & Deft_idPresenCompra & ", "
                sql = sql & "" & Deft_idPresenVenta & "," & IvaPorcent & ",'" & coduser & "'," & Facturable & "," & AdminDateExpirate & "," & Me.IdKind & ")"
                sql = sql & "SET @identity = SCOPE_IDENTITY() "

                cmd.CommandText = sql
                cmd.Parameters.Add(New SqlParameter("@identity", SqlDbType.Int))
                cmd.Parameters("@identity").Direction = ParameterDirection.Output
                If cmd.ExecuteNonQuery Then
                    Id_Producto = (cmd.Parameters("@identity").Value)
                    Return True
                End If
            ElseIf Me.Operation = stateOperation.Update Then ' para midificar
                sql = "UPDATE Productos SET Nom_Comercial='" & Nom_Comercial & "',Nom_Comun='" & Nom_Comun & "',Descripcion ='" & Descripcion & "',Cant_minima =" & Cant_minima & ", "
                sql = sql & "idUnidad =" & idUnidad & ", "
                sql = sql & "IvaPorcentaje = " & IvaPorcent & " ,coduser='" & coduser & "',Facturable = " & Facturable & ", Activo = " & Activo & ", "
                sql = sql & "ItIsExpirable = " & AdminDateExpirate & ", IdKind = " & Me.IdKind & " "
                sql = sql & "WHERE   (idProducto =" & Id_Producto & ") "

                cmd.CommandText = sql
                If cmd.ExecuteNonQuery() Then
                    Using db As New DataContext
                        If db.prcUpdateUndStoc(Id_Producto) Then
                            'aqui para ver si ejecuta el codig
                            sql = sql
                        End If
                    End Using
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub btnSigienteProdcuto_Click(sender As Object, e As EventArgs) Handles SigienteButton.Click
        SigienteButton.Tag = 0
        If ValidateProducto() Then
            SigienteButton.Tag = 1
            If Agrega_Producto() Then
                With Me.myPadre
                    .Id_Producto = Id_Producto
                    .Nom_Comerial = Nom_Comercialtxt.Text
                    If .Operation = stateOperation.Insert Then
                        .lblProdcutodesc.BackColor = Color.Red
                        .lblProdcutodesc.Text = "Agregando a: " & Nom_Comercialtxt.Text
                        .Nom_Comerial = Nom_Comercialtxt.Text
                    Else
                        .lblProdcutodesc.Text = Nom_Comercialtxt.Text
                    End If
                    .menuCategory.Enabled = True
                    .menuCategory.PerformClick()
                End With
            End If
        End If
    End Sub

    Private Sub btnModificaProducto_Click(sender As Object, e As EventArgs)
        If ValidateProducto() Then
            If Agrega_Producto() Then
                NotifyIcon1.ShowBalloonTip(1500, "Aviso", "Modificado carrectamete", ToolTipIcon.Info)
            End If
        End If
    End Sub
    Private Sub txtNom_Comercial_TextChanged(sender As Object, e As EventArgs) Handles Nom_Comercialtxt.TextChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub
    Private Function hayCambio() As Boolean
        Try
            With Detalle
                If .Nom_Comer = Nom_Comercialtxt.Text And
                   .NomComu = NomComuntext.Text And
                   .Descrip = Descriptext.Text And
                   .undMed = UndMedComBox.SelectedValue And
                   .Cant = CantidadMinNumeric.Value And
                   .ivaEstate = IvaCheckBox.Checked And
                   .ivaDescription = ivaPreserminadoLinkLabel.Text And
                   .AdminDatexpirate = AdminDateExpirateCheckBox.Checked Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub CargaMemoria()
        Try
            With Detalle
                .Nom_Comer = Nom_Comercialtxt.Text
                .NomComu = NomComuntext.Text
                .Descrip = Descriptext.Text
                .undMed = UndMedComBox.SelectedValue
                .Cant = CantidadMinNumeric.Value
                .ivaEstate = IvaCheckBox.Checked
                .ivaDescription = ivaPreserminadoLinkLabel.Text
            End With
            AdminControlNot()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub AdminControlYes()
        Try
            If IsNothing(Me.myPadre) Then
                Return
            End If
            With Me.myPadre
                Select Case Me.myPadre.Operation
                    Case stateOperation.Insert
                    Case stateOperation.Update
                        If .Estado Then
                        Else
                            .SiguienteButton.Visible = True
                            .SiguienteButton.Enabled = True
                            .SiguienteButton.Text = "Guardar"
                        End If
                End Select
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub AdminControlNot()
        If IsNothing(Me.myPadre) Then
            Return
        End If
        With Me.myPadre
            Select Case Me.myPadre.Operation
                Case stateOperation.Insert
                Case stateOperation.Update
                    If .Estado Then
                    Else
                        .SiguienteButton.Visible = False
                    End If
            End Select
        End With
    End Sub

    Private Sub NomComuntext_TextChanged(sender As Object, e As EventArgs) Handles NomComuntext.TextChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub Descriptext_TextChanged(sender As Object, e As EventArgs) Handles Descriptext.TextChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub UndMedComBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UndMedComBox.SelectedIndexChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub CantidadMinNumeric_ValueChanged(sender As Object, e As EventArgs) Handles CantidadMinNumeric.ValueChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub IvaCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IvaCheckBox.CheckedChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
        Dim iva As Double = 0
        If (IvaCheckBox.Checked) Then
            iva = Me.ivaPorcentaje
        End If
        Me.ivaApliDesLabel.Text = String.Format("IVA Aplicado. {0}", iva.ToString("P2"))
    End Sub

    Private Sub StateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StateCheckBox.CheckedChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub ivaPreserminadoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ivaPreserminadoLinkLabel.LinkClicked
        Try
            Using frmIvaDialog
                With frmIvaDialog
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.ivaPorcentaje = .ivaPorcentaje
                        ivaPreserminadoLinkLabel.Text = String.Format("IVA. predeterminado. {0}", Me.ivaPorcentaje.ToString("P2"))
                        ivaApliDesLabel.Text = String.Format("IVA. Aplicado. {0}", Me.ivaPorcentaje.ToString("P2"))
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ivaPreserminadoLinkLabel_TextChanged(sender As Object, e As EventArgs) Handles ivaPreserminadoLinkLabel.TextChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub AdminDateExpirateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AdminDateExpirateCheckBox.CheckedChanged
        If cargado Then
            If hayCambio() Then
                AdminControlYes()
            Else
                AdminControlNot()
            End If
        End If
    End Sub

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        '  this save for combianed  product
        If Save_ProductCombine() Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function Save_ProductCombine() As Boolean
        Try
            If ValidateProducto() Then
                Select Case Operation
                    Case stateOperation.Insert, stateOperation.Update
                        If Agrega_Producto() Then
                            Return True
                        End If
                    Case stateOperation.Delete
                End Select
            End If
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If ValidateProducto() Then
                If Me.myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                    myPadre.Operation = stateOperation.Update
                    If Agrega_Producto() Then
                        Return
                    End If
                Else
                    If MsgBox("Está seguro de guardar los cambios..?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                        If Agrega_Producto() Then
                            With Me.myPadre
                                .SiguienteButton.Visible = False
                                .OkButton.Enabled = True
                            End With
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class