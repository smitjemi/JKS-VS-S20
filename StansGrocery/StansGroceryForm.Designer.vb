<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookUpItemTextBox = New System.Windows.Forms.TextBox()
        Me.SelectedItemBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.LookUpLabel = New System.Windows.Forms.Label()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeftGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip.SuspendLayout()
        Me.LeftGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(625, 24)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileTopMenuItem.Text = "&File"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpTopMenuItem.Text = "Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutTopMenuItem.Text = "About"
        '
        'LookUpItemTextBox
        '
        Me.LookUpItemTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.LookUpItemTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.LookUpItemTextBox.Location = New System.Drawing.Point(82, 46)
        Me.LookUpItemTextBox.Name = "LookUpItemTextBox"
        Me.LookUpItemTextBox.Size = New System.Drawing.Size(411, 20)
        Me.LookUpItemTextBox.TabIndex = 1
        '
        'SelectedItemBox
        '
        Me.SelectedItemBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SelectedItemBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SelectedItemBox.FormattingEnabled = True
        Me.SelectedItemBox.Location = New System.Drawing.Point(82, 72)
        Me.SelectedItemBox.Name = "SelectedItemBox"
        Me.SelectedItemBox.Size = New System.Drawing.Size(218, 21)
        Me.SelectedItemBox.TabIndex = 2
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(306, 72)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(291, 251)
        Me.DisplayListBox.TabIndex = 3
        '
        'LookUpLabel
        '
        Me.LookUpLabel.AutoSize = True
        Me.LookUpLabel.Location = New System.Drawing.Point(5, 46)
        Me.LookUpLabel.Name = "LookUpLabel"
        Me.LookUpLabel.Size = New System.Drawing.Size(71, 13)
        Me.LookUpLabel.TabIndex = 4
        Me.LookUpLabel.Text = "Look Up Item"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(16, 72)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(60, 13)
        Me.SelectLabel.TabIndex = 5
        Me.SelectLabel.Text = "Select Item"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(499, 46)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(98, 20)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeftGroupBox
        '
        Me.LeftGroupBox.Controls.Add(Me.DisplayLabel)
        Me.LeftGroupBox.Location = New System.Drawing.Point(82, 99)
        Me.LeftGroupBox.Name = "LeftGroupBox"
        Me.LeftGroupBox.Size = New System.Drawing.Size(218, 224)
        Me.LeftGroupBox.TabIndex = 7
        Me.LeftGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(3, 16)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(209, 205)
        Me.DisplayLabel.TabIndex = 0
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 347)
        Me.Controls.Add(Me.LeftGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.LookUpLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SelectedItemBox)
        Me.Controls.Add(Me.LookUpItemTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGroceryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Stan's Grocery"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.LeftGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents LookUpItemTextBox As TextBox
    Friend WithEvents SelectedItemBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents LookUpLabel As Label
    Friend WithEvents SelectLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents LeftGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
