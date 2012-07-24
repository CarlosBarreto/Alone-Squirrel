Imports DataSource
Imports System.Text

Public Class uc_NuevaSolicitudCotización
    Private DB As DBDataSource
    Public _DT As DataTable

    '-------------------
    Dim _PrecioTotal As Integer
    Dim CondicionesLoaded As Boolean
    '-------------------
    Public Sub ppResponse(ByVal IDResponse As String, ByVal NResponse As String)
        Dim DT As DataTable
        Dim Requisitor As New Requisitor

        'Public ppResponse As String
        txt_NumeroCliente.Text = IDResponse
        txt_Empresa.Text = NResponse
        txt_NumeroCliente.Focus()

        'Mostrar Requisitores por cliente
        DT = Requisitor.RequisitoresPorCliente(IDResponse)

        'obDataTable = BDCon.RequisitoresPorCliente(_NumeroDeCliente)

        'Cargar los datos del DataTable
        If DT.Rows.Count > 0 Then
            cb_Requisitor.DataSource = DT
            cb_Requisitor.ValueMember = DT.Columns(0).ToString()
            cb_Requisitor.DisplayMember = DT.Columns(1).ToString()
            cb_Requisitor.Text = ""
        End If

        lb_Requisitor.Visible = True
        cb_Requisitor.Visible = True
    End Sub

    Private Sub bt_Options_Click(sender As System.Object, e As System.EventArgs) Handles bt_Options.Click
        Dim FRpopUp As New uc_PopUp
        Dim DT As DataTable
        Dim Cliente As New Cliente

        'Conectarse a la Base de datos
        DT = Cliente.ListaDeClientes

        With FRpopUp
            .Text = "Listado de Clientes"
            .StartPosition = FormStartPosition.CenterParent
            .ParentObject = Me
            With .DataGrid
                .DataSource = DT
                .AllowDrop = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
                .RowHeadersVisible = False
                .Columns(0).Width = 60
                .Columns(1).Width = 220
            End With
        End With

        FRpopUp.Show()
        Cliente.Dispose()
    End Sub

    Public Function ListaDeClientes() As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ListaDeClientes;")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Public Function RequisitoresPorCliente(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_RequisitoresXClientes(")
        strSQL.Append("'" & NumeroDeCliente & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Private Sub uc_NuevaSolicitudCotización_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim strSQL As New StringBuilder
        CondicionesLoaded = False

        'Ajustar los calendarios
        dt_Solicitud.Value = Now
        dt_Entrega.Value = DateAdd(DateInterval.Day, 1, Now)
        CreateDT()

        'Agregar las condiciones de pago
        Dim Condicion As New CondicionesPago
        DT = Condicion.ListadoCondicionesPago

        If DT.Rows.Count > 0 Then
            cb_Condiciones.DataSource = DT
            cb_Condiciones.ValueMember = DT.Columns(0).ToString()
            cb_Condiciones.DisplayMember = DT.Columns(1).ToString()
            cb_Condiciones.Text = ""
        End If
        Condicion.Dispose()
        DT = Nothing

        'Agregar Lista de Materiales
        Dim Material As New Material
        DT = Material.ListadoMaterial

        If DT.Rows.Count > 0 Then
            txt_Material.DataSource = DT
            txt_Material.ValueMember = DT.Columns(0).ToString()
            txt_Material.DisplayMember = DT.Columns(1).ToString()
            txt_Material.Text = ""
        End If

        Material.Dispose()
        DT = Nothing

        'Agregar Lista de procesos
        Dim Proceso As New Proceso
        DT = Proceso.ListadoProceso

        If DT.Rows.Count > 0 Then
            txt_Proceso.DataSource = DT
            txt_Proceso.ValueMember = DT.Columns(0).ToString()
            txt_Proceso.DisplayMember = DT.Columns(1).ToString()
            txt_Proceso.Text = ""
        End If

        Proceso.Dispose()
        DT = Nothing

        'Agregar Lista de Tratamiento
        Dim Tratamiento As New Tratamiento
        DT = Tratamiento.ListadoTratamiento

        If DT.Rows.Count > 0 Then
            txt_Tratamiento.DataSource = DT
            txt_Tratamiento.ValueMember = DT.Columns(0).ToString()
            txt_Tratamiento.DisplayMember = DT.Columns(1).ToString()
            txt_Tratamiento.Text = ""
        End If

        Tratamiento.Dispose()
        DT = Nothing


        CondicionesLoaded = True
    End Sub

    '-------------------------------------------------------------
    ' --------------- ESPECIFICACION DE COTIZACION ---------------
    Private Sub bt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Agregar.Click

        Dim workRow As DataRow
        workRow = _DT.NewRow()

        workRow(0) = txt_Nombre.Text
        workRow(1) = txt_Descripcion.Text
        workRow(2) = txt_Material.SelectedValue
        workRow(3) = txt_Proceso.SelectedValue
        workRow(4) = txt_Tratamiento.SelectedValue
        workRow(5) = txt_Cantidad.Text
        workRow(6) = txt_PrecioUnitario.Text
        workRow(7) = txt_PrecioObjetivo.Text
        workRow(8) = txt_CondicionesEntrega.Text
        If opt_Cliente.Checked Then
            workRow(9) = "Cliente"
        Else
            workRow(9) = "Empresa"
        End If
        _DT.Rows.Add(workRow)

        Me.DataGrid.DataSource = Nothing
        Me.DataGrid.DataSource = _DT
        Me.DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Limpiar el formulario
        LimpiarEspecificaciones()

        'Calcular el precio total
        _PrecioTotal = 0 'Inicializar

        'Recorrer la datatable para calcular el total
        For i As Integer = 0 To _DT.Rows.Count - 1
            _PrecioTotal = _PrecioTotal + (_DT.Rows(i)("PrecioUnitario") * _DT.Rows(i)("Cantidad"))
        Next

        CalcularValores()
    End Sub

    Public Sub LimpiarEspecificaciones()
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        'txt_Material_.Text = ""
        'txt_Proceso_.Text = ""
        'txt_Tratamiento_.Text = ""
        txt_Cantidad.Text = ""
        txt_PrecioUnitario.Text = ""
        txt_PrecioObjetivo.Text = ""
        txt_CondicionesEntrega.Text = ""
        opt_Empresa.Checked = True
        opt_Cliente.Checked = False
    End Sub

    Private Sub bt_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Limpiar.Click
        LimpiarEspecificaciones()
    End Sub

    Public Sub CreateDT()
        _DT = New DataTable
        _DT.Columns.Add("Nombre")
        _DT.Columns.Add("Descripcion")
        _DT.Columns.Add("Material")
        _DT.Columns.Add("Proceso")
        _DT.Columns.Add("Tratamiento")
        _DT.Columns.Add("Cantidad")
        _DT.Columns.Add("PrecioUnitario")
        _DT.Columns.Add("PrecioObjetivo")
        _DT.Columns.Add("CondicionesEntrega")
        _DT.Columns.Add("MaterialProporcionado")
    End Sub

    Public Sub CalcularValores()
        If CondicionesLoaded = True Then
            Dim Anticipo As Integer
            Dim Solicitud As New SolicitudCotizacion
            Anticipo = Solicitud.ObtenerAnticipo(cb_Condiciones.SelectedValue)
            Solicitud.Dispose()

            If CondicionesLoaded = True Then
                If Anticipo = 100 Then
                    txt_Anticipo.Text = _PrecioTotal.ToString
                    txt_Resto.Text = "0"
                ElseIf Anticipo = 0 Then
                    txt_Anticipo.Text = "0"
                    txt_Resto.Text = _PrecioTotal.ToString
                Else
                    txt_Anticipo.Text = (_PrecioTotal * Anticipo) / 100
                    txt_Resto.Text = _PrecioTotal * (100 - Anticipo) / 100
                End If
            End If
        End If
    End Sub

    Public Function CalcularCostoUnitario() As Integer
        Dim CostoUnitario As Double
        Dim Solicitud As New SolicitudCotizacion
        With Solicitud
            CostoUnitario = .ObtenerCostoMaterial(txt_Material.SelectedValue) + _
                            .ObtenerCostoProceso(txt_Proceso.SelectedValue) + _
                            .ObtenerCostoTratamiento(txt_Tratamiento.SelectedValue)
        End With

        CostoUnitario = CostoUnitario + (CostoUnitario * 0.35)

        Solicitud.Dispose()
        Return CostoUnitario
    End Function

    Private Sub cb_Condiciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Condiciones.SelectedIndexChanged
        CalcularValores()
    End Sub

    Private Sub txt_Material_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txt_Material.SelectedIndexChanged
        If CondicionesLoaded = True Then
            txt_PrecioUnitario.Text = CalcularCostoUnitario()
            txt_PrecioObjetivo.Text = Val(txt_PrecioUnitario.Text) * Val(txt_Cantidad.Text)
        End If
    End Sub

    Private Sub txt_Proceso_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txt_Proceso.SelectedIndexChanged
        If CondicionesLoaded = True Then
            txt_PrecioUnitario.Text = CalcularCostoUnitario()
            txt_PrecioObjetivo.Text = Val(txt_PrecioUnitario.Text) * Val(txt_Cantidad.Text)
        End If
    End Sub

    Private Sub txt_Tratamiento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txt_Tratamiento.SelectedIndexChanged
        If CondicionesLoaded = True Then
            txt_PrecioUnitario.Text = CalcularCostoUnitario()
            txt_PrecioObjetivo.Text = Val(txt_PrecioUnitario.Text) * Val(txt_Cantidad.Text)
        End If
    End Sub

    Private Sub txt_Cantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_Cantidad.TextChanged
        If CondicionesLoaded = True Then
            txt_PrecioUnitario.Text = CalcularCostoUnitario()
            txt_PrecioObjetivo.Text = Val(txt_PrecioUnitario.Text) * Val(txt_Cantidad.Text)
        End If
    End Sub

End Class
