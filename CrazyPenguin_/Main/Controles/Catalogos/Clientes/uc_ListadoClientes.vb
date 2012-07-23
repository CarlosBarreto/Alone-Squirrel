Imports DataSource
Public Class uc_ListadoClientes
    Private DT As DataTable

    Private Sub uc_ListadoClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cliente As New Cliente
        DT = Cliente.ListadoClientes()
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Cliente.Dispose()

        DataGrid.Width = Me.Width
    End Sub

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub

End Class
