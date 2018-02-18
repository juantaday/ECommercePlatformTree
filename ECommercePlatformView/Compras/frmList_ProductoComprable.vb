Imports CADsisVenta.DataSetComprasTableAdapters
Imports CADsisVenta

Public Class frmList_ProductoComprable
    Protected Friend NomComercial As String
    Protected Friend idPresent As Integer
    Protected Friend idProducto As Integer
    Protected Friend idProveedor As Integer
    Protected Friend idPresent_Master As Integer
    Private estaCargado As Boolean
    Private idPresent_childre As Integer
    Private Presentacion As String
    Private Nom_Comercial As String
    Protected Friend State As _state
    Private Sub frmList_ProductoComprable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idPresent_Master = 0
        NomComercial = String.Empty
        If IsNothing(idProveedor) Then
            idProveedor = 0
        End If
    End Sub
    Sub Carga_listProductAll(LikeNom_Comercial As String)
        If IsNothing(LikeNom_Comercial) Then
            Exit Sub
        End If
        Dim dtg As New System.Windows.Forms.DataGridView
        InitializeGrid(dtg)
        Try
            clearFields()

            estaCargado = False
            Dim ds As New DataSetCompras
            Dim tap As New ProductListComprableTableAdapter
            'Dim tapDetal As New ProductListComprableDetailTableAdapter
            Dim dt As New DataTable
            dt = tap.GetDataByNom_Comercial(LikeNom_Comercial)

            PanelView.Controls.Add(dtg)



            dtg.DataSource = dt


            ' dtg.setParentSource(ds.ProductListComprable.TableName, "idProducto")
            ' dtg.childView.Add(ds.ProductListComprableDetail.TableName, "Presentaciones..")

            dtg.Columns(dtg.Columns("idProducto").Index).Visible = False
            dtg.Columns(dtg.Columns("idPresentacion").Index).Visible = False  'Cant_Present
            dtg.Columns(dtg.Columns("Cant_Present").Index).Visible = False
            dtg.Columns(dtg.Columns("precioCompra").Index).Visible = False


            dtg.Columns(dtg.Columns("codProducto").Index).HeaderText = "Codido producto"
            dtg.Columns(dtg.Columns("codProducto").Index).Width = 100

            dtg.Columns(dtg.Columns("Nom_Comercial").Index).HeaderText = "Producto"
            dtg.Columns(dtg.Columns("Nom_Comercial").Index).Width = 250

            dtg.Columns(dtg.Columns("Fech_UltimaCompra").Index).HeaderText = "Última fecha compra"
            dtg.Columns(dtg.Columns("Fech_UltimaCompra").Index).Width = 120
            'estilo de datagirview
            applyGridTheme(dtg)
            dtg.ColumnHeadersHeight = 50

            AddHandler dtg.RowStateChanged, AddressOf dtg_RowStateChanged
            AddHandler dtg.CellClick, AddressOf dtg_CellClick
            AddHandler dtg.KeyDown, AddressOf dtg_KeyDown

            AddHandler dtg.RowHeaderMouseClick, AddressOf dtg_RowHeaderMouseClick
            AddHandler dtg.RowPostPaint, AddressOf dtg_RowPostPaint
            AddHandler dtg.Scroll, AddressOf dtg_Scroll

            'For i = 0 To dtg.RowCount - 1
            '    totalDeuda += dtg.Rows(i).Cells(dtg.Columns("Total").Index).Value
            'Next
            ' TotalLabel.Text = "Total => $ " & FormatNumber(totalDeuda, 2)
            childView = New DetailList With {.Height = rowExpandedDivider - rowDividerMargin * 2, .Visible = False}
            dtg.Controls.Add(childView)
            childView.Add()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            estaCargado = True
            dtg.Dock = DockStyle.Fill
            If dtg.RowCount > 0 Then
                dtg.Focus()
            End If
        End Try
    End Sub
    Private Sub dtg_Scroll(sender As Object, e As ScrollEventArgs)
        If Not rowCurrent.Count = 0 Then
            collapseRow = True
            sender.ClearSelection()
            sender.Rows(rowCurrent(0)).Selected = True
        End If
    End Sub

    Private Sub dtg_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        'set childview control
        Try
            Dim rect = New Rectangle(e.RowBounds.X + ((rowDefaultHeight - 16) / 2), e.RowBounds.Y + ((rowDefaultHeight - 16) / 2), 16, 16)
            Dim dt As New DataTable
            If collapseRow Then
                If rowCurrent.Contains(e.RowIndex) Then
                    sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)

                    Dim tapt As New ProductListComprableDetailTableAdapter
                    dt = tapt.GetData(idProducto, idPresent_Master)
                    If IsNothing(dt) Then
                        Return
                    ElseIf dt.Rows.Count = 0 Then
                        Return
                    End If

                    childView.setDataSource(dt, "Mas presenatciones de: " + Nom_Comercial)

                    childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                    childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                    childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10

                    Dim dtg_childer As New System.Windows.Forms.DataGridView
                    dtg_childer = childView.newGrid
                    dtg_childer.Columns(dtg_childer.Columns("idProducto").Index).Visible = False
                    dtg_childer.Columns(dtg_childer.Columns("idPresentacion").Index).Visible = False
                    AddHandler dtg_childer.RowStateChanged, AddressOf dtgChildren_RowStateChanged
                    AddHandler dtg_childer.CellClick, AddressOf dtgChildren_CellClick

                    childView.Visible = True
                Else
                    idPresent_childre = 0
                    childView.Visible = False
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
                End If
                collapseRow = False
            Else
                If rowCurrent.Contains(e.RowIndex) Then
                    sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                    childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                    childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                    childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                    childView.Visible = True
                Else
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
                End If
            End If
            rowPostPaint_HeaderCount(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub dtg_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim rect As Rectangle = New Rectangle((rowDefaultHeight - 16) / 2, (rowDefaultHeight - 16) / 2, 16, 16)
        If rect.Contains(e.Location) Then
            If rowCurrent.Contains(e.RowIndex) Then
                rowCurrent.Clear()
                sender.Rows(e.RowIndex).Height = rowDefaultHeight
                sender.Rows(e.RowIndex).DividerHeight = rowDefaultDivider
            Else
                If Not rowCurrent.Count = 0 Then
                    Dim eRow = rowCurrent(0)
                    rowCurrent.Clear()
                    sender.Rows(eRow).Height = rowDefaultHeight
                    sender.Rows(eRow).DividerHeight = rowDefaultDivider
                    sender.ClearSelection()
                    collapseRow = True
                    sender.Rows(eRow).Selected = True
                End If
                rowCurrent.Add(e.RowIndex)
                sender.Rows(e.RowIndex).Height = rowExpandedHeight
                sender.Rows(e.RowIndex).DividerHeight = rowExpandedDivider
            End If
            sender.ClearSelection()
            collapseRow = True
            sender.Rows(e.RowIndex).Selected = True
        Else
            collapseRow = False
        End If
    End Sub
    Private Sub dtg_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            AcepButton.PerformClick()
        End If
    End Sub

    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        'btnok.Enabled = False
        ''AddMenuFlowLayoutPane.Enabled = False
        'If State = state_.Admin Then
        '    AddMenuFlowLayoutPane.Enabled = True
        ''End If
        'MenuAdminFlowLayout.Enabled = False
        idPresent_childre = 0
        AcceptButton = Nothing
        If e.Row.Selected And estaCargado Then
            If sender.SelectedRows.Count = 1 Then
                idProducto = sender.SelectedCells.item(sender.columns("idProducto").index).Value
                idPresent_Master = sender.SelectedCells.item(sender.columns("idPresentacion").index).Value
                Nom_Comercial = sender.SelectedCells.item(sender.columns("Nom_comercial").index).Value
                Presentacion = sender.SelectedCells.item(sender.columns("Presentacion").index).Value
                AcceptButton = AcepButton
            End If
        End If
    End Sub
    Private Sub dtgChildren_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs)
        AcceptButton = Nothing
        If e.Row.Selected And estaCargado Then
            If sender.SelectedRows.Count = 1 Then
                idProducto = sender.SelectedCells.item(sender.columns("idProducto").index).Value
                idPresent_childre = sender.SelectedCells.item(sender.columns("idPresentacion").index).Value
                Presentacion = sender.SelectedCells.item(sender.columns("Presentacion").index).Value
                AcceptButton = AcepButton
            End If
        End If
    End Sub


    Private Sub dtg_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        AcceptButton = Nothing
        idPresent_childre = 0
        If estaCargado Then
            If sender.SelectedRows.Count = 1 Then
                idProducto = sender.SelectedCells.item(sender.columns("idProducto").index).Value
                idPresent_Master = sender.SelectedCells.item(sender.columns("idPresentacion").index).Value
                Nom_Comercial = sender.SelectedCells.item(sender.columns("Nom_comercial").index).Value
                Presentacion = sender.SelectedCells.item(sender.columns("Presentacion").index).Value
                AcceptButton = AcepButton
            End If
        End If
    End Sub
    Private Sub dtgChildren_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        AcceptButton = Nothing
        If estaCargado Then
            If sender.SelectedRows.Count = 1 Then
                idProducto = sender.SelectedCells.item(sender.columns("idProducto").index).Value
                idPresent_childre = sender.SelectedCells.item(sender.columns("idPresentacion").index).Value
                Presentacion = sender.SelectedCells.item(sender.columns("Presentacion").index).Value
                AcceptButton = AcepButton
            End If
        End If
    End Sub
    Sub clearFields()
        PanelView.Controls.Clear()
        Refresh()
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If FindTextBox.TextLength > 2 Then
            Dim ultimo_text As String = String.Empty
            sql = String.Empty
            For Each texto In FindTextBox.Text
                If Not ultimo_text.ToString.Equals("%") Then
                    If String.IsNullOrWhiteSpace(texto) Then
                        texto = "%"
                        sql = sql & texto
                    Else
                        sql = sql & texto
                    End If
                End If
                ultimo_text = texto
            Next
            Carga_listProductAll("%" & sql & "%")
        Else
            MsgBox("Pocos parámetros para buscar", MsgBoxStyle.Information, "Aviso")
            FindTextBox.Focus()
        End If
    End Sub

    Private Sub AcepButton_Click(sender As Object, e As EventArgs) Handles AcepButton.Click
        Try
            sql = idPresent_childre
            Dim result As Boolean = False
            Select Case State
                Case _state.Admin
                    result = Agrega_ToList()
                Case _state.Select_
                    result = Select_ToList()
            End Select
            If result Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Select_ToList() As Boolean
        Try
            If idPresent_Master = 0 Then
                Return False
            End If
            'comrpbamos si seleccione uno de lo hijos
            If idPresent_childre > 0 Then
                idPresent = idPresent_childre
            Else
                idPresent = idPresent_Master
            End If
            NomComercial = Nom_Comercial + " [" + Presentacion + "]"
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function

    Private Function Agrega_ToList()
        Try
            If Not (idProveedor > 0 And idPresent_Master > 0) Then
                Return False
            End If
            'comprobamos si ya esta registrado
            If ClsCompras.Scalar_idProdcutByProvider(idPresent_Master, idProveedor) > 0 Then
                Return True
            End If
            'instacio la tabla de prodcutoProveedor para agregar
            Dim data As New ProductoProveedorTableAdapter
            If (data.Insert(idPresent_Master, idProveedor, 0, Date.Now, String.Empty)) > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Try
            Using AddProductos As New MDI_AddProductos(stateOperation.Insert, 0, idProveedor)
                With AddProductos
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        sql = .Nom_Comerial
                        Carga_listProductAll(.Nom_Comerial)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        AcceptButton = Nothing
        If FindTextBox.TextLength > 2 Then
            AcceptButton = FindButton
        End If
    End Sub
    Private Sub InitializeGrid(sender As Object)

        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.RowHeaderIconList = New System.Windows.Forms.ImageList(Me.components)
        'CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.SuspendLayout()
        '
        'RowHeaderIconList
        '
        Me.RowHeaderIconList.ImageStream = CType(resources.GetObject("RowHeaderIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RowHeaderIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.RowHeaderIconList.Images.SetKeyName(0, "expand.png")
        Me.RowHeaderIconList.Images.SetKeyName(1, "collapse.png")
        'sender.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '
        'MasterControl
        '
        ' CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend rowCurrent As New List(Of Integer)
    Friend rowDefaultHeight = 22
    Friend rowExpandedHeight = 250
    Friend rowDefaultDivider = 0
    Friend rowExpandedDivider = 300 - 22
    Friend rowDividerMargin = 5
    Friend collapseRow As Boolean
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Friend childView As New DetailList
End Class