Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring2020
'ifThen
Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 5

        If firstNumber > secondNumber Then
            Console.WriteLine("First number is bigger...")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("Second number is bigger...")
        ElseIf firstNumber <= secondNumber Then
            Console.WriteLine("First number is smaller or equal")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("First number is bigger or equal")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("The numbers are not equal")
        Else
            Console.WriteLine("Some other thing???")
        End If
        Console.ReadLine()

    End Sub

End Module
