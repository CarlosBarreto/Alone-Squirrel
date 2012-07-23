Public Class uc_RequisitorCliente
    Private _Method As String
    Private _SelectedRowValue As String
    Private _SelectedRowValue2 As String
    Private Form As UserControl ' uc_FormularioDatosCliente
    Private Point_ As Point
    Private frMain As fr_Main

    Public Sub New(ByVal Method As String)
        InitializeComponent()
        _Method = Method
    End Sub

    Private Sub uc_RequisitorCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Cliente As New Cliente
        Dim DT As DataTable

        DT = Cliente.ListaDeClientes()

        If _Method = "Guardar" Then
            ComboBox1.Visible = False
            ComboBox2.Visible = False

            DataGrid.DataSource = DT
        Else
            'Cargar los datos del DataTable
            If DT.Rows.Count > 0 Then
                ComboBox2.DataSource = DT
                ComboBox2.ValueMember = DT.Columns(0).ToString()
                ComboBox2.DisplayMember = DT.Columns(1).ToString()
                ComboBox2.Text = ""
            End If
        End If
        
        Cliente.Dispose()
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
            Case "Guardar"
                GuardarRequisitor()
            Case "Modificar"
                ModificarRequisitor()
            Case "Eliminar"
                EliminarRequisitor()
        End Select


    End Sub

    Protected Sub GuardarRequisitor()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Agregar un Requisitor")

            Form = New uc_GuardarRequisitor(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Protected Sub ModificarRequisitor()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Modificar un Requisitor")

            Form = New uc_ModificarRequisitor(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Protected Sub EliminarRequisitor()
        frMain = Me.Parent
        frMain.KillForm()

        With frMain
            .AddTitle("Eliminar un Requisitor")

            Form = New uc_EliminarRequisitor(_SelectedRowValue)
            Point_.X = 0
            Point_.Y = 130
            Form.Location = Point_
            Form.Width = Me.Width
            .Controls.Add(Form)
            .Form = Form
        End With
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim DT As DataTable
        Dim Requisitor As New Requisitor

        DT = Requisitor.RequisitoresPorCliente(ComboBox2.SelectedValue.ToString)
        DataGrid.DataSource = DT

        Requisitor.Dispose()
    End Sub
End Class
