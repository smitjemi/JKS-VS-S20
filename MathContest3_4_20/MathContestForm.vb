'Jemika Smith
'RCET0265
'Spring2020
'Math Contest
'https://github.com/smitjemi/JKS-VS-S20
Public Class MathContestForm
    Dim userMessage As String
    Dim randomNumber As Integer
    Dim studentAnswer As Integer
    Dim correctAnswer As Integer
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim numbersCorrect As Integer
    Dim numberOfProblems As Integer
    Dim ageNumber As Integer
    Dim gradeNumber As Integer
    Dim gradeValidated As Boolean = False
    Private Sub StudentInfoGroupBox_Validate(sender As Object, e As EventArgs) Handles StudentInfoGroupBox.Validated, GradeTextBox.TextChanged, AgeTextBox.Validated
        'Checks to see if student information is correct/eligable.
        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber < 7 Or ageNumber > 11 Then
                MsgBox("Student is not eligble to compete.")
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""
        End Try
        If GradeTextBox.Text <> "" Then
            Try
                gradeNumber = CInt(GradeTextBox.Text)
                If gradeNumber < 1 Or gradeNumber > 4 Then
                    MsgBox("Student is not eligble to compete.")
                Else
                    gradeValidated = True
                End If
            Catch ex As Exception
                MsgBox("Please enter a valid grade.")
                GradeTextBox.Text = ""
            End Try
        End If
    End Sub
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Random Number Generator
        randomNumber = CInt(Int((20 * Rnd()) + 0))
        firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        firstNumberTextBox.Enabled = False
        secondNumberTextBox.Enabled = False
        SummaryButton.Enabled = False
        AddRadioButton.Checked = True
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'This sub is validating the math answers.
        'This sub is also calculating correct answers.
        'This sub is saving and resetting for next set of questions.
        If gradeValidated = True Then
            firstNumber = CInt(firstNumberTextBox.Text)
            secondNumber = CInt(secondNumberTextBox.Text)
            studentAnswer = studentAnswerTextBox.Text
            If AddRadioButton.Checked = True Then
                correctAnswer = firstNumber + secondNumber
            ElseIf SubtractRadioButton.Checked = True Then
                correctAnswer = firstNumber - secondNumber
            ElseIf DivideRadioButton.Checked = True Then
                correctAnswer = firstNumber / secondNumber
            ElseIf MultiplyRadioButton.Checked = True Then
                correctAnswer = firstNumber * secondNumber
            End If
            If studentAnswer = correctAnswer Then
                userMessage = "Good job, that is correct!"
                numbersCorrect += 1
            End If
            If studentAnswer <> correctAnswer Then
                userMessage = "Sorry, that is not correct. The correct answer was " & correctAnswer & "."
            End If
            MsgBox(userMessage)
            SummaryButton.Enabled = True
            numberOfProblems += 1
            randomNumber = CInt(Int((20 * Rnd()) + 0))
            firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
            secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
            studentAnswerTextBox.Text = ""
        Else
            MsgBox("Please enter a grade or correct grade.")
        End If
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'Displays summary
        MsgBox("You got " & numbersCorrect & " answers correct out of " & numberOfProblems & " problems.")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Dim ResetAllControls
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        studentAnswerTextBox.Text = ""
        AddRadioButton.Enabled = True
        numbersCorrect = 0
        numberOfProblems = 0
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Ends Program
        Me.Close()
    End Sub


End Class
