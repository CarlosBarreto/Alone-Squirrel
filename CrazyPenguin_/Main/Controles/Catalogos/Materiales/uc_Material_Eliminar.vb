Public Class uc_Material_Eliminar

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
            .MaterialID = txt_MaterialID.Text
            .Material_Eliminar()

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
        txt_Fecha.Text = ""
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
        If txt_MaterialID.Text <> "" Or txt_Nombre.Text <> "" Or txt_Descripcion.Text <> "" Or txt_Fecha.Text <> "" Or _
            txt_Unidad.Text <> "" Or txt_Ancho.Text <> "" Or txt_Largo.Text <> "" Or txt_Alto.Text <> "" Or _
            txt_Peso.Text <> "" Or txt_UnidadPeso.Text <> "" Or txt_Costo.Text <> "" Or txt_Padre.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function

    'metodos
    Public Sub New(ByVal Material As String)
        InitializeComponent()
        _MaterialID = Material
    End Sub

    Private Sub uc_Material_Eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim Material As New Material

        DT = Material.MostrarMaterial(_MaterialID)

        txt_MaterialID.Text = _MaterialID
        txt_Nombre.Text = DT.Rows(0)(1).ToString()
        txt_Descripcion.Text = DT.Rows(0)(2).ToString()
        txt_Fecha.Text = DT.Rows(0)(3).ToString()
        txt_Unidad.Text = DT.Rows(0)(4).ToString()
        txt_Ancho.Text = DT.Rows(0)(5).ToString()
        txt_Largo.Text = DT.Rows(0)(6).ToString()
        txt_Alto.Text = DT.Rows(0)(7).ToString()
        txt_Peso.Text = DT.Rows(0)(8).ToString()
        txt_UnidadPeso.Text = DT.Rows(0)(9).ToString()
        txt_Costo.Text = DT.Rows(0)(10).ToString()
        txt_Padre.Text = DT.Rows(0)(11).ToString()

        txt_MaterialID.Enabled = False
    End Sub
End Class
