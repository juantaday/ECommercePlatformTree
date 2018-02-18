Imports CADsisVenta
Imports CADsisVenta.DataSetVentasTableAdapters
Imports ECommercePlatformView.DebitEmployeeNameSpace

Public Class frmList_CuentasXcobrar
    Private cargado As Boolean
    Private idcliente As Integer
    Private IdPerson As Integer
    Private SelectIndexUbicated As Integer
    Private NameCliente As String
    Private totalGeneral As Double
    Private totalDeudaVenta As Double

    Private ListDebitEployee As DebitEmployeeCollection

    Dim masterDetail As MasterControl
    Private Sub frmList_DeudaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListDebitEployee = New DebitEmployeeCollection
        PersonalizeGridView()
        SelectIndexUbicated = -1
        Carga_ComboBoxProvincia()
        Carga_Datosclientes()
        Load_DebitEployee()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PersonalizeGridView()
        Try
            dtgEmployee.AutoGenerateColumns = False
            applyGridTheme(dtgEmployee)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_DebitEployee()
        Try
            totalGeneral = totalDeudaVenta
            ListDebitEployee.Clear()

            Using db As New DataContext
                Dim _debitEmployee = From p In db.GetAllEmployeeDebt
                For Each item In _debitEmployee
                    ListDebitEployee.Add(New DebitEmployee() With
                            {
                              .IdEmpleadoDeuda = item.idEmpleadoDeuda,
                              .TypeDebit = "Responsabilidades",
                              .Document = item.idEmpleadoDeuda,
                              .Apellidos = item.Apellidos,
                              .DebitDate = item.DebitDate,
                              .DebitValue = item.DevitValue,
                              .IdPerson = item.idPersona,
                              .Nombres = item.Nombre,
                              .RucCi = item.Ruc_Ci,
                              .PaymentDebit = item.valCobrado
                            })
                Next

                If ListDebitEployee.Count > 0 Then
                    Dim totalDebit = Aggregate em In ListDebitEployee
                                         Into Sum(em.BalaceDebit)
                    If Not IsNothing(totalDebit) Then
                        Me.totaDebitEmployeeLabel.Text = String.Format("Total deuda trabajadores : {0}", totalDebit.ToString("C2"))
                        totalGeneral += totalDebit
                    End If
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            TotalGeneralLabel.Text = String.Format("Total General por Cobrar: {0}", totalGeneral.ToString("C2"))
        End Try
    End Sub

    Private Sub CedulaTextBox_TextChanged(sender As Object, e As EventArgs)
        CedulaBusButton.Enabled = False
        AcceptButton = Nothing
        If BuscCedulaTextBox.TextLength > 9 Then
            CedulaBusButton.Enabled = True
            AcceptButton = CedulaBusButton
        End If
    End Sub

    Private Sub NomApelliTextBox_TextChanged(sender As Object, e As EventArgs)
        AcceptButton = Nothing
        BuscNomApelliButton.Enabled = False
        If NomApelliTextBox.TextLength > 3 Then
            BuscNomApelliButton.Enabled = True
            AcceptButton = BuscNomApelliButton
        End If
    End Sub
    Sub clearFields()
        panelView.Controls.Clear()
        masterDetail = Nothing
        Refresh()
    End Sub
    Sub Carga_Datosclientes()
        Try
            clearFields()

            Dim ds As New CADsisVenta.DataSetVentas
            Dim tapDC As New DeudaClientesTableAdapter
            Dim tapDD As New DeudaDetalleClientesTableAdapter
            Dim tapCN As New ClienteNameTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapDC.Fill(ds.DeudaClientes)
            tapDD.Fill(ds.DeudaDetalleClientes)
            tapCN.Fill(ds.ClienteName)

            masterDetail.setParentSource(ds.DeudaClientes.TableName, "idCliente")
            masterDetail.childView.Add(ds.DeudaDetalleClientes.TableName, "Detalle de dueda")
            masterDetail.childView.Add(ds.ClienteName.TableName, "Detalle cliente")
            AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            For i = 0 To masterDetail.RowCount - 1
                totalDeudaVenta += masterDetail.Rows(i).Cells(masterDetail.Columns("Saldo").Index).Value
            Next
            totalLabel.Text = "Total por cobrar: " & FormatNumber(totalDeudaVenta, 2)
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Datosclientes ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ClienteRowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Try
            CobrarLinkLabel.Visible = False
            NameCliente = String.Empty
            Dim dt As DataGridView = sender
            If dt.SelectedRows.Count = 1 Then
                NameCliente = dt.SelectedCells.Item(1).Value
                CobrarLinkLabel.Text = "Cobrar la deuda del: " & NameCliente
                CobrarLinkLabel.Visible = True
                idcliente = dt.SelectedRows(0).Cells(dt.Columns("idCliente").Index).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub BuscNomApelliButton_Click(sender As Object, e As EventArgs)
        Try
            If panelView.Controls.Count > 0 Then
                Dim dt As DataGridView = panelView.Controls(0)
                CType(dt.DataSource, DataView).RowFilter = String.Format("Nombres like '%" & NomApelliTextBox.Text & "%'")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NomApelliTextBox_Leave(sender As Object, e As EventArgs)
        NomApelliTextBox.Text = Trim(NomApelliTextBox.Text)
    End Sub

    Private Sub CedulaBusButton_Click(sender As Object, e As EventArgs)
        Try
            If panelView.Controls.Count > 0 Then
                Dim dt As DataGridView = panelView.Controls(0)
                CType(dt.DataSource, DataView).RowFilter = String.Format("Cedula = '" & NomApelliTextBox.Text & "'")
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el CedulaBusButton_Click", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CobrarLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CobrarLinkLabel.LinkClicked
        If idcliente > 0 Then
            Using formnew As New frmCobro()
                With formnew
                    .Text = String.Format("ESTADO DE DEUDA DE: {0}", NameCliente)
                    .idCliente = idcliente
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .Operation Then
                        todosClientButton.PerformClick()
                    End If
                End With
            End Using
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles _CancelButton.Click
        Close()
    End Sub


    Private Sub UbicatedCheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index As Integer = UbicatedCheckedListBox.SelectedIndex
        If UbicatedCheckedListBox.SelectedIndex = 0 Then
            UbicatedCheckedListBox.SetItemChecked(0, True)
            UbicatedCheckedListBox.SetItemChecked(1, False)
        ElseIf UbicatedCheckedListBox.SelectedIndex = 1 Then
            UbicatedCheckedListBox.SetItemChecked(0, False)
            UbicatedCheckedListBox.SetItemChecked(1, True)
        End If
        If Not (index = SelectIndexUbicated) Then
            SelectIndexUbicated = index
            AdministraCotrol(UbicatedCheckedListBox.SelectedValue)
        End If
    End Sub
    Sub AdministraCotrol(state As String)
        Select Case state
            Case "Ubicación"

            Case "Ruta"
        End Select
    End Sub

    Private Sub Carga_ComboBoxProvincia()
        Try
            With ProvinciaComboBox
                .DataSource = ClsZona.getProvinciaAll(1)
                .DisplayMember = "Nom_Provincia"
                .ValueMember = "idProvincia"
                .SelectedValue = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_ComboBoxCanton()
        Try
            With CantonComboBox
                .DataSource = ClsZona.getCantonAll(ProvinciaComboBox.SelectedValue)
                .DisplayMember = "Nom_Canton"
                .ValueMember = "idCanton"
                .SelectedValue = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_ComboBoxParroquia()
        Try
            With ParroquiaComboBox
                .DataSource = ClsZona.getParroquiaAll(CantonComboBox.SelectedValue)
                .DisplayMember = "Nom_Parroquia"
                .ValueMember = "idParroquia"
                .SelectedValue = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_ComboBoxSector()
        Try
            With SectorComboBox
                .DataSource = ClsZona.getSectorAll(ParroquiaComboBox.SelectedValue)
                .DisplayMember = "Nom_Sector"
                .ValueMember = "idSector"
                .SelectedValue = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ProvinciaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProvinciaComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                CantonComboBox.Enabled = True
                Carga_ComboBoxCanton()
                Return
            End If
        End If
        CantonComboBox.Text = "TODAS"
        CantonComboBox.Enabled = False
        ParroquiaComboBox.Text = "TODAS"
        ParroquiaComboBox.Enabled = False
        SectorComboBox.Text = "TODAS"
        SectorComboBox.Enabled = False
    End Sub

    Private Sub CantonComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CantonComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                ParroquiaComboBox.Enabled = True
                Carga_ComboBoxParroquia()
                Return
            End If
        End If
        ParroquiaComboBox.Text = "TODAS"
        ParroquiaComboBox.Enabled = False
        SectorComboBox.Text = "TODAS"
        SectorComboBox.Enabled = False
    End Sub

    Private Sub ParroquiaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ParroquiaComboBox.SelectedIndexChanged
        If sender.SelectedIndex >= 0 And sender.ValueMember.Length > 0 Then
            If sender.selectedValue > 0 Then
                SectorComboBox.Enabled = True
                Carga_ComboBoxSector()
                Return
            End If
        End If
        SectorComboBox.Text = "TODAS"
        SectorComboBox.Enabled = False
    End Sub


    Private Sub AllDeudorButton_Click_1(sender As Object, e As EventArgs) Handles AllDeudorButton.Click
        Try
            Load_DebitEployee()
            dtgEmployee.DataSource = Nothing
            dtgEmployee.DataSource = Me.ListDebitEployee.ToList()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub todosClientButton_Click_1(sender As Object, e As EventArgs) Handles todosClientButton.Click
        Carga_Datosclientes()
    End Sub
    Private Sub dtgEmployee_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEmployee.RowEnter
        Try
            CahrgeEmployeeLinkLabel.Visible = False
            NameCliente = String.Empty
            Dim dt As DataGridView = sender
            If dt.SelectedRows.Count = 1 Then
                NameCliente = dt.SelectedRows(0).Cells("EmployeeClm").Value
                CahrgeEmployeeLinkLabel.Text = "Cobrar la deuda del: " & NameCliente
                CahrgeEmployeeLinkLabel.Visible = True
                IdPerson = dt.SelectedRows(0).Cells(dt.Columns("idPersonClm").Index).Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CahrgeEmployeeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CahrgeEmployeeLinkLabel.LinkClicked
        Try
            Using formnew As New frmCobroEmpleado(Me.IdPerson, Nothing)
                With formnew
                    .Text = String.Format("ESTADO DE DEUDA DE: {0}", NameCliente)
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .Operation Then
                        AllDeudorButton.PerformClick()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class