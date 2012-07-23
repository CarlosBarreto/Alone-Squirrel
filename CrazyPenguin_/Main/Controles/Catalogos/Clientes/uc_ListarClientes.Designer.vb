<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_ListaClientesRequisitores
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
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.bt_Options = New System.Windows.Forms.Button()
        Me.txt_NumeroCliente = New Main.TextBoxExt()
        Me.txt_Empresa = New Main.TextBoxExt()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(13, 76)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.Size = New System.Drawing.Size(539, 223)
        Me.DataGrid.TabIndex = 2
        '
        'bt_Options
        '
        Me.bt_Options.Location = New System.Drawing.Point(528, 32)
        Me.bt_Options.Name = "bt_Options"
        Me.bt_Options.Size = New System.Drawing.Size(24, 23)
        Me.bt_Options.TabIndex = 49
        Me.bt_Options.Text = " > "
        Me.bt_Options.UseVisualStyleBackColor = True
        '
        'txt_NumeroCliente
        '
        Me.txt_NumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumeroCliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumeroCliente.ForeColor = System.Drawing.Color.Black
        Me.txt_NumeroCliente.Location = New System.Drawing.Point(13, 32)
        Me.txt_NumeroCliente.Name = "txt_NumeroCliente"
        Me.txt_NumeroCliente.Size = New System.Drawing.Size(132, 22)
        Me.txt_NumeroCliente.TabIndex = 48
        Me.txt_NumeroCliente.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'txt_Empresa
        '
        Me.txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Empresa.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Empresa.ForeColor = System.Drawing.Color.Black
        Me.txt_Empresa.Location = New System.Drawing.Point(161, 32)
        Me.txt_Empresa.Name = "txt_Empresa"
        Me.txt_Empresa.Size = New System.Drawing.Size(348, 22)
        Me.txt_Empresa.TabIndex = 47
        Me.txt_Empresa.Type = Main.TextBoxExt.ValidType.Alpha
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(164, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Empresa"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Número de Cliente"
        '
        'uc_ListaClientesRequisitores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.bt_Options)
        Me.Controls.Add(Me.txt_NumeroCliente)
        Me.Controls.Add(Me.txt_Empresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "uc_ListaClientesRequisitores"
        Me.Size = New System.Drawing.Size(570, 315)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents bt_Options As System.Windows.Forms.Button
    Friend WithEvents txt_NumeroCliente As Main.TextBoxExt
    Friend WithEvents txt_Empresa As Main.TextBoxExt
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
