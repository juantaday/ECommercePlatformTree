Imports System.Data.SqlClient
Imports CADsisVenta

Public Class frmList_clientes
    Protected Friend txtFlag As String
    Protected Friend idPersona As Integer
    Private idCliente As Integer
    Private stateClient As stateClient
    Private listClient As List(Of ItemPerson)
    Sub New(stateClient As stateClient)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateClient = stateClient
    End Sub
    Private Sub frmList_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listClient = New List(Of ItemPerson)
        Load_ListClientes()
        PersonalizeGridView()
    End Sub

    Private Sub FindTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FindTextBox.KeyDown
        FindButton.Tag = 0
        If e.KeyCode = Keys.Enter Then
            FindButton.Tag = 1
        End If
    End Sub

    Private Sub FindTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FindTextBox.KeyPress
        If FindButton.Tag = 1 Then
            e.Handled = True
            FindButton.PerformClick()
        End If
    End Sub

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        If FindTextBox.Text.Length > 2 Then
            FindButton.Enabled = True
            Me.AcceptButton = FindButton
        Else
            FindButton.Enabled = False
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Sub ViewAddNew(ByVal _idPersona As Integer)
        Try
            Load_ListClientes()
            Dim Viewlis = New List(Of ItemPerson)
            If dtg.RowCount > 0 Then
                Viewlis = dtg.DataSource
            End If

            Using db As New DataContext
                Dim list = From c In db.Clientes
                           Join p In db.Personas On p.idPersona Equals c.idPersona
                           Where p.idPersona = _idPersona
                           Select p.idPersona, c.idCliente, idEmployee = 0, p.Apellidos,
                           p.Nombre, p.Ruc_Ci, p.Direccion, p.telefono, p.mail, c.monto_Max


                For Each item In list
                    Viewlis.Add(New ItemPerson(item.idPersona,
                                                    item.idCliente,
                                                    item.idEmployee,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    0,
                                                    String.Empty,
                                                    0,
                                                    item.monto_Max))
                Next
            End Using

            If Viewlis.Count > 0 Then
                listClient.AddRange(Viewlis)
                ViewList(Viewlis)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub Load_ListClientes()
        Try
            listClient.Clear()
            Using db As New DataContext

                Dim list = From c In db.Clientes
                           Join p In db.Personas On p.idPersona Equals c.idPersona
                           Where p.Ruc_Ci <> "9999999999"
                           Select p.idPersona, c.idCliente, idEmployee = 0, p.Apellidos,
                           p.Nombre, p.Ruc_Ci, p.Direccion, p.telefono, p.mail, c.monto_Max

                For Each item In list
                    listClient.Add(New ItemPerson(item.idPersona,
                                                    item.idCliente,
                                                    item.idEmployee,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    0,
                                                    String.Empty,
                                                  _genero:=False,
                                                  montoMax:=item.monto_Max))
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim ItemViewList As New List(Of ItemPerson)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim _response As New ResponseSpliter
            _response = GenerateSpliter(FindTextBox.Text) 'conbierte el texto en matriz
            If _response.IsSucces = True And _response.IsNumeric = True Then  'si es nurico
                ItemViewList = Me.listClient.Where(Function(x) x.Ruc_Ci.Contains(_response.Spliter(0))).ToList()
            ElseIf _response.IsSucces = True Then 'si es por nombre del producto...
                ItemViewList =
                    FindClienWithParameters(_response.Spliter(), _response.Spliter.Count)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            ViewList(ItemViewList)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ViewList(ByVal itemList As List(Of ItemPerson), Optional DoNotOrder As Boolean = False)
        Try
            Me.dtg.DataSource = Nothing
            If DoNotOrder Then
                Me.dtg.DataSource = itemList.ToList
            Else
                Me.dtg.DataSource = itemList.OrderBy(Function(x) x.FullName).ToList()
            End If

            applyGridTheme(dtg)
            For Each column As DataGridViewColumn In dtg.Columns
                column.Visible = False
            Next
            clm = dtg.Columns("Ruc_Ci")
            clm.Visible = True
            clm.HeaderText = "Ruc (o) C.I."
            clm.DisplayIndex = 1

            clm = dtg.Columns("FullName")
            clm.Visible = True
            clm.HeaderText = "Cliente"

            clm = dtg.Columns("Telefono") 'Télefono
            clm.Visible = True
            clm.HeaderText = "Télefono"

            clm = dtg.Columns("mail")
            clm.Visible = True
            clm.HeaderText = "E-mail"

            clm = dtg.Columns("Monto_Max")
            clm.Visible = True
            clm.HeaderText = "Monto máximo crédito"
            clm.DefaultCellStyle = myStileMoney

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            Me.TotalListLabel.Text = "Total : " & itemList.Count.ToString()
        End Try
    End Sub
    Private Function FindClienWithParameters(ByVal _Spliter As String(), v4 As Integer) As List(Of ItemPerson)
        Try
            Dim list1 As New List(Of ItemPerson)
            Dim list2 As New List(Of ItemPerson)
            Dim list3 As New List(Of ItemPerson)
            Dim listResult As New List(Of ItemPerson)
            Dim v1 As String, v2 As String, v3 As String

            Select Case v4
                Case 1
                    v1 = _Spliter(0)
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    listResult = list1
                Case 2
                    v1 = _Spliter(0)
                    v2 = _Spliter(1)
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    listResult = list2
                Case 3
                    v1 = _Spliter(0)
                    v2 = _Spliter(1)
                    v3 = _Spliter(2)
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    list3 = list2.Where(Function(x) x.FullName.ToUpper().Contains(v3.ToUpper())).ToList()
                    listResult = list3
            End Select

            Return listResult.ToList()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Return New List(Of ItemPerson)
        End Try
    End Function

    Private Sub FindClienWithCedula(myFindText As String)
        Try
            dtg.DataSource = Nothing
            dtg.DataSource = listClient.Where(Function(x) x.Ruc_Ci.Contains(myFindText)).ToList()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = True
            applyGridTheme(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub VisibleCabecera(ByVal Visible As Boolean)
        btnEditarCliente.Visible = Visible
        btnEliminarCliente.Visible = Visible
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg.CellDoubleClick
        If Me.txtFlag = "Lote" Then

        ElseIf txtFlag = "Ventas" Then
            OK_Button.PerformClick()
        End If
    End Sub
    Private Sub Factura_AlCliente()
        If LoadOptionsPrint(1) Then
            If Me.txtFlag = "Lote" Then
                If MsgBox("Esta seguro de facturar a nombre de " & Me.dtg.SelectedCells(2).Value, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..") = MsgBoxResult.Yes Then
                    FacturVenta.idCliente = Me.dtg.SelectedCells(0).Value
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End If
            ElseIf Me.txtFlag = "Ventas" Then
                FacturVenta.idCliente = Me.dtg.SelectedCells(0).Value
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        Try
            Using newAddPerson As New frmAdd_Personas(stateOperation.Insert, 0)
                With newAddPerson
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        idCliente = ClsClientes.isClinteBypersonAdmin(.idPersona)
                        ViewAddNew(.idPersona)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        Try
            If Me.GetSelectedRow Then
                Using EddPerson As New frmAdd_Personas(stateOperation.Update, Me.idPersona)
                    With EddPerson
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            'obtener toda las lista y luego quitar el seleccinado
                            Dim SelectList As New List(Of ItemPerson)
                            SelectList = dtg.DataSource
                            'los que no se han modifica
                            Dim oldList = SelectList.Where(Function(x) x.IdPersona <> Me.idPersona)
                            dtg.DataSource = Nothing
                            dtg.DataSource = oldList.ToList()
                            ViewAddNew(Me.idPersona)
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Try
            If GetSelectedRow() Then
                sql = dtg.SelectedRows(0).Cells("FullName").Value
                If MsgBox("Esta sueguro de eliminar al cliente " + sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda.") = MsgBoxResult.Yes Then
                    If Eliminar_clinete(Me.idPersona) Then
                        Dim SelectList As New List(Of ItemPerson)
                        SelectList = dtg.DataSource
                        ViewList(SelectList.Where(Function(x) x.IdPersona <> Me.idPersona).ToList())
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Function GetSelectedRow() As Boolean
        Try
            If dtg.SelectedRows.Count = 1 Then
                Me.idCliente = dtg.SelectedRows(0).Cells("IdCliente").Value
                Me.idPersona = dtg.SelectedRows(0).Cells("IdPersona").Value
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Eliminar_clinete(idPersona As Integer) As Boolean
        sql = "Delete Clientes from Clientes where idPersona=" & idPersona & ""
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql)
                cmd.CommandType = CommandType.Text
                cmd.Connection = Cnn_sql
                If cmd.ExecuteNonQuery() Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro en el Eliminar_clinete")
            Return False
        Finally
            desconecta_sql()
        End Try

    End Function

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles dtg.KeyDown
        If Me.dtg.SelectedRows.Count = 1 Then
            If e.KeyCode = Keys.Enter Then
                sql = dtg.SelectedCells(2).Value
                OK_Button.PerformClick()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        If txtFlag = "Lote" And FacturVenta.idFormPago > 0 Then
            Factura_AlCliente()
        ElseIf txtFlag = "Ventas" Then
            Factura_AlCliente()
        ElseIf txtFlag = "Lote" Then
            MsgBox("Determine la forma de pago", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtg.CellFormatting
        If sender.Columns(e.ColumnIndex).name = "btnCredito" And e.RowIndex >= 0 Then
            e.Value = "Otorgar Crédito"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        If sender.Columns(e.ColumnIndex).name = "btnCredito" And e.RowIndex >= 0 And txtFlag = "Creditos" Then
            If MsgBox("Está seguro de habilitar para que el cliente pueda comprar a crédito", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then

                dtg.Enabled = False
                FlowMenu.Enabled = False

                sql = (dtg.SelectedCells.Item(0).Value)
                sql = dtg.SelectedCells.Item(8).Value

            End If
        End If
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.RowEnter
        If txtFlag = "Creditos" Then

        ElseIf txtFlag = "Lote" Then
            lblformaPago.Visible = False
            FacturVenta.idFormPago = 0
        End If
    End Sub

    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click
        Try
            If GetSelectedRow() Then
                If Not (stateClient = stateClient.Admin) Then
                    MsgBox("No tiene permiso para esta opción.", MsgBoxStyle.Exclamation, "Aviso")
                    Return
                End If

                Using frmdata As New frmImputData
                    With frmdata
                        .txtNumber.Value = dtg.SelectedRows(0).Cells("Monto_Max").Value
                        .Text = "Determine el monto máximo de crédito."
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            If Otorga_Credito(Me.idCliente, .txtNumber.Value) Then
                                'obtener toda las lista y luego quitar el seleccinado
                                Dim SelectList As New List(Of ItemPerson)
                                SelectList = dtg.DataSource
                                'los que no se han modifica
                                Dim oldList = SelectList.Where(Function(x) x.IdPersona <> Me.idPersona)
                                dtg.DataSource = Nothing
                                dtg.DataSource = oldList.ToList()
                                ViewAddNew(Me.idPersona)
                            End If
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function Otorga_Credito(idCliente As Integer, monto As Double) As Boolean
        Try
            sql = "Update [dbo].[Clientes] set monto_Max =@monto_Max, credito =@credito "
            sql = sql & "Where idCliente = @idCliente "
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@credito", SqlDbType.Bit)
                    cmd.Parameters.Add("@monto_Max", SqlDbType.Decimal, 18, 2)
                    cmd.Parameters.Add("@idCliente", SqlDbType.Int)

                    If monto = 0 Then
                        cmd.Parameters("@credito").Value = 0
                    Else
                        cmd.Parameters("@credito").Value = 1
                    End If
                    cmd.Parameters("@monto_Max").Value = monto
                    cmd.Parameters("@idCliente").Value = idCliente
                    If cmd.ExecuteNonQuery() >= 1 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub btnCobro_Click(sender As Object, e As EventArgs) Handles btnCobro.Click
        Try
            If GetSelectedRow() Then
                Using fornew As New frmCobro

                    With fornew
                        .Text = String.Format("ESTADO DE DEUDA DE: {0}", dtg.SelectedRows(0).Cells("FullName").Value)
                        .idCliente = Me.idCliente
                        .StartPosition = FormStartPosition.CenterScreen
                        .ShowDialog()
                        If .Operation Then
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellClick
        Try
            idPersona = 0
            idCliente = 0
            If dtg.SelectedRows.Count = 1 Then
                Me.VisibleCabecera(True)
                idPersona = dtg.SelectedRows(0).Cells(dtg.Columns("idPersona").Index).Value
                idCliente = dtg.SelectedRows(0).Cells(dtg.Columns("idCliente").Index).Value
            Else
                Me.VisibleCabecera(False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        Try
            If Me.GetSelectedRow Then
                Using newClient As New frmAdd_Personas(stateOperation.View, Me.idPersona)
                    With newClient
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then

                        End If
                    End With
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error`")
        End Try

    End Sub

    Private Sub SettingButton_MouseDown(sender As Object, e As MouseEventArgs) Handles SettingButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub
    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        Load_ListClientes()
        Me.Cursor = Cursors.WaitCursor
        ViewList(Me.listClient)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CereditAutorizationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CereditAutorizationToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            ViewList(listClient.Where(Function(x) x.Monto_Max > 0).ToList)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DebtbalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebtbalanceToolStripMenuItem.Click
        Try
            Using newForDebitBalance As New frmList_CuentasXcobrar
                With newForDebitBalance
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub NuevosClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevosClientesToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Load_ListClientes()
            ViewList(Me.listClient.OrderByDescending(Function(x) x.IdCliente).ToList(), True)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
