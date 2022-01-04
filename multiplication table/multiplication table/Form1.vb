Public Class Form1


    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        Dim num, start, finish, i As Integer

        num = tb1.Text
        start = tb2.Text
        finish = tb3.Text

        For i = start To finish
            lb1.Items.Add(num & " x " & i & " = " & num * i)


        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lb1.Items.Clear()
        tb1.Text = ""
        tb2.Text = ""
        tb3.Text = ""


    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        Application.Exit()

    End Sub
End Class
