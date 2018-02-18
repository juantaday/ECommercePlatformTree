
Imports CADsisVenta.DataSetPersonTableAdapters
Imports CADsisVenta
Public Class frmAdd_Personas

    Protected Friend idPersona As Integer
    Private state As stateOperation
    Private zona As Boolean
    Private imagenBase As Byte()
    Private idSector As Integer
    Sub New(state As stateOperation, idPersona As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.state = state
        Me.idPersona = idPersona
    End Sub
    Private Sub frmAdd_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Acepte todo en minusculas
        Mays()
        Select Case state
            Case stateOperation.Insert
            Case stateOperation.Update
                Carga_DatosPersona()
            Case stateOperation.View
                Carga_DatosPersona()
                Enable_controls()
        End Select
        Me.Width = 520
        PaneMasDatos.Height = 0
    End Sub

    Private Sub Enable_controls()
        Try
            DatosGroupBox.Enabled = False
            PaneMasDatos.Enabled = False
            Dim control As System.Windows.Forms.Control
            For Each control In OptionalGroupBox.Controls
                If control.Name = "Mas_Informa_Button" Then
                    control.Enabled = True
                Else
                    control.Enabled = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub Mays()
        NombreText.CharacterCasing = CharacterCasing.Upper
        ApellidosText.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub Carga_DatosPersona()
        Try
            Dim dt As New DataTable
            Dim adt As New PersonasTableAdapter()
            dt = adt.GetDataPerson(idPersona)
            If dt.Rows.Count > 0 Then
                ApellidosText.Text = Convert.ToString(dt.Rows(0)("Apellidos"))
                NombreText.Text = Convert.ToString(dt.Rows(0)("Nombre"))
                Ruc_CiText.Text = Convert.ToString(dt.Rows(0)("Ruc_Ci"))
                DireccionText.Text = Convert.ToString(dt.Rows(0)("Direccion"))
                TelefonoText.Text = Convert.ToString(dt.Rows(0)("Telefono"))
                EmailTextBox.Text = Convert.ToString(dt.Rows(0)("mail"))
                Invisible_FechaNaci()
                If IsDate(dt.Rows(0)("fech_Naci")) Then
                    fech_NaciDateTimePicker.Value = dt.Rows(0)("fech_Naci")
                    Fech_NaciCheckBox.Checked = True
                End If

                'carga imagem
                Dim img() As Byte = Nothing
                If IsArray(dt(0)("foto")) Then
                    img = (dt(0)("foto"))
                End If

                If Not IsNothing(img) Then
                    If img.Length > 0 Then
                        imagenBase = (dt(0)("foto"))
                        Dim ms As New IO.MemoryStream(img)
                        PersonPictureBox.Image = Image.FromStream(ms)
                        PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        fotoCheckBox.Checked = True
                    End If
                End If
                'carga genero
                If (dt.Rows(0)("typePerson")) <> 0 Then
                    SexoComboBox.Text = "Empresa"
                    SexoComboBox.Enabled = False
                    TypePersonComboBox.SelectedIndex = 1
                Else
                    SexoComboBox.Text = "Empresa"
                    SexoComboBox.Enabled = True

                    If Boolean.Parse(dt.Rows(0)("genero")) Then
                        SexoComboBox.Text = "Masculino"
                    Else
                        SexoComboBox.Text = "Femenino"
                    End If

                End If

                NotaTextBox.Text = Convert.ToString(dt.Rows(0)("nota"))
                telf_casaTextBox.Text = Convert.ToString(dt.Rows(0)("Telef_casa"))
                telf_oficTextBox.Text = Convert.ToString(dt.Rows(0)("Telef_ofic"))
                'cargamos los datos del sector sy ya esta regristrado en alguno
                Carga_DatosPersonaZona(idPersona)
                Carga_DatosBancos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_DatosPersonaZona(idpersona As Integer)
        Try
            idSector = ClsPerson.getPersonIdSector(idpersona)
            If IsNothing(idSector) Then
                Return
            End If
            If idSector = 0 Then
                Return
            End If
            Dim idParro As Nullable(Of Integer) = Integer.Parse(ClsZona.getIdParroquiaByIdSector(idSector))
            Dim idCanton As Nullable(Of Integer) = Integer.Parse(ClsZona.getIdCantonByIdParroquia(idParro))
            Dim idProvin As Nullable(Of Integer) = Integer.Parse(ClsZona.getIdProvinByIdCanton(idCanton))
            Dim idPais As Nullable(Of Integer) = Integer.Parse(ClsZona.getIdPaisByIdProvin(idProvin))

            Carga_Pais()

            PaisComboBox.SelectedValue = idPais
            provinciaComboBox.SelectedIndex = -1
            provinciaComboBox.SelectedValue = idProvin
            CantonComboBox.SelectedIndex = -1
            CantonComboBox.SelectedValue = idCanton
            ParroquiaComboBox.SelectedIndex = -1
            ParroquiaComboBox.SelectedValue = idParro
            SectorComboBox.SelectedIndex = -1
            SectorComboBox.SelectedValue = idSector

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_DatosBancos()
        Try
            dtGBancos.DataSource = Nothing
            Dim dt As New DataTable
            Dim adt As New PersonBancosTableAdapter()
            dt = adt.GetDataBancos(idPersona)
            If dt.Rows.Count > 0 Then
                dtGBancos.DataSource = dt
                applyGridTheme(dtGBancos)
                clm = dtGBancos.Columns("nom_Banco")
                clm.HeaderText = "Banco"
                clm.Width = "150"

                clm = dtGBancos.Columns("tipo_cuenta")
                clm.HeaderText = "Tipo de cuenta"
                clm.Width = "150"

                clm = dtGBancos.Columns("num_Cuenta")
                clm.HeaderText = "Cuenta"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ApellidosText_Leave(sender As Object, e As EventArgs) Handles ApellidosText.Leave
        sender.Text = Trim(sender.Text)
    End Sub

    Private Sub NombreText_Leave(sender As Object, e As EventArgs) Handles NombreText.Leave
        sender.Text = Trim(sender.Text)
    End Sub

    Private Sub Ruc_CiText_Leave(sender As Object, e As EventArgs) Handles Ruc_CiText.Leave
        sender.Text = Trim(sender.Text)
    End Sub
    Private Function Valida_Datos() As Boolean
        Try
            If String.IsNullOrEmpty(ApellidosText.Text) Then
                ErrorProvider1.SetError(ApellidosText, "Datos obligarorios")
                Return False
            End If
            If String.IsNullOrEmpty(NombreText.Text) Then
                ErrorProvider1.SetError(NombreText, "Datos obligarorios")
                Return False
            End If
            If String.IsNullOrEmpty(Ruc_CiText.Text) Then
                ErrorProvider1.SetError(Ruc_CiText, "Datos obligarorios")
                Return False
            End If

            If TypePersonComboBox.SelectedIndex = -1 Then
                ErrorProvider1.SetError(TypePersonComboBox, "Seleccione una opción")
                Return False
            End If
            If TypePersonComboBox.SelectedIndex = 0 Then
                If Not (SexoComboBox.SelectedIndex > 0) Then
                    ErrorProvider1.SetError(SexoComboBox, "Seleccione una opción")
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            Return False
        End Try
    End Function

    Private Sub LocatedButton_Click(sender As Object, e As EventArgs) Handles LocatedButton.Click
        Try
            Using formew As New frmAdd_Zonas()
                With formew
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Carga_Pais()
                    End If
                End With
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_Pais()
        With PaisComboBox
            .DataSource = ClsZona.getPaisAll()
            .DisplayMember = "Nom_Pais"
            .ValueMember = "idPais"
            .SelectedValue = 0
        End With
    End Sub

    Private Sub Carga_Provincia()
        Try
            With provinciaComboBox
                .DataSource = ClsZona.getProvinciaSelect(PaisComboBox.SelectedValue)
                .DisplayMember = "Nom_Provincia"
                .ValueMember = "idProvincia"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub PaisComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaisComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                Carga_Provincia()
                If provinciaComboBox.Items.Count = 0 Then
                    LimpiaZonaComboBoxs(provinciaComboBox)
                End If
                provinciaComboBox.Enabled = True
                ZonaOKPictureBox.Visible = True
                Return
            Else
                LimpiaZonaComboBoxs(provinciaComboBox)
            End If
        End If
        ZonaOKPictureBox.Visible = False
        provinciaComboBox.Text = "NINGUNA..."
        provinciaComboBox.Enabled = False
        CantonComboBox.Text = "NINGUNA..."
        CantonComboBox.Enabled = False
        ParroquiaComboBox.Text = "NINGUNA..."
        ParroquiaComboBox.Enabled = False
        SectorComboBox.Text = "NINGUNA..."
        SectorComboBox.Enabled = False
    End Sub

    Private Sub provinciaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles provinciaComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                Carga_Canton()
                If CantonComboBox.Items.Count = 0 Then
                    LimpiaZonaComboBoxs(CantonComboBox)
                    LimpiaZonaComboBoxs(ParroquiaComboBox)
                    LimpiaZonaComboBoxs(SectorComboBox)
                End If
                CantonComboBox.Enabled = True
                Return
            Else
                LimpiaZonaComboBoxs(CantonComboBox)
                LimpiaZonaComboBoxs(ParroquiaComboBox)
                LimpiaZonaComboBoxs(SectorComboBox)
            End If
        End If
    End Sub
    Private Sub LimpiaZonaComboBoxs(sender As Object)
        sender.DataSource = Nothing
        sender.Text = ""
        ZonaOKPictureBox.Visible = True
        ZonaOKPictureBox.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        ToolTip1.SetToolTip(ZonaOKPictureBox, "Ruta no especificada.. no se podrà guardar ")
        zona = False
    End Sub
    Private Sub Carga_Canton()
        Try
            With CantonComboBox
                .DataSource = ClsZona.getCanton(provinciaComboBox.SelectedValue)
                .DisplayMember = "Nom_Canton"
                .ValueMember = "idCanton"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Parroquia()
        Try
            With ParroquiaComboBox
                .DataSource = ClsZona.getParroquia(CantonComboBox.SelectedValue)
                .DisplayMember = "Nom_Parroquia"
                .ValueMember = "idParroquia"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Sector()
        Try
            With SectorComboBox
                .DataSource = ClsZona.getSector(ParroquiaComboBox.SelectedValue)
                .DisplayMember = "Nom_Sector"
                .ValueMember = "idSector"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CantonComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CantonComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                Carga_Parroquia()
                If ParroquiaComboBox.Items.Count = 0 Then
                    LimpiaZonaComboBoxs(ParroquiaComboBox)
                    LimpiaZonaComboBoxs(SectorComboBox)
                End If
                ParroquiaComboBox.Enabled = True
                Return
            Else
                LimpiaZonaComboBoxs(ParroquiaComboBox)
                LimpiaZonaComboBoxs(SectorComboBox)
            End If
        End If
    End Sub

    Private Sub ParroquiaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParroquiaComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                Carga_Sector()
                If SectorComboBox.Items.Count = 0 Then
                    LimpiaZonaComboBoxs(SectorComboBox)
                End If
                SectorComboBox.Enabled = True
                Return
            Else
                LimpiaZonaComboBoxs(SectorComboBox)
            End If
        End If
    End Sub
    Private Sub SectorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectorComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                ZonaOKPictureBox.Image = Global.ECommercePlatformView.My.Resources.Resources.ok_32
                ToolTip1.SetToolTip(ZonaOKPictureBox, "Ruta especificada ")
                zona = True
                Return
            End If
        End If
        If PaisComboBox.SelectedValue > 0 Then
            ZonaOKPictureBox.Visible = True
            ZonaOKPictureBox.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
            ToolTip1.SetToolTip(ZonaOKPictureBox, "Ruta no especificada.. no se podrà guardar ")
        Else
            ZonaOKPictureBox.Visible = False
        End If
    End Sub
    Private Sub SectorComboBox_Leave(sender As Object, e As EventArgs) Handles SectorComboBox.Leave
        If Not (IsNothing(sender.DataSource)) And IsNothing(sender.SelectedValue) Then
            Messaje_NotList()
        End If
    End Sub
    Private Sub Messaje_NotList()
        ZonaOKPictureBox.Image = Global.ECommercePlatformView.My.Resources.Resources.Delete_32
        ToolTip1.SetToolTip(ZonaOKPictureBox, "Seleccione uno del listado ")
        zona = False
    End Sub

    Private Sub ParroquiaComboBox_Leave(sender As Object, e As EventArgs) Handles ParroquiaComboBox.Leave
        If Not (IsNothing(sender.DataSource)) And IsNothing(sender.SelectedValue) Then
            Messaje_NotList()
        End If
    End Sub
    Private Sub CantonComboBox_Leave(sender As Object, e As EventArgs) Handles CantonComboBox.Leave
        If Not (IsNothing(sender.DataSource)) And IsNothing(sender.SelectedValue) Then
            Messaje_NotList()
        End If
    End Sub
    Private Sub provinciaComboBox_Leave(sender As Object, e As EventArgs) Handles provinciaComboBox.Leave
        If Not (IsNothing(sender.DataSource)) And IsNothing(sender.SelectedValue) Then
            Messaje_NotList()
        End If
    End Sub
    Private Sub PaisComboBox_Leave(sender As Object, e As EventArgs) Handles PaisComboBox.Leave
        If Not (IsNothing(sender.DataSource)) And IsNothing(sender.SelectedValue) Then
            Messaje_NotList()
        End If
    End Sub

    Private Sub Fech_NaciCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Fech_NaciCheckBox.CheckedChanged
        If Fech_NaciCheckBox.Checked Then
            fech_NaciDateTimePicker.Visible = True
            fech_NaciDateTimePicker.Enabled = True
            fech_Naci_TapaTextBox.Visible = False
        Else
            Invisible_FechaNaci()
        End If
    End Sub
    Private Sub Invisible_FechaNaci()
        fech_NaciDateTimePicker.Visible = False
        With fech_Naci_TapaTextBox
            .Visible = True
            .Width = fech_NaciDateTimePicker.Width
            .Height = fech_NaciDateTimePicker.Height
            .Location = fech_NaciDateTimePicker.Location
        End With
    End Sub

    Private Sub fotoCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles fotoCheckBox.CheckedChanged
        Try
            If fotoCheckBox.Checked Then
                FotoEddButton.Enabled = True
                If Not (IsNothing(imagenBase)) Then
                    If imagenBase.LongLength > 0 Then
                        Dim ms As New IO.MemoryStream(imagenBase)
                        PersonPictureBox.Image = Image.FromStream(ms)
                        PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                End If
            Else
                FotoEddButton.Enabled = False
                PersonPictureBox.Image = Global.ECommercePlatformView.My.Resources.Resources.user_nothing_72
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FotoEddButton_Click(sender As Object, e As EventArgs) Handles FotoEddButton.Click
        Dim dlg = New OpenFileDialog
        Dim imglocation As String = ""

        dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|GIF All (*.*)|*.*"
        dlg.Title = "Seelccione el empleado"
        If dlg.ShowDialog = DialogResult.OK Then
            imglocation = dlg.FileName.ToString()
            PersonPictureBox.ImageLocation = imglocation
            PersonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        If Valida_Datos() Then
            If Operation_Person() Then
                If zona Then
                    Guarda_Zona()
                End If
                DialogResult = DialogResult.OK
                Close()
            End If
        End If
    End Sub
    Private Function Operation_Person() As Boolean
        Try
            Dim foto() As Byte
            Dim fecha_naci As Nullable(Of Date) = Nothing
            Dim genero As Boolean
            'si determinamos la fecha de nacimiento
            If Fech_NaciCheckBox.Checked Then
                fecha_naci = fech_NaciDateTimePicker.Value
            End If
            'si determinamos el genero
            If SexoComboBox.SelectedIndex = 1 Then
                genero = True
            ElseIf SexoComboBox.SelectedIndex = 2 Then
                genero = False
            End If
            'si determinamos la foto
            Dim ms As New IO.MemoryStream()

            If fotoCheckBox.Checked Then
                PersonPictureBox.Image.Save(ms, PersonPictureBox.Image.RawFormat)
                foto = ms.GetBuffer()
            Else
                foto = Nothing
            End If
            Select Case state
                Case stateOperation.Insert
                    If idPersona = 0 Then
                        idPersona = ClsPerson.InsertPerson(ApellidosText.Text, NombreText.Text, Ruc_CiText.Text, DireccionText.Text, TelefonoText.Text,
                         EmailTextBox.Text, fecha_naci, genero, NotaTextBox.Text, foto, telf_casaTextBox.Text, telf_oficTextBox.Text, Me.TypePersonComboBox.SelectedIndex)
                        Return True
                    End If
                Case stateOperation.Update
                    If ClsPerson.UpdatePerson(idPersona, ApellidosText.Text, NombreText.Text, Ruc_CiText.Text, DireccionText.Text, TelefonoText.Text,
                         EmailTextBox.Text, fecha_naci, genero, NotaTextBox.Text, foto, telf_casaTextBox.Text, telf_oficTextBox.Text, Me.TypePersonComboBox.SelectedIndex) Then
                        Return True
                    End If
                Case stateOperation.View
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Mas_Informa_Button_Click(sender As Object, e As EventArgs) Handles Mas_Informa_Button.Click
        Try
            If Mas_Informa_Button.Tag = 0 Then
                Me.Width = 965
                PaneMasDatos.Width = 425
                PaneMasDatos.Height = 425
                PanelLocaliza.Width = 420
                PanelLocaliza.Height = 420
                PanelBancos.Width = 0
                Mas_Informa_Button.Tag = 1
                Mas_Informa_Button.Text = "<= Menos informacíon"
                If Not IsNothing(idSector) Then
                    If idSector = 0 Then
                        Carga_Pais()
                    End If
                End If
            Else
                Me.Width = 520
                PaneMasDatos.Width = 0
                PanelBancos.Width = 0
                Mas_Informa_Button.Tag = 0
                Mas_Informa_Button.Text = "Más informacíon =>"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Guarda_Zona()
        Try
            ClsPerson.UpdatePersonZona(idPersona, SectorComboBox.SelectedValue)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Ruc_CiText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ruc_CiText.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
        'Ascii 
        '8  = Retroceso 
        '58 = dos Puntos Decimales 
        '46 = Punto Decimal 
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub Ruc_CiText_TextChanged(sender As Object, e As EventArgs) Handles Ruc_CiText.TextChanged

    End Sub

    Private Sub returnBancosButton_Click(sender As Object, e As EventArgs) Handles returnBancosButton.Click
        PanelBancos.Width = 0
        PanelLocaliza.Width = 420
    End Sub
    Private Sub gotoBancoButton_Click(sender As Object, e As EventArgs) Handles gotoBancoButton.Click
        PanelLocaliza.Width = 0
        PanelBancos.Width = 420
        Dim localiza As New Point()
        localiza.Y = PanelLocaliza.Location.X
        localiza.X = PanelLocaliza.Location.X
        PanelBancos.Location = localiza
        Carga_Cuentas()
    End Sub

    Private Sub returnLocalizaButton_Click(sender As Object, e As EventArgs) Handles returnLocalizaButton.Click
        Mas_Informa_Button.PerformClick()
    End Sub

    Private Sub accionButton_MouseDown(sender As Object, e As MouseEventArgs) Handles accionButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.actionContextMenuStrip()
            Menu.Show(Cursor.Position)
        End If
    End Sub
    Private Sub actionContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles actionContextMenuStrip.Opening
        actionContextMenuStrip.Items(1).Enabled = Boolean.Parse((dtGBancos.SelectedRows.Count = 1))
        actionContextMenuStrip.Items(2).Enabled = Boolean.Parse((dtGBancos.SelectedRows.Count = 1))
    End Sub
    Public Function Carga_Cuentas() As Boolean
        Try
            Dim dat As New PersonasCuentasTableAdapter
            Dim dt As DataTable = dat.GetData(Me.idPersona)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    Me.dtGBancos.DataSource = dt
                    dtGBancos.Columns(0).Visible = False
                    dtGBancos.Columns(1).Visible = False
                    applyGridTheme(dtGBancos)
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub AgregarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCuentaToolStripMenuItem.Click
        Try
            Using addCuenta As New frmAdd_Cuenta(stateOperation.Insert,
                                             0,
                                            idPersona,
                                             0,
                                             String.Empty,
                                             String.Empty,
                                             String.Format("{0} {1}", ApellidosText.Text, NombreText.Text))
                With addCuenta
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Cuentas()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BorrarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarCuentaToolStripMenuItem.Click
        Try
            sql = "Está seguro de eliminar: " & vbNewLine
            sql = sql & "La cuenta: " & dtGBancos.SelectedCells.Item(dtGBancos.Columns("num_Cuenta").Index).Value & vbNewLine
            sql = sql & "del banco: " & dtGBancos.SelectedCells.Item(dtGBancos.Columns("nom_Banco").Index).Value
            If (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Importante") = MsgBoxResult.Yes) Then

                Using addCuenta As New frmAdd_Cuenta(stateOperation.Delete,
                      dtGBancos.SelectedCells.Item(dtGBancos.Columns("idBancoCuenta").Index).Value,  'idBancoCuenta
                       0, 0, "", "", "")
                    If addCuenta.DialogResult = DialogResult.OK Then
                        Carga_Cuentas()
                    End If
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarCuentaToolStripMenuItem.Click
        Try
            Using addCuenta As New frmAdd_Cuenta(stateOperation.Update,
                         dtGBancos.SelectedCells.Item(dtGBancos.Columns("idBancoCuenta").Index).Value,
                                            idPersona,
                                             dtGBancos.SelectedCells.Item(dtGBancos.Columns("idBanco").Index).Value,
                                            dtGBancos.SelectedCells.Item(dtGBancos.Columns("tipo_cuenta").Index).Value,
                                             dtGBancos.SelectedCells.Item(dtGBancos.Columns("num_Cuenta").Index).Value,
                                               String.Format("{0} {1}", Me.ApellidosText.Text, Me.NombreText.Text))
                With addCuenta
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Cuentas()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub TypePersonComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypePersonComboBox.SelectedIndexChanged
        If TypePersonComboBox.SelectedIndex = 0 Then
            SexoComboBox.SelectedIndex = -1
            SexoComboBox.Enabled = True
        Else
            SexoComboBox.Enabled = False
        End If
    End Sub
End Class