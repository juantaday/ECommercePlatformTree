Option Strict Off
Option Explicit On
Module mdFunciones
    'calcula el ultimo dijito
    Function formarCodBarras(ByVal codBarrasOr As String) As String
        formarCodBarras = codBarrasOr & comprobarDigitoControl(codBarrasOr)
    End Function

    Function comprobarDigitoControl(ByVal codigoBarras As String) As Byte
        Dim digito, calTotal As Byte
        Dim codTmp As String
        Dim bPal, numC As Byte
        Try
            Select Case Len(codigoBarras)
                Case 7, 12
                    codTmp = Right("0000000000000000" & codigoBarras, 17)
                    bPal = 3
                    For numC = 1 To 17
                        calTotal = calTotal + Val(Mid(codTmp, numC, 1)) * bPal
                        bPal = 4 - bPal
                    Next
                    digito = calTotal Mod 10
                    digito = IIf(digito = 0, 0, 10 - digito)
                Case 11
                    'calculate check digit
                    Dim even As Integer = 0
                    Dim odd As Integer = 0
                    For i = odd To codigoBarras.Length - 1
                        If i Mod 2 = 0 Then
                            odd += Int32.Parse(codigoBarras.Substring(i, 1)) * 3
                        Else
                            even += Int32.Parse(codigoBarras.Substring(i, 1))
                        End If
                    Next
                    'for
                    Dim total As Integer = even + odd
                    Dim cs As Integer = total Mod 10
                    cs = 10 - cs
                    If cs = 10 Then
                        cs = 0
                    End If

                    digito = cs
            End Select
            comprobarDigitoControl = digito
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Sub msgAviso(ByVal textoAviso As String)
        MsgBox(textoAviso, MsgBoxStyle.Exclamation, My.Application.Info.Title)
    End Sub

    Function medIn(ByVal vTextoTmp As Object, ByVal vPosicion As Object) As Object
        medIn = CShort(Mid(vTextoTmp, vPosicion, 1))
    End Function

End Module