Imports New_SolicitudCotizacion_wizzard.Globals

Public Class fr_CondicionesPago
    Private Sub fr_CondicionesPago__Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_EspecificacionServicio.Show()
        Me.Hide()
    End Sub

    Private Sub bt_finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_finalizar.Click
        'Guardar la solicitud

    End Sub
End Class