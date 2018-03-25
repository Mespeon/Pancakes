Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mei.connect()
    End Sub

    Private Sub Login_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing, MyBase.Closed
        Mei.disconnect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            lblUsernameError.Visible = True
        End If

        If txtPassword.Text = "" Then
            lblPasswordError.Visible = True
        End If

        If txtUsername.Text IsNot "" And txtPassword.Text IsNot "" Then
            Yuzu.beginLogin(txtUsername.Text, txtPassword.Text)
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If lblUsernameError.Visible = True Then
            lblUsernameError.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If lblPasswordError.Visible = True Then
            lblPasswordError.Visible = False
        End If
    End Sub
End Class