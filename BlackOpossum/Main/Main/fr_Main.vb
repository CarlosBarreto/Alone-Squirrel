Imports Main.AppMain

Public Class fr_Main
    Private
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel1.Width = Me.Width - PictureBox1.Width - 20

        Dim AD As New ApplicationData
        Dim DT As DataTable
        DT = AD.ReadMenu


        AD = Nothing
        DT = Nothing
    End Sub

End Class
