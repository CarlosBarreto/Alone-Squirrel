<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_NuevaSolicitudCotización
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
        Me.tbc_Cliente = New System.Windows.Forms.TabPage()
        Me.lb_Requisitor = New System.Windows.Forms.Label()
        Me.cb_Requisitor = New System.Windows.Forms.ComboBox()
        Me.lb_Desc = New System.Windows.Forms.Label()
        Me.bt_Options = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NumeroCliente = New Main.TextBoxExt()
        Me.txt_Empresa = New Main.TextBoxExt()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbc_Servicio = New System.Windows.Forms.TabPage()
        Me.dt_Entrega = New System.Windows.Forms.DateTimePicker()
        Me.dt_Solicitud = New System.Windows.Forms.DateTimePicker()
        Me.lb_Entrega = New System.Windows.Forms.Label()
        Me.txt_Servicio = New Main.TextBoxExt()
        Me.lb_Servicio = New System.Windows.Forms.Label()
        Me.lb_Solicitud = New System.Windows.Forms.Label()
        Me.tbc_Especificacion = New System.Windows.Forms.TabPage()
        Me.bt_Limpiar = New System.Windows.Forms.Button()
        Me.bt_Agregar = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_Empresa = New System.Windows.Forms.RadioButton()
        Me.opt_Cliente = New System.Windows.Forms.RadioButton()
        Me.txt_CondicionesEntrega = New Main.TextBoxExt()
        Me.txt_PrecioUnitario = New Main.TextBoxExt()
        Me.txt_Cantidad = New Main.TextBoxExt()
        Me.txt_PrecioObjetivo = New Main.TextBoxExt()
        Me.txt_Proceso = New Main.TextBoxExt()
        Me.txt_Descripcion = New Main.TextBoxExt()
        Me.lb_CondicionesEntrega = New System.Windows.Forms.Label()
        Me.lb_PrecioUnitario = New System.Windows.Forms.Label()
        Me.lb_PrecioObjetivo = New System.Windows.Forms.Label()
        Me.lb_Proceso = New System.Windows.Forms.Label()
        Me.lb_Tratamiento = New System.Windows.Forms.Label()
        Me.lb_Cantidad = New System.Windows.Forms.Label()
        Me.txt_Material = New Main.TextBoxExt()
        Me.lb_Material = New System.Windows.Forms.Label()
        Me.txt_Tratamiento = New Main.TextBoxExt()
        Me.txt_Nombre = New Main.TextBoxExt()
        Me.lb_Nombre = New System.Windows.Forms.Label()
        Me.lb_Descripcion = New System.Windows.Forms.Label()
        Me.tbc_Condiciones = New System.Windows.Forms.TabPage()
        Me.cb_Condiciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Observaciones = New Main.TextBoxExt()
        Me.txt_TipoPago = New Main.TextBoxExt()
        Me.txt_Contado = New Main.TextBoxExt()
        Me.txt_Credito = New Main.TextBoxExt()
        Me.txt_Resto = New Main.TextBoxExt()
        Me.txt_Anticipo = New Main.TextBoxExt()
        Me.lb_Correo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_Telefono = New System.Windows.Forms.Label()
        Me.lb_Ext = New System.Windows.Forms.Label()
        Me.lb_Celular = New System.Windows.Forms.Label()
        Me.lb_Radio = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.tbc_Cliente.SuspendLayout()
        Me.tbc_Servicio.SuspendLayout()
        Me.tbc_Especificacion.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tbc_Condiciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.tbc_Cliente)
        Me.TabControl.Controls.Add(Me.tbc_Servicio)
        Me.TabControl.Controls.Add(Me.tbc_Especificacion)
        Me.TabControl.Controls.Add(Me.tbc_Condiciones)
        Me.TabControl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(859, 544)
        Me.TabControl.TabIndex = 0
        '
        'tbc_Cliente
        '
        Me.tbc_Cliente.BackColor = System.Drawing.Color.White
        Me.tbc_Cliente.Controls.Add(Me.lb_Requisitor)
        Me.tbc_Cliente.Controls.Add(Me.cb_Requisitor)
        Me.tbc_Cliente.Controls.Add(Me.lb_Desc)
        Me.tbc_Cliente.Controls.Add(Me.bt_Options)
        Me.tbc_Cliente.Controls.Add(Me.Label3)
        Me.tbc_Cliente.Controls.Add(Me.txt_NumeroCliente)
        Me.tbc_Cliente.Controls.Add(Me.txt_Empresa)
        Me.tbc_Cliente.Controls.Add(Me.Label4)
        Me.tbc_Cliente.Location = New System.Drawing.Point(4, 28)
        Me.tbc_Cliente.Name = "tbc_Cliente"
        Me.tbc_Cliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tbc_Cliente.Size = New System.Drawing.Size(851, 512)
        Me.tbc_Cliente.TabIndex = 0
        Me.tbc_Cliente.Text = "Clientes/Requisitores"
        '
        'lb_Requisitor
        '
        Me.lb_Requisitor.AutoSize = True
        Me.lb_Requisitor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Requisitor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Requisitor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Requisitor.Location = New System.Drawing.Point(36, 233)
        Me.lb_Requisitor.Name = "lb_Requisitor"
        Me.lb_Requisitor.Size = New System.Drawing.Size(66, 16)
        Me.lb_Requisitor.TabIndex = 54
        Me.lb_Requisitor.Text = "Requisitor"
        Me.lb_Requisitor.Visible = False
        '
        'cb_Requisitor
        '
        Me.cb_Requisitor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Requisitor.FormattingEnabled = True
        Me.cb_Requisitor.Location = New System.Drawing.Point(161, 230)
        Me.cb_Requisitor.Name = "cb_Requisitor"
        Me.cb_Requisitor.Size = New System.Drawing.Size(346, 24)
        Me.cb_Requisitor.TabIndex = 53
        Me.cb_Requisitor.Text = "---"
        Me.cb_Requisitor.Visible = False
        '
        'lb_Desc
        '
        Me.lb_Desc.AutoSize = True
        Me.lb_Desc.Location = New System.Drawing.Point(36, 139)
        Me.lb_Desc.Name = "lb_Desc"
        Me.lb_Desc.Size = New System.Drawing.Size(172, 16)
        Me.lb_Desc.TabIndex = 52
        Me.lb_Desc.Text = "Buscar el cliente a modificar"
        '
        'bt_Options
        '
        Me.bt_Options.Location = New System.Drawing.Point(299, 170)
        Me.bt_Options.Name = "bt_Options"
        Me.bt_Options.Size = New System.Drawing.Size(141, 23)
        Me.bt_Options.TabIndex = 51
        Me.bt_Options.Text = " > "
        Me.bt_Options.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(36, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Número de Cliente"
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(161, 170)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_NumeroCliente.TabIndex = 49
        Me.txt_NumeroCliente.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(161, 200)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 22)
        Me.txt_Empresa.TabIndex = 48
        Me.txt_Empresa.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(36, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Empresa"
        '
        'tbc_Servicio
        '
        Me.tbc_Servicio.BackColor = System.Drawing.Color.White
        Me.tbc_Servicio.Controls.Add(Me.dt_Entrega)
        Me.tbc_Servicio.Controls.Add(Me.dt_Solicitud)
        Me.tbc_Servicio.Controls.Add(Me.lb_Entrega)
        Me.tbc_Servicio.Controls.Add(Me.txt_Servicio)
        Me.tbc_Servicio.Controls.Add(Me.lb_Servicio)
        Me.tbc_Servicio.Controls.Add(Me.lb_Solicitud)
        Me.tbc_Servicio.Location = New System.Drawing.Point(4, 28)
        Me.tbc_Servicio.Name = "tbc_Servicio"
        Me.tbc_Servicio.Padding = New System.Windows.Forms.Padding(3)
        Me.tbc_Servicio.Size = New System.Drawing.Size(851, 512)
        Me.tbc_Servicio.TabIndex = 1
        Me.tbc_Servicio.Text = "Servicio"
        '
        'dt_Entrega
        '
        Me.dt_Entrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Entrega.Location = New System.Drawing.Point(319, 92)
        Me.dt_Entrega.Name = "dt_Entrega"
        Me.dt_Entrega.Size = New System.Drawing.Size(137, 22)
        Me.dt_Entrega.TabIndex = 61
        Me.dt_Entrega.Value = New Date(2012, 5, 7, 0, 0, 0, 0)
        '
        'dt_Solicitud
        '
        Me.dt_Solicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_Solicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Solicitud.Location = New System.Drawing.Point(96, 92)
        Me.dt_Solicitud.Name = "dt_Solicitud"
        Me.dt_Solicitud.Size = New System.Drawing.Size(137, 22)
        Me.dt_Solicitud.TabIndex = 60
        Me.dt_Solicitud.Value = New Date(2012, 5, 7, 0, 0, 0, 0)
        '
        'lb_Entrega
        '
        Me.lb_Entrega.AutoSize = True
        Me.lb_Entrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Entrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Entrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Entrega.Location = New System.Drawing.Point(248, 98)
        Me.lb_Entrega.Name = "lb_Entrega"
        Me.lb_Entrega.Size = New System.Drawing.Size(53, 16)
        Me.lb_Entrega.TabIndex = 59
        Me.lb_Entrega.Text = "Entrega"
        '
        'txt_Servicio
        '
        Me.txt_Servicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Servicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Servicio.ForeColor = System.Drawing.Color.Black
        Me.txt_Servicio.Location = New System.Drawing.Point(96, 51)
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.Size = New System.Drawing.Size(360, 22)
        Me.txt_Servicio.TabIndex = 58
        Me.txt_Servicio.Type = Main.TextBoxExt.ValidType.Text
        '
        'lb_Servicio
        '
        Me.lb_Servicio.AutoSize = True
        Me.lb_Servicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Servicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Servicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Servicio.Location = New System.Drawing.Point(17, 53)
        Me.lb_Servicio.Name = "lb_Servicio"
        Me.lb_Servicio.Size = New System.Drawing.Size(53, 16)
        Me.lb_Servicio.TabIndex = 57
        Me.lb_Servicio.Text = "Servicio"
        '
        'lb_Solicitud
        '
        Me.lb_Solicitud.AutoSize = True
        Me.lb_Solicitud.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Solicitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Solicitud.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Solicitud.Location = New System.Drawing.Point(17, 98)
        Me.lb_Solicitud.Name = "lb_Solicitud"
        Me.lb_Solicitud.Size = New System.Drawing.Size(58, 16)
        Me.lb_Solicitud.TabIndex = 56
        Me.lb_Solicitud.Text = "Solicitud"
        '
        'tbc_Especificacion
        '
        Me.tbc_Especificacion.BackColor = System.Drawing.Color.White
        Me.tbc_Especificacion.Controls.Add(Me.bt_Limpiar)
        Me.tbc_Especificacion.Controls.Add(Me.bt_Agregar)
        Me.tbc_Especificacion.Controls.Add(Me.DataGrid)
        Me.tbc_Especificacion.Controls.Add(Me.GroupBox1)
        Me.tbc_Especificacion.Controls.Add(Me.txt_CondicionesEntrega)
        Me.tbc_Especificacion.Controls.Add(Me.txt_PrecioUnitario)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Cantidad)
        Me.tbc_Especificacion.Controls.Add(Me.txt_PrecioObjetivo)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Proceso)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Descripcion)
        Me.tbc_Especificacion.Controls.Add(Me.lb_CondicionesEntrega)
        Me.tbc_Especificacion.Controls.Add(Me.lb_PrecioUnitario)
        Me.tbc_Especificacion.Controls.Add(Me.lb_PrecioObjetivo)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Proceso)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Tratamiento)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Cantidad)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Material)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Material)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Tratamiento)
        Me.tbc_Especificacion.Controls.Add(Me.txt_Nombre)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Nombre)
        Me.tbc_Especificacion.Controls.Add(Me.lb_Descripcion)
        Me.tbc_Especificacion.Location = New System.Drawing.Point(4, 28)
        Me.tbc_Especificacion.Name = "tbc_Especificacion"
        Me.tbc_Especificacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tbc_Especificacion.Size = New System.Drawing.Size(851, 512)
        Me.tbc_Especificacion.TabIndex = 2
        Me.tbc_Especificacion.Text = "Especificaciones de Servicio"
        '
        'bt_Limpiar
        '
        Me.bt_Limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Limpiar.Location = New System.Drawing.Point(711, 196)
        Me.bt_Limpiar.Name = "bt_Limpiar"
        Me.bt_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Limpiar.TabIndex = 92
        Me.bt_Limpiar.Text = "Limpiar"
        Me.bt_Limpiar.UseVisualStyleBackColor = True
        '
        'bt_Agregar
        '
        Me.bt_Agregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_Agregar.Location = New System.Drawing.Point(711, 155)
        Me.bt_Agregar.Name = "bt_Agregar"
        Me.bt_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.bt_Agregar.TabIndex = 91
        Me.bt_Agregar.Text = "Agregar"
        Me.bt_Agregar.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(25, 236)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(788, 202)
        Me.DataGrid.TabIndex = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt_Empresa)
        Me.GroupBox1.Controls.Add(Me.opt_Cliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(652, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 92)
        Me.GroupBox1.TabIndex = 89
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
        Me.txt_CondicionesEntrega.Location = New System.Drawing.Point(227, 197)
        Me.txt_CondicionesEntrega.Name = "txt_CondicionesEntrega"
        Me.txt_CondicionesEntrega.Size = New System.Drawing.Size(402, 22)
        Me.txt_CondicionesEntrega.TabIndex = 88
        Me.txt_CondicionesEntrega.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_PrecioUnitario
        '
        Me.txt_PrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PrecioUnitario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioUnitario.ForeColor = System.Drawing.Color.Black
        Me.txt_PrecioUnitario.Location = New System.Drawing.Point(227, 155)
        Me.txt_PrecioUnitario.Name = "txt_PrecioUnitario"
        Me.txt_PrecioUnitario.Size = New System.Drawing.Size(195, 22)
        Me.txt_PrecioUnitario.TabIndex = 87
        Me.txt_PrecioUnitario.Type = Main.TextBoxExt.ValidType.Number
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.ForeColor = System.Drawing.Color.Black
        Me.txt_Cantidad.Location = New System.Drawing.Point(25, 154)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(195, 22)
        Me.txt_Cantidad.TabIndex = 86
        Me.txt_Cantidad.Type = Main.TextBoxExt.ValidType.Number
        '
        'txt_PrecioObjetivo
        '
        Me.txt_PrecioObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PrecioObjetivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrecioObjetivo.ForeColor = System.Drawing.Color.Black
        Me.txt_PrecioObjetivo.Location = New System.Drawing.Point(434, 155)
        Me.txt_PrecioObjetivo.Name = "txt_PrecioObjetivo"
        Me.txt_PrecioObjetivo.Size = New System.Drawing.Size(195, 22)
        Me.txt_PrecioObjetivo.TabIndex = 85
        Me.txt_PrecioObjetivo.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_Proceso
        '
        Me.txt_Proceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Proceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Proceso.ForeColor = System.Drawing.Color.Black
        Me.txt_Proceso.Location = New System.Drawing.Point(231, 99)
        Me.txt_Proceso.Name = "txt_Proceso"
        Me.txt_Proceso.Size = New System.Drawing.Size(195, 22)
        Me.txt_Proceso.TabIndex = 84
        Me.txt_Proceso.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.ForeColor = System.Drawing.Color.Black
        Me.txt_Descripcion.Location = New System.Drawing.Point(112, 51)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(517, 22)
        Me.txt_Descripcion.TabIndex = 83
        Me.txt_Descripcion.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'lb_CondicionesEntrega
        '
        Me.lb_CondicionesEntrega.AutoSize = True
        Me.lb_CondicionesEntrega.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_CondicionesEntrega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_CondicionesEntrega.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_CondicionesEntrega.Location = New System.Drawing.Point(23, 199)
        Me.lb_CondicionesEntrega.Name = "lb_CondicionesEntrega"
        Me.lb_CondicionesEntrega.Size = New System.Drawing.Size(146, 16)
        Me.lb_CondicionesEntrega.TabIndex = 82
        Me.lb_CondicionesEntrega.Text = "Condiciones de Entrega"
        '
        'lb_PrecioUnitario
        '
        Me.lb_PrecioUnitario.AutoSize = True
        Me.lb_PrecioUnitario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_PrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_PrecioUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PrecioUnitario.Location = New System.Drawing.Point(228, 134)
        Me.lb_PrecioUnitario.Name = "lb_PrecioUnitario"
        Me.lb_PrecioUnitario.Size = New System.Drawing.Size(93, 16)
        Me.lb_PrecioUnitario.TabIndex = 81
        Me.lb_PrecioUnitario.Text = "Precio Unitario"
        '
        'lb_PrecioObjetivo
        '
        Me.lb_PrecioObjetivo.AutoSize = True
        Me.lb_PrecioObjetivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_PrecioObjetivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_PrecioObjetivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_PrecioObjetivo.Location = New System.Drawing.Point(431, 134)
        Me.lb_PrecioObjetivo.Name = "lb_PrecioObjetivo"
        Me.lb_PrecioObjetivo.Size = New System.Drawing.Size(95, 16)
        Me.lb_PrecioObjetivo.TabIndex = 80
        Me.lb_PrecioObjetivo.Text = "Precio Objetivo"
        '
        'lb_Proceso
        '
        Me.lb_Proceso.AutoSize = True
        Me.lb_Proceso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Proceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Proceso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Proceso.Location = New System.Drawing.Point(228, 82)
        Me.lb_Proceso.Name = "lb_Proceso"
        Me.lb_Proceso.Size = New System.Drawing.Size(56, 16)
        Me.lb_Proceso.TabIndex = 79
        Me.lb_Proceso.Text = "Proceso"
        '
        'lb_Tratamiento
        '
        Me.lb_Tratamiento.AutoSize = True
        Me.lb_Tratamiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Tratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Tratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Tratamiento.Location = New System.Drawing.Point(431, 82)
        Me.lb_Tratamiento.Name = "lb_Tratamiento"
        Me.lb_Tratamiento.Size = New System.Drawing.Size(76, 16)
        Me.lb_Tratamiento.TabIndex = 78
        Me.lb_Tratamiento.Text = "Tratamiento"
        '
        'lb_Cantidad
        '
        Me.lb_Cantidad.AutoSize = True
        Me.lb_Cantidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Cantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Cantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Cantidad.Location = New System.Drawing.Point(22, 134)
        Me.lb_Cantidad.Name = "lb_Cantidad"
        Me.lb_Cantidad.Size = New System.Drawing.Size(59, 16)
        Me.lb_Cantidad.TabIndex = 77
        Me.lb_Cantidad.Text = "Cantidad"
        '
        'txt_Material
        '
        Me.txt_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Material.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Material.ForeColor = System.Drawing.Color.Black
        Me.txt_Material.Location = New System.Drawing.Point(25, 99)
        Me.txt_Material.Name = "txt_Material"
        Me.txt_Material.Size = New System.Drawing.Size(195, 22)
        Me.txt_Material.TabIndex = 76
        Me.txt_Material.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'lb_Material
        '
        Me.lb_Material.AutoSize = True
        Me.lb_Material.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Material.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Material.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Material.Location = New System.Drawing.Point(23, 82)
        Me.lb_Material.Name = "lb_Material"
        Me.lb_Material.Size = New System.Drawing.Size(54, 16)
        Me.lb_Material.TabIndex = 75
        Me.lb_Material.Text = "Material"
        '
        'txt_Tratamiento
        '
        Me.txt_Tratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tratamiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tratamiento.ForeColor = System.Drawing.Color.Black
        Me.txt_Tratamiento.Location = New System.Drawing.Point(434, 99)
        Me.txt_Tratamiento.Name = "txt_Tratamiento"
        Me.txt_Tratamiento.Size = New System.Drawing.Size(195, 22)
        Me.txt_Tratamiento.TabIndex = 74
        Me.txt_Tratamiento.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Nombre
        '
        Me.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.txt_Nombre.Location = New System.Drawing.Point(112, 14)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(517, 22)
        Me.txt_Nombre.TabIndex = 73
        Me.txt_Nombre.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Nombre.Location = New System.Drawing.Point(22, 16)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(53, 16)
        Me.lb_Nombre.TabIndex = 72
        Me.lb_Nombre.Text = "Nombre"
        '
        'lb_Descripcion
        '
        Me.lb_Descripcion.AutoSize = True
        Me.lb_Descripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Descripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Descripcion.Location = New System.Drawing.Point(22, 53)
        Me.lb_Descripcion.Name = "lb_Descripcion"
        Me.lb_Descripcion.Size = New System.Drawing.Size(76, 16)
        Me.lb_Descripcion.TabIndex = 71
        Me.lb_Descripcion.Text = "Descripcion"
        '
        'tbc_Condiciones
        '
        Me.tbc_Condiciones.BackColor = System.Drawing.Color.White
        Me.tbc_Condiciones.Controls.Add(Me.cb_Condiciones)
        Me.tbc_Condiciones.Controls.Add(Me.Label1)
        Me.tbc_Condiciones.Controls.Add(Me.txt_Observaciones)
        Me.tbc_Condiciones.Controls.Add(Me.txt_TipoPago)
        Me.tbc_Condiciones.Controls.Add(Me.txt_Contado)
        Me.tbc_Condiciones.Controls.Add(Me.txt_Credito)
        Me.tbc_Condiciones.Controls.Add(Me.txt_Resto)
        Me.tbc_Condiciones.Controls.Add(Me.txt_Anticipo)
        Me.tbc_Condiciones.Controls.Add(Me.lb_Correo)
        Me.tbc_Condiciones.Controls.Add(Me.Label2)
        Me.tbc_Condiciones.Controls.Add(Me.lb_Telefono)
        Me.tbc_Condiciones.Controls.Add(Me.lb_Ext)
        Me.tbc_Condiciones.Controls.Add(Me.lb_Celular)
        Me.tbc_Condiciones.Controls.Add(Me.lb_Radio)
        Me.tbc_Condiciones.Location = New System.Drawing.Point(4, 28)
        Me.tbc_Condiciones.Name = "tbc_Condiciones"
        Me.tbc_Condiciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbc_Condiciones.Size = New System.Drawing.Size(851, 512)
        Me.tbc_Condiciones.TabIndex = 3
        Me.tbc_Condiciones.Text = "Condiciones de Pago"
        '
        'cb_Condiciones
        '
        Me.cb_Condiciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Condiciones.FormattingEnabled = True
        Me.cb_Condiciones.Location = New System.Drawing.Point(148, 35)
        Me.cb_Condiciones.Name = "cb_Condiciones"
        Me.cb_Condiciones.Size = New System.Drawing.Size(388, 24)
        Me.cb_Condiciones.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Condiones de Pago"
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Observaciones.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Observaciones.ForeColor = System.Drawing.Color.Black
        Me.txt_Observaciones.Location = New System.Drawing.Point(148, 221)
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(388, 86)
        Me.txt_Observaciones.TabIndex = 65
        Me.txt_Observaciones.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_TipoPago
        '
        Me.txt_TipoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TipoPago.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TipoPago.ForeColor = System.Drawing.Color.Black
        Me.txt_TipoPago.Location = New System.Drawing.Point(148, 180)
        Me.txt_TipoPago.Name = "txt_TipoPago"
        Me.txt_TipoPago.Size = New System.Drawing.Size(388, 22)
        Me.txt_TipoPago.TabIndex = 64
        Me.txt_TipoPago.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Contado
        '
        Me.txt_Contado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Contado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contado.ForeColor = System.Drawing.Color.Black
        Me.txt_Contado.Location = New System.Drawing.Point(148, 143)
        Me.txt_Contado.Name = "txt_Contado"
        Me.txt_Contado.Size = New System.Drawing.Size(388, 22)
        Me.txt_Contado.TabIndex = 63
        Me.txt_Contado.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Credito
        '
        Me.txt_Credito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Credito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Credito.ForeColor = System.Drawing.Color.Black
        Me.txt_Credito.Location = New System.Drawing.Point(148, 106)
        Me.txt_Credito.Name = "txt_Credito"
        Me.txt_Credito.Size = New System.Drawing.Size(388, 22)
        Me.txt_Credito.TabIndex = 62
        Me.txt_Credito.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Resto
        '
        Me.txt_Resto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Resto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Resto.ForeColor = System.Drawing.Color.Black
        Me.txt_Resto.Location = New System.Drawing.Point(386, 71)
        Me.txt_Resto.Name = "txt_Resto"
        Me.txt_Resto.Size = New System.Drawing.Size(150, 22)
        Me.txt_Resto.TabIndex = 61
        Me.txt_Resto.Type = Main.TextBoxExt.ValidType.Text
        '
        'txt_Anticipo
        '
        Me.txt_Anticipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Anticipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Anticipo.ForeColor = System.Drawing.Color.Black
        Me.txt_Anticipo.Location = New System.Drawing.Point(148, 71)
        Me.txt_Anticipo.Name = "txt_Anticipo"
        Me.txt_Anticipo.Size = New System.Drawing.Size(150, 22)
        Me.txt_Anticipo.TabIndex = 60
        Me.txt_Anticipo.Type = Main.TextBoxExt.ValidType.Text
        '
        'lb_Correo
        '
        Me.lb_Correo.AutoSize = True
        Me.lb_Correo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Correo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Correo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Correo.Location = New System.Drawing.Point(21, 224)
        Me.lb_Correo.Name = "lb_Correo"
        Me.lb_Correo.Size = New System.Drawing.Size(93, 16)
        Me.lb_Correo.TabIndex = 59
        Me.lb_Correo.Text = "Observaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(21, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Anticipo %"
        '
        'lb_Telefono
        '
        Me.lb_Telefono.AutoSize = True
        Me.lb_Telefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Telefono.Location = New System.Drawing.Point(322, 73)
        Me.lb_Telefono.Name = "lb_Telefono"
        Me.lb_Telefono.Size = New System.Drawing.Size(58, 16)
        Me.lb_Telefono.TabIndex = 57
        Me.lb_Telefono.Text = "Resto %"
        '
        'lb_Ext
        '
        Me.lb_Ext.AutoSize = True
        Me.lb_Ext.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Ext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Ext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Ext.Location = New System.Drawing.Point(21, 103)
        Me.lb_Ext.Name = "lb_Ext"
        Me.lb_Ext.Size = New System.Drawing.Size(49, 16)
        Me.lb_Ext.TabIndex = 56
        Me.lb_Ext.Text = "Credito"
        '
        'lb_Celular
        '
        Me.lb_Celular.AutoSize = True
        Me.lb_Celular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Celular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Celular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Celular.Location = New System.Drawing.Point(21, 140)
        Me.lb_Celular.Name = "lb_Celular"
        Me.lb_Celular.Size = New System.Drawing.Size(56, 16)
        Me.lb_Celular.TabIndex = 55
        Me.lb_Celular.Text = "Contado"
        '
        'lb_Radio
        '
        Me.lb_Radio.AutoSize = True
        Me.lb_Radio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Radio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lb_Radio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Radio.Location = New System.Drawing.Point(21, 177)
        Me.lb_Radio.Name = "lb_Radio"
        Me.lb_Radio.Size = New System.Drawing.Size(100, 16)
        Me.lb_Radio.TabIndex = 54
        Me.lb_Radio.Text = "Tiempo de pago"
        '
        'uc_NuevaSolicitudCotización
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TabControl)
        Me.Name = "uc_NuevaSolicitudCotización"
        Me.Size = New System.Drawing.Size(882, 545)
        Me.TabControl.ResumeLayout(False)
        Me.tbc_Cliente.ResumeLayout(False)
        Me.tbc_Cliente.PerformLayout()
        Me.tbc_Servicio.ResumeLayout(False)
        Me.tbc_Servicio.PerformLayout()
        Me.tbc_Especificacion.ResumeLayout(False)
        Me.tbc_Especificacion.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbc_Condiciones.ResumeLayout(False)
        Me.tbc_Condiciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tbc_Cliente As System.Windows.Forms.TabPage
    Friend WithEvents tbc_Servicio As System.Windows.Forms.TabPage
    Friend WithEvents tbc_Especificacion As System.Windows.Forms.TabPage
    Friend WithEvents tbc_Condiciones As System.Windows.Forms.TabPage
    Friend WithEvents dt_Entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_Solicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb_Entrega As System.Windows.Forms.Label

    Friend WithEvents txt_Servicio As TextBoxExt ' System.Windows.Forms.TextBox
    Friend WithEvents txt_CondicionesEntrega As TextBoxExt ' System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioUnitario As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Cantidad As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioObjetivo As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Proceso As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Descripcion As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Material As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_NumeroCliente As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Empresa As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Observaciones As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_TipoPago As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Contado As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Credito As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Resto As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Anticipo As TextBoxExt 'System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As TextBoxExt 'System.Windows.Forms.TextBox

    Friend WithEvents lb_Servicio As System.Windows.Forms.Label
    Friend WithEvents lb_Solicitud As System.Windows.Forms.Label
    Friend WithEvents bt_Limpiar As System.Windows.Forms.Button
    Friend WithEvents bt_Agregar As System.Windows.Forms.Button
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Empresa As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Cliente As System.Windows.Forms.RadioButton

    Friend WithEvents lb_CondicionesEntrega As System.Windows.Forms.Label
    Friend WithEvents lb_PrecioUnitario As System.Windows.Forms.Label
    Friend WithEvents lb_PrecioObjetivo As System.Windows.Forms.Label
    Friend WithEvents lb_Proceso As System.Windows.Forms.Label
    Friend WithEvents lb_Tratamiento As System.Windows.Forms.Label
    Friend WithEvents lb_Cantidad As System.Windows.Forms.Label

    Friend WithEvents lb_Material As System.Windows.Forms.Label

    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents lb_Descripcion As System.Windows.Forms.Label
    Friend WithEvents cb_Condiciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents lb_Correo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_Telefono As System.Windows.Forms.Label
    Friend WithEvents lb_Ext As System.Windows.Forms.Label
    Friend WithEvents lb_Celular As System.Windows.Forms.Label
    Friend WithEvents lb_Radio As System.Windows.Forms.Label
    Friend WithEvents lb_Desc As System.Windows.Forms.Label
    Friend WithEvents bt_Options As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_Requisitor As System.Windows.Forms.Label
    Friend WithEvents cb_Requisitor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Tratamiento As Main.TextBoxExt

End Class
