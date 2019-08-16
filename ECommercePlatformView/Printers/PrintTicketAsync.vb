Imports System.Threading
Imports System.Drawing.Printing
Imports System.IO
Imports CADsisVenta
Imports CADsisVenta.DataSetFacturaVenta
Imports CADsisVenta.DataSetFacturaVentaTableAdapters
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class PrintTicketAsync
    Private _claveAcceso As String
    Private _cancelTokenSource As CancellationTokenSource

    Public ActionToExecute As Action(Of CancellationToken)

    Public Sub Print_Ticket(ByVal idFactur As Integer,
                                 Optional isLatest As Boolean = False,
                                 Optional claveAcceso As String = "",
                                 Optional isInvoiceElectronic As Boolean = False)
        Try
            _claveAcceso = claveAcceso
            'is isntall printer name for factur
            If Not isInstallPrinter_factura() Then
                Return
            End If
            'initializa the data
            Dim dC As New DataTable
            Dim dT As New DataTable
            'is isLatest initializa bucle
            If isLatest Then
                Using db As New DataContext
                    Dim Latest = From q In db.DocumentULT
                                 Where q.codTerminal = TerminalActivo.codTerminal _
                                 And q.codUser = UsuarioActivo.codUser

                    For Each item In Latest
                        dC = carga_Cabecera(item.idDocument)
                        If IsNothing(dC) Then
                            Return
                        End If
                        If dC.Rows.Count = 0 Then
                            Return
                        End If
                        '-------------------------------------------------
                        'Load Detalle----------------------------------

                        dT = carga_Detail(item.idDocument)
                        If IsNothing(dT) Then
                            Return
                        End If
                        If dT.Rows.Count = 0 Then
                            Return
                        End If
                        'Evaluo si es facturacion electronica....
                        If isInvoiceElectronic Then
                            'PrintTicket_FacturRide(dC, dT, Me._claveAcceso)
                        Else
                            PrintTicket_FacturAndNoteVent(dC, dT, Me._claveAcceso)
                        End If
                    Next
                    Return
                End Using
                Return
            End If

            'si me entrega un id de documento
            dC = carga_Cabecera(idFactur)
            If IsNothing(dC) Then
                Return
            End If
            If dC.Rows.Count = 0 Then
                Return
            End If
            '-------------------------------------------------
            'Load Detalle----------------------------------

            dT = carga_Detail(idFactur)
            If IsNothing(dT) Then
                Return
            End If
            If dT.Rows.Count = 0 Then
                Return
            End If
            'Evaluo tipo de impresion....
            If isInvoiceElectronic Then
                ' PrintTicket_FacturRide(dC, dT)
            Else
                PrintTicket_FacturAndNoteVent(dC, dT)
            End If

            Return
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Sub New(cancelTokenSource As CancellationTokenSource)
        _cancelTokenSource = cancelTokenSource
    End Sub

    Public Sub Star()
        Try

            Task.Factory.StartNew(Sub() _
                ActionToExecute(_cancelTokenSource.Token)) _
                .ContinueWith(Sub() TaskCompleted())

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub TaskCompleted()
        releaseCancellationTokenSource()
    End Sub

    Private Sub releaseCancellationTokenSource()
        If _cancelTokenSource IsNot Nothing Then
            _cancelTokenSource.Dispose()
            _cancelTokenSource = Nothing
        End If
    End Sub
#Region "Methods get Data"
    Private Function carga_Cabecera(idFactur As Integer) As DataTable
        Try
            Dim datp As New Fact_venta_CabeceraTableAdapter
            Return datp.GetData(idFactur)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Private Function carga_Detail(idFactur As Integer) As DataTable
        Try
            Dim datp As New Fact_venta_DetailTableAdapter
            Return datp.GetData(idFactur)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Private Function carga_OpcionPrint(idBodega As Integer, idDocument As Integer) As List(Of ItemSettingOptionPrint)
        Try
            Dim list = New List(Of ItemSettingOptionPrint)

            Using dat As New SettingOpcionPrintsTableAdapter
                Using dt As New SettingOpcionPrintsDataTable
                    dat.Fill(dt, idBodega, idDocument)
                    For Each item As DataRow In dt.Rows
                        list.Add(New ItemSettingOptionPrint With
                                  {
                                  .FontZise = item.Item("FontZise").ToString(),
                                  .ForeColor = item.Item("ForeColor").ToString(),
                                  .NameSetting = item.Item("NameSetting").ToString()
                                  })
                    Next
                End Using
            End Using
            Return list
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return New List(Of ItemSettingOptionPrint)
        End Try
    End Function

#End Region

End Class
