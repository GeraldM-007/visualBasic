Public Class Form2
    Private Sub prvspagebtn1_Click(sender As Object, e As EventArgs) Handles prvspagebtn1.Click
        Form1.Show()
        Hide()

    End Sub
    Private Sub nextbtn1_Click(sender As Object, e As EventArgs) Handles nextbtn1.Click
        Form3.Show()
        Hide()
        Dim length, width, budget, total, kitdim(13) As Integer
        'kitdim = Dimentions of the Kitchen Layout

        Dim countertop(2), kitch(6) As String
        'kitch = Style of Kitchen Available


        'Initializing values as respective 


        kitch(0) = ("Small L-Shaped Kitchen")
        kitch(1) = ("Medium L-Shaped Kitchen")
        kitch(2) = ("Large L-Shaped Kitchen")
        kitch(3) = ("Small Straight Kitchen")
        kitch(4) = ("Medium Straight Kitchen")
        kitch(5) = ("Large Straight Kitchen")
        kitch(6) = ("Large Island Kitchen")

        kitdim(0) = 250
        kitdim(1) = 180

        kitdim(2) = 350
        kitdim(3) = 240

        kitdim(4) = 450
        kitdim(5) = 350

        kitdim(6) = 150
        kitdim(7) = 60

        kitdim(8) = 350
        kitdim(9) = 60

        kitdim(10) = 500
        kitdim(11) = 60

        kitdim(12) = 450
        kitdim(13) = 450

        countertop(0) = "Wooden Block"
        countertop(1) = "Laminate"
        countertop(2) = "Granite"



        'This segment disallows users to input values less than those available for the kitchen design
        lengthtxb.Text = length
        widthtxb.Text = width

        If length < 150 Or width > 600 Then
            MessageBox.Show("The Length of the Kitchen is incompatible with our designs")
        End If

        If length < 60 Or width > 600 Then
            MessageBox.Show("The Width of the Kidchen is incompatible with our designs")
        End If


        'Here the code checks the users budget and displays the options available to them
        budgettxb.Text = budget

        If budget < 1000 Or budget > 2500 Then
            MessageBox.Show("The Budget is not in range")
        End If



    End Sub
End Class