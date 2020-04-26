'Jemika Smith
'RCET0265
'Spring 2020
'Stans Grocery
'https://github.com/smitjemi/JKS-VS-S20
Public Class StansGroceryForm
    Dim Myarray(2, 4) As String
    Dim x As Integer = 0
    Dim y As Integer = 0
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As String = "..\..\Grocery Item List.txt" 'File is located and read.
        FileOpen(1, file, OpenMode.Input) 'Open's File
        Do While Not EOF(1)
            Myarray(x, y) = LineInput(1)
            SelectedItemBox.Items.Add(Myarray(x, y))
            If y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            End If
        Loop
        FileClose()
    End Sub
    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        MsgBox("GUI: Tim Rossitor" & vbNewLine & "Program: Jemika Smith" & vbNewLine & "Version 0.1")
    End Sub
    Private Sub SelectedItemBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedItemBox.SelectedIndexChanged
        Dim find As Boolean
        find = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Searches the Array
            If SelectedItemBox.Text = Myarray(x, y) Then
                find = False
                DisplayListBox.Items.Add("You will find " & Myarray(x, y) & " on asile #" & (x + 1) & ", item #" & (y + 1))
            ElseIf y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            ElseIf x > 4 Then
                find = False
                MsgBox("Item was not found, try agian.")
            End If
        Loop
    End Sub
    Private Sub LookUpItemTextBox_TextChanged(sender As Object, e As EventArgs) Handles LookUpItemTextBox.TextChanged
        'Drop down menu
        If LookUpItemTextBox.Text = "" Then
            SelectedItemBox.Enabled = True
        Else
            SelectedItemBox.Enabled = False
        End If
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim find As Boolean
        find = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Search the array
            Try
                If LookUpItemTextBox.Text = "" Then
                    find = False
                    MsgBox("Please enter a search or select from the dropdown.")
                ElseIf LCase(LookUpItemTextBox.Text) = "zzz" Then
                    find = False
                    Me.Close()
                ElseIf LCase(LookUpItemTextBox.Text) = LCase(Myarray(x, y)) Then
                    find = False
                    DisplayListBox.Items.Add("You will find " & Myarray(x, y) & " on asile #" & (x + 1) & ", item #" & (y + 1))
                ElseIf y < 4 Then
                    y = y + 1
                ElseIf y = 4 Then
                    y = 0
                    x = x + 1
                ElseIf x > 4 Then
                    find = False
                    MsgBox("Item not found!")
                End If
            Catch ex As Exception
                find = False
                MsgBox("Item not found!")
                LookUpItemTextBox.Text = ""
            End Try
        Loop
    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
