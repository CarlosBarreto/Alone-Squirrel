<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_NuevaCotizacion
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tbc_Nueva = New System.Windows.Forms.TabPage()
        Me.Opt_NuevosDatos = New System.Windows.Forms.RadioButton()
        Me.Opt_Solicitud = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbc_SelectSolicitud = New System.Windows.Forms.TabPage()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbc_Cliente = New System.Windows.Forms.TabPage()
        Me.lb_Desc = New System.Windows.Forms.Label()
        Me.bt_Options = New System.Windows.Forms.Button()
        Me.bt_Modificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NumeroCliente = New System.Windows.Forms.TextBox()
        Me.txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbc_Servicio = New System.Windows.Forms.TabPage()
        Me.dt_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.dt_Solicitud = New System.Windows.Forms.DateTimePicker()
        Me.bt_Editar = New System.Windows.Forms.Button()
        Me.lb_Entrega = New System.Windows.Forms.Label()
        Me.txt_Servicio = New System.Windows.Forms.TextBox()
        Me.lb_Servicio = New System.Windows.Forms.Label()
        Me.lb_Solicitud = New System.Windows.Forms.Label()
        Me.tbc_Especificaciones = New System.Windows.Forms.TabPage()
        Me.bt_Limpiar = New System.Windows.Forms.Button()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_Empresa = New System.Windows.Forms.RadioButton()
        Me.opt_Cliente = New System.Windows.Forms.RadioButton()
        Me.txt_CondicionesEntrega = New System.Windows.Forms.TextBox()
        Me.txt_PrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.txt_PrecioObjetivo = New System.Windows.Forms.TextBox()
        Me.txt_Proceso = New System.Windows.Forms.TextBox()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lb_CondicionesEntrega = New System.Windows.Forms.Label()
        Me.lb_PrecioUnitario = New System.Windows.Forms.Label()
        Me.lb_PrecioObjetivo = New System.Windows.Forms.Label()
        Me.lb_Proceso = New System.Windows.Forms.Label()
        Me.lb_Tratamiento = New System.Windows.Forms.Label()
        Me.lb_Cantidad = New System.Windows.Forms.Label()
        Me.txt_Material = New System.Windows.Forms.TextBox()
        Me.lb_Material = New System.Windows.Forms.Label()
        Me.txt_Tratamiento = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_Descripcion = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.tbc_Nueva.SuspendLayout()
        Me.tbc_SelectSolicitud.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc_Cliente.SuspendLayout()
        Me.tbc_Servicio.SuspendLayout()
        Me.tbc_Especificaciones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.tbc_Nueva)
        Me.TabControl.Controls.Add(Me.tbc_SelectSolicitud)
        Me.TabControl.Controls.Add(Me.tbc_Cliente)
        Me.TabControl.Controls.Add(Me.tbc_Servicio)
        Me.TabControl.Controls.Add(Me.tbc_Especificaciones)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(880, 505)
        Me.TabControl.TabIndex = 0
        '
        'tbc_Nueva
        '
        Me.tbc_Nueva.BackColor = System.Drawing.Color.White
        Me.tbc_Nueva.Controls.Add(Me.Opt_NuevosDatos)
        Me.tbc_Nueva.Controls.Add(Me.Opt_Solicitud)
        Me.tbc_Nueva.Controls.Add(Me.Label1)
        Me.tbc_Nueva.Location = New System.Drawing.Point(4, 25)
        Me.tbc_Nueva.Name = "tbc_Nueva"
        Me.tbc_Nueva.Padding = New System.Windows.Forms.Padding(3)
        Me.tbc_Nueva.Size = New System.Drawing.Size(872, 476)
        Me.tbc_Nueva.TabIndex = 0
        Me.tbc_Nueva.Text = "Nueva"
        '
        'Opt_NuevosDatos
        '
        Me.Opt_NuevosDatos.AutoSize = True
        Me.Opt_NuevosDatos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_NuevosDatos.Location = New System.Drawing.Point(49, 176)
        Me.Opt_NuevosDatos.Name = "Opt_NuevosDatos"
        Me.Opt_NuevosDatos.Size = New System.Drawing.Size(169, 20)
        Me.Opt_NuevosDatos.TabIndex = 7
        Me.Opt_NuevosDatos.TabStop = True
        Me.Opt_NuevosDatos.Text = "A partir de Nuevos Datos"
        Me.Opt_NuevosDatos.UseVisualStyleBackColor = True
        '
        'Opt_Solicitud
        '
        Me.Opt_Solicitud.AutoSize = True
        Me.Opt_Solicitud.Checked = True
        Me.Opt_Solicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Solicitud.Location = New System.Drawing.Point(49, 141)
        Me.Opt_Solicitud.Name = "Opt_Solicitud"
        Me.Opt_Solicitud.Size = New System.Drawing.Size(164, 20)
        Me.Opt_Solicitud.TabIndex = 6
        Me.Opt_Solicitud.TabStop = True
        Me.Opt_Solicitud.Text = "A partir de una Solicitud"
        Me.Opt_Solicitud.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccione si desea partir de una Solicitud de Cotización o a partir de nuevos da" & _
    "tos"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'tbc_SelectSolicitud
        '
        Me.tbc_SelectSolicitud.BackColor = System.Drawing.Color.White
        Me.tbc_SelectSolicitud.Controls.Add(Me.DataGrid)
        Me.tbc_SelectSolicitud.Controls.Add(Me.Label2)
        Me.tbc_SelectSolicitud.Location = New System.Drawing.Point(4, 25)
        Me.tbc_SelectSolicitud.Name = "tbc_SelectSolicitud"
        Me.tbc_SelectSolicitud.Size = New System.Drawing.Size(872, 476)
        Me.tbc_SelectSolicitud.TabIndex = 1
        Me.tbc_SelectSolicitud.Text = "Select Solicitud"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(48, 96)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.Size = New System.Drawing.Size(505, 222)
        Me.DataGrid.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(542, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seleccione si desea partir de una Solicitud de Cotización o a partir de nuevos da" & _
    "tos"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'tbc_Cliente
        '
        Me.tbc_Cliente.BackColor = System.Drawing.Color.White
        Me.tbc_Cliente.Controls.Add(Me.lb_Desc)
        Me.tbc_Cliente.Controls.Add(Me.bt_Options)
        Me.tbc_Cliente.Controls.Add(Me.bt_Modificar)
        Me.tbc_Cliente.Controls.Add(Me.Label3)
        Me.tbc_Cliente.Controls.Add(Me.txt_NumeroCliente)
        Me.tbc_Cliente.Controls.Add(Me.txt_Empresa)
        Me.tbc_Cliente.Controls.Add(Me.Label4)
        Me.tbc_Cliente.Location = New System.Drawing.Point(4, 25)
        Me.tbc_Cliente.Name = "tbc_Cliente"
        Me.tbc_Cliente.Size = New System.Drawing.Size(872, 476)
        Me.tbc_Cliente.TabIndex = 2
        Me.tbc_Cliente.Text = "Cliente / Requisitor"
        '
        'lb_Desc
        '
        Me.lb_Desc.AutoSize = True
        Me.lb_Desc.Location = New System.Drawing.Point(56, 148)
        Me.lb_Desc.Name = "lb_Desc"
        Me.lb_Desc.Size = New System.Drawing.Size(139, 13)
        Me.lb_Desc.TabIndex = 59
        Me.lb_Desc.Text = "Buscar el cliente a modificar"
        '
        'bt_Options
        '
        Me.bt_Options.Location = New System.Drawing.Point(319, 179)
        Me.bt_Options.Name = "bt_Options"
        Me.bt_Options.Size = New System.Drawing.Size(24, 23)
        Me.bt_Options.TabIndex = 58
        Me.bt_Options.Text = " > "
        Me.bt_Options.UseVisualStyleBackColor = True
        '
        'bt_Modificar
        '
        Me.bt_Modificar.Location = New System.Drawing.Point(454, 237)
        Me.bt_Modificar.Name = "bt_Modificar"
        Me.bt_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Modificar.TabIndex = 57
        Me.bt_Modificar.Text = "Modificar"
        Me.bt_Modificar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(56, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Número de Cliente"
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(181, 179)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_NumeroCliente.TabIndex = 56
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(181, 209)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 22)
        Me.txt_Empresa.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(56, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Empresa"
        '
        'tbc_Servicio
        '
        Me.tbc_Servicio.BackColor = System.Drawing.Color.White
        Me.tbc_Servicio.Controls.Add(Me.dt_Entrega)
        Me.tbc_Servicio.Controls.Add(Me.dt_Solicitud)
        Me.tbc_Servicio.Controls.Add(Me.bt_Editar)
        Me.tbc_Servicio.Controls.Add(Me.lb_Entrega)
        Me.tbc_Servicio.Controls.Add(Me.txt_Servicio)
        Me.tbc_Servicio.Controls.Add(Me.lb_Servicio)
        Me.tbc_Servicio.Controls.Add(Me.lb_Solicitud)
        Me.tbc_Servicio.Location = New System.Drawing.Point(4, 25)
        Me.tbc_Servicio.Name = "tbc_Servicio"
        Me.tbc_Servicio.Size = New System.Drawing.Size(872, 476)
        Me.tbc_Servicio.TabIndex = 4
        Me.tbc_Servicio.Text = "Servicio"
        '
        'dt_Entrega
        '
        Me.dt_Entrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Entrega.Location = New System.Drawing.Point(355, 192)
        Me.dt_Entrega.Name = "dt_Entrega"
        Me.dt_Entrega.Size = New System.Drawing.Size(137, 22)
        Me.dt_Entrega.TabIndex = 63
        Me.dt_Entrega.Value = New Date(2012, 5, 7, 0, 0, 0, 0)
        '
        'dt_Solicitud
        '
        Me.dt_Solicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Solicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Solicitud.Location = New System.Drawing.Point(132, 192)
        Me.dt_Solicitud.Name = "dt_Solicitud"
        Me.dt_Solicitud.Size = New System.Drawing.Size(137, 22)
        Me.dt_Solicitud.TabIndex = 62
        Me.dt_Solicitud.Value = New Date(2012, 5, 7, 0, 0, 0, 0)
        '
        'bt_Editar
        '
        Me.bt_Editar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Editar.Location = New System.Drawing.Point(417, 248)
        Me.bt_Editar.Name = "bt_Editar"
        Me.bt_Editar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Editar.TabIndex = 54
        Me.bt_Editar.Text = "Editar"
        Me.bt_Editar.UseVisualStyleBackColor = True
        '
        'lb_Entrega
        '
        Me.lb_Entrega.AutoSize = True
        Me.lb_Entrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Entrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Entrega.Location = New System.Drawing.Point(284, 198)
        Me.lb_Entrega.Name = "lb_Entrega"
        Me.lb_Entrega.Size = New System.Drawing.Size(53, 16)
        Me.lb_Entrega.TabIndex = 59
        Me.lb_Entrega.Text = "Entrega"
        '
        'txt_Servicio
        '
        Me.txt_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Servicio.Enabled = False
        Me.txt_Servicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Servicio.ForeColor = System.Drawing.Color.Black
        Me.txt_Servicio.Location = New System.Drawing.Point(132, 151)
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.Size = New System.Drawing.Size(360, 22)
        Me.txt_Servicio.TabIndex = 57
        '
        'lb_Servicio
        '
        Me.lb_Servicio.AutoSize = True
        Me.lb_Servicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Servicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Servicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Servicio.Location = New System.Drawing.Point(53, 153)
        Me.lb_Servicio.Name = "lb_Servicio"
        Me.lb_Servicio.Size = New System.Drawing.Size(53, 16)
        Me.lb_Servicio.TabIndex = 56
        Me.lb_Servicio.Text = "Servicio"
        '
        'lb_Solicitud
        '
        Me.lb_Solicitud.AutoSize = True
        Me.lb_Solicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Solicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Solicitud.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Solicitud.Location = New System.Drawing.Point(53, 198)
        Me.lb_Solicitud.Name = "lb_Solicitud"
        Me.lb_Solicitud.Size = New System.Drawing.Size(58, 16)
        Me.lb_Solicitud.TabIndex = 55
        Me.lb_Solicitud.Text = "Solicitud"
        '
        'tbc_Especificaciones
        '
        Me.tbc_Especificaciones.BackColor = System.Drawing.Color.White
        Me.tbc_Especificaciones.Controls.Add(Me.bt_Limpiar)
        Me.tbc_Especificaciones.Controls.Add(Me.bt_Agregar)
        Me.tbc_Especificaciones.Controls.Add(Me.DataGridView1)
        Me.tbc_Especificaciones.Controls.Add(Me.GroupBox1)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_CondicionesEntrega)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_PrecioUnitario)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Cantidad)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_PrecioObjetivo)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Proceso)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Descripcion)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_CondicionesEntrega)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_PrecioUnitario)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_PrecioObjetivo)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Proceso)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Tratamiento)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Cantidad)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Material)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Material)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Tratamiento)
        Me.tbc_Especificaciones.Controls.Add(Me.txt_Nombre)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Nombre)
        Me.tbc_Especificaciones.Controls.Add(Me.lb_Descripcion)
        Me.tbc_Especificaciones.Location = New System.Drawing.Point(4, 25)
        Me.tbc_Especificaciones.Name = "tbc_Especificaciones"
        Me.tbc_Especificaciones.Size = New System.Drawing.Size(872, 476)
        Me.tbc_Especificaciones.TabIndex = 5
        Me.tbc_Especificaciones.Text = "Especificaciones de Servicio"
        '
        'bt_Limpiar
        '
        Me.bt_Limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Limpiar.Location = New System.Drawing.Point(717, 197)
        Me.bt_Limpiar.Name = "bt_Limpiar"
        Me.bt_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Limpiar.TabIndex = 114
        Me.bt_Limpiar.Text = "Limpiar"
        Me.bt_Limpiar.UseVisualStyleBackColor = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Agregar.Location = New System.Drawing.Point(717, 156)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Agregar.TabIndex = 113
        Me.bt_Agregar.Text = "Agregar"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 202)
        Me.DataGridView1.TabIndex = 112
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt_Empresa)
        Me.GroupBox1.Controls.Add(Me.opt_Cliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(658, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 92)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Material Proporcionado"
        '
        'opt_Empresa
        '
        Me.opt_Empresa.AutoSize = True
        Me.opt_Empresa.Location = New System.Drawing.Point(13, 24)
        Me.opt_Empresa.Name = "opt_Empresa"
        Me.opt_Empresa.Size = New System.Drawing.Size(78, 20)
        Me.opt_Empresa.TabIndex = 1
        Me.opt_Empresa.TabStop = True
        Me.opt_Empresa.Text = "Empresa"
        Me.opt_Empresa.UseVisualStyleBackColor = True
        '
        'opt_Cliente
        '
        Me.opt_Cliente.AutoSize = True
        Me.opt_Cliente.Location = New System.Drawing.Point(13, 52)
        Me.opt_Cliente.Name = "opt_Cliente"
        Me.opt_Cliente.Size = New System.Drawing.Size(66, 20)
        Me.opt_Cliente.TabIndex = 0
        Me.opt_Cliente.TabStop = True
        Me.opt_Cliente.Text = "Cliente"
        Me.opt_Cliente.UseVisualStyleBackColor = True
        '
        'txt_CondicionesEntrega
        '
        Me.txt_CondicionesEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CondicionesEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CondicionesEntrega.ForeColor = System.Drawing.Color.Black
        Me.txt_CondicionesEntrega.Location = New System.Drawing.Point(233, 198)
        Me.txt_CondicionesEntrega.Name = "txt_CondicionesEntrega"
        Me.txt_CondicionesEntrega.Size = New System.Drawing.Size(402, 22)
        Me.txt_CondicionesEntrega.TabIndex = 110
        '
        'txt_PrecioUnitario
        '
        Me.txt_PrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PrecioUnitario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioUnitario.ForeColor = System.Drawing.Color.Black
        Me.txt_PrecioUnitario.Location = New System.Drawing.Point(233, 156)
        Me.txt_PrecioUnitario.Name = "txt_PrecioUnitario"
        Me.txt_PrecioUnitario.Size = New System.Drawing.Size(195, 22)
        Me.txt_PrecioUnitario.TabIndex = 109
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Black
        Me.txt_Cantidad.Location = New System.Drawing.Point(31, 155)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(195, 22)
        Me.txt_Cantidad.TabIndex = 108
        '
        'txt_PrecioObjetivo
        '
        Me.txt_PrecioObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PrecioObjetivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioObjetivo.ForeColor = System.Drawing.Color.Black
        Me.txt_PrecioObjetivo.Location = New System.Drawing.Point(440, 156)
        Me.txt_PrecioObjetivo.Name = "txt_PrecioObjetivo"
        Me.txt_PrecioObjetivo.Size = New System.Drawing.Size(195, 22)
        Me.txt_PrecioObjetivo.TabIndex = 107
        '
        'txt_Proceso
        '
        Me.txt_Proceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Proceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Proceso.ForeColor = System.Drawing.Color.Black
        Me.txt_Proceso.Location = New System.Drawing.Point(237, 100)
        Me.txt_Proceso.Name = "txt_Proceso"
        Me.txt_Proceso.Size = New System.Drawing.Size(195, 22)
        Me.txt_Proceso.TabIndex = 106
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.ForeColor = System.Drawing.Color.Black
        Me.txt_Descripcion.Location = New System.Drawing.Point(118, 52)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(517, 22)
        Me.txt_Descripcion.TabIndex = 105
        '
        'lb_CondicionesEntrega
        '
        Me.lb_CondicionesEntrega.AutoSize = True
        Me.lb_CondicionesEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_CondicionesEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_CondicionesEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_CondicionesEntrega.Location = New System.Drawing.Point(29, 200)
        Me.lb_CondicionesEntrega.Name = "lb_CondicionesEntrega"
        Me.lb_CondicionesEntrega.Size = New System.Drawing.Size(146, 16)
        Me.lb_CondicionesEntrega.TabIndex = 104
        Me.lb_CondicionesEntrega.Text = "Condiciones de Entrega"
        '
        'lb_PrecioUnitario
        '
        Me.lb_PrecioUnitario.AutoSize = True
        Me.lb_PrecioUnitario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_PrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_PrecioUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PrecioUnitario.Location = New System.Drawing.Point(234, 135)
        Me.lb_PrecioUnitario.Name = "lb_PrecioUnitario"
        Me.lb_PrecioUnitario.Size = New System.Drawing.Size(93, 16)
        Me.lb_PrecioUnitario.TabIndex = 103
        Me.lb_PrecioUnitario.Text = "Precio Unitario"
        '
        'lb_PrecioObjetivo
        '
        Me.lb_PrecioObjetivo.AutoSize = True
        Me.lb_PrecioObjetivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_PrecioObjetivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_PrecioObjetivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PrecioObjetivo.Location = New System.Drawing.Point(437, 135)
        Me.lb_PrecioObjetivo.Name = "lb_PrecioObjetivo"
        Me.lb_PrecioObjetivo.Size = New System.Drawing.Size(95, 16)
        Me.lb_PrecioObjetivo.TabIndex = 102
        Me.lb_PrecioObjetivo.Text = "Precio Objetivo"
        '
        'lb_Proceso
        '
        Me.lb_Proceso.AutoSize = True
        Me.lb_Proceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Proceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Proceso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Proceso.Location = New System.Drawing.Point(234, 83)
        Me.lb_Proceso.Name = "lb_Proceso"
        Me.lb_Proceso.Size = New System.Drawing.Size(56, 16)
        Me.lb_Proceso.TabIndex = 101
        Me.lb_Proceso.Text = "Proceso"
        '
        'lb_Tratamiento
        '
        Me.lb_Tratamiento.AutoSize = True
        Me.lb_Tratamiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Tratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Tratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Tratamiento.Location = New System.Drawing.Point(437, 83)
        Me.lb_Tratamiento.Name = "lb_Tratamiento"
        Me.lb_Tratamiento.Size = New System.Drawing.Size(76, 16)
        Me.lb_Tratamiento.TabIndex = 100
        Me.lb_Tratamiento.Text = "Tratamiento"
        '
        'lb_Cantidad
        '
        Me.lb_Cantidad.AutoSize = True
        Me.lb_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Cantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Cantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Cantidad.Location = New System.Drawing.Point(28, 135)
        Me.lb_Cantidad.Name = "lb_Cantidad"
        Me.lb_Cantidad.Size = New System.Drawing.Size(59, 16)
        Me.lb_Cantidad.TabIndex = 99
        Me.lb_Cantidad.Text = "Cantidad"
        '
        'txt_Material
        '
        Me.txt_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Material.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Material.ForeColor = System.Drawing.Color.Black
        Me.txt_Material.Location = New System.Drawing.Point(31, 100)
        Me.txt_Material.Name = "txt_Material"
        Me.txt_Material.Size = New System.Drawing.Size(195, 22)
        Me.txt_Material.TabIndex = 98
        '
        'lb_Material
        '
        Me.lb_Material.AutoSize = True
        Me.lb_Material.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Material.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Material.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Material.Location = New System.Drawing.Point(29, 83)
        Me.lb_Material.Name = "lb_Material"
        Me.lb_Material.Size = New System.Drawing.Size(54, 16)
        Me.lb_Material.TabIndex = 97
        Me.lb_Material.Text = "Material"
        '
        'txt_Tratamiento
        '
        Me.txt_Tratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tratamiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tratamiento.ForeColor = System.Drawing.Color.Black
        Me.txt_Tratamiento.Location = New System.Drawing.Point(440, 100)
        Me.txt_Tratamiento.Name = "txt_Tratamiento"
        Me.txt_Tratamiento.Size = New System.Drawing.Size(195, 22)
        Me.txt_Tratamiento.TabIndex = 96
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(118, 15)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(517, 22)
        Me.txt_Nombre.TabIndex = 95
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Nombre.Location = New System.Drawing.Point(28, 17)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(53, 16)
        Me.lb_Nombre.TabIndex = 94
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_Descripcion
        '
        Me.lb_Descripcion.AutoSize = True
        Me.lb_Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Descripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Descripcion.Location = New System.Drawing.Point(28, 54)
        Me.lb_Descripcion.Name = "lb_Descripcion"
        Me.lb_Descripcion.Size = New System.Drawing.Size(76, 16)
        Me.lb_Descripcion.TabIndex = 93
        Me.lb_Descripcion.Text = "Descripcion"
        '
        'uc_NuevaCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Name = "uc_NuevaCotizacion"
        Me.Size = New System.Drawing.Size(883, 508)
        Me.TabControl.ResumeLayout(False)
        Me.tbc_Nueva.ResumeLayout(False)
        Me.tbc_Nueva.PerformLayout()
        Me.tbc_SelectSolicitud.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc_Cliente.ResumeLayout(False)
        Me.tbc_Cliente.PerformLayout()
        Me.tbc_Servicio.ResumeLayout(False)
        Me.tbc_Servicio.PerformLayout()
        Me.tbc_Especificaciones.ResumeLayout(False)
        Me.tbc_Especificaciones.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tbc_Nueva As System.Windows.Forms.TabPage
    Friend WithEvents tbc_SelectSolicitud As System.Windows.Forms.TabPage
    Protected Friend WithEvents tbc_Cliente As System.Windows.Forms.TabPage
    Protected Friend WithEvents tbc_Servicio As System.Windows.Forms.TabPage
    Friend WithEvents tbc_Especificaciones As System.Windows.Forms.TabPage
    Friend WithEvents Opt_NuevosDatos As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Solicitud As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_Desc As System.Windows.Forms.Label
    Friend WithEvents bt_Options As System.Windows.Forms.Button
    Friend WithEvents bt_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_NumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bt_Editar As System.Windows.Forms.Button
    Friend WithEvents lb_Entrega As System.Windows.Forms.Label
    Friend WithEvents txt_Servicio As System.Windows.Forms.TextBox
    Friend WithEvents lb_Servicio As System.Windows.Forms.Label
    Friend WithEvents lb_Solicitud As System.Windows.Forms.Label
    Friend WithEvents dt_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_Solicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents bt_Limpiar As System.Windows.Forms.Button
    Friend WithEvents bt_Agregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Empresa As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Cliente As System.Windows.Forms.RadioButton
    Friend WithEvents txt_CondicionesEntrega As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioObjetivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Proceso As System.Windows.Forms.TextBox
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lb_CondicionesEntrega As System.Windows.Forms.Label
    Friend WithEvents lb_PrecioUnitario As System.Windows.Forms.Label
    Friend WithEvents lb_PrecioObjetivo As System.Windows.Forms.Label
    Friend WithEvents lb_Proceso As System.Windows.Forms.Label
    Friend WithEvents lb_Tratamiento As System.Windows.Forms.Label
    Friend WithEvents lb_Cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_Material As System.Windows.Forms.TextBox
    Friend WithEvents lb_Material As System.Windows.Forms.Label
    Friend WithEvents txt_Tratamiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_Descripcion As System.Windows.Forms.Label

End Class
