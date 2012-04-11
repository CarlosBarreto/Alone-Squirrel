Imports New_SolicitudCotizacion_wizzard.Globals
Imports BDConnection.BDConnection

Public Class fr_Cliente

    Private Sub bt_Anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Anterior.Click
        fr_Pressentation.Show()
        Me.Hide()
    End Sub

    Private Sub bt_nuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_nuevoCliente.Click
        ShowNewClientForm()
    End Sub

    ''' <summary>
    ''' Funcion encargada de mostrar los controles para agregar un nuevo cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowNewClientForm()
        'Visualizar los Labels
        lb_Empresa.Visible = True
        lb_Domicilio.Visible = True
        lb_Colonia.Visible = True
        lb_CP.Visible = True
        lb_Ciudad.Visible = True
        lb_Estado.Visible = True
        lb_Telefono.Visible = True
        lb_Ramo.Visible = True

        'Visualizar los TextBox
        txt_Empresa.Visible = True
        txt_Domicilio.Visible = True
        txt_Colonia.Visible = True
        txt_CP.Visible = True
        txt_Ciudad.Visible = True
        txt_Estado.Visible = True
        txt_Telefono.Visible = True
        txt_Ramo.Visible = True

        'Ocultar el resto de los controles
        lb_Cliente.Visible = False
        cb_Cliente.Visible = False
        bt_nuevoCliente.Visible = False
        'bt_Guardar.Visible = True
        'bt_Ca()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        End
    End Sub

    Private Sub bt_Cancelar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Disposed
        End
    End Sub

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click
        'Determinar si se seleccionó un Cliente
        If cb_Cliente.SelectedValue <> "" Then
            'Guardar el numero de cliente
            _NumeroDeCliente = cb_Cliente.SelectedValue
        Else
            If txt_Empresa.Visible = False Then
                MsgBox("Es necesario que seleccione un cliente", MsgBoxStyle.Critical, "MIGSA")
                Exit Sub
            End If
        End If
        'Guardar los datos del cliente en la variable global correspondiente
        If _NumeroDeCliente = Nothing Or _NumeroDeCliente = "" Then
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

    Private Sub fr_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Obtener todos los Clientes mediante el SP
        Dim obDataTable As DataTable
        Dim BDCon As New Cliente

        obDataTable = BDCon.ListaDeClientes
        'Cargar los datos del DataTable
        If obDataTable.Rows.Count > 0 Then
            cb_Cliente.DataSource = obDataTable
            cb_Cliente.ValueMember = obDataTable.Columns(0).ToString()
            cb_Cliente.DisplayMember = obDataTable.Columns(1).ToString()
            cb_Cliente.Text = ""
        End If

        If cb_Cliente.Items.Count > 0 Then
            cb_Cliente.Text = "Selecciona un Cliente"
            cb_Cliente.SelectedValue = ""
        End If



        'Cargar los valores desde la estructura cliente
        With _Cliente
            txt_Empresa.Text = .ct_EMPRESA
            txt_Domicilio.Text = .ct_DOMICILIO
            txt_Colonia.Text = .ct_COLONIA
            txt_CP.Text = .ct_CP
            txt_Ciudad.Text = .ct_CIUDAD
            txt_Estado.Text = .ct_ESTADO
            txt_Telefono.Text = .ct_TELEFONO
            txt_Ramo.Text = .ct_RAMO
        End With
    End Sub
End Class
