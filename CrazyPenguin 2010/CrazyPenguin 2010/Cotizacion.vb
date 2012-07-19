Public Class Cotizacion
    Private _NumeroCotizacion As String
    Private _Servicio As String
    Private _NumeroProyecto As String
    Private _IDRequisitor As String
    Private _FormaPago As String
    Private _TiempoEntrega As String
    Private _DomicilioEntrega As String
    Private _CondicionesEntrega As String
    Private _MaterialProporcionado As String

    '---- Propiedades
    Public Property NumeroCotizacion As String
        Get
            Return _NumeroCotizacion
        End Get
        Set(ByVal value As String)
            _NumeroCotizacion = value
        End Set
    End Property
    Public Property Servicio As String
        Get
            Return _Servicio
        End Get
        Set(ByVal value As String)
            _Servicio = value
        End Set
    End Property
    Public Property NumeroProyecto As String
        Get
            Return _NumeroProyecto
        End Get
        Set(ByVal value As String)
            _NumeroProyecto = value
        End Set
    End Property
    Public Property IDRequisitor As String
        Get
            Return _IDRequisitor
        End Get
        Set(ByVal value As String)
            _IDRequisitor = value
        End Set
    End Property
    Public Property FormaPago As String
        Get
            Return _FormaPago
        End Get
        Set(ByVal value As String)
            _FormaPago = value
        End Set
    End Property
    Public Property TiempoEntrega As String
        Get
            Return _TiempoEntrega
        End Get
        Set(ByVal value As String)
            _TiempoEntrega = value
        End Set
    End Property
    Public Property DomicilioEntrega As String
        Get
            Return _DomicilioEntrega
        End Get
        Set(ByVal value As String)
            _DomicilioEntrega = value
        End Set
    End Property
    Public Property CondicionesEntrega As String
        Get
            Return _CondicionesEntrega
        End Get
        Set(ByVal value As String)
            _CondicionesEntrega = value
        End Set
    End Property
    Public Property MaterialProporcionado As String
        Get
            Return _MaterialProporcionado
        End Get
        Set(ByVal value As String)
            _MaterialProporcionado = value
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
