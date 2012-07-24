Public Class uc_ListarMaterial
    'Control del dataGrid
    Private _SelectedRowValue As String
    Private _SelectedRowValue2 As String
    'Tipo de accion a tomar
    Private _Method As String
    'Para administrar el comportamiento de la ventana
    Private Form As UserControl
    Private Point_ As Point
    Private frMain As fr_Main

    Public Sub New(ByVal Method As String)
        InitializeComponent()
        _Method = Method
    End Sub

    Private Sub uc_ListarMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Material As New Material
        Dim DT As DataTable

        DT = Material.ListarMaterial()

        'Cargar los datos del DataTable
        DataGrid.DataSource = DT
    End Sub

    Private Sub DataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        DataGrid.Rows(e.RowIndex).Selected = True
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
        _SelectedRowValue2 = DataGrid.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub DataGrid_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentDoubleClick
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
        _SelectedRowValue2 = DataGrid.Rows(e.RowIndex).Cells(1).Value.ToString

        Select Case _Method
            Case "Modificar"
                ModificarMaterial()
            Case "Eliminar"
                EliminarMaterial()
        End Select
    End Sub

    Protected Sub ModificarMaterial()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Modificar un Material")

            Form = New uc_Material_Modificar(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Protected Sub EliminarMaterial()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Eliminar un Material")

            Form = New uc_Material_Eliminar(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Private Sub bt_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cerrar.Click
        Dim x As fr_Main
        x = Me.Parent
        x.KillForm()
    End Sub
End Class







