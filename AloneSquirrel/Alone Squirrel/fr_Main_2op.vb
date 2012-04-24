Imports System.Drawing
Imports System.Windows.Forms

Public Class fr_Main_2op
    Inherits Form

    Private tabArea As Rectangle
    Private tabTextArea As RectangleF
    
    Dim _imgHitArea As Point = New Point(13, 2)
    Dim _imageLocation As Point = New Point(15, 5)

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            'Close Image to draw
            Dim img As Image = New Bitmap("cerrar.gif")
            Dim r As Rectangle = e.Bounds


            r = Me.TabControl2.GetTabRect(e.Index)
            r.Offset(2, 2)
            Dim TitleBrush As Brush = New SolidBrush(Color.Black)
            Dim f As Font = Me.Font
            Dim title As String = Me.TabControl2.TabPages(e.Index).Text
            e.Graphics.DrawString(title, f, TitleBrush, New PointF(r.X, r.Y))
            If e.Index <> 0 Then
                e.Graphics.DrawImage(img, New Point(r.X + (Me.TabControl2.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Declares the event handler DrawOnTab which is a method that
    ' draws a string and Rectangle on the tabPage1 tab.
    'Not Used --    Private Sub DrawOnTab(ByVal sender As Object, ByVal e As DrawItemEventArgs)
    'Not Used --    Dim g As Graphics = e.Graphics
    'Not Used --    Dim p As New Pen(Color.Blue)
    'Not Used --    Dim font As New Font("Arial", 10.0F)
    'Not Used --    Dim brush As New SolidBrush(Color.Black)
    'Not Used --    Dim backBrush As New SolidBrush(Color.WhiteSmoke)
    'Not Used --
    'Not Used --    Dim sf As New StringFormat()
    'Not Used --        sf.Alignment = StringAlignment.Center
    'Not Used --
    'Not Used --    Dim title As String = Me.TabControl2.TabPages(e.Index).Text
    'Not Used --
    'Not Used --    Dim img As Image = New Bitmap("cerrar.gif")
    'Not Used --
    'Not Used --        g.DrawRectangle(p, tabArea)
    'Not Used --        g.FillRectangle(backBrush, tabArea)
    'Not Used --        g.DrawString(title, font, brush, tabTextArea)
    'Not Used --        If e.Index <> 0 Then
    'Not Used --            g.DrawImage(img, New Point(tabArea.X + (Me.TabControl2.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))
    'Not Used --        End If
    'Not Used --
    'Not Used --    End Sub


    Private Sub fr_Main_2op_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Globals._TabPageHeight = Me.TabControl2.Height
        Globals._TabPageWidht = Me.TabControl2.Width

        Globals._TabPagePosition.X = (Me.Width - 800) / 2
        Globals._TabPagePosition.Y = 120

        panel_principal.Location = Globals._TabPagePosition

        'Ajustar las pestañas
        With Me.TabControl2
            .SizeMode = TabSizeMode.Fixed
            .ItemSize = New Size(100, 25)
        End With
        'Not Used --        Dim tabControl1 As New TabControl()
        'Not Used --        tabControl1 = Me.TabControl2

        'Not Used --        ' Allows access to the DrawItem event. 
        'Not Used --        tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

        'Not Used --        tabControl1.SizeMode = TabSizeMode.Fixed
        'Not Used --        tabControl1.ItemSize = New Size(100, 25)
        'Not Used --        'tabControl1.Location = New Point(25, 25)
        'Not Used --        tabControl1.Size = New Size(600, 450)

        'Not Used --        ClientSize = New Size(300, 300)
        'Not Used --        'Controls.Add(tabControl1)

        'Not Used --        tabArea = tabControl1.GetTabRect(0)
        'Not Used --        tabTextArea = RectangleF.op_Implicit(tabControl1.GetTabRect(0))


        'Not Used --        ' Binds the event handler DrawOnTab to the DrawItem event 
        'Not Used --        ' through the DrawItemEventHandler delegate.
        'Not Used --        AddHandler tabControl1.DrawItem, AddressOf DrawOnTab

        'Set the Mode of Drawing as Owner Drawn
        TabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed

        'Add the Handler to draw the Image on Tab Pages
        AddHandler TabControl2.DrawItem, AddressOf TabControl1_DrawItem

    End Sub

    Private Sub TabControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl2.MouseClick
        Dim tc As TabControl = CType(sender, TabControl)
        Dim p As Point = e.Location
        Dim _tabWidth As Integer

        _tabWidth = Me.TabControl2.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X)
        Dim r As Rectangle = Me.TabControl2.GetTabRect(tc.SelectedIndex)
        r.Offset(_tabWidth, _imgHitArea.Y)
        r.Width = 16
        r.Height = 16
        If r.Contains(p) Then
            Dim TabP As TabPage = DirectCast(tc.TabPages.Item(tc.SelectedIndex), TabPage)
            tc.TabPages.Remove(TabP)
        End If
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TabPage_AgregarCliente As TabPage
        Dim TabControl As TabControl
        'Dim UserMenu As New UserMenu
        Dim Form As New usr_FormClienteAgregar

        TabControl = Me.TabControl2

        If TabControl.Controls("tb_AgregarCliente") Is Nothing Then
            'Agregar tabpage
            TabPage_AgregarCliente = New TabPage
            With TabPage_AgregarCliente
                .Name = "tb_AgregarCliente"
                .Text = "Agregar Cliente"
                .Width = Globals._WIDHT - 10
                .Height = Globals._WIDHT - 40
                .BackColor = Color.White
                .TabIndex = TabControl.TabPages.Count + 1
                TabControl.Controls.Add(TabPage_AgregarCliente)
                .Controls.Add(Form)
            End With


            TabControl.SelectedTab = TabControl.Controls("tb_AgregarCliente")
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        'Funciona pero como proceso independiente
        Dim myProcess As Process
        myProcess = System.Diagnostics.Process.Start(Application.StartupPath & "\New_SolicitudCotizacion_wizzard.exe", "")
        'Me.Close()
    End Sub
End Class
