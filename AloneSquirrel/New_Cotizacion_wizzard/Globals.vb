Imports System.Text
Imports BDConnection.BDConnection

Public Class Globals
    'Variables publicas 
    ''' <summary>
    ''' Alamacena el numero de solicitud de cotizacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _SolicitudCotizacion As String
    ''' <summary>
    ''' Almacena el numero de cotizacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _NumeroCotizacion As String
    ''' <summary>
    ''' Almacena el numero de Cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _NumeroDeCliente As String
    ''' <summary>
    ''' Almacena el ID del requisitor
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _IDRequisitor As String


    'ADMINISTRACION DE LOS DATOS DEL CLIENTE
    ''' <summary>
    ''' Estructura que almacena los datos del cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosCliente
        Public ct_EMPRESA As String
        Public ct_DOMICILIO As String
        Public ct_COLONIA As String
        Public ct_CP As String
        Public ct_CIUDAD As String
        Public ct_ESTADO As String
        Public ct_TELEFONO As String
        Public ct_RAMO As String
    End Structure
    ''' <summary>
    ''' Almacena la los datos del cliente 
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _Cliente As DatosCliente

    ''' <summary>
    ''' Rellena la estructura de los datos del cliente a partir de _SolicitudCotizacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub fill_Cliente()
        Dim DT As DataTable
        Dim Cotizacion As New Cotizacion
        DT = Cotizacion.getDatosDelCliente(_SolicitudCotizacion)

        With _Cliente
            .ct_EMPRESA = DT.Rows(0)("Empresa")
            .ct_DOMICILIO = DT.Rows(0)("Domicilio")
            .ct_COLONIA = DT.Rows(0)("Colonia")
            .ct_CP = DT.Rows(0)("CP")
            .ct_CIUDAD = DT.Rows(0)("Ciudad")
            .ct_ESTADO = DT.Rows(0)("Estado")
            .ct_TELEFONO = DT.Rows(0)("Telefono")
            .ct_RAMO = DT.Rows(0)("Ramo")
        End With

        Cotizacion.Dispose()
        Cotizacion = Nothing
        DT = Nothing
    End Sub


    'ADMINISTRACION DE LOS DATOS DEL REQUISITOR
    ''' <summary>
    ''' Estructura que alamcena los datos del requisitor
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosRequisitor
        Public rq_NOMBRE As String
        Public rq_TELEFONO As String
        Public rq_EXT As String
        Public rq_CELULAR As String
        Public rq_RADIO As String
        Public rq_CORREO As String
    End Structure
    ''' <summary>
    ''' Almacena los datos del requisitor
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _Requisitor As DatosRequisitor

    Public Shared Sub fill_Requisitor()
        Dim DT As DataTable
        Dim Cotizacion As New Cotizacion
        DT = Cotizacion.getDatosDelRequisitor(_SolicitudCotizacion)

        With _Requisitor
            .rq_NOMBRE = DT.Rows(0)("Nombre")
            .rq_TELEFONO = DT.Rows(0)("Telefono")
            .rq_EXT = DT.Rows(0)("Ext")
            .rq_CELULAR = DT.Rows(0)("Celular")
            .rq_RADIO = DT.Rows(0)("Radio")
            .rq_CORREO = DT.Rows(0)("Correo")
        End With

        Cotizacion.Dispose()
        Cotizacion = Nothing
        DT = Nothing
    End Sub

    'ADMINISTRACION DE LOS DATOS DE SERVICIO
    ''' <summary>
    ''' Estructura que almacena los datos del servicio
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosServicio
        Public Servicio As String
        Public Solicitud As String
        Public Entrega As String
    End Structure
    ''' <summary>
    ''' Almacena los datos del servicio
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _Servicio As DatosServicio

    ''' <summary>
    ''' Estructura que almacena los datos de la Especificacion de servicios
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosEspecificacionServicios
        Public Nombre As String
        Public Descripcion As String
        Public Material As String
        Public Proceso As String
        Public Tratamiento As String
        Public Cantidad As Integer
        Public PrecioUnitatio As Integer
        Public PrecioObjetivo As Integer
        Public CondicionesEntrega As String
        Public MaterialProporcionado As String
    End Structure
    ''' <summary>
    ''' Almacena los datos de la especificacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _EspecificacionServicios(0) As DatosEspecificacionServicios

    ''' <summary>
    ''' Data table
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared _DT As DataTable
    Public Shared Sub CreateDT()
        _DT = New DataTable
        _DT.Columns.Add("Nombre")
        _DT.Columns.Add("Descripcion")
        _DT.Columns.Add("Material")
        _DT.Columns.Add("Proceso")
        _DT.Columns.Add("Tratamiento")
        _DT.Columns.Add("Cantidad")
        _DT.Columns.Add("PrecioUnitario")
        _DT.Columns.Add("PrecioObjetivo")
        _DT.Columns.Add("CondicionesEntrega")
        _DT.Columns.Add("MaterialProporcionado")
    End Sub

    Public Shared _PrecioTotal As Integer

    Public Structure DatosCondicionesPago
        Public Anticipo As String
        Public Resto As String
        Public Credito As String
        Public Contado As String
        Public TiempoPago As String
        Public Observaciones As String
    End Structure
    Public Shared _CondicionesPago As DatosCondicionesPago



    ''' <summary>
    ''' Para cerrar la aplicacion
    ''' </summary>
    ''' <param name="Type">Complemento del mensaje Cancelar/Salir</param>
    ''' <remarks></remarks>
    Public Shared Sub _CancelFc(ByVal Type As String)
        Dim strMsg As String
        Dim Response As Integer

        strMsg = "Reamente deseas " + Type
        Response = MsgBox(strMsg, MsgBoxStyle.YesNo, "MIGSA")

        If Response = 6 Then
            End
        End If
    End Sub
End Class
