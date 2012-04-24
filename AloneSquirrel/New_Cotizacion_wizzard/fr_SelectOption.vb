Imports New_Cotizacion_wizzard.Globals

Public Class fr_SelectOption

    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_SelectOption_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub


    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Presentacion.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        If Opt_Solicitud.Checked = True Then
            'Muestra las solicitudes pendientes
            fr_Solicitudes.Show()
        End If

        Me.Hide()
    End Sub
End Class