Public Class uc_ListadoCondicionesPago
    Private DT As DataTable

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub

    Private Sub uc_ListadoCondicionesPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Condicion As New CondicionesPago
        DT = Condicion.ListadoCondicionesPago
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Condicion.Dispose()

        DataGrid.Width = Me.Width
    End Sub
End Class
