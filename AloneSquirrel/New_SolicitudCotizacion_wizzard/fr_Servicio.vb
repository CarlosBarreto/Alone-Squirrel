Imports New_SolicitudCotizacion_wizzard.Globals

Public Class fr_Servicio

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Requisitor.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        'Guardar los datos del servicio
        With _Servicio
            .Servicio = txt_Servicio.Text
            .Solicitud = dt_Solicitud.Text
            .Entrega = dt_Entrega.Text
            '.Entrega = txt_Entrega.Text
            '.Solicitud = txt_Solicitud.Text
        End With

        'Cargar el siguiente formulario
        fr_EspecificacionServicio.Show()
        Me.Hide()
    End Sub

    'Opciones para cerrar el wizzard
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub
    Private Sub fr_Servicio_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub fr_Servicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dt_Entrega.Value = DateAdd(DateInterval.Day, 1, Now())
    End Sub
End Class