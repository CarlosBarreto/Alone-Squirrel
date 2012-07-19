Public Class TratamientoHist
    Private _TratamientoID As String
    Private _CostoUnitario As Integer
    Private _ProveedorID As String
    Private _Fecha As String

    Public Property TratamientoID As String
        Get
            Return _TratamientoID
        End Get
        Set(ByVal value As String)
            _TratamientoID = value
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
    Public Property ProveedorID As String
        Get
            Return _ProveedorID
        End Get
        Set(ByVal value As String)
            _ProveedorID = value
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
