﻿Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
        FrmAddVehicle.ShowDialog()
    End Sub

    Private Sub RemoveVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveVehicleToolStripMenuItem.Click

    End Sub
End Class