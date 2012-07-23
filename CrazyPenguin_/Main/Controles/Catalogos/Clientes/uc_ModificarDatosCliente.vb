Imports DataSource
Imports System.Text


Public Class uc_ModificarDatosCliente
    Protected DB As DBDataSource


    'Variables de la clase
    ''' <summary>
    ''' Estructura que almacena los datos del cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosCliente
        Public ct_EMPRESA As String
        Public ct_DOMICILIO As String
        Public ct_COLONIA As String
        Public ct_CP As String
        Public ct_CIUDAD As String
        Public ct_ESTADO As String
        Public ct_TELEFONO As String
        Public ct_RAMO As String
    End Structure
    Private _DatosCliente As DatosCliente
    Public _NumeroDeCliente As String
    'Protected DB As DBDataSource

    'Botones
    Private Sub bt_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Cancelar.Click
        Dim x As fr_Main
        Dim op As Integer
        If IsEditing() Then
            op = MsgBox("Al cancelar, se perderan los datos proporcionados. ¿Realemente desea cancelar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "MIGSA")
            If op = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        x = Me.Parent
        CleanText()
        x.KillForm()
    End Sub

    Private Sub bt_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Guardar.Click
        Dim Cliente As New Cliente
        Dim x As fr_Main

        With Cliente
            .NumeroDeCliente = txt_NumeroCliente.Text
            .Empresa = txt_Empresa.Text
            .Domicilio = txt_Domicilio.Text
            .Colonia = txt_Colonia.Text
            .CP = txt_CP.Text
            .Ciudad = txt_Ciudad.Text
            .Estado = txt_Estado.Text
            .Telefono = txt_Telefono.Text
            .Ramo = txt_Ramo.Text

            .ModificarCliente()
        End With

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

    Private Sub uc_ModificarDatosCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

