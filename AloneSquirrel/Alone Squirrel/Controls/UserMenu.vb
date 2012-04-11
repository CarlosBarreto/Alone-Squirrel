Imports Alone_Squirrel.AloneSquirrel.Posicionamiento

Public Class UserMenu

    Private Sub AgregarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Dim TabPage_AgregarCliente As TabPage
        Dim TabControl As TabControl
        Dim UserMenu As New UserMenu
        Dim Form As New usr_FormClienteAgregar

        TabControl = fr_Main.TabControl1
        If TabControl.Controls("tb_AgregarCliente") Is Nothing Then
            'Agregar tabpage
            TabPage_AgregarCliente = New TabPage
            With TabPage_AgregarCliente
                .Name = "tb_AgregarCliente"
                .Text = "Agregar Cliente"
                .Width = Globals._WIDHT - 10
                .Height = Globals._WIDHT - 40
                .BackColor = Color.WhiteSmoke
                TabControl.Controls.Add(TabPage_AgregarCliente)
                .Controls.Add(UserMenu)
                .Controls.Add(Form)
            End With


            TabControl.SelectedTab = TabControl.Controls("tb_AgregarCliente")
        End If
    End Sub

    Private Sub UserMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = Me.Parent.Parent.Width
    End Sub
End Class