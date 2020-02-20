'Jemika Smith
'RCET0265
'Spring2020
'List Example
'https://github.com/smitjemi/JKS-VS-S20
Option Explicit On
Option Strict On
Module ListExample

    Sub Main()
        Dim names As New List(Of String)
        Dim searchString As String

        names.Add("Tim")
        names.Add("Joe")
        'names.Add(Console.ReadLine())

        searchString = Console.ReadLine()
        If names.Contains(searchString) = True Then
            Console.WriteLine("Yes, " & searchString & " is at index" & names.IndexOf("searchString"))
        Else
            Console.WriteLine("Sorry, " & searchString & " was not found.")
        End If

        'For Each name In names
        '    Console.WriteLine(name)
        'Next
        Console.ReadLine()
    End Sub

End Module
