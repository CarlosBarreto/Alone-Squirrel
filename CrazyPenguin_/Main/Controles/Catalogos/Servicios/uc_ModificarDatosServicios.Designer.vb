<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_ModificarDatosServicios
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
        Me.txt_EmailRepresentante = New Main.TextBoxExt()
        Me.txt_CargoRepresentante = New Main.TextBoxExt()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_NombreRepresentante = New Main.TextBoxExt()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_EmailRepresentante
        '
        Me.txt_EmailRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EmailRepresentante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmailRepresentante.ForeColor = System.Drawing.Color.Black
        Me.txt_EmailRepresentante.Location = New System.Drawing.Point(132, 100)
        Me.txt_EmailRepresentante.Name = "txt_EmailRepresentante"
        Me.txt_EmailRepresentante.Size = New System.Drawing.Size(348, 22)
        Me.txt_EmailRepresentante.TabIndex = 74
        Me.txt_EmailRepresentante.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_CargoRepresentante
        '
        Me.txt_CargoRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CargoRepresentante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CargoRepresentante.ForeColor = System.Drawing.Color.Black
        Me.txt_CargoRepresentante.Location = New System.Drawing.Point(132, 66)
        Me.txt_CargoRepresentante.Name = "txt_CargoRepresentante"
        Me.txt_CargoRepresentante.Size = New System.Drawing.Size(348, 22)
        Me.txt_CargoRepresentante.TabIndex = 70
        Me.txt_CargoRepresentante.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(13, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Fecha:"
        '
        'txt_NombreRepresentante
        '
        Me.txt_NombreRepresentante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NombreRepresentante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreRepresentante.ForeColor = System.Drawing.Color.Black
        Me.txt_NombreRepresentante.Location = New System.Drawing.Point(132, 35)
        Me.txt_NombreRepresentante.Name = "txt_NombreRepresentante"
        Me.txt_NombreRepresentante.Size = New System.Drawing.Size(348, 22)
        Me.txt_NombreRepresentante.TabIndex = 69
        Me.txt_NombreRepresentante.Type = Main.TextBoxExt.ValidType.Text
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
        Me.Panel1.Size = New System.Drawing.Size(508, 34)
        Me.Panel1.TabIndex = 66
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_EmailRepresentante)
        Me.GroupBox2.Controls.Add(Me.txt_CargoRepresentante)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_NombreRepresentante)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 132)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicio"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(13, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 18)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Descripción:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(13, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Nombre"
        '
        'uc_ModificarDatosServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "uc_ModificarDatosServicios"
        Me.Size = New System.Drawing.Size(508, 193)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_EmailRepresentante As Main.TextBoxExt
    Friend WithEvents txt_CargoRepresentante As Main.TextBoxExt
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreRepresentante As Main.TextBoxExt
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
