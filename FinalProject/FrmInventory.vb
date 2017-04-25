Public Class FrmInventory
    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet1.Inventory1' table. You can move, or remove it, as needed.
        Me.Inventory1TableAdapter.Fill(Me.DealerDataSet.Inventory1)


        Dim mInventory As New Vehicle
        dgvInventory.DataSource = mInventory.InventoryList
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim StockNumber As Integer = CInt(txtStockNum.Text)

        Dim frmSellVehicle As New FrmSellVehicle
        frmSellVehicle.StockNumber = StockNumber
        frmSellVehicle.ShowDialog()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim StockNumber As Integer = CInt(txtStockNum.Text)

        Dim frmUpdateVehicle As New FrmUpdateVehicle
        frmUpdateVehicle.StockNumber = StockNumber
        frmUpdateVehicle.ShowDialog()
    End Sub
End Class