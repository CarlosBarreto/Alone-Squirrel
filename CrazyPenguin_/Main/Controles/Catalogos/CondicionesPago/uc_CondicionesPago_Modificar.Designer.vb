<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CondicionesPago_Modificar
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
        Me.TextBoxExt2 = New Main.TextBoxExt()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxExt1 = New Main.TextBoxExt()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.txt_NumeroCliente = New Main.TextBoxExt()
        Me.txt_Empresa = New Main.TextBoxExt()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxExt2
        '
        Me.TextBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExt2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxExt2.Location = New System.Drawing.Point(126, 139)
        Me.TextBoxExt2.Name = "TextBoxExt2"
        Me.TextBoxExt2.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxExt2.TabIndex = 59
        Me.TextBoxExt2.Type = Main.TextBoxExt.ValidType.Text
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Resto"
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxExt1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxExt1.Location = New System.Drawing.Point(126, 110)
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxExt1.TabIndex = 57
        Me.TextBoxExt1.Type = Main.TextBoxExt.ValidType.Text
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Anticipo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.bt_Cancelar)
        Me.Panel1.Controls.Add(Me.bt_Guardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 34)
        Me.Panel1.TabIndex = 55
        '
        'bt_Cancelar
        '
        Me.bt_Cancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.bt_Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Cancelar.Location = New System.Drawing.Point(103, 3)
        Me.bt_Cancelar.Name = "bt_Cancelar"
        Me.bt_Cancelar.Size = New System.Drawing.Size(89, 22)
        Me.bt_Cancelar.TabIndex = 42
        Me.bt_Cancelar.Text = "&Cancelar"
        Me.bt_Cancelar.UseVisualStyleBackColor = True
        '
        'bt_Guardar
        '
        Me.bt_Guardar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Guardar.ForeColor = System.Drawing.Color.Black
        Me.bt_Guardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Guardar.Location = New System.Drawing.Point(8, 3)
        Me.bt_Guardar.Name = "bt_Guardar"
        Me.bt_Guardar.Size = New System.Drawing.Size(89, 22)
        Me.bt_Guardar.TabIndex = 41
        Me.bt_Guardar.Text = "&Guardar"
        Me.bt_Guardar.UseVisualStyleBackColor = True
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(126, 52)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_NumeroCliente.TabIndex = 54
        Me.txt_NumeroCliente.Type = Main.TextBoxExt.ValidType.Alpha
        Me.txt_NumeroCliente.Visible = False
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(126, 82)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 22)
        Me.txt_Empresa.TabIndex = 53
        Me.txt_Empresa.Type = Main.TextBoxExt.ValidType.Text
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Condición ID"
        Me.Label1.Visible = False
        '
        'uc_CondicionesPago_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TextBoxExt2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxExt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_NumeroCliente)
        Me.Controls.Add(Me.txt_Empresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_CondicionesPago_Modificar"
        Me.Size = New System.Drawing.Size(499, 312)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxExt2 As Main.TextBoxExt
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxExt1 As Main.TextBoxExt
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents txt_NumeroCliente As Main.TextBoxExt
    Friend WithEvents txt_Empresa As Main.TextBoxExt
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
