Imports System.Text

Public Class Proceso
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _ProcesoID As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _Fecha As String
    Private _CostoUnitario As String

    'Propiedades
    Public Property ProcesoID As String
        Get
            Return _ProcesoID
        End Get
        Set(ByVal value As String)
            _ProcesoID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Property CostoUnitario As String
        Get
            Return _CostoUnitario
        End Get
        Set(ByVal value As String)
            _CostoUnitario = value
        End Set
    End Property

    'Métodos
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

    Public Sub Proceso_Insertar()
        strSQl = New StringBuilder

        _ProcesoID = DB.getSeqNo("Proceso")

        strSQl.Append("INSERT INTO `appmigsa`.`proceso` ")
        strSQl.Append("(`ProcesoID`,`Nombre`,`Descripcion`,`CostoUnitario`,`Fecha`) ")
        strSQl.Append(" VALUES('" & _ProcesoID & "', '" & _Descripcion & "', '" & _Nombre & "', '" & _CostoUnitario & "', '" & _Fecha & "');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _ProcesoID, "Se ha agregado un nuevo Proceso - " & _ProcesoID)
    End Sub

    Public Sub Proceso_Modificar()
        strSQl = New StringBuilder

        strSQl.Append("UPDATE `appmigsa`.`proceso` ")
        strSQl.Append("SET `Nombre` = '" & _Nombre & "',`Descripcion` = '" & _Descripcion & "',`CostoUnitario` = '" & _CostoUnitario & "',`Fecha` = '" & _Fecha & "'")
        strSQl.Append("WHERE `ProcesoID` = '" & _ProcesoID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("UPDATE", _ProcesoID, "Se ha modificado un Proceso - " & _ProcesoID)
    End Sub

    Public Sub Proceso_Eliminar()
        strSQl = New StringBuilder

        strSQl.Append("DELETE FROM `appmigsa`.`proceso` ")
        strSQl.Append("WHERE `ProcesoID` = '" & _ProcesoID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("DELETE", _ProcesoID, "Se ha Eliminado un Proceso - " & _ProcesoID)
    End Sub

    Public Function ListarProceso() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT `ProcesoID`, `Nombre`  FROM `appmigsa`.`proceso`;")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function ListadoProceso() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT *  FROM `appmigsa`.`proceso`;")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function MostrarProceso(ByVal Proceso As String) As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT *  FROM `appmigsa`.`proceso` ")
        strSQl.Append("WHERE `ProcesoID` = '" & Proceso & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    
End Class
