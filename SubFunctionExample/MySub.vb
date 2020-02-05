'Jemika Smith
'RCET0265
'Spring2020
'SubFunction
'https://github.com/smitjemi/JKS-VS-S20
Option Explicit On
Option Strict On
Module MySub

    Sub Main()
        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'MySub(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)

        'DoMath(7, 5, "*")
        'For i = 1 To 80 Step 20
        ShowPattern(27, "JEM")
        'Next
        Console.ReadLine()
    End Sub
    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber += 2
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
    Sub DoMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double
        If operatorChoice = "+" Then
            result = (firstNumber + secondNumber)
        ElseIf operatorChoice = "-" Then
            result = (firstNumber - secondNumber)
        ElseIf operatorChoice = "/" Then
            result = (firstNumber / secondNumber)
        ElseIf operatorChoice = "*" Then
            result = (firstNumber * secondNumber)
        End If
        Console.WriteLine(result)
    End Sub
    Sub ShowPattern(length As Integer, character As String)
        'Dim character As String
        Dim pattern As String
        Console.WriteLine(Len(character))
        'character = "*"
        pattern = ""
        For index = 1 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next
        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next

    End Sub

End Module
