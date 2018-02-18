Imports System.Windows.Forms
Imports CADsisVenta

Public Class frmSubCategoryRates
    Private idRates As Integer
    Private Operation As stateOperation
    Private latestValue As Double
    Private listCategory As List(Of ItemCategory)
    Private isLoad As Boolean
    Private Const Structura_Name As String = "Sub Categoría"
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
        listCategory = New List(Of ItemCategory)
        PersonalizeGridView()
        Loade_Category()
        Select Case Operation
            Case stateOperation.Insert
                Loade_ListSubCategory()
            Case stateOperation.Update
                Loade_ListSubCategory(Me.idRates)
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
    Private Sub Loade_ListSubCategory()
        Try
            Using db As New DataContext
                Dim subCategory = From c In db.ProductoSubCategoria
                For Each item In subCategory
                    listCategory.Add(New ItemCategory(item.idCategoria, item.idSubCategoria, item.Nom_SubCategoria, 1, 0))
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_Category()
        Try
            Using db As New DataContext
                Dim category = From c In db.ProductoCategoria

                Me.TreeView1.Nodes.Add("Categorías")
                For Each item In category
                    Dim tvRoot As TreeNode
                    Dim tvNode As New TreeNode

                    tvNode.Tag = item.idCategoria
                    tvNode.Text = item.Nom_Categoria

                    tvRoot = Me.TreeView1.Nodes.Item(0)
                    tvRoot.Nodes.Add(tvNode)
                    tvNode.Checked = True
                Next
            End Using

            For Each nodes As TreeNode In TreeView1.Nodes
                nodes.Expand()
            Next
            dtg.DataSource = listCategory
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_ListSubCategory(_idRates As Integer)
        Try
            Using db As New DataContext

                Dim myList = (From r In db.Rates
                              Join d In db.RatesSubCategoryDetail On r.idRates Equals d.idRates
                              Select r.Descriptions, d.FromC, d.idSubCategory, d.PercentC)
                Me.DescriptionRichTextBox.Text = myList.FirstOrDefault().Descriptions

                Dim petOwners = (From pc In db.ProductoSubCategoria
                                 Group Join r In myList On pc.idSubCategoria Equals r.idSubCategory
                                 Into PetList = Group
                                 From pet In PetList.DefaultIfEmpty()
                                 Select pc.idCategoria, pc.Nom_SubCategoria, pc.idSubCategoria,
                            Fromc =
                                 If(pet Is Nothing, 1, pet.FromC),
                            PercentC =
                                 If(pet Is Nothing, 0, pet.PercentC))
                For Each item In petOwners
                    listCategory.Add(New ItemCategory(item.idCategoria, item.idSubCategoria, item.Nom_SubCategoria, item.Fromc, item.PercentC * 100))
                Next
                petOwners = Nothing
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemCategory
        Sub New(ByVal idCategory As Integer, ByVal idSubCategory As Integer,
                ByVal nom_SubCategory As String, ByVal fromC As Integer, ByVal percent As Double)
            _idCategory = idCategory
            _idSubCategory = idSubCategory
            _nomSubCategory = nom_SubCategory
            _from = fromC
            _percent = percent
            _isUpdate = False
        End Sub
        Private _idCategory As Integer
        Public Property IdCategory() As Integer
            Get
                Return _idCategory
            End Get
            Set(ByVal value As Integer)
                _idCategory = value
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
        Private _nomSubCategory As String
        Public Property Nom_Category() As String
            Get
                Return _nomSubCategory
            End Get
            Set(ByVal value As String)
                _nomSubCategory = value
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
                    If InsertRate_SubCategory() Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Case stateOperation.Update
                    If UpdateRate_SubCategory(Me.idRates) Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
            End Select

        End If
    End Sub

    Private Function UpdateRate_SubCategory(_idRates As Integer) As Boolean
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

                    Dim ratesDetail = (From r In db.RatesSubCategoryDetail
                                       Where r.idRates = _idRates)
                    Dim _percent As Double = 0

                    For Each item In ratesDetail
                        _percent = listCategory.Where(Function(x) x.IdSubCategory = item.idSubCategory) _
                          .FirstOrDefault().Percent
                        If _percent > 0 Then
                            item.FromC = listCategory.Where(Function(x) x.IdSubCategory = item.idSubCategory) _
                                 .FirstOrDefault().FromC
                            item.PercentC = _percent / 100
                        Else
                            db.RatesSubCategoryDetail.DeleteOnSubmit(item)
                        End If
                        ' set set 
                        listCategory.Where(Function(x) x.IdSubCategory = item.idSubCategory) _
                       .FirstOrDefault().IsUpdate = True
                    Next
                    db.SubmitChanges()
                    'insert the sub not foiunt
                    For Each item In listCategory.Where(Function(x) x.IsUpdate = False And x.Percent > 0)
                        Dim ratesSunDetail = New RatesSubCategoryDetail With
                            {
                            .FromC = item.FromC,
                            .idRates = _idRates,
                            .idSubCategory = item.IdSubCategory,
                            .PercentC = item.Percent / 100
                            }
                        db.RatesSubCategoryDetail.InsertOnSubmit(ratesSunDetail)
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

    Private Function InsertRate_SubCategory() As Boolean
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

                    For Each item As ItemCategory In listCategory
                        Dim _ratesDetail As New RatesSubCategoryDetail With {
                       .FromC = item.FromC,
                       .idRates = _rates.idRates,
                       .idSubCategory = item.IdSubCategory,
                       .PercentC = item.Percent / 100
                      }
                        db.RatesSubCategoryDetail.InsertOnSubmit(_ratesDetail)
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
        If listCategory.Count = 0 Then
            MsgBox("No existe estructura de la tarifa.", MsgBoxStyle.Exclamation, "Importante")
            dtg.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim node As TreeNode = TreeView1.SelectedNode
        If Not IsNothing(node) Then
            If Not IsNothing(node.Tag) Then
                Carga_SubCategory(Integer.Parse(node.Tag))
                detalleLabel.Text = "Detalle de la categoría: " & node.Text
            Else
                detalleLabel.Text = String.Empty
                dtg.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub Carga_SubCategory(id As Integer)
        Try
            dtg.DataSource = Nothing
            If listCategory.Count = 0 Then
                Return
            End If
            dtg.DataSource = listCategory.Where(Function(x) x.IdCategory = id).ToList()
            Dim total As Double = dtg.RowCount
            Me.totalSunCategoriaLabel.Text = "Total sub categoría: " & total.ToString("N0")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
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
End Class
