Imports System.Windows.Forms

Public Class frmListEmployeeView
    Private State As stateLoad
    Private isClosed As Boolean
    Protected Friend _ItemPerson As ItemPerson
    Public Sub New(ByVal _State As stateLoad)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.State = _State
    End Sub
    Private listPerson As List(Of ItemPerson)

    Private Sub frmListEmployeeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listPerson = New List(Of ItemPerson)
        PersonalizeGridView()
        EmployeeToolStripMenuItem.PerformClick()
        Select Case State
            Case stateLoad.Dialogo
                PanelMenu.Visible = False
                Me.CheckBoxSeelct.Visible = False
                Me.OkButton.Text = "Seleccionar.."
        End Select
    End Sub

    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = False
            applyGridTheme(dtg)
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

    Private Sub Load_DataPerson()
        Try
            Me.Cursor = Cursors.WaitCursor
            listPerson.Clear()
            Using db As New DataContext
                Dim list = From p In db.Personas
                           Select p.idPersona, idCliente = 0, idEmployee = 0, p.Apellidos, p.Nombre, p.Ruc_Ci,
                               p.Direccion, p.telefono, p.mail, idRates = 0, Description = String.Empty, p.genero

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
                                                  item.genero))
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

    Private Sub Load_DataEmployee()
        Try
            Me.Cursor = Cursors.WaitCursor
            listPerson.Clear()
            Using db As New DataContext
                Dim list = From p In db.Personas
                           Join e In db.Empleados On p.idPersona Equals e.idPersona
                           Select p.idPersona, idCliente = 0, idEmployee = e.idEmpleado, p.Apellidos, p.Nombre, p.Ruc_Ci,
                               p.Direccion, p.telefono, p.mail, idRates = 0, Description = String.Empty, p.genero

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
                                                    item.genero))
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
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Try
            Load_DataEmployee()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        _ItemPerson = Nothing
        isClosed = True
        If Me.OkButton.Text.Contains("Seleccionar..") Then
            If Me.dtg.SelectedRows.Count = 1 Then
                Dim _idperson As Integer? = Me.dtg.SelectedRows(0).Cells(idPersonaClm.Index).Value

                Dim SeletPerson = From lp In listPerson
                                  Where lp.IdPersona = _idperson
                If SeletPerson.Count = 1 Then
                    'Retorna toda la informacion de la persona
                    _ItemPerson = SeletPerson.FirstOrDefault()
                    Me.DialogResult = DialogResult.OK
                    isClosed = False
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub frmListEmployeeView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = isClosed
    End Sub

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        If FindTextBox.Text.Length > 2 Then
            FindButton.Enabled = True
        Else
            FindButton.Enabled = False
        End If
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

    Private Sub dtg_KeyDown(sender As Object, e As KeyEventArgs) Handles dtg.KeyDown
        Select Case State
            Case stateLoad.Dialogo
                If (e.KeyCode = Keys.Enter) Then
                    e.SuppressKeyPress = True
                    OkButton.PerformClick()
                End If
        End Select
    End Sub

    Private Sub QuitFilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        ViewData()
        QuitFilterButton.Visible = False
        QuitFilterButton.Text = "Quitar el filtro"
    End Sub

    Private Sub ViewData()
        Try
            dtg.DataSource = Nothing
            dtg.DataSource = listPerson.OrderBy(Function(x) x.Apellidos) _
                .ThenBy(Function(x) x.Nombre).ToList()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        isClosed = False
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub SettingButton_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingButton.MouseClick
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub dtg_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentDoubleClick
        Me.OkButton.PerformClick()
    End Sub
End Class
