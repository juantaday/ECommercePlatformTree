Imports CADsisVenta
Imports CADsisVenta.DataSetDeudas
Imports CADsisVenta.DataSetDeudasTableAdapters

Public Class frmFormaPago
    Private LocatedPane As New Point()
    Protected Friend id_proveedor As Integer
    Protected Friend idcliente As Integer
    Protected Friend idFormaPago As Integer
    Protected Friend Vuelto As Double
    Protected Friend flag As String
    Protected Friend MsgBoxRetur As String
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        EnceraDatos()
        If ValidaGlobal(MenuActivo) Then
            DialogResult = DialogResult.OK
            Close()
        End If
    End Sub
    Private Sub EnceraDatos()
        Pagos.fech_Factura = Nothing
        Pagos.fech_Pago = Nothing
        Pagos.idBancoCuenta = 0
        Pagos.idCliente = 0
        Pagos.idformaPago = 0
        Pagos.idPago = 0
        Pagos.idPagoDetail = 0
        Pagos.idProveedor = 0
        Pagos.loginUser = String.Empty
        Pagos.Num_Documento = String.Empty
        Pagos.num_pago = String.Empty
        Pagos.tipo_Pago = 0
        Pagos.val_Factura = 0
        Pagos.val_Pagado = 0
    End Sub

    Private Function ValidaGlobal(ByVal MenuActiva As String) As Boolean
        Try
            Select Case flag
                'para clientes
                Case "Clientes"
                    Return ValidaClientes(MenuActiva)
                Case "Empleados"
                    'Return ValidaClientes(MenuActiva)
                Case "Compras"
                    Return ValidaCompras(MenuActiva)
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaClientes(ByVal MenuActiva As String) As Boolean
        Try
            Select Case MenuActiva
                Case paneEfectivo.Name
                    Return Mensaje_Efectivo()
                Case paneCredito.Name
                    Return Mensaje_Credito()
                Case paneCheque.Name
                    Return Mensaje_Cheque()
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaCompras(ByVal MenuActiva As String) As Boolean
        Try
            Select Case MenuActiva
                'para menu pago en activo
                Case paneEfectivo.Name
                    Pagos.fech_Factura = FacturCompra.FechaComra
                    Pagos.idProveedor = id_proveedor
                    Return Mensaje_Efectivo()
                    'para el cao credito
                Case paneCredito.Name
                    Pagos.idProveedor = id_proveedor
                    Pagos.fech_Factura = FacturCompra.FechaComra
                    Return Mensaje_Credito()
                    'para pagos con cheque
                Case paneCheque.Name
                    Return Mensaje_Cheque()
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Mensaje_Efectivo()
        Try
            If Double.Parse(txtPaga.Text) >= Double.Parse(txtTotal.Text) Then
                'este es el ensaje que ba ha retornar a la pantalla
                FacturVenta.idCliente = idcliente
                With Pagos
                    .idCliente = idcliente
                    .idformaPago = idFormaPago
                    .fech_Pago = Now()
                End With
                Vuelto = Redondear(Double.Parse(txtPaga.Text) - Double.Parse(txtTotal.Text), 2)
                MsgBoxRetur = vbNewLine & "PAGO EN EFECTIVO" & vbNewLine & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Total $:" & txtTotal.Text & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Pagó con $:" & txtPaga.Text & vbNewLine & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Cambio $:" & Vuelto
                Return True
            Else
                MsgBox("El valor pagado no puede ser menor a la de Total.", MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Mensaje_Credito() As Boolean
        Try
            'este es el ensaje que ba ha retornar a la pantalla
            With Pagos
                .idCliente = idcliente
                .idformaPago = idFormaPago
                .fech_Pago = Now()
            End With
            MsgBoxRetur = vbNewLine & "COMPRA A CREDITO" & vbNewLine & vbNewLine
            MsgBoxRetur = MsgBoxRetur & "Saldo anterior $:" & txtSaldo.Text & vbNewLine
            MsgBoxRetur = MsgBoxRetur & "Factura actual $:" & txtCreditoActual.Text & vbNewLine & vbNewLine
            MsgBoxRetur = MsgBoxRetur & "Total déuda $:" & txtTotalDeuda.Text
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Mensaje_Cheque() As Boolean
        Try
            If ValidateChildren() And cmbBanco.SelectedIndex >= 0 And cmbCuenta.SelectedIndex >= 0 And Num_cheqTxt.TextLength > 0 And ValCaheqtxt.TextLength > 0 Then
                With Pagos
                    .idCliente = idcliente
                    .idformaPago = idFormaPago
                    .idBancoCuenta = cmbCuenta.SelectedValue
                    .Num_Documento = Num_cheqTxt.Text
                    .val_Factura = txtCreditoActual.Text
                    .tipo_Pago = idFormaPago
                    .fech_Cheq = fecha_cheqDatatime.Value
                    .fech_Pago = Now()
                    .num_pago = Busca_New_NumDoc()
                End With
                MsgBoxRetur = vbNewLine & "SE PAGA CON CHEQUE" & vbNewLine & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Institución :" & cmbBanco.Text & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Cuenta :" & cmbCuenta.Text & vbNewLine & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Número de cheque :" & Num_cheqTxt.Text & vbNewLine
                MsgBoxRetur = MsgBoxRetur & "Valor de cheque :" & ValCaheqtxt.Text
                Return True
            Else
                MsgBox("Falta de ingresar algunos datos", MsgBoxStyle.Information, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NumericUpDown1_Enter(sender As Object, e As EventArgs) Handles txtPaga.Enter
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
            MsgBox(ex.Message + "en le txtprecioVenta_Enter del " + Me.Name, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub ToolStripMenuEfectivo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEfectivo.Click
        idFormaPago = sender.Tag
        Pinta_Menu(sender.name)
        Carga_Controles(paneEfectivo.Name)
    End Sub
    Private Sub Carga_Controles(ByVal ControlName As String)
        Try
            Dim pane As Control = Controls("paneNavegation")
            Dim paneSelect As System.Windows.Forms.Panel = Controls(ControlName)

            pane.Visible = False
            paneCheque.Visible = False
            paneEfectivo.Visible = False
            paneCredito.Visible = False

            paneSelect.Visible = True
            paneSelect.Location = pane.Location
            paneSelect.Height = pane.Height
            paneSelect.Width = pane.Width
            OK_Button.Enabled = True
            MenuActivo = ControlName
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(flag) Then
            MsgBox("No se ha determinado el parametro para [flag]", MsgBoxStyle.Exclamation, "Importante")
            Close()
        End If
        Me.Num_cheqTxt.CharacterCasing = CharacterCasing.Upper
        fecha_cheqDatatime.Value = Now
    End Sub

    Public Function InitialityMenu() As Boolean
        'determino la localizacion en la que aparecera los controles
        LocatedPane.X = 175
        LocatedPane.Y = 10
        Try
            If Carga_Menus() Then
                Me.Width = 540
                Me.Height = 335
                'creo un panel para navegacion
                Dim pane As New System.Windows.Forms.Panel
                Me.Controls.Add(pane)
                With pane
                    .Name = "paneNavegation"
                    .Width = 340
                    .Height = 230
                    .Location = LocatedPane
                    .Visible = True
                End With
                ToolStripMenuEfectivo.PerformClick()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Function Carga_Menus() As Boolean
        sql = "select * from [STM].[FormaPago] as fp order by fp.idformaPago"

        Try
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count >= (MenuStrip1.Items.Count - 1) Then
                    For i = 0 To MenuStrip1.Items.Count - 1
                        MenuStrip1.Items(i).Text = dt.Rows(i)("formaPago")
                        MenuStrip1.Items(i).Tag = dt.Rows(i)("idformaPago")
                    Next
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ToolStripMenuCredito_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCredito.Click
        Try
            Select Case flag
                Case "Clientes"
                    If Me.AutorizCredito(idcliente) Then
                        idFormaPago = sender.Tag
                        Pinta_Menu(sender.name)
                        Carga_Controles(paneCredito.Name)
                        Saldo_Deudas()
                    Else
                        MsgBox("Cliente no autorizado para comprar a crédito", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Case "Compras"
                    idFormaPago = sender.Tag
                    Pinta_Menu(sender.name)
                    Carga_Controles(paneCredito.Name)
                    Saldo_Deudas()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function total_Duda() As Double
        sql = "SELECT  idFacturaCompra, total_Fact, SUM(pagado) AS pagadas "
        sql = sql & " From dbo.Cobros AS c "
        sql = sql & "WHERE  (idCliente = " & idcliente & " ) "
        sql = sql & "GROUP BY idFacturaCompra, total_Fact"
        Try
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                Dim deuda As Double = 0
                Dim pagada As Double = 0

                For i = 0 To dt.Rows.Count - 1
                    deuda += dt.Rows(i)("total_Fact")
                    pagada += dt.Rows(i)("pagadas")
                Next
                Return (deuda - pagada)
            End If
            Return 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub Saldo_Deudas()
        Try
            Dim dt As New DataTable
            Dim isResponse As Boolean = False
            Select Case flag
                Case "Clientes"
                    Using data As New pcdLiastDuedasClientTableAdapter
                        Using dttable As New pcdLiastDuedasClientDataTable
                            data.Fill(dttable, Me.idcliente)
                            dt = dttable
                        End Using
                    End Using
                    isResponse = True'pcdLiastDuedasProviderTableAdapter
                Case "Compras"
                    Using data As New pcdLiastDuedasProviderTableAdapter
                        Using dttable As New pcdLiastDuedasProviderDataTable
                            data.Fill(dttable, Me.id_proveedor)
                            dt = dttable
                        End Using
                    End Using
                    isResponse = True
            End Select
            If isResponse Then
                Dim TotalDeudas As Double = 0
                Dim TotalPagado As Double = 0
                If Not IsNothing(dt) Then
                    For i = 0 To dt.Rows.Count - 1
                        TotalDeudas += dt.Rows(i)("val_Factura")
                        TotalPagado += dt.Rows(i)("Pagado")
                    Next
                End If
                txtSaldo.Text = Redondear(TotalDeudas - TotalPagado, 2)
                txtCreditoActual.Text = txtTotal.Text
                txtTotalDeuda.Text = Double.Parse(txtSaldo.Text) + Double.Parse(txtCreditoActual.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el Saldo_Proveedor " + Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ToolStripMenuCheque_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCheque.Click
        idFormaPago = sender.Tag
        Pinta_Menu(sender.name)
        Carga_Controles(paneCheque.Name)
        Carga_Propietarios()
    End Sub
    Private Sub Pinta_Menu(ByVal NameNemu As String)
        Try
            For i = 0 To MenuStrip1.Items.Count - 1
                If MenuStrip1.Items(i).Name = NameNemu Then
                    MenuStrip1.Items(i).BackColor = Color.Azure
                Else
                    MenuStrip1.Items(i).BackColor = MenuStrip1.BackColor
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ToolStripMenuCreditCar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCreditCar.Click
        'esta opcion aun no está abilitada
        paneCredito.Visible = False
        paneEfectivo.Visible = False
        paneCheque.Visible = False
        OK_Button.Enabled = False
    End Sub

    Private Sub txtPaga_ValueChanged(sender As Object, e As EventArgs) Handles txtPaga.ValueChanged
        If txtPaga.Value > 0 Then
            AcceptButton = OK_Button
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub Carga_Bancos(ByVal idPersona As Integer)
        cmbBanco.DataSource = Nothing
        Try
            sql = ""
            Select Case flag
                Case "Clientes"
                    sql = "select b.idBanco, b.nom_Banco from bancos as b "
                    sql = sql & "inner join BancosCuentas as bd on b.idBanco = bd.idBanco  "
                    sql = sql & "inner join personas as p on p.idPersona = bd.idPersona "
                    sql = sql & "where p.idPersona = " & idPersona & " "
                    sql = sql & "GROUP BY b.idBanco, b.nom_Banco "
                Case "Empleados"

                Case "Proveedores"

                Case "Compras"
                    sql = "select b.idBanco, b.nom_Banco from bancos as b "
                    sql = sql & "inner join BancosCuentas as bd on b.idBanco = bd.idBanco  "
                    sql = sql & "inner join personas as p on p.idPersona = bd.idPersona "
                    sql = sql & "where p.idPersona = " & idPersona & " "
                    sql = sql & "GROUP BY b.idBanco, b.nom_Banco "
            End Select
            If sql.Length > 0 Then
                Dim cmd As New ClassCargadorProducto()
                Dim dt As DataTable = cmd.RetornaTabla(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        cmbBanco.DataSource = dt
                        cmbBanco.ValueMember = "idBanco"
                        cmbBanco.DisplayMember = "nom_Banco"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Propietarios()
        cmbPropietario.DataSource = Nothing
        Try
            sql = ""
            Select Case flag
                Case "Clientes"
                    sql = "select p.idPersona , p.Ruc_Ci + ' ' + p.Apellidos +' '+p.Nombre  as [Titular] from Clientes  as c "
                    sql = sql & "inner join Personas as p on p.idPersona  = c.idPersona  "
                    sql = sql & "where c.idCliente = " & idcliente & " "
                Case "Empleados"

                Case "Proveedores"

                Case "Compras"
                    sql = "select p.idPersona, p.Ruc_Ci +' '+ p.Apellidos +' '+ p.Nombre as [Titular] from bodegas as b "
                    sql = sql & "inner join Empleados as e on b.Resp2_idEmpleado = e.idEmpleado "
                    sql = sql & "inner join personas as p on e.idPersona = p.idPersona "
            End Select
            If sql.Length > 0 Then
                Dim cmd As New ClassCargadorProducto()
                Dim dt As DataTable = cmd.RetornaTabla(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        cmbPropietario.DataSource = dt
                        cmbPropietario.ValueMember = "idPersona"
                        cmbPropietario.DisplayMember = "Titular"
                        If flag.Equals("Clientes") Then
                            If idcliente > 1 Then
                                cmbPropietario.Enabled = False
                            Else
                                MsgBox("Cliente no autorizado para este pago", MsgBoxStyle.Information, "Aviso")
                                ToolStripMenuEfectivo.PerformClick()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub paneCredito_Enter(sender As Object, e As EventArgs) Handles paneCredito.Enter
        AcceptButton = OK_Button

    End Sub

    Private Sub txtNumCheque_TextChanged(sender As Object, e As EventArgs) Handles Num_cheqTxt.TextChanged
        If Num_cheqTxt.TextLength > 0 Then
            AcceptButton = OK_Button
        Else
            AcceptButton = Nothing
        End If
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex >= 0 Then
            If cmbBanco.ValueMember.Length > 0 Then
                Carga_cuentas(cmbBanco.SelectedValue)
            End If
        Else
            cmbCuenta.DataSource = Nothing
        End If
    End Sub

    Private Sub Carga_cuentas(ByVal idBanco As Integer)

        Try
            If cmbPropietario.SelectedValue > 0 Then
                sql = "select bd.idBancoCuenta, bd.tipo_cuenta +' '+ bd.num_Cuenta as [Nom_cuenta] from BancosCuentas as bd "
                sql = sql & "inner join Personas as p on bd.idPersona = p.idPersona "
                sql = sql & "where p.idPersona =" & cmbPropietario.SelectedValue & " and bd.idBanco = " & idBanco & " "
                Dim cmd As New ClassCargadorProducto()
                Dim dt As DataTable = cmd.RetornaTabla(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        cmbCuenta.DataSource = dt
                        cmbCuenta.ValueMember = "idBancoCuenta"
                        cmbCuenta.DisplayMember = "Nom_cuenta"
                    End If
                End If
            Else
                MsgBox("No se pudo buscar cuentas", MsgBoxStyle.Information, "Importante")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbBanco_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbBanco.Validating, cmbPropietario.Validating
        If DirectCast(sender, ComboBox).SelectedIndex < 0 Then
            ErrorProvider1.SetError(sender, "Seleccione un banco")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub cmbCuenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbCuenta.Validating
        If DirectCast(sender, ComboBox).SelectedIndex < 0 Then
            ErrorProvider1.SetError(sender, "Seleccione una cuenta")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtNumCheque_Validated(sender As Object, e As EventArgs) Handles Num_cheqTxt.Validated
        If DirectCast(sender, TextBox).TextLength = 0 Then
            ErrorProvider1.SetError(sender, "Ingrese el número de cheque")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtValCheque_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, NumericUpDown).Value = 0 Then
            ErrorProvider1.SetError(sender, "Determine el valor de cheque")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        If cmbPropietario.SelectedValue > 0 Then
            Using newform As New frmAdd_Cuenta(stateOperation.Insert, 0,
                                 cmbPropietario.SelectedValue, 0, "", "",
                                 cmbPropietario.SelectedText)
                With newform
                    .ShowDialog()
                    Carga_Bancos(cmbPropietario.SelectedValue)
                End With
            End Using
        Else
            MsgBox("Seleccione en propieratario de la cuenta" + Name, MsgBoxStyle.Exclamation, "Información")
        End If
    End Sub

    Private Function Busca_IdPersona(ByVal TypoPersona As String) As Integer
        Try
            sql = ""
            Select Case TypoPersona
                Case "Clientes"
                    sql = "Select idPersona from Clientes where idCliente = " & idcliente & ""
                Case "Empleados"
                    sql = "Select idPersona from Empleados where idEmpleado = " & idcliente & ""
                Case "Compras"
                    sql = "select  e.idPersona ,  p.idPersona, p.Apellidos + ' ' + p.Nombre as [Nom_Empleado]from Empleados as e "
                    sql = sql & "inner join Bodegas  as b "
                    sql = sql & "on b.Resp2_idEmpleado = e.idEmpleado "
                    sql = sql & "inner join Personas  as p on p.idpersona = e.idPersona "
                    sql = sql & "where e.idEmpleado =" & idcliente & " "
            End Select

            If sql.Length > 0 Then
                Dim cmd As New ClassCargadorProducto()
                Dim dt As DataTable = cmd.RetornaTabla(sql)
                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        txtNom_Persona.Text = dt.Rows(0)("Nom_Empleado")
                        Return dt.Rows(0)("idPersona")
                    End If
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub cmbPropietario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPropietario.SelectedIndexChanged
        If cmbPropietario.SelectedIndex >= 0 Then
            If cmbPropietario.ValueMember.Length > 0 Then
                Carga_Bancos(cmbPropietario.SelectedValue)
            End If
        Else
            cmbCuenta.DataSource = Nothing
        End If
    End Sub

    Private Sub txtNumCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Num_cheqTxt.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
        'Ascii 
        '8  = Retroceso 
        '58 = dos Puntos Decimales 
        '46 = Punto Decimal 
    End Sub
    Private Function AutorizCredito(idcliente) As Boolean
        Try
            Return ClsClientes.isAurotizeCredit(idcliente)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class
