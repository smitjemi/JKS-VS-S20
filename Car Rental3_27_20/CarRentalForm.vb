'Jemika Smith
'RCET0265
'Spring2020
'Car Rental Program
'https://github.com/smitjemi/JKS-VS-S20
Public Class CarRentalForm
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'VerifyOdometer()
        'DailyCharge()
        'Discont()
        Console.WriteLine(MileageCharge(600))
        MileageCharge(220)
        'Check and Convert to Kilomoters
        'MsgBox(UserMessages(False, "", False))
    End Sub
    Function Discount(totalCharges As Decimal) As Decimal
        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D
        Dim totalDiscount As Decimal = 0
        If AAACheckBox.Checked = True Then
            totalDiscount = totalCharges * AAARATE
        End If
        If SeniorCheckBox.Checked = True Then
            totalDiscount += totalCharges * SENIORRATE
        End If

        Return totalDiscount
    End Function
    Sub verifyOdometer()
        Dim userMessage As String
        Try
            If CDec(BegOdTextBox.Text) > CDec(EndOdTextBox.Text) Then
                'MsgBox("Yeah!")
                userMessage = "Beginning Odometer Must Be Smaller Than Ending Odometer"
            End If
        Catch ex As Exception
            userMessage = "Odometer Entries Must Be Numbers"
        End Try
        UserMessages(True, userMessage, False)
    End Sub
    Function MileageCharge(ByRef miles As Decimal) As Decimal
        Dim mileCharge As Decimal
        Const RATE_REGULAR = 0.12D
        Const RATE_LOW = 0.1D
        Const RATE_FREE = 0D
        'Mileage Charge
        'First 200 miles driven are always free
        'All miles between 201 and 500 inclusive are .12 cents per mile.
        'Miles greater than 500 charged at .10 cents per mile.
        Select Case miles
            Case <= 200
                mileCharge = miles * RATE_FREE
            Case > 500
                mileCharge = 300 * RATE_REGULAR
                mileCharge += (miles - 500) * RATE_LOW
            Case Else
                mileCharge = (miles - 200) * RATE_REGULAR
        End Select
        Return mileCharge
    End Function
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String
        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If
        Return formattedMessages
    End Function
    Sub ResetAll()
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
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MsgBox()
    End Sub
End Class
