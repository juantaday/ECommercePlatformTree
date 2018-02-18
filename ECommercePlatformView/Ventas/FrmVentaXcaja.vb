Imports CADsisVenta
Imports CADsisVenta.DataSetVentasTableAdapters
Public Class FrmVentaXcaja
    Dim masterDetail As MasterControl
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime

    Private Sub FrmVentaXcaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If ListarComboBox.SelectedIndex < 0 Then
            MsgBox("SEleccione una opción", MsgBoxStyle.Exclamation, "Importante")
            ListarComboBox.Focus()
            Return
        End If
        Select Case ListarComboBox.SelectedIndex
            Case 0
                Carga_xEpleado_Document_Fecha()
            Case 1
                If dateIni.Year = dateFin.Year And
                      dateIni.Month = dateFin.Month And
                      dateIni.Day = dateFin.Day Then
                    Carga_xHora()
                Else
                    MsgBox("Es necesario que consulte solo de una fecha", MsgBoxStyle.Exclamation, "Importante")
                End If
        End Select
    End Sub
    Private Sub Carga_xEpleado_Document_Fecha()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaCajaTableAdapter
            Dim tapFVE As New FacturaVentaEmpleadoTableAdapter
            Dim tapFVN As New FacturaVentaNumFacturTableAdapter
            Dim tapFVF As New FacturaVentaFechaTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaCaja, dateIni, dateFin)
            tapFVE.Fill(ds.FacturaVentaEmpleado, dateIni, dateFin)
            tapFVN.Fill(ds.FacturaVentaNumFactur, dateIni, dateFin)
            tapFVF.Fill(ds.FacturaVentaFecha, dateIni, dateFin)

            masterDetail.setParentSource(ds.FacturaVentaCaja.TableName, "Caja")
            masterDetail.childView.Add(ds.FacturaVentaEmpleado.TableName, "Detalle por empleado")
            masterDetail.childView.Add(ds.FacturaVentaNumFactur.TableName, "Detalle por documento")
            masterDetail.childView.Add(ds.FacturaVentaFecha.TableName, "Detalle por fecha")
            ' AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Datosclientes ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_xHora()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaCajaTableAdapter
            Dim tapFVH As New FacturaVentaHoraTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaCaja, dateIni, dateFin)
            tapFVH.Fill(ds.FacturaVentaHora, dateIni, dateFin)

            masterDetail.setParentSource(ds.FacturaVentaCaja.TableName, "Caja")
            masterDetail.childView.Add(ds.FacturaVentaHora.TableName, "Detalle por hora")

            AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Datosclientes ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ClienteRowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Dim ds As New DataSetVentas

         masterDetail.childView.Add(ds.FacturaVentaHora.TableName, "Detalle por hora")

        masterDetail.childView.Add(ds.FacturaVentaEmpleado.TableName, "Detalle por empleado")

    End Sub
    Sub clearFields()
        panelView.Controls.Clear()
        masterDetail = Nothing
        Refresh()
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
    Private Sub ListarComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListarComboBox.SelectedIndexChanged
        clearFields()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub TotalLabel_Click(sender As Object, e As EventArgs) Handles TotalLabel.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub panelView_Paint(sender As Object, e As PaintEventArgs) Handles panelView.Paint

    End Sub

    Private Sub paneldata_Paint(sender As Object, e As PaintEventArgs) Handles paneldata.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class