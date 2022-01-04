Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = TextBox1.Text




        While (i < 10 Or i > 50)

                i = InputBox("Value incorrect!! Enter a number between 10 and 50")

            End While



    End Sub
End Class