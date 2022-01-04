Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Area, Radius As Double

        Radius = InputBox("Enter The Radius")

        Area = (2 * 3.142 * (Radius * Radius))

        MessageBox.Show("The Area Is " & Area.ToString("N2"))


    End Sub
End Class
