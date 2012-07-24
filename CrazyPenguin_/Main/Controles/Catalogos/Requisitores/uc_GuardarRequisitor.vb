Public Class uc_GuardarRequisitor
    Private _NumeroDeCliente As String

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

    Private Sub bt_Guardar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Guardar.Click
        Dim x As fr_Main
        Dim Requisitor As New Requisitor

        With Requisitor
            .NumeroDeCliente = txt_NumeroCliente.Text
            .Nombre = txt_Nombre.Text
            .Telefono = txt_Telefono.Text
            .Ext = txt_Ext.Text
            .Celular = txt_Celular.Text
            .Radio = txt_Radio.Text
            .Correo = txt_Correo.Text
            .Puesto = txt_Puesto.Text

            .GuardarNuevoRequisitor()
            .Dispose()
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
        txt_Nombre.Text = ""
        txt_Telefono.Text = ""
        txt_Ext.Text = ""
        txt_Celular.Text = ""
        txt_Radio.Text = ""
        txt_Correo.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_NumeroCliente.Text <> "" Or txt_Nombre.Text <> "" Or txt_Telefono.Text <> "" Or txt_Ext.Text <> "" Or txt_Celular.Text <> "" _
            Or txt_Radio.Text <> "" Or txt_Correo.Text <> "" Then

            Response = True

        End If

        Return Response
    End Function


    'metodos
    Public Sub New(ByVal NoCliente As String)
        InitializeComponent()
        _NumeroDeCliente = NoCliente
    End Sub

    Private Sub uc_GuardarRequisitor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_NumeroCliente.Text = _NumeroDeCliente
        txt_NumeroCliente.Enabled = False
    End Sub
End Class
