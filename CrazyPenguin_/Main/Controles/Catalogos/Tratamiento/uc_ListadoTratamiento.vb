Public Class uc_ListadoTratamiento
    Private DT As DataTable

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub


    Private Sub uc_ListadoTratamiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Tratamiento As New Tratamiento
        DT = Tratamiento.ListadoTratamiento
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tratamiento.Dispose()

        DataGrid.Width = Me.Width
    End Sub
End Class
