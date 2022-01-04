Public Class Form1


    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        ' Dim Me As String

        If chk1.Checked Then


            MessageBox.Show(" I love food")
        Else
            MessageBox.Show("I dont love food")

        End If
        If chk2.Checked Then
            'Label2.Text += "I love Cars"
            MessageBox.Show("I love cars")
        Else
            MessageBox.Show("I dont love cars")

        End If
        If chk4.Checked Then

            MessageBox.Show("I love Novels")
        Else
            MessageBox.Show("I dont love Novels")

        End If


    End Sub
End Class
