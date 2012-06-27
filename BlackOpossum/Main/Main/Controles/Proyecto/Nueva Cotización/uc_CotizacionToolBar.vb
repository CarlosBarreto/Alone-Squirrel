Imports DataSource
Imports Main.NuevaSolicitud
Imports System.Text

Public Class uc_CotizacionToolBar 'Public Class uc_SolicitudToolBar
    Public UC As uc_NuevaCotizacion
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
    End Sub

    Private Sub tb_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles tb_Cancelar.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Al cancelar, se perdera el progreso de esta cotización, ¿Desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "MIGSA")
        If Response = MsgBoxResult.Yes Then
            _frMain.KillForm()
        End If
    End Sub

    Private Sub tb_Siguiente_Click(sender As System.Object, e As System.EventArgs) Handles tb_Siguiente.Click
        'Determinar en que tab se encuentra
        Dim SelTab As TabPage
        SelTab = UC.TabControl.SelectedTab

        Select Case SelTab.Text
            Case "Nueva"
                UC.TabControl.SelectTab(UC.tbc_SelectSolicitud)
            Case "Select Solicitud"
                UC.TabControl.SelectTab(UC.tbc_Cliente)
            Case "Cliente / Requisitor"
                UC.TabControl.SelectTab(UC.tbc_Servicio)
            Case "Servicio"
                UC.TabControl.SelectTab(UC.tbc_Especificaciones)
            Case "Especificaciones de Servicio"
                UC.TabControl.SelectTab(UC.tbc_Nueva)
        End Select
    End Sub

    Private Sub tb_Anterior_Click(sender As System.Object, e As System.EventArgs) Handles tb_Anterior.Click
        'Determinar en que tab se encuentra
        Dim SelTab As TabPage
        SelTab = UC.TabControl.SelectedTab

        Select Case SelTab.Text
            Case "Nueva"
                UC.TabControl.SelectTab(UC.tbc_Especificaciones)
            Case "Select Solicitud"
                UC.TabControl.SelectTab(UC.tbc_Nueva)
            Case "Cliente / Requisitor"
                UC.TabControl.SelectTab(UC.tbc_SelectSolicitud)
            Case "Servicio"
                UC.TabControl.SelectTab(UC.tbc_Cliente)
            Case "Especificaciones de Servicio"
                UC.TabControl.SelectTab(UC.tbc_Servicio)
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
        End With
    End Sub



End Class
