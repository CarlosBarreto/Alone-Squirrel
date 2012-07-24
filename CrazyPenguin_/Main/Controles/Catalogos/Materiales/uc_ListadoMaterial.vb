Public Class uc_ListadoMaterial
    Private DT As DataTable

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub


    Private Sub uc_ListadoMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim material As New Material
        DT = material.ListadoMaterial
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        material.Dispose()

        DataGrid.Width = Me.Width
    End Sub
End Class
