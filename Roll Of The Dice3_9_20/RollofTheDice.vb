'Jemika Smith
'RCET0265
'Spring2020
'Roll of the Dice
'https://github.com/smitjemi/JKS-VS-S20
Module RollofTheDice
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
        Console.WriteLine("      Total Dice   Times Rolled      ")
        For i = 1 To 2
            For j = 2 To 12
                Console.Write(MyArray(j, i).ToString().PadLeft(3) & "|")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
End Module
