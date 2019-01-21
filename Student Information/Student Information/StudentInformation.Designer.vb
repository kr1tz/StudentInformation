<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHighSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NumberUnitLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UnitTextBox = New System.Windows.Forms.TextBox()
        Me.ClassGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorRadioButton = New System.Windows.Forms.RadioButton()
        Me.JuniorRadioButton = New System.Windows.Forms.RadioButton()
        Me.SophomoreRadioButton = New System.Windows.Forms.RadioButton()
        Me.FreshmanRadioButton = New System.Windows.Forms.RadioButton()
        Me.HighSchoolComboBox = New System.Windows.Forms.ComboBox()
        Me.HighSchoolLabel = New System.Windows.Forms.Label()
        Me.MajorLabel = New System.Windows.Forms.Label()
        Me.MajorListBox = New System.Windows.Forms.ListBox()
        Me.DeansCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentOne = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentTwo = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip.SuspendLayout()
        Me.ClassGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSchoolToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSchoolToolStripMenuItem
        '
        Me.PrintSchoolToolStripMenuItem.Name = "PrintSchoolToolStripMenuItem"
        Me.PrintSchoolToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PrintSchoolToolStripMenuItem.Text = "Print &School"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddHighSchoolToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddHighSchoolToolStripMenuItem
        '
        Me.AddHighSchoolToolStripMenuItem.Name = "AddHighSchoolToolStripMenuItem"
        Me.AddHighSchoolToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddHighSchoolToolStripMenuItem.Text = "&Add High School"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(97, 57)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(78, 13)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Student &Name:"
        '
        'NumberUnitLabel
        '
        Me.NumberUnitLabel.AutoSize = True
        Me.NumberUnitLabel.Location = New System.Drawing.Point(36, 91)
        Me.NumberUnitLabel.Name = "NumberUnitLabel"
        Me.NumberUnitLabel.Size = New System.Drawing.Size(139, 13)
        Me.NumberUnitLabel.TabIndex = 2
        Me.NumberUnitLabel.Text = "Number of &Units Completed:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(181, 50)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'UnitTextBox
        '
        Me.UnitTextBox.Location = New System.Drawing.Point(181, 84)
        Me.UnitTextBox.Name = "UnitTextBox"
        Me.UnitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnitTextBox.TabIndex = 4
        '
        'ClassGroupBox
        '
        Me.ClassGroupBox.Controls.Add(Me.SeniorRadioButton)
        Me.ClassGroupBox.Controls.Add(Me.JuniorRadioButton)
        Me.ClassGroupBox.Controls.Add(Me.SophomoreRadioButton)
        Me.ClassGroupBox.Controls.Add(Me.FreshmanRadioButton)
        Me.ClassGroupBox.Location = New System.Drawing.Point(39, 163)
        Me.ClassGroupBox.Name = "ClassGroupBox"
        Me.ClassGroupBox.Size = New System.Drawing.Size(136, 115)
        Me.ClassGroupBox.TabIndex = 5
        Me.ClassGroupBox.TabStop = False
        Me.ClassGroupBox.Text = "Class"
        '
        'SeniorRadioButton
        '
        Me.SeniorRadioButton.AutoSize = True
        Me.SeniorRadioButton.Location = New System.Drawing.Point(7, 88)
        Me.SeniorRadioButton.Name = "SeniorRadioButton"
        Me.SeniorRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.SeniorRadioButton.TabIndex = 3
        Me.SeniorRadioButton.TabStop = True
        Me.SeniorRadioButton.Text = "Senior"
        Me.SeniorRadioButton.UseVisualStyleBackColor = True
        '
        'JuniorRadioButton
        '
        Me.JuniorRadioButton.AutoSize = True
        Me.JuniorRadioButton.Location = New System.Drawing.Point(7, 65)
        Me.JuniorRadioButton.Name = "JuniorRadioButton"
        Me.JuniorRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.JuniorRadioButton.TabIndex = 2
        Me.JuniorRadioButton.TabStop = True
        Me.JuniorRadioButton.Text = "Junior"
        Me.JuniorRadioButton.UseVisualStyleBackColor = True
        '
        'SophomoreRadioButton
        '
        Me.SophomoreRadioButton.AutoSize = True
        Me.SophomoreRadioButton.Location = New System.Drawing.Point(7, 42)
        Me.SophomoreRadioButton.Name = "SophomoreRadioButton"
        Me.SophomoreRadioButton.Size = New System.Drawing.Size(79, 17)
        Me.SophomoreRadioButton.TabIndex = 1
        Me.SophomoreRadioButton.TabStop = True
        Me.SophomoreRadioButton.Text = "Sophomore"
        Me.SophomoreRadioButton.UseVisualStyleBackColor = True
        '
        'FreshmanRadioButton
        '
        Me.FreshmanRadioButton.AutoSize = True
        Me.FreshmanRadioButton.Location = New System.Drawing.Point(7, 19)
        Me.FreshmanRadioButton.Name = "FreshmanRadioButton"
        Me.FreshmanRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.FreshmanRadioButton.TabIndex = 0
        Me.FreshmanRadioButton.TabStop = True
        Me.FreshmanRadioButton.Text = "Freshman"
        Me.FreshmanRadioButton.UseVisualStyleBackColor = True
        '
        'HighSchoolComboBox
        '
        Me.HighSchoolComboBox.FormattingEnabled = True
        Me.HighSchoolComboBox.Items.AddRange(New Object() {"Franklin", "Highland", "Midtown", "West Highland"})
        Me.HighSchoolComboBox.Location = New System.Drawing.Point(539, 178)
        Me.HighSchoolComboBox.Name = "HighSchoolComboBox"
        Me.HighSchoolComboBox.Size = New System.Drawing.Size(121, 21)
        Me.HighSchoolComboBox.TabIndex = 6
        '
        'HighSchoolLabel
        '
        Me.HighSchoolLabel.AutoSize = True
        Me.HighSchoolLabel.Location = New System.Drawing.Point(536, 154)
        Me.HighSchoolLabel.Name = "HighSchoolLabel"
        Me.HighSchoolLabel.Size = New System.Drawing.Size(65, 13)
        Me.HighSchoolLabel.TabIndex = 7
        Me.HighSchoolLabel.Text = "HighSchool:"
        '
        'MajorLabel
        '
        Me.MajorLabel.AutoSize = True
        Me.MajorLabel.Location = New System.Drawing.Point(248, 154)
        Me.MajorLabel.Name = "MajorLabel"
        Me.MajorLabel.Size = New System.Drawing.Size(83, 13)
        Me.MajorLabel.TabIndex = 8
        Me.MajorLabel.Text = "Choose a major:"
        '
        'MajorListBox
        '
        Me.MajorListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MajorListBox.FormattingEnabled = True
        Me.MajorListBox.ItemHeight = 18
        Me.MajorListBox.Items.AddRange(New Object() {"Accounting", "Business", "Computer Information Systems", "Marketing"})
        Me.MajorListBox.Location = New System.Drawing.Point(251, 178)
        Me.MajorListBox.Name = "MajorListBox"
        Me.MajorListBox.Size = New System.Drawing.Size(225, 76)
        Me.MajorListBox.TabIndex = 9
        '
        'DeansCheckBox
        '
        Me.DeansCheckBox.AutoSize = True
        Me.DeansCheckBox.Location = New System.Drawing.Point(253, 261)
        Me.DeansCheckBox.Name = "DeansCheckBox"
        Me.DeansCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.DeansCheckBox.TabIndex = 10
        Me.DeansCheckBox.Text = "Dean's List"
        Me.DeansCheckBox.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(253, 348)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(351, 348)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 12
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDocumentOne
        '
        '
        'PrintDocumentTwo
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 387)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DeansCheckBox)
        Me.Controls.Add(Me.MajorListBox)
        Me.Controls.Add(Me.MajorLabel)
        Me.Controls.Add(Me.HighSchoolLabel)
        Me.Controls.Add(Me.HighSchoolComboBox)
        Me.Controls.Add(Me.ClassGroupBox)
        Me.Controls.Add(Me.UnitTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NumberUnitLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "Student Information"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ClassGroupBox.ResumeLayout(False)
        Me.ClassGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHighSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NumberUnitLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SeniorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JuniorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SophomoreRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FreshmanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents HighSchoolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HighSchoolLabel As System.Windows.Forms.Label
    Friend WithEvents MajorLabel As System.Windows.Forms.Label
    Friend WithEvents MajorListBox As System.Windows.Forms.ListBox
    Friend WithEvents DeansCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentOne As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocumentTwo As System.Drawing.Printing.PrintDocument

End Class
