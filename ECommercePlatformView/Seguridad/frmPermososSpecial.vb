Imports System.Windows.Forms
Imports CADsisVenta.DataSetSystemTableAdapters
Imports System.Data.SqlClient

Public Class frmPermososSpecial
    Private codUser As String
    Sub New(codUser As String)
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.codUser = codUser
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.transaccionData(Me.codUser) Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function transaccionData(codUser As String) As Boolean
        Try
            Using connection As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                connection.Open()
                Dim command As SqlCommand = connection.CreateCommand()
                Dim transaction As SqlTransaction
                transaction = connection.BeginTransaction("SampleTransaction")
                command.Connection = connection
                command.Transaction = transaction
                Try
                    ' Start a local transaction

                    command.CommandType = CommandType.Text
                    'delete the information////////////
                    command.CommandText = "Delete [stm].[UserSpecial] WHERE (codUser =@codUser) "
                    command.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    command.Parameters("@codUser").Value = codUser
                    command.ExecuteNonQuery()
                    'add the information ///////

                    Dim inserComman As SqlCommand = connection.CreateCommand()
                    inserComman.Connection = connection
                    inserComman.Transaction = transaction
                    inserComman.CommandText = "Insert [stm].[UserSpecial] (idUserCotrol, codUser) Values(@idUserCotrol, @codUser) "
                    Dim isIntro As Boolean = False
                    For i = 0 To Me.ListView1.Items.Count - 1
                        If Me.ListView1.Items(i).Checked Then
                            If Not isIntro Then
                                inserComman.Parameters.Add("@codUser", SqlDbType.Char, 8)
                                inserComman.Parameters.Add("@idUserCotrol", SqlDbType.Int)
                            End If
                            inserComman.Parameters("@codUser").Value = codUser
                            inserComman.Parameters("@idUserCotrol").Value = Integer.Parse(Me.ListView1.Items(i).SubItems(1).Text)
                            If Not (inserComman.ExecuteNonQuery() = 1) Then

                            End If
                            isIntro = True
                        End If
                    Next
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmPermososSpecial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(Me.codUser) Then
            Me.Close()
        End If
        Carga_Datos()
    End Sub

    Private Sub Carga_Datos()
        Try
            Using cmd As New PermisoSpecialTableAdapter
                Dim dt As New DataTable
                dt = cmd.GetData(Me.codUser)
                For i = 0 To dt.Rows.Count - 1
                    Me.ListView1.Items.Add(dt.Rows(i)("DescriptionControl").ToString)
                    Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dt.Rows(i)("idUserCotrol").ToString)
                    Me.ListView1.Items(Me.ListView1.Items.Count - 1).Checked = dt.Rows(i)("Permiso")
                Next
            End Using
            ListView1.View = View.List
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            For i = 0 To Me.ListView1.Items.Count - 1
                Me.ListView1.Items(i).Checked = CheckBox1.Checked
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
