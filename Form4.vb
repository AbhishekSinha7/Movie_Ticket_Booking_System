Public Class Form4

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price As Integer

        If ComboBox2.SelectedItem = "Front Area" Then

        End If
        price = 150
        If ComboBox2.SelectedItem = "Back Area" Then

        End If
        price = 100
        If ComboBox2.SelectedItem = "Corner" Then

        End If
        price = 200
        If ComboBox2.SelectedItem = "Balcony" Then
            price = 170
        End If

        If ComboBox3.SelectedItem = "Popcorn" Then

        End If
        price = price + 80
        If ComboBox3.SelectedItem = "Coke" Then

        End If
        price = price + 40
        If ComboBox3.SelectedItem = "Chips" Then
            price = price + 30

        End If
        price = price + 200
        If ComboBox3.SelectedItem = "Hot Dog" Then
            price = price + 200

        End If



        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Please Fill All the fields", MessageBoxIcon.Exclamation)
        Else
            MsgBox("Booking Successfull. Please Reach 35 min. Before Showtime & Pay At the theatre", MessageBoxIcon.Asterisk)
            TextBox6.Text = price
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        DateTimePicker1.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ErrorProvider1.Clear()
        If IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "Enter valid name")
        End If
        
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ErrorProvider2.Clear()
        If TextBox2.Text.Length > 10 Or TextBox2.Text.Length < 10 Then
            ErrorProvider2.SetError(TextBox2, "Please Enter valid phone number")

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            AxWindowsMediaPlayer1.URL = "C:\Users\shree\Videos\movie trailers\Sooryavanshi _ Official Trailer _ Akshay K, Ajay D, Ranveer S, Katrina K _ Rohit Shetty _ 24th March - YouTube (480p).mp4"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            AxWindowsMediaPlayer1.URL = "C:\Users\shree\Videos\movie trailers\Street Dancer 3D (Trailer) Varun D, Shraddha K,Prabhudeva, Nora F _ Remo D _ Bhushan K_24th Jan 2020 - YouTube (480p).mp4"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            AxWindowsMediaPlayer1.URL = "C:\Users\shree\Videos\Captures\Tanhaji_ The Unsung Warrior - Official Trailer _ Ajay D, Saif Ali K, Kajol _ Om Raut _ 10 Jan 2020 - YouTube (480p).mp4"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            AxWindowsMediaPlayer1.URL = "C:\Users\shree\Videos\Captures\War Trailer _ Hrithik Roshan _ Tiger Shroff _ Vaani Kapoor _ 4K _ New Movie Trailer 2019 - YouTube (480p).mp4"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            AxWindowsMediaPlayer1.URL = "C:\Users\shree\Videos\movie trailers\Baaghi 3 _ Official Trailer _ Tiger Shroff _Shraddha_Riteish_Sajid Nadiadwala_Ahmed Khan_ 6th MARCH - YouTube (480p).mp4"
        End If
    End Sub
End Class