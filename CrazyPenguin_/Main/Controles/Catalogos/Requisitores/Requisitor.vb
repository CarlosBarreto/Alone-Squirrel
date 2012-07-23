Imports System.Text

Public Class Requisitor
    Private DT As DataTable
    Private strSQL As StringBuilder
    Private DB As DataBase

    Private _IDRequisitor As String
    Private _NumeroDeCliente As String
    Private _Nombre As String
    Private _Telefono As String
    Private _Ext As String
    Private _Celular As String
    Private _Radio As String
    Private _Correo As String
    Private _Puesto As String

    '---- Propiedades
    Public Property IDRequisitor As String
        Get
            Return _IDRequisitor
        End Get
        Set(value As String)
            _IDRequisitor = value
        End Set
    End Property
    Public Property NumeroDeCliente As String
        Get
            Return _NumeroDeCliente
        End Get
        Set(value As String)
            _NumeroDeCliente = value
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
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Ext As String
        Get
            Return _Ext
        End Get
        Set(value As String)
            _Ext = value
        End Set
    End Property
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property
    Public Property Radio As String
        Get
            Return _Radio
        End Get
        Set(value As String)
            _Radio = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
    Public Property Puesto As String
        Get
            Return _Puesto
        End Get
        Set(value As String)
            _Puesto = value
        End Set
    End Property

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

    Public Function GuardarNuevoRequisitor() As String
        strSQL = New StringBuilder

        _IDRequisitor = DB.getSeqNo("Requisitor")

        strSQL.Append("INSERT INTO `appmigsa`.`requisitor` ")
        strSQL.Append(" (`RequisitorID`, `NumeroDeCliente`, `Nombre`, `Telefono`, `Ext`, `Celular`, `Radio`, `Correo`, `Puesto`) ")
        strSQL.Append(" VALUES('" & _IDRequisitor & "', '" & _NumeroDeCliente & "', '" & _Nombre & "', '" & _Telefono & "', '" & _Ext & "', '" & _Celular & "', '" & _Radio & "', '" & _Correo & "', '" & _Puesto & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)

        DB.SaveTransactionLog("INSERT", _IDRequisitor, "Se ha agregado un nuevo Requisitor - " & _IDRequisitor)

        Return _IDRequisitor
    End Function

    Public Sub ModificarRequisitor()
        strSQL = New StringBuilder

        strSQL.Append("UPDATE `appmigsa`.`requisitor` ")
        strSQL.Append("SET `NumeroDeCliente` = '" & _NumeroDeCliente & "', `Nombre` = '" & _Nombre & "', `Telefono` = '" & _Telefono & "', `Ext` = '" & _Ext & "',")
        strSQL.Append(" `Celular` = '" & _Celular & "', `Radio` = '" & _Radio & "', `Correo` = '" & _Correo & "', `Puesto` = '" & _Puesto & "' ")
        strSQL.Append(" WHERE RequisitorID = '" & _IDRequisitor & "';")

        DT = DB.getDataTableQuery(strSQL.ToString)

        DB.SaveTransactionLog("UPDATE", _IDRequisitor, "Se ha actualizado al Requisitor - " & _IDRequisitor)

    End Sub

    Public Sub EliminarRequisitor()
        strSQL = New StringBuilder

        strSQL.Append("DELETE FROM `appmigsa`.`requisitor` ")
        strSQL.Append("WHERE RequisitorID = '" & _IDRequisitor & "';")

        DT = DB.getDataTableQuery(strSQL.ToString)

        DB.SaveTransactionLog("DELETE", _IDRequisitor, "Se ha eliminado al Requisitor - " & _IDRequisitor)
    End Sub

    Public Function ListarRequisitores() As DataTable
        strSQL = New StringBuilder

        strSQL.Append("SELECT a.RequisitorID, a.NumeroDeCliente, b.Empresa, a.Nombre, a.Telefono, a.Ext, a.Celular, ")
        strSQL.Append("a.Radio, a.Correo, a.Puesto ")
        strSQL.Append("FROM `appmigsa`.`requisitor` AS a ")
        strSQL.Append("LEFT OUTER JOIN `appmigsa`.`cliente` AS b ON a.NumeroDeCliente = b.NumeroDeCliente ; ")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return dt
    End Function

    Public Function RequisitoresPorCliente(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT RequisitorID, Nombre FROM `appmigsa`.`requisitor` WHERE NumeroDeCliente = '" & NumeroDeCliente & "';")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Public Function MostrarDatosRequisitor(ByVal IDReq As String) As DataTable
        strSQL = New StringBuilder

        strSQL.Append("SELECT * FROM `appmigsa`.`requisitor` WHERE RequisitorID = '" & IDReq & "'; ")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function
End Class
