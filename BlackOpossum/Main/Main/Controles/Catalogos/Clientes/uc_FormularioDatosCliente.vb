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
        DB = New DBDataSource
        GuardarNuevoCliente(txt_Empresa.Text, txt_Domicilio.Text, txt_Colonia.Text, txt_CP.Text, txt_Ciudad.Text, txt_Estado.Text, txt_Telefono.Text, txt_Ramo.Text)
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


    'Funciones sobre la Base de datos
    Public Function GuardarNuevoCliente(ByVal Empresa As String, ByVal Domicilio As String, ByVal Colonia As String, ByVal CP As String, _
                                       ByVal Ciudad As String, ByVal Estado As String, ByVal Telefono As String, ByVal Ramo As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_CatalogoCliente_Insertar(")
        strSQL.Append("'" & Empresa & "', ")
        strSQL.Append("'" & Domicilio & "', ")
        strSQL.Append("'" & Colonia & "', ")
        strSQL.Append("'" & CP & "', ")
        strSQL.Append("'" & Ciudad & "', ")
        strSQL.Append("'" & Estado & "', ")
        strSQL.Append("'" & Telefono & "', ")
        strSQL.Append("'" & Ramo & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
        '" & Empresa & ')
    End Function

    Public Function GuardarNuevoRequisitor(ByVal NumeroDeCliente As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Ext As String, ByVal Celular As String, _
                                      ByVal Radio As String, ByVal Correo As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_Requisitor_Insertar (")
        strSQL.Append("'" & NumeroDeCliente & "');")
        strSQL.Append("'" & Nombre & "');")
        strSQL.Append("'" & Telefono & "');")
        strSQL.Append("'" & Ext & "');")
        strSQL.Append("'" & Celular & "');")
        strSQL.Append("'" & Radio & "');")
        strSQL.Append("'" & Correo & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Public Function ListaDeClientes() As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ListaDeClientes;")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Public Function ClientesAutoFill(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ClientesAutofill(")
        strSQL.Append("'" & NumeroDeCliente & "')")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Public Function RequisitoresPorCliente(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_RequisitoresXClientes(")
        strSQL.Append("'" & NumeroDeCliente & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function
End Class
