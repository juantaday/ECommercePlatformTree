Imports System.Windows.Forms
Imports CADsisVenta
Imports DGVPrinterHelper

Public Class frmProductoRates
    Private idRates As Integer
    Private Operation As stateOperation
    Private latestValue As Double
    Private listProducto As List(Of ItemProducto)
    Private isLoad As Boolean
    Private isSave As Boolean
    Private Const Structura_Name As String = "Producto"
    Sub New(ByVal idRates As Integer, ByVal operation As stateOperation)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idRates = idRates
        Me.Operation = operation
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

            dtg.SelectionMode = DataGridViewSelectionMode.CellSelect
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_ListProductos()
        Try
            Using db As New DataContext
                Dim subCategory = From c In db.Productos
                For Each item In subCategory
                    listProducto.Add(New ItemProducto(item.idProducto, item.IdSubCategoria, item.Nom_Comercial, 1, 0))
                Next
                A_Button.PerformClick()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_ListProductos(_idRates As Integer)
        Try
            Using db As New DataContext

                Dim myList = (From r In db.Rates
                              Join d In db.RatesProductoDetail On r.idRates Equals d.idRates
                              Where r.idRates = _idRates
                              Select r.Descriptions, d.FromC, d.idProducto, d.PercentC)

                Me.DescriptionRichTextBox.Text = myList.FirstOrDefault().Descriptions

                Dim petOwners = (From pc In db.Productos
                                 Group Join r In myList On pc.idProducto Equals r.idProducto
                                 Into PetList = Group
                                 From pet In PetList.DefaultIfEmpty()
                                 Select pc.idProducto, pc.Nom_Comercial, pc.IdSubCategoria,
                            Fromc =
                                 If(pet Is Nothing, 1, pet.FromC),
                            PercentC =
                                 If(pet Is Nothing, 0, pet.PercentC))
                For Each item In petOwners
                    listProducto.Add(New ItemProducto(item.idProducto, item.IdSubCategoria, item.Nom_Comercial, item.Fromc, item.PercentC * 100))
                Next
                petOwners = Nothing
                A_Button.PerformClick()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemProducto
        Sub New(ByVal idProducto As Integer, ByVal idSubCategory As Integer,
                ByVal nom_Producto As String, ByVal fromC As Integer, ByVal percent As Double)
            _idProdcuto = idProducto
            _idSubCategory = idSubCategory
            _nomProducto = nom_Producto
            _from = fromC
            _percent = percent
            _isUpdate = False
        End Sub
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

                    Dim ratesDetail = (From r In db.RatesProductoDetail
                                       Where r.idRates = _idRates)
                    Dim _percent As Double = 0
                    For Each item In ratesDetail
                        _percent = listProducto.Where(Function(x) x.IdProducto = item.idProducto) _
                                   .FirstOrDefault().Percent
                        If _percent > 0 Then
                            item.FromC = listProducto.Where(Function(x) x.IdProducto = item.idProducto) _
                        .FirstOrDefault().FromC
                            item.PercentC = _percent / 100
                        Else
                            db.RatesProductoDetail.DeleteOnSubmit(item)
                        End If

                        ' set set 
                        listProducto.Where(Function(x) x.IdProducto = item.idProducto) _
                       .FirstOrDefault().IsUpdate = True
                    Next
                    db.SubmitChanges()
                    'insert the sub not foiunt
                    For Each item In listProducto.Where(Function(x) x.IsUpdate = False And x.Percent > 0)
                        Dim ratesSunDetail = New RatesProductoDetail With
                            {
                            .FromC = item.FromC,
                            .idRates = _idRates,
                            .idProducto = item.IdProducto,
                            .PercentC = item.Percent / 100
                            }
                        db.RatesProductoDetail.InsertOnSubmit(ratesSunDetail)
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

                    For Each item As ItemProducto In listProducto
                        Dim _ratesDetail As New RatesProductoDetail With {
                       .FromC = item.FromC,
                       .idRates = _rates.idRates,
                       .idProducto = item.IdProducto,
                       .PercentC = item.Percent / 100
                      }
                        db.RatesProductoDetail.InsertOnSubmit(_ratesDetail)
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
        dtg.DataSource = listProducto.Where(Function(x) x.Nom_Producto.StartsWith(filter)) _
            .OrderBy(Function(x) x.Nom_Producto).ToList()
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
            .OrderBy(Function(x) x.Nom_Producto).ToList()
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

            printer.SubTitle = "ESTRUCTURA DE LA TARIFA POR PRODUCTO."
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

            printer.SubTitle = "ESTRUCTURA DE LA TARIFA POR PRODUCTO."
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
            printer.PrintDataGridView(dtg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


End Class
