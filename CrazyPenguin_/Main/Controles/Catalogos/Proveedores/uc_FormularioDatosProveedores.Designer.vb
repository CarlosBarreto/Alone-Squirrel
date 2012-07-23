<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_FormularioDatosProveedores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDProveedor = New Main.TextBoxExt()
        Me.txt_RFC = New Main.TextBoxExt()
        Me.txt_Telefono = New Main.TextBoxExt()
        Me.txt_Estado = New Main.TextBoxExt()
        Me.txt_Ciudad = New Main.TextBoxExt()
        Me.txt_CP = New Main.TextBoxExt()
        Me.txt_Colonia = New Main.TextBoxExt()
        Me.txt_Domicilio = New Main.TextBoxExt()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New Main.TextBoxExt()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_EmailRepresentante = New Main.TextBoxExt()
        Me.txt_CargoRepresentante = New Main.TextBoxExt()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_NombreRepresentante = New Main.TextBoxExt()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(579, 34)
        Me.Panel1.TabIndex = 60
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_IDProveedor)
        Me.GroupBox1.Controls.Add(Me.txt_RFC)
        Me.GroupBox1.Controls.Add(Me.txt_Telefono)
        Me.GroupBox1.Controls.Add(Me.txt_Estado)
        Me.GroupBox1.Controls.Add(Me.txt_Ciudad)
        Me.GroupBox1.Controls.Add(Me.txt_CP)
        Me.GroupBox1.Controls.Add(Me.txt_Colonia)
        Me.GroupBox1.Controls.Add(Me.txt_Domicilio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 272)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Datos Generales "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ID"
        Me.Label1.Visible = False
        '
        'txt_IDProveedor
        '
        Me.txt_IDProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_IDProveedor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDProveedor.ForeColor = System.Drawing.Color.Black
        Me.txt_IDProveedor.Location = New System.Drawing.Point(130, 27)
        Me.txt_IDProveedor.Name = "txt_IDProveedor"
        Me.txt_IDProveedor.Size = New System.Drawing.Size(132, 22)
        Me.txt_IDProveedor.TabIndex = 77
        Me.txt_IDProveedor.Type = Main.TextBoxExt.ValidType.Alpha
        Me.txt_IDProveedor.Visible = False
        '
        'txt_RFC
        '
        Me.txt_RFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RFC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RFC.ForeColor = System.Drawing.Color.Black
        Me.txt_RFC.Location = New System.Drawing.Point(130, 237)
        Me.txt_RFC.Name = "txt_RFC"
        Me.txt_RFC.Size = New System.Drawing.Size(348, 22)
        Me.txt_RFC.TabIndex = 76
        Me.txt_RFC.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_Telefono.Location = New System.Drawing.Point(130, 207)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(348, 22)
        Me.txt_Telefono.TabIndex = 75
        Me.txt_Telefono.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Estado
        '
        Me.txt_Estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Estado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Estado.ForeColor = System.Drawing.Color.Black
        Me.txt_Estado.Location = New System.Drawing.Point(130, 178)
        Me.txt_Estado.Name = "txt_Estado"
        Me.txt_Estado.Size = New System.Drawing.Size(348, 22)
        Me.txt_Estado.TabIndex = 74
        Me.txt_Estado.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_Ciudad
        '
        Me.txt_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ciudad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ciudad.ForeColor = System.Drawing.Color.Black
        Me.txt_Ciudad.Location = New System.Drawing.Point(130, 148)
        Me.txt_Ciudad.Name = "txt_Ciudad"
        Me.txt_Ciudad.Size = New System.Drawing.Size(348, 22)
        Me.txt_Ciudad.TabIndex = 73
        Me.txt_Ciudad.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_CP
        '
        Me.txt_CP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CP.ForeColor = System.Drawing.Color.Black
        Me.txt_CP.Location = New System.Drawing.Point(387, 118)
        Me.txt_CP.Name = "txt_CP"
        Me.txt_CP.Size = New System.Drawing.Size(91, 22)
        Me.txt_CP.TabIndex = 72
        Me.txt_CP.Type = Main.TextBoxExt.ValidType.Number
        '
        'txt_Colonia
        '
        Me.txt_Colonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Colonia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Colonia.ForeColor = System.Drawing.Color.Black
        Me.txt_Colonia.Location = New System.Drawing.Point(130, 118)
        Me.txt_Colonia.Name = "txt_Colonia"
        Me.txt_Colonia.Size = New System.Drawing.Size(200, 22)
        Me.txt_Colonia.TabIndex = 71
        Me.txt_Colonia.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_Domicilio
        '
        Me.txt_Domicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Domicilio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Domicilio.ForeColor = System.Drawing.Color.Black
        Me.txt_Domicilio.Location = New System.Drawing.Point(130, 87)
        Me.txt_Domicilio.Name = "txt_Domicilio"
        Me.txt_Domicilio.Size = New System.Drawing.Size(348, 22)
        Me.txt_Domicilio.TabIndex = 70
        Me.txt_Domicilio.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(11, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 18)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(11, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(11, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(11, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Colonia"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(130, 56)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(348, 22)
        Me.txt_Nombre.TabIndex = 69
        Me.txt_Nombre.Type = Main.TextBoxExt.ValidType.Text
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(345, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 18)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "CP"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(11, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(11, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Nombre"
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
        Me.GroupBox2.Location = New System.Drawing.Point(35, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 132)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Representante "
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
        Me.Label12.Text = "Email"
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
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(13, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 18)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Cargo"
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
        'uc_FormularioDatosProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_FormularioDatosProveedores"
        Me.Size = New System.Drawing.Size(579, 480)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    'Panels & GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

    'Buttons
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents bt_Guardar As System.Windows.Forms.Button

    'Labels
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

    'TextBoxes
    Friend WithEvents txt_Ciudad As Main.TextBoxExt
    Friend WithEvents txt_Colonia As Main.TextBoxExt
    Friend WithEvents txt_CP As Main.TextBoxExt
    Friend WithEvents txt_Domicilio As Main.TextBoxExt
    Friend WithEvents txt_Estado As Main.TextBoxExt
    Friend WithEvents txt_IDProveedor As Main.TextBoxExt
    Friend WithEvents txt_Nombre As Main.TextBoxExt
    Friend WithEvents txt_RFC As Main.TextBoxExt
    Friend WithEvents txt_Telefono As Main.TextBoxExt

    Friend WithEvents txt_CargoRepresentante As Main.TextBoxExt
    Friend WithEvents txt_EmailRepresentante As Main.TextBoxExt
    Friend WithEvents txt_NombreRepresentante As Main.TextBoxExt

End Class
