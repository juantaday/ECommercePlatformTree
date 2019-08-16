Module variables
#Region "File Reports"

    Private file As String = Application.StartupPath
    'Private file As String = "F:\Users\juant\Source\Repos\ECommercePlatformTree\ECommercePlatformView"

    Public file_rptInventoriesUpdate As String = String.Format("{0}\Reports\rptInventoriesUpdate.rpt", file)
    Public file_rptFacturaBacha As String = String.Format("{0}\Reports\rptFacturaBacha.rpt", file)
    Public file_rptNotaVentaBacha As String = String.Format("{0}\Reports\rptNotaVentaBacha.rpt", file)
    Public file_rptProformaBacha As String = String.Format("{0}\Reports\rptProformaBacha.rpt", file)
    Public file_rptCobroCliente As String = String.Format("{0}\Reports\rptCobroCliente.rpt", file)
    Public file_rptCloseTerminal As String = String.Format("{0}\Reports\rptCloseTerminal.rpt", file)
    Public file_rptSaldoDivisas As String = String.Format("{0}\Reports\rptSaldoDivisas.rpt", file)
    Public file_rptViewSalesByDate As String = String.Format("{0}\Reports\rptViewSalesByDate.rpt", file)
    'sub reports
    Public file_rptSubSaldoXTipo As String = String.Format("{0}\Reports\rptSubSaldoXTipo.rpt", file)
    Public file_rptSubSaldoXLocalidad As String = String.Format("{0}\Reports\rptSubSaldoXLocalidad.rpt", file)

#End Region


    Public ListVendiblescollection As List(Of PresentVendiblescollection)
    Public ListOfertas As List(Of Ofertas)

    Public buscar_expediente, buscar, sql As String
    Public id As Integer
    Public processBackGround As Boolean
    Public msgSelect_list As String = "Seleccione uno de la lista desplegable"
    Public msgRespond As String = "Responda"
    Public msgSave As String = "Está seguro de guardar los cambios..?"
    Public msgFalta As String = "Falta de ingresar información"
    Public msgExsito As String = "Operación Exitosa.."
    Public msgDelete As String = "Está seguro de eliminar..."
    Public MenuActivo As String
    Public clm As New System.Windows.Forms.DataGridViewColumn()
    Public myStileMoney As New System.Windows.Forms.DataGridViewCellStyle _
                   With {.NullValue = 0, .Format = "C2", .Alignment = DataGridViewContentAlignment.MiddleRight}
    Public myStileMoneyWith4 As New System.Windows.Forms.DataGridViewCellStyle _
                   With {.NullValue = 0, .Format = "C2", .Alignment = DataGridViewContentAlignment.MiddleRight}
    Public myStileNumber As New System.Windows.Forms.DataGridViewCellStyle _
       With {.NullValue = 0, .Format = "N0", .Alignment = DataGridViewContentAlignment.MiddleRight}

    Public myStileDecimal As New System.Windows.Forms.DataGridViewCellStyle _
       With {.NullValue = 0, .Format = "N2", .Alignment = DataGridViewContentAlignment.MiddleRight}
    Public myStilePercentage As New System.Windows.Forms.DataGridViewCellStyle _
     With {.NullValue = 0, .Format = "P2", .Alignment = DataGridViewContentAlignment.MiddleRight}

End Module
