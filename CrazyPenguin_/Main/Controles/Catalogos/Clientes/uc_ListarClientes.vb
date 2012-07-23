Imports DataSource

Public Class uc_ListarClientes
    Private DT As New DataTable

    Private Sub uc_ListarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cliente As New Cliente
        DT = Cliente.ListaDeClientes()
        DataGrid.DataSource = DT
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Cliente.Dispose()
    End Sub

    Private _SelectedRowValue As String
    Private _SelectedRowValue2 As String
    Public ParentObject As Object

    Private Sub DataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        'Determinar que celda fue la seleccionada
        'MsgBox(DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString)
        DataGrid.Rows(e.RowIndex).Selected = True
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
        _SelectedRowValue2 = DataGrid.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub DataGrid_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentDoubleClick
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
        _SelectedRowValue2 = DataGrid.Rows(e.RowIndex).Cells(1).Value.ToString

        Dim Form As UserControl ' uc_FormularioDatosCliente
        Dim Point_ As Point
        Dim frMain As fr_Main

        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Modificar Un Cliente")

            Form = New uc_ModificarDatosCliente(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
        'ParentObject.ppResponse(_SelectedRowValue, _SelectedRowValue2)
        'Me.Dispose()
        ' Me.Close()
    End Sub
End Class
