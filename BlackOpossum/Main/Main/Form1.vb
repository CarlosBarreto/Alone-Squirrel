Imports Main.AppMain

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim AD As New ApplicationData
        Dim DT As DataTable
        DT = AD.ReadMenu

        AD = Nothing
        DT = Nothing
    End Sub
End Class
