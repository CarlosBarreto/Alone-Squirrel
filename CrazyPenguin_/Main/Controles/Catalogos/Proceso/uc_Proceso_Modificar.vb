Public Class uc_Proceso_Modificar
    Private _ProcesoID As String

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
        Dim Proceso As New Proceso

        With Proceso

            .ProcesoID = txt_ProcesoID.Text
            .Nombre = txt_Nombre.Text
            .Descripcion = txt_Descripcion.Text
            .CostoUnitario = txt_CostoUnitario.Text
            .Fecha = dt_Proceso.Text

            .Proceso_Modificar()
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
        txt_ProcesoID.Text = ""
        txt_Nombre.Text = ""
        txt_Descripcion.Text = ""
        txt_CostoUnitario.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_ProcesoID.Text <> "" Or txt_Nombre.Text <> "" Or txt_Descripcion.Text <> "" Or txt_CostoUnitario.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function
    'metodos
    Public Sub New(ByVal Proceso As String)
        InitializeComponent()
        _ProcesoID = Proceso
    End Sub

    Private Sub uc_Material_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim proceso As New Proceso

        DT = proceso.MostrarProceso(_ProcesoID)

        txt_ProcesoID.Text = _ProcesoID
        txt_Nombre.Text = DT.Rows(0)(1).ToString()
        txt_Descripcion.Text = DT.Rows(0)(2).ToString()
        txt_CostoUnitario.Text = DT.Rows(0)(3).ToString()
        dt_Proceso.Text = DT.Rows(0)(4).ToString()

        txt_ProcesoID.Enabled = False
    End Sub
End Class
