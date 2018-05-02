Imports System.Data.SqlClient
Imports CADsisVenta

Public Class frmConfiguracion
#Region "Atributes"
    Private myPadre As MDI_AddProductos
    Private ListSelectInbodega As New List(Of ItemInBodega)
    Private ListBodega As New List(Of ListBosegas)
    Private listaBase As New List(Of ListBosegas)
    Private dt As New DataTable
#End Region

#Region "constructor"
    Sub New(myPadre As MDI_AddProductos)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.myPadre = myPadre
    End Sub
#End Region

#Region "Load Data"
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Presentation_SeCompraSeVende()
        Load_ItemEnbodega()
        Load_ListBodega()
        'SetCombobox()
    End Sub
    Private Sub Load_ItemEnbodega()
        Try
            Dim medida As String = String.Empty
            Dim disposable As Boolean = False
            Dim listItemInBodega As New List(Of ItemInBodega)
            listItemInBodega.Add(New ItemInBodega(0, "[Seleccione..]", False, String.Empty))

            If Not IsNothing(dt) Then
                For i = 0 To dt.Rows.Count - 1
                    medida = dt.Rows(i)("Medida")
                    If medida = "KG" Or medida = "LB" Or medida = "LT" Then
                        disposable = True
                    Else
                        disposable = False
                    End If
                    listItemInBodega.Add(New ItemInBodega(dt.Rows(i)("IdProUndMed"), dt.Rows(i)("nombre"), disposable, medida))
                Next
                Dim isDelete As Boolean = False
                For Each it In listItemInBodega
                    If it.Isdisposable Then
                        isDelete = True : Exit For
                    End If
                Next


                If isDelete Then
                    For Each item In listItemInBodega
                        If Not item.Medida = "UN" Then
                            ListSelectInbodega.Add(item)
                        End If
                    Next
                Else
                    ListSelectInbodega = listItemInBodega
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_ListBodega()
        Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
            cnn.Open()
            sql = "select 
                b.idBodega,
                b.Nom_Bodega,
                'Nota:'+ CHAR(13) + CHAR(10) + b.Des_Bodega + CHAR(13) + CHAR(10) + ' Dirección:' + CHAR(13) + CHAR(10) + 
                 b.Direc_Bodega +'Teléfono:'+ CHAR(13) + CHAR(10) +  b.Telef1_Bodega as Descripcion,
                stc.idProUndMed,
                stc.StockAlert 
                from Bodegas as b
                inner join ProductosStock as stc on stc.idBodega = b.idBodega
                inner join Productos as p on p.idProducto  = stc.idProducto
                where ((stc.idProducto=@idProducto))"
            Using cmd As New SqlCommand(sql, cnn)
                Using dat As New SqlDataAdapter(cmd)
                    cmd.Parameters.Add("@idProducto", SqlDbType.Int)
                    cmd.Parameters("@idProducto").Value = myPadre.Id_Producto
                    Using dt As New DataTable
                        dat.Fill(dt)
                        For Each row As DataRow In dt.Rows
                            ListBodega.Add(New ListBosegas(row("idBodega"), row("Nom_Bodega"),
                               row("idProUndMed"), row("Descripcion"), row("StockAlert"), ListSelectInbodega))
                            listaBase.Add(New ListBosegas(row("idBodega"), row("Nom_Bodega"),
                              row("idProUndMed"), row("Descripcion"), row("StockAlert"), ListSelectInbodega))
                        Next

                        ' Initialize the DataGridView.
                        dtg.AutoGenerateColumns = False
                        dtg.AutoSize = False
                        dtg.DataSource = ListBodega
                        applyGridThemeEdit(dtg)
                        'combre del local o bodega
                        Dim column As DataGridViewColumn = New DataGridViewTextBoxColumn()
                        column.DataPropertyName = "Nom_Bodega"
                        column.Name = "Nom_Bodega"
                        column.HeaderText = "Local o bodega"
                        column.Width = 180
                        column.ReadOnly = True
                        dtg.Columns.Add(column)
                        'medidas en stoct..
                        Dim combo As New DataGridViewComboBoxColumn()
                        combo.DataPropertyName = "IdProUndMe"
                        combo.Name = "IdProUndMed"
                        combo.ValueMember = "idProUndMed"
                        combo.DisplayMember = "nombre"
                        combo.DataSource = ListSelectInbodega
                        combo.HeaderText = "Medida stock"
                        combo.Width = 150
                        dtg.Columns.Add(combo)
                        'uinidades minimas a aertar
                        column = New DataGridViewTextBoxColumn()
                        column.DataPropertyName = "Stockalert"
                        column.Name = "Stockalert"
                        column.HeaderText = "Mínimo stock alerta"
                        column.Width = 100
                        column.DefaultCellStyle = myStileNumber
                        dtg.Columns.Add(column)

                        'descripcion
                        column = New DataGridViewTextBoxColumn()
                        column.DataPropertyName = "Description"
                        column.Name = "Description"
                        column.HeaderText = "Descripcion de bodega"
                        column.Visible = False
                        dtg.Columns.Add(column)
                        'idbodega
                        column = New DataGridViewTextBoxColumn()
                        column.DataPropertyName = "IdBodega"
                        column.Name = "IdBodega"
                        column.HeaderText = "IdBodega"
                        column.Visible = False
                        dtg.Columns.Add(column)
                        dtg.ColumnHeadersHeight = 40
                        dtg.BorderStyle = BorderStyle.Fixed3D
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Private Sub Load_Presentation_SeCompraSeVende()
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "Select p.idPresentacion, m.idProUndMed, m.Nom_Medida + ' ['+ p.Presentacion+']' as nombre,  
                m.Medida from ProductoPresentacion  as p 
                inner Join ProductoUndMedida as m
                On m.idProUndMed = p.idProUndMed
                where p.idProducto = @IdProducto "

                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@IdProducto", SqlDbType.Int)
                    cmd.Parameters("@IdProducto").Value = Me.myPadre.Id_Producto

                    Dim dtCompra As New DataTable
                    Dim dtVenta As New DataTable
                    Dim dtBodega As New DataTable

                    Using dat As New SqlDataAdapter(cmd)
                        dat.Fill(dt)
                        dat.Fill(dtCompra)
                        dat.Fill(dtVenta)
                        dat.Fill(dtBodega)

                        If dtCompra.Rows.Count > 0 Then
                            seCompraCombobox.DataSource = dtCompra
                            seVendeCombobox.DataSource = dtVenta

                            seCompraCombobox.DisplayMember = "nombre"
                            seVendeCombobox.DisplayMember = "nombre"

                            seCompraCombobox.ValueMember = "idProUndMed"
                            seVendeCombobox.ValueMember = "idProUndMed"

                            With myPadre
                                If .Id_seCompra > 0 Then
                                    seCompraCombobox.SelectedValue = .Id_seCompra
                                End If
                                If .Id_seVende > 0 Then
                                    seVendeCombobox.SelectedValue = .Id_seVende
                                End If
                            End With
                        End If
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

#End Region

#Region "Events"
    Private Sub seCompraCombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seCompraCombobox.SelectedIndexChanged
        Try
            If DirectCast(sender, ComboBox).ValueMember.ToString.Length > 0 Then
                If DirectCast(sender, ComboBox).SelectedValue > 0 Then
                    If Not (myPadre.Id_seCompra = DirectCast(sender, ComboBox).SelectedValue) Then
                        If myPadre.Operation = stateOperation.Insert And myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Siguiente=>"
                        ElseIf myPadre.Operation = stateOperation.Update Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Guardar"
                        End If
                    Else
                        myPadre.SiguienteButton.Visible = True
                        myPadre.SiguienteButton.Enabled = False
                    End If

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub seVendeCombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seVendeCombobox.SelectedIndexChanged
        Try
            If DirectCast(sender, ComboBox).ValueMember.ToString.Length > 0 Then
                If DirectCast(sender, ComboBox).SelectedValue > 0 Then
                    If Not (myPadre.Id_seVende = DirectCast(sender, ComboBox).SelectedValue) Then
                        If myPadre.Operation = stateOperation.Insert And myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Siguiente=>"
                        ElseIf myPadre.Operation = stateOperation.Update Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Guardar"
                        End If
                    Else
                        myPadre.SiguienteButton.Visible = True
                        myPadre.SiguienteButton.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SiguientButton_Click(sender As Object, e As EventArgs) Handles SiguientButton.Click
        If validaDatos() Then
            If Update_SeCompra_SeVende() Then
                If UpdateVerBodega() Then
                    If myPadre.Id_Proveedor > 0 Then
                        SaveDefaultProvider()
                    End If
                    If myPadre.Estado And myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                        With myPadre
                            .menuDetalle.Enabled = True
                            .menuCategory.Enabled = True
                            .menuPresentacion.Enabled = True
                            .menuConfiguracion.Enabled = True
                            .menuProveedor.Enabled = True
                            .menuProveedor.PerformClick()
                        End With
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        sender.Tag = 0
        If validaDatos() Then
            If UpdateVerBodega() Then
                If Update_SeCompra_SeVende() Then
                    'si tengo el codigo de proveerdor aqui agrego automaticamen
                    If myPadre.Id_Proveedor > 0 Then
                        SaveDefaultProvider()
                    End If
                    sender.Tag = 1
                End If
            End If
        End If
    End Sub

    Private Sub SaveDefaultProvider()
        Try
            If seCompraCombobox.SelectedIndex = -1 Then
                Return
            End If
            myPadre.IdPresent_SeCompra = seCompraCombobox.SelectedItem("idPresentacion").ToString()

            Using db As New DataContext
                Dim productProvider = db.ProductoProveedor.Where(
                    Function(x) x.idPresentacion = myPadre.IdPresent_SeCompra _
                    And x.idProveedor = myPadre.Id_Proveedor).FirstOrDefault()

                If productProvider Is Nothing Then
                    Dim _ProductoProveedor As New ProductoProveedor With
               {
                   .CostoTotal = 0,
                   .Fech_Compra = Date.Now(),
                   .idPresentacion = myPadre.IdPresent_SeCompra,
                   .idProveedor = myPadre.Id_Proveedor
               }
                    db.ProductoProveedor.InsertOnSubmit(_ProductoProveedor)
                    db.SubmitChanges()
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "Commands"

    Private Function Update_SeCompra_SeVende() As Boolean
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()

                Using cmd As New SqlCommand("prcDefaultSalesAndPurchars", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@IdPorduct", SqlDbType.Int)
                    cmd.Parameters.Add("@idDefaultSales", SqlDbType.Int)
                    cmd.Parameters.Add("@idDefaultPurchars", SqlDbType.Int)
                    cmd.Parameters.Add("@idIsDefaultSales", SqlDbType.Int)

                    cmd.Parameters("@IdPorduct").Value = myPadre.Id_Producto
                    cmd.Parameters("@idDefaultPurchars").Value = seCompraCombobox.SelectedValue
                    cmd.Parameters("@idDefaultSales").Value = seVendeCombobox.SelectedValue
                    cmd.Parameters("@idIsDefaultSales").Value =
                       Integer.Parse(CType(seVendeCombobox.SelectedItem, DataRowView).Item("idPresentacion"))

                    If cmd.ExecuteNonQuery() Then
                        myPadre.Id_seCompra = cmd.Parameters("@idDefaultPurchars").Value
                        myPadre.Id_seVende = cmd.Parameters("@idDefaultSales").Value
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function UpdateVerBodega() As Boolean
        Try

            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "Update ProductosStock set idProUndMed = @idProUndMed, StockAlert = @StockAlert, Und =@Nombre
                       where ((idProducto =@idProducto) and (idBodega = @IdBodega))"
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@idProUndMed", SqlDbType.Int)
                    cmd.Parameters.Add("@IdBodega", SqlDbType.Int)
                    cmd.Parameters.Add("@idProducto", SqlDbType.Int)
                    cmd.Parameters.Add("@StockAlert", SqlDbType.Int)
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100)

                    For Each row As DataGridViewRow In dtg.Rows
                        cmd.Parameters("@idProUndMed").Value = row.Cells(dtg.Columns("idProUndMed").Index).Value
                        cmd.Parameters("@IdBodega").Value = row.Cells(dtg.Columns("IdBodega").Index).Value
                        cmd.Parameters("@idProducto").Value = myPadre.Id_Producto
                        cmd.Parameters("@StockAlert").Value = row.Cells(dtg.Columns("Stockalert").Index).Value

                        For Each item As ItemInBodega In ListSelectInbodega
                            If item.IdProUndMed = cmd.Parameters("@idProUndMed").Value Then
                                cmd.Parameters("@Nombre").Value = item.Nombre
                                Exit For
                            End If
                        Next

                        If Not cmd.ExecuteNonQuery() = 1 Then
                            Return False
                        End If
                    Next
                End Using
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function validaDatos() As Boolean
        Try
            Dim respose As Boolean = True
            If Not seCompraCombobox.ValueMember.ToString.Length > 0 Then
                respose = False
            End If

            If Not seVendeCombobox.ValueMember.ToString.Length > 0 Then
                respose = False
            End If

            If Not seCompraCombobox.SelectedValue > 0 Then
                respose = False
            End If

            If Not seVendeCombobox.SelectedValue > 0 Then
                respose = False
            End If

            If Not respose Then
                MsgBox("Datos no Validos.", MsgBoxStyle.Exclamation, "Elerta.")
                Return respose
            End If
            If seCompraCombobox.SelectedValue = 0 Then
                ErrorIcon.SetError(seCompraCombobox, "Seleccione uno de la lista")
                Return False
            Else
                ErrorIcon.SetError(seCompraCombobox, "")
            End If
            If seVendeCombobox.SelectedValue = 0 Then
                ErrorIcon.SetError(seVendeCombobox, "Seleccione uno de la lista")
                Return False
            Else
                ErrorIcon.SetError(seVendeCombobox, "")
            End If

            'Valida unidades validos en stock 
            For Each row As DataGridViewRow In dtg.Rows
                If IsNothing(row.Cells(dtg.Columns("IdProUndMed").Index).Value) Then
                    MsgBox("El unidad de stoc no es valido", MsgBoxStyle.Exclamation, "Importante")
                    ErrorIcon.SetError(dtg, "El unidad de stoc no es valido")
                    Return False
                End If
                If row.Cells(dtg.Columns("IdProUndMed").Index).Value = 0 Then
                    MsgBox("El unidad de stoc no es valido", MsgBoxStyle.Exclamation, "Importante")
                    ErrorIcon.SetError(dtg, "El unidad de stoc no es valido")
                    Return False
                End If
            Next
            ErrorIcon.SetError(dtg, "")
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "models"
    Private Class ItemInBodega
        Public Sub New(ByVal Id_ProUndMed As Integer, ByVal Nombre As String,
            ByVal Isdisposable As Boolean, ByVal medida As String)

            _idProUndMed = Id_ProUndMed
            _nombre = Nombre
            _isDisposable = Isdisposable
            _medida = medida
        End Sub

        Private _idProUndMed As Integer
        Public Property IdProUndMed() As Integer
            Get
                Return _idProUndMed
            End Get
            Set(ByVal value As Integer)
                _idProUndMed = value
            End Set
        End Property

        Private _nombre As String
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _isDisposable As Boolean
        Public Property Isdisposable() As Boolean
            Get
                Return _isDisposable
            End Get
            Set(ByVal value As Boolean)
                _isDisposable = value
            End Set
        End Property
        Private _medida As String
        Public Property Medida() As String
            Get
                Return _medida
            End Get
            Set(ByVal value As String)
                _medida = value
            End Set
        End Property

    End Class

    Private Class ListBosegas
        Public Sub New(ByVal id_Bodega As Integer, ByVal bodega As String,
            ByVal idMedida As Integer, ByVal description As String,
             ByVal stockAlert As Integer, ByVal listMed As List(Of ItemInBodega))

            _idBodega = id_Bodega
            _nombodega = bodega
            _idProUndMed = idMedida
            _description = description
            _stockAlext = stockAlert
            'exite mediba
            Dim exis As Boolean = False
            For Each med In listMed
                If idMedida = med.IdProUndMed Then
                    exis = True : Exit For
                End If
            Next
            If Not exis Then
                _idProUndMed = 0
            End If
        End Sub

        Private _idBodega As Integer
        Public Property IdBodega() As Integer
            Get
                Return _idBodega
            End Get
            Set(ByVal value As Integer)
                _idBodega = value
            End Set
        End Property
        Private _nombodega As String
        Public Property Nom_Bodega() As String
            Get
                Return _nombodega
            End Get
            Set(ByVal value As String)
                _nombodega = value
            End Set
        End Property
        Private _description As String
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                _description = value
            End Set
        End Property
        Private _idProUndMed As Integer
        Public Property IdProUndMe() As Integer
            Get
                Return _idProUndMed
            End Get
            Set(ByVal value As Integer)
                _idProUndMed = value
            End Set
        End Property
        Private _stockAlext As Integer
        Public Property Stockalert() As Integer
            Get
                Return _stockAlext
            End Get
            Set(ByVal value As Integer)
                _stockAlext = value
            End Set
        End Property
    End Class
    Private Sub dtg_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtg.DataError
        If e.Exception.Message.Contains("formato correcto") Then
            MsgBox("La celda acepta solo valores numéricos", MsgBoxStyle.Exclamation, "Error")
            e.Cancel = False
        Else
            MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dtg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellValueChanged
        Try
            Select Case dtg.Columns(e.ColumnIndex).Name
                Case "Stockalert", "IdProUndMed"
                    If EvaluateChanges(e.RowIndex, dtg.Columns(e.ColumnIndex).Name,
                                      dtg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        If myPadre.Operation = stateOperation.Insert And myPadre.lblProdcutodesc.Text.Contains("Agregando") Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Siguiente=>"
                        ElseIf myPadre.Operation = stateOperation.Update Then
                            myPadre.SiguienteButton.Visible = True
                            myPadre.SiguienteButton.Enabled = True
                            myPadre.SiguienteButton.Text = "Guardar"
                        End If
                    Else
                        myPadre.SiguienteButton.Visible = True
                        myPadre.SiguienteButton.Enabled = False
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub
    Private Function EvaluateChanges(RowIndex As Integer, campo As String, data As Integer) As Boolean
        Try
            Dim i As Integer = 0
            For Each item As ListBosegas In listaBase
                If i = RowIndex Then
                    Select Case campo
                        Case "Stockalert"
                            If Not (item.Stockalert = data) Then
                                Return True
                            End If
                        Case "IdProUndMed"
                            If Not (item.IdProUndMe = data) Then
                                Return True
                            End If
                    End Select
                End If
                i += 1
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

End Class


