Imports System.ComponentModel
Imports System.Data.SqlClient
Imports CADsisVenta.DataSetZonasTableAdapters
Public Class frmAdd_Almacen
    Private estaCargado As Boolean
    Protected Friend idBodega As Integer
    Private idResponsable1, idResponsable2, idResponsable3 As Integer
    Private StateOperation As stateOperation
    Private DateStar As Date
    Public Sub New(ByVal _stateOperation As stateOperation, ByVal _idbodega As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.StateOperation = _stateOperation
        Select Case Me.StateOperation
            Case stateOperation.Update
                Me.idBodega = _idbodega
        End Select
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Load_Bodega(ByVal _idbodega As Integer)
        estaCargado = False
        Try
            Using db As New DataContext
                Dim _bodega = From b In db.Bodegas
                              Where b.idBodega = _idbodega


                For Each item In _bodega
                    Me.NomBodegaText.Text = item.Nom_Bodega
                    DescripcionBodegaText.Text = item.Des_Bodega
                    DireccionText.Text = item.Direc_Bodega
                    If Not IsNothing(item.Resp1_idEmpleado) And IsNumeric(item.Resp1_idEmpleado) Then
                        Me.idResponsable1 = item.Resp1_idEmpleado
                        inChargeEmployTextbox.Text = Load_Responsable(item.Resp1_idEmpleado)
                    End If
                    If Not IsNothing(item.Resp2_idEmpleado) And IsNumeric(item.Resp2_idEmpleado) Then
                        Me.idResponsable2 = item.Resp2_idEmpleado
                        checkEmployeeText.Text = Load_Responsable(item.Resp2_idEmpleado)
                    End If
                    telefono1Text.Text = item.Telef1_Bodega
                    telefono2Text.Text = item.Telef2_Bodega
                    telefono3TextBox.Text = item.Telef3_Bodega
                    If IsDate(item.Fecha_Apertura) Then
                        Me.DateStarDateTimePicker.Value = item.Fecha_Apertura
                        Me.DateStarTextBox.Text = item.Fecha_Apertura
                    End If
                    TypoBodegaComboBox.SelectedValue = item.TypoBodega
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub

    Private Function Load_Responsable(ByVal _IdEmployee As Integer) As String
        Try
            If IsNothing(_IdEmployee) OrElse Not IsNumeric(_IdEmployee) Then
                Return String.Empty
            End If
            Using db As New DataContext
                Dim _Employee = From e In db.Empleados
                                Join p In db.Personas On p.idPersona Equals e.idPersona
                                Where e.idEmpleado = _IdEmployee
                                Select New With {p}


                For Each item In _Employee
                    Return item.p.Ruc_Ci & " - " & item.p.Apellidos & " " & item.p.Nombre
                Next
            End Using
            Return String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return String.Empty
        End Try
    End Function
    Private Sub brnAddPesponsable_Click(sender As Object, e As EventArgs) Handles brnAddPesponsable.Click
        Using newResponsa As New frmList_Empleados(stateClient.Admin)
            With newResponsa
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    idResponsable1 = .idEmpleado
                    sql = "(" + .dtg.SelectedCells.Item(.dtg.Columns("Ruc_Ci").Index).Value & ") "
                    sql = sql & .dtg.SelectedCells.Item(.dtg.Columns("Nombres").Index).Value
                    Me.inChargeEmployTextbox.Text = sql
                End If
            End With

        End Using
    End Sub

    Private Sub BloqueaControles(ByVal Estado As Boolean)
        For Each ctrls In Me.pnlEntrada.Controls
            ctrls.enabled = Estado
        Next

    End Sub
    Private Function Add_WhereHouse() As Boolean
        Try
            Dim datp As New BodegasTableAdapter()
            Dim resp1 As Nullable(Of Integer) = Nothing
            Dim resp2 As Nullable(Of Integer) = Nothing
            Dim resp3 As Nullable(Of Integer) = Nothing
            If idResponsable1 > 0 Then
                resp1 = idResponsable1
            End If
            If idResponsable2 > 0 Then
                resp2 = idResponsable2
            End If
            If idResponsable3 > 0 Then
                resp3 = idResponsable3
            End If
            If datp.InsertBodegas(NomBodegaText.Text,
                               DescripcionBodegaText.Text,
                               DireccionText.Text,
                               telefono1Text.Text,
                               telefono2Text.Text,
                               telefono3TextBox.Text,
                               resp1,
                               resp2,
                               resp3,
                               DateStarDateTimePicker.Value,
                               TypoBodegaComboBox.SelectedValue) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el Agregar_Bodega del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaDatos() As Boolean
        If Me.ValidateChildren And Me.NomBodegaText.Text.Length > 0 _
              And Me.DateStarTextBox.Text.Length And inChargeEmployTextbox.Text.Length > 0 Then
            If TypoBodegaComboBox.SelectedIndex <= 0 Then
                MsgBox(msgSelect_list, MsgBoxStyle.Information, "Aviso")
                TypoBodegaComboBox.Focus()
                Return False
            End If
            Return True
        Else
            MsgBox("Falta de ingrsar algunos datos", MsgBoxStyle.Information, "Aviso")
            Return False
        End If
    End Function


    Private Function Edit_WhereHouse() As Boolean
        Try
            Dim datp As New BodegasTableAdapter()
            Dim resp1 As Nullable(Of Integer) = Nothing
            Dim resp2 As Nullable(Of Integer) = Nothing
            Dim resp3 As Nullable(Of Integer) = Nothing
            If idResponsable1 > 0 Then
                resp1 = idResponsable1
            End If
            If idResponsable2 > 0 Then
                resp2 = idResponsable2
            End If
            If idResponsable3 > 0 Then
                resp3 = idResponsable3
            End If
            If datp.UpdateBodega(NomBodegaText.Text,
                               DescripcionBodegaText.Text,
                               DireccionText.Text,
                               telefono1Text.Text,
                               telefono2Text.Text,
                               telefono3TextBox.Text,
                               resp1,
                               resp2,
                               resp3,
                               DateStarDateTimePicker.Value,
                               TypoBodegaComboBox.SelectedValue,
                               idBodega) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el Agregar_Bodega del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NomBodegaText.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre del almacen o bodega")
        End If
    End Sub

    Private Sub frmAdd_Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Load_TypoBodega()
            Select Case Me.StateOperation
                Case stateOperation.Update
                    Load_Bodega(Me.idBodega)
                Case stateOperation.View
                    Load_Bodega(Me.idBodega)
                    BloqueaControles(False)
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_TypoBodega()
        Try
            Dim data As New TypoBodegaTableAdapter
            TypoBodegaComboBox.DataSource = data.GetDataByAll()
            TypoBodegaComboBox.ValueMember = "idTypoBodega"
            TypoBodegaComboBox.DisplayMember = "Nom_typoBodega"
            TypoBodegaComboBox.SelectedIndex = 0
            data = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker2_DropDown(sender As Object, e As EventArgs) Handles DateStarDateTimePicker.DropDown
        Try
            If IsNothing(DateStar) Then
                DateStarDateTimePicker.Value = DateStar
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateTimePicker2_CloseUp(sender As Object, e As EventArgs) Handles DateStarDateTimePicker.CloseUp
        DateStarTextBox.Text = DateStarDateTimePicker.Value.ToShortDateString()
        DateStar = DateStarDateTimePicker.Value
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Using listEmployee As New frmListEmployeeView(stateLoad.Dialogo)
                With listEmployee
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.idResponsable1 = ._ItemPerson.IdEmployee
                        inChargeEmployTextbox.Text = ._ItemPerson.Ruc_Ci & " - " & ._ItemPerson.Apellidos & " " & ._ItemPerson.Nombre
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles FinEmployee2Button.Click
        Try
            Using listEmployee As New frmListEmployeeView(stateLoad.Dialogo)
                With listEmployee
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.idResponsable2 = ._ItemPerson.IdEmployee
                        checkEmployeeText.Text = ._ItemPerson.Ruc_Ci & " - " & ._ItemPerson.Apellidos & " " & ._ItemPerson.Nombre
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If ValidaDatos() Then
                Select Case StateOperation
                    Case stateOperation.Insert
                        If Add_WhereHouse() Then
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    Case stateOperation.Update
                        If Edit_WhereHouse() Then
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateStarTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DateStarTextBox.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese la fecha de apertura")
        End If
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles NomBodegaText.Leave
        Me.NomBodegaText.Text = Trim(Me.NomBodegaText.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using Form = New frmList_Empleados(stateClient.Admin)

            Form.ShowDialog()

            If Form.DialogResult = DialogResult.OK Then
                idResponsable2 = id
                Me.checkEmployeeText.Text = sql
            End If
        End Using
    End Sub

    Private Sub inChargeEmployTextbox_Validating(sender As Object, e As CancelEventArgs) Handles inChargeEmployTextbox.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el responsable del local o bodega..")
        End If
    End Sub
End Class