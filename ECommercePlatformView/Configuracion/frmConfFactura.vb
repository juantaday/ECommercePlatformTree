Imports CADsisVenta.ClsSystem
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmConfFactura
    Private idTerminal As Integer
    Private idTerminalConfig As Integer
    Private Sub frmConfFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        idTerminal = GetIdTerminal(Dominio._HotName)
        idTerminalConfig = 0
        If Not (idTerminal = 0) Then
            Carga_DocumentList()
            Carga_Domicio()
        Else
            MsgBox("Registre este equipo mediante la opcion Herraminetas-Registro equipo ", MsgBoxStyle.Critical, "Importante")
            Me.OK_Button.Enabled = False
        End If
    End Sub

    Private Sub Carga_Domicio()
        DominioTextBox.Text = Dominio._HotName
        IpTextBox.Text = Dominio._ip
        IsValidatedWepTextBox.Text = Convert.ToString(Dominio.isWep)
    End Sub
    Private Sub Carga_DocumentList()
        Try
            DocumentListBox.DataSource = Nothing
            Dim adpt As New TypoDocumentoTableAdapter
            Dim dt As DataTable
            dt = adpt.GetData
            If IsNothing(dt) Then
                Return
            End If
            If dt.Rows.Count > 0 Then
                DocumentListBox.DataSource = dt
                DocumentListBox.DisplayMember = "Nom_Docu"
                DocumentListBox.ValueMember = "idTypoDocu"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            DocumentListBox.DataSource = Nothing
        End Try
    End Sub
    Private Sub Carga_NumDocument(idDocument As Integer, idTerminal As Integer)
        Try
            txtnumfactur1.Text = String.Empty
            txtnumfactur2.Text = String.Empty
            txtnumfactur3.Text = String.Empty
            txtnumfactur4.Text = String.Empty
            Using dat As New TerminalConfiTableAdapter
                Using dt As New TerminalConfiDataTable
                    dat.FillByIdTerminalIdDocument(dt, idTerminal, idDocument)
                    If dt.Rows.Count = 1 Then
                        idTerminalConfig = dt.Rows(0)("idTerminalConfi").ToString
                        txtnumfactur1.Text = dt.Rows(0)("NumFact01").ToString
                        txtnumfactur2.Text = dt.Rows(0)("NumFact02").ToString
                        txtnumfactur3.Text = dt.Rows(0)("NumFact03").ToString
                        txtnumfactur4.Text = dt.Rows(0)("NumFact04").ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub DocumentListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DocumentListBox.SelectedIndexChanged
        Try
            If DocumentListBox.ValueMember.ToString.Length > 0 Then
                If DocumentListBox.SelectedIndex >= 0 Then
                    idTerminalConfig = 0
                    Carga_NumDocument(DocumentListBox.SelectedValue, Me.idTerminal)
                    DetailNumberGroupBox.Text = "Detalle de nueración de: " & DocumentListBox.Text
                    Me.EliminaErrorIcono()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EliminaErrorIcono()
        ErrorIcono.SetError(txtnumfactur1, "")
        ErrorIcono.SetError(txtnumfactur2, "")
        ErrorIcono.SetError(txtnumfactur3, "")
        ErrorIcono.SetError(txtnumfactur4, "")
        txtnumfactur1.BackColor = Color.White
        txtnumfactur2.BackColor = Color.White
        txtnumfactur3.BackColor = Color.White
        txtnumfactur4.BackColor = Color.White
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim response As Boolean = False
        If Me.validaDatos() Then
            If Me.idTerminalConfig = 0 Then
                response = Me.InsertNumDocument()
            Else
                response = Me.UpdateNumDocument()
            End If
        End If
        If response Then
            MsgBox("Modificada Correctamete", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Function UpdateNumDocument() As Boolean
        Try
            Using dat As New TerminalConfiTableAdapter
                If dat.UpdateNumDocument(txtnumfactur1.Text,
                                         txtnumfactur2.Text,
                                         txtnumfactur3.Text,
                                         txtnumfactur4.Text,
                                         Me.idTerminalConfig) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function InsertNumDocument() As Boolean
        Try
            Dim typePrint As String = String.Empty
            Using dat As New TerminalConfiTableAdapter
                If dat.InsertNumDocument(txtnumfactur1.Text,
                                         txtnumfactur2.Text,
                                         txtnumfactur3.Text,
                                         txtnumfactur4.Text,
                                         Me.idTerminal,
                                         Me.DocumentListBox.SelectedValue, typePrint:=typePrint) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function validaDatos() As Boolean
        Try
            'null
            If String.IsNullOrEmpty(txtnumfactur1.Text) Then
                ErrorIcono.SetError(txtnumfactur1, "Datos requeridos")
                txtnumfactur1.BackColor = Color.Red
                Return False
            Else
                txtnumfactur1.BackColor = Color.White
            End If
            If String.IsNullOrEmpty(txtnumfactur2.Text) Then
                ErrorIcono.SetError(txtnumfactur2, "Datos requeridos")
                txtnumfactur2.BackColor = Color.Red
                Return False
            Else
                txtnumfactur2.BackColor = Color.White
            End If
            If String.IsNullOrEmpty(txtnumfactur3.Text) Then
                ErrorIcono.SetError(txtnumfactur3, "Datos requeridos")
                txtnumfactur3.BackColor = Color.Red
                Return False
            Else
                txtnumfactur3.BackColor = Color.White
            End If
            If String.IsNullOrEmpty(txtnumfactur4.Text) Then
                ErrorIcono.SetError(txtnumfactur4, "Datos requeridos")
                txtnumfactur4.BackColor = Color.Red
                Return False
            Else
                txtnumfactur4.BackColor = Color.White
            End If
            ' length
            If Not txtnumfactur1.Text.Length = 3 Then
                ErrorIcono.SetError(txtnumfactur1, "Tres caracteres")
                txtnumfactur1.BackColor = Color.Red
                Return False
            Else
                txtnumfactur1.BackColor = Color.White
            End If
            If Not txtnumfactur2.Text.Length = 3 Then
                ErrorIcono.SetError(txtnumfactur2, "Tres caracteres")
                txtnumfactur2.BackColor = Color.Red
                Return False
            Else
                txtnumfactur2.BackColor = Color.White
            End If
            If Not txtnumfactur3.Text.Length = 2 Then
                ErrorIcono.SetError(txtnumfactur3, "Dos caracteres")
                txtnumfactur3.BackColor = Color.Red
                Return False
            Else
                txtnumfactur3.BackColor = Color.White
            End If
            If Not txtnumfactur4.Text.Length = 7 Then
                ErrorIcono.SetError(txtnumfactur4, "Siete caracteres")
                txtnumfactur4.BackColor = Color.Red
                Return False
            Else
                txtnumfactur4.BackColor = Color.White
            End If

            If DocumentListBox.SelectedIndex = -1 Then
                ErrorIcono.SetError(DocumentListBox, "Debe seleccionar uno de la lista")
                Return False
            End If
            If idTerminal = 0 Then
                MsgBox("Por alguna razón no se determinó la IdTerminal", MsgBoxStyle.Exclamation, "Importante")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub txtnumfactur1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumfactur1.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
            Return
        End If
        If e.KeyChar = vbBack Then
            Return
        End If
        If Not (InStr("0123456789", e.KeyChar) > 0) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub txtnumfactur2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumfactur2.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
            Return
        End If
        If e.KeyChar = vbBack Then
            Return
        End If
        If Not (InStr("0123456789", e.KeyChar) > 0) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub txtnumfactur3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumfactur3.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
            Return
        End If
        If e.KeyChar = vbBack Then
            Return
        End If
        If Not (InStr("0123456789", e.KeyChar) > 0) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub txtnumfactur4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumfactur4.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
            Return
        End If
        If e.KeyChar = vbBack Then
            Return
        End If
        If Not (InStr("0123456789", e.KeyChar) > 0) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub StarNumberButton_Click(sender As Object, e As EventArgs) Handles StarNumberButton.Click
        txtnumfactur1.Text = "000"
        txtnumfactur2.Text = "000"
        txtnumfactur3.Text = "00"
        txtnumfactur4.Text = "0000001"
    End Sub
End Class
