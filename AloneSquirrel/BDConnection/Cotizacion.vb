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


        Public Function GetCondicionesDeServicio() As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`")
            DT = getDataTableQuery(strSQL.ToString)

            Return DT
        End Function

    End Class
End Namespace
