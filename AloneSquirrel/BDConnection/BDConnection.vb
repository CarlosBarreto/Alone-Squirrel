Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Xml

Namespace BDConnection

    ''' <summary>
    ''' Clase que implemente la conexion a la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Class BDConnection


        ''' <summary>
        ''' Almacena el ultimo error ocurrido en la clase
        ''' </summary>
        ''' <remarks></remarks>
        Protected _LastErrorMessage As String

        Protected connStr As String
        Protected conn As MySqlConnection
        Protected _DataTable As DataTable
        Protected _DataAdapter As MySqlDataAdapter
        Protected _CommandBuilder As MySqlCommandBuilder

        Protected xDoc As New XmlDocument()


        '--- Variables de la base de datos
        ''' <summary>
        ''' Almacena el nombre del servidor de Base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Protected _dbServer As String
        ''' <summary>
        ''' Almacena el nombre de la base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Protected _dbDataBase As String
        ''' <summary>
        ''' Almacena el Id de usuario de la base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Protected _dbUser As String
        ''' <summary>
        ''' Almacena el password de acceso a la base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Protected _dbPassword As String

        ''' <summary>
        ''' Almacena la ruta del archivo XML de configuración
        ''' </summary>
        ''' <remarks></remarks>
        Protected _xmlFilePath As String

        '---------------- PROPIEDADES DE LA CLASE ----------------
        ''' <summary>
        ''' Contiene el ultimo error ocurrido en el sistema
        ''' </summary>
        ''' <value>El valor inicial es una cadena en vacia</value>
        ''' <returns>Retorna el ultimo error ocurrido en la clase</returns>
        ''' <remarks>El sistema no muestra las exepciones que ocurren, debido a esto es preferible
        '''          que se guarde el ultimo mensaje de error para que pueda ser mostrado en la 
        '''          página
        ''' </remarks>
        Public ReadOnly Property LastErrorMessage() As String
            Get
                If _LastErrorMessage Is Nothing Then _LastErrorMessage = String.Empty
                Return _LastErrorMessage
            End Get
        End Property
        ''' <summary>
        ''' Contiene el nombre del servidor de Base de Datos
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property db_Server() As String
            Get
                If _dbServer Is Nothing Then _dbServer = String.Empty
                Return _dbServer
            End Get
        End Property
        ''' <summary>
        ''' Contiene el nombre de la Base de Datos Accesada
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property db_DataBase() As String
            Get
                If _dbDataBase Is Nothing Then _dbDataBase = String.Empty
                Return _dbDataBase
            End Get
        End Property
        ''' <summary>
        ''' Contiene el ID de usuario de acceso a la Base de Datos
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property db_User() As String
            Get
                If _dbUser Is Nothing Then _dbUser = String.Empty
                Return _dbUser
            End Get
        End Property
        ''' <summary>
        ''' Contiene el ID password de acceso a la Base de Datos
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property db_Password() As String
            Get
                If _dbPassword Is Nothing Then _dbPassword = String.Empty
                Return _dbPassword
            End Get
        End Property

        ''' <summary>
        ''' Contiene el path del archivo XML de configuración
        ''' </summary>
        ''' <value>El valor inicial siempre es vacío</value>
        ''' <returns>Retorna el path del archivo de configuración</returns>
        ''' <remarks></remarks>
        Public Property XmlConfigurationFile() As String
            Get
                If _xmlFilePath Is Nothing Then _xmlFilePath = "Config.xml"
                Return _xmlFilePath
            End Get
            Set(ByVal value As String)
                _xmlFilePath = value
            End Set
        End Property

        ''' <summary>
        ''' Genera una cadena de conexión / Make a new Connection String
        ''' </summary>
        ''' <returns>Connection String</returns>
        ''' <remarks>Modificada para utilizar MySQL</remarks>
        Protected Function CadenaConexion() As String
            LoadXMLDBConfig()

            Dim connStr As String
            connStr = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", _
                                    _dbServer, _dbUser, _dbPassword, _dbDataBase)
            Return connStr
        End Function

        ''' <summary>
        ''' Lee el archivo XML especificado en _xmlFilePath para obtener los valores de conexion
        ''' a la base de datos
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub LoadXMLDBConfig()
            Dim DB_Connection As XmlNodeList
            Dim DBServer As XmlNodeList
            Dim DBUser As XmlNodeList
            Dim DBPass As XmlNodeList
            Dim DBDataBase As XmlNodeList

            ''Validar que la propiedad FilePath no este vacía / Solo para proyectos WEB
            'NOT USED --            If _xmlFilePath = "" Or _xmlFilePath Is Nothing Then
            'NOT USED --            _dbServer = WebConfigurationManager.AppSettings("DBServer").ToString ', GetType(System.String)) 'ConfigurationManager.AppSettings("DBServer")
            'NOT USED --            _dbUser = WebConfigurationManager.AppSettings("DBUser")
            'NOT USED --            _dbPassword = WebConfigurationManager.AppSettings("DBPassword")
            'NOT USED --            _dbDataBase = WebConfigurationManager.AppSettings("DBDataBase")
            'NOT USED --            Else
            xDoc.Load(XmlConfigurationFile)
            DB_Connection = xDoc.GetElementsByTagName("DB_Connection")
            For Each nodo As XmlElement In DB_Connection
                DBServer = nodo.GetElementsByTagName("Server")
                DBUser = nodo.GetElementsByTagName("User")
                DBPass = nodo.GetElementsByTagName("Pass")
                DBDataBase = nodo.GetElementsByTagName("DataBase")

                _dbServer = DBServer(0).InnerText
                _dbUser = DBUser(0).InnerText
                _dbPassword = DBPass(0).InnerText
                _dbDataBase = DBDataBase(0).InnerText
            Next
            'NOT USED --            End If
        End Sub


        ''' <summary>
        ''' Constructor 
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            Try
                connStr = CadenaConexion()
                conn = New MySqlConnection(connStr)
                conn.Open()
                _LastErrorMessage = ""

                'GetDatabases()
            Catch ex As MySqlException
                _LastErrorMessage = "Error connecting to the server: " + ex.Message
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
            connStr = Nothing
            _LastErrorMessage = ""
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
                _LastErrorMessage = "Failed to populate database list: " + ex.Message
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
                _LastErrorMessage = "Failed to populate table list: " + ex.Message
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
                _LastErrorMessage = "Failed to change the Data Base: " + ex.Message
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
End Namespace


