Public Class uc_CondicionesPago_Insertar
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
        Dim Condiciones As New CondicionesPago

        With Condiciones
            .Nombre = txt_Nombre.Text
            .Anticipo = txt_Anticipo.Text
            .Resto = txt_Resto.Text

            .CondicionesPago_Insertar()
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

End Class
