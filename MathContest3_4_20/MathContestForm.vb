'Jemika Smith
'RCET0265
'Spring2020
'Math Contest
'https://github.com/smitjemi/JKS-VS-S20
Public Class MathContestForm
    Private Sub InputGroupBox_Enter(sender As Object, e As EventArgs) Handles InputGroupBox.Enter

    End Sub
    End Sub
    Private Sub MathGroupBox_Enter(sender As Object, e As EventArgs) Handles MathGroupBox.Enter
        If AddRadioButton.Checked Or SubtractRadioButton.Checked Or MultiplyRadioButton.Checked Or DivideRadioButton.Checked Then
            Dim firstNumber As Integer
            Dim secondNumber As Integer
            Randomize()
            firstNumber = CInt((8 * Rnd()) + 1)
            secondNumber = CInt((8 * Rnd()) + 1)
            firstNumberTextBox.Text = CStr(firstNumber)
            SecondNumberTextBox.Text = CStr(secondNumber)
        End If
    End Sub
    'Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
    '    MsgBox(NameTextBox.Text & " got " 
    '    studentAnswerTextBox.Focus()
    'End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        firstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        studentAnswerTextBox.Enabled = ""
        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
