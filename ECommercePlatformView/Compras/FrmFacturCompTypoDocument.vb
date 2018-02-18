Imports CADsisVenta.DataSetComprasTableAdapters
Imports CADsisVenta
Public Class FrmFacturCompTypoDocument
    Dim masterDetail As MasterControl
    Private idDocumento As Integer
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime

    Private Sub frmCompraTypeDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idDocumento = 0
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
        Carga_Combox()
    End Sub
    Private Sub Carga_Combox()
        Try

            Dim datp As New TypoDocumentoTableAdapter
            Dim dt As DataTable = datp.GetData()
            ListTypeDocumentComboBox.DataSource = dt
            ListTypeDocumentComboBox.ValueMember = "idTypoDocu"
            ListTypeDocumentComboBox.DisplayMember = "Nom_Docu"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If ListTypeDocumentComboBox.SelectedIndex = 0 Then
            Carga_datosAll()
        ElseIf ListTypeDocumentComboBox.SelectedIndex > 0 Then
            Carga_TypoDocumentID(ListTypeDocumentComboBox.SelectedValue)
        End If
    End Sub
    Private Sub Carga_datosAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetCompras
            Dim tapFCA As New FacturaCompraTypeDocumentAllTableAdapter
            Dim tapFCB As New FacturaCompraDocumentoTableAdapter


            masterDetail = New MasterControl(ds)
            PanelView.Controls.Add(masterDetail)

            tapFCA.Fill(ds.FacturaCompraTypeDocumentAll, dateIni, dateFin)
            tapFCB.Fill(ds.FacturaCompraDocumento, dateIni, dateFin)



            masterDetail.setParentSource(ds.FacturaCompraTypeDocumentAll.TableName, "idProveedor")
            masterDetail.childView.Add(ds.FacturaCompraDocumento.TableName, "Detalle por documento")

            masterDetail.Columns("idProveedor").Visible = False

            masterDetail.Columns("Razon_social").HeaderText = "Proveedor"
            'cantidad
            clm = masterDetail.Columns("Cant_documento")
            clm.HeaderText = "Cantidad documento"
            clm.DefaultCellStyle = myStileNumber
            'base 0%
            clm = masterDetail.Columns("base00Iva")
            clm.HeaderText = "Base 0%"
            clm.DefaultCellStyle = myStileMoney
            'base 12%
            clm = masterDetail.Columns("base12Iva")
            clm.HeaderText = "Base 12%"
            clm.DefaultCellStyle = myStileMoney
            'base iva
            clm = masterDetail.Columns("Iva")
            clm.HeaderText = "Iva"
            clm.DefaultCellStyle = myStileMoney
            'base total
            clm = masterDetail.Columns("Total")
            clm.HeaderText = "Total $"
            clm.DefaultCellStyle = myStileMoney

            masterDetail.ColumnHeadersHeight = 50

            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_TypoDocumentID(idDocument As Integer)
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetCompras
            Dim tapFCA As New FacturaCompraTypeDocumentIDTableAdapter
            Dim tapFCB As New FacturaCompraDocumentoTableAdapter


            masterDetail = New MasterControl(ds)
            PanelView.Controls.Add(masterDetail)

            tapFCA.Fill(ds.FacturaCompraTypeDocumentID, dateIni, dateFin, idDocument)
            tapFCB.Fill(ds.FacturaCompraDocumento, dateIni, dateFin)



            masterDetail.setParentSource(ds.FacturaCompraTypeDocumentID.TableName, "idProveedor")
            masterDetail.childView.Add(ds.FacturaCompraDocumento.TableName, "Detalle por documento")

            masterDetail.Columns("idProveedor").Visible = False

            masterDetail.Columns("Razon_social").HeaderText = "Proveedor"
            'cantidad
            clm = masterDetail.Columns("Cant_documento")
            clm.HeaderText = "Cantidad documento"
            clm.DefaultCellStyle = myStileNumber
            'base 0%
            clm = masterDetail.Columns("base00Iva")
            clm.HeaderText = "Base 0%"
            clm.DefaultCellStyle = myStileMoney
            'base 12%
            clm = masterDetail.Columns("base12Iva")
            clm.HeaderText = "Base 12%"
            clm.DefaultCellStyle = myStileMoney
            'base iva
            clm = masterDetail.Columns("Iva")
            clm.HeaderText = "Iva"
            clm.DefaultCellStyle = myStileMoney
            'base total
            clm = masterDetail.Columns("Total")
            clm.HeaderText = "Total $"
            clm.DefaultCellStyle = myStileMoney

            masterDetail.ColumnHeadersHeight = 50

            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub clearFields()
        PanelView.Controls.Clear()
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
End Class