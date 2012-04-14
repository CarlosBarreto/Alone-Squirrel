Imports New_SolicitudCotizacion_wizzard.Globals

Public Class fr_Pressentation

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        fr_Cliente.Show()
        Me.Hide()
    End Sub


    'Opciones para cerrar el wizzard
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub
    Private Sub fr_Pressentation_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

End Class
