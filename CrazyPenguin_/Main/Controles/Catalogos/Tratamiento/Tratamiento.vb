Imports System.Text

Public Class Tratamiento

    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _TratamientoID As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _CostoUnitario As String
    Private _Fecha As String

    Public Property TratamientoID As String
        Get
            Return _TratamientoID
        End Get
        Set(ByVal value As String)
            _TratamientoID = value
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
    Public Property CostoUnitario As Integer
        Get
            Return _CostoUnitario
        End Get
        Set(value As Integer)
            _CostoUnitario = value
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


    '---- Métodos
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

    Public Sub Tratamiento_Insertar()
        strSQl = New StringBuilder

        _TratamientoID = DB.getSeqNo("Tratamiento")

        strSQl.Append("INSERT INTO `appmigsa`.`tratamiento` ")
        strSQl.Append("(`TratamientoID`,`Nombre`,`Descripcion`,`CostoUnitario`,`Fecha`) ")
        strSQl.Append("VALUES('" & _TratamientoID & "','" & _Nombre & "','" & _Descripcion & "', '" & _CostoUnitario & "' ,'" & _Fecha & "');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _TratamientoID, "Se ha agregado un nuevo Tratamiento - " & _TratamientoID)

    End Sub

    Public Sub Tratamiento_Modificar()
        strSQl = New StringBuilder

        strSQl.Append("UPDATE `appmigsa`.`tratamiento` ")
        strSQl.Append("SET `Nombre` = '" & _Nombre & "',`Descripcion` = '" & _Descripcion & "', `CostoUnitario` = '" & _CostoUnitario & "',`Fecha` = '" & _Fecha & "' ")
        strSQl.Append("WHERE `TratamientoID`= '" & _TratamientoID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("UPDATE", _TratamientoID, "Se ha modificado un Tratamiento - " & _TratamientoID)
    End Sub

    Public Sub Tratamiento_Eliminar()
        strSQl = New StringBuilder

        strSQl.Append("DELETE FROM `appmigsa`.`tratamiento` ")
        strSQl.Append("WHERE `TratamientoID`= '" & _TratamientoID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("DELETE", _TratamientoID, "Se ha eliminado un Tratamiento - " & _TratamientoID)
    End Sub

    Public Function ListarTratamiento() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT `TratamientoID`, `Nombre` FROM `appmigsa`.`tratamiento`; ")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function ListadoTratamiento() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`tratamiento`; ")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function MostrarTratamiento(ByVal Tratamiento As String) As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`tratamiento` ")
        strSQl.Append("WHERE `TratamientoID`= '" & Tratamiento & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    
End Class
