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
    Dim firstNumberGood As Boolean
    Dim secNumberGood As Boolean
    Dim studentAnswerGood As Boolean

    Private Sub StudentInfoGroupBox_Enter(sender As Object, e As EventArgs) Handles StudentInfoGroupBox.Enter, GradeTextBox.Leave, AgeTextBox.Leave
        Try
            ageNumber = CInt(AgeTextBox.Text)
            If ageNumber < 7 Or ageNumber > 11 Then
                MsgBox("Student is not eligble to compete.")
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid age.")
            AgeTextBox.Text = ""
        End Try

        Try
            gradeNumber = CInt(GradeTextBox.Text)
            If gradeNumber < 1 Or gradeNumber > 4 Then
                MsgBox("Student is not eligble to compete.")
            End If
        Catch ex As Exception
            MsgBox("Please enter a valid grade.")
            GradeTextBox.Text = ""
        End Try

    End Sub
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        firstNumberGood = False
        secNumberGood = False
        studentAnswerGood = False
        'Random Number Generator
        randomNumber = CInt(Int((4 * Rnd()) + 0))
        firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If studentAnswer = correctAnswer Then
            userMessage = "Good job, that is correct!"
            numbersCorrect += 1
        Else
            userMessage = "Sorry, that is not correct. The correct answer was " & correctAnswer & "."
        End If
        randomNumber = CInt(Int((20 * Rnd()) + 0))
        firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        MsgBox(userMessage)
        studentAnswerTextBox.Text = ""
        SummaryButton.Enabled = True
        numberOfProblems += 1
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox("You got " & numbersCorrect & " answers correct out of " & numberOfProblems & " problems.")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Dim ResetAllControls
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        studentAnswerTextBox.Text = ""
        firstNumberTextBox.Text = ""
        secondNumberTextBox.Text = ""
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        numbersCorrect = 0
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
