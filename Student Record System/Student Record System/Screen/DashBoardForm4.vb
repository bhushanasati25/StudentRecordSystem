Public Class DashBoardForm4

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        loginForm.Show()
        MessageBox.Show("Log Out Successfull !!", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnallrecorddisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallrecorddisplay.Click
        AllRecordForm3.Show()
        Me.Hide()



    End Sub

    Private Sub btnaddnewrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddnewrecord.Click
        Me.Hide()

        NewustudentaddForm2.Show()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        Me.Hide()
        Report.Show()

    End Sub

    Private Sub btnlc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlc.Click
        LC.Show()
        Me.Hide()



    End Sub
End Class