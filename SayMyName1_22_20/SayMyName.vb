﻿Option Explicit On
Option Strict On
'Jemika Smith
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/smitjemi/JKS-VS-S20
Module sayMyNname

    Sub Main()
        'promt user for a message
        'then display the message

        Dim userMessage As String
        Console.WriteLine("Hello, what is your name?")
        userMessage = Console.ReadLine()

        If userMessage = "Emily" Then
            Console.WriteLine(" You are now ready to become a Jedi, Padawan " & userMessage & "!")
        ElseIf userMessage = "Joe" Then
            Console.WriteLine(" Are you ready to become a Padawan, " & userMessage & "?")
        ElseIf userMessage = "Jemika" Then
            Console.WriteLine(" Are you ready to train your Padawan" & userMessage & "?")

        End If

    End Sub

End Module
