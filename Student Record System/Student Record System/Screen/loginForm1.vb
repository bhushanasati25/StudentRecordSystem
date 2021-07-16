Public Class loginForm

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtusername.Text = "ADMIN" And txtpassword.Text = "admin" Then
            Me.ErrorProvider1.SetError(txtusername, "")
            Me.ErrorProvider1.SetError(txtpassword, "")
            MessageBox.Show("Login Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            DashBoardForm4.Show()
        ElseIf txtusername.Text = "Administrator" And txtpassword.Text = "admin" Then
            Me.ErrorProvider1.SetError(txtusername, "")
            Me.ErrorProvider1.SetError(txtpassword, "")
            MessageBox.Show("Login Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            DashBoardForm4.Show()
        ElseIf txtusername.Text = "iHack" And txtpassword.Text = "admin" Then
            Me.ErrorProvider1.SetError(txtusername, "")
            Me.ErrorProvider1.SetError(txtpassword, "")
            MessageBox.Show("Login Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            DashBoardForm4.Show()
        ElseIf txtusername.Text = "bhushan25" And txtpassword.Text = "bhushan25@" Then
            Me.ErrorProvider1.SetError(txtusername, "")
            Me.ErrorProvider1.SetError(txtpassword, "")
            MessageBox.Show("Login Successfull !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            DashBoardForm4.Show()
        Else

            Me.ErrorProvider1.SetError(txtusername, "Please enter valid user name")
            Me.ErrorProvider1.SetError(txtpassword, "Please enter valid password")
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class