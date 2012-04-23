Imports System.Text
Imports System.IO
Imports System.Collections.Generic
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml

''' <summary>
''' Clase encargada del manejo de los archivos PDF
''' </summary>
''' <remarks></remarks>
Public Class PDFUtility
    'Variables 
    'Not used --     Protected _PDFTemplate As String
    'Not used --     Protected _PDFFile As String

    'Propiedades
    'Not used --     Public Property PDFTemplate() As String
    'Not used --         Get
    'Not used --             If _PDFTemplate Is Nothing Then _PDFTemplate = "template.pdf"
    'Not used --             Return _PDFTemplate
    'Not used --         End Get
    'Not used --         Set(ByVal value As String)
    'Not used --             _PDFTemplate = value
    'Not used --         End Set
    'Not used --     End Property
    'Not used --     Public Property PDFFile() As String
    'Not used --         Get
    'Not used --             If _PDFFile Is Nothing Then _PDFFile = "File.pdf"
    'Not used --             Return _PDFFile
    'Not used --         End Get
    'Not used --         Set(value As String)
    'Not used --             _PDFFile = value
    'Not used --         End Set
    'Not used --     End Property

    Private Property [Delegate] As System.Action(Of PdfReader)


    Public Sub pdf_NewCotizacion(ByVal _NewFile As String)
        Dim _PDFTemplate As String

        'Determinar que archivo utilizar

        Dim pdfReader As New PdfReader(_PDFTemplate)
        Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(_NewFile, FileMode.Create))
        Dim pdfFormFields As AcroFields = pdfStamper.AcroFields

    End Sub

    'Funciones para el manejo de archivos PDF
    ''' <summary>
    ''' Lista todos los elementos del formulario en una Cadena.The
    ''' form fields identified can be used to map each of 
    ''' fields in a PDF
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ListFieldNames() As String
        Dim pdfTemplate As String = "C:\Temp\file.pdf"

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

    Public Shared Sub fillForm()
        Dim pdfTemplate As String = "C:\Temp\file.pdf"
        Dim newfile As String = "C:\Temp\Complete.pdf"
        Dim pdfReader As New PdfReader(pdfTemplate)
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


    
End Class
