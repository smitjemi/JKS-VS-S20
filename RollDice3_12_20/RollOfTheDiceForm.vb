Public Class RollOfTheDiceForm
    Sub Main()
        Dim sum As Integer
        Dim MyArray(12, 2) As Decimal
        Dim rollNumber As Integer = 1000
        For i = 1 To rollNumber
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            MyArray(sum, 2) += 1
            'myArray(row, column)
            For j = 2 To 12
                MyArray(j, 1) = j
            Next
        Next
        'display's array
        Console.WriteLine("Total Dice   Times Rolled")
        For i = 1 To 2
            For j = 2 To 12
                Console.Write(MyArray(j, i).ToString().PadLeft(3) & "|")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
    Function ArrayToString(arrayofNumbers() As Integer, columnWidth, As Integer) As String
        Dim tempString As String
        For i = LBound(arrayofNumbers) To UBound(arrayofNumbers)
            tempString = CStr(arrayofNumbers(i)).PadLeft(3) & "|"
        Next
        Return tempString
    End Function
    Sub WritetoListbox(arrayofNumbers() As Integer)
        Dim rowWidth As Integer = 55
        Dim columnWidth As Integer = CInt(rowWidth / arrayofNumbers.Count)
        TotalListBox.Items.Add(Space(Len(Me.Text) - CInt(rowWidth / 2)) & Me.Text & Space(Len(Me.Text) - CInt(rowWidth / 2)))
        TotalListBox.items.Add(StrDup(rowWidth, "-"))
        TotalListBox.Items.Add("1")
        ArrayToString(arrayofNumbers, 4)
        TotalListBox.Items.Add(StrDup(rowWidth, "-"))
    End Sub
    Private Sub RollEventHandler(sender As Object, e As EventArgs) Handles RollButton.
            WriteToListBox()
        For i = 1 To rollNumber
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            MyArray(sum, 2) += 1
            'myArray(row, column)
            For j = 2 To 12
                MyArray(j, 1) = j
End Class
