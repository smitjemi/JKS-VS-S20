Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring2020
'Car Rental Program
'https://github.com/smitjemi/JKS-VS-S20
Public Class CarRentalForm
    Dim totalCustomers As Integer
    Dim totalDistance As Decimal
    Dim totalCharge As Decimal
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SummaryButton.Enabled = False
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim ValidateCheckBox As Boolean = False
        Dim userMessage As String = "" 'Use a single message box to display any improper input
        Dim begOd As Decimal
        Dim beg1 As Boolean = False
        Dim endOd As Decimal
        Dim end1 As Boolean = False
        Dim numberofDays As Integer
        Dim numberDays As Boolean = False
        Dim daysCharged As Decimal
        Dim miles As Decimal
        Dim mileageTotal As Decimal
        Dim YouOwe As Decimal
        'Include input validation for all text boxes
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
            Try 'Validate the odometer readings
                begOd = CDec(BegOdTextBox.Text)
                beg1 = True
            Catch ex As Exception
                userMessage &= "Please enter a Valid Beginning Number" & vbNewLine
            End Try
            Try 'Validate the odometer readings
                endOd = CDec(EndOdTextBox.Text)
                end1 = True
            Catch ex As Exception
                userMessage &= "Please enter a Valid Ending Number" & vbNewLine
            End Try
            Try 'Validate number of days
                numberofDays = CInt(DaysTextBox.Text)
                If numberofDays > 0 And numberofDays < 46 Then 'Days must be greater than zero.Days cannot be greater than 45.
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
        'Remove the invalid data from any affected text box
        If userMessage <> "" Then
            MsgBox(userMessage)
            If beg1 = False Then
                BegOdTextBox.Text = ""
            End If
            If end1 = False Then
                EndOdTextBox.Text = ""
            End If
            If numberofDays = False Then
                DaysTextBox.Text = ""
            End If
        Else
            ValidateCheckBox = True
        End If
        'Set the focus to the first affected text box in the tab order
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
        'Do not display the message box until the calculate button is clicked
        If ValidateCheckBox = True Then
            daysCharged = (numberofDays * 15D) 'Daily Charge $15 per day
            DayCharTextBox.Text = daysCharged.ToString("C") 'Customer’s total daily charge format as currency
            If MilesRadioButton.Checked = True Then 'The radio buttons determine if odometer value is miles/kilo
                miles = endOd - begOd
            Else '1 Kilometer equals .62 Miles.
                miles = (endOd - begOd) * 0.62D 'convert kilo to miles
            End If
            MilesDrTextBox.Text = miles.ToString
            Select Case miles
                Case <= 200 'First 200 miles driven are always free
                    mileageTotal = miles * 0
                Case > 500 'Miles greater than 500 charged at .10 cents per mile.
                    mileageTotal += (miles - 500D) * 0.1D + 36D
                Case Else 'Miles after free 200 is charged at .12 cents per mile.
                    mileageTotal = (miles - 200D) * 0.12D
            End Select
            MileageTextBox.Text = mileageTotal.ToString("C") 'Customer’s total mileage charge format as currency

            Dim totalCharges As Decimal
            totalCharges = CDec(DayCharTextBox.Text) + CDec(MileageTextBox.Text)

            Dim totalDiscount As Decimal
            If AAACheckBox.Checked = True Then 'AAA members receive a 5% discount
                totalDiscount = totalCharges * 0.05D
            End If
            If SeniorCheckBox.Checked = True Then 'senior citizens get a 3% discount.
                totalDiscount += totalCharges * 0.03D
            End If
            MinusTextBox.Text = totalDiscount
            MinusTextBox.Text = totalDiscount.ToString("C") 'Customer’s total discount applied format as currency


            YouOwe = CDec(totalCharges - totalDiscount)
            OweTextBox.Text = YouOwe.ToString("C") 'Customer’s total charges format as currency

            SummaryButton.Enabled = True

            totalCustomers += 1 'Total number of customers for the day
            totalDistance += CDec(MilesDrTextBox.Text) 'Total distance driven in miles for the day
            totalCharge += CDec(OweTextBox.Text) 'Total charges for the day
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clear all input text boxes
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        BegOdTextBox.Text = ""
        EndOdTextBox.Text = ""
        DaysTextBox.Text = ""
        'Clear all output text boxes
        MilesDrTextBox.Text = ""
        DayCharTextBox.Text = ""
        MileageTextBox.Text = ""
        MinusTextBox.Text = ""
        OweTextBox.Text = ""
        'Clear discount check boxes
        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False
        'Select the miles radio button
        MilesRadioButton.Select()
        'Do not clear the summary totals	
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim stringVariable As String
        stringVariable = "Total Customers:      " & totalCustomers.ToString & vbNewLine & 'Total number of customers
            "Total Distance:         " & totalDistance.ToString & vbNewLine & 'Total distance driven in miles
            "Total Charge:            " & totalCharge.ToString("C") 'Total charges
        MessageBox.Show(stringVariable, "Detailed Summary") 'Display the following summary using a message box
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'MsgBox to exit form
        Dim Result As DialogResult
        'Prompt the user with Yes/No buttons in a message box. Ask if they are sure they want to exit.
        Result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If Result = DialogResult.Yes Then 'Do not exit unless the user clicks the yes button.
            Me.Close()
        End If
    End Sub
End Class
