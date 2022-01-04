Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim i As Integer
        i = Txb1.Text
        If i < 5 Then
            MessageBox.Show("There is no available")
        ElseIf i > 5 And i < 21 Then
            MessageBox.Show("A2")
        ElseIf i > 20 And i < 31 Then
            MessageBox.Show("A3")
        ElseIf i > 30 And i < 61 Then
            MessageBox.Show("Lab 1")
        ElseIf i > 60 And i < 101 Then
            MessageBox.Show("Hall 3")
        Else
            MessageBox.Show("No room can handle that capacity")
        End If

    End Sub
End Class
