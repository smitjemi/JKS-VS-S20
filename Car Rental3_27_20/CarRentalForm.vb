﻿'Jemika Smith
'RCET0265
'Spring2020
'Car Rental Program
'https://github.com/smitjemi/JKS-VS-S20
Public Class CarRentalForm
    Dim totalCustomers As Integer
    Dim totalDistance As Decimal
    Dim totalCharges As Decimal
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SummaryButton.Enabled = False
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim ValidateCheckBox As Boolean = False
        Dim userMessage As String = ""
        Dim begOd As Decimal
        Dim beg1 As Boolean = False
        Dim endOd As Decimal
        Dim end1 As Boolean = False
        Dim numberofDays As Integer
        Dim numberDays As Boolean = False
        Dim miles As Decimal
        If NameTextBox.Text = "" Then
            userMessage = "Please enter a Name" & vbNewLine
        End If
        If AddressTextBox.Text = "" Then
            userMessage &= "Please enter a Address" & vbNewLine
        End If
        If CityTextBox.Text = "" Then
            userMessage &= "Please enter a City" & vbNewLine
        End If
        If StateTextBox.Text = "" Then
            userMessage &= "Please enter a State" & vbNewLine
        End If
        If ZipTextBox.Text = "" Then
            userMessage &= "Please enter a Zip Code" & vbNewLine
        End If
        If BegOdTextBox.Text = "" Then
            userMessage &= "Please enter a Beginning Odometer number" & vbNewLine
        End If
        If EndOdTextBox.Text = "" Then
            userMessage &= "Please enter a Ending Odometer number" & vbNewLine
        End If
        If DaysTextBox.Text = "" Then
            userMessage &= "Please enter a Number of Days" & vbNewLine
        End If
        If BegOdTextBox.Text <> "" Or EndOdTextBox.Text <> "" Or DaysTextBox.Text <> "" Then
            Try
                begOd = CDec(BegOdTextBox.Text)
                beg1 = True
            Catch ex As Exception
                userMessage &= "Please enter a Valid Beginning Number" & vbNewLine
            End Try
            Try
                endOd = CDec(EndOdTextBox.Text)
                end1 = True
            Catch ex As Exception
                userMessage &= "Please enter a Valid Ending Number" & vbNewLine
            End Try
            Try
                numberofDays = CInt(DaysTextBox.Text)
                If numberofDays > 0 And numberofDays < 46 Then
                    'GOOD!
                    numberDays = True
                Else
                    userMessage &= "Please enter a number between 0 and 45"
                End If
            Catch ex As Exception
                userMessage &= "Please enter a Valid Number of Days"
            End Try
            If beg1 = True And end1 = True Then
                If begOd < endOd Then
                    'ValidateCheckBox = True
                Else
                    userMessage &= "Beginning Odometer must be less than End Odometer"
                End If
            End If
        End If
        If userMessage <> "" Then
            MsgBox(userMessage)
            If beg1 = False Then
                BegOdTextBox.Text = ""
            End If
            If end1 = False Then
                EndOdTextBox.Text = ""
            End If
            If numberDays = False Then
                DaysTextBox.Text = ""
            End If
        End If
        If numberofDays = False Then
            DaysTextBox.Select()
        End If
        If end1 = False Then
            EndOdTextBox.Select()
        End If
        If beg1 = False Then
            BegOdTextBox.Select()
        End If
        If ZipTextBox.Text = "" Then
            ZipTextBox.Select()
        End If
        If StateTextBox.Text = "" Then
            StateTextBox.Select()
        End If
        If CityTextBox.Text = "" Then
            CityTextBox.Select()
        End If
        If AddressTextBox.Text = "" Then
            AddressTextBox.Select()
        End If
        If NameTextBox.Text = "" Then
            NameTextBox.Select()
        End If
        ValidateCheckBox = True

        DayCharTextBox.Text = (numberofDays * 15D) 'Daily Charge $15 per day

        MilesDrTextBox.Text = CDec(EndOdTextBox.Text) - CDec(BegOdTextBox.Text)
        miles = CDec(MilesDrTextBox.Text)
        If MilesRadioButton.Checked = True Then
            Select Case miles
                Case <= 200 'First 200 miles driven are always free
                    MileageTextBox.Text = miles * 0
                Case > 500 'Miles greater than 500 charged at .10 cents per mile.
                    MileageTextBox.Text += (miles - 500) * 0.1D + 36
                Case Else 'Miles after free 200 is charged at .12 cents per mile.
                    MileageTextBox.Text = (miles - 200) * 0.12D
            End Select
        ElseIf KilometersRadioButton.Checked = True Then
            miles = miles * 1.609D
        End If

        Dim totalCharges As Decimal
        totalCharges = CDec(DayCharTextBox.Text + MileageTextBox.Text)

        Dim totalDiscount As Decimal

        If AAACheckBox.Checked = True Then 'AAA members receive a 5% discount
            totalDiscount = totalCharges * 0.05D
        End If
        If SeniorCheckBox.Checked = True Then 'senior citizens get a 3% discount.
            totalDiscount += totalCharges * 0.03D
        End If
        MinusTextBox.Text = totalDiscount
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear User Input
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        BegOdTextBox.Text = ""
        EndOdTextBox.Text = ""
        DaysTextBox.Text = ""
        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False
        MilesRadioButton.Select()
        'Clear Output
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show("total message", "Detailed Summary")
        totalCustomers += CInt(NameTextBox.Text) 'Total number of customers
        totalDistance += CDec(MilesDrTextBox.Text) 'Total distance driven in miles
        totalCharges += CDec(OweTextBox.Text) 'Total charges

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'MsgBox to exit form
        Dim result As DialogResult
        result = CType(MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2), DialogResult)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
