﻿Public Class FrmRemoveVehicle

    Private mVehicle As New Vehicle
    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub FrmRemoveVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DealerDataSet.Inventory1' table. You can move, or remove it, as needed.
        Me.Inventory1TableAdapter.Fill(Me.DealerDataSet.Inventory1)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If (mVehicle.Delete(CInt(txtStockNum.Text))) Then
            dgvInventory.DataSource = mVehicle.Items()
        End If

        lblStatus.Text = mVehicle.LastStatus
    End Sub

End Class