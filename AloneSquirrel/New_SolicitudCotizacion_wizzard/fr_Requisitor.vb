Imports New_SolicitudCotizacion_wizzard.Globals
Imports BDConnection.BDConnection

Public Class fr_Requisitor

    Private Sub bt_nuevoRequisitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevoRequisitor.Click
        'Mostrar el formulario para nuevo requisitor
        ShowNewRequisitorForm()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        End
    End Sub

    Private Sub bt_Cancelar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Disposed
        End
    End Sub

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub fr_Requisitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _NumeroDeCliente = Nothing Or _NumeroDeCliente = "" Then
            'Si el numero de cliente está vacío, en automatico se habilitan los controles para un nuevo requisitor
            'Mostrar el formulario para nuevo requisitor
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

            If cb_Requisitor.Items.Count > 0 Then
                cb_Requisitor.Text = "Selecciona un Requisitor"
                cb_Requisitor.SelectedValue = ""
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
        With _Requisitor
            .rq_NOMBRE = txt_Nombre.Text
            .rq_TELEFONO = txt_Telefono.Text
            .rq_EXT = txt_Ext.Text
            .rq_CELULAR = txt_Celular.Text
            .rq_RADIO = txt_Radio.Text
            .rq_CORREO = txt_Correo.Text
        End With

        'Mostrar el formulario de servicio  
        fr_Servicio.Show()
        Me.Hide()
    End Sub
End Class