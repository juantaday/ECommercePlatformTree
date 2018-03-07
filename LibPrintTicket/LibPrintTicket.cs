using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace LibPrintTicket
{
    public class PrintTicket
    {
        #region Clase para generar CreaTicket
        // La clase "CreaTicket" tiene varios metodos para imprimir con diferentes formatos (izquierda, derecha, centrado, desripcion precio,etc), a
        // continuacion se muestra el metodo con ejemplo de parametro que acepta, longitud maxima y un ejemplo de como imprimira, esta clase esta 
        // basada en una impresora Epson de matriz de puntos con impresion maxima de 40 caracteres por renglon


        public enum ColorPrint
        {
            Negro = 0, Rojo = 1
               
        }


        public enum FontZise
        {
            Default = 0, l0cpp = 1, l2cpp = 2, l4cpp = 3, l6cpp = 4, l8cpp = 5
        }

        public class LeftRightMid
        {
            public static string Left(string param, int length)
            {
                string result = param.Substring(0, length);
                return result;
            }

            public static string Right(string param, int length)
            {
                int value = param.Length - length;
                string result = param.Substring(value, length);
                return result;
            }

            public static string Mid(string param, int startIndex, int length)
            {
                string result = param.Substring(startIndex, length);
                return result;
            }


        }

        public class CreaTicket
        {

            public string PrinterName;
            public bool isAvanzaLinea = true;
            string ticket = "";
            string parte1, parte2;
            int fontZise;
            //string impresora = "\\\\FARMACIA-PVENTA\\Generic / Text Only"; // nombre exacto de la impresora como esta en el panel de control
            //string impresora = "Generic / Text Only"; // nombre exacto de la impresora como esta en el panel de control
            int max, cort;
            public void LineasGuion()
            {
                ticket = "----------------------------------------";   // agrega lineas separadoras
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
            }
            public void LineasAsterisco()
            {
                ticket = "****************************************";   // agrega lineas separadoras *
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
            }
            public void LineasIgual()
            {
                ticket = "========================================";   // agrega lineas separadoras 
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
            }
            public void LineasTotales()
            {
                ticket = "                             -----------"; ;   // agrega lineas de total
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
            }
            public void EncabezadoVenta()
            {
                //ticket = "Articulo        Can    P.Unit    Importe\n";   // agrega lineas de  encabezados
                ticket = "I CNT   ARTICULO           P.Uit   TOTAL";   // agrega lineas de  encabezados
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime texto
            }

            #region Alinement
            public void AlinementLefth()
            {
                string Alineacion = "\x1B" + "a" + "\x0";
                RawPrinterHelper.SendStringToPrinter(PrinterName, Alineacion); // comado de lefth
            }
            public void AlinementCenter()
            {
                string Alineacion = "\x1B" + "a" + "\x1";
                RawPrinterHelper.SendStringToPrinter(PrinterName, Alineacion); // comado de Center
            }

            public void AlinementRight()
            {
                string Alineacion = "\x1B" + "a" + "\x2";
                RawPrinterHelper.SendStringToPrinter(PrinterName, Alineacion); // comado de Right
            }

            #endregion
            public void TextoIzquierda(string texto, bool Justificado)                          // agrega texto a la izquierda
            {
                string Alineacion = "\x1B" + "a" + "\x0";
                RawPrinterHelper.SendStringToPrinter(PrinterName, Alineacion); // comando de alineación

                if (Justificado)
                { ticket = AlineaTexto(texto, 40, true, PrinterName); }
                else
                { ticket = texto; }

                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }

                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket);
            }
            public void TextoDerecha(string text, bool Justificado)
            {
                string Alineacion = "\x1B" + "a" + "\x2";
                RawPrinterHelper.SendStringToPrinter(PrinterName, Alineacion); // comado de alineacion
                if (Justificado)
                    ticket = AlineaTexto(text, 40, true, PrinterName);
                else
                { ticket = text; }
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket);
            }
            public void TextoCentro(string text, bool Justificado)
            {

                string Alineacion = "\x1B" + "a" + "\x1";      //Comando Centrado de texto

                RawPrinterHelper.SendStringToPrinter(text, Alineacion); // ejecuta el comando
                if (Justificado)
                    ticket = AlineaTexto(text, 40, true, PrinterName);
                else
                { ticket = text; }
                if (isAvanzaLinea)
                {
                    ticket += "\n";
                }

                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket);
            }

            public void TextoExtremos(string par1, string par2)
            {
                max = par1.Length;
                if (max > 20)                                 // **********
                {
                    cort = max - 20;
                    parte1 = par1.Remove(20, cort);          // si par1 es mayor que 18 lo corta
                }
                else { parte1 = par1; }                      // **********
                ticket = parte1;                             // agrega el primer parametro
                max = par2.Length;
                if (max > 18)                                 // **********
                {
                    cort = max - 18;
                    parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
                }
                else { parte2 = par2; }
                max = 40 - (parte1.Length + parte2.Length);
                for (int i = 0; i < max; i++)                 // **********
                {
                    ticket += " ";                            // Agrega espacios para poner par2 al final
                }                                             // **********
                ticket += parte2;                     // agrega el segundo parametro al final
                if (isAvanzaLinea)
                { ticket += "\n"; }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime texto
            }
            //public void AgregaTotales(string par1, double total)
            public void AgregaTotales(string par1, string total)
            {
                //DESCRIPCION DEL TOTAL  -  28 DIJITOS-------------------------------------------
                max = par1.Length;
                if (max > 28)
                {
                    cort = max - 28;
                    ticket = par1.Remove(28, cort);
                }
                else
                {
                    parte1 = "";
                    max = 28 - (par1.Length);
                    for (int i = 0; i < max; i++)
                    {
                        parte1 += " ";
                    }
                    ticket = parte1 + par1;
                }
                // VALOR DEL TOTAL ---------------------------9 DIJITOS-------------------------------------
                max = total.Length;
                if (max > 9)
                {
                    cort = max - 9;
                    parte1 = "mas 9 dij";
                }
                else
                {
                    parte1 = "";
                    max = 9 - (total.Length);
                    for (int i = 0; i < max; i++)
                    {
                        parte1 += " ";
                    }
                    parte1 += total;
                }
                ticket += parte1;
                if (isAvanzaLinea) { ticket += "\n"; }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime texto
            }

            public void AgregaArticulo(string iva, string Cant, string Descp, string put, string Total)
            {
                if (Cant.ToString().Length <= 5 && Total.ToString().Length <= 7) // valida que cantidad de 5 y el total de 7  dentro de rango
                {
                    //IVA ------------------------------------------------------------------------------------------------
                    max = iva.ToString().Length;              //total de caracteres
                    if (max > 1)                              //si supera cortamos
                    {
                        cort = max - 1;                        //cuantos estan fuera de rango  
                        parte1 = iva.Remove(1, cort);          //cortamos
                    }
                    else
                    {
                        parte1 = iva;                         //Cargamos en una variable temporal  
                        max = (1 - iva.ToString().Length);    //Vemos cuenatas faltan    
                        for (int i = 0; i < max; i++)          //vueltas  para completar
                        {
                            parte1 += " ";                     //completamos los faltantes con estacios
                        }
                    }
                    ticket = parte1;                          //guadamos
                    //CANTIDAD-----------------------------------------------------------------------------------------
                    max = (5 - Cant.ToString().Length);        //faltantes para 5 caracteres de cantidad 
                    if (max > 5)
                    {
                        cort = max - 1;                        //cuantos estan fuera de rango  
                        parte1 = Cant.Remove(1, cort);          //cortamos
                    }
                    else
                    {
                        parte1 = "";
                        max = 5 - Cant.ToString().Length;
                        for (int i = 0; i < max; i++)              //vueltas  para completar
                        {
                            ticket += " ";                         //completamos los faltantes con estacios
                        }
                    }                                    //CANTIDAD
                    ticket += Cant + " ";                            //cuando cantidad tiene cuatro dijitos completos

                    //DESCRIPCION -------------------------------------------------------------------------------------------------------------------
                    max = Descp.ToString().Length;             //Total caracteres
                    if (max > 19)                              //siesta fuera de rango lo cortamos
                    {
                        cort = max - 19;                        //cuantos estan fuera de rango  
                        parte1 = Descp.Remove(19, cort);         //cortamos (desde, cuanntos)
                    }
                    else
                    {
                        parte1 = "";
                        max = 19 - Descp.ToString().Length;     //espacios faltantes
                        for (int i = 0; i < max; i++)          //vueltas  para completar
                        {
                            Descp += " ";                     //completamos los faltantes con estacios
                        }
                        parte1 += Descp;
                    }
                    ticket += parte1 + " ";                    //GUARDAMOS descripcion mas un espacio
                    //pvp -------------------------------------------------------------------------------------------------------------------
                    max = put.ToString().Length;             //Total caracteres para precio unitario
                    if (max > 5)                               //siesta fuera de rango lo cortamos
                    {
                        cort = max - 5;                        //cuantos estan fuera de rango  
                        parte1 = put.Remove(5, cort);         //cortamos (desde, cuanntos)
                    }
                    else
                    {
                        parte1 = "";
                        max = 5 - put.ToString().Length;     //espacios faltantes
                        for (int i = 0; i < max; i++)          //vueltas  para completar
                        {
                            parte1 += " ";                     //completamos los faltantes con estacios
                        }
                        parte1 += put;
                    }
                    ticket += parte1 + " ";                   //guardamos
                    //Total -------------------------------------------------------------------------------------------------------------------
                    max = Total.ToString().Length;             //Total caracteres
                    if (max > 7)                              //siesta fuera de rango lo cortamos
                    {
                        cort = max - 7;                        //cuantos estan fuera de rango  
                        parte1 = Total.Remove(7, cort);         //cortamos (desde, cuanntos)
                    }
                    else
                    {
                        parte1 = "";
                        max = 7 - (Total.ToString().Length);     //espacios faltantes
                        for (int i = 0; i < max; i++)          //vueltas  para completar
                        {
                            parte1 += " ";                     //completamos los faltantes con estacios
                        }
                        parte1 += Total;
                    }

                    ticket += parte1;                           //carga al tiket

                    if (isAvanzaLinea)
                    {
                         ticket += "\n";
                    }
                     // agrega  linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime articulo
                }
                else
                {
                    ///// MessageBox.Show("Valores fuera de rango");
                    RawPrinterHelper.SendStringToPrinter(PrinterName, "Error, valor fuera de rango\n"); // imprime texto
                }



            }

            public void ImprimeLineaVacia()
            {
                ticket = string.Empty;
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket);
            }
            public void CortaTicket()
            {
                string corte = "\x1B" + "m";                  // caracteres de corte
                string avance = "\x1B" + "d" + "\x07";        // avanza 6 renglones
                RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // avanza
                RawPrinterHelper.SendStringToPrinter(PrinterName, corte); // corta
            }

            public void ModoPagina()
            {
                string modo = "\x1B" + "L";
                string direcc = "\x1B" + "T";
                RawPrinterHelper.SendStringToPrinter(PrinterName, modo); // avanza
                RawPrinterHelper.SendStringToPrinter(PrinterName, direcc); // avanza
            }

            public void AvanzaRollo(int Cuanto)
            {
                for (int i = 0; i < Cuanto; i++)                // **********
                {
                    string avance = "\x1B" + "d" + "\x1";       // avanza 1 linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // avanza
                }
            }
            public void AvanzaLinea(int Cuanto)
            {
                for (int i = 0; i < Cuanto; i++)                // **********
                {
                    string avance = "\x0A";       // avanza 1 linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // avanza
                }
            }

            public void setPrint_Net(string testx)
            {
                RawPrinterHelper.SendStringToPrinter(PrinterName, testx); // Retrocede
            }

            public void AvanzaPagina(int Cuanto)
            {
                for (int i = 0; i < Cuanto; i++)                // **********
                {
                    string avance = "\xFL";        // Retrocede 1 linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
                }
            }
            public void AvanzaEncabezado()
            {
                string avance = "\x1B" + "J" + "\x40";        //avanza 28 lines mínimas
                RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
            }
            public void AvanzaPiePagina()
            {
                string avance = "\x1B" + "J" + "\x14";        //avanza 13 lines mínimas
                RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
            }
            public void Avanza2Lines()
            {
                string avance = "\x1B" + "J" + "\x12";        //avanza 28 lines mínimas
                RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
            }
            public void RetrocedeLinea(int Cuanto)
            {
                for (int i = 0; i < Cuanto; i++)                // **********
                {
                    string avance = "\x1B" + "e" + "\x1";        // Retrocede 1 linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
                }
            }
            public void LongitudPagina(int Cuanto)
            {
                for (int i = 0; i < Cuanto; i++)                // **********
                {
                    string avance = "\x1B" + "C" + "\x10";        // Retrocede 1 linea
                    RawPrinterHelper.SendStringToPrinter(PrinterName, avance); // Retrocede
                }
            }
            public void AbreCajon()
            {
                string cajon0 = "\x1B" + "p" + "\x00" + "\x0F" + "\x96";                  // caracteres de apertura cajon 0
                string cajon1 = "\x1B" + "p" + "\x01" + "\x0F" + "\x96";                 // caracteres de apertura cajon 1
                RawPrinterHelper.SendStringToPrinter(PrinterName, cajon0); // abre cajon0
                RawPrinterHelper.SendStringToPrinter(PrinterName, cajon1); // abre cajon1
            }

            public int ColorPrintCinta(ColorPrint Color)
            {
                if ((System.Convert.ToInt32(Color)) == System.Convert.ToInt32(ColorPrint.Negro))
                {
                    ticket = "\x1B" + "r" + "\x00";
                }
                else if ((System.Convert.ToInt32(Color)) == System.Convert.ToInt32(ColorPrint.Rojo))
                {
                    ticket = "\x1B" + "r" + "\x01";
                }
                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
                return System.Convert.ToInt32(Color);
            }

            public int FontZiseText(FontZise FontZise)
            {
                //Predeterminado por la fabrica
                if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.Default))
                {
                    ticket = "\x1B" + "!" + "\x1";
                }
                else if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.l0cpp))
                {
                    ticket = "\x1B" + "!" + "\x1";
                }
                else if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.l2cpp))
                {
                    ticket = "\x1B" + "!" + "\x0";
                }

                else if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.l4cpp))
                {
                    ticket = "\x1B" + "!" + "\x21";
                }
                else if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.l6cpp))
                {
                    ticket = "\x1B" + "!" + "\x13";
                }
                else if ((System.Convert.ToInt32(FontZise)) == System.Convert.ToInt32(FontZise.l8cpp))
                {
                    // doble ancho[32] + comprimido[4] + 12cpp[1]  = 37
                    ticket = "\x1B" + "!" + "\x37";
                }

                RawPrinterHelper.SendStringToPrinter(PrinterName, ticket); // imprime linea
                fontZise = System.Convert.ToInt32(FontZise);  // carga el ultimo configuracion de tamaño
                return fontZise;
            }

            private static string AlineaTexto(string Texto, int Tamaño, bool Justificar, string NamePrinter)
            {
                string Todo, Linea, Parte, TextoReal;
                int Desde, Hasta, Previo, Posicion, Intro;
                bool Insertar, HayBlancos;

                char[] charsToTrim = { ' ' };
                Todo = Texto.Trim(charsToTrim) + " ";

                // si no biene datos regresamos espacio   
                if (Texto.Length == 0)
                    return "";


            TieneIntros: ;
                TextoReal = "";

                Intro = Todo.IndexOf('/');

                if (Intro >= 0)
                {
                    Parte = LeftRightMid.Left(Todo, Intro - 1);
                    Todo = LeftRightMid.Mid(Todo, Intro + 2, Todo.Length - (Intro + 2));
                    Linea = Parte + "\n" + Todo;
                    RawPrinterHelper.SendStringToPrinter(NamePrinter, Linea); // imprime texto
                    goto TieneIntros;

                }

                Previo = 1;
                do
                {
                    if (Todo.IndexOf(" ", 0) < 0)
                    {
                        TextoReal = TextoReal + Todo + "\n";
                    }
                    Desde = 1;
                MasAun: ;
                    Hasta = Todo.IndexOf(' ', Desde) + 1;

                    if (LeftRightMid.Left(Todo, Hasta).Length < Tamaño)
                    {
                        Previo = Hasta;       //'El último corte que encaja en el ancho
                        Desde = Hasta + 1;
                        if (Hasta < Todo.Length)
                        {
                            goto MasAun;
                        }
                    }

                    char[] espacio = { ' ' };
                    Linea = (LeftRightMid.Left(Todo, Previo - 1).Trim(espacio));
                    Todo = LeftRightMid.Mid(Todo, Previo, Todo.Length - (Previo));

                    //si no quiere justicicar saltamo
                    if (Justificar == false)
                        goto ExitWile;
                Ajustar: ;

                    Posicion = 1;
                    if (Linea.IndexOf(' ') >= 0)
                        HayBlancos = true;
                    else
                        HayBlancos = false;

                    Insertar = false;

                    do
                    {
                        string buscar = LeftRightMid.Mid(Linea, Posicion - 1, 1);
                        if (buscar.IndexOf(" ", 0) < 0)
                            Insertar = true;
                        else
                        {

                            if (Insertar == true)
                            {
                                Linea = LeftRightMid.Left(Linea, Posicion) + " " + LeftRightMid.Mid(Linea, Posicion, (Linea.Length - Posicion));
                                Insertar = false;
                            }
                        }
                        Posicion = Posicion + 1;
                    } while (!((HayBlancos == false) || (Linea.Length >= Tamaño) || (Posicion == Linea.Length)));

                    if (Linea.Length < Tamaño && HayBlancos && Todo.Length > 0)
                    {
                        goto Ajustar;
                    }
                ExitWile: ;
                    Linea += "\n";
                    RawPrinterHelper.SendStringToPrinter(NamePrinter, Linea); // imprime texto
                } while (Todo.IndexOf(" ", 0) >= 0);
                return TextoReal;
            }

        }

        #endregion

        // ESTA CLASE ES PARA PODER IMPRIMIR EL TEXTO PLANO
        #region Clase para enviar a imprsora texto plano



        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "DOCINFOA.pDataType"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "DOCINFOA.pOutputFile"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "DOCINFOA.pDocName"), DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1060:MovePInvokesToNativeMethodsClass"), DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Es para devover si se imprime asume como falso

                di.pDocName = "My C#.NET RAW Document";
                di.pDataType = "RAW";

                //si posee nomobre de impresora
                if (szPrinterName.ToString().Length > 0)
                {
                    // abre la impresona.
                    if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                    {
                        // Start a document.
                        if (StartDocPrinter(hPrinter, 1, di))
                        {
                            // Start a page.
                            if (StartPagePrinter(hPrinter))
                            {
                                // Write your bytes.
                                bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                                EndPagePrinter(hPrinter);
                            }
                            EndDocPrinter(hPrinter);
                        }
                        ClosePrinter(hPrinter);
                    }
                }

                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
        #endregion
    }
}

