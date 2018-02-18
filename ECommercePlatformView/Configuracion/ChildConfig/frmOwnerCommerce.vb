Imports CADsisVenta

Public Class frmOwnerCommerce
    Private ListOwer As List(Of ItemOwner)
    Private idAutoMatic As Int32
    Private idPerson As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        idAutoMatic = -1
        ListOwer = New List(Of ItemOwner)
        Load_Data()
        ViewItemInListView()
    End Sub

    Private Sub ViewItemInListView()
        Try
            Me.ListView1.Items.Clear()
            For Each item In ListOwer
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
                .SubItems.Add(item.Phone)
                .SubItems.Add(item.Email)
                .SubItems.Add(item.NamePositions)
            End With
            Return myItem
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return myItem
        End Try
    End Function

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


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub frmChildOWnerCommerce_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SaveListOwner Then
            MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Function SaveListOwner() As Boolean
        Try
            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction

                Try
                    Dim _Owner = From p In db.Propietarios

                    For Each item As Propietarios In _Owner
                        Dim result = ListOwer.Where(Function(x) x.IdPropietarios = item.idPropietarios).FirstOrDefault()
                        If IsNothing(result) Then
                            db.Propietarios.DeleteOnSubmit(item)
                        End If
                    Next
                    db.SubmitChanges()
                    'update the list
                    For Each item In _Owner
                        Dim _idPosition As Integer? = ListOwer.Where(Function(x) x.IdPropietarios = item.idPropietarios) _
                                                       .FirstOrDefault().IdPositions
                        If _idPosition = 0 Then
                            item.idPosition = Nothing
                        Else
                            item.idPosition = _idPosition
                        End If

                        ListOwer.Where(Function(x) x.IdPropietarios = item.idPropietarios).FirstOrDefault() _
                            .IsUpdate = True
                    Next
                    db.SubmitChanges()
                    'Add new Person
                    For Each item In ListOwer.Where(Function(x) x.IsUpdate = False)
                        Dim _idPosition As Integer? = item.IdPositions
                        If _idPosition = 0 Then
                            _idPosition = Nothing
                        End If
                        Dim _Propietarios = New Propietarios With
                                {
                                .idPerson = item.IdPerson,
                                .idPosition = _idPosition,
                                .Salary = 0
                                }
                        db.Propietarios.InsertOnSubmit(_Propietarios)
                    Next
                    db.SubmitChanges()
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 1 Then
            Me.EditButton.Enabled = True
            Me.DeleteButton.Enabled = True
        Else
            Me.EditButton.Enabled = False
            Me.DeleteButton.Enabled = False
        End If
    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        Try
            Using ListClient As New frmList_PersonViewTarget(stateLoad.Dialogo)
                With ListClient
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        idPerson = .PersonClickNamaLabel.Tag
                        If AddOwner(idPerson) Then
                            Me.ViewItemInListView()
                            SelectedImte(idPerson)
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SelectedImte(_idPerson As Integer)
        Try
            Dim i As Integer = 0
            For Each item In ListOwer
                If item.IdPerson = _idPerson Then
                    Me.ListView1.Items(i).Selected = True
                Else
                    Me.ListView1.Items(i).Selected = False
                End If
                i += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function AddOwner(_idPerson As Integer)
        Try
            Using db As New DataContext
                Dim _person = (From p In db.Personas
                               Where p.idPersona = _idPerson).FirstOrDefault()

                If Not IsNothing(_person) Then
                    Dim _owner As New ItemOwner With
                        {
                                .Email = _person.mail,
                                .IdPerson = _person.idPersona,
                                .IdPositions = 0,
                                .NamePerson = String.Format("{0} {1}", _person.Apellidos, _person.Nombre),
                                .NamePositions = String.Empty,
                                .Phone = _person.telefono,
                                .RucCI = _person.Ruc_Ci,
                                .IdPropietarios = idAutoMatic
                            }
                    idAutoMatic -= 1
                    ListOwer.Add(_owner)
                End If
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MsgBox(msgDelete, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
            If DeleteOwner(Integer.Parse(ListView1.SelectedItems(0).Text)) Then
                ViewItemInListView()
            End If
        End If
    End Sub

    Private Function DeleteOwner(_idProperties As Integer) As Boolean
        Try

            Dim ItemOwner = (From l In ListOwer).Where(Function(x) x.IdPropietarios = _idProperties).FirstOrDefault()
            If Not IsNothing(ItemOwner) Then
                ListOwer.Remove(ItemOwner)
                Return True
            End If
            Return False
        Catch ex As Exception
            If ex.Message.Contains("enumaracin") Then
                Return True
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class