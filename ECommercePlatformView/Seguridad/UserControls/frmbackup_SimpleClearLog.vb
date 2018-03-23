Imports System.Data.SqlClient

Public Class frmbackup_SimpleClearLog
    Private myParent As frmBackup
    Private NameArchiv As String
    Private isExecuting As Boolean
    Private connection As SqlConnection
    Private Delegate Sub DisplayInfoDelegate(ByVal Text As String)


    Sub New(ByVal myParent As frmBackup, Optional file As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        NameArchiv = file
        Me.myParent = myParent
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click

        If fileNameTextBox.Text.Length = 0 Or NameArchiv.ToString.Length = 0 Then
            MessageBox.Show("Debe seleccionar la rura del arcchivo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If isExecuting Then
            MessageBox.Show(Me,
               "Already executing. Please wait until the current query " &
                "has completed.")
        Else
            Dim command As SqlCommand
            Try
                isExecuting = True
                DisplayResults("/Initialize")
                DisplayStatus("Connecting...")
                connection = New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                ' To emulate a long-running query, wait for 
                ' a few seconds before working with the data.
                ' This command does not do much, but that's the point--
                ' it does not change your data, in the long run.


                command = New SqlCommand("backup_base", connection)
                command.CommandType = CommandType.StoredProcedure

                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add("@Direcions", SqlDbType.VarChar)
                command.Parameters.Add("@NameArchiv", SqlDbType.VarChar)
                command.Parameters.Add("@ResultID", SqlDbType.Int)

                command.Parameters("@Direcions").Value = NameArchiv
                command.Parameters("@NameArchiv").Value = "Esto es una prueba "
                command.Parameters("@ResultID").Direction = ParameterDirection.Output


                connection.Open()

                DisplayStatus("Executing...")

                ' Although it is not required that you pass the 
                ' SqlCommand object as the second parameter in the 
                ' BeginExecuteNonQuery call, doing so makes it easier
                ' to call EndExecuteNonQuery in the callback procedure.

                Dim callback As New AsyncCallback(AddressOf HandleCallback)
                command.BeginExecuteNonQuery(callback, command)

            Catch ex As Exception
                isExecuting = False
                DisplayStatus(String.Format("Ready (last error: {0})", ex.Message))
                If connection IsNot Nothing Then
                    connection.Close()
                End If
            End Try
        End If


    End Sub
    Private Sub HandleCallback(ByVal result As IAsyncResult)
        Try
            ' Retrieve the original command object, passed
            ' to this procedure in the AsyncState property
            ' of the IAsyncResult parameter.
            Dim command As SqlCommand = CType(result.AsyncState, SqlCommand)
            Dim rowCount As Integer = command.EndExecuteNonQuery(result)
            Dim resultInfo As Integer = Integer.Parse(command.Parameters("@ResultID").Value)

            Dim rowText() As String = {}
            If resultInfo = 1 Then
                rowText = {"Operacion Exitosa/Finally"}
            Else
                rowText = {"/Finally"}
            End If

            ' You may not interact with the form and its contents
            ' from a different thread, and this callback procedure
            ' is all but guaranteed to be running from a different thread
            ' than the form. Therefore you cannot simply call code that 
            ' displays the results, like this:
            ' DisplayResults(rowText)

            ' Instead, you must call the procedure from the form's thread.
            ' One simple way to accomplish this is to call the Invoke
            ' method of the form, which calls the delegate you supply
            ' from the form's thread. 
            Dim del As New DisplayInfoDelegate(AddressOf DisplayResults)
            Me.Invoke(del, rowText)


        Catch ex As Exception
            ' Because you are now running code in a separate thread, 
            ' if you do not handle the exception here, none of your other
            ' code catches the exception. Because none of your code
            ' is on the call stack in this thread, there is nothing
            ' higher up the stack to catch the exception if you do not 
            ' handle it here. You can either log the exception or 
            ' invoke a delegate (as in the non-error case in this 
            ' example) to display the error on the form. In no case
            ' can you simply display the error without executing a delegate
            ' as in the Try block here. 

            ' You can create the delegate instance as you 
            ' invoke it, like this:
            Me.Invoke(New DisplayInfoDelegate(AddressOf DisplayStatus),
                String.Format("Ready(last error: {0}", ex.Message))
        Finally
            isExecuting = False
            myParent.isClosable = isExecuting
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DisplayStatus(ByVal Text As String)
        Me.Label1.Text = Text
    End Sub

    Private Sub DisplayResults(ByVal Text As String)
        Dim mesa() As String = Split(Text, "/")
        Me.Label1.Text = mesa(0)
        If mesa(1) = "Initialize" Then
            Me.ProgressBar2.Style = ProgressBarStyle.Marquee
        ElseIf mesa(1) = "Finally" Then
            Me.ProgressBar2.Style = ProgressBarStyle.Blocks
        End If
        myParent.isClosable = Me.isExecuting
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        Try
            ' Displays an OpenFileDialog so the user can select a Cursor.
            Dim openFileDialog1 As New OpenFileDialog

            openFileDialog1.Filter = "Cursor Files|*.bak"
            openFileDialog1.Title = "Selecione la direccion del respaldo"

            ' Show the Dialog.
            ' If the user clicked OK in the dialog and 
            ' a .CUR file was selected, open it.
            Using file As New OpenFilePersonalise(typeFile.Backup, Me.NameArchiv)
                If file.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    fileNameTextBox.Text = file.FullName
                    NameArchiv = file.FullName
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub frmbackup_Simple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.fileNameTextBox.Text = NameArchiv
    End Sub


End Class