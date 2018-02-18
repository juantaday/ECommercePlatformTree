Module AdminControles
    'para seeelcionar todo
    Public Function cmdSelectAll(ByVal sender As System.Windows.Forms.Control) As Boolean
        Try
            If TypeOf (sender) Is TextBox Then
                Return SelectText(sender, True)
            ElseIf TypeOf (sender) Is ListView Then
                Return SelectListView(sender, True)
            ElseIf TypeOf (sender) Is DataGridView Then
                Return SelectDataGridView(sender, True)
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'para no selecionatr data
    Public Function cmdNotSelect(ByVal sender As System.Windows.Forms.Control) As Boolean
        Try
            If TypeOf (sender) Is TextBox Then
                Return SelectText(sender, False)
            ElseIf TypeOf (sender) Is ListView Then
                Return SelectListView(sender, False)
            ElseIf TypeOf (sender) Is DataGridView Then
                Return SelectDataGridView(sender, False)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'cmdo Copiar
    Public Function cmdCopy(ByVal sender As System.Windows.Forms.Control) As Boolean
        Try
            Clipboard.Clear()
            If TypeOf (sender) Is TextBox Then
                Return CopyText(sender)
            ElseIf TypeOf (sender) Is ListView Then
                Return CopyListView(sender)
            ElseIf TypeOf (sender) Is DataGridView Then
                Return CopyDataGridView(sender)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function



    'controlador interno para seleccionar
    Private Function SelectText(ByVal sender As System.Windows.Forms.TextBox, ByVal state As Boolean) As Boolean
        Try
            If state Then
                sender.Select(0, sender.TextLength)
            Else
                sender.Select(0, 0)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function SelectListView(ByVal sender As System.Windows.Forms.ListView, state As Boolean) As Boolean
        Try
            sender.MultiSelect = True
            For i = 0 To sender.Items.Count - 1
                sender.Items(i).Selected = state
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function SelectDataGridView(ByVal sender As System.Windows.Forms.DataGridView, state As Boolean) As Boolean
        Try
            sender.MultiSelect = True
            For i = 0 To sender.RowCount - 1
                sender.Rows(i).Selected = state
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'controladores interno para copiar
    Private Function CopyText(ByVal sender As System.Windows.Forms.TextBox) As Boolean
        Try
            My.Computer.Clipboard.SetText(sender.Text)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function CopyListView(ByVal sender As System.Windows.Forms.ListView) As Boolean
        Try
            Dim buffer As New System.Text.StringBuilder
            Dim coleecionItem As ListView.SelectedListViewItemCollection = sender.SelectedItems

            For c = 0 To sender.Columns.Count - 1
                Buffer.Append(sender.Columns(c).Text)
                Buffer.Append(vbTab)
            Next
            Buffer.Append(vbNewLine)
            Dim items As ListViewItem
            For Each items In coleecionItem
                For col = 0 To items.SubItems.Count - 1
                    Buffer.Append(items.SubItems(col).Text)
                    Buffer.Append(vbTab)
                Next
                Buffer.Append(vbNewLine)
            Next
            Clipboard.SetText(Buffer.ToString())
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function CopyDataGridView(ByVal sender As System.Windows.Forms.DataGridView) As Boolean
        Try
            Dim buffer As New System.Text.StringBuilder

            For c = 0 To sender.Columns.Count - 1
                buffer.Append(sender.Columns(c).HeaderText)
                buffer.Append(vbTab)
            Next
            buffer.Append(vbNewLine)

            Dim RowSelect As DataGridViewSelectedRowCollection = sender.SelectedRows

            Dim Rows As DataGridViewRow
            For Each Rows In RowSelect
                For col = 0 To Rows.Cells.Count - 1
                    buffer.Append(Rows.Cells(col).Value)
                    buffer.Append(vbTab)
                Next
                buffer.Append(vbNewLine)
            Next
            Clipboard.SetText(buffer.ToString())
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

End Module
Public Enum _state
    Admin = 0
    View = 1
    Select_ = 2
End Enum
Public Enum _operation
    Insert = 0
    Update = 1
    Delete = 2
End Enum
Public Enum rowHeaderIcons
    expand = 0
    collapse = 1
End Enum


