'Jemika Smith
'RCET0265
'Spring 2020
'Accumutlate Message
'https://github.com/smitjemi/JKS-VS-S20
Public Class AccumulateMessage
    Sub Main()
        'MsgBox(UserMessages(True, "Hello", False)
        Console.WriteLine(UserMessage(True, "Hello 1", False))
        Console.WriteLine(UserMessage(True, "Hello 2", False))
        Console.WriteLine(UserMessage(True, "Hello 3", False))
        MsgBox(UserMessages(True, "", False))
    End Sub
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Dim formattedMessages As String = ""
        formattedMessages &= message
        Return formattedMessages
    End Function
End Class
