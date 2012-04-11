Imports System.Text

Namespace BDConnection
    Public Class Cliente
        Inherits BDConnection

        Public Function GuardarNuevoCliente(ByVal Empresa As String, ByVal Domicilio As String, ByVal Colonia As String, ByVal CP As String, _
                                       ByVal Ciudad As String, ByVal Estado As String, ByVal Telefono As String, ByVal Ramo As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("CALL migsa_CatalogoCliente_Insertar(")
            strSQL.Append("'" & Empresa & "', ")
            strSQL.Append("'" & Domicilio & "', ")
            strSQL.Append("'" & Colonia & "', ")
            strSQL.Append("'" & CP & "', ")
            strSQL.Append("'" & Ciudad & "', ")
            strSQL.Append("'" & Estado & "', ")
            strSQL.Append("'" & Telefono & "', ")
            strSQL.Append("'" & Ramo & "');")

            DT = getDataTableQuery(strSQL.ToString)
            Return DT
            '" & Empresa & ')
        End Function

        Public Function GuardarNuevoRequisitor(ByVal NumeroDeCliente As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Ext As String, ByVal Celular As String, _
                                          ByVal Radio As String, ByVal Correo As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("CALL migsa_Requisitor_Insertar (")
            strSQL.Append("'" & NumeroDeCliente & "');")
            strSQL.Append("'" & Nombre & "');")
            strSQL.Append("'" & Telefono & "');")
            strSQL.Append("'" & Ext & "');")
            strSQL.Append("'" & Celular & "');")
            strSQL.Append("'" & Radio & "');")
            strSQL.Append("'" & Correo & "');")

            DT = getDataTableQuery(strSQL.ToString)
            Return DT
        End Function

        Public Function ListaDeClientes() As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("CALL migsa_ListaDeClientes;")
            DT = getDataTableQuery(strSQL.ToString)
            Return DT
        End Function

        Public Function ClientesAutoFill(ByVal NumeroDeCliente As String) As DataTable
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            strSQL.Append("CALL migsa_ClientesAutofill(")
            strSQL.Append("'" & NumeroDeCliente & "')")

            DT = getDataTableQuery(strSQL.ToString)
            Return DT
        End Function
    End Class
End Namespace

