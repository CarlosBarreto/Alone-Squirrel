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

            strSQL.Append("-- Seleccionar los datos del cliente a partir de la Solicitud de cotizacion ")
            strSQL.Append("SELECT b.Empresa, b.Domicilio, b.Colonia, b.CP, b.Ciudad, b.Estado, b.Telefono, b.Ramo ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_catalogocliente AS b ")
            strSQL.Append("ON a.NumeroDeCliente = b.NumeroDeCliente ")
            strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

        Public Function getDatosDelRequisitor(ByVal NumeroSolicitud As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("-- Seleccionar los datos del requisitor a partir de la solicitud de cotizacion ")
            strSQL.Append("SELECT b.NumeroDeCliente, b.Nombre, b.Telefono, b.Ext, b.Celular, b.Radio, b.Correo ")
            strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_requisitor AS b ")
            strSQL.Append("ON a.id_Requisitor = b.id_Requisitor ")
            strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function
        Public Function GetCondicionesDeServicio() As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

    End Class
End Namespace
