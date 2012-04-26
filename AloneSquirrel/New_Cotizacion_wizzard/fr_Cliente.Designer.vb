<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_Cliente))
        Me.bt_Editar = New System.Windows.Forms.Button()
        Me.txt_Ramo = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Estado = New System.Windows.Forms.TextBox()
        Me.txt_Ciudad = New System.Windows.Forms.TextBox()
        Me.txt_CP = New System.Windows.Forms.TextBox()
        Me.txt_Colonia = New System.Windows.Forms.TextBox()
        Me.txt_Domicilio = New System.Windows.Forms.TextBox()
        Me.txt_Empresa = New System.Windows.Forms.TextBox()
        Me.lb_CP = New System.Windows.Forms.Label()
        Me.lb_Ramo = New System.Windows.Forms.Label()
        Me.lb_Telefono = New System.Windows.Forms.Label()
        Me.lb_Estado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.lb_Ciudad = New System.Windows.Forms.Label()
        Me.lb_Colonia = New System.Windows.Forms.Label()
        Me.lb_Domicilio = New System.Windows.Forms.Label()
        Me.lb_Empresa = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_NumeroDeCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_Editar
        '
        Me.bt_Editar.Location = New System.Drawing.Point(397, 290)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Editar.TabIndex = 37
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseVisualStyleBackColor = True
        '
        'txt_Ramo
        '
        Me.txt_Ramo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ramo.Enabled = False
        Me.txt_Ramo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Ramo.ForeColor = System.Drawing.Color.Black
        Me.txt_Ramo.Location = New System.Drawing.Point(124, 258)
        Me.txt_Ramo.Name = "txt_Ramo"
        Me.txt_Ramo.Size = New System.Drawing.Size(348, 26)
        Me.txt_Ramo.TabIndex = 34
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Telefono.Enabled = False
        Me.txt_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_Telefono.Location = New System.Drawing.Point(124, 226)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(348, 26)
        Me.txt_Telefono.TabIndex = 33
        '
        'txt_Estado
        '
        Me.txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Estado.Enabled = False
        Me.txt_Estado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Estado.ForeColor = System.Drawing.Color.Black
        Me.txt_Estado.Location = New System.Drawing.Point(124, 194)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.Size = New System.Drawing.Size(348, 26)
        Me.txt_Estado.TabIndex = 32
        '
        'txt_Ciudad
        '
        Me.txt_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ciudad.Enabled = False
        Me.txt_Ciudad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Ciudad.ForeColor = System.Drawing.Color.Black
        Me.txt_Ciudad.Location = New System.Drawing.Point(124, 162)
        Me.txt_Ciudad.Name = "txt_Ciudad"
        Me.txt_Ciudad.Size = New System.Drawing.Size(348, 26)
        Me.txt_Ciudad.TabIndex = 31
        '
        'txt_CP
        '
        Me.txt_CP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CP.Enabled = False
        Me.txt_CP.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_CP.ForeColor = System.Drawing.Color.Black
        Me.txt_CP.Location = New System.Drawing.Point(381, 130)
        Me.txt_CP.Name = "txt_CP"
        Me.txt_CP.Size = New System.Drawing.Size(91, 26)
        Me.txt_CP.TabIndex = 30
        '
        'txt_Colonia
        '
        Me.txt_Colonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Colonia.Enabled = False
        Me.txt_Colonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Colonia.ForeColor = System.Drawing.Color.Black
        Me.txt_Colonia.Location = New System.Drawing.Point(124, 130)
        Me.txt_Colonia.Name = "txt_Colonia"
        Me.txt_Colonia.Size = New System.Drawing.Size(200, 26)
        Me.txt_Colonia.TabIndex = 29
        '
        'txt_Domicilio
        '
        Me.txt_Domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Domicilio.Enabled = False
        Me.txt_Domicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Domicilio.ForeColor = System.Drawing.Color.Black
        Me.txt_Domicilio.Location = New System.Drawing.Point(124, 96)
        Me.txt_Domicilio.Name = "txt_Domicilio"
        Me.txt_Domicilio.Size = New System.Drawing.Size(348, 26)
        Me.txt_Domicilio.TabIndex = 28
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Enabled = False
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(124, 64)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 26)
        Me.txt_Empresa.TabIndex = 27
        '
        'lb_CP
        '
        Me.lb_CP.AutoSize = True
        Me.lb_CP.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_CP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_CP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_CP.Location = New System.Drawing.Point(344, 138)
        Me.lb_CP.Name = "lb_CP"
        Me.lb_CP.Size = New System.Drawing.Size(31, 18)
        Me.lb_CP.TabIndex = 26
        Me.lb_CP.Text = "CP"
        '
        'lb_Ramo
        '
        Me.lb_Ramo.AutoSize = True
        Me.lb_Ramo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Ramo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ramo.Location = New System.Drawing.Point(16, 266)
        Me.lb_Ramo.Name = "lb_Ramo"
        Me.lb_Ramo.Size = New System.Drawing.Size(50, 18)
        Me.lb_Ramo.TabIndex = 25
        Me.lb_Ramo.Text = "Ramo"
        '
        'lb_Telefono
        '
        Me.lb_Telefono.AutoSize = True
        Me.lb_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Telefono.Location = New System.Drawing.Point(13, 234)
        Me.lb_Telefono.Name = "lb_Telefono"
        Me.lb_Telefono.Size = New System.Drawing.Size(66, 18)
        Me.lb_Telefono.TabIndex = 24
        Me.lb_Telefono.Text = "Teléfono"
        '
        'lb_Estado
        '
        Me.lb_Estado.AutoSize = True
        Me.lb_Estado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Estado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Estado.Location = New System.Drawing.Point(14, 202)
        Me.lb_Estado.Name = "lb_Estado"
        Me.lb_Estado.Size = New System.Drawing.Size(58, 18)
        Me.lb_Estado.TabIndex = 23
        Me.lb_Estado.Text = "Estado"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bt_Ayuda)
        Me.Panel1.Controls.Add(Me.bt_Cancelar)
        Me.Panel1.Controls.Add(Me.bt_finalizar)
        Me.Panel1.Controls.Add(Me.bt_Siguiente)
        Me.Panel1.Controls.Add(Me.bt_Anterior)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 55)
        Me.Panel1.TabIndex = 4
        '
        'bt_Ayuda
        '
        Me.bt_Ayuda.Location = New System.Drawing.Point(12, 16)
        Me.bt_Ayuda.Name = "bt_Ayuda"
        Me.bt_Ayuda.Size = New System.Drawing.Size(75, 23)
        Me.bt_Ayuda.TabIndex = 4
        Me.bt_Ayuda.Text = "Ayuda"
        Me.bt_Ayuda.UseVisualStyleBackColor = True
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Location = New System.Drawing.Point(405, 16)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Cancelar.TabIndex = 3
        Me.bt_Cancelar.Text = "Cancelar"
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_finalizar
        '
        Me.bt_finalizar.Enabled = False
        Me.bt_finalizar.Location = New System.Drawing.Point(324, 16)
        Me.bt_finalizar.Name = "bt_finalizar"
        Me.bt_finalizar.Size = New System.Drawing.Size(75, 23)
        Me.bt_finalizar.TabIndex = 2
        Me.bt_finalizar.Text = "Finalizar >>"
        Me.bt_finalizar.UseVisualStyleBackColor = True
        '
        'bt_Siguiente
        '
        Me.bt_Siguiente.Location = New System.Drawing.Point(243, 16)
        Me.bt_Siguiente.Name = "bt_Siguiente"
        Me.bt_Siguiente.Size = New System.Drawing.Size(75, 23)
        Me.bt_Siguiente.TabIndex = 1
        Me.bt_Siguiente.Text = "Siguiente >"
        Me.bt_Siguiente.UseVisualStyleBackColor = True
        '
        'bt_Anterior
        '
        Me.bt_Anterior.Location = New System.Drawing.Point(162, 16)
        Me.bt_Anterior.Name = "bt_Anterior"
        Me.bt_Anterior.Size = New System.Drawing.Size(75, 23)
        Me.bt_Anterior.TabIndex = 0
        Me.bt_Anterior.Text = "< Anterior"
        Me.bt_Anterior.UseVisualStyleBackColor = True
        '
        'lb_Ciudad
        '
        Me.lb_Ciudad.AutoSize = True
        Me.lb_Ciudad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Ciudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ciudad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ciudad.Location = New System.Drawing.Point(16, 170)
        Me.lb_Ciudad.Name = "lb_Ciudad"
        Me.lb_Ciudad.Size = New System.Drawing.Size(59, 18)
        Me.lb_Ciudad.TabIndex = 22
        Me.lb_Ciudad.Text = "Ciudad"
        '
        'lb_Colonia
        '
        Me.lb_Colonia.AutoSize = True
        Me.lb_Colonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Colonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Colonia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Colonia.Location = New System.Drawing.Point(16, 138)
        Me.lb_Colonia.Name = "lb_Colonia"
        Me.lb_Colonia.Size = New System.Drawing.Size(62, 18)
        Me.lb_Colonia.TabIndex = 21
        Me.lb_Colonia.Text = "Colonia"
        '
        'lb_Domicilio
        '
        Me.lb_Domicilio.AutoSize = True
        Me.lb_Domicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Domicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Domicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Domicilio.Location = New System.Drawing.Point(14, 104)
        Me.lb_Domicilio.Name = "lb_Domicilio"
        Me.lb_Domicilio.Size = New System.Drawing.Size(74, 18)
        Me.lb_Domicilio.TabIndex = 20
        Me.lb_Domicilio.Text = "Domicilio"
        '
        'lb_Empresa
        '
        Me.lb_Empresa.AutoSize = True
        Me.lb_Empresa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Empresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Empresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Empresa.Location = New System.Drawing.Point(16, 69)
        Me.lb_Empresa.Name = "lb_Empresa"
        Me.lb_Empresa.Size = New System.Drawing.Size(72, 18)
        Me.lb_Empresa.TabIndex = 19
        Me.lb_Empresa.Text = "Empresa"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_NumeroDeCliente)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.bt_Editar)
        Me.Panel3.Controls.Add(Me.txt_Ramo)
        Me.Panel3.Controls.Add(Me.txt_Telefono)
        Me.Panel3.Controls.Add(Me.txt_Estado)
        Me.Panel3.Controls.Add(Me.txt_Ciudad)
        Me.Panel3.Controls.Add(Me.txt_CP)
        Me.Panel3.Controls.Add(Me.txt_Colonia)
        Me.Panel3.Controls.Add(Me.txt_Domicilio)
        Me.Panel3.Controls.Add(Me.txt_Empresa)
        Me.Panel3.Controls.Add(Me.lb_CP)
        Me.Panel3.Controls.Add(Me.lb_Ramo)
        Me.Panel3.Controls.Add(Me.lb_Telefono)
        Me.Panel3.Controls.Add(Me.lb_Estado)
        Me.Panel3.Controls.Add(Me.lb_Ciudad)
        Me.Panel3.Controls.Add(Me.lb_Colonia)
        Me.Panel3.Controls.Add(Me.lb_Domicilio)
        Me.Panel3.Controls.Add(Me.lb_Empresa)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(493, 381)
        Me.Panel3.TabIndex = 6
        '
        'txt_NumeroDeCliente
        '
        Me.txt_NumeroDeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroDeCliente.Enabled = False
        Me.txt_NumeroDeCliente.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_NumeroDeCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroDeCliente.Location = New System.Drawing.Point(347, 14)
        Me.txt_NumeroDeCliente.Name = "txt_NumeroDeCliente"
        Me.txt_NumeroDeCliente.Size = New System.Drawing.Size(125, 26)
        Me.txt_NumeroDeCliente.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(203, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Numero de Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 57)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 60)
        Me.Panel2.TabIndex = 5
        '
        'fr_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_Editar As System.Windows.Forms.Button
    Friend WithEvents txt_Ramo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_Estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents txt_CP As System.Windows.Forms.TextBox
    Friend WithEvents txt_Colonia As System.Windows.Forms.TextBox
    Friend WithEvents txt_Domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents lb_CP As System.Windows.Forms.Label
    Friend WithEvents lb_Ramo As System.Windows.Forms.Label
    Friend WithEvents lb_Telefono As System.Windows.Forms.Label
    Friend WithEvents lb_Estado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Ayuda As System.Windows.Forms.Button
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_finalizar As System.Windows.Forms.Button
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents lb_Ciudad As System.Windows.Forms.Label
    Friend WithEvents lb_Colonia As System.Windows.Forms.Label
    Friend WithEvents lb_Domicilio As System.Windows.Forms.Label
    Friend WithEvents lb_Empresa As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_NumeroDeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
