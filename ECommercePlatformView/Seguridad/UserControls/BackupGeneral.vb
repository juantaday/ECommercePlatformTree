Imports System.Data.SqlClient

Public Class BackupGeneral
    Public Files As List(Of FileTypes)
    Sub New(_Files As List(Of FileTypes))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Files = _Files
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Files = New List(Of FileTypes)
    End Sub
    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub BackupGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TypeCopySegurity.SelectedIndex = 0
        Me.CopyToComboBox.SelectedIndex = 0
        For Each item In Files
            Me.ListFileBox.Items.Add(item.NameFile)
        Next
        LoadData()

    End Sub

    Private Sub LoadData()
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "SELECT db.[name]
                        ,db.recovery_model
                           FROM sys.databases  as db
                           WHERE name = 'jsofwareCommerceDB03'"
                Using cmd As New SqlCommand(sql, cnn)
                    Using dat As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            If dat.Fill(dt) Then
                                If dt.Rows.Count > 0 Then
                                    Me.DataBaseTextBox.Text = dt.Rows(0)(0)
                                    Select Case dt.Rows(0)(1)
                                        Case 1
                                            ModeRecoveryTextBox.Text = "Completa"
                                        Case 2
                                            ModeRecoveryTextBox.Text = "Registro masivo"
                                        Case 3
                                            ModeRecoveryTextBox.Text = "Simple"
                                        Case Else
                                            ModeRecoveryTextBox.Text = "No determinado..."
                                    End Select
                                End If
                            End If


                        End Using
                    End Using

                End Using
            End Using

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub AddNewFileButton_Click(sender As Object, e As EventArgs) Handles AddNewFileButton.Click
        Using fil As New OpenFilePersonalise(
                     typeFile.Backup,
                     If(Me.ListFileBox.SelectedItems.Count = 1,
                     Me.ListFileBox.SelectedItem.ToString, String.Empty))

            fil.ShowDialog()

            If fil.DialogResult = DialogResult.OK Then
                Me.ListFileBox.Items.Add(fil.FullName)
            End If
        End Using
    End Sub

    Private Sub ListFileBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFileBox.SelectedIndexChanged
        Me.ViewDetailButton.Enabled = ListFileBox.SelectedItems.Count = 1
        Me.DeleteFileButton.Enabled = ListFileBox.SelectedItems.Count = 1
    End Sub

    Private Sub ViewDetailButton_Click(sender As Object, e As EventArgs) Handles ViewDetailButton.Click

    End Sub

    Private Sub BackupGeneral_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Files.Clear()
        Try
            For Each item In Me.ListFileBox.Items
                Me.Files.Add(New FileTypes With {.NameFile = item})
            Next
            Dim pyPanel As Object = Me.Parent
            If Not IsNothing(pyPanel) Then
                Dim myParent As Object = pyPanel.Parent
                If Not IsNothing(myParent) Then
                    If myParent.name.Equals("MyBackColor") Then
                        myParent.MyDirFiles = Me.Files
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub DeleteFileButton_Click(sender As Object, e As EventArgs) Handles DeleteFileButton.Click
        If MsgBox("Esta seguro de quitar esta dirección",
                  MsgBoxStyle.Question +
                  MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2,
                  "Responda.") = MsgBoxResult.Yes Then
            Me.ListFileBox.Items.Remove(Me.ListFileBox.SelectedItem)
        End If
    End Sub
End Class
