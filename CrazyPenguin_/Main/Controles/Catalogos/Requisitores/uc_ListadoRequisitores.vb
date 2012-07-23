Public Class uc_ListadoRequisitores
    Private DT As DataTable

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub

    Private Sub uc_ListadoRequisitores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Requisitor As New Requisitor
        DT = Requisitor.ListarRequisitores()
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Requisitor.Dispose()

        DataGrid.Width = Me.Width
    End Sub
End Class
