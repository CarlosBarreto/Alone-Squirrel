Imports DataSource
Imports System.Text

Public Class uc_ModificarFormularioDatosCliente
    Protected DB As DBDataSource

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
        Dim Cliente As New Cliente

        With Cliente
            .Empresa = txt_Empresa.Text
            .Domicilio = txt_Domicilio.Text
            .Colonia = txt_Colonia.Text
            .CP = txt_CP.Text
            .Ciudad = txt_Ciudad.Text
            .Estado = txt_Estado.Text
            .Telefono = txt_Telefono.Text
            .Ramo = txt_Ramo.Text

            .GuardarNuevoCliente()
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

End Class
