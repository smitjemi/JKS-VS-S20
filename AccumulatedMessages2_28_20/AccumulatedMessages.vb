'Jemika Smith
'RCET0265
'Spring 2020
'Accumutlate Message
'https://github.com/smitjemi/JKS-VS-S20
Module AccumulatedMessages

    Sub Main()
        MsgBox("Hello, Tim")
        UserMessages(True, "This is Jemika", False)
        UserMessages(True, "You're a great teacher!", False)
        UserMessages(True, "Have a good time grading this!", False)
        MsgBox(UserMessages(True, "", False))
    End Sub
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String = ""
        If clearMessage = False Then
            If addMessage = True Then
                formattedMessages &= message & vbNewLine
            End If
        Else
            formattedMessages = ""
        End If
        Return formattedMessages
    End Function

End Module
