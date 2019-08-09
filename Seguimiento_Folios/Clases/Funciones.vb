Imports System.Data.SqlClient
Module Funciones
    Public R As String 'Variable que almacena todos los scripts de base de datos
    Public cadena As String 'VARIABLE PARA ALMACENAR LA CADENA DEL ERROR DE LA BITACORA
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
End Module
