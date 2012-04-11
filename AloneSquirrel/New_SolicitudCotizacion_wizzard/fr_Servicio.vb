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
            .Entrega = txt_Entrega.Text
            .Solicitud = txt_Solicitud.Text
        End With

        'Cargar el siguiente formulario
        fr_EspecificacionServicio.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Siguiente_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Disposed
        End
    End Sub
End Class