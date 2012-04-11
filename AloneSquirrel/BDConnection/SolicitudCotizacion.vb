Imports System.Text

Namespace BDConnection
    Public Class SolicitudCotizacion
        Inherits BDConnection

        Public Sub GuardarSolicitudCotizacion(ByVal NumeroDeCliente As String, ByVal ID_Requisitor As String, ByVal Servicio As String, ByVal Solicitud As String, _
                                              ByVal Entrega As String, ByVal Anticipo As String, ByVal Resto As String, ByVal Credito As String, ByVal Contado As String, _
                                              ByVal TiempoPago As String, ByVal Observaciones As String)
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("CALL migsa_SolicitudCotizacion_Insertar(")
            strSQL.Append("'" & NumeroDeCliente & "', ")
            strSQL.Append("'" & ID_Requisitor & "', ")
            strSQL.Append("'" & Servicio & "', ")
            strSQL.Append("'" & Solicitud & "', ")
            strSQL.Append("'" & Entrega & "', ")
            strSQL.Append("'" & Anticipo & "', ")
            strSQL.Append("'" & Resto & "', ")
            strSQL.Append("'" & Credito & "', ")
            strSQL.Append("'" & Contado & "', ")
            strSQL.Append("'" & TiempoPago & "', ")
            strSQL.Append("'" & Observaciones & "'); ")

            DT = getDataTableQuery(strSQL.ToString)
        End Sub

        Public Sub GuardarEspecificacionSolicitudCotizacion(ByVal NumeroSolicitud As String, ByVal Nombre As String, ByVal Descripcion As String, _
                                                            ByVal Material As String, ByVal Proceso As String, ByVal Tratamiento As String, ByVal Cantidad As Integer, _
                                                            ByVal PrecioUnitario As Integer, ByVal PrecioObjetivo As Integer, ByVal CondicionesEntrega As String, ByVal MaterialProporcionado As String)
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("migsa_EspecificacionSolicitudCotizacion_Insertar(")
            strSQL.Append("'" & NumeroSolicitud & "', ")
            strSQL.Append("'" & Nombre & "', ")
            strSQL.Append("'" & Descripcion & "', ")
            strSQL.Append("'" & Material & "', ")
            strSQL.Append("'" & Proceso & "', ")
            strSQL.Append("'" & Tratamiento & "', ")
            strSQL.Append("'" & Cantidad & "', ")
            strSQL.Append("'" & PrecioUnitario & "', ")
            strSQL.Append("'" & PrecioObjetivo & "', ")
            strSQL.Append("'" & CondicionesEntrega & "', ")
            strSQL.Append("'" & Material & "'); ")

            DT = getDataTableQuery(strSQL.ToString)
        End Sub
    End Class
End Namespace