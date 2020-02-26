'Jemika Smith
'RCET0265
'Spring 2020
'List Box Example
'https://github.com/smitjemi/JKS-VS-S20
Option Strict On
Option Explicit On

Public Class ListBoxForm
    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DataListBox
        FirstNameTextBox.Text = "Jemika"
        LastNameTextBox.Text = "Smith"
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        DataListBox.Items.Add(FirstNameTextBox.Text & " " & LastNameTextBox.Text)
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        DataListBox.Items.Clear()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Dim index As Integer
        Me.Text = DataListBox.SelectedIndex.ToString
        index = InStr(DataListBox.SelectedItem.ToString, " ")
        FirstNameTextBox.Text = Trim(Strings.Left(DataListBox.SelectedItem.ToString, index))
        LastNameTextBox.Text = Trim(Strings.Mid(DataListBox.SelectedItem.ToString, index, Len(DataListBox.SelectedItem.ToString)))
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
