<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketchForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChaneColorButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 400)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ChaneColorButton
        '
        Me.ChaneColorButton.Location = New System.Drawing.Point(41, 406)
        Me.ChaneColorButton.Name = "ChaneColorButton"
        Me.ChaneColorButton.Size = New System.Drawing.Size(115, 45)
        Me.ChaneColorButton.TabIndex = 1
        Me.ChaneColorButton.Text = "Change Color"
        Me.ChaneColorButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(271, 408)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(115, 41)
        Me.DrawButton.TabIndex = 2
        Me.DrawButton.Text = "Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(624, 406)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(115, 39)
        Me.EraseButton.TabIndex = 3
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'EtchASketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.ChaneColorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EtchASketchForm"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChaneColorButton As Button
    Friend WithEvents DrawButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label1 As Label
End Class
