Public Class EspecificacionCotizacion
    Private _NumeroEspecificacion As String
    Private _NumeroCotizacion As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _MaterialID As String
    Private _ProcesoID As String
    Private _TratamientoID As String
    Private _Cantidad As Integer
    Private _PrecioUnitario As Integer

    '---- Propiedades
    Public Property NumeroEspecificacion As String
        Get
            Return _NumeroEspecificacion
        End Get
        Set(ByVal value As String)
            _NumeroEspecificacion = value
        End Set
    End Property
    Public Property NumeroCotizacion As String
        Get
            Return _NumeroCotizacion
        End Get
        Set(ByVal value As String)
            _NumeroCotizacion = value
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
    Public Property MaterialID As String
        Get
            Return _MaterialID
        End Get
        Set(ByVal value As String)
            _MaterialID = value
        End Set
    End Property
    Public Property ProcesoID As String
        Get
            Return _ProcesoID
        End Get
        Set(ByVal value As String)
            _ProcesoID = value
        End Set
    End Property
    Public Property TratamientoID As String
        Get
            Return _TratamientoID
        End Get
        Set(ByVal value As String)
            _TratamientoID = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Integer)
            _Cantidad = value
        End Set
    End Property
    Public Property PrecioUnitario As Integer
        Get
            Return _PrecioUnitario
        End Get
        Set(ByVal value As Integer)
            _PrecioUnitario = value
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
