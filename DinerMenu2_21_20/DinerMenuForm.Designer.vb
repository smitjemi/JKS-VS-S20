<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(668, 12)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(120, 81)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "&Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(668, 99)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(120, 81)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "S&alad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(668, 186)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(120, 81)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "&Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(668, 273)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(120, 81)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Ink Free", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(155, 14)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(389, 79)
        Me.DinerNameLabel.TabIndex = 4
        Me.DinerNameLabel.Text = "Jitters Café"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Ink Free", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(21, 99)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(641, 255)
        Me.DisplaySpecialLabel.TabIndex = 5
        '
        'DinerMenuForm
        '
        Me.AcceptButton = Me.SoupButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "Jitters Café Special menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
End Class
