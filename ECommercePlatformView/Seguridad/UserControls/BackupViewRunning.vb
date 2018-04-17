Imports System.Data.SqlClient

Public Class BackupViewRunning
    Private MyParent As frmBackup
    Private AutoExceute As Boolean
    Private isExecuting As Boolean

    Private connection As SqlConnection
    Private Delegate Sub DisplayInfoDelegate(ByVal obj As String)



    Sub New(ByVal myParent As frmBackup, Optional autoExecute As Boolean = False)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MyParent = myParent
        Me.AutoExceute = autoExecute
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged

    End Sub

    Private Sub BackupViewRunning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BunifuCircleProgressbar1.StopRunnig()
        Me.Button1.Height = 0
        Me.Button1.Width = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If isExecuting Then
            MessageBox.Show(Me,
               "Already executing. Please wait until the current query " &
                "has completed.")
        Else
            Me.BunifuCircleProgressbar1.StartRunnig()
            Me.BunifuCustomLabel1.Visible = True
            Me.BunifuCustomLabel2.Visible = True
            Me.Refresh()

            Dim command As SqlCommand
            Try
                isExecuting = True
                DisplayResults("/Initialize")

                DisplayStatus("Connecting.../Initialize")
                connection = New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                ' To emulate a long-running query, wait for 
                ' a few seconds before working with the data.
                ' This command does not do much, but that's the point--
                ' it does not change your data, in the long run.


                command = New SqlCommand()
                command.Connection = connection
                command.CommandType = CommandType.Text

                sql = PreparatedStringCommad()

                command.CommandText = sql


                'command.Parameters("@ResultID").Direction = ParameterDirection.Output


                connection.Open()
                DisplayStatus("Execute.../Initialize")

                ' Although it is not required that you pass the 
                ' SqlCommand object as the second parameter in the 
                ' BeginExecuteNonQuery call, doing so makes it easier
                ' to call EndExecuteNonQuery in the callback procedure.

                Dim callback As New AsyncCallback(AddressOf HandleCallback)
                command.BeginExecuteNonQuery(callback, command)

            Catch ex As Exception
                isExecuting = False

                DisplayStatus(ex.Message & "/Finally/0")
                If connection IsNot Nothing Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Function PreparatedStringCommad() As String
        Try
            sql = String.Empty
            Dim StringFiles As String = String.Empty

            For Each item In Me.MyParent.MyDirFiles
                If String.IsNullOrEmpty(StringFiles) Then
                    StringFiles = "TO DISK = '" & item.NameFile & "'"
                Else
                    StringFiles = StringFiles & ", DISK = '" & item.NameFile & "'"
                End If
            Next
            Dim formater As String = String.Empty
            Select Case MyParent.TypeBackup
                Case 0
                    formater = "FORMAT"
                Case 1
                    formater = "NOFORMAT"
                Case 2
                    formater = "NOFORMAT"
            End Select





            Dim inity As String = String.Empty
            Select Case MyParent.OptionMedia
                Case 0
                    inity = "INIT"
                Case 1
                    inity = "NOINIT"
                Case 2
                    inity = "NOINIT"
            End Select

            Dim compresionStrin As String = String.Empty
            Select Case MyParent.CompresionType
                Case 0
                    compresionStrin = "NO_COMPRESSION"
                Case 1
                    compresionStrin = "COMPRESSION"
                Case 2
                    compresionStrin = "NO_COMPRESSION"
            End Select


            Select Case MyParent.TypeBackup
                Case 0
                    sql = "BACKUP DATABASE [" & MyParent.DataBase & "] 
                        " & StringFiles & "
                        With DESCRIPTION = '" & MyParent.DescriptionBackup & "', 
                        " & formater & ",
                        " & inity & ",
                        Name ='" & MyParent.NameBackup & "', 
                        SKIP,
                        NOREWIND,
                        NOUNLOAD,
                        " & compresionStrin & ",
                        STATS = 10"
                Case 1
                    sql = "BACKUP DATABASE [" & MyParent.DataBase & "] 
                        " & StringFiles & "
                        With  DIFFERENTIAL,
                        DESCRIPTION = '" & MyParent.DescriptionBackup & "', 
                        " & formater & ",
                        " & inity & ",
                        Name ='" & MyParent.NameBackup & "', 
                        SKIP,
                        NOREWIND,
                        NOUNLOAD,
                        " & compresionStrin & ",
                        STATS = 10"
                Case 2
                    sql = "BACKUP LOG [" & MyParent.DataBase & "] 
                        " & StringFiles & "
                        With DESCRIPTION = '" & MyParent.DescriptionBackup & "', 
                        " & formater & ",
                        " & inity & ",
                        Name ='" & MyParent.NameBackup & "', 
                        SKIP,
                        NOREWIND,
                        NOUNLOAD,
                        " & compresionStrin & ",
                        STATS = 10"
                Case Else
                    sql = "Configuracion Errornea"
            End Select

            Return sql
        Catch ex As Exception
            DisplayResults(ex.Message & "/Finally")
            Return String.Empty
        End Try
    End Function

    Private Sub HandleCallback(ByVal result As IAsyncResult)

        Try
            ' Retrieve the original command object, passed
            ' to this procedure in the AsyncState property
            ' of the IAsyncResult parameter.
            Dim command As SqlCommand = CType(result.AsyncState, SqlCommand)
            Dim rowCount As Integer = command.EndExecuteNonQuery(result)
            Dim tesResul() As String

            If rowCount <> 0 Then
                tesResul = {"Operacion Exitosa/Finally"}
            Else
                tesResul = {"/Finally"}
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
            Me.Invoke(del, tesResul)


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

            Dim del As New DisplayInfoDelegate(AddressOf DisplayStatus)
            Me.Invoke(del, ex.Message & "/Finally/0")


            'String.Format("Un error a ocurrido:", ex.Message))
        Finally
            isExecuting = False
            MyParent.isClosable = isExecuting
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub DisplayStatus(ByVal text As String)
        Me.Label1.Text = text
        Dim countResul = Split(text, "/")

        If countResul.Length = 3 Then
            Me.BunifuCircleProgressbar1.StopRunnig()
            Me.BunifuCustomLabel1.Visible = False
            Me.BunifuCustomLabel2.Visible = False
        End If
    End Sub

    Private Sub DisplayResults(ByVal Text As String)
        Dim mesa() As String = Split(Text, "/")
        Me.Label1.Text = mesa(0)

        If mesa(1) = "Finally" Then
            Me.BunifuCircleProgressbar1.StopRunnig()
            Me.BunifuCustomLabel1.Visible = False
            Me.BunifuCustomLabel2.Visible = False
        End If
        MyParent.isClosable = Me.isExecuting
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Me.AutoExceute Then
            Me.Button1.PerformClick()
        End If
    End Sub
End Class
