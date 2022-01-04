Public Class Form1
    Private Sub buttonclicked_Click(sender As Object, e As EventArgs) Handles buttonclicked.Click
        MessageBox.Show("i am gerald")


    End Sub

    Private Sub Buttonforclicking_Click(sender As Object, e As EventArgs) Handles Buttonforclicking.Click
        Dim firstname As String
        Dim lastname As String

        firstname = "Gerald"
        lastname = "muchuku"

        MessageBox.Show("Hello this is " & firstname & " " & lastname)



    End Sub
End Class
