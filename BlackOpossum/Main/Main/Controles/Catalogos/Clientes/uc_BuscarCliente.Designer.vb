<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_BuscarCliente
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NumeroCliente = New System.Windows.Forms.TextBox()
        Me.txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_Buscar = New System.Windows.Forms.Button()
        Me.bt_Options = New System.Windows.Forms.Button()
        Me.lb_Desc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(35, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Número de Cliente"
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(154, 189)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_NumeroCliente.TabIndex = 42
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(154, 219)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 22)
        Me.txt_Empresa.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(35, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Empresa"
        '
        'bt_Buscar
        '
        Me.bt_Buscar.Location = New System.Drawing.Point(427, 247)
        Me.bt_Buscar.Name = "bt_Buscar"
        Me.bt_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Buscar.TabIndex = 43
        Me.bt_Buscar.Text = "Buscar"
        Me.bt_Buscar.UseVisualStyleBackColor = True
        '
        'bt_Options
        '
        Me.bt_Options.Location = New System.Drawing.Point(292, 188)
        Me.bt_Options.Name = "bt_Options"
        Me.bt_Options.Size = New System.Drawing.Size(24, 23)
        Me.bt_Options.TabIndex = 44
        Me.bt_Options.Text = " > "
        Me.bt_Options.UseVisualStyleBackColor = True
        '
        'lb_Desc
        '
        Me.lb_Desc.AutoSize = True
        Me.lb_Desc.Location = New System.Drawing.Point(35, 158)
        Me.lb_Desc.Name = "lb_Desc"
        Me.lb_Desc.Size = New System.Drawing.Size(139, 13)
        Me.lb_Desc.TabIndex = 45
        Me.lb_Desc.Text = "Buscar el cliente a modificar"
        '
        'uc_BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lb_Desc)
        Me.Controls.Add(Me.bt_Options)
        Me.Controls.Add(Me.bt_Buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_NumeroCliente)
        Me.Controls.Add(Me.txt_Empresa)
        Me.Controls.Add(Me.Label2)
        Me.Name = "uc_BuscarCliente"
        Me.Size = New System.Drawing.Size(536, 431)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_NumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_Buscar As System.Windows.Forms.Button
    Friend WithEvents bt_Options As System.Windows.Forms.Button
    Friend WithEvents lb_Desc As System.Windows.Forms.Label

End Class
