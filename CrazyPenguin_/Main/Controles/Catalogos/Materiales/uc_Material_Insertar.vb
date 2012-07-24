Public Class uc_Material_Insertar
    Private _MaterialID As String

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
        Dim Material As New Material

        With Material

            .Nombre = txt_Nombre.Text
            .Descripcion = txt_Descripcion.Text
            .Fecha = dt_Material.Text
            .Unidad = txt_Unidad.Text
            .Ancho = txt_Ancho.Text
            .Largo = txt_Largo.Text
            .Alto = txt_Alto.Text
            .Peso = txt_Peso.Text
            .UnidadPeso = txt_UnidadPeso.Text
            .CostoUnitario = txt_Costo.Text
            .Padre = txt_Padre.Text

            .Material_Insertar()
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
        txt_MaterialID.Text = ""
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        dt_Material.Text = ""
        txt_Unidad.Text = ""
        txt_Ancho.Text = ""
        txt_Largo.Text = ""
        txt_Alto.Text = ""
        txt_Peso.Text = ""
        txt_UnidadPeso.Text = ""
        txt_Costo.Text = ""
        txt_Padre.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_MaterialID.Text <> "" Or txt_Nombre.Text <> "" Or txt_Descripcion.Text <> "" Or _
            txt_Unidad.Text <> "" Or txt_Ancho.Text <> "" Or txt_Largo.Text <> "" Or txt_Alto.Text <> "" Or _
            txt_Peso.Text <> "" Or txt_UnidadPeso.Text <> "" Or txt_Costo.Text <> "" Or txt_Padre.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function
End Class

'


