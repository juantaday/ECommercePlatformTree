Imports CADsisVenta
Imports CADsisVenta.DataSetVentasTableAdapters

Public Class FrmVentaXProducto
    Dim masterDetail As MasterControl
    Private isTime As Boolean
    Private dateIni As DateTime
    Private dateFin As DateTime
    Private idProducto As Integer
    Private Sub FrmVentaXcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idProducto = 0
        isTime = False
        dateIni = Date.Today.AddYears(-1)
        dateFin = Date.Today
        dateFin = dateFin.AddHours(23.9999)
        ViewDate(isTime)
        Carga_Combox()
    End Sub

    Private Sub Carga_Combox()
        ListClienComboBox.Items.Clear()
        ListClienComboBox.Items.Add("Todas las categorias")
        ListClienComboBox.Items.Add("Todos los productos")
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
                Carga_datosCategoAll()
            Case 1
                Carga_datosProductoAll()
            Case 2
                If Not IsNothing(idProducto) Then
                    If idProducto > 0 Then
                        Carga_datosProductoId(idProducto)
                        Return
                    End If
                End If
        End Select

    End Sub

    Private Sub Carga_datosCategoAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaProducCategTableAdapter
            Dim tapFVF As New FacturaVentaProductProductTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaProducCateg, dateIni, dateFin)
            tapFVF.Fill(ds.FacturaVentaProductProduct, dateIni, dateFin)


            masterDetail.setParentSource(ds.FacturaVentaProducCateg.TableName, "idSubCategoria")
            masterDetail.childView.Add(ds.FacturaVentaProductProduct.TableName, "Detalle por producto")
            ''AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
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
    Private Sub Carga_datosProductoAll()
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaGroupByProductTableAdapter
            Dim tapFVF As New FacturaVentaGroupByClientTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaGroupByProduct, dateIni, dateFin)
            tapFVF.Fill(ds.FacturaVentaGroupByClient, dateIni, dateFin)


            masterDetail.setParentSource(ds.FacturaVentaGroupByProduct.TableName, "idProducto")
            masterDetail.childView.Add(ds.FacturaVentaGroupByClient.TableName, "Detalle por cliente")
            ''AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            masterDetail.Columns(masterDetail.Columns("idProducto").Index).Visible = False
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => " & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_datosProductoId(idproducto As Integer)
        Try
            clearFields()
            Dim totalDeuda As Double = 0
            Dim ds As New DataSetVentas
            Dim tapFVC As New FacturaVentaGroupByIdProdcutTableAdapter
            ' Dim tapFVF As New FacturaVentaProductProductTableAdapter

            masterDetail = New MasterControl(ds)
            panelView.Controls.Add(masterDetail)

            tapFVC.Fill(ds.FacturaVentaGroupByIdProdcut, dateIni, dateFin, idproducto)
            ' tapFVF.Fill(ds.FacturaVentaProductProduct, dateIni, dateFin)


            masterDetail.setParentSource(ds.FacturaVentaGroupByIdProdcut.TableName, "idFactVenta")
            'masterDetail.childView.Add(ds.FacturaVentaProductProduct.TableName, "Detalle por producto")
            ''AddHandler masterDetail.RowEnter, AddressOf ClienteRowEnter
            masterDetail.Columns(0).Visible = False
            masterDetail.Columns(masterDetail.Columns("Total").Index).HeaderText = "Total $"
            For i = 0 To masterDetail.RowCount - 1
                totalDeuda += masterDetail.Rows(i).Cells(masterDetail.Columns("Total").Index).Value
            Next
            TotalLabel.Text = "Total => $:" & FormatNumber(totalDeuda, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindClienteButton.Click
        Try
            Using listProduct As New frmList_ProductPrecioVenta
                With listProduct
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        idProducto = .idProducto
                        Carga_Combox()
                        If idProducto > 0 Then
                            ListClienComboBox.Items.Add(Convert.ToString(.datalistado.SelectedCells(1).Value)) 'Nombre de producto
                            ListClienComboBox.SelectedIndex = 2
                        End If
                        panelView.Controls.Clear()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListClienComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListClienComboBox.SelectedIndexChanged

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class