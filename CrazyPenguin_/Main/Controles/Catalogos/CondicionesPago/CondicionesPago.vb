Imports System.Text

Public Class CondicionesPago
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _CondicionID As String
    Private _Nombre As String
    Private _Anticipo As Integer
    Private _Resto As Integer

    '---- Propiedades
    Public Property CondicionID As String
        Get
            Return _CondicionID
        End Get
        Set(ByVal value As String)
            _CondicionID = value
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
    Public Property Anticipo As Integer
        Get
            Return _Anticipo
        End Get
        Set(ByVal value As Integer)
            _Anticipo = value
        End Set
    End Property
    Public Property Resto As Integer
        Get
            Return _Resto
        End Get
        Set(ByVal value As Integer)
            _Resto = value
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

    Public Sub CondicionesPago_Insertar()
        strSQl = New StringBuilder

        _CondicionID = DB.getSeqNo("Condicion")

        strSQl.Append("INSERT INTO `appmigsa`.`condiciones_pago` ")
        strSQl.Append("(`CondicionID`,`Nombre`,`Anticipo`,`Resto`) ")
        strSQl.Append("VALUES('" & _CondicionID & "','" & _Nombre & "'," & _Anticipo & "," & _Resto & "); ")
        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _CondicionID, "Se ha agregado una nueva Condición de Pago - " & _CondicionID)

    End Sub

    Public Sub CondicionesPago_Modificar()
        strSQl = New StringBuilder

        strSQl.Append("UPDATE `appmigsa`.`condiciones_pago` ")
        strSQl.Append(" SET `Nombre` = '" & _Nombre & "',`Anticipo` = " & _Anticipo & ",`Resto` = " & _Resto & " ")
        strSQl.Append("WHERE `CondicionID` = '" & _CondicionID & "';")
        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("UPDATE", _CondicionID, "Se ha actualizado una Condicion de Pago - " & _CondicionID)
    End Sub

    Public Sub CondicionesPago_Eliminar()
        strSQl = New StringBuilder

        strSQl.Append("DELETE FROM `appmigsa`.`condiciones_pago` ")
        strSQl.Append("WHERE `CondicionID` = '" & _CondicionID & "';")
        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("DELETE", _CondicionID, "Se ha eliminado una condicion de pago - " & _CondicionID)
    End Sub

    Public Function ListarCondicionesPago() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT `CondicionID`, `Nombre` FROM `appmigsa`.`condiciones_pago`; ")
        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function ListadoCondicionesPago() As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`condiciones_pago`; ")
        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function

    Public Function MostrarCondicionesPago(ByVal Condicion As String) As DataTable
        strSQl = New StringBuilder

        strSQl.Append("SELECT * FROM `appmigsa`.`condiciones_pago` ")
        strSQl.Append("WHERE `CondicionID` = '" & Condicion & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)

        Return DT
    End Function
End Class
