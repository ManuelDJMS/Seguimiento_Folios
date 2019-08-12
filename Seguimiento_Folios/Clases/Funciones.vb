Imports System.Data.SqlClient
Module Funciones
    Public R As String 'Variable que almacena todos los scripts de base de datos
    Public cadena As String 'VARIABLE PARA ALMACENAR LA CADENA DEL ERROR DE LA BITACORA
    Public bandera As Boolean
    Public folio As Integer
    Public cveOperador As Integer

    Public Sub Bitacora(Formulario As String, Evento As String, error1 As String, Descripcion As String)
        Try
            Dim conexionbit As New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=Bitacora; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionbit.Open()
            Dim comando As SqlCommand = conexionbit.CreateCommand()
            Dim r As String
            Dim I As Integer
            Dim x As String
            x = "'"
            For I = 1 To Len(error1)
                If Mid(error1, I, 1) = Chr(39) Then
                    x = x & "'"
                Else
                    x = x & Mid(error1, I, 1)
                End If
            Next
            error1 = x
            r = "insert into Resultados(Formulario, Evento, Error, Descripcion, Fecha) values ('" & Formulario & "','" & Evento & "'," & error1 & "','" & Descripcion & "', getdate())"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            conexionbit.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al buscar cot", Err.Number, cadena)
        End Try
    End Sub
    Public Sub colorearpanel(ByVal formulario As Panel, ByVal panelwhite As Panel)
        Dim Text As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is Panel Then
                Dim txtTemp As Panel = CType(Text, Panel)
                txtTemp.BackColor = Color.White
                panelwhite.BackColor = Color.MediumSeaGreen
                'PanelSesion.BackColor = Color.FromArgb(42, 50, 80)
            End If
        Next
    End Sub
    Public Sub busquedas(ByVal dg As DataGridView, ByVal folio As TextBox, ByVal empresa As TextBox, ByVal cot As TextBox, ByVal pendientes As ComboBox, ByVal noc As TextBox, ByVal user As String)
        Try
            dg.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String = "select x1.Folio, Cliente, Cve_operador, Pendientes, Fac_Adelantado, CA, Combinado_con, Operador_ext, Cierre_folio, Credito, x1.Observaciones, Equipo, Dias, [Fecha-recep], FechaVenc, 
            Con_cot, Num_cot, Mensajeria_recep, Obser_retencion, FMC, FEF, datos_informes, OC, OC_necesaria, fac_oc, Num_orde_de_compra, Status_folio  from [MetasCotizador].[dbo].[Segumiento_folios] x1 inner join 
            [METASINF-2019-3].[dbo].[Recepcion-Equipos-Logistica] x2 on x1.Folio=x2.Folio where x1.Folio like '" & folio.Text & "%' and Cliente like '" & empresa.Text & "%' and Num_Cot like '" & cot.Text & "%' and Pendientes like '" & pendientes.Text & "%' and Num_orde_de_compra like '" & noc.Text & "%' and Cve_operador=17" '& user
            MsgBox(R)
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12), lector(13), lector(14), lector(15), lector(16), lector(17), lector(18), lector(19), lector(20), lector(21), lector(22), lector(23), lector(24), lector(25), lector(26))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            'cadena = Err.Description
            'cadena = cadena.Replace("'", "")
            'Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
End Module
