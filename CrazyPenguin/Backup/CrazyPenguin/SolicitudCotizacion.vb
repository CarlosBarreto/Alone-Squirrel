Public Class SolicitudCotizacion
    Inherits Cliente
    Private _NumeroSolicitud As String
    Private _NumeroDeCliente As String
    Private _IDRequisitor As String
    Private _Servicio As String
    Private _Solicitud As DateTime
    Private _Entrega As DateTime
    Private _CondicionID As String
    Private _Credito As Boolean
    Private _Contado As Boolean
    Private _TiempoPago As String


    Public Property NumeroSolicitud() As String
        Get
            Return _NumeroSolicitud
        End Get
        Set(ByVal value As String)
            _NumeroSolicitud = value
        End Set
    End Property
    Public Property NumeroDeCliente() As String
        Get
            Return _NumeroDeCliente
        End Get
        Set(ByVal value As String)
            _NumeroDeCliente = value
        End Set
    End Property
    Public Property IDRequisitor() As String
        Get
            Return _IDRequisitor
        End Get
        Set(ByVal value As String)
            _IDRequisitor = value
        End Set
    End Property
    Public Property Servicio() As String
        Get
            Return _Servicio
        End Get
        Set(ByVal value As String)
            _Servicio = value
        End Set
    End Property
    Public Property solicitud() As DateTime
        Get
            Return _Solicitud
        End Get
        Set(ByVal value As DateTime)
            _Solicitud = value
        End Set
    End Property
    Public Property Entrega() As DateTime
        Get
            Return _Entrega
        End Get
        Set(ByVal value As DateTime)
            _Entrega = value
        End Set
    End Property
    Public Property CondicionID() As String
        Get
            Return _CondicionID
        End Get
        Set(ByVal value As String)
            _CondicionID = value
        End Set
    End Property
    Public Property credito() As Boolean
        Get
            Return _Credito
        End Get
        Set(ByVal value As Boolean)
            _Credito = value
        End Set
    End Property
    Public Property Contado() As Boolean
        Get
            Return _Contado
        End Get
        Set(ByVal value As Boolean)
            _Contado = value
        End Set
    End Property
    Public Property TiempoPago() As String
        Get
            Return _TiempoPago
        End Get
        Set(ByVal value As String)
            _TiempoPago = value
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
