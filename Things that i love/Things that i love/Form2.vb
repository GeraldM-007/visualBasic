Public Class Form2

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim Gender As String
        If rdoMale.Checked Then
            Gender = "Male"
        Else
            Gender = "Female"
        End If

        Dim Age As String
        If rdoAge1.Checked Then
            Age = "0 - 10"
        ElseIf rdoAge2.Checked Then
            Age = "11 - 15"
        ElseIf rdoAge3.Checked Then
            Age = "16 - 25"
        ElseIf rdoAge4.Checked Then
            Age = "16 - 35"

        End If

        Dim Language As String
        If rdoPL1.Checked Then
            Language = "C#"
        ElseIf rdoPL2.Checked Then
            Language = "VB"
        ElseIf rdoPL2.Checked Then
            Language = "Python"
        ElseIf rdoPL3.checked Then
            Language = "Java"

        End If
        Dim County As String
        If rdoNai.Checked Then
            County = "Nairobi"
        ElseIf rdoMba.Checked Then
            County = "Mbagathi"
        ElseIf rdoKia.checked Then
            County = "Kiambu"
        ElseIf rdoMar.Checked Then
            County = "Marsabit"
        ElseIf rdoUge.checked Then
            County = "Ugenya"

        End If
        MessageBox.Show("Gender: " & Gender & vbCrLf & "Age :" & Age & vbCrLf & "Programming language: " & Language & vbCrLf & "County: " & County & vbCrLf);



    End Sub


End Class