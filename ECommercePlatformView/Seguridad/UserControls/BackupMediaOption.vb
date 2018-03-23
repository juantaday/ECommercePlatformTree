Public Class BackupMediaOption
    Private MyParent As frmBackup
    Private _AceeptButton As Button
    Private IsLoated As Boolean
    Sub New(ByVal myParent As frmBackup)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MyParent = myParent
    End Sub
    Private Sub BackupMediaOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.CompresionComboBox.Items.Count > 0 Then
            CompresionComboBox.SelectedIndex = 0
        End If
        LoadData()
        IsLoated = True
    End Sub

    Private Sub LoadData()
        NameBackupTextBox.Text = Me.MyParent.NameBackup
        DescriptionTextBox.Text = Me.MyParent.DescriptionBackup
        CompresionComboBox.SelectedIndex = MyParent.CompresionType
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameBackupTextBox.TextChanged
        If IsLoated Then
            Me.MyParent.NameBackup = NameBackupTextBox.Text
        End If
    End Sub

    Private Sub CompresionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompresionComboBox.SelectedIndexChanged
        If IsLoated Then
            Me.MyParent.CompresionType = CompresionComboBox.SelectedIndex
        End If
    End Sub

    Private Sub DescriptionTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged
        If IsLoated Then
            Me.MyParent.DescriptionBackup = DescriptionTextBox.Text
        End If
    End Sub

    Private Sub DescriptionTextBox_Enter(sender As Object, e As EventArgs) Handles DescriptionTextBox.Enter
        If Not IsNothing(MyParent.AcceptButton) Then
            Me._AceeptButton = MyParent.AcceptButton
        End If
        MyParent.AcceptButton = Nothing
    End Sub

    Private Sub DescriptionTextBox_Leave(sender As Object, e As EventArgs) Handles DescriptionTextBox.Leave
        If Not IsNothing(Me._AceeptButton) Then
            Me.MyParent.AcceptButton = _AceeptButton
        End If
    End Sub
End Class
