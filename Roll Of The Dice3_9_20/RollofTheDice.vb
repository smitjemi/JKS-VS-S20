'Jemika Smith
'RCET0265
'Spring2020
'Roll of the Dice
Module RollofTheDice

    Sub Main()
        Dim DiceSum As Single
        Console.WriteLine(FirstDice)
        Console.WriteLine(SecondDice)
        Console.WriteLine(DiceTotal)
        Totals(2)
    End Sub
    Private Function FirstDice() As Integer
        Dim maxSingle As Single : maxSingle = 6
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond)
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + maxSingle)
        FirstDice = Convert.ToInt32(tempSingle)
        Console.WriteLine("FirstDi =")
        Console.WriteLine(FirstDice)
        Console.ReadLine()
    End Function
    Private Function SecondDice() As Integer
        Dim maxSingle As Single : maxSingle = 6
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond)
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + maxSingle)
        SecondDice = Convert.ToInt32(tempSingle)
        Console.WriteLine("SecondDi =")
        Console.WriteLine(SecondDice)
        Console.ReadLine()
    End Function
    Private Function DiceTotal() As Integer
        Dim DiceSum As Single
        DiceSum = FirstDice() + SecondDice()
        Console.WriteLine("FirstDi + SecondDi = " & DiceSum)
    End Function
    Private Function Totals(currentNumber As Integer) As Integer
        Static myArray(currentNumber) As Integer
        myArray(currentNumber) = 12
        myArray = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
        Static numbers(12) As Integer
        ReDim Preserve myArray(12)
        Console.ReadLine()
        'Static myArray(currentNumber) As Integer

        'myArray(1) = currentNumber

        'myArray = {1, 2, 3, 4}

        'myArray(0) = 5
        'ReDim Preserve myArray(15)


        'Console.ReadLine()
    End Function
End Module
