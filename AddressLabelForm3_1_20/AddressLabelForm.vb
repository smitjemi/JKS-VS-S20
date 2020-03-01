'Jemika Smith
'RCET0265
'Spring2020
'Address Label Form
'https://github.com/smitjemi/JKS-VS-S20
Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text &= FirstNameTextBox.Text
        DisplayLabel.Text &= LastNameTextBox.Text & "" & vbNewLine
        DisplayLabel.Text &= StreetAddressTextBox.Text & "" & vbNewLine
        DisplayLabel.Text &= CityTextBox.Text & ", "
        DisplayLabel.Text &= StateTextBox.Text & "  "
        DisplayLabel.Text &= ZipTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
