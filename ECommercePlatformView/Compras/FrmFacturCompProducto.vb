Imports CADsisVenta
Imports CADsisVenta.DataSetComprasTableAdapters

Public Class FrmFacturCompProducto
    Dim masterDetail As MasterControl
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime
    Private idPresent As Integer
    Private Sub FrmVentaXcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idPresent = 0
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
        Carga_Combox()
    End Sub
    Private Sub Carga_Combox()
        ListProductComboBox.Items.Clear()
        ListProductComboBox.Items.Add("Todos los productos")
        ListProductComboBox.SelectedIndex = 0
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
        If ListProductComboBox.SelectedIndex < 0 Then
            MsgBox("SEleccione una opción", MsgBoxStyle.Exclamation, "Importante")
            ListProductComboBox.Focus()
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

        Select Case ListProductComboBox.SelectedIndex
            Case 0
                Carga_datosAll()
            Case 1
                If Not IsNothing(idPresent) Then
                    If idPresent > 0 Then
                        Carga_datosProductoId(idPresent)
                        Return
                    End If
                End If
        End Select
    End Sub

    Private Sub Carga_datosAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetCompras
            Dim tapFCA As New FacturaCompraAllProdcutTableAdapter
            Dim tapFCB As New FacturaCompraProductIdTableAdapter
            Dim tapFCD As New FacturaCompraProductProviderTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFCA.Fill(ds.FacturaCompraAllProdcut, dateIni, dateFin)
            tapFCB.Fill(ds.FacturaCompraProductId, dateIni, dateFin)
            tapFCD.Fill(ds.FacturaCompraProductProvider, dateIni, dateFin)


            masterDetail.setParentSource(ds.FacturaCompraAllProdcut.TableName, "idPresentacion")
            masterDetail.childView.Add(ds.FacturaCompraProductId.TableName, "Detalle por bodega o local")
            masterDetail.childView.Add(ds.FacturaCompraProductProvider.TableName, "Detalle por proveedor")

            'AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            masterDetail.Columns(0).Visible = False
            masterDetail.Columns(masterDetail.Columns("Total").Index).HeaderText = "Total $"
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_datosProductoId(idpresent As Integer)
        Try
            clearFields()
            Dim totalDeuda As Double = 0

            Dim ds As New DataSetCompras
            Dim tapFCD As New FacturaCompraProductSelectIdTableAdapter
            masterDetail = New MasterControl(ds)

            tapFCD.Fill(ds.FacturaCompraProductSelectId, idpresent, dateIni, dateFin)
            masterDetail.setParentSource(ds.FacturaCompraProductSelectId.TableName, "")
            panelView.Controls.Add(masterDetail)

            If masterDetail.RowCount = 0 Then
                panelView.Controls.Add(New System.Windows.Forms.Label _
                              With {.Text = "No hay información", .ForeColor = Color.Red, .Dock = DockStyle.Top})
                Return
            End If


            'ocultamos columnas
            masterDetail.Columns(masterDetail.Columns("Medida").Index).Visible = False
            masterDetail.Columns(masterDetail.Columns("Medida_Refery").Index).Visible = False
            masterDetail.Columns(masterDetail.Columns("Cant_Present").Index).Visible = False
            'cambiamos la aparencia de las columnas

            Dim clm As New System.Windows.Forms.DataGridViewColumn()
            Dim myStileMoney As New System.Windows.Forms.DataGridViewCellStyle _
                           With {.NullValue = 0, .Format = "C2", .Alignment = DataGridViewContentAlignment.MiddleRight}
            Dim myStileNumber As New System.Windows.Forms.DataGridViewCellStyle _
               With {.NullValue = 0, .Format = "N2", .Alignment = DataGridViewContentAlignment.MiddleRight}

            clm = masterDetail.Columns(masterDetail.Columns("Costo_unidad").Index)
            clm.HeaderText = "Costo por " + masterDetail.Rows(0).Cells(masterDetail.Columns("Medida").Index).Value
            clm.DefaultCellStyle = myStileMoney

            clm = masterDetail.Columns(masterDetail.Columns("Costo_Refery").Index)
            clm.HeaderText = "Costo por " + masterDetail.Rows(0).Cells(masterDetail.Columns("Medida_Refery").Index).Value
            clm.DefaultCellStyle = myStileMoney

            clm = masterDetail.Columns(masterDetail.Columns("Total").Index)
            clm.HeaderText = "Total $"
            clm.DefaultCellStyle = myStileMoney

            clm = masterDetail.Columns(masterDetail.Columns("cantidad").Index)
            clm.DefaultCellStyle = myStileNumber

            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => $ " & FormatNumber(totalDeuda, 2)
            masterDetail.ColumnHeadersHeight = 50
            masterDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindProviderButton.Click
        Try
            Using listProvider As New frmList_ProductoComprable()
                With listProvider
                    .StartPosition = FormStartPosition.CenterParent
                    .State = _state.Select_
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Carga_Combox()
                        If .idPresent > 0 Then
                            idPresent = .idPresent
                            ListProductComboBox.Items.Add(.NomComercial)
                            ListProductComboBox.SelectedIndex = 1
                        End If
                        panelView.Controls.Clear()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class