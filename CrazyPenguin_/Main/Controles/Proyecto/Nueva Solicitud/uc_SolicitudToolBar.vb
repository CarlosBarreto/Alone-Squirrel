Imports DataSource
Imports Main.NuevaSolicitud
Imports System.Text

Public Class uc_SolicitudToolBar
    Public UC As uc_NuevaSolicitudCotización
    Protected _frMain As fr_Main
    Public _DT As DataTable

    Private _NumeroCotizacion As String
    '----------------------------------------------------------
    


    '---------------------------------------------------------
    Public Sub New(ByRef frMain As fr_Main)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frMain = frMain
        UC = _frMain.Form
    End Sub

    Private Sub tb_Guardar_Click(sender As System.Object, e As System.EventArgs) Handles tb_Guardar.Click
        Dim DT As DataTable

        ' Comporbar los valores minimos necesarios para guardar una solicitud
        With UC

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
            Dim Solicitud As New SolicitudCotizacion
            With Solicitud
                .NumeroDeCliente = UC.txt_NumeroCliente.Text
                .IDRequisitor = UC.cb_Requisitor.SelectedValue
                .Servicio = UC.txt_Servicio.Text
                .Solicitud = UC.dt_Solicitud.Text
                .Entrega = UC.dt_Entrega.Text
                .CondicionID = UC.cb_Condiciones.SelectedValue
                If UC.rd_Credito.Checked = True Then
                    .Credito = "Si"
                    .Contado = "No"
                Else
                    .Credito = "No"
                    .Contado = "Si"
                End If
                .TiempoPago = UC.txt_TipoPago.Text

                .Solicitud_Insertar()
            End With
            _NumeroCotizacion = Solicitud.NumeroSolicitud

            'Not Used --             strSQL = New StringBuilder
            'Not Used --             DB = New DBDataSource
            'Not Used --             strSQL.Append("CALL migsa_SolicitudCotizacion_Insertar(")
            'Not Used --             strSQL.Append("'" & UC.txt_NumeroCliente.Text & "', ")
            'Not Used --             strSQL.Append("'" & UC.cb_Requisitor.SelectedValue & "', ")
            'Not Used --             strSQL.Append("'" & UC.txt_Servicio.Text & "', ")
            'Not Used --             strSQL.Append("'" & UC.dt_Solicitud.Text & "', ") 'Solicitud
            'Not Used --             strSQL.Append("'" & UC.dt_Entrega.Text & "', ") 'Entrega
            'Not Used --             srSQL.Append("'" & UC.txt_Anticipo.Text & "', ") 'Anticipo
            'Not Used --             strSQL.Append("'" & UC.txt_Resto.Text & "', ") 'Resto
            'Not Used --             strSQL.Append("'" & UC.txt_Credito.Text & "', ") 'Credito
            'Not Used --             strSQL.Append("'" & UC.txt_Contado.Text & "', ") 'Contado
            'Not Used --             strSQL.Append("'" & UC.txt_TipoPago.Text & "', ") 'TiempoPago
            'Not Used --             strSQL.Append("'" & UC.txt_Observaciones.Text & "'); ") 'Observaciones

            'Not Used --             DT = DB.getDataTableQuery(strSQL.ToString)
            'Not Used --             _NumeroCotizacion = DT.Rows(0)("_NumeroSolicitud").ToString
            'Not Used --             strSQL = Nothing

            _DT = UC._DT

            Dim Especificacion As New EspecificacionSolicitud
            For i As Integer = 0 To _DT.Rows.Count - 1
                With Especificacion
                    .NumeroSolicitud = _NumeroCotizacion
                    .Nombre = _DT.Rows(i)("Nombre")
                    .Descripcion = _DT.Rows(i)("Descripcion")
                    .MaterialID = _DT.Rows(i)("Material")
                    .ProcesoID = _DT.Rows(i)("Proceso")
                    .TratamientoID = _DT.Rows(i)("Tratamiento")
                    .Cantidad = _DT.Rows(i)("Cantidad")
                    .PrecioUnitario = _DT.Rows(i)("PrecioUnitario")
                    .PrecioObjetivo = _DT.Rows(i)("PrecioObjetivo")
                    .CondicionEntrega = _DT.Rows(i)("CondicionesEntrega")
                    .MaterialProporcionado = _DT.Rows(i)("MaterialProporcionado")

                    .Especificacion_Insertar()
                End With
                'Not Used --                 strSQL = New StringBuilder
                'Not Used --                 strSQL.Append("call migsa_EspecificacionSolicitudCotizacion_Insertar(")
                'Not Used --                 strSQL.Append("'" & _NumeroCotizacion & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Nombre") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Descripcion") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Material") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Proceso") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Tratamiento") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("Cantidad") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("PrecioUnitario") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("PrecioObjetivo") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("CondicionesEntrega") & "', ")
                'Not Used --                 strSQL.Append("'" & _DT.Rows(i)("MaterialProporcionado") & "'); ")

                'Not Used --                 DT = DB.getDataTableQuery(strSQL.ToString)
                'Not Used --                 strSQL = Nothing
            Next

            'Generar el documento PDF
            Dim PDFFile As New NuevaSolicitud
            Select Case _DT.Rows.Count
                Case 1
                    PDFFile.pdf_Solicitud1P(_NumeroCotizacion)
                Case 2
                    PDFFile.pdf_Solicitud2p(_NumeroCotizacion)
                Case 3
                    'Obtener los datos del cliente
                    Dim Utility As New PDFUtility.PDFUtility
                    Utility.PDFSourceFile = "C:\MIGSA\RES\PDF\solicitud de cotizacion h1 2p.pdf"
                    MsgBox(Utility.ListFieldNames())

                    Utility.PDFSourceFile = "C:\MIGSA\RES\PDF\solicitud de cotizacion h2 +fs.pdf"
                    MsgBox(Utility.ListFieldNames())

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MIGSA")
            'Exit Sub
        Finally
            DT = Nothing

            'Cerrar el formulario
            fr_Main = Me.Parent
            fr_Main.KillForm()
        End Try
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

End Class
