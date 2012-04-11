<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_Cliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bt_nuevoCliente = New System.Windows.Forms.Button()
        Me.lb_Cliente = New System.Windows.Forms.Label()
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
        Me.lb_Ciudad = New System.Windows.Forms.Label()
        Me.lb_Colonia = New System.Windows.Forms.Label()
        Me.lb_Domicilio = New System.Windows.Forms.Label()
        Me.lb_Empresa = New System.Windows.Forms.Label()
        Me.cb_Cliente = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bt_Ayuda)
        Me.Panel1.Controls.Add(Me.bt_Cancelar)
        Me.Panel1.Controls.Add(Me.bt_finalizar)
        Me.Panel1.Controls.Add(Me.bt_Siguiente)
        Me.Panel1.Controls.Add(Me.bt_Anterior)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 55)
        Me.Panel1.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 60)
        Me.Panel2.TabIndex = 2
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bt_nuevoCliente)
        Me.Panel3.Controls.Add(Me.lb_Cliente)
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
        Me.Panel3.Controls.Add(Me.cb_Cliente)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(483, 312)
        Me.Panel3.TabIndex = 3
        '
        'bt_nuevoCliente
        '
        Me.bt_nuevoCliente.Location = New System.Drawing.Point(396, 42)
        Me.bt_nuevoCliente.Name = "bt_nuevoCliente"
        Me.bt_nuevoCliente.Size = New System.Drawing.Size(75, 23)
        Me.bt_nuevoCliente.TabIndex = 37
        Me.bt_nuevoCliente.Text = "Nuevo"
        Me.bt_nuevoCliente.UseVisualStyleBackColor = True
        '
        'lb_Cliente
        '
        Me.lb_Cliente.AutoSize = True
        Me.lb_Cliente.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Cliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Cliente.Location = New System.Drawing.Point(46, 18)
        Me.lb_Cliente.Name = "lb_Cliente"
        Me.lb_Cliente.Size = New System.Drawing.Size(57, 18)
        Me.lb_Cliente.TabIndex = 36
        Me.lb_Cliente.Text = "Cliente"
        Me.lb_Cliente.Visible = False
        '
        'txt_Ramo
        '
        Me.txt_Ramo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ramo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Ramo.ForeColor = System.Drawing.Color.Black
        Me.txt_Ramo.Location = New System.Drawing.Point(124, 239)
        Me.txt_Ramo.Name = "txt_Ramo"
        Me.txt_Ramo.Size = New System.Drawing.Size(348, 26)
        Me.txt_Ramo.TabIndex = 34
        Me.txt_Ramo.Visible = False
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_Telefono.Location = New System.Drawing.Point(124, 207)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(348, 26)
        Me.txt_Telefono.TabIndex = 33
        Me.txt_Telefono.Visible = False
        '
        'txt_Estado
        '
        Me.txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Estado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Estado.ForeColor = System.Drawing.Color.Black
        Me.txt_Estado.Location = New System.Drawing.Point(124, 175)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.Size = New System.Drawing.Size(348, 26)
        Me.txt_Estado.TabIndex = 32
        Me.txt_Estado.Visible = False
        '
        'txt_Ciudad
        '
        Me.txt_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ciudad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Ciudad.ForeColor = System.Drawing.Color.Black
        Me.txt_Ciudad.Location = New System.Drawing.Point(124, 143)
        Me.txt_Ciudad.Name = "txt_Ciudad"
        Me.txt_Ciudad.Size = New System.Drawing.Size(348, 26)
        Me.txt_Ciudad.TabIndex = 31
        Me.txt_Ciudad.Visible = False
        '
        'txt_CP
        '
        Me.txt_CP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CP.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_CP.ForeColor = System.Drawing.Color.Black
        Me.txt_CP.Location = New System.Drawing.Point(381, 111)
        Me.txt_CP.Name = "txt_CP"
        Me.txt_CP.Size = New System.Drawing.Size(91, 26)
        Me.txt_CP.TabIndex = 30
        Me.txt_CP.Visible = False
        '
        'txt_Colonia
        '
        Me.txt_Colonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Colonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Colonia.ForeColor = System.Drawing.Color.Black
        Me.txt_Colonia.Location = New System.Drawing.Point(124, 111)
        Me.txt_Colonia.Name = "txt_Colonia"
        Me.txt_Colonia.Size = New System.Drawing.Size(200, 26)
        Me.txt_Colonia.TabIndex = 29
        Me.txt_Colonia.Visible = False
        '
        'txt_Domicilio
        '
        Me.txt_Domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Domicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Domicilio.ForeColor = System.Drawing.Color.Black
        Me.txt_Domicilio.Location = New System.Drawing.Point(124, 77)
        Me.txt_Domicilio.Name = "txt_Domicilio"
        Me.txt_Domicilio.Size = New System.Drawing.Size(348, 26)
        Me.txt_Domicilio.TabIndex = 28
        Me.txt_Domicilio.Visible = False
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(124, 45)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 26)
        Me.txt_Empresa.TabIndex = 27
        Me.txt_Empresa.Visible = False
        '
        'lb_CP
        '
        Me.lb_CP.AutoSize = True
        Me.lb_CP.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_CP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_CP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_CP.Location = New System.Drawing.Point(344, 119)
        Me.lb_CP.Name = "lb_CP"
        Me.lb_CP.Size = New System.Drawing.Size(31, 18)
        Me.lb_CP.TabIndex = 26
        Me.lb_CP.Text = "CP"
        Me.lb_CP.Visible = False
        '
        'lb_Ramo
        '
        Me.lb_Ramo.AutoSize = True
        Me.lb_Ramo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Ramo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ramo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ramo.Location = New System.Drawing.Point(16, 247)
        Me.lb_Ramo.Name = "lb_Ramo"
        Me.lb_Ramo.Size = New System.Drawing.Size(50, 18)
        Me.lb_Ramo.TabIndex = 25
        Me.lb_Ramo.Text = "Ramo"
        Me.lb_Ramo.Visible = False
        '
        'lb_Telefono
        '
        Me.lb_Telefono.AutoSize = True
        Me.lb_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Telefono.Location = New System.Drawing.Point(13, 215)
        Me.lb_Telefono.Name = "lb_Telefono"
        Me.lb_Telefono.Size = New System.Drawing.Size(66, 18)
        Me.lb_Telefono.TabIndex = 24
        Me.lb_Telefono.Text = "Teléfono"
        Me.lb_Telefono.Visible = False
        '
        'lb_Estado
        '
        Me.lb_Estado.AutoSize = True
        Me.lb_Estado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Estado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Estado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Estado.Location = New System.Drawing.Point(14, 183)
        Me.lb_Estado.Name = "lb_Estado"
        Me.lb_Estado.Size = New System.Drawing.Size(58, 18)
        Me.lb_Estado.TabIndex = 23
        Me.lb_Estado.Text = "Estado"
        Me.lb_Estado.Visible = False
        '
        'lb_Ciudad
        '
        Me.lb_Ciudad.AutoSize = True
        Me.lb_Ciudad.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Ciudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ciudad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ciudad.Location = New System.Drawing.Point(16, 151)
        Me.lb_Ciudad.Name = "lb_Ciudad"
        Me.lb_Ciudad.Size = New System.Drawing.Size(59, 18)
        Me.lb_Ciudad.TabIndex = 22
        Me.lb_Ciudad.Text = "Ciudad"
        Me.lb_Ciudad.Visible = False
        '
        'lb_Colonia
        '
        Me.lb_Colonia.AutoSize = True
        Me.lb_Colonia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Colonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Colonia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Colonia.Location = New System.Drawing.Point(16, 119)
        Me.lb_Colonia.Name = "lb_Colonia"
        Me.lb_Colonia.Size = New System.Drawing.Size(62, 18)
        Me.lb_Colonia.TabIndex = 21
        Me.lb_Colonia.Text = "Colonia"
        Me.lb_Colonia.Visible = False
        '
        'lb_Domicilio
        '
        Me.lb_Domicilio.AutoSize = True
        Me.lb_Domicilio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Domicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Domicilio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Domicilio.Location = New System.Drawing.Point(14, 85)
        Me.lb_Domicilio.Name = "lb_Domicilio"
        Me.lb_Domicilio.Size = New System.Drawing.Size(74, 18)
        Me.lb_Domicilio.TabIndex = 20
        Me.lb_Domicilio.Text = "Domicilio"
        Me.lb_Domicilio.Visible = False
        '
        'lb_Empresa
        '
        Me.lb_Empresa.AutoSize = True
        Me.lb_Empresa.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Empresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Empresa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Empresa.Location = New System.Drawing.Point(16, 50)
        Me.lb_Empresa.Name = "lb_Empresa"
        Me.lb_Empresa.Size = New System.Drawing.Size(72, 18)
        Me.lb_Empresa.TabIndex = 19
        Me.lb_Empresa.Text = "Empresa"
        Me.lb_Empresa.Visible = False
        '
        'cb_Cliente
        '
        Me.cb_Cliente.FormattingEnabled = True
        Me.cb_Cliente.Location = New System.Drawing.Point(125, 15)
        Me.cb_Cliente.Name = "cb_Cliente"
        Me.cb_Cliente.Size = New System.Drawing.Size(346, 21)
        Me.cb_Cliente.TabIndex = 1
        '
        'fr_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 427)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Ayuda As System.Windows.Forms.Button
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_finalizar As System.Windows.Forms.Button
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cb_Cliente As System.Windows.Forms.ComboBox
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
    Friend WithEvents lb_Ciudad As System.Windows.Forms.Label
    Friend WithEvents lb_Colonia As System.Windows.Forms.Label
    Friend WithEvents lb_Domicilio As System.Windows.Forms.Label
    Friend WithEvents lb_Empresa As System.Windows.Forms.Label
    Friend WithEvents bt_nuevoCliente As System.Windows.Forms.Button
    Friend WithEvents lb_Cliente As System.Windows.Forms.Label
End Class
