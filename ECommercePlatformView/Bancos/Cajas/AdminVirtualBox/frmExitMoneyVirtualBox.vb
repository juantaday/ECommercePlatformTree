Imports System.Windows.Forms

Public Class frmExitMoneyVirtualBox
    Protected Friend idbodega As Integer
    Protected Friend IdVirtualBox As Integer
    Protected Friend IdFormaPago As Integer
    Protected Friend MontoDivisa As Double

    Public Sub New(ByVal idBodega As Integer, ByVal montoDivisa As Double, _idVirtualBox As Integer, _idformaPago As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idbodega = idBodega
        Me.MontoDivisa = montoDivisa
        Me.IdVirtualBox = _idVirtualBox
        Me.IdFormaPago = _idformaPago
    End Sub
#Region "Forms"
    Private Sub frmExitMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.montoDivisaLabel.Text = "Monto divisa: " & Me.MontoDivisa.ToString("C2")
        If Me.IdVirtualBox = 0 Then
            MsgBox("No se ha determinado la caja ha administrar [IdCajaStado =0]", MsgBoxStyle.Exclamation, "Importante")
            Me.Close()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Radio Butonn"
    Private Sub virtualBoxRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("virtualBoxRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub

    Private Sub BankAccountRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BankAccountRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("BankAccountRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub

    Private Sub PaymentProviderRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PaymentProviderRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("PaymentProviderRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub
    Private Sub AccountEmployeeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AccountEmployeeRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("AccountEmployeeRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub
    Private Sub ExitOnwerRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ExitOnwerRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("UconExitDivisaToOnwer")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub


#End Region

#Region "Controllers"
    Private Function ControlCheck(sender As System.Object) As Boolean
        Try
            If Not (DirectCast(sender, RadioButton).Checked) Then
                Return False
            End If

            Select Case DirectCast(sender, RadioButton).Name
                Case "ExitOnwerRadioButton"
                    Return SetExitOnwerRadioButton()
                Case "virtualBoxRadioButton"
                    Return SetViartualBox()
                Case "BankAccountRadioButton"
                    SetBanckAccount()
                Case "PaymentProviderRadioButton"
                    SetPaymentProvider()
                Case "AccountEmployeeRadioButton"
                    SetAccountEmployee()
                Case ""

                Case ""


            End Select

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "Set View"

    Private Function SetExitOnwerRadioButton() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim _UconExitDivisaToOnwer = New ECommercePlatformView.UconExitDivisaToOnwer(Me, Me.IdVirtualBox)
            Me.PanelViewData.Controls.Add(_UconExitDivisaToOnwer)
            _UconExitDivisaToOnwer.Dock = DockStyle.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function SetPaymentProvider() As Boolean
        Try
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetViartualBox() As Boolean
        Try
            PanelViewData.Controls.Clear()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetBanckAccount() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim _UConBankDeposit = New ECommercePlatformView.UConBankDeposit(Me)
            Me.PanelViewData.Controls.Add(_UConBankDeposit)
            _UConBankDeposit.Dock = DockStyle.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetAccountEmployee() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim _UConAccountEmployee As New ECommercePlatformView.UConAccountEmployee(Me)
            PanelViewData.Controls.Add(_UConAccountEmployee)
            _UConAccountEmployee.Dock = DockStyle.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function



#End Region

End Class
