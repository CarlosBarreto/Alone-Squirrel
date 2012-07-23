Public Class uc_ModificarRequisitor
    Private _IDRequisitor As String

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
        Dim Requisitor As New Requisitor

        With Requisitor
            .IDRequisitor = txt_IDRequisitor.Text
            .NumeroDeCliente = txt_NumeroCliente.Text
            .Nombre = txt_Nombre.Text
            .Telefono = txt_Telefono.Text
            .Ext = txt_Ext.Text
            .Celular = txt_Celular.Text
            .Radio = txt_Radio.Text
            .Correo = txt_Correo.Text
            .Puesto = txt_Puesto.Text

            .ModificarRequisitor()
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
        txt_NumeroCliente.Text = ""
        txt_Nombre.Text = ""
        txt_Telefono.Text = ""
        txt_Ext.Text = ""
        txt_Celular.Text = ""
        txt_Radio.Text = ""
        txt_Correo.Text = ""
        txt_Puesto.Text = ""
    End Sub

    ''' <summary>
    ''' Determina si se esta editando el formulario
    ''' </summary>
    ''' <returns>Retorna verdadero si se está editando el formulario</returns>
    ''' <remarks></remarks>
    Protected Function IsEditing() As Boolean
        Dim Response As Boolean = False
        If txt_NumeroCliente.Text <> "" Or txt_Nombre.Text <> "" Or txt_Telefono.Text <> "" Or txt_Ext.Text <> "" Or txt_Celular.Text <> "" _
            Or txt_Radio.Text <> "" Or txt_Correo.Text <> "" Then

            Response = True

        End If

        Return Response
    End Function

    'metodos
    Public Sub New(ByVal NoCliente As String)
        InitializeComponent()

        _IDRequisitor = NoCliente
    End Sub

    Private Sub uc_ModificarRequisitor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim DT As DataTable
        Dim Requsitor As New Requisitor

        DT = Requsitor.MostrarDatosRequisitor(_IDRequisitor)

        txt_IDRequisitor.Text = _IDRequisitor
        txt_NumeroCliente.Text = DT.Rows(0)(1).ToString()
        txt_Nombre.Text = DT.Rows(0)(2).ToString()
        txt_Telefono.Text = DT.Rows(0)(3).ToString()
        txt_Ext.Text = DT.Rows(0)(4).ToString()
        txt_Celular.Text = DT.Rows(0)(5).ToString()
        txt_Radio.Text = DT.Rows(0)(6).ToString()
        txt_Correo.Text = DT.Rows(0)(7).ToString()
        txt_Puesto.Text = DT.Rows(0)(8).ToString()

        txt_IDRequisitor.Enabled = False
        txt_NumeroCliente.Enabled = False
    End Sub
End Class
