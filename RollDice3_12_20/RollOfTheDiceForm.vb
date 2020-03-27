Public Class RollOfTheDiceForm
    Sub Main()
        Dim sum As Integer
        Dim MyArray(12, 3) As Decimal
        Dim rollNum As Integer = 1000
        Dim totalPercent As Decimal
        For i = 1 To rollNum
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            'Console.WriteLine(sum)
            'add a count to the corresponding sum
            MyArray(sum, 2) += 1

            'myArray(row, column)
            For j = 2 To 12
                'display the number of the row (possible sums)
                MyArray(j, 1) = j
                'calculate chance of roll
                MyArray(j, 3) = Decimal.Round(MyArray(j, 2) / rollNum * 100, 1)
            Next
        Next

        'display array
        Console.WriteLine("      Total Dice    Times Rolled        % Chance")
        For i = 2 To 12
            For j = 1 To 3
                'Console.WriteLine(MyArray(i, j))
                Console.Write(MyArray(i, j).ToString().PadLeft(15) & "|")
            Next
            Console.WriteLine()
        Next
        For i = 2 To 12
            totalPercent += MyArray(i, 3)
        Next
        Console.WriteLine(totalPercent.ToString().PadLeft(47) & "|")
        Console.ReadLine()
    End Sub
End Class

