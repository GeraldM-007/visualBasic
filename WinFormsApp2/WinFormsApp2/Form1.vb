Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim Cpuchoice, memchoice, HDDchoice, Oschoice, Graphicschoice, Monitorchoice, periferalchoice As String
        Dim total As Double
        total = 0.0
        Cpuchoice = cmb1.Text
        memchoice = cbomem.Text
        HDDchoice = cboHDD.Text
        Graphicschoice = cboGraphics.Text
        Oschoice = cboOS.Text
        Monitorchoice = cbomonitor.Text
        periferalchoice = CheckedListBox1.Text

        If Cpuchoice = "Intel Pentium G4400" Then
            Cpuchoice = "Intel Pentium G4400"
            total = total + 40.0
        ElseIf Cpuchoice = "Intel i3 6100" Then
            Cpuchoice = "Intel i3 6100"
            total = total + 60.0
        ElseIf Cpuchoice = "Intel Core i5 4430" Then
            Cpuchoice = "Intel Core i54430"
            total = total + 90.0
        ElseIf Cpuchoice = "Intel i7 4790" Then
            Cpuchoice = "Intel i7 4790"
            total = total + 130.0
        ElseIf Cpuchoice = "AMD A4 6300" Then
            Cpuchoice = "AMD A4 6300"
            total = total + 55.0
        ElseIf Cpuchoice = "AMD A6 7400" Then
            Cpuchoice = "AMD A6 7400"
            total = total + 95.0
        ElseIf Cpuchoice = "AMD FX 8530" Then
            Cpuchoice = "AMD FX 8530"
            total = total + 140.0
        End If

        If memchoice = "2GB DDR3 1333MHz" Then
            memchoice = "2GB DDR3 1333MHz"
            total = total + 30.0
        ElseIf memchoice = "4GB DDR3 2000MHz" Then
            memchoice = "4GB DDR3 2000MHz"
            total = total + 40.0
        ElseIf memchoice = "4GB DDR4 3000MHz" Then
            memchoice = "4GB DDR4 3000MHz"
            total = total + 50.0
        ElseIf memchoice = "8GB DDR4 3400MHz" Then
            memchoice = "8GB DDR4 3400MHz"
            total = total + 60.0
        End If

        If HDDchoice = "1 TB" Then
            HDDchoice = "1 TB"
            total = total + 70.0
        ElseIf HDDchoice = "2 TB" Then
            HDDchoice = "2 TB"
            total = total + 80.0
        ElseIf HDDchoice = "4 TB" Then
            HDDchoice = "4 TB"
            total = total + 90.0
        ElseIf HDDchoice = "6 TB" Then
            HDDchoice = "6 TB"
            total = total + 100.0
        ElseIf HDDchoice = "8 TB" Then
            HDDchoice = "8 TB"
            total = total + 140.0
        End If


        If Oschoice = "None" Then
            Oschoice = "None"
            total = total + 0.0
        ElseIf Oschoice = "Microsoft Windows 10" Then
            Oschoice = "Microsoft Windows 10"
            total = total + 20.0
        ElseIf Oschoice = "Microsoft Windows 8.1" Then
            Oschoice = "Microsoft Windows 8.1"
            total = total + 18.0
        ElseIf Oschoice = "Microsoft Windows 7" Then
            Oschoice = "Microsoft Windows 7"
            total = total + 15.0
        ElseIf Oschoice = "Ubuntu 16.04.7 LTS" Then
            Oschoice = "Ubuntu 16.04.7 LTS"
            total = total + 22.0

        End If

        If Graphicschoice = "Saphire HD 6450" Then
            Graphicschoice = "Saphire HD 6450"
            total = total + 90.0
        ElseIf Graphicschoice = "GigaByte Radeon Rx 460" Then
            Graphicschoice = "GigaByte Radeon Rx 460"
            total = total + 110.0
        ElseIf Graphicschoice = "NVIDIA Quadro K620" Then
            Graphicschoice = "NVIDIA Quadro k620"
            total = total + 150.0
        End If


        If Monitorchoice = "17'' 1080HP" Then
            Monitorchoice = "17'' 1080HP"
            total = total + 30.0
        ElseIf Monitorchoice = "23'' Full HD" Then
            Monitorchoice = "23'' Full HD"
            total = total + 40.0
        ElseIf Monitorchoice = "24'' Full HD" Then
            Monitorchoice = "24'' Full HD"
            total = total + 50.0
        ElseIf Monitorchoice = "27'' Full HD" Then
            Monitorchoice = "27'' Full HD"
            total = total + 60.0
        End If

        If periferalchoice = "Portable External HDD 1TB" Then
            periferalchoice = "Portable External HDD 1TB"
            total = total + 20.0
        ElseIf periferalchoice = " DVD Drive" Then
            periferalchoice = " DVD Drive"
            total = total + 10.0
        ElseIf periferalchoice = " Inkjet printer" Then
            periferalchoice = " Inkjet printer"
            total = total + 60.0
        ElseIf periferalchoice = "Scanner" Then
            periferalchoice = "Scanner"
            total = total + 57.0
        ElseIf periferalchoice = "Card Reader" Then
            periferalchoice = " Card Reader"
            total = total + 5.0
        End If



        total += total
        Dim totals As String = total.ToString("")
        Label8.Text = Cpuchoice + memchoice + HDDchoice + Oschoice + Graphicschoice + Monitorchoice + periferalchoice + “ The total cost is: £” + totals











    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged

    End Sub
End Class
