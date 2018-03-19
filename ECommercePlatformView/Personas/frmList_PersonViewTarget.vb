Imports System.Security.Permissions
Imports CADsisVenta
Public Class frmList_PersonViewTarget
    Private stateLoad As stateLoad
    Protected Friend dtPersonas As New DataTable()
    Protected Friend idPersona As Integer
    Dim IndexDtPerso, countIndexToPage, minIndex, maxIndex As Integer
    Sub New(stateLoad As stateLoad)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateLoad = stateLoad
    End Sub
    Private Sub frmList_Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countIndexToPage = 10
        If Not (stateLoad = stateLoad.Dialogo) Then
            SelectPersonButton.Visible = False
        End If
        If IsNothing(idPersona) Then
            idPersona = 0
        End If
        If Not IsNothing(Me.dtPersonas) Then
            Me.InitializaView(Me.dtPersonas)
        End If
    End Sub
    Sub AddTarget()
        Try
            EditButton.Enabled = False
            DetailsButton.Enabled = False
            DeleteButton.Enabled = False
            PersonVisibleNemuClicLabel.Text = String.Empty
            '
            TableView.SuspendLayout()
            '
            Me.PanelMaster = New System.Windows.Forms.Panel()
            Me.PanelTible = New System.Windows.Forms.Panel()
            Me.PanelCard = New System.Windows.Forms.Panel()
            '
            Me.NomLabel = New System.Windows.Forms.Label()
            Me.EmailLabel = New System.Windows.Forms.Label()
            Me.cedulaLabel = New System.Windows.Forms.Label()
            Me.telefLabel = New System.Windows.Forms.Label()
            '
            Me.PictureBox = New System.Windows.Forms.PictureBox()
            Me.PicturImageCard = New System.Windows.Forms.PictureBox()
            Me.PicturImageTelf = New System.Windows.Forms.PictureBox()
            '
            ' añado el cuadro a la tabla
            Me.TableView.Controls.Add(PanelMaster)
            '
            ' reinicio el diseño
            '
            Me.PanelMaster.SuspendLayout()
            Me.PanelTible.SuspendLayout()
            Me.PanelCard.SuspendLayout()
            Me.NomLabel.SuspendLayout()
            Me.EmailLabel.SuspendLayout()
            Me.cedulaLabel.SuspendLayout()
            Me.telefLabel.SuspendLayout()


            'Panel master
            Me.PanelMaster.BackColor = System.Drawing.Color.GreenYellow
            Me.PanelMaster.Controls.Add(Me.PictureBox)
            Me.PanelMaster.Controls.Add(Me.PanelCard)
            Me.PanelMaster.Controls.Add(Me.PanelTible)
            Me.PanelMaster.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelMaster.Location = New System.Drawing.Point(3, 3)
            Me.PanelMaster.Name = "PanelMaster"
            Me.PanelMaster.Size = New System.Drawing.Size(176, 140)
            Me.PanelMaster.TabIndex = 0
            '
            'Panel de nombres
            '
            Me.PanelTible.Controls.Add(Me.NomLabel)
            Me.PanelTible.Controls.Add(Me.EmailLabel)
            Me.PanelTible.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PanelTible.Location = New System.Drawing.Point(0, 100)
            Me.PanelTible.Name = "PanelTible"
            Me.PanelTible.Size = New System.Drawing.Size(176, 38)
            Me.PanelTible.TabIndex = 0

            'Label1
            '
            Me.NomLabel.AutoSize = True
            Me.NomLabel.Location = New System.Drawing.Point(2, 6)
            Me.NomLabel.Name = "NomLabel"
            Me.NomLabel.Size = New System.Drawing.Size(162, 13)
            Me.NomLabel.TabIndex = 0
            Me.NomLabel.Tag = Convert.ToString(dtPersonas.Rows(IndexDtPerso)("Ruc_Ci"))
            Me.NomLabel.Text = Convert.ToString(dtPersonas.Rows(IndexDtPerso)("Apellidos")) & " " & dtPersonas.Rows(IndexDtPerso)("Nombre")
            '
            'emial
            '
            Me.EmailLabel.AutoSize = True
            Me.EmailLabel.Location = New System.Drawing.Point(2, 22)
            Me.EmailLabel.Name = "EmailLabel"
            Me.EmailLabel.Size = New System.Drawing.Size(147, 13)
            Me.EmailLabel.TabIndex = 1
            Me.EmailLabel.Text = "Email: " & Convert.ToString(dtPersonas.Rows(IndexDtPerso)("mail"))
            '
            'panel de tarjeta
            '       
            Me.PanelCard.Controls.Add(Me.PicturImageCard)
            Me.PanelCard.Controls.Add(Me.cedulaLabel)
            Me.PanelCard.Controls.Add(Me.PicturImageTelf)
            Me.PanelCard.Controls.Add(Me.telefLabel)
            Me.PanelCard.Dock = System.Windows.Forms.DockStyle.Right
            Me.PanelCard.Location = New System.Drawing.Point(95, 0)
            Me.PanelCard.Name = "PanelCard"
            Me.PanelCard.Size = New System.Drawing.Size(81, 102)
            Me.PanelCard.TabIndex = 2
            '
            'cedulaLabel
            '
            Me.cedulaLabel.AutoSize = True
            Me.cedulaLabel.Location = New System.Drawing.Point(0, 17)
            Me.cedulaLabel.Name = "cedulaLabel"
            Me.cedulaLabel.TabIndex = 1
            Me.cedulaLabel.Text = "Cédula:" & Global.Microsoft.VisualBasic.ChrW(10) & Convert.ToString(dtPersonas.Rows(IndexDtPerso)("Ruc_Ci"))
            'telefLabel
            '
            Me.telefLabel.AutoSize = True
            Me.telefLabel.Location = New System.Drawing.Point(0, 67)
            Me.telefLabel.Name = "telefLabel"
            Me.telefLabel.TabIndex = 3
            Me.telefLabel.Text = "Teléfono:" & Global.Microsoft.VisualBasic.ChrW(10) & Convert.ToString(dtPersonas.Rows(IndexDtPerso)("telefono"))
            '
            'PictureBox
            '
            Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox.Name = "PicturePerson"
            Me.PictureBox.Size = New System.Drawing.Size(95, 102)
            Me.PictureBox.TabIndex = 3
            Me.PictureBox.Tag = dtPersonas.Rows(IndexDtPerso)("idPersona")
            Me.PictureBox.TabStop = False
            'carga imagenes--------
            Dim img() As Byte = Nothing
            If IsArray(dtPersonas.Rows(IndexDtPerso)("foto")) Then
                img = dtPersonas(IndexDtPerso)("foto")
            End If

            If Not IsNothing(img) Then
                If img.Length > 0 Then
                    Dim ms As New IO.MemoryStream(img)
                    PictureBox.Image = Image.FromStream(ms)
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Else
                If dtPersonas.Rows(IndexDtPerso)("TypePerson") = 0 Then
                    If Not IsNothing(dtPersonas.Rows(IndexDtPerso)("genero")) Then
                        If dtPersonas.Rows(IndexDtPerso)("genero") Then
                            PictureBox.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            PictureBox.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        End If
                    End If
                ElseIf dtPersonas.Rows(IndexDtPerso)("TypePerson") = 1 Then
                    PictureBox.Image = Global.ECommercePlatformView.My.Resources.myCommerce_48
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
            '
            'PictureBox_Imagen_Car
            '
            Me.PicturImageCard.Location = New System.Drawing.Point(2, 0)
            Me.PicturImageCard.Name = "PicturImageCard"
            Me.PicturImageCard.Size = New System.Drawing.Size(16, 16)
            Me.PicturImageCard.Image = Global.ECommercePlatformView.My.Resources.Resources.Card_16x16
            Me.PicturImageCard.TabIndex = 0
            Me.PicturImageCard.TabStop = False
            '
            'picture lelefono
            Me.PicturImageTelf.Location = New System.Drawing.Point(0, 50)
            Me.PicturImageTelf.Name = "PicturImageTelf"
            Me.PicturImageTelf.Size = New System.Drawing.Size(16, 16)
            Me.PicturImageTelf.Image = Global.ECommercePlatformView.My.Resources.Resources.MobilePhone2_16x16
            Me.PicturImageTelf.TabIndex = 2
            Me.PicturImageTelf.TabStop = False
            '
            'evento de control de datos
            AddHandler PictureBox.Click, AddressOf PanelMas_Enter
            '
            'Actualiza el diseño
            TableView.ResumeLayout(True)
            PanelMaster.ResumeLayout(True)
            PanelTible.ResumeLayout(True)
            PanelCard.ResumeLayout(True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PanelMas_Enter(sender As Object, e As EventArgs)
        Try
            For Each pane In TableView.Controls
                If pane.name = "PanelMaster" Then
                    pane.BackColor = Color.GreenYellow
                End If
            Next
            PersonClickNamaLabel.Tag = sender.tag
            Dim padre As System.Windows.Forms.Panel = sender.Parent
            padre.BackColor = Color.Yellow

            Dim title As New System.Windows.Forms.Panel
            Dim pictureImage As New System.Windows.Forms.PictureBox
            For Each panetitle In padre.Controls
                If (panetitle.name = "PanelTible") Then
                    title = panetitle
                ElseIf (panetitle.name = "PicturePerson") Then
                    pictureImage = panetitle
                End If

            Next

            Dim personLaber As New System.Windows.Forms.Label
            For Each panetitle In title.Controls
                If (panetitle.name = "NomLabel") Then 'PicturePerson
                    personLaber = panetitle
                End If
                sql = panetitle.name
            Next

            TableView.AutoScroll = True
            TableView.ResumeLayout(False)
            PersonVisibleNemuClicLabel.Text = personLaber.Text ' Apellidos y nombres
            PersonVisibleNemuClicLabel.Tag = personLaber.Tag   ' ruc o cedula
            idPersona = pictureImage.Tag                       ' Id de la persona
            DetailsButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            PersonClickNamaLabel.Text = PersonVisibleNemuClicLabel.Text & " (" & PersonVisibleNemuClicLabel.Tag & ")"

            If stateLoad = stateLoad.Dialogo Then
                SelectPersonButton.Visible = True
                SelectPersonButton.Enabled = True
                SelectPersonButton.PerformClick()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Try
            Dim st1 As String = String.Empty
            Dim st2 As String = String.Empty
            Dim st3 As String = String.Empty
            Dim isInsert As Boolean = False
            Dim isEmpy As Boolean = False
            Dim count As Integer = 0
            For Each texto In FindTextBox.Text
                If Not String.IsNullOrWhiteSpace(texto) Then
                    If isInsert And isEmpy Then
                        count += 1
                    End If

                    If count > 2 Then count = 2
                    isInsert = False
                    isEmpy = False
                    Select Case count
                        Case 0
                            st1 = st1 & texto
                            isInsert = True
                        Case 1
                            st2 = st2 & texto
                            isInsert = True
                        Case 2
                            st3 = st3 & texto
                            isInsert = True
                    End Select
                Else
                    isEmpy = True
                End If
            Next
            Me.dtPersonas = ClsPerson.getDataLikePerson(st1, st2, st3)
            If Not IsNothing(dtPersonas) Then
                InitializaView(Me.dtPersonas)
                If Me.dtPersonas.Rows.Count = 1 Then
                    sql = TableView.Controls(0).Controls(0).Name
                    Dim resul As stateLoad = Me.stateLoad
                    Me.stateLoad = stateLoad.List
                    PanelMas_Enter(TableView.Controls(0).Controls(0), New EventArgs)
                    Me.stateLoad = Me.stateLoad
                    Me.SelectPersonButton.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub InitializaView(dtPersonas As DataTable)
        TableView.Controls.Clear()
        TableView.ResumeLayout(True)
        minIndex = 0
        maxIndex = 0
        TotalIndexLabel.Text = String.Empty
        PreviuLinkLabel.Enabled = False
        NextLinkLabel.Enabled = False
        If Not IsNothing(dtPersonas) Then
            If Not (dtPersonas.Rows.Count = 0) Then
                For i = 0 To dtPersonas.Rows.Count - 1
                    IndexDtPerso = i
                    AddTarget()
                    maxIndex = IndexDtPerso
                    If countIndexToPage - 1 = i Then
                        Exit For
                    End If
                Next
                TotalIndexLabel.Text = "Total de lista: " & dtPersonas.Rows.Count
                If dtPersonas.Rows.Count - 1 > maxIndex Then
                    NextLinkLabel.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        If String.IsNullOrWhiteSpace(FindTextBox.Text) Then
            FindTextBox.VisibleButton = False
        Else
            FindTextBox.VisibleButton = True
        End If

        AcceptButton = Nothing
        If FindTextBox.TextLength > 2 Then
            AcceptButton = FindButton
        End If
    End Sub



    Private Sub NextLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NextLinkLabel.LinkClicked
        TableView.Controls.Clear()
        PreviuLinkLabel.Enabled = True
        minIndex = maxIndex + 1
        If maxIndex > dtPersonas.Rows.Count - 1 Then
            maxIndex = dtPersonas.Rows.Count - 1
        End If
        For i = 0 To countIndexToPage
            maxIndex += 1
            IndexDtPerso = maxIndex
            AddTarget()
            If ((dtPersonas.Rows.Count - 1) = IndexDtPerso) Or (i = (countIndexToPage - 1)) Then
                Exit For
            End If
        Next
        If (dtPersonas.Rows.Count - 1) = IndexDtPerso Then
            NextLinkLabel.Enabled = False
        End If
    End Sub

    Private Sub PreviuLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PreviuLinkLabel.LinkClicked
        TableView.Controls.Clear()
        NextLinkLabel.Enabled = True
        minIndex = (minIndex) - countIndexToPage
        If minIndex < 0 Then
            minIndex = 0
        End If
        maxIndex = minIndex - 1
        For i = 0 To countIndexToPage
            maxIndex += 1
            IndexDtPerso = maxIndex
            AddTarget()
            If ((IndexDtPerso = dtPersonas.Rows.Count - 1) Or (i = countIndexToPage - 1)) Then
                Exit For
            End If
        Next
        If (minIndex = 0) Then
            PreviuLinkLabel.Enabled = False
        End If
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

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            Using EddPerson As New frmAdd_Personas(stateOperation.Update, PersonClickNamaLabel.Tag)
                With EddPerson
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        FindTextBox.Text = .Ruc_CiText.Text
                        FindButton.PerformClick()
                        FindTextBox.Text = String.Empty
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    <SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Protected Overrides Function ProcessCmdKey(
                    ByRef msg As Message,
                    keyData As Keys) As Boolean

        If Me.ActiveControl.Name.Equals("FindTextBox") And keyData = Keys.Tab Then
            If Me.dtPersonas.Rows.Count > 0 Then
                Dim reaspo As stateLoad = Me.stateLoad
                Me.stateLoad = stateLoad.List
                PanelMas_Enter(TableView.Controls(0).Controls(0), New EventArgs)
                TableView.Controls(0).Controls(0).Focus()
                Me.stateLoad = reaspo
            End If
            Return True
        ElseIf Me.ActiveControl.Name.Equals("PicturePerson") And keyData = Keys.Tab Then
            If Me.dtPersonas.Rows.Count = 1 Then
                Dim reaspo As stateLoad = Me.stateLoad
                Me.stateLoad = stateLoad.List
                Me.FindTextBox.Focus()
                Me.stateLoad = reaspo
            Else
                Dim reaspo As stateLoad = Me.stateLoad
                Me.stateLoad = stateLoad.List
                PanelMas_Enter(TableView.Controls(0).Controls(0), New EventArgs)
                TableView.Controls(0).Controls(0).Focus()
                Me.stateLoad = reaspo
            End If
            Return True
        End If
        Return False
    End Function

    Private Sub FindTextBox_ButtonClick(sender As Object, e As EventArgs) Handles FindTextBox.ButtonClick
        FindTextBox.Text = String.Empty
        FindTextBox.Focus()
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        Using EddPerson As New frmAdd_Personas(stateOperation.View, PersonClickNamaLabel.Tag)
            With EddPerson
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    FindTextBox.Text = .Ruc_CiText.Text
                    FindButton.PerformClick()
                    FindTextBox.Text = String.Empty
                End If
            End With
        End Using
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            sql = "Está seguro de eliminar registro.?" + vbNewLine
            sql = sql + PersonClickNamaLabel.Text
            If MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                If ClsPerson.DeletePerson(PersonClickNamaLabel.Tag) > 0 Then
                    FindButton.PerformClick()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SelectPersonButton_Click(sender As Object, e As EventArgs) Handles SelectPersonButton.Click
        If idPersona > 0 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("No se pudo determinar a la persona")
        End If
    End Sub
End Class
