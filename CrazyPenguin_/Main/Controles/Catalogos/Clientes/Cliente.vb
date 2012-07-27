Imports System.Text

Public Class Cliente
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _NumeroDeCliente As String
    Private _Empresa As String
    Private _Domicilio As String
    Private _Colonia As String
    Private _CP As String
    Private _Ciudad As String
    Private _Estado As String
    Private _Telefono As String
    Private _Ramo As String

    '---- Propiedades
    Public Property NumeroDeCliente As String
        Get
            Return _NumeroDeCliente
        End Get
        Set(ByVal value As String)
            _NumeroDeCliente = value
        End Set
    End Property
    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(ByVal value As String)
            _Empresa = value
        End Set
    End Property
    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
        End Set
    End Property
    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(ByVal value As String)
            _Colonia = value
        End Set
    End Property
    Public Property CP As String
        Get
            Return _CP
        End Get
        Set(ByVal value As String)
            _CP = value
        End Set
    End Property
    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Ramo As String
        Get
            Return _Ramo
        End Get
        Set(ByVal value As String)
            _Ramo = value
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

    ''' <summary>
    ''' Guarda un registro del nuevo cliente
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarNuevoCliente() As String
        strSQl = New StringBuilder

        _NumeroDeCliente = DB.getSeqNo("Cliente")

        strSQl.Append("INSERT INTO `appmigsa`.`cliente` ")
        strSQl.Append("(`NumeroDeCliente`, `Empresa`, `Domicilio`, `Colonia`, `CP`, `Ciudad`, `Estado`, `Telefono`, `Ramo`) ")
        strSQl.Append("VALUES( '" & _NumeroDeCliente & "', '" & _Empresa & "', '" & _Domicilio & "', '" & _Colonia & "', '" & _CP & "', '" & _Ciudad & "', '" & _Estado & "', '" & _Telefono & "', '" & _Ramo & "');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _NumeroDeCliente, "Se ha agregado un nuevo Cliente - " & _NumeroDeCliente)

        Return _NumeroDeCliente
    End Function

    ''' <summary>
    ''' Modifica los datos de un Cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ModificarCliente()
        strSQl = New StringBuilder

        strSQl.Append("UPDATE `appmigsa`.`cliente` SET  `Empresa` = '" & _Empresa & "', `Domicilio` = '" & _Domicilio & "',")
        strSQl.Append(" `Colonia` = '" & _Colonia & "', `CP` = '" & _CP & "', `Ciudad` = '" & _Ciudad & "', `Estado` = '" & _Estado & "', `Telefono` = '" & _Telefono & "',")
        strSQl.Append(" `Ramo` = '" & _Ramo & "' WHERE `NumeroDeCliente` = '" & _NumeroDeCliente & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("UPDATE", _NumeroDeCliente, "Se ha modificado al Cliente - " & _NumeroDeCliente)
    End Sub

    ''' <summary>
    ''' Elimina a un Cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EliminarCliente()
        strSQl = New StringBuilder

        strSQl.Append("DELETE FROM `appmigsa`.`cliente` WHERE `NumeroDeCliente` = '" & _NumeroDeCliente & "'")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("DELETED", _NumeroDeCliente, "Se ha Eliminado al Cliente - " & _NumeroDeCliente)
    End Sub

    ''' <summary>
    ''' Mustra una lista con los Clientes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListaDeClientes() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT NumeroDeCliente, Empresa FROM `appmigsa`.`cliente`;")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    ''' <summary>
    ''' Lista todos los clientes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListadoClientes() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`cliente`;")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return DT
    End Function

    ''' <summary>
    ''' Lista lo datos de un cliente en especifico
    ''' </summary>
    ''' <param name="NumeroCliente">Numero de cliente a buscar</param>
    ''' <remarks></remarks>
    Public Sub BuscarClientes(ByVal NumeroCliente As String)
        strSQl = New StringBuilder

        strSQl.Append("SELECT b.NumeroDeCliente, b.Empresa, b.Domicilio, b.Colonia, b.CP, b.Ciudad, b.Estado, b.Telefono, b.Ramo ")
        strSQl.Append("FROM appmigsa.cliente AS b ")
        strSQl.Append("WHERE b.NumeroDeCliente = '" & NumeroCliente & "'; ")

        DT = DB.getDataTableQuery(strSQl.ToString)

        _NumeroDeCliente = NumeroCliente
        _Empresa = DT.Rows(0)(1).ToString
        _Domicilio = DT.Rows(0)(2).ToString
        _Colonia = DT.Rows(0)(3).ToString
        _CP = DT.Rows(0)(4).ToString
        _Ciudad = DT.Rows(0)(5).ToString
        _Estado = DT.Rows(0)(6).ToString
        _Telefono = DT.Rows(0)(7).ToString
        _Ramo = DT.Rows(0)(8).ToString

    End Sub

    Public Function ClientesAutoFill(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ClientesAutofill(")
        strSQL.Append("'" & NumeroDeCliente & "')")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function
End Class
