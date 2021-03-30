<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form))
        Me.cmdinsertar = New System.Windows.Forms.Button()
        Me.actualizar = New System.Windows.Forms.Button()
        Me.cmdlimpiar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdsalir = New System.Windows.Forms.Button()
        Me.txteditoria = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.txtanio = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdinsertar
        '
        Me.cmdinsertar.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdinsertar.Location = New System.Drawing.Point(24, 183)
        Me.cmdinsertar.Name = "cmdinsertar"
        Me.cmdinsertar.Size = New System.Drawing.Size(75, 23)
        Me.cmdinsertar.TabIndex = 0
        Me.cmdinsertar.Text = "Insertar"
        Me.cmdinsertar.UseVisualStyleBackColor = True
        '
        'actualizar
        '
        Me.actualizar.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actualizar.Location = New System.Drawing.Point(115, 183)
        Me.actualizar.Name = "actualizar"
        Me.actualizar.Size = New System.Drawing.Size(75, 23)
        Me.actualizar.TabIndex = 1
        Me.actualizar.Text = "Actualizar"
        Me.actualizar.UseVisualStyleBackColor = True
        '
        'cmdlimpiar
        '
        Me.cmdlimpiar.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlimpiar.Location = New System.Drawing.Point(196, 183)
        Me.cmdlimpiar.Name = "cmdlimpiar"
        Me.cmdlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdlimpiar.TabIndex = 2
        Me.cmdlimpiar.Text = "Limpiar"
        Me.cmdlimpiar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeliminar.Location = New System.Drawing.Point(277, 183)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdeliminar.TabIndex = 3
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdsalir
        '
        Me.cmdsalir.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsalir.Location = New System.Drawing.Point(367, 183)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 4
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.UseVisualStyleBackColor = True
        '
        'txteditoria
        '
        Me.txteditoria.Location = New System.Drawing.Point(88, 84)
        Me.txteditoria.Name = "txteditoria"
        Me.txteditoria.Size = New System.Drawing.Size(100, 20)
        Me.txteditoria.TabIndex = 5
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(88, 47)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(90, 118)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(100, 20)
        Me.txtautor.TabIndex = 7
        '
        'txtanio
        '
        Me.txtanio.Location = New System.Drawing.Point(90, 150)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.Size = New System.Drawing.Size(100, 20)
        Me.txtanio.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(38, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Autor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Editoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Año"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.editoria, Me.autor, Me.año})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(418, 150)
        Me.DataGridView1.TabIndex = 13
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 50
        '
        'editoria
        '
        Me.editoria.DataPropertyName = "editoria"
        Me.editoria.HeaderText = "Editoria"
        Me.editoria.Name = "editoria"
        Me.editoria.ReadOnly = True
        '
        'autor
        '
        Me.autor.DataPropertyName = "autor"
        Me.autor.HeaderText = "Autor"
        Me.autor.Name = "autor"
        Me.autor.ReadOnly = True
        Me.autor.Width = 150
        '
        'año
        '
        Me.año.DataPropertyName = "año"
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        Me.año.Width = 75
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication6.My.Resources.Resources.thumbbig_389874
        Me.ClientSize = New System.Drawing.Size(464, 368)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtanio)
        Me.Controls.Add(Me.txtautor)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.txteditoria)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdlimpiar)
        Me.Controls.Add(Me.actualizar)
        Me.Controls.Add(Me.cmdinsertar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form"
        Me.Text = "Libros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdinsertar As System.Windows.Forms.Button
    Friend WithEvents actualizar As System.Windows.Forms.Button
    Friend WithEvents cmdlimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
    Friend WithEvents txteditoria As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtautor As System.Windows.Forms.TextBox
    Friend WithEvents txtanio As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
