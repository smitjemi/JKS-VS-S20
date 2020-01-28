Option Explicit On
Option Strict On
'Jemika Smith
'RCET0256
'Spring2020
'LoopExample
'https://github.com/smitjemi/JKS-VS-S20
Module LoopExample

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        firstNumber = 5
        secondNumber = 7
        result = firstNumber + secondNumber

        For loopCount = 0 To 25 Step 5
            result = result + 3
            Console.WriteLine(loopCount)
        Next
        Console.WriteLine(result)
        Console.ReadLine()
    End Sub

End Module
