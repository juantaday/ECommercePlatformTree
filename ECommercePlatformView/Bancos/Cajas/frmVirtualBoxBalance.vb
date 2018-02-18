Public Class frmVirtualBoxBalance
    Private totalSaldo As Double
    Private Sub frmVirtualBoxBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalSaldo = 0
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Using db As New DataContext
                Dim mylist = From v In db.VirtualBox
                             Join b In db.Bodegas On b.idBodega Equals v.idBodega
                             Select New With {v.idVirtualBox, b.Nom_Bodega, v.NameVirtualBox, v.Saldo}

                dtg.DataSource = mylist.ToList()
                applyGridTheme(dtg)
                For Each item As DataGridViewRow In dtg.Rows
                    Me.totalSaldo += item.Cells("Saldo").Value
                Next
                Me.totalLabel.Text = "Total saldo en cajas virtuales: " & Me.totalSaldo.ToString("C2")

                clm = dtg.Columns("idVirtualBox")
                clm.HeaderText = "idVirtualBox"
                clm.Visible = False

                clm = dtg.Columns("Nom_Bodega")
                clm.HeaderText = "Local o bodega"
                clm.Width = 200

                clm = dtg.Columns("NameVirtualBox")
                clm.HeaderText = "Caja virtual"
                clm.Width = 200

                clm = dtg.Columns("Saldo")
                clm.DefaultCellStyle = myStileMoney

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        Try
            If dtg.SelectedRows.Count = 1 Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class