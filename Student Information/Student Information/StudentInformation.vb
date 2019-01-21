Public Class MainForm

    Dim RowInteger As Integer = 0




    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click

        PrintPreviewDialog.Document = PrintDocumentTwo
        PrintPreviewDialog.ShowDialog()

    End Sub


    Private Sub OkButton_Click(sender As System.Object, e As System.EventArgs) Handles OkButton.Click

        NameTextBox.Clear()
        UnitTextBox.Clear()

        FreshmanRadioButton.Checked = False
        SophomoreRadioButton.Checked = False
        JuniorRadioButton.Checked = False
        SeniorRadioButton.Checked = False

        DeansCheckBox.Checked = False
        MajorListBox.ClearSelected()


    End Sub


    Private Sub PrintSchoolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSchoolToolStripMenuItem.Click

        PrintPreviewDialog.Document = PrintDocumentOne
        PrintPreviewDialog.ShowDialog()

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub


    Private Sub AddHighSchoolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddHighSchoolToolStripMenuItem.Click

        Dim SchoolString As String

        SchoolString = InputBox("High School Name: ")
        If Not String.IsNullOrEmpty(SchoolString) Then
            HighSchoolComboBox.Items.Add(SchoolString)
        End If


    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox.ShowDialog()


    End Sub

    Private Sub HighSchoolComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles HighSchoolComboBox.SelectedIndexChanged

        Dim NameString As String

        HighSchoolComboBox.SelectedItem.ToString()
        If HighSchoolComboBox.SelectedItem.ToString().Equals("Other") Then
            NameString = InputBox("High School Name: ")
            HighSchoolComboBox.Items.Add(NameString)

        End If



    End Sub

    Private Sub PrintDocumentOne_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentOne.PrintPage

   

        'Sets up and display heading lines

        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        e.Graphics.DrawString("Student Information", Font, Brushes.Black, 5, 5)

        VerticalPrintLocationSingle += 20
        e.Graphics.DrawString("The list of high" & " schools present are: ", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20


        With HighSchoolComboBox
            Do While RowInteger < .Items.Count
                Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left


                e.Graphics.DrawString(.Items(RowInteger).ToString(), Font, Brushes.Black, HorizontalPrintLocationSingle + 30, VerticalPrintLocationSingle)

                VerticalPrintLocationSingle += 20
                RowInteger += 1



            Loop

            RowInteger = 0

        End With





    End Sub

    Private Sub PrintDocumentTwo_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentTwo.PrintPage

      
        'Second Printer for Selected Radio Buttons


        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left


        e.Graphics.DrawString("Student Information", Font, Brushes.Black, 10, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20

        e.Graphics.DrawString("Name:" & NameTextBox.Text, Font, Brushes.Black, 100, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20

        e.Graphics.DrawString("Unit:" & UnitTextBox.Text, Font, Brushes.Black, 100, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20

        If FreshmanRadioButton.Checked Then
            e.Graphics.DrawString("Status: Freshman", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += 20
        End If

        If SophomoreRadioButton.Checked Then
            e.Graphics.DrawString("Status: Sophomore", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += 20
        End If

        If JuniorRadioButton.Checked Then
            e.Graphics.DrawString("Status: Junior", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += 20
        End If

        If SeniorRadioButton.Checked Then
            e.Graphics.DrawString("Status: Senior", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += 20
        End If

        If DeansCheckBox.Checked Then

            e.Graphics.DrawString("Dean's List: " & DeansCheckBox.Checked.ToString(), Font, Brushes.Black, 100, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += 20

        End If

        e.Graphics.DrawString("Majors In: ", Font, Brushes.Black, 100, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20

        For ListIndexInteger = 0 To MajorListBox.SelectedItems.Count - 1
            e.Graphics.DrawString("-" & MajorListBox.SelectedItems(ListIndexInteger).ToString(), Font, Brushes.Black, HorizontalPrintLocationSingle + 20, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += 20
        Next

        e.Graphics.DrawString("High School: " & HighSchoolComboBox.SelectedItem.ToString(), Font, Brushes.Black, 100, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += 20

    End Sub


    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        NameTextBox.Select()

    End Sub
End Class
