Option Explicit On
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
        'userMessage = "Name"
        Console.WriteLine("Hello, What is your name?")
        userMessage = Console.ReadLine()
        Console.WriteLine("Hello, " & userMessage & " Have a nice day! ")
        Console.ReadLine()
    End Sub

End Module
