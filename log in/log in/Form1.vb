Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username, password, uname, pword As String
        txt2.Text = password
        txb1.Text = username
        username = "TIME"
        password = "STAR"
        uname = username.ToUpper()
        pword = password.ToUpper()
        If uname = "" Then
            If pword = "" Then
                MessageBox.Show("Enter login credentials!")
            Else
                MessageBox.Show("Enter Username")
            End If
        ElseIf uname = "TIME" And pword = "" Then
            MessageBox.Show("Enter Password")
        ElseIf uname <> "TIME" Then
            MessageBox.Show("Incorrect Username")

        Else uname = "TIME" And pword = "STAR" Then
            MessageBox.Show("logged in")
        End If
    End Sub
End Class
