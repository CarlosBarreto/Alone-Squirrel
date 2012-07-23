Imports DataSource
Imports System.Text

Public Class uc_MostrarDatosEliminar
    Protected DB As DBDataSource
    Public _NumeroDeCliente As String

    'Botones
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        Dim x As fr_Main
        x = Me.Parent
        CleanText()
        x.KillForm()
    End Sub

    Private Sub bt_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Guardar.Click
        Dim x As fr_Main
        If MsgBox("Realmente deseas eliminar a este cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "MIGSA") = MsgBoxResult.Yes Then
            Dim Cliente As New Cliente

            With Cliente
                .NumeroDeCliente = txt_NumeroCliente.Text
                .EliminarCliente()
            End With
        End If
        CleanText()
        x = Me.Parent
        x.KillForm()
    End Sub

    'Funciones del formulario
    ''' <summary>
    ''' Limpia los TextBox's del formulario
    ''' </summary>
    ''' <remarks></remarks>
    Protected Sub CleanText()
        txt_NumeroCliente.Text = ""
        txt_Empresa.Text = ""
        txt_Domicilio.Text = ""
        txt_Colonia.Text = ""
        txt_CP.Text = ""
        txt_Ciudad.Text = ""
        txt_Estado.Text = ""
        txt_Telefono.Text = ""
        txt_Ramo.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_NumeroCliente.Text <> "" Or txt_Empresa.Text <> "" Or txt_Domicilio.Text <> "" Or txt_Colonia.Text <> "" Or _
           txt_CP.Text <> "" Or txt_Ciudad.Text <> "" Or txt_Estado.Text <> "" Or txt_Telefono.Text <> "" Or txt_Ramo.Text <> "" Then

            Response = True

        End If

        Return Response
    End Function

    'Eventos
    Public Sub New(ByVal NumeroCliente As String)
        ' This call is required by the designer.
        InitializeComponent()
        _NumeroDeCliente = NumeroCliente
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub uc_MostrarDatosEliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cliente As New Cliente
        With Cliente
            .BuscarClientes(_NumeroDeCliente)

            txt_NumeroCliente.Text = .NumeroDeCliente
            txt_Empresa.Text = .Empresa
            txt_Domicilio.Text = .Domicilio
            txt_Colonia.Text = .Colonia
            txt_CP.Text = .CP
            txt_Ciudad.Text = .Ciudad
            txt_Estado.Text = .Estado
            txt_Telefono.Text = .Telefono
            txt_Ramo.Text = .Ramo

            .Dispose()
        End With
    End Sub
End Class