'Jemika Smith
'RCET0265
'Spring2020
'Math Contest
'https://github.com/smitjemi/JKS-VS-S20
Public Class MathContestForm

    Private Sub StudentInfoGroupBox_Enter(sender As Object, e As EventArgs) Handles StudentInfoGroupBox.Enter, NameTextBox.Checked, GradeTextBox.Checked, AgeTextBox.Checked


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
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
