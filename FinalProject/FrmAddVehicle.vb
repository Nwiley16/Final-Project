Public Class FrmAddVehicle

    Private mVehicle As New Vehicle


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDrivetrain.Items.Add("FWD")
        cboDrivetrain.Items.Add("RWD")
        cboDrivetrain.Items.Add("AWD")
        cboDrivetrain.Items.Add("4WD")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblStatus.Text = ""

        If mVehicle.Insert(CInt(txtStockNum.Text), CInt(txtYear.Text),
                           txtMake.Text, txtModel.Text, txtTrim.Text, txtColor.Text,
                           cboDrivetrain.Text, CInt(txtMileage.Text),
                              CDec(txtTMV.Text), CDec(txtPrice.Text), dtpArrival.Value) Then



        End If
        lblStatus.Text = mVehicle.LastStatus
    End Sub
End Class