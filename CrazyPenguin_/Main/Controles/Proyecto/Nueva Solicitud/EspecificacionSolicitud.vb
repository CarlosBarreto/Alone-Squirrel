Imports System.Text

Public Class EspecificacionSolicitud
    Private DT As DataTable
    Private strSQl As StringBuilder
    Private DB As DataBase

    Private _NumeroSolicitud As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _MaterialID As String
    Private _ProcesoID As String
    Private _TratamientoID As String
    Private _Cantidad As Integer
    Private _PrecioUnitario As Integer
    Private _PrecioObjetivo As Integer
    Private _CondicionEntrega As String
    Private _MaterialProporcionado As String

    'Propiedades
    Public Property NumeroSolicitud() As String
        Get
            Return _NumeroSolicitud
        End Get
        Set(value As String)
            _NumeroSolicitud = value
        End Set
    End Property

    Public Property Nombre() As String
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

    Public Property MaterialID() As String
        Get
            Return _MaterialID
        End Get
        Set(value As String)
            _MaterialID = value
        End Set
    End Property

    Public Property ProcesoID() As String
        Get
            Return _ProcesoID
        End Get
        Set(value As String)
            _ProcesoID = value
        End Set
    End Property

    Public Property TratamientoID() As String
        Get
            Return _TratamientoID
        End Get
        Set(value As String)
            _TratamientoID = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario() As Integer
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Integer)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property PrecioObjetivo() As Integer
        Get
            Return _PrecioObjetivo
        End Get
        Set(value As Integer)
            _PrecioObjetivo = value
        End Set
    End Property

    Public Property CondicionEntrega() As String
        Get
            Return _CondicionEntrega
        End Get
        Set(value As String)
            _CondicionEntrega = value
        End Set
    End Property

    Public Property MaterialProporcionado() As String
        Get
            Return _MaterialProporcionado
        End Get
        Set(value As String)
            _MaterialProporcionado = value
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

    Public Sub Especificacion_Insertar()
        strSQl = New StringBuilder

        strSQl.Append("INSERT INTO `appmigsa`.`especificacionsolicitud` ")
        strSQl.Append("(`NumeroDeEspecificacion`,`NumeroSolicitud`,`Nombre`, `Descripcion`,`MaterialID`,`ProcesoID`,`TratamientoID`,`Cantidad`,`PrecioUnitario`,`PrecioObjetivo`,`CondicionEntrega`,`MaterialProporcionado`) ")
        strSQl.Append("VALUES(0, '" & _NumeroSolicitud & "','" & _Nombre & "','" & _Descripcion & "', '" & _MaterialID & "','" & _ProcesoID & "','" & _TratamientoID & "','" & _Cantidad & "','" & _PrecioUnitario & "','" & _PrecioObjetivo & "','" & _CondicionEntrega & "','" & _MaterialProporcionado & "');")

        DT = DB.getDataTableQuery(strSQl.ToString)

        DB.SaveTransactionLog("INSERT", _NumeroSolicitud, "Se ha agregado una nueva especificacion para la solicitud de cotizacion - " & _NumeroSolicitud)

    End Sub
End Class
