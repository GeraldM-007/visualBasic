Public Class Form1
    Private Sub Buttonclick_Click(sender As Object, e As EventArgs) Handles btnloggin.Click
        'a message box to show logged in or not
        If tb.Text = "Gerald Muchuku" And
            tb2.Text = "37960114" Then
            MessageBox.Show("Logged in")
        Else
            MessageBox.Show("failed! Either the name or ID number is not correct!")
        End If

    End Sub
End Class
