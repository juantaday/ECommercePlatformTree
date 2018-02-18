Imports System.Windows.Forms
Public Class frmList_EmployeeDebit
    Private IdPerson As Integer
    Sub New(ByVal _IdPerson As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IdPerson = _IdPerson
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmList_EmployeeDebit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemBebitEmployee1 = New ECommercePlatformView.ItemBebitEmployee(Me.IdPerson, Me)
        Me.ElementHost1.Child = Me.ItemBebitEmployee1
        Cursor = Cursors.Default
    End Sub
End Class
