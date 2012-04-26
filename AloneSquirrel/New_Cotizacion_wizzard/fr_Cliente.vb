Imports New_Cotizacion_wizzard.Globals

Public Class fr_Cliente


    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_Cliente_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub fr_Cliente_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        _EditableCliente = False
        'Rellenar los datos del cliente
        With _Cliente
            txt_Empresa.Text = .ct_EMPRESA
            txt_Domicilio.Text = .ct_DOMICILIO
            txt_Colonia.Text = .ct_COLONIA
            txt_CP.Text = .ct_CP
            txt_Ciudad.Text = .ct_CIUDAD
            txt_Estado.Text = .ct_ESTADO
            txt_Telefono.Text = .ct_TELEFONO
            txt_Ramo.Text = .ct_RAMO
            txt_NumeroDeCliente.Text = _NumeroDeCliente
        End With
    End Sub

    Private Sub bt_Editar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Editar.Click
        _EditableCliente = True
        txt_Empresa.Enabled = True
        txt_Domicilio.Enabled = True
        txt_Colonia.Enabled = True
        txt_CP.Enabled = True
        txt_Ciudad.Enabled = True
        txt_Estado.Enabled = True
        txt_Telefono.Enabled = True
        txt_Ramo.Enabled = True
    End Sub

    Private Sub bt_Siguiente_Click(sender As System.Object, e As System.EventArgs) Handles bt_Siguiente.Click
        If _EditableCliente = True Then
            'Modificar los valores del registro
            With _Cliente
                .ct_EMPRESA = txt_Empresa.Text
                .ct_DOMICILIO = txt_Domicilio.Text
                .ct_COLONIA = txt_Colonia.Text
                .ct_CP = txt_CP.Text
                .ct_CIUDAD = txt_Ciudad.Text
                .ct_ESTADO = txt_Estado.Text
                .ct_TELEFONO = txt_Telefono.Text
                .ct_RAMO = txt_Ramo.Text
            End With
        End If

        fr_Requisitor.Show()
        Me.Hide()
    End Sub
End Class