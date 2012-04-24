Public Class fr_Main
    Dim _imgHitArea As Point = New Point(13, 2)
    Dim _imageLocation As Point = New Point(15, 5)

    Private Sub fr_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tamaño de la aplicacion
        Globals._HEIGHT = Me.Height
        Globals._WIDHT = Me.Width

        'Configuracion del tamaño del TabControl
        TabControl1.Width = Globals._WIDHT
        TabControl1.Height = Globals._HEIGHT

        'Dim UserMenu As New UserMenu
        'TabPage1.Controls.Add(UserMenu)

        'Set the Mode of Drawing as Owner Drawn
        TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed

        'Add the Handler to draw the Image on Tab Pages
        AddHandler TabControl1.DrawItem, AddressOf TabControl1_DrawItem


    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            'Close Image to draw
            Dim img As Image = New Bitmap("cerrar.gif")
            Dim r As Rectangle = e.Bounds

            r = Me.TabControl1.GetTabRect(e.Index)
            r.Offset(2, 2)
            Dim TitleBrush As Brush = New SolidBrush(Color.Black)
            Dim f As Font = Me.Font
            Dim title As String = Me.TabControl1.TabPages(e.Index).Text
            e.Graphics.DrawString(title, f, TitleBrush, New PointF(r.X, r.Y))
            e.Graphics.DrawImage(img, New Point(r.X + (Me.TabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseClick
        Dim tc As TabControl = CType(sender, TabControl)
        Dim p As Point = e.Location
        Dim _tabWidth As Integer

        _tabWidth = Me.TabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X)
        Dim r As Rectangle = Me.TabControl1.GetTabRect(tc.SelectedIndex)
        r.Offset(_tabWidth, _imgHitArea.Y)
        r.Width = 16
        r.Height = 16
        If r.Contains(p) Then
            Dim TabP As TabPage = DirectCast(tc.TabPages.Item(tc.SelectedIndex), TabPage)
            tc.TabPages.Remove(TabP)
        End If
    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
