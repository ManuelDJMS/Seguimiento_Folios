Imports System.Data.SqlClient
Public Class FrmSeguimieto
    Dim equipo, CA, facAd, CONC, UOC, OCN, FACOC As String
    Dim numCot As Integer
    Dim dias, cveoperador, pendientes, OC As Integer
    Dim lector As SqlDataReader
    Private Sub FrmSeguimieto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        R = "select REL.[Folio], [Descripcion], CCU.[Compania], [Nombre] +' '+[Apellidos] AS Cliente,isnull([Email],'-'),[Tel],[Credito], [Fecha-recep],
             REL.[Mensajeria], [TIPO],[DatosdelInforme], isnull([NumCot], '') as NumCot, [Status], [CveOperador], [Orden de compra] FROM [Recepcion-Equipos-Logistica] REL  
            INNER JOIN [INFORMES-SERVICIOS] INF  ON REL.[Folio] = INF.[Folio]
            INNER JOIN [Contactos-Clientes-Usuarios] CCU on REL.[Cvempresa] = CCU.[Clavempresa]
            INNER JOIN [MetAsInf] ON [MetAsInf].[Clavempresa] = CCU.[Clavempresa] where REL.[Folio] = " & folio & ""
        Dim comando As New SqlCommand(R, conexionMetasCotizador)
        lector = comando.ExecuteReader
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
        cveoperador = lector(13)
        txtMenRecep.Text = lector(8)
        If lector(14) = "1" Then
            rbSIOC.Checked = True
            rbNOOC.Checked = False
        End If
        While lector.Read()
            equipo = equipo + ", " + lector(9)
        End While
        txtEquipo.Text = equipo
        lector.Close()

        MetodoLIMS()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = "SELECT [cveOper],[Nombre] FROM [ListaOperadores]"
        lector = comandoMetasCotizador.ExecuteReader
        While lector.Read()
            cboOperadores.Items.Add(lector(1))
            cboCierra.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub
    Private Sub txtDias_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged
        dias = Val(txtDias.Text)
        dtpFechaVencimiento.Value = dtpFechaRecepcion.Value.AddDays(dias)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If rbCompleto.Checked = True Then
            pendientes = 0
        ElseIf rbOc.Checked = True Then
            pendientes = 1
        ElseIf rbOcyMensajeria.Checked = True Then
            pendientes = 2
        ElseIf rbMensajeria.Checked = True Then
            pendientes = 3
        End If
        If RbSI.Checked = True Then
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
        MetodoMetasCotizador()
        Dim fechaVen, FEC, FEF As Date
        fechaVen = Convert.ToDateTime(dtpFechaVencimiento.Text).ToShortDateString
        FEC = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
        FEF = Convert.ToDateTime(dtpfechaCertificado.Text).ToShortDateString
        R = "insert into [MetasCotizador].[dbo].[Segumiento_folios] ([Folio],[Cve_operador],[Pendientes],[Fac_Adelantado],[CA],[Combinado_con],[Operador_ext],[Cierre_folio],[Credito],[Observaciones],[Equipo],[Dias],[FechaVenc],[Con_cot],[Num_cot],[Mensajeria_recep],[Obser_retencion],[FMC],[FEF],[datos_informes],[OC],[OC_necesaria],[fac_oc],[Num_orde_de_compra],[Status_folio],[Domicilio_entrega],[Mensajeria_retorno])
        values(" & Val(lblNumFolio.Text) & "," & Val(cveoperador) & "," & Val(pendientes) & ", '" & facAd & "','" & CA & "','" & txtCombinadoCon.Text & "', '" & cboOperadores.Text & "','" & cboCierra.Text & "', '" & txtCredito.Text & "', '" & txtObserPendientes.Text & "','" & txtEquipo.Text & "'," & Val(txtDias.Text) & ", '" & fechaVen & "', '" & CONC & "',  " & Val(txtNumCot.Text) & ", '" & txtMenRecep.Text & "','" & txtObserRetencion.Text & "','" & FEC & "','" & FEF & "', '" & txtDatosInforme.Text & "','" & UOC & "','" & OCN & "','" & FACOC & "'," & txtNumComp.Text & ", '" & cboStatus.Text & "', '" & txtDomEntrega.Text & "','" & txtMenEnv.Text & "')"
        Dim comando2 As New SqlCommand(R, conexionMetasCotizador)
        comando2.CommandText = R
        'MsgBox(R)
        comando2.ExecuteNonQuery()
        MsgBox("FOLIO NUM:" & folio & ".  ACTUALIZADO")
    End Sub
End Class