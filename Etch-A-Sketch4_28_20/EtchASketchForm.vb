'Jemika Smith
'RCET0265
'Spring 2020
'Etch-A-Sketch
'https://github.com/smitjemi/JKS-VS-S20
Public Class EtchASketchForm
    Dim penColor As Color
    Dim myPen As New Pen(Color.Black)
    Dim oldX As Integer
    Dim oldY As Integer
    Dim graph As Graphics
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Me.Text = "x: " & e.X & " y: " & e.Y & " Mouse Button: " & e.Button.ToString
        graph = PictureBox1.CreateGraphics 'create graphics object
        If e.Button.ToString <> "None" Then 'draw the line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        End If
        oldX = e.X
        oldY = e.Y
        'constructor for pen object
    End Sub

    Private Sub ChaneColorButton_Click(sender As Object, e As EventArgs) Handles ChaneColorButton.Click
        ColorDialog1.ShowDialog() 'the color wheel 
        penColor = ColorDialog1.Color 'makes the pen the color the user chose
        myPen.Color = penColor 'telling the program that the mouse is the pen
    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        Dim Xvalue As Decimal
        Dim Yvalue As Decimal
        Dim oldY2 = 200
        Dim oldX2 = 0
        Label1.Show()
        myPen.Color = Color.Black
        graph.Clear(BackColor) 'erase
        'Verticle Lines (Same X change Y)
        For xVal = 80 To 720 Step 80
            For yVal = 5 To 400 Step 10
                graph.DrawLine(myPen, xVal, yVal, xVal, yVal + 5)
            Next
        Next
        'Horizontal Lines (Same Y change X)
        For yVal = 40 To 360 Step 40
            For xVal = 5 To 800 Step 10
                graph.DrawLine(myPen, xVal, yVal, xVal + 5, yVal)
            Next
        Next
        'Creates sinewave
        myPen.Color = Color.Blue
        For X = 1 To 800 'Draw graticules
            Yvalue = 200 - (50 * Math.Sin(X / 400 * 2 * Math.PI)) 'Draw sine
            Xvalue = X
            graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next
        'Creates sinewave phase of cos
        myPen.Color = Color.Green
        oldX2 = 0
        oldY2 = 200
        For X = 1 To 800 'Draw graticules
            Yvalue = 200 - (50 * Math.Cos(X / 400 * 2 * Math.PI)) 'Draw Cos
            Xvalue = X
            graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next
        'creates a tangent wave
        myPen.Color = Color.Red
        oldX2 = 0
        oldY2 = 200
        For X = 1 To 800 'Draw graticules
            Yvalue = 200 - (50 * Math.Tan(X / 400 * 2 * Math.PI)) 'Draw Tan
            If Yvalue > 600 Then
                Yvalue = 600
            ElseIf Yvalue < -200 Then
                Yvalue = -200
            End If
            Xvalue = X
            If (X > 95 And X < 105) Or (X > 295 And X < 305) Or (X > 495 And X < 505) Or (X > 695 And X < 705) Then
                ' DO NOT DRAW
            Else
                graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            End If
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next
        Label1.Text = ("Sin: Blue" & vbNewLine & "Cos: Green" & vbNewLine & "Tan: Red") 'tells you which colors goes to what waveform.
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        Dim oldTop = Me.Top
        'Shakes the EtchASketch to erase
        For i = 1 To 3
            For j = 1 To 9000000 'Had to shake enough for you to acutally see it move
                If j < 4500000 Then
                    Me.Top = oldTop - 50
                Else
                    Me.Top = oldTop
                End If
            Next
        Next
        Label1.Hide() 'shows whichwaveforms are what
        graph.Clear(BackColor)
    End Sub
End Class
