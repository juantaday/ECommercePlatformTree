Imports CADsisVenta
Imports DGVPrinterHelper

Public Class frmPresentRates
    Private idRates As Integer
    Private Operation As stateOperation
    Private latestValue As Double
    Private LastNameProducto As String
    Private listProducto As List(Of ItemProducto)
    Private isLoad As Boolean
    Private isSave As Boolean
    Private Const Structura_Name As String = "Presentacion"
    Private _font As Font

    Sub New(ByVal idRates As Integer, ByVal operation As stateOperation)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idRates = idRates
        Me.Operation = operation
        _font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmCategoryRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listProducto = New List(Of ItemProducto)
        PersonalizeGridView()
        Select Case Operation
            Case stateOperation.Insert
                Loade_ListProductos()
            Case stateOperation.Update
                Loade_ListProductos(Me.idRates)
                isSave = True
        End Select
        isLoad = True
    End Sub

    Private Sub PersonalizeGridView()
        Try
            dtg.AutoGenerateColumns = False
            applyGridThemeEdit(dtg)
            dtg.ColumnHeadersHeight = 50
            dtg.SelectionMode = DataGridViewSelectionMode.CellSelect
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_ListProductos()
        Try
            Using db As New DataContext
                Dim _presentation = From p In db.Productos
                                    Join pp In db.ProductoPresentacion On p.idProducto Equals pp.idProducto
                                    Join m In db.ProductoUndMedida On pp.idProUndMed Equals m.idProUndMed
                                    Select p.idProducto, p.IdSubCategoria, pp.idPresentacion, p.Nom_Comercial,
                                    m.Nom_Medida, pp.Presentacion, pp.Empaquetado, pp.precioVenta, pp.precioCompra

                For Each item In _presentation
                    listProducto.Add(New ItemProducto(item.idProducto, item.IdSubCategoria, item.idPresentacion, item.Nom_Comercial,
                    item.Presentacion, item.Empaquetado, item.Nom_Medida, item.precioCompra, item.precioVenta, 1, 0))
                Next
                A_Button.PerformClick()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_ListProductos(_idRates As Integer)
        Try

            Me.DescriptionRichTextBox.Text = String.Empty

            Using db As New DataContext

                Dim myList As IQueryable
                Dim petOwners As IQueryable
                petOwners = Nothing

                myList = (From r In db.Rates
                          Join d In db.RatesPresentantionDetail On r.idRates Equals d.idRates
                          Where r.idRates = _idRates
                          Select r.Descriptions, d.FromC, d.idPresentacion, d.PercentC)

                For Each item In myList

                    Dim myList2 = (From r In db.Rates
                                   Join d In db.RatesPresentantionDetail On r.idRates Equals d.idRates
                                   Where r.idRates = _idRates
                                   Select r.Descriptions, d.FromC, d.idPresentacion, d.PercentC)


                    Me.DescriptionRichTextBox.Text = item.Descriptions

                    petOwners = (From pp In db.ProductoPresentacion
                                 Join p In db.Productos On p.idProducto Equals pp.idProducto
                                 Join m In db.ProductoUndMedida On pp.idProUndMed Equals m.idProUndMed
                                 Group Join r In myList2 On pp.idPresentacion Equals r.idPresentacion
                                 Into PetList = Group
                                 From pet In PetList.DefaultIfEmpty()
                                 Select p.idProducto, p.Nom_Comercial, p.IdSubCategoria, pp.idPresentacion, pp.Presentacion,
                                      pp.Empaquetado, m.Nom_Medida, pp.precioCompra, pp.precioVenta,
                            Fromc =
                                 If(pet Is Nothing, 1, pet.FromC),
                            PercentC =
                                 If(pet Is Nothing, 0, pet.PercentC))
                    Exit For
                Next
                If String.IsNullOrEmpty(Me.DescriptionRichTextBox.Text) Then
                    Dim myList2 = (From r In db.Rates
                                   Where r.idRates = _idRates
                                   Select r.Descriptions, FromC = New Int32, idPresentacion = New Int32, PercentC = New Double)
                    petOwners = (From pp In db.ProductoPresentacion
                                 Join p In db.Productos On p.idProducto Equals pp.idProducto
                                 Join m In db.ProductoUndMedida On pp.idProUndMed Equals m.idProUndMed
                                 Group Join r In myList2 On pp.idPresentacion Equals r.idPresentacion
                                 Into PetList = Group
                                 From pet In PetList.DefaultIfEmpty()
                                 Select p.idProducto, p.Nom_Comercial, p.IdSubCategoria, pp.idPresentacion, pp.Presentacion,
                                      pp.Empaquetado, m.Nom_Medida, pp.precioCompra, pp.precioVenta,
                            Fromc =
                                 If(pet Is Nothing, 1, pet.FromC),
                            PercentC =
                                 If(pet Is Nothing, 0, pet.PercentC))

                    Me.DescriptionRichTextBox.Text = myList2.FirstOrDefault().Descriptions
                End If


                For Each item In petOwners
                    listProducto.Add(New ItemProducto(item.idProducto, item.IdSubCategoria, item.idPresentacion, item.Nom_Comercial,
                                                      item.Presentacion, item.Empaquetado, item.Nom_Medida, item.precioCompra, item.precioVenta,
                                                       item.Fromc, item.PercentC * 100))
                Next
                petOwners = Nothing
                A_Button.PerformClick()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemProducto
        Sub New(ByVal idProducto As Integer, ByVal idSubCategory As Integer, ByVal idPresentation As Integer,
                ByVal nom_Producto As String, ByVal PresentacionDescrip As String, ByVal empaquetad As Double,
                ByVal medida As String, ByVal precioCompra As Double, ByVal precioNorm As Double,
                ByVal fromC As Integer, ByVal percent As Double)
            _idProdcuto = idProducto
            _idSubCategory = idSubCategory
            _nomProducto = nom_Producto
            _from = fromC
            _percent = percent
            _idPresent = idPresentation
            _presentacionDesc = PresentacionDescrip
            _Nom_Medida = medida
            _empaquetado = empaquetad
            _precioCompra = precioCompra
            _precionormal = precioNorm
            _isUpdate = False
        End Sub
        Public Property PrecioTarifa() As Double
            Get
                Return (Me.PrecioNormal - Me.Descuento)
            End Get
            Set(value As Double)
            End Set
        End Property

        Public Property Rentabilidad() As Double
            Get
                If Me.PrecioTarifa > 0 Then
                    Return ((Me.PrecioTarifa - Me.PrecioCompra) / Me.PrecioCompra)
                Else
                    Return 0
                End If

            End Get
            Set(value As Double)
            End Set
        End Property
        Public Property Utilidad() As Double
            Get
                If Me.PrecioTarifa > 0 Then
                    Return (Me.PrecioTarifa - Me.PrecioCompra)
                Else
                    Return 0
                End If

            End Get
            Set(value As Double)
            End Set
        End Property

        Public Property Descuento() As Double
            Get
                Return (Me.PrecioNormal * Me.Percent) / 100
            End Get
            Set(value As Double)

            End Set
        End Property
        Private _precioCompra As Double
        Public Property PrecioCompra() As Double
            Get
                Return _precioCompra
            End Get
            Set(ByVal value As Double)
                _precioCompra = value
            End Set
        End Property
        Private _precionormal As Double
        Public Property PrecioNormal() As Double
            Get
                Return _precionormal
            End Get
            Set(ByVal value As Double)
                _precionormal = value
            End Set
        End Property
        Private _empaquetado As Double
        Public Property Empaquetado() As Double
            Get
                Return _empaquetado
            End Get
            Set(ByVal value As Double)
                _empaquetado = value
            End Set
        End Property
        Private _Nom_Medida As String
        Public Property Nom_Medida() As String
            Get
                Return _Nom_Medida
            End Get
            Set(ByVal value As String)
                _Nom_Medida = value
            End Set
        End Property

        Private _presentacionDesc As String
        Public Property PresentacionDesc() As String
            Get
                Return _presentacionDesc
            End Get
            Set(ByVal value As String)
                _presentacionDesc = value
            End Set
        End Property
        Private _idPresent As Integer
        Public Property IdPresentation() As Integer
            Get
                Return _idPresent
            End Get
            Set(ByVal value As Integer)
                _idPresent = value
            End Set
        End Property
        Private _idProdcuto As Integer
        Public Property IdProducto() As Integer
            Get
                Return _idProdcuto
            End Get
            Set(ByVal value As Integer)
                _idProdcuto = value
            End Set
        End Property
        Private _idSubCategory As Integer
        Public Property IdSubCategory() As Integer
            Get
                Return _idSubCategory
            End Get
            Set(ByVal value As Integer)
                _idSubCategory = value
            End Set
        End Property
        Private _nomProducto As String
        Public Property Nom_Producto() As String
            Get
                Return _nomProducto
            End Get
            Set(ByVal value As String)
                _nomProducto = value
            End Set
        End Property
        Private _from As Integer
        Public Property FromC() As Integer
            Get
                Return _from
            End Get
            Set(ByVal value As Integer)
                _from = value
            End Set
        End Property
        Private _percent As Double
        Public Property Percent() As Double
            Get
                Return _percent
            End Get
            Set(ByVal value As Double)
                _percent = value
            End Set
        End Property
        Private _isUpdate As Boolean
        Public Property IsUpdate() As Boolean
            Get
                Return _isUpdate
            End Get
            Set(ByVal value As Boolean)
                _isUpdate = value
            End Set
        End Property
    End Class

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If Validation() Then
            Select Case Operation
                Case stateOperation.Insert
                    If InsertRate_Producto() Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Case stateOperation.Update
                    If UpdateRate_Producto(Me.idRates) Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
            End Select

        End If
    End Sub

    Private Function UpdateRate_Producto(_idRates As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim rates = (From r In db.Rates
                                 Where r.idRates = _idRates).FirstOrDefault()

                    rates.Descriptions = DescriptionRichTextBox.Text
                    db.SubmitChanges()

                    Dim ratesDetail = (From r In db.RatesPresentantionDetail
                                       Where r.idRates = _idRates)
                    For Each item In ratesDetail
                        item.FromC = listProducto.Where(Function(x) x.IdPresentation = item.idPresentacion) _
                        .FirstOrDefault().FromC
                        item.PercentC = listProducto.Where(Function(x) x.IdPresentation = item.idPresentacion) _
                       .FirstOrDefault().Percent / 100
                        ' set set 
                        listProducto.Where(Function(x) x.IdPresentation = item.idPresentacion) _
                       .FirstOrDefault().IsUpdate = True
                    Next
                    db.SubmitChanges()
                    'insert the sub not foiunt
                    For Each item In listProducto.Where(Function(x) x.IsUpdate = False And x.Percent > 0)
                        Dim ratesSunDetail = New RatesPresentantionDetail With
                            {
                            .FromC = item.FromC,
                            .idRates = _idRates,
                            .idPresentacion = item.IdPresentation,
                            .PercentC = item.Percent / 100
                            }
                        db.RatesPresentantionDetail.InsertOnSubmit(ratesSunDetail)
                    Next
                    db.SubmitChanges()
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function InsertRate_Producto() As Boolean
        Try

            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try

                    Dim _rates As New Rates With {
                        .codUserRaise = UsuarioActivo.codUser,
                        .Descriptions = DescriptionRichTextBox.Text,
                        .Structure = Structura_Name
                       }
                    db.Rates.InsertOnSubmit(_rates)
                    db.SubmitChanges()

                    Me.idRates = _rates.idRates

                    For Each item As ItemProducto In listProducto.Where(Function(x) x.Percent > 0)
                        Dim _ratesDetail As New RatesPresentantionDetail With {
                       .FromC = item.FromC,
                       .idRates = _rates.idRates,
                       .idPresentacion = item.IdPresentation,
                       .PercentC = item.Percent / 100
                      }
                        db.RatesPresentantionDetail.InsertOnSubmit(_ratesDetail)
                    Next
                    db.SubmitChanges()
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Validation() As Boolean
        If String.IsNullOrEmpty(Me.DescriptionRichTextBox.Text) Then
            MsgBox("Ingrese la descripcion de la tarifa.", MsgBoxStyle.Exclamation, "Importante")
            DescriptionRichTextBox.Focus()
            Return False

        End If
        If listProducto.Count = 0 Then
            MsgBox("No existe estructura de la tarifa.", MsgBoxStyle.Exclamation, "Importante")
            dtg.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub DescriptionRichTextBox_Leave(sender As Object, e As EventArgs) Handles DescriptionRichTextBox.Leave
        Me.DescriptionRichTextBox.Text = Trim(DescriptionRichTextBox.Text)
    End Sub

    Private Sub dataGridView1_CellEndEdit(ByVal sender As Object,
        ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
        Handles dtg.CellEndEdit

        ' Clear the row error in case the user presses ESC.   
        dtg.Rows(e.RowIndex).ErrorText = String.Empty
        dtg.Refresh()
    End Sub
    Private Sub dataGridView1_CellValidating(ByVal sender As Object,
    ByVal e As DataGridViewCellValidatingEventArgs) _
    Handles dtg.CellValidating

        Dim headerText As String =
            dtg.Columns(e.ColumnIndex).Name

        ' Abort validation if cell is not in the CompanyName column.
        If Not (headerText.Equals("FromcClm") Or headerText.Equals("PercentClm")) Then Return
        Select Case headerText
            Case "FromcClm"
                ' Confirm that the cell is not empty.
                Dim value As String = e.FormattedValue.ToString()
                If IsNumeric(value) Then
                    If Not (Double.Parse(value) >= 1) Then
                        dtg.Rows(e.RowIndex).ErrorText =
                            "El valor debe ser mayor que cero"
                        e.Cancel = True
                    End If
                End If
            Case "PercentClm"
                Dim value As String = e.FormattedValue.ToString()
                If IsNumeric(value) Then
                    If (Double.Parse(value) > 100) Then
                        dtg.Rows(e.RowIndex).ErrorText =
                            "El porcentage máximo es 100%"
                        e.Cancel = True
                    ElseIf (Double.Parse(value) < 0) Then
                        dtg.Rows(e.RowIndex).ErrorText =
                            "El porcentage no puede ser negativo"
                        e.Cancel = True
                    End If
                End If
        End Select
    End Sub
    Private Sub dtg_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtg.DataError
        If e.Exception.Message.Contains("formato correcto") Then
            MsgBox("La celda acepta solo valores numéricos", MsgBoxStyle.Exclamation, "Error")
        ElseIf e.Exception.HResult = -2146233033 Then
            MsgBox("Debe ser números enteros", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub A_Button_Click(sender As Object, e As EventArgs) Handles A_Button.Click, B_Button.Click, C_Button.Click,
            D_Button.Click, E_Button.Click, F_Button.Click, G_Button.Click, H_Button.Click, I_Button.Click,
              J_Button.Click, K_Button.Click, L_Button.Click, M_Button.Click, N_Button.Click, NN_Button.Click,
        O_Button.Click, P_Button.Click, Q_Button.Click, R_Button.Click, S_Button.Click, T_Button.Click,
          U_Button.Click, V_Button.Click, W_Button.Click, X_Button.Click, Y_Button.Click, Z_Button.Click

        dtg.DataSource = Nothing
        Dim filter As String = sender.text
        For Each control As System.Windows.Forms.Control In HerraminetasPanel.Controls
            If control.Name = sender.name Then
                control.BackColor = Color.Blue
                control.ForeColor = Color.White
            Else
                control.BackColor = HerraminetasPanel.BackColor
                control.ForeColor = Color.Black
            End If
        Next
        LastNameProducto = String.Empty
        dtg.DataSource = listProducto.Where(Function(x) x.Nom_Producto.StartsWith(filter)) _
            .OrderBy(Function(x) x.Nom_Producto).ThenBy(Function(x) x.Empaquetado).ToList()
        Dim total As Double = dtg.RowCount
        Me.TotalLabel.Text = "Total en lista: " & total.ToString("N2")
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

    Private Sub FindTextBox_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox.TextChanged
        If FindTextBox.Text.Length > 2 Then
            findButton.Enabled = True
        Else
            findButton.Enabled = False
        End If
    End Sub
    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        dtg.DataSource = Nothing
        For Each Control In HerraminetasPanel.Controls
            Control.BackColor = HerraminetasPanel.BackColor
            Control.ForeColor = Color.Black
        Next
        dtg.DataSource = listProducto.Where(Function(x) x.Nom_Producto.ToUpper.Contains(FindTextBox.Text.ToUpper)) _
            .OrderBy(Function(x) x.Nom_Producto).ThenBy(Function(x) x.Empaquetado).ToList()
        Dim total As Double = dtg.RowCount
        Me.TotalLabel.Text = "Total en lista: " & total.ToString("N2")
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        isSave = False
        If Validation() Then
            Select Case Operation
                Case stateOperation.Insert
                    If InsertRate_Producto() Then
                        isSave = True
                        Operation = stateOperation.Update
                    End If
                Case stateOperation.Update
                    If UpdateRate_Producto(Me.idRates) Then
                        isSave = True
                    End If
            End Select
        End If
        If isSave Then
            MsgBox("Operación exitosa..", MsgBoxStyle.Information, "Aviso.")
        End If
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintAllButton.Click
        Try
            Dim grid As New DataGridView
            grid = Me.dtg
            grid.DataSource = Nothing
            grid.DataSource = listProducto.OrderBy(Function(x) x.Nom_Producto).ToList()

            Dim eCommerce As String
            Using db As New DataContext
                Dim myCommerce = db.myCommerce.ToList()
                eCommerce = myCommerce(0).RazonSocial
            End Using

            Dim printer As New DGVPrinter
            printer.Title = eCommerce

            Dim stado As String = "En modificación"
            If isSave Then
                stado = "Gurdado"
            End If
            Dim subtitle As String = vbCrLf & "Descripcion: " & DescriptionRichTextBox.Text & vbCrLf & vbCrLf
            subtitle = subtitle & "Estado: " & stado & vbCrLf & " "

            printer.SubTitle = "ESTRUCTURA DE LA TARIFA POR PRESENTACION."
            printer.SubTitleAlignment2 = StringAlignment.Near
            printer.SubTitle2 = subtitle
            printer.SubTitleFont2 = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            printer.TitleSpacing = 2
            printer.PageNumbers = True
            printer.PorportionalColumns = True
            printer.HeaderCellAlignment = StringAlignment.Near
            printer.Footer = String.Format("Impreso: {0} {1}      User: {2}", Date.Now.ToShortDateString, Date.Now.ToShortTimeString, UsuarioActivo.codUser)
            printer.FooterSpacing = 8
            printer.FooterAlignment = StringAlignment.Near
            printer.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            printer.PrintDataGridView(grid)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub dtg_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellValueChanged
        isSave = False
    End Sub

    Private Sub PrintListButton_Click(sender As Object, e As EventArgs) Handles PrintListButton.Click
        Try
            Dim eCommerce As String
            Using db As New DataContext
                Dim myCommerce = db.myCommerce.ToList()
                eCommerce = myCommerce(0).RazonSocial
            End Using

            Dim printer As New DGVPrinter
            printer.Title = eCommerce

            Dim stado As String = "En modificación"
            If isSave Then
                stado = "Gurdado"
            End If
            Dim subtitle As String = vbCrLf & "Descripcion: " & DescriptionRichTextBox.Text & vbCrLf & vbCrLf
            subtitle = subtitle & "Estado: " & stado & vbCrLf & " "

            printer.SubTitle = "ESTRUCTURA DE LA TARIFA POR PRESENTACION."
            printer.SubTitleAlignment2 = StringAlignment.Near
            printer.SubTitle2 = subtitle
            printer.SubTitleFont2 = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            printer.TitleSpacing = 2
            printer.PageNumbers = True
            printer.PorportionalColumns = True
            printer.HeaderCellAlignment = StringAlignment.Near
            printer.Footer = String.Format("Impreso: {0} {1}      User: {2}", Date.Now.ToShortDateString, Date.Now.ToShortTimeString, UsuarioActivo.codUser)
            printer.FooterSpacing = 8
            printer.FooterAlignment = StringAlignment.Near
            printer.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            printer.PrintDataGridView(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub dtg_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dtg.CellPainting
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If
            If e.RowIndex = 0 Then
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.OutsetDouble
            ElseIf e.ColumnIndex = 2 Then
                If dtg.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value = e.Value Then
                    e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single
                    e.CellStyle.ForeColor = e.CellStyle.BackColor
                Else
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.OutsetDouble
                    e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
                End If
            Else
                If (dtg.Rows(e.RowIndex - 1).Cells(2).Value = dtg.Rows(e.RowIndex).Cells(2).Value) Then
                    ' e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
                Else
                    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.OutsetDouble
                End If
            End If
            If e.ColumnIndex = PrecioTarifaClm.Index Or e.ColumnIndex = DescuentoClm.Index Then
                If dtg.Rows(e.RowIndex).Cells(PercentClm.Index).Value <= 0 Then
                    e.CellStyle.ForeColor = e.CellStyle.BackColor
                Else
                    e.CellStyle.ForeColor = Color.Black
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


End Class