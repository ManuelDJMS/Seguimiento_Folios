Imports System.IO
Imports Timer = System.Windows.Forms.Timer
Public Class FrmInicio
    Public variable As String
    Dim version As String
    Public timerback As New Timer
    Public Sub New()
        InitializeComponent()
        AddHandler timerback.Tick, New EventHandler(AddressOf resorce)
        defaul()
    End Sub
    Sub defaul()
        linerocket.Height = 8
        linerocket.Width = 0
        linerocket.Left = 286
        timerback.Interval = 30
        timerback.Start()
    End Sub
    Dim wd As Integer = 0
    Sub resorce(sender As Object, e As EventArgs)
        linerocket.Width += wd
        If linerocket.Width < 1 Then
            wd = 8
        End If
        If linerocket.Width > 752 Then
            timerback.Stop()
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity > 0.0 Then
            Me.Opacity -= 0.105
        Else
            Timer1.Stop()
            FrmSesion.Show()
            Me.Dispose()
        End If
    End Sub
    Sub LeerArchivo()
        Dim leer As New StreamReader("\\10.10.10.7\Public-2\INSTALACIONES COTIZADOR\Seguimiento_Folios\version.txt")
        Try
            'Se abre el txt para ver la version
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                variable = (linea)
            End While
            leer.Close()
            If Not variable = lbVersion.Text Then 'Verifica si la version es igual a la del txt
                MsgBox("Existe una nueva actualizacion", MsgBoxStyle.Exclamation, "METAS COTIZADOR")
                Dim OpenFileDialog As New OpenFileDialog
                Process.Start("\\10.10.10.7\Public-2\INSTALACIONES COTIZADOR\Metas Cotizador\MetasCotizador.msp")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerArchivo()
    End Sub
End Class