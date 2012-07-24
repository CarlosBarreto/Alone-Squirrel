Public Class uc_CondicionesPago_Modificar
    Private _CondicionID As String

    'Botones
    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
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
        Dim x As fr_Main
        Dim Condicion As New CondicionesPago

        With Condicion
            .CondicionID = txt_CondicionID.Text
            .Nombre = txt_Nombre.Text
            .Anticipo = txt_Anticipo.Text
            .Resto = txt_Resto.Text

            .CondicionesPago_Modificar()
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
        txt_CondicionID.Text = ""
        txt_Nombre.Text = ""
        txt_Anticipo.Text = ""
        txt_Resto.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_CondicionID.Text <> "" Or txt_Nombre.Text <> "" Or txt_Anticipo.Text <> "" Or txt_Resto.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function

    'metodos
    Public Sub New(ByVal CondicionID As String)
        InitializeComponent()
        _CondicionID = CondicionID
    End Sub
    Private Sub uc_CondicionesPago_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim Condicion As New CondicionesPago

        DT = Condicion.MostrarCondicionesPago(_CondicionID)

        txt_CondicionID.Text = _CondicionID
        txt_Nombre.Text = DT.Rows(0)(1).ToString()
        txt_Anticipo.Text = DT.Rows(0)(2).ToString()
        txt_Resto.Text = DT.Rows(0)(3).ToString()

        txt_CondicionID.Enabled = False
    End Sub
End Class
