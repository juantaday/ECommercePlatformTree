Public Class FrmImputDate
    Protected Friend DateIni As DateTime
    Protected Friend DateFin As DateTime
    Private Sub FrmVentasxCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (DateIni.Year = 1) Then
            DateStart.Value = DateIni
            TimeStart.Value = DateIni
        Else
            DateStart.Value = Date.Today.AddYears(-1)
        End If
        If Not (DateFin.Year = 1) Then
            DateEnd.Value = DateFin
            TimeEnd.Value = DateFin
        Else
            DateEnd.Value = Date.Today
        End If
        AvilitaHora()
    End Sub
    Sub AvilitaHora()
        If IsHourCheckBox.Checked Then
            TimeStart.Visible = True
            TimeEnd.Visible = True
        Else
            TimeStart.Visible = False
            TimeEnd.Visible = False
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If IsHourCheckBox.Checked Then
                'fecha de inicio
                DateIni = DateStart.Value
                'restamos las horas registradas
                DateIni = DateIni.AddHours(-(DateIni.Hour))
                'luego restamos los minutos para volver ha cargar
                DateIni = DateIni.AddMinutes(-DateIni.Minute)
                'cargamos las nuevas horas
                DateIni = DateIni.AddHours(TimeStart.Value.Hour)
                DateIni = DateIni.AddMinutes(TimeStart.Value.Minute)

                '*************************************** la misma operacion rala fecha final
                DateFin = DateEnd.Value
                DateFin = DateFin.AddHours(-DateFin.Hour)
                DateFin = DateFin.AddMinutes(-DateFin.Minute)
                'vovemos ha gargar las horas
                DateFin = DateFin.AddHours(TimeEnd.Value.Hour)
                DateFin = DateFin.AddMinutes(TimeEnd.Value.Minute)
            Else
                DateIni = DateStart.Value
                'quitamos todos lo minuto que se cargo
                DateIni = DateIni.AddHours(-DateIni.Hour)
                DateIni = DateIni.AddMinutes(-DateIni.Minute)
                DateIni = DateIni.AddMilliseconds(-DateIni.Millisecond)

                DateFin = DateEnd.Value
                'quitamos las horas por defecto
                DateFin = DateFin.AddHours(-DateFin.Hour)
                DateFin = DateFin.AddMinutes(-DateFin.Minute)
                DateFin = DateFin.AddMilliseconds(-DateFin.Millisecond)
                'agregamos por que se considera que va ha cojer hasta las 12:59:59
                DateFin = DateFin.AddHours(23.9999)
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub IsHourCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsHourCheckBox.CheckedChanged
        AvilitaHora()
    End Sub
End Class