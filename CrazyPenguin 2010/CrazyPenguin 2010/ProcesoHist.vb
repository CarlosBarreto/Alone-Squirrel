Public Class ProcesoHist
    Private _ProcesoID As String
    Private _CostoUnitario As Integer
    Private _Fecha As String


    '---- Propiedades
    Public Property ProcesiID As String
        Get
            Return _ProcesoID
        End Get
        Set(ByVal value As String)
            _ProcesoID = value
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
