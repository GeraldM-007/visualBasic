Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Answer1, Answer2, Answer3, correctAnswer1, correctAnswer2, correctAnswer3, countr1, countr2, countr3, countr4 As String
        Dim Answer4, correctAnswer4 As String

        correctAnswer1 = "SEOUL"
        correctAnswer2 = "AMAZON"
        correctAnswer3 = "SAHARA DESERT"
        correctAnswer4 = "EVEREST"
        countr1 = 0
        countr2 = 0
        countr3 = 0
        countr4 = 0

        Do
            Answer1 = InputBox("What is the capital city South Korea?")
            Answer1 = Answer1.ToUpper()
            countr1 += 1

        Loop While (Answer1 <> correctAnswer1)
        MessageBox.Show("The Answer is correct " + vbCr + "Your attempts were: " & countr1)

        Do
            Answer2 = InputBox("Which is the largest forest in the world?")
            Answer2 = Answer2.ToUpper()

            countr2 += 1
        Loop While (Answer2 <> correctAnswer2)
        MessageBox.Show("The Answer is correct " + vbCr + "Your attempts were: " & countr2)

        Do
            Answer3 = InputBox("Which is the biggest desert in the world?")
            Answer3 = Answer3.ToUpper()

            countr3 += 1
        Loop While (Answer3 <> correctAnswer3)
        MessageBox.Show("The Answer is correct " + vbCr + "Your attempts were: " & countr3)

        Do

            Answer4 = InputBox("What is the tallest Mountain in the world")
            Answer4 = Answer4.ToUpper()

            countr4 += 1
        Loop While (Answer4 <> correctAnswer4)
        MessageBox.Show("The Answer is correct " + vbCr + "Your attempts were: " & countr4)


    End Sub
End Class
