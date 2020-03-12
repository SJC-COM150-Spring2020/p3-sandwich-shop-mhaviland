Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Declare and intialize variable
        Dim subtotal As Double

        Dim tax As Double
        tax = subtotal * 0.08

        Dim total As Double
        total = subtotal + tax
        lstOut.Items.Add("You selected the following items: ")


        'check for optional drink items that are checked

        'check for Coffee
        If (chkCofee.Checked = True) Then
            lstOut.Items.Add("Coffee - $2.25")
            subtotal = subtotal + 2.25
            total = (subtotal + 2.25) * 0.08
        End If
        'check for Tea
        If (chkTea.Checked = True) Then
            lstOut.Items.Add("Tea - $2.25")
            subtotal = subtotal + 2.25
            total = (subtotal + 2.25) * 0.08
        End If
        'check for Hot Chocolate
        If (chkHotChoc.Checked = True) Then
            lstOut.Items.Add("Hot Chocolate - $2.25")
            subtotal = subtotal + 2.25
            total = (subtotal + 2.25) * 0.08
        End If
        'check for Milk
        If (chkMilk.Checked = True) Then
            lstOut.Items.Add("Milk - $2.25")
            subtotal = subtotal + 2.25
            total = (subtotal + 2.25) * 0.08
        End If
        'check for Juice
        If (chkJuice.Checked = True) Then
            lstOut.Items.Add("Juice - $2.25")
            subtotal = subtotal + 2.25
            total = (subtotal + 2.25) * 0.08
        End If

        'check for optional egg items that are checked

        'check for scrambled
        If (radScrambled.Checked = True) Then
            lstOut.Items.Add("Scrambled - $6.95")
            subtotal = subtotal + 6.95
            total = (subtotal + 6.95) * 0.08
        ElseIf (radOverEasy.Checked = True) Then
            lstOut.Items.Add("Over Easy - $6.95")
            subtotal = subtotal + 6.95
            total = (subtotal + 6.95) * 0.08
        ElseIf (radSunny.Checked = True) Then
            lstOut.Items.Add("Sunny Side Up - $6.95")
            subtotal = subtotal + 6.95
            total = (subtotal + 6.95) * 0.08
        ElseIf (radPoached.Checked = True) Then
            lstOut.Items.Add("Poached - $6.95")
            subtotal = subtotal + 6.95
            total = (subtotal + 6.95) * 0.08
        End If

        'check for optional extra items that are checked

        'check for cheese
        If (chkCheese.Checked = True) Then
            lstOut.Items.Add("Cheese - $1.50")
            subtotal = subtotal + 1.5
            total = (subtotal + 1.5) * 0.08
        End If
        'check for bacon
        If (chkBacon.Checked = True) Then
            lstOut.Items.Add("Bacon - $1.50")
            subtotal = subtotal + 1.5
            total = (subtotal + 1.5) * 0.08
        End If
        'check for sausage
        If (chkSausage.Checked = True) Then
            lstOut.Items.Add("Sausage - $1.50")
            subtotal = subtotal + 1.5
            total = (subtotal + 1.5) * 0.08
        End If
        'check for ham
        If (chkHam.Checked = True) Then
            lstOut.Items.Add("Ham - $1.50")
            subtotal = subtotal + 1.5
            total = (subtotal + 1.5) * 0.08
        End If
        'check for veggies
        If (chkVeggies.Checked = True) Then
            lstOut.Items.Add("Veggies - $1.50")
            subtotal = subtotal + 1.5
            total = (subtotal + 1.5) * 0.08
        End If

        lstOut.Items.Add("Your subtotal is $" & CStr(subtotal))
        lstOut.Items.Add("Tax: $" & CStr(subtotal * 0.08))
        lstOut.Items.Add("Your total is $" & CStr(subtotal + (subtotal * 0.08)))
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all checkboxes and listbox values
        lstOut.Items.Clear()
        chkBacon.Checked = False
        chkCheese.Checked = False
        chkCofee.Checked = False
        chkHam.Checked = False
        chkHotChoc.Checked = False
        chkJuice.Checked = False
        chkMilk.Checked = False
        chkSausage.Checked = False
        chkTea.Checked = False
        chkVeggies.Checked = False
        radOverEasy.Checked = False
        radPoached.Checked = False
        radScrambled.Checked = False
        radSunny.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit application
        Application.Exit()
    End Sub




End Class
