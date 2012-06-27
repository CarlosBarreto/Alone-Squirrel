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
    Public _SolicitudCotizacion As String

    '---
    Private _BaseFont As BaseFont
    Private _EnablePagination As Boolean = False
    Private _Documents As List(Of PdfReader)
    Private _TotalPages As Integer
    '--

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
    Public _Requisitor As DatosRequisitor

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
    Public _Servicio As DatosServicio

    'ADMINSITRACION DE LOS DATOS DE LA ESPECIFICACION DE SERVICIOS
    ''' <summary>
    ''' Data table
    ''' </summary>
    ''' <remarks></remarks>
    Public _DT As DataTable
    Public Sub CreateDT()
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
        _DT.Columns.Add("MaterialesProporcionados")
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
    Public Sub FillNuevaSolicitud()
        DB = New DBDataSource

        fill_Cliente()
        fill_Requisitor()
        fill_Servicios()
        fill_DTEspecificacionServicios()
        fill_CondicionesPago()

        DB.Dispose()
        DB = Nothing
    End Sub


    ''' <summary>
    ''' Rellena la estructura de los datos del cliente a partir de _SolicitudCotizacion
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub fill_Cliente()
        Dim DT As DataTable
        DT = getDatosDelCliente(_SolicitudCotizacion)

        With _Cliente
            .ct_EMPRESA = UCase(DT.Rows(0)("Empresa"))
            .ct_DOMICILIO = UCase(DT.Rows(0)("Domicilio"))
            .ct_COLONIA = UCase(DT.Rows(0)("Colonia"))
            .ct_CP = UCase(DT.Rows(0)("CP"))
            .ct_CIUDAD = UCase(DT.Rows(0)("Ciudad"))
            .ct_ESTADO = UCase(DT.Rows(0)("Estado"))
            .ct_TELEFONO = UCase(DT.Rows(0)("Telefono"))
            .ct_RAMO = UCase(DT.Rows(0)("Ramo"))
            .ct_NUMERODECLIENTE = UCase(DT.Rows(0)("NumeroDeCliente"))
        End With

        DT = Nothing
    End Sub

    Public Sub fill_Requisitor()
        Dim DT As DataTable
        DT = getDatosDelRequisitor(_SolicitudCotizacion)

        With _Requisitor
            .rq_NOMBRE = UCase(DT.Rows(0)("Nombre"))
            .rq_TELEFONO = UCase(DT.Rows(0)("Telefono"))
            .rq_EXT = UCase(DT.Rows(0)("Ext"))
            .rq_CELULAR = UCase(DT.Rows(0)("Celular"))
            .rq_RADIO = UCase(DT.Rows(0)("Radio"))
            .rq_CORREO = UCase(DT.Rows(0)("Correo"))
            .rq_REQUISITOR = UCase(DT.Rows(0)("id_Requisitor"))
        End With

        DT = Nothing
    End Sub

    Public Sub fill_Servicios()
        Dim DT As DataTable

        DT = getDatosDelServicio(_SolicitudCotizacion)
        With _Servicio
            .Servicio = UCase(DT.Rows(0)("Servicio"))
            .Solicitud = UCase(DT.Rows(0)("Solicitud"))
            .Entrega = UCase(DT.Rows(0)("Entrega"))
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
            .Anticipo = FormatCurrency(DT.Rows(0)("Resto"), 2)
            .Resto = FormatCurrency(DT.Rows(0)("Resto"), 2)
            .Credito = UCase(DT.Rows(0)("Credito"))
            .Contado = UCase(DT.Rows(0)("Contado"))
            .TiempoPago = UCase(DT.Rows(0)("TiempoPago"))
            .Observaciones = UCase(DT.Rows(0)("Observaciones"))
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
        FillNuevaSolicitud()

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
        pdfFormFields.SetField("entrega", _Servicio.Entrega)

        'Datos del requisitor
        pdfFormFields.SetField("nombre req", _Requisitor.rq_NOMBRE)
        pdfFormFields.SetField("telefono req", _Requisitor.rq_TELEFONO)
        pdfFormFields.SetField("ext req", _Requisitor.rq_EXT)
        pdfFormFields.SetField("celular", _Requisitor.rq_CELULAR)
        pdfFormFields.SetField("radio req", _Requisitor.rq_RADIO)
        pdfFormFields.SetField("correo req", _Requisitor.rq_CORREO)

        'Fecha
        pdfFormFields.SetField("dia", DatePart(DateInterval.Day, Now))
        pdfFormFields.SetField("mes", Format(Now, "MMMM")) ' DatePart (DateInterval.Month, Now))
        pdfFormFields.SetField("año", Format(Now, "yy")) 'DatePart(DateInterval.Year, Now))

        'Especificacion servicio
        For i As Integer = 0 To _DT.Rows.Count - 1
            pdfFormFields.SetField("nombre", UCase(_DT.Rows(i)("Nombre")))
            pdfFormFields.SetField("descripcion", UCase(_DT.Rows(i)("Descripcion")))
            pdfFormFields.SetField("material", UCase(_DT.Rows(i)("Material")))
            pdfFormFields.SetField("proceso", UCase(_DT.Rows(i)("Proceso")))
            pdfFormFields.SetField("tratamiento", UCase(_DT.Rows(i)("Tratamiento")))
            pdfFormFields.SetField("cantidad", UCase(_DT.Rows(i)("Cantidad")))
            pdfFormFields.SetField("punitario", FormatCurrency(_DT.Rows(i)("PrecioUnitario"), 2))
            pdfFormFields.SetField("pobjetivo", FormatCurrency(_DT.Rows(i)("PrecioObjetivo"), 2))
            pdfFormFields.SetField("cond entrega", UCase(_DT.Rows(i)("CondicionEntrega")))
            pdfFormFields.SetField("dibujo", "")
            If _DT.Rows(i)("MaterialesProporcionados").ToString = "Empresa" Then
                pdfFormFields.SetField("empresa", "Yes")
                pdfFormFields.SetField("cliente", "No")
            Else
                pdfFormFields.SetField("empresa", "No")
                pdfFormFields.SetField("cliente", "Yes")
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

    Public Sub pdf_Solicitud2p(ByVal _NumeroSolicitud As String)
        'Determinar que archivo usar
        Dim RespPath As String
        Dim FilePath As String

        'Archivos temporales
        Dim temp1 As String, temp2 As String

        RespPath = ConfigurationManager.AppSettings("RESPATH").ToString()
        FilePath = RespPath & "RES\PDF\solicitud de cotizacion h1 2p.pdf"

        temp1 = RespPath & "TEMP\tmp_" & _NumeroSolicitud & "_1.pdf"
        'FilePath = RespPath & "RES\PDF\solicitud de cotizacion h2 +fs.pdf"


        Dim pdfReader As New PdfReader(FilePath)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(temp1, FileMode.Create))
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

        _SolicitudCotizacion = _NumeroSolicitud
        FillNuevaSolicitud()

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
        pdfFormFields.SetField("entrega", _Servicio.Entrega)

        'Datos del requisitor
        pdfFormFields.SetField("nombre req", _Requisitor.rq_NOMBRE)
        pdfFormFields.SetField("telefono req", _Requisitor.rq_TELEFONO)
        pdfFormFields.SetField("ext req", _Requisitor.rq_EXT)
        pdfFormFields.SetField("celular", _Requisitor.rq_CELULAR)
        pdfFormFields.SetField("radio req", _Requisitor.rq_RADIO)
        pdfFormFields.SetField("correo req", _Requisitor.rq_CORREO)

        'Fecha
        pdfFormFields.SetField("dia", DatePart(DateInterval.Day, Now))
        pdfFormFields.SetField("mes", Format(Now, "MMMM")) ' DatePart (DateInterval.Month, Now))
        pdfFormFields.SetField("año", Format(Now, "yy")) 'DatePart(DateInterval.Year, Now))

        'Especificacion servicio
        For i As Integer = 0 To _DT.Rows.Count - 1
            pdfFormFields.SetField("nombre" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Nombre")))
            pdfFormFields.SetField("descripcion" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Descripcion")))
            pdfFormFields.SetField("material" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Material")))
            pdfFormFields.SetField("proceso" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Proceso")))
            pdfFormFields.SetField("tratamiento" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Tratamiento")))
            pdfFormFields.SetField("cantidad" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("Cantidad")))
            pdfFormFields.SetField("punitario" & Trim(Str(i + 1)), FormatCurrency(_DT.Rows(i)("PrecioUnitario"), 2))
            pdfFormFields.SetField("pobjetivo" & Trim(Str(i + 1)), FormatCurrency(_DT.Rows(i)("PrecioObjetivo"), 2))
            pdfFormFields.SetField("condicion" & Trim(Str(i + 1)), UCase(_DT.Rows(i)("CondicionEntrega")))
            pdfFormFields.SetField("dibujo" & Trim(Str(i + 1)), "")
            If _DT.Rows(i)("MaterialesProporcionados").ToString = "Empresa" Then
                pdfFormFields.SetField("empresa" & Trim(Str(i + 1)), "Yes")
            Else
                pdfFormFields.SetField("cliente" & Trim(Str(i + 1)), "Yes")
            End If
        Next

        pdfStamper.FormFlattening = True
        pdfStamper.Close()

        pdfReader = Nothing
        pdfStamper = Nothing
        pdfFormFields = Nothing
        ' -- Termina archivo 1

        FilePath = RespPath & "RES\PDF\solicitud de cotizacion h2 +fs.pdf"
        temp2 = RespPath & "TEMP\tmp_" & _NumeroSolicitud & "_2.pdf"



        pdfReader = New PdfReader(FilePath)
        pdfStamper = New PdfStamper(pdfReader, New FileStream(temp2, FileMode.Create))
        pdfFormFields = pdfStamper.AcroFields

        pdfFormFields.SetField("no solicitud", _NumeroSolicitud)

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

        pdfStamper.FormFlattening = True
        pdfStamper.Close()

        pdfReader = Nothing
        pdfStamper = Nothing
        pdfFormFields = Nothing

        'Merge files
        _Documents = New List(Of PdfReader)
        AddDocument(temp1)
        AddDocument(temp2)
        Merge(RespPath & "FILES\SOLICITUDES\" & _NumeroSolicitud & ".pdf")

        'Borrar archivos temporales
        My.Computer.FileSystem.DeleteFile(temp1, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        My.Computer.FileSystem.DeleteFile(temp2, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)


    End Sub

    
    'Funciones para el manejo del PDF
    Public Property BaseFont As BaseFont
        Get
            Return _BaseFont
        End Get
        Set(value As BaseFont)
            _BaseFont = value
        End Set
    End Property
    Public Property EnablePagination As Boolean
        Get
            Return _EnablePagination
        End Get
        Set(value As Boolean)
            _EnablePagination = value
            If _BaseFont Is Nothing Then
                _BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            End If

        End Set
    End Property
    Public ReadOnly Property Documents As List(Of PdfReader)
        Get
            Return _Documents
        End Get
    End Property

    Public Sub AddDocument(filename As String)
        Dim pdf As New PdfReader(filename)
        _Documents.Add(pdf)
    End Sub

    Public Sub AddDocument(pdfstream As Stream)
        _Documents.Add(New PdfReader(pdfstream))
    End Sub

    Public Sub AddDocument(pdfContents As Byte())
        _Documents.Add(New PdfReader(pdfContents))
    End Sub

    Public Sub AddDocument(pdfDocument As PdfReader)
        _Documents.Add(pdfDocument)
    End Sub

    Public Sub Merge(OutputFileName As String)
        Merge(New FileStream(OutputFileName, FileMode.Create))
    End Sub

    Public Sub Merge(outputStream As Stream)
        If outputStream Is Nothing Or Not outputStream.CanWrite Then
            Throw New Exception("OutputStream es nulo o no se puede escribir en él")
        End If

        Dim NewDocument As Document = Nothing
        Try
            NewDocument = New Document
            Dim pdfWriter As PdfWriter = pdfWriter.GetInstance(NewDocument, outputStream)
            NewDocument.Open()

            Dim pdfContentByte As PdfContentByte = pdfWriter.DirectContent

            Dim totalPages As Integer
            If _EnablePagination Then
                ' _Documents.ForEach([Delegate](doc As iTextSharp.text.pdf.PdfReader )(_TotalPages = _TotalPages + doc.NumberOfPages)
            End If

            Dim currentPage As Integer = 1
            For Each PdfReader As PdfReader In _Documents
                For Page As Integer = 1 To PdfReader.NumberOfPages
                    NewDocument.NewPage()
                    Dim importedPage As PdfImportedPage = pdfWriter.GetImportedPage(PdfReader, Page)
                    pdfContentByte.AddTemplate(importedPage, 0, 0)
                Next
            Next

            If _EnablePagination Then
                pdfContentByte.BeginText()
                pdfContentByte.SetFontAndSize(BaseFont, 9)
                pdfContentByte.ShowTextAligned(pdfContentByte.ALIGN_CENTER, String.Format("{0} de {1}", currentPage + 1, totalPages), 520, 5, 0)
                pdfContentByte.EndText()
            End If

        Catch ex As Exception
        Finally
            outputStream.Flush()
            If Not IsNothing(NewDocument) Then
                NewDocument.Close()
            End If
            outputStream.Close()
        End Try
    End Sub
End Class
