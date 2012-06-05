Imports DataSource
Imports System.Text

Public Class uc_NuevaCotizacion
    'Variables de la base de datos
    Private DT As DataTable
    Private strSQL As StringBuilder
    Private DB As DBDataSource

    Private Sub tbc_SelectSolicitud_Click(sender As System.Object, e As System.EventArgs) Handles tbc_SelectSolicitud.Click
        IniciarConexion()
        DataGrid.DataSource = DT
        TerminarConexion()
    End Sub


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
        DT.Clear()

        DB = Nothing
        DT = Nothing
        strSQL = Nothing
    End Sub
End Class
