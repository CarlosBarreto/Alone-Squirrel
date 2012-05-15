Imports System.Data
Imports DataSource
Imports System.Text

Namespace AppMain
    Public Class ApplicationData
        Private _DataSource As DBDataSource
        Private _DataTable As DataTable
        Private _strSQL As String

        ''' <summary>
        ''' Constructor
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            _DataSource = New DBDataSource
        End Sub

        Public Sub Dispose()
            _DataSource.Dispose()
            _DataSource = Nothing
            _DataTable = Nothing
        End Sub
        ''' <summary>
        ''' Funcion que lee de la Base de Datos, el menú de opciones
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ReadMenu() As DataTable
            Dim DT As DataTable
            DT = _DataSource.getDataTableQuery("Select * from sys_optionmenu;")
            Return DT
        End Function



    End Class
End Namespace
