Public Class uc_ListadoProceso
    Private DT As DataTable

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub


    Private Sub uc_ListadoMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Proceso As New Proceso
        DT = Proceso.ListadoProceso
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Proceso.Dispose()

        DataGrid.Width = Me.Width
    End Sub
End Class
