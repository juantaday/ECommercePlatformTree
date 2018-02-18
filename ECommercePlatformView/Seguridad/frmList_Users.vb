
Imports CADsisVenta.DataSetUsers
Imports CADsisVenta.DataSetUsersTableAdapters

Public Class frmList_Users
    Private estaCargado As Boolean
    Private Sub frmList_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_ListUser()
    End Sub
    Private Sub Carga_ListUser()
        Try
            estaCargado = False
            Dim data As New UserNameTableAdapter
            Dim dt As New UserNameDataTable
            data.Fill(dt)
            dtg.DataSource = dt
            MyThemDataGridview()
            Total_listLabel.Text = "Total lista : " + Convert.ToString(dtg.RowCount - 1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub

    Private Sub dtg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellClick
        Carga_Image(sender, e.RowIndex)
    End Sub

    Private Sub dtg_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dtg.RowStateChanged
        btnok.Enabled = False
        PanelDetail.Enabled = False
        AcceptButton = Nothing
        If e.Row.Selected And estaCargado Then
            If dtg.SelectedRows.Count = 1 Then
                Carga_Image(sender, e.Row.Index)
                btnok.Enabled = True
                PanelDetail.Enabled = True
                AcceptButton = btnok
            End If
        End If
    End Sub
    Private Sub MyThemDataGridview()
        Try
            applyGridTheme(dtg)
            For Each col In dtg.Columns
                col.visible = False
            Next
            dtg.ColumnHeadersHeight = 50
            'visibleColumna de ruc
            dtg.Columns(dtg.Columns("Ruc_Ci").Index).Visible = True
            dtg.Columns(dtg.Columns("Ruc_Ci").Index).HeaderText = "Ruc. C.I"
            dtg.Columns(dtg.Columns("Ruc_Ci").Index).Width = 120
            dtg.Columns(dtg.Columns("Ruc_Ci").Index).DisplayIndex = 1
            'visibleColumna de elpledo
            dtg.Columns(dtg.Columns("Nombres").Index).Visible = True
            dtg.Columns(dtg.Columns("Nombres").Index).HeaderText = "Empleado"
            dtg.Columns(dtg.Columns("Nombres").Index).Width = 200
            dtg.Columns(dtg.Columns("Nombres").Index).DisplayIndex = 2
            'visibleColumna de Telefono
            dtg.Columns(dtg.Columns("telefono").Index).Visible = True
            dtg.Columns(dtg.Columns("telefono").Index).HeaderText = "Teléfono personal"
            dtg.Columns(dtg.Columns("telefono").Index).Width = 150
            dtg.Columns(dtg.Columns("telefono").Index).DisplayIndex = 3
            'visibleColumna de Telefono casa
            dtg.Columns(dtg.Columns("Login").Index).Visible = True
            dtg.Columns(dtg.Columns("Login").Index).HeaderText = "Código usuario"
            dtg.Columns(dtg.Columns("Login").Index).Width = 100
            dtg.Columns(dtg.Columns("Login").Index).DisplayIndex = 0
            'evento para contar lon mumeros de row
            'AddHandler dtg.RowPostPaint, AddressOf rowPostPaint_HeaderCount

            Total_listLabel.Text = "Total lista : " + Convert.ToString(dtg.RowCount - 1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Carga_Image(sender As Object, p2 As Integer)
        Try
            If Not (sender.SelectedRows.Count = 1) Then
                Return
            End If

            Dim img() As Byte = Nothing
            If IsArray(sender.SelectedCells.Item(sender.Columns("foto").Index).Value) Then
                img = sender.SelectedCells.Item(sender.Columns("foto").Index).Value
            End If

            If Not IsNothing(img) Then
                If img.Length > 0 Then
                    Dim ms As New IO.MemoryStream(img)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    If Boolean.Parse(sender.SelectedCells.Item(sender.Columns("genero").Index).Value) Then
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    Else
                        PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    End If
                End If
            Else
                If Boolean.Parse(sender.SelectedCells.Item(sender.Columns("genero").Index).Value) Then
                    PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128png
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    PictureBox1.Image = Global.ECommercePlatformView.My.Resources.Person_128_Won_png
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Try
            Using detailPeople As New frmAdd_Personas(stateOperation.View, dtg.SelectedCells.Item(dtg.Columns("idPersona").Index).Value)
                With detailPeople
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class