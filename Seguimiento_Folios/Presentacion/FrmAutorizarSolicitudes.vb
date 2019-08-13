Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Dim CustimerId As Integer
    Dim cotizacion As Integer
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'consultaGeneralDeCotizaciones(DGRes)
        MetodoMetasInf()
        comandoMetasInf = conexionMetasInf.CreateCommand
        Dim r As String
        r = "select distinct x1.Folio, Cliente, Cve_operador, Pendientes, Fac_Adelantado, CA, Combinado_con, Operador_ext, Cierre_folio, Credito, x1.Observaciones, Equipo, Dias, [Fecha-recep], FechaVenc, Con_cot, Num_cot, Mensajeria_recep, Mensajeria_retorno, Domicilio_entrega, Obser_retencion, obser_tecnicas,
            FMC, FEF, datos_informes, OC, OC_necesaria, fac_oc, Num_orde_de_compra, Status_folio  from [MetasCotizador].[dbo].[Segumiento_folios] x1 inner join [METASINF-2019-3].[dbo].[Recepcion-Equipos-Logistica] x2 on x1.Folio=x2.Folio where Cve_operador=" & cveOperador
        comandoMetasInf.CommandText = r
        lectorMetasInf = comandoMetasInf.ExecuteReader
        While lectorMetasInf.Read
            DGRes.Rows.Add(lectorMetasInf(0), lectorMetasInf(1), lectorMetasInf(2), lectorMetasInf(3), lectorMetasInf(4), lectorMetasInf(5), lectorMetasInf(6), lectorMetasInf(7), lectorMetasInf(8), lectorMetasInf(9), lectorMetasInf(10), lectorMetasInf(11), lectorMetasInf(12), lectorMetasInf(13), lectorMetasInf(14), lectorMetasInf(15), lectorMetasInf(16), lectorMetasInf(17), lectorMetasInf(18), lectorMetasInf(19), lectorMetasInf(20), lectorMetasInf(21), lectorMetasInf(22), lectorMetasInf(23), lectorMetasInf(24), lectorMetasInf(25), lectorMetasInf(26), lectorMetasInf(27), lectorMetasInf(28), lectorMetasInf(29))
        End While
        alternarColorColumnas(DGRes)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Dispose()
    End Sub

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
        busquedas(DGRes, txtFolio, txtNombreE, txtNumCot, cbPendientes, txtNumCompra, cveOperador)
    End Sub

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        busquedas(DGRes, txtFolio, txtNombreE, txtNumCot, cbPendientes, txtNumCompra, cveOperador)
    End Sub

    Private Sub TxtNumCot_TextChanged(sender As Object, e As EventArgs) Handles txtNumCot.TextChanged
        busquedas(DGRes, txtFolio, txtNombreE, txtNumCot, cbPendientes, txtNumCompra, cveOperador)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPendientes.SelectedIndexChanged
        Try
            DGRes.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String = "select x1.Folio, Cliente, Cve_operador, Pendientes, Fac_Adelantado, CA, Combinado_con, Operador_ext, Cierre_folio, Credito, x1.Observaciones, Equipo, Dias, [Fecha-recep], FechaVenc, 
            Con_cot, Num_cot, Mensajeria_recep, Obser_retencion, FMC, FEF, datos_informes, OC, OC_necesaria, fac_oc, Num_orde_de_compra, Status_folio  from [MetasCotizador].[dbo].[Segumiento_folios] x1 inner join 
            [METASINF-2019-3].[dbo].[Recepcion-Equipos-Logistica] x2 on x1.Folio=x2.Folio where x1.Folio like '" & txtFolio.Text & "%' and Cliente like '" & txtNombreE.Text & "%'
            and Num_Cot like '" & txtNumCot.Text & "%' and Pendientes like '" & cbPendientes.Text & "%' and Num_orde_de_compra like'" & txtNumCompra.Text & "%' and Cve_operador= " & cveOperador
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12), lector(13), lector(14), lector(15), lector(16), lector(17), lector(18), lector(19), lector(20), lector(21), lector(22), lector(23), lector(24), lector(25), lector(26))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes del sistema folios", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Try
        Using conexion As New SqlConnection(cotizador)
            conexion.Open()
            Dim r As String
            Dim transaction As SqlTransaction
            transaction = conexion.BeginTransaction("Sample")
            Dim comando As SqlCommand = conexion.CreateCommand()
            comando.Connection = conexion
            comando.Transaction = transaction
            For i = 0 To DGRes.Rows.Count - 2
                r = "update [MetasCotizador].[dbo].[Segumiento_folios] set Pendientes='" & (DGRes.Item(3, i).Value).Replace("'", "") & "',Fac_Adelantado='" & (DGRes.Item(4, i).Value).Replace("'", "") & "',
                CA='" & (DGRes.Item(5, i).Value) & "', Combinado_con='" & (DGRes.Item(6, i).Value) & "',Operador_ext='" & (DGRes.Item(7, i).Value) & "',
                Cierre_folio='" & (DGRes.Item(8, i).Value) & "',Credito='" & DGRes.Item(9, i).Value & "',Observaciones='" & (DGRes.Item(10, i).Value) & "',
                Equipo='" & (DGRes.Item(11, i).Value) & "',Dias=" & Val(DGRes.Item(12, i).Value) & ",FechaVenc='" & (DGRes.Item(13, i).Value) & "',
                Con_cot='" & (DGRes.Item(15, i).Value) & "',Num_cot=" & Val(DGRes.Item(16, i).Value) & ",Mensajeria_recep='" & (DGRes.Item(17, i).Value) & "',
                Mensajeria_retorno='" & (DGRes.Item(18, i).Value) & "', Domicilio_entrega='" & (DGRes.Item(19, i).Value) & "',
                Obser_retencion='" & (DGRes.Item(20, i).Value) & "', obser_tecnicas='" & (DGRes.Item(21, i).Value) & "',FMC='" & (DGRes.Item(22, i).Value) & "',FEF='" & (DGRes.Item(23, i).Value) & "',
                datos_informes='" & (DGRes.Item(24, i).Value) & "',OC='" & (DGRes.Item(25, i).Value) & "',OC_necesaria='" & (DGRes.Item(26, i).Value) & "',
                fac_oc='" & (DGRes.Item(27, i).Value) & "',Num_orde_de_compra='" & (DGRes.Item(28, i).Value) & "',
                Status_folio='" & (DGRes.Item(29, i).Value) & "' where Folio='" & DGRes.Item(0, i).Value & "' and Cve_Operador= " & cveOperador
                comando.CommandText = r
                comando.ExecuteNonQuery()


            Next

            Try
                If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    transaction.Commit()
                    MsgBox("El Catálogo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                Else
                    transaction.Rollback()
                    Me.Dispose()
                End If
            Catch ex As Exception
                MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                Try
                    transaction.Rollback()
                Catch ex1 As Exception
                    MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                End Try
            End Try
            conexion.Close()
        End Using

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
    End Sub

    Private Sub TxtNumCompra_TextChanged(sender As Object, e As EventArgs) Handles txtNumCompra.TextChanged
        busquedas(DGRes, txtFolio, txtNombreE, txtNumCot, cbPendientes, txtNumCompra, cveOperador)
    End Sub
End Class