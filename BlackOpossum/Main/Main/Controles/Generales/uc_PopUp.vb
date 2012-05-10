﻿Public Class uc_PopUp
    Private _SelectedRowValue As String
    Public ParentObject As Object

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        'Determinar que celda fue la seleccionada
        'MsgBox(DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString)
        'DataGrid.Rows(e.RowIndex).Selected = True
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub DataGrid_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentDoubleClick
        _SelectedRowValue = DataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
        ParentObject.ppResponse(_SelectedRowValue)
        Me.Dispose()
        Me.Close()
    End Sub
End Class