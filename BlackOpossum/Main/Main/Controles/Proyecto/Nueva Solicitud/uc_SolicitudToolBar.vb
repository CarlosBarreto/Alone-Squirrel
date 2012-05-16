Imports DataSource
Imports System.Text


Public Class uc_SolicitudToolBar
    Public UC As uc_NuevaSolicitudCotización
    Protected _frMain As fr_Main
    Private DB As DBDataSource
    Public _DT As DataTable

    Public Sub New(ByRef frMain As fr_Main)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frMain = frMain
        UC = _frMain.Form
    End Sub

    Private Sub tb_Guardar_Click(sender As System.Object, e As System.EventArgs) Handles tb_Guardar.Click
        With UC
            ' Comporbar los valores minimos necesarios para guardar una solicitud
            If .txt_NumeroCliente.Text = "" Then
                MsgBox("El campo Numero de Cliente no puede quedar vacío", MsgBoxStyle.Critical, "MIGSA")
                .txt_NumeroCliente.Focus()
                Exit Sub
            End If
            If .cb_Requisitor.Text = "" Then
                MsgBox("El campo Requisitor no puede quedar vacío", MsgBoxStyle.Critical, "MIGSA")
                .txt_NumeroCliente.Focus()
                Exit Sub
            End If
            If .txt_Servicio.Text = "" Then
                MsgBox("El campo Servicio no puede quedar vacío", MsgBoxStyle.Critical, "MIGSA")
                .txt_Servicio.Focus()
                Exit Sub
            End If

            If ._DT.Rows.Count <= 0 Then
                MsgBox("Debe agregar al menos una especificación de servicio", MsgBoxStyle.Critical, "MIGSA")
                .txt_Nombre.Focus()
                Exit Sub
            End If
        End With

        'Guardar solicitud
        Try
            Dim DT As DataTable
            Dim strSQL As New StringBuilder

            DB = New DBDataSource
            strSQL.Append("CALL migsa_SolicitudCotizacion_Insertar(")
            strSQL.Append("'" & UC.txt_NumeroCliente.Text & "', ")
            strSQL.Append("'" & UC.cb_Requisitor.SelectedValue & "', ")
            strSQL.Append("'" & UC.txt_Servicio.Text & "', ")
            strSQL.Append("'" & UC.dt_Solicitud.Text & "', ") 'Solicitud
            strSQL.Append("'" & UC.dt_Entrega.Text & "', ") 'Entrega
            strSQL.Append("'" & UC.txt_Anticipo.Text & "', ") 'Anticipo
            strSQL.Append("'" & UC.txt_Resto.Text & "', ") 'Resto
            strSQL.Append("'" & UC.txt_Credito.Text & "', ") 'Credito
            strSQL.Append("'" & UC.txt_Contado.Text & "', ") 'Contado
            strSQL.Append("'" & UC.txt_TipoPago.Text & "', ") 'TiempoPago
            strSQL.Append("'" & UC.txt_Observaciones.Text & "'); ") 'Observaciones

            DT = DB.getDataTableQuery(strSQL.ToString)
            strSQL = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
            'Exit Sub
        End Try

        'Guardar Especificaciones
        Try
            Dim strSQL As New StringBuilder
            For i As Integer = 0 To _DT.Rows.Count - 1
                strSQL.Append("call migsa_EspecificacionSolicitudCotizacion_Insertar(")
                strSQL.Append("'" & NumeroSolicitud & "', ")
                strSQL.Append("'" & Nombre & "', ")
                strSQL.Append("'" & Descripcion & "', ")
                strSQL.Append("'" & Material & "', ")
                strSQL.Append("'" & Proceso & "', ")
                strSQL.Append("'" & Tratamiento & "', ")
                strSQL.Append("'" & Cantidad & "', ")
                strSQL.Append("'" & PrecioUnitario & "', ")
                strSQL.Append("'" & PrecioObjetivo & "', ")
                strSQL.Append("'" & CondicionesEntrega & "', ")
                strSQL.Append("'" & Material & "'); ")

                DT = DB.getDataTableQuery(strSQL.ToString)
            Next

            Dim BDEspecificacion As New SolicitudCotizacion

            BDEspecificacion.GuardarEspecificacionSolicitudCotizacion(_NumeroCotizacion, _DT.Rows(i)("Nombre"), _
                                                                      _DT.Rows(i)("Descripcion"), _DT.Rows(i)("Material"), _
                                                                      _DT.Rows(i)("Proceso"), _DT.Rows(i)("Tratamiento"), _
                                                                      _DT.Rows(i)("Cantidad"), _DT.Rows(i)("PrecioUnitario"), _
                                                                      _DT.Rows(i)("PrecioObjetivo"), _DT.Rows(i)("CondicionesEntrega"), _
                                                                      _DT.Rows(i)("MaterialProporcionado"))


            BDEspecificacion.Dispose()
            BDEspecificacion = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
            Exit Sub
        End Try

        'Generar el documento PDF
    End Sub

    Private Sub tb_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles tb_Cancelar.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Al cancelar, se perdera el progreso de esta solicitud, ¿Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "MIGSA")
        If Response = MsgBoxResult.Yes Then
            _frMain.KillForm()
        End If
    End Sub

    Private Sub tb_Siguiente_Click(sender As System.Object, e As System.EventArgs) Handles tb_Siguiente.Click
        'Determinar en que tab se encuentra
        Dim SelTab As TabPage
        SelTab = UC.TabControl.SelectedTab

        Select Case SelTab.Text
            Case "Clientes/Requisitores"
                UC.TabControl.SelectTab(UC.tbc_Servicio)
            Case "Servicio"
                UC.TabControl.SelectTab(UC.tbc_Especificacion)
            Case "Especificaciones de Servicio"
                UC.TabControl.SelectTab(UC.tbc_Condiciones)
            Case "Condiciones de Pago"
                UC.TabControl.SelectTab(UC.tbc_Cliente)
        End Select
    End Sub

    Private Sub tb_Anterior_Click(sender As System.Object, e As System.EventArgs) Handles tb_Anterior.Click
        'Determinar en que tab se encuentra
        Dim SelTab As TabPage
        SelTab = UC.TabControl.SelectedTab

        Select Case SelTab.Text
            Case "Clientes/Requisitores"
                UC.TabControl.SelectTab(UC.tbc_Condiciones)
            Case "Servicio"
                UC.TabControl.SelectTab(UC.tbc_Cliente)
            Case "Especificaciones de Servicio"
                UC.TabControl.SelectTab(UC.tbc_Servicio)
            Case "Condiciones de Pago"
                UC.TabControl.SelectTab(UC.tbc_Especificacion)
        End Select
    End Sub

    Private Sub tb_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles tb_Imprimir.Click
        With UC
            ' Comporbar los valores minimos necesarios para guardar una solicitud
            If .txt_NumeroCliente.Text = "" Then
                MsgBox("El campo Numero de Cliente no puede quedar vacío", MsgBoxStyle.Critical, "MIGSA")
                .txt_NumeroCliente.Focus()
                Exit Sub
            End If
            If .cb_Requisitor.Text = "" Then
                MsgBox("El campo Requisitor no puede quedar vacío", MsgBoxStyle.Critical, "MIGSA")
                .txt_NumeroCliente.Focus()
                Exit Sub
            End If
        End With
    End Sub




    Public Sub GuardarEspecificacionSolicitudCotizacion(ByVal NumeroSolicitud As String, ByVal Nombre As String, ByVal Descripcion As String, _
                                                        ByVal Material As String, ByVal Proceso As String, ByVal Tratamiento As String, ByVal Cantidad As Integer, _
                                                        ByVal PrecioUnitario As Integer, ByVal PrecioObjetivo As Integer, ByVal CondicionesEntrega As String, ByVal MaterialProporcionado As String)
        Dim DT As DataTable
        
    End Sub
End Class
