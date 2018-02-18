Imports System.Windows.Input

Namespace ItemViewModel
    Friend Class RelayCommand
        Implements ICommand

        Private selectTournament As Object

        Public Sub New(selectTournament As Object)
            Me.selectTournament = selectTournament
        End Sub

        Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

        Public Sub Execute(parameter As Object) Implements ICommand.Execute
            Throw New NotImplementedException()
        End Sub

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
