Public Class FrmInventory
    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet1.Inventory1' table. You can move, or remove it, as needed.
        Me.Inventory1TableAdapter.Fill(Me.DealerDataSet.Inventory1)


        Dim mInventory As New Vehicle
        dgvInventory.DataSource = mInventory.InventoryList
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub
End Class