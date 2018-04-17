Public Class frmListFacturPurchases
    Private isLoadted As Boolean
    Private idProveedor As Integer
    Private idFactura As Integer

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.FastDataListView1.DataSource = Nothing
            Me.FastDataListView1.Clear()

            Select Case Me.ComboBox1.SelectedIndex
                Case 0
                    Load_LastedPurcharse(150)
                Case 1
                    Load_ProviderPurcharse(500)
                Case 2
                    Load_DatePurcharse()
            End Select
            Me.Paneldata.Width = panelView.Width * 0.97
            Me.Paneldata.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        Finally

            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Load_DatePurcharse()
        Try
            If (Me.BunifuDatepicker2.Value.Date - Me.BunifuDatepicker1.Value.Date).Days > 366 Then
                MsgBox("Parametros muy largos sugerimos que uses analizadores de datos como el Power By", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            Using db As New DataContext
                Dim list = (From f In db.FacturaCompra
                            Join p In db.Proveedores On p.idProveedor Equals f.idProveedor
                            Join b In db.Bodegas On b.idBodega Equals f.idBodega
                            Where f.fechaCompra >= Me.BunifuDatepicker1.Value.Date And f.fechaCompra <= Me.BunifuDatepicker2.Value.Date
                            Select New With {f.idFacturaCompra, p.Razon_social, f.fechaCompra, b.Nom_Bodega, f.base00Iva, f.base12Iva, f.iva, f.TotalPedido}).ToList()

                Me.FastDataListView1.DataSource = list.OrderByDescending(Function(x) x.fechaCompra).ToList()
                If list.Count > 0 Then
                    sql = String.Format("Total item: {0}" & vbCrLf, list.Count)
                    Dim total As Double = Aggregate i In list
                                               Into Sum(i.TotalPedido)
                    sql = sql & String.Format("Total valor : {0}" & vbCrLf, total.ToString("C2"))
                    Me.Label2.Text = sql
                End If
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_ProviderPurcharse(item As Integer)
        Try
            Using db As New DataContext
                Dim list = (From f In db.FacturaCompra
                            Join p In db.Proveedores On p.idProveedor Equals f.idProveedor
                            Join b In db.Bodegas On b.idBodega Equals f.idBodega
                            Order By f.idFacturaCompra Descending
                            Where f.idProveedor = Me.idProveedor
                            Select New With {f.idFacturaCompra, p.Razon_social, f.fechaCompra, b.Nom_Bodega, f.base00Iva, f.base12Iva, f.iva, f.TotalPedido}).Take(item).ToList()

                Me.FastDataListView1.DataSource = list
                If list.Count > 0 Then
                    sql = String.Format("Total item: {0}" & vbCrLf, list.Count)
                    Dim total As Double = Aggregate i In list
                                               Into Sum(i.TotalPedido)
                    sql = sql & String.Format("Total valor : {0}" & vbCrLf, total.ToString("C2"))
                    Me.Label2.Text = sql
                End If
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Load_LastedPurcharse(item As Integer)
        Try
            Using db As New DataContext
                Dim list = (From f In db.FacturaCompra
                            Join p In db.Proveedores On p.idProveedor Equals f.idProveedor
                            Join b In db.Bodegas On b.idBodega Equals f.idBodega
                            Order By f.idFacturaCompra Descending
                            Select New With {f.idFacturaCompra, p.Razon_social, f.fechaCompra, b.Nom_Bodega, f.base00Iva, f.base12Iva, f.iva, f.TotalPedido}).Take(item).ToList()

                Me.FastDataListView1.DataSource = list
                If list.Count > 0 Then
                    sql = String.Format("Total item: {0}" & vbCrLf, list.Count)
                    Dim total As Double = Aggregate i In list
                                               Into Sum(i.TotalPedido)
                    sql = sql & String.Format("Total valor : {0}" & vbCrLf, total.ToString("C2"))
                    Me.Label2.Text = sql
                End If

            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub frmListFacturPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindButton.PerformClick()
        Me.BunifuDatepicker1.Value = Date.Now().Date.AddMonths(-5)
        Me.BunifuDatepicker2.Value = Date.Now().Date
        Default_Panel()
        isLoadted = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If isLoadted Then
            Me.ProveedorLabel.Visible = False
            Me.FindProviderButton.Visible = False
            Me.ProveedorLabel.Text = ""
            Me.ProveedorLabel.Visible = False
            Me.HastaLabel.Visible = False
            Me.BunifuDatepicker1.Visible = False
            Me.BunifuDatepicker2.Visible = False
            Me.idProveedor = 0

            Me.FastDataListView1.Clear()
            If Me.ComboBox1.SelectedIndex = 0 Then
                Me.FindButton.PerformClick()
            ElseIf Me.ComboBox1.SelectedIndex = 1 Then
                Me.FindProviderButton.Visible = True
                Me.FindButton.PerformClick()
            ElseIf Me.ComboBox1.SelectedIndex = 2 Then
                Me.ProveedorLabel.Text = "Desde: "
                Me.ProveedorLabel.Visible = True

                Me.HastaLabel.Visible = True
                Me.BunifuDatepicker1.Visible = True
                Me.BunifuDatepicker2.Visible = True
            End If

        End If
    End Sub

    Private Sub FindProviderButton_Click(sender As Object, e As EventArgs) Handles FindProviderButton.Click
        Try
            Using listProvider As New frmList_Proveedores(stateLoad.Dialogo, stateClient.User)
                With listProvider
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        idProveedor = .dataListado.SelectedCells.Item(.dataListado.Columns("idProveedor").Index).Value
                        sql = Convert.ToString(.dataListado.SelectedCells(.dataListado.Columns("Ruc_Ci").Index).Value) & " "
                        sql = sql & Convert.ToString(.dataListado.SelectedCells(.dataListado.Columns("Razon_social").Index).Value) & " "
                        ProveedorLabel.Text = sql
                        Me.ProveedorLabel.Visible = True
                        FindButton.PerformClick()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Me.FastDataListView1.SelectObjects(FastDataListView1.Objects)
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        FastDataListView1.CopyObjectsToClipboard(Me.FastDataListView1.SelectedObjects)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If FastDataListView1.SelectedIndices.Count = 0 Then
                MsgBox("Seleccione uno de la lista", MsgBoxStyle.Information, "Aviso")
                Return
            End If
            If (MsgBox("Está seguro de eliminar..", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..")) = DialogResult.Yes Then

                Using newform As New LoginForm(stateReturn._response, "Compras")
                    With newform
                        .Text = "Validando para Eliminar.."
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            If DeleteFactur() Then
                                Me.FindButton.PerformClick()
                            End If
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Function DeleteFactur()
        Try
            Using db As New DataContext
                For Each item In FastDataListView1.SelectedObjects
                    sql = item.GetHashCode()
                    Dim item2 As String() = Split(item.ToString, ",")
                    If item2.Count = 0 Then
                        Return False
                    End If
                    Dim idFactura As Integer? = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
                    Dim remo = (From f In db.FacturaCompra Where f.idFacturaCompra = idFactura).FirstOrDefault()
                    If remo Is Nothing Then
                        Return False
                    End If
                    db.FacturaCompra.DeleteOnSubmit(remo)
                Next
                db.SubmitChanges()
            End Using

            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        If Not Me.FastDataListView1.SelectedObjects.Count = 1 Then
            ErrorProvider1.SetError(BunifuImageButton3, "Seleccione uno de la lista")
            Return
        End If
        ErrorProvider1.SetError(BunifuImageButton3, String.Empty)
        Me.Paneldata.Width = panelView.Width * 0.15
        Me.Paneldata.Enabled = False


        Dim item = FastDataListView1.SelectedObject

        Dim item2 As String() = Split(item.ToString, ",")
            If item2.Count = 0 Then
            Return
        End If
        idFactura = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
        Load_Details(idFactura)
    End Sub

    Private Sub Load_Details(ByVal idFactur As Integer)
        Me.PanelDetail.Visible = True

        Using db As New DataContext
            Dim List = (From d In db.FacturaCompra_Detail
                        Join pp In db.ProductoPresentacion On d.idPresent Equals pp.idPresentacion
                        Join p In db.Productos On pp.idProducto Equals p.idProducto
                        Where d.idFacturaCompra = idFactur
                        Select New With {d.idFacturaCompra_Detail, d.idPresent, p.idProducto,
                             p.Nom_Comercial, pp.PresentacionPrint, d.cantidad, d.descuento, d.iva, d.SubTotal, d.Total}).ToList()


            Me.DataListView1.DataSource = List
            If List.Count > 0 Then
                sql = String.Format("Total item: {0}" & vbCrLf, List.Count)
                Dim total As Double = Aggregate j In List
                                               Into Sum(j.Total)
                sql = sql & String.Format("Total valor : {0}" & vbCrLf, total.ToString("C2"))
                Me.Label3.Text = sql

                Dim i As Integer = 0
                For Each COL In DataListView1.Columns
                    If i = 0 Then
                        Me.DataListView1.Columns(0).Width = 0
                    ElseIf i = 3 Then
                        Me.DataListView1.Columns(3).Width = 350
                    Else
                        Me.DataListView1.Columns(i).Width = 100
                    End If
                    i += 1
                Next
            End If
        End Using

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Default_Panel()
    End Sub

    Private Sub Default_Panel()
        Me.PanelDetail.Visible = False
        Me.Paneldata.Width = panelView.Width * 0.97
        Me.Paneldata.Enabled = True
        Me.DataListView1.Clear()
        Me.Label3.Text = String.Empty
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        Try
            If Not Me.FastDataListView1.SelectedObjects.Count = 1 Then
                ErrorProvider1.SetError(BunifuImageButton8, "Seleccione uno de la lista de detalle")
                Return
            End If
            ErrorProvider1.SetError(BunifuImageButton8, String.Empty)
            Using newform As New LoginForm(stateReturn._response, "Compras")
                With newform
                    .Text = "Validando para Eliminar.."
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        Dim item = Me.DataListView1.SelectedObject

                        Dim item2 As String() = Split(item.ToString, ",")
                        If item2.Count = 0 Then
                            Return
                        End If
                        Dim idFactura_Detail As Integer? = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
                        ChangedProductForSelect(idFactura_Detail)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ChangedProductForSelect(idFacturaCompra_Detail As Integer)
        Try
            Using newlist As New frmList_ProductoView(stateLoad.Dialogo)
                With newlist
                    .PanelAdmin.Visible = False
                    .SplitContainer1.Panel2.Visible = False
                    .SplitContainer1.SplitterDistance = .Width * 0.97
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If .id_Present > 0 Then
                            Using db As New DataContext

                                Dim item = (From d In db.FacturaCompra_Detail
                                            Where d.idFacturaCompra_Detail = idFacturaCompra_Detail).FirstOrDefault()

                                If Not item Is Nothing Then
                                    item.idPresent = .id_Present
                                End If
                                db.SubmitChanges()
                                Load_Details(idFactura)
                            End Using
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Try
            If Not Me.FastDataListView1.SelectedObjects.Count = 1 Then
                ErrorProvider1.SetError(BunifuImageButton7, "Seleccione uno de la lista de detalle")
                Return
            End If
            ErrorProvider1.SetError(BunifuImageButton7, String.Empty)
            Using newform As New LoginForm(stateReturn._response, "Compras")
                With newform
                    .Text = "Validando para cambiar.."
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then

                        Dim item = Me.DataListView1.SelectedObject

                        Dim item2 As String() = Split(item.ToString, ",")
                        If item2.Count = 0 Then
                            Return
                        End If
                        Dim idFactura_Detail As Integer? = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
                        Dim count As Double? = Strings.Right(item2(5), item2(5).Length - Strings.InStr(item2(5), "="))
                        ChangedCountForSelect(idFactura_Detail, count)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ChangedCountForSelect(idFactura_Detail As Integer?, count As Double)
        Try
            Using newlist As New frmImputData()
                With newlist
                    .txtNumber.Value = count
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Using db As New DataContext

                            Dim item = (From d In db.FacturaCompra_Detail
                                        Where d.idFacturaCompra_Detail = idFactura_Detail).FirstOrDefault()

                            If Not item Is Nothing Then
                                item.cantidad = .txtNumber.Value
                            End If
                            db.SubmitChanges()
                            Load_Details(idFactura)
                        End Using
                    End If
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        DataListView1.CopyObjectsToClipboard(Me.DataListView1.SelectedObjects)
    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click
        Me.DataListView1.SelectObjects(DataListView1.Objects)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        'frmAdministrarPrecios
        Me.Cursor = Cursors.WaitCursor
        If Not FastDataListView1.SelectedObjects.Count = 1 Then
            MsgBox("Seleccione uno de la lista", MsgBoxStyle.Information, "Aviso")
            Return
        End If
        Try
            Dim idFactura As Integer?
            Cursor = Cursors.WaitCursor
            For Each item In FastDataListView1.SelectedObjects
                Dim item2 As String() = Split(item.ToString, ",")
                If item2.Count = 0 Then
                    Return
                End If
                idFactura = Strings.Right(item2(0), item2(0).Length - Strings.InStr(item2(0), "="))
                Exit For
            Next

            Using adnminPrice As New frmAdministrarPrecios(stateLoad.Dialogo, viewLoadReport.Select_Id, idFactura)
                With adnminPrice
                    .Width = Screen.PrimaryScreen.Bounds.Width * 0.9
                    .Height = Screen.PrimaryScreen.Bounds.Height * 0.8
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class