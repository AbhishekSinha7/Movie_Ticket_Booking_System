Public Class Form6

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MsgBox("Please Fill the Password", MessageBoxIcon.Exclamation)
        Else
            My.Settings.password = TextBox2.Text
            MsgBox("Updated Password Successfully", MessageBoxIcon.Asterisk)
            My.Settings.Save()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Fill the Username", MessageBoxIcon.Exclamation)
        Else
            My.Settings.username = TextBox1.Text
            MsgBox("Updated Username Successfully", MessageBoxIcon.Asterisk)
            My.Settings.Save()
        End If
    End Sub

   
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class