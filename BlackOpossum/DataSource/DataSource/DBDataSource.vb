Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Xml

Imports System.Configuration

''' <summary>
''' Clase utilizada para implementar conexiones a la Base de datos
''' </summary>
''' <remarks></remarks>
Public Class DBDataSource
    Private connString As String
    Private conn As MySqlConnection

    Private _DataTable As DataTable
    Private _DataAdapter As MySqlDataAdapter
    Private _CommandBuilder As MySqlCommandBuilder

    ''' <summary>
    ''' Genera una cadena de conexión / Make a new Connection String
    ''' </summary>
    ''' <returns>Connection String</returns>
    ''' <remarks>
    ''' <para>Mod1 - Modificada para utilizar MySQL</para>
    ''' <para>Mod2 - Modificada para utilizar App.Conf</para>
    ''' Modificada para utilizar MySQL</remarks>
    Private Function CadenaConexion() As String
        Dim ConnectionString As String
        Dim _dbServer As String, _dbUser As String, _dbPassword As String, _dbDataBase As String

        _dbServer = ConfigurationManager.AppSettings("DBServer").ToString() ', GetType(System.String)) 'ConfigurationManager.AppSettings("DBServer")
        _dbUser = ConfigurationManager.AppSettings("DBUser").ToString
        _dbPassword = ConfigurationManager.AppSettings("DBPassword").ToString
        _dbDataBase = ConfigurationManager.AppSettings("DBDataBase").ToString

        ConnectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", _
                                _dbServer, _dbUser, _dbPassword, _dbDataBase)
        Return ConnectionString
    End Function


    ''' <summary>
    ''' Constructor 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            connString = CadenaConexion()
            conn = New MySqlConnection(connString)
            conn.Open()

            'GetDatabases()
        Catch ex As MySqlException
            '_LastErrorMessage = "Error connecting to the server: " + ex.Message
            'MessageBox.Show("Error connecting to the server: " + ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Destructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Dispose()
        conn.Close()
        conn = Nothing
        connString = Nothing
    End Sub

    ''' <summary>
    ''' Query preestablecido para la lectura de las Bases de Datos del servidor
    ''' </summary>
    ''' <returns>Retorna un MySqlDataReader con el resultado de la consulta</returns>
    ''' <remarks>La Base de datos del servidor debe ser MySql</remarks>
    Public Function getDatabases() As MySqlDataReader
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand

        reader = Nothing
        cmd = New MySqlCommand("SHOW DATABASES", conn)
        reader = Nothing

        Try
            reader = cmd.ExecuteReader()
        Catch ex As MySqlException
            '_LastErrorMessage = "Failed to populate database list: " + ex.Message
            'MessageBox.Show("Failed to populate database list: " + ex.Message)
        End Try

        Return reader
    End Function

    ''' <summary>
    ''' Query preestablecido para la lectura de las tablas que componen la base de datos.
    ''' </summary>
    ''' <returns>Retorna un MySqlDataReader el resultado de la consulta</returns>
    ''' <remarks></remarks>
    Public Function showTables() As MySqlDataReader
        Dim reader As MySqlDataReader
        Dim cmd As MySqlCommand

        reader = Nothing
        cmd = New MySqlCommand("SHOW TABLES", conn)
        Try
            reader = cmd.ExecuteReader()
        Catch ex As MySqlException
            '_LastErrorMessage = "Failed to populate table list: " + ex.Message
            'MessageBox.Show("Failed to populate table list: " + ex.Message)
        End Try

        Return reader
    End Function

    ''' <summary>
    ''' Procedimiento para actualizar la Base de Datos a la que se esta conectado. Solo en tiempo de ejecución
    ''' </summary>
    ''' <param name="NewDataBase">Nombre de la Base de Datos</param>
    ''' <remarks></remarks>
    Public Sub changeDataBase(ByVal NewDataBase As String)
        Try
            conn.ChangeDatabase(NewDataBase)
        Catch ex As Exception
            '_LastErrorMessage = "Failed to change the Data Base: " + ex.Message
            'MessageBox.Show("Failed to change the Data Base: " + ex.Message)
        End Try

    End Sub


    'PROCEDIMIENTOS PARA EJECUTAR CONSULTAS
    ''' <summary>
    ''' Procedimiento para ejecutar un Query y retonar un DataTable
    ''' </summary>
    ''' <param name="strQuery">String con el Query a ejecutar</param>
    ''' <returns>DataTable con el resultado del Query</returns>
    ''' <remarks></remarks>
    Public Function getDataTableQuery(ByVal strQuery As String) As DataTable
        Try
            _DataAdapter = New MySqlDataAdapter(strQuery, conn)
            _CommandBuilder = New MySqlCommandBuilder(_DataAdapter)
            _DataTable = New DataTable

            _DataAdapter.Fill(_DataTable)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
        End Try
        Return _DataTable
        'DataGrid.DataSource = Data

    End Function
End Class



Namespace BDConnection

    ''' <summary>
    ''' Clase que implemente la conexion a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Class BDConnection


        


  

        
    End Class
End Namespace


