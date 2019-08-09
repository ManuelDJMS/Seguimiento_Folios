Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Dim CustimerId As Integer
    Dim cotizacion As Integer
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'consultaGeneralDeCotizaciones(DGRes)
        MetodoMetasInf()
        comandoMetasInf = conexionMetasInf.CreateCommand
        Dim r As String
        r = "select x1.Folio, Cliente, Cve_operador, Pendientes, Fac_Adelantado, CA, Combinado_con, Operador_ext, Cierre_folio, Credito, x1.Observaciones, Equipo, Dias, [Fecha-entrega], FechaVenc, Con_cot, Num_cot, Mensajeria_recep, Obser_retencion,
            FMC, FEF, datos_informes, OC, OC_necesaria, fac_oc, Num_orde_de_compra, Status_folio  from [MetasCotizador].[dbo].[Segumiento_folios] x1 inner join [METASINF-2019-3].[dbo].[Entrega-Equipos-Logistica] x2 on x1.Folio=x2.Folio"
        comandoMetasInf.CommandText = r
        lectorMetasInf = comandoMetasInf.ExecuteReader
        While lectorMetasInf.Read
            DGRes.Rows.Add(lectorMetasInf(0), lectorMetasInf(1), lectorMetasInf(2), lectorMetasInf(3), lectorMetasInf(4), lectorMetasInf(5), lectorMetasInf(6), lectorMetasInf(7), lectorMetasInf(8), lectorMetasInf(9), lectorMetasInf(10), lectorMetasInf(11), lectorMetasInf(12), lectorMetasInf(13), lectorMetasInf(14), lectorMetasInf(15), lectorMetasInf(16), lectorMetasInf(17), lectorMetasInf(18), lectorMetasInf(19), lectorMetasInf(20), lectorMetasInf(21), lectorMetasInf(22), lectorMetasInf(23), lectorMetasInf(24), lectorMetasInf(25), lectorMetasInf(26))
        End While
        alternarColorColumnas(DGRes)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

    Sub consultaContactos(ByVal CustomerId As Integer)
        'Try
        '    MetodoLIMS()
        '    Dim R As String = "select isnull(CustAccountNo,'-'), isnull(FirstName,'-'), isnull(MiddleName,'-'), isnull(LastName,'-'),
        '                        isnull(Phone,'-'), isnull(Mobile,'-'), isnull(Email,'-'), isnull(CompanyName,'-'), isnull(KeyFiscal,'-') 
        '                        from [SetupCustomerDetails] where [SetupCustomerDetails].[CustomerId]=" & CustomerId & ""
        '    Dim comando As New SqlCommand(R, conexionLIMS)
        '    Dim lector As SqlDataReader
        '    lector = comando.ExecuteReader
        '    lector.Read()
        '    txtNumeroDeCuenta.Text = lector(0)
        '    'txtNombreDeContacto.Text = lector(1) & " " & lector(2) & " " & lector(3)
        '    txtTelefono.Text = lector(4)
        '    txtCelular.Text = lector(5)
        '    txtCorreo1.Text = lector(6)
        '    txtNombreCompania.Text = lector(7)
        '    txtKeyFiscal.Text = lector(8)
        '    lector.Close()
        '    conexionLIMS.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmAutorizarSolicitudes", "Error en Consulta Contactos", Err.Number, cadena)
        'End Try
    End Sub

    Sub consultaCot(ByVal numCot As Integer)
        'Try
        '    MetodoMetasCotizador()
        '    Dim R As String
        '    R = "select isnull(Referencia,'-'), isnull(Observaciones,'-'), isnull(FechaDesde,'-'), isnull(FechaHasta,'-'),
        '        isnull(Subtotal,'-'), isnull(IVA,'-'), isnull(Total,'-') from Cotizaciones where Cotizaciones.NumCot=" & numCot & ""
        '    Dim comando As New SqlCommand(R, conexionMetasCotizador)
        '    Dim lector As SqlDataReader
        '    lector = comando.ExecuteReader
        '    lector.Read()
        '    txtReferencia.Text = lector(0)
        '    txtObservaciones.Text = lector(1)
        '    txtFechaDesde.Text = lector(2)
        '    txtFechaHasta.Text = lector(3)
        '    txtSubtotal.Text = lector(4)
        '    txtIVA.Text = lector(5)
        '    txtTotal.Text = lector(6)
        '    lector.Close()
        '    R = "select NumCot, ItemNumber, RelationItemNo, EquipmentName, Mfr, Model, SrlNo, Accuracy, Price, CantidadReal from DetalleCotizaciones
        '     inner join" & servidor & "[SetupEquipment] Equipos on DetalleCotizaciones.EquipId=Equipos.EquipId
        '     inner join" & servidor & "[SetupEquipmentServiceMapping] Precio on Equipos.EquipId=Precio.EquipId where NumCot=" & numCot
        '    comando.CommandText = R
        '    lector = comando.ExecuteReader
        '    While lector.Read
        '        dgCot.Rows.Add(lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))
        '    End While
        '    lector.Close()
        '    conexionMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmAutorizarSolicitudes", "Error al cargar la consulta de la cotización", Err.Number, cadena)
        'End Try
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged
    '    Try
    '        For Each row As DataGridViewRow In DGRes.Rows
    '            row.Selected = False
    '            If CStr(row.Cells(1).Value) = txtFolio.Text Then
    '                row.Selected = True
    '                Exit For
    '            ElseIf CStr(row.Cells(0).Value).ToLower = Nothing Then
    '                row.Selected = False
    '            Else
    '                row.Selected = False
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox("No se encuentra dicho número de cotización.", MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    'Private Sub BtSinCot_Click(sender As Object, e As EventArgs) Handles btSinCot.Click
    '    FrmFiltrar.Show()
    'End Sub

    'Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
    '    busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    'End Sub

    'Private Sub TextDom_TextChanged(sender As Object, e As EventArgs) Handles TextDom.TextChanged
    '    busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    'End Sub

    'Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
    '    busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    'End Sub

    'Private Sub TxtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
    '    busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    'End Sub

    'Private Sub TextTel_TextChanged(sender As Object, e As EventArgs) Handles TextTel.TextChanged
    '    busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    'End Sub

    'Private Sub DGRes_RowHeaderMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRes.RowHeaderMouseClick
    '    Try
    '        Dim numCot As String
    '        numCot = DGRes.Rows(e.RowIndex).Cells(1).Value.ToString()
    '        CustimerId = DGRes.Rows(e.RowIndex).Cells(12).Value.ToString()
    '        txtClaveRecopilada.Text = numCot
    '        consultaContactos(CustimerId)
    '        consultaCot(numCot)
    '        TabConsulta.SelectTab(1)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
    '        cadena = Err.Description
    '        cadena = cadena.Replace("'", "")
    '        Bitacora("FrmAutorizarSolicitudes", "Error al seleccionar una cotización", Err.Number, cadena)
    '    End Try
    'End Sub

    Private Sub RbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RbTodos.CheckedChanged
        For i = 1 To DGRes.Columns.Count
            DGRes.Columns("Column" & Convert.ToString(i)).Visible = True
        Next
    End Sub

    Private Sub DgDatosG_CheckedChanged(sender As Object, e As EventArgs) Handles dgDatosG.CheckedChanged
        Dim arreglo() = {1, 2, 4, 5, 9, 10, 11, 15, 16, 22, 24, 25, 26}
        Dim l As Integer
        l = Convert.ToInt32(UBound(arreglo))
        For i = 1 To DGRes.Columns.Count
            For j = 0 To l
                If i = arreglo(j) Then
                    DGRes.Columns("Column" & Convert.ToString(i)).Visible = True
                    j = 14
                Else
                    DGRes.Columns("Column" & Convert.ToString(i)).Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub RbTecnicos_CheckedChanged(sender As Object, e As EventArgs) Handles RbTecnicos.CheckedChanged
        Dim arreglo() = {1, 2, 10, 11, 12, 13, 14, 19, 20}
        Dim l As Integer
        l = Convert.ToInt32(UBound(arreglo))
        For i = 1 To DGRes.Columns.Count
            For j = 0 To l
                If i = arreglo(j) Then
                    DGRes.Columns("Column" & Convert.ToString(i)).Visible = True
                    j = 10
                Else
                    DGRes.Columns("Column" & Convert.ToString(i)).Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub TxtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged
        busquedas(DGRes, txtFolio, txtNombreE, txtNumCot)
    End Sub
End Class