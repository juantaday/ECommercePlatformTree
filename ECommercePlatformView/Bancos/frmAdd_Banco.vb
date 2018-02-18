Imports System.Windows.Forms
Imports CADsisVenta.DataSetPersonTableAdapters

Public Class frmAdd_Banco
    Private state As stateOperation
    Private nameBanco As String
    Private telefoBanco As String
    Private idBancos As Integer
    Sub New(stateOpen As stateOperation, idBancos As Integer, nameBanco As String, telefoBanco As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.state = stateOpen
        Me.idBancos = idBancos
        Me.nameBanco = nameBanco
        Me.telefoBanco = telefoBanco
        If Me.state = stateOperation.Delete Then
            If Me.DeleteBanco(idBancos) Then
                Me.DialogResult = DialogResult.OK
            Else
                Me.DialogResult = DialogResult.No
            End If
        End If
    End Sub
    Private Sub frmAdd_Banco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case state
            Case stateOperation.Insert
                Me.Label1.Text = "Agregando"
            Case stateOperation.Update
                Me.Label1.Text = "Modificando"
                NameBancoTextBox.Text = nameBanco
                Me.TelefonoTextBox.Text = telefoBanco
            Case stateOperation.Delete
        End Select
        NameBancoTextBox.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        If ValidaDatos() Then
            Dim acction As Boolean = False
            Select Case state
                Case stateOperation.Insert
                    Me.Label1.Text = "Agregando"
                    acction = Me.AddBanco()
                Case stateOperation.Update
                    Me.Label1.Text = "Modificando"
                    acction = Me.EditBanco(Me.idBancos)
                Case stateOperation.Delete
                    acction = Me.DeleteBanco(Me.idBancos)
            End Select
            If acction Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function DeleteBanco(idBancos As Integer) As Boolean
        Try
            Dim dta As New BancosTableAdapter
            If dta.DeleteBancos(idBancos) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.Message.Contains("REFERENCE") Then
                MsgBox("No se puede borrar porque existe infomación relacionada con este registro ", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try
    End Function

    Private Function EditBanco(idBancos As Integer) As Boolean
        Try
            Dim dta As New BancosTableAdapter
            If dta.UpdateBancos(NameBancoTextBox.Text, TelefonoTextBox.Text, idBancos) = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function AddBanco() As Boolean
        Try
            Dim dta As New BancosTableAdapter
            If dta.InsertBancos(NameBancoTextBox.Text, TelefonoTextBox.Text) = 1 Then
                Return True
            Else

                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ValidaDatos() As Boolean
        Try
            NameBancoTextBox.Text = UCase(Trim(NameBancoTextBox.Text))
            TelefonoTextBox.Text = UCase(Trim(TelefonoTextBox.Text))
            If String.IsNullOrEmpty(NameBancoTextBox.Text) Then
                MsgBox("Debe ingresar el nombre del banco", MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

End Class
