Imports DataSource
Imports System.Text

Public Class uc_FormularioDatosServicio
    Protected DB As DBDataSource

    'Funciones de los botones
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
        DB = New DBDataSource
        GuardarServicio(txt_Nombre.Text, txt_Descripcion.Text)
        DB.Dispose()
        DB = Nothing

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
        txt_Nombre.Text = ""
        txt_Fecha.Text = ""
        txt_Descripcion.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_Nombre.Text <> "" Or txt_Fecha.Text <> "" Or txt_Descripcion.Text <> "" Then
            Response = True
        End If

        Return Response
    End Function

    'Funciones con las Bases de Datos
    Public Function GuardarServicio(ByVal Nombre As String, ByVal Descripcion As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_CatalogoServicios_Insertar(")
        strSQL.Append("'" & Nombre & "', ")
        strSQL.Append("'" & Descripcion & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function
End Class
