Imports New_Cotizacion_wizzard.Globals
Imports BDConnection.BDConnection

Public Class fr_Solicitudes
    'Opciones para cerrar la aplicacion
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub

    Private Sub fr_Solicitudes_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_SelectOption.Show()
        Me.Hide()
    End Sub

    Private Sub fr_Solicitudes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim DT As DataTable
        Dim Cotizacion As New Cotizacion
        DT = Cotizacion.GetListOfSolicitudesDeCotizacion()

        DataGrid.DataSource = DT
        Cotizacion.Dispose()
        Cotizacion = Nothing

    End Sub

    Private Sub DataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        'Determinar que celda fue la seleccionada
        MsgBox(DataGrid.Rows(e.RowIndex).Cells("NumeroSolicitud").Value.ToString)
        DataGrid.Rows(e.RowIndex).Selected = True
        _SolicitudCotizacion = DataGrid.Rows(e.RowIndex).Cells("NumeroSolicitud").Value.ToString
    End Sub

End Class