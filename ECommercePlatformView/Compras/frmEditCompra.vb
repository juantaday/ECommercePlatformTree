Imports System.ComponentModel
Imports System.Linq
Imports System.Net
Imports CADsisVenta
Imports CADsisVenta.DataSetCompras

Public Class frmEditCompra
    Private list As List(Of ItemAcquisition)
    Private ListProductProvider As List(Of ItemProductsPurchases)
    Private IdProveedor As Integer
    Public dt As DataTable
    Private customersBindingSource As New Windows.Forms.BindingSource()
    Private customerList As BindingList(Of ItemAcquisition)
    Private isLoated As Boolean

    Public Enum Estado
        Unitario = 0
        Total = 1
        AddNew = 2
        EditCount = 3
    End Enum
    Sub New(_list As List(Of ItemAcquisition), _idProveedor As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        customerList = New BindingList(Of ItemAcquisition)
        ListProductProvider = New List(Of ItemProductsPurchases)

        For Each item In _list
            Me.customerList.Add(item)
        Next
        Me.IdProveedor = _idProveedor
    End Sub

    Public _flag As Estado
    Private Property Flag As Estado
        Get
            Return _flag
        End Get
        Set(value As Estado)
            _flag = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Select Case Me.Flag
            Case Estado.AddNew
                ' UpdateProviderInList()
        End Select
        Me.Close()
    End Sub

    Private Sub UpdateProviderInList()
        Using db As New DataContext
            For i = 0 To Me.DataGridView1.Rows.Count - 1
                Dim dataNew As New ProductoProveedor With
                {
                .CostoTotal = 0,
                .idPresentacion = DataGridView1.Rows(i).Cells(DataGridView1.Columns("idPresent").Index).Value,
                .Fech_Compra = Date.Now,
                .idProveedor = IdProveedor
                }
                db.ProductoProveedor.InsertOnSubmit(dataNew)
            Next
            db.SubmitChanges()
        End Using
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Carga_Datos()
        Try
            If IsNothing(Flag) Then
                MsgBox("No se ha determinado el valor para flag ")
                Return
            End If
            If Not IsNothing(list) Then

                dt = New DataTable()
                Dim Column0 As New DataColumn()
                'columna de [Productos] --------- 0
                Column0.ColumnName = "KeyCode"
                Column0.DataType = GetType(String)
                'columna de [Productos] --------- 1
                Dim Column1 As New DataColumn()
                Column1.ColumnName = "Producto"
                Column1.DataType = GetType(String)
                'columna de [P/Unitario] ---------2
                Dim Column2 As New DataColumn()
                Column2.ColumnName = "P/Unitario"
                Column2.DataType = GetType(Double)
                'columna de [P/Total]----------------3
                Dim Column3 As New DataColumn()
                Column3.ColumnName = "P/Total"
                Column3.DataType = GetType(Double)
                'columna de [IvaPorcent]---------------4
                Dim Column4 As New DataColumn()
                Column4.ColumnName = "ivaPorcent"
                Column4.DataType = GetType(Double)
                'columna de [desCuento]--------------5
                Dim Column5 As New DataColumn()
                Column5.ColumnName = "desCuento"
                Column5.DataType = GetType(Double)
                'columna de cantidad------------------6
                Dim Column6 As New DataColumn()
                Column6.ColumnName = "cant"
                Column6.DataType = GetType(Double)
                'columna de cantidad------------------6
                Dim Column7 As New DataColumn()
                Column6.ColumnName = "idPresent"
                Column6.DataType = GetType(Integer)

                'cargamos datos............................................................................
                dt.Columns.AddRange({Column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7})

                For i = 0 To list.Count - 1
                    dt.Rows.Add()
                    dt.Rows(i)("KeyCode") = list(i).ID
                    dt.Rows(i)("Producto") = list(i).Producto
                    dt.Rows(i)("P/Unitario") = list(i).UnitPrice
                    dt.Rows(i)("P/Total") = list(i).TotalParcial
                    dt.Rows(i)("desCuento") = list(i).Discount
                    dt.Rows(i)("ivaPorcent") = list(i).IvaPercent
                    dt.Rows(i)("cant") = list(i).Count
                    dt.Rows(i)("idPresent") = list(i).IdPresent
                Next
                With DataGridView1
                    .DataSource = dt
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    For x = 0 To .Columns.Count - 1
                        .Columns(x).ReadOnly = True
                        .Columns(x).Visible = False
                    Next

                    Select Case Flag.value__
                        Case Estado.Unitario
                            .Columns("P/Unitario").ReadOnly = False
                            .Columns("P/Unitario").Visible = True
                        Case Estado.Total
                            .Columns("P/Total").ReadOnly = False
                            .TabIndex = 0
                            .Columns("P/Total").Selected = True
                            .Columns("P/Total").Visible = True
                        Case Estado.AddNew
                            .AllowUserToAddRows = True
                            .Columns("idPresent").Visible = True
                            .Columns("idPresent").DisplayIndex = 0
                            .Columns("idPresent").ReadOnly = False
                    End Select

                    .Columns("Producto").Visible = True
                    .Columns("Producto").DisplayIndex = 1
                    .Columns("cant").Visible = True
                    .Columns("cant").DisplayIndex = 2

                    ImpideOrdenamiento(DataGridView1)
                    SumaTotal()
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub frmList_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga_Datos()
        IntializaDataVew()
        'Carga_Datos2()
        Load_ProductList()
        isLoated = True
    End Sub
    Private Sub Load_ProductList()
        Try
            Me.ListProductProvider.Clear()
            Using db As New DataContext
                Dim listData = (From p In db.Productos
                                Join pp In db.ProductoPresentacion On p.idProducto Equals pp.idProducto)

                For Each item In listData

                    ListProductProvider.Add(New ItemProductsPurchases With
                             {
                              .CodProducto = item.pp.codProducto,
                              .CostoTotal = item.pp.precioCompra,
                              .idPresentacion = item.pp.idPresentacion,
                              .idProducto = item.p.idProducto,
                              .ItIsExpirable = item.p.ItIsExpirable,
                              .ivaPorcentaje = item.p.ivaPorcentaje,
                              .NomComercial = item.p.Nom_Comercial & " [" & item.pp.Presentacion & "]"
                            })
                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub IntializaDataVew()
        Me.DataGridView1.AutoGenerateColumns = False
        Me.customersBindingSource.DataSource = customerList
        Me.DataGridView1.DataSource = customersBindingSource

        With DataGridView1
            For Each col As DataGridViewColumn In .Columns
                col.ReadOnly = True
                col.Visible = False
            Next
            .Columns(ProductoClm.Index).Visible = True
            .Columns(CountClm.Index).Visible = True

            Select Case Flag.value__

                Case Estado.Unitario
                    .AllowUserToAddRows = False
                    .Columns(UnitPriceClm.Index).ReadOnly = False
                    .Columns(UnitPriceClm.Index).Visible = True
                Case Estado.Total
                    .AllowUserToAddRows = False
                    .Columns(TotalParcialClm.Index).ReadOnly = False
                    .TabIndex = 0
                    .Columns(TotalParcialClm.Index).Selected = True
                    .Columns(TotalParcialClm.Index).Visible = True
                Case Estado.AddNew
                    .AllowUserToAddRows = True
                    .Columns(idPresentClm.Index).Visible = True
                    .Columns(idPresentClm.Index).DisplayIndex = 0
                    .Columns(idPresentClm.Index).ReadOnly = False
            End Select
        End With

    End Sub

    Private Sub Carga_Datos2()
        Me.DataGridView1.DataSource = Me.list
        With DataGridView1
            Select Case Flag.value__

                Case Estado.Unitario
                    .Columns("P/Unitario").ReadOnly = False
                    .Columns("P/Unitario").Visible = True
                Case Estado.Total
                    .Columns("P/Total").ReadOnly = False
                    .TabIndex = 0
                    .Columns("P/Total").Selected = True
                    .Columns("P/Total").Visible = True
                Case Estado.AddNew
                    .AllowUserToAddRows = True
                    .Columns("idPresent").Visible = True
                    .Columns("idPresent").DisplayIndex = 0
                    .Columns("idPresent").ReadOnly = False

            End Select
        End With
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Or Not isLoated Then
            Return
        End If
        SumaTotal()

        Return


        Dim IvaPor As Double = 0
        Dim IvaReal As Double = 0
        Dim Ptotals As Double = 0
        Dim pUnit As Double = 0
        Dim cant As Double = 0
        Dim desc As Double = 0
        Dim estado As Boolean = False
        'columna de [Productos] - 0
        'columna de [P/Unitario] --1
        'columna de [P/Total]------2
        'columna de [IvaPorcent]---3
        'columna de [desCuento]----4
        'columna de cantidad-------5


        'dt.Rows(i)("KeyCode") = list(i).ID
        'dt.Rows(i)("Producto") = list(i).Producto
        'dt.Rows(i)("P/Unitario") = list(i).UnitPrice
        'dt.Rows(i)("P/Total") = list(i).TotalParcial
        'dt.Rows(i)("desCuento") = list(i).Discount
        'dt.Rows(i)("ivaPorcent") = list(i).IvaPercent
        'dt.Rows(i)("cant") = list(i).Count

        Try
            With DataGridView1
                If IsDBNull(sender.rows(e.RowIndex).cells(e.ColumnIndex).value) Then
                    .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                End If
                IvaPor = .Rows(e.RowIndex).Cells(DataGridView1.Columns("ivaPorcent").Index).Value
                Ptotals = .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Total").Index).Value
                pUnit = .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Unitario").Index).Value
                cant = .Rows(e.RowIndex).Cells(DataGridView1.Columns("cant").Index).Value
                desc = .Rows(e.RowIndex).Cells(DataGridView1.Columns("desCuento").Index).Value

                If .Columns(e.ColumnIndex).Name.Equals("P/Unitario") And Not estado Then
                    estado = True
                    If ivaCheckBox.Checked Then
                        'Cantidad po valor unirario
                        Ptotals = FormatNumber((pUnit * cant), 5)
                        If Not descCheckBox.Checked Then
                            .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Total").Index).Value = FormatNumber((Ptotals), 5)
                        Else
                            .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Total").Index).Value = FormatNumber((Ptotals - desc), 5)
                            Ptotals -= .Rows(e.RowIndex).Cells(4).Value
                        End If
                    Else
                        Ptotals = FormatNumber((pUnit * cant), 5)
                        If Not descCheckBox.Checked Then
                            .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Total").Index).Value = FormatNumber((Ptotals), 5)
                        Else
                            .Rows(e.RowIndex).Cells(DataGridView1.Columns("P/Total").Index).Value = FormatNumber((Ptotals - desc), 5)
                        End If
                    End If
                ElseIf .Columns(e.ColumnIndex).Name.Equals("P/Total") And Not estado Then
                    estado = True
                End If
            End With
            SumaTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SumaTotal()
        Dim total As Double = Aggregate item In Me.customerList
                          Into Sum(item.TotalParcial)
        TotalTextBox.Text = Convert.ToString(total)
    End Sub


    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

        If e.Exception.Message.Contains("formato correcto") Then
            MsgBox("La celda acepta solo valores numéricos", MsgBoxStyle.Exclamation, "Error")
        Else
            MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub PegarButton_Click(sender As Object, e As EventArgs) Handles PegarButton.Click
        Try
            Dim buffer As New System.Text.StringBuilder

            If Clipboard.ContainsText Then
                sql = Clipboard.GetText()
            End If

            Dim data As String() = Split(sql, vbNewLine)
            Dim columnEdit As String = String.Empty
            Select Case Flag.value__
                Case Estado.Unitario
                    columnEdit = UnitPriceClm.Name
                Case Estado.Total
                    columnEdit = TotalParcialClm.Name
                Case Estado.AddNew
                    columnEdit = "idPresent"
                Case Estado.EditCount
                    columnEdit = CountClm.Name
            End Select
            If String.IsNullOrWhiteSpace(columnEdit) Then
                Return
            End If

            Select Case Flag.value__
                Case Estado.AddNew

                    For i = 0 To data.Length - 2
                        Me.customerList.Add(New ItemAcquisition With
                                {
                                .IdPresent = data(i)
                                 })
                    Next
                    Update_controls()
                    Return
            End Select

            For i = 0 To data.Count - 2
                DataGridView1.Rows(i).Cells(columnEdit).Value = data(i).ToString
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Update_controls()

        For Each item In Me.customerList
            Dim data = Me.ListProductProvider.Where(Function(x) x.idPresentacion = item.IdPresent).FirstOrDefault()
            If Not data Is Nothing Then
                item.Producto = data.NomComercial
                item.IdProducto = data.idProducto
                item.Codigo = data.CodProducto
                item.IvaPercent = data.ivaPorcentaje
                item.IsExpirate = data.ItIsExpirable
                item.UnitPrice = data.CostoTotal
            End If
        Next
    End Sub
End Class

