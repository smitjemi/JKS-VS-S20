'Jemika Smith
'RCET0265
'Spring2020
'Car Rental Program
'https://github.com/smitjemi/JKS-VS-S20
Public Class CarRentalForm
    Dim totalCustomer As Integer
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
                userMessage &= "Please enter a Valid Beginning Number"
            End Try
            Try
                endOd = CDec(EndOdTextBox.Text)
                end1 = True
            Catch ex As Exception
                userMessage &= "Please enter a Valid Ending Number"
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
                If beg1 < end1 Then
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
                If end1 = False Then
                    EndOdTextBox.Text = ""
                    If numberDays = False Then
                        DaysTextBox.Text = ""
                    End If
                End If
            End If
            If NameTextBox.Text = "" Then
                NameTextBox.Select()
            End If
            If AddressTextBox.Text = "" Then
                AddressTextBox.Select()
            End If
            If CityTextBox.Text = "" Then
                CityTextBox.Select()
            End If
            If StateTextBox.Text = "" Then
                StateTextBox.Select()
            End If
            If ZipTextBox.Text = "" Then
                ZipTextBox.Select()
            End If
            If beg1 = False Then
                BegOdTextBox.Select()
            End If
            If end1 = False Then
                EndOdTextBox.Select()
            End If
            If DaysTextBox.Text = "" Then
                DaysTextBox.Select()
            End If
            ValidateCheckBox = True
        End If
        'If ValidateAll() Then
        '    'ToDo proceed to calculations and updates 
        '    Console.WriteLine("Yes")
        'Else
        '    'ToDo alert user
        '    Console.WriteLine("Nope")
        '    'MsgBox(UserMessages(False, "", False))
        'End If
        ''DailyCharge()
        Const AAARATE = 0.05D
        Const SENIORRATE = 0.03D
        Dim totalDiscount As Decimal = 0
        If AAACheckBox.Checked = True Then
            totalDiscount = totalCharges * AAARATE
        End If
        If SeniorCheckBox.Checked = True Then
            totalDiscount += totalCharges * SENIORRATE
        End If

        'Return totalDiscount
        ''Discont()
        ''Console.WriteLine(MileageCharge(600))
        'MileageCharge(220)
        ''Check and Convert to Kilomoters

    End Sub
    Function MileageCharge(ByRef miles As Decimal) As Decimal
        'Mileage Charge
        Dim mileCharge As Decimal
        Const RATE_REGULAR = 0.12D
        Const RATE_LOW = 0.1D
        Const RATE_FREE = 0D
        'All miles between 201 and 500 inclusive are .12 cents per mile.
        'Miles greater than 500 charged at .10 cents per mile.
        Select Case miles
            Case <= 200 'First 200 miles driven are always free
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
