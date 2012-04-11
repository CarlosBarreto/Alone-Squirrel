<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Servicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_Servicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Ayuda = New System.Windows.Forms.Button()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_finalizar = New System.Windows.Forms.Button()
        Me.bt_Siguiente = New System.Windows.Forms.Button()
        Me.bt_Anterior = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_Entrega = New System.Windows.Forms.TextBox()
        Me.lb_Entrega = New System.Windows.Forms.Label()
        Me.txt_Solicitud = New System.Windows.Forms.TextBox()
        Me.txt_Servicio = New System.Windows.Forms.TextBox()
        Me.lb_Servicio = New System.Windows.Forms.Label()
        Me.lb_Solicitud = New System.Windows.Forms.Label()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 55)
        Me.Panel1.TabIndex = 6
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
        Me.Panel2.TabIndex = 7
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
        Me.Panel3.Controls.Add(Me.txt_Entrega)
        Me.Panel3.Controls.Add(Me.lb_Entrega)
        Me.Panel3.Controls.Add(Me.txt_Solicitud)
        Me.Panel3.Controls.Add(Me.txt_Servicio)
        Me.Panel3.Controls.Add(Me.lb_Servicio)
        Me.Panel3.Controls.Add(Me.lb_Solicitud)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(483, 298)
        Me.Panel3.TabIndex = 8
        '
        'txt_Entrega
        '
        Me.txt_Entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txt_Servicio.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txt_Servicio.ForeColor = System.Drawing.Color.Black
        Me.txt_Servicio.Location = New System.Drawing.Point(94, 41)
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.Size = New System.Drawing.Size(360, 26)
        Me.txt_Servicio.TabIndex = 50
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
        'fr_Servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 413)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fr_Servicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fr_Servicio"
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
    Friend WithEvents txt_Solicitud As System.Windows.Forms.TextBox
    Friend WithEvents txt_Servicio As System.Windows.Forms.TextBox
    Friend WithEvents lb_Servicio As System.Windows.Forms.Label
    Friend WithEvents lb_Solicitud As System.Windows.Forms.Label
    Friend WithEvents txt_Entrega As System.Windows.Forms.TextBox
    Friend WithEvents lb_Entrega As System.Windows.Forms.Label
End Class
