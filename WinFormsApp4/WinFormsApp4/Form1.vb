Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = 100

        TextBox1.Text = num.ToString("N2")
    End Sub
End Class
