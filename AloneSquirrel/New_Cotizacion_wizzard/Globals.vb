Public Class Globals
    'Variables publicas 
    Public Shared _SolicitudCotizacion As String


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
