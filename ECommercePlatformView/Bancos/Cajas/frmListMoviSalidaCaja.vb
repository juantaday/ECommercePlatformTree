Imports System.Data.SqlClient
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmListMoviSalidaCaja
    Private idCajaStado As Integer
    Private totalSalida As Double
    Private idTerminal As Integer

    Private isLoad As Boolean


    Public Sub New(idTerminal As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idTerminal = idTerminal
        totalSalida = 0
    End Sub

    Private Sub frmListMoviSalidaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoad = False
        Carga_ListOperacio()
        isLoad = True
    End Sub

    Private Sub Carga_ListOperacio()
        Try
            Dim listOperacion As New List(Of ItemOperacion)

            Dim listAdap As New CajaStadoTableAdapter
            Dim dtList As New DataTable

            dtList = listAdap.GetDataByListCajaStado(idTerminal, 1)
            For i = 0 To dtList.Rows.Count - 1
                sql = "Operacion: " & dtList(i)("idCajaStado") & " /Estado: Abierto. /Para: "

                If String.IsNullOrEmpty(dtList(i)("own_User").ToString) Then
                    sql = sql & "Todos."
                Else
                    sql = sql & dtList(i)("own_User")
                End If
                listOperacion.Add(New ItemOperacion(dtList(i)("idCajaStado"), sql))
            Next

            dtList = listAdap.GetDataByListCajaStado(idTerminal, 2)
            For i = 0 To dtList.Rows.Count - 1
                sql = "Operacion: " & dtList(i)("idCajaStado") & " /Estado: Suspendido. /Para: "

                If String.IsNullOrEmpty(dtList(i)("own_User").ToString) Then
                    sql = sql & "Todos."
                Else
                    sql = sql & dtList(i)("own_User")
                End If
                listOperacion.Add(New ItemOperacion(dtList(i)("idCajaStado"), sql))
            Next
            If listOperacion.Count > 0 Then
                ListOperationComboBox.DataSource = listOperacion
                ListOperationComboBox.DisplayMember = "Description"
                ListOperationComboBox.ValueMember = "IdCajaStado"
                ListOperationComboBox.SelectedIndex = -1
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally

        End Try
    End Sub

    Private Sub Carga_Datos(idCajaStado As Integer)
        Try
            totalSalida = 0
            sql = "Select c.idCaja, c.dateAntTime,
                c.Descripcion,
                p.formaPago,c.haber as Valor
                 from Cajas  as c
                inner join [stm].FormaPago  as p on p.idformaPago = c.idFormaPago
                where  ((idCajaStado =@idCajaStado) and (haber >0))
                order by c.dateAntTime desc"
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.Parameters.AddWithValue("@idCajaStado", idCajaStado)
                    Using dat As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        dat.Fill(dt)
                        dtg.DataSource = dt
                        applyGridTheme(dtg)

                        clm = dtg.Columns("idCaja")
                        clm.Visible = False

                        clm = dtg.Columns("dateAntTime")
                        clm.HeaderText = "Fecha y hora"

                        clm = dtg.Columns("formaPago")
                        clm.HeaderText = "Tipo"

                        clm = dtg.Columns("Valor")
                        clm.DefaultCellStyle = myStileMoney


                        For i = 0 To dtg.RowCount - 1
                            totalSalida += dtg.Rows(i).Cells(dtg.Columns("Valor").Index).Value
                        Next
                        totalSalidaLabel.Text = "Total movimiento de salida: " & totalSalida.ToString("C2")
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Class ItemOperacion
        Public Sub New(ByVal idCajaStado As Integer, ByVal description As String)
            _idCajaStado = idCajaStado
            _description = description
        End Sub
        Private _idCajaStado As Integer
        Public Property IdCajaStado() As Integer
            Get
                Return _idCajaStado
            End Get
            Set(ByVal value As Integer)
                _idCajaStado = value
            End Set
        End Property
        Private _description As String
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                _description = value
            End Set
        End Property
    End Class

    Private Sub ListOperationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListOperationComboBox.SelectedIndexChanged
        If isLoad Then
            If ListOperationComboBox.SelectedIndex >= 0 Then
                Me.Carga_Datos(ListOperationComboBox.SelectedValue)
            End If
        End If
    End Sub
    Private Sub TicketPrinterButton_Click(sender As Object, e As EventArgs) Handles TicketPrinterButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not dtg.SelectedRows.Count = 1 Then
                Return
            End If

            If LoadOptionsPrint("Recibo salida divisas") Then
                PrintReciboTerminal(dtg.SelectedRows(0).Cells("idCaja").Value, myOptnsPrint)
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class