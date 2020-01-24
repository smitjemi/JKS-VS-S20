Option Strict On
Option Explicit On
'Jemika Smith
'RCET0265
'Spring2020
'SayMyNameAgain
Module SayMyNameAgain

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String
        Console.WriteLine("Hello, what is your name?")
        userMessage = Console.ReadLine()

        If userMessage = "Emily" Then
            Console.WriteLine(" You are now ready to become a Jedi, Padawan " & userMessage & "!")
        ElseIf userMessage = "Joe" Then
            Console.WriteLine(" Are you ready to become a Padawan, " & userMessage & "?")
        ElseIf userMessage = "Jemika" Then
            Console.WriteLine(" Are you ready to train your Padawan " & userMessage & "?")
        End If
    End Sub

End Module
