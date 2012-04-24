Imports System.Text
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml

Public Class PDFUtility
    'vARIABLES


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
