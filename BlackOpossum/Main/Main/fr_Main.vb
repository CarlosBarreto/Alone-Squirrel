Imports Main.AppMain

Public Class fr_Main
    Private lbTitle As uc_Title
    Public Form As UserControl ' uc_FormularioDatosCliente
    Public FormTool As UserControl
    Private Point_ As Point

    ''' <summary>
    ''' Para eliminar el objeto en uso actual
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KillForm()
        If Not IsNothing(Form) Then Me.Controls.Remove(Form)
        If Not IsNothing(lbTitle) Then Me.Controls.Remove(lbTitle)
        If Not IsNothing(FormTool) Then Me.Controls.Remove(FormTool)
        Form = Nothing
        lbTitle = Nothing
        FormTool = Nothing
    End Sub

    Public Sub AddTitle(ByVal Text As String, Optional X As Integer = 25, Optional Y As Integer = 60)
        Point_ = New Point
        lbTitle = New uc_Title
        Point_.X = X
        Point_.Y = Y
        With lbTitle
            .Location = Point_
            .Label1.Text = Text '"Agregar Nuevo Cliente"
        End With
        Me.Controls.Add(lbTitle)
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = Me.Width - PictureBox1.Width - 20

        Dim AD As New ApplicationData
        Dim DT As DataTable
        DT = AD.ReadMenu


        AD = Nothing
        DT = Nothing
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar Nuevo Cliente")
       
        Form = New uc_ModificarFormularioDatosCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        KillForm()
        AddTitle("Modificar Un Cliente")

        Form = New uc_BuscarCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        KillForm()
        AddTitle("Eliminar Un Cliente")

        Form = New uc_BuscarCliente
        Point_.X = 0
        Point_.Y = 130
        Form.Location = Point_
        Form.Width = Me.Width
        Form.Controls("bt_Eliminar").Visible = True
        Form.Controls("bt_Eliminar").Location = Form.Controls("bt_Modificar").Location
        Form.Controls("bt_Modificar").Visible = False
        Me.Controls.Add(Form)
    End Sub

    Private Sub NuevaSolicitudToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaSolicitudToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar una nueva Solicitud de Cotización")

        Form = New uc_NuevaSolicitudCotización
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)

        FormTool = New uc_SolicitudToolBar(Me)
        Point_.X = 0
        Point_.Y = 110
        FormTool.Location = Point_
        FormTool.Width = Me.Width
        Me.Controls.Add(FormTool)
    End Sub

    Private Sub NuevaCotizaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCotizaciónToolStripMenuItem.Click
        KillForm()
        AddTitle("Agregar una nueva Cotización")

        Form = New uc_NuevaCotizacion
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)
    End Sub
    '------------------------------------
    Private Sub fr_Main_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Not IsNothing(lbTitle) Then lbTitle.Width = Me.Width
        If Not IsNothing(Form) Then Form.Width = Me.Width
    End Sub


    Private Sub AgregarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        KillForm()
        AddTitle("Agregar Nuevo Proveedor")

        Form = New uc_FormularioDatosProveedores
        Point_.X = 0
        Point_.Y = 140
        Form.Location = Point_
        Form.Width = Me.Width
        Me.Controls.Add(Form)

    End Sub
End Class
