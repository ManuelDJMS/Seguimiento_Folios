Imports System.Data.SqlClient
Public Class FrmSeguimieto
    Dim equipo, CA, facAd, CONC, UOC, OCN, FACOC, pendientes As String
    Dim numCot As Integer
    Dim dias, OC As Integer
    Dim lector As SqlDataReader
    Private Sub FrmSeguimieto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetodoMetasInf()
            comandoMetasInf = conexionMetasInf.CreateCommand
            If idseguimiento = 0 Then
                R = "select DISTINCT REL.[Folio], isnull([Descripcion],'-'), INF.[Empresa],[Usuario],isnull(CCU.Email,'-'),isnull([Tel],'-'),isnull([Credito],'-'), [Fecha-recep],
             REL.[Mensajeria], isnull([TIPO],'-'),isnull([DatosdelInforme],'-'), isnull([NumCot], '') as NumCot, isnull([Status],'-'), [CveOperador], [Orden de compra],isnull([Peso kg],'-') 
			 FROM [Recepcion-Equipos-Logistica] REL  
            INNER JOIN [INFORMES-SERVICIOS] INF  ON REL.[Folio] = INF.[Folio]
            INNER JOIN [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] CCU on INF.[ClavecontactoConsign] = CCU.[Clavempresa]
            INNER JOIN [InformacionGeneral].[dbo].[MetAsInf] ON [MetAsInf].[Clavempresa] = CCU.[Clavempresa] where INF.[Folio] = " & folio & ""
                comandoMetasInf.CommandText = R
                lector = comandoMetasInf.ExecuteReader
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
                equipo = lector(9)
                While lector.Read()
                    equipo = equipo + ", " + lector(9)
                End While
                txtEquipo.Text = equipo
                lector.Close()

            Else
                R = "
			select DISTINCT x.idSeguimiento, x.Folio, x.Credito, Fac_Adelantado, CA, Status_folio, Pendientes, x.Observaciones, x.obser_tecnicas, Equipo, con_cot, Num_Cot, [Peso kg], Combinado_con, Operador_ext,
			Cierre_folio, Dias, FechaVenc, datos_informes, FMC, OC, Num_orde_de_compra, OC_Necesaria, fac_oc, FEF, [Fecha-recep], Mensajeria_recep, Mensajeria_retorno, Obser_retencion, Domicilio_entrega, 
			INF.[Empresa],[Usuario],isnull([Tel],'-') from [MetasCotizador].[dbo].[Segumiento_folios] x INNER JOIN [Recepcion-Equipos-Logistica] REL on x.Folio=REL.Folio inner join  
			 [INFORMES-SERVICIOS] INF  ON x.[Folio] = INF.[Folio] INNER JOIN [InformacionGeneral].[dbo].[Contactos-Clientes-Usuarios] CCU on INF.[ClavecontactoConsign] = CCU.[Clavempresa]
            INNER JOIN [InformacionGeneral].[dbo].[MetAsInf] ON [MetAsInf].[Clavempresa] = CCU.[Clavempresa]  where INF.[Folio] = " & folio & " and idSeguimiento=" & idseguimiento
                comandoMetasInf.CommandText = R
                lector = comandoMetasInf.ExecuteReader
                'lector = comandoMetasInf.ExecuteReader
                'MsgBox(R)
                lector.Read()
                lblNumFolio.Text = lector(1)
                txtCredito.Text = lector(2)
                If lector(3) = "SI" Then
                    RbSi.Checked = True
                    rbNo.Checked = False
                End If
                If lector(4) = "SI" Then
                    RbSICA.Checked = True
                    RbNOCA.Checked = False
                End If
                cboStatus.Text = lector(5)
                pendientes = lector(6)
                If pendientes = "COMPLETO" Then
                    rbCompleto.Checked = True
                ElseIf pendientes = "Orden de compra" Then
                    rbOc.Checked = True
                ElseIf pendientes = "Orden de O.C. Y Mensajeria" Then
                    rbOcyMensajeria.Checked = True
                ElseIf pendientes = "Solo mensajeria" Then
                    rbMensajeria.Checked = True
                End If
                txtObserPendientes.Text = lector(7)
                txtObserTec.Text = lector(8)
                txtEquipo.Text = lector(9)
                If lector(10) = "SI" Then
                    rbSiCot.Checked = True
                    rbNoCot.Checked = False
                End If
                txtNumCot.Text = lector(11)
                txtPeso.Text = lector(12)
                cboOperadores.Visible = False
                cboOperadores2.Visible = False
                TextOperador.Visible = True
                txtCombinadoCon.Text = lector(13)
                TextOperador.Text = lector(14)
                cboCierra.Text = lector(15)
                txtDias.Text = lector(16)
                dtpFechaVencimiento.Value = lector(17)
                txtDatosInforme.Text = lector(18)
                Label2.Visible = True
                'dtpfechaCertificado.Visible = True
                If lector(19) = "0000-00-00" Then
                    dtpfechaCertificado.Visible = False
                    txtFMC.Visible = True
                    txtFMC.Text = lector(19)
                Else
                    dtpfechaCertificado.Value = lector(19)
                    dtpfechaCertificado.Visible = True
                End If
                'dtpfechaCertificado.Value = lector(19)
                If lector(20) = "SI" Then
                    rbSIOC.Checked = True
                    rbNOOC.Checked = False
                End If
                txtNumComp.Text = lector(21)
                If lector(22) = "SI" Then
                    rbSIOCN.Checked = True
                    rbNOOCN.Checked = False
                End If
                If lector(23) = "SI" Then
                    rbSIOCFAC.Checked = True
                    rbNOOCFAC.Checked = False
                End If
                Label17.Visible = True
                'dtpFechaFacturación.Visible = True
                If lector(24) = "0000-00-00" Then
                    dtpFechaFacturación.Visible = False
                    textFEF.Visible = True
                    textFEF.Text = lector(24)
                Else
                    dtpFechaFacturación.Value = lector(24)
                    dtpFechaFacturación.Visible = True
                End If
                'dtpFechaFacturación.Value = lector(24)
                dtpFechaRecepcion.Value = lector(25)
                txtMenRecep.Text = lector(26)
                txtMenEnv.Text = lector(27)
                txtObserRetencion.Text = lector(28)
                txtDomEntrega.Text = lector(29)
                txtNombreCompania.Text = lector(30)
                txtNombreCliente.Text = lector(31)
                txtTelefono.Text = lector(32)
                lector.Close()

            End If



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
        idseguimiento = 0
        Me.Close()
    End Sub
    Private Sub txtDias_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged
        dias = Val(txtDias.Text)
        DiasHab()
        dtpFechaVencimiento.Value = dtpFechaRecepcion.Value.AddDays(dias)
    End Sub
    Sub DiasHab()
        Dim Ini As DateTime = dtpFechaRecepcion.Value
        Dim Fin As Date = dtpFechaRecepcion.Value.AddDays(20)
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
            If idseguimiento = 0 Then
                R = "insert into [MetasCotizador].[dbo].[Segumiento_folios] ([Folio],[Cve_operador],[Pendientes],[Fac_Adelantado],[CA],[Combinado_con],[Operador_ext],[Cierre_folio],[Credito],[Observaciones],
                    [Equipo],[Dias],[FechaVenc],[Con_cot],[Num_cot],[Mensajeria_recep],[Obser_retencion],[FMC],[FEF],[datos_informes],[OC],[OC_necesaria],[fac_oc],[Num_orde_de_compra],[Status_folio],
                    [Domicilio_entrega],[Mensajeria_retorno],[obser_tecnicas])
                    values(" & Val(lblNumFolio.Text) & "," & Val(cveOperador) & ",'" & (pendientes) & "', '" & facAd & "','" & CA & "','" & txtCombinadoCon.Text & "', '" & operadores & "','" & cboCierra.Text &
                    "', '" & txtCredito.Text & "', '" & txtObserPendientes.Text & "','" & txtEquipo.Text & "'," & Val(txtDias.Text) & ", '" & fechaVen & "', '" & CONC & "',  " & Val(txtNumCot.Text) & ", '" &
                    txtMenRecep.Text & "','" & txtObserRetencion.Text & "','0000-00-00','0000-00-00', '" & txtDatosInforme.Text & "','" & UOC & "','" & OCN & "','" & FACOC & "','" & txtNumComp.Text & "', '" &
                    cboStatus.Text & "', '" & txtDomEntrega.Text & "','" & txtMenEnv.Text & "', '" & txtObserTec.Text & "')"

            Else
                Dim fechacertificado As String
                Dim fechafacturacion As String
                If txtFMC.Visible = True And textFEF.Visible = True Then
                    fechacertificado = txtFMC.Text
                    fechafacturacion = textFEF.Text
                ElseIf txtFMC.Visible = True And textFEF.Visible = False Then
                    fechacertificado = txtFMC.Text
                    fechafacturacion = Convert.ToDateTime(dtpFechaFacturación.Text).ToShortDateString
                ElseIf txtFMC.Visible = False And textFEF.Visible = True Then
                    fechacertificado = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
                    fechafacturacion = textFEF.Text
                ElseIf txtFMC.Visible = False And textFEF.Visible = False Then
                    fechacertificado = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
                    fechafacturacion = Convert.ToDateTime(dtpFechaFacturación.Text).ToShortDateString
                End If
                R = "update [MetasCotizador].[dbo].[Segumiento_folios] set Pendientes='" & pendientes & "',Fac_Adelantado='" & facAd & "',
                CA='" & CA & "', Combinado_con='" & txtCombinadoCon.Text & "',Operador_ext='" & TextOperador.Text & "',
                Cierre_folio='" & cboCierra.Text & "',Credito='" & txtCredito.Text & "',Observaciones='" & txtObserPendientes.Text & "',
                Equipo='" & txtEquipo.Text & "',Dias=" & Val(txtDias.Text) & ",FechaVenc='" & fechaVen & "',
                Con_cot='" & CONC & "',Num_cot=" & Val(txtNumCot.Text) & ",Mensajeria_recep='" & txtMenRecep.Text & "',
                Mensajeria_retorno='" & txtMenEnv.Text & "', Domicilio_entrega='" & txtDomEntrega.Text & "',
                Obser_retencion='" & txtObserRetencion.Text & "', obser_tecnicas='" & txtObserTec.Text & "',FMC='" & fechacertificado & "',FEF='" & fechafacturacion & "',
                datos_informes='" & txtDatosInforme.Text & "',OC='" & UOC & "',OC_necesaria='" & OCN & "',
                fac_oc='" & FACOC & "',Num_orde_de_compra='" & txtNumComp.Text & "',
                Status_folio='" & cboStatus.Text & "' where idSeguimiento=" & idseguimiento & " and Cve_Operador= " & cveOperador

            End If
            Dim comando2 As New SqlCommand(R, conexionMetasCotizador)
            comando2.CommandText = R
            comando2.ExecuteNonQuery()
            MsgBox("FOLIO NUM: " & folio & ".  ACTUALIZADO")
            idseguimiento = 0
            FrmAutorizarSolicitudes.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmSeguimiento", "Error al grabar", Err.Number, cadena)
        End Try
    End Sub
End Class