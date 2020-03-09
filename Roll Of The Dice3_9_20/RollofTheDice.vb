'Jemika Smith
'RCET0265
'Spring2020
'Roll of the Dice
Module RollofTheDice

    Sub Main()
        Console.WriteLine(getFirstRandomInteger1To6)
        Console.WriteLine(getSecondRandomInteger1To6)

    End Sub
    Private Function getFirstRandomInteger1To6() As Integer
        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getFirstRandomInteger1To6 = Convert.ToInt32(tempSingle) 'return the number
        Console.WriteLine(getFirstRandomInteger1To6)
        Console.ReadLine()
    End Function
    Private Function getSecondRandomInteger1To6() As Integer
        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getSecondRandomInteger1To6 = Convert.ToInt32(tempSingle) 'return the number
        Console.WriteLine(getSecondRandomInteger1To6)
        Console.ReadLine()
    End Function
End Module
