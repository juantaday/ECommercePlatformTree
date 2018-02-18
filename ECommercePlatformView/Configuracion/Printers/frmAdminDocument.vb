Imports System.Windows.Forms
Imports CADsisVenta

Public Class frmAdminDocument
    Private isLoated As Boolean
    Private Sub frmSettingDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_CategoryDocument()
        isLoated = True
        ListBoxControl1_SelectedIndexChanged(Me.ListBoxControl1, New System.EventArgs)
    End Sub
    Private Sub Load_CategoryDocument()
        Try
            Using db As New DataContext
                Dim lisCategory = From c In db.DocumentCaregory

                If Not (lisCategory Is Nothing) Then
                    ListBoxControl1.DataSource = lisCategory.ToList()
                    ListBoxControl1.DisplayMember = "NameDocumentCatg"
                    ListBoxControl1.ValueMember = "IdDocumentCaregory"
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedIndexChanged
        If isLoated Then
            If Not ListBoxControl1.SelectedIndex = -1 Then
                Loated_Detail(Integer.Parse(ListBoxControl1.SelectedValue))
            End If
        End If
    End Sub

    Private Sub Loated_Detail(v As Integer)
        Try
            Using db As New DataContext
                Dim lisCategory = From c In db.TypoDocumento
                                  Where c.IdDocumentCaregory = v

                If Not (lisCategory Is Nothing) Then
                    ListBoxControl2.DataSource = lisCategory.ToList()
                    ListBoxControl2.DisplayMember = "Nom_Docu"
                    ListBoxControl2.ValueMember = "idTypoDocu"
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            'agregar
            If Me.ListBoxControl1.SelectedIndex = -1 Then
                MsgBox("Selccione la caregoria del documento.", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            sql = InputBox("Escriba el nombre del nuevo documento", "Dialogo")
            sql = Trim(sql)
            If sql.Length > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Using db As New DataContext
                    Dim document As New TypoDocumento With
                    {
                    .Nom_Docu = sql,
                    .generate = 14,
                    .Indefinite = False,
                    .IdDocumentCaregory = Integer.Parse(Me.ListBoxControl1.SelectedValue)
                    }

                    db.TypoDocumento.InsertOnSubmit(document)
                    db.SubmitChanges()
                End Using
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'editar
        If Me.ListBoxControl2.SelectedIndex = -1 Then
            MsgBox("Selccione uno de los documentos.", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        Try
            sql = InputBox("Cambie el nombre del documento", "Dialogo", Me.ListBoxControl2.Text)
            sql = Trim(sql)
            If sql.Length > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Using db As New DataContext
                    Dim lisCategory = (From c In db.TypoDocumento
                                       Where c.idTypoDocu = Me.ListBoxControl2.SelectedValue).FirstOrDefault


                    lisCategory.Nom_Docu = sql

                    db.SubmitChanges()
                End Using
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'delete 
        If Me.ListBoxControl2.SelectedIndex = -1 Then
            MsgBox("Selccione uno de los documentos.", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If

        If Not MsgBox("Esta seguro de eliminar el doumento seleccionado.",
                  MsgBoxStyle.YesNo + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responta") = vbYes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Using db As New DataContext
                Dim lisCategory = From c In db.TypoDocumento
                                  Where c.idTypoDocu = Me.ListBoxControl2.SelectedValue

                For Each item In lisCategory
                    db.TypoDocumento.DeleteOnSubmit(item)
                Next
                db.SubmitChanges()
            End Using
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
