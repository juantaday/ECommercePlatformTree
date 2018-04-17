Imports BrightIdeasSoftware
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmViewTranfer

    Private listItem As List(Of ItemProductTranfer)
    Protected compraTotal As Double
    Protected ventaTotal As Double

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        initializeComponents()
        initializeComponents2()
        listItem = New List(Of ItemProductTranfer)
    End Sub
    Private Sub frmViewTranfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_bodega()
        LoadListView()
        Me.OrigenComboBox.SelectedIndex = -1
        Me.DestinoComboBox.SelectedIndex = -1
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If ObjectListView1.SelectedObjects.Count = 1 Then
                Me.PanelView.Controls.Clear()
                Me.PanelView.Controls.Add(Me.PanelDetail)
                Me.PanelDetail.Visible = True
                Me.PanelDetail.Enabled = True
                Me.PanelDetail.Dock = DockStyle.Fill


                PanelView.Controls.Add(PanelList)
                PanelList.Dock = DockStyle.Left
                PanelList.Width = 250
                PanelList.Enabled = False

                Dim obj = Me.ObjectListView1.SelectedObject
                Dim idtransfer = obj.trans.IdTransfer

                LoadDetailsListView(Integer.Parse(idtransfer))
                Me.Cursor = Cursors.Default

            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Carga_bodega()
        Try
            Using dat As New BodegaSystemTableAdapter
                Using dt As New BodegaSystemDataTable
                    dat.Fill(dt)
                    OrigenComboBox.DataSource = dt.ToList()
                    OrigenComboBox.DisplayMember = "Nom_Bodega"
                    OrigenComboBox.ValueMember = "idBodega"
                    OrigenComboBox.SelectedIndex = -1

                    DestinoComboBox.DataSource = dt.ToList()
                    DestinoComboBox.DisplayMember = "Nom_Bodega"
                    DestinoComboBox.ValueMember = "idBodega"
                    DestinoComboBox.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ArrowBackButton_Click(sender As Object, e As EventArgs) Handles ArrowBackButton.Click
        initializeComponents()
    End Sub
    Private Sub initializeComponents()
        Me.PanelView.Controls.Clear()
        Me.PanelView.Controls.Add(Me.PanelList)
        Me.PanelView.Controls.Add(Me.PanelDetail)
        Me.PanelDetail.Dock = DockStyle.Right
        Me.PanelDetail.Width = 250
        Me.PanelDetail.Enabled = False

        Me.PanelList.Dock = DockStyle.Fill
        Me.PanelList.Enabled = True
        Me.PanelView.Dock = DockStyle.Fill
    End Sub
    Private Sub initializeComponents2()
        Try
            Me.CountClm.AspectGetter = Function(ByVal x As Object)
                                           Return (CType(x, ItemProductTranfer)).count_Tranfer
                                       End Function
            Me.CountClm.AspectPutter = Sub(x As Object, newValue As Object)
                                           DirectCast(x, ItemProductTranfer).count_Tranfer = (Double.Parse(newValue))
                                       End Sub




            CountClm.DataType = GetType(Double)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Try
            PanelView.Controls.Clear()
            ListView1.ClearObjects()
            Me.listItem.Clear()


            PanelView.Controls.Add(Me.PanelAdd)
            Me.PanelAdd.Dock = DockStyle.Fill
            Me.PanelAdd.Enabled = True


            PanelView.Controls.Add(Me.PanelList)
            Me.PanelList.Dock = DockStyle.Left
            Me.PanelList.Width = 250
            Me.PanelList.Enabled = False

            Me.OrigenComboBox.SelectedIndex = -1
            Me.DestinoComboBox.SelectedIndex = -1
            Me.NameTranferTextBox.Text = String.Empty

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        initializeComponents()
    End Sub

    Private Sub NewCombinedButton_Click(sender As Object, e As EventArgs) Handles NewCombinedButton.Click
        If AddNewItemTransfer() Then
            SumaTotales()
        End If
    End Sub

    Private Function AddNewItemTransfer() As Boolean
        Try
            Using newlist As New frmList_ProductoView(stateLoad.Dialogo)
                With newlist
                    .PanelAdmin.Visible = False
                    .SplitContainer1.Panel2.Visible = False
                    .SplitContainer1.SplitterDistance = .Width * 0.97
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Return AddNewItem(.datalistado.SelectedRows(0))
                    End If
                End With
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Function AddNewItem(row As DataGridViewRow) As Boolean
        Try

            listItem.Add(New ItemProductTranfer With
              {
                  .count_Tranfer = 1,
                  .idPresent = row.Cells("idPresentacion").Value,
                  .IdProducto = row.Cells("idProducto").Value,
                  .PrecioCompra = row.Cells("UltimaCompra").Value,
                  .PrecioVenta = row.Cells("precioVenta").Value,
                  .Nom_Comercial = row.Cells("Nom_Comercial").Value,
                  .codProducto = row.Cells("codProducto").Value,
                  .PresentacionPrint = row.Cells("PresentacionPrint").Value
               })
            Me.ListView1.SetObjects(listItem)
            Return True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_CellEditFinishing(sender As Object, e As BrightIdeasSoftware.CellEditEventArgs) Handles ListView1.CellEditFinishing
        Dim _newValue As Double = 0
        If Not Double.TryParse(e.NewValue, _newValue) Then
            e.Cancel = True
            Me.NotifyIcon1.Text = "Debe ingresar un valor numérico.."
            Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
            Me.NotifyIcon1.BalloonTipText = "Debe ingresar un valor numérico.."
            Me.NotifyIcon1.ShowBalloonTip(2000)
        Else
            SumaTotales()
        End If
    End Sub

    Private Sub SumaTotales()
        Try
            compraTotal = Aggregate t In Me.listItem
                             Into Sum(t.count_Tranfer * t.PrecioCompra)

            ventaTotal = Aggregate t In Me.listItem
                             Into Sum(t.count_Tranfer * t.PrecioVenta)

            Me.totalCompraLabel.Text = String.Format("Total al precio de compra: {0}",
                                                     compraTotal.ToString("C2"))

            Me.totalVentaLabel.Text = String.Format("Total al precio de venta: {0}",
                                                   ventaTotal.ToString("C2"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If ListView1.SelectedObjects.Count = 0 Then
            Return
        End If

        If MsgBox("Está seguro de eliminar los items seleccionados...?",
                  MsgBoxStyle.Question _
                  + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2,
                  "Responda") = MsgBoxResult.Yes Then

            Dim myIList = ListView1.SelectedObjects

            Dim cleated As List(Of Object) = New List(Of Object)(myIList.OfType(Of Object)())
            For Each item In cleated
                Me.listItem.Remove(item)
            Next

            ListView1.RemoveObjects(ListView1.SelectedObjects)
            SumaTotales()
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Carga_bodega()
    End Sub

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click

        If ValidatedDatos() Then
            Me.Cursor = Cursors.WaitCursor
            If SaveDatas() Then
                LoadListView()
                Me.ArrowBackButton.PerformClick()
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub LoadListView()
        Try
            Using db As New DataContext
                Dim lisView = (From t In db.ProductTransfer
                               Join d In db.Bodegas On d.idBodega Equals t.idbodegaDestino
                               Join o In db.Bodegas On o.idBodega Equals t.idBodegaOrigen
                               Order By t.IdTransfer Descending
                               Select New With {.trans = t, .origen = o.Nom_Bodega, .destino = d.Nom_Bodega}
                               ).Take(200).ToList()


                Me.ObjectListView1.DataSource = lisView

            End Using

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub LoadDetailsListView(IdTransfer As Integer)
        Try
            Using db As New DataContext
                Dim lisView = (From d In db.ProductTransfer_Detail
                               Join pp In db.ProductoPresentacion On pp.idPresentacion Equals d.idPresent
                               Join p In db.Productos On pp.idProducto Equals p.idProducto
                               Where d.IdTransfer = IdTransfer
                               Select New With {pp.codProducto, p.Nom_Comercial, pp.PresentacionPrint,
                                 .Cantidad = d.count_Tranfer, d.PrecioCompra, d.PrecioVenta}
                               ).ToList()

                Me.FastDataListView1.DataSource = lisView
                FastDataListView1.AutoGenerateColumns = True
                For Each col As ColumnHeader In FastDataListView1.Columns
                    col.Width = 0
                Next
                FastDataListView1.AutoSizeColumns()
                FastDataListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.None
                FastDataListView1.IncludeColumnHeadersInCopy = True

                Dim totalcompra As Double = Aggregate t In lisView
                                      Into Sum(t.Cantidad * t.PrecioCompra)

                Dim totalVenta As Double = Aggregate t In lisView
                                      Into Sum(t.Cantidad * t.PrecioVenta)

                Me.totalCompraDetailsLabel.Text = String.Format(
                                        "Total al precio de compra: {0}",
                                        totalcompra.ToString("C2"))

                Me.totalVentaDetailsLabel.Text = String.Format(
                                        "Total al precio de venta: {0}",
                                        totalVenta.ToString("C2"))

            End Using

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SaveDatas() As Boolean
        Dim transaction As System.Data.Common.DbTransaction = Nothing
        Try

            Using db As New DataContext
                'FIND THE ID EMPAQUETADO
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction

                Dim transCabe = New ProductTransfer With
                    {
                    .codUser = UsuarioActivo.codUser,
                    .idbodegaDestino = DestinoComboBox.SelectedValue,
                    .idBodegaOrigen = OrigenComboBox.SelectedValue,
                    .NameTranfer = Trim(Me.NameTranferTextBox.Text),
                    .totalPrecioCompra = Me.compraTotal,
                    .totalPrecioVenta = Me.ventaTotal
                }

                db.ProductTransfer.InsertOnSubmit(transCabe)
                db.SubmitChanges()
                For Each item In Me.listItem
                    Dim detail = New ProductTransfer_Detail With
                    {
                        .count_Tranfer = item.count_Tranfer,
                        .idPresent = item.idPresent,
                        .IdTransfer = transCabe.IdTransfer,
                        .PrecioCompra = item.PrecioCompra,
                        .PrecioVenta = item.PrecioVenta
                     }
                    db.ProductTransfer_Detail.InsertOnSubmit(detail)
                Next

                db.SubmitChanges()

                transaction.Commit()
                Return True
            End Using
            Return False
        Catch ex As System.IO.IOException
            Me.Cursor = Cursors.Default
            If Not IsNothing(transaction) Then
                transaction.Rollback()
                transaction.Dispose()
            End If
            MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        Catch ex As NullReferenceException
            Me.Cursor = Cursors.Default
            If Not IsNothing(transaction) Then
                transaction.Rollback()
                transaction.Dispose()
            End If

            MessageBox.Show("NullReferenceException: " & ex.Message)
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
            Return False
        Catch ex As SqlClient.SqlException
            Me.Cursor = Cursors.Default
            If Not IsNothing(transaction) Then
                transaction.Rollback()
                transaction.Dispose()
            End If
            If ex.Class = 11 Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try
    End Function

    Private Function ValidatedDatos() As Boolean
        Try
            If Me.listItem.Count = 0 Then
                Me.NotifyIcon1.BalloonTipText = "No existe datos para guardar.."
                Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
                NotifyIcon1.ShowBalloonTip(1000)
                Return False
            End If

            If Me.OrigenComboBox.SelectedIndex = -1 Then
                Me.NotifyIcon1.BalloonTipText = "Seleccione el origen de traslado.."
                Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
                NotifyIcon1.ShowBalloonTip(1000)
                Me.ErrorProvider1.SetError(OrigenComboBox, "Seleccione el origen de traslado..")
                Return False
            End If

            If Me.DestinoComboBox.SelectedIndex = -1 Then
                Me.NotifyIcon1.BalloonTipText = "Seleccione el destino del producto.."
                Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
                NotifyIcon1.ShowBalloonTip(1000)
                Me.ErrorProvider1.SetError(DestinoComboBox, "Seleccione el destino del producto..")
                Return False
            End If


            If Me.OrigenComboBox.SelectedIndex = Me.DestinoComboBox.SelectedIndex Then
                Me.NotifyIcon1.BalloonTipText = "El lugar del destino no puede ser el misno orige.."
                Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
                NotifyIcon1.ShowBalloonTip(1000)
                Me.ErrorProvider1.SetError(DestinoComboBox, "El lugar del destino no puede ser el misno orige..")
                Return False
            End If

            If String.IsNullOrEmpty(Me.NameTranferTextBox.Text) Then
                Me.NotifyIcon1.BalloonTipText = "Escriba una pequeña descripción, del motivo del traslado"
                Me.NotifyIcon1.BalloonTipTitle = "JMTSystem Software"
                NotifyIcon1.ShowBalloonTip(1000)
                Me.ErrorProvider1.SetError(NameTranferTextBox, "Escriba una pequeña descripción, del motivo del traslado")
                Return False
            End If


            Me.ErrorProvider1.SetError(NameTranferTextBox, String.Empty)
            Me.ErrorProvider1.SetError(OrigenComboBox, String.Empty)
            Me.ErrorProvider1.SetError(DestinoComboBox, String.Empty)


            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.initializeComponents()
    End Sub

    Private Sub txtFindInAdd_TextChanged(sender As Object, e As EventArgs) Handles txtFindInAdd.TextChanged
        txtFindInAdd.VisibleButton = Not String.IsNullOrWhiteSpace(txtFindInAdd.Text)
        Me.TimedFilter(Me.ListView1, txtFindInAdd.Text)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String)
        Me.TimedFilter(olv, txt, 0)
    End Sub

    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String, ByVal matchKind As Integer)
        Dim filter As TextMatchFilter = Nothing
        If Not String.IsNullOrEmpty(txt) Then
            Select Case matchKind
                Case 0
                    filter = TextMatchFilter.Contains(olv, txt)
                Case 1
                    filter = TextMatchFilter.Prefix(olv, txt)
                Case 2
                    filter = TextMatchFilter.Regex(olv, txt)
            End Select
        End If

        If filter Is Nothing Then olv.DefaultRenderer = Nothing Else olv.DefaultRenderer = New HighlightTextRenderer(filter)
        Dim highlightingRenderer As HighlightTextRenderer = TryCast(olv.GetColumn(0).Renderer, HighlightTextRenderer)
        If highlightingRenderer IsNot Nothing Then highlightingRenderer.Filter = filter
        Dim stopWatch As Stopwatch = New Stopwatch()
        stopWatch.Start()
        olv.AdditionalFilter = filter
        stopWatch.[Stop]()
        Dim objects As IList = TryCast(olv.Objects, IList)
        If objects Is Nothing Then Me.Text = String.Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds) Else Me.Text = String.Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
    End Sub

    Private Sub textBoxFilterSimple_TextChanged(sender As Object, e As EventArgs) Handles textBoxFilterSimple.TextChanged
        textBoxFilterSimple.VisibleButton = Not String.IsNullOrWhiteSpace(textBoxFilterSimple.Text)
        Me.TimedFilter(Me.ObjectListView1, textBoxFilterSimple.Text)
    End Sub

    Private Sub textBoxFilterSimple_ButtonClick(sender As Object, e As EventArgs) Handles textBoxFilterSimple.ButtonClick
        textBoxFilterSimple.Text = String.Empty
        textBoxFilterSimple.Focus()
    End Sub

    Private Sub txtFindInAdd_ButtonClick(sender As Object, e As EventArgs) Handles txtFindInAdd.ButtonClick
        txtFindInAdd.Text = String.Empty
        txtFindInAdd.Focus()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        'cambiar el motivo
        Try
            If Not Me.ObjectListView1.SelectedObjects.Count = 1 Then
                Return
            End If
            Using Dialog As New frmCahgedNameTranfer()
                Dim obj = Me.ObjectListView1.SelectedObject
                Dim nameTranfers = obj.trans.NameTranfer
                Dim idtrasfe = obj.trans.IdTransfer

                Dialog.NewNameTransferTextBox.Text = nameTranfers
                Dialog.ShowDialog()
                If Dialog.DialogResult = DialogResult.OK Then
                    If ChangedNameTranfer(idtrasfe, Dialog.NewNameTransferTextBox.Text) Then
                        LoadListView()
                    End If
                End If
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ChangedNameTranfer(ByVal idTransfer As Integer, newNameTransfet As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Using db As New DataContext
                Dim dataTraansfer = (From t In db.ProductTransfer
                                     Where t.IdTransfer = idTransfer).FirstOrDefault()

                If Not IsNothing(dataTraansfer) Then
                    dataTraansfer.NameTranfer = newNameTransfet
                    db.SubmitChanges()
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class