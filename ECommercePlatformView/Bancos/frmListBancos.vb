Imports CADsisVenta.DataSetPersonTableAdapters
Public Class frmListBancos
    Private Sub frmBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Bancos()
    End Sub

    Private Sub Carga_Bancos()
        Try
            Dim dat As New BancosTableAdapter
            Dim dt As DataTable = dat.GetData()
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    DataGridView1.DataSource = dt
                    DataGridView1.Columns(0).Visible = False

                    applyGridTheme(DataGridView1)
                    DataGridView1.RowHeadersWidth = 4

                    clm = DataGridView1.Columns("nom_Banco")
                    clm.HeaderText = "Bancos"
                    clm.Width = 200

                    clm = DataGridView1.Columns("telf_Banco")
                    clm.HeaderText = "Teléfono"
                    clm.Width = 200
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en le Carga_Bancos ", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub cancel_Button_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub
    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub addBancosButton_Click(sender As Object, e As EventArgs) Handles addBancosButton.Click
        Try
            Using newaddBancos As New frmAdd_Banco(stateOperation.Insert, 0, String.Empty, String.Empty)
                With newaddBancos
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Bancos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditBancosButton_Click(sender As Object, e As EventArgs) Handles EditBancosButton.Click
        Try
            Using newaddBancos As New frmAdd_Banco(stateOperation.Update,
                            DataGridView1.SelectedCells.Item(0).Value,
                            DataGridView1.SelectedCells.Item(DataGridView1.Columns("nom_Banco").Index).Value,
                            DataGridView1.SelectedCells.Item(DataGridView1.Columns("telf_Banco").Index).Value)
                With newaddBancos
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Carga_Bancos()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub deleteBancosButton_Click(sender As Object, e As EventArgs) Handles deleteBancosButton.Click
        Try
            sql = "Está seguro de eliminar: " & vbNewLine
            sql = sql & DataGridView1.SelectedCells.Item(DataGridView1.Columns("nom_Banco").Index).Value
            If (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Alerta") = MsgBoxResult.Yes) Then
                Using newaddBancos As New frmAdd_Banco(stateOperation.Delete,
                        DataGridView1.SelectedCells.Item(0).Value, String.Empty, String.Empty)
                    With newaddBancos
                        If .DialogResult = DialogResult.OK Then
                            Carga_Bancos()
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            EditBancosButton.Enabled = Boolean.Parse((DataGridView1.SelectedRows.Count = 1))
            deleteBancosButton.Enabled = Boolean.Parse((DataGridView1.SelectedRows.Count = 1))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
