Imports New_SolicitudCotizacion_wizzard.Globals
Imports System.Data

Public Class fr_EspecificacionServicio


    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")

    End Sub

    Private Sub fr_EspecificacionServicio_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub


    Private Sub bt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Agregar.Click

        Dim workRow As DataRow
        workRow = _DT.NewRow()

        workRow(0) = txt_Nombre.Text
        workRow(1) = txt_Descripcion.Text
        workRow(2) = txt_Material.Text
        workRow(3) = txt_Proceso.Text
        workRow(4) = txt_Tratamiento.Text
        workRow(5) = txt_Cantidad.Text
        workRow(6) = txt_PrecioUnitario.Text
        workRow(7) = txt_PrecioObjetivo.Text
        workRow(8) = txt_CondicionesEntrega.Text
        If opt_Cliente.Checked Then
            workRow(9) = "Cliente"
        Else
            workRow(9) = "Empresa"
        End If
        _DT.Rows.Add(workRow)

        Me.DataGrid.DataSource = Nothing
        Me.DataGrid.DataSource = _DT
        Me.DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Limpiar el formulario
        LimpiarEspecificaciones()
        
    End Sub

    Public Sub LimpiarEspecificaciones()
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        txt_Material.Text = ""
        txt_Proceso.Text = ""
        txt_Tratamiento.Text = ""
        txt_Cantidad.Text = ""
        txt_PrecioUnitario.Text = ""
        txt_PrecioObjetivo.Text = ""
        txt_CondicionesEntrega.Text = ""
        opt_Empresa.Checked = True
        opt_Cliente.Checked = False
    End Sub

    Private Sub bt_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Limpiar.Click
        LimpiarEspecificaciones()
    End Sub

    Private Sub fr_EspecificacionServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarEspecificaciones()
        CreateDT()
    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Servicio.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        fr_CondicionesPago.Show()
        Me.Hide()
    End Sub
End Class