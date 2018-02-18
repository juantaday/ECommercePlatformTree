Imports System.Data.SqlClient
Imports CADsisVenta
Imports CADsisVenta.DataSetEmployeeTableAdapters
Imports CADsisVenta.DataSetEmployee
Public Class frmList_Empleados

    Protected Friend idEmpleado As Integer
    Protected Friend idPersona As Integer
    Private indexRow As Integer
    Protected Friend stateClient As stateClient
    Private estaCargado As Boolean

    Private listPerson As List(Of ItemPerson)
    Sub New(stateClient As stateClient)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateClient = stateClient
    End Sub

    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = False
            applyGridTheme(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles AddNewEmplToList.Click
        Try
            Using listPerson As New frmList_PersonViewTarget(stateLoad.Dialogo)
                With listPerson
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Using addEmployee As New frmAdd_Empleados(stateLoad.Dialogo, stateClient.Admin, stateOperation.Insert)
                            addEmployee.idEmpleado = getIdEmpleadoFromIdPerson(listPerson.idPersona)
                            addEmployee.idPersona = listPerson.idPersona
                            With addEmployee
                                .ShowDialog()
                                If addEmployee.DialogResult = DialogResult.OK Then
                                    Load_DataEmployee()
                                Else
                                    sql = sql
                                End If
                            End With
                        End Using
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function getIdEmpleadoFromIdPerson(idPersona As Integer) As Integer
        Try
            Using db As New DataContext
                Dim _emplados = From e In db.Empleados Where e.idPersona = idPersona

                For Each p In _emplados
                    Return p.idEmpleado
                Next
            End Using
            Return 0
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
    Private Sub txtEmple_Busca_Leave(sender As Object, e As EventArgs)
        Me.AcceptButton = Nothing
    End Sub

    Private Sub frmList_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPerson = New List(Of ItemPerson)
        PersonalizeGridView()
        Load_DataEmployee()
        indexRow = -1
        ActivaControl()
        Me.estaCargado = True
    End Sub
    Private Sub ActivaControl()
        If stateClient = stateClient.Admin Then
            AddNewEmplToList.Enabled = True
        Else
            AddNewEmplToList.Enabled = False
        End If
    End Sub

    Private Sub Load_DataEmployee()
        Try
            Me.Cursor = Cursors.WaitCursor
            listPerson.Clear()
            Using db As New DataContext
                Dim list = From p In db.Personas
                           Join e In db.Empleados On p.idPersona Equals e.idPersona
                           Select p.idPersona, idCliente = 0, idEmployee = e.idEmpleado, p.Apellidos, p.Nombre, p.Ruc_Ci,
                               p.Direccion, p.telefono, p.mail, idRates = 0, Description = String.Empty, p.foto, p.genero

                For Each item In list
                    listPerson.Add(New ItemPerson(item.idPersona,
                                                    item.idCliente,
                                                    item.idEmployee,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    item.idRates,
                                                    item.Description,
                                                    item.genero, 0,
                                                   If(IsNothing(item.foto), Nothing, item.foto.ToArray())))
                Next
            End Using
            dtg.DataSource = Nothing
            dtg.DataSource = listPerson.OrderBy(Function(x) x.Apellidos).ThenBy(Function(x) x.Nombre).ToList()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            TotalListLabel.Text = String.Format("Total en la lista: {0}", listPerson.Count.ToString("N0"))
        End Try
    End Sub

    Sub rowPostPaint_HeaderCount(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        'set rowheader count
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top,
            grid.RowHeadersWidth, e.RowBounds.Height - sender.rows(e.RowIndex).DividerHeight)
        e.Graphics.DrawString(rowIdx, grid.Font, SystemBrushes.ControlText,
            headerBounds, centerFormat)
    End Sub
    Sub clearFields()
        PanelView.Controls.Clear()
        Refresh()
    End Sub
    Private Function Insert_Employee(idpersona As Integer, genero As String) As Boolean
        Try
            Dim repotTo As Nullable(Of Integer) = Nothing
            Dim data As New EmpleadosTableAdapter
            Dim respont As Integer
            respont = data.Insert(idpersona, genero, "Empleado", 0, Date.Now, repotTo)
            If respont > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs)
        If (MsgBox("Está seguro de Eliminar?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation, "Responda")) = MsgBoxResult.Yes Then
        End If
    End Sub

    Private Function Elimina_Empleado(ByVal idempleado As Integer) As Boolean
        conecta_sql()

        sql = "Delete Empleados from Empleados where idEmpleado = " & idempleado & " "
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
            MsgBox(ex.Message + " en el Elimina_Empleado del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Function Elimina_Persona(ByVal idpersona As Integer) As Boolean
        conecta_sql()

        sql = "Delete personas from personas where idPersona = " & idpersona & ""
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
            MsgBox(ex.Message + " en el Elimina_Persona del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles EdidEmployeeCliente.Click
        Using UpdateEmploye As New frmAdd_Personas(stateOperation.Update, Me.idPersona)
            With UpdateEmploye
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    Me.notificacion.Visible = True
                    Me.notificacion.ShowBalloonTip(1000, "Aviso", "Modificación exitosa", ToolTipIcon.Info)
                End If
            End With
        End Using
    End Sub

    Private Sub datalistado_Leave(sender As Object, e As EventArgs)
        Me.AcceptButton = Nothing
    End Sub

    Private Sub Carga_Image(sender As System.Windows.Forms.DataGridView, index As Integer)
        Try
            If Not (sender.SelectedRows.Count = 1) Then
                Return
            End If

            Dim img() As Byte = Nothing
            If IsArray(sender.SelectedCells.Item(sender.Columns("ImageClm").Index).Value) Then
                img = sender.SelectedCells.Item(sender.Columns("ImageClm").Index).Value
            End If

            If Not IsNothing(img) Then
                If img.Length > 0 Then
                    Dim ms As New IO.MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    If Boolean.Parse(sender.SelectedCells.Item(sender.Columns("Genero").Index).Value) Then
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Else
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                End If
            Else
                If Boolean.Parse(sender.SelectedCells.Item(sender.Columns("Genero").Index).Value) Then
                    PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Delete_Employee(idperson As Integer) As Boolean
        Try
            Dim data As New EmpleadosTableAdapter
            Dim respont As Integer
            respont = data.Insert(idPersona, String.Empty, "Empleado", 0, Date.Now, vbNull)
            If respont > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Selection_Row(iempl As Integer)
        For index = 0 To dtg.RowCount - 1
            If iempl = dtg.Rows(index).Cells(dtg.Columns("idEmpleado").Index).Value Then
                dtg.Rows(index).Selected = True
                Return
            Else
                If dtg.Rows(index).Selected Then
                    dtg.Rows(index).Selected = False
                End If
            End If
        Next
    End Sub

    Private Sub ReportToButton_Click(sender As Object, e As EventArgs)
        Try
            Dim reportTo As Nullable(Of Integer)
            Using newListEm As New frmList_Empleados(stateClient.User)
                With newListEm
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        reportTo = .idEmpleado
                        If reportTo > 0 Then
                            Dim dat As New EmpleadosTableAdapter()
                            If dat.UpdateReportTo(reportTo, idEmpleado) = 1 Then
                                Load_DataEmployee()
                            End If
                            dat = Nothing
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_Detail(sender As System.Windows.Forms.DataGridView, index As Integer)
        Try
            Dim reportTo As String = String.Empty
            'id de persona seleccionada
            idEmpleado = Convert.ToInt32(sender.Rows(index).Cells(sender.Columns("IdEmployeeClm").Index).Value)
            idPersona = Convert.ToInt32(sender.Rows(index).Cells(sender.Columns("idPersonaClm").Index).Value)
            NameEmployeeLabel.Text = Convert.ToString(sender.Rows(index).Cells(sender.Columns("ClienteClm").Index).Value)
            PhoneLabel.Text = String.Format("Teléfono: {0}", Convert.ToString(sender.Rows(index).Cells(sender.Columns("telefonoClm").Index).Value))
            EmailLabel.Text = String.Format("Email: {0}", Convert.ToString(sender.Rows(index).Cells(sender.Columns("mailClm").Index).Value))

            indexRow = index

            'cargamos la imagen
            Carga_Image(sender, index)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_DerportTo(idempledo As Integer)
        Try
            Dim tap As New EmpleadoNameTableAdapter
            Dim dt As New EmpleadoNameDataTable
            tap.FillByIdEmpleado(dt, idempledo)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    sql = dt.Rows(0)("cargo") + ":" + vbNewLine
                    sql = sql & dt.Rows(0)("Nombres") + vbNewLine
                    sql = sql & "(" + dt.Rows(0)("Ruc_Ci") + ")"
                End If
                tap = Nothing
                dt = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        Dim data As New EmpleadosTableAdapter
    End Sub

    Private Sub DeleteReportToButton_Click(sender As Object, e As EventArgs)
        Try
            Dim repotTo As Nullable(Of Integer) = Nothing
            Dim dat As New EmpleadosTableAdapter()
            If dat.UpdateReportTo(repotTo, idEmpleado) = 1 Then
                Load_DataEmployee()
            End If
            dat = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditDetailButton_Click(sender As Object, e As EventArgs) Handles EditDetailButton.Click
        Try
            Using EditEmployee As New frmAdd_Empleados(stateLoad.Dialogo, stateClient.Admin, stateOperation.Update)
                With EditEmployee
                    .idEmpleado = Me.idEmpleado
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UpdateDetailButton_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub CandelDeatilButton_Click(sender As Object, e As EventArgs)
        If dtg.RowCount > 0 Then
            EditDetailButton.Enabled = True
        End If
        dtg.Focus()
        PanelList.Enabled = True
        PanelBusq.Enabled = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditCardButton_Click(sender As Object, e As EventArgs) Handles EditCardButton.Click
        Try
            Using EditEmployee As New frmAdd_Empleados(stateLoad.Dialogo, stateClient.Admin, stateOperation.View)
                With EditEmployee
                    .idEmpleado = Me.idEmpleado
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BorrarDeLaListaDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarDeLaListaDeEmpleadosToolStripMenuItem.Click
        Try
            Dim resp As Integer
            If (MsgBox("Está seguro de eliminar..?",
            MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo +
            MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                Dim dap As New EmpleadosTableAdapter
                resp = dap.DeleteEmployee(idEmpleado)
                If resp = 1 Then
                    Load_DataEmployee()
                End If
            End If
        Catch ex As Exception
            If ex.Message.Contains("REFERENCE") Then
                MsgBox("Este empleado tiene información realacionado con otros datos" + vbNewLine +
                       "No se puede borrar.", MsgBoxStyle.Exclamation, "Importante")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub
    Private Sub EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTotaLaInformacionDeEsteEmpleadoToolStripMenuItem.Click
        Try
            Dim rest As Integer
            If (MsgBox("Está seguro de eliminar toda su informacíon..?",
            MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo +
            MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                rest = ClsEmployee.DeleteEmployeeAll(idEmpleado)
                If rest = 1 Then
                    Load_DataEmployee()
                ElseIf rest = -1 Then
                    MsgBox("Hay personas que se reporta a este empleado.." + vbNewLine +
                           "borra esa opcíón para poder eliminar.", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If
        Catch ex As Exception
            If ex.Message.Contains("REFERENCE") Then
                MsgBox("Este empleado tiene información realacionado con otros datos" + vbNewLine +
                       "No se puede borrar.", MsgBoxStyle.Exclamation, "Importante")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub

    Private Sub deleteEmployeeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles deleteEmployeeButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.deleteContextMenuStrip()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dtg.RowStateChanged
        Try
            adminEmployeePanel.Enabled = False
            If e.Row.Selected And estaCargado Then
                If dtg.SelectedRows.Count = 1 Then
                    Carga_Detail(sender, e.Row.Index)
                    If stateClient = stateClient.Admin Then
                        EdidEmployeeCliente.Enabled = True
                        deleteEmployeeButton.Enabled = True
                        adminEmployeePanel.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Try

            'si no ha dada
            Dim myFindText As String = Trim(FindTextBox.Text)
            If myFindText.Length = 0 Or String.IsNullOrWhiteSpace(myFindText) Then
                MsgBox("Determine lo que busca..", MsgBoxStyle.Exclamation, "Importante")
                FindTextBox.Focus()
                Return
            End If
            'preparamos el texto
            Dim isSpace As Boolean = False
            sql = ""
            For Each stri In myFindText
                If Not isSpace Then
                    sql += stri
                    isSpace = False
                End If
                If String.IsNullOrWhiteSpace(stri) Then
                    isSpace = True
                Else
                    If isSpace Then
                        sql += stri
                    End If
                    isSpace = False
                End If
            Next
            myFindText = sql

            'rebisamos si no es codigo munerico entonces es cedula
            Dim isnumric As Boolean = True
            For Each texto In myFindText
                If InStr("0123456789", texto) = False Then
                    isnumric = False
                    Exit For
                End If
            Next
            If isnumric Then
                FindClienWithCedula(myFindText)
                Return
            End If

            'si es nombre de producto covierto en una matriz
            Dim split As String() = myFindText.Split(" ")
            Select Case split.Count
                Case 1
                    FindClienWithParameters(split(0), String.Empty, String.Empty, split.Count)
                Case 2
                    FindClienWithParameters(split(0), split(1), String.Empty, split.Count)
                Case 3
                    FindClienWithParameters(split(0), split(1), split(2), split.Count)
                Case > 3
                    FindClienWithParameters(split(0), split(1), split(2), split.Count)
                Case Else
                    Return
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            QuitFilterButton.Visible = True
        End Try
    End Sub

    Private Sub FindClienWithCedula(myFindText As String)
        Try
            dtg.DataSource = Nothing
            dtg.DataSource = listPerson.Where(Function(x) x.Ruc_Ci.Contains(myFindText)).ToList()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub FindClienWithParameters(v1 As String, v2 As String, v3 As String, v4 As Integer)
        Try
            Dim list1 As New List(Of ItemPerson)
            Dim list2 As New List(Of ItemPerson)
            Dim list3 As New List(Of ItemPerson)
            Dim listResult As New List(Of ItemPerson)
            Select Case v4
                Case 1
                    list1 = listPerson.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    listResult = list1
                Case 2
                    list1 = listPerson.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    listResult = list2
                Case 3
                    list1 = listPerson.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    list3 = list2.Where(Function(x) x.FullName.ToUpper().Contains(v3.ToUpper())).ToList()
                    listResult = list3
            End Select

            dtg.DataSource = Nothing
            dtg.DataSource = listResult.ToList()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub QuitFilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        Load_DataEmployee()
        QuitFilterButton.Visible = False
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
        Else
            FindButton.Enabled = False
        End If
    End Sub
    Private Sub EstadoBunifuThinButton_Click(sender As Object, e As EventArgs) Handles EstadoBunifuThinButton.Click
        Try
            Cursor = Cursors.WaitCursor
            Using newListDebit As New frmList_EmployeeDebit(idPersona)
                With newListDebit
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dtg_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.RowEnter
        Try
            If estaCargado Then
                adminEmployeePanel.Enabled = True
                AdminPayMentPanel.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class