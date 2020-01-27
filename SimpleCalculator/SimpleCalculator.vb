Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring2020
'Simple Calculator
Module SimpleCalculator

    Sub Main()
        'prompt user a message
        'then display the message
        Dim userMessage As String
        Dim userMessage2 As String
        Dim userMessage3 As String

        Console.WriteLine(" Hello, can you give me a number?  ")
        userMessage = Console.ReadLine()
        Console.WriteLine(" Hello, can you give me another number? ")
        userMessage2 = Console.ReadLine()
        Console.WriteLine(" Do you want to add or multiply ")
        userMessage3 = Console.ReadLine()

        If userMessage3 = "Add" Or userMessage3 = "+" Then
            Console.WriteLine(CInt(userMessage) + CInt(userMessage2))
        ElseIf userMessage3 = "Multiply" Or userMessage3 = "*" Then
            Console.WriteLine(CInt(userMessage) * CInt(userMessage2))
        End If
    End Sub

End Module
