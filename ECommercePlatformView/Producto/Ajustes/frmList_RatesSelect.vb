Imports System.Windows.Forms

Public Class frmList_RatesSelect
    Private isClosed As Boolean
    Protected Friend idRates As Integer
    Protected Friend Descriptios As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        isClosed = False
        If dtg.SelectedRows.Count = 1 Then
            idRates = dtg.SelectedRows(0).Cells("idRates").Value
            Me.Descriptios = dtg.SelectedRows(0).Cells("Descriptions").Value
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            isClosed = True
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        idRates = 0
        Descriptios = String.Empty
    End Sub

    Private Sub Load_Data()
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
            clm.Visible = False

            clm = dtg.Columns("DateStar")
            clm.Visible = False

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
            Me.Label1.Text = String.Format("Listado de tarifas disponibles: ({0})", total.ToString("N0"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmList_RatesSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If dtg.SelectedRows.Count > 0 Then
            e.Cancel = isClosed
        End If
    End Sub

    Private Sub dtg_KeyDown(sender As Object, e As KeyEventArgs) Handles dtg.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            OK_Button.PerformClick()
        End If
    End Sub

    Private Sub dtg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellDoubleClick
        idRates = dtg.Rows(e.RowIndex).Cells("idRates").Value
        Me.Descriptios = dtg.Rows(e.RowIndex).Cells("Descriptions").Value
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
