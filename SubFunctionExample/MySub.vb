'Jemika Smith
'RCET0265
'Spring2020
'SubFunction
Option Explicit On
Option Strict On
Module MySub

    Sub Main()
        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        MySub(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)

        myNumber = MyFunc(myNumber)
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(MyFunc(myNumber))

        Console.ReadLine()
    End Sub
    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        myNumber += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub
    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function
End Module
