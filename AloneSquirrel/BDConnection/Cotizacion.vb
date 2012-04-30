Imports System.Text

Namespace BDConnection
    Public Class Cotizacion
        Inherits BDConnection

        Public Function GetListOfSolicitudesDeCotizacion() As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("SELECT a.NumeroSolicitud, b.Empresa, a.Servicio, a.status ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_catalogocliente AS b ")
            strSQL.Append("ON a.NumeroDeCliente = b.NumeroDeCliente ")
            strSQL.Append("WHERE a.Status = 'OPEN'; ")

            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosDelCliente(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            'strSQL.Append("-- Seleccionar los datos del cliente a partir de la Solicitud de cotizacion ")
            strSQL.Append("SELECT a.NumeroDeCliente, b.Empresa, b.Domicilio, b.Colonia, b.CP, b.Ciudad, b.Estado, b.Telefono, b.Ramo ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_catalogocliente AS b ")
            strSQL.Append("ON a.NumeroDeCliente = b.NumeroDeCliente ")
            strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosDelRequisitor(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            'strSQL.Append("-- Seleccionar los datos del requisitor a partir de la solicitud de cotizacion ")
            strSQL.Append("SELECT b.NumeroDeCliente, a.id_Requisitor, b.Nombre, b.Telefono, b.Ext, b.Celular, b.Radio, b.Correo ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_requisitor AS b ")
            strSQL.Append("ON a.id_Requisitor = b.id_Requisitor ")
            strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosDelServicio(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("SELECT Servicio, Solicitud, Entrega FROM migsa_.migsa_solicitudcotizacion ")
            strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosCondicionesDeServicio(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("SELECT Anticipo, Resto, Credito, Contado, TiempoPago, Observaciones ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion ")
            strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosEspecificacionesSolicitud(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("SELECT Nombre, Descripcion, Material, Proceso, Tratamiento, Cantidad, PrecioUnitario, ")
            strSQL.Append("PrecioObjetivo, CondicionEntrega, MaterialesProporcionados ")
            strSQL.Append("FROM migsa_.migsa_especificacionsolicitudcotizacion ")
            strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function GetCondicionesDeServicio(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

    End Class
End Namespace
