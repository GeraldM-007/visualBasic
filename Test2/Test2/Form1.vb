Public Class Form1
    Private Sub Buttongreetings_Click(sender As Object, e As EventArgs) Handles Buttongreetings.Click
        MsgBox("This is gerald writing this code")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonvariable.Click

        Dim firstname As String
        Dim lastname As String

        firstname = "Gerald"
        lastname = "Muchuku"

        MessageBox.Show("Hello this is " & firstname & " " & lastname & " I hope you like this")

        firstname = "Mark"
        lastname = "Arthony"

        MessageBox.Show("Hello this is " & firstname & " " & lastname & " I hope you like this")



    End Sub
End Class
