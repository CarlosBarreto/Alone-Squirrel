<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Servicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_Servicio))
        Me.lb_Servicio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bt_Editar = New System.Windows.Forms.Button()
        Me.txt_Entrega = New System.Windows.Forms.TextBox()
        Me.lb_Entrega = New System.Windows.Forms.Label()
        Me.txt_Solicitud = New System.Windows.Forms.TextBox()
        Me.txt_Servicio = New System.Windows.Forms.TextBox()
        Me.lb_Solicitud = New System.Windows.Forms.Label()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_Servicio
        '
        Me.lb_Servicio.AutoSize = True
        Me.lb_Servicio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Servicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Servicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Servicio.Location = New System.Drawing.Point(15, 43)
        Me.lb_Servicio.Name = "lb_Servicio"
        Me.lb_Servicio.Size = New System.Drawing.Size(65, 18)
        Me.lb_Servicio.TabIndex = 49
        Me.lb_Servicio.Text = "Servicio"
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bt_Editar)
        Me.Panel3.Controls.Add(Me.txt_Entrega)
        Me.Panel3.Controls.Add(Me.lb_Entrega)
        Me.Panel3.Controls.Add(Me.txt_Solicitud)
        Me.Panel3.Controls.Add(Me.txt_Servicio)
        Me.Panel3.Controls.Add(Me.lb_Servicio)
        Me.Panel3.Controls.Add(Me.lb_Solicitud)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(493, 326)
        Me.Panel3.TabIndex = 11
        '
        'bt_Editar
        '
        Me.bt_Editar.Location = New System.Drawing.Point(379, 138)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Editar.TabIndex = 12
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseVisualStyleBackColor = True
        '
        'txt_Entrega
        '
        Me.txt_Entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Entrega.Enabled = False
        Me.txt_Entrega.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Entrega.ForeColor = System.Drawing.Color.Black
        Me.txt_Entrega.Location = New System.Drawing.Point(317, 86)
        Me.txt_Entrega.Name = "txt_Entrega"
        Me.txt_Entrega.Size = New System.Drawing.Size(137, 26)
        Me.txt_Entrega.TabIndex = 53
        '
        'lb_Entrega
        '
        Me.lb_Entrega.AutoSize = True
        Me.lb_Entrega.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Entrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Entrega.Location = New System.Drawing.Point(246, 88)
        Me.lb_Entrega.Name = "lb_Entrega"
        Me.lb_Entrega.Size = New System.Drawing.Size(63, 18)
        Me.lb_Entrega.TabIndex = 52
        Me.lb_Entrega.Text = "Entrega"
        '
        'txt_Solicitud
        '
        Me.txt_Solicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Solicitud.Enabled = False
        Me.txt_Solicitud.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Solicitud.ForeColor = System.Drawing.Color.Black
        Me.txt_Solicitud.Location = New System.Drawing.Point(94, 86)
        Me.txt_Solicitud.Name = "txt_Solicitud"
        Me.txt_Solicitud.Size = New System.Drawing.Size(137, 26)
        Me.txt_Solicitud.TabIndex = 51
        '
        'txt_Servicio
        '
        Me.txt_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Servicio.Enabled = False
        Me.txt_Servicio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Servicio.ForeColor = System.Drawing.Color.Black
        Me.txt_Servicio.Location = New System.Drawing.Point(94, 41)
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.Size = New System.Drawing.Size(360, 26)
        Me.txt_Servicio.TabIndex = 50
        '
        'lb_Solicitud
        '
        Me.lb_Solicitud.AutoSize = True
        Me.lb_Solicitud.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lb_Solicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Solicitud.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Solicitud.Location = New System.Drawing.Point(15, 88)
        Me.lb_Solicitud.Name = "lb_Solicitud"
        Me.lb_Solicitud.Size = New System.Drawing.Size(68, 18)
        Me.lb_Solicitud.TabIndex = 48
        Me.lb_Solicitud.Text = "Solicitud"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 60)
        Me.Panel2.TabIndex = 10
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
        'bt_Anterior
        '
        Me.bt_Anterior.Location = New System.Drawing.Point(162, 16)
        Me.bt_Anterior.Name = "bt_Anterior"
        Me.bt_Anterior.Size = New System.Drawing.Size(75, 23)
        Me.bt_Anterior.TabIndex = 0
        Me.bt_Anterior.Text = "< Anterior"
        Me.bt_Anterior.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 9
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
        'fr_Servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 441)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_Servicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_Servicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lb_Servicio As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bt_Ayuda As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_Entrega As System.Windows.Forms.TextBox
    Friend WithEvents lb_Entrega As System.Windows.Forms.Label
    Friend WithEvents txt_Solicitud As System.Windows.Forms.TextBox
    Friend WithEvents txt_Servicio As System.Windows.Forms.TextBox
    Friend WithEvents lb_Solicitud As System.Windows.Forms.Label
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt_finalizar As System.Windows.Forms.Button
    Friend WithEvents bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents bt_Editar As System.Windows.Forms.Button
End Class
