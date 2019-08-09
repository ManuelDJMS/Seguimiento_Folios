Public Class FrmNumFolio
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        folio = txtBuscarFolio.Text
        'FrmSeguimieto.ShowDialog()
        'Me.Close()
        colorearpanel(FrmHOME.PanelMenu, FrmHOME.PL_Contactos)
        AbrirFormEnPanel(Of FrmSeguimieto)()
        Me.Close()
    End Sub
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = FrmHOME.PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            FrmHOME.PanelFormularios.Controls.Add(Formulario)
            FrmHOME.PanelFormularios.Tag = Formulario
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
End Class