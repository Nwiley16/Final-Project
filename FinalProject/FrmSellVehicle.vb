Public Class FrmSellVehicle
    Public Property StockNumber As Integer
    Private mVehicle As New Vehicle
    Private mSoldVehicle As New SoldVehicle

    Private Sub FrmSellVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim row As DealerDataSet.Inventory1Row
        row = mVehicle.FindByStockNumber(StockNumber)
        txtStockNum.Text = row.StockNumber.ToString
        txtYear.Text = row.Year
        txtMake.Text = row.Make
        txtModel.Text = row.Model
        txtTrim.Text = row.Trim
        txtColor.Text = row.Color
        cboDrivetrain.Text = row.Drivetrain
        txtMileage.Text = row.Mileage
        txtTMV.Text = row.TrueMarketValue
        txtPrice.Text = row.Price
        dtpArrival.Value = row.ArrivalDate

        txtProfit.Text = txtPrice.Text - txtTMV.Text

        If dtpSale.Value = dtpArrival.Value.AddDays(10) Then
            txtPrice.Text = txtPrice.Text - txtTMV.Text * 0.05
        End If



    End Sub




    Private Sub dtpSale_ValueChanged(sender As Object, e As EventArgs) Handles dtpSale.ValueChanged
        If dtpSale.Value = dtpArrival.Value.AddDays(10) Then
            txtTMV.Text = txtTMV.Text - txtTMV.Text * 0.05
        End If




    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click

    End Sub

    Private Sub txtSellPrice_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtPrice.MaskInputRejected

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class