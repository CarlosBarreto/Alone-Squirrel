Imports DataSource
Imports System.Text


Public Class uc_ModificarDatosCliente
    'Variables de la clase
    ''' <summary>
    ''' Estructura que almacena los datos del cliente
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure DatosCliente
        Public ct_EMPRESA As String
        Public ct_DOMICILIO As String
        Public ct_COLONIA As String
        Public ct_CP As String
        Public ct_CIUDAD As String
        Public ct_ESTADO As String
        Public ct_TELEFONO As String
        Public ct_RAMO As String
    End Structure
    Private _DatosCliente As DatosCliente
    Public _NumeroDeCliente As String
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
        DB = New DBDataSource
        Dim DT As DataTable
        Dim strSQL As New StringBuilder
        Dim x As fr_Main

        strSQL.Append("UPDATE migsa_catalogocliente ")
        strSQL.Append("SET Empresa = '" & txt_Empresa.Text & "', ")
        strSQL.Append("Domicilio = '" & txt_Domicilio.Text & "',")
        strSQL.Append("Colonia = '" & txt_Colonia.Text & "', ")
        strSQL.Append("CP = '" & txt_CP.Text & "', ")
        strSQL.Append("Ciudad = '" & txt_Ciudad.Text & "',")
        strSQL.Append("Estado = '" & txt_Estado.Text & "', ")
        strSQL.Append("Telefono = '" & txt_Telefono.Text & "', ")
        strSQL.Append("Ramo = '" & txt_Ramo.Text & "'")
        strSQL.Append("WHERE NumeroDeCliente = '" & _NumeroDeCliente & "';")

        DT = DB.getDataTableQuery(strSQL.ToString)
        DB.Dispose()
        DB = Nothing
        DT = Nothing

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

    'Eventos
    Public Sub New(ByVal NumeroDeCliente As String)
        Dim DT As DataTable
        Dim strSQL As New StringBuilder


        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        DB = New DBDataSource

        strSQL.Append("SELECT b.NumeroDeCliente, b.Empresa, b.Domicilio, b.Colonia, b.CP, b.Ciudad, b.Estado, b.Telefono, b.Ramo ")
        strSQL.Append("FROM migsa_.migsa_catalogocliente AS b ")
        strSQL.Append("WHERE b.NumeroDeCliente = '" & NumeroDeCliente & "'; ")

        DT = DB.getDataTableQuery(strSQL.ToString)

        With _DatosCliente
            .ct_EMPRESA = DT.Rows(0)("Empresa")
            .ct_DOMICILIO = DT.Rows(0)("Domicilio")
            .ct_COLONIA = DT.Rows(0)("Colonia")
            .ct_CP = DT.Rows(0)("CP")
            .ct_CIUDAD = DT.Rows(0)("Ciudad")
            .ct_ESTADO = DT.Rows(0)("Estado")
            .ct_TELEFONO = DT.Rows(0)("Telefono")
            .ct_RAMO = DT.Rows(0)("Ramo")
            _NumeroDeCliente = DT.Rows(0)("NumeroDeCliente")
        End With

        db.Dispose()
        db = Nothing
        DT = Nothing

    End Sub

    Private Sub uc_ModificarDatosCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With _DatosCliente
            txt_Empresa.Text = .ct_EMPRESA
            txt_Domicilio.Text = .ct_DOMICILIO
            txt_Colonia.Text = .ct_COLONIA
            txt_CP.Text = .ct_CP
            txt_Ciudad.Text = .ct_CIUDAD
            txt_Estado.Text = .ct_ESTADO
            txt_Telefono.Text = .ct_TELEFONO
            txt_Ramo.Text = .ct_RAMO
        End With
    End Sub
End Class

