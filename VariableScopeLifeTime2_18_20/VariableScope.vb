'Jemika Smith
'RCET0265
'Spring2020
'Variable Scope Life Time
'https://github.com/smitjemi/JKS-VS-S20
Module VariableScope
    Public aName As String = "Pete"
    'aName = "Chucky"
    Sub Main()
        Dim aNumber As Integer
        Dim anotherName As String
        aNumber = 5
        aName = "Chucky"
        anotherName = "Jason"
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anotherName)
        MySub()
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.WriteLine(anotherName)
        Console.ReadLine()
    End Sub
    Sub MySub()
        Dim aNumber As Integer
        Dim anotherName As String
        aNumber = 3
        aName = "Billy"
        anotherName = "Freddy"
    End Sub
End Module
