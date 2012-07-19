Public Class Tratamiento
    Private _TratamientoID As String
    Private _Nombre As String
    Private _Descripcion As String
    Private _Fecha As String

    Public Property TratamientoID As String
        Get
            Return _TratamientoID
        End Get
        Set(ByVal value As String)
            _TratamientoID = value
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
