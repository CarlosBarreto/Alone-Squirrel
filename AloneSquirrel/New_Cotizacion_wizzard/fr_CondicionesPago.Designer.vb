<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_CondicionesPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_CondicionesPago))
        Me.txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.lb_Correo = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_Telefono = New System.Windows.Forms.Label()
        Me.lb_Ext = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cb_Condiciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TipoPago = New System.Windows.Forms.TextBox()
        Me.txt_Contado = New System.Windows.Forms.TextBox()
        Me.txt_Credito = New System.Windows.Forms.TextBox()
        Me.txt_Resto = New System.Windows.Forms.TextBox()
        Me.txt_Anticipo = New System.Windows.Forms.TextBox()
        Me.lb_Celular = New System.Windows.Forms.Label()
        Me.lb_Radio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Observaciones.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Observaciones.ForeColor = System.Drawing.Color.Black
        Me.txt_Observaciones.Location = New System.Drawing.Point(145, 220)
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(326, 86)
        Me.txt_Observaciones.TabIndex = 51
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
        Me.lb_Nombre.Location = New System.Drawing.Point(17, 64)
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
        Me.lb_Telefono.Location = New System.Drawing.Point(268, 64)
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
        Me.lb_Ext.Location = New System.Drawing.Point(17, 111)
        Me.lb_Ext.Name = "lb_Ext"
        Me.lb_Ext.Size = New System.Drawing.Size(60, 18)
        Me.lb_Ext.TabIndex = 40
        Me.lb_Ext.Text = "Credito"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cb_Condiciones)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_Observaciones)
        Me.Panel3.Controls.Add(Me.txt_TipoPago)
        Me.Panel3.Controls.Add(Me.txt_Contado)
        Me.Panel3.Controls.Add(Me.txt_Credito)
        Me.Panel3.Controls.Add(Me.txt_Resto)
        Me.Panel3.Controls.Add(Me.txt_Anticipo)
        Me.Panel3.Controls.Add(Me.lb_Correo)
        Me.Panel3.Controls.Add(Me.lb_Nombre)
        Me.Panel3.Controls.Add(Me.lb_Telefono)
        Me.Panel3.Controls.Add(Me.lb_Ext)
        Me.Panel3.Controls.Add(Me.lb_Celular)
        Me.Panel3.Controls.Add(Me.lb_Radio)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(483, 312)
        Me.Panel3.TabIndex = 12
        '
        'cb_Condiciones
        '
        Me.cb_Condiciones.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cb_Condiciones.FormattingEnabled = True
        Me.cb_Condiciones.Location = New System.Drawing.Point(171, 21)
        Me.cb_Condiciones.Name = "cb_Condiciones"
        Me.cb_Condiciones.Size = New System.Drawing.Size(300, 26)
        Me.cb_Condiciones.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Condiones de Pago"
        '
        'txt_TipoPago
        '
        Me.txt_TipoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TipoPago.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_TipoPago.ForeColor = System.Drawing.Color.Black
        Me.txt_TipoPago.Location = New System.Drawing.Point(145, 178)
        Me.txt_TipoPago.Name = "txt_TipoPago"
        Me.txt_TipoPago.Size = New System.Drawing.Size(326, 26)
        Me.txt_TipoPago.TabIndex = 50
        '
        'txt_Contado
        '
        Me.txt_Contado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Contado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Contado.ForeColor = System.Drawing.Color.Black
        Me.txt_Contado.Location = New System.Drawing.Point(111, 139)
        Me.txt_Contado.Name = "txt_Contado"
        Me.txt_Contado.Size = New System.Drawing.Size(360, 26)
        Me.txt_Contado.TabIndex = 49
        '
        'txt_Credito
        '
        Me.txt_Credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Credito.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Credito.ForeColor = System.Drawing.Color.Black
        Me.txt_Credito.Location = New System.Drawing.Point(111, 103)
        Me.txt_Credito.Name = "txt_Credito"
        Me.txt_Credito.Size = New System.Drawing.Size(360, 26)
        Me.txt_Credito.TabIndex = 48
        '
        'txt_Resto
        '
        Me.txt_Resto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Resto.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Resto.ForeColor = System.Drawing.Color.Black
        Me.txt_Resto.Location = New System.Drawing.Point(341, 62)
        Me.txt_Resto.Name = "txt_Resto"
        Me.txt_Resto.Size = New System.Drawing.Size(130, 26)
        Me.txt_Resto.TabIndex = 47
        '
        'txt_Anticipo
        '
        Me.txt_Anticipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Anticipo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Anticipo.ForeColor = System.Drawing.Color.Black
        Me.txt_Anticipo.Location = New System.Drawing.Point(111, 62)
        Me.txt_Anticipo.Name = "txt_Anticipo"
        Me.txt_Anticipo.Size = New System.Drawing.Size(130, 26)
        Me.txt_Anticipo.TabIndex = 46
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
        'bt_Ayuda
        '
        Me.bt_Ayuda.Location = New System.Drawing.Point(12, 16)
        Me.bt_Ayuda.Name = "bt_Ayuda"
        Me.bt_Ayuda.Size = New System.Drawing.Size(75, 23)
        Me.bt_Ayuda.TabIndex = 4
        Me.bt_Ayuda.Text = "Ayuda"
        Me.bt_Ayuda.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 10
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 60)
        Me.Panel2.TabIndex = 11
        '
        'fr_CondicionesPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 427)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_CondicionesPago"
        Me.Text = "fr_CondicionesPago"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents lb_Correo As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_Telefono As System.Windows.Forms.Label
    Friend WithEvents lb_Ext As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cb_Condiciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoPago As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contado As System.Windows.Forms.TextBox
    Friend WithEvents txt_Credito As System.Windows.Forms.TextBox
    Friend WithEvents txt_Resto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Anticipo As System.Windows.Forms.TextBox
    Friend WithEvents lb_Celular As System.Windows.Forms.Label
    Friend WithEvents lb_Radio As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bt_Ayuda As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_finalizar As System.Windows.Forms.Button
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
