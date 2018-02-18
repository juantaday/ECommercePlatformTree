Public Class frmIvaDialog
    Protected Friend ivaPorcentaje As Double
    Private Sub ApliTodoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApliTodoButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If ivaNumericUpDow.Value <= 0 Then
                sql = "Imposible realizar este cambio " + vbNewLine
                sql = "Consulte a su proveedor del sistema"
                MsgBox(sql, MsgBoxStyle.Critical, "Importante..")
                Return
            End If
            If CambiaIvaTodos(ivaNumericUpDow.Value / 100) Then
                Me.ivaPorcentaje = ivaNumericUpDow.Value / 100
                DialogResult = DialogResult.OK
                Close()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub frmIvaDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ivaPorcentaje = CargaIva()
        Me.ivaNumericUpDow.Value = Me.ivaPorcentaje * 100
    End Sub
    Private Sub AplicUnoButton_Click(sender As Object, e As EventArgs) Handles AplicUnoButton.Click
        Me.ivaPorcentaje = ivaNumericUpDow.Value / 100
        DialogResult = DialogResult.OK
        Close()
    End Sub
End Class
