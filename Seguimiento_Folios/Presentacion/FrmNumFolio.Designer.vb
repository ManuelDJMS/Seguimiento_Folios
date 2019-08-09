<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNumFolio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombreDeContacto = New System.Windows.Forms.Label()
        Me.txtBuscarFolio = New System.Windows.Forms.TextBox()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreDeContacto
        '
        Me.txtNombreDeContacto.AutoSize = True
        Me.txtNombreDeContacto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDeContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.txtNombreDeContacto.Location = New System.Drawing.Point(12, 19)
        Me.txtNombreDeContacto.Name = "txtNombreDeContacto"
        Me.txtNombreDeContacto.Size = New System.Drawing.Size(203, 18)
        Me.txtNombreDeContacto.TabIndex = 187
        Me.txtNombreDeContacto.Text = "Ingrese el Número de folio"
        '
        'txtBuscarFolio
        '
        Me.txtBuscarFolio.Location = New System.Drawing.Point(60, 51)
        Me.txtBuscarFolio.Name = "txtBuscarFolio"
        Me.txtBuscarFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarFolio.TabIndex = 188
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.White
        Me.btBuscar.Location = New System.Drawing.Point(47, 77)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(127, 33)
        Me.btBuscar.TabIndex = 277
        Me.btBuscar.Text = "BUSCAR "
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'FrmNumFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 117)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.txtBuscarFolio)
        Me.Controls.Add(Me.txtNombreDeContacto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNumFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmNumFolio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreDeContacto As Label
    Friend WithEvents txtBuscarFolio As TextBox
    Friend WithEvents btBuscar As Button
End Class
