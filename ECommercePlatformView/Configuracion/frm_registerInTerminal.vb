Imports CADsisVenta.ClsSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frm_registerInTerminal
    Protected Friend Operation As _operation
    Protected Friend idEquipo As Integer
    Dim estaCargado As Boolean

    Private Sub frm_registerInTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            codTerminalTextBox.CharacterCasing = CharacterCasing.Upper

inicia:
            If IsNothing(Dominio._HotName) Then

            End If

            Dim tapt As New EquiposTableAdapter
            idEquipo = tapt.idEquipoByDominio(Dominio._HotName)

            If idEquipo = 0 Then
                MsgBox("Equipo no resgistrado. Registrese por favor.", MsgBoxStyle.Critical, "Importante")
                Using nnewregister As New frmRegistroEquipo
                    With nnewregister
                        .Operation = _operation.Insert
                        .StartPosition = FormStartPosition.CenterParent
                        .ShowDialog()
                        If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                            GoTo inicia
                        Else
                            Me.Close()
                            Return
                        End If
                    End With

                End Using
            End If

            If isRegisterInTerminal(Dominio._HotName) Then
                sql = "Este equipo ya esta ubicada en una estacinó." & vbNewLine
                sql = sql & "Puede cambiar su ubicación desde menu Configuración."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Aviso")
                Me.OK_Button.Enabled = False
            End If

            Carga_Domicio()
            Carga_bodega()
            Carga_Location()
            Carga_Datos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            If Valida_datos() Then
                Dim tadp As New TerminalTableAdapter
                Select Case Operation
                    Case _operation.Insert
                        If Not (tadp.InsertTerminal(idEquipo, BodegaComboBo.SelectedValue,
                                       LocattionComboBox.SelectedValue, codTerminalTextBox.Text) = 0) Then
                            Me.DialogResult = System.Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    Case _operation.Update

                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Valida_datos() As Boolean
        Try
            'bodega 
            If Not BodegaComboBo.SelectedIndex >= 0 Then
                ErrorProvider1.SetError(BodegaComboBo, "Selecccione uno del listado")
                BodegaComboBo.Focus()
                Return False
            Else
                ErrorProvider1.SetError(BodegaComboBo, "")
            End If
            'location
            If Not LocattionComboBox.SelectedIndex >= 0 Then
                ErrorProvider1.SetError(LocattionComboBox, "Selecccione uno del listado")
                LocattionComboBox.Focus()
                Return False
            Else
                ErrorProvider1.SetError(LocattionComboBox, "")
            End If
            'cod terminal

            If Not codTerminalTextBox.TextLength = 8 Then
                ErrorProvider1.SetError(codTerminalTextBox, "Debe tener 8 caracteres")
                codTerminalTextBox.Focus()
                Return False
            ElseIf String.IsNullOrWhiteSpace(codTerminalTextBox.Text) Then
                ErrorProvider1.SetError(codTerminalTextBox, "Invalido")
                codTerminalTextBox.Focus()
                Return False
            Else
                For Each tex In codTerminalTextBox.Text
                    If Not (Asc(tex) > 64 And Asc(tex) < 91) Then
                        If Not (Asc(tex) > 96 And Asc(tex) < 123) Then
                            If Not (Asc(tex) > 47 And Asc(tex) < 58) Then
                                If Not (Asc(tex) = 95) Then
                                    ErrorProvider1.SetError(codTerminalTextBox, "Invalido.. Sin espacios Letras o números")
                                    codTerminalTextBox.Focus()
                                    Return False
                                End If
                            End If
                        End If
                    End If
                Next
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub Carga_Domicio()
        DominioTextBox.Text = Dominio._HotName
        IpTextBox.Text = Dominio._ip
        IsValidatedWepTextBox.Text = Convert.ToString(Dominio.isWep)
    End Sub

    Private Sub Carga_bodega()
        estaCargado = False
        Try
            Dim tadp As New BodegaSystemTableAdapter
            BodegaComboBo.DataSource = tadp.GetData()
            If BodegaComboBo.Items.Count > 0 Then
                BodegaComboBo.DisplayMember = "Nom_Bodega"
                BodegaComboBo.ValueMember = "idBodega"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub

    Private Sub Carga_Location()
        estaCargado = False
        Try
            Dim tadp As New LocationTableAdapter
            LocattionComboBox.DataSource = tadp.GetData()
            If LocattionComboBox.Items.Count > 0 Then
                LocattionComboBox.DisplayMember = "Des_Location"
                LocattionComboBox.ValueMember = "idLocation"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub
    Private Sub Carga_Datos()
        Try
            Dim dt As New DataTable()
            dt = GetTerminalDataByDominio(Dominio._HotName)
            If dt.Rows.Count = 1 Then
                BodegaComboBo.SelectedValue = dt.Rows(0)("idBodega").ToString
                LocattionComboBox.SelectedValue = dt.Rows(0)("idLocation").ToString
                codTerminalTextBox.Text = dt.Rows(0)("codTerminal").ToString
            End If
            If Not IsNothing(dt) Then
                dt = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub codTerminalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codTerminalTextBox.KeyPress
        If InStr(" ", e.KeyChar) = 1 Then
            e.Handled = True
        End If
    End Sub
End Class