'Imports Main.AppMain

Public Class fr_Main
    Private lbTitle As uc_Title
    Public Form As UserControl ' uc_FormularioDatosCliente
    Public FormTool As UserControl
    Private Point_ As Point

    ''' <summary>
    ''' Para eliminar el objeto en uso actual
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KillForm()
        If Not IsNothing(Form) Then Me.Controls.Remove(Form)
        If Not IsNothing(lbTitle) Then Me.Controls.Remove(lbTitle)
        If Not IsNothing(FormTool) Then Me.Controls.Remove(FormTool)
        Form = Nothing
        lbTitle = Nothing
        FormTool = Nothing
    End Sub

    Public Sub AddTitle(ByVal Text As String, Optional X As Integer = 25, Optional Y As Integer = 60)
        Point_ = New Point
        lbTitle = New uc_Title
        Point_.X = X
        Point_.Y = Y
        With lbTitle
            .Location = Point_
            .Label1.Text = Text '"Agregar Nuevo Cliente"
        End With
        Me.Controls.Add(lbTitle)
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = Me.Width - PictureBox1.Width - 20
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar Nuevo Cliente")
       
        Form = New uc_ModificarFormularioDatosCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        KillForm()
        AddTitle("Modificar Un Cliente")

        Form = New uc_ListaClientesRequisitores 'uc_BuscarCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        KillForm()
        AddTitle("Eliminar Un Cliente")

        Form = New uc_ListarClientesEliminar 'uc_BuscarCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        'Form.Controls("bt_Eliminar").Visible = True
        'Form.Controls("bt_Eliminar").Location = Form.Controls("bt_Modificar").Location
        'Form.Controls("bt_Modificar").Visible = False
        Me.Controls.Add(Form)
    End Sub

    Private Sub NuevaSolicitudToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaSolicitudToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar una nueva Solicitud de Cotización")

        Form = New uc_NuevaSolicitudCotización
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)

        FormTool = New uc_SolicitudToolBar(Me)
        Point_.X = 0
        Point_.Y = 110
        FormTool.Location = Point_
        FormTool.Width = Me.Width
        Me.Controls.Add(FormTool)
    End Sub

    Private Sub NuevaCotizaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCotizaciónToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar una nueva Cotización")

        Form = New uc_NuevaCotizacion
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)

        FormTool = New uc_CotizacionToolBar(Me)
        Point_.X = 0
        Point_.Y = 110
        FormTool.Location = Point_
        FormTool.Width = Me.Width
        Me.Controls.Add(FormTool)
    End Sub
    '------------------------------------
    Private Sub fr_Main_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Not IsNothing(lbTitle) Then lbTitle.Width = Me.Width
        If Not IsNothing(Form) Then Form.Width = Me.Width
    End Sub


    Private Sub AgregarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        KillForm()
        AddTitle("Agregar Nuevo Proveedor")

        Form = New uc_FormularioDatosProveedores
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)

    End Sub

    Private Sub AgregarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem2.Click
        KillForm()
        AddTitle("Agregar Nuevo Servicio")

        Form = New uc_FormularioDatosServicio
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

   

    Private Sub ListadoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        KillForm()
        AddTitle("Listado de clientes")

        Form = New uc_ListadoClientes
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub AgregarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem6.Click
        KillForm()
        AddTitle("Seleccionar un cliente")

        Form = New uc_RequisitorCliente("Guardar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem6.Click
        KillForm()
        AddTitle("Seleccionar un cliente")

        Form = New uc_RequisitorCliente("Modificar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem5.Click
        KillForm()
        AddTitle("Seleccionar un cliente")

        Form = New uc_RequisitorCliente("Eliminar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListarToolStripMenuItem.Click
        KillForm()
        AddTitle("Seleccionar un cliente")

        Form = New uc_ListadoRequisitores
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    '----- CONDICIONES DE PAGO --- Begin
    Private Sub AgregarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem5.Click
        KillForm()
        AddTitle("Agregar una Condicion de pago")

        Form = New uc_CondicionesPago_Insertar()
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem5.Click
        KillForm()
        AddTitle("Modificar una Condicion de pago")

        Form = New uc_ListarCondicionesPago("Modificar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ElimanarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElimanarToolStripMenuItem.Click
        KillForm()
        AddTitle("Eliminar una Condicion de pago")

        Form = New uc_ListarCondicionesPago("Eliminar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ListadoDeCondicionesDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeCondicionesDePagoToolStripMenuItem.Click
        KillForm()
        AddTitle("Listado de Condiciones de pago")

        Form = New uc_ListadoCondicionesPago()
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub
    '----- CONDICIONES DE PAGO --- End

    '----- MATERIALES -- Begin
    Private Sub AgregarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem4.Click
        KillForm()
        AddTitle("Agregar un nuevo Material")

        Form = New uc_Material_Insertar()
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem4.Click
        KillForm()
        AddTitle("Modificar un  Material")

        Form = New uc_ListarMaterial("Modificar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem4.Click
        KillForm()
        AddTitle("Eliminar un  Material")

        Form = New uc_ListarMaterial("Eliminar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ListadoDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeMaterialesToolStripMenuItem.Click
        KillForm()
        AddTitle("Listado de Materiales")

        Form = New uc_ListadoMaterial
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub
    '----- MATERIALES -- End

    '----- PROCESOS -- Begin
    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar un nuevo Proceso")

        Form = New uc_Proceso_Insertar()
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem7.Click
        KillForm()
        AddTitle("Modificar un  Proceso")

        Form = New uc_ListarProceso("Modificar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem6.Click
        KillForm()
        AddTitle("Eliminar un  Proceso")

        Form = New uc_ListarProceso("Eliminar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ListadoDeProcesosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeProcesosToolStripMenuItem.Click
        KillForm()
        AddTitle("Listado de Procesos")

        Form = New uc_ListadoProceso
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub
    '----- PROCESOS --End 

    '----- TRATAMIENTO -- Begin
    Private Sub AgregarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem3.Click
        KillForm()
        AddTitle("Agregar Nuevo Tratamiento")

        Form = New uc_Tratamiento_Insertar
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem3.Click
        KillForm()
        AddTitle("Modificar un Tratamiento")

        Form = New uc_ListarTratamiento("Modificar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem3.Click
        KillForm()
        AddTitle("Eliminar un Tratamiento")

        Form = New uc_ListarTratamiento("Eliminar")
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ListadoDeTratamientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeTratamientosToolStripMenuItem.Click
        KillForm()
        AddTitle("Listado de Tratamientos")

        Form = New uc_ListadoTratamiento
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub
End Class
