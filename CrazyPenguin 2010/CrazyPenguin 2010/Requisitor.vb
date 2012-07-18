Public Class Requisitor
    Private _IDRequisitor As String
    Private _NumeroDeCliente As String
    Private _Nombre As String
    Private _Telefono As String
    Private _Ext As String
    Private _Celular As String
    Private _Radio As String
    Private _Correo As String
    Private _Puesto As String

    '---- Propiedades
    Public Property IDRequisitor As String
        Get
            Return _IDRequisitor
        End Get
        Set(value As String)
            _IDRequisitor = value
        End Set
    End Property
    Public Property NumeroDeCliente As String
        Get
            Return _NumeroDeCliente
        End Get
        Set(value As String)
            _NumeroDeCliente = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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
    Public Property Ext As String
        Get
            Return _Ext
        End Get
        Set(value As String)
            _Ext = value
        End Set
    End Property
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property
    Public Property Radio As String
        Get
            Return _Radio
        End Get
        Set(value As String)
            _Radio = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
    Public Property Puesto As String
        Get
            Return _Puesto
        End Get
        Set(value As String)
            _Puesto = value
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
