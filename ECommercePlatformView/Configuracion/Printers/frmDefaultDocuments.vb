Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmDefaultDocuments
    Private isLoated As Boolean
    Private idDocunent As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmDefaultDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_typeDocument()
        isLoated = True
    End Sub

    Private Sub load_typeDocument()
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "select *   from [stm].[DocumentCaregory] "
                Using cmd As New SqlCommand(sql, cnn)
                    Using dat As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable
                        dat.Fill(dt)
                        Me.ComboBox1.DataSource = dt
                        Me.ComboBox1.DisplayMember = "NameDocumentCatg"
                        Me.ComboBox1.ValueMember = "IdDocumentCaregory"
                        ComboBox1.SelectedIndex = -1
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If isLoated Then
            LoatedDocuments(Integer.Parse(ComboBox1.SelectedValue))
        End If
    End Sub

    Private Sub LoatedDocuments(v As Integer)
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                sql = "select *  from [stm].[TypoDocumento] as c where IdDocumentCaregory = " & v & ""
                Using cmd As New SqlCommand(sql, cnn)
                    Using dat As New SqlDataAdapter(cmd)
                        Using dt As New DataTable
                            dat.Fill(dt)
                            Me.DataListView1.DataSource = dt
                            Me.idTypoDocuclm.Width = 0
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub DataListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListView1.SelectedIndexChanged
        If isLoated Then
            Try
                If Me.DataListView1.SelectedObjects.Count = 1 Then
                    Dim row = CType(DataListView1.SelectedObject, DataRowView)
                    idDocunent = Integer.Parse(row.Item("idTypoDocu"))
                    TextBox1.Text = row.Item("NumFact01").ToString()
                    TextBox2.Text = row.Item("NumFact02").ToString()
                    TextBox3.Text = row.Item("NumFact03").ToString()
                    TextBox4.Text = row.Item("NumFact04").ToString()


                    RadioButton1.Checked = CType(row.Item("Indefinite"), Boolean)
                    RadioButton2.Checked = Not CType(row.Item("Indefinite"), Boolean)
                    NumericUpDown1.Value = CType(row.Item("generate"), Int32)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress
        If InStr("0123456789", e.KeyChar) = False Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
        'Ascii 
        '8  = Retroceso 
        '58 = dos Puntos Decimales 
        '46 = Punto Decimal 
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.Panel1.Enabled = Not RadioButton1.Checked
    End Sub
    Private Sub Savebutton_Click(sender As Object, e As EventArgs) Handles Savebutton.Click
        If Validatios() Then
            Me.Cursor = Cursors.WaitCursor
            If SaveData() Then
                Me.Cursor = Cursors.Default
                MsgBox(msgExsito, MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Function SaveData() As Boolean
        sql = "update  [stm].[TypoDocumento] set
                generate = @generate,
                Indefinite= @Indefinite,
                NumFact01 = @NumFact01,
                NumFact02 = @NumFact02,
                NumFact03 = @NumFact03,
                NumFact04 = @NumFact04
                where idTypoDocu = @idTypoDocu"
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())

                cnn.Open()
                Using cmm As New SqlCommand(sql, cnn)
                    cmm.Parameters.AddWithValue("@generate", NumericUpDown1.Value)
                    cmm.Parameters.AddWithValue("@Indefinite", If(RadioButton1.Checked, 1, 0))
                    cmm.Parameters.AddWithValue("@NumFact01", TextBox1.Text)
                    cmm.Parameters.AddWithValue("@NumFact02", TextBox2.Text)
                    cmm.Parameters.AddWithValue("@NumFact03", TextBox3.Text)
                    cmm.Parameters.AddWithValue("@NumFact04", TextBox4.Text)
                    cmm.Parameters.AddWithValue("@idTypoDocu", Me.idDocunent)

                    If cmm.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Validatios() As Boolean
        If Not Me.DataListView1.SelectedItems.Count = 1 Then
            Me.ErrorProvider1.SetError(DataListView1, "Seleccione uno de la lista..")
            Return False
        Else
            Me.ErrorProvider1.SetError(DataListView1, "")
        End If

        If RadioButton2.Checked Then
            If NumericUpDown1.Value < 3 Then
                Me.ErrorProvider1.SetError(NumericUpDown1, "Número demaciado bajo..")
                Return False
            Else
                Me.ErrorProvider1.SetError(NumericUpDown1, "")
            End If
        Else
            Me.ErrorProvider1.SetError(NumericUpDown1, "")
        End If
        If Not (TextBox1.Text.Length = TextBox1.MaxLength) Or
            Not (TextBox2.Text.Length = TextBox2.MaxLength) Or
            Not (TextBox3.Text.Length = TextBox3.MaxLength) Or
            Not (TextBox4.Text.Length = TextBox4.MaxLength) Then
            sql = "Numeracion incorrecta:" & vbCrLf
            sql = sql & "La cantidad de dijitos son 3, 3, 2, 7"
            Me.ErrorProvider1.SetError(TextBox4, sql)
            Return False
        Else
            Me.ErrorProvider1.SetError(TextBox4, String.Empty)
        End If
        If Not idDocunent > 0 Then
            MsgBox("No se pudo determinar el tipo de documento..", MsgBoxStyle.Exclamation, "Importante")
            Return False
        End If
        Return True
    End Function
End Class
