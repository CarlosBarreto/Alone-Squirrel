Public Class fr_Pressentation

    Private Sub bt_Siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Siguiente.Click

        fr_Cliente.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Click
        End
    End Sub

    Private Sub bt_Cancelar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt_Cancelar.Disposed
        End
    End Sub
End Class
