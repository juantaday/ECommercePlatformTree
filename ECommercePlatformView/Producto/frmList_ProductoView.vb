Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports CADsisVenta
Imports CADsisVenta.DataSetVentas
Imports CADsisVenta.DataSetVentasTableAdapters
Public Class frmList_ProductoView
    Private isLoated As Boolean
    Private _ziView As Single
    Private PictureBoxCopy As Bitmap
    Private dialogoPrint As PrinterSettings

    Protected Friend id_proveedor As Integer
    Protected Friend id_Producto As Integer
    Public Property id_Present As Integer
    Public Property Nom_comercial As String
    Protected Friend id_Product_return As Integer
    Protected Friend flag As String

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
            isLoated = False
            Me.Cursor = Cursors.WaitCursor
            Me.Label2.Text = String.Format("Total registros: {0:N0}", 0)
            txtProduc_Select.Text = Trim(txtProduc_Select.Text)


            Me.datalistado.DataSource = Nothing
            Me.id_Producto = 0
            Dim mySpliter As ResponseSpliter = GenerateSpliter(txtProduc_Select.Text, True)
            If mySpliter.IsSucces Then
                Carga_ListProducto()
                isLoated = True
                If datalistado.Rows.Count > 0 Then
                    datalistado_RowEnter(datalistado, New System.Windows.Forms.DataGridViewCellEventArgs(1, 0))
                    datalistado.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Carga_ListProducto()
        Try
            Using adat As New pcdGetListProductRentableTableAdapter
                Using dt As New pcdGetListProductRentableDataTable
                    adat.Fill(dt, codTerminal:=TerminalActivo.codTerminal, codUser:=UsuarioActivo.codUser)
                    If dt.Rows.Count > 0 Then
                        With datalistado
                            .DataSource = dt
                            .AutoSizeColumnsMode =
                          DataGridViewAutoSizeColumnsMode.AllCells
                            clm = .Columns("Rentabilidad")
                            clm.DefaultCellStyle = myStilePercentage

                            clm = .Columns("idPresentacion")
                            clm.Visible = False

                            clm = .Columns("Nom_Comun")
                            clm.Visible = False

                            clm = .Columns("Barcode")
                            clm.Visible = False

                            clm = .Columns("codProducto")
                            clm.HeaderText = "Cod Interno"

                            clm = .Columns("Nom_Comercial")
                            clm.HeaderText = "Producto"

                            clm = .Columns("Nom_Medida")
                            clm.HeaderText = "Empaque"

                            clm = .Columns("Cant_Present")
                            clm.HeaderText = "UND EMQ"

                            clm = .Columns("UltimaCompra")
                            clm.HeaderText = "Ultima Compra"

                            clm = .Columns("precioVenta")
                            clm.HeaderText = "PVP Venta"

                            Me.Label2.Text = String.Format("Total registros: {0:N0}", dt.Rows.Count)
                        End With
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_ListProducto del " + Me.Name, MsgBoxStyle.Critical, "Error al cargar Proveedor")
        End Try
    End Sub
    Private Sub frmLista_Producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        _ziView = 2
        Dim MenuaDMIN As ContextMenuStrip = ContextMenuAdministra
        Dim MenualECT As ContextMenuStrip = ContextMenuLectura
        dialogoPrint = New PrinterSettings()
        Try
            Select Case flag
                Case "Lectura"
                    Me.datalistado.ContextMenuStrip = MenualECT
                Case "Administrar"
                    Me.datalistado.ContextMenuStrip = MenuaDMIN
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el frmLista_Producto_Load")
        End Try
        Me.txtProduc_Select.Focus()
    End Sub
    Private Sub txtProduc_Select_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProduc_Select.TextChanged
        SetButtonDefaul(Me.btnBuscar)
    End Sub
    Private Sub SetButtonDefaul(ByVal btn As Button)
        Me.AcceptButton = btn
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        If Me.IsSelectedRow() Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub
    Private Sub datalistado_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If datalistado.SelectedRows.Count = 1 Then
            EditPriceSalesButton.PerformClick()
        End If
    End Sub
    Private Sub edirPreciSalesButton_Click(sender As Object, e As EventArgs) Handles EditPriceSalesButton.Click
        Try
            If Not IsSelectedRow() Then
                MsgBox("Selecccione uno del listado ", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            'emviaamos el prodcuto a la tabla temporal
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "Delete [tmp].[SelectMyProduct]  WHERE ((codUser=@codUser) AND (codTerminal=@codTerminal))"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    'eLIMINACION
                    cmd.Parameters.AddWithValue("@codUser", UsuarioActivo.codUser)
                    cmd.Parameters.AddWithValue("@codTerminal", TerminalActivo.codTerminal)
                    cmd.ExecuteNonQuery()
                    'agregaremos
                    sql = "Insert [tmp].[SelectMyProduct] (idProducto,codUser,codTerminal) "
                    sql = sql & "Values (@idProducto,@codUser,@codTerminal)"
                    cmd.CommandText = sql
                    cmd.Parameters.AddWithValue("@idProducto", Me.id_Producto)
                    If Not (cmd.ExecuteNonQuery() = 1) Then
                        Return
                    End If
                End Using
            End Using

            Me.Cursor = Cursors.WaitCursor
            Using forAdminPrice As New frmAdministrarPrecios(stateLoad.Dialogo)
                With forAdminPrice
                    .Text = "Administradondo precios"
                    .txtProduc_Select.Text = datalistado.SelectedCells(datalistado.Columns("Nom_Comercial").Index).Value
                    .StartPosition = FormStartPosition.CenterScreen
                    .FormBorderStyle = FormBorderStyle.Fixed3D
                    .WindowState = FormWindowState.Normal
                    .Height = 800
                    .Width = 3000
                    .Text = String.Format("Administrando precios de venta.")
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        btnBuscar.PerformClick()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub AgregarButton_Click(sender As Object, e As EventArgs) Handles AgregarButton.Click
        Try
            Using formProdcutos As New MDI_AddProductos(stateOperation.Insert, 0, Me.id_proveedor)
                With formProdcutos
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsSelectedRow() Then
            Try
                Using AddProductos As New MDI_AddProductos(stateOperation.Update, Me.id_Producto, 0)
                    With AddProductos
                        .ShowDialog()
                    End With
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
            Me.datalistado.Focus()
        End If
    End Sub
    Private Function IsSelectedRow() As Boolean
        Try
            Dim RowSelect As DataGridViewSelectedRowCollection = datalistado.SelectedRows
            Dim Rows As DataGridViewRow
            Dim i As Int16 = 0
            For Each Rows In RowSelect
                i += 1
            Next
            If i = 1 Then
                Me.id_Producto = RowSelect.Item(0).Cells(0).Value
                Me.id_Present = RowSelect.Item(0).Cells("idPresentacion").Value.ToString()
                Me.Nom_comercial = RowSelect.Item(0).Cells("Nom_Comun").Value.ToString()
                '
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function



    Private Sub ImprimirCodBarrToolStripMenuI_Click(sender As Object, e As EventArgs) Handles ImprimirCodBarrToolStripMenuI.Click
        If barCodeTextBox.Text.Length <> 0 Then
            ImprimirCodigo.Print()
        Else
            msgAviso("No hay código de barras EAN para guardar.")
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ImprimirCodigo.PrintPage
        Try
            e.PageSettings.PrinterSettings = dialogoPrint
            Me.barCodeTextBox.Text = Trim(Me.barCodeTextBox.Text)
            Dim pagina As Integer = 1

            Dim Fuente As New Font("arial", 10, FontStyle.Regular)
            Dim salto_linea As Integer = Fuente.GetHeight(e.Graphics)

            Dim linea_actual As Integer = 0
            linea_actual = linea_actual + 1
            '//////////////////////////////////////////////////////////// Drow in paint
            'Write the label producto
            If Not IsNothing(PictureBoxCopy) Then
                e.Graphics.DrawImage(PictureBoxCopy, 0, 0)
                linea_actual = linea_actual + 1
                If linea_actual * salto_linea >= e.MarginBounds.Bottom Then
                    pagina = pagina + 1
                    linea_actual = 0
                    e.HasMorePages = True
                    'Exit For
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub GuardarImagen(ByVal txtnombre As String)
        ' Dim txtnombre As String = "imagen.bmp"
        Try
            If String.IsNullOrEmpty(txtnombre) Then
                MessageBox.Show("Debes indicar el nombre del fichero",
                                "Guardar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop)
                Exit Sub
            End If
            ' Usar el formato según la extensión
            Dim ext As String = Path.GetExtension(txtnombre).ToLower()
            If Not IsNothing(PictureBoxCopy) Then
                Select Case ext
                    Case ".jpg"
                        Me.PictureBoxCopy.Save(txtnombre, ImageFormat.Jpeg)
                    Case ".png"
                        PictureBoxCopy.Save(txtnombre, ImageFormat.Png)
                    Case ".gif"
                        PictureBoxCopy.Save(txtnombre, ImageFormat.Gif)
                    Case ".bmp"
                        PictureBoxCopy.Save(txtnombre, ImageFormat.Bmp)
                    Case ".tif"
                        PictureBoxCopy.Save(txtnombre, ImageFormat.Tiff)
                    Case Else
                        PictureBoxCopy.Save(txtnombre)
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub datalistado_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.RowEnter
        If isLoated Then
            Try
                If datalistado.SelectedRows.Count = 1 Then
                    If datalistado.SelectedRows(0).Cells("Barcode").Value.ToString().Length > 0 Then
                        DrawCodBarr()
                    Else
                        Me.PictureBox1.Image = Nothing
                        Me.barCodeTextBox.Text = String.Empty
                    End If
                Else
                    Me.PictureBox1.Image = Nothing
                    Me.barCodeTextBox.Text = String.Empty
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Me.barCodeTextBox.Text = String.Empty
            End Try
        End If
    End Sub
    Private Sub DrawCodBarr(Optional barCodeNew As String = "")
        Try
            Dim codBarr As String = If(barCodeNew.Length = 0, datalistado.SelectedRows(0).Cells("Barcode").Value.ToString, barCodeNew)
            Dim labelProduct As String = datalistado.SelectedRows(0).Cells("Nom_Comun").Value
            Dim priceProduct As Double = datalistado.SelectedRows(0).Cells("precioVenta").Value
            Dim empProduct As String = datalistado.SelectedRows(0).Cells("Nom_Medida").Value
            PictureBoxCopy = DrawBarCode.DrawBarCodeAndLabel(Trim(codBarr), labelProduct, priceProduct, empProduct, _ziView, isPrintLabel:=True)
            Me.PictureBox1.Image = PictureBoxCopy
            Me.barCodeTextBox.Text = codBarr
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If Me.datalistado.SelectedRows.Count = 1 Then
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Dim Menu As ContextMenuStrip = Me.ContextMenuSettingCodBarr()
                Menu.Items("GenerarCodigoDeBarraToolStripMenuItem").Visible = If(barCodeTextBox.Text.Length > 0, False, True)
                Menu.Items("CambiarCodigoDeBarraToolStripMenuItem").Visible = If(barCodeTextBox.Text.Length > 0, True, False)
                Menu.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub VerADosPixelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerADosPixelesToolStripMenuItem.Click
        If _ziView = 2 Then
            Return
        End If

        _ziView = 2
        If Me.barCodeTextBox.Text.Length > 0 Then
            DrawCodBarr()
        End If
    End Sub
    Private Sub VerA1PixelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerA1PixelToolStripMenuItem.Click
        If _ziView = 1 Then
            Return
        End If

        _ziView = 1
        If Me.barCodeTextBox.Text.Length > 0 Then
            DrawCodBarr()
        End If
    End Sub
    Private Sub GenerarCodigoDeBarraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarCodigoDeBarraToolStripMenuItem.Click
        GeneratedBarCode()
    End Sub

    Private Sub GeneratedBarCode()
        Try
            If Not (Me.datalistado.SelectedRows.Count = 1) Then
                Return
            End If
            Using frmBarrCodes As New frmBarrCode
                With frmBarrCodes
                    .ProductoLabel.Text = datalistado.SelectedRows(0).Cells("Nom_Comercial").Value.ToString
                    .PresentacionLabel.Text = datalistado.SelectedRows(0).Cells("Nom_Medida").Value.ToString
                    .idPresent = datalistado.SelectedRows(0).Cells("idPresentacion").Value.ToString
                    .barCodeTextBox.Text = datalistado.SelectedRows(0).Cells("Barcode").Value.ToString
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        DrawCodBarr(.barCodeTextBox.Text)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CambiarCodigoDeBarraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarCodigoDeBarraToolStripMenuItem.Click
        GeneratedBarCode()
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        If Me.datalistado.SelectedRows.Count = 1 Then
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Dim Menu As ContextMenuStrip = Me.ContextMenuAdminCodeBarr()
                For Each item In Menu.Items
                    item.Enabled = If(barCodeTextBox.Text.Length > 0, True, False)
                Next
                Menu.Show(Cursor.Position)
            End If
        End If
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim rutaNombreFichEAN As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Guardar Image File"
        saveFileDialog1.FileName = Trim(Me.barCodeTextBox.Text)
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            rutaNombreFichEAN = saveFileDialog1.FileName
            If Dir(rutaNombreFichEAN) <> "" Then
                Kill(rutaNombreFichEAN)
            End If
            GuardarImagen(rutaNombreFichEAN)
        End If
    End Sub
    Private Sub ContextMenuAdminCodeBarr_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuAdminCodeBarr.Opening
        Dim Menu As ContextMenuStrip = Me.ContextMenuAdminCodeBarr()
        For Each item In Menu.Items
            item.Enabled = If(barCodeTextBox.Text.Length > 0, True, False)
        Next
        Menu.Show(Cursor.Position)
    End Sub

    Private Sub ImprimirCodigo_BeginPrint(sender As Object, e As PrintEventArgs) Handles ImprimirCodigo.BeginPrint
        Dim peitnBialo As New PrintDialog
        peitnBialo.PrinterSettings = dialogoPrint
        If Not peitnBialo.ShowDialog() = DialogResult.OK Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub FolderBrouserButton_Click(sender As Object, e As EventArgs) Handles FolderBrouserButton.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            FolderFileTextBox.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub EnviarAUnaRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarAUnaRutaToolStripMenuItem.Click
        If FolderFileTextBox.Text.Length > 0 Then
            Dim rutaNombreFichEAN As String = String.Format("{0}\{1}.png", FolderFileTextBox.Text, Trim(barCodeTextBox.Text))
            If Dir(rutaNombreFichEAN) <> "" Then
                Kill(rutaNombreFichEAN)
            End If
            GuardarImagen(rutaNombreFichEAN)
        Else
            MsgBox("No se ha especificado una carpeta a guardar.", MsgBoxStyle.Exclamation, "Importante")
        End If
    End Sub

    Private Sub EtiquetasButton_Click(sender As Object, e As EventArgs) Handles EtiquetasButton.Click
        Try
            Using newView As New frmViewBarcodeList()
                With newView
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        My.Computer.Clipboard.SetImage(PictureBoxCopy)
    End Sub
    Private Sub PictureBoxCopyNetWord()
        Try
            If Not IsNothing(PictureBoxCopy) Then
                My.Computer.Clipboard.SetImage(PictureBoxCopy)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EnviarMyListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarMyListToolStripMenuItem.Click
        Try
            Dim idPresent = Integer.Parse(datalistado.SelectedRows(0).Cells("idPresentacion").Value)
            If Not IsNothing(idPresent) Then
                Using db As New DataContext
                    Dim _myItem As New ViewBarCodeTicket With
                    {
                        .CodUser = UsuarioActivo.codUser,
                        .CountTicket = 1,
                        .IdPresent = idPresent
                    }
                    db.ViewBarCodeTicket.InsertOnSubmit(_myItem)
                    db.SubmitChanges()
                End Using
            End If
        Catch ex As Exception
            If Not ex.Message.Contains("UQ_ViewBarCodeTicket_IdPresent") Then
                MsgBox(ex.Message & " " & ex.StackTrace.ToString, MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub
    Private Sub DeleteBarCodButton_Click(sender As Object, e As EventArgs) Handles DeleteBarCodButton.Click
        Try
            If Not datalistado.SelectedRows.Count = 1 Then
                Return
            End If

            Dim idPresent = Integer.Parse(datalistado.SelectedRows(0).Cells("idPresentacion").Value)
            If Not IsNothing(idPresent) Then
                If MsgBox("Está seguro de borra el código de barra..", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                    If DeleteBarCod(idPresent) Then
                        Me.PictureBox1.Image = Nothing
                        Me.barCodeTextBox.Text = String.Empty
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ExpirateButton_Click(sender As Object, e As EventArgs) Handles ExpirateButton.Click
        IsSelectedRow()
        Try
            Using newViewExpir As New frmAdminDateExpir(Me.id_Producto, Me.Nom_comercial)
                newViewExpir.ShowDialog()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class