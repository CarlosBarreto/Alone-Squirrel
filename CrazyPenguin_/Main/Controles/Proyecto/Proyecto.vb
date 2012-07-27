Imports System.Text

Public Class Proyecto
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _NumeroProyecto As String
    Private _NumeroCliente As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _Fecha As String
    Private _StatusID As String

    'Propiedades
    Public Property NumeroProyecto As String
        Get
            Return _NumeroProyecto
        End Get
        Set(value As String)
            _NumeroProyecto = value
        End Set
    End Property

    Public Property NumeroCliente As String
        Get
            Return _NumeroCliente
        End Get
        Set(value As String)
            _NumeroCliente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    'Metodos
    ''' <summary>
    ''' Constructor 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        DB = New DataBase
    End Sub

    ''' <summary>
    ''' Destructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Dispose()
        DB.Dispose()
        DB = Nothing
        DT = Nothing
        strSQl = Nothing
    End Sub


    Public Function GuardarNuevoProyecto() As String
        strSQl = New StringBuilder

        _NumeroProyecto = DB.getSeqNo("Proyecto")

        strSQl.Append("INSERT INTO `appmigsa`.`proyecto` ")
        strSQl.Append("(`NumeroProyecto`,`NumeroCliente`,`Nombre`,`Descripcion`,`Fecha`,`StatusID`) ")
        strSQl.Append("VALUES('" & _NumeroProyecto & "','" & _NumeroCliente & "','" & _Nombre & "','" & _Descripcion & "','" & _Fecha & "','NEW');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _NumeroProyecto, "Se ha agregado un nuevo Cliente - " & _NumeroProyecto)
        Return _NumeroProyecto
    End Function

    Public Function MostrarDatosProyecto(ByVal Proyecto As String) As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`proyecto` ")
        strSQl.Append("WHERE `NumeroProyecto` = '" & Proyecto & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return DT
    End Function

    'Funciones privadas
    Private Sub CrearCarpetas()

    End Sub

End Class
