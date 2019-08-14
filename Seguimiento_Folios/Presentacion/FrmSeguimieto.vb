﻿Imports System.Data.SqlClient
Public Class FrmSeguimieto
    Dim equipo, CA, facAd, CONC, UOC, OCN, FACOC, pendientes As String
    Dim numCot As Integer
    Dim dias, OC As Integer
    Dim lector As SqlDataReader
    Private Sub FrmSeguimieto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasInf()
            R = "select DISTINCT REL.[Folio], [Descripcion], INF.[Empresa], INF.[Usuario],CCU.Email,[Tel],isnull([Credito],'-'), [Fecha-recep],
             REL.[Mensajeria], isnull([TIPO],'-'),[DatosdelInforme], isnull([NumCot], '') as NumCot, [Status], [CveOperador], [Orden de compra],[Peso kg] FROM [Recepcion-Equipos-Logistica] REL  
            INNER JOIN [INFORMES-SERVICIOS] INF  ON REL.[Folio] = INF.[Folio]
            INNER JOIN [Contactos-Clientes-Usuarios] CCU on INF.[ClavecontactoConsign] = CCU.[Clavempresa]
            INNER JOIN [MetAsInf] ON [MetAsInf].[Clavempresa] = CCU.[Clavempresa] where INF.[Folio] = " & folio & ""
            Dim comando As New SqlCommand(R, conexionMetasInf)

            lector = comando.ExecuteReader
            'MsgBox(R)
            lector.Read()
            'MsgBox(lector(1))
            lblNumFolio.Text = lector(0)
            txtNombreCompania.Text = lector(2)
            txtNombreCliente.Text = lector(3)
            txtCorreo.Text = lector(4)
            txtTelefono.Text = lector(5)
            txtTelefono.Text = lector(5)
            txtCredito.Text = lector(6)
            numCot = lector(11)
            If numCot.ToString = "" Or numCot.ToString = " " Then
                txtNumCot.Enabled = False
            Else
                txtNumCot.Text = numCot
                rbSiCot.Checked = True
                rbNoCot.Checked = False
            End If
            txtCombinadoCon.Text = lector(1)
            txtDatosInforme.Text = lector(10)
            dtpFechaRecepcion.Value = lector(7)
            txtMenRecep.Text = lector(8)
            txtPeso.Text = lector(15)
            If lector(14) = "1" Then
                rbSIOC.Checked = True
                rbNOOC.Checked = False
            End If
            While lector.Read()
                equipo = equipo + ", " + lector(9)
            End While
            txtEquipo.Text = equipo
            lector.Close()

            'MetodoMetasInf()
            'comando = conexionMetasInf.CreateCommand
            'comando.CommandText = "SELECT [cveOper],[Nombre] FROM [ListaOperadores] where Depto <> 'Almacén & Envíos' "
            'lector = comando.ExecuteReader
            'While lector.Read()
            '    cboOperadores.Items.Add(lector(1))
            '    cboOperadores2.Items.Add(lector(1))
            '    cboCierra.Items.Add(lector(1))
            'End While
            'lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmSeguimiento", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub
    Private Sub txtDias_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged
        dias = Val(txtDias.Text)
        DiasHab()
        dtpFechaVencimiento.Value = dtpFechaRecepcion.Value.AddDays(dias)
    End Sub
    Sub DiasHab()
        Dim Ini As DateTime = dtpFechaRecepcion.Value
        Dim Fin As Date = dtpFechaRecepcion.Value.AddDays(40)
        Dim listaDiasFestivos As List(Of DateTime) = ListDiasFectivos()
        While Ini <> Fin
            If (Ini.DayOfWeek = DayOfWeek.Saturday Or Ini.DayOfWeek = DayOfWeek.Sunday) Then
                dias = dias + 1
            End If
            If listaDiasFestivos.Contains(Ini) Then
                dias = dias + 1
            End If
            Ini = Ini.AddDays(1)
        End While
    End Sub


    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        If rbCompleto.Checked = True Then
            pendientes = "COMPLETO"
        ElseIf rbOc.Checked = True Then
            pendientes = "Orden de compra"
        ElseIf rbOcyMensajeria.Checked = True Then
            pendientes = "Orden de O.C. Y Mensajeria"
        ElseIf rbMensajeria.Checked = True Then
            pendientes = "Solo mensajeria"
        End If
        If RbSi.Checked = True Then
            facAd = "SI"
        Else
            facAd = "NO"
        End If
        If RbSICA.Checked = True Then
            CA = "SI"
        Else
            CA = "NO"
        End If
        If rbSiCot.Checked = True Then
            CONC = "SI"
        Else
            CONC = "NO"
        End If
        If rbSIOC.Checked = True Then
            UOC = "SI"
        Else
            UOC = "NO"
        End If
        If rbSIOC.Checked = True Then
            UOC = "SI"
        Else
            UOC = "NO"
        End If
        If rbSIOCN.Checked = True Then
            OCN = "SI"
        Else
            OCN = "NO"
        End If
        If rbSIOCFAC.Checked = True Then
            FACOC = "SI"
        Else
            FACOC = "NO"
        End If
        If cboOperadores2.Text = "" Then
            cboOperadores2.Text = " "
        End If
        MetodoMetasCotizador()
        Try
            'Dim fechaVen, FEC, FEF As Date
            Dim fechaVen As Date
            fechaVen = Convert.ToDateTime(dtpFechaVencimiento.Text).ToShortDateString
            'FEC = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
            'FEF = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
            Dim operadores As String = cboOperadores.Text + cboOperadores2.Text
            'MsgBox(operadores)
            R = "insert into [MetasCotizador].[dbo].[Segumiento_folios] ([Folio],[Cve_operador],[Pendientes],[Fac_Adelantado],[CA],[Combinado_con],[Operador_ext],[Cierre_folio],[Credito],[Observaciones],[Equipo],[Dias],[FechaVenc],[Con_cot],[Num_cot],[Mensajeria_recep],[Obser_retencion],[FMC],[FEF],[datos_informes],[OC],[OC_necesaria],[fac_oc],[Num_orde_de_compra],[Status_folio],[Domicilio_entrega],[Mensajeria_retorno],[obser_tecnicas])
        values(" & Val(lblNumFolio.Text) & "," & Val(cveOperador) & ",'" & (pendientes) & "', '" & facAd & "','" & CA & "','" & txtCombinadoCon.Text & "', '" & operadores & "','" & cboCierra.Text & "', '" & txtCredito.Text & "', '" & txtObserPendientes.Text & "','" & txtEquipo.Text & "'," & Val(txtDias.Text) & ", '" & fechaVen & "', '" & CONC & "',  " & Val(txtNumCot.Text) & ", '" & txtMenRecep.Text & "','" & txtObserRetencion.Text & "','0000-00-00 ','0000-00-00', '" & txtDatosInforme.Text & "','" & UOC & "','" & OCN & "','" & FACOC & "','" & txtNumComp.Text & "', '" & cboStatus.Text & "', '" & txtDomEntrega.Text & "','" & txtMenEnv.Text & "', '" & txtObserTec.Text & "')"
            Dim comando2 As New SqlCommand(R, conexionMetasCotizador)
            comando2.CommandText = R
            comando2.ExecuteNonQuery()
            MsgBox("FOLIO NUM: " & folio & ".  ACTUALIZADO")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmSeguimiento", "Error al grabar", Err.Number, cadena)
        End Try
    End Sub
End Class