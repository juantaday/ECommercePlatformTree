Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmViewDetailBackupRestory

    Private _File As String
    Sub New(ByVal file As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me._File = file
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmViewDetailBackupRestory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoaData()
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()

                sql = "Restore headeronly from disk ='" & Me._File & "'"
                Using cmd As New SqlCommand(sql, cnn)
                    Using dat As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            dat.Fill(dt)
                            Me.dtg.DataSource = dt
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Cursor = Cursors.WaitCursor
        LoaData()
        Me.Cursor = Cursors.Default
    End Sub


End Class
