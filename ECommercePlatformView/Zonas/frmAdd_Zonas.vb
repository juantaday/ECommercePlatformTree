Imports CADsisVenta

Public Class frmAdd_Zonas
    Private cargado As Boolean
    Private idProvincia_Activa As Integer
    Private idCanton_Activa As Integer
    Private idParroquia_Activa As Integer
    Private idSector_Activo As Integer
    Private ult_Provincia, ult_Canton, ult_Parroqui As Integer
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles _CancelButton.Click
        Close()
    End Sub

    Private Sub frmZonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPageCanton.Parent = Nothing ' Ocultar Tabpage
        TabPageParroq.Parent = Nothing ' Ocultar Tabpage
        TabPageSector.Parent = Nothing ' Ocultar Tabpage
        Carga_Pais()
    End Sub
    Private Sub Add_NewProvinLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Add_NewProvinLinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Provincia"
                .idPais = PaisComboBox.SelectedValue
                .ActionProc = frmZonasDescrip.Estado.Insert
                .Text = "Agregando nueva provincia.."
                .TableLayoutPanel2.TabIndex = 0
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Carga_DatosProvincia()
                End If
            End With
        End Using
    End Sub
    Sub Carga_DatosProvincia()
        Try
            cargado = False
            With dtGridViewProvincia
                .DataSource = ClsZona.getProvincia(PaisComboBox.SelectedValue)
                .Columns(1).Visible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Dim but As New DataGridViewButtonColumn
                applyGridTheme(dtGridViewProvincia)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
            ult_Provincia = idProvincia_Activa
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cargado = True
        End Try
    End Sub
    Private Sub Edit_ProvincinLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Edit_ProvincinLinkLabel.LinkClicked
        Try
            Dim row As Integer = dtGridViewProvincia.CurrentRow.Index
            Using frmZonasDescrip
                With frmZonasDescrip
                    .stateLoad = "Provincia"
                    .idPais = PaisComboBox.SelectedValue
                    .ActionProc = frmZonasDescrip.Estado.Update
                    .id = Integer.Parse(dtGridViewProvincia.Rows(row).Cells(dtGridViewProvincia.Columns("idProvincia").Index).Value)
                    sql = "Cambiando provincia de: " & dtGridViewProvincia.Rows(row).Cells("Nom_Provincia").Value
                    .Text = sql
                    .NomTextBox.Text = dtGridViewProvincia.Rows(row).Cells("Nom_Provincia").Value
                    .LatitudNumericUpDown.Value = dtGridViewProvincia.Rows(row).Cells("latitud").Value
                    .LongitudNumericUpDown.Value = dtGridViewProvincia.Rows(row).Cells("longitud").Value
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_DatosProvincia()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Delet_ProvinceLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Delet_ProvinceLinkLabel.LinkClicked
        Try
            If Confirmation() Then
                If ClsZona.DeleteProvincia(idProvincia_Activa) > 0 Then
                    Carga_DatosProvincia()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dataGridViewProvincia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewProvincia.CellClick
        If cargado Then
            If dtGridViewProvincia.SelectedRows.Count = 1 Then
                Edit_ProvincinLinkLabel.Enabled = True
                Delet_ProvinceLinkLabel.Enabled = True
                idProvincia_Activa = dtGridViewProvincia.Rows(dtGridViewProvincia.CurrentRow.Index).Cells("idProvincia").Value
            Else
                Edit_ProvincinLinkLabel.Enabled = False
                Delet_ProvinceLinkLabel.Enabled = False
            End If
        End If
    End Sub

    Private Sub dataGridViewProvincia_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewProvincia.RowEnter
        If cargado Then
            If dtGridViewProvincia.SelectedRows.Count = 1 Then
                Edit_ProvincinLinkLabel.Enabled = True
                Delet_ProvinceLinkLabel.Enabled = True
                idProvincia_Activa = dtGridViewProvincia.Rows(dtGridViewProvincia.CurrentRow.Index).Cells("idProvincia").Value
                Edit_ProvincinLinkLabel.Enabled = False
                Delet_ProvinceLinkLabel.Enabled = False
            End If
        End If
    End Sub
    Private Sub dataGridViewProvincia_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtGridViewProvincia.CellFormatting
        If cargado Then
            If e.RowIndex >= 0 And e.ColumnIndex = 0 Then
                e.Value = "Ver cantones"
            End If
        End If
    End Sub
    Sub Carga_datosCanton()
        Try
            idProvincia_Activa = dtGridViewProvincia.SelectedRows(0).Cells("idProvincia").Value
            cargado = False
            With dtGridCanton
                .DataSource = Nothing
                .DataSource = ClsZona.getCanton(idProvincia_Activa)
                .Columns(1).Visible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                applyGridTheme(dtGridCanton)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                ult_Canton = idCanton_Activa
                ult_Provincia = idProvincia_Activa
            End With
            canton_des_Label.Text = "Cantones de la provincia de :" & dtGridViewProvincia.SelectedRows(0).Cells("Nom_Provincia").Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.MsgBoxRight, "Error")
        Finally
            cargado = True
        End Try
    End Sub

    Private Sub new_cantonLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles new_cantonLinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Canton"
                .Text = "Agregando cantones a la provincia " & dtGridViewProvincia.SelectedRows(0).Cells("Nom_Provincia").Value
                .ActionProc = frmZonasDescrip.Estado.Insert
                .id_Provincia = idProvincia_Activa
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    carga_datosCanton()
                End If
            End With
        End Using
    End Sub

    Private Sub LisProvincia_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LisProvincia_LinkLabel.LinkClicked
        TabPageCanton.Parent = Nothing
        TabPageProvincias.Parent = TabControl
    End Sub

    Private Sub dtGridCanton_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridCanton.CellClick
        If cargado Then
            If sender.SelectedRows.Count = 1 Then
                UpdateCanton_LinkLabel.Enabled = True
                Delete_CantonLinkLabel.Enabled = True
                idCanton_Activa = sender.SelectedRows(0).Cells("idCanton").Value
                List_CantonesLinkLabel.Text = "Cantones de la provincia de " & dtGridViewProvincia.SelectedRows(0).Cells("Nom_Provincia").Value
            Else
                UpdateCanton_LinkLabel.Enabled = False
                Delete_CantonLinkLabel.Enabled = False
            End If

        End If
    End Sub

    Private Sub dtGridCanton_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridCanton.CellContentClick
        If e.RowIndex >= 0 And sender.columns(e.ColumnIndex).name = "butoonViewParroquia" Then
            TabPageCanton.Parent = Nothing
            TabPageParroq.Parent = TabControl
            If ult_Canton <> idCanton_Activa Then
                carga_datosParroquia()
            End If
        End If
    End Sub
    Private Sub dtGridCanton_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridCanton.RowEnter
        If cargado Then
            If sender.SelectedRows.Count = 1 Then
                UpdateCanton_LinkLabel.Enabled = True
                Delete_CantonLinkLabel.Enabled = True
                idCanton_Activa = sender.SelectedRows(0).Cells("idCanton").Value
                List_CantonesLinkLabel.Text = "Cantones de la provincia de " & dtGridViewProvincia.SelectedRows(0).Cells("Nom_Provincia").Value
            Else
                UpdateCanton_LinkLabel.Enabled = False
                Delete_CantonLinkLabel.Enabled = False
            End If

        End If
    End Sub

    Private Sub dtGridCanton_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtGridCanton.CellFormatting
        If cargado Then
            If e.RowIndex >= 0 And sender.Columns(e.ColumnIndex).name = "butoonViewParroquia" Then
                e.Value = "Ver parroquias"
            End If
        End If
    End Sub

    Private Sub UpdateCanton_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UpdateCanton_LinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Canton"
                .Text = "Modificando cantón: " & dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
                .NomTextBox.Text = dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
                .ActionProc = frmZonasDescrip.Estado.Update
                .id_Provincia = idProvincia_Activa
                .id = idCanton_Activa
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Carga_datosCanton()
                End If
            End With
        End Using
    End Sub

    Private Sub Delete_CantonLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Delete_CantonLinkLabel.LinkClicked
        If Confirmation() Then
            ClsZona.DeleteCanton(idCanton_Activa)
            Carga_datosCanton()
        End If
    End Sub

    Private Function Confirmation() As Boolean
        If MsgBox("Está seguro de eliminar", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub List_CantonesLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles List_CantonesLinkLabel.LinkClicked
        TabPageParroq.Parent = Nothing
        TabPageCanton.Parent = TabControl
    End Sub

    Private Sub dtGridViewParroquia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewParroquia.CellContentClick
        If e.RowIndex >= 0 And sender.columns(e.ColumnIndex).name = "ButtonViewSector" Then
            TabPageParroq.Parent = Nothing
            TabPageSector.Parent = TabControl
            If ult_Parroqui <> idParroquia_Activa Then
                Carga_DatosSector()
            End If
        End If
    End Sub

    Private Sub Carga_DatosSector()
        Try
            cargado = False
            idParroquia_Activa = dtGridViewParroquia.SelectedRows(0).Cells("idParroquia").Value
            With dtGridViewSector
                .DataSource = Nothing
                .DataSource = ClsZona.getSector(idParroquia_Activa)
                .Columns(0).Visible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                applyGridTheme(dtGridViewSector)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
            Sector_des_label.Text = "Sectores de la parroquia:" & dtGridViewParroquia.SelectedRows(0).Cells("Nom_Parroquia").Value
            ult_Parroqui = idParroquia_Activa
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.MsgBoxRight, "Error")
        Finally
            cargado = True
        End Try
    End Sub

    Private Sub List_ParroquiaLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles List_ParroquiaLinkLabel.LinkClicked
        TabPageSector.Parent = Nothing
        TabPageParroq.Parent = TabControl
    End Sub

    Private Sub dtGridViewSector_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewSector.CellClick
        If cargado Then
            If sender.SelectedRows.Count = 1 Then
                Update_sectorLinkLabe.Enabled = True
                Delete_sectorLinkLabel1.Enabled = True
                idSector_Activo = sender.SelectedRows(0).Cells("idSector").Value
            Else
                Update_sectorLinkLabe.Enabled = False
                Delete_sectorLinkLabel1.Enabled = False
            End If
        End If
    End Sub

    Private Sub new_sectorLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles new_sectorLinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Sector"
                .Text = "Agregando nuevo sector a la parroquia: " & dtGridViewParroquia.SelectedRows(0).Cells("Nom_Parroquia").Value
                .ActionProc = frmZonasDescrip.Estado.Insert
                .id_Parroquia = idParroquia_Activa
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Carga_DatosSector()
                End If
            End With
        End Using
    End Sub

    Private Sub New_ParroquiaLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles New_ParroquiaLinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Parroquia"
                .Text = "Agregando nueva parroquia al canton: " & dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
                .ActionProc = frmZonasDescrip.Estado.Insert
                .id_Canton = idCanton_Activa
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    carga_datosParroquia()
                End If
            End With
        End Using
    End Sub

    Private Sub dtGridViewParroquia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewParroquia.CellClick
        If cargado Then
            If sender.SelectedRows.Count = 1 Then
                Update_ParroquiaLinkLabel.Enabled = True
                DeleteParroquiaLinkLabel.Enabled = True
                idParroquia_Activa = sender.SelectedRows(0).Cells("idParroquia").Value
                List_ParroquiaLinkLabel.Text = "Ver parroquias del canton " & dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
            Else
                Update_ParroquiaLinkLabel.Enabled = False
                DeleteParroquiaLinkLabel.Enabled = False
            End If
        End If
    End Sub

    Private Sub Delete_sectorLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Delete_sectorLinkLabel1.LinkClicked
        If Confirmation() Then
            If ClsZona.DeleteSector(idSector_Activo) > 0 Then
                Carga_DatosSector()
            End If
        End If
    End Sub

    Private Sub carga_datosParroquia()
        Try
            cargado = False
            idCanton_Activa = dtGridCanton.SelectedRows(0).Cells("idCanton").Value
            With dtGridViewParroquia
                .DataSource = Nothing
                .DataSource = ClsZona.getParroquia(idCanton_Activa)
                .Columns(1).Visible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                Dim but As New DataGridViewButtonColumn
                applyGridTheme(dtGridViewParroquia)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
            ult_Canton = idCanton_Activa
            Parroquia_desc_Label.Text = "Parroquias del cantón " & dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cargado = True
        End Try
    End Sub

    Private Sub DeleteParroquiaLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteParroquiaLinkLabel.LinkClicked
        If Confirmation() Then
            If ClsZona.DeleteParroquia(idParroquia_Activa) > 0 Then
                carga_datosParroquia()
            End If
        End If
    End Sub

    Private Sub Update_ParroquiaLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Update_ParroquiaLinkLabel.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Parroquia"
                .Text = "Modificando parroquia: " & dtGridViewParroquia.SelectedRows(0).Cells("Nom_Parroquia").Value
                .NomTextBox.Text = dtGridViewParroquia.SelectedRows(0).Cells("Nom_Parroquia").Value
                .ActionProc = frmZonasDescrip.Estado.Update
                .id_Canton = idCanton_Activa
                .id = idParroquia_Activa
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    carga_datosParroquia()
                End If
            End With
        End Using
    End Sub

    Private Sub dtGridViewProvincia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridViewProvincia.CellContentClick
        If e.RowIndex >= 0 And sender.columns(e.ColumnIndex).name = "butoonViewCanton" Then
            TabPageProvincias.Parent = Nothing
            TabPageCanton.Parent = TabControl
            If sender.rows(e.RowIndex).cells("idProvincia").value <> ult_Provincia Then
                Carga_datosCanton()
            End If
        End If
    End Sub
    Private Sub dtGridViewParroquia_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtGridViewParroquia.CellFormatting
        If e.RowIndex >= 0 And sender.columns(e.ColumnIndex).name = "ButtonViewSector" Then
            e.Value = "Ver sectores"
        End If
    End Sub

    Private Sub dtGridViewParroquia_RowErrorTextChanged(sender As Object, e As DataGridViewRowEventArgs) Handles dtGridViewParroquia.RowErrorTextChanged
        If cargado Then
            If sender.SelectedRows.Count = 1 Then
                Update_ParroquiaLinkLabel.Enabled = True
                DeleteParroquiaLinkLabel.Enabled = True
                idParroquia_Activa = sender.SelectedRows(0).Cells("idParroquia").Value
                List_ParroquiaLinkLabel.Text = "Ver parroquias del canton " & dtGridCanton.SelectedRows(0).Cells("Nom_Canton").Value
            Else
                Update_ParroquiaLinkLabel.Enabled = False
                DeleteParroquiaLinkLabel.Enabled = False
            End If
        End If
    End Sub

    Private Sub Update_sectorLinkLabe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Update_sectorLinkLabe.LinkClicked
        Using frmZonasDescrip
            With frmZonasDescrip
                .stateLoad = "Sector"
                .Text = "Modificando sector: " & dtGridViewSector.SelectedRows(0).Cells("Nom_Sector").Value
                .NomTextBox.Text = dtGridViewSector.SelectedRows(0).Cells("Nom_Sector").Value
                .ActionProc = frmZonasDescrip.Estado.Update
                .id_Parroquia = idParroquia_Activa
                .id = idSector_Activo
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Carga_DatosSector()
                End If
            End With
        End Using
    End Sub

    Private Sub PaisComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaisComboBox.SelectedIndexChanged
        Try
            If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
                If sender.selectedValue > 0 Then
                    Pais_DeleteButton.Enabled = True
                    Edd_PaisButton.Enabled = True
                    Carga_DatosProvincia()
                    If dtGridViewProvincia.RowCount = 0 Then
                        Edit_ProvincinLinkLabel.Enabled = False
                        Delet_ProvinceLinkLabel.Enabled = False
                    Else
                        Edit_ProvincinLinkLabel.Enabled = True
                        Delet_ProvinceLinkLabel.Enabled = True
                    End If
                    TabControl.Enabled = True
                    Return
                Else
                    dtGridViewProvincia.DataSource = Nothing
                    Edit_ProvincinLinkLabel.Enabled = False
                    Delet_ProvinceLinkLabel.Enabled = False
                End If
            End If
            Edd_PaisButton.Enabled = False
            Pais_DeleteButton.Enabled = False
            TabControl.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Pais()
        Try
            With PaisComboBox
                .DataSource = ClsZona.getPaisAll()
                .DisplayMember = "Nom_Pais"
                .ValueMember = "idPais"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged

    End Sub

    Private Sub TabPageProvincias_ParentChanged(sender As Object, e As EventArgs) Handles TabPageProvincias.ParentChanged
        Try
            If IsNothing(TabPageProvincias.Parent) Then
                PanePais.Enabled = False
            Else
                PanePais.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Edd_PaisButton_Click(sender As Object, e As EventArgs) Handles Edd_PaisButton.Click
        Try
            Using frmZonasDescrip
                With frmZonasDescrip
                    .stateLoad = "Pais"
                    .ActionProc = frmZonasDescrip.Estado.Update
                    .id = Integer.Parse(PaisComboBox.SelectedValue)
                    sql = "Cambiando (Páis): " & PaisComboBox.Text
                    .Text = sql
                    .NomTextBox.Text = PaisComboBox.Text
                    .LatitudNumericUpDown.Enabled = False
                    .LongitudNumericUpDown.Enabled = False
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Pais()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Pais_newButton_Click(sender As Object, e As EventArgs) Handles Pais_newButton.Click
        Try
            Using frmZonasDescrip
                With frmZonasDescrip
                    .stateLoad = "Pais"
                    .ActionProc = frmZonasDescrip.Estado.Insert
                    sql = "Agregando nuevo pías"
                    .Text = sql
                    .NomTextBox.Text = ""
                    .LatitudNumericUpDown.Enabled = False
                    .LongitudNumericUpDown.Enabled = False
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Pais()
                        PaisComboBox.Text = .NomTextBox.Text
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PaisComboBox_Leave(sender As Object, e As EventArgs) Handles PaisComboBox.Leave
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.SelectedIndex > 0 Then
                TabControl.Enabled = True
                Pais_DeleteButton.Enabled = True
                Edd_PaisButton.Enabled = True
                Return
            End If
        End If
        Pais_DeleteButton.Enabled = False
        TabControl.Enabled = False
        Edd_PaisButton.Enabled = False
    End Sub

    Private Sub Pais_DeleteButton_Click(sender As Object, e As EventArgs) Handles Pais_DeleteButton.Click
        sql = "Está seguro de eliminar..!" & vbNewLine
        sql = sql & "toda la infromación de: " & PaisComboBox.Text
        If MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Impotante") = MsgBoxResult.Yes Then
            If ClsZona.DeletePais(PaisComboBox.SelectedValue) Then
                Carga_Pais()
            End If
        End If
    End Sub

End Class