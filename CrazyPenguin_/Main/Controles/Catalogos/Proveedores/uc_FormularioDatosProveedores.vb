Public Class uc_FormularioDatosProveedores

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

    'Funciones del formulario
    ''' <summary>
    ''' Limpia los TextBox's del formulario
    ''' </summary>
    ''' <remarks></remarks>
    Protected Sub CleanText()
        txt_IDProveedor.Text = ""
        txt_Nombre.Text = ""
        txt_Domicilio.Text = ""
        txt_Colonia.Text = ""
        txt_CP.Text = ""
        txt_Ciudad.Text = ""
        txt_Estado.Text = ""
        txt_Telefono.Text = ""
        txt_RFC.Text = ""
        txt_NombreRepresentante.Text = ""
        txt_CargoRepresentante.Text = ""
        txt_EmailRepresentante.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False

        If txt_IDProveedor.Text <> "" Or _
            txt_Nombre.Text <> "" Or _
            txt_Domicilio.Text <> "" Or _
            txt_Colonia.Text <> "" Or _
            txt_CP.Text <> "" Or _
            txt_Ciudad.Text <> "" Or _
            txt_Estado.Text <> "" Or _
            txt_Telefono.Text <> "" Or _
            txt_RFC.Text <> "" Or _
            txt_NombreRepresentante.Text <> "" Or _
            txt_CargoRepresentante.Text <> "" Or _
            txt_EmailRepresentante.Text <> "" Then

            Response = True
        End If

        Return Response
    End Function

End Class
