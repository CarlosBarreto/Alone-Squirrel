Imports DataSource
Imports Main.NuevaSolicitud
Imports System.Text

Public Class uc_SolicitudToolBar
    Public UC As uc_NuevaSolicitudCotización
    Protected _frMain As fr_Main
    Private DB As DBDataSource
    Public _DT As DataTable

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
        Dim _NumeroCotizacion As String
        Dim DT As DataTable
        Dim strSQL As StringBuilder

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
            strSQL = New StringBuilder
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
            _NumeroCotizacion = DT.Rows(0)("_NumeroSolicitud").ToString
            strSQL = Nothing

            _DT = UC._DT


            For i As Integer = 0 To _DT.Rows.Count - 1
                strSQL = New StringBuilder
                strSQL.Append("call migsa_EspecificacionSolicitudCotizacion_Insertar(")
                strSQL.Append("'" & _NumeroCotizacion & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Nombre") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Descripcion") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Material") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Proceso") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Tratamiento") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("Cantidad") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("PrecioUnitario") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("PrecioObjetivo") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("CondicionesEntrega") & "', ")
                strSQL.Append("'" & _DT.Rows(i)("MaterialProporcionado") & "'); ")

                DT = DB.getDataTableQuery(strSQL.ToString)
                strSQL = Nothing
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
            DB.Dispose()
            DB = Nothing
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
