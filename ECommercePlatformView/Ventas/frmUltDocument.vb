Public Class frmUltDocument
    Private state As stateLoad
    Private document As String
    Sub New(state As stateLoad)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.state = state
    End Sub
    Protected Friend flag As String
    Public Enum stateLoad
        PrintAll = 1
        PrintSelect = 2
        PrintNot = 3
    End Enum
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmUltDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Carga_Datos() Then
            MenuTableLayout.Enabled = True
        Else
            MenuTableLayout.Enabled = False
        End If
        If Me.state = stateLoad.PrintAll Then
            SelectAllButton.PerformClick()
            sql = "Existe " & DataGridView1.SelectedRows.Count & " documentos "
            sql = sql & "Desea imprimir..?"
            If Not MsgBox(sql, MsgBoxStyle.Information + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Aviso") = MsgBoxResult.Yes Then
                Close()
                Return
            End If
            If PrintAll(Me.document) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
    Private Function Carga_Datos() As Boolean
        DataGridView1.DataSource = Nothing
        Try
            sql = "Select f.idFactVenta as [ID],td.Nom_Docu,f.Num_Factu AS [Factura], n.Nombres as [Cliente],f.Total from [tmp].DocumentULT  as t "
            sql = sql & "inner join facturaVenta As f On f.idFactVenta = t.idDocument "
            sql = sql & "inner join ClienteName As n On n.idCliente = f.idCliente "
            sql = sql & "INNER JOIN [STM].TypoDocumento AS td on td.idTypoDocu = f.idTypoDocument "
            sql = sql & "where t.codTerminal ='" & TerminalActivo.codTerminal & " ' and t.codUser ='" & UsuarioActivo.codUser & "' "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    DataGridView1.DataSource = dt
                    Me.document = DataGridView1.Rows(0).Cells(DataGridView1.Columns("Nom_Docu").Index).Value
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub ActualizaButton_Click(sender As Object, e As EventArgs) Handles ActualizaButton.Click
        If Carga_Datos() Then
            MenuTableLayout.Enabled = True
        Else
            MenuTableLayout.Enabled = False
        End If
    End Sub

    Private Sub PrintTicketButton_Click(sender As Object, e As EventArgs) Handles PrintTicketButton.Click
        Try
            If Not (MsgBox("Está seguro de imprimir en TICKET ", MsgBoxStyle.Exclamation + vbYesNo, "Responda") = MsgBoxResult.Yes) Then
                Return
            End If

            Dim RowSelect As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
            Dim Rows As DataGridViewRow
            Dim i As Int16 = 0
            For Each Rows In RowSelect
                If i = 0 Then
                    LoadOptionsPrint(Me.document)
                End If
                Print_Ticket(Rows.Cells(0).Value)
                i += 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function PrintAll(document As String)
        Try
            Select Case myOptnsPrint.typePrint
                Case "Ticket"
                    For Each Rows In DataGridView1.Rows
                        Print_Ticket(Rows.Cells(0).Value)
                    Next
                    Return True
                Case "Matricial"
                    printMatricial(document, 0, True)
                Case "Tinta"
            End Select
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub SelectAllButton_Click(sender As Object, e As EventArgs) Handles SelectAllButton.Click
        cmdSelectAll(DataGridView1)
    End Sub
    Private Sub PrintColorButton_Click(sender As Object, e As EventArgs) Handles PrintMatricialButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If LoadOptionsPrint(Me.document) Then
                Me.PrintAll(Me.document)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub ViewReportButton_Click(sender As Object, e As EventArgs) Handles ViewReportButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Select Case Me.document
                Case "Factura"
                    Using reporteNotaVenta As New frmReportFactura(viewLoadReport.Latest)
                        reporteNotaVenta.ShowDialog()
                    End Using
                Case "Nota de venta"
                    Using reporteNotaVenta As New frmReportNotaVenta(viewLoadReport.Latest)
                        reporteNotaVenta.ShowDialog()
                    End Using
                Case "Proforma"
                    Using reporteNotaVenta As New frmReportProforma(viewLoadReport.Latest)
                        reporteNotaVenta.ShowDialog()
                    End Using
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
