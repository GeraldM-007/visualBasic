Public Class Form1
    Private Sub purchasebtn_Click(sender As Object, e As EventArgs) Handles purchasebtn.Click


        Dim Adult, Children, Nutrionplan, Additionservices As String
        Dim cost, costa, costb, costc, total As Double

        cost = 0.0
        Children = childrencbo.Text
        Adult = adultscbo.Text
        Nutrionplan = nutritioncbo.Text
        Additionservices = additioncbo.Text




        If nutritioncbo.SelectedItem = "Regular healthy eating plan" Then
            Nutrionplan = "Regular healthy eating plan"
            costa = adultscbo.SelectedItem * 50.0
            costb = childrencbo.SelectedItem * 35
            cost = costa + costb


        ElseIf nutritioncbo.SelectedItem = "Weightlifter eating plan" Then
            Nutrionplan = "Weightlifter eating plan"
            costa = adultscbo.SelectedItem * 80.0
            cost = costa

        ElseIf nutritioncbo.SelectedItem = "Endurance trainer eating plan" Then
            Nutrionplan = "Endurance trainer eating plan"
            costa = adultscbo.SelectedItem * 70.0
            cost = costa
        ElseIf nutritioncbo.SelectedItem = "Gluten free healthy eating plan" Then
            Nutrionplan = "Gluten free healthy eating plan"
            costb = childrencbo.SelectedItem * 40

            costa = adultscbo.SelectedItem * 75.0
            cost = costa + costb
        ElseIf nutritioncbo.SelectedItem = "Gluten free weightlifter eating plan" Then
            Nutrionplan = "Gluten free weightlifter eating plan"
            costa = adultscbo.SelectedItem * 85.0
            cost = costa
        ElseIf nutritioncbo.SelectedItem = "Gluten free endurance trainer eating plan" Then
            Nutrionplan = "Gluten free endurance trainer eating plan"
            costa = adultscbo.SelectedItem * 75.0
            cost = costa
        ElseIf nutritioncbo.SelectedItem = "Vegetarian healthy eating plan" Then
            Nutrionplan = "Vegetarian healthy eating plan"
            costa = adultscbo.SelectedItem * 70.0
            costb = childrencbo.SelectedItem * 35

            cost = costa + costb
        ElseIf nutritioncbo.SelectedItem = "Vegetarian weightlifter eating plan" Then
            Nutrionplan = "Vegetarian weightlifter eating plan"
            costa = adultscbo.SelectedItem * 80.0
            cost = costa
        ElseIf nutritioncbo.SelectedItem = "Vegetarian endurance trainer eating plan" Then
            Nutrionplan = "Vegetarian endurance trainer eating plan"
            costa = adultscbo.SelectedItem * 70.0
            cost = costa
        End If


        If additioncbo.SelectedItem = "Muscle building fitness plan" Then
            Additionservices = "Muscle building fitness plan"
            costc = 50
        ElseIf additioncbo.SelectedItem = "Endurance building fitness plan" Then
            Additionservices = "Endurance building fitness plan"
            costc = 40
        ElseIf additioncbo.SelectedItem = "Balanced fitness plan" Then
            Additionservices = "Balanced fitness plan"
            costc = 45
        End If



        If adultscbo.SelectedIndex = -1 Or nutritioncbo.SelectedIndex = -1 Or additioncbo.SelectedIndex = -1 Then

            MessageBox.Show("Invalid Choice")

        Else
            Form2.Show()
        End If



        total = cost + costc


        Dim totals As String = total.ToString("")

        totallbl.Text = “ The total cost is: £ ” + totals


    End Sub
End Class
