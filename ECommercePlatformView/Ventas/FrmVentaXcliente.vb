Imports CADsisVenta
Imports CADsisVenta.DataSetVentasTableAdapters

Public Class FrmVentaXcliente
    Dim masterDetail As MasterControl
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime
    Private idCliente As Integer
    Private Sub FrmVentaXcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idCliente = 0
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
        AñadeItemList()
    End Sub
    Sub AñadeItemList()
        ListClienComboBox.Items.Clear()
        ListClienComboBox.Items.Add("TODOS...")
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
                Carga_datosAll()
            Case 1
                If Not IsNothing(idCliente) Then
                    If idCliente > 0 Then
                        Carga_datosIdCliente(idCliente)
                        Return
                    End If
                End If
        End Select

    End Sub

    Private Sub Carga_datosAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaClienteAllTableAdapter
            Dim tapFVF As New FacturaVentaClienteFechAllTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaClienteAll, dateIni, dateFin)
            tapFVF.Fill(ds.FacturaVentaClienteFechAll, dateIni, dateFin)
           

            masterDetail.setParentSource(ds.FacturaVentaClienteAll.TableName, "Identidad")
            masterDetail.childView.Add(ds.FacturaVentaClienteFechAll.TableName, "Detalle por fecha")
            ''AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_datosIdCliente(idcliente As Integer)
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaClienteIdTableAdapter
            Dim tapFVD As New FacturaVentaClienteIdDetailTableAdapter


            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaClienteId, dateIni, dateFin, idcliente)
            tapFVD.Fill(ds.FacturaVentaClienteIdDetail, idcliente)


            masterDetail.setParentSource(ds.FacturaVentaClienteId.TableName, "idFactVenta")
            masterDetail.childView.Add(ds.FacturaVentaClienteIdDetail.TableName, "Detalle de compra")
            masterDetail.Columns(0).Visible = False

            AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ClienteRowEnter(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindClienteButton.Click
        Using listclient As New frmList_clientes(stateClient.Cliente)
            With listclient
                .txtFlag = "Ventas"
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    idCliente = .dtg.SelectedCells(0).Value
                    For i = 0 To ListClienComboBox.Items.Count - 1
                        If i > 0 Then
                            ListClienComboBox.Items.Remove(i)
                        End If
                    Next
                    AñadeItemList()
                    ListClienComboBox.Items.Add(Convert.ToString(.dtg.SelectedCells(1).Value) & " " & Convert.ToString(.dtg.SelectedCells(2).Value))
                    ListClienComboBox.SelectedIndex = 1
                    panelView.Controls.Clear()
                End If
            End With
        End Using
    End Sub

    Private Sub ListClienComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListClienComboBox.SelectedIndexChanged

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class