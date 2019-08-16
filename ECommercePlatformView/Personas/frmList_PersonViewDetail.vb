Imports System.Windows.Forms

Public Class frmList_PersonViewDetail
    Private indexRow As Integer
    Private estaCargado As Boolean
    Private idPersona As Integer
    Private listPerson As List(Of ItemPerson)
    Private stateClient As stateClient

    Sub New(stateClient As stateClient)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateClient = stateClient
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        Using newAddPerson As New frmAdd_Personas(stateOperation.Insert, 0)
            With newAddPerson
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    FindTextBox.Text = .Ruc_CiText.Text
                    FindButton.PerformClick()
                    FindTextBox.Text = String.Empty
                End If
            End With
        End Using
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EdidPersonButton.Click
        Try
            If Me.GetSelectedRow Then
                Using EddPerson As New frmAdd_Personas(stateOperation.Update, Me.idPersona)
                    With EddPerson
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            Load_DataPerson()
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GetSelectedRow() As Boolean
        Try
            If dtg.SelectedRows.Count = 1 Then
                Me.idPersona = dtg.SelectedRows(0).Cells("idPersonaClm").Value
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub ViewAddNew(ByVal _idPersona As Integer)
        Try
            Load_DataPerson()
            Dim Viewlis = New List(Of ItemPerson)
            If dtg.RowCount > 0 Then
                Viewlis = dtg.DataSource
            End If

            Using db As New DataContext
                Dim list = From p In db.Personas Where idPersona = _idPersona And p.TypePerson = 0

                For Each item In list
                    Viewlis.Add(New ItemPerson(item.idPersona,
                                                    0,
                                                    0,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    0,
                                                    0,
                                                    item.genero, 0,
                                                   If(IsNothing(item.foto), Nothing, item.foto.ToArray())))
                Next
            End Using

            If Viewlis.Count > 0 Then
                listPerson.AddRange(Viewlis)
                ViewList(Viewlis)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub ViewList(ByVal itemList As List(Of ItemPerson), Optional DoNotOrder As Boolean = False)
        Try
            Me.dtg.DataSource = Nothing
            If DoNotOrder Then
                Me.dtg.DataSource = itemList.ToList()
            Else
                Me.dtg.DataSource = itemList.OrderBy(Function(x) x.FullName).ToList()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            Me.TotalListLabel.Text = "Total : " & itemList.Count.ToString()
        End Try
    End Sub
    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dtg.RowStateChanged
        Try
            adminEmployeePanel.Enabled = False
            AdminPayMentPanel.Enabled = False
            If e.Row.Selected And estaCargado Then
                If dtg.SelectedRows.Count = 1 Then
                    Carga_Detail(sender, e.Row.Index)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Carga_Detail(sender As System.Windows.Forms.DataGridView, index As Integer)
        Try
            Dim reportTo As String = String.Empty
            If stateClient = stateClient.Admin Then
                EdidPersonButton.Enabled = True
                DeletePersonButton.Enabled = True
                adminEmployeePanel.Enabled = True
                AdminPayMentPanel.Enabled = True
            End If

            If NameEmployeeLabel.Text.ToUpper().Contains("CONSUMIDOR") Then
                EdidPersonButton.Enabled = False
                DeletePersonButton.Enabled = False
                adminEmployeePanel.Enabled = False
                AdminPayMentPanel.Enabled = False
            End If

            'id de persona seleccionada
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
                    If sender.SelectedCells.Item(sender.Columns("TypePerson").Index).Value = 1 Then
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Company_128
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                        Return
                    End If
                    If Boolean.Parse(sender.SelectedCells.Item(sender.Columns("Genero").Index).Value) Then
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Else
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                End If
            Else 'TypePerson
                If sender.SelectedCells.Item(sender.Columns("TypePerson").Index).Value = 1 Then
                    PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Company_128
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Return
                End If
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


    Private Sub DetailsButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeletePersonButton.Click
        Try
            If dtg.SelectedRows.Count = 1 Then
                If MsgBox("Esta seguro de eliminar..", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 _
                          , "Responda") = MsgBoxResult.Yes Then
                    If DeletePerson(dtg.SelectedRows(0).Cells("idPersonaClm").Value) Then
                        Load_DataPerson()
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Function DeletePerson(_idPersona As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _Person = From p In db.Personas
                              Where p.idPersona = _idPersona

                For Each item In _Person
                    db.Personas.DeleteOnSubmit(item)
                    db.SubmitChanges()
                    Return True
                Next
            End Using

            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub frmList_PersonViewDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPerson = New List(Of ItemPerson)
        PersonalizeGridView()
        Load_DataPerson()
        estaCargado = True
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = False
            applyGridTheme(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_DataPerson()
        Try
            Me.Cursor = Cursors.WaitCursor
            listPerson.Clear()
            Using db As New DataContext
                Dim list = From p In db.Personas Where p.TypePerson = 0

                For Each item In list
                    listPerson.Add(New ItemPerson(item.idPersona,
                                                    0,
                                                   0,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    0,
                                                    0,
                                                    If(IsNothing(item.genero), False, item.genero),
                                                    0,
                                                   If(IsNothing(item.foto), Nothing, item.foto.ToArray()),
                                                    item.TypePerson))
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

    Private Sub QuitFilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        Load_DataPerson()
        QuitFilterButton.Visible = False
        FindTextBox.Text = String.Empty
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
            Me.AcceptButton = OK_Button
            FindButton.Enabled = False
        End If
    End Sub
    Private Sub dtg_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.RowEnter
        If estaCargado And dtg.SelectedRows.Count = 1 Then
            Carga_Detail(dtg, dtg.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub ToolsButton_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolsButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ToolsContextMenuStrip()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub PersonasNaturalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasNaturalesToolStripMenuItem.Click
        Load_DataPerson()
    End Sub

    Private Sub CompaniasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompaniasToolStripMenuItem.Click
        Load_DataCompany()
    End Sub

    Private Sub Load_DataCompany()
        Try
            Me.Cursor = Cursors.WaitCursor
            listPerson.Clear()
            Using db As New DataContext
                Dim list = From p In db.Personas Where p.TypePerson = 1

                For Each item In list
                    listPerson.Add(New ItemPerson(item.idPersona,
                                                    0,
                                                   0,
                                                    item.Ruc_Ci,
                                                    item.Apellidos,
                                                    item.Nombre,
                                                    item.Direccion,
                                                    item.telefono,
                                                    item.mail,
                                                    0,
                                                    0,
                                                    If(IsNothing(item.genero), False, item.genero),
                                                    0,
                                                   If(IsNothing(item.foto), Nothing, item.foto.ToArray()),
                                                   item.TypePerson))
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

End Class
