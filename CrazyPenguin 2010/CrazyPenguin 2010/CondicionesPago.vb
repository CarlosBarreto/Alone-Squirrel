Public Class CondicionesPago
    Private _CondicionID As String
    Private _Nombre As String
    Private _Anticipo As Integer
    Private _Resto As Integer

    '---- Propiedades
    Public Property CondicionID As String
        Get
            Return _CondicionID
        End Get
        Set(ByVal value As String)
            _CondicionID = value
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
    Public Property Anticipo As Integer
        Get
            Return _Anticipo
        End Get
        Set(ByVal value As Integer)
            _Anticipo = value
        End Set
    End Property
    Public Property Resto As Integer
        Get
            Return _Resto
        End Get
        Set(ByVal value As Integer)
            _Resto = value
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
