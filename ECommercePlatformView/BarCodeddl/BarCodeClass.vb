Imports iTextSharp.text.pdf
Public Class BarCodeClass
    Public Shared Function codigo128(ByVal _code As String, Optional ByVal verTexto As Boolean = False, Optional ByVal Heigt As Single = 0)
        Dim barcode As New BarcodeCodabar
        barcode.StartStopText = True
        If Heigt <> 0 Then
            barcode.BarHeight = Heigt
        End If
        barcode.Code = _code
        Try
            Dim bm As New System.Drawing.Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))
            If Not verTexto Then
                Return bm
            End If

            Dim ncode As String = _code.Substring(1, _code.Length - 2)
            Dim bmT As Image
            bmT = New Bitmap(bm.Width, bm.Height + 30)
            Dim g As Graphics = Graphics.FromImage(bmT)

            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 30)

            Dim pintarTexto As New Font("Arial", 10)
            Dim brocha As New SolidBrush(Color.Black)

            Dim stringZise As New SizeF
            stringZise = g.MeasureString(ncode, pintarTexto)

            Dim centrox As Single = stringZise.Width / 2
            Dim x As Single = 15
            Dim y As Single = bm.Height + 15

            Dim drawFormat As New StringFormat
            drawFormat.FormatFlags = StringFormatFlags.NoWrap

            g.DrawImage(bm, 15, 15)
            g.DrawString(ncode, pintarTexto, brocha, x, y, drawFormat)

            Return bmT
        Catch ex As Exception
            Throw New Exception("Error al pintar en codigo" + ex.Message)
        End Try
    End Function

End Class
