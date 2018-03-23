Public Class BackupOverwrite
    Private isLoated As Boolean
    Private MyParent As frmBackup
    Sub New(ByVal myParent As frmBackup)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MyParent = myParent
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.RadioGroup2.Enabled = RadioButton1.Checked
        If isLoated And Me.RadioButton1.Checked Then
            If RadioGroup2.SelectedIndex = -1 Then
                MyParent.OptionMedia = 3 ' no terminet
                Return
            End If

            For Each item In RadioGroup2.Properties.Items
                If RadioGroup2.SelectedIndex = 0 Then
                    MyParent.OptionMedia = 1
                    Exit For
                ElseIf RadioGroup2.SelectedIndex = 1 Then
                    MyParent.OptionMedia = 2
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub RadioGroup2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup2.SelectedIndexChanged
        If isLoated Then
            If RadioGroup2.SelectedIndex = 0 Then
                MyParent.OptionMedia = 1
            ElseIf RadioGroup2.SelectedIndex = 1 Then
                MyParent.OptionMedia = 2
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Me.RadioGroup2.Enabled = False
        End If
        If isLoated Then
            MyParent.OptionMedia = 0
        End If
    End Sub

    Private Sub BackupOverwrite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isLoated = True
        LoadData()
    End Sub

    Private Sub LoadData()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Select Case MyParent.OptionMedia
            Case 0
                RadioButton2.Checked = True
            Case 1
                RadioButton1.Checked = True
                RadioGroup2.SelectedIndex = 0
            Case 2
                RadioButton1.Checked = True
                RadioGroup2.SelectedIndex = 1
            Case Else

        End Select
    End Sub
End Class
