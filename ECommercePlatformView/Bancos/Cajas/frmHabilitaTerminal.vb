Imports System.Data.SqlClient
Public Class frmHabilitaTerminal
    Private isLoad As Boolean

    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dtg.RowStateChanged
        If isLoad Then
            If dtg.SelectedRows.Count = 1 Then
                Me.AbrirCajaToolStripMenuItem.Enabled = True
            Else
                Me.AbrirCajaToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub frmHabilitaTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_datos()
        isLoad = True
        DescriptionLabel.Text = String.Empty
    End Sub
    Private Sub Carga_datos()
        Try
            sql = "select t.idTerminal
                     ,b.Nom_Bodega
                     ,e.Dominio
                    ,t.codTerminal 
                     , b.Des_Bodega 
                      ,e.Descripcion
                     from [stm].Terminal as t
                     inner join [stm].[Equipos]  as e  on t.idEquipo = e.idEquipo
                    inner join [stm].[Location] as l on l.idLocation  = t.idLocation
                    inner join Bodegas as b on b.idBodega  = t.idBodega
                    where l.Des_Location like '%terminal%'"
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    Using dat As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        dat.Fill(dt)
                        dtg.DataSource = dt

                        applyGridTheme(dtg)
                        clm = dtg.Columns("idTerminal")
                        clm.Visible = False

                        clm = dtg.Columns("Nom_Bodega")
                        clm.HeaderText = "Local o bodega"
                        clm.Width = 150

                        clm = dtg.Columns("Dominio")
                        clm.HeaderText = "Nombre del equipo"
                        clm.Width = 150

                        clm = dtg.Columns("codTerminal")
                        clm.HeaderText = "Terminal"
                        clm.Width = 200

                        clm = dtg.Columns("Descripcion")
                        clm.Visible = False

                        clm = dtg.Columns("Des_Bodega")
                        clm.Visible = False

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub AbrirCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaToolStripMenuItem.Click
        Try
            Dim idTerminal As Nullable(Of Integer) = dtg.SelectedRows(0).Cells(dtg.Columns("idTerminal").Index).Value
            Dim codterminal As String = dtg.SelectedRows(0).Cells(dtg.Columns("codTerminal").Index).Value

            Using frmNewOperationCaja
                With frmNewOperationCaja
                    .idTerminal = idTerminal
                    .codTerminalTextBox.Text = codterminal
                    .Operation = _operation.Insert
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        MsgBox("Operación exitosa", MsgBoxStyle.Information, "Aviso")
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dtg_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.RowEnter
        Try
            If dtg.SelectedRows.Count = 1 Then
                sql = "Bodega o local: " & dtg.SelectedRows(0).Cells(dtg.Columns("Des_Bodega").Index).Value.ToString() & vbCrLf
                sql = sql & "Equipo: " & dtg.SelectedRows(0).Cells(dtg.Columns("Descripcion").Index).Value.ToString()
                DescriptionLabel.Text = sql
            Else
                DescriptionLabel.Text = String.Empty
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class