Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports CADsisVenta.DataSetEmployeeTableAdapters

Public Class frmAdd_Empleados
    Protected Friend idEmpleado As Integer
    Protected Friend idPersona As Integer
    Protected Friend idReportTo As Integer
    Private stateLoad As stateLoad
    Private stateCliente As stateClient
    Private stateOperation As stateOperation
    Sub New(stateLoad As stateLoad, stateCliente As stateClient, stateOperation As stateOperation)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.stateLoad = stateLoad
        Me.stateCliente = stateCliente
        Me.stateOperation = stateOperation
    End Sub
    Private Sub frmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Cargos()
        Select Case Me.stateCliente
            Case stateClient.Admin, stateClient.User
                Carga_DetallePerson(Me.idPersona)
                Carga_DetalleEmpld(Me.idEmpleado)
            Case stateClient.Cliente
                For Each cntls In Me.Controls
                    cntls.enabled = False
                Next
                Me.btnCancel.Enabled = True
                Me.CancelButton = Me.btnCancel
        End Select
        'si solamente biene ha ber lo bloqueo
        Select Case Me.stateOperation
            Case stateOperation.View
                For Each cntls In Me.Controls
                    cntls.enabled = False
                Next
                Me.btnCancel.Enabled = True
                Me.CancelButton = Me.btnCancel
        End Select
    End Sub

    Private Sub Carga_DetallePerson(ByVal idPerson As Integer)
        If idPerson = 0 Then
            Return
        End If

        Try
            Using db As New DataContext
                Dim perosn = From p In db.Personas
                             Where p.idPersona = idPerson

                For Each dt In perosn
                    Me.NameEmployeeLinkLabel.Text = String.Format("{0} {1}", dt.Apellidos, dt.Nombre)
                    Me.rucEmployeeLabel.Text = "Ruc o C.I:  " & dt.Ruc_Ci

                    'telefonos
                    sql = "Teléfono: " & dt.telefono & " - "
                    sql = sql & dt.telef_ofic & " -  "
                    sql = sql & dt.telef_casa & vbNewLine
                    'direccion
                    sql = sql & "Direccion: " & dt.Direccion & vbNewLine
                    'email
                    sql = sql & "E-mail: " & dt.mail & vbNewLine
                    'email
                    If IsDate(dt.fech_Naci) Then
                        sql = sql & "Fecha de nacimiento: " & dt.fech_Naci
                    Else
                        sql = sql & "Fecha de nacimiento:"
                    End If
                    Me.descriptionEmployeeLabel.Text = sql
                    'email

                    'carga imagem
                    imgFoto.Image = Nothing
                    If Not IsDBNull(dt.foto) Then
                        Dim img() As Byte = dt.foto
                        If Not IsNothing(img) Then
                            If img.Length > 0 Then
                                Dim ms As New IO.MemoryStream(img)
                                imgFoto.Image = Image.FromStream(ms)
                                imgFoto.SizeMode = PictureBoxSizeMode.StretchImage
                            End If
                        End If
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " " + ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub Carga_DetalleEmpld(ByVal idempld As Integer)
        If idEmpleado = 0 Then
            Return
        End If

        sql = "SELECT p.*, e.* "
        sql = sql + "FROM dbo.Empleados AS e INNER JOIN "
        sql = sql + "dbo.Personas AS p ON e.idPersona = p.idPersona "
        sql = sql + "WHERE(e.idEmpleado = " & idempld & ") "

        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Using cmd As New SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text
                    Using adat As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            adat.Fill(dt)

                            If dt.Rows.Count > 0 Then
                                Me.NameEmployeeLinkLabel.Text = String.Format("{0} {1}", dt(0)("Apellidos").ToString, dt(0)("Nombre").ToString)
                                Me.rucEmployeeLabel.Text = "Ruc o C.I:  " & dt(0)("Ruc_Ci").ToString

                                'telefonos
                                sql = "Teléfono: " & dt(0)("telefono").ToString & " - "
                                sql = sql & dt(0)("telef_ofic").ToString & " -  "
                                sql = sql & dt(0)("telef_casa").ToString & vbNewLine
                                'direccion
                                sql = sql & "Direccion: " & dt(0)("Direccion").ToString & vbNewLine
                                'email
                                sql = sql & "E-mail: " & dt(0)("mail").ToString & vbNewLine
                                'email
                                If IsDate(dt(0)("fech_Naci")) Then
                                    sql = sql & "Fecha de nacimiento: " & dt(0)("fech_Naci")
                                Else
                                    sql = sql & "Fecha de nacimiento:"
                                End If
                                Me.descriptionEmployeeLabel.Text = sql
                                'email

                                'carga imagem
                                imgFoto.Image = Nothing
                                If Not IsDBNull(dt(0)("foto")) Then
                                    Dim img() As Byte = (dt(0)("foto"))
                                    If Not IsNothing(img) Then
                                        If img.Length > 0 Then
                                            Dim ms As New IO.MemoryStream(img)
                                            imgFoto.Image = Image.FromStream(ms)
                                            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage
                                        End If
                                    End If
                                End If

                                Me.sueldoTextBox.Value = Double.Parse(dt(0)("sueldo"))
                                Me.tituloCombobox.Text = dt(0)("titulo").ToString
                                Me.SalariosComboBox.Text = dt(0)("SalaryType").ToString
                                Me.CargoBombox.Text = dt(0)("cargo").ToString

                                If Not IsNothing(dt(0)("reporta_A")) Then
                                    If IsNumeric(dt(0)("reporta_A").ToString) Then
                                        Cargo_reporta_A(Integer.Parse(dt(0)("reporta_A").ToString))
                                    End If
                                End If

                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_DetalleEmpld del " + Me.Name, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
    Private Sub Cargo_reporta_A(ByVal idempleado As Integer)
        conecta_sql()

        sql = "Select   e.idEmpleado, p.Ruc_Ci, p.Apellidos, p.Nombre "
        sql = sql + "FROM            dbo.Empleados As e INNER JOIN "
        sql = sql + "       dbo.Personas As p On e.idPersona = p.idPersona "
        sql = sql + " WHERE(e.idEmpleado = " & idempleado & ")"
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dat As New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                dat.Fill(dt)
                If dt.Rows.Count > 0 Then
                    If IsNumeric(dt(0)("idEmpleado")) Then
                        Me.idReportTo = dt(0)("idEmpleado")
                        Me.txtNameReportto.Text = dt(0)("Ruc_Ci").ToString + " " + dt(0)("Apellidos").ToString + " " + dt(0)("Nombre").ToString
                    End If
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta")
        End Try

    End Sub
    Private Sub Cargar_Cargos()
        conecta_sql()
        sql = "Select distinct cargo from Empleados "
        Try

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dar As SqlDataReader = cmd.ExecuteReader()

                CargoBombox.Items.Clear()
                CargoBombox.Items.Add("Selecciona...")
                While dar.Read()
                    CargoBombox.Items.Add(dar(0).ToString)
                End While
                dar.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "en el Cargar_Cargos del " & Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Titulos()
        conecta_sql()
        sql = "Select Distinct titulo from Empleados "
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                Dim dar As SqlDataReader = cmd.ExecuteReader()

                CargoBombox.Items.Clear()
                While dar.Read()
                    CargoBombox.Items.Add(dar(0).ToString)
                End While
                dar.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "en el Cargar_Titulos del " & Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Me.ValidaData() Then
            Dim response As Boolean = False
            Select Case stateOperation
                Case stateOperation.Insert
                    response = Me.Insert()
                Case stateOperation.Update
                    response = Update_(Me.idEmpleado)
            End Select
            If response Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function Update_(idempleado As Integer) As Boolean
        Try
            Using cmd As New EmpleadosTableAdapter
                Dim titulo As Object = Nothing
                If Not (tituloCombobox.SelectedIndex = -1) Then
                    titulo = tituloCombobox.Text
                End If

                Dim cargo As String = vbNull
                If Not (CargoBombox.SelectedIndex = -1) Then
                    cargo = CargoBombox.Text
                End If

                Dim dateEnter As Nullable(Of Date) = Nothing
                If dtFecha_Ingreso.Checked Then
                    dateEnter = dtFecha_Ingreso.Value
                End If
                Dim _ReportTo As Object = Nothing
                If txtNameReportto.Text.Length > 0 Then
                    _ReportTo = Me.idReportTo
                End If
                Dim _SalaryType As Object = Nothing
                If Not (SalariosComboBox.SelectedIndex = -1) Then
                    _SalaryType = SalariosComboBox.Text
                End If
                If cmd.UpdateEmpledo(
                            titulo:=titulo,
                            cargo:=cargo,
                            sueldo:=sueldoTextBox.Value,
                            fecha_ingre:=dateEnter,
                            reporta_A:=_ReportTo,
                            SalaryType:=_SalaryType,
                            idEmpleado:=idempleado
                           ) = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Insert() As Boolean
        Try
            Using cmd As New EmpleadosTableAdapter
                Dim titulo As Object = Nothing
                If Not (tituloCombobox.SelectedIndex = -1) Then
                    titulo = tituloCombobox.Text
                End If

                Dim cargo As String = vbNull
                If Not (CargoBombox.SelectedIndex = -1) Then
                    cargo = CargoBombox.Text
                End If

                Dim dateEnter As Object = Nothing
                If dtFecha_Ingreso.Checked Then
                    dateEnter = dtFecha_Ingreso.Value
                End If
                Dim _ReportTo As Object = Nothing
                If txtNameReportto.Text.Length > 0 Then
                    _ReportTo = Me.idReportTo
                End If
                Dim _SalaryType As Object = Nothing
                If Not (SalariosComboBox.SelectedIndex = -1) Then
                    _SalaryType = SalariosComboBox.Text
                End If
                If cmd.InsertEmployee(
                                     idPersona:=Me.idPersona,
                                     titulo:=titulo,
                                     cargo:=cargo,
                                     sueldo:=sueldoTextBox.Value,
                                     fecha_ingre:=dateEnter,
                                     reporta_A:=_ReportTo,
                                     SalaryType:=_SalaryType) = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaData() As Boolean
        If CargoBombox.SelectedIndex = -1 Or CargoBombox.Text = "Selecciona..." Then
            MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
            CargoBombox.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub btnAddcargo_Click(sender As Object, e As EventArgs) Handles btnAddcargo.Click
        sql = InputBox("Escriba el cargo a agregar caso contrario cancele", "Dialogo")
        sql = Trim(sql)
        If sql.Length > 0 Then
            Me.CargoBombox.Items.Add(sql)
            Me.CargoBombox.Text = sql
        End If
    End Sub

    Private Sub cmbCargo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CargoBombox.Validating
        If (DirectCast(sender, ComboBox).Text.Length > 0) And (DirectCast(sender, ComboBox).Text <> "Selecciona...") Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Selecione un cargo")
        End If
    End Sub

    Private Sub btnRepot_Click(sender As Object, e As EventArgs) Handles btnRepot.Click
        Try
            Using newlistEmploye As New frmListEmployeeView(stateLoad.Dialogo)
                With newlistEmploye
                    .Text = "Seleccione a quien debe reportarse"
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        idReportTo = ._ItemPerson.IdEmployee
                        Me.txtNameReportto.Text = String.Format("{0} - {1}", ._ItemPerson.Ruc_Ci, ._ItemPerson.FullName)
                    End If
                End With
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtRuc_Ci_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnEddCargo_Click(sender As Object, e As EventArgs) Handles btnEddCargo.Click

    End Sub
End Class