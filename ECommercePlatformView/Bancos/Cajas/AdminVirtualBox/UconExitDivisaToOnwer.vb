Imports CADsisVenta
Imports ECommercePlatformView

Public Class UconExitDivisaToOnwer
    Private IdPersonAccount As Integer
    Private IdVirtualBox As Integer
    Private ListOwer As List(Of ItemOwner)
    Private MyParent As frmExitMoneyVirtualBox
    Sub New(ByVal _MyParent As frmExitMoneyVirtualBox, ByVal _idVirtualBox As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IdVirtualBox = _idVirtualBox
        MyParent = _MyParent
    End Sub

    Private Sub UconExitDivisaToOnwer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListOwer = New List(Of ItemOwner)
        Load_Data()
    End Sub
    Private Sub Load_Data()
        Try
            ListOwer.Clear()
            Using db As New DataContext
                Dim myProperty = From p In db.Propietarios
                                 Join r In db.Personas On p.idPerson Equals r.idPersona
                                 Group Join c In db.Positions On p.idPosition Equals c.idPositions
                                  Into PetList = Group
                                 From Pet In PetList.DefaultIfEmpty
                                 Select p.idPropietarios, p.idPerson, r.Apellidos, r.Nombre, r.Ruc_Ci,
                                  r.telefono, r.mail, idPositions = If(Pet Is Nothing, 0, Pet.idPositions),
                                       Name_Positios = If(Pet Is Nothing, String.Empty, Pet.Name_Position)

                For Each item In myProperty
                    Dim _owner As New ItemOwner With
                        {
                            .Email = item.mail,
                            .IdPerson = item.idPerson,
                            .IdPositions = item.idPositions,
                            .IdPropietarios = item.idPropietarios,
                            .NamePerson = String.Format("{0} {1}", item.Apellidos, item.Nombre),
                            .NamePositions = item.Name_Positios,
                            .Phone = item.telefono,
                            .RucCI = item.Ruc_Ci
                       }

                    ListOwer.Add(_owner)
                Next
            End Using

            ViewData(ListOwer)
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
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Load_Data()
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
            ViewData(ListOwer.Where(Function(x) x.RucCI.Contains(myFindText)).ToList())
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub FindClienWithParameters(v1 As String, v2 As String, v3 As String, v4 As Integer)
        Try
            Dim list1 As New List(Of ItemOwner)
            Dim list2 As New List(Of ItemOwner)
            Dim list3 As New List(Of ItemOwner)
            Dim listResult As New List(Of ItemOwner)
            Select Case v4
                Case 1
                    list1 = ListOwer.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    listResult = list1
                Case 2
                    list1 = ListOwer.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    listResult = list2
                Case 3
                    list1 = ListOwer.Where(Function(x) x.FullName.ToUpper().Contains(v1.ToUpper())).ToList()
                    list2 = list1.Where(Function(x) x.FullName.ToUpper().Contains(v2.ToUpper())).ToList()
                    list3 = list2.Where(Function(x) x.FullName.ToUpper().Contains(v3.ToUpper())).ToList()
                    listResult = list3
            End Select

            ViewData(listResult)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ViewData(list As List(Of ItemOwner))
        Try
            Me.ListView1.Items.Clear()
            For Each item In list
                ListView1.Items.Add(SetItem(item))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function SetItem(item As ItemOwner) As ListViewItem
        Dim myItem As New ListViewItem
        Try
            With myItem
                .Text = item.IdPropietarios
                .SubItems.Add(item.RucCI)
                .SubItems.Add(item.NamePerson)
                .SubItems.Add(item.NamePositions)
                .SubItems.Add(item.Email)
                .SubItems.Add(item.Phone)
            End With
            Return myItem
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return myItem
        End Try
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 1 Then
            Me.SubmitButton.Enabled = True
        Else
            Me.SubmitButton.Enabled = False
        End If
    End Sub
    Private Sub QuitFilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        FindTextBox.Text = String.Empty
        ViewData(Me.ListOwer)
        QuitFilterButton.Visible = False
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleccione el propietario que retira", MsgBoxStyle.Exclamation, "Importante")
                ListView1.Focus()
                Return
            End If

            Dim userAurization As String
            Dim destino As String
            Using newform As New LoginForm(stateReturn._response, "Administrador de cajas")
                With newform
                    .ShowDialog()
                    If Not .DialogResult = DialogResult.OK Then
                        Return
                    End If
                    userAurization = .UsernameTextBox.Text
                    destino = "Retiro de la caja virtual por :[" & Me.ListView1.SelectedItems(0).Text & "]/ "
                    destino = destino & Me.ListOwer.Where(Function(x) x.IdPropietarios = ListView1.SelectedItems(0).Text).FirstOrDefault().FullName
                End With
            End Using

            If SaveTransfer(IdVirtualBox, userAurization, destino) Then
                MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                MyParent.DialogResult = DialogResult.OK
                MyParent.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Function SaveTransfer(_idVirtualBox As Integer, _userAurization As String, _destino As String) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim LastSaldo As Double = 0

                    Dim _saldo = From s In db.VirtualBox
                                 Where s.idVirtualBox = _idVirtualBox

                    For Each item In _saldo
                        LastSaldo = item.Saldo
                    Next

                    Dim newSaldoVirtual As Double = LastSaldo - MyParent.MontoDivisa
                    Dim _VirtualBoxDetails As New VirtualBoxDetails With
                            {
                                .idVirtualBox = _idVirtualBox,
                                .debe = 0,
                                .Descripcion = _destino & "/ Autorizado por: " & _userAurization,
                                .haber = MyParent.MontoDivisa,
                                .saldo = newSaldoVirtual
                            }
                    db.VirtualBoxDetails.InsertOnSubmit(_VirtualBoxDetails)
                    db.SubmitChanges()
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

End Class
