Imports System.Data.SqlClient
Imports ECommercePlatformView

Public Class MDI_AddProductos
#Region "Atributes"
    Private Ultimo_menu As String
    Private m_ChildFormNumber As Integer
    Private _operation As New stateOperation
    Private _id_Producto As Integer     ' el ID de producto
    Private _estado As Boolean          'es true todavia no se se fa finalizado el proceso de ingreso
    Private _id_seCompra As Integer     'ID que normalmente de compro
    Private _id_seVende As Integer      'ID en la  que normalmente se vende
    Private _id_Proveedor As Integer    'IP proveedor de de la que se viene
    Private _id_seVeEnBodega As Integer
    Private _nom_Comerial As String
    Private _idPresentacion As Integer  'ID de presentacion en la que se compra
    Private _idPresent_SeCompra As Integer

    Protected Friend Property Id_seCompra As Integer
        Get
            Return _id_seCompra
        End Get
        Set(value As Integer)
            _id_seCompra = value
        End Set
    End Property

    Protected Friend Property Id_seVende As Integer
        Get
            Return _id_seVende
        End Get
        Set(value As Integer)
            _id_seVende = value
        End Set
    End Property

    Protected Friend Property Id_Proveedor As Integer
        Get
            Return _id_Proveedor
        End Get
        Set(value As Integer)
            _id_Proveedor = value
        End Set
    End Property

    Protected Friend Property Id_seVeEnBodega As Integer
        Get
            Return _id_seVeEnBodega
        End Get
        Set(value As Integer)
            _id_seVeEnBodega = value
        End Set
    End Property

    Protected Friend Property Nom_Comerial As String
        Get
            Return _nom_Comerial
        End Get
        Set(value As String)
            _nom_Comerial = value
        End Set
    End Property

    Protected Friend Property IdPresentacion As Integer
        Get
            Return _idPresentacion
        End Get
        Set(value As Integer)
            _idPresentacion = value
        End Set
    End Property

    Protected Friend Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Protected Friend Property Id_Producto As Integer
        Get
            Return _id_Producto
        End Get
        Set(value As Integer)
            _id_Producto = value
        End Set
    End Property

    Protected Friend Property Operation As stateOperation
        Get
            Return _operation
        End Get
        Set(value As stateOperation)
            _operation = value
        End Set
    End Property

    Public Property IdPresent_SeCompra As Integer
        Get
            Return _idPresent_SeCompra
        End Get
        Set(value As Integer)
            _idPresent_SeCompra = value
        End Set
    End Property


#End Region

#Region "Constructor"
    Public Sub New(operation As stateOperation, idProducto As Integer, idProveedor As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Id_Producto = idProducto
        Me.Id_Proveedor = idProveedor
        Me.Operation = operation
    End Sub
    Private Sub MDI_AddProdcutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Me.Operation = stateOperation.Insert Then
                Id_Producto = 0
            End If
            If Id_Producto > 0 Then
                If Not ExisteProducto(Id_Producto) Then
                    Return
                End If
                OkButton.Enabled = False
            End If
            ControlMenu()
            If lblProdcutodesc.Text.Contains("Label") Then
                lblProdcutodesc.Text = String.Empty
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
        End Try
    End Sub

#End Region

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        Using newfor As New frmList_ProductoView()
            With newfor
                .flag = "Consulta"
                .StartPosition = FormStartPosition.CenterScreen
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .Height = 500
                .Width = 800
                .PanelAdmin.Visible = False
                .CancelButton = .btnCancelar
                .ShowDialog()
            End With
        End Using
    End Sub


    Private Sub menuDescription_Click(sender As Object, e As EventArgs) Handles menuDetalle.Click
        Dim myFormName As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmdetalla As New frm_detalle(Me, Me.Operation, Id_Producto, 1)
            myFormName = frmdetalla.Name
            If IsOpenMychildren(myFormName) Then
                myFormName = Nothing
                Return
            End If
            With frmdetalla
                myFormName = .Name
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                If Id_Producto > 0 Then
                    AtrasButton.Enabled = False
                    SiguienteButton.Enabled = True
                    CancelButon.Enabled = True
                ElseIf Id_Producto = 0 Then
                    AtrasButton.Enabled = False
                    SiguienteButton.Enabled = True
                    OkButton.Enabled = False
                    CancelButon.Enabled = True
                End If
                .Show()
                Pinta_Menu(sender.name)
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CierroIndesable(myFormName)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CierroIndesable(ByRef name As String)
        Try
            If String.IsNullOrEmpty(name) Then
                Return
            End If

            For i = 0 To Me.MdiChildren.Count - 1
                If Not IsNothing(MdiChildren(i)) Then
                    If Not MdiChildren(i).Name = name Then
                        MdiChildren(i).Close()
                    End If
                End If
            Next
        Catch ex As Exception
            If Not ex.HResult = -2146233080 Then
                MsgBox(ex.Message + " Al cerrar el MdiChildren", MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub
#Region "Methodos"
    Public Function ExisteProducto(idProducto As Integer) As Boolean
        Try
            sql = "Select top(1) p.idProducto, p.Deft_idPresenCompra  "
            sql = sql & "From [dbo].[Productos] as p Where p.idProducto = " & idProducto & " "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    'sql tomando el predefinido de compra
                    sql = "Select top(1) idPresentacion from  ProductoPresentacion "
                    sql = sql & " where idProducto = " & idProducto & " And idProUndMed = " & dt.Rows(0)("Deft_idPresenCompra") & " "
                    dt = cmd.RetornaTabla(sql)
                    If Not IsNothing(dt) Then
                        If dt.Rows.Count > 0 Then
                            Me.IdPresentacion = dt.Rows(0)("idPresentacion")
                            Return True
                        Else
                            MsgBox("No se a determinado la medida en la que se compra el producto [ID]: " & idProducto.ToString())
                        End If
                    Else
                        MsgBox("No se a determinado la medida en la que se compra el producto [ID]: " & idProducto.ToString())
                    End If
                    Return False
                Else
                    MsgBox("No se encontro el producto con [ID]: " & idProducto.ToString())
                End If
            Else
                MsgBox("No se encontro el producto con [ID]: " & idProducto.ToString())
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ControlMenu()
        If Operation = stateOperation.View And Id_Producto = 0 Then
            MsgBox("No se ha determinado los par'ametros necesarios", MsgBoxStyle.Exclamation, "Importante")
            Close()
            Return
        ElseIf Operation = stateOperation.View And Id_Producto > 0 Then
            Me.menuDetalle.PerformClick()
            Me.OkButton.Enabled = False
            Return
        ElseIf Operation = stateOperation.Insert And Id_Producto = 0 Then
            menuCategory.Enabled = False
            menuPresentacion.Enabled = False
            menuConfiguracion.Enabled = False
            menuProveedor.Enabled = False
            menuDetalle.PerformClick()
            Estado = True
            Return
        ElseIf Operation = stateOperation.Update And Id_Producto > 0 Then
            menuDetalle.Enabled = True
            menuCategory.Enabled = True
            menuPresentacion.Enabled = True
            menuConfiguracion.Enabled = True
            menuProveedor.Enabled = True
            menuDetalle.PerformClick()
            AtrasButton.Visible = False
            SiguienteButton.Visible = False
            OkButton.Enabled = False
        End If
    End Sub

#End Region

    Private Sub Pinta_Menu(ByVal NameNemu As String)
        Try
            For i = 0 To MenuStrip1.Items.Count - 1
                If MenuStrip1.Items(i).Name = NameNemu Then
                    MenuStrip1.Items(i).BackColor = Color.Aquamarine
                    Ultimo_menu = NameNemu
                Else
                    MenuStrip1.Items(i).BackColor = MenuStrip1.BackColor
                    If Me.lblProdcutodesc.Text.Contains("Agregando") Then
                        MenuStrip1.Items(i).Enabled = False
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub menuCategory_Click(sender As Object, e As EventArgs) Handles menuCategory.Click
        Dim myFormName As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmCategoria As New frm_Categoria(Me)
            myFormName = frmCategoria.Name
            If IsOpenMychildren(myFormName) Then
                frmCategoria = Nothing
                Return
            End If
            With frmCategoria
                .MdiParent = Me
                .id_producto = Id_Producto
                .WindowState = FormWindowState.Maximized
                If Estado Then
                    menuDetalle.Enabled = False
                    AtrasButton.Enabled = True
                    SiguienteButton.Enabled = True
                    OkButton.Enabled = False
                Else
                    SiguienteButton.Visible = False
                End If
                .Show()
                Pinta_Menu(sender.name)
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CierroIndesable(myFormName)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Function IsOpenMychildren(myNameforms) As Boolean
        Try
            For i = 0 To Me.MdiChildren.Count - 1
                If MdiChildren(i).Name = myNameforms Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub menuPresentacion_Click(sender As Object, e As EventArgs) Handles menuPresentacion.Click
        Dim myFormName As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmPresentacion As New frm_Presentacion(Me)
            myFormName = frmPresentacion.Name
            If IsOpenMychildren(myFormName) Then
                frmPresentacion = Nothing
                Return
            End If
            With frmPresentacion
                myFormName = .Name
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
                Pinta_Menu(sender.name)
                SiguienteButton.Enabled = True
                OkButton.Enabled = False
                If Not Estado Then
                    SiguienteButton.Visible = False
                End If
                If Me.lblProdcutodesc.Text.Contains("Agregando") Then
                    SiguienteButton.Text = "Siguiente=>"
                End If
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CierroIndesable(myFormName)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles CancelButon.Click
        MyBase.Close()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If Ok_Dialogo() Then
            Estado = False
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function Ok_Dialogo() As Boolean
        If Estado Then
            If Id_Producto > 0 And Id_Proveedor > 0 And Id_seCompra > 0 And Id_seVende > 0 Then
                Return True
            Else
                MsgBox(msgFalta, MsgBoxStyle.Information, "Aviso")
            End If
        Else
            Return True
        End If
        Return False
    End Function



    Private Sub MDI_AddProdcutos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Estado Then
            If Id_Producto > 0 Then
                If MsgBox("Está seguro de salir sin guardar ésta información", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    If Elimina_Producto(Id_Producto) Then
                        Id_Producto = 0
                        Close()
                    End If
                    Me.Cursor = Cursors.Default
                Else
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub menuProveedor_Click(sender As Object, e As EventArgs) Handles menuProveedor.Click
        Dim myFormName As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmProveedor As New frm_Proveedor(Me)
            myFormName = frmProveedor.Name
            If IsOpenMychildren(myFormName) Then
                frmProveedor = Nothing
                Return
            End If
            With frmProveedor
                .MdiParent = Me
                .id_producto = Id_Producto
                .WindowState = FormWindowState.Maximized
                .Show()
                Pinta_Menu(sender.name)
                SiguienteButton.Enabled = False
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CierroIndesable(myFormName)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub SiguienteButton_Click(sender As Object, e As EventArgs) Handles SiguienteButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If MdiChildren.Count > 0 Then
                Dim bottoonmy As Button
                Select Case MdiChildren(0).Name
                    Case "frm_detalle"
                        If Id_Producto > 0 Then
                            bottoonmy = MdiChildren(0).Controls("SaveButton")
                            bottoonmy.Enabled = True
                        Else
                            bottoonmy = MdiChildren(0).Controls("SigienteButton")
                        End If
                        bottoonmy.PerformClick()
                        If Me.lblProdcutodesc.Text.Contains("Agregando") Then
                            menuCategory.Enabled = True
                            menuCategory.PerformClick()
                        End If
                    Case "frm_Categoria"
                        If Estado Then
                            bottoonmy = MdiChildren(0).Controls("SiguientButton")
                            bottoonmy.PerformClick()
                            menuCategory.Enabled = False
                            menuPresentacion.Enabled = True
                            menuPresentacion.PerformClick()
                        Else
                            bottoonmy = MdiChildren(0).Controls("SaveButton")
                            bottoonmy.PerformClick()
                        End If
                    Case "frm_Presentacion"
                        If Estado Then
                            bottoonmy = MdiChildren(0).Controls("SiguientButton")
                            bottoonmy.PerformClick()
                            If (bottoonmy.Tag = 0) Then 'si no se ha determinado las fomas mas usuales de compra y venta
                                Return
                            End If
                        Else
                            bottoonmy = MdiChildren(0).Controls("SaveButton")
                            bottoonmy.PerformClick()
                        End If
                    Case "frmConfiguracion"
                        If Estado Then
                            bottoonmy = MdiChildren(0).Controls("SiguientButton")
                            bottoonmy.PerformClick()
                            If (bottoonmy.Tag = 0) Then 'si no se ha determinado las fomas mas usuales de compra y venta
                                Return
                            End If
                            menuPresentacion.Enabled = False
                            menuProveedor.Enabled = True
                            menuProveedor.PerformClick()
                        Else
                            bottoonmy = MdiChildren(0).Controls("SaveButton")
                            bottoonmy.PerformClick()
                            If bottoonmy.Tag = 1 Then
                                MsgBox("Modificado correctamente", MsgBoxStyle.Information, "Aviso")
                                Me.SiguienteButton.Enabled = False
                                Me.OkButton.Enabled = True
                            End If
                        End If
                    Case "frm_Presentacion"
                End Select
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AtrasButton_Click(sender As Object, e As EventArgs) Handles AtrasButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If MdiChildren.Count > 0 Then
                OkButton.Enabled = False
                Select Case MdiChildren(0).Name
                    Case "frm_Categoria"
                        menuDetalle.Enabled = True
                        menuDetalle.PerformClick()
                        menuCategory.Enabled = False
                    Case "frm_Presentacion"
                        menuCategory.Enabled = True
                        menuCategory.PerformClick()
                        menuPresentacion.Enabled = False
                    Case "frmConfiguracion"
                        menuPresentacion.Enabled = True
                        menuPresentacion.PerformClick()
                        menuConfiguracion.Enabled = False
                    Case "frm_Proveedor"
                        menuConfiguracion.Enabled = True
                        menuConfiguracion.PerformClick()
                        menuProveedor.Enabled = False
                End Select
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub MDI_AddProdcutos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Me.Cursor = Cursors.WaitCursor
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand("[dbo].[prcDeleteProducMalEnter]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub menuConfiguracion_Click(sender As Object, e As EventArgs) Handles menuConfiguracion.Click
        Dim myFormName As String = String.Empty
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmConfiguracion As New frmConfiguracion(Me)
            myFormName = frmConfiguracion.Name
            If IsOpenMychildren(myFormName) Then
                frmConfiguracion = Nothing
                Return
            End If
            With frmConfiguracion
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
                Pinta_Menu(sender.name)

                If Me.Id_seCompra > 0 And Me.Id_seVende > 0 Then
                    SiguienteButton.Enabled = True
                Else
                    SiguienteButton.Enabled = False
                    OkButton.Enabled = False
                End If
                If Not Estado Then
                    SiguienteButton.Visible = False
                End If
            End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CierroIndesable(myFormName)
            Me.Cursor = Cursors.Default
        End Try

    End Sub
End Class
