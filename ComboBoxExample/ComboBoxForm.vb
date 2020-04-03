'Jemika Smith
'RCET0265
'Spring 2020
'ComboBox Example

Public Class ComboBoxForm
    'Determines how many users, 10 user Names and Ages.
    Dim userInfo(9, 1) As String
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim userIndex As Integer = 0
        Const NAMEFIELDINDEX = 0I
        Const AGEFIELDINDEX = 1I
        'Load Name into the ComboBox
        MainComboBox.Items.Add(NameTextBox.Text)
        'Load Name and Age into array
        userIndex = CInt(MainComboBox.Items.Count)
        userInfo(userIndex, NAMEFIELDINDEX) = NameTextBox.Text
        userInfo(userIndex, AGEFIELDINDEX) = AgeTextBox.Text
        AgeTextBox.Text = MainComboBox.Items.Count
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub
    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged
        Me.Text = MainComboBox.SelectedIndex
        NameTextBox.Text = MainComboBox.SelectedItem.ToString
    End Sub
End Class
