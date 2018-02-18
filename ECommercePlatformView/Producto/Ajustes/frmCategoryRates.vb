Imports System.Windows.Forms
Imports CADsisVenta

Public Class frmCategoryRates
    Private idRates As Integer
    Private Operation As stateOperation
    Private latestValue As Double
    Private listCategory As List(Of ItemCategory)
    Private isLoad As Boolean
    Private Const Structura_Name As String = "Categoría"
    Sub New(ByVal _idRates As Integer, ByVal operation As stateOperation)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idRates = _idRates
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
        Select Case Operation
            Case stateOperation.Insert
                Loade_Category()
            Case stateOperation.Update
                Loade_Category(Me.idRates)
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

    Private Sub Loade_Category()
        Try
            Using db As New DataContext
                Dim category = From cd In db.ProductoCategoria
                For Each item In category
                    listCategory.Add(New ItemCategory(item.idCategoria, item.Nom_Categoria, 1, 0))
                Next
            End Using
            dtg.DataSource = listCategory
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Loade_Category(_idRates As Integer)
        Try
            Using db As New DataContext
                Dim _rates = (From r In db.Rates
                              Join d In db.RatesCategoryDetail On r.idRates Equals d.idRates
                              Where r.idRates = _idRates
                              Select r.Descriptions, d.idCategory, d.FromC, d.PercentC)

                Me.DescriptionRichTextBox.Text = _rates.FirstOrDefault().Descriptions

                Dim category = (From p In db.ProductoCategoria
                                Group Join r In _rates On r.idCategory Equals p.idCategoria
                                Into PetList = Group
                                From pet In PetList.DefaultIfEmpty()
                                Select p.idCategoria, p.Nom_Categoria,
                            Fromc =
                                 If(pet Is Nothing, 1, pet.FromC),
                            PercentC =
                                 If(pet Is Nothing, 0, pet.PercentC))

                For Each item In category
                    listCategory.Add(New ItemCategory(item.idCategoria, item.Nom_Categoria, item.Fromc, item.PercentC * 100))
                Next
                dtg.DataSource = listCategory
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemCategory
        Sub New(ByVal idCategory As Integer, ByVal nom_Category As String, ByVal fromC As Integer, ByVal percent As Double)
            _idCategory = idCategory
            _nomCategory = nom_Category
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
        Private _nomCategory As String
        Public Property Nom_Category() As String
            Get
                Return _nomCategory
            End Get
            Set(ByVal value As String)
                _nomCategory = value
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
    Private Sub dtg_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dtg.DataError
        If e.Exception.Message.Contains("formato correcto") Then
            MsgBox("La celda acepta solo valores numéricos", MsgBoxStyle.Exclamation, "Error")
        ElseIf e.Exception.HResult = -2146233033 Then
            MsgBox("Debe ser números enteros", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox(e.Exception.Message, MsgBoxStyle.Critical, "Error")
        End If
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

    Private Sub dataGridView1_CellEndEdit(ByVal sender As Object,
        ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
        Handles dtg.CellEndEdit

        ' Clear the row error in case the user presses ESC.   
        dtg.Rows(e.RowIndex).ErrorText = String.Empty

    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If Validation() Then
            Select Case Operation
                Case stateOperation.Insert
                    If InsertRate_Category() Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Case stateOperation.Update
                    If UpdateRate_Category(Me.idRates) Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
            End Select
        End If
    End Sub

    Private Function UpdateRate_Category(_idRates As Integer) As Boolean
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

                    Dim categories = From c In db.RatesCategoryDetail
                                     Where c.idRates = _idRates

                    For Each item In categories
                        item.FromC = listCategory.Where(Function(x) x.IdCategory = item.idCategory).FirstOrDefault.FromC
                        item.PercentC = listCategory.Where(Function(x) x.IdCategory = item.idCategory).FirstOrDefault.Percent / 100
                        listCategory.Where(Function(x) x.IdCategory = item.idCategory).FirstOrDefault.IsUpdate = True
                    Next
                    For Each item In listCategory.Where(Function(x) x.IsUpdate = False)
                        Dim subCategory As New RatesCategoryDetail With
                            {
                            .FromC = item.FromC,
                            .idCategory = item.IdCategory,
                            .idRates = _idRates,
                            .PercentC = item.Percent / 100
                        }
                        db.RatesCategoryDetail.InsertOnSubmit(subCategory)
                    Next
                    db.SubmitChanges()
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
        End Try
    End Function

    Private Function InsertRate_Category() As Boolean
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
                        Dim _ratesDetail As New RatesCategoryDetail With {
                       .FromC = item.FromC,
                       .idRates = _rates.idRates,
                       .idCategory = item.IdCategory,
                       .PercentC = item.Percent / 100
                      }
                        db.RatesCategoryDetail.InsertOnSubmit(_ratesDetail)
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

    Private Sub DescriptionRichTextBox_Leave(sender As Object, e As EventArgs) Handles DescriptionRichTextBox.Leave
        Me.DescriptionRichTextBox.Text = Trim(DescriptionRichTextBox.Text)
    End Sub
End Class
