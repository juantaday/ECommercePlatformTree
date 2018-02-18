Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Windows.Controls
Imports System.Windows.Media.Imaging
Imports CADsisVenta.DataSetMonedasTableAdapters

Public Class MoneyDetail
    Private TotalLabel As System.Windows.Forms.Label
    Private RealizedMenu As System.Windows.Forms.ToolStripMenuItem
    Private DeleteMenu As System.Windows.Forms.ToolStripMenuItem
    Private EditMenu As System.Windows.Forms.ToolStripMenuItem

    Public Sub New(RealizedMenu As ToolStripMenuItem,
                   DeleteMenu As ToolStripMenuItem,
                   EditMenu As ToolStripMenuItem,
                   TotalLabel As System.Windows.Forms.Label,
                   idMoney As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.CargaView(idMoney, True)
        Me.CargaView(idMoney, False)

        Me.RealizedMenu = RealizedMenu
        Me.DeleteMenu = DeleteMenu
        Me.EditMenu = EditMenu
        Me.TotalLabel = TotalLabel
    End Sub
    Private Sub CargaView(idmoneda As Integer, typoMoney As Boolean)
        Dim tapt As New MonedaDetailTableAdapter
        Dim dtMoneda As New DataTable
        Dim listMoney = New System.Collections.ObjectModel.ObservableCollection(Of MoneyList)
        Try
            dtMoneda = tapt.GetData(idmoneda, typoMoney)
            Dim dataView As New DataView(dtMoneda)
            dataView.Sort = "Value_Moneda"

            dtMoneda = dataView.ToTable()

            Dim mBit As New BitmapImage()
            For i = 0 To dtMoneda.Rows.Count - 1
                Dim img() As Byte = Nothing
                If IsArray(dtMoneda(i)("imageMoney")) Then
                    img = dtMoneda(i)("imageMoney")
                End If
                Dim ms As New MemoryStream(img)
                mBit = New BitmapImage
                mBit.BeginInit()
                mBit.StreamSource = ms
                mBit.EndInit()
                Dim item As New MoneyList(dtMoneda.Rows(i)("idMonedaDeatil"),
                                          dtMoneda.Rows(i)("Moneda"),
                                          dtMoneda.Rows(i)("Value_Moneda"),
                                          0, False, False,
                                          mBit)
                listMoney.Add(item)
            Next
            If Not IsNothing(dtMoneda) And typoMoney Then
                listViewMoneda.ItemsSource = listMoney
            ElseIf Not IsNothing(dtMoneda) Then
                listViewVillete.ItemsSource = listMoney
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
        End Try
    End Sub
    Private Sub Sum()
        Try
            Dim total As Double = 0
            For Each item As MoneyList In listViewMoneda.Items

                total += item.Quantity
            Next

            For Each item As MoneyList In listViewVillete.Items
                total += item.Quantity
            Next
            Me.TotalLabel.Text = total.ToString("C2")
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub QuantityEntry_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs)
        sender.SelectAll()
    End Sub

    Private Sub QuantityEntry_GotMouseCapture(sender As Object, e As System.Windows.Input.MouseEventArgs)
        sender.SelectAll()
    End Sub

    Private Sub QuantityEntry_TextChanged_Moneda(sender As Object, e As TextChangedEventArgs)
        Try
            If Not IsNumeric(sender.text) Then
                sender.text = 0
                Return
            End If

            Dim entry As Double = DirectCast(sender, TextBox).Text
            Dim stackPanel As StackPanel
            Dim stackPaneMaster As StackPanel

            stackPanel = DirectCast(sender, TextBox).Parent
            stackPaneMaster = stackPanel.Parent

            Dim idMonedaDeatil As Integer = 0
            For Each control In stackPaneMaster.Children
                If control.Name.Equals("idMonedaDeatil") Then
                    idMonedaDeatil = control.Text
                    Exit For
                End If
            Next

            For Each item As MoneyList In listViewMoneda.Items
                If item.IdMonedaDetail = idMonedaDeatil Then
                    item.Quantity = item.Value_Moneda * entry
                    Exit For
                End If
            Next
            Sum()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub QuantityEntry_TextChanged_Villete(sender As Object, e As TextChangedEventArgs)
        Try
            If Not IsNumeric(sender.text) Then
                sender.text = 0
                Return
            End If

            Dim entry As Double = DirectCast(sender, TextBox).Text
            Dim stackPanel As StackPanel
            Dim stackPaneMaster As StackPanel

            stackPanel = DirectCast(sender, TextBox).Parent
            stackPaneMaster = stackPanel.Parent

            Dim idMonedaDeatil As Integer = 0
            For Each control In stackPaneMaster.Children
                If control.Name.Equals("idMonedaDeatil") Then
                    idMonedaDeatil = control.Text
                    Exit For
                End If
            Next

            For Each item As MoneyList In listViewVillete.Items
                If item.IdMonedaDetail = idMonedaDeatil Then
                    item.Quantity = item.Value_Moneda * entry
                    Exit For
                End If
            Next
            Sum()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub CheckBoxIsChecken_Checked(sender As Object, e As System.Windows.RoutedEventArgs)
        Dim state As Boolean = DirectCast(sender, CheckBox).IsChecked
        If Me.EditMenu.Tag = 1 Then
            ActivaMenuEdit(DirectCast(sender, CheckBox).Tag, state)
        Else
            ActivaMenuDelete(state)
        End If
    End Sub
    Public Sub ActivaMenuDelete(state As Boolean)
        Try
            If state Then
                Me.RealizedMenu.Image = Global.ECommercePlatformView.My.Resources.checkbox_checked_16
                Me.RealizedMenu.Tag = 0
                DeleteMenu.Visible = True
            Else
                If Me.IsCheckenBox() Then
                    RealizedMenu.Image = My.Resources.checkbox_checked_16
                    RealizedMenu.Tag = 0
                    DeleteMenu.Visible = True
                Else
                    RealizedMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.checkbox_notChecked_16
                    RealizedMenu.Tag = 1
                    DeleteMenu.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub ActivaMenuEdit(idMoneyDetail As Integer, state As Boolean)
        Try
            EditMenu.Visible = state
            If state Then
                Dim listMoney = New ObservableCollection(Of MoneyList)

                For Each money As MoneyList In listViewMoneda.Items
                    If Not money.IdMonedaDetail = idMoneyDetail Then
                        money.IsChecken = False
                    End If
                    listMoney.Add(money)
                Next
                listViewMoneda.ItemsSource = listMoney

                listMoney = New ObservableCollection(Of MoneyList)
                For Each money As MoneyList In listViewVillete.Items
                    If Not money.IdMonedaDetail = idMoneyDetail Then
                        money.IsChecken = False
                    End If
                    listMoney.Add(money)
                Next
                listViewVillete.ItemsSource = listMoney
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function IsCheckenBox() As Boolean
        Try
            For Each money As MoneyList In listViewMoneda.Items
                If money.IsChecken Then
                    Return True
                End If
            Next
            For Each money As MoneyList In listViewVillete.Items
                If money.IsChecken Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class
