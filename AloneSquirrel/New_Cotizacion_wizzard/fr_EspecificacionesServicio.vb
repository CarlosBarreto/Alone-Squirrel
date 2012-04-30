Imports New_Cotizacion_wizzard.Globals

Public Class fr_EspecificacionesServicio
    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_EspecificacionesServicio_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub fr_EspecificacionesServicio_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.DataGrid.DataSource = Nothing
        Me.DataGrid.DataSource = _DT
        Me.DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Limpiar el formulario
        LimpiarEspecificaciones()

    End Sub

    Public Sub LimpiarEspecificaciones()
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        txt_Material.Text = ""
        txt_Proceso.Text = ""
        txt_Tratamiento.Text = ""
        txt_Cantidad.Text = ""
        txt_PrecioUnitario.Text = ""
        txt_PrecioObjetivo.Text = ""
        txt_CondicionesEntrega.Text = ""
        opt_Empresa.Checked = True
        opt_Cliente.Checked = False
    End Sub
End Class