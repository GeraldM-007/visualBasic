Public Class Form2
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim streetname, town As String
        Dim housenumber, postcode As Integer
        housenumber = hsntxb.Text
        streetname = srtntxb.Text
        town = twntxb.Text
        postcode = pstctxb.Text


        ' lblDisplay.Text =   

        Form1.Show()
        Hide()


    End Sub
End Class