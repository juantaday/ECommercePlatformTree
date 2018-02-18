Imports System.ComponentModel
Imports System.Windows.Data
Imports ECommercePlatformView.DebitEmployeeNameSpace
Imports System.Windows.Input
Public Class ItemBebitEmployee
    Private TotalDebt As Double
    Private IdPerson As Integer
    Private IdCliente As Integer
    Private FullNamePeople As String
    Private MyParent As frmList_EmployeeDebit
    Private _tasks As DebitEmployeeCollection

    Public Sub New(ByVal _idPerson As Integer, ByVal _MyParent As frmList_EmployeeDebit)
        InitializeComponent()
        Try
            ' Get a reference to the tasks collection.
            IdPerson = _idPerson
            _tasks = Me.Resources("tasks")

            TotalDebt = 0
            MyParent = _MyParent

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ' Generate some task data and add it to the task list.
        Load_Data()
    End Sub
    Private Sub Load_Data()
        Dim namePeople As String = String.Empty
        _tasks.Clear()
        Try
            Using db As New DataContext

                Dim _debitSales = From debit In db.GetDebitClient(Me.IdPerson)
                For Each item In _debitSales
                    _tasks.Add(New DebitEmployee() With
                      {
                      .IdEmpleadoDeuda = item.idFacturaVenta,
                      .TypeDebit = "Venta productos",
                      .Document = item.idFacturaVenta,
                      .Apellidos = item.Apellidos,
                      .DebitDate = item.fech_Factura,
                      .DebitValue = item.val_Factura - item.ValCobrado,
                      .IdPerson = item.idPersona,
                      .Nombres = item.Nombre,
                      .RucCi = item.Ruc_Ci
                      })
                    TotalDebt += item.val_Factura - item.ValCobrado
                    Me.IdCliente = item.idCliente
                Next


                Dim _debitEmployee = From debit In db.GetDebitEmployee(Me.IdPerson)

                For Each item In _debitEmployee
                    _tasks.Add(New DebitEmployee() With
                            {
                              .IdEmpleadoDeuda = item.idEmpleadoDeuda,
                              .TypeDebit = "Responsabilidades",
                              .Document = item.idEmpleadoDeuda,
                              .Apellidos = item.Apellidos,
                              .DebitDate = item.DebitDate,
                              .DebitValue = item.DevitValue,
                              .IdPerson = item.idPersona,
                              .Nombres = item.Nombre,
                              .RucCi = item.Ruc_Ci,
                              .PaymentDebit = item.valCobrado
                            })
                    TotalDebt += item.DevitValue - item.valCobrado
                Next

                If _tasks.Count > 0 Then
                    Me.MyParent.NamePeopleLabel.Text = String.Format("{0}  ==>Total deuda: {1}", _tasks.Item(0).FullName, TotalDebt.ToString("C2"))
                    Me.dataGrid1.Visibility = Windows.Visibility.Visible
                    Me.TextBlockNothing.Visibility = Windows.Visibility.Collapsed
                Else
                    Me.MyParent.NamePeopleLabel.Text = String.Empty
                    Me.dataGrid1.Visibility = Windows.Visibility.Collapsed
                    Me.TextBlockNothing.Visibility = Windows.Visibility.Visible
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub UngroupButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim cvTasks As ICollectionView = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource)
        If cvTasks IsNot Nothing Then
            cvTasks.GroupDescriptions.Clear()
        End If
    End Sub

    Private Sub GroupButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim cvTasks As ICollectionView = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource)
        If cvTasks IsNot Nothing And cvTasks.CanGroup = True Then
            cvTasks.GroupDescriptions.Clear()
            cvTasks.GroupDescriptions.Add(New PropertyGroupDescription("TypeDebit"))
        End If
    End Sub

    Private Sub CompleteFilter_Changed(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        ' Refresh the view to apply filters.
        CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource).Refresh()
    End Sub

    Private Sub CollectionViewSource_Filter(ByVal sender As System.Object, ByVal e As System.Windows.Data.FilterEventArgs)
        Dim t As DebitEmployee = e.Item
        If t IsNot Nothing Then
            ' If filter is turned on, filter completed items.
            If Me.cbCompleteFilter.IsChecked = True And t.IsUpdate = True Then
                e.Accepted = False
            Else
                e.Accepted = True
            End If
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As Windows.RoutedEventArgs)

    End Sub

    Private Sub TextBlock_MouseDown(sender As Object, e As Windows.Input.MouseButtonEventArgs)
        Try
            Me.Cursor = Cursors.Wait
            sender.Cursor = Cursors.Wait
            Dim NameTypoDebit = TryCast(sender, Windows.Controls.TextBlock)
            If Not NameTypoDebit Is Nothing Then
                Dim TypoDebit = DirectCast(NameTypoDebit, Windows.Controls.TextBlock).Tag
                If Not IsNothing(TypoDebit) Then

                    If TypoDebit.ToString.Contains("Responsabilidades") Then
                        Dim collection = _tasks.Where(Function(x) x.TypeDebit.Contains("Responsabilidades")).ToList()
                        Using formnew As New frmCobroEmpleado(Me.IdPerson, collection)
                            With formnew
                                .Text = String.Format("ESTADO DE DEUDA DE: {0}", _tasks.Item(0).FullName)
                                .StartPosition = FormStartPosition.CenterScreen
                                .ShowDialog()
                                If .Operation Then
                                    Me.Load_Data()
                                End If
                            End With
                        End Using
                    ElseIf TypoDebit.ToString.Contains("Venta") Then
                        Using formnew As New frmCobro()
                            With formnew
                                .Text = String.Format("ESTADO DE DEUDA DE: {0}", _tasks.Item(0).FullName)
                                .idCliente = Me.IdCliente
                                .StartPosition = FormStartPosition.CenterScreen
                                .ShowDialog()
                                If .Operation Then
                                    Me.Load_Data()
                                End If
                            End With
                        End Using
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Nothing
            sender.Cursor = Cursors.Hand
        End Try
    End Sub

End Class
