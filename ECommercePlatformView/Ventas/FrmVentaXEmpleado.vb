Imports CADsisVenta
Imports CADsisVenta.DataSetVentasTableAdapters

Public Class FrmVentaXEmpleado
    Dim masterDetail As MasterControl
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime
    Private codUser As String
    Private Sub FrmVentaXcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codUser = String.Empty
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
        Carga_Combox()
    End Sub

    Private Sub Carga_Combox()
        ListClienComboBox.Items.Clear()
        ListClienComboBox.Items.Add("Todas los empleados")
        ListClienComboBox.SelectedIndex = 0
    End Sub
    Sub ViewDate(isTime As Boolean)
        If isTime Then
            sql = "Desde: " & FormatDateTime(dateIni, DateFormat.ShortDate)
            sql = sql & " " & Format(dateIni, "hh:mm tt") & vbNewLine + vbNewLine
            sql = sql & "Hasta: " & FormatDateTime(dateFin, DateFormat.ShortDate)
            sql = sql & " " & Format(dateFin, "hh:mm tt")
            LinkLabel1.Text = sql
        Else
            sql = "Desde: " & FormatDateTime(dateIni, DateFormat.ShortDate) & vbNewLine + vbNewLine
            sql = sql & "Hasta: " & FormatDateTime(dateFin, DateFormat.ShortDate)
            LinkLabel1.Text = sql
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using newfecha As New FrmImputDate
            With newfecha
                If isTime Then
                    .DateIni = dateIni
                    .DateFin = dateFin
                Else
                    .DateIni = CDate(FormatDateTime(dateIni, DateFormat.ShortDate))
                    .DateFin = CDate(FormatDateTime(dateFin, DateFormat.ShortDate))
                End If
                .IsHourCheckBox.Checked = isTime
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    dateIni = .DateIni
                    dateFin = .DateFin
                    isTime = .IsHourCheckBox.Checked
                    ViewDate(isTime)
                    clearFields()
                End If
            End With
        End Using
    End Sub
    Sub clearFields()
        panelView.Controls.Clear()
        masterDetail = Nothing
        Refresh()
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If ListClienComboBox.SelectedIndex < 0 Then
            MsgBox("SEleccione una opción", MsgBoxStyle.Exclamation, "Importante")
            ListClienComboBox.Focus()
            Return
        End If

        If isTime Then
            If dateIni.Year = dateFin.Year And
                      dateIni.Month = dateFin.Month And
                      dateIni.Day = dateFin.Day Then
            Else
                MsgBox("Es necesario que consulte solo de una fecha", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
        End If

        Select Case ListClienComboBox.SelectedIndex
            Case 0
                Carga_datosEmployeeAll()
            Case 1
                If Not String.IsNullOrEmpty(codUser) Then
                    Carga_datosEmployeeCodUser(codUser)
                    Return
                End If
        End Select

    End Sub

    Private Sub Carga_datosEmployeeAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FVGroupByUserTableAdapter
            Dim tapFVF As New FVGroupByUserDeatailTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FVGroupByUser, dateIni, dateFin)
            tapFVF.Fill(ds.FVGroupByUserDeatail, dateIni, dateFin)


            masterDetail.setParentSource(ds.FVGroupByUser.TableName, "codUser")
            masterDetail.childView.Add(ds.FVGroupByUserDeatail.TableName, "Detalle por producto")
            ''AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            masterDetail.Columns(masterDetail.Columns("codUser").Index).Visible = False
            masterDetail.Columns(masterDetail.Columns("Total").Index).HeaderText = "Total $"
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => $ " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_datosEmployeeCodUser(coduser As String)
        Try
            Dim totalDeuda As Double
            Carga_datosEmployeeAll()
            If masterDetail.RowCount > 0 Then
                CType(masterDetail.DataSource, DataView).RowFilter = String.Format("codUser='" + coduser + "'")

                For i = 0 To masterDetail.RowCount - 1
                    totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
                Next
                TotalLabel.Text = "Total => $:" & FormatNumber(totalDeuda, 2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindClienteButton.Click
        Using listUser As New frmList_Users()
            With listUser
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    codUser = .dtg.SelectedCells.Item(.dtg.Columns("Login").Index).Value
                    Carga_Combox()
                    sql = .dtg.SelectedCells.Item(.dtg.Columns("Ruc_Ci").Index).Value & " "
                    sql = sql & .dtg.SelectedCells.Item(.dtg.Columns("Nombres").Index).Value
                    ListClienComboBox.Items.Add(sql)
                    ListClienComboBox.SelectedIndex = 1
                    panelView.Controls.Clear()
                End If
            End With
        End Using
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class