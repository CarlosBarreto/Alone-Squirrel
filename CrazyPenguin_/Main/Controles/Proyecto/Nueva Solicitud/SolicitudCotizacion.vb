Imports System.Text

Public Class SolicitudCotizacion
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _NumeroSolicitud As String
    Private _NumeroDeCliente As String
    Private _IDRequisitor As String
    Private _Servicio As String
    Private _Solicitud As String
    Private _Entrega As String
    'Private _CondicionID As String
    Private _Anticipo As Integer
    Private _Resto As Integer
    Private _Credito As String
    Private _Contado As String
    Private _TiempoPago As String
    Private _Observaciones As String

    Public Property NumeroSolicitud As String
        Get
            Return _NumeroSolicitud
        End Get
        Set(value As String)
            _NumeroSolicitud = value
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

    Public Property IDRequisitor As String
        Get
            Return _IDRequisitor
        End Get
        Set(value As String)
            _IDRequisitor = value
        End Set
    End Property

    Public Property Servicio As String
        Get
            Return _Servicio
        End Get
        Set(value As String)
            _Servicio = value
        End Set
    End Property

    Public Property Solicitud As String
        Get
            Return _Solicitud
        End Get
        Set(value As String)
            _Solicitud = value
        End Set
    End Property

    Public Property Entrega As String
        Get
            Return _Entrega
        End Get
        Set(value As String)
            _Entrega = value
        End Set
    End Property

    'Public Property CondicionID As String
    '    Get
    '        Return _CondicionID
    '    End Get
    '    Set(value As String)
    '        _CondicionID = value
    '    End Set
    'End Property
    Public Property Anticipo As Integer
        Get
            Return _Anticipo
        End Get
        Set(value As Integer)
            _Anticipo = value
        End Set
    End Property
    Public Property Resto As Integer
        Get
            Return _Resto
        End Get
        Set(value As Integer)
            _Resto = value
        End Set
    End Property

    Public Property Credito As String
        Get
            Return _Credito
        End Get
        Set(value As String)
            _Credito = value
        End Set
    End Property

    Public Property Contado As String
        Get
            Return _Contado
        End Get
        Set(value As String)
            _Contado = value
        End Set
    End Property

    Public Property TiempoPago As String
        Get
            Return _TiempoPago
        End Get
        Set(value As String)
            _TiempoPago = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(value As String)
            _Observaciones = value
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

    Public Sub Solicitud_Insertar()
        strSQl = New StringBuilder

        _NumeroSolicitud = DB.getSeqNo("Solicitud")

        strSQl.Append("INSERT INTO `appmigsa`.`solicitudcotizacion` ")
        strSQl.Append("(`NumeroSolicitud`,`NumeroDeCliente`,`IDRequisitor`,`Servicio`,`Solicitud`,`Entrega`,`Anticipo`,`Resto`,`Credito`,`Contado`,`TiempoPago`, `Observaciones`, `Status`) ")
        strSQl.Append("VALUES('" & _NumeroSolicitud & "', '" & _NumeroDeCliente & "', '" & _IDRequisitor & "', '" & _Servicio & "', '" & _Solicitud & "', '" & _Entrega & "', '" & _Anticipo & "', '" & _Resto & "', '" & _Credito & "', '" & _Contado & "','" & _TiempoPago & "', '" & _Observaciones & "', 'OPEN');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _NumeroSolicitud, "Se ha agregado una nueva Solicitud de cotizacion - " & _NumeroSolicitud)

    End Sub

    Public Function ObtenerCostoMaterial(ByVal ID As String) As Integer
        strSQl = New StringBuilder
        strSQl.Append("Select CostoUnitario FROM `appmigsa`.`material` ")
        strSQl.Append("WHERE `MaterialID` = '" & ID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return Val(DT.Rows(0)("CostoUnitario").ToString)
    End Function

    Public Function ObtenerCostoProceso(ByVal ID As String) As Integer
        strSQl = New StringBuilder
        strSQl.Append("Select CostoUnitario FROM `appmigsa`.`proceso` ")
        strSQl.Append("WHERE `ProcesoID` = '" & ID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return Val(DT.Rows(0)("CostoUnitario").ToString)
    End Function

    Public Function ObtenerCostoTratamiento(ByVal ID As String) As Integer
        strSQl = New StringBuilder
        strSQl.Append("Select CostoUnitario FROM `appmigsa`.`tratamiento` ")
        strSQl.Append("WHERE `TratamientoID` = '" & ID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return Val(DT.Rows(0)("CostoUnitario").ToString)
    End Function

    Public Function ObtenerAnticipo(ByVal ID As String) As Integer
        strSQl = New StringBuilder
        strSQl.Append("Select Anticipo FROM `appmigsa`.`condiciones_pago` ")
        strSQl.Append("WHERE `CondicionID` = '" & ID & "';")

        DT = DB.getDataTableQuery(strSQl.ToString)
        Return Val(DT.Rows(0)("Anticipo").ToString)
    End Function
End Class
