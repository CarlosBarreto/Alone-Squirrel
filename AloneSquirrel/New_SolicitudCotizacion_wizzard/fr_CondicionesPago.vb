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
        'Agregar los datos de las condiciones de pago
        With _CondicionesPago
            .Anticipo = txt_Anticipo.Text
            .Resto = txt_Resto.Text
            .Credito = txt_Credito.Text
            .Contado = txt_Contado.Text
            .TiempoPago = txt_TipoPago.Text
            .Observaciones = txt_Observaciones.Text
        End With

        'verificar si se cuenta con numero de cliente
        If _NumeroDeCliente = "" Then
            'No se tiene numero de cliente, se procede a generar uno validando que los campos no esten vacios
            Try
                Dim BD As New Cliente
                Dim DT As DataTable

                With _Cliente
                    DT = BD.GuardarNuevoCliente(.ct_EMPRESA, .ct_DOMICILIO, .ct_COLONIA, .ct_CP, .ct_CIUDAD, _
                                           .ct_ESTADO, .ct_TELEFONO, .ct_RAMO)
                End With

                _NumeroDeCliente = DT.Rows(0)("NumeroDeCliente")
                BD.Dispose()
                BD = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
                Exit Sub
            End Try
        End If

        'verificar si se cuenta con numero de requisitor
        If _IDRequisitor = "" Then
            'Sin requisitor, se agrega uno nuevo
            Try
                Dim BD As New Cliente
                Dim DT As DataTable

                With _Requisitor
                    DT = BD.GuardarNuevoRequisitor(_NumeroDeCliente, .rq_NOMBRE, .rq_TELEFONO, .rq_EXT, .rq_CELULAR, .rq_RADIO, .rq_CORREO)
                    _IDRequisitor = DT.Rows(0)("NumeroDeCliente")
                End With
                BD.Dispose()
                BD = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
                Exit Sub
            End Try
        End If

        'Guardar solicitud
        Try
            Dim BDSolicitud As New SolicitudCotizacion
            Dim DT As DataTable

            DT = BDSolicitud.GuardarSolicitudCotizacion(_NumeroDeCliente, _IDRequisitor, _Servicio.Servicio, _Servicio.Solicitud, _
                                                   _Servicio.Entrega, _CondicionesPago.Anticipo, _CondicionesPago.Resto, _
                                                   _CondicionesPago.Credito, _CondicionesPago.Contado, _CondicionesPago.TiempoPago, _
                                                   _CondicionesPago.Observaciones)
            _NumeroCotizacion = DT.Rows(0)("_NumeroSolicitud").ToString

            BDSolicitud.Dispose()
            BDSolicitud = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
            'Exit Sub
        End Try

        'Guardar Especificaciones
        Try
            Dim BDEspecificacion As New SolicitudCotizacion
            For i As Integer = 0 To _DT.Rows.Count - 1
                BDEspecificacion.GuardarEspecificacionSolicitudCotizacion(_NumeroCotizacion, _DT.Rows(i)("Nombre"), _
                                                                          _DT.Rows(i)("Descripcion"), _DT.Rows(i)("Material"), _
                                                                          _DT.Rows(i)("Proceso"), _DT.Rows(i)("Tratamiento"), _
                                                                          _DT.Rows(i)("Cantidad"), _DT.Rows(i)("PrecioUnitario"), _
                                                                          _DT.Rows(i)("PrecioObjetivo"), _DT.Rows(i)("CondicionesEntrega"), _
                                                                          _DT.Rows(i)("MaterialProporcionado"))
            Next

            BDEspecificacion.Dispose()
            BDEspecificacion = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
            Exit Sub
        End Try

        'Generar el documento PDF

        'Cerrar aplicacion
        End
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