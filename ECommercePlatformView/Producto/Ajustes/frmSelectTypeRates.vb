Imports System.Windows.Forms

Public Class frmSelectTypeRates
    Private StateOperatio As Boolean
    Private IdRates As Integer
    Private isClosed As Boolean

    Public Sub New(ByVal operation As Boolean, ByVal _idrates As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        StateOperatio = operation
        Me.IdRates = _idrates

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            isClosed = True
            Using db As New DataContext
                Dim _rates = (From r In db.Rates Where r.idRates = Me.IdRates).FirstOrDefault()
                If StalkerButton.Checked Then
                    _rates.TypeRate = 1
                ElseIf Me.RatesRadioButton.Checked Then
                    _rates.TypeRate = 0
                End If
                db.SubmitChanges()
            End Using
            isClosed = False
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            isClosed = False
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmSelectTypeRates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setData()
    End Sub
    Private Sub setData()
        If StateOperatio Then
            StalkerButton.Checked = True
        Else
            RatesRadioButton.Checked = True
        End If
    End Sub

    Private Sub frmSelectTypeRates_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = isClosed
    End Sub
End Class
