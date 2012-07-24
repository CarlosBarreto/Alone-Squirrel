Imports System.Text

Public Class Material
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _MaterialID As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _Fecha As String
    Private _Unidad As String
    Private _Ancho As Integer
    Private _Largo As Integer
    Private _Alto As Integer
    Private _Peso As Integer
    Private _UnidadPeso As String
    Private _CostoUnitario As Integer
    Private _Padre As String

    Public Property MaterialID As String
        Get
            Return _MaterialID
        End Get
        Set(ByVal value As String)
            _MaterialID = value
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

    Public Property Unidad As String
        Get
            Return _Unidad
        End Get
        Set(ByVal value As String)
            _Unidad = value
        End Set
    End Property

    Public Property Ancho As Integer
        Get
            Return _Ancho
        End Get
        Set(ByVal value As Integer)
            _Ancho = value
        End Set
    End Property

    Public Property Largo As Integer
        Get
            Return _Largo
        End Get
        Set(ByVal value As Integer)
            _Largo = value
        End Set
    End Property

    Public Property Alto As Integer
        Get
            Return _Alto
        End Get
        Set(ByVal value As Integer)
            _Alto = value
        End Set
    End Property

    Public Property Peso As Integer
        Get
            Return _Peso
        End Get
        Set(ByVal value As Integer)
            _Peso = value
        End Set
    End Property

    Public Property UnidadPeso As String
        Get
            Return _UnidadPeso
        End Get
        Set(ByVal value As String)
            _UnidadPeso = value
        End Set
    End Property

    Public Property CostoUnitario As Integer
        Get
            Return _CostoUnitario
        End Get
        Set(ByVal value As Integer)
            _CostoUnitario = value
        End Set
    End Property

    Public Property Padre As String
        Get
            Return _Padre
        End Get
        Set(ByVal value As String)
            _Padre = value
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

    Public Sub Material_Insertar()
        strSQl = New StringBuilder

        _MaterialID = DB.getSeqNo("Material")

        strSQl.Append("INSERT INTO `appmigsa`.`material` ")
        strSQl.Append("(`MaterialID`,`Nombre`,`Descripcion`,`Fecha`,`Unidad`,`Ancho`,`Largo`,`Alto`,`Peso`,`UnidadPeso`,`CostoUnitario`,`Padre`) ")
        strSQl.Append("VALUES('" & _MaterialID & "', '" & _Nombre & "','" & _Descripcion & "', '" & _Fecha & "', '" & _Unidad & "', ")
        strSQl.Append("'" & _Ancho & "','" & _Largo & "','" & _Alto & "','" & _Peso & "','" & _UnidadPeso & "','" & _CostoUnitario & "','" & _Padre & "');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _MaterialID, "Se ha agregado un nuevo Material- " & _MaterialID)
    End Sub

    Public Sub Material_Modificar()
        strSQl = New StringBuilder

        strSQl.Append("UPDATE `appmigsa`.`material` ")
        strSQl.Append(" SET `Nombre` = '" & _Nombre & "',`Descripcion` = '" & _Descripcion & "',`Fecha` = '" & _Fecha & "', ")
        strSQl.Append("`Unidad` = '" & _Unidad & "',`Ancho` = '" & _Ancho & "',`Largo` = '" & _Largo & "',`Alto` = '" & _Alto & "', ")
        strSQl.Append("`Peso` = '" & _Peso & "',`UnidadPeso` = '" & _UnidadPeso & "',`CostoUnitario` = '" & _CostoUnitario & "',`Padre` = '" & _Padre & "' ")
        strSQl.Append(" WHERE `MaterialID` = '" & _MaterialID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("UPDATE", _MaterialID, "Se ha modificado a un Material- " & _MaterialID)
    End Sub

    Public Sub Material_Eliminar()
        strSQl = New StringBuilder

        strSQl.Append("DELETE FROM `appmigsa`.`material` ")
        strSQl.Append(" WHERE `MaterialID` = '" & _MaterialID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("DELETE", _MaterialID, "Se ha eliminado un Material- " & _MaterialID)
    End Sub

    Public Function ListarMaterial() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("Select `MaterialID`, `Nombre` FROM `appmigsa`.`material`;")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return DT
    End Function

    Public Function ListadoMaterial() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("Select * FROM `appmigsa`.`material`;")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return DT
    End Function

    Public Function MostrarMaterial(ByVal Material As String) As DataTable
        strSQl = New StringBuilder

        strSQl.Append("Select * FROM `appmigsa`.`material` ")
        strSQl.Append("WHERE `MaterialID` = '" & Material & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return DT
    End Function

    
End Class
