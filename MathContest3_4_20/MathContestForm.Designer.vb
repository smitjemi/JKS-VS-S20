<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.firstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.secondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.studentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.MathGroupBox.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 39)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(130, 66)
        Me.SubmitButton.TabIndex = 11
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(199, 39)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(130, 66)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Cl&ear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(414, 39)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(130, 66)
        Me.SummaryButton.TabIndex = 13
        Me.SummaryButton.Text = "Summ&ary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(596, 39)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 66)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(215, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(6, 78)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(62, 20)
        Me.AgeTextBox.TabIndex = 2
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox.Location = New System.Drawing.Point(159, 81)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(62, 20)
        Me.GradeTextBox.TabIndex = 3
        '
        'firstNumberTextBox
        '
        Me.firstNumberTextBox.Location = New System.Drawing.Point(6, 39)
        Me.firstNumberTextBox.Name = "firstNumberTextBox"
        Me.firstNumberTextBox.Size = New System.Drawing.Size(124, 20)
        Me.firstNumberTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 18)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Name"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(10, 59)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 9
        Me.AgeLabel.Text = "Age"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(3, 23)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(61, 13)
        Me.FirstNumberLabel.TabIndex = 10
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(160, 62)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 11
        Me.GradeLabel.Text = "Grade"
        '
        'secondNumberTextBox
        '
        Me.secondNumberTextBox.Location = New System.Drawing.Point(182, 39)
        Me.secondNumberTextBox.Name = "secondNumberTextBox"
        Me.secondNumberTextBox.Size = New System.Drawing.Size(124, 20)
        Me.secondNumberTextBox.TabIndex = 5
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(179, 23)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(65, 13)
        Me.SecondNumberLabel.TabIndex = 13
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'studentAnswerTextBox
        '
        Me.studentAnswerTextBox.Location = New System.Drawing.Point(78, 90)
        Me.studentAnswerTextBox.Name = "studentAnswerTextBox"
        Me.studentAnswerTextBox.Size = New System.Drawing.Size(177, 20)
        Me.studentAnswerTextBox.TabIndex = 6
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(75, 74)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 15
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(6, 29)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 7
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(199, 29)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRadioButton.TabIndex = 8
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(414, 29)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRadioButton.TabIndex = 9
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(596, 29)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideRadioButton.TabIndex = 10
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(29, 12)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(329, 116)
        Me.StudentInfoGroupBox.TabIndex = 20
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.secondNumberTextBox)
        Me.OutputGroupBox.Controls.Add(Me.firstNumberTextBox)
        Me.OutputGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.OutputGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.OutputGroupBox.Controls.Add(Me.studentAnswerTextBox)
        Me.OutputGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(432, 12)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(329, 116)
        Me.OutputGroupBox.TabIndex = 21
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Current Math Problem"
        '
        'MathGroupBox
        '
        Me.MathGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathGroupBox.Location = New System.Drawing.Point(29, 134)
        Me.MathGroupBox.Name = "MathGroupBox"
        Me.MathGroupBox.Size = New System.Drawing.Size(732, 68)
        Me.MathGroupBox.TabIndex = 22
        Me.MathGroupBox.TabStop = False
        Me.MathGroupBox.Text = "Math Problem Type"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ExitButton)
        Me.GroupBox4.Controls.Add(Me.SummaryButton)
        Me.GroupBox4.Controls.Add(Me.ClearButton)
        Me.GroupBox4.Controls.Add(Me.SubmitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 209)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(732, 130)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 345)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MathGroupBox)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Form1"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.MathGroupBox.ResumeLayout(False)
        Me.MathGroupBox.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents firstNumberTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents secondNumberTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents studentAnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents MathGroupBox As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
