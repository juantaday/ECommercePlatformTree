
Imports CADsisVenta

Public Class Frm_DetailEcommerce
    Private CommerceId As Integer
    Protected Friend IdPersonCommerceId As Integer
    Private idPersonRepresentative As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        load_Data()
        Load_Banck(Me.IdPersonCommerceId)
    End Sub
    Private Sub Frm_DetailCommerce_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub load_Data()

        Try
            Using db As New DataContext()
                Dim myconnerce = (From c In db.myCommerce)
                If myconnerce.Count > 0 Then
                    CommerceId = myconnerce.FirstOrDefault().CommerceId
                    Me.razonSoacialTextBox.Text = myconnerce.FirstOrDefault().RazonSocial
                    Me.rucTextBox.Text = myconnerce.FirstOrDefault().Ruc
                    Me.phoneTextBox.Text = myconnerce.FirstOrDefault().Phone
                    CompaniaTextBox.Text = myconnerce.FirstOrDefault().Compania
                    Dim _date As Date? = myconnerce.FirstOrDefault().DateStar
                    If Not IsNothing(_date) Then
                        CheckBoxDateStar.Checked = True
                        Me.DateStarTimePicker.Value = myconnerce.FirstOrDefault().DateStar
                        Me.DateStarTimePicker.Visible = True
                    Else
                        CheckBoxDateStar.Checked = False
                        Me.DateStarTimePicker.Visible = False
                    End If
                    Me.DomicilioTextBox.Text = myconnerce.FirstOrDefault().Domicilio
                    Dim _IdRepresentative As System.Nullable(Of Integer) = myconnerce.FirstOrDefault().IdRepresentative

                    If Not IsNothing(_IdRepresentative) Then
                        Me.idPersonRepresentative = _IdRepresentative
                    End If
                    Me.NoteTextBox.Text = myconnerce.FirstOrDefault().note

                    Dim _Person = From p In db.Personas
                                  Where p.idPersona = Me.idPersonRepresentative

                    For Each item In _Person
                        Me.representanteTextBox.Text = item.Ruc_Ci & "  " & item.Apellidos & " " & item.Nombre
                    Next

                    Dim InformationInPerson = From p In db.Personas
                                              Where p.Ruc_Ci = myconnerce.FirstOrDefault().Ruc

                    For Each item In InformationInPerson
                        Me.IdPersonCommerceId = item.idPersona
                    Next

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If Valida_Data() Then
            If SaveDetails() Then
                MsgBox("Información guardada correctamente.", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    Private Function SaveDetails() As Boolean
        Try
            Using db As New DataContext()
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    'ANTES DE CAMBIAR COPIO EL RUC DE LA EMPRESA
                    Dim starDate? As DateTime = Nothing
                    If CheckBoxDateStar.Checked Then
                        starDate = DateStarTimePicker.Value
                    End If

                    Dim idRepresent? As Integer = Nothing
                    If Me.idPersonRepresentative > 0 Then
                        idRepresent = idPersonRepresentative
                    End If
                    If Me.CommerceId = 0 Then
                        Dim __myCpmmer As New myCommerce With
                                {
                                    .Compania = CompaniaTextBox.Text,
                                    .DateStar = starDate,
                                    .Domicilio = Me.DomicilioTextBox.Text,
                                    .lema = Me.lemaTextBox.Text,
                                    .note = NoteTextBox.Text,
                                    .Phone = Me.phoneTextBox.Text,
                                    .RazonSocial = Me.razonSoacialTextBox.Text,
                                    .IdRepresentative = idRepresent,
                                    .Ruc = rucTextBox.Text
                                }
                        db.myCommerce.InsertOnSubmit(__myCpmmer)
                        db.SubmitChanges()
                        Me.CommerceId = __myCpmmer.CommerceId

                        Dim _Personas = New Personas With
                        {
                                 .Apellidos = Me.razonSoacialTextBox.Text,
                                  .Direccion = Me.DomicilioTextBox.Text,
                                .fech_Naci = If(Me.CheckBoxDateStar.Checked, Me.DateStarTimePicker.Value, Nothing),
                                .genero = Nothing,
                               .Nombre = String.Empty,
                               .nota = Me.NoteTextBox.Text,
                               .Ruc_Ci = Me.rucTextBox.Text,
                              .telefono = Me.phoneTextBox.Text,
                              .TypePerson = 1
                        }
                        db.Personas.InsertOnSubmit(_Personas)
                        db.SubmitChanges()
                        Me.idPersonRepresentative = _Personas.idPersona
                    Else
                        Dim __myCpmmer = (From c In db.myCommerce
                                          Where c.CommerceId = Me.CommerceId)
                        If __myCpmmer.Count = 1 Then
                            With __myCpmmer.FirstOrDefault()
                                If Me.CheckBoxDateStar.Checked Then
                                    .DateStar = DateStarTimePicker.Value
                                Else
                                    .DateStar = Nothing
                                End If
                                .Compania = CompaniaTextBox.Text
                                .Domicilio = Me.DomicilioTextBox.Text
                                .lema = Me.lemaTextBox.Text
                                .note = NoteTextBox.Text
                                .Phone = Me.phoneTextBox.Text
                                .RazonSocial = Me.razonSoacialTextBox.Text
                                If Me.idPersonRepresentative > 0 Then
                                    .IdRepresentative = Me.idPersonRepresentative
                                Else
                                    .IdRepresentative = Nothing
                                End If
                                .Ruc = rucTextBox.Text
                            End With

                            db.SubmitChanges()
                            Dim _person = From p In db.Personas
                                          Where p.idPersona = Me.IdPersonCommerceId

                            For Each item In _person
                                item.Apellidos = Me.razonSoacialTextBox.Text
                                item.Direccion = Me.DomicilioTextBox.Text
                                If Me.CheckBoxDateStar.Checked Then
                                    item.fech_Naci = Me.DateStarTimePicker.Value
                                End If
                                item.genero = Nothing
                                item.Nombre = String.Empty
                                item.nota = Me.NoteTextBox.Text
                                item.Ruc_Ci = Me.rucTextBox.Text
                                item.telefono = Me.phoneTextBox.Text
                                item.TypePerson = 1
                            Next
                            db.SubmitChanges()
                        End If
                    End If
                    transaction.Commit()
                Catch ex2 As Exception
                    transaction.Rollback()
                    If ex2.Message.Contains("Fk_Mycommerce_Representative") Then
                        MsgBox("Ingrese el representate legal", MsgBoxStyle.Information, "Informacion")
                    Else
                        MsgBox(ex2.Message, vbCritical, "Error")
                    End If

                    Return False
                End Try
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Return False
        End Try
    End Function

    Private Function Valida_Data() As Boolean
        Try
            If String.IsNullOrEmpty(razonSoacialTextBox.Text) Then
                MsgBox("Ingrese razon social..", MsgBoxStyle.Exclamation, "Importante")
                razonSoacialTextBox.Focus()
                Return False
            End If

            If String.IsNullOrEmpty(rucTextBox.Text) Then
                MsgBox("Ingrese ruc..", MsgBoxStyle.Exclamation, "Importante")
                rucTextBox.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    Private Sub AddNewBanckButton_Click(sender As Object, e As EventArgs) Handles AddNewBanckButton.Click
        Try
            If IsNothing(Me.IdPersonCommerceId) OrElse Me.IdPersonCommerceId = 0 Then
                If Not AddCommerceInPerson(Me.CommerceId) Then
                    Return
                End If
                If Me.idPersonRepresentative = 0 Then
                    Return
                End If
            End If

            Using newBanck As New frmAdd_Cuenta(stateOperation.Insert, 0, Me.idPersonRepresentative, 0,
                                                String.Empty, String.Empty, Me.razonSoacialTextBox.Text)
                With newBanck
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If Load_Banck(Me.idPersonRepresentative) Then

                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function AddCommerceInPerson(_commerceId As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _Commerce = From c In db.myCommerce
                                Where c.CommerceId = _commerceId
                For Each item In _Commerce
                    Dim _Person As New Personas With
                        {
                            .Apellidos = item.RazonSocial,
                            .Nombre = String.Empty,
                            .Direccion = item.Domicilio,
                            .fech_Naci = item.DateStar,
                            .genero = Nothing,
                            .nota = item.note,
                            .Ruc_Ci = item.Ruc,
                            .telefono = item.Phone,
                            .TypePerson = 1
                        }
                    db.Personas.InsertOnSubmit(_Person)
                    db.SubmitChanges()
                    Me.idPersonRepresentative = _Person.idPersona
                Next
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Load_Banck(_idPerson As Integer) As Boolean
        Try
            Me.ListView1.Items.Clear()

            Using db As New DataContext
                Dim listBanck = From b In db.Bancos
                                Join bc In db.BancosCuentas On b.idBanco Equals bc.idBanco
                                Where bc.idPersona = _idPerson
                                Select bc.idBancoCuenta, b.nom_Banco, bc.num_Cuenta, bc.tipo_cuenta, b.idBanco

                For Each item In listBanck
                    Me.ListView1.Items.Add(getListView(item))
                Next
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function getListView(item As Object) As ListViewItem
        Dim itemView As New ListViewItem
        With itemView
            .Text = item.idBancoCuenta
            .SubItems.Add(item.nom_Banco)
            .SubItems.Add(item.num_Cuenta)
            .SubItems.Add(item.tipo_cuenta)
            .SubItems.Add(item.idBanco)
        End With
        Return itemView
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count = 1 Then
            Me.EditBanckButton.Enabled = True
            Me.DeleteBanckButton.Enabled = True
        Else
            Me.EditBanckButton.Enabled = False
            Me.DeleteBanckButton.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxDateStar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDateStar.CheckedChanged, CheckBoxDateStar.CheckStateChanged
        Me.DateStarTimePicker.Visible = CheckBoxDateStar.Checked
    End Sub

    Private Sub EditBanckButton_Click(sender As Object, e As EventArgs) Handles EditBanckButton.Click
        Try

            If Not Me.ListView1.SelectedItems.Count = 1 Then
                Return
            End If
            Dim _idCuenatBanco As Integer? = Me.ListView1.SelectedItems(0).Text
            Dim _idBanco As Integer? = Me.ListView1.SelectedItems(0).SubItems(IdBancoClm.Index).Text
            Dim _tipoCuenta As String = Me.ListView1.SelectedItems(0).SubItems(TypoCuentaClm.Index).Text
            Dim _numCuenta As String = Me.ListView1.SelectedItems(0).SubItems(NumCuentaClm.Index).Text

            Using newBanck As New frmAdd_Cuenta(stateOperation.Update, _idCuenatBanco, Me.idPersonRepresentative, _idBanco,
                                                    _tipoCuenta, _numCuenta, Me.razonSoacialTextBox.Text)
                With newBanck
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If Load_Banck(Me.idPersonRepresentative) Then

                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub DeleteBanckButton_Click(sender As Object, e As EventArgs) Handles DeleteBanckButton.Click
        If DeleteBanck() Then
            Load_Banck(Me.idPersonRepresentative)
        End If
    End Sub

    Private Function DeleteBanck() As Boolean
        Try
            Dim _idCuenatBanco As Integer = 0
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                Return False
            End If

            _idCuenatBanco = Me.ListView1.SelectedItems(0).Text

            If MsgBox("Esta seguro de elliminar la cuenta",
                  MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                Using db As New DataContext
                    Dim _Bancocuenta = From bc In db.BancosCuentas
                                       Where bc.idBancoCuenta = _idCuenatBanco

                    For Each item In _Bancocuenta
                        db.BancosCuentas.DeleteOnSubmit(item)
                        db.SubmitChanges()
                        Return True
                    Next
                End Using
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub FindRepresentanteButton_Click(sender As Object, e As EventArgs) Handles FindRepresentanteButton.Click
        Try
            Using ListClient As New frmList_PersonViewTarget(stateLoad.Dialogo)
                With ListClient
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        sql = .PersonVisibleNemuClicLabel.Tag & " - "
                        sql = sql & .PersonVisibleNemuClicLabel.Text
                        Me.representanteTextBox.Text = sql
                        Me.idPersonRepresentative = .idPersona
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


End Class