'Jemika Smith
'RCET0265
'Spring2020
'Math Contest
'https://github.com/smitjemi/JKS-VS-S20
Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim userMessage As String = ""
        Dim firstNumberGood As Boolean
        Dim secNumberGood As Boolean
        Dim studentAnswerGood As Boolean
        firstNumberGood = False
        secNumberGood = False
        studentAnswerGood = False
        Dim randomNumber As Integer
        'Random Number Generator
        randomNumber = CInt(Int((4 * Rnd()) + 0))
        firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim userMessage As String
        Dim NameTextBox As String
        'Dim firstNumber As Integer
        'Dim secondNumber As Integer
        Dim studentAnswer As Integer
        Dim correctAnswer As Integer
        Dim randomNumber As Integer
        Dim numberOfProblems As Integer = 0
        Dim numbersCorrect As Integer = 0
        randomNumber = CInt(Int((4 * Rnd()) + 0))
        firstNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))
        secondNumberTextBox.Text = Str(Int((20 * Rnd()) + 0))

        If studentAnswer = correctAnswer Then
            userMessage = "Good job " & NameTextBox & ", that is correct!"
            numberOfProblems += 1
        Else
            userMessage = "Sorry, " & NameTextBox & ", that is not correct. The correct " & "answer was " & correctAnswer & "."
        End If
        MsgBox(userMessage)
        firstNumberTextBox.Text = ""
        secondNumberTextBox.Text = ""
        studentAnswerTextBox.Text = ""
        SummaryButton.Enabled = True
        numberOfProblems += 1
    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim numbersCorrect As Integer
        Dim numberOfProblems As Integer
        MsgBox("You got " & numbersCorrect & " answers out of " & numberOfProblems & "correct.")
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim numbersCorrect As Integer = 0
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
