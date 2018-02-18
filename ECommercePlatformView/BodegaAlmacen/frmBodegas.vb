Imports System.Data.SqlClient
Imports CADsisVenta.ClsSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmBodegas
    Dim idRowSelect As Integer = -1
    Private idBodega As Integer
    Private estaCargado As Boolean
    Private idEquipo As Integer
    Private idTerminal As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.ValidaDatos Then
            If Edita_Terminal() Then
                GetInformationServices.GeneralInformation.Inicia_Terminal(True)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function ValidaDatos() As Boolean
        Try
            If String.IsNullOrWhiteSpace(codTerminalTextBox.Text) Then
                ErrorProvider1.SetError(codTerminalTextBox, "Debe asignar un código")
                Return False
            End If

            If Not (codTerminalTextBox.Text.Length = 8) Then
                ErrorProvider1.SetError(codTerminalTextBox, "Se requiere de 8 caracteres")
                Return False
            End If
            If LocattionComboBox.SelectedIndex = -1 Then
                ErrorProvider1.SetError(LocattionComboBox, "Seleccione una de esta lista")
                Return False
            End If

            ErrorProvider1.SetError(codTerminalTextBox, String.Empty)
            ErrorProvider1.SetError(LocattionComboBox, String.Empty)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function Edita_Terminal() As Boolean
        Try
            Using dat As New TerminalTableAdapter
                If dat.UpdateTerminal(idEquipo,
                                      idBodega,
                                      LocattionComboBox.SelectedValue,
                                      codTerminalTextBox.Text, idTerminal) = 1 Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            If ex.Message.Contains("UK_codTerminal_Teminales") Then
                MsgBox("Ya existe otro equipo regristrado con este código.", MsgBoxStyle.Critical, "Error")
                ErrorProvider1.SetError(codTerminalTextBox, "Ya existe otro equipo regristrado con este código")
            ElseIf ex.Message.Contains("UK_idEquipo_Teminales") Then
                MsgBox("Es posible que este dominio este usando otro Equipo.", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try
    End Function
    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        If Me.datalistado.SelectedRows.Count = 1 Then
            Me.OK_Button.Enabled = True
        Else
            Me.OK_Button.Enabled = False
        End If
    End Sub
    Private Function Carga_Bodegas() As Boolean

        sql = "SELECT b.idbodega, CAST(IIF(ISNULL((select top(1) f.idTerminal from [STM].Terminal as f  "
        sql = sql & "where f.codTerminal ='" & TerminalActivo.codTerminal & "' and f.idBodega = b.idbodega),0)= 0,0,1) AS bit) AS Selecciona,  "
        sql = sql & "b.Nom_Bodega, b.Direc_Bodega, b.Telef1_Bodega "
        sql = sql & "FROM Bodegas as b "
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                dat.Fill(dt)
                Me.datalistado.DataSource = Nothing
                If dt.Rows.Count > 0 Then
                    Me.datalistado.DataSource = dt
                    Me.datalistado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    Me.datalistado.Columns(0).Visible = False
                    Return True
                Else
                    Return False
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.datalistado.DataSource = Nothing
            Return False
        End Try

    End Function
    Private Sub frmBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If Not isRegisterInTerminal(Dominio._HotName) Then
                sql = "Equipo no registrado en una estación" & vbNewLine
                sql = sql & "Solicite a su administrador.."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Aviso")
                Me.DialogResult = DialogResult.No
                Me.Close()
                Return
            End If
inicia:
            Dim tapt As New EquiposTableAdapter
            Dim _Respon As Integer? = tapt.idEquipoByDominio(Dominio._HotName)
            idEquipo = _Respon
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
            Carga_Bodegas()
            Carga_Domicio()
            Carga_bodega()
            Carga_Location()
            Carga_Datos()
        Catch ex As Exception
            MsgBox(ex.Message + " " + ex.StackTrace.ToString + " " + ex.TargetSite.ToString(), MsgBoxStyle.Critical, "Error")
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
    Private Sub Carga_Domicio()
        DominioTextBox.Text = Dominio._HotName
        IpTextBox.Text = Dominio._ip
        IsValidatedWepTextBox.Text = Convert.ToString(Dominio.isWep)
    End Sub
    Private Sub Carga_Datos()
        Try
            Dim dt As New DataTable()
            dt = GetTerminalDataByDominio(Dominio._HotName)
            If dt.Rows.Count = 1 Then
                idTerminal = dt.Rows(0)("idTerminal").ToString
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

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If (e.ColumnIndex = sender.Columns.Item("Selecciona").Index) And e.RowIndex >= 0 Then
            Dim chkcell As DataGridViewCheckBoxCell = sender.Rows(e.RowIndex).Cells("Selecciona")
            If Not Boolean.Parse(chkcell.Value) Then
                chkcell.Value = True
                idBodega = Me.datalistado.Rows(e.RowIndex).Cells(0).Value
            End If
            idRowSelect = e.RowIndex
            EliminaSelecio()
        End If
    End Sub
    Private Sub EliminaSelecio()
        For i = 0 To Me.datalistado.Rows.Count - 1
            If i <> idRowSelect Then
                datalistado.Rows(i).Cells(1).Value = False
            End If
        Next
    End Sub

    Private Sub datalistado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datalistado.CellFormatting
        If e.ColumnIndex = sender.Columns.Item("Selecciona").Index And e.RowIndex >= 0 Then
            If Boolean.Parse(e.Value) Then
                idBodega = Me.datalistado.Rows(e.RowIndex).Cells(0).Value
            End If
        End If
    End Sub

    Private Sub RefreshCodTerminalButton_Click(sender As Object, e As EventArgs) Handles RefreshCodTerminalButton.Click
        Me.Carga_Datos()
    End Sub
End Class
