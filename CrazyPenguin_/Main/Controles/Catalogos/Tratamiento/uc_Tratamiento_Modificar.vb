Public Class uc_Tratamiento_Modificar
    Private _TratamientoID As String

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
        Dim Tratamiento As New Tratamiento

        With Tratamiento

            .TratamientoID = txt_TratamientoID.Text
            .Nombre = txt_Nombre.Text
            .Descripcion = txt_Descripcion.Text
            .CostoUnitario = txt_CostoUnitario.Text
            .Fecha = dt_Tratamiento.Text

            .Tratamiento_Modificar()
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
        txt_TratamientoID.Text = ""
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_TratamientoID.Text <> "" Or txt_Nombre.Text <> "" Or txt_Descripcion.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function

    'metodos
    Public Sub New(ByVal Tratamiento As String)
        InitializeComponent()
        _TratamientoID = Tratamiento
    End Sub

    Private Sub uc_Material_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim Tratamiento As New Tratamiento

        DT = Tratamiento.MostrarTratamiento(_TratamientoID)

        txt_TratamientoID.Text = _TratamientoID
        txt_Nombre.Text = DT.Rows(0)(1).ToString()
        txt_Descripcion.Text = DT.Rows(0)(2).ToString()
        txt_CostoUnitario.Text = DT.Rows(0)(3).ToString()
        dt_Tratamiento.Text = DT.Rows(0)(4).ToString()

        txt_TratamientoID.Enabled = False
    End Sub
End Class
