Imports New_Cotizacion_wizzard.Globals

Public Class fr_Requisitor
    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_Requisitor_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub fr_Requisitor_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        _EditableRequisitor = False
        'Rellenar los datos del cliente
        With _Requisitor
            txt_Nombre.Text = .rq_NOMBRE
            txt_Telefono.Text = .rq_TELEFONO
            txt_Ext.Text = .rq_EXT
            txt_Celular.Text = .rq_CELULAR
            txt_Radio.Text = .rq_RADIO
            txt_Correo.Text = .GetHashCode
            txt_IDRequisitor.Text = _IDRequisitor
            txt_NumeroCliente.Text = _NumeroDeCliente
        End With
    End Sub

    Private Sub bt_Editar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Editar.Click
        txt_Nombre.Enabled = True
        txt_Telefono.Enabled = True
        txt_Ext.Enabled = True
        txt_Celular.Enabled = True
        txt_Radio.Enabled = True
        txt_Correo.Enabled = True
        txt_IDRequisitor.Enabled = True
        txt_NumeroCliente.Enabled = True
    End Sub

    Private Sub bt_Siguiente_Click(sender As System.Object, e As System.EventArgs) Handles bt_Siguiente.Click
        fr_Servicio.Show()
        Me.Hide()
    End Sub
End Class