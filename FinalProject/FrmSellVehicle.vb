Public Class FrmSellVehicle

    Private mVehicle As New Vehicle
    Private mSoldVehicle As New SoldVehicle

    Private Sub FrmSellVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub




    Private Sub dtpSale_ValueChanged(sender As Object, e As EventArgs) Handles dtpSale.ValueChanged
        If dtpSale.Value = dtpArrival.Value.AddDays(10) Then
            txtPrice.Text = txtPrice.Text - txtPrice.Text * 0.05
        End If




    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click

    End Sub
End Class