'Jemika Smith
'RCET0265
'Spring2020
'BetterCalculator
'https://github.com/smitjemi/JKS-VS-S20
Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean
        Dim userInput1 As String
        Dim userInput2 As String

        promptUser = True
        quitProgram = False

        Do While quitProgram = False
            'prompt user for two numbers
            Console.Write("Please enter a first number...")
            Do While promptUser = True
                userInput1 = Console.ReadLine()
                Try
                    firstNumber = CInt(userInput1)
                    promptUser = False
                    Console.WriteLine("You Entered """ & firstNumber & """")
                Catch ex As Exception
                    If userInput1 = "q" Then
                        promptUser = False
                        quitProgram = True
                    Else
                        Console.WriteLine("You Entered """ & userInput1 & """. Please enter a whole number")
                        promptUser = True
                    End If

                End Try
            Loop
            promptUser = True
            Do While promptUser = True And quitProgram = False
                Console.Write("Please enter a second number...")
                userInput2 = Console.ReadLine()
                Try
                    secondNumber = CInt(userInput2)
                    promptUser = False
                    Console.WriteLine("You Entered """ & secondNumber & """")
                Catch ex As Exception
                    If userInput2 = "q" Then
                        promptUser = False
                        quitProgram = True
                    Else
                        Console.WriteLine("You Entered """ & userInput2 & """. Please enter a whole number")
                        promptUser = True
                    End If
                End Try
            Loop
            promptUser = True
            'prompt user for sum or product choice
            'perform proper operation
            Do While promptUser = True And quitProgram = False
                Console.WriteLine("Please Choose an Option")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Multiply")
                Console.WriteLine("3. Subtract")
                Console.WriteLine("4. Divide")
                userChoice = Console.ReadLine()
                Console.WriteLine("You Entered """ & userChoice & """")

                'Determine the user's choice
                If userChoice = "1" Then
                    promptUser = False
                    Console.WriteLine(firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)
                ElseIf userChoice = "2" Then
                    promptUser = False
                    Console.WriteLine(firstNumber & " * " & secondNumber & " = " & firstNumber + secondNumber)
                ElseIf userChoice = "3" Then
                    promptUser = False
                    Console.WriteLine(firstNumber & " - " & secondNumber & " = " & firstNumber + secondNumber)
                ElseIf userChoice = "4" Then
                    promptUser = False
                    Console.WriteLine(firstNumber & " / " & secondNumber & " = " & firstNumber + secondNumber)
                ElseIf userChoice = "q" Then
                    promptUser = False
                    quitProgram = True
                Else
                    Console.WriteLine("Invalid Selection")
                    promptUser = True
                End If
            Loop
            'display result prompt to end
            promptUser = True
        Loop
        Console.WriteLine("Have a nice day...")
        Console.ReadLine()

    End Sub

End Module
