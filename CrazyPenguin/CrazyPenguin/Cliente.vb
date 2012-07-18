Public Class Cliente
    Private _NumeroDeCliente As String
    Private _Empresa As String
    Private _Domicilio As String
    Private _Colonia As String
    Private _CP As String
    Private _Ciudad As String
    Private _Estado As String
    Private _Telefono As String
    Private _Ramo As String

    '---- Propiedades
    Public Property NumeroDeCliente As String
        Get
            Return _NumeroDeCliente
        End Get
        Set(value As String)
            _NumeroDeCliente = value
        End Set
    End Property
    Public Property Empresa As String
        Get
            Return _Empresa
        End Get
        Set(value As String)
            _Empresa = value
        End Set
    End Property
    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(value As String)
            _Domicilio = value
        End Set
    End Property
    Public Property Colonia As String
        Get
            Return _CP
        End Get
        Set(value As String)
            _CP = value
        End Set
    End Property
    Public Property CP As String
        Get
            Return _CP
        End Get
        Set(value As String)
            _CP = value
        End Set
    End Property
    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
        End Set
    End Property
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Ramo As String
        Get
            Return _Ramo
        End Get
        Set(value As String)
            _Ramo = value
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
