Public Class uc_ListarCondicionesPago
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

    Private Sub uc_ListarCondicionesPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Condiciones As New CondicionesPago
        Dim DT As DataTable

        DT = Condiciones.ListarCondicionesPago()

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
                ModificarCondicionesPago()
            Case "Eliminar"
                EliminarCondicionesPago()
        End Select
    End Sub


    Protected Sub ModificarCondicionesPago()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Modificar una Condicion de Pago")

            Form = New uc_CondicionesPago_Modificar(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Protected Sub EliminarCondicionesPago()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Eliminar una Condicion de Pago")

            Form = New uc_CondicionesPago_Eliminar(_SelectedRowValue)
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















