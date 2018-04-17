Imports System.IO
Imports System.Windows.Forms.VisualStyles
Imports CADsisVenta.DataSetComprasTableAdapters
Imports CADsisVenta.DataSetStockTableAdapters

Public Class frmInventoriesExplorer
    Protected Friend idProducto As Integer
    Private estaCargado As Boolean
    Private idPresent_childre As Integer
    Private idBodega As Integer
    Private idCategoria As Integer
    Private idSubCategoria As Integer
    Private NomBodega As String
    Private mycolor As Color
    Private Sub frmStocProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (IsNothing(Me.MdiParent)) Then
            Carga_StockBodegas()
        ElseIf idProducto > 0 Then
            LoadProductSelect(idProducto)
        End If
        mycolor = MenuStrip1.BackColor
    End Sub

    Private Sub Carga_StockBodegas()
        Try
            Me.PanelView.Controls.Clear()
            Dim dat As New prcGetStocBodegasTableAdapter
            Dim dt As DataTable = dat.GetData()

            If dt.Rows.Count = 0 Then
                PanelView.Controls.Add(New System.Windows.Forms.Label _
                                  With {.Text = "No hay información",
                                  .ForeColor = Color.Red,
                                  .Dock = DockStyle.Top
                                   })
                Return
            Else

                Dim dtg As New System.Windows.Forms.DataGridView _
                       With {.Dock = DockStyle.Fill,
                       .Name = "Bodegas",
                       .DataSource = dt}
                PanelView.Controls.Add(dtg)
                clm = dtg.Columns("Nom_Bodega")
                clm.HeaderText = "Almacén o  bodega"

                clm = dtg.Columns("Articulos")
                clm.DefaultCellStyle = myStileNumber
                clm.HeaderText = "Artículos"

                clm = dtg.Columns("Unidades")
                clm.DefaultCellStyle = myStileDecimal

                clm = dtg.Columns("UltMovi")
                clm.HeaderText = "Ultimo fecha movimiento"

                clm = dtg.Columns("USDmercaderia")
                clm.HeaderText = "Total en Mercadería" 'UltMovi
                clm.DefaultCellStyle = myStileMoney
                Dim total As Double = 0
                For i = 0 To dtg.RowCount - 1
                    total += dtg.Rows(i).Cells(dtg.Columns("USDmercaderia").Index).Value
                Next

                Me.TotalLabel.Text = String.Format("Total en general: {0}", total.ToString("C2"))
                WithEventsGridView(dtg)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub

    Private Sub WithEventsGridView(dtg As DataGridView)
        Try
            dtg.Columns(0).Visible = False
            'estilo de datagirview
            applyGridTheme(dtg)
            dtg.ColumnHeadersHeight = 50
            dtg.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells
            Dim columnSave As New DataGridViewImageButtonSaveColumn()
            columnSave.Name = "SaveButton"
            columnSave.HeaderText = ""
            dtg.Columns.Add(columnSave)

            AddHandler dtg.CellClick, AddressOf dtg_CellClick
            AddHandler dtg.CellMouseDown, AddressOf dtg_MouseDown
            AddHandler dtg.CellEnter, AddressOf dtg_CellEnter
            AddHandler dtg.CurrentCellDirtyStateChanged, AddressOf dtg_CurrentCellDirtyStateChanged
            AddHandler dtg.CellValueChanged, AddressOf dtg_CellValueChanged
            AddHandler dtg.CellMouseUp, AddressOf stg_cellMouseUp
            AddHandler dtg.RowEnter, AddressOf dtg_RowEnter
            AddHandler dtg.CellLeave, AddressOf dtg_CellLeave
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtg_CellLeave(sender As Object, e As DataGridViewCellEventArgs)
        SetGridButtonState(sender, e.RowIndex, e.ColumnIndex, PushButtonState.Normal)
    End Sub

    Private Sub dtg_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        ' SetGridButtonState(sender, e.RowIndex, DirectCast(sender, DataGridView).Columns("SaveButton").Index, PushButtonState.Hot)
    End Sub

    Private Sub stg_cellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        SetGridButtonState(sender, e.RowIndex, e.ColumnIndex, PushButtonState.Normal)
    End Sub

    Private Sub dtg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

        ' If the "Text" column is changed...
        If sender.Columns(e.ColumnIndex).Name = "Text" Then
            ' If the "Text" column value is null...
            If sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is Nothing Then
                ' Disable the buttons
                DirectCast(sender.Rows(e.RowIndex).Cells("SaveButton"), DataGridViewImageButtonSaveCell).Enabled = False
                DirectCast(sender.Rows(e.RowIndex).Cells("SaveButton"), DataGridViewImageButtonSaveCell).ButtonState = PushButtonState.Disabled

                DirectCast(sender.Rows(e.RowIndex).Cells("PrintButton"), DataGridViewImageButtonCell).Enabled = False
                DirectCast(sender.Rows(e.RowIndex).Cells("PrintButton"), DataGridViewImageButtonCell).ButtonState = PushButtonState.Disabled
            Else
                ' Enable the buttons
                DirectCast(sender.Rows(e.RowIndex).Cells("SaveButton"), DataGridViewImageButtonSaveCell).Enabled = True
                DirectCast(sender.Rows(e.RowIndex).Cells("SaveButton"), DataGridViewImageButtonSaveCell).ButtonState = PushButtonState.Normal

                DirectCast(sender.Rows(e.RowIndex).Cells("PrintButton"), DataGridViewImageButtonCell).Enabled = True
                DirectCast(sender.Rows(e.RowIndex).Cells("PrintButton"), DataGridViewImageButtonCell).ButtonState = PushButtonState.Normal
            End If

            sender.Invalidate()
        End If



    End Sub

    Private Sub dtg_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If sender.IsCurrentCellDirty Then
            sender.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtg_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
        SetGridButtonState(sender, e.RowIndex, e.ColumnIndex, PushButtonState.Hot)
    End Sub

    Private Sub dtg_MouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
        SetGridButtonState(sender, e.RowIndex, e.ColumnIndex, PushButtonState.Pressed)
    End Sub

    Private Sub SetGridButtonState(dgv As DataGridView, rowIndex As Integer, columnIndex As Integer, pushButtonState As PushButtonState)
        If (rowIndex > -1) AndAlso (columnIndex > -1) Then
            If (dgv.Columns(columnIndex).[GetType]().Equals(GetType(DataGridViewImageButtonSaveColumn))) Then
                Dim buttonCell As DataGridViewImageButtonCell = DirectCast(dgv.Rows(rowIndex).Cells(columnIndex), DataGridViewImageButtonCell)
                buttonCell.ButtonState = pushButtonState
            End If
        End If
    End Sub

    Private Sub dtg_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (e.RowIndex > -1) AndAlso (e.ColumnIndex > -1) Then
                If (sender.Columns(e.ColumnIndex).[GetType]().Equals(GetType(DataGridViewImageButtonSaveColumn))) Then
                    Dim buttonCell As DataGridViewImageButtonCell = DirectCast(sender.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewImageButtonCell)
                    Dim total As Double = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("USDmercaderia").Index).Value
                    Dim id As Integer = 0
                    Dim description As String = String.Empty
                    Select Case sender.name
                        Case "Bodegas"
                            id = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("IdBodega").Index).Value
                            description = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("Nom_Bodega").Index).Value
                            Me.LodCategorias(id, description, total)
                        Case "Categorias"
                            id = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("idCategoria").Index).Value
                            description = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("Nom_Categoria").Index).Value
                            Me.LodSubCategorias(id, description, total)
                        Case "SubCategorias"
                            id = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("idSubCategoria").Index).Value
                            description = DirectCast(sender, DataGridView).SelectedCells.Item(sender.Columns("Nom_SubCategoria").Index).Value
                            Me.LodSubProductos(id, description, total)
                        Case "Productos"
                    End Select
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub LodSubProductos(id As Integer, description As String, total As Double)
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not IsNumeric(id) Then
                Return
            End If
            Me.idSubCategoria = id

            Dim dat As New prcGetStockProductosTableAdapter
            Dim dt As DataTable = dat.GetData(Me.idBodega, Me.idSubCategoria)

            If dt.Rows.Count = 0 Then
                PanelView.Controls.Add(New System.Windows.Forms.Label _
                                  With {.Text = "No hay información",
                                  .ForeColor = Color.Red,
                                  .Dock = DockStyle.Top,
                                  .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                                   })
                Return
            Else
                Dim dtg As New System.Windows.Forms.DataGridView _
                           With {.Dock = DockStyle.Fill,
                           .Name = "Productos",
                           .DataSource = dt}

                Dim linSubCategoria As New LinkLabel _
                With {.Text = String.Format("<<= {0}: {1}", description, total.ToString("C2")),
                      .Name = "Productos",
                     .Dock = DockStyle.Top,
                     .Tag = id,
                     .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))}



                Dim linBodega As New LinkLabel
                Dim linCategoria As New LinkLabel

                For Each control In Me.PanelView.Controls
                    If TypeOf (control) Is LinkLabel Then
                        If control.Name.ToString.Equals("Categorias") Then
                            linBodega = control
                        ElseIf control.Name.ToString.Equals("SubCategorias") Then
                            linCategoria = control
                        End If
                    End If
                Next
                Me.PanelView.Controls.Clear()

                PanelView.Controls.Add(dtg)
                PanelView.Controls.Add(linSubCategoria)
                PanelView.Controls.Add(linCategoria)
                PanelView.Controls.Add(linBodega)

                clm = dtg.Columns("Nom_Comercial")
                clm.HeaderText = "Producto"

                clm = dtg.Columns("UltMovi")
                clm.HeaderText = "Ultimo movimiento"

                clm = dtg.Columns("Unidades")
                clm.DefaultCellStyle = myStileDecimal

                clm = dtg.Columns("USDmercaderia")
                clm.HeaderText = "Total en mercadería"
                clm.DefaultCellStyle = myStileMoney


                WithEventsGridView(dtg)
                AddHandler linSubCategoria.Click, AddressOf LinkLabel_Label
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LodSubCategorias(id As Integer, description As String, total As Double)
        Try

            If Not IsNumeric(id) Then
                Return
            End If
            Me.idCategoria = id


            Dim esxist As Boolean = False
            For Each control As System.Windows.Forms.Control In Me.PanelView.Controls
                If TypeOf (control) Is LinkLabel Then
                    If control.Name.Equals("SubCategorias") Then
                        esxist = True
                    End If
                End If
            Next

            Dim linkSubCateorias As New LinkLabel
            If Not esxist Then
                Dim link As New LinkLabel _
                With {.Text = String.Format("<<= {0}: {1}", description, total.ToString("C2")),
                      .Name = "SubCategorias",
                     .Dock = DockStyle.Top,
                     .Tag = id,
                     .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))}
                linkSubCateorias = link
            End If
            'load de data
            Dim dat As New prcGetStocSubCategoriaTableAdapter
            Dim dt As DataTable = dat.GetData(Me.idBodega, id)

            If dt.Rows.Count = 0 Then
                PanelView.Controls.Add(New System.Windows.Forms.Label _
                                  With {.Text = "No hay información",
                                  .ForeColor = Color.Red,
                                  .Dock = DockStyle.Top,
                                  .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                                   })
                Return
            Else
                Dim dtg As New System.Windows.Forms.DataGridView _
                           With {.Dock = DockStyle.Fill,
                           .Name = "SubCategorias",
                           .DataSource = dt}

                Dim linBodega As New LinkLabel
                Dim linCategoriaBodega As New LinkLabel

                For Each control As System.Windows.Forms.Control In Me.PanelView.Controls
                    If TypeOf (control) Is LinkLabel Then
                        If control.Name.Equals("Categorias") Then
                            linBodega = control
                        ElseIf control.Name.Equals("SubCategorias") Then
                            linCategoriaBodega = control
                        End If
                    End If
                Next
                If Not esxist Then
                    linCategoriaBodega = linkSubCateorias
                    AddHandler linCategoriaBodega.Click, AddressOf LinkLabel_Label
                End If

                Me.PanelView.Controls.Clear()

                PanelView.Controls.Add(dtg)
                PanelView.Controls.Add(linCategoriaBodega)
                PanelView.Controls.Add(linBodega)

                clm = dtg.Columns("Nom_SubCategoria")
                clm.HeaderText = "Sub robro"

                clm = dtg.Columns("Articulos")
                clm.DefaultCellStyle = myStileNumber
                clm.HeaderText = "Artículos"

                clm = dtg.Columns("UltMovi")
                clm.HeaderText = "Ultimo movimiento"

                clm = dtg.Columns("Unidades")
                clm.DefaultCellStyle = myStileDecimal

                clm = dtg.Columns("USDmercaderia")
                clm.HeaderText = "Total en Mercadería"
                clm.DefaultCellStyle = myStileMoney


                WithEventsGridView(dtg)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LodCategorias(value1 As Object, value2 As Object, total As Double)
        Try
            Dim idBodega As Integer = 0
            If Not IsNumeric(value1.ToString) Then
                Return
            End If
            idBodega = value1
            Me.idBodega = idBodega

            For Each control As System.Windows.Forms.Control In PanelView.Controls
                If TypeOf (control) Is DataGridView Then
                    PanelView.Controls.Remove(control)
                ElseIf TypeOf (control) Is LinkLabel Then
                    If Not control.Name.ToString.Equals("Categorias") Then
                        PanelView.Controls.Remove(control)
                    End If
                End If
            Next
            For Each control As System.Windows.Forms.Control In PanelView.Controls
                If TypeOf (control) Is DataGridView Then
                    PanelView.Controls.Remove(control)
                ElseIf TypeOf (control) Is LinkLabel Then
                    If Not control.Name.ToString.Equals("Categorias") Then
                        PanelView.Controls.Remove(control)
                    End If
                End If
            Next

            'buscar si ya esta cargado el control
            Dim esxist As Boolean = False
            For Each control As System.Windows.Forms.Control In Me.PanelView.Controls
                If TypeOf (control) Is LinkLabel Then
                    If control.Name.Equals("Categorias") Then
                        esxist = True
                    End If
                End If
            Next
            Dim linkLabe As New LinkLabel
            If Not esxist Then
                Dim link As New LinkLabel _
                With {.Text = String.Format("<<= {0}: {1}", value2.ToString, total.ToString("C2")),
                      .Name = "Categorias",
                     .Dock = DockStyle.Top,
                     .Tag = idBodega,
                     .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))}
                linkLabe = link
            End If

            'load de data
            Dim dat As New prcGetStocCategoriaTableAdapter
            Dim dt As DataTable = dat.GetData(idBodega)

            If dt.Rows.Count = 0 Then
                PanelView.Controls.Add(New System.Windows.Forms.Label _
                                  With {.Text = "No hay información",
                                  .ForeColor = Color.Red,
                                  .Dock = DockStyle.Top,
                                  .Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                                   })
                Return
            Else
                Dim dtg As New System.Windows.Forms.DataGridView _
                      With {.Dock = DockStyle.Fill,
                      .Name = "Categorias",
                      .DataSource = dt}

                If Not esxist Then
                    PanelView.Controls.Add(dtg)
                    PanelView.Controls.Add(linkLabe)
                    AddHandler linkLabe.Click, AddressOf LinkLabel_Label
                Else
                    Dim linBaodega As New LinkLabel
                    linBaodega = Me.PanelView.Controls(0)
                    PanelView.Controls.Clear()
                    PanelView.Controls.Add(dtg)
                    PanelView.Controls.Add(linBaodega)
                    AddHandler linkLabe.Click, AddressOf LinkLabel_Label
                End If
                clm = dtg.Columns("Nom_Categoria")
                clm.HeaderText = "Rubro"

                clm = dtg.Columns("Articulos")
                clm.DefaultCellStyle = myStileNumber
                clm.HeaderText = "Artículos"

                clm = dtg.Columns("Unidades")
                clm.DefaultCellStyle = myStileDecimal

                clm = dtg.Columns("USDmercaderia")
                clm.HeaderText = "Total en Mercadería"
                clm.DefaultCellStyle = myStileMoney

                clm = dtg.Columns("UltMovi")
                clm.HeaderText = "Ultimo movimiento"

                WithEventsGridView(dtg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LinkLabel_Label(sender As Object, e As EventArgs)
        Try
            Select Case sender.name
                Case "Categorias"
                    Carga_StockBodegas()
                Case "SubCategorias"
                    Me.LodCategorias(Me.idBodega, DirectCast(sender, LinkLabel).Text, 0)
                Case "Productos"
                    Me.LodSubCategorias(Me.idCategoria, DirectCast(sender, LinkLabel).Text, 0)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindClienteButton_Click(sender As Object, e As EventArgs) Handles FindClienteButton.Click
        Try
            Me.idProducto = 0
            Using listProvider As New frmList_ProductoComprable()
                With listProvider
                    .StartPosition = FormStartPosition.CenterParent
                    .State = _state.Select_
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Carga_Combox()
                        If .idPresent > 0 Then
                            Me.idProducto = .idProducto
                            ListProductComboBox.Items.Add(.NomComercial)
                            ListProductComboBox.SelectedIndex = 1
                            FindButton.PerformClick()
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_Combox()
        ListProductComboBox.Items.Clear()
        ListProductComboBox.Items.Add("Todos los productos")
        ListProductComboBox.SelectedIndex = 0
    End Sub
    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        If ListProductComboBox.SelectedIndex > 0 Then
            Me.LoadProductSelect(Me.idProducto)
        Else
            Carga_StockBodegas()
        End If
    End Sub
    Private Sub LoadProductSelect(selectedValue As Integer)
        Try
            Me.PanelView.Controls.Clear()
            Dim dat As New prcGetStockSelectProductoTableAdapter
            Dim dt As DataTable = dat.GetData(selectedValue)

            If dt.Rows.Count = 0 Then
                PanelView.Controls.Add(New System.Windows.Forms.Label _
                                  With {.Text = "No hay información",
                                  .ForeColor = Color.Red,
                                  .Dock = DockStyle.Top
                                   })
                Return
            Else

                Dim dtg As New System.Windows.Forms.DataGridView _
                       With {.Dock = DockStyle.Fill,
                       .Name = "SelectProduct",
                       .DataSource = dt}
                PanelView.Controls.Add(dtg)
                clm = dtg.Columns("Nom_Bodega")
                clm.HeaderText = "Almacén o  bodega"

                clm = dtg.Columns("Nom_Comercial")
                clm.HeaderText = "Producto"


                clm = dtg.Columns("getCompra")
                clm.HeaderText = "Presentación de compra"

                clm = dtg.Columns("getVenta")
                clm.HeaderText = "Presentación de venta"

                clm = dtg.Columns("stock")
                clm.HeaderText = "Stock"
                clm.DefaultCellStyle = myStileDecimal

                clm = dtg.Columns("Enbodega")
                clm.HeaderText = "Presentación en bodega"

                clm = dtg.Columns("pvpUND")
                clm.HeaderText = "Precio promedio compra"
                clm.DefaultCellStyle = myStileMoneyWith4

                clm = dtg.Columns("ultiMovi")
                clm.HeaderText = "Ultimo movimiento"


                clm = dtg.Columns("USDmercaderia")
                clm.HeaderText = "Total en Mercadería"
                clm.DefaultCellStyle = myStileMoney
                Dim total As Double = 0
                For i = 0 To dtg.RowCount - 1
                    total += dtg.Rows(i).Cells(dtg.Columns("USDmercaderia").Index).Value
                Next

                Me.TotalLabel.Text = String.Format("Total en general: {0}", total.ToString("C2"))
                WithEventsGridView(dtg)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub NewListToolStrip_Click(sender As Object, e As EventArgs) Handles NewListToolStrip.Click
        Try
            Dim myInventories As New frm_ListInventories(stateOperation.Insert, 0)
            With myInventories
                .WindowState = FormWindowState.Maximized
                .Show()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UpdateListToolStrip_Click(sender As Object, e As EventArgs) Handles UpdateListToolStrip.Click
        Try



            Using list As New frmListInventoriesUpdate
                With list
                    .ShowDialog()
                End With
            End Using


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub UpdateOneProductToolStrip_Click(sender As Object, e As EventArgs) Handles UpdateOneProductToolStrip.Click
        Try
            Dim idproducto As Integer = 0
            Using listProvider As New frmList_ProductoComprable()
                With listProvider
                    .StartPosition = FormStartPosition.CenterParent
                    .State = _state.Select_
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        idproducto = .idProducto
                    End If
                End With
            End Using

            If idproducto = 0 Then
                Return
            End If

            Using frmUpdateOne As New frmUpdateInventotyOneProduct(idproducto)
                With frmUpdateOne
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class

Public Class DataGridViewImageButtonSaveColumn
    Inherits DataGridViewButtonColumn
    Public Sub New()
        Me.CellTemplate = New DataGridViewImageButtonSaveCell()
        Me.Width = 22
        Me.Resizable = DataGridViewTriState.[False]
    End Sub
End Class
Public Class DataGridViewImageButtonSaveCell
    Inherits DataGridViewImageButtonCell
    Public Overrides Sub LoadImages()
        InitializeGrid()
        ' The normal Save image
        Dim normalArray As Byte() = New Byte() {&H42, &H4D, &H36, &H3, &H0, &H0,
            &H0, &H0, &H0, &H0, &H36, &H0,
            &H0, &H0, &H28, &H0, &H0, &H0,
            &H10, &H0, &H0, &H0, &H10, &H0,
            &H0, &H0, &H1, &H0, &H18, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &H0, &H0, &H12, &HB, &H0, &H0,
            &H12, &HB, &H0, &H0, &H0, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &HFF, &H0, &HFF, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HFF, &H0, &HFF,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H90, &H63,
            &HB1, &HB4, &HB3, &H68, &H3F, &HD,
            &H68, &H3F, &HD, &HFC, &HFE, &HFF,
            &HEB, &HE9, &HED, &HD2, &HCB, &HCD,
            &HB1, &HB4, &HB3, &H68, &H3F, &HD,
            &H8B, &H67, &H9, &HB4, &H90, &H63,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H90, &H63,
            &HB0, &HB2, &HB0, &H68, &H3F, &HD,
            &H86, &H5A, &H4, &HFC, &HFE, &HFF,
            &HFC, &HFE, &HFF, &HEB, &HE9, &HED,
            &HD2, &HCB, &HCD, &H68, &H3F, &HD,
            &H8B, &H67, &H9, &HB4, &H90, &H63,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H90, &H63,
            &HBA, &HBC, &HBA, &H68, &H3F, &HD,
            &H86, &H56, &H7, &HFC, &HFE, &HFF,
            &HF4, &HF6, &HFA, &HFC, &HFC, &HFC,
            &HEB, &HE9, &HED, &H68, &H3F, &HD,
            &H8B, &H67, &H9, &HB4, &H90, &H63,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H90, &H63,
            &HD2, &HD6, &HD6, &H68, &H3F, &HD,
            &H68, &H3F, &HD, &HFC, &HFE, &HFF,
            &HF4, &HF6, &HFA, &HF4, &HF6, &HFA,
            &HFF, &HFF, &HFF, &H68, &H3F, &HD,
            &H8B, &H67, &H9, &HB4, &H90, &H63,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &H9D, &H53, &H1C,
            &HB4, &H90, &H63, &HB4, &H90, &H63,
            &HB4, &H90, &H63, &HB4, &H90, &H63,
            &HB4, &H90, &H63, &HB4, &H90, &H63,
            &HB4, &H90, &H63, &HB4, &H90, &H63,
            &HB4, &H90, &H63, &H9D, &H53, &H1C,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &HB4, &H60, &H21,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HBD, &H7B, &H49, &HD6, &HCC, &HC0,
            &HD6, &HCC, &HC0, &HD6, &HCC, &HC0,
            &HD6, &HCC, &HC0, &HD6, &HCC, &HC0,
            &HD6, &HCC, &HC0, &HD6, &HCC, &HC0,
            &HD6, &HCC, &HC0, &HD6, &HCC, &HC0,
            &HD6, &HCC, &HC0, &HBD, &H7B, &H49,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HD6, &HCC, &HC0, &HE5, &HE8, &HEB,
            &HE7, &HE8, &HE8, &HEC, &HED, &HED,
            &HEF, &HF0, &HF0, &HF1, &HF2, &HF2,
            &HF2, &HF2, &HF3, &HF0, &HF1, &HF1,
            &HEE, &HEE, &HEF, &HE9, &HE9, &HEA,
            &HE4, &HE5, &HE6, &HD6, &HCC, &HC0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HD6, &HCC, &HC0, &HE8, &HEA, &HED,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HE8, &HE9, &HEA, &HD6, &HCC, &HC0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HD6, &HCC, &HC0, &HE8, &HEA, &HEC,
            &HEC, &HEC, &HEC, &HF0, &HF0, &HF0,
            &HF5, &HF5, &HF5, &HF7, &HF7, &HF7,
            &HF7, &HF7, &HF7, &HF6, &HF6, &HF6,
            &HF3, &HF3, &HF3, &HEE, &HEE, &HEE,
            &HE9, &HE9, &HEA, &HD6, &HCC, &HC0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HD6, &HCC, &HC0, &HEA, &HEC, &HEF,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HB6, &HB6, &HB7, &HB6, &HB6, &HB7,
            &HEA, &HEB, &HEC, &HD6, &HCC, &HC0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &HD6, &HCC, &HC0, &HE9, &HEA, &HEC,
            &HED, &HED, &HEC, &HF1, &HF1, &HF0,
            &HF5, &HF5, &HF3, &HF7, &HF7, &HF5,
            &HF8, &HF8, &HF6, &HF6, &HF6, &HF5,
            &HF3, &HF3, &HF2, &HEE, &HEE, &HED,
            &HE9, &HEA, &HE9, &HD6, &HCC, &HC0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &H2E, &H2F, &HA0, &H2E, &H2F, &HA0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HB4, &H60, &H21,
            &H2E, &H2F, &HA0, &H2F, &H32, &HBC,
            &H2F, &H32, &HBC, &H2F, &H32, &HBC,
            &H2F, &H32, &HBC, &H2F, &H32, &HBC,
            &H2F, &H32, &HBC, &H2F, &H32, &HBC,
            &H2F, &H32, &HBC, &H2F, &H32, &HBC,
            &H2F, &H32, &HBC, &H2E, &H2F, &HA0,
            &HB4, &H60, &H21, &H92, &H54, &H1F,
            &HFF, &H0, &HFF, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &H92, &H54, &H1F,
            &H92, &H54, &H1F, &HFF, &H0, &HFF}

        Dim msNormal As New MemoryStream(normalArray)
        _buttonImageNormal = Me.RowHeaderIconList.Images(rowHeaderIcons.expand)

        ' The disabled Save image
        Dim disabledArray As Byte() = New Byte() {&H42, &H4D, &H36, &H3, &H0, &H0,
            &H0, &H0, &H0, &H0, &H36, &H0,
            &H0, &H0, &H28, &H0, &H0, &H0,
            &H10, &H0, &H0, &H0, &H10, &H0,
            &H0, &H0, &H1, &H0, &H18, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &H0, &H0, &H12, &HB, &H0, &H0,
            &H12, &HB, &H0, &H0, &H0, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &HFF, &H0, &HFF, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HFF, &H0, &HFF,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HCF, &HCF, &HCF,
            &HE0, &HE0, &HE0, &HB1, &HB1, &HB1,
            &HB1, &HB1, &HB1, &HFF, &HFF, &HFF,
            &HF6, &HF6, &HF6, &HEA, &HEA, &HEA,
            &HE0, &HE0, &HE0, &HB1, &HB1, &HB1,
            &HBF, &HBF, &HBF, &HCF, &HCF, &HCF,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HCF, &HCF, &HCF,
            &HDF, &HDF, &HDF, &HB1, &HB1, &HB1,
            &HBB, &HBB, &HBB, &HFF, &HFF, &HFF,
            &HFF, &HFF, &HFF, &HF6, &HF6, &HF6,
            &HEA, &HEA, &HEA, &HB1, &HB1, &HB1,
            &HBF, &HBF, &HBF, &HCF, &HCF, &HCF,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HCF, &HCF, &HCF,
            &HE3, &HE3, &HE3, &HB1, &HB1, &HB1,
            &HBA, &HBA, &HBA, &HFF, &HFF, &HFF,
            &HFC, &HFC, &HFC, &HFE, &HFE, &HFE,
            &HF6, &HF6, &HF6, &HB1, &HB1, &HB1,
            &HBF, &HBF, &HBF, &HCF, &HCF, &HCF,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HCF, &HCF, &HCF,
            &HEE, &HEE, &HEE, &HB1, &HB1, &HB1,
            &HB1, &HB1, &HB1, &HFF, &HFF, &HFF,
            &HFC, &HFC, &HFC, &HFC, &HFC, &HFC,
            &HFF, &HFF, &HFF, &HB1, &HB1, &HB1,
            &HBF, &HBF, &HBF, &HCF, &HCF, &HCF,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HCF, &HCF, &HCF, &HCF, &HCF, &HCF,
            &HCF, &HCF, &HCF, &HCF, &HCF, &HCF,
            &HCF, &HCF, &HCF, &HCF, &HCF, &HCF,
            &HCF, &HCF, &HCF, &HCF, &HCF, &HCF,
            &HCF, &HCF, &HCF, &HBD, &HBD, &HBD,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HC2, &HC2, &HC2,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HCA, &HCA, &HCA, &HE9, &HE9, &HE9,
            &HE9, &HE9, &HE9, &HE9, &HE9, &HE9,
            &HE9, &HE9, &HE9, &HE9, &HE9, &HE9,
            &HE9, &HE9, &HE9, &HE9, &HE9, &HE9,
            &HE9, &HE9, &HE9, &HE9, &HE9, &HE9,
            &HE9, &HE9, &HE9, &HCA, &HCA, &HCA,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HE9, &HE9, &HE9, &HF6, &HF6, &HF6,
            &HF6, &HF6, &HF6, &HF8, &HF8, &HF8,
            &HF9, &HF9, &HF9, &HFA, &HFA, &HFA,
            &HFA, &HFA, &HFA, &HF9, &HF9, &HF9,
            &HF8, &HF8, &HF8, &HF6, &HF6, &HF6,
            &HF4, &HF4, &HF4, &HE9, &HE9, &HE9,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HE9, &HE9, &HE9, &HF7, &HF7, &HF7,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HF6, &HF6, &HF6, &HE9, &HE9, &HE9,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HE9, &HE9, &HE9, &HF6, &HF6, &HF6,
            &HF7, &HF7, &HF7, &HF9, &HF9, &HF9,
            &HFB, &HFB, &HFB, &HFC, &HFC, &HFC,
            &HFC, &HFC, &HFC, &HFB, &HFB, &HFB,
            &HFA, &HFA, &HFA, &HF8, &HF8, &HF8,
            &HF6, &HF6, &HF6, &HE9, &HE9, &HE9,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HE9, &HE9, &HE9, &HF8, &HF8, &HF8,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HE1, &HE1, &HE1, &HE1, &HE1, &HE1,
            &HF7, &HF7, &HF7, &HE9, &HE9, &HE9,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HE9, &HE9, &HE9, &HF6, &HF6, &HF6,
            &HF8, &HF8, &HF8, &HF9, &HF9, &HF9,
            &HFB, &HFB, &HFB, &HFB, &HFB, &HFB,
            &HFC, &HFC, &HFC, &HFB, &HFB, &HFB,
            &HFA, &HFA, &HFA, &HF8, &HF8, &HF8,
            &HF6, &HF6, &HF6, &HE9, &HE9, &HE9,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC0, &HC0, &HC0, &HC0, &HC0, &HC0,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HC2, &HC2, &HC2,
            &HC0, &HC0, &HC0, &HC3, &HC3, &HC3,
            &HC3, &HC3, &HC3, &HC3, &HC3, &HC3,
            &HC3, &HC3, &HC3, &HC3, &HC3, &HC3,
            &HC3, &HC3, &HC3, &HC3, &HC3, &HC3,
            &HC3, &HC3, &HC3, &HC3, &HC3, &HC3,
            &HC3, &HC3, &HC3, &HC0, &HC0, &HC0,
            &HC2, &HC2, &HC2, &HBD, &HBD, &HBD,
            &HFF, &H0, &HFF, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HBD, &HBD, &HBD,
            &HBD, &HBD, &HBD, &HFF, &H0, &HFF}

        Dim msDisabled As New MemoryStream(disabledArray)
        _buttonImageDisabled = Me.RowHeaderIconList.Images(rowHeaderIcons.collapse)

        ' The hot Save image
        Dim hotArray As Byte() = New Byte() {&H42, &H4D, &H36, &H3, &H0, &H0,
            &H0, &H0, &H0, &H0, &H36, &H0,
            &H0, &H0, &H28, &H0, &H0, &H0,
            &H10, &H0, &H0, &H0, &H10, &H0,
            &H0, &H0, &H1, &H0, &H18, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &H0, &H0, &H12, &HB, &H0, &H0,
            &H12, &HB, &H0, &H0, &H0, &H0,
            &H0, &H0, &H0, &H0, &H0, &H0,
            &HFF, &H0, &HFF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HFF, &H0, &HFF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H77, &H48,
            &H9D, &HA0, &H9F, &H4D, &H28, &H5,
            &H4D, &H28, &H5, &HFB, &HFE, &HFF,
            &HE5, &HE2, &HE7, &HC5, &HBC, &HBF,
            &H9D, &HA0, &H9F, &H4D, &H28, &H5,
            &H72, &H4C, &H3, &HA0, &H77, &H48,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H77, &H48,
            &H9C, &H9E, &H9C, &H4D, &H28, &H5,
            &H6C, &H40, &H1, &HFB, &HFE, &HFF,
            &HFB, &HFE, &HFF, &HE5, &HE2, &HE7,
            &HC5, &HBC, &HBF, &H4D, &H28, &H5,
            &H72, &H4C, &H3, &HA0, &H77, &H48,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H77, &H48,
            &HA7, &HAA, &HA7, &H4D, &H28, &H5,
            &H6C, &H3C, &H2, &HFB, &HFE, &HFF,
            &HF0, &HF3, &HF8, &HFB, &HFB, &HFB,
            &HE5, &HE2, &HE7, &H4D, &H28, &H5,
            &H72, &H4C, &H3, &HA0, &H77, &H48,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H77, &H48,
            &HC5, &HCA, &HCA, &H4D, &H28, &H5,
            &H4D, &H28, &H5, &HFB, &HFE, &HFF,
            &HF0, &HF3, &HF8, &HF0, &HF3, &HF8,
            &HFF, &HFF, &HFF, &H4D, &H28, &H5,
            &H72, &H4C, &H3, &HA0, &H77, &H48,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &H86, &H39, &HD,
            &HA0, &H77, &H48, &HA0, &H77, &H48,
            &HA0, &H77, &H48, &HA0, &H77, &H48,
            &HA0, &H77, &H48, &HA0, &H77, &H48,
            &HA0, &H77, &H48, &HA0, &H77, &H48,
            &HA0, &H77, &H48, &H86, &H39, &HD,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &HA0, &H45, &H11,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HAB, &H60, &H30, &HCA, &HBD, &HAF,
            &HCA, &HBD, &HAF, &HCA, &HBD, &HAF,
            &HCA, &HBD, &HAF, &HCA, &HBD, &HAF,
            &HCA, &HBD, &HAF, &HCA, &HBD, &HAF,
            &HCA, &HBD, &HAF, &HCA, &HBD, &HAF,
            &HCA, &HBD, &HAF, &HAB, &H60, &H30,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HCA, &HBD, &HAF, &HDD, &HE1, &HE5,
            &HE0, &HE1, &HE1, &HE6, &HE7, &HE7,
            &HEA, &HEB, &HEB, &HED, &HEE, &HEE,
            &HEE, &HEE, &HEF, &HEB, &HED, &HED,
            &HE9, &HE9, &HEA, &HE2, &HE2, &HE3,
            &HDC, &HDD, &HDE, &HCA, &HBD, &HAF,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HCA, &HBD, &HAF, &HE1, &HE3, &HE7,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HE1, &HE2, &HE3, &HCA, &HBD, &HAF,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HCA, &HBD, &HAF, &HE1, &HE3, &HE6,
            &HE6, &HE6, &HE6, &HEB, &HEB, &HEB,
            &HF2, &HF2, &HF2, &HF4, &HF4, &HF4,
            &HF4, &HF4, &HF4, &HF3, &HF3, &HF3,
            &HEF, &HEF, &HEF, &HE9, &HE9, &HE9,
            &HE2, &HE2, &HE3, &HCA, &HBD, &HAF,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HCA, &HBD, &HAF, &HE3, &HE6, &HEA,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HA3, &HA3, &HA4, &HA3, &HA3, &HA4,
            &HE3, &HE5, &HE6, &HCA, &HBD, &HAF,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &HCA, &HBD, &HAF, &HE2, &HE3, &HE6,
            &HE7, &HE7, &HE6, &HED, &HED, &HEB,
            &HF2, &HF2, &HEF, &HF4, &HF4, &HF2,
            &HF6, &HF6, &HF3, &HF3, &HF3, &HF2,
            &HEF, &HEF, &HEE, &HE9, &HE9, &HE7,
            &HE2, &HE3, &HE2, &HCA, &HBD, &HAF,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &H1A, &H1B, &H89, &H1A, &H1B, &H89,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HA0, &H45, &H11,
            &H1A, &H1B, &H89, &H1B, &H1D, &HAA,
            &H1B, &H1D, &HAA, &H1B, &H1D, &HAA,
            &H1B, &H1D, &HAA, &H1B, &H1D, &HAA,
            &H1B, &H1D, &HAA, &H1B, &H1D, &HAA,
            &H1B, &H1D, &HAA, &H1B, &H1D, &HAA,
            &H1B, &H1D, &HAA, &H1A, &H1B, &H89,
            &HA0, &H45, &H11, &H79, &H3A, &HF,
            &HFF, &H0, &HFF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &H79, &H3A, &HF,
            &H79, &H3A, &HF, &HFF, &H0, &HFF}
        'hotArray
        Dim msHot As New MemoryStream(hotArray)
        _buttonImageHot = Me.RowHeaderIconList.Images(rowHeaderIcons.collapse) 'Image.FromStream(msHot)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Private Sub InitializeGrid()

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
    End Sub

End Class
Public MustInherit Class DataGridViewImageButtonCell
    Inherits DataGridViewButtonCell
    Private _enabled As Boolean
    ' Is the button enabled
    Private _buttonState As PushButtonState
    ' What is the button state
    Protected _buttonImageHot As Image
    ' The hot image
    Protected _buttonImageNormal As Image
    ' The normal image
    Protected _buttonImageDisabled As Image
    ' The disabled image
    Private _buttonImageOffset As Integer
    ' The amount of offset or border around the image
    Protected Sub New()
        ' In my project, buttons are disabled by default
        _enabled = False
        _buttonState = PushButtonState.Normal

        ' Changing this value affects the appearance of the image on the button.
        _buttonImageOffset = 2

        ' Call the routine to load the images specific to a column.
        LoadImages()
    End Sub

    ' Button Enabled Property
    Public Property Enabled() As Boolean
        Get
            Return _enabled
        End Get

        Set
            _enabled = Value
            _buttonState = If(Value, PushButtonState.Normal, PushButtonState.Disabled)
        End Set
    End Property

    ' PushButton State Property
    Public Property ButtonState() As PushButtonState
        Get
            Return _buttonState
        End Get
        Set
            _buttonState = Value
        End Set
    End Property

    ' Image Property
    ' Returns the correct image based on the control's state.
    Public ReadOnly Property ButtonImage() As Image
        Get
            Select Case _buttonState
                Case PushButtonState.Disabled
                    Return _buttonImageDisabled

                Case PushButtonState.Hot
                    Return _buttonImageHot

                Case PushButtonState.Normal
                    Return _buttonImageNormal

                Case PushButtonState.Pressed
                    Return _buttonImageNormal

                Case PushButtonState.[Default]
                    Return _buttonImageNormal
                Case Else

                    Return _buttonImageNormal
            End Select
        End Get
    End Property

    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, elementState As DataGridViewElementStates, value As Object,
        formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        'base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

        ' Draw the cell background, if specified.
        If (paintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            Dim cellBackground As New SolidBrush(cellStyle.BackColor)
            graphics.FillRectangle(cellBackground, cellBounds)
            cellBackground.Dispose()
        End If

        ' Draw the cell borders, if specified.
        If (paintParts And DataGridViewPaintParts.Border) = DataGridViewPaintParts.Border Then
            PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle)
        End If

        ' Calculate the area in which to draw the button.
        ' Adjusting the following algorithm and values affects
        ' how the image will appear on the button.
        Dim buttonArea As Rectangle = cellBounds

        Dim buttonAdjustment As Rectangle = BorderWidths(advancedBorderStyle)

        buttonArea.X += buttonAdjustment.X
        buttonArea.Y += buttonAdjustment.Y
        buttonArea.Height -= buttonAdjustment.Height
        buttonArea.Width -= buttonAdjustment.Width

        Dim imageArea As New Rectangle(buttonArea.X + _buttonImageOffset, buttonArea.Y + _buttonImageOffset, 16, 16)

        ButtonRenderer.DrawButton(graphics, buttonArea, ButtonImage, imageArea, False, ButtonState)
    End Sub

    ' An abstract method that must be created in each derived class.
    ' The images in the derived class will be loaded here.
    Public MustOverride Sub LoadImages()
End Class
