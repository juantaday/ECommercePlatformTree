Imports CADsisVenta.DataSetSystemTableAdapters
Public Class frmClosedTransactionsTerminal
    Private isLoated As Boolean
    Private Sub frmClosedTransactionsTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Bodega()
        isLoated = True
        ListBodegaComboBox_SelectedIndexChanged(Me.ListBodegaComboBox, New System.EventArgs)
    End Sub
    Private Sub Load_Data(ByVal dateStar As Date, ByVal dateEnd As Date)
        Try
            If ListBodegaComboBox.SelectedIndex = -1 Then
                MsgBox("Seleccione el local o la bodega...", MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If
            dtg.DataSource = Nothing
            Using db As New DataContext
                dtg.DataSource = db.getClosedTerminal(dateStar, dateEnd, Integer.Parse(ListBodegaComboBox.SelectedValue.ToString))
                dtg.Columns("idCajaStado").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_Bodega()
        Try
            Dim dat As New BodegaSystemTableAdapter
            Dim dt As New DataTable
            dt = dat.GetData()
            If dt.Rows.Count > 0 Then
                ListBodegaComboBox.DataSource = dt
                ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                ListBodegaComboBox.ValueMember = "idBodega"
                ListBodegaComboBox.SelectedIndex = -1
                If Not (IsNothing(TerminalActivo)) And IsNumeric(TerminalActivo.idBodega) Then
                    ListBodegaComboBox.SelectedValue = TerminalActivo.idBodega
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ListBodegaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBodegaComboBox.SelectedIndexChanged
        If isLoated Then
            Try
                If ListBodegaComboBox.SelectedIndex >= 0 And ListBodegaComboBox.ValueMember.ToString.Length > 0 Then
                    If NewRadioButton.Checked Then
                        Load_Data(Date.Now, Date.Now)
                    ElseIf YesterdayRadioButton.Checked Then
                        Load_Data(Date.Now.AddDays(-1), Date.Now.AddDays(-1))
                    ElseIf Me.ByDateRadioButton.Checked Then
                        If BunifuDatepicker1.Visible Then
                            Load_Data(BunifuDatepicker1.Value, BunifuDatepicker1.Value)
                        Else
                            BunifuDatepicker1.Visible = True
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub PrintTicketButton_Click(sender As Object, e As EventArgs) Handles PrintTicketButton.Click
        Try
            If dtg.SelectedRows.Count = 1 Then
                Dim idCajaStado As Integer = dtg.SelectedRows(0).Cells("idCajaStado").Value
                If LoadOptionsPrint("Reporte de cierre de caja") Then
                    sql = "Desea imprimir el Reporte de cierre de caja" & vbNewLine
                    sql = sql & "En impresora " & myOptnsPrint.typePrint & " " & myOptnsPrint.NamePrint
                    If (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                        PrintArqueoTerminal(idCajaStado, myOptnsPrint)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub YesterdayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles YesterdayRadioButton.CheckedChanged
        If YesterdayRadioButton.Checked Then
            If isLoated Then
                Load_Data(Date.Now.AddDays(-1), Date.Now.AddDays(-1))
            End If
        End If
    End Sub
    Private Sub NewRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NewRadioButton.CheckedChanged
        If NewRadioButton.Checked Then
            If isLoated Then
                Load_Data(Date.Now.AddDays(0), Date.Now.AddDays(0))
            End If
        End If
    End Sub
    Private Sub ByDateRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ByDateRadioButton.CheckedChanged
        BunifuDatepicker1.Visible = ByDateRadioButton.Checked
    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged
        If BunifuDatepicker1.Visible Then
            If isLoated Then
                Me.Load_Data(BunifuDatepicker1.Value, BunifuDatepicker1.Value)
            End If
        End If
    End Sub

    Private Sub BeforeDayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BeforeDayRadioButton.CheckedChanged
        If BeforeDayRadioButton.Checked Then
            If isLoated Then
                Load_Data(Date.Now.AddDays(-2), Date.Now.AddDays(-2))
            End If
        End If
    End Sub
End Class