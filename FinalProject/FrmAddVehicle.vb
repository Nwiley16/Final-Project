Public Class FrmAddVehicle
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmAddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDrivetrain.Items.Add("FWD")
        cboDrivetrain.Items.Add("RWD")
        cboDrivetrain.Items.Add("AWD")
        cboDrivetrain.Items.Add("4WD")

    End Sub
End Class