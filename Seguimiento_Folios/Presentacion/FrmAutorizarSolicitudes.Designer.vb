<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAutorizarSolicitudes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAutorizarSolicitudes))
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGRes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbTecnicos = New System.Windows.Forms.RadioButton()
        Me.dgDatosG = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPendientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.txtNumCot = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btSinCot = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabConsulta.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.Controls.Add(Me.TabPage2)
        Me.TabConsulta.Location = New System.Drawing.Point(5, 27)
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 639)
        Me.TabConsulta.TabIndex = 42
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.DGRes)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.btSinCot)
        Me.TabPage2.Controls.Add(Me.btnGuardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1140, 613)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Cotizaciones"
        '
        'DGRes
        '
        Me.DGRes.AllowUserToDeleteRows = False
        Me.DGRes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGRes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27})
        Me.DGRes.EnableHeadersVisualStyles = False
        Me.DGRes.Location = New System.Drawing.Point(14, 120)
        Me.DGRes.Name = "DGRes"
        Me.DGRes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.DGRes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGRes.Size = New System.Drawing.Size(1109, 463)
        Me.DGRes.TabIndex = 261
        '
        'Column1
        '
        Me.Column1.HeaderText = "Folio"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Empresa"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Operador"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Pendientes"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Factura por Adelantado"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Carta de Autorización"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Combinado con "
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Operador Exterior"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Cierre Folio"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Crédito"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Observaciones"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Equipo"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Días"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Fecha Recepción"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Fecha Vencimiento"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Con Cot"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.HeaderText = "Num Cot"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.HeaderText = "Mensajería de Recepción"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.HeaderText = "Observaciones de Retención"
        Me.Column19.Name = "Column19"
        '
        'Column20
        '
        Me.Column20.HeaderText = "Fecha Entrega del Certificado"
        Me.Column20.Name = "Column20"
        '
        'Column21
        '
        Me.Column21.HeaderText = "Fecha Entrega Factura"
        Me.Column21.Name = "Column21"
        '
        'Column22
        '
        Me.Column22.HeaderText = "Datos Informes"
        Me.Column22.Name = "Column22"
        '
        'Column23
        '
        Me.Column23.HeaderText = "Orden de Compra"
        Me.Column23.Name = "Column23"
        '
        'Column24
        '
        Me.Column24.HeaderText = "Orden de Compra Necesaría"
        Me.Column24.Name = "Column24"
        '
        'Column25
        '
        Me.Column25.HeaderText = "Factura = Orden Compra"
        Me.Column25.Name = "Column25"
        '
        'Column26
        '
        Me.Column26.HeaderText = "N° Orden de Compra"
        Me.Column26.Name = "Column26"
        '
        'Column27
        '
        Me.Column27.HeaderText = "Status"
        Me.Column27.Name = "Column27"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbTecnicos)
        Me.GroupBox2.Controls.Add(Me.dgDatosG)
        Me.GroupBox2.Controls.Add(Me.RbTodos)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(725, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 69)
        Me.GroupBox2.TabIndex = 260
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar"
        '
        'RbTecnicos
        '
        Me.RbTecnicos.AutoSize = True
        Me.RbTecnicos.ForeColor = System.Drawing.SystemColors.MenuText
        Me.RbTecnicos.Location = New System.Drawing.Point(282, 26)
        Me.RbTecnicos.Name = "RbTecnicos"
        Me.RbTecnicos.Size = New System.Drawing.Size(107, 25)
        Me.RbTecnicos.TabIndex = 17
        Me.RbTecnicos.Text = "Generales"
        Me.RbTecnicos.UseVisualStyleBackColor = True
        '
        'dgDatosG
        '
        Me.dgDatosG.AutoSize = True
        Me.dgDatosG.ForeColor = System.Drawing.SystemColors.MenuText
        Me.dgDatosG.Location = New System.Drawing.Point(108, 26)
        Me.dgDatosG.Name = "dgDatosG"
        Me.dgDatosG.Size = New System.Drawing.Size(148, 25)
        Me.dgDatosG.TabIndex = 16
        Me.dgDatosG.Text = "Administrativos"
        Me.dgDatosG.UseVisualStyleBackColor = True
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Checked = True
        Me.RbTodos.ForeColor = System.Drawing.SystemColors.MenuText
        Me.RbTodos.Location = New System.Drawing.Point(20, 25)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(73, 25)
        Me.RbTodos.TabIndex = 15
        Me.RbTodos.TabStop = True
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbPendientes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.LabelNombre)
        Me.GroupBox1.Controls.Add(Me.txtNumCot)
        Me.GroupBox1.Controls.Add(Me.txtNombreE)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(14, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 69)
        Me.GroupBox1.TabIndex = 259
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por"
        '
        'cbPendientes
        '
        Me.cbPendientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPendientes.FormattingEnabled = True
        Me.cbPendientes.Items.AddRange(New Object() {"COMPLETO", "Orden de O.C. Y Mensajería", "Orden de compra", "Solo mensajería"})
        Me.cbPendientes.Location = New System.Drawing.Point(560, 27)
        Me.cbPendientes.Name = "cbPendientes"
        Me.cbPendientes.Size = New System.Drawing.Size(121, 25)
        Me.cbPendientes.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(478, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Pendientes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(54, 30)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(71, 20)
        Me.txtFolio.TabIndex = 128
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label25.Location = New System.Drawing.Point(339, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 17)
        Me.Label25.TabIndex = 204
        Me.Label25.Text = "Num Cot:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LabelNombre.Location = New System.Drawing.Point(127, 32)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(67, 17)
        Me.LabelNombre.TabIndex = 203
        Me.LabelNombre.Text = "Empresa:"
        '
        'txtNumCot
        '
        Me.txtNumCot.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCot.Location = New System.Drawing.Point(417, 29)
        Me.txtNumCot.Name = "txtNumCot"
        Me.txtNumCot.Size = New System.Drawing.Size(59, 21)
        Me.txtNumCot.TabIndex = 206
        '
        'txtNombreE
        '
        Me.txtNombreE.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreE.Location = New System.Drawing.Point(198, 31)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(138, 21)
        Me.txtNombreE.TabIndex = 205
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 586)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 257
        Me.Label8.Text = "Nota:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 587)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(357, 14)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Selecciona las cotizaciones que se convertiran a orden de venta en LIMS"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label27.Location = New System.Drawing.Point(153, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(149, 16)
        Me.Label27.TabIndex = 152
        Me.Label27.Text = "Seguimiento de Folios"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(10, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(137, 19)
        Me.Label26.TabIndex = 165
        Me.Label26.Text = "Edicion de Folios"
        '
        'btSinCot
        '
        Me.btSinCot.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btSinCot.Cursor = System.Windows.Forms.Cursors.Default
        Me.btSinCot.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btSinCot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSinCot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSinCot.ForeColor = System.Drawing.Color.Black
        Me.btSinCot.Location = New System.Drawing.Point(908, 7)
        Me.btSinCot.Name = "btSinCot"
        Me.btSinCot.Size = New System.Drawing.Size(83, 33)
        Me.btSinCot.TabIndex = 181
        Me.btSinCot.Text = "Sin Cot"
        Me.btSinCot.UseVisualStyleBackColor = False
        Me.btSinCot.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(987, 7)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(144, 33)
        Me.btnGuardar.TabIndex = 166
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1128, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        '
        'FrmAutorizarSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TabConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.MaximizeBox = False
        Me.Name = "FrmAutorizarSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Autorizaciòn de solicitudes"
        Me.TabConsulta.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btSinCot As Button
    Friend WithEvents txtNumCot As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RbTecnicos As RadioButton
    Friend WithEvents dgDatosG As RadioButton
    Friend WithEvents RbTodos As RadioButton
    Friend WithEvents DGRes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents cbPendientes As ComboBox
    Friend WithEvents Label1 As Label
End Class
