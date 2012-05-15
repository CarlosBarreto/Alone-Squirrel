Imports BDConnection.BDConnection

Public Class usr_FormClienteAgregar

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        CleanText()
    End Sub


    

    Private Sub usr_FormClienteAgregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usrControlPoint As New Point(0, 0)
        Dim PanelPoint As Point
        Dim PosX As Integer

        Me.Height = Globals._TabPageHeight
        Me.Width = Globals._TabPageWidht
        Me.Location = usrControlPoint

        PosX = (Globals._TabPageWidht - Panel1.Width) / 2
        PanelPoint = New Point(PosX, 10)
        Me.Panel1.Location = PanelPoint

    End Sub

    Private Sub bt_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Guardar.Click
        Dim BD As New Cliente
        BD.GuardarNuevoCliente(txt_Empresa.Text, txt_Domicilio.Text, txt_Colonia.Text, txt_CP.Text, txt_Ciudad.Text, txt_Estado.Text, txt_Telefono.Text, txt_Ramo.Text)
        BD.Dispose()
        BD = Nothing
        CleanText()
    End Sub
End Class
