'Jemika Smith
'RCET0256
'Spring2020
'Diner Menu
'https://github.com/smitjemi/JKS-VS-S20
Option Strict On
Option Explicit On
Public Class DinerMenuForm
    'program displays buttons to chose an item from a menu.
    'each button has a description of what it is.
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'display soup button control
        Dim soupMessage As String
        soupMessage &= " Soup of the Day" & vbNewLine & " Homemade Chicken Noodle Soup, Served with a roll and Jitters coffee!  Classic, comforting, a cure-all for whatever ailed me, and I could taste my mommas love in it; Chef Melissa Smith"
        DisplaySpecialLabel.Text = soupMessage
    End Sub
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'display salad button control
        Dim saladMessage As String
        saladMessage &= " Salad of the Day" & vbNewLine & "  Cesar Salad, Served with a Jitters coffee! Crisp homemade croutons and a light caesar dressing; Chef Melissa Smith."
        DisplaySpecialLabel.Text = saladMessage
    End Sub
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'display fish button control
        Dim fishMessage As String
        fishMessage &= " Fish of the Day" & vbNewLine & " A sweet, gummy, red-fish shaped candy served for dessert. "
        DisplaySpecialLabel.Text = fishMessage
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'closes program
        Me.Close()
    End Sub
End Class
