Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As New Random()
        Dim guess, num As Integer
        Dim countr As Integer
        countr = 0

        guess = rand.Next(1, 6)

        Do
            num = InputBox("Guess a Number: ")
            If num < 1 Or num > 6 Then
                MessageBox.Show("Number out of range!")
            End If

            countr += 1
            If countr > 7 Then
                MessageBox.Show("Maximum Number of tries Reached")
                Exit Do


            End If

        Loop While guess <> num



        MessageBox.Show("The correct guess is: " & num)
        MessageBox.Show("Attempts are: " & countr)

        Select Case countr
            Case 1
                MessageBox.Show("Congratulations. Right first time, You win a car")
            Case 2
                MessageBox.Show("Congrats right 2nd time. You win a notebook")
            Case 3
                MessageBox.Show("That took three tries,,, You have another go for free")
            Case 4 To 6
                MessageBox.Show("That took more tries than average,,,Better  lack next time")
            Case 7
                MessageBox.Show("You must have guessed the same incorrect number more than once")
            Case Else
                MessageBox.Show("Maximum guess reached.")

        End Select








    End Sub
End Class
