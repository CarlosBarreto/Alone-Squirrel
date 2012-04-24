Imports New_Cotizacion_wizzard.Globals

Public Class fr_Presentacion

    'Funciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub
    Private Sub fr_Presentacion_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        fr_SelectOption.Show()
        Me.Hide()
    End Sub
End Class
