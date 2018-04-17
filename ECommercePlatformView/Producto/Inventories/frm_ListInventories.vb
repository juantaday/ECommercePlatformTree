Imports System.Data.Linq
Imports CADsisVenta
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters
Imports DGVPrinterHelper

Public Class frm_ListInventories
    Private ListProductoctSeelct As New List(Of ItemProductos)
    Private isSave As Boolean
    Private Err_code As Integer
    Private Operation As stateOperation
    Private IdInvetory As Integer
    Private isLoad As Boolean
    Private MyStado As Int16

    Private AffectMoney As Double
    Sub New(ByVal stateOperation As stateOperation, ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Operation = stateOperation '
        Me.IdInvetory = id
        MyStado = 1
    End Sub
    Private Sub CloseListNotFountButton_Click(sender As Object, e As EventArgs) Handles CloseListNotFountButton.Click
        Me.SplitContainer1.Panel1Collapsed = True
        dtgNotFount.DataSource = Nothing
    End Sub

    Private Sub frm_ListInventories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListProductoctSeelct = New List(Of ItemProductos)
        SplitContainer1.Panel1Collapsed = True
        Carga_bodega()
        PersonalizaDtg()
        Select Case Operation
            Case stateOperation.Insert
                Me.isSave = False
                Me.SaveStockButton.Enabled = False
            Case stateOperation.Update
                Load_ListSave(Me.IdInvetory)
                Me.SaveListButton.Enabled = False
            Case stateOperation.View
                Load_ListSave(Me.IdInvetory)
                Me.SaveListButton.Enabled = False
                Me.SaveStockButton.Enabled = False
                Me.AddNewListButton.Enabled = False
        End Select
        isLoad = True
    End Sub

    Private Sub Load_ListSave(idInvetory As Integer)
        Try

            Using db As New DataContext
                Dim listSave = (From d In db.InventoryDetail
                                Join i In db.Inventory On i.IdInventory Equals d.IdInventory
                                Join p In db.Productos On d.idProducto Equals p.idProducto
                                Join s In db.ProductosStock On d.idProducto Equals s.idProducto And s.idBodega Equals i.IdBodega
                                Where d.IdInventory = idInvetory
                                Select i.IdBodega, d.idProducto, p.Nom_Comercial, s.Und, s.stock, d.NewStock, i.State, i.Observation).ToList()
                If listSave.Count = 0 Then
                    Me.PanelSelectBodega.Enabled = False
                    SplitContainer1.Enabled = False
                    MsgBox("No hay información", MsgBoxStyle.Exclamation, "Aviso")
                    Return
                End If
                'set the bodegas
                For Each item In listSave
                    ListBodegaComboBox.SelectedValue = item.IdBodega
                    ListProductoctSeelct.Add(New ItemProductos(False, item.idProducto, item.Nom_Comercial, item.Und, item.stock, item.NewStock))
                    MyStado = item.State
                    ObservationRichTextBox.Text = item.Observation
                Next
                Me.PanelSelectBodega.Enabled = False
                If MyStado = 0 Then
                    SaveListButton.Enabled = False
                    SaveStockButton.Enabled = False
                    AddNewListButton.Enabled = False
                    DeleteButton.Enabled = False
                    clm = dtgSelect.Columns("NewStock")
                    clm.ReadOnly = True
                    Me.isSave = True
                Else
                    Me.isSave = True
                    SaveStockButton.Enabled = Me.isSave
                End If
                ViewData()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PersonalizaDtg()
        Try
            dtgSelect.AutoGenerateColumns = False
            dtgNotFount.AutoGenerateColumns = False
            ' dtgSelect.DataSource = ListProductoctSeelct
            applyGridThemeEdit(dtgSelect)
            Me.QuitarFiltroPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
            Me.findButton.BackColor = Me.QuitarFiltroPanel.BackColor
            Me.QuitarFiltroPanel.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_bodega()
        Try
            Using dat As New BodegaSystemTableAdapter
                Using dt As New BodegaSystemDataTable
                    dat.Fill(dt)
                    ListBodegaComboBox.DataSource = dt.ToList()
                    ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                    ListBodegaComboBox.ValueMember = "idBodega"
                    ListBodegaComboBox.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Add_Categoreis(id As Integer)
        Try
            sql = "select p.idProducto
                    , p.Nom_Comercial
                    ,ps.Und, ps.stock
                        from ProductosStock as ps
                    inner join Productos as p  on p.idProducto = ps.idProducto
	                inner join ProductoSubCategoria as sc on sc.idSubCategoria = p.IdSubCategoria
	                inner join ProductoCategoria as c on c.idCategoria  = sc.idCategoria
                    where idBodega  =@idBodega and c.idCategoria = @idCategoria"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@idBodega", ListBodegaComboBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@idCategoria", id)
                    Using dar As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                        Read_Data(dar)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Add_SubCategoreis(id As Integer)
        Try
            sql = "select p.idProducto
                , p.Nom_Comercial
                ,ps.Und, ps.stock
                 from ProductosStock as ps
                inner join Productos as p  on p.idProducto = ps.idProducto 
                where idBodega  =@idBodega and p.IdSubCategoria = @IdSubCategoria"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@idBodega", ListBodegaComboBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@IdSubCategoria", id)
                    Using dar As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                        Read_Data(dar)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Read_Data(ByVal dar As System.Data.SqlClient.SqlDataReader)
        Try
            Dim newList As New List(Of ItemProductos)

            While dar.Read()
                newList.Add(New ItemProductos(False, dar("idProducto").ToString, dar("Nom_Comercial").ToString,
                                                           dar("Und").ToString, dar("stock").ToString, 0))
            End While
            If newList.Count = 0 Then
                Return
            End If
            ' Grouped results.
            Dim petOwnersJoin = (From n In newList
                                 Join l In ListProductoctSeelct
                                 On l.idProducto Equals n.idProducto
                                 Select n.idProducto, n.CheckItem, n.Nom_Comercial, n.Und, n.Stock, n.NewStock).ToList()

            If petOwnersJoin.Count > 0 Then
                Dim totalnotFunt As Double = petOwnersJoin.Count
                dtgNotFount.DataSource = Nothing
                dtgNotFount.DataSource = petOwnersJoin
                applyGridTheme(dtgNotFount)
                SplitContainer1.Panel1Collapsed = False
                SplitContainer1.SplitterDistance = 500
                totalNotFountLabel.Text = "Total: " & totalnotFunt.ToString("N0")
                If Not newList.Count = petOwnersJoin.Count Then
                    Dim petOwners = (From N In newList
                                     Group Join l In ListProductoctSeelct On N.idProducto Equals l.idProducto
                                    Into PetList = Group
                                     From pet In PetList.DefaultIfEmpty()
                                     Select N.idProducto, N.CheckItem, N.Nom_Comercial, N.Und, N.Stock, N.NewStock,
                    PetName =
                      If(pet Is Nothing, String.Empty, pet.Nom_Comercial)).ToList().Where(Function(x) x.PetName = String.Empty).ToList()

                    sql = petOwners.Count
                    For Each item In petOwners
                        ListProductoctSeelct.Add(New ItemProductos(False, item.idProducto,
                                                                   item.Nom_Comercial, item.Nom_Comercial,
                                                                   item.Stock, item.NewStock))
                    Next
                    ViewData()
                End If
            Else
                For Each item As ItemProductos In newList
                    ListProductoctSeelct.Add(item)
                Next
            End If
            ViewData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemProductos
        Public Sub New(ByVal checkItem As Boolean, ByVal idproduct As Integer, ByVal nom_Comercial As String, ByVal und As String,
                ByVal stock As Double, ByVal newStock As Double)
            _idProducto = idproduct
            _Nom_Comercial = nom_Comercial
            _Und = und
            _stock = stock
            _newStock = newStock
            _CheckItem = checkItem
        End Sub

        Private _CheckItem As Boolean
        Public Property CheckItem() As Boolean
            Get
                Return _CheckItem
            End Get
            Set(ByVal value As Boolean)
                _CheckItem = value
            End Set
        End Property
        Private _idProducto As Integer
        Public Property idProducto() As Integer
            Get
                Return _idProducto
            End Get
            Set(ByVal value As Integer)
                _idProducto = value
            End Set
        End Property
        Private _Nom_Comercial As String
        Public Property Nom_Comercial() As String
            Get
                Return _Nom_Comercial
            End Get
            Set(ByVal value As String)
                _Nom_Comercial = value
            End Set
        End Property
        Private _Und As String
        Public Property Und() As String
            Get
                Return _Und
            End Get
            Set(ByVal value As String)
                _Und = value
            End Set
        End Property
        Private _stock As Double
        Public Property Stock() As Double
            Get
                Return _stock
            End Get
            Set(ByVal value As Double)
                _stock = value
            End Set
        End Property

        Private _newStock As Double
        Public Property NewStock() As Double
            Get
                Return _newStock
            End Get
            Set(ByVal value As Double)
                _newStock = value
            End Set
        End Property
    End Class

    Private Sub AddNewListButton_MouseDown(sender As Object, e As MouseEventArgs) Handles AddNewListButton.MouseDown
        If ListBodegaComboBox.SelectedIndex = -1 Then
            MsgBox("Seleccione el local o bodega", MsgBoxStyle.Exclamation, "Importante")
            ListBodegaComboBox.Focus()
            ListBodegaComboBox.DroppedDown = True
            Return
        End If
        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DesdeUnaCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesdeUnaCategoríaToolStripMenuItem.Click
        Try
            If ListBodegaComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccion la bodega a actualizar", MsgBoxStyle.Exclamation, "Importante")
                ListBodegaComboBox.Focus()
                Return
            End If

            Using formCategories As New frm_Categoria(Nothing)
                With formCategories
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Dim id As Integer = .SelectedNode.Tag
                        If .isSubCategory Then
                            Add_SubCategoreis(id)
                        Else
                            Add_Categoreis(id)
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ViewData()
        Try
            Dim totalItem As Double = ListProductoctSeelct.Count
            If totalItem > 0 Then
                ListProductoctSeelct.OrderBy(Function(x) x.Nom_Comercial).ToList()
                dtgSelect.DataSource = Nothing
                dtgSelect.DataSource = ListProductoctSeelct
                QuitFilterButton.Visible = False
                DeleteButton.Visible = False

                QuitarFiltroPanel.Visible = True
                Panelfilter.Visible = True
                CheckBoxSeelct.Checked = False
                FindTextBox.Text = String.Empty
            Else
                dtgSelect.DataSource = Nothing
                QuitarFiltroPanel.Visible = False
                Panelfilter.Visible = False
            End If
            If isLoad Then
                Me.isSave = False
                Me.SaveStockButton.Enabled = isSave
                Me.SaveListButton.Enabled = True
            End If

            TotalItemLabel.Text = "Total en lista: " & totalItem.ToString("N0")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtgSelect_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSelect.CellContentClick
        Try
            If e.RowIndex >= 0 And e.ColumnIndex = 1 Then
                Dim response As Boolean = Not dtgSelect.Rows(e.RowIndex).Cells(1).Value
                dtgSelect.Rows(e.RowIndex).Cells(1).Value = response
                If response Then
                    DeleteButton.Visible = True
                Else
                    Dim list As List(Of ItemProductos) = ListProductoctSeelct.Where(Function(x) x.CheckItem = True).ToList()
                    DeleteButton.Visible = list.Count
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CheckBoxSeelct_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeelct.CheckedChanged
        Try
            For i = 0 To dtgSelect.RowCount - 1
                dtgSelect.Rows(i).Cells(1).Value = CheckBoxSeelct.Checked
            Next
            DeleteButton.Visible = CheckBoxSeelct.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If MsgBox("Esta seguro de eliminar los registros seleccionados.?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Dim list As New List(Of ItemProductos)
                list = ListProductoctSeelct.Where(Function(x) x.CheckItem = False).ToList()

                ListProductoctSeelct.Clear()
                For Each item As ItemProductos In list
                    ListProductoctSeelct.Add(item)
                Next
                ViewData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FindTextBox.KeyDown
        findButton.Tag = 0
        If e.KeyCode = Keys.Enter Then
            findButton.Tag = 1
        End If
    End Sub

    Private Sub FindTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FindTextBox.KeyPress
        If findButton.Tag = 1 Then
            e.Handled = True
            findButton.PerformClick()
        End If
    End Sub

    Private Sub TodaLaListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodaLaListaToolStripMenuItem.Click
        Try
            If ListBodegaComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccion la bodega a actualizar", MsgBoxStyle.Exclamation, "Importante")
                ListBodegaComboBox.Focus()
                Return
            End If
            sql = "select p.idProducto
                , p.Nom_Comercial
                ,ps.Und, ps.stock
                    from ProductosStock as ps
                inner join Productos as p  on p.idProducto = ps.idProducto
                where idBodega  =@idBodega"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@idBodega", ListBodegaComboBox.SelectedValue)
                    Using dar As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                        Read_Data(dar)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Dim List As New List(Of ItemProductos)
            List = ListProductoctSeelct.Where(Function(x) x.Nom_Comercial.Contains(FindTextBox.Text.ToUpper())).ToList
            dtgSelect.DataSource = Nothing
            dtgSelect.DataSource = List
            QuitFilterButton.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        If FindTextBox.Text.Length > 2 Then
            findButton.Enabled = True
        Else
            findButton.Enabled = False
        End If
    End Sub
    Private Sub QitfilterButton_Click(sender As Object, e As EventArgs) Handles QuitFilterButton.Click
        ViewData()
        QuitFilterButton.Visible = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            If ListProductoctSeelct.Count = 0 Then
                MsgBox("No hay informacion para imprimir", MsgBoxStyle.Information, "Aviso")
                Return
            End If
            Dim eCommerce As String
            Using db As New DataContext
                Dim myCommerce = db.myCommerce.ToList()
                eCommerce = myCommerce(0).RazonSocial
            End Using

            Dim stado As String = String.Empty
            Select Case MyStado
                Case 0
                    stado = "Actualizado(finalizado)"
                Case 1
                    stado = "Iniciado"
                Case 2
                    stado = "En proceso"
                Case Else
                    stado = "No establecido"
            End Select


            Dim printer As New DGVPrinter
            printer.Title = eCommerce

            sql = "INVENTARIO DE PRODUCTOS PREVIO A LAS MODIFICACIONES." & vbCrLf _
                & String.Format("Local o Bodega: {0}", ListBodegaComboBox.Text) & vbCrLf _
                & "Estado: " & stado
            printer.SubTitle = sql
            'printer.SubTitlePrint = String.Format("Fecha: {0}", Date.Now.Date.ToString)
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            printer.TitleSpacing = 8
            printer.PageNumbers = True
            printer.PorportionalColumns = True
            printer.HeaderCellAlignment = StringAlignment.Near
            printer.Footer = String.Format("Impreso: {0} {1}      User: {2}", Date.Now.ToShortDateString, Date.Now.ToShortTimeString, UsuarioActivo.codUser)
            printer.FooterSpacing = 15
            printer.FooterAlignment = StringAlignment.Near
            printer.PrintDataGridView(dtgSelect)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function SaveListInventoryAS(id As Integer) As Boolean
        Try
            If id = 0 Then
                Return False
            End If
            Me.Cursor = Cursors.WaitCursor
            Using db As New DataContext
                Dim _AffectMoney As Double = 0
                Me.AffectMoney = 0

                Dim transaction As Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim Invent = (From inv In db.Inventory
                                  Where inv.IdInventory = id
                                  Select inv)


                    For Each invt In Invent
                        invt.Observation = ObservationRichTextBox.Text
                        invt.State = 2
                        db.SubmitChanges()
                        'delte the information
                        Dim detailQuery = From detail In db.InventoryDetail Where detail.IdInventory = id
                        For Each detail In detailQuery
                            db.InventoryDetail.DeleteOnSubmit(detail)
                        Next
                        db.SubmitChanges()

                        'add the information
                        For Each item As ItemProductos In ListProductoctSeelct
                            Dim InventoryDetail As New InventoryDetail With
                              {
                                .IdInventory = id,
                                .idProducto = item.idProducto,
                                .BeforeStock = item.Stock,
                                .NewStock = item.NewStock,
                                .AffectsInMoney = 0
                               }
                            db.InventoryDetail.InsertOnSubmit(InventoryDetail)
                        Next
                        db.SubmitChanges()

                        'tomo la informacion del estock actual,,,
                        Dim invetQuery = From idtail In db.InventoryDetail
                                         Join p In db.ProductosStock On p.idProducto Equals idtail.idProducto
                                         Where idtail.IdInventory = Me.IdInvetory And p.idBodega = invt.IdBodega
                                         Select idtail.IdInventoryDetail, p.idProdcutStock, p.stock, idtail.NewStock, p.pvpUND

                        'leo y actulizo un solo inforamcionb
                        For Each item In invetQuery
                            Dim invetDetail = From invetdell In db.InventoryDetail
                                              Where invetdell.IdInventoryDetail = item.IdInventoryDetail
                            For Each dt In invetDetail
                                dt.BeforeStock = item.stock
                                dt.AffectsInMoney = (item.NewStock - item.stock) * item.pvpUND
                                Me.AffectMoney += dt.AffectsInMoney
                            Next
                            db.SubmitChanges()
                        Next
                        invt.AffectsInMoney = Me.AffectMoney
                    Next

                    db.SubmitChanges()
                    transaction.Commit()
                    db.Connection.Close()
                    SaveStockButton.Enabled = True
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    If Not IsNothing(transaction) Then
                        transaction.Rollback()
                    End If
                    If db.Connection.State = ConnectionState.Open Then
                        db.Connection.Close()
                    End If
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Function SaveListInventory() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            If ListProductoctSeelct.Count = 0 Then
                MsgBox("No existe información para guardar.", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim db As New DataContext

            Dim transaction As System.Data.Common.DbTransaction

            db.Connection.Open()
            transaction = db.Connection.BeginTransaction()
            Try
                db.Transaction = transaction
                Dim Inventory As New Inventory With {
                     .IdBodega = ListBodegaComboBox.SelectedValue,
                    .CodUserStar = UsuarioActivo.codUser,
                    .Observation = ObservationRichTextBox.Text,
                    .State = 1
                   }
                db.Inventory.InsertOnSubmit(Inventory)
                db.SubmitChanges()

                For Each item As ItemProductos In ListProductoctSeelct
                    Dim InventoryDetail As New InventoryDetail With
                    {
                             .IdInventory = Inventory.IdInventory,
                            .idProducto = item.idProducto,
                            .BeforeStock = item.Stock,
                            .NewStock = item.NewStock,
                            .AffectsInMoney = 0
                           }
                    db.InventoryDetail.InsertOnSubmit(InventoryDetail)
                Next
                Me.IdInvetory = Inventory.IdInventory
                db.SubmitChanges()
                transaction.Commit()
                SaveStockButton.Enabled = True
                Return True
            Catch ex2 As Exception
                MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                If Not IsNothing(transaction) Then
                    transaction.Rollback()
                End If
                Return False
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function
    Private Sub OnInfoMessage(sender As Object, args As System.Data.SqlClient.SqlInfoMessageEventArgs)
        Err_code = args.Errors.Item(0).Number
        Dim err As System.Data.SqlClient.SqlError
        For Each err In args.Errors
            MsgBox(err.Message, MsgBoxStyle.Exclamation, "Error")
        Next
    End Sub

    Private Sub SaveListButton_Click(sender As Object, e As EventArgs) Handles SaveListButton.Click
        Me.isSave = False
        If Operation = stateOperation.Update Then
            Return
        End If
        If ListProductoctSeelct.Count = 0 Then
            MsgBox("No existe información para guardar", MsgBoxStyle.Exclamation, "Aviso")
            Return
        End If
        Using frmInvent As New frmDescriptionInventories(stateOperation.Insert, 0)
            With frmInvent
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    Me.ObservationRichTextBox.Text = .ObservationRichTextBox.Text
                    If SaveListInventory() Then
                        PanelSelectBodega.Enabled = False
                        Me.isSave = True
                        Me.SaveStockButton.Enabled = isSave
                        Me.Operation = stateOperation.Update
                        Me.SaveListButton.Enabled = False
                        MsgBox("Información guardada.", MsgBoxStyle.Information, "Aviso")
                    End If
                End If
            End With
        End Using
    End Sub

    Private Sub SoloUnProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoloUnProductoToolStripMenuItem.Click
        Try
            If ListBodegaComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione el local o bodega.", MsgBoxStyle.Exclamation, "Imortante")
                Return
            End If

            Using listProduct As New frmList_ProductPrecioVenta
                With listProduct
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Add_OnePorduct(.idProducto)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Add_OnePorduct(id As Integer)
        Try
            If ListBodegaComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione el local o bodega.", MsgBoxStyle.Exclamation, "Imortante")
                Return
            End If
            sql = "select p.idProducto
                , p.Nom_Comercial
                ,ps.Und, ps.stock
                 from ProductosStock as ps
                inner join Productos as p  on p.idProducto = ps.idProducto 
                where idBodega  =@idBodega and p.idProducto = @idProducto"

            Using cnn As New System.Data.SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New System.Data.SqlClient.SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@idBodega", ListBodegaComboBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@idProducto", id)
                    Using dar As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader()
                        Read_Data(dar)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SaveStockButton_Click(sender As Object, e As EventArgs) Handles SaveStockButton.Click
        If Update_ListInventory() Then
            MsgBox(msgExsito, MsgBoxStyle.Exclamation, "Eviso")
            Me.SaveStockButton.Enabled = False
            SaveListButton.Enabled = False
            AddNewListButton.Enabled = False
            DeleteButton.Enabled = False
            dtgSelect.Columns("NewStock").ReadOnly = True
            Me.Operation = stateOperation.View
            PanelSelectBodega.Enabled = False
        End If
    End Sub

    Private Function Update_ListInventory() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor
            'set the autorization----
            Dim Autorization As String = String.Empty
            Dim response As Boolean = False
            Using newform As New LoginForm(stateReturn._response, "Administrador de inventarios")
                With newform
                    .Text = "Validando para guardar."
                    .ShowDialog()
                    If (.DialogResult = DialogResult.OK) Then
                        Autorization = .UsernameTextBox.Text
                        response = True
                    Else
                        Return False
                    End If
                End With
            End Using


            Using db As New DataContext
                Dim transaction As Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    'tomo la informacion del estock actual,,,
                    Dim invetQuery =
                        From i In db.Inventory
                        Join id In db.InventoryDetail On i.IdInventory Equals id.IdInventory
                        Join p In db.ProductosStock On p.idProducto Equals id.idProducto And p.idBodega Equals i.IdBodega
                        Where i.IdInventory = Me.IdInvetory
                        Select i.IdInventory, id.IdInventoryDetail, p.idProdcutStock
                    'leo y actulizo un solo inforamcionb
                    Dim row As Integer = 0
                    Dim _newStock As Double = 0
                    Dim _AffectMoney As Double = 0
                    Me.AffectMoney = 0
                    For Each item In invetQuery
                        'load and set the product
                        Dim productStock = From iv In db.ProductosStock Where iv.idProdcutStock = item.idProdcutStock Select iv
                        Dim inevtDetail = From idetal In db.InventoryDetail Where idetal.IdInventoryDetail = item.IdInventoryDetail Select idetal
                        For Each it In productStock
                            For Each idt In inevtDetail
                                idt.BeforeStock = it.stock
                                idt.AffectsInMoney = (idt.NewStock - it.stock) * it.pvpUND
                                _AffectMoney = idt.AffectsInMoney
                                Me.AffectMoney += _AffectMoney
                                _newStock = idt.NewStock
                            Next
                            it.stock = _newStock
                            db.SubmitChanges()
                        Next
                        'si es el ultimmo registro gurdo
                        If row = invetQuery.Count - 1 Then
                            Dim invent = From iv In db.Inventory Where iv.IdInventory = item.IdInventory
                            Dim getDateServer = db.getDateServer.ToList()(0)
                            For Each it In invent
                                it.Observation = Me.ObservationRichTextBox.Text
                                it.AffectsInMoney = Me.AffectMoney
                                it.Authorizes = Autorization
                                it.DateTimeEnd = getDateServer.Column1
                                it.State = 0
                                db.SubmitChanges()
                            Next
                        End If
                        row += 1
                    Next
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function


    Private Sub ListBodegaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBodegaComboBox.SelectedIndexChanged
        Try
            If Not ListBodegaComboBox.SelectedIndex = -1 Then
                ' Referenciando el objeto DataRowView correspondiente
                ' al elemento seleccionado en el control ComboBox.
                Dim row As BodegaSystemRow = DirectCast(ListBodegaComboBox.SelectedItem, BodegaSystemRow)
                If IsNothing(row) Then
                    Return
                End If
                sql = row.Item("Des_Bodega").ToString & vbCrLf
                sql = sql & "Dirección: " & row.Item("Direc_Bodega").ToString & vbCrLf
                sql = sql & "Teléfono: " & row.Item("Telef1_Bodega").ToString
                DescriptionBodegaLabel.Text = sql
                If Not IsNothing(ListProductoctSeelct) Then
                    ListProductoctSeelct.Clear()
                    dtgSelect.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SaveListButton_MouseDown(sender As Object, e As MouseEventArgs) Handles SaveListButton.MouseDown
        If Me.Operation = stateOperation.Update Then
            If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Dim Menu As ContextMenuStrip = Me.ContextMenuSaveAs
                Menu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dtgSelect_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSelect.CellValueChanged
        If Operation = stateOperation.View Then
            Return
        End If
        Me.isSave = False
        Me.SaveStockButton.Enabled = Me.isSave
        Me.SaveListButton.Enabled = True
    End Sub

    Private Sub CambiarObservacionesYGuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarObservacionesYGuardarToolStripMenuItem.Click
        Try
            Using frmObserv As New frmDescriptionInventories(stateOperation.Update, Me.IdInvetory)
                With frmObserv
                    .ObservationRichTextBox.Text = ObservationRichTextBox.Text
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.ObservationRichTextBox.Text = .ObservationRichTextBox.Text
                    Else
                        Return
                    End If
                End With
            End Using

            If Me.SaveListInventoryAS(Me.IdInvetory) Then
                MsgBox(msgExsito, MsgBoxStyle.Exclamation, "Eviso")
                Me.SaveListButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If Me.SaveListInventoryAS(Me.IdInvetory) Then
                MsgBox(msgExsito, MsgBoxStyle.Exclamation, "Eviso")
                Me.SaveListButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
    Private Sub dtgSelect_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtgSelect.DataError
        If e.Exception.Message.Contains("formato correcto") Then
            MsgBox("La celda acepta solo valores numéricos", MsgBoxStyle.Exclamation, "Error")
        ElseIf (e.Exception.Message.Contains("no tiene un valor.")) Then

        Else
            MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class

