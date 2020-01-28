Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring2020
'Simple Calculator
'https://github.com/smitjemi/JKS-VS-S20
Module SimpleCalculator

    Sub Main()
        'prompt user a message
        'then display the message
        Dim userMessage As String
        Dim userMessage2 As String
        Dim userMessage3 As String

        Console.WriteLine("Hello, can you give me a number? ")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, can you give me another number?")
        userMessage2 = Console.ReadLine()
        Console.WriteLine("Do you want to add or multiply?")
        userMessage3 = Console.ReadLine()

        If userMessage3 = "Add" Or userMessage3 = "+" Then
            Console.WriteLine(CInt(userMessage) + CInt(userMessage2))
        ElseIf userMessage3 = "Multiply" Or userMessage3 = "*" Then
            Console.WriteLine(CInt(userMessage) * CInt(userMessage2))

            'Determine the user's choice
            If userMessage = "Add" Or userMessage = "+" Then
                Try
                    Console.WriteLine(CInt(userMessage) + CInt(userMessage2))
                Catch ex As Exception
                    'Console.WriteLine(ex.Message.ToString)
                End Try
            ElseIf userMessage = "Multiply" Or userMessage = "*" Then
                Try
                    Console.WriteLine(CInt(userMessage) * CInt(userMessage2))
                Catch ex As Exception
                    Console.WriteLine("ERROR, Please enter a whole number")
                End Try
            Else
                Console.WriteLine("Invalid Selection")
            End If
        End If
    End Sub

End Module
