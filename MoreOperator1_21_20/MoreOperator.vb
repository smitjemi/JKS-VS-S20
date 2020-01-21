Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring2020
'More Operator
Module MoreOperator

    Sub Main()

        'promt user for a message
        'then display the message

        Dim userMessage As String
        'userMessage = "Hello"

        Console.WriteLine("Please enter a message. Press enter when done")
        userMessage = Console.ReadLine()
        Console.WriteLine("You entered " & userMessage & "Good job!")
        Console.ReadLine()
    End Sub

End Module
