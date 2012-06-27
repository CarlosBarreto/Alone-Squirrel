Imports DataSource
Imports System.Text

Public Class uc_NuevaCotizacion
    'Variables de la base de datos
    Private DT As DataTable
    Private strSQL As StringBuilder
    Private DB As DBDataSource
    Protected _OrigenDatos As String
    Protected _ObjSolicitud As NuevaSolicitud

    'Funciones usando la base de datos
    Private Sub SeleccionarSolicitudesPendientes()
        strSQL.Append("SELECT a.NumeroSolicitud, b.Empresa, a.Servicio, a.status ")
        strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_catalogocliente AS b ")
        strSQL.Append("ON a.NumeroDeCliente = b.NumeroDeCliente ")
        strSQL.Append("WHERE a.Status = 'OPEN'; ")
        'strSQL.Append("Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`")
        DT = DB.getDataTableQuery(strSQL.ToString)
    End Sub


    Private Sub IniciarConexion()
        DB = New DBDataSource
        strSQL = New StringBuilder
    End Sub
    Private Sub TerminarConexion()
        DB.Dispose()

        DB = Nothing
        DT = Nothing
        strSQL = Nothing
    End Sub


    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        'Cuando se pierde el foco, determinar si se trata de obtener los datos desde una solicitud de cotización ya establecida o se crean nuevos datos
        If Opt_Solicitud.Checked Then
            MsgBox("A partir de una solicitud")
            _OrigenDatos = "SOLICITUD"
        Else
            MsgBox("Nuevos datos")
            _OrigenDatos = "NUEVOS"
        End If

        Select Case TabControl.SelectedIndex
            Case 1
                If _OrigenDatos = "SOLICITUD" Then
                    IniciarConexion()
                    SeleccionarSolicitudesPendientes()
                    DataGrid.DataSource = DT
                    TerminarConexion()
                End If
        End Select
    End Sub

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        _ObjSolicitud = New NuevaSolicitud
        _ObjSolicitud._SolicitudCotizacion = ""

        'Determinar que celda fue la seleccionada
        MsgBox(DataGrid.Rows(e.RowIndex).Cells("NumeroSolicitud").Value.ToString)
        DataGrid.Rows(e.RowIndex).Selected = True
        _ObjSolicitud._SolicitudCotizacion = DataGrid.Rows(e.RowIndex).Cells("NumeroSolicitud").Value.ToString

        'Rellenar los datos de los clientes
        If _ObjSolicitud._SolicitudCotizacion <> "" Then
            _ObjSolicitud.FillNuevaSolicitud()

            'Rellenar los campos
            '-- Clientes
            txt_NumeroCliente.Text = _ObjSolicitud._Cliente.ct_NUMERODECLIENTE
            txt_Empresa.Text = _ObjSolicitud._Cliente.ct_EMPRESA

            txt_Servicio.Text = _ObjSolicitud._Servicio.Servicio
            dt_Entrega.Text = _ObjSolicitud._Servicio.Entrega
            dt_Solicitud.Text = _ObjSolicitud._Servicio.Solicitud

            DG_Especificacion.DataSource = _ObjSolicitud._DT
        End If
    End Sub
End Class
