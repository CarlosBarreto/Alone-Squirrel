Imports New_SolicitudCotizacion_wizzard.Globals
Imports BDConnection.BDConnection

Public Class fr_Requisitor
    Private _NewRequisitor As Boolean

    Private Sub bt_nuevoRequisitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevoRequisitor.Click
        'Mostrar el formulario para nuevo requisitor
        ShowNewRequisitorForm()
    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub fr_Requisitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _NumeroDeCliente = Nothing Or _NumeroDeCliente = "" Then
            'Si el numero de cliente está vacío, en automatico se habilitan los controles para un nuevo requisitor
            'Mostrar el formulario para nuevo requisitor
            _NewRequisitor = True
            ShowNewRequisitorForm()
        Else
            'Obtener todos los Clientes mediante el SP
            Dim obDataTable As DataTable
            Dim BDCon As New Cliente

            obDataTable = BDCon.RequisitoresPorCliente(_NumeroDeCliente)

            'Cargar los datos del DataTable
            If obDataTable.Rows.Count > 0 Then
                cb_Requisitor.DataSource = obDataTable
                cb_Requisitor.ValueMember = obDataTable.Columns(0).ToString()
                cb_Requisitor.DisplayMember = obDataTable.Columns(1).ToString()
                cb_Requisitor.Text = ""
            End If

            'Limpiar los accesos a la base de datos
            BDCon.Dispose()
            BDCon = Nothing
            obDataTable = Nothing

            If cb_Requisitor.Items.Count > 0 Then
                _NewRequisitor = False
                'cb_Requisitor.SelectedItem = cb_Requisitor.Items(1)
                cb_Requisitor.SelectedItem = cb_Requisitor.Items(0)
            Else
                _NewRequisitor = True
                ShowNewRequisitorForm()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Permite mostrar el formulario para un nuevo requisitor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowNewRequisitorForm()
        'Ocultar controles
        lb_Requisitor.Visible = False
        cb_Requisitor.Visible = False
        bt_nuevoRequisitor.Visible = False

        'Mostrar Labels
        lb_Nombre.Visible = True
        lb_Telefono.Visible = True
        lb_Ext.Visible = True
        lb_Celular.Visible = True
        lb_Radio.Visible = True
        lb_Correo.Visible = True
        lb_NumeroCliente.Visible = True

        'Mostrar Textbox
        txt_Nombre.Visible = True
        txt_Telefono.Visible = True
        txt_Ext.Visible = True
        txt_Celular.Visible = True
        txt_Radio.Visible = True
        txt_Correo.Visible = True
        txt_NumeroCliente.Visible = True
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        'Guardar en los datos del requisitor
        If _NewRequisitor = False Then
            'Guardar el numero de requisitor
            _IDRequisitor = cb_Requisitor.SelectedValue
        Else
            _IDRequisitor = ""
            With _Requisitor
                .rq_NOMBRE = txt_Nombre.Text
                .rq_TELEFONO = txt_Telefono.Text
                .rq_EXT = txt_Ext.Text
                .rq_CELULAR = txt_Celular.Text
                .rq_RADIO = txt_Radio.Text
                .rq_CORREO = txt_Correo.Text
            End With
        End If

        'Mostrar el formulario de servicio  
        fr_Servicio.Show()
        Me.Hide()
    End Sub

    'Opciones para cerrar el wizzard
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        _CancelFc("Cancelar")
    End Sub
    Private Sub fr_Requisitor_Close(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.Closing
        _CancelFc("Salir")
        e.Cancel = True
    End Sub
End Class