Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports CADsisVenta
Imports CADsisVenta.DataSetTicket

Public Class FrmViewSalesSing

    Private tableAdapter As DataSetTicketTableAdapters.GetListViewCodBarrTableAdapter
    Private ImpresoraActual As New Printing.PrinterSettings

    Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource
    Dim dtTable As GetListViewCodBarrDataTable
    Dim DataSet1 As DataSetTicket
    Private Sub FrmSalesSing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'JSofwareCommerceDB02DataSet.GetListViewCodBarr' Puede moverla o quitarla según sea necesario.
        Try
            dtTable = New GetListViewCodBarrDataTable
            DataSet1 = New DataSetTicket
            GetListViewCodBarrBindingSource = New System.Windows.Forms.BindingSource()
            ReportDataSource1 = New Microsoft.Reporting.WinForms.ReportDataSource()
            tableAdapter = New DataSetTicketTableAdapters.GetListViewCodBarrTableAdapter

            GetListViewCodBarrBindingSource.DataMember = "GetListViewCodBarr"
            GetListViewCodBarrBindingSource.DataSource = DataSet1

            ReportDataSource1.Name = "DataSet1"

            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ECommercePlatformView.rptSalesSing.rdlc"
            BillData()
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddItemButton_MouseDown(sender As Object, e As MouseEventArgs) Handles AddItemButton.MouseDown
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DesdeUnaCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesdeUnaCategoríaToolStripMenuItem.Click
        Try
            Dim response As Boolean = False
            Using formCategories As New frm_Categoria(Nothing)
                With formCategories
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Dim id As Integer = .SelectedNode.Tag
                        If .isSubCategory Then
                            response = Add_SubCategoreis(id)
                        Else
                            response = Add_Categoreis(id)
                        End If
                    End If
                End With
            End Using
            If response Then
                BillData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TodaLaListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodaLaListaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If IntoAllList() Then
            BillData()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function IntoAllList() As Boolean
        Try
            sql = "INSERT INTO [tmp].[ViewSign]  (idPresent, codUser)
                    SELECT pp.idPresentacion, @codUser
                    FROM [dbo].[Productos] as p
	                inner join ProductoPresentacion as pp on p.idProducto = pp.idProducto 
	                and p.Deft_idPresenVenta = pp.idProUndMed"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser

                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            If ex.Message.Contains("UQ_ViewSign_idPresent") Then
                Return True
            Else
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Return False
            End If
            Return False
        End Try
    End Function

    Private Sub SoloUnProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoloUnProductoToolStripMenuItem.Click
        Try
            Using listProduct As New frmList_ProductPrecioVenta
                With listProduct
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        If Add_OnePorduct(.idProducto) Then
                            BillData()
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function Add_SubCategoreis(id As Integer) As Boolean
        Try
            sql = "INSERT INTO [tmp].[ViewSign]  (idPresent, codUser)
                    SELECT pp.idPresentacion, @CodUser
                    FROM [dbo].[Productos] as p
	                inner join ProductoPresentacion as pp on p.idProducto = pp.idProducto 
	                and p.Deft_idPresenVenta = pp.idProUndMed
                    where  p.IdSubCategoria =@IdSubCategoria "

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)

                    cmd.Parameters.Add("@CodUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@IdSubCategoria", SqlDbType.Int)

                    cmd.Parameters("@CodUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@IdSubCategoria").Value = id
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            If ex.Message.Contains("UQ_ViewSign_idPresent") Then
                Return True
            Else
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End Try
    End Function
    Private Function Add_Categoreis(id As Integer) As Boolean
        Try
            sql = "INSERT INTO [tmp].[ViewSign]  (idPresent, codUser)
                    SELECT pp.idPresentacion, @CodUser
                    FROM Productos as p
	                inner join ProductoPresentacion as pp on p.idProducto = pp.idProducto 
	                and p.Deft_idPresenVenta = pp.idProUndMed
	                inner join ProductoSubCategoria as sc on sc.idSubCategoria = p.IdSubCategoria
	                inner join ProductoCategoria as c on c.idCategoria  = sc.idCategoria
                    where  c.idCategoria =@idCategoria"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)

                    cmd.Parameters.Add("@CodUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@idCategoria", SqlDbType.Int)

                    cmd.Parameters("@CodUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@idCategoria").Value = id
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            If ex.Message.Contains("UQ_ViewSign_idPresent") Then
                Return True
            Else
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End Try
    End Function
    Private Sub View_Data()
        Try
            Me.DataGridView1.DataSource = Nothing

            Me.DataGridView1.DataSource = DataSet1.GetListViewCodBarr

            Me.totalItemCountLabel.Text = String.Format("Total etiquetas: {0}", dtTable.Rows.Count.ToString)

            clm = DataGridView1.Columns("idPresentacion")
            clm.HeaderText = "Codigo interno"

            clm = DataGridView1.Columns("Nom_Comun")
            clm.HeaderText = "Producto"
            clm.Width = 350

            clm = DataGridView1.Columns("PresentacionPrint")
            clm.HeaderText = "Presentación"
            clm.Width = 150

            clm = DataGridView1.Columns("precioVenta")
            clm.HeaderText = "Precio normal"
            clm.DisplayIndex = 3
            clm.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle _
                   With {.NullValue = 0, .Format = "C5", .Alignment = DataGridViewContentAlignment.MiddleRight}


            clm = DataGridView1.Columns("fromC")
            clm.HeaderText = "A partir de"
            clm.DefaultCellStyle = New DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight}

            clm = DataGridView1.Columns("PercentC")
            clm.HeaderText = "Descuento (%)"
            clm.DefaultCellStyle = myStilePercentage

            clm = DataGridView1.Columns("discount")
            clm.HeaderText = "Precio descuento"
            clm.DefaultCellStyle = New System.Windows.Forms.DataGridViewCellStyle _
                   With {.NullValue = 0, .Format = "C5", .Alignment = DataGridViewContentAlignment.MiddleRight}

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BillData()
        Try
            ReportDataSource1.Value = Nothing

            tableAdapter.Fill(DataSet1.GetListViewCodBarr, UsuarioActivo.codUser, TerminalActivo.idRates)

            Dim bmT As Image
            Dim bitmap As New Bitmap(100, 20)
            Dim Grafico As System.Drawing.Graphics
            bitmap.SetResolution(96.0F, 96.0F)
            bmT = bitmap
            Grafico = Graphics.FromImage(bmT)
            Grafico.Clear(Color.White)
            Dim bitWhite As Byte() = ConvertImageToByteArray(bmT)

            For Each item In DataSet1.GetListViewCodBarr
                'carga imagem
                If Not IsNothing(item.Barcode) Then
                    If Not (String.IsNullOrEmpty(item.Barcode)) Then
                        item.barImage = ConvertImageToByteArray(DrawBarCode.DrawBarCodeAndLabel(item.Barcode.Trim, "", 0, "", 1, 20, isPrintLabel:=False))
                    End If
                Else
                    item.barImage = bitWhite
                End If
            Next

            View_Data()

            ReportDataSource1.Value = GetListViewCodBarrBindingSource

            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)

            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Add_OnePorduct(id As Integer) As Boolean
        Try

            sql = "INSERT INTO [tmp].[ViewSign]  (idPresent, codUser)
                    SELECT pp.idPresentacion, @CodUser
                    FROM [dbo].[Productos] as p
	                inner join ProductoPresentacion as pp on p.idProducto = pp.idProducto 
	                and p.Deft_idPresenVenta = pp.idProUndMed
	                where p.idProducto = @idProducto"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.Add("@CodUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@idProducto", SqlDbType.Int)

                    cmd.Parameters("@CodUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@idProducto").Value = id
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            If ex.Message.Contains("UQ_ViewSign_idPresent") Then
                Return True
            Else
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End Try
    End Function
    Private Sub DeleteItemButton_Click(sender As Object, e As EventArgs) Handles DeleteItemButton.Click
        Dim list = DataGridView1.SelectedRows
        If IsNothing(list) Then
            Return
        End If

        If Not (MsgBox("Esta seguro de borrar los items seleccionados.",
                    MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes) Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        If DeteleItemsSelect() Then
            BillData()
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Function DeteleItemsSelect() As Boolean
        Try
            Dim list = DataGridView1.SelectedRows
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Dim transaction As SqlTransaction = cnn.BeginTransaction

                sql = "Delete [tmp].[ViewSign] 
                       Where idPresent =@idPresent and codUser = @codUser"
                Try
                    Using cmd As New SqlCommand(sql, cnn, transaction)
                        cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                        cmd.Parameters.Add("@idPresent", SqlDbType.Int)

                        For Each item As DataGridViewRow In list
                            cmd.Parameters("@idPresent").Value = item.Cells("idPresentacion").Value
                            cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                            If Not cmd.ExecuteNonQuery() > 0 Then

                            End If
                        Next
                    End Using

                Catch ex2 As Exception
                    transaction.Rollback()
                    Me.Cursor = Cursors.Default
                    MsgBox(ex2.Message & " " & ex2.StackTrace, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
                transaction.Commit()
                Return True
            End Using

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub PrintColorButton_Click(sender As Object, e As EventArgs) Handles PrintColorButton.Click
        Try
            ReportViewer1.PrinterSettings = ImpresoraActual
            ReportViewer1.PrintDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
                .PrinterSettings = ImpresoraActual
                If .ShowDialog() = DialogResult.OK Then
                    SettingConfigPrintButton.Tag = 1
                    ImpresoraActual = .PrinterSettings
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SaveListButton_Click(sender As Object, e As EventArgs) Handles SaveListButton.Click
        If Me.DataGridView1.Rows.Count = 0 Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        If SaveList() Then
            Me.Cursor = Cursors.Default
            MsgBox(msgExsito, MsgBoxStyle.Information, "Error")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Function SaveList() As Boolean

        Try

            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Dim transaction As SqlTransaction = cnn.BeginTransaction

                sql = "Delete [tmp].[ViewSign] 
                       Where  codUser = @codUser"
                Try
                    Using cmd As New SqlCommand(sql, cnn, transaction)
                        cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                        cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                        If Not cmd.ExecuteNonQuery() > 0 Then
                        End If
                        cmd.Parameters.Add("@idPresent", SqlDbType.Int)

                        sql = "INSERT INTO [tmp].[ViewSign]  (idPresent, codUser)
                               Values(@idPresent, @CodUser)"

                        cmd.CommandText = sql
                        For Each item As DataGridViewRow In DataGridView1.Rows
                            cmd.Parameters("@idPresent").Value = item.Cells("idPresentacion").Value
                            If Not cmd.ExecuteNonQuery() > 0 Then

                            End If
                        Next
                    End Using
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    Me.Cursor = Cursors.Default
                    MsgBox(ex2.Message & " " & ex2.StackTrace, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub InserTheDataBaseButton_Click(sender As Object, e As EventArgs) Handles InserTheDataBaseButton.Click
        BillData()
    End Sub

    Private Sub DeleteDataBaseButton_Click(sender As Object, e As EventArgs) Handles DeleteDataBaseButton.Click

    End Sub
End Class