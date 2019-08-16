Imports System.Drawing.Printing
Imports System.IO
Imports CADsisVenta
Imports CADsisVenta.DataSetFacturaVenta
Imports CADsisVenta.DataSetFacturaVentaTableAdapters
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine
Imports ECommercePlatformView.DebitEmployeeNameSpace
Imports LibPrintTicket.PrintTicket

Module PrintTickets
    Private _claveAcceso As String
#Region "printReciboTerminal"
    Public Function PrintReciboTerminal(ByVal _NumPago As Integer, ByVal opcionPrint As optPrintFac) As Boolean
        Select Case opcionPrint.typePrint
            Case "Ticket"
                Return ViwReciboTerminalTicket(_NumPago)
            Case "Matricial"
                Return ViewReciboPagoInMatricial(_NumPago)
            Case "Tinta"
                MsgBox("Disponible en la proxima version..", MsgBoxStyle.Exclamation, "Ups..")
                Return False
        End Select
        Return False
    End Function

    Private Function ViwReciboTerminalTicket(ByVal _IdCaja As Integer) As Boolean

        Dim Totalcobro As Double = 0, totalSaldo As Double = 0
        Dim FechaCobro As DateTime = Date.Now
        Dim Terminal As String = String.Empty, Operacion As String = String.Empty, Aurizado As String = String.Empty,
            Cajero As String = String.Empty, Concepto As String = String.Empty

        Dim Ticket1 As New CreaTicket
        Try
            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona

            'caega color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            End If
            'gargamos los datos
            GoTo ReadDetail

Pritn_Cabecera:
            Ticket1.AbreCajon()
            Ticket1.isAvanzaLinea = True
            '---------------------------------------------perint empresa
            Ticket1.FontZiseText(FontZise.l8cpp)                          ' letra grande
            Ticket1.TextoIzquierda(EcommerceActive.RazonSocial, False)           'nombre de la empresa
            '---------------------------------------------Print recibo
            Ticket1.FontZiseText(FontZise.l4cpp)
            Ticket1.TextoIzquierda("RECIBO DE TERMINAL", False)           'nombre de la empresa' TAMAÑO DE LETRA A 8
            Ticket1.FontZiseText(FontZise.l2cpp)
            '//////////////////////define para imprimir numero  y valor
            sql = Totalcobro.ToString("C2")
            Dim TotalDescrip As String = TextoDiseñado(Totalcobro.ToString("C2"), Alinea.Derecha, sql.Length)
            Dim Recibo As String = TextoDiseñado("Nro:" & _IdCaja.ToString(), Alinea.Izquierda, 40 - (sql.Length + 11))
            Ticket1.TextoIzquierda(Recibo & "Por:" & TotalDescrip, False)

            '----------------------------------------------print cabecera
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.isAvanzaLinea = False
            Ticket1.TextoIzquierda("Fecha: " & FechaCobro.ToShortDateString & " Hora: " & FechaCobro.ToShortTimeString, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Terminal: " & Terminal, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Operacion: " & Operacion, False)
            Ticket1.AvanzaRollo(1)
            '----------------------------------------------Description
            Ticket1.LineasGuion()
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Por concepto de:", False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoCentro(Concepto & vbCrLf, False)
            Ticket1.LineasGuion()
            '----------------------------------------------Description
            Ticket1.isAvanzaLinea = True
            Dim Detail As String = String.Empty,
                valFactur As String = String.Empty,
                valPagado As String = String.Empty,
                Saldo As String = String.Empty


            Ticket1.AvanzaLinea(1)
            Ticket1.FontZiseText(FontZise.l4cpp)
            Ticket1.TextoIzquierda("T.RECIBO:" & Totalcobro.ToString("C2"), False)
            Ticket1.FontZiseText(FontZise.l0cpp)
            Ticket1.LineasAsterisco()
            Ticket1.TextoIzquierda("Impreso por: " & UsuarioActivo.Apellido & " " & UsuarioActivo.Nombre, False)
            Ticket1.TextoIzquierda("Fecha impreso: " & Date.Now.ToShortDateString & " Hora: " & Date.Now.ToShortTimeString, False)
            Ticket1.TextoIzquierda("Desde: " & TerminalActivo.codTerminal & " (" & Dominio._HotName & ")", False)
            Ticket1.LineasAsterisco()

            '//////////////////  atentament
            Ticket1.AvanzaLinea(1)
            Ticket1.FontZiseText(FontZise.Default)
            '//////////////////  firmantes
            Ticket1.LineasIgual()
            Ticket1.TextoDerecha("A T E N T A M E N T E:", False)
            Ticket1.TextoDerecha("Firma cajero", False)
            Ticket1.TextoDerecha("Cajero: " & Cajero, False)
            '//////////////////  firmma
            Ticket1.LineasGuion()
            Ticket1.AvanzaLinea(1)
            Ticket1.TextoDerecha("FIRMA AUTORIZADO:", True)
            Ticket1.TextoDerecha("Por: " & Aurizado, False)
            Ticket1.LineasGuion()
            GoTo Salida


ReadDetail:
            'Leo los datos para imprimir 
            Dim ThereIsData As Boolean = False
            Using db As New DataContext

                Dim _myDetails = From t In db.Terminal
                                 Join cs In db.CajaStado On t.idTerminal Equals cs.idTerminal
                                 Join cj In db.Cajas On cs.idCajaStado Equals cj.idCajaStado
                                 Join fp In db.FormaPago On fp.idformaPago Equals cj.idFormaPago
                                 Where cj.idCaja = _IdCaja
                'creamos la tabla y tenemos datos

                For Each item In _myDetails
                    Totalcobro += item.cj.haber
                    FechaCobro = item.cj.dateAntTime
                    Terminal = item.t.codTerminal
                    Operacion = item.cj.idCajaStado
                    Aurizado = item.cj.codUserMovi
                    Cajero = If(String.IsNullOrEmpty(item.cs.own_User), UsuarioActivo.codUser, item.cs.own_User)
                    Concepto = item.cj.Descripcion
                    ThereIsData = True
                Next
            End Using

            If ThereIsData Then
                GoTo Pritn_Cabecera
            Else
                Ticket1.TextoDerecha("No hay informacion..", False)
                GoTo Salida
            End If

Salida:
            Ticket1.CortaTicket()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
#Region "printArqueoTerminal"
    Public Function PrintArqueoTerminal(ByVal idCajaStado As Integer, ByVal opcionPrint As optPrintFac) As Boolean
        Select Case opcionPrint.typePrint
            Case "Ticket"
                Return ViwArqueoTerminalTicket(idCajaStado)
            Case "Matricial"
                Return ViewArqueoTerminalMatricial(idCajaStado)
            Case "Tinta"
                MsgBox("Disponible en la proxima version..", MsgBoxStyle.Exclamation, "Ups..")
                Return False
        End Select
        Return False
    End Function
    Private Function ViwArqueoTerminalTicket(ByVal idCajaStado As Integer) As Boolean
        Dim myListClose As Object
        Dim myInformation As Object
        Dim Ticket1 As New CreaTicket
        Dim debe As Double = 0
        Dim haber As Double = 0
        Dim _debe As Double = 0
        Dim _haber As Double = 0
        Dim diferencia As Double = 0
        Dim cantStg As String = String.Empty
        Try
            Using db As New DataContext
                myListClose = From l In db.getTerminalClosure(idCajaStado) _
                                   .OrderBy(Function(x) x.idformaPago) _
                                  .ThenBy(Function(x) x.cod).ToList()

                myInformation = (From s In db.CajaStado
                                 Join t In db.Terminal On t.idTerminal Equals s.idTerminal
                                 Where s.idCajaStado = idCajaStado).ToList()
            End Using

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'INICIO DE IMPRECION
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona
            'carga color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            Else
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            End If
            Ticket1.AvanzaEncabezado()                      'AVANZA 28 LINEAS
            Ticket1.isAvanzaLinea = True
            Ticket1.FontZiseText(FontZise.l8cpp)
            Ticket1.AlinementLefth()
            Ticket1.TextoIzquierda(EcommerceActive.RazonSocial, False)
            Ticket1.FontZiseText(FontZise.l6cpp)
            Ticket1.TextoIzquierda("Arqueo de terminal", False)
            Ticket1.TextoIzquierda("Operacion: " & idCajaStado.ToString(), False)

            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.LineasGuion()
            'there is information
            If IsNothing(myListClose) Then
                Ticket1.TextoCentro("No hay informacion.", False)
                Return True
            End If

            Dim idFormaPago As Integer = 0
            Dim formaPago As String = String.Empty
            Dim isPrintDiference As Boolean = False
            For Each item In myListClose
                If Not (idFormaPago = item.idformaPago) Then
                    If Not (formaPago = item.formaPago) And formaPago.Equals("Efectivo") Then
                        isPrintDiference = True
                        diferencia = haber - debe
                        Ticket1.FontZiseText(FontZise.Default)
                        Ticket1.LineasTotales()
                        Ticket1.ColorPrintCinta(ColorPrint.Rojo)
                        Ticket1.FontZiseText(FontZise.l2cpp)
                        Ticket1.TextoDerecha("Diferencia: " & diferencia.ToString("C2"), False)
                        Ticket1.ColorPrintCinta(ColorPrint.Negro)
                        Ticket1.FontZiseText(FontZise.Default)
                        Ticket1.LineasTotales()
                    End If
                    Ticket1.FontZiseText(FontZise.Default)
                    Ticket1.LineasAsterisco()
                End If

                If Not idFormaPago = item.idformaPago Then
                    debe = 0
                    haber = 0
                    Ticket1.FontZiseText(FontZise.Default)
                    Ticket1.LineasGuion()
                    Ticket1.FontZiseText(FontZise.l4cpp)
                    Dim aString As String = Replace(item.formaPago, "é", "e")
                    Ticket1.TextoIzquierda(aString, False)
                    Ticket1.FontZiseText(FontZise.Default)
                    Ticket1.LineasTotales()
                    Ticket1.TextoIzquierda("  DETALLE                  DEBE    HABER", False)
                End If
                _debe = item.debe
                _haber = item.haber
                cantStg = TextoDiseñado(item.detalle, Alinea.Izquierda, 21)
                cantStg = " " & cantStg & TextoDiseñado(_debe.ToString("N2"), Alinea.Derecha, 9)
                cantStg = cantStg & TextoDiseñado(_haber.ToString("N2"), Alinea.Derecha, 9)
                Ticket1.TextoIzquierda(cantStg, False)

                debe += _debe
                haber += _haber
                idFormaPago = item.idformaPago
                formaPago = item.formaPago
            Next
            If Not isPrintDiference Then
                diferencia = haber - debe
                Ticket1.FontZiseText(FontZise.Default)
                Ticket1.LineasTotales()
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
                Ticket1.FontZiseText(FontZise.l2cpp)
                Ticket1.TextoDerecha("Diferencia: " & diferencia.ToString("C2"), False)
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
                Ticket1.FontZiseText(FontZise.Default)
                Ticket1.LineasTotales()
            End If
            Ticket1.AvanzaLinea(2)
            Ticket1.LineasIgual()
            Ticket1.FontZiseText(FontZise.Default)
            Dim codUserOpen As String = String.Empty
            Dim codUserClosed As String = String.Empty
            Dim codTerminal As String = String.Empty
            Dim dateStar As String = String.Empty
            Dim dateEnd As String = String.Empty

            For Each item In myInformation
                dateStar = item.s.dateStar.ToString()
                dateEnd = item.s.dateEnd.ToString()
                codUserOpen = item.s.codUserOpen.ToString()
                codUserClosed = item.s.codUserClosed.ToString()
                codTerminal = item.t.codTerminal.ToString()
            Next
            Ticket1.TextoDerecha("TERMINAL:" & codTerminal, False)
            Ticket1.TextoDerecha("Abierto por:" & codUserOpen, False)
            Ticket1.TextoDerecha("Inicio :" & dateStar, False)
            Ticket1.TextoDerecha("Cierre:" & dateEnd, False)
            Ticket1.TextoDerecha("Arqueado por:" & codUserClosed, False)
            Ticket1.TextoDerecha("Impreso:" & UsuarioActivo.codUser, False)

            Ticket1.CortaTicket()
            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & " Ocurrió en: " & ex.StackTrace.ToString())
            Return False
        Finally
            Ticket1 = Nothing
        End Try
    End Function
    Private Function ViewArqueoTerminalMatricial(ByVal idCajaStado As Integer) As Boolean
        Try
            Return False
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & " Ocurrió en: " & ex.StackTrace.ToString())
            Return False
        End Try
    End Function
#End Region
#Region "printReciboCobro"
    Public Function PrintReciboCobro(ByVal _NumPago As String, ByVal opcionPrint As optPrintFac) As Boolean
        Select Case opcionPrint.typePrint
            Case "Ticket"
                Return ViwReciboCobroInTicket(_NumPago)
            Case "Matricial"
                Return ViewReciboPagoInMatricial(_NumPago)
            Case "Tinta"
                MsgBox("Disponible en la proxima version..", MsgBoxStyle.Exclamation, "Ups..")
                Return False
        End Select
        Return False
    End Function

    Private Function ViwReciboCobroInTicket(ByVal _NumPago As String) As Boolean
        Dim ListDetailPayment As New List(Of DetailPayment)
        Dim ListSaldo As New List(Of DebitEmployee)

        Dim IdPersona As Integer = 0
        Dim Totalcobro As Double = 0, totalSaldo As Double = 0, TotalDebt As Double = 0, _saldoItem As Double = 0
        Dim FechaCobro As DateTime = Date.Now
        Dim Cliente As String = String.Empty, Ruc As String = String.Empty, Recaudador As String = String.Empty

        Dim Ticket1 As New CreaTicket
        Try
            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona

            'caega color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            End If
            'gargamos los datos
            GoTo ReadDetail

Pritn_Cabecera:
            Ticket1.AbreCajon()
            '---------------------------------------------perint empresa
            Ticket1.FontZiseText(FontZise.l6cpp)                          ' letra grande
            Ticket1.TextoIzquierda(EcommerceActive.RazonSocial, False)           'nombre de la empresa
            '---------------------------------------------Print recibo
            Ticket1.FontZiseText(FontZise.l4cpp)
            Ticket1.TextoIzquierda("RECIBO DE COBRO", False)           'nombre de la empresa' TAMAÑO DE LETRA A 8
            Ticket1.FontZiseText(FontZise.l2cpp)
            '//////////////////////define para imprimir numero  y valor
            sql = Totalcobro.ToString("C2")
            Dim TotalDescrip As String = TextoDiseñado(Totalcobro.ToString("C2"), Alinea.Derecha, sql.Length)
            Dim Recibo As String = TextoDiseñado("Nro:" & _NumPago, Alinea.Izquierda, 40 - (sql.Length + 11))
            Ticket1.TextoIzquierda(Recibo & "Por:" & TotalDescrip, False)

            '----------------------------------------------print cabecera
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.isAvanzaLinea = False
            Ticket1.TextoIzquierda("Fecha: " & FechaCobro.ToShortDateString & " Hora: " & FechaCobro.ToShortTimeString, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Cliente: " & Cliente, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("CI/RUC: " & Ruc, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Terminal: " & TerminalActivo.codTerminal, False)
            Ticket1.AvanzaRollo(1)
            '----------------------------------------------Description
            Ticket1.TextoIzquierda("Hemos recibido de " & Cliente, False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("Por el siguiente concepto:", False)
            Ticket1.AvanzaLinea(1)
            Ticket1.AlinementRight()
            Ticket1.LineasGuion()
            Ticket1.Avanza2Lines()
            Ticket1.TextoDerecha("DESCRIPCION     V.FACTUR  V.PAGO   SALDO", False)
            Ticket1.Avanza2Lines()
            Ticket1.LineasGuion()
            Ticket1.AvanzaLinea(1)
            '----------------------------------------------Description
            Ticket1.isAvanzaLinea = True
            Dim Detail As String = String.Empty,
                valFactur As String = String.Empty,
                valPagado As String = String.Empty,
                Saldo As String = String.Empty

            For Each item In ListDetailPayment
                Detail = TextoDiseñado(item.Detail, Alinea.Izquierda, 16)
                valFactur = TextoDiseñado(item.ValFactura.ToString("N2"), Alinea.Derecha, 8)
                valPagado = TextoDiseñado(item.ValPago.ToString("N2"), Alinea.Derecha, 8)
                Saldo = TextoDiseñado(item.ValSalso.ToString("N2"), Alinea.Derecha, 8)
                totalSaldo += item.ValSalso
                'printer
                Ticket1.TextoDerecha(Detail & valFactur & valPagado & Saldo, False)
            Next
            Ticket1.AvanzaLinea(1)
            Ticket1.AlinementLefth()
            Ticket1.FontZiseText(FontZise.l4cpp)
            Ticket1.TextoIzquierda("Tot PAGADO:" & Totalcobro.ToString("C2"), False)
            Ticket1.FontZiseText(FontZise.l2cpp)
            Ticket1.TextoIzquierda("SALDO LISTA:" & totalSaldo.ToString("C2"), False)

            '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ SALDO DE DOCUMENTOTOS
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.AlinementRight()
            Ticket1.AvanzaLinea(3)
            Ticket1.LineasIgual()
            Ticket1.FontZiseText(FontZise.l4cpp)
            Ticket1.TextoIzquierda("SALDO DOCUMENTOS", False)
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.isAvanzaLinea = False
            Ticket1.AvanzaLinea(1)
            Ticket1.AlinementRight()
            Ticket1.LineasGuion()
            Ticket1.Avanza2Lines()
            Ticket1.TextoDerecha("DETALLE                            SALDO", False)
            Ticket1.Avanza2Lines()
            Ticket1.LineasGuion()
            Ticket1.AvanzaLinea(1)
            Ticket1.isAvanzaLinea = True

            If ListSaldo.Count > 0 Then
                For Each item In ListSaldo
                    Detail = TextoDiseñado(String.Format("{0}: {1}", item.TypeDebit, item.Document), Alinea.Izquierda, 32)
                    _saldoItem = item.DebitValue
                    If Detail.Contains("Responsabilidades") Then
                        _saldoItem = item.DebitValue - item.PaymentDebit
                    End If
                    'printer
                    Saldo = TextoDiseñado(_saldoItem.ToString("N2"), Alinea.Derecha, 8)
                    Ticket1.TextoDerecha(Detail & Saldo, False)
                Next
                Ticket1.FontZiseText(FontZise.l2cpp)
                Ticket1.TextoDerecha("TOTAL PENDIENTE: " & TotalDebt.ToString("C2"), False)
                Ticket1.FontZiseText(FontZise.Default)
            Else
                Ticket1.TextoDerecha("No tiene saldos pendientes....", False)
            End If

            '//////////////////  atentament
            Ticket1.AvanzaLinea(1)
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.AlinementRight()
            Ticket1.LineasIgual()
            Ticket1.TextoDerecha("Recaudador: " & Recaudador, False)
            Ticket1.TextoDerecha("A T E N T A M E N T E:", False)
            Ticket1.TextoDerecha(EcommerceActive.RazonSocial, False)

            '//////////////////  firmma
            Ticket1.LineasGuion()
            Ticket1.TextoDerecha("FIRMA CLIENTE:", True)
            GoTo Salida

ReadDetail:
            'Leo los datos para imprimir 
            Using db As New DataContext
                Dim _myDetails = From cb In db.Cobros
                                 Join cd In db.CobroDetail On cb.idCobro Equals cd.idCobro
                                 Join c In db.Clientes On cb.idCliente Equals c.idCliente
                                 Join p In db.Personas On p.idPersona Equals c.idPersona
                                 Where cd.num_cobro = _NumPago
                'creamos la tabla y tenemos datos

                For Each item In _myDetails
                    IdPersona = item.p.idPersona
                    Totalcobro += item.cd.val_Cobro
                    FechaCobro = item.cd.fech_Cobro
                    Cliente = item.p.Apellidos & " " & item.p.Nombre
                    Ruc = item.p.Ruc_Ci
                    Recaudador = item.cd.loginUser

                    Dim TotCobrado = Aggregate cob In db.CobroDetail
                                         Where cob.idCobro = item.cb.idCobro
                          Into Sum(cob.val_Cobro)

                    Dim _ItemDetal As New DetailPayment With
                    {
                        .Detail = "Documento:" & item.cb.idFacturaVenta.ToString,
                        .ValFactura = item.cb.val_Factura,
                        .ValPago = item.cd.val_Cobro,
                        .TotalCobrabo = If(IsNothing(TotCobrado), 0, TotCobrado),
                        .ValSalso = .ValFactura - .TotalCobrabo
                       }
                    ListDetailPayment.Add(_ItemDetal)
                Next
                'LEO TOTAL DE DEUDAS
                Dim _debitSales = From debit In db.GetDebitClient(IdPersona)

                For Each item In _debitSales
                    ListSaldo.Add(New DebitEmployee() With
                      {
                      .IdEmpleadoDeuda = item.idFacturaVenta,
                      .TypeDebit = "Venta productos",
                      .Document = item.idFacturaVenta,
                      .Apellidos = item.Apellidos,
                      .DebitDate = item.fech_Factura,
                      .DebitValue = item.val_Factura - item.ValCobrado,
                      .IdPerson = item.idPersona,
                      .Nombres = item.Nombre,
                      .RucCi = item.Ruc_Ci
                      })
                    TotalDebt += item.val_Factura - item.ValCobrado
                Next


                Dim _debitEmployee = From debit In db.GetDebitEmployee(IdPersona)

                For Each item In _debitEmployee
                    ListSaldo.Add(New DebitEmployee() With
                            {
                              .IdEmpleadoDeuda = item.idEmpleadoDeuda,
                              .TypeDebit = "Responsabilidades",
                              .Document = item.idEmpleadoDeuda,
                              .Apellidos = item.Apellidos,
                              .DebitDate = item.DebitDate,
                              .DebitValue = item.DevitValue,
                              .IdPerson = item.idPersona,
                              .Nombres = item.Nombre,
                              .RucCi = item.Ruc_Ci,
                              .PaymentDebit = item.valCobrado
                            })
                    TotalDebt += item.DevitValue - item.valCobrado
                Next

            End Using

            If ListDetailPayment.Count > 0 Then
                GoTo Pritn_Cabecera
            Else
                Ticket1.TextoDerecha("No hay informacion..", False)
                GoTo Salida
            End If

Salida:
            Ticket1.CortaTicket()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ViewReciboPagoInMatricial(ByVal numpago As String)
        Try
            Using frmReporview As New frmReportCobroDeuda(numpago)
                With frmReporview
                    .ShowDialog()
                End With
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region
#Region "printProforma"
    Public Function Print_Proforma(idProforma As Integer, Document As String) As Boolean
        Try
            Dim PagTotal, PagActual, VueltaItem, i As Integer
            Dim pvpPage, TotalGeneral As Double
            Dim detalle, pvpTexto As String
            Dim Hora As String
            Hora = DateTime.Now.ToString("T")

            'carga nombre de la impresora configurada si no esta  va ha panel de opciones
cargaNuevo:
            If Not LoadOptionsPrint(Document) Then
                MsgBox("No se encuentra la impresora configurada", MsgBoxStyle.Information, "Aviso")
                Using form As New frmOptionPrint()
                    With form
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            If i = 0 Then
                                i = 1
                                GoTo cargaNuevo
                            Else
                                Return False
                            End If
                        End If
                    End With
                End Using
                Return False
            End If

            If Not myOptnsPrint.items > 0 Then
                MsgBox("Determine la cantidad de lineas de impresión en opcion de: [Coniguración] [Impresora de Tickest]")
                Return False
            End If
            'si no puedo cargar la cabecera salgo
            'If Not Carga_Cabecera(idProforma) Then
            '    Return False
            'End If

            Dim Ticket1 As New CreaTicket
            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona

            'caega color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                '      Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                ' Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            Else
                '       Ticket1.ColorPrintCinta(ColorPrint.Negro)
            End If
            'si quiero que avance el carro de la impresión


            Dim dt As New DataTable()
            dt = Carga_Detalle(idProforma)
            If IsNothing(dt) Then Return False
            If (dt.Rows.Count = 0) Then Return False

            Dim NumFac As Double = dt.Rows.Count / myOptnsPrint.items
            Dim valor As String = NumFac
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                sql = Strings.Left(valor, posicion - 1)
                PagTotal = Integer.Parse(sql) + 1
            Else
                PagTotal = Integer.Parse(NumFac)
            End If
            VueltaItem = 0

            For IndexRows = 0 To dt.Rows.Count - 1
                If VueltaItem = 0 Then
                    GoTo Pritn_Cabecera
                End If
LineaDetalle:
                Ticket1.FontZiseText(FontZise.Default)

                pvpPage += dt.Rows(IndexRows)("Vent_Total")  'precio de producto
                detalle = dt.Rows(IndexRows)("Cant_Vent")    'Cantidad

                posicion = Strings.InStr(detalle, ".")
                i = Integer.Parse(Strings.Right(detalle, Len(detalle) - posicion))
                If i = 0 Then
                    detalle = Strings.Left(detalle, posicion - 1)
                End If

                detalle = detalle & " " & dt.Rows(IndexRows)("Presentacion")  'empaque
                detalle = detalle & " " + dt.Rows(IndexRows)("Nom_Comun")   'nom_Comercial
                detalle = TextoDiseñado(detalle, Alinea.Izquierda, 33)

                Dim ItemTotal As Double = dt.Rows(IndexRows)("Vent_Total")  'redoondeo el precio a dos decimales
                pvpTexto = TextoDiseñado(ItemTotal.ToString("N2"), Alinea.Derecha, 7)
                Ticket1.TextoDerecha(detalle & pvpTexto, False)
                VueltaItem += 1

                If IndexRows = dt.Rows.Count - 1 Then
                    Ticket1.AvanzaRollo(myOptnsPrint.items - VueltaItem)
                    GoTo Pritn_PieInforme
                End If

                If VueltaItem = myOptnsPrint.items Then
                    GoTo Pritn_PiePagina
                End If
                GoTo Salida_Next
Pritn_Cabecera:
                Ticket1.FontZiseText(FontZise.l6cpp)                          ' letra grande
                Ticket1.TextoCentro(Document & " N: " & idProforma, False)           'PROFORMA numero
                Ticket1.FontZiseText(FontZise.Default)                         ' TAMAÑO DE LETRA A 8
                Ticket1.TextoIzquierda("Cliente:" & ClienteActivo.Nombres, False)        ' NOMBRE DE CLIENTE
                Ticket1.TextoIzquierda("Ruc o C.I:" & ClienteActivo.Ruc, False)               'RUC O C.I
                Ticket1.TextoIzquierda("Usuario:" & UsuarioActivo.codUser, False) 'Usuario quien emprime
                Ticket1.TextoIzquierda("FECHA:" + FormatDateTime(Now, DateFormat.ShortDate) + "-" + Hora, False)
                Ticket1.AlinementRight()
                Ticket1.LineasGuion()
                Ticket1.TextoDerecha("Cant-empaque      Articulo         PVP  ", False)
                Ticket1.LineasGuion()
                pvpPage = 0
                GoTo LineaDetalle
Pritn_PiePagina:
                Ticket1.FontZiseText(FontZise.l2cpp)
                PagActual += 1
                TotalGeneral += pvpPage
                Ticket1.TextoDerecha("Pagina " & PagActual & " de " & PagTotal & ": $" & Redondear(pvpPage, 2), False)
                Ticket1.CortaTicket()
                VueltaItem = 0
                GoTo Salida_Next
Pritn_PieInforme:
                PagActual += 1
                TotalGeneral += pvpPage
                Ticket1.FontZiseText(FontZise.l2cpp)
                Ticket1.TextoDerecha("Pagina " & PagActual & " de " & PagTotal & ": " & pvpPage.ToString("C2"), False)
                Ticket1.FontZiseText(FontZise.l6cpp)
                If Not ClienteActivo.OtroValor > 0 Then
                    Ticket1.TextoDerecha("Total Proforma " & idProforma & ": " & TotalGeneral.ToString("C2"), False)
                Else
                    TotalGeneral = Redondear(TotalGeneral + ClienteActivo.OtroValor, 2)
                    Ticket1.TextoDerecha("*Total Proforma " & idProforma & ": " & TotalGeneral.ToString("C2"), False)
                End If
                Ticket1.CortaTicket()
Salida_Next:
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + " en el modulode impresión de TICKET", MsgBoxStyle.Critical, "Aviso")
            Return False
        End Try
    End Function
    Private Function Carga_Detalle(idProforma As Integer) As DataTable
        Try
            sql = "select vd.* ,pp.PresentacionPrint,pp.Presentacion,pp.idProducto, p.Nom_Comun
                from [dbo].[Ventas_Detail]  as vd 
                inner join [dbo].[ProductoPresentacion] as pp on pp.idPresentacion = vd.idPresent
                inner join Productos as  p  on p.idProducto = pp.idProducto 
                 Where  vd.idVenta = " & idProforma

            Dim cmd As New ClassCargadorProducto
            Return cmd.RetornaTabla(sql)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "printTicket"
    Public Function Print_Ticket(ByVal idFactur As Integer,
                                 Optional isLatest As Boolean = False,
                                 Optional claveAcceso As String = "",
                                 Optional isInvoiceElectronic As Boolean = False) As Boolean
        Try
            _claveAcceso = claveAcceso
            'is isntall printer name for factur
            If Not isInstallPrinter_factura() Then
                Return False
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
                            Return False
                        End If
                        If dC.Rows.Count = 0 Then
                            Return False
                        End If
                        '-------------------------------------------------
                        'Load Detalle----------------------------------

                        dT = carga_Detail(item.idDocument)
                        If IsNothing(dT) Then
                            Return False
                        End If
                        If dT.Rows.Count = 0 Then
                            Return False
                        End If
                        'Evaluo si es facturacion electronica....
                        If isInvoiceElectronic Then
                            PrintTicket_FacturAndNoteVent(dC, dT)
                        Else
                            PrintTicket_FacturAndNoteVent(dC, dT)
                        End If
                    Next
                    Return True
                End Using
                Return True
            End If

            'si me entrega un id de documento
            dC = carga_Cabecera(idFactur)
            If IsNothing(dC) Then
                Return False
            End If
            If dC.Rows.Count = 0 Then
                Return False
            End If
            '-------------------------------------------------
            'Load Detalle----------------------------------

            dT = carga_Detail(idFactur)
            If IsNothing(dT) Then
                Return False
            End If
            If dT.Rows.Count = 0 Then
                Return False
            End If
            'Evaluo tipo de impresion....
            If isInvoiceElectronic Then
                ' PrintTicket_FacturRide(dC, dT)
            Else
                PrintTicket_FacturAndNoteVent(dC, dT)
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'imprime factura electronica
    'Public Function PrintTicket_FacturRide(dC As DataTable, dT As DataTable, Optional claveAcceso As String = "") As Boolean
    '    Try
    '        If Not String.IsNullOrEmpty(claveAcceso) Then
    '            _claveAcceso = claveAcceso
    '        End If
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        'INICIO DE IMPRECION
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        'cargo opciones de impresiones
    '        Dim Op As List(Of ItemSettingOptionPrint) = carga_OpcionPrint(dC.Rows(0)("idBodega"), dC.Rows(0)("idTypoDocument"))


    '        Dim Ticket1 As New CreaTicket
    '        Dim isIncludeIva As Boolean = False
    '        Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona
    '        'carga color de la impresora

    '        Ticket1.FontZiseText(FontZise.Default)
    '        Ticket1.AbreCajon()
    '        ' Ticket1.AvanzaLinea(1)                    'AVANZA 3 LINEAS
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        'DETERMINO SI INCLUYO IVA EN LOS ITEMS
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains("iva")).FirstOrDefault()) Then
    '            isIncludeIva = True
    '        End If

    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        '  PRINT DE COMPANIA
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '        If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault()) Then
    '            Dim fonZise? As Integer = Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault().FontZise
    '            Dim foreColor As String = Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault().ForeColor.ToString()
    '            If foreColor.Contains("Rojo") Then
    '                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
    '            Else
    '                Ticket1.ColorPrintCinta(ColorPrint.Negro)
    '            End If
    '            Ticket1.FontZiseText(CType(fonZise, FontZise))
    '            Ticket1.TextoIzquierda(EcommerceActive.Compania, False)
    '        End If
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        '  PRINT DETAIL COMPANY
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        Ticket1.FontZiseText(FontZise.Default)
    '        Ticket1.TextoIzquierda(SettinObject.EcommerceActive.RazonSocial)
    '        Ticket1.TextoIzquierda("R.U.C.: " & SettinObject.EcommerceActive.Ruc)
    '        Ticket1.TextoIzquierda("Matriz: " & SettinObject.EcommerceActive.Domicilio)
    '        Ticket1.TextoIzquierda("Teléfono: " & SettinObject.EcommerceActive.Phone)
    '        If Not String.IsNullOrEmpty(SettinObject.EcommerceActive.NroResolucion) Then
    '            Ticket1.TextoCentro("* Contribuyente espacial *")
    '            Ticket1.TextoCentro("Nro. resolución: " & SettinObject.EcommerceActive.NroResolucion)
    '        End If
    '        Ticket1.Avanza1Lines()
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        '  PRINT Num Factury
    '        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '        Ticket1.FontZiseText(FontZise.l4cpp)
    '        Ticket1.TextoCentro("FACTURA:")
    '        Ticket1.TextoIzquierda("No:" & dC.Rows(0)("Num_Factu"))
    '        '   CLAVE DE ACCESO
    '        Ticket1.FontZiseText(FontZise.l2cpp)
    '        Ticket1.TextoCentro("Clave de acceso:")
    '        Ticket1.TextoIzquierda(_claveAcceso)
    '        '  detalle de factura
    '        Dim ambient = New TipoAmbienteEnum(_claveAcceso.Substring(23, 1))
    '        Ticket1.FontZiseText(FontZise.l0cpp)
    '        Ticket1.TextoIzquierda("AMBIENTE:" & ambient.getName)
    '        Ticket1.TextoIzquierda("EMISION: NORMAL")

    '        Ticket1.TextoIzquierda("Fecha de emisión: " & CDate(dC.Rows(0)("fechaDesde")).ToString("dd/MM/yyyy"))
    '        Ticket1.Avanza1Lines()

    '        '  Datos del cliente
    '        Ticket1.FontZiseText(FontZise.l4cpp)
    '        Ticket1.TextoCentro("Datos del cliente:")
    '        Ticket1.FontZiseText(FontZise.l0cpp)
    '        Ticket1.TextoIzquierda("Nombre: " & dC.Rows(0)("Nombres"))
    '        Ticket1.TextoIzquierda("C.I./RUC: " & dC.Rows(0)("Ruc_Ci"))
    '        Ticket1.TextoIzquierda("FORMA PAGO: " + dC.Rows(0)("formaPago"), False) 'formaPago

    '        ' Lineas de encabezado del detalle......................
    '        Ticket1.isAvanzaLinea = False
    '        Ticket1.LineasIgual()
    '        Ticket1.Avanza2Lines()
    '        Ticket1.EncabezadoVenta()
    '        Ticket1.Avanza2Lines()
    '        Ticket1.LineasIgual()
    '        Ticket1.isAvanzaLinea = True
    '        Ticket1.Avanza2Lines()


    '        'variables
    '        Dim i, VueltaItem As Integer
    '        Dim Cant As Double
    '        Dim _descrip As String = String.Empty
    '        Dim cantStg, Descp1, Descp2, SimIva, pvp, Empaq, unt, TotalStri As String
    '        VueltaItem = 0

    '        For i = 0 To dT.Rows.Count - 1
    '            SimIva = dT.Rows(i)("isIva")
    '            Cant = dT.Rows(i)("Cantidad")
    '            Empaq = dT.Rows(i)("Medida")

    '            _descrip = dT.Rows(i)("Nom_Comercial")
    '            If _descrip.Length > 19 Then
    '                Descp1 = _descrip.Substring(0, 19)
    '                Descp2 = _descrip.Substring(19)
    '                Descp2 = Descp2 & " " & dT.Rows(i)("PresentacionPrint")
    '            Else
    '                Descp1 = _descrip
    '                Descp2 = dT.Rows(i)("PresentacionPrint")
    '            End If



    '            TotalStri = dT.Rows(i)("Prec_Venta")
    '            If Not isIncludeIva Then
    '                TotalStri = FormatNumber(dT.Rows(i)("Prec_Venta") - dT.Rows(i)("Iva"), 2)
    '            End If

    '            If (dT.Rows(i)("Cantidad") > 0) Then
    '                If Not isIncludeIva Then
    '                    unt = FormatNumber(Double.Parse(TotalStri) / dT.Rows(i)("Cantidad"), 2)
    '                Else
    '                    unt = FormatNumber(dT.Rows(i)("Prec_Venta") / dT.Rows(i)("Cantidad"), 2)
    '                End If

    '            Else
    '                unt = "0.00"
    '            End If
    '            pvp = unt
    '            cantStg = Cant
    '            cantStg += Empaq
    '            cantStg = TextoDiseñado(cantStg, Alinea.Derecha, 5)

    '            Ticket1.isAvanzaLinea = False
    '            Ticket1.AgregaArticulo(SimIva, cantStg, Descp1, pvp, TotalStri) 'imprime una linea de descripcion
    '            Ticket1.Avanza2Lines()
    '            Ticket1.TextoIzquierda("       " & Descp2)
    '            Ticket1.Avanza3Lines()

    '            VueltaItem += 1
    '            If VueltaItem = myOptnsPrint.items Then Exit For
    '        Next

    '        'For i = 1 To (myOptnsPrint.items - VueltaItem)
    '        '    Ticket1.ImprimeLineaVacia()
    '        '    Ticket1.Avanza2Lines()
    '        'Next

    '        Ticket1.isAvanzaLinea = False
    '        Ticket1.LineasIgual()
    '        Ticket1.Avanza2Lines()
    '        Ticket1.AgregaTotales("BASE TARIFA IVA 0%:", FormatNumber(dC.Rows(0)("Base00Iva"), 2))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.AgregaTotales(String.Format("BASE TARIFA IVA {0}:", EcommerceActive.IvaPercent.ToString("P2")), FormatNumber(dC.Rows(0)("Base12Iva"), 2))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.AgregaTotales("SUB TOTAL:", FormatNumber(dC.Rows(0)("Base00Iva") + dC.Rows(0)("Base12Iva"), 2))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.AgregaTotales(String.Format("IVA {0}:", EcommerceActive.IvaPercent.ToString("P2")), FormatNumber(dC.Rows(0)("Iva"), 2))
    '        Ticket1.Avanza3Lines()

    '        ' imprime el valor total
    '        'Ticket1.LineasTotales()
    '        Ticket1.FontZiseText(FontZise.l6cpp)
    '        If dC.Rows(0)("OtroValor") > 0 Then
    '            Ticket1.AgregaTotales("*TOTAL A PAGAR", FormatNumber(dC.Rows(0)("Total"), 2))
    '        Else
    '            Ticket1.TextoDerecha("TOTAL A PAGAR: " & CDbl(dC.Rows(0)("Total")).ToString("N2") & "   ")
    '        End If
    '        Ticket1.AvanzaRollo(1)

    '        ' imprim campos adicionales
    '        Ticket1.FontZiseText(FontZise.Default)
    '        Ticket1.isAvanzaLinea = False
    '        Ticket1.TextoIzquierda("Hora: " & CDate(dC.Rows(0)("fechaDesde")).ToString("HH:mm:ss"))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Vendedor: " & dC.Rows(0)("codUser"))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Terminal: " + dC.Rows(0)("codTerminal"))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Fecha venc.: " + dC.Rows(0)("fechaHasta"))
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Cod cliente: " + CInt(dC.Rows(0)("idCliente")).ToString())
    '        Ticket1.Avanza2Lines() 'idCliente
    '        Ticket1.TextoIzquierda("Direccion: " + dC.Rows(0)("Direccion"), False)
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Cod interno: " + dC.Rows(0)("idFactVenta").ToString())
    '        Ticket1.Avanza2Lines()
    '        Ticket1.TextoIzquierda("Impreso por: " & UsuarioActivo.codUser)


    '        'Ticket1.AvanzaPiePagina()
    '        Ticket1.Avanza3Lines()
    '        If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains(" nota")).FirstOrDefault()) Then
    '            Ticket1.TextoIzquierda(EcommerceActive.note, True)
    '        End If
    '        Ticket1.CortaTicket()
    '        Ticket1 = Nothing
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
    '        Return False
    '    End Try
    'End Function
    '//hasta aqui

    Public Function PrintTicket_FacturAndNoteVent(ByVal dC As DataTable, ByVal dT As DataTable, Optional claveAcceso As String = "") As Boolean
        Try
            If Not String.IsNullOrEmpty(claveAcceso) Then
                _claveAcceso = claveAcceso
            End If
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'INICIO DE IMPRECION
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'cargo opciones de impresiones
            Dim Op As List(Of ItemSettingOptionPrint) = carga_OpcionPrint(dC.Rows(0)("idBodega"), dC.Rows(0)("idTypoDocument"))


            Dim Ticket1 As New CreaTicket
            Dim isIncludeIva As Boolean = False
            Ticket1.PrinterName = myOptnsPrint.NamePrint 'Nombre de la impresona
            'carga color de la impresora
            If myOptnsPrint.Color.Equals("Negro") Then
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            ElseIf myOptnsPrint.Color.Equals("Rojo") Then
                Ticket1.ColorPrintCinta(ColorPrint.Rojo)
            Else
                Ticket1.ColorPrintCinta(ColorPrint.Negro)
            End If
            Ticket1.FontZiseText(FontZise.Default)
            Ticket1.AbreCajon()
            Ticket1.AvanzaEncabezado()                    'AVANZA 28 LINEAS
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'DETERMINO SI INCLUYO IVA EN LOS ITEMS
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains("iva")).FirstOrDefault()) Then
                isIncludeIva = True
            End If

            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            'IMPRIMO DE COMPANIA
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault()) Then
                Dim fonZise? As Integer = Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault().FontZise
                Dim foreColor As String = Op.Where(Function(x) x.NameSetting.Contains("compan")).FirstOrDefault().ForeColor.ToString()
                If foreColor.Contains("Rojo") Then
                    Ticket1.ColorPrintCinta(ColorPrint.Rojo)
                Else
                    Ticket1.ColorPrintCinta(ColorPrint.Negro)
                End If
                Ticket1.FontZiseText(CType(fonZise, FontZise))
                Ticket1.TextoIzquierda(EcommerceActive.Compania, False)
            End If


            Ticket1.FontZiseText(FontZise.Default)
            'Impide avanzar a la sigiente lines 
            Ticket1.isAvanzaLinea = False
            Ticket1.TextoExtremos("Cod:" & Convert.ToString(dC.Rows(0)("idFactVenta").ToString), dC.Rows(0)("Num_Factu"))
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("CLIENTE:" + dC.Rows(0)("Nombres"), False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoExtremos("CI/RUC:" + dC.Rows(0)("Ruc_Ci"), "User:" + UsuarioActivo.codUser)
            Ticket1.Avanza2Lines()
            Ticket1.TextoIzquierda("DIRECCION:" + dC.Rows(0)("Direccion"), False)
            Ticket1.Avanza2Lines()
            Ticket1.TextoExtremos("FECH:" + dC.Rows(0)("fechaDesde"), "Term:" + dC.Rows(0)("codTerminal"))
            Ticket1.Avanza2Lines()
            Ticket1.isAvanzaLinea = True
            Ticket1.TextoIzquierda("FORMA PAGO: " + dC.Rows(0)("formaPago"), False) 'formaPago
            Ticket1.isAvanzaLinea = False
            Ticket1.LineasIgual()
            Ticket1.Avanza2Lines()
            Ticket1.EncabezadoVenta()
            Ticket1.Avanza2Lines()
            Ticket1.LineasIgual()
            Ticket1.Avanza2Lines()
            Ticket1.isAvanzaLinea = True
            'variables
            Dim i, VueltaItem As Integer
            Dim Cant As Double
            Dim cantStg, Descp, SimIva, pvp, Empaq, unt, TotalStri As String
            VueltaItem = 0

            For i = 0 To dT.Rows.Count - 1
                SimIva = dT.Rows(i)("isIva")
                Cant = dT.Rows(i)("Cantidad")
                Empaq = dT.Rows(i)("Medida")
                Descp = dT.Rows(i)("Nom_Comun")
                TotalStri = dT.Rows(i)("Prec_Venta")
                If Not isIncludeIva Then
                    TotalStri = FormatNumber(dT.Rows(i)("Prec_Venta") - dT.Rows(i)("Iva"), 2)
                End If

                If (dT.Rows(i)("Cantidad") > 0) Then
                    If Not isIncludeIva Then
                        unt = FormatNumber(Double.Parse(TotalStri) / dT.Rows(i)("Cantidad"), 2)
                    Else
                        unt = FormatNumber(dT.Rows(i)("Prec_Venta") / dT.Rows(i)("Cantidad"), 2)
                    End If

                Else
                    unt = "0.00"
                End If
                pvp = unt
                cantStg = Cant
                cantStg += Empaq
                cantStg = TextoDiseñado(cantStg, Alinea.Derecha, 5)

                Ticket1.isAvanzaLinea = False
                Ticket1.AgregaArticulo(SimIva, cantStg, Descp, pvp, TotalStri) 'imprime una linea de descripcion
                Ticket1.Avanza2Lines()
                VueltaItem += 1
                If VueltaItem = myOptnsPrint.items Then Exit For
            Next

            For i = 1 To (myOptnsPrint.items - VueltaItem)
                Ticket1.ImprimeLineaVacia()
                Ticket1.Avanza2Lines()
            Next
            Ticket1.isAvanzaLinea = False
            Ticket1.LineasIgual()
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("BASE TARIFA IVA 0%:", FormatNumber(dC.Rows(0)("Base00Iva"), 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales(String.Format("BASE TARIFA IVA {0}:", EcommerceActive.IvaPercent.ToString("P2")), FormatNumber(dC.Rows(0)("Base12Iva"), 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales("SUB TOTAL:", FormatNumber(dC.Rows(0)("Base00Iva") + dC.Rows(0)("Base12Iva"), 2))
            Ticket1.Avanza2Lines()
            Ticket1.AgregaTotales(String.Format("IVA {0}:", EcommerceActive.IvaPercent.ToString("P2")), FormatNumber(dC.Rows(0)("Iva"), 2))
            Ticket1.Avanza2Lines()
            Ticket1.isAvanzaLinea = False
            'Ticket1.LineasTotales()
            If dC.Rows(0)("OtroValor") > 0 Then
                Ticket1.AgregaTotales("*TOTAL A PAGAR", FormatNumber(dC.Rows(0)("Total"), 2))
            Else
                Ticket1.AgregaTotales("TOTAL A PAGAR", FormatNumber(dC.Rows(0)("Total"), 2))
            End If
            Ticket1.AvanzaPiePagina()
            Ticket1.AvanzaRollo(2)
            If Not IsNothing(Op.Where(Function(x) x.NameSetting.Contains(" nota")).FirstOrDefault()) Then
                Ticket1.isAvanzaLinea = False
                Ticket1.FontZiseText(FontZise.Default)
                Ticket1.TextoIzquierda(EcommerceActive.note, False)
            End If
            Ticket1.CortaTicket()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function carga_Cabecera(idFactur As Integer) As DataTable
        Try
            Dim datp As New Fact_venta_CabeceraTableAdapter
            Return datp.GetData(idFactur)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Private Function carga_Detail(idFactur As Integer) As DataTable
        Try
            Dim datp As New Fact_venta_DetailTableAdapter
            Return datp.GetData(idFactur)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
#Region "isInstallPrinter"
    Public Function isInstallPrinter_factura() As Boolean
        Try

            Dim i As Integer = 0
cargaNuevo:
            If IsNothing(myOptnsPrint.NamePrint) Then
                If Not LoadOptionsPrint(myOptnsPrint.idPrint) Then
                    MsgBox("No se encuentra la impresora configurada", MsgBoxStyle.Information, "Aviso")
                    Using form As New frmOptionPrint
                        With form
                            .ShowDialog()
                            If .DialogResult = DialogResult.OK Then
                                If i = 0 Then
                                    i = 1
                                    GoTo cargaNuevo
                                Else
                                    Return False
                                End If
                            End If
                        End With
                    End Using
                    Return False  'si ya da 2 vueltas y no pudo configurar sale
                End If
            End If
            If Not PrinterNametInstol(myOptnsPrint.NamePrint) Then
                MsgBox("La impresora" + myOptnsPrint.NamePrint + " no está instalada", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Return False
        End Try
    End Function
#End Region
#Region "printMatricial"
    Public Function printMatricial(document As String, idDocument As Integer, isLatest As Boolean) As Boolean
        Try
            Select Case document
                Case "Factura"
                    Return printFacturMatricial(isLatest, idDocument)
                Case "Nota de venta"
                    Return printNotaVentaMatricial(isLatest, idDocument)
                Case "Proforma" 'Pedido
                    Return printProformaMatricial(isLatest, idDocument)
                Case "Pedido" 'Pedido
            End Select
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            Return False
        End Try
    End Function

    Private Function printProformaMatricial(isLatest As Boolean, idDocument As Integer) As Boolean
        Try
            Using cmd As New getDataReportFacturTableAdapter
                Dim dt As New DataTable
                If isLatest Then
                    dt = cmd.GetDataByLast(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                Else
                    dt = cmd.GetDataByAll(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                End If
                If dt.Rows.Count > 0 Then
                    Using rpt As New ReportDocument()
                        rpt.Load(file_rptProformaBacha)
                        If rpt.IsLoaded Then
                            rpt.SetDataSource(dt)
                            Dim printerSettings As New PrinterSettings
                            printerSettings.PrinterName = myOptnsPrint.NamePrint
                            If printerSettings.IsValid Then
                                Dim pageSettings As New PageSettings(printerSettings)
                                rpt.PrintToPrinter(printerSettings, pageSettings, False)
                            End If
                        End If
                    End Using
                    Return True
                Else
                    MsgBox("No se pudo leer datos en el getDataReportFacturTableAdapter.", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function printNotaVentaMatricial(isLatest As Boolean, idDocument As Integer) As Boolean
        Try
            Using cmd As New getDataReportFacturTableAdapter
                Dim dt As New DataTable
                If isLatest Then
                    dt = cmd.GetDataByLast(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                Else
                    dt = cmd.GetDataByAll(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                End If
                If dt.Rows.Count > 0 Then
                    Using rpt As New ReportDocument()
                        rpt.Load(file_rptNotaVentaBacha)
                        If rpt.IsLoaded Then
                            rpt.SetDataSource(dt)
                            Dim printerSettings As New PrinterSettings
                            printerSettings.PrinterName = myOptnsPrint.NamePrint
                            If printerSettings.IsValid Then
                                Dim pageSettings As New PageSettings(printerSettings)
                                rpt.PrintToPrinter(printerSettings, pageSettings, False)
                            End If
                        End If
                    End Using
                    Return True
                Else
                    MsgBox("No se pudo leer datos en el getDataReportFacturTableAdapter.", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function printFacturMatricial(isAllDocument As Boolean, idDocument As Integer) As Boolean
        Try
            Using adat As New getDataReportFacturTableAdapter
                Dim dt As New DataTable
                If isAllDocument Then
                    dt = adat.GetDataByLast(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                Else
                    dt = adat.GetDataByAll(TerminalActivo.codTerminal, UsuarioActivo.codUser)
                End If

                If dt.Rows.Count > 0 Then
                    Using rpt As New ReportDocument()
                        rpt.Load(file_rptFacturaBacha)
                        rpt.SetDataSource(dt)
                        If rpt.IsLoaded Then
                            rpt.SetDataSource(dt)
                            Dim printerSettings As New PrinterSettings
                            printerSettings.PrinterName = myOptnsPrint.NamePrint
                            If printerSettings.IsValid Then
                                Dim pageSettings As New PageSettings(printerSettings)
                                rpt.PrintToPrinter(printerSettings, pageSettings, False)
                            End If
                        End If
                    End Using
                End If
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Module
