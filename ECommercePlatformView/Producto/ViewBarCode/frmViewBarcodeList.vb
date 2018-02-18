Imports System.ComponentModel
Imports System.Drawing.Printing
Imports CADsisVenta

Public Class frmViewBarcodeList
    Private document As PrintDocument
    Private WithEvents pdPrint As PrintDocument
    Private StrPrinterName As String = "Códigos de barra"
    Private ImpresoraActual As PrinterSettings

    Dim pbImage2 As PictureBox
    Private IsLoad As Boolean

    Dim PARRAFOS As Collection 'PARA ALMACENAR LOS PARRAFOS
    Dim MICOLOR As SolidBrush 'PARA PODER CAMBIAR COLORES
    Dim PAGINAS As Integer 'PARA NUMERAR LAS PAGINAS
    Dim TotalEtiquetas As Integer = 0
    Dim Rows As Integer
    Dim subItem As Integer
    Dim nomeNext As Boolean

    Private customersBindingSource As New Windows.Forms.BindingSource()
    Private customerList As BindingList(Of ItemCodBarTicket)


    Private Sub frmViewListBarCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImpresoraActual = New PrinterSettings With {.PrinterName = StrPrinterName}

        PAGINAS = 1
        IntializaDataVew()
        InitializeSettingPage()
        IsLoad = True
    End Sub

    Private Sub InitializeSettingPage()
        Dim TamañoPersonal As Printing.PaperSize

        Dim Ancho As Short
        Dim Alto As Short
        Try
            Ancho = Short.Parse(120)
            Alto = Short.Parse(75)
            TamañoPersonal = New Printing.PaperSize("BorCodView", Ancho, Alto)
            If ImpresoraActual.IsValid Then
                PrintDocument1.PrinterSettings = ImpresoraActual
            End If
            PrintDocument1.DefaultPageSettings.PaperSize = TamañoPersonal

            PrintDocument1.DefaultPageSettings.Margins.Left = 5
            PrintDocument1.DefaultPageSettings.Margins.Right = 5

            PrintPreviewControl1.Document = Nothing
            PrintPreviewControl1.Document = PrintDocument1
            Me.PrintPreviewControl1.UseAntiAlias = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub IntializaDataVew()
        Me.DataGridView1.AutoGenerateColumns = False
        customerList = New BindingList(Of ItemCodBarTicket)
        Me.customersBindingSource.DataSource = customerList
        Me.DataGridView1.DataSource = customersBindingSource
        DataGridView1.Columns(IdPresentClm.Index).Visible = False
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#Region "Comands"
    Private Function AddItemInList() As Boolean
        Try
            If Not isValidated() Then Return False

            If IsNothing(Me.customerList) Then
                customerList = New BindingList(Of ItemCodBarTicket)
            End If
            customerList.Add(New ItemCodBarTicket With
                              {
                                  .BarCod = Me.BarCodTextBox.Text.Trim(),
                                  .CountTicket = Me.CountTicketsNumericUpDown.Value,
                                  .IdPresent = Integer.Parse(Me.idPresentTextBox.Text),
                                  .NameProduct = TituloSuperiorTextBox.Text.Trim(),
                                  .Presentation = PresentationTextBox.Text,
                                  .UnitPrice = UnitPriceNumericUpDown.Value
                              })

            ClearTheBox()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function isValidated() As Boolean
        Try
            If String.IsNullOrEmpty(Me.BarCodTextBox.Text) Then
                Me.TabControl1.SelectedIndex = 0
                MsgBox("Debe ingresar el codigo de barra.", MsgBoxStyle.Information, "Importante")
                BarCodTextBox.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(TituloSuperiorTextBox.Text) Then
                Me.TabControl1.SelectedIndex = 0
                MsgBox("Debe ingresar el titulo.", MsgBoxStyle.Information, "Importante")
                TituloSuperiorTextBox.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(PresentationTextBox.Text) Then
                Me.TabControl1.SelectedIndex = 0
                MsgBox("Debe ingresar la presentación del producto.", MsgBoxStyle.Information, "Importante")
                PresentationTextBox.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub ClearTheBox()
        Me.BarCodTextBox.Text = String.Empty
        Me.CountTicketsNumericUpDown.Value = 1
        TituloSuperiorTextBox.Text = String.Empty
        PresentationTextBox.Text = String.Empty
        UnitPriceNumericUpDown.Value = 0
    End Sub

#End Region
#Region "Methods"
    Private Sub Load_DataServer()
        Try
            Using db As New DataContext
                Dim _listserver = From i In db.ViewBarCodeTicket
                                  Join pp In db.ProductoPresentacion On pp.idPresentacion Equals i.IdPresent
                                  Join p In db.Productos On p.idProducto Equals pp.idProducto
                                  Where i.CodUser = UsuarioActivo.codUser

                For Each item In _listserver
                    customerList.Add(New ItemCodBarTicket With
                                     {
                                     .BarCod = item.pp.Barcode.Trim(),
                                     .IdPresent = item.i.IdPresent,
                                     .NameProduct = item.p.Nom_Comun,
                                     .Presentation = item.pp.PresentacionPrint,
                                     .UnitPrice = item.pp.precioVenta,
                                     .CountTicket = item.i.CountTicket
                                     })
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Try


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PrintColorButton_Click(sender As Object, e As EventArgs) Handles PrintColorButton.Click
        Try
            SettingConfigPrintButton.Tag = 0
            SettingConfigPrintButton.PerformClick()
            If SettingConfigPrintButton.Tag = 0 Then
                Return
            End If
            PrintDocument1.PrinterSettings = ImpresoraActual
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SaveListButton_Click(sender As Object, e As EventArgs) Handles SaveListButton.Click
        If SaveData() Then
            MsgBox("Información guardada exitosamente..", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Function SaveData() As Boolean
        Try
            If Me.customerList.Count = 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("No existe información para guardar.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim db As New DataContext

            Dim transaction As System.Data.Common.DbTransaction

            db.Connection.Open()
            transaction = db.Connection.BeginTransaction()
            Try
                db.Transaction = transaction
                Dim itemBarCode = From t In db.ViewBarCodeTicket
                                  Where t.CodUser = UsuarioActivo.codUser

                For Each item In itemBarCode
                    db.ViewBarCodeTicket.DeleteOnSubmit(item)
                Next
                db.SubmitChanges()

                For Each item In Me.customerList
                    Dim NewItemBarCode As New ViewBarCodeTicket With
                    {
                    .CodUser = UsuarioActivo.codUser,
                    .CountTicket = item.CountTicket,
                    .IdPresent = item.IdPresent
                    }
                    db.ViewBarCodeTicket.InsertOnSubmit(NewItemBarCode)
                Next
                db.SubmitChanges()
                transaction.Commit()
                Me.Cursor = Cursors.Default
                Return True
            Catch ex2 As Exception
                Me.Cursor = Cursors.Default
                MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                If Not IsNothing(transaction) Then
                    transaction.Rollback()
                End If
                Return False
            End Try
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Try
            Me.PrintPreviewControl1.Zoom = NumericUpDown1.Value / 100
            PrintPreviewControl1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
#End Region

#Region "PrintDocument"
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Try
            If LoadOptionsPrint(StrPrinterName) Then
                e.Cancel = Not PrinterNametInstol(myOptnsPrint.NamePrint)
            Else
                e.Cancel = True
            End If

            Me.Cursor = Cursors.WaitCursor
            PAGINAS = 1
            Rows = 0
            subItem = 0
            Dim _total = Aggregate i In customerList
                         Where i.Generated = True
                         Into Sum(i.CountTicket)

            If Not IsNothing(_total) Then
                TotalEtiquetas = If(_total = 0, 1, _total)
            Else
                TotalEtiquetas = 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub pdPrint_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            If customerList.Count = 0 Then Return
            nomeNext = False
            If (Rows + 1) <= TotalEtiquetas Then
                Dim item = customerList.Item(Rows)

                If Not customerList.Item(Rows).Generated Then
                    nomeNext = True
                    subItem = 0
                ElseIf customerList.Item(Rows).CountTicket = 1 Then
                    DrawBarCode.DrawBarCodeAndLabel(item.BarCod, item.NameProduct,
                            PriceProduc:=item.UnitPrice, LabelEmp:=item.Presentation, Width:=40, GraficoView:=e.Graphics, isPrintLabel:=True)
                    nomeNext = True
                    subItem = 0
                Else
                    If subItem <= customerList.Item(Rows).CountTicket Then
                        DrawBarCode.DrawBarCodeAndLabel(item.BarCod, item.NameProduct,
                           PriceProduc:=item.UnitPrice, LabelEmp:=item.Presentation, Width:=40, GraficoView:=e.Graphics, isPrintLabel:=True)
                        subItem += 1
                        If subItem = customerList.Item(Rows).CountTicket Then
                            subItem = 0
                            nomeNext = True
                        End If
                    End If
                End If
                e.HasMorePages = True
            End If
            PAGINAS += 1

            If Rows + 1 = customerList.Count Then
                If customerList.Item(Rows).CountTicket > 1 Then
                    If subItem = 0 Then
                        e.HasMorePages = False
                    End If
                Else
                    e.HasMorePages = False
                End If
            End If
            If nomeNext Then
                Rows += 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PagueNumericUpDown_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PreViewButton_Click(sender As Object, e As EventArgs) Handles PreViewButton.Click
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TabSetting_Click(sender As Object, e As EventArgs) Handles TabSetting.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub finInDataSourseButton_Click(sender As Object, e As EventArgs) Handles finInDataSourseButton.Click
        Try
            Using newlist As New frmList_ProductPrecioVenta
                With newlist
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.Cursor = Cursors.WaitCursor
                        LoadItemProduct(.idPresent)
                    End If
                End With
            End Using
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadItemProduct(idPresent As Integer)
        Try
            Using db As New DataContext
                Dim product = From p In db.Productos
                              Join pp In db.ProductoPresentacion On p.idProducto Equals pp.idProducto
                              Where pp.idPresentacion = idPresent

                For Each item In product
                    Me.TituloSuperiorTextBox.Text = item.p.Nom_Comun
                    Me.BarCodTextBox.Text = item.pp.Barcode.Trim()
                    Me.PresentationTextBox.Text = item.pp.PresentacionPrint
                    Me.UnitPriceNumericUpDown.Value = item.pp.precioVenta
                    Me.idPresentTextBox.Text = idPresent
                Next
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SettingConfigPrintButton_Click(sender As Object, e As EventArgs) Handles SettingConfigPrintButton.Click
        Dim prtDialog As New PrintDialog
        SettingConfigPrintButton.Tag = 0
        Try
            If ImpresoraActual Is Nothing Then
                ImpresoraActual = New PrinterSettings
            End If

            With prtDialog
                .AllowPrintToFile = False
                .AllowSelection = False
                .AllowSomePages = False
                .PrintToFile = False
                .ShowHelp = False
                .ShowNetwork = True

                .PrinterSettings = ImpresoraActual

                If .ShowDialog() = DialogResult.OK Then
                    ImpresoraActual = .PrinterSettings
                    SettingConfigPrintButton.Tag = 1
                    InitializeSettingPage()
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RefreshViewButton_Click(sender As Object, e As EventArgs) Handles RefreshViewButton.Click
        Try
            Me.PrintPreviewControl1.Document = Nothing
            Me.PrintPreviewControl1.Document = PrintDocument1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub InserTheDataBaseButton_Click(sender As Object, e As EventArgs) Handles InserTheDataBaseButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Load_DataServer()
            Me.TabControl1.SelectedIndex = 1
            PrintPreviewControl1.Document = Nothing
            PrintPreviewControl1.Document = PrintDocument1
            PrintPreviewControl1.Rows = TotalEtiquetas
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteDataBaseButton_Click(sender As Object, e As EventArgs) Handles DeleteDataBaseButton.Click
        Try
            If Not (MsgBox("Está seguro de borra la lista de base de datos..",
                      MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes) Then
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            Using db As New DataContext
                Dim itemBarCode = From t In db.ViewBarCodeTicket
                                  Where t.CodUser = UsuarioActivo.codUser

                For Each item In itemBarCode
                    db.ViewBarCodeTicket.DeleteOnSubmit(item)
                Next
                db.SubmitChanges()
                Me.Cursor = Cursors.Default
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace.ToString(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteItemButton_Click(sender As Object, e As EventArgs) Handles DeleteItemButton.Click
        Try
            Me.TabControl1.SelectedIndex = 1
            If DataGridView1.SelectedRows.Count = 0 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            If Not (MsgBox("Está seguro de borrar items seleccionados.?",
                      MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes) Then
                Return
            End If

            Dim _customerList As New BindingList(Of ItemCodBarTicket)

            For Each item As DataGridViewRow In DataGridView1.Rows
                If Not item.Selected Then
                    _customerList.Add(New ItemCodBarTicket With
                                  {
                                  .BarCod = item.Cells(Me.BarCodClm.Index).Value,
                                  .CountTicket = item.Cells(CountTicketClm.Index).Value,
                                   .IdPresent = item.Cells(IdPresentClm.Index).Value,
                                   .NameProduct = item.Cells(TitleTopClm.Index).Value,
                                    .Presentation = item.Cells(Me.PresentationClm.Index).Value,
                                    .UnitPrice = item.Cells(UnitPriceClm.Index).Value
                                  })
                End If
            Next

            Me.customerList.Clear()
            For Each item In _customerList
                customerList.Add(item)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        If AddItemInList() Then
            Me.TabControl1.SelectedIndex = 1
            PrintPreviewControl1.Document = Nothing
            PrintPreviewControl1.Document = PrintDocument1
        End If
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.EndPrint
        PrintPreviewControl1.Rows = TotalEtiquetas
        Me.EtiquetasLabelCount.Text = String.Format("Etiquetas:{0}", TotalEtiquetas.ToString())
        Me.Cursor = Cursors.Default
    End Sub

#End Region

End Class