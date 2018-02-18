Public Class DrawBarCode
    Private Shared digCentral As Byte
    Private Shared i, j As Short
    Private Shared lCurNum, lPrimerNum As Integer
    Private Shared iMod As Short


    Private Shared logitudCodigoBarras As Byte
    Private Shared codigoBarrasF As String
    Private Shared CurrentX As Integer
    Private Shared CurrentY As Integer
    Private Shared lposX As Integer
    Private Shared _Width As Single
    Private Shared _DistanceLabel As Integer
    Private Shared _HeitPanelLabel As Single


    Private Shared Tamaño As Byte = 1
    Private Shared ColorPen As New System.Drawing.Pen(Brushes.Black, Tamaño)
    Private Shared TextoFont As New System.Drawing.Font("Microsoft Sans Serif", 8)
    Private Shared delitedWidth As Integer = 0
    Private Shared deliteHeigth As Integer = 0

    Private Shared _LabelProduct As String
    Private Shared _PriceProduct As Double
    Private Shared _EmqProduct As String
    Private Shared _IsPrintLabel As Boolean

    Public Shared Function DrawBarCodeAndLabel(ByVal CodBar As String,
                                               ByVal LabelProduc As String,
                                               ByVal PriceProduc As Double,
                                               ByVal LabelEmp As String,
                                               Optional Zise As Byte = 1,
                                               Optional Width As Single = 50,
                                               Optional GraficoView As System.Drawing.Graphics = Nothing,
                                               Optional isPrintLabel As Boolean = False
                                              ) As Bitmap
        Try
            'quit then empy
            Dim result As String = String.Empty
            For Each _Text In CodBar
                If Not String.IsNullOrWhiteSpace(_Text) Then
                    result = result & _Text
                End If
            Next
            CodBar = result
            'validate data code
            Dim isValidCode As Boolean = DrawBarCode.IsValidCode(CodBar)
            'Initialize  data
            _LabelProduct = LabelProduc
            _EmqProduct = LabelEmp
            _PriceProduct = PriceProduc
            _Width = Width
            ColorPen.Width = Zise
            _IsPrintLabel = isPrintLabel
            TextoFont = New System.Drawing.Font("Microsoft Sans Serif", 8)

            If Zise = 2 Then
                TextoFont = New Font("Century", 14)
            End If

            Dim Grafico As System.Drawing.Graphics
            If Not IsNothing(GraficoView) Then
                Grafico = GraficoView
            End If
            Dim bmT As Image
            delitedWidth = 0
            deliteHeigth = 0
            Select Case logitudCodigoBarras
                Case 8
                    delitedWidth = If(Zise = 1, 120, 150)
                    deliteHeigth = If(Zise = 1, 90, 120)
                Case 12
                    delitedWidth = If(Zise = 1, 120, 220)
                    deliteHeigth = If(Zise = 1, 90, 120)
                Case 13
                    delitedWidth = If(Zise = 1, 120, 212)
                    deliteHeigth = If(Zise = 1, 90, 120)
                Case Else
                    delitedWidth = 100
                    deliteHeigth = 120
            End Select

            Dim bitmap As New Bitmap(delitedWidth, deliteHeigth)
            bitmap.SetResolution(96.0F, 96.0F)
            'star the value
            bmT = bitmap
            bmT.Tag = 0
            Grafico = Graphics.FromImage(bmT)
            If Not IsNothing(GraficoView) Then
                Grafico = GraficoView
            End If
            Grafico.Clear(Color.White)

            If Not isValidCode Then
                DrowError(Grafico, "Error")
                Return bmT
            End If

            DibujarCodigoBarras(Grafico)
            bmT.Tag = 1
            Return bmT
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Public Shared ReadOnly Property IsValidCode(ByVal CodBar As String) As Boolean
        Get
            Try
                Dim tipoCodBarras As Byte = 0
                Dim longitudReal As Integer = CodBar.Length
                Select Case longitudReal
                    Case 0 To 6
                        Return False
                    Case 7 To 8
                        tipoCodBarras = 7
                        logitudCodigoBarras = 8
                    Case 11 To 12
                        tipoCodBarras = 11
                        logitudCodigoBarras = 12
                    Case 13 To 20
                        tipoCodBarras = 12
                        logitudCodigoBarras = 13
                    Case Else
                        Return False
                End Select
                If longitudReal = tipoCodBarras Then
                    CodBar = String.Format("{0}0", CodBar)
                End If
                codigoBarrasF = formarCodBarras(CodBar.Remove(tipoCodBarras))
                Return CodBar = codigoBarrasF
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        End Get
    End Property

#Region "Methods"
    Private Shared Sub DrowError(Objeto As Graphics, Optional ErrorMesague As String = "Error")
        dibujarLabel(Objeto)
        Objeto.DrawString(ErrorMesague, New Font("Microsoft Sans Serif", 14, FontStyle.Bold), Brushes.Red, 20, 30)
        Objeto.DrawString("Recomendado:", TextoFont, Brushes.Black, 5, 48)
        Objeto.DrawString(codigoBarrasF, TextoFont, Brushes.Black, 5, 65)
    End Sub

    Private Shared Sub DibujarCodigoBarras(ByVal Objeto As System.Drawing.Graphics)

        If IsNothing(iniciarAr) Then
            iniciarAr()
        End If
        'initialize value
        iMod = 0
        Select Case logitudCodigoBarras
            Case 8, 13
                dibujarLabel(Objeto)
                digCentral = IIf(logitudCodigoBarras = 8, 5, 8)

                CurrentY = _Width
                lposX = 8 + (5 * ColorPen.Width)
                For i = 1 To logitudCodigoBarras
                    lCurNum = CInt(Mid(codigoBarrasF, i, 1))

                    If i = 1 Then
                        GuardBar(lposX, Objeto)
                        lPrimerNum = lCurNum

                        CurrentX = 2
                        Objeto.DrawString(IIf(logitudCodigoBarras = 8, "<", lPrimerNum), TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
                        Select Case logitudCodigoBarras
                            Case 8
                                iMod = 0
                                For j = 1 To 7
                                    If medIn(Mdl(iMod)(lCurNum), j) = 1 Then
                                        dibujarLinea(lposX, 0, Objeto)
                                    End If
                                    lposX = lposX + ColorPen.Width
                                Next j
                                CurrentX = lposX - (ColorPen.Width * j)
                                Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
                        End Select
                    End If

                    If i <> 1 Or logitudCodigoBarras = 8 Then
                        If i < digCentral Then
                            Select Case logitudCodigoBarras
                                Case 8
                                    iMod = 0
                                Case 13
                                    iMod = medIn(MdlLeft(lPrimerNum), i - 1)
                            End Select
                        Else
                            iMod = 2
                        End If
                    End If

                    If i = digCentral Then
                        lposX = lposX + (1 * ColorPen.Width)
                        GuardBar(lposX, Objeto)
                        lposX = lposX + (1 * ColorPen.Width)
                    End If

                    If i <> 1 Then
                        For j = 1 To 7
                            If medIn(Mdl(iMod)(lCurNum), j) = 1 Then
                                dibujarLinea(lposX, 0, Objeto)
                            End If
                            lposX = lposX + ColorPen.Width
                        Next j
                        CurrentX = lposX - (ColorPen.Width * j)
                        CurrentY = _Width

                        If i >= digCentral Then
                            CurrentX = CurrentX - ColorPen.Width
                        End If
                        Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
                    End If
                Next i
                CurrentX = lposX + lposX + (j * ColorPen.Width)
                CurrentY = _Width

                GuardBar(lposX, Objeto)

                If logitudCodigoBarras = 8 Then
                    CurrentX = lposX - (2 * ColorPen.Width)
                    Objeto.DrawString(">", TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
                End If
            Case 12
                Dibuja_UPCA(Objeto)
        End Select


    End Sub
    Private Shared Sub Dibuja_UPCA(Objeto)
        dibujarLabel(Objeto)

        digCentral = 7
        CurrentY = _Width
        lposX = 8 + (5 * ColorPen.Width)
        For i = 1 To logitudCodigoBarras - 1
            lCurNum = CInt(Mid(codigoBarrasF, i, 1))
            If i = 1 Then
                GuardBar_UPCA(lposX, Objeto)
                CurrentX = 2
                Objeto.DrawString(lPrimerNum, TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)

                lPrimerNum = lCurNum
                Guard_UPCA(lCurNum, lposX, Objeto)
            End If

            If i <> 1 Or logitudCodigoBarras = 8 Then

                If i < digCentral Then
                    Select Case logitudCodigoBarras
                        Case 8
                            iMod = 0
                        Case 13
                            iMod = medIn(MdlLeft(lPrimerNum), i - 1)
                    End Select
                Else
                    iMod = 2
                End If
            End If


            If i = digCentral Then
                lposX = lposX + (1 * ColorPen.Width)
                GuardBar(lposX, Objeto)
                lposX = lposX + (1 * ColorPen.Width)
            End If

            If i <> 1 Then
                For j = 1 To 7
                    If medIn(Mdl(iMod)(lCurNum), j) = 1 Then
                        dibujarLinea(lposX, 0, Objeto)
                    End If
                    lposX = lposX + ColorPen.Width
                Next j
                CurrentX = lposX - (ColorPen.Width * j)
                CurrentY = _Width

                If i >= digCentral Then
                    CurrentX = CurrentX - ColorPen.Width
                End If
                Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
            End If
        Next i
        CurrentX += (j * ColorPen.Width)
        CurrentY = _Width

        lCurNum = CInt(Mid(codigoBarrasF, logitudCodigoBarras, 1))
        'distancia del ultimo dijito en pixeles
        CurrentX += 7 * ColorPen.Width
        Guard_UPCA(lCurNum, CurrentX, Objeto)
        'tomo ditancia de la line ade barra
        CurrentX += 3 * ColorPen.Width
        GuardBar_UPCA(lposX, Objeto)
        'tomo tomo diatANCIA PARA LA LETRA
        'CurrentX += 2
        Objeto.DrawString(lCurNum, TextoFont, Brushes.Black, CurrentX, _HeitPanelLabel + CurrentY + _DistanceLabel)
    End Sub

    Private Shared Sub Guard_UPCA(ByVal number As Short, posX As Integer, ByVal Objeto As Object)
        If i < digCentral Then
            Select Case logitudCodigoBarras
                Case 8
                    iMod = 0
                Case 13
                    iMod = medIn(MdlLeft(lPrimerNum), i - 1)
            End Select
        Else
            iMod = 2
        End If
        For j = 1 To 7
            If medIn(Mdl(iMod)(number), j) = 1 Then
                dibujarLinea(lposX, 7 * ColorPen.Width, Objeto)
            End If
            lposX = lposX + ColorPen.Width
        Next j
    End Sub
    Private Shared Sub GuardBar(ByRef posX As Integer, ByVal Objeto As Object)
        dibujarLinea(posX, 7 * ColorPen.Width, Objeto)
        dibujarLinea(posX + (ColorPen.Width * 2), 7 * ColorPen.Width, Objeto)
        posX = posX + (ColorPen.Width * 3)
    End Sub
    Private Shared Sub GuardBar_UPCA(ByRef posX As Integer, ByVal Objeto As Object)
        dibujarLinea(posX, 7 * ColorPen.Width, Objeto)
        posX += 2 * ColorPen.Width
        dibujarLinea(posX, 7 * ColorPen.Width, Objeto)
        posX += ColorPen.Width
    End Sub
    Private Shared Sub dibujarLinea(ByRef posX As Integer, ByRef bExten As Byte, ByVal Objeto As System.Drawing.Graphics)
        Objeto.DrawLine(ColorPen, posX, _HeitPanelLabel, posX, _HeitPanelLabel + CurrentY + bExten)
    End Sub

    Private Shared Sub dibujarLabel(ByVal Objeto As System.Drawing.Graphics)
        If Not _IsPrintLabel Then
            Return
        End If
        Select Case ColorPen.Width
            Case 1
                _HeitPanelLabel = 18
            Case 2
                _HeitPanelLabel = 28
        End Select

        Dim _FontLabel As New Font("Microsoft Sans Serif", 6)
        Dim _FontPrice As New Font("Microsoft Sans Serif", 6)
        If ColorPen.Width = 2 Then
            _FontLabel = New Font("Microsoft Sans Serif", 9)
            _FontPrice = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
        End If

        Dim bmT As Image
        Dim bitmaps As New Bitmap(Integer.Parse(delitedWidth), (Integer.Parse(_HeitPanelLabel)))
        bitmaps.SetResolution(96.0F, 96.0F)
        bmT = bitmaps
        Dim g As Graphics = Graphics.FromImage(bmT)
        g.FillRectangle(New SolidBrush(Color.White), 0, 0, delitedWidth, _HeitPanelLabel)

        'set the width for label product
        Dim stringZise As New SizeF
        stringZise = g.MeasureString(_LabelProduct, _FontLabel)
        Dim altoLabel As Single = stringZise.Height

        'Draw the label product
        g.DrawString(_LabelProduct, _FontLabel, Brushes.Black, 2, 0)

        '//////////////////////////////////////////////////////////// Drow in paint
        'Write the label producto
        Objeto.DrawString(_LabelProduct, _FontLabel, Brushes.Black, 2, 0)
        'Write the label Empaque
        Objeto.DrawString(_EmqProduct, _FontLabel, Brushes.Black, 2, altoLabel - 1)
        'Write the label Price
        stringZise = g.MeasureString(_PriceProduct.ToString("C2"), _FontPrice)
        Dim anchoPrecio As Single = stringZise.Width + 3
        Dim altoPrecio As Single = stringZise.Height
        Objeto.DrawString(_PriceProduct.ToString("C2"), _FontLabel, Brushes.Black, delitedWidth - anchoPrecio, altoLabel - 1)
        _HeitPanelLabel = (altoLabel + altoPrecio)
    End Sub

    Friend Shared ReadOnly Property GenetatedNewDigit(text As String) As String
        Get
            If IsValidCode(text) Then
                Return codigoBarrasF
            Else
                Return text
            End If
        End Get
    End Property
#End Region

End Class
