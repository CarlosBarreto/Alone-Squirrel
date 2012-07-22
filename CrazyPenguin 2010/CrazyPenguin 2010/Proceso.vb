Public Class Proceso
    Private _ProcesoID As String
    Private _Nombre As String
    Private _Fecha As String
    Private _CostoUnitario As Integer

    '---- Propiedades
    Public Property ProcesoID As String
        Get
            Return _ProcesoID
        End Get
        Set(ByVal value As String)
            _ProcesoID = value
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
    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property
    Public Property CostoUnitario As String
        Get
            Return _CostoUnitario
        End Get
        Set(ByVal value As String)
            _CostoUnitario = value
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
