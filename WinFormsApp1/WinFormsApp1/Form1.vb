Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim num1, num2, nummod1, nummod2 As Integer
        Dim i As Integer


        While (num1 > num2)
            num1 += nummod1
            num2 += nummod2
            i = 0
            i += 1


        End While
        LblDisplay.Text = i


    End Sub
End Class
