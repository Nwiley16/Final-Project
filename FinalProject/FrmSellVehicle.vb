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

        txtSaleID.Text = txtStockNum.Text + 105



    End Sub




    Private Sub dtpSale_ValueChanged(sender As Object, e As EventArgs) Handles dtpSale.ValueChanged
        Dim SalePrice As Decimal
        SalePrice = txtPrice.Text
        Dim SellDate As DateTime = dtpSale.Value
        Dim ArrivalDate As DateTime = dtpArrival.Value
        SalePrice = SalePrice - (SalePrice * 0.05)

        'If SellDate.Date = ArrivalDate.Date.AddDays(10) Then
        '    SalePrice = SalePrice - (SalePrice * 0.05)
        'End If




    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        lblStatus.Text = ""

        If mSoldVehicle.Insert(CInt(txtSaleID.Text), CInt(txtYear.Text),
                           txtMake.Text, txtModel.Text, txtTrim.Text, txtColor.Text,
                           cboDrivetrain.Text, CInt(txtMileage.Text),
                              CDec(txtPrice.Text), CDec(txtProfit.Text)) Then


            mVehicle.Delete(txtStockNum.Text)
        End If
        lblStatus.Text = mVehicle.LastStatus
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

        txtProfit.Text = txtPrice.Text - txtTMV.Text


    End Sub
End Class