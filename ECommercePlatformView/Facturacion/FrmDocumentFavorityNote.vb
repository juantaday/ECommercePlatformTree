Imports System.Windows.Forms

Public Class FrmDocumentFavorityNote

    Private idFacturVenta As Integer
    Private ValTotal As Double
    Protected Friend _DocumentFavorite As DocumentFavorite

    Public Sub New(item As DocumentFavorite)
        InitializeComponent()
        Me._DocumentFavorite = item
        Me.txtnote.Text = item.note
    End Sub

    Public Sub New(idFact As Integer, valtotal As Double)
        InitializeComponent()
        Me.idFacturVenta = idFact
        Me.ValTotal = valtotal
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.txtnote.Text.Trim().Length > 5 Then

            ErrorProvider1.SetError(txtnote, "")
            Try
                Using db As New DataContext
                    If Me._DocumentFavorite Is Nothing Then
                        Dim _newdara As New DocumentFavorite With {
                                  .idFactVenta = Me.idFacturVenta,
                                  .total = Me.ValTotal,
                                  .note = Me.txtnote.Text.Trim()
                              }
                        db.DocumentFavorite.InsertOnSubmit(_newdara)
                    Else
                        Dim documentFavo = db.DocumentFavorite _
                           .Where(Function(x) x.id = _DocumentFavorite.id).FirstOrDefault()

                        If Not documentFavo Is Nothing Then
                            documentFavo.note = txtnote.Text
                            _DocumentFavorite.note = documentFavo.note
                        End If
                    End If

                    db.SubmitChanges()
                End Using
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            ErrorProvider1.SetError(txtnote, "Ingrese una descripcion entendible")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmDocumentFavorityNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
