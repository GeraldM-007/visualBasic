Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password, correctpassword As String

        correctpassword = "Google"


        Do

            password = InputBox("Enter password")



        Loop While (password <> correctpassword)














    End Sub
End Class