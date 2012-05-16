Imports DataSource

Imports System.Configuration
Imports System.IO
Imports System.Text

Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml

Public Class NuevaSolicitud
    '-- VARIABLES --
    Private DB As DBDataSource
    Private _SolicitudCotizacion As String

    'ADMINISTRACION DE LOS DATOS DEL CLIENTE
    ''' <summary>
    ''' Estructura que almacena los datos del cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosCliente
        Public ct_NUMERODECLIENTE As String
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
    Public _Cliente As DatosCliente

    'ADMINISTRACION DE LOS DATOS DEL REQUISITOR
    ''' <summary>
    ''' Estructura que alamcena los datos del requisitor
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosRequisitor
        Public rq_REQUISITOR As String
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

    'ADMINSITRACION DE LOS DATOS DE LA ESPECIFICACION DE SERVICIOS
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

    'ADMINISTRACION DE LOS DATOS DE LAS CONDICIONES DE PAGO
    ''' <summary>
    ''' Estructura que almacena los datos de las condiciones de pago
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosCondicionesPago
        Public Anticipo As String
        Public Resto As String
        Public Credito As String
        Public Contado As String
        Public TiempoPago As String
        Public Observaciones As String
    End Structure
    Public Shared _CondicionesPago As DatosCondicionesPago


    'Funciones usando la BD
    Public Function getDatosDelCliente(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        'strSQL.Append("-- Seleccionar los datos del cliente a partir de la Solicitud de cotizacion ")
        strSQL.Append("SELECT a.NumeroDeCliente, b.Empresa, b.Domicilio, b.Colonia, b.CP, b.Ciudad, b.Estado, b.Telefono, b.Ramo ")
        strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_catalogocliente AS b ")
        strSQL.Append("ON a.NumeroDeCliente = b.NumeroDeCliente ")
        strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function

    Public Function getDatosDelRequisitor(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        'strSQL.Append("-- Seleccionar los datos del requisitor a partir de la solicitud de cotizacion ")
        strSQL.Append("SELECT b.NumeroDeCliente, a.id_Requisitor, b.Nombre, b.Telefono, b.Ext, b.Celular, b.Radio, b.Correo ")
        strSQL.Append("FROM migsa_.migsa_solicitudcotizacion AS a LEFT OUTER JOIN migsa_.migsa_requisitor AS b ")
        strSQL.Append("ON a.id_Requisitor = b.id_Requisitor ")
        strSQL.Append("WHERE a.NumeroSolicitud = '" & NumeroSolicitud & "'; ")

        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function

    Public Function getDatosDelServicio(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT Servicio, Solicitud, Entrega FROM migsa_.migsa_solicitudcotizacion ")
        strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function

    Public Function getDatosCondicionesDeServicio(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT Anticipo, Resto, Credito, Contado, TiempoPago, Observaciones ")
        strSQL.Append("FROM migsa_.migsa_solicitudcotizacion ")
        strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function

    Public Function getDatosEspecificacionesSolicitud(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT Nombre, Descripcion, Material, Proceso, Tratamiento, Cantidad, PrecioUnitario, ")
        strSQL.Append("PrecioObjetivo, CondicionEntrega, MaterialesProporcionados ")
        strSQL.Append("FROM migsa_.migsa_especificacionsolicitudcotizacion ")
        strSQL.Append("WHERE NumeroSolicitud = '" & NumeroSolicitud & "'; ")
        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function

    Public Function GetCondicionesDeServicio(ByVal NumeroSolicitud As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("Select Nombre, Anticipo, Resto From `migsa_`.`migsa_catalogocondicionespago`")
        DT = DB.getDataTableQuery(strSQL.ToString)

        Return DT
    End Function


    '-----
    ''' <summary>
    ''' Rellena la estructura de los datos del cliente a partir de _SolicitudCotizacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub fill_Cliente()
        Dim DT As DataTable
        DT = getDatosDelCliente(_SolicitudCotizacion)

        With _Cliente
            .ct_EMPRESA = DT.Rows(0)("Empresa")
            .ct_DOMICILIO = DT.Rows(0)("Domicilio")
            .ct_COLONIA = DT.Rows(0)("Colonia")
            .ct_CP = DT.Rows(0)("CP")
            .ct_CIUDAD = DT.Rows(0)("Ciudad")
            .ct_ESTADO = DT.Rows(0)("Estado")
            .ct_TELEFONO = DT.Rows(0)("Telefono")
            .ct_RAMO = DT.Rows(0)("Ramo")
            .ct_NUMERODECLIENTE = DT.Rows(0)("NumeroDeCliente")
        End With

        DT = Nothing
    End Sub

    Public Sub fill_Requisitor()
        Dim DT As DataTable
        DT = getDatosDelRequisitor(_SolicitudCotizacion)

        With _Requisitor
            .rq_NOMBRE = DT.Rows(0)("Nombre")
            .rq_TELEFONO = DT.Rows(0)("Telefono")
            .rq_EXT = DT.Rows(0)("Ext")
            .rq_CELULAR = DT.Rows(0)("Celular")
            .rq_RADIO = DT.Rows(0)("Radio")
            .rq_CORREO = DT.Rows(0)("Correo")
            .rq_REQUISITOR = DT.Rows(0)("id_Requisitor")
        End With

        DT = Nothing
    End Sub

    Public Sub fill_Servicios()
        Dim DT As DataTable

        DT = getDatosDelServicio(_SolicitudCotizacion)
        With _Servicio
            .Servicio = DT.Rows(0)("Servicio")
            .Solicitud = DT.Rows(0)("Solicitud")
            .Entrega = DT.Rows(0)("Entrega")
        End With

        DT = Nothing
    End Sub

    Public Sub fill_DTEspecificacionServicios()
        _DT = getDatosEspecificacionesSolicitud(_SolicitudCotizacion)
    End Sub

    Public Sub fill_CondicionesPago()
        Dim DT As DataTable

        DT = getDatosCondicionesDeServicio(_SolicitudCotizacion)
        With _CondicionesPago
            .Anticipo = DT.Rows(0)("Anticipo")
            .Resto = DT.Rows(0)("Resto")
            .Credito = DT.Rows(0)("Credito")
            .Contado = DT.Rows(0)("Contado")
            .TiempoPago = DT.Rows(0)("TiempoPago")
            .Observaciones = DT.Rows(0)("Observaciones")
        End With

        DT = Nothing
    End Sub
    '----------

    Public Sub pdf_Solicitud1P(ByVal _NumeroSolicitud As String)
        'Determinar que archivo usar
        Dim RespPath As String
        Dim FilePath As String

        RespPath = ConfigurationManager.AppSettings("RESPATH").ToString()
        FilePath = RespPath & "RES\PDF\solicitud de cotizacion 1p.pdf"
        Dim newfile As String = RespPath & "FILES\SOLICITUDES\" & _NumeroSolicitud & ".pdf" ' "C:\Temp\Complete.pdf"

        Dim pdfReader As New PdfReader(FilePath)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newfile, FileMode.Create))
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

        'NOT USED --       'Obtener los datos del cliente
        'NOT USED --        Dim Utility As New PDFUtility.PDFUtility
        'NOT USED --         Utility.PDFSourceFile = FilePath
        'NOT USED --         'MsgBox(Utility.ListFieldNames())

        _SolicitudCotizacion = _NumeroSolicitud
        DB = New DBDataSource

        fill_Cliente()
        fill_Requisitor()
        fill_Servicios()
        fill_DTEspecificacionServicios()
        fill_CondicionesPago()

        DB.Dispose()
        DB = Nothing

        pdfFormFields.SetField("no solicitud", _NumeroSolicitud)
        'Datos del cliente

        pdfFormFields.SetField("empresa cl", _Cliente.ct_EMPRESA)
        pdfFormFields.SetField("domicilio cl", _Cliente.ct_DOMICILIO)
        pdfFormFields.SetField("colonia cl", _Cliente.ct_COLONIA)
        pdfFormFields.SetField("ciudad cl", _Cliente.ct_CIUDAD)
        pdfFormFields.SetField("cp cl", _Cliente.ct_CP)
        pdfFormFields.SetField("telefono cl", _Cliente.ct_TELEFONO)
        pdfFormFields.SetField("ramo ind", _Cliente.ct_RAMO)
        pdfFormFields.SetField("estados cl", _Cliente.ct_ESTADO)

        'Datos del servicio
        pdfFormFields.SetField("servicio", _Servicio.Servicio)
        pdfFormFields.SetField("solicitud", _Servicio.Solicitud)
        pdfFormFields.SetField("Entrega", _Servicio.Entrega)

        'Datos del requisitor
        pdfFormFields.SetField("nombre req", _Requisitor.rq_NOMBRE)
        pdfFormFields.SetField("telefono req", _Requisitor.rq_TELEFONO)
        pdfFormFields.SetField("ext req", _Requisitor.rq_EXT)
        pdfFormFields.SetField("celular", _Requisitor.rq_CELULAR)
        pdfFormFields.SetField("radio req", _Requisitor.rq_RADIO)
        pdfFormFields.SetField("correo req", _Requisitor.rq_CORREO)

        'Fecha
        pdfFormFields.SetField("dia", DatePart(DateInterval.Day, Now))
        pdfFormFields.SetField("mes", DatePart(DateInterval.Month, Now))
        pdfFormFields.SetField("año", DatePart(DateInterval.Year, Now))

        'Especificacion servicio
        For i As Integer = 0 To _DT.Rows.Count - 1
            pdfFormFields.SetField("nombre", _DT.Rows(i)("Nombre"))
            pdfFormFields.SetField("descripcion", _DT.Rows(i)("Descripcion"))
            pdfFormFields.SetField("material", _DT.Rows(i)("Material"))
            pdfFormFields.SetField("proceso", _DT.Rows(i)("Proceso"))
            pdfFormFields.SetField("tratamiento", _DT.Rows(i)("Tratamiento"))
            pdfFormFields.SetField("cantidad", _DT.Rows(i)("Cantidad"))
            pdfFormFields.SetField("punitario", _DT.Rows(i)("PrecioUnitario"))
            pdfFormFields.SetField("pobjetivo", _DT.Rows(i)("PrecioObjetivo"))
            pdfFormFields.SetField("cond entrega", _DT.Rows(i)("CondicionEntrega"))
            pdfFormFields.SetField("dibujo", "")
            If _DT.Rows(i)("MaterialProporcionado").ToString = "Empresa" Then
                pdfFormFields.SetField("empresa", 1)
            Else
                pdfFormFields.SetField("cliente", 1)
            End If
        Next

        pdfFormFields.SetField("anticipo b", "")
        pdfFormFields.SetField("resto b", "")
        pdfFormFields.SetField("credito b", "")
        pdfFormFields.SetField("contado b", "")

        pdfFormFields.SetField("anticipo", _CondicionesPago.Anticipo)
        pdfFormFields.SetField("resto", _CondicionesPago.Resto)
        pdfFormFields.SetField("credito", _CondicionesPago.Credito)
        pdfFormFields.SetField("contado", _CondicionesPago.Contado)

        pdfFormFields.SetField("tiempo pago", _CondicionesPago.TiempoPago)
        pdfFormFields.SetField("observaciones", _CondicionesPago.Observaciones)

        pdfStamper.FormFlattening = False
        '    // close the pdf
        pdfStamper.Close()
    End Sub
End Class
