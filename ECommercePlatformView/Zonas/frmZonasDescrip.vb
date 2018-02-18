Imports CADsisVenta

Public Class frmZonasDescrip
    Protected Friend stateLoad As String
    Protected Friend id As Integer
    Protected Friend id_Provincia As Integer
    Protected Friend id_Canton As Integer
    Protected Friend id_Parroquia As Integer
    Protected Friend idPais As Integer
    Public Enum Estado
        Insert = 0
        Update = 1
    End Enum
    Private _action As Estado
    Public Property ActionProc As Estado
        Get
            Return _action
        End Get
        Set(value As Estado)
            _action = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidaDatos() Then
            If Operations() Then
                DialogResult = System.Windows.Forms.DialogResult.OK
                Close()
            End If
        End If
    End Sub
    Private Function ValidaDatos() As Boolean
        Try
            If NomTextBox.Text.Length = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Operations() As Boolean
        Try
            Select Case stateLoad
                Case "Pais"
                    Return Pais()
                Case "Provincia"
                    Return Provincia()
                Case "Canton"
                    Return Canton()
                Case "Parroquia"
                    Return Parroquia()
                Case "Sector"
                    Return Sector()
            End Select
            Return False
        Catch ex As Exception
            If ex.Message.Contains("UQ_") Then
                sql = "Ya existe esta información..." & vbNewLine
                sql = sql & "!" & NomTextBox.Text & "¡"
                MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Provincia() As Boolean
        Select Case ActionProc
            Case Estado.Insert
                If Not ClsZona.InsertProvincia(NomTextBox.Text, idPais, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
            Case Estado.Update
                If Not ClsZona.UpdateProvincia(id, NomTextBox.Text, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function
    Private Function Pais() As Boolean
        Select Case ActionProc
            Case Estado.Insert
                If Not ClsZona.InsertPais(NomTextBox.Text) = 0 Then
                    Return True
                End If
            Case Estado.Update
                If Not ClsZona.UpdatePais(id, NomTextBox.Text) = 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmZonasDescrip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomTextBox.CharacterCasing = CharacterCasing.Upper
        If stateLoad = "Provincia" Then
            If IsNothing(idPais) Then
                MsgBox("No se determino el id del pais")
                Close()
                Return
            ElseIf idPais = 0 Then
                MsgBox("No se determino el id del pais")
                Close()
                Return
            End If
        End If
    End Sub
    Private Sub NomTextBox_Leave(sender As Object, e As EventArgs) Handles NomTextBox.Leave
        NomTextBox.Text = Trim(NomTextBox.Text)
    End Sub

    Private Function Canton() As Boolean
        Select Case ActionProc
            Case Estado.Insert
                If Not ClsZona.InsertCanton(id_Provincia, NomTextBox.Text, LongitudNumericUpDown.Value, LatitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
            Case Estado.Update
                If Not ClsZona.UpdateCanton(id, id_Provincia, NomTextBox.Text, LongitudNumericUpDown.Value, LatitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function
    Private Function Parroquia() As Boolean
        Select Case ActionProc
            Case Estado.Insert
                If Not ClsZona.InsertParroquia(id_Canton, NomTextBox.Text, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
            Case Estado.Update
                If Not ClsZona.UpdateParroquia(id, id_Canton, NomTextBox.Text, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function
    Private Function Sector() As Boolean
        Select Case ActionProc
            Case Estado.Insert
                If Not ClsZona.InsertSector(id_Parroquia, NomTextBox.Text, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
            Case Estado.Update
                If Not ClsZona.UpdateSector(id, id_Parroquia, NomTextBox.Text, LatitudNumericUpDown.Value, LongitudNumericUpDown.Value) = 0 Then
                    Return True
                End If
        End Select
        Return False
    End Function
End Class
