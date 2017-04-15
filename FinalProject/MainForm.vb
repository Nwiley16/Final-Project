Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
        FrmAddVehicle.ShowDialog()
    End Sub

    Private Sub RemoveVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveVehicleToolStripMenuItem.Click
        FrmRemoveVehicle.ShowDialog()
    End Sub

    Private Sub ViewInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInventoryToolStripMenuItem.Click
        FrmInventory.ShowDialog()

    End Sub

    Private Sub EditVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVehicleToolStripMenuItem.Click
        FrmUpdateVehicle.ShowDialog()

    End Sub

    Private Sub InventoryStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryStatusToolStripMenuItem.Click
        FrmDealerStatus.ShowDialog()
    End Sub
End Class
