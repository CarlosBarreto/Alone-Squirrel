Imports System.Text
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml

Public Class PDFUtility
    'Dim pdfTemplate As String = "C:\Temp\file.pdf"
    Private _PDFSourceFile As String
    Private _PDFPATH As String

    ''' <summary>
    ''' Archivo de plantilla PDF a utilizar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PDFSourceFile As String
        Get
            Return _PDFSourceFile
        End Get
        Set(value As String)
            _PDFSourceFile = value
        End Set
    End Property

    ''' <summary>
    ''' Path donde se guardaran los archivos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PDFPATH As String
        Get
            Return _PDFPATH
        End Get
        Set(value As String)
            _PDFPATH = value
        End Set
    End Property

    Public Sub FillNuevaSolicitudH1(NumeroSolicitud As String)
        Dim newfile As String = _PDFPATH & "FILES\SOLICITUDES\" & NumeroSolicitud & ".pdf" ' "C:\Temp\Complete.pdf"

        Dim pdfReader As New PdfReader(_PDFSourceFile)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newfile, FileMode.Create))
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

        ' set form pdfFormFields
        ' The first worksheet and W-4 form

        pdfFormFields.SetField("cotizacion", "0001")
        pdfFormFields.SetField("nombre3", "0001")
        pdfFormFields.SetField("descripcion3", "0001")
        pdfFormFields.SetField("material3", "0001")
        pdfFormFields.SetField("punitario3", "0001")

        ' report by reading values from completed PDF
        Dim sTmp As String = "W-4 Completed for " + _
                pdfFormFields.GetField("f1_09(0)") + " " + _
                pdfFormFields.GetField("f1_10(0)")

        'MessageBox.Show(sTmp, "Finished")
        '    // flatten the form to remove editting options, set it to false
        '    // to leave the form open to subsequent manual edits

        pdfStamper.FormFlattening = False
        '    // close the pdf

        pdfStamper.Close()
    End Sub


    'Funciones para el manejo de archivos PDF

    ''' <summary>
    ''' Lista todos los elementos del formulario en una Cadena.The
    ''' form fields identified can be used to map each of 
    ''' fields in a PDF
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ListFieldNames() As String
        Dim pdfTemplate As String = _PDFSourceFile

        'create a new PDF reader based on the PDF template document
        Dim PDFReader As New PdfReader(pdfTemplate)

        'create and populate a string builder with each of the 
        'field names available in the subject PDF
        Dim sb As New StringBuilder
        For Each de As Object In PDFReader.AcroFields.Fields
            sb.Append(de.key.ToString + Environment.NewLine)
        Next

        Return sb.ToString()
    End Function

    'NOT USED --     Public Shared Sub fillForm()
    'NOT USED --     Dim pdfTemplate As String = "C:\Temp\file.pdf"
    'NOT USED --     Dim newfile As String = "C:\Temp\Complete.pdf"
    'NOT USED --     Dim pdfReader As New PdfReader(PdfTemplate)
    'NOT USED --     Dim pdfStamper As New PdfStamper(PdfReader, New FileStream(newfile, FileMode.Create))
    'NOT USED --     Dim pdfFormFields As AcroFields = PdfStamper.AcroFields
    'NOT USED -- 
    'NOT USED -- ' set form pdfFormFields
    'NOT USED --     ' The first worksheet and W-4 form
    'NOT USED -- 
    'NOT USED --         pdfFormFields.SetField("cotizacion", "0001")
    'NOT USED --         pdfFormFields.SetField("nombre3", "0001")
    'NOT USED --         pdfFormFields.SetField("descripcion3", "0001")
    'NOT USED --         pdfFormFields.SetField("material3", "0001")
    'NOT USED --         pdfFormFields.SetField("punitario3", "0001")
    'NOT USED -- 
    'NOT USED -- ' report by reading values from completed PDF
    'NOT USED -- Dim sTmp As String = "W-4 Completed for " + _
    'NOT USED -- pdfFormFields.GetField("f1_09(0)") + " " + _
    'NOT USED -- pdfFormFields.GetField("f1_10(0)")
    'NOT USED -- 
    'NOT USED -- MessageBox.Show(sTmp, "Finished")
    'NOT USED -- '    // flatten the form to remove editting options, set it to false
    'NOT USED -- '    // to leave the form open to subsequent manual edits
    'NOT USED -- 
    'NOT USED -- pdfStamper.FormFlattening = False
    'NOT USED -- '    // close the pdf
    'NOT USED -- 
    'NOT USED -- pdfStamper.Close()
    'NOT USED -- End Sub
End Class
