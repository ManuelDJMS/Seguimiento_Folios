﻿Imports System.Data.SqlClient
Module Conexiones
    '-----------------------------Variables para la conexion con bases de Datos LIMS-------------------------------------------
    Public conexionMetasInf As SqlConnection
    Public comandoMetasInf As SqlCommand
    Public lectorMetasInf As SqlDataReader
    Public adapterMetasInf As SqlDataAdapter
    Public datatableMetasInf As DataTable
    '--------------------------------------------------------------------------------------------------------------------------
    '-----------------------------Variables para la conexion con bases de Datos COTIZADOR-------------------------------------------
    Public conexionMetasCotizador As SqlConnection
    Public comandoMetasCotizador As SqlCommand
    Public lectorMetasCotizador As SqlDataReader
    Public adapterMetasCotizador As SqlDataAdapter
    Public datatableMetasCotizador As DataTable
    '--------------------------------------------------------------------------------------------------------------------------
    Public ban As Boolean = True
    Public banderaform As Boolean
    Public numcotfrm, Total As Integer
    Public empresafrm, Contacto, Referencia, corrreofrm As String
    Public cnm As String = "Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019; User Id=sa; Password=Met99011578a;Integrated Security=False"
    Public usuario As Integer

    Public cotizador As String = "Data Source=SERVER3\COMPAC2;Initial Catalog=MetasCotizador; User Id=sa; Password=Met99011578a;Integrated Security=False"
    Public nombreusuario As String

    '------------------------------------------------------------------------CONEXIONES A BASES DE DATOS-------------------------------------------------------------------------------------------
    Sub MetodoMetasInf()
        Try
            conexionMetasInf = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019; User Id=sa; Password=Met99011578a;Integrated Security=False")
            'conexionMetasInf = New SqlConnection("Data Source=DATABASESERVER\COMPAC; Initial Catalog=MetAs_Live-pruebas; User Id=sa; Password=Contpaq1; Integrated Security=false")
            conexionMetasInf.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
    Sub MetodoMetasCotizador()
        Try
            conexionMetasCotizador = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=MetasCotizador; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionMetasCotizador.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
End Module
