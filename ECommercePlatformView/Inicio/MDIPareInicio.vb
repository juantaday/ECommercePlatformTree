Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Public Class MDIPareInicio
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        CloseAllWindows()
    End Sub
    Private Sub CloseAllWindows()
        Try
            ' Cierre todos los formularios secundarios del principal.
            For Each ChildForm As Form In Me.MdiChildren
                If Not ChildForm.Name.Equals("frmPanel") Then
                    ChildForm.Close()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private m_ChildFormNumber As Integer
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            System.Windows.Forms.Application.EnableVisualStyles()
            If IsNothing(ListPanelAccessPermissions) Then
                GetInformationServices.AccessPanel.GetListNenuAccess(True)
            End If
            If TerminalActivo.idTerminal = 0 Then
                GetInformationServices.GeneralInformation.Inicia_Terminal(True)
            End If
            DatosUsuario()
            Hide_PagesOpenView()

            Me.paneMuestra.Visible = False
            Dim located As Point
            located.Y = 0
            located.X = 0
            Dim formnew As New frmPanel()
            With formnew
                .MdiParent = Me
                .Width = Me.paneMuestra.Width
                .Height = Me.paneMuestra.Height
                .Location = located
                .Show()
            End With

            StatusLabelUsuario.Text = String.Format("USER:{0} {1} ,TERMINAL: {2}, EQUIPO:[{3}]  DataSource:[{4}]", UsuarioActivo.Apellido, UsuarioActivo.Nombre, TerminalActivo.codTerminal, Dominio._HotName, UsuarioActivo.DataSource)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical & " " & ex.StackTrace.ToString, "Error")
            Me.Close()
        End Try
    End Sub

    Private Sub DatosUsuario()
        Try
            Try
                For Each MenuPrincipal As ToolStripMenuItem In MenuStrip1.Items
                    'MenuPrincipal.Name.Contains 
                    MenuPrincipal.Enabled = ActivarMenu(MenuPrincipal.Name, "MenuStripName")
                    For Each SubMenu In MenuPrincipal.DropDownItems
                        If Not (SubMenu.Name.Contains("ToolStripSeparator")) Then
                            SubMenu.Enabled = ActivarMenu(SubMenu.Name, "DropDownName")
                            If SubMenu.Text = "Entrar" Or SubMenu.Text = "Salir" Or SubMenu.Text = "Cambiar de Usuario" Then
                                SubMenu.Enabled = True
                            End If
                        End If
                    Next
                    If MenuPrincipal.Text = "Inicio" Then
                        MenuPrincipal.Enabled = True
                    End If
                Next
                Return
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub ProcesarSesion()
        Try
            Dim Forms() As Form
            Forms = Me.MdiChildren

            For Each form As Form In Forms
                If Not form.Name.ToString.Equals("frmPanel") Then
                    form.Close()
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            CambiarDeUsuarioToolStripMenuItem.Text = "Entrar"
            StatusLabelUsuario.Text = "No hay sesión activa"
            Using modalFormLogin As New LoginForm
                modalFormLogin.ShowDialog()
                If Not (modalFormLogin.DialogResult = DialogResult.OK) Then
                    DatosUsuario()
                End If
                'inicializa the informacion
                GetInformationServices.GeneralInformation.Inicia_Terminal(True)
                GetInformationServices.AccessPanel.GetListNenuAccess(True)

                CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario"
                StatusLabelUsuario.Text = String.Format("USER:{0} {1} ,TERMINAL: {2}, EQUIPO:[{3}]  DataSource:[{4}]", UsuarioActivo.Apellido, UsuarioActivo.Nombre, TerminalActivo.codTerminal, Dominio._HotName, UsuarioActivo.DataSource)


                Dim hos As String = Dns.GetHostName()
                If Not hos.Equals(Dominio._HotName) Then
                    GetInformationServices.GeneralInformation.Carga_DominioMaquina()
                    If Not (IsNothing(Dominio)) And (Not String.IsNullOrEmpty(Dominio._HotName)) Then
                        Me.Close()
                    End If
                End If

                DatosUsuario()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ActivarMenu(ByVal NameMenu As String, ByVal NameCampo As String) As Boolean
        Try
            If IsNothing(ListPanelAccessPermissions) Then
                Return False
            End If

            Select Case NameCampo
                Case "MenuStripName"
                    Return Not IsNothing(ListPanelAccessPermissions.Where(Function(x) x.MenuStripName = NameMenu And x.Login = UsuarioActivo.codUser).ToList.FirstOrDefault())
                Case "DropDownName"
                    Return Not IsNothing(ListPanelAccessPermissions.Where(Function(x) x.DropDownName = NameMenu And x.Login = UsuarioActivo.codUser).ToList.FirstOrDefault())
                Case Else
                    Return False
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub CambiarDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeUsuarioToolStripMenuItem.Click
        Try
            If CambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario" Then
                If MsgBox("Confirma Cambiar de Usuario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                    ProcesarSesion()
                Else
                    ProcesarSesion()
                End If
            ElseIf CambiarDeUsuarioToolStripMenuItem.Text = "Entrar" Then
                ProcesarSesion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem2.Click
        Me.Close()
    End Sub


    Private Sub OrdenCompraNew_Click(sender As Object, e As EventArgs) Handles OrdenCompraNew.Click
        Try
            Cursor = Cursors.WaitCursor
            Dim inicia As Boolean = False
            With frmAdquisicion
                If .Register_inTerminal() = True Then
                    inicia = True
                    .FechaPedidoDatatime.Value = Now
                    .txtFalg.Text = 1
                    .MdiParent = Me
                    .WindowState = FormWindowState.Maximized
                    .Show()
                End If
            End With
            If inicia = False Then
                frmAdquisicion = Nothing
            End If
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub OrdenDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeTrabajoToolStripMenuItem.Click
        Try
            MsgBox("Disponible en la próxima versión..", MsgBoxStyle.Exclamation, "Ups...")
            Return



            Dim idDeclaracion As Integer
            Dim idConsumo As Integer
            'determinamos lass declaraciones posible------
            Using newform = New frmImput_Consumo()
                With newform
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        idDeclaracion = .DeclaracionComboBox.SelectedValue
                        idConsumo = .ConsumoComboBox.SelectedValue
                    Else
                        Return
                    End If
                End With
            End Using
            'Abrimos el formulario con las declaraciones establecidas
            Using newform = New frmAdquisicion
                With newform
                    .iniciado = frmAdquisicion.state.gasto_Personal
                    .Carga_Declaracion()
                    .cmbDeclaracion.SelectedValue = idDeclaracion
                    .Carga_Tipo_Consumo()
                    .cmbItmTipconsumo.SelectedValue = idConsumo
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub OrdenDeEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenCompraToolStripMenuItem.Click
        Try
            Using newPesido As New frmListPedido()
                With newPesido
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ListadoDeOrdenesDeEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoListToolStripMenuItem.Click
        Try
            Dim listEmployee = New frmList_Empleados(stateClient.Cliente)
            With listEmployee
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ListadoDeOrdenesDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClinetListToolStripMenuItem.Click
        Try
            Dim listClient As New frmList_clientes(stateClient.User)
            With listClient
                .txtFlag = "Listado"
                .MdiParent = Me
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorListToolStripMenuItem.Click
        Try
            Using frmNew As New frmList_Proveedores(stateLoad.List, stateClient.Cliente)
                With frmNew
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DiariaPorCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiariaPorCajaToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            GetInformationServices.GeneralInformation.Inicia_Terminal(True)
            Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
            If myTerminalActivo.Success Then
                Dim responIsHabil As ResponseTerminal = Carga_idCajaStado(myTerminalActivo.DataDb)
                If responIsHabil.Success Then
                    Dim frmVentaNew = New frmVentas
                    With frmVentaNew
                        .MdiParent = Me
                        .Show()
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
            End If
            myTerminalActivo = Nothing
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub OrdenDeVentaNoFacturadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeVentaNoFacturadaToolStripMenuItem.Click
        Try
            Using frmList_OrdenVenta
                With frmList_OrdenVenta
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PreciosDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosDeVentasToolStripMenuItem.Click
        Try
            Using fraVentas As New frmList_ProductPrecioVenta
                With fraVentas
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Try
            Using frmUsuarios
                With frmUsuarios
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PermisosDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosDeUsuarioToolStripMenuItem.Click
        Try
            With frmPermisos
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RespaldarBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespaldarBaseDeDatosToolStripMenuItem.Click
        Try
            Using frmbackup_Base
                frmbackup_Base.StartPosition = FormStartPosition.CenterParent
                frmbackup_Base.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

        Try
            Using AboutBox
                AboutBox.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ImpresoraDeTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresonaTicketToolStripMenuItem.Click
        Try
            Using frm As New frmOptionPrint
                With frm
                    .StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AsignacionBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionBodegaToolStripMenuItem.Click
        Using Form As New frmBodegas
            Form.ShowDialog()
        End Using
    End Sub

    Private Sub RegistrarEsteEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEsteEquipoToolStripMenuItem.Click
        Try
            Dim r As Boolean = False
            Using Form As New frmRegistroEquipo
                With Form
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        r = True
                    End If
                End With
            End Using
            If r Then
                Me.notificacion.Visible = True
                Me.notificacion.ShowBalloonTip(2000, "Aviso", "Modificación exitosa", ToolTipIcon.Info)
                Me.notificacion.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub CuentasPorCobrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasPorCobrarToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim listClientCobro As New frmList_CuentasXcobrar()
            With listClientCobro
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CuentasPoPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasPoPagarToolStripMenuItem.Click
        Try
            Using newform As New frmList_DeudaProveedor()
                With newform
                    .StartPosition = FormStartPosition.CenterScreen
                    .FormBorderStyle = FormBorderStyle.Sizable
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ContagtoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContagtoToolStripMenuItem.Click
        Using ContagFrm
            ContagFrm.ShowDialog()
        End Using
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        Try
            Using Form As New frmList_Facturas()
                With Form
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SelectToolStripMenuItem_Click(e As ToolStripDropDownItem)
        Try
            Hide_PagesOpenView()
            Dim i As Integer = 0
            Dim index As Integer = 1
            Dim ActiveIndex As Integer = 1
            For Each desactive In Me.MdiChildren
                desactive.Tag = Nothing
            Next

            If Me.MdiChildren.Count > 0 Then
                Dim j As Integer = 0
                Me.ActiveMdiChild.Tag = 1

                For Each ActivateIndex In Me.MdiChildren
                    If Not (ActivateIndex.Tag Is Nothing) Then
                        ActiveIndex = j
                        Exit For
                    End If
                    j += 1
                Next
            End If

            For Each SubMenu In e.DropDownItems
                If i > 6 Then
                    If Not (MenuBarr.Items(i).Name.Contains("ToolStripSeparator")) Then
                        MenuBarr.Items(i).ForeColor = Color.Black
                        MenuBarr.Items(i).Name = "i" & SubMenu.Name
                        MenuBarr.Items(i).Text = SubMenu.Text
                        MenuBarr.Items(i).ToolTipText = SubMenu.Text
                        MenuBarr.Items(i).ImageScaling = SubMenu.ImageScaling
                        MenuBarr.Items(i).Image = SubMenu.Image
                        MenuBarr.Items(i).Visible = True
                        MenuBarr.Items(i).Enabled = SubMenu.Enabled
                        MenuBarr.Items(i).Tag = index
                        If ActiveIndex = index Then
                            MenuBarr.Items(i).ForeColor = Color.White
                            MenuBarr.Items(i).BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(139, Byte), Integer))
                        End If
                        index += 1
                    End If
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Hide_PagesOpenView()
        Try
            For m = 0 To MenuBarr.Items.Count - 1
                MenuBarr.Items(m).Visible = False
                MenuBarr.Items(m).BackColor = MenuBarr.BackColor
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MenuBarr_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuBarr.ItemClicked
        Try
            If Not (e.ClickedItem.Tag Is Nothing) Then
                Dim index As Integer = e.ClickedItem.Tag
                Me.MdiChildren(index).Select()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub ReporteDeVentasPorCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasPorCajaToolStripMenuItem.Click
        Try
            Dim detailCaja As New FrmVentaXcaja()
            With detailCaja
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub

    Private Sub ReporteDeVentasPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasPorClienteToolStripMenuItem.Click
        Try
            Dim detaicliente As New FrmVentaXcliente()
            With detaicliente
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub
    Private Sub ReporteDeVentasPorProdcutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasPorProdcutoToolStripMenuItem.Click
        Try
            Dim detaiproduct As New FrmVentaXProducto()
            With detaiproduct
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub
    Private Sub PorEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorEmpleadoToolStripMenuItem.Click
        Try
            Dim detailEmpledo As New FrmVentaXEmpleado()
            With detailEmpledo
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub

    Private Sub PorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorProveedorToolStripMenuItem.Click
        Try
            Dim detaiproductProvider As New FrmFacturCompProvider(0, viewLoadReport.All)
            With detaiproductProvider
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub
    Private Sub PorProdcutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorProdcutoToolStripMenuItem.Click
        Try
            Dim detaiproductProduc As New FrmFacturCompProducto()
            With detaiproductProduc
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub

    Private Sub PorDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorDocumentoToolStripMenuItem.Click
        Try
            Dim factCompraTypeCocument As New FrmFacturCompTypoDocument()
            With factCompraTypeCocument
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
        End Try
    End Sub
    Private Function WhatIsMyIP() As String

        Dim WhatIsMyIPUrl As String = "http://checkip.dyndns.org/"
        Dim req As HttpWebRequest
        Dim res As HttpWebResponse
        Dim Stream As IO.Stream
        Dim PublicIP As String = String.Empty
        Dim sr As StreamReader

        Try
            req = WebRequest.Create(WhatIsMyIPUrl)
            res = req.GetResponse()
            Stream = res.GetResponseStream()
            sr = New StreamReader(Stream)
            PublicIP = sr.ReadToEnd()
            PublicIP = PublicIP.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").ToString()
            sr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return PublicIP
    End Function
    Private Sub CambiarDeContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDeContraseñaToolStripMenuItem.Click
        Try
            Dim dta As New getInicio
            dta.GUsuario = UsuarioActivo.codUser
            Using newChangePassword As New frmChangePassword(frmChangePassword.stateOperation.changePassword, dta)
                With newChangePassword
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RegistrarEnUnaEstaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEnUnaEstaciónToolStripMenuItem.Click
        Try
            Using newOpera As New frm_registerInTerminal
                With newOpera
                    .Operation = _operation.Insert
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        GetInformationServices.GeneralInformation.Inicia_Terminal(True)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub StockDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDeProductosToolStripMenuItem.Click
        Try
            Dim stocProductos As New frmInventoriesExplorer()
            With stocProductos
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub ArqueoDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArqueoDeCajaToolStripMenuItem.Click
        Try
            Dim idCajastado As Integer = 0
            Dim myTerminalActivo As ResponseTerminal = isTerminalHabil(UsuarioActivo.codUser, TerminalActivo.codTerminal)
            If myTerminalActivo.Success Then
                Dim myidCajaStado As ResponseTerminal
                myidCajaStado = Carga_idCajaStado(myTerminalActivo.DataDb)
                If Not myidCajaStado.Success Then
                    Return
                End If
                idCajastado = myidCajaStado.IdStadoCaja
                myidCajaStado = Nothing
            End If

            Using mycaja As New MDIcajas(idCajastado, viewLoadReport.Select_)
                With mycaja
                    .ShowDialog()
                End With
            End Using
            myTerminalActivo = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            Cursor = Cursors.WaitCursor
            Clipboard.Clear()
            Dim i As Integer
            Dim List As New ListView
            Dim buffer As New System.Text.StringBuilder
            Dim datagrid As New DataGridView
            Dim comboBox As New ComboBox

            For i = 0 To MdiChildren.Count - 1
                If Not (MdiChildren(i).Name.ToString.Equals("frmPanel")) Then
                    If MdiChildren(i).ContainsFocus Then
                        If TypeOf (MdiChildren(i).ActiveControl) Is TextBox Or TypeOf (MdiChildren(i).ActiveControl) Is ComboBox Then
                            My.Computer.Clipboard.SetText(MdiChildren _
                           (i).ActiveControl.Text)
                            GoTo Salida
                        ElseIf TypeOf (MdiChildren(i).ActiveControl) _
                      Is ListView Then
                            List = MdiChildren(i).ActiveControl
                            GoTo Carga_Listview
                        ElseIf TypeOf (MdiChildren(i).ActiveControl) _
                    Is DataGridView Then
                            datagrid = MdiChildren(i).ActiveControl
                            GoTo Carga_DataGrid
                        End If
                    End If
                End If
            Next
            GoTo Salida

Carga_Listview:
            For c = 0 To List.Columns.Count - 1
                buffer.Append(List.Columns(c).Text)
                buffer.Append(vbTab)
            Next
            buffer.Append(vbNewLine)
            For i = 0 To List.Items.Count - 1
                For Col = 0 To List.Columns.Count - 1
                    buffer.Append(List.Items(i).SubItems(Col).Text)
                    buffer.Append(vbTab)
                Next
                buffer.Append(vbNewLine)
            Next
            Clipboard.SetText(buffer.ToString())
            GoTo Salida
Carga_DataGrid:

            For c = 0 To datagrid.Columns.Count - 1
                buffer.Append(datagrid.Columns(c).HeaderText)
                buffer.Append(vbTab)
            Next
            buffer.Append(vbNewLine)
            For i = 0 To datagrid.Rows.Count - 1
                For Col = 0 To datagrid.Columns.Count - 1
                    buffer.Append(datagrid.Rows(i).Cells(Col).Value)
                    buffer.Append(vbTab)
                Next
                buffer.Append(vbNewLine)
            Next
            Clipboard.SetText(buffer.ToString())
            GoTo Salida
Salida:
            Cursor = Cursors.Default
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub PasteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Try
            Dim data As New Object
            data = My.Computer.Clipboard.GetText()
            sql = My.Computer.Clipboard.GetText()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub WindowsMenu_Paint(sender As Object, e As PaintEventArgs) Handles WindowsMenu.Paint
        If WindowsMenu.HasDropDownItems Then
            SelectToolStripMenuItem_Click(sender)
        End If
    End Sub
    Private Sub ContadorBillteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadorBillteToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Using forcontador As New frmAdminMoney
                With forcontador
                    .AcceptButton = Nothing
                    .ShowDialog()
                End With
            End Using
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Try
            Dim Form = New frmList_ProductoView
            With Form
                .flag = 2
                .MdiParent = Me
                .Show()
                .BringToFront()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MDIPareInicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'CierraUserActivo()
    End Sub
    Private Function CierraUserActivo() As Boolean
        Try
            Using cierrra As New FunInicio
                Return cierrra.CierraSecion(UsuarioActivo.codUser)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Sub EstadoDeTerminalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDeTerminalesToolStripMenuItem.Click
        Try
            Using mycaja As New MDIcajas(0, viewLoadReport.All)
                With mycaja
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        Try
            Dim NewListProdcut = New frmList_ProductoView
            With NewListProdcut
                .flag = 2
                .MdiParent = Me
                .Show()
                .BringToFront()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Try
            Dim stocProductos As New frmInventoriesExplorer()
            With stocProductos
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PrecioDeVentaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrecioDeVentaDeProductosToolStripMenuItem.Click
        Try
            Dim Formnew = New frmAdministrarPrecios(stateLoad.List)
            With Formnew
                .MdiParent = Me
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MontoDeCreditoParaClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontoDeCreditoParaClientesToolStripMenuItem.Click
        Try
            Dim Neworm As New frmList_clientes(stateClient.Admin)
            With Neworm
                .MdiParent = Me
                .txtFlag = "Creditos"
                .WindowState = FormWindowState.Maximized
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TarifasDescuentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifasDescuentosToolStripMenuItem.Click
        Try
            Dim rates As New frmList_RatesDiscount
            With rates
                .MdiParent = Me
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub AplicarTarifasParaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicarTarifasParaClienteToolStripMenuItem.Click
        Try
            Me.MenuBarr.Visible = False
            Dim rates As New FrmList_ClientRates
            With rates
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub NumeracionDeFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeracionDeFacturaToolStripMenuItem.Click
        Try
            Using frmconfig As New frmConfFactura
                With frmconfig
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MiEmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MiEmpresaToolStripMenuItem1.Click
        Try
            Using newmyCommerce As New frmMyCommerce
                newmyCommerce.StartPosition = FormStartPosition.CenterScreen
                newmyCommerce.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BalanceToolStripMenuItem.Click
        Try
            Using balance As New frmBalanceGeneral
                With balance
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "" & ex.StackTrace.ToString(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub paneMuestra_Paint(sender As Object, e As PaintEventArgs) Handles paneMuestra.Paint

    End Sub

    Private Sub AdministrarEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarEmpleadosToolStripMenuItem.Click
        Try
            Dim listEmployee = New frmList_Empleados(stateClient.Admin)
            With listEmployee
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PersonListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonListToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Using newListPerson As New frmList_PersonViewDetail(stateClient.Admin)
                With newListPerson
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub EtiquetasCodigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EtiquetasCodigosToolStripMenuItem.Click
        Try
            Using newView As New frmViewBarcodeList()
                With newView
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MisLetreritosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MisLetreritosToolStripMenuItem.Click
        Try
            Using newView As New FrmViewSalesSing()
                With newView
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SystemManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingDocumentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingDocumentsToolStripMenuItem.Click
        Try
            Using confi As New frmSettingDocuments(stateClient.Cliente, TerminalActivo.idBodega)
                With confi
                    .ShowDialog()

                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OrdenesDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesDeCompraToolStripMenuItem.Click
        Try
            Dim listPurcharse As New frmListFacturPurchases()
            With listPurcharse
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub P_CompuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles P_CompuestoToolStripMenuItem.Click
        Try
            Dim listPurcharse As New frmProductConbined
            With listPurcharse
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
