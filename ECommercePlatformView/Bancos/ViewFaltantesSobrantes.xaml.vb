Imports System.Collections.ObjectModel
Public Class ViewFaltantesSobrantes
    Private selectedItems As ItemCajaStado
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Dim list As New ObservableCollection(Of ItemCajaStado)

        Using db As New DataContext
            Dim Mysobrantes = (From c In db.CajaStado
                               Join t In db.Terminal On c.idTerminal Equals t.idTerminal
                               Join b In db.Bodegas On b.idBodega Equals t.idBodega
                               Order By c.idCajaStado Descending
                               Where c.Qntt_difference <> 0
                               Select New With {c, b.Nom_Bodega, t.codTerminal}).Take(20)

            For Each item In Mysobrantes
                list.Add(New ItemCajaStado(item.c, item.Nom_Bodega, item.codTerminal))
            Next
        End Using
        Me.listViewMoneda.ItemsSource = list
    End Sub
    Private Sub listViewMoneda_SelectionChanged(sender As Object, e As System.Windows.Controls.SelectionChangedEventArgs)
        Try

            selectedItems = e.AddedItems.Item(0)
            ' MsgBox(selectedItems.Qntt_difference.ToString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub TextBlock_MouseDown(sender As Object, e As System.Windows.Input.MouseButtonEventArgs)
        'print text
        sql = sender.tag.ToString
        MsgBox("Disponible en la proxima version...", MsgBoxStyle.Exclamation, "Ups..")
    End Sub

    Private Sub TextBlock_MouseDown_1(sender As Object, e As System.Windows.Input.MouseButtonEventArgs)
        'ver detalle
        sql = sender.tag.ToString
        MsgBox("Disponible en la proxima version...", MsgBoxStyle.Exclamation, "Ups..")
    End Sub
End Class
