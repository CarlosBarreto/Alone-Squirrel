Public Class EspecificacionSolicitud
    Inherits SolicitudCotizacion
    Private _NumeroDeEspecificacion As String
    Private _NumeroDeSolicitud As String
    Private _Nombre As String
    Private _MaterialID As String
    Private _ProcesoID As String
    Private _TratamientoID As String
    Private _Cantidad As Integer
    Private _PrecioUnitario As Integer
    Private _PrecioObjetivo As Integer
    Private _CondicionEntrega As String
    Private _MaterialesProporcionados As String

    '---- Propiedades
    Public Property NumeroDeEspecificacion() As String
        Get
            Return _NumeroDeEspecificacion
        End Get
        Set(ByVal value As String)
            _NumeroDeEspecificacion = value
        End Set
    End Property
    Public Property NumeroDeSolicitud() As String
        Get
            Return _NumeroDeSolicitud
        End Get
        Set(ByVal value As String)
            _NumeroDeSolicitud = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property MaterialID() As String
        Get
            Return _MaterialID
        End Get
        Set(ByVal value As String)
            _MaterialID = value
        End Set
    End Property
    Public Property ProcesoID() As String
        Get
            Return _ProcesoID
        End Get
        Set(ByVal value As String)
            _ProcesoID = value
        End Set
    End Property
    Public Property TratamientoID() As String
        Get
            Return _TratamientoID
        End Get
        Set(ByVal value As String)
            _TratamientoID = value
        End Set
    End Property
    Public Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property PrecioUnitario() As Integer
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Integer)
            _PrecioUnitario = value
        End Set
    End Property
    Public Property PrecioObjetivo() As Integer
        Get
            Return _PrecioObjetivo
        End Get
        Set(ByVal value As Integer)
            _PrecioObjetivo = value
        End Set
    End Property
    Public Property CondicionEntrega() As String
        Get
            Return _CondicionEntrega
        End Get
        Set(ByVal value As String)
            _CondicionEntrega = value
        End Set
    End Property
    Public Property MaterialesProporcionados() As String
        Get
            Return _MaterialesProporcionados
        End Get
        Set(ByVal value As String)
            _MaterialesProporcionados = value
        End Set
    End Property

    '---- Métodos
    Public Sub Insertar()

    End Sub
    Public Sub Modificar()

    End Sub
    Public Sub Eliminar()

    End Sub
    Public Sub Listar()

    End Sub
End Class
