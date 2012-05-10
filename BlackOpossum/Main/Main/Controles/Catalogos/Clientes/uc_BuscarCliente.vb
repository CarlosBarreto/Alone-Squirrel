Imports System.Text
Imports DataSource

Public Class uc_BuscarCliente
    Private DB As DBDataSource


    Public Sub ppResponse(ByVal Response As String)
        'Public ppResponse As String
        txt_NumeroCliente.Text = Response
        txt_NumeroCliente.Focus()
    End Sub

    Private Sub bt_Options_Click(sender As System.Object, e As System.EventArgs) Handles bt_Options.Click
        Dim FRpopUp As New uc_PopUp
        Dim DT As DataTable

        'Conectarse a la Base de datos
        DB = New DBDataSource
        DT = ListaDeClientes()

        With FRpopUp
            .Text = "Listado de Clientes"
            .StartPosition = FormStartPosition.CenterParent
            .ParentObject = Me
            With .DataGrid
                .DataSource = DT
                .AllowDrop = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
                .RowHeadersVisible = False
                .Columns(0).Width = 60
                .Columns(1).Width = 220
            End With
        End With

        FRpopUp.Show()
        DB.Dispose()
        DB = Nothing
    End Sub


    Public Function ListaDeClientes() As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ListaDeClientes;")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function
End Class
