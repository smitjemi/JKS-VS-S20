'Jemika Smith
'RCET 0265
'Spring 2020
'Array Example

Module ArrayExample

    Sub Main()
        Dim myArray(3) As Integer
        myArray(1) = 5
        myArray = {1, 2, 3, 4}
        myArray(0) = 5
        ReDim perserve myArray 
        Console.ReadLine()
    End Sub
    Sub AnotherArrayExample()
        'no element definition
        Dim infoArray() As String
        infoArray = Split("Hello, Goodbye, Pizza, Hungry, Ice Cream", ",")
        For Each thingy In infoArray
            Console.WriteLine(thingy)
            infoArray.Contains(thingy)
        Next
    End Sub
End Module
