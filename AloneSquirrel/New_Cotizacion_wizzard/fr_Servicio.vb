Imports New_Cotizacion_wizzard.Globals

Public Class fr_Servicio
    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_Servicio_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub fr_Servicio_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        _EditableServicio = False
        'Rellenar los datos del servicio
        With _Servicio
            txt_Servicio.Text = .Servicio
            txt_Solicitud.Text = .Solicitud
            txt_Entrega.Text = .Entrega
        End With
    End Sub

    Private Sub bt_Editar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Editar.Click
        _EditableServicio = True
        txt_Servicio.Enabled = True
        txt_Solicitud.Enabled = True
        txt_Entrega.Enabled = True
    End Sub

    Private Sub bt_Siguiente_Click(sender As System.Object, e As System.EventArgs) Handles bt_Siguiente.Click
        fr_EspecificacionesServicio.Show()
        Me.Hide()
    End Sub
End Class