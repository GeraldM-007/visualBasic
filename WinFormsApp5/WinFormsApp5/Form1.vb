Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Student(9) As Integer
        Dim Total, Average As Integer


        Student(0) = InputBox("Enter  percentage Marks For Student 1 ")
        Student(1) = InputBox("Enter percentage Marks For Student 2 ")
        Student(2) = InputBox("Enter percentage Marks For Student 3 ")
        Student(3) = InputBox("Enter percentage Marks For Student 4 ")
        Student(4) = InputBox("Enter percentage Marks For Student 5 ")
        Student(5) = InputBox("Enter percentage Marks For Student 6 ")
        Student(6) = InputBox("Enter percentage Marks For Student 7 ")
        Student(7) = InputBox("Enter percentage Marks For Student 8 ")
        Student(8) = InputBox("Enter percentage Marks For Student 9 ")
        Student(9) = InputBox("Enter percentage Marks For Student 10 ")



        Total = Student(0) + Student(1) + Student(2) + Student(3) + Student(4) + Student(5) + Student(6) + Student(7) + Student(8) + Student(9)
        Average = Total / 9
        TextBox1.Text = Total.ToString
        TextBox2.Text = Average.ToString


    End Sub
End Class
