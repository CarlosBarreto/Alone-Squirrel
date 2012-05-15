Imports DataSource
Imports System.Text

Public Class uc_NuevaSolicitudCotización
    Private DB As DBDataSource

    Public Sub ppResponse(ByVal IDResponse As String, ByVal NResponse As String)
        Dim DT As DataTable
        'Public ppResponse As String
        txt_NumeroCliente.Text = IDResponse
        txt_Empresa.Text = NResponse
        txt_NumeroCliente.Focus()

        'Mostrar Requisitores por cliente
        DB = New DBDataSource
        DT = RequisitoresPorCliente(IDResponse)

        'obDataTable = BDCon.RequisitoresPorCliente(_NumeroDeCliente)

        'Cargar los datos del DataTable
        If DT.Rows.Count > 0 Then
            cb_Requisitor.DataSource = DT
            cb_Requisitor.ValueMember = DT.Columns(0).ToString()
            cb_Requisitor.DisplayMember = DT.Columns(1).ToString()
            cb_Requisitor.Text = ""
        End If

        lb_Requisitor.Visible = True
        cb_Requisitor.Visible = True
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

    Public Function RequisitoresPorCliente(ByVal NumeroDeCliente As String) As DataTable
        Dim DT As DataTable
        Dim strSQL As New StringBuilder

        strSQL.Append("CALL migsa_RequisitoresXClientes(")
        strSQL.Append("'" & NumeroDeCliente & "');")

        DT = DB.getDataTableQuery(strSQL.ToString)
        Return DT
    End Function

    Private Sub uc_NuevaSolicitudCotización_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Ajustar los calendarios
        dt_Solicitud.Value = Now
        dt_Entrega.Value = DateAdd(DateInterval.Day, 1, Now)
    End Sub
End Class
