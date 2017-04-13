Public Class FrmUpdateVehicle

    Private mVehicle As New Vehicle
    Public Property StockNumber As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        mVehicle.Update(StockNumber, txtYear.Text, txtMake.Text, txtModel.Text,
                        txtTrim.Text, txtColor.Text, cboDrivetrain.Text,
                        txtMileage.Text, txtPrice.Text)
    End Sub

    Private Sub FrmUpdateVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As DealerDataSet.Inventory1Row
        row = mVehicle.FindByStockNumber(StockNumber)
        txtStockNum.Text = row.StockNumber
        txtYear.Text = row.Year
        txtMake.Text = row.Make
        txtModel.Text = row.Model
        txtTrim.Text = row.Trim
        txtColor.Text = row.Color
        cboDrivetrain.Text = row.Drivetrain
        txtMileage.Text = row.Mileage
        txtPrice.Text = row.Price
    End Sub
End Class