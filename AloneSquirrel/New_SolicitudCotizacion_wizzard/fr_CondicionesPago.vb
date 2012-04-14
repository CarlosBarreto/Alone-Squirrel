Imports New_SolicitudCotizacion_wizzard.Globals
Imports BDConnection.BDConnection

Public Class fr_CondicionesPago
    Private _isLoaded As Boolean

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

    Private Sub fr_CondicionesPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obDataTable As DataTable
        Dim BDCon As New SolicitudCotizacion

        _isLoaded = False
        obDataTable = BDCon.GetCondicionesDeServicio
        If obDataTable.Rows.Count > 0 Then
            cb_Condiciones.DataSource = obDataTable
            cb_Condiciones.ValueMember = obDataTable.Columns(1).ToString()
            cb_Condiciones.DisplayMember = obDataTable.Columns(0).ToString()
            cb_Condiciones.Text = ""
        End If

        'Limpiar los accesos a la base de datos
        BDCon.Dispose()
        BDCon = Nothing
        obDataTable = Nothing

        obDataTable = _DT
        _PrecioTotal = 0 'Inicializar

        'Recorrer la datatable para calcular el total
        For i As Integer = 0 To obDataTable.Rows.Count - 1
            _PrecioTotal = _PrecioTotal + (obDataTable.Rows(i)("PrecioUnitario") * obDataTable.Rows(i)("Cantidad"))
        Next

        If cb_Condiciones.Items.Count > 0 Then
            cb_Condiciones.SelectedItem = cb_Condiciones.Items(1)
            cb_Condiciones.SelectedItem = cb_Condiciones.Items(0)

            If cb_Condiciones.SelectedValue = 100 Then
                txt_Anticipo.Text = _PrecioTotal.ToString
                txt_Resto.Text = "0"
            ElseIf cb_Condiciones.SelectedValue = 0 Then
                txt_Anticipo.Text = "0"
                txt_Resto.Text = _PrecioTotal.ToString
            Else
                txt_Anticipo.Text = (_PrecioTotal * cb_Condiciones.SelectedValue) / 100
                txt_Resto.Text = _PrecioTotal * (100 - cb_Condiciones.SelectedValue) / 100
            End If

        End If
        _isLoaded = True
    End Sub

    Public Sub CalcularValores()
        'Asignar los valores 
        If cb_Condiciones.SelectedValue = 100 Then
            txt_Anticipo.Text = _PrecioTotal.ToString
            txt_Resto.Text = "0"
        ElseIf cb_Condiciones.SelectedValue = 0 Then
            txt_Anticipo.Text = "0"
            txt_Resto.Text = _PrecioTotal.ToString
        Else
            txt_Anticipo.Text = (_PrecioTotal * cb_Condiciones.SelectedValue) / 100
            txt_Resto.Text = _PrecioTotal * (100 - cb_Condiciones.SelectedValue) / 100
        End If
    End Sub

    Private Sub cb_Condiciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Condiciones.SelectedIndexChanged
        If _isLoaded = True Then
            CalcularValores()
        End If
    End Sub
End Class