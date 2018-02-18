Public Class MDIcajas
    Private idCajaStado As Integer
    Private viewLoad As viewLoadReport
    Public Sub New(idCajaStado As Integer, viewLoad As viewLoadReport)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idCajaStado = idCajaStado
        Me.viewLoad = viewLoad
    End Sub
    Private Sub MycajaLabel_Click(sender As Object, e As EventArgs)
        If sender.tag = 1 Then
            PanelUser.Height = sender.Height
            sender.tag = 0
        Else
            If sender.tag = 0 Then
                PanelUser.Height = 140
                sender.tag = 1
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        If sender.tag = 1 Then
            Panel1.Height = sender.Height
            sender.tag = 0
        Else
            If sender.tag = 0 Then
                Panel1.Height = 140
                sender.tag = 1
            End If
        End If
    End Sub

    Private Sub CollapMycajaButton_Click(sender As Object, e As EventArgs) Handles CollapMycajaButton.Click
        CollapCotrol(sender)
    End Sub
    Sub CollapCotrol(sender As Object)
        Dim _control As System.Windows.Forms.Panel = sender.Parent
        Try
            If sender.tag = 0 Then
                sender.Image = ECommercePlatformView.My.Resources.Resources.hamburger_22_white
                _control.Height = sender.Height
                _control.BackColor = Color.DimGray
                sender.BackColor = Color.DimGray
                sender.tag = 1
            Else
                sender.Image = ECommercePlatformView.My.Resources.Resources.hamburger_22_Down_white
                _control.Height = 140
                _control.BackColor = PanelMenu.BackColor
                sender.BackColor = Color.Black
                sender.tag = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub MySaldoButton_Click(sender As Object, e As EventArgs) Handles MySaldoButton.Click
        Try
            If IsNothing(TerminalActivo.idTerminal) Then
                MsgBox("No se ha tederminado el terminal", MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If

            If Not (IsNumeric(TerminalActivo.idTerminal)) Then
                MsgBox("No se ha tederminado el terminal", MsgBoxStyle.Exclamation, "Aviso")
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim frmCaja_stado As New FrmSaldo_caja(Me.idCajaStado, True)
            With frmCaja_stado
                .MdiParent = Me
                .codTerminal = TerminalActivo.codTerminal
                .idTerminal = TerminalActivo.idTerminal
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            CierroIndeseales(frmCaja_stado.Name)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub MDIcajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formnew As New System.Windows.Forms.Form With {
            .Name = "frmPanelCaja",
            .WindowState = FormWindowState.Maximized,
            .BackColor = Color.White}
        With formnew
            .MdiParent = Me
            .Show()
        End With
        AddHandler formnew.FormClosing, AddressOf FormClosing_formnew
        'Cierra collapsible
        Admin_Collapsible()
        If viewLoad = viewLoadReport.Select_ Then
            MySaldoButton.PerformClick()
            PanelMenu.Visible = False
        End If
    End Sub

    Private Sub FormClosing_formnew(sender As Object, e As FormClosingEventArgs)
        Try
            e.Cancel = True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CollapAdminButton_Click(sender As Object, e As EventArgs) Handles CollapAdminButton.Click
        CollapCotrol(sender)
    End Sub

    Private Sub Admin_Collapsible()
        CollapCotrol(CollapMycajaButton)
        CollapCotrol(CollapAdminButton)
        CollapCotrol(CollapVirtualButton)
        CollapCotrol(CollapPropertyButton)
    End Sub

    Private Sub CollapVirtualButton_Click(sender As Object, e As EventArgs) Handles CollapVirtualButton.Click
        CollapCotrol(sender)
    End Sub
    Private Sub pintaControl(sender As Object)
        Try
            For Each _control In PanelMenu.Controls
                If TypeOf (_control) Is Panel Then
                    For Each _control2 In _control.Controls
                        If _control2.NAME = sender.NAME Then
                            _control2.BackColor = Color.Blue
                        ElseIf _control2.name.ToString.Contains("Collap") Then
                        Else
                            _control2.BackColor = PanelUser.BackColor
                        End If
                    Next
                ElseIf _control.name = sender.Name Then
                    _control.BackColor = Color.Blue
                ElseIf _control.name.ToString.Contains("Collap") Then
                    sql = sql
                Else
                    _control.BackColor = PanelUser.BackColor
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MovimButton_Click(sender As Object, e As EventArgs) Handles MovimButton.Click
        Try
            If TerminalActivo.idTerminal = 0 Then
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim frmCaja_stado As New frmListMoviSalidaCaja(TerminalActivo.idTerminal)
            With frmCaja_stado
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            CierroIndeseales(frmCaja_stado.Name)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub UltCierreButton_Click(sender As Object, e As EventArgs) Handles UltCierreButton.Click
        pintaControl(sender)
    End Sub

    Private Sub CierroIndeseales(ByVal notClosedName As String)
        Try
            For Each forms In Me.MdiChildren
                If Not forms.Name = notClosedName Then
                    forms.Close()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SaldoEnCajasButton_Click(sender As Object, e As EventArgs) Handles SaldoEnCajasButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim frmCaja_stado As New frmSaldo_Terminales(Me)
            With frmCaja_stado
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub HabilitaTerminalButton_Click(sender As Object, e As EventArgs) Handles HabilitaTerminalButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim frmCaja_stado As New frmHabilitaTerminal()
            With frmCaja_stado
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub VirtualBoxBalanceButton_Click(sender As Object, e As EventArgs) Handles VirtualBoxBalanceButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim newfrmVirtualBoxBalance As New frmVirtualBoxBalance()
            With newfrmVirtualBoxBalance
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FaltantesButton_Click(sender As Object, e As EventArgs) Handles FaltantesButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim newfrmFaltantes As New frmFaltantesSobrantes()
            With newfrmFaltantes
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PropertycollapsyButton_Click(sender As Object, e As EventArgs) Handles CollapPropertyButton.Click
        CollapCotrol(sender)
    End Sub

    Private Sub BalanzaDivisaButton_Click(sender As Object, e As EventArgs) Handles BalanzaDivisaButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim newfrmStadoDivisas As New frmStadoDivisas()
            With newfrmStadoDivisas
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub ExitDivisaButton_Click(sender As Object, e As EventArgs) Handles ExitDivisaButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim newfrmExitDivisaInVirtualBox As New frmExitDivisaInVirtualBox()
            With newfrmExitDivisaInVirtualBox
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListOperacionButton_Click(sender As Object, e As EventArgs) Handles ListOperacionButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CierroIndeseales(String.Empty)
            Dim frmCaja_stado As New frmClosedTransactionsTerminal()
            With frmCaja_stado
                .MdiParent = Me
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
            pintaControl(sender)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class