Public Class FrmNumFolio
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        folio = txtBuscarFolio.Text
        FrmSeguimieto.ShowDialog()
        Me.Close()
    End Sub
End Class