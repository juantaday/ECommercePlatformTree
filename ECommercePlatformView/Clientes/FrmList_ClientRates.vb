Imports CADsisVenta

Public Class FrmList_ClientRates
    Private listClient As List(Of ItemPerson)

    Private Sub FrmList_ClientRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listClient = New List(Of ItemPerson)
        PersonalizeGridView()
        Carga_Datos()
    End Sub
    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = False
            applyGridTheme(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Datos()
        Try
            Me.Cursor = Cursors.WaitCursor
            listClient.Clear()
            Using db As New DataContext
                Dim _rates = From r In db.Rates
                             Join cr In db.ClientesRate On r.idRates Equals cr.IdRates
                             Select r.idRates, cr.idCliente, r.Descriptions, r.Structure

                Dim list = From c In db.Clientes
                           Join p In db.Personas On p.idPersona Equals c.idPersona
                           Group Join r In _rates On r.idCliente Equals c.idCliente
                           Into PetList = Group
                           From pet In PetList.DefaultIfEmpty()
                           Where Not p.genero Is Nothing
                           Select p.idPersona, c.idCliente, idEmployee = 0, p.Apellidos, p.Nombre, p.Ruc_Ci, p.Direccion, p.telefono, p.mail,
                           idRates =
                                     If(pet Is Nothing, 0, pet.idRates),
                           Description =
                                     If(pet Is Nothing, "Ninguna..", pet.Descriptions), p.genero


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
                                                    item.idRates,
                                                    item.Description,
                                                    item.genero))
                Next
            End Using
            dtg.DataSource = Nothing
            dtg.DataSource = listClient.OrderBy(Function(x) x.Apellidos).ThenBy(Function(x) x.Nombre).ToList()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            TotalListLabel.Text = String.Format("Total en la lista: {0}", listClient.Count.ToString("N0"))
        End Try
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub


    Private Sub CheckBoxSeelct_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeelct.CheckedChanged
        Try
            For i = 0 To dtg.RowCount - 1
                dtg.Rows(i).Cells(IsSelectClm.Index).Value = CheckBoxSeelct.Checked
            Next
            DeleteRatesButton.Visible = CheckBoxSeelct.Checked
            SetRatesButton.Visible = CheckBoxSeelct.Checked
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
            QuitFilterButton.Text = "Quitar el filtro (" & dtg.RowCount & ")"
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
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    listResult = list1
                Case 2
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    listResult = list2
                Case 3
                    list1 = listClient.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
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

    Private Sub FindClienWithCedula(myFindText As String)
        Try
            dtg.DataSource = Nothing
            dtg.DataSource = listClient.Where(Function(x) x.Ruc_Ci.Contains(myFindText)).ToList()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Function myFindText() As String
        Throw New NotImplementedException()
    End Function

    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        Try
            If e.RowIndex >= 0 And e.ColumnIndex = IsSelectClm.Index Then
                Dim response As Boolean = Not dtg.Rows(e.RowIndex).Cells(IsSelectClm.Index).Value
                dtg.Rows(e.RowIndex).Cells(IsSelectClm.Index).Value = response
                If response Then
                    DeleteRatesButton.Visible = True
                    SetRatesButton.Visible = True
                Else
                    Dim list As List(Of ItemPerson) = listClient.Where(Function(x) x.IsSelect = True).ToList()
                    DeleteRatesButton.Visible = list.Count
                    SetRatesButton.Visible = list.Count
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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

    Private Sub QuitFilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        ViewData()
        QuitFilterButton.Visible = False
        QuitFilterButton.Text = "Quitar el filtro"
    End Sub

    Private Sub ViewData()
        Try
            dtg.DataSource = Nothing
            dtg.DataSource = listClient.OrderBy(Function(x) x.Apellidos) _
                .ThenBy(Function(x) x.Nombre).ToList()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dtg.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected Then
            DireccionLabel.Text = String.Format("Dirección: {0}", e.Row.Cells(DireccionClm.Index).Value)
        Else
            DireccionLabel.Text = String.Empty
        End If
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        DeleteRatesButton.Visible = False
        SetRatesButton.Visible = False
        QuitFilterButton.Visible = False
        Carga_Datos()
    End Sub
    Private Sub DeleteRatesButton_Click(sender As Object, e As EventArgs) Handles DeleteRatesButton.Click
        If Not (MsgBox("Esta seduro de borar la tafifa a estos clientes..", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes) Then
            Return
        End If
        Dim list As New List(Of ItemPerson)
        list = dtg.DataSource
        For Each item As ItemPerson In list.Where(Function(x) x.IsSelect = True)
            If item.IsSelect Then
                item.idRates = 0
                item.Description = "Ninguna.."
                listClient.Where(Function(x) x.IdPersona = item.IdPersona).FirstOrDefault().idRates = 0
                listClient.Where(Function(x) x.IdPersona = item.IdPersona).FirstOrDefault().Description = "Ninguna.."
            End If
        Next
        dtg.DataSource = Nothing
        dtg.DataSource = list
    End Sub
    Private Sub SetRatesButton_Click(sender As Object, e As EventArgs) Handles SetRatesButton.Click
        Try
            Using selectRates As New frmList_RatesSelect
                With selectRates
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If SetFunction(.idRates, .Descriptios) Then

                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Function SetFunction(ByVal _idRates As Integer, ByVal _descriptions As String) As Boolean
        Try
            Dim list As New List(Of ItemPerson)
            list = dtg.DataSource
            For Each item As ItemPerson In list.Where(Function(x) x.IsSelect = True)
                If item.IsSelect Then
                    item.idRates = _idRates
                    item.Description = _descriptions
                    listClient.Where(Function(x) x.IdPersona = item.IdPersona).FirstOrDefault().idRates = _idRates
                    listClient.Where(Function(x) x.IdPersona = item.IdPersona).FirstOrDefault().Description = _descriptions
                End If
            Next
            dtg.DataSource = Nothing
            dtg.DataSource = list
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        If SaveRates() Then
            MsgBox("Información guardada exitosamente.", MsgBoxStyle.Information, "Aviso")
            UpdateButton.PerformClick()
        End If
    End Sub
    Private Function SaveRates() As Boolean
        Try

            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim _ratesclient = From r In db.ClientesRate
                    If listClient.Where(Function(x) x.idRates > 0).ToList().Count = 0 Then
                        For Each item In _ratesclient
                            db.ClientesRate.DeleteOnSubmit(item)
                        Next
                        db.SubmitChanges()
                    Else
                        For Each item In _ratesclient
                            If listClient.Where(Function(x) x.IdCliente = item.idCliente) _
                                .FirstOrDefault().idRates = 0 Then
                                db.ClientesRate.DeleteOnSubmit(item)
                            Else
                                item.IdRates = listClient.Where(Function(x) x.IdCliente = item.idCliente) _
                                             .FirstOrDefault().idRates
                            End If
                            listClient.Where(Function(x) x.IdCliente = item.idCliente) _
                                             .FirstOrDefault().IsUpdate = True
                        Next
                        db.SubmitChanges()
                        'para clientes que no estan registrados
                        For Each item In listClient.Where(Function(x) x.IsUpdate = False And x.idRates > 0)
                            Dim _r As New ClientesRate With
                                {
                                .idCliente = item.IdCliente,
                                .IdRates = item.idRates
                                }
                            db.ClientesRate.InsertOnSubmit(_r)
                        Next
                        db.SubmitChanges()
                    End If
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles SettingButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub RatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatesToolStripMenuItem.Click
        Try
            dtg.DataSource = Nothing
            Dim list As New List(Of ItemPerson)
            list = listClient.Where(Function(x) x.idRates > 0).ToList()

            dtg.DataSource = list.OrderBy(Function(x) x.idRates).ThenBy(Function(x) x.Apellidos) _
                .ThenBy(Function(x) x.Nombre).ToList()
            QuitFilterButton.Visible = True
            QuitFilterButton.Text = "Quitar filtro (" & dtg.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NotRatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotRatesToolStripMenuItem.Click
        Try
            dtg.DataSource = Nothing
            Dim list As New List(Of ItemPerson)
            list = listClient.Where(Function(x) x.idRates = 0).ToList()

            dtg.DataSource = list.OrderBy(Function(x) x.Apellidos) _
                .ThenBy(Function(x) x.Nombre).ToList()
            QuitFilterButton.Visible = True
            QuitFilterButton.Text = "Quitar filtro (" & dtg.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.Click
        Try
            dtg.DataSource = Nothing
            Dim list As New List(Of ItemPerson)
            list = listClient.Where(Function(x) x.IsSelect = True).ToList()

            dtg.DataSource = list.OrderBy(Function(x) x.Apellidos) _
                .ThenBy(Function(x) x.Nombre).ToList()
            QuitFilterButton.Visible = True
            QuitFilterButton.Text = "Quitar filtro (" & dtg.RowCount & ")"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class