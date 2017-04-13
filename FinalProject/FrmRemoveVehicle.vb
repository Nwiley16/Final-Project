Public Class FrmRemoveVehicle

    Private mVehicle As New Vehicle
    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub FrmRemoveVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If (mVehicle.Delete(CInt(txtStockNum.Text))) Then
            dgvInventory.DataSource = mVehicle.Items()
        End If

        lblStatus.Text = mVehicle.LastStatus
    End Sub

End Class