Public Class Form1
    Dim arr() As Integer = New Integer() {}
    Dim counter As Integer = 0
    Dim Age() As Integer
    Dim largest As Integer = Age(0)
    Dim small As Integer = Age(0)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim current, av As Integer
        Age(counter) = current
        counter += 1
        For i = 0 To counter Step 1
            av += Age(i)
            If small > Age(i) Then
                small = Age(i)
            End If
        Next
        av /= counter

        lblAv.Text = small.ToString()



    End Sub


End Class
