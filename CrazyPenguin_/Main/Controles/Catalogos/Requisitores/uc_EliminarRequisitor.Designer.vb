﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_EliminarRequisitor
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
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.txt_Radio = New System.Windows.Forms.TextBox()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.txt_Ext = New System.Windows.Forms.TextBox()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lb_Correo = New System.Windows.Forms.Label()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_Telefono = New System.Windows.Forms.Label()
        Me.lb_Ext = New System.Windows.Forms.Label()
        Me.lb_Celular = New System.Windows.Forms.Label()
        Me.lb_Radio = New System.Windows.Forms.Label()
        Me.txt_NumeroCliente = New System.Windows.Forms.TextBox()
        Me.lb_NumeroCliente = New System.Windows.Forms.Label()
        Me.txt_IDRequisitor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Puesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(448, 34)
        Me.Panel1.TabIndex = 83
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
        Me.bt_Guardar.Text = "&Eliminar"
        Me.bt_Guardar.UseVisualStyleBackColor = True
        '
        'txt_Correo
        '
        Me.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Correo.Enabled = False
        Me.txt_Correo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Correo.ForeColor = System.Drawing.Color.Black
        Me.txt_Correo.Location = New System.Drawing.Point(79, 223)
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(360, 22)
        Me.txt_Correo.TabIndex = 82
        '
        'txt_Radio
        '
        Me.txt_Radio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Radio.Enabled = False
        Me.txt_Radio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Radio.ForeColor = System.Drawing.Color.Black
        Me.txt_Radio.Location = New System.Drawing.Point(79, 195)
        Me.txt_Radio.Name = "txt_Radio"
        Me.txt_Radio.Size = New System.Drawing.Size(360, 22)
        Me.txt_Radio.TabIndex = 81
        '
        'txt_Celular
        '
        Me.txt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Celular.Enabled = False
        Me.txt_Celular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Celular.ForeColor = System.Drawing.Color.Black
        Me.txt_Celular.Location = New System.Drawing.Point(79, 167)
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(360, 22)
        Me.txt_Celular.TabIndex = 80
        '
        'txt_Ext
        '
        Me.txt_Ext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Ext.Enabled = False
        Me.txt_Ext.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ext.ForeColor = System.Drawing.Color.Black
        Me.txt_Ext.Location = New System.Drawing.Point(79, 139)
        Me.txt_Ext.Name = "txt_Ext"
        Me.txt_Ext.Size = New System.Drawing.Size(360, 22)
        Me.txt_Ext.TabIndex = 79
        '
        'txt_Telefono
        '
        Me.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Telefono.Enabled = False
        Me.txt_Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Telefono.ForeColor = System.Drawing.Color.Black
        Me.txt_Telefono.Location = New System.Drawing.Point(79, 111)
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(360, 22)
        Me.txt_Telefono.TabIndex = 78
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Enabled = False
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(79, 83)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(360, 22)
        Me.txt_Nombre.TabIndex = 77
        '
        'lb_Correo
        '
        Me.lb_Correo.AutoSize = True
        Me.lb_Correo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Correo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Correo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Correo.Location = New System.Drawing.Point(6, 230)
        Me.lb_Correo.Name = "lb_Correo"
        Me.lb_Correo.Size = New System.Drawing.Size(46, 16)
        Me.lb_Correo.TabIndex = 75
        Me.lb_Correo.Text = "Correo"
        Me.lb_Correo.Visible = False
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Nombre.Location = New System.Drawing.Point(6, 90)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(53, 16)
        Me.lb_Nombre.TabIndex = 73
        Me.lb_Nombre.Text = "Nombre"
        Me.lb_Nombre.Visible = False
        '
        'lb_Telefono
        '
        Me.lb_Telefono.AutoSize = True
        Me.lb_Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Telefono.Location = New System.Drawing.Point(6, 116)
        Me.lb_Telefono.Name = "lb_Telefono"
        Me.lb_Telefono.Size = New System.Drawing.Size(55, 16)
        Me.lb_Telefono.TabIndex = 72
        Me.lb_Telefono.Text = "Telefono"
        Me.lb_Telefono.Visible = False
        '
        'lb_Ext
        '
        Me.lb_Ext.AutoSize = True
        Me.lb_Ext.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Ext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ext.Location = New System.Drawing.Point(6, 146)
        Me.lb_Ext.Name = "lb_Ext"
        Me.lb_Ext.Size = New System.Drawing.Size(66, 16)
        Me.lb_Ext.TabIndex = 71
        Me.lb_Ext.Text = "Extension"
        Me.lb_Ext.Visible = False
        '
        'lb_Celular
        '
        Me.lb_Celular.AutoSize = True
        Me.lb_Celular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Celular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Celular.Location = New System.Drawing.Point(6, 174)
        Me.lb_Celular.Name = "lb_Celular"
        Me.lb_Celular.Size = New System.Drawing.Size(48, 16)
        Me.lb_Celular.TabIndex = 70
        Me.lb_Celular.Text = "Celular"
        Me.lb_Celular.Visible = False
        '
        'lb_Radio
        '
        Me.lb_Radio.AutoSize = True
        Me.lb_Radio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Radio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Radio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Radio.Location = New System.Drawing.Point(6, 202)
        Me.lb_Radio.Name = "lb_Radio"
        Me.lb_Radio.Size = New System.Drawing.Size(41, 16)
        Me.lb_Radio.TabIndex = 69
        Me.lb_Radio.Text = "Radio"
        Me.lb_Radio.Visible = False
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Enabled = False
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(352, 40)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(87, 22)
        Me.txt_NumeroCliente.TabIndex = 76
        '
        'lb_NumeroCliente
        '
        Me.lb_NumeroCliente.AutoSize = True
        Me.lb_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_NumeroCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_NumeroCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_NumeroCliente.Location = New System.Drawing.Point(208, 48)
        Me.lb_NumeroCliente.Name = "lb_NumeroCliente"
        Me.lb_NumeroCliente.Size = New System.Drawing.Size(115, 16)
        Me.lb_NumeroCliente.TabIndex = 74
        Me.lb_NumeroCliente.Text = "Numero de Cliente"
        Me.lb_NumeroCliente.Visible = False
        '
        'txt_IDRequisitor
        '
        Me.txt_IDRequisitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_IDRequisitor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDRequisitor.ForeColor = System.Drawing.Color.Black
        Me.txt_IDRequisitor.Location = New System.Drawing.Point(107, 46)
        Me.txt_IDRequisitor.Name = "txt_IDRequisitor"
        Me.txt_IDRequisitor.Size = New System.Drawing.Size(87, 22)
        Me.txt_IDRequisitor.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "IDRequisitor"
        '
        'txt_Puesto
        '
        Me.txt_Puesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Puesto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Puesto.ForeColor = System.Drawing.Color.Black
        Me.txt_Puesto.Location = New System.Drawing.Point(78, 255)
        Me.txt_Puesto.Name = "txt_Puesto"
        Me.txt_Puesto.Size = New System.Drawing.Size(360, 22)
        Me.txt_Puesto.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Puesto"
        '
        'uc_EliminarRequisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.txt_Puesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_IDRequisitor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_Correo)
        Me.Controls.Add(Me.txt_Radio)
        Me.Controls.Add(Me.txt_Celular)
        Me.Controls.Add(Me.txt_Ext)
        Me.Controls.Add(Me.txt_Telefono)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.lb_Correo)
        Me.Controls.Add(Me.lb_Nombre)
        Me.Controls.Add(Me.lb_Telefono)
        Me.Controls.Add(Me.lb_Ext)
        Me.Controls.Add(Me.lb_Celular)
        Me.Controls.Add(Me.lb_Radio)
        Me.Controls.Add(Me.txt_NumeroCliente)
        Me.Controls.Add(Me.lb_NumeroCliente)
        Me.Name = "uc_EliminarRequisitor"
        Me.Size = New System.Drawing.Size(448, 293)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_Guardar As System.Windows.Forms.Button
    Friend WithEvents txt_Correo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Radio As System.Windows.Forms.TextBox
    Friend WithEvents txt_Celular As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ext As System.Windows.Forms.TextBox
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lb_Correo As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_Telefono As System.Windows.Forms.Label
    Friend WithEvents lb_Ext As System.Windows.Forms.Label
    Friend WithEvents lb_Celular As System.Windows.Forms.Label
    Friend WithEvents lb_Radio As System.Windows.Forms.Label
    Friend WithEvents txt_NumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents lb_NumeroCliente As System.Windows.Forms.Label
    Friend WithEvents bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_IDRequisitor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Puesto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class