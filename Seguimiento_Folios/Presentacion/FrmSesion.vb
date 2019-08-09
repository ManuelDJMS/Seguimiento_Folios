Imports System.Data.SqlClient
Public Class FrmSesion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.pictureBox1, "Ingresa al Sistema")
            Me.ToolTip1.SetToolTip(Me.btnmin, "Minimiza el Sistema")
            Me.ToolTip1.SetToolTip(Me.btncerrar, "Salir del Sistema")
            Me.ToolTip1.AutoPopDelay = 5000
            'Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize       'Captura el Tamaño del Monitor
            'Dim alto As Int32 = (desktopSize.Height - 280) \ 2
            'Dim ancho As Int32 = (desktopSize.Width - 500) \ 2
            'panel1.Location = New Point(ancho, alto)
            Timer1.Start()
            lblFecha.Text = DateTime.Now.ToLongDateString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Txtuser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtuser.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca un Nombre de Usuario")
        End If
    End Sub

    Private Sub Txtpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpass.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca su Contraseña")
        End If
    End Sub

    Private Sub Txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If Me.ValidateChildren = True And txtpass.Text <> "" And txtuser.Text <> "" Then
                        Using conexion1 As New SqlConnection(cnm)
                            conexion1.Open()
                            Dim transaction As SqlTransaction
                            transaction = conexion1.BeginTransaction("Sample")
                            Dim comando As SqlCommand = conexion1.CreateCommand()
                            Dim lector As SqlDataReader
                            comando.Connection = conexion1
                            comando.Transaction = transaction
                            Dim r As String = "select idUsuario, Login, Password, Rol from Usuarios where Login= " & "'" & txtuser.Text & "'"
                            comando.CommandText = r
                            lector = comando.ExecuteReader()
                            lector.Read()
                            usuario = lector(0)
                            If txtuser.Text = lector(1) And txtpass.Text = lector(2) Then
                                lector.Close()
                                MsgBox("Usuario Correcto, BIENVENIDO", MsgBoxStyle.Information)
                                FrmHOME.Show()
                                conexion1.Close()
                                Me.Dispose()
                            Else
                                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                                txtpass.Clear()
                            End If
                        End Using
                    Else
                        MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Try

            If Me.ValidateChildren = True And txtpass.Text <> "" And txtuser.Text <> "" Then
                        Using conexion1 As New SqlConnection(cnm)
                            conexion1.Open()
                            Dim transaction As SqlTransaction
                            transaction = conexion1.BeginTransaction("Sample")
                            Dim comando As SqlCommand = conexion1.CreateCommand()
                            Dim lector As SqlDataReader
                            comando.Connection = conexion1
                            comando.Transaction = transaction
                            Dim r As String = "select idUsuario, Login, Password, Rol from Usuarios where Login= " & "'" & txtuser.Text & "'"
                            comando.CommandText = r
                            lector = comando.ExecuteReader()
                            lector.Read()
                            usuario = lector(0)
                            If txtuser.Text = lector(1) And txtpass.Text = lector(2) Then
                                lector.Close()
                                MsgBox("Usuario Correcto, BIENVENIDO", MsgBoxStyle.Information)
                                FrmHOME.Show()
                                conexion1.Close()
                                Me.Dispose()
                            Else
                                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                                txtpass.Clear()
                            End If
                        End Using
                    Else
                        MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub
End Class