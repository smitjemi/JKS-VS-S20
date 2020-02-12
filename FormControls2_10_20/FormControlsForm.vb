Public Class FormControlsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayText As String

        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text

        DisplayLabel.Text = displayText
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox.Text
        End If
        If CheckBox2.Checked = True Then
            MsgBox("Hello, Your Data is No Good!!")
        End If
        If CheckBox3.Checked = True Then
            UserPictureBox.Image = My.Resources.puppy
        End If
    End Sub

    Private Sub FormControlsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton2.Checked = True
    End Sub

End Class
