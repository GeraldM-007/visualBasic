Public Class Form1
    Dim total As Integer = 0
    Dim Average As Integer

    Dim counter As Integer = 0


    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click

        Dim Age(5) As Integer
        For Each element As Integer In Age
            element = 0
            element = txbAge.Text
            total += Age(element)
        Next
        counter += 1
        Average = total/ counter


        lbldisplay.Text = counter
            lblAv.Text = Average


    End Sub
End Class
