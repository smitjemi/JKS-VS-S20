'Jemika Smith
'RCET0265
'Spring2020

Public Class FileExampleForm
    Dim fileName As String = ""
    Sub WriteToFile()
        'FileOpen(1, "Mytestfile.txt", OpenMode.Output)
        FileOpen(1, "fileName", OpenMode.Output)
        WriteLine(1, "Don't overwrite your file.")
        FileClose(1)
    End Sub
    Sub AppendToFile()
        FileOpen(1, "fileName", OpenMode.Append)
        WriteLine(1, "File was opend for append", Now)
        FileClose(1)
    End Sub
    Sub ReadAfile()
        Dim tempString As String
        FileOpen(1, fileName, OpenMode.Input)
        Input(1, tempString)
        Console.WriteLine(tempString)
        Input(1, tempString)
        Console.WriteLine(tempString)
        FileClose(1)
    End Sub
    Sub ReadEntireFile()
        Dim tempString As String
        FileOpen(1, fileName, OpenMode.Input)
        Do While Not EOF(1)
            Input(1, tempString)
            Console.WriteLine(tempString)
        Loop
        Catch ex As Exception
        Console.WriteLine(Exception.Message)
        Finally
        FileClose(1)
        End Try
    End Sub
    Private Sub FileExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'WriteToFile()
        'AppendToFile()
        ReadAfile()
    End Sub
End Class
