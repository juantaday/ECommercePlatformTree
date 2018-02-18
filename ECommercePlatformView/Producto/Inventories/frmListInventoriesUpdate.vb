Imports System.Windows.Forms
Imports CADsisVenta

Public Class frmListInventoriesUpdate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListInventoriesUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Predicted()
    End Sub

    Private Sub Predicted()
        ListModeFindComboBox.SelectedIndex = 0
        Load_Default()
    End Sub

    Private Sub Load_Default()
        Try
            Using db As New DataContext
                ' load the list
                Dim dt = (From i In db.Inventory
                          Join b In db.Bodegas
                                 On i.IdBodega Equals b.idBodega
                          Where i.State > 0
                          Order By i.DateTimeStar Descending
                          Select i.IdInventory, b.Nom_Bodega, i.DateTimeStar, i.CodUserStar, i.State)
                ViewData(dt)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ViewData(data As IQueryable(Of Object))

        Try
            Dim view = (From i In data.ToList()
                        Select i.IdInventory, i.Nom_Bodega, i.DateTimeStar, i.CodUserStar, i.State,
                                    Estado = If(i.State = 0, "Actualizado(Finalizado)",
                                                    If(i.State = 1, "Iniciado",
                                                    If(i.State = 2, "En proceso",
                                                   If(Not IsNothing(i.State), "No definido", "-")))))

            dtgList.DataSource = view.ToList()
            applyGridTheme(dtgList)

            clm = dtgList.Columns("State")
            clm.Visible = False

            clm = dtgList.Columns("IdInventory")
            clm.HeaderText = "Operación"

            clm = dtgList.Columns("Nom_Bodega")
            clm.HeaderText = "Bodega"

            clm = dtgList.Columns("DateTimeStar")
            clm.HeaderText = "Fecha de inicio"

            clm = dtgList.Columns("CodUserStar")
            clm.HeaderText = "Usuario cread@r"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Select Case ListModeFindComboBox.Text
                Case "En proceso de actualización."
                    Me.EditConinueButton.Enabled = True
                    Me.DeleteButton.Enabled = True
                    Load_Default()
                Case "Finalizado (Historial)."
                    Me.EditConinueButton.Enabled = False
                    Me.DeleteButton.Enabled = False
                    Using db As New DataContext
                        ' load the list
                        Dim dt = (From i In db.Inventory
                                  Join b In db.Bodegas
                                         On i.IdBodega Equals b.idBodega
                                  Where i.State = 0
                                  Order By i.DateTimeStar Descending
                                  Select i.IdInventory, b.Nom_Bodega, i.DateTimeStar, i.CodUserStar, i.State)
                        ViewData(dt)
                    End Using
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If Not dtgList.SelectedRows.Count = 1 Then
                MsgBox("Seleccione uno de la lista", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            If dtgList.SelectedRows(0).Cells(dtgList.Columns("State").Index).Value = 0 Then
                MsgBox("Proceso cerrado, imposible emilinar.", MsgBoxStyle.Critical, "Importante")
                Return
            End If

            If Not dtgList.SelectedRows(0).Cells(dtgList.Columns("CodUserStar").Index).Value = UsuarioActivo.codUser Then
                Using newform As New LoginForm(stateReturn._response, "Administrador de inventarios")
                    With newform

                        .Text = "Validando para eliminar"
                        .ShowDialog()
                        If Not (.DialogResult = DialogResult.OK) Then
                            Return
                        End If
                    End With
                End Using
            End If

            If Not (MsgBox("Está seguro de eliminar.?", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Responda") = MsgBoxResult.Yes) Then
                Return
            End If

            If Delete_data(dtgList.SelectedRows(0).Cells(dtgList.Columns("IdInventory").Index).Value) Then
                MsgBox("Eliminación exitosa.?", MsgBoxStyle.Information, "Aviso")
                findButton.PerformClick()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function Delete_data(id As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim Inventory =
                       (From i In db.Inventory()
                        Where i.IdInventory = id
                        Select i).ToList()(0)

                db.Inventory.DeleteOnSubmit(Inventory)
                db.SubmitChanges()
                Return True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub EditConinueButton_Click(sender As Object, e As EventArgs) Handles EditConinueButton.Click
        Try
            If Not dtgList.SelectedRows.Count = 1 Then
                MsgBox("Seleccione uno de la lista", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            Dim id As Integer = dtgList.SelectedRows(0).Cells(dtgList.Columns("IdInventory").Index).Value
            Dim state As Int16 = dtgList.SelectedRows(0).Cells(dtgList.Columns("State").Index).Value
            Using listinventor As New frm_ListInventories(stateOperation.Update, id)
                With listinventor
                    .WindowState = FormWindowState.Maximized
                    If state = 0 Then
                        .Text = "Detalle de la operación: " & id
                    Else
                        .Text = "Modificando la operación: " & id
                    End If
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListModeFindComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListModeFindComboBox.SelectedIndexChanged
        findButton.PerformClick()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If Not dtgList.SelectedRows.Count = 1 Then
            MsgBox("Seleccione uno de la lista", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        Try
            Dim id As Integer = dtgList.SelectedRows(0).Cells(dtgList.Columns("IdInventory").Index).Value
            Dim state As Int16 = dtgList.SelectedRows(0).Cells(dtgList.Columns("State").Index).Value
            Using newRepor As New frmReportInventoriesUpdates(id)
                With newRepor
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
