Imports System.Text

Public Class DataBase
    Inherits DataSource.DBDataSource

    Private DT As DataTable
    Private strSQL As StringBuilder

    ''' <summary>
    ''' Retorna el numero consecutivo correspondiente al tipo
    ''' </summary>
    ''' <param name="SecType">Tipo de numero consecutivo</param>
    ''' <returns>Numero consecutivo</returns>
    ''' <remarks></remarks>
    Public Function getSeqNo(ByVal SecType As String) As String
        strSQL = New StringBuilder
        strSQL.Append("CALL sys_getSeqNo('" & SecType & "');")
        DT = getDataTableQuery(strSQL.ToString)

        Return DT.Rows(0)(0).ToString
    End Function

    ''' <summary>
    ''' Guarda un registro en el trnsactions Log de la aplicacion
    ''' </summary>
    ''' <param name="Type">Tipo de registro que será guardado</param>
    ''' <param name="Reference">Referencia, puede ser una clave o valor proporcionado</param>
    ''' <param name="Description">registra el tipo de transaccion que se a guardado</param>
    ''' <remarks></remarks>
    Public Sub SaveTransactionLog(ByVal Type As String, ByVal Reference As String, ByVal Description As String)
        strSQL = New StringBuilder
        'strSQL.Append("CALL sys_TransactionsLog_Insert_sp('" & Type & "', '" & Reference & "', '" & Description & "');")
        strSQL.Append("INSERT INTO sys_TransactionsLog (TransactionID, Type, Reference, Description, Date) ")
        strSQL.Append(" VALUES (0, '" & Type & "', '" & Reference & "', '" & Description & "', CAST(CURDATE() as DATETIME));")

        DT = getDataTableQuery(strSQL.ToString)
    End Sub
End Class
