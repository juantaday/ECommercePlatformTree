Imports System.Data.SqlClient

Public Class BackupGeneral
    Private isLoadted As Boolean
    Public Files As List(Of FileTypes)
    Private MyParent As frmBackup
    Sub New(_Files As List(Of FileTypes), myparent As frmBackup)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Files = _Files
        Me.MyParent = myparent
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
        Me.TypeBackupComboBox.SelectedIndex = 0
        Me.CopyToComboBox.SelectedIndex = 0
        For Each item In Files
            Me.ListFileBox.Items.Add(item.NameFile)
        Next
        LoadData()
        isLoadted = True
    End Sub

    Private Sub LoadData()
        Me.DataBaseTextBox.Text = MyParent.DataBase
        Select Case Me.MyParent.TypeCopySegurity
            Case 1
                ModeRecoveryTextBox.Text = "Completa"
            Case 2
                ModeRecoveryTextBox.Text = "Registro masivo"
            Case 3
                ModeRecoveryTextBox.Text = "Simple"
            Case Else
                ModeRecoveryTextBox.Text = "No determinado..."
        End Select
        TypeBackupComboBox.SelectedIndex = MyParent.TypeBackup
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
        Dim file As String = String.Empty

        If Me.ListFileBox.SelectedItems.Count = 1 Then
            file = ListFileBox.Text
            For Each item In Me.Files
                If True Then

                End If
            Next
        End If

        If Not String.IsNullOrEmpty(file) Then
            Try
                Using newView As New frmViewDetailBackupRestory(file)
                    newView.Width = My.Computer.Screen.Bounds.Width * 0.95
                    newView.StartPosition = FormStartPosition.CenterParent
                    newView.ShowDialog()

                End Using
            Catch ex As Exception
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            End Try
        End If
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

    Private Sub TypeBackupComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeBackupComboBox.SelectedIndexChanged
        If isLoadted Then
            Me.MyParent.TypeBackup = TypeBackupComboBox.SelectedIndex
        End If
    End Sub
End Class
