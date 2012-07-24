<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Material_Modificar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.txt_Padre = New Main.TextBoxExt()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Costo = New Main.TextBoxExt()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_UnidadPeso = New Main.TextBoxExt()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Peso = New Main.TextBoxExt()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Alto = New Main.TextBoxExt()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Largo = New Main.TextBoxExt()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Ancho = New Main.TextBoxExt()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Unidad = New Main.TextBoxExt()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New Main.TextBoxExt()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_MaterialID = New Main.TextBoxExt()
        Me.txt_Nombre = New Main.TextBoxExt()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.bt_Cancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dt_Material = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Padre
        '
        Me.txt_Padre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Padre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Padre.ForeColor = System.Drawing.Color.Black
        Me.txt_Padre.Location = New System.Drawing.Point(134, 349)
        Me.txt_Padre.Name = "txt_Padre"
        Me.txt_Padre.Size = New System.Drawing.Size(132, 22)
        Me.txt_Padre.TabIndex = 74
        Me.txt_Padre.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dt_Material)
        Me.GroupBox1.Controls.Add(Me.txt_Padre)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_Costo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_UnidadPeso)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_Peso)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Alto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_Largo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Ancho)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_Unidad)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Descripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_MaterialID)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 382)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Condiciones de Pago "
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(15, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Padre"
        '
        'txt_Costo
        '
        Me.txt_Costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Costo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Costo.ForeColor = System.Drawing.Color.Black
        Me.txt_Costo.Location = New System.Drawing.Point(134, 321)
        Me.txt_Costo.Name = "txt_Costo"
        Me.txt_Costo.Size = New System.Drawing.Size(132, 22)
        Me.txt_Costo.TabIndex = 72
        Me.txt_Costo.Type = Main.TextBoxExt.ValidType.Number
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(15, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Costo Unitario"
        '
        'txt_UnidadPeso
        '
        Me.txt_UnidadPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_UnidadPeso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UnidadPeso.ForeColor = System.Drawing.Color.Black
        Me.txt_UnidadPeso.Location = New System.Drawing.Point(134, 290)
        Me.txt_UnidadPeso.Name = "txt_UnidadPeso"
        Me.txt_UnidadPeso.Size = New System.Drawing.Size(328, 22)
        Me.txt_UnidadPeso.TabIndex = 70
        Me.txt_UnidadPeso.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(15, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 18)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Unidad de Peso"
        '
        'txt_Peso
        '
        Me.txt_Peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Peso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Peso.ForeColor = System.Drawing.Color.Black
        Me.txt_Peso.Location = New System.Drawing.Point(134, 261)
        Me.txt_Peso.Name = "txt_Peso"
        Me.txt_Peso.Size = New System.Drawing.Size(132, 22)
        Me.txt_Peso.TabIndex = 68
        Me.txt_Peso.Type = Main.TextBoxExt.ValidType.Number
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(15, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Peso"
        '
        'txt_Alto
        '
        Me.txt_Alto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Alto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Alto.ForeColor = System.Drawing.Color.Black
        Me.txt_Alto.Location = New System.Drawing.Point(134, 233)
        Me.txt_Alto.Name = "txt_Alto"
        Me.txt_Alto.Size = New System.Drawing.Size(132, 22)
        Me.txt_Alto.TabIndex = 66
        Me.txt_Alto.Type = Main.TextBoxExt.ValidType.Number
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(15, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Alto"
        '
        'txt_Largo
        '
        Me.txt_Largo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Largo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Largo.ForeColor = System.Drawing.Color.Black
        Me.txt_Largo.Location = New System.Drawing.Point(134, 204)
        Me.txt_Largo.Name = "txt_Largo"
        Me.txt_Largo.Size = New System.Drawing.Size(132, 22)
        Me.txt_Largo.TabIndex = 64
        Me.txt_Largo.Type = Main.TextBoxExt.ValidType.Number
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(15, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Largo"
        '
        'txt_Ancho
        '
        Me.txt_Ancho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ancho.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ancho.ForeColor = System.Drawing.Color.Black
        Me.txt_Ancho.Location = New System.Drawing.Point(134, 175)
        Me.txt_Ancho.Name = "txt_Ancho"
        Me.txt_Ancho.Size = New System.Drawing.Size(132, 22)
        Me.txt_Ancho.TabIndex = 62
        Me.txt_Ancho.Type = Main.TextBoxExt.ValidType.Number
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(15, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Ancho"
        '
        'txt_Unidad
        '
        Me.txt_Unidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Unidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Unidad.ForeColor = System.Drawing.Color.Black
        Me.txt_Unidad.Location = New System.Drawing.Point(134, 147)
        Me.txt_Unidad.Name = "txt_Unidad"
        Me.txt_Unidad.Size = New System.Drawing.Size(328, 22)
        Me.txt_Unidad.TabIndex = 60
        Me.txt_Unidad.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(15, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(15, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Fecha"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.ForeColor = System.Drawing.Color.Black
        Me.txt_Descripcion.Location = New System.Drawing.Point(134, 90)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(328, 22)
        Me.txt_Descripcion.TabIndex = 56
        Me.txt_Descripcion.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Descripcion"
        '
        'txt_MaterialID
        '
        Me.txt_MaterialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MaterialID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialID.ForeColor = System.Drawing.Color.Black
        Me.txt_MaterialID.Location = New System.Drawing.Point(134, 32)
        Me.txt_MaterialID.Name = "txt_MaterialID"
        Me.txt_MaterialID.Size = New System.Drawing.Size(132, 22)
        Me.txt_MaterialID.TabIndex = 54
        Me.txt_MaterialID.Type = Main.TextBoxExt.ValidType.Alpha
        Me.txt_MaterialID.Visible = False
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(134, 62)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(328, 22)
        Me.txt_Nombre.TabIndex = 53
        Me.txt_Nombre.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(15, 64)
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
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Material ID"
        Me.Label1.Visible = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.bt_Cancelar)
        Me.Panel1.Controls.Add(Me.bt_Guardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 34)
        Me.Panel1.TabIndex = 54
        '
        'dt_Material
        '
        Me.dt_Material.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Material.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Material.Location = New System.Drawing.Point(134, 118)
        Me.dt_Material.Name = "dt_Material"
        Me.dt_Material.Size = New System.Drawing.Size(137, 22)
        Me.dt_Material.TabIndex = 76
        Me.dt_Material.Value = New Date(2012, 5, 7, 0, 0, 0, 0)
        '
        'uc_Material_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Material_Modificar"
        Me.Size = New System.Drawing.Size(501, 459)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Padre As Main.TextBoxExt
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Costo As Main.TextBoxExt
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_UnidadPeso As Main.TextBoxExt
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Peso As Main.TextBoxExt
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Alto As Main.TextBoxExt
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Largo As Main.TextBoxExt
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Ancho As Main.TextBoxExt
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Unidad As Main.TextBoxExt
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As Main.TextBoxExt
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_MaterialID As Main.TextBoxExt
    Friend WithEvents txt_Nombre As Main.TextBoxExt
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dt_Material As System.Windows.Forms.DateTimePicker

End Class
