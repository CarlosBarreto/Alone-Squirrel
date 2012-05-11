Imports Main.AppMain

Public Class fr_Main
    Private lbTitle As uc_Title
    Private Form As UserControl ' uc_FormularioDatosCliente
    Private Point_ As Point

    ''' <summary>
    ''' Para eliminar el objeto en uso actual
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub KillForm()
        If Not IsNothing(Form) Then Me.Controls.Remove(Form)
        If Not IsNothing(lbTitle) Then Me.Controls.Remove(lbTitle)

        Form = Nothing
        lbTitle = Nothing
    End Sub

    Private Sub AddTitle(ByVal Text As String, Optional X As Integer = 25, Optional Y As Integer = 72)
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
       
        Form = New uc_FormularioDatosCliente
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

    Private Sub fr_Main_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Not IsNothing(lbTitle) Then lbTitle.Width = Me.Width
        If Not IsNothing(Form) Then Form.Width = Me.Width
    End Sub
End Class
