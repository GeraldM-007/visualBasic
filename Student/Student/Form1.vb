Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer

        If x >= 70 And x <= 100 Then
            MessageBox.Show("your grade is: A  Congratulations an excelent result")
        ElseIf x >= 60 And x < 70 Then
            MessageBox.Show("your grade is: B  Very well done a very good result")
        ElseIf x >= 50 And x < 60 Then
            MessageBox.Show("your grade is: C  well done satisfactory result")
        ElseIf x >= 40 And x < 50 Then
            MessageBox.Show("your grade is: D  not too bad do more work to impove")
        ElseIf x >= 0 And x < 40 Then
            MessageBox.Show("your grade is: f  unfortunately you need a resit")
        Else
            MessageBox.Show("Invalid marks")

        End If
    End Sub
End Class
