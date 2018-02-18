Imports System.Data.SqlClient
Imports CADsisVenta.DataSetVentasTableAdapters

Public Class frmChequeContab
    Private idCajaStatus As Integer
    Private listCheque As List(Of facturNotofunt)
    Private totalSaldoCheque As Double
    Private totalDiferenciaCheque As Double

    Public Function Load_Cheque(idCajaStatus As Integer) As Boolean
        Dim countCheque As Integer = 0
        totalSaldoCheque = 0
        Dim adat As New cheqResumencontabTableAdapter
        Dim adtCheNo As New CheqNotFountTableAdapter
        Dim dtNofoun As New DataTable
        Try


            dtNofoun = adtCheNo.GetData(idCajaStatus)

            With ResumenDataGridView
                .DataSource = adat.GetData(idCajaStatus)
                .Columns(0).Visible = False

                clm = .Columns("nom_Banco")
                clm.HeaderText = "Banco"
                clm.Width = 150

                clm = .Columns("N_cheque")
                clm.HeaderText = "Cheques"
                clm.Width = 80
                clm.DefaultCellStyle = myStileNumber

                clm = .Columns("Total")
                clm.HeaderText = "Total"
                clm.Width = 100
                clm.DefaultCellStyle = myStileMoney

                For i = 0 To .RowCount - 1
                    totalSaldoCheque += .Rows(i).Cells(3).Value
                    countCheque += .Rows(i).Cells(2).Value
                Next
                applyGridTheme(ResumenDataGridView)
            End With

            TotalSaldoCheqLabel.Text = String.Format("Total: {0}", totalSaldoCheque.ToString("C2"))
            TotalCountLabel.Text = String.Format("Total cheques: {0}", countCheque.ToString("N0"))
            For i = 0 To dtNofoun.Rows.Count - 1
                agregaCheque(dtNofoun.Rows(i)("idCajaDetailCheque"), dtNofoun.Rows(i)("val_Cobro"))
            Next
            Me.idCajaStatus = idCajaStatus
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            adat = Nothing
            adtCheNo = Nothing
            dtNofoun = Nothing
        End Try
    End Function

    Private Sub frmChequeContab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ResumenDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResumenDataGridView.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Carga_detalle(Integer.Parse(ResumenDataGridView.Rows(e.RowIndex).Cells(0).Value))
        End If
    End Sub

    Private Sub Carga_detalle(idBanco As Integer)
        Try
            Dim adat As New ChequeContabTableAdapter
            Dim dt As New DataTable
            dt = adat.GetData(idCajaStatus, idBanco)

            Dim dtComun As New DataColumn()

            With dtComun
                .DataType = System.Type.GetType("System.Boolean")
                .AllowDBNull = False
                .Caption = "Ok"
                .ColumnName = "OK"
                .DefaultValue = True
            End With
            ' Add the column to the table. 
            dt.Columns.Add(dtComun)
            With DetailDataGridView
                .DataSource = dt
                .Columns(0).Visible = False

                clm = .Columns("Ok")
                clm.DisplayIndex = 1
                clm.Width = 50

                clm = .Columns("nom_Banco")
                clm.HeaderText = "Banco"
                clm.Width = 150

                clm = .Columns("num_Cuenta")
                clm.HeaderText = "Cuenta"
                clm.Width = 120

                clm = .Columns("Num_Documento")
                clm.HeaderText = "Documento"
                clm.Width = 100

                clm = .Columns("val_Cobro")
                clm.HeaderText = "Total"
                clm.Width = 80
                clm.DefaultCellStyle = myStileMoney

                clm = .Columns("isArching")
                clm.HeaderText = "Arqueo"
                clm.Visible = False
                clm.DefaultCellStyle = myStileMoney

                applyGridThemeEdit(DetailDataGridView)
                For i = 0 To DetailDataGridView.RowCount - 1
                    DetailDataGridView.Rows(i).Cells(DetailDataGridView.Columns("Ok").Index).Value = DetailDataGridView.Rows(i).Cells(DetailDataGridView.Columns("isArching").Index).Value
                Next

            End With

            TabControl1.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ChequeContabButton_Click(sender As Object, e As EventArgs) Handles ChequeContabButton.Click
        If Not IsNumeric(sender.tag) Then
            Return
        End If

        Dim forms As Form
        forms = ChequeContabButton.FindForm
        If Not forms.Name.Equals("frmCajaDetail") Then
            Return
        End If
        If Not Me.transferCheque() Then
            Return
        End If
        Dim cajaDetail As frmCajaDetail
        cajaDetail = forms

        For Each item As ListViewItem In cajaDetail.ListViewList.Items
            If (Integer.Parse(item.SubItems(1).Text) = sender.Tag) Then
                item.ImageKey = "ok_16_png"
                item.Text = String.Format("{0} ({1:C2})", item.SubItems(2).Text, totalDiferenciaCheque)
                cajaDetail.totalDiferenciaCaheque = totalDiferenciaCheque
                cajaDetail.ListViewList.Refresh()
                Exit For
            End If
        Next

        Dim isArquedototo As Boolean = True
        For Each item As ListViewItem In cajaDetail.ListViewList.Items
            If String.IsNullOrEmpty(item.ImageKey.ToString) Then
                isArquedototo = False
            End If
        Next
        With cajaDetail
            .totalDiferenciaGeneral = .totalDiferenciaCaheque + .totalDifereniaEfectivo + .totalTargeta
        End With
        cajaDetail.OK_Button.Enabled = isArquedototo
        cajaDetail.totalDiferenciaArqueoLabel.Text = String.Format("Diferencia General: {0:C2}", cajaDetail.totalDiferenciaGeneral)
        cajaDetail = Nothing
        forms = Nothing
    End Sub

    Private Function transferCheque() As Boolean
        Try
            If IsNothing(listCheque) Then
                Return True
            End If
            If listCheque.Count = 0 Then
                Return True
            End If

            Using connection As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                connection.Open()

                Dim command As SqlCommand = connection.CreateCommand()
                Dim transaction As SqlTransaction

                ' Start a local transaction
                transaction = connection.BeginTransaction("SampleTransaction")

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = connection
                command.Transaction = transaction
                command.CommandType = CommandType.Text

                Dim response As Integer
                Try
                    command.CommandText = "Update [dbo].[CajaDetailDocument] Set isArching = @isArching " _
                    + " where idCajaDetailCheque = @idCajaDetailCheque "
                    Dim i As Integer = 0
                    For Each item In listCheque
                        If i = 0 Then
                            command.Parameters.Add("@isArching", SqlDbType.Bit)
                            command.Parameters.Add("@idCajaDetailCheque", SqlDbType.Int)
                        End If
                        command.Parameters("@isArching").Value = 0
                        command.Parameters("@idCajaDetailCheque").Value = item.idCajaDetailCheque
                        response = command.ExecuteNonQuery()
                        If Not response = 1 Then
                            Return False
                        End If
                        i += 1
                    Next
                    transaction.Commit()
                    Return True
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub DetailDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetailDataGridView.CellContentClick
        Try
            If e.RowIndex >= 0 And e.ColumnIndex = DetailDataGridView.Columns("Ok").Index Then

                Dim response As Boolean = Not DetailDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If Not response Then
                    Me.agregaCheque(DetailDataGridView.Rows(e.RowIndex).Cells(0).Value,
                                    DetailDataGridView.Rows(e.RowIndex).Cells(DetailDataGridView.Columns("val_Cobro").Index).Value)
                Else
                    Me.eliminaCheque(DetailDataGridView.Rows(e.RowIndex).Cells(0).Value)
                End If

                DetailDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = response
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub agregaCheque(id As Integer, parcial As Double)
        If IsNothing(Me.listCheque) Then
            listCheque = New List(Of facturNotofunt)
        End If
        Dim item As New facturNotofunt(id, parcial, False)
        listCheque.Add(item)
        sumaTotal()
    End Sub
    Private Sub eliminaCheque(id As Integer)
        If IsNothing(Me.listCheque) Then
            listCheque = New List(Of facturNotofunt)
        End If
        For Each item In listCheque
            If item.idCajaDetailCheque = id Then
                listCheque.Remove(item)
                Exit For
            End If
        Next
        sumaTotal()
    End Sub
    Private Sub sumaTotal()
        Dim total As Double = 0
        For Each item In listCheque
            total += item.valCheq
        Next
        total = total * -1
        DiferecCheqLabel.Text =
            String.Format("Diferecia:{0}, total:{1:C2}", listCheque.Count, total)
        Me.totalDiferenciaCheque = total
    End Sub
End Class

Class facturNotofunt
    Private _id As Integer
    Private _val As Double
    Private _isArching As Boolean

    Sub New(id As Integer, _value As Double, isArching As Boolean)
        _id = id
        _val = _value
        _isArching = isArching
    End Sub

    Public Property valCheq() As Double
        Get
            Return _val
        End Get
        Set(ByVal value As Double)
            _val = value
        End Set
    End Property
    Public Property idCajaDetailCheque() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property isArching() As Boolean
        Get
            Return _isArching
        End Get
        Set(ByVal value As Boolean)
            _isArching = value
        End Set
    End Property
End Class