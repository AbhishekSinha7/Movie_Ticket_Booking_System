Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorProvider1.Clear()
        If IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "Please Enter valid name")
        ElseIf TextBox1.Text = My.Settings.username And TextBox2.Text = My.Settings.password Then
            Me.Hide()
            home.Show()
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please fill the username and password", MessageBoxIcon.Exclamation)
        Else
            MsgBox("Incorrect password Or username", MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
