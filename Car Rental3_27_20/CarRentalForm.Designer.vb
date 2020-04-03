<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.DaysTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdTextBox = New System.Windows.Forms.TextBox()
        Me.BegOdTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.OweTextBox = New System.Windows.Forms.TextBox()
        Me.MinusTextBox = New System.Windows.Forms.TextBox()
        Me.DayTextBox = New System.Windows.Forms.TextBox()
        Me.MileageTextBox = New System.Windows.Forms.TextBox()
        Me.MilesDrTextBox = New System.Windows.Forms.TextBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.BeginningLabel = New System.Windows.Forms.Label()
        Me.EndingLabel = New System.Windows.Forms.Label()
        Me.NumberDaysLabel = New System.Windows.Forms.Label()
        Me.DistanceLabel = New System.Windows.Forms.Label()
        Me.MileageLabel = New System.Windows.Forms.Label()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.OweLabel = New System.Windows.Forms.Label()
        Me.MilesGroupBox = New System.Windows.Forms.GroupBox()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MilesGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(230, 33)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(230, 62)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTextBox.TabIndex = 1
        '
        'StateTextBox
        '
        Me.StateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(230, 114)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StateTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(230, 88)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CityTextBox.TabIndex = 2
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaysTextBox.Location = New System.Drawing.Point(230, 219)
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DaysTextBox.TabIndex = 7
        '
        'EndOdTextBox
        '
        Me.EndOdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndOdTextBox.Location = New System.Drawing.Point(230, 193)
        Me.EndOdTextBox.Name = "EndOdTextBox"
        Me.EndOdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.EndOdTextBox.TabIndex = 6
        '
        'BegOdTextBox
        '
        Me.BegOdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BegOdTextBox.Location = New System.Drawing.Point(230, 167)
        Me.BegOdTextBox.Name = "BegOdTextBox"
        Me.BegOdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BegOdTextBox.TabIndex = 5
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipTextBox.Location = New System.Drawing.Point(230, 141)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipTextBox.TabIndex = 4
        '
        'OweTextBox
        '
        Me.OweTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OweTextBox.Location = New System.Drawing.Point(571, 140)
        Me.OweTextBox.Name = "OweTextBox"
        Me.OweTextBox.Size = New System.Drawing.Size(100, 22)
        Me.OweTextBox.TabIndex = 12
        '
        'MinusTextBox
        '
        Me.MinusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinusTextBox.Location = New System.Drawing.Point(571, 110)
        Me.MinusTextBox.Name = "MinusTextBox"
        Me.MinusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MinusTextBox.TabIndex = 11
        '
        'DayTextBox
        '
        Me.DayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayTextBox.Location = New System.Drawing.Point(571, 84)
        Me.DayTextBox.Name = "DayTextBox"
        Me.DayTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DayTextBox.TabIndex = 10
        '
        'MileageTextBox
        '
        Me.MileageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileageTextBox.Location = New System.Drawing.Point(571, 58)
        Me.MileageTextBox.Name = "MileageTextBox"
        Me.MileageTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MileageTextBox.TabIndex = 9
        '
        'MilesDrTextBox
        '
        Me.MilesDrTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesDrTextBox.Location = New System.Drawing.Point(571, 33)
        Me.MilesDrTextBox.Name = "MilesDrTextBox"
        Me.MilesDrTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MilesDrTextBox.TabIndex = 8
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Location = New System.Drawing.Point(6, 32)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(190, 24)
        Me.AAACheckBox.TabIndex = 13
        Me.AAACheckBox.Text = "AAA Member Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Location = New System.Drawing.Point(6, 55)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(193, 24)
        Me.SeniorCheckBox.TabIndex = 14
        Me.SeniorCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(7, 27)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(63, 24)
        Me.MilesRadioButton.TabIndex = 15
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Location = New System.Drawing.Point(6, 50)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(101, 24)
        Me.KilometersRadioButton.TabIndex = 16
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(65, 389)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(95, 41)
        Me.CalculateButton.TabIndex = 17
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(222, 389)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(95, 41)
        Me.ClearButton.TabIndex = 18
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(380, 389)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(95, 41)
        Me.SummaryButton.TabIndex = 20
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(555, 389)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 41)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(6, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(124, 20)
        Me.NameLabel.TabIndex = 21
        Me.NameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(6, 59)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(68, 20)
        Me.AddressLabel.TabIndex = 22
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.Location = New System.Drawing.Point(6, 88)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 24
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateLabel.Location = New System.Drawing.Point(6, 114)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 23
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipLabel.Location = New System.Drawing.Point(6, 140)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipLabel.TabIndex = 28
        Me.ZipLabel.Text = "Zip Code"
        '
        'BeginningLabel
        '
        Me.BeginningLabel.AutoSize = True
        Me.BeginningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginningLabel.Location = New System.Drawing.Point(6, 167)
        Me.BeginningLabel.Name = "BeginningLabel"
        Me.BeginningLabel.Size = New System.Drawing.Size(219, 20)
        Me.BeginningLabel.TabIndex = 27
        Me.BeginningLabel.Text = "Beginning Odometer Reading"
        '
        'EndingLabel
        '
        Me.EndingLabel.AutoSize = True
        Me.EndingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndingLabel.Location = New System.Drawing.Point(6, 193)
        Me.EndingLabel.Name = "EndingLabel"
        Me.EndingLabel.Size = New System.Drawing.Size(198, 20)
        Me.EndingLabel.TabIndex = 26
        Me.EndingLabel.Text = "Ending Odometer Reading"
        '
        'NumberDaysLabel
        '
        Me.NumberDaysLabel.AutoSize = True
        Me.NumberDaysLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberDaysLabel.Location = New System.Drawing.Point(6, 219)
        Me.NumberDaysLabel.Name = "NumberDaysLabel"
        Me.NumberDaysLabel.Size = New System.Drawing.Size(126, 20)
        Me.NumberDaysLabel.TabIndex = 25
        Me.NumberDaysLabel.Text = "Number Of Days"
        '
        'DistanceLabel
        '
        Me.DistanceLabel.AutoSize = True
        Me.DistanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceLabel.Location = New System.Drawing.Point(376, 33)
        Me.DistanceLabel.Name = "DistanceLabel"
        Me.DistanceLabel.Size = New System.Drawing.Size(179, 20)
        Me.DistanceLabel.TabIndex = 33
        Me.DistanceLabel.Text = "Distance Driven In Miles"
        '
        'MileageLabel
        '
        Me.MileageLabel.AutoSize = True
        Me.MileageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MileageLabel.Location = New System.Drawing.Point(376, 60)
        Me.MileageLabel.Name = "MileageLabel"
        Me.MileageLabel.Size = New System.Drawing.Size(120, 20)
        Me.MileageLabel.TabIndex = 32
        Me.MileageLabel.Text = "Mileage Charge"
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayLabel.Location = New System.Drawing.Point(376, 86)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(93, 20)
        Me.DayLabel.TabIndex = 31
        Me.DayLabel.Text = "Day Charge"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.Location = New System.Drawing.Point(376, 112)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(118, 20)
        Me.DiscountLabel.TabIndex = 30
        Me.DiscountLabel.Text = "Minus Discount"
        '
        'OweLabel
        '
        Me.OweLabel.AutoSize = True
        Me.OweLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OweLabel.Location = New System.Drawing.Point(376, 140)
        Me.OweLabel.Name = "OweLabel"
        Me.OweLabel.Size = New System.Drawing.Size(74, 20)
        Me.OweLabel.TabIndex = 29
        Me.OweLabel.Text = "You Owe"
        '
        'MilesGroupBox
        '
        Me.MilesGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.MilesGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MilesGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MilesGroupBox.Location = New System.Drawing.Point(10, 273)
        Me.MilesGroupBox.Name = "MilesGroupBox"
        Me.MilesGroupBox.Size = New System.Drawing.Size(297, 79)
        Me.MilesGroupBox.TabIndex = 34
        Me.MilesGroupBox.TabStop = False
        Me.MilesGroupBox.Text = "Is Odometer In Miles Or Kilometers?"
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(380, 273)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(264, 83)
        Me.DiscountsGroupBox.TabIndex = 35
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Enter Any Discounts"
        '
        'CarRentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 450)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.MilesGroupBox)
        Me.Controls.Add(Me.DistanceLabel)
        Me.Controls.Add(Me.MileageLabel)
        Me.Controls.Add(Me.DayLabel)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.OweLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.BeginningLabel)
        Me.Controls.Add(Me.EndingLabel)
        Me.Controls.Add(Me.NumberDaysLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.OweTextBox)
        Me.Controls.Add(Me.MinusTextBox)
        Me.Controls.Add(Me.DayTextBox)
        Me.Controls.Add(Me.MileageTextBox)
        Me.Controls.Add(Me.MilesDrTextBox)
        Me.Controls.Add(Me.DaysTextBox)
        Me.Controls.Add(Me.EndOdTextBox)
        Me.Controls.Add(Me.BegOdTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Car Rental Service"
        Me.MilesGroupBox.ResumeLayout(False)
        Me.MilesGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents DaysTextBox As TextBox
    Friend WithEvents EndOdTextBox As TextBox
    Friend WithEvents BegOdTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents OweTextBox As TextBox
    Friend WithEvents MinusTextBox As TextBox
    Friend WithEvents DayTextBox As TextBox
    Friend WithEvents MileageTextBox As TextBox
    Friend WithEvents MilesDrTextBox As TextBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents BeginningLabel As Label
    Friend WithEvents EndingLabel As Label
    Friend WithEvents NumberDaysLabel As Label
    Friend WithEvents DistanceLabel As Label
    Friend WithEvents MileageLabel As Label
    Friend WithEvents DayLabel As Label
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents OweLabel As Label
    Friend WithEvents MilesGroupBox As GroupBox
    Friend WithEvents DiscountsGroupBox As GroupBox
End Class
