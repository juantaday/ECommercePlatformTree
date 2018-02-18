Imports CADsisVenta.ClsSystem
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmRegistroEquipo
    Protected Friend idEquipo As Integer
    Protected Friend Operation As _operation
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Valida_Datos() Then
            Try

                Select Case Operation
                    Case _operation.Insert
                        If insertEquipoDeault(DominioText.Text, IpText.Text, Me.RemarskTextBox.Text) = True Then
                            Me.DialogResult = system.Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    Case _operation.Update
                        If updateEquipos(idEquipo, DominioText.Text, IpText.Text,
                                      RemarskTextBox.Text) = True Then
                            Me.DialogResult = system.Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                End Select

            Catch ex As Exception
                If ex.Message.Contains("UQ_") Then
                    MsgBox("Este dominio o código ya está regitrado", MsgBoxStyle.Exclamation, "Importante")
                End If
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmRegistroEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "Dominio [HotName]: " + Dominio._HotName + vbNewLine
        sql = sql + "Ip: " + Dominio._ip + vbNewLine
        sql = sql + "Validated Wep: " + Convert.ToString(Dominio.isWep)
        DescriptionText.Text = sql
        DominioText.Text = Dominio._HotName
        IpText.Text = Dominio._ip

        If isRegisterEquipo(Dominio._HotName) Then
            Me.OK_Button.Enabled = False
        End If


        Using adat As New EquiposTableAdapter
            Using dt As New EquiposDataTable
                adat.FillOneBydominio(dt, Dominio._HotName)
                If dt.Rows.Count > 0 Then
                    Me.RemarskTextBox.Text = dt.Rows(0)("Descripcion")
                End If
            End Using
        End Using
        Select Case Operation
            Case _operation.Insert
            Case _operation.Update
        End Select
    End Sub

    Private Function Valida_Datos() As Boolean
        Try
            If String.IsNullOrWhiteSpace(DominioText.Text) Then
                ErrorProvider1.SetError(DominioText, "Invalido")
                DominioText.Focus()
                Return False
            Else
                ErrorProvider1.SetError(DominioText, "")
            End If
            'ip
            If String.IsNullOrWhiteSpace(IpText.Text) Then
                ErrorProvider1.SetError(IpText, "Invalido")
                IpText.Focus()
                Return False
            Else
                ErrorProvider1.SetError(IpText, "")
            End If

            If String.IsNullOrWhiteSpace(RemarskTextBox.Text) Then
                ErrorProvider1.SetError(RemarskTextBox, "Invalido")
                RemarskTextBox.Focus()
                Return False
            Else
                ErrorProvider1.SetError(RemarskTextBox, "")
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class
