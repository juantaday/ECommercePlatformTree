Imports System.Windows.Forms

Public Class frmDescriptionInventories
    Private Operation As stateOperation
    Private IdInventory As Integer
    Sub New(ByVal stateOperation As stateOperation, ByVal id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.IdInventory = id
        Me.Operation = stateOperation
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ObservationRichTextBox.TextLength = 0 Then
            MsgBox("Determine el motivo.", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDescriptionInventories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Operation
            Case stateOperation.Insert
            Case stateOperation.Update
                Load_Observation()
            Case stateOperation.View
                Me.OK_Button.Enabled = False
        End Select
    End Sub

    Private Sub Load_Observation()
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
