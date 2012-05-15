Imports System.Text
Imports DataSource

Public Class uc_BuscarCliente
    Private DB As DBDataSource


    Public Sub ppResponse(ByVal IDResponse As String, ByVal NResponse As String)
        'Public ppResponse As String
        txt_NumeroCliente.Text = IDResponse
        txt_Empresa.Text = NResponse
        txt_NumeroCliente.Focus()
    End Sub

    Private Sub bt_Options_Click(sender As System.Object, e As System.EventArgs) Handles bt_Options.Click
        Dim FRpopUp As New uc_PopUp
        Dim DT As DataTable

        'Conectarse a la Base de datos
        DB = New DBDataSource
        DT = ListaDeClientes()

        With FRpopUp
            .Text = "Listado de Clientes"
            .StartPosition = FormStartPosition.CenterParent
            .ParentObject = Me
            With .DataGrid
                .DataSource = DT
                .AllowDrop = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
                .RowHeadersVisible = False
                .Columns(0).Width = 60
                .Columns(1).Width = 220
            End With
        End With

        FRpopUp.Show()
        DB.Dispose()
        DB = Nothing
    End Sub


    Public Function ListaDeClientes() As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_ListaDeClientes;")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Private Sub bt_Modificar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Modificar.Click
        Dim IDResponse As String
        Dim Form As UserControl ' uc_FormularioDatosCliente
        Dim Point_ As Point
        Dim frMain As fr_Main

        IDResponse = txt_NumeroCliente.Text

        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Modificar Un Cliente")

            Form = New uc_ModificarDatosCliente(IDResponse)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Private Sub bt_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles bt_Eliminar.Click
        Dim qResponse As MsgBoxResult

        If txt_NumeroCliente.Text = "" Then
            MsgBox("Debe seleccionar un cliente antes. ", MsgBoxStyle.Critical, "MIGSA")
            Exit Sub
        End If

        qResponse = MsgBox("¿Realmente desea eliminar a este Cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "MIGSA")
        If qResponse = MsgBoxResult.Yes Then
            Dim DB As New DBDataSource
            Dim DT As DataTable
            Dim strSQL As New StringBuilder
            Dim frMain As fr_Main

            strSQL.Append("DELETE From migsa_catalogocliente ")
            strSQL.Append("WHERE NumeroDeCliente = '" & txt_NumeroCliente.Text & "';")

            DT = DB.getDataTableQuery(strSQL.ToString)

            DB.Dispose()
            DT = Nothing
            DB = Nothing

            frMain = Me.Parent
            frMain.KillForm()
        End If
    End Sub
End Class
