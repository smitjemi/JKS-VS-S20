Option Explicit On
Option Strict On
Option Compare Text
'Jemika Smith
'RCET0265
'Spring2020
'Simple Calculator
'https://github.com/smitjemi/JKS-VS-S20
Module SimpleCalculator

    Sub Main()

        Dim userMessage As Integer
        Dim userMessage2 As Integer
        Dim userMessage3 As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean

        quitProgram = False
        promptUser = True

        Do While quitProgram = False

            'prompt user for two numbers 
            Console.WriteLine("Hello, can you give me a number? ")
            Do While promptUser = True
                Try
                    userMessage = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("ERROR, Please enter a whole number")
                    promptUser = True
                End Try
            Loop
            Console.WriteLine("Hello, can you give me another number?")
            Try
                userMessage2 = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("ERROR, Please enter a whole number")
            End Try

            'promt user for sum or product choice
            'then display the message
            Console.WriteLine("Do you want to add or multiply?")
            userMessage3 = Console.ReadLine()

            If userMessage3 = "Add" Or userMessage3 = "+" Then
                    Console.WriteLine(userMessage + userMessage2)
                ElseIf userMessage3 = "Multiply" Or userMessage3 = "*" Then
                    Console.WriteLine(userMessage * userMessage2)

                    'Determine the user's choice
                    If userMessage3 = "Add" Or userMessage3 = "+" Then
                        Try
                            Console.WriteLine(userMessage + userMessage2)
                        Catch ex As Exception
                            Console.WriteLine("ERROR, Please enter a whole number")
                            Console.WriteLine("YOu broke it")
                        End Try
                    ElseIf userMessage3 = "Multiply" Or userMessage3 = "*" Then
                        Try
                            Console.WriteLine(userMessage * userMessage2)
                        Catch ex As InvalidCastException
                            Console.WriteLine("ERROR, Please enter a whole number")
                        Catch ex As Exception
                            Console.WriteLine("You Broke it")
                        End Try
                    Else
                        Console.WriteLine("Invalid Selection")
                    End If
                End If
                'display result prompt to end
                Console.WriteLine("Have a great day")
                Console.WriteLine("Press Any To Run Again. Enter Q to quit.")

                If Console.ReadLine() = "q" Then
                    quitProgram = True
                Else
                    quitProgram = False
                End If
                Console.Clear()
            Loop
    End Sub

End Module
