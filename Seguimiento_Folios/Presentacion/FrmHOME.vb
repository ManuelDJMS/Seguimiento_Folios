﻿Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FrmHOME
    Dim banm, banb As Boolean
#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.Size = New Size(30, 30)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnRestaurar_MouseHover(sender As Object, e As EventArgs) Handles btnRestaurar.MouseHover
        btnRestaurar.Size = New Size(35, 35)
    End Sub

    Private Sub btnRestaurar_MouseLeave(sender As Object, e As EventArgs) Handles btnRestaurar.MouseLeave
        btnRestaurar.Size = New Size(30, 30)
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_MouseHover(sender As Object, e As EventArgs) Handles btnMinimizar.MouseHover
        btnMinimizar.Size = New Size(35, 35)
    End Sub

    Private Sub btnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimizar.MouseLeave
        btnMinimizar.Size = New Size(30, 30)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnMaximizar.MouseHover
        btnMaximizar.Size = New Size(35, 35)
    End Sub

    Private Sub btnMaximizar_MouseLeave(sender As Object, e As EventArgs) Handles btnMaximizar.MouseLeave
        btnMaximizar.Size = New Size(30, 30)
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Normal
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub BtnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        colorearpanel(PanelMenu, PL_Cotizacion)
        AbrirFormEnPanel(Of FrmAutorizarSolicitudes)()
    End Sub

    Private Sub BtnContactos_Click(sender As Object, e As EventArgs) Handles btnContactos.Click
        Try
            'cveOperador = InputBox("Ingrese su clave de operador: ", "Información de operador")
            'MetodoMetasInf()
            'Dim comando As New SqlCommand(R, conexionMetasInf)
            ''Dim lector As SqlDataReader
            'comando = conexionMetasInf.CreateCommand
            'comando.CommandText = "SELECT * FROM [ListaOperadores] where cveOper = " & cveOperador & ""
            'lector = comando.ExecuteReader
            'lector.Read()
            'If cveOperador = lector(0) Then
            FrmNumFolio.Show()
            'Else
            '    MsgBox("Número de operador INCORRECTO")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("HOME", "Error al ingresar la clavede de operador", Err.Number, cadena)
        End Try
    End Sub
    'Private Sub BtnContactos_Click_1(sender As Object, e As EventArgs) Handles btnContactos.Click
    '    colorearpanel(PanelMenu, PL_Contactos)
    '    AbrirFormEnPanel(Of FrmContactos)()
    'End Sub

    'Private Sub BtnCerrar_MouseHover(sender As Object, e As EventArgs) Handles btnCerrar.MouseHover
    '    btnCerrar.Size = New Size(35, 35)
    'End Sub

    'Private Sub BtnOrdenVenta_Click(sender As Object, e As EventArgs) Handles btnOrdenVenta.Click
    '    colorearpanel(PanelMenu, PL_OrdenVenta)
    '    AbrirFormEnPanel(Of FrmAutorizarSolicitudes)()
    'End Sub

    'Private Sub BtnRecordatorios_Click(sender As Object, e As EventArgs) Handles btnRecordatorios.Click
    '    colorearpanel(PanelMenu, PL_Recordatorio)
    '    AbrirFormEnPanel(Of FrmSeguimientoCot)()
    'End Sub

    'Private Sub BtnConfirmacion_Click(sender As Object, e As EventArgs) Handles btnConfirmacion.Click
    '    ConfirmacionDeDatos.Show()
    'End Sub

    'Private Sub BtnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
    '    colorearpanel(PanelMenu, PL_Cotizacion)
    '    AbrirFormEnPanel(Of FrmCotizadorLIMS)()
    'End Sub

    'Private Sub BtnPreFact_Click(sender As Object, e As EventArgs) Handles btnPreFact.Click

    '    colorearpanel(PanelMenu, PL_Cotizacion)
    '    AbrirFormEnPanel(Of FrmCompletarOT)()
    'End Sub
#End Region
    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If (Application.OpenForms("FormPacientes") Is Nothing) Then
            'Button1.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If (Application.OpenForms("FormAgenda") Is Nothing) Then
            ' Button2.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub
    '------------Funcion para colorear los paneles cuando se presiona un cierto boton------------------
    Sub colorearpanel(ByVal formulario As Panel, ByVal panelwhite As Panel)
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
End Class