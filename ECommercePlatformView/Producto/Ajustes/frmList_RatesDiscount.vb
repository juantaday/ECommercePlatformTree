Imports CADsisVenta

Public Class frmList_RatesDiscount
    Private Sub AddNewListButton_MouseDown(sender As Object, e As MouseEventArgs) Handles AddNewListButton.MouseDown

        If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
            Dim Menu As ContextMenuStrip = Me.ContextMenuAdd_new()
            Menu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Try
            Using frmCategory As New frmCategoryRates(0, stateOperation.Insert)
                With frmCategory
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Datos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmList_RatesDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub
    Private Sub Carga_Datos()
        Try
            Using db As New DataContext
                Dim ListRates As New List(Of RatesCollecction)

                For Each item In db.Rates
                    ListRates.Add(New RatesCollecction(item))
                Next
                dtg.DataSource = ListRates.ToList()
            End Using
            applyGridTheme(dtg)
            clm = dtg.Columns("idRates")
            clm.HeaderText = "Código"

            clm = dtg.Columns("Descriptions")
            clm.HeaderText = "Descripcion" 'DateStar

            clm = dtg.Columns("codUserRaise")
            clm.HeaderText = "Creó"

            clm = dtg.Columns("DateStar")
            clm.HeaderText = "Fecha de creación"

            clm = dtg.Columns("Structure")
            clm.HeaderText = "Estructurado por:"
            clm.DisplayIndex = 2


            clm = dtg.Columns("TypeRate")
            clm.HeaderText = "TypeRate"
            clm.Visible = False

            clm = dtg.Columns("DescriptionType")
            clm.HeaderText = "Typo de tarifa:"
            clm.DisplayIndex = 1


            Dim total As Double = dtg.RowCount
            Me.TotalItemLabel.Text = "Total en lista: " & total.ToString("N")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub EditRatesButton_Click(sender As Object, e As EventArgs) Handles EditRatesButton.Click
        Try
            If Not dtg.SelectedRows.Count = 1 Then
                MsgBox("Seelccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            Dim idRates As Integer = dtg.SelectedRows(0).Cells(dtg.Columns("idRates").Index).Value

            Select Case dtg.SelectedRows(0).Cells(dtg.Columns("Structure").Index).Value
                Case "Categoría"
                    Using RatesCategoty As New frmCategoryRates(idRates, stateOperation.Update)
                        With RatesCategoty
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                Carga_Datos()
                                GoTo FinTheRow
                            End If
                        End With
                    End Using
                Case "Sub Categoría"
                    Using RatesCategoty As New frmSubCategoryRates(idRates, stateOperation.Update)
                        With RatesCategoty
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                Carga_Datos()
                                GoTo FinTheRow
                            End If
                        End With
                    End Using
                Case "Producto"
                    Using RatesCategoty As New frmProductoRates(idRates, stateOperation.Update)
                        With RatesCategoty
                            .WindowState = FormWindowState.Maximized
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then

                            End If
                            Carga_Datos()
                            GoTo FinTheRow
                        End With
                    End Using

                Case "Presentacion"
                    Using RatesCategoty As New frmPresentRates(idRates, stateOperation.Update)
                        With RatesCategoty
                            .WindowState = FormWindowState.Maximized
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then

                            End If
                            Carga_Datos()
                            GoTo FinTheRow
                        End With
                    End Using
            End Select
            Return

FinTheRow:
            For i = 0 To dtg.RowCount - 1
                If dtg.Rows(i).Cells("idRates").Value = idRates Then
                    dtg.Rows(i).Selected = True
                Else
                    dtg.Rows(i).Selected = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteTaresButton_Click(sender As Object, e As EventArgs) Handles DeleteTaresButton.Click
        If Not dtg.SelectedRows.Count = 1 Then
            MsgBox("Seelccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        If MsgBox(msgDelete, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda.") = MsgBoxResult.Yes Then
            If Delete_Rates(Integer.Parse(dtg.SelectedRows(0).Cells("idRates").Value)) Then
                Carga_Datos()
            End If
        End If
    End Sub

    Private Function Delete_Rates(id As Integer) As Boolean
        Try

            Using db As New DataContext
                Dim _rate = (From r In db.Rates Where r.idRates = id).FirstOrDefault()
                db.Rates.DeleteOnSubmit(_rate)
                db.SubmitChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub SubCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoryToolStripMenuItem.Click
        Try
            Using frmCategory As New frmSubCategoryRates(0, stateOperation.Insert)
                With frmCategory
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Datos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Try
            Using frmCategory As New frmProductoRates(0, stateOperation.Insert)
                With frmCategory
                    .StartPosition = FormStartPosition.CenterScreen
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Datos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

    End Sub

    Private Sub PresentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentToolStripMenuItem.Click
        Try
            Using frmCategory As New frmPresentRates(0, stateOperation.Insert)
                With frmCategory
                    .StartPosition = FormStartPosition.CenterScreen
                    .WindowState = FormWindowState.Maximized
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Datos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
    Private Sub EditTypeButton_Click(sender As Object, e As EventArgs) Handles EditTypeButton.Click
        Try
            If Not dtg.SelectedRows.Count = 1 Then
                MsgBox("Seelccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Dim idRates As Integer = dtg.SelectedRows(0).Cells(dtg.Columns("idRates").Index).Value

            Using selectOperation As New frmSelectTypeRates(dtg.SelectedRows(0).Cells(dtg.Columns("TypeRate").Index).Value, idRates)
                With selectOperation
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Datos()
                        GoTo FinTheRow
                    End If
                End With
            End Using
            Return
FinTheRow:
            For i = 0 To dtg.RowCount - 1
                If dtg.Rows(i).Cells("idRates").Value = idRates Then
                    dtg.Rows(i).Selected = True
                Else
                    dtg.Rows(i).Selected = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carga_Datos()
    End Sub
End Class