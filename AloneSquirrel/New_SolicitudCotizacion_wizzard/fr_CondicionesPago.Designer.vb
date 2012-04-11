<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_CondicionesPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_CondicionesPago))
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.txt_Radio = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.txt_Ext = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lb_Correo = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_Telefono = New System.Windows.Forms.Label()
        Me.lb_Ext = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lb_Celular = New System.Windows.Forms.Label()
        Me.lb_Radio = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Correo
        '
        Me.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Correo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Correo.ForeColor = System.Drawing.Color.Black
        Me.txt_Correo.Location = New System.Drawing.Point(145, 220)
        Me.txt_Correo.Multiline = True
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(326, 86)
        Me.txt_Correo.TabIndex = 51
        '
        'txt_Radio
        '
        Me.txt_Radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Radio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Radio.ForeColor = System.Drawing.Color.Black
        Me.txt_Radio.Location = New System.Drawing.Point(145, 178)
        Me.txt_Radio.Name = "txt_Radio"
        Me.txt_Radio.Size = New System.Drawing.Size(326, 26)
        Me.txt_Radio.TabIndex = 50
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
        Me.Panel1.TabIndex = 7
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
        Me.bt_finalizar.Location = New System.Drawing.Point(324, 16)
        Me.bt_finalizar.Name = "bt_finalizar"
        Me.bt_finalizar.Size = New System.Drawing.Size(75, 23)
        Me.bt_finalizar.TabIndex = 2
        Me.bt_finalizar.Text = "Finalizar >>"
        Me.bt_finalizar.UseVisualStyleBackColor = True
        '
        'bt_Siguiente
        '
        Me.bt_Siguiente.Enabled = False
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
        'txt_Celular
        '
        Me.txt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Celular.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Celular.ForeColor = System.Drawing.Color.Black
        Me.txt_Celular.Location = New System.Drawing.Point(111, 139)
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(360, 26)
        Me.txt_Celular.TabIndex = 49
        '
        'txt_Ext
        '
        Me.txt_Ext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ext.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Ext.ForeColor = System.Drawing.Color.Black
        Me.txt_Ext.Location = New System.Drawing.Point(111, 98)
        Me.txt_Ext.Name = "txt_Ext"
        Me.txt_Ext.Size = New System.Drawing.Size(360, 26)
        Me.txt_Ext.TabIndex = 48
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_Telefono.Location = New System.Drawing.Point(111, 56)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(360, 26)
        Me.txt_Telefono.TabIndex = 47
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
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(111, 15)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(360, 26)
        Me.txt_Nombre.TabIndex = 46
        '
        'lb_Correo
        '
        Me.lb_Correo.AutoSize = True
        Me.lb_Correo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Correo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Correo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Correo.Location = New System.Drawing.Point(17, 228)
        Me.lb_Correo.Name = "lb_Correo"
        Me.lb_Correo.Size = New System.Drawing.Size(113, 18)
        Me.lb_Correo.TabIndex = 44
        Me.lb_Correo.Text = "Observaciones"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Nombre.Location = New System.Drawing.Point(17, 23)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(83, 18)
        Me.lb_Nombre.TabIndex = 42
        Me.lb_Nombre.Text = "Anticipo %"
        '
        'lb_Telefono
        '
        Me.lb_Telefono.AutoSize = True
        Me.lb_Telefono.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Telefono.Location = New System.Drawing.Point(17, 64)
        Me.lb_Telefono.Name = "lb_Telefono"
        Me.lb_Telefono.Size = New System.Drawing.Size(67, 18)
        Me.lb_Telefono.TabIndex = 41
        Me.lb_Telefono.Text = "Resto %"
        '
        'lb_Ext
        '
        Me.lb_Ext.AutoSize = True
        Me.lb_Ext.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Ext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ext.Location = New System.Drawing.Point(17, 106)
        Me.lb_Ext.Name = "lb_Ext"
        Me.lb_Ext.Size = New System.Drawing.Size(60, 18)
        Me.lb_Ext.TabIndex = 40
        Me.lb_Ext.Text = "Credito"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_Correo)
        Me.Panel3.Controls.Add(Me.txt_Radio)
        Me.Panel3.Controls.Add(Me.txt_Celular)
        Me.Panel3.Controls.Add(Me.txt_Ext)
        Me.Panel3.Controls.Add(Me.txt_Telefono)
        Me.Panel3.Controls.Add(Me.txt_Nombre)
        Me.Panel3.Controls.Add(Me.lb_Correo)
        Me.Panel3.Controls.Add(Me.lb_Nombre)
        Me.Panel3.Controls.Add(Me.lb_Telefono)
        Me.Panel3.Controls.Add(Me.lb_Ext)
        Me.Panel3.Controls.Add(Me.lb_Celular)
        Me.Panel3.Controls.Add(Me.lb_Radio)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(483, 367)
        Me.Panel3.TabIndex = 9
        '
        'lb_Celular
        '
        Me.lb_Celular.AutoSize = True
        Me.lb_Celular.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Celular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Celular.Location = New System.Drawing.Point(17, 147)
        Me.lb_Celular.Name = "lb_Celular"
        Me.lb_Celular.Size = New System.Drawing.Size(68, 18)
        Me.lb_Celular.TabIndex = 39
        Me.lb_Celular.Text = "Contado"
        '
        'lb_Radio
        '
        Me.lb_Radio.AutoSize = True
        Me.lb_Radio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Radio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Radio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Radio.Location = New System.Drawing.Point(17, 186)
        Me.lb_Radio.Name = "lb_Radio"
        Me.lb_Radio.Size = New System.Drawing.Size(122, 18)
        Me.lb_Radio.TabIndex = 38
        Me.lb_Radio.Text = "Tiempo de pago"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 60)
        Me.Panel2.TabIndex = 8
        '
        'fr_CondicionesPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_CondicionesPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_CondicionesPago"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Correo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Radio As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Ayuda As System.Windows.Forms.Button
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_finalizar As System.Windows.Forms.Button
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents txt_Celular As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ext As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lb_Correo As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_Telefono As System.Windows.Forms.Label
    Friend WithEvents lb_Ext As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lb_Celular As System.Windows.Forms.Label
    Friend WithEvents lb_Radio As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
