Imports DLoder.ExmDataLoader    'Supports Database Operation
Imports Microsoft.Win32         'Namespace for registry operation
Imports Encoder.FileCrypto      'for ecrypting files




Public Class eXaminer

#Region "<<<<<<<<<<<<<  Decleration  >>>>>>>>>>"
    Dim FileOpen As Boolean = False
    Dim FileOpend As String
    Dim SaveState As Boolean = False
    Dim newFile As Boolean = True
    Dim Question(9) As String
    Dim QuestionType As Integer = 1
    Dim OptionNo As Integer = 5
    Dim QuestionNo As Integer
    Dim CurrentQuestion As Integer
    Dim ResentDocNo As Integer
#End Region

#Region "       Main Menu >>>>> File        "
    'new Exam file
    Private Sub NewMenuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMenuFile.Click
        'Check File is oppend
        If FileOpen = True Then
            Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "Save Questions", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    Me.UseWaitCursor = True
                    StatusLabel.Text = "Saving Questions..."
                    SaveQuestions(FileOpend)
                    DeleteQstTable()
                    'Create new Question Table
                    Dim EDLoarer As New DLoder.ExmDataLoader
                    EDLoarer.CreateQuestionTable()
                    'new Questions
                    CurrentQuestion = 1
                    QuestionNo = 1
                    newFile = True
                    OpenReset()
                    'Enable dilable
                    SaveState = False
                    StatusLabel.Text = "Ready.."
                    Me.Text = "eXaminer [ new examfile ]"
                    Me.UseWaitCursor = False
                Case Windows.Forms.DialogResult.No
                    Me.UseWaitCursor = True
                    StatusLabel.Text = "Clearing temporary datas.."
                    'dropQuestions 
                    DeleteQstTable()
                    'Create new Question Table
                    Dim EDLoarer As New DLoder.ExmDataLoader
                    EDLoarer.CreateQuestionTable()
                    'New Questions  
                    CurrentQuestion = 1
                    QuestionNo = 1
                    newFile = True
                    'Enable dilable
                    OpenReset()
                    SaveState = False
                    StatusLabel.Text = "Ready.."
                    Me.Text = "eXaminer [ new examfile ]"
                    Me.UseWaitCursor = False
                Case Windows.Forms.DialogResult.Cancel
                    'donothing
            End Select
            Question_no.Text = QuestionNo
        Else
            Me.UseWaitCursor = True
            'dropQuestions
            DeleteQstTable()
            'New Questions
            'Create new Question Table
            Dim EDLoarer As New DLoder.ExmDataLoader
            EDLoarer.CreateQuestionTable()
            CurrentQuestion = 1
            QuestionNo = 1
            FileOpen = True
            newFile = True
            SaveState = False
            'Enable dilable 
            OpenReset()
            'Clear Questionpannel
            ClearPanel()
            StatusLabel.Text = "Ready.."
            Me.Text = "eXaminer [ new examfile ]"
            Me.UseWaitCursor = True
        End If
        Question_no.Text = QuestionNo.ToString
        CurrQst.Text = CurrentQuestion
        Me.UseWaitCursor = False
    End Sub
    'Open
    Private Sub OpenMenuFileMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuFile.Click
        StatusLabel.Text = "opening.."
        Dim OpenFileDig As New OpenFileDialog
        OpenFileDig.Filter = "Exam files|*.exm"
        OpenFileDig.FilterIndex = 1
        OpenFileDig.RestoreDirectory = True
        If OpenFileDig.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '''''
            'Check File oppend
            If FileOpen = True And SaveState = False Then
                Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "exam Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        Me.UseWaitCursor = True
                        StatusLabel.Text = "Saving Questions.."
                        'save questions
                        SaveQuestions(FileOpend)
                        'DeleteQst
                        DeleteQstTable()
                        'Load new  Questions
                        'Create new Question Table
                        Dim EDLoarer As New DLoder.ExmDataLoader
                        EDLoarer.CreateQuestionTable()
                        FileOpend = OpenFileDig.FileName
                        If LoadQuestions(OpenFileDig.FileName) = True Then
                            'Enable dilable 
                            ClearPanel()
                            OpenReset()
                            newFile = False
                            Me.Text = "eXaminer  " & "[ " & OpenFileDig.FileName & " ]"
                            'Adding into ResentDocument List
                            AddResentDoc(FileOpend)
                        End If
                        Me.UseWaitCursor = False
                    Case Windows.Forms.DialogResult.No
                        Me.UseWaitCursor = True
                        StatusLabel.Text = "Clearing temporary datas.."
                        'Drop Questions
                        DeleteQstTable()
                        'Create new Question Table
                        Dim EDLoarer As New DLoder.ExmDataLoader
                        EDLoarer.CreateQuestionTable()
                        'Load new  Questions
                        FileOpend = OpenFileDig.FileName
                        If LoadQuestions(OpenFileDig.FileName) = True Then
                            'Enable dilable 
                            ClearPanel()
                            OpenReset()
                            newFile = False
                            Me.Text = "eXaminer  " & "[ " & OpenFileDig.FileName & " ]"
                            'Adding into ResentDocument List
                            AddResentDoc(FileOpend)
                        End If
                        Me.UseWaitCursor = False
                    Case Windows.Forms.DialogResult.Cancel
                        'donothing
                End Select
            Else
                Me.UseWaitCursor = True
                'Drop Questions
                DeleteQstTable()
                'Create new Question Table
                Dim EDLoarer As New DLoder.ExmDataLoader
                EDLoarer.CreateQuestionTable()
                'Load new  Questions
                FileOpend = OpenFileDig.FileName
                If LoadQuestions(OpenFileDig.FileName) = True Then
                    'Enable dilable 
                    ClearPanel()
                    OpenReset()
                    Me.Text = "eXaminer  " & "[ " & OpenFileDig.FileName & " ]"
                    'Adding into resent doc
                    AddResentDoc(OpenFileDig.FileName)
                End If
                Me.UseWaitCursor = False
                'Adding into ResentDocument List
                AddResentDoc(FileOpend)
            End If
        Else
            'Questions not oppend
        End If
        StatusLabel.Text = "Ready.."
        OpenFileDig.Dispose()
        OpenFileDig = Nothing
    End Sub
    'Save 
    Private Sub SaveMenuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMenuFile.Click
        If newFile = True Then
            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.Filter = "Exam files|*.exm"
            SaveFileDialog.FilterIndex = 1
            SaveFileDialog.RestoreDirectory = True
            If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                StatusLabel.Text = "Saving File.."
                'Saving File
                FileOpend = SaveFileDialog.FileName
                SaveQuestions(SaveFileDialog.FileName)
                StatusLabel.Text = "Ready.."
                SaveState = True
                Me.Text = "eXaminer  " & "[ " & SaveFileDialog.FileName & " ]"
                'Adding into ResentDocument List
                AddResentDoc(FileOpend)
            End If
            StatusLabel.Text = "Ready.."
            SaveFileDialog.Dispose()
            SaveFileDialog = Nothing
            newFile = False
        Else
            StatusLabel.Text = "Saving File.."
            'saveQuestions
            SaveQuestions(FileOpend)
            StatusLabel.Text = "Ready.."
            newFile = False
        End If
    End Sub
    'Save as 
    Private Sub SaveAsMenuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsMenuFile.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.Filter = "Exam files|*.exm"
        SaveFileDialog.FilterIndex = 1
        SaveFileDialog.RestoreDirectory = True
        If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StatusLabel.Text = "Saving File.."
            'save DataBase File to temp xml 
            SaveQuestions(SaveFileDialog.FileName)
            Me.Text = "eXaminer  " & "[ " & SaveFileDialog.FileName & " ]"
            'Adding into ResentDocument List
            AddResentDoc(FileOpend)
            StatusLabel.Text = "Ready.."
        End If
        SaveFileDialog.Dispose()
        SaveFileDialog = Nothing
    End Sub
    'Close
    Private Sub CloseMenuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseMenuFile.Click
        If SaveState = False And FileOpen = True Then
            Select Case MessageBox.Show("Save Questions Before Cloasing ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.OK
                    StatusLabel.Text = "Saving Questions.."
                    'Save File 
                    SaveQuestions(FileOpend)
                    'Close Diable
                    CloseReset()
                    'Drop Table Close Form 
                    DeleteQstTable()
                    StatusLabel.Text = "Ready.."
                Case Windows.Forms.DialogResult.No
                    StatusLabel.Text = "Clearing Temporary datas.."
                    CloseReset()
                    'Drop Table Close Form 
                    DeleteQstTable()
                    StatusLabel.Text = "Ready.."
                Case Windows.Forms.DialogResult.Cancel
                    'do nothing
            End Select
        ElseIf SaveState = True Then
            StatusLabel.Text = "Clearing Temporary datas.."
            CloseReset()
            'Drop Table Close Form 
            DeleteQstTable()
            StatusLabel.Text = "Ready.."
        End If

    End Sub
    'Exit
    Private Sub ExitMenuFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenuFile.Click
        TrayIcon.Visible = False
        If SaveState = False Then
            Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "Save Questions", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    StatusLabel.Text = "Saving Questions.."
                    'saving Question
                    SaveQuestions(FileOpend)
                    'Drop Questions 
                    DeleteQstTable()
                    End
                Case Windows.Forms.DialogResult.No
                    StatusLabel.Text = "Clearing temporary datas.."
                    'dropQuestions                              
                    DeleteQstTable()
                    End
                Case Windows.Forms.DialogResult.Cancel
                    'donothing
            End Select
        Else
            DeleteQstTable()
            End
        End If
    End Sub
    'Recent Documents
    'Open File 1
    Private Sub File1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File1ToolStripMenuItem.Click
        FileOpenRec(File1ToolStripMenuItem.Text)
    End Sub
    'Open File 2
    Private Sub File2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File2ToolStripMenuItem.Click
        If FileOpenRec(File2ToolStripMenuItem.Text) = True Then
            AddResentDoc(File2ToolStripMenuItem.Text, 2)
        End If
    End Sub
    'Open File 3
    Private Sub File3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File3ToolStripMenuItem.Click
        If FileOpenRec(File3ToolStripMenuItem.Text) = True Then
            AddResentDoc(File3ToolStripMenuItem.Text, 3)
        End If
    End Sub
    'Open File 4
    Private Sub File4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File4ToolStripMenuItem.Click
        If FileOpenRec(File4ToolStripMenuItem.Text) = True Then
            AddResentDoc(File4ToolStripMenuItem.Text, 4)
        End If
    End Sub
    'Open File 5
    Private Sub File5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles File5ToolStripMenuItem.Click
        If FileOpenRec(File5ToolStripMenuItem.Text) = True Then
            AddResentDoc(File5ToolStripMenuItem.Text, 5)
        End If
    End Sub
    'Clear Resent Documents
    Private Sub ClearAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        RecentMenuFile.Enabled = False
        Try
            'Clearing Registry Values
            Dim Software As RegistryKey = Registry.CurrentUser.OpenSubKey("Software")
            Dim Examiner2007 As RegistryKey = Software.OpenSubKey("Examiner2007")
            Dim ExmEditor As RegistryKey = Examiner2007.OpenSubKey("Exam-Editor", True)
            Dim Count As Integer = CInt(ExmEditor.GetValue("FileIndex"))
            ExmEditor.SetValue("FileIndex", "0")
            ExmEditor.SetValue("File0", "")
            ExmEditor.SetValue("File1", "")
            ExmEditor.SetValue("File2", "")
            ExmEditor.SetValue("File3", "")
            ExmEditor.SetValue("File4", "")
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "       Main Menu >>>>>>>> Edit        "
    'Update
    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        'Update Database
        If Not QuestionRText.Text.Length = 0 Then
            StatusLabel.Text = "Updating..."
            'Updating
            Dim EDLoader As New DLoder.ExmDataLoader

            Select Case QuestionType
                Case 1
                    If ARB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "A", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf BRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "B", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf CRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "C", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf DRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "D", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf ERB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "E", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
                Case 2
                    EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, ACB.Checked.ToString, BCB.Checked.ToString, CCB.Checked.ToString, DCB.Checked.ToString, ECB.Checked.ToString, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 3
                    EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", FIB1.Text, FIB2.Text, FIB3.Text, FIB4.Text, FIB5.Text, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 4 Or 5
                    If TRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "1", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    Else
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "2", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
            End Select
        Else
            MessageBox.Show("Enter Your Question in your Question Box", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            QuestionRText.Focus()
        End If
        StatusLabel.Text = "Ready..."
    End Sub
    'Delete
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        StatusLabel.Text = "Deleting Question..."
        'Deletequestions from database
        ButtonOK.Enabled = False
        Delete.Enabled = False
        ButtonUpdate.Enabled = False
        Next_1.Enabled = False
        Dim EDLoader As New DLoder.ExmDataLoader
        Me.UseWaitCursor = True
        EDLoader.DeleteQuestion(QuestionNo)
        Me.UseWaitCursor = False
        SaveState = False
        'back button
        ClearPanel()
        CurrentQuestion = CurrentQuestion - 1
        If QuestionNo = CurrentQuestion Then
            DeleteToolStripMenuItem.Enabled = False
            UpdateToolStripMenuItem.Enabled = False
            ButtonOK.Enabled = True
            Delete.Enabled = False
            ButtonUpdate.Enabled = False
            Next_1.Enabled = False
            If QuestionNo = 1 Then
                PreviousQue.Enabled = False
            End If
        Else
            ButtonOK.Enabled = False
            DeleteToolStripMenuItem.Enabled = True
            UpdateToolStripMenuItem.Enabled = True
            Delete.Enabled = True
            ButtonUpdate.Enabled = True
            Next_1.Enabled = True
            AriangeQuestions(QuestionNo)
            If QuestionNo = 1 Then
                PreviousQue.Enabled = False
            Else
                PreviousQue.Enabled = False
            End If
        End If
        Question_no.Text = QuestionNo.ToString
        CurrQst.Text = CurrentQuestion
        StatusLabel.Text = "Ready..."
    End Sub
    'clear
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ClearPanel()
        ARB.Checked = True
    End Sub
#End Region

#Region "       Main Menu >>>>>>> About         "
    ''''''''''''''''''''''''''''''''''''''''''''''''  About   '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub AboutToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutAboutMenu.Click
        AboutScrean_eXaminer.Show()
    End Sub
    Private Sub OnlineHelpMenuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineHelpMenuHelp.Click
        System.Diagnostics.Process.Start("http://www.Google.com")
    End Sub
    Private Sub HelpMenuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMenuAbout.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\Files\Help\index.html")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub IntegrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntegrationToolStripMenuItem.Click
        Integration.Show()
        If Integration.DialogResult = Windows.Forms.DialogResult.OK Then

            Dim RegKey As RegistryKey = Registry.ClassesRoot
            Try
                RegKey.CreateSubKey(".exm")
                'set file property
                RegKey.SetValue("", "exam files")
                RegKey.Close()
                RegKey = Registry.ClassesRoot.CreateSubKey("exam files")
                RegKey.SetValue("", "examiner 2007 Question Files")
                RegKey.Close()
                'set default program to open
                'RegKey.SetValue("", "\"" + Application.ExecutablePath + "\"" + " \"%L\"");

				'RegKey = Registry.ClassesRoot.CreateSubKey("ssb files" + "\\" + "Shell" + "\\" + "Open");
				'RegKey = RegKey.CreateSubKey("Command");
                'RegKey.SetValue("", "\"" + Application.ExecutablePath + "\"" + " \"%L\"");

                '                       "Application.executionpath""%L"

                RegKey = Registry.ClassesRoot.CreateSubKey("exam files" & "\\" & "Shell" + "\\" & "Open")
                RegKey = RegKey.CreateSubKey("Command")
                RegKey.SetValue("", """" & Application.ExecutablePath & """" & """" & "%L" & """")
                RegKey.Close()
                'setting Icon For file
                RegKey = Registry.ClassesRoot.CreateSubKey("exam files" & "\\" & "DefaultIcon")
                RegKey.SetValue("", Application.StartupPath & "\\exam.ico")

            Catch ex As Exception
                MessageBox.Show("Error in creating registry entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                RegKey.Close()
                RegKey.Flush()
            End Try



        End If
    End Sub

#End Region

#Region "<< Back , Clear ,Delete, Enter ,Update ,Next >> " '<------------
    '**********   Next   ***************
    'Back
    Private Sub PreviousQue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousQue.Click
        'data entry
        If Not QuestionNo = 1 Then
            QuestionNo = QuestionNo - 1
            Question_no.Text = QuestionNo.ToString
            ' Clear  panel and increment Question number 
            ClearPanel()
            'Update Question Panel with new values
            AriangeQuestions(QuestionNo)
            DeleteToolStripMenuItem.Enabled = True
            UpdateToolStripMenuItem.Enabled = True
            Next_1.Enabled = True
            Delete.Enabled = True
            ButtonUpdate.Enabled = True
            ButtonOK.Enabled = False
        Else
        End If
        If QuestionNo = 1 Then
            PreviousQue.Enabled = False
        End If
        CurrQst.Text = CurrentQuestion
    End Sub
    'Delete                                 
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        StatusLabel.Text = "Deleting Question..."
        'Deletequestions from database
        ButtonOK.Enabled = False
        Delete.Enabled = False
        ButtonUpdate.Enabled = False
        Next_1.Enabled = False
        Dim EDLoader As New DLoder.ExmDataLoader
        Me.UseWaitCursor = True
        EDLoader.DeleteQuestion(QuestionNo)
        Me.UseWaitCursor = False
        SaveState = False
        'back button
        ClearPanel()
        CurrentQuestion = CurrentQuestion - 1
        If QuestionNo = CurrentQuestion Then
            ButtonOK.Enabled = True
            Delete.Enabled = False
            ButtonUpdate.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
            UpdateToolStripMenuItem.Enabled = False
            Next_1.Enabled = False
            If QuestionNo = 1 Then
                PreviousQue.Enabled = False
            End If
        Else
            DeleteToolStripMenuItem.Enabled = True
            UpdateToolStripMenuItem.Enabled = True
            ButtonOK.Enabled = False
            Delete.Enabled = True
            ButtonUpdate.Enabled = True
            Next_1.Enabled = True
            AriangeQuestions(QuestionNo)
            If QuestionNo = 1 Then
                PreviousQue.Enabled = False
            Else
                PreviousQue.Enabled = False
            End If
        End If
        Question_no.Text = QuestionNo.ToString
        CurrQst.Text = CurrentQuestion
        StatusLabel.Text = "Ready..."
    End Sub
    'clear
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        ClearPanel()
        ARB.Checked = True
    End Sub
    'Enter Question                          
    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        'Insetr questions to data base
        If ValidateQuestion() = False Then
            StatusLabel.Text = "Enter Your Question ..."
            MessageBox.Show("Please fill your questions completely....", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StatusLabel.Text = "Ready..."
        Else
            StatusLabel.Text = "Updating..."
            PreviousQue.Enabled = True
            Next_1.Enabled = False
            Delete.Enabled = False
            ButtonUpdate.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
            UpdateToolStripMenuItem.Enabled = False
            'Insetr questions to data base
            Dim EDLoader As New DLoder.ExmDataLoader
            Select Case QuestionType
                Case 1
                    If ARB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "A", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf BRB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "B", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf CRB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "C", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf DRB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "D", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf ERB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "E", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
                Case 2
                    EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, ACB.Checked.ToString, BCB.Checked.ToString, CCB.Checked.ToString, DCB.Checked.ToString, ECB.Checked.ToString, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 3
                    EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", FIB1.Text, FIB2.Text, FIB3.Text, FIB4.Text, FIB5.Text, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 4 Or 5
                    If TRB.Checked = True Then
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "1", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    Else
                        EDLoader.InsertQuestions(CurrentQuestion, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "2", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
            End Select
            SaveState = False
            ClearPanel()
            ARB.Checked = True
            QuestionNo = QuestionNo + 1
            CurrentQuestion = CurrentQuestion + 1
            Question_no.Text = QuestionNo.ToString
            CurrQst.Text = CurrentQuestion
            StatusLabel.Text = "Ready..."
        End If
    End Sub
    'Update                                 
    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdate.Click
        'Update Database
        If Not QuestionRText.Text.Length = 0 Then
            StatusLabel.Text = "Updating..."
            'Updating
            Dim EDLoader As New DLoder.ExmDataLoader

            Select Case QuestionType
                Case 1
                    If ARB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "A", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf BRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "B", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf CRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "C", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf DRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "D", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    ElseIf ERB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, "E", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
                Case 2
                    EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, ATB.Text, BTB.Text, CTB.Text, DTB.Text, ETB.Text, ACB.Checked.ToString, BCB.Checked.ToString, CCB.Checked.ToString, DCB.Checked.ToString, ECB.Checked.ToString, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 3
                    EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", FIB1.Text, FIB2.Text, FIB3.Text, FIB4.Text, FIB5.Text, OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                Case 4 Or 5
                    If TRB.Checked = True Then
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "1", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    Else
                        EDLoader.UpdateQuestions(QuestionNo, QuestionRText.Text, "Nill", "Nill", "Nill", "Nill", "Nill", "2", "Nill", "Nill", "Nill", "Nill", OptionNo, QuestionType, CInt(CAns.Text), CInt(WAns.Text), CInt(TimeAlloc.Text))
                    End If
            End Select
        Else
            MessageBox.Show("Enter Your Question in your Question Box", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            QuestionRText.Focus()
        End If
        StatusLabel.Text = "Ready..."
    End Sub
    'Next Question
    Private Sub Next_Ques_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_1.Click
        ClearPanel()
        'Update Question Panel with new values         
        PreviousQue.Enabled = True
        QuestionNo = QuestionNo + 1
        Question_no.Text = QuestionNo
        If CurrentQuestion = QuestionNo Then
            ClearPanel()
            Next_1.Enabled = False
            ButtonUpdate.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
            UpdateToolStripMenuItem.Enabled = False
            ButtonOK.Enabled = True
            Delete.Enabled = False
        Else
            AriangeQuestions(QuestionNo)
        End If
        CurrQst.Text = CurrentQuestion
        SaveState = False
        StatusLabel.Text = "Ready..."
    End Sub
    'Main Panel >>>>>>>> Fill in the Blanks
    Private Sub Blank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blank.Click
        QuestionRText.Text = QuestionRText.Text & " ______ "
    End Sub


#End Region

#Region "Property panel >>>>>>>> Question panel"

    'Multiple Choice Single Answer
    Private Sub MCSA_RB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCSA_RB.CheckedChanged
        QuestionType = 1
        SetQuestionPanel(QuestionType, OptionNo)
        If CurrentQuestion > 1 Then
            PreviousQue.Enabled = True
        End If
        Choice_no.Enabled = True
    End Sub
    'Multiple Choice Multiple Answer
    Private Sub MCMA_RB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCMA_RB.CheckedChanged
        QuestionType = 2
        SetQuestionPanel(QuestionType, OptionNo)
        If CurrentQuestion > 1 Then
            PreviousQue.Enabled = True
        End If
        Choice_no.Enabled = True
    End Sub
    'Fill in the Blanks 
    Private Sub FinB_RB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinB_RB.CheckedChanged
        QuestionType = 3
        SetQuestionPanel(QuestionType, OptionNo)
        If CurrentQuestion > 1 Then
            PreviousQue.Enabled = True
        End If
        Choice_no.Enabled = True
    End Sub
    'True or False
    Private Sub TorF_RB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TorF_RB.CheckedChanged
        QuestionType = 4
        SetQuestionPanel(QuestionType, OptionNo)
        If CurrentQuestion > 1 Then
            PreviousQue.Enabled = True
        End If

    End Sub
    'Yes or No
    Private Sub YorN_RB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YorN_RB.CheckedChanged
        Choice_no.Enabled = False
        QuestionType = 5
        SetQuestionPanel(QuestionType, OptionNo)
        If CurrentQuestion > 1 Then
            PreviousQue.Enabled = True
        End If
    End Sub


    Private Sub CAns_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CAns.Validated
        If CAns.Text = "" Then
            ErrorProvider.SetError(CAns, "Enter value")
            CAns.Focus()
        Else
            ErrorProvider.Dispose()
            WAns.Focus()
        End If
    End Sub

    Private Sub WAns_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles WAns.Validating
        If WAns.Text = "" Then
            ErrorProvider.SetError(WAns, "Enter value")
            TimeAlloc.Focus()
            WAns.Focus()
        Else
            ErrorProvider.Dispose()
            Choice.Focus()
        End If
    End Sub


    Private Sub TimeAlloc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimeAlloc.Validated
        If TimeAlloc.Text = "" Then
            ErrorProvider.SetError(TimeAlloc, "Enter value")
            TimeAlloc.Focus()
        Else
            ErrorProvider.Dispose()
        End If
    End Sub


#End Region

#Region "Property panel >>>>>>>> Control Panel"


    Private Sub PanelBack_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelBack.Click
        Static IntContorlCount As Integer
        IntContorlCount = IntContorlCount - 1
        PanelBack.Enabled = False
        PanelNext.Enabled = True
        StartPanel.Visible = False
    End Sub

    Private Sub PanelNext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelNext.Click
        Static IntContorlCount As Integer = 1
        IntContorlCount = IntContorlCount + 1
        PanelBack.Enabled = True
        PanelNext.Enabled = False
        StartPanel.Visible = True
    End Sub

#End Region

#Region "Property panel >>>>>>>> Options Panel"


    Private Sub Choice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Choice.SelectedIndexChanged
        'MessageBox.Show(Choice.Text)
        Select Case Choice.Text
            Case 2
                OptionNo = 2
                SetQuestionPanel(QuestionType, OptionNo)
            Case 3
                OptionNo = 3
                SetQuestionPanel(QuestionType, OptionNo)
            Case 4
                OptionNo = 4
                SetQuestionPanel(QuestionType, OptionNo)
            Case 5
                OptionNo = 5
                SetQuestionPanel(QuestionType, OptionNo)
        End Select
    End Sub

#End Region

#Region "<<<<<<<<<<<   Tray Icon   >>>>>>>>>>>>"

    Private Sub TrayExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayExit.Click
        TrayIcon.Visible = False
        If SaveState = False And FileOpen = True Then
            Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "Save Questions", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    StatusLabel.Text = "Saving Questions.."
                    'saving Question
                    SaveQuestions(FileOpend)
                    'Drop Questions 
                    StatusLabel.Text = "Clearing temporary datas.."
                    DeleteQstTable()
                    End
                Case Windows.Forms.DialogResult.No
                    StatusLabel.Text = "Clearing temporary datas.."
                    'dropQuestions                              
                    DeleteQstTable()
                    End
                Case Windows.Forms.DialogResult.Cancel
                    'donothing
            End Select
        Else
            DeleteQstTable()
            End
        End If
        TrayIcon.Visible = True
    End Sub

    Private Sub TrayAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayAbout.Click
        Me.Enabled = False
        AboutScrean_eXaminer.Show()
    End Sub

    Private Sub TrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
            TrayShow.Text = "Show"
            Me.Visible = False
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            TrayShow.Text = "Hide"
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Normal Then
            TrayShow.Text = "Show"
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
        End If
    End Sub

    Private Sub TrayShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayShow.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
            TrayShow.Text = "Show"
            Me.Visible = False
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            TrayShow.Text = "Hide"
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Normal Then
            TrayShow.Text = "Show"
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
        End If
    End Sub

#End Region

#Region "<<<<<<<<<<<< form >>>>>>>>>>>>>>"
    Private Sub eXaminer_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        TrayIcon.Visible = False
        If SaveState = False And FileOpen = True Then
            Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "Save Questions", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    Me.UseWaitCursor = True
                    StatusLabel.Text = "Saving Questions.."
                    'saving Question
                    SaveQuestions(FileOpend)
                    'Drop Questions 
                    StatusLabel.Text = "Clearing temporary datas.."
                    DeleteQstTable()
                    e.Cancel = False
                    End
                Case Windows.Forms.DialogResult.No
                    Me.UseWaitCursor = True
                    StatusLabel.Text = "Clearing temporary datas.."
                    'dropQuestions                              
                    DeleteQstTable()
                    End
                Case Windows.Forms.DialogResult.Cancel
                    'donothing
                    e.Cancel = True
                    StatusLabel.Text = "Rady.."
                    TrayIcon.Visible = True
            End Select
        Else
            StatusLabel.Text = "Clearing temporary datas.."
            DeleteQstTable()
            End
        End If
        StatusLabel.Text = "Rady.."
        TrayIcon.Visible = True
    End Sub

    Private Sub eXaminer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case IsCamandArgs()
            Case True
                Me.UseWaitCursor = True
                'Drop Questions
                DeleteQstTable()
                'Create new Question Table
                Dim EDLoarer As New DLoder.ExmDataLoader
                EDLoarer.CreateQuestionTable()
                'Load new  Questions
                FileOpend = My.Application.CommandLineArgs(0)
                If LoadQuestions(FileOpend) = True Then
                    'Enable dilable 
                    OpenReset()
                    Me.Text = "eXaminer  " & "[ " & FileOpend & " ]"
                End If
                Me.UseWaitCursor = False
                FileOpen = True
                SaveState = True
                ArrangeResentDoc()
            Case False
                'Arrange resent documents
                ArrangeResentDoc()
        End Select
    End Sub
#End Region

#Region "<<<<<<<<<<< Functions and Sub >>>>>>>>>>>>> "

    Private Function LoadQuestions(ByVal FileName As String) As Boolean
        'loadQuestion into DataBase 
        If IO.File.Exists(FileName) Then
            Try
                'Dicrypt File
                Dim ENC As New Encoder.FileCrypto
                ENC.FileDecript(FileName, My.Application.Info.DirectoryPath & "\TempDataFile.xml", 2)
                Dim DSet As New Data.DataSet
                DSet.ReadXml(My.Application.Info.DirectoryPath & "\TempDataFile.xml")
                'Create Questiontable
                Dim EDLoader As New DLoder.ExmDataLoader
                EDLoader.CreateQuestionTable()
                DLoadAdapter.Update(DSet)
                'Delete Temp File
                IO.File.Delete(My.Application.Info.DirectoryPath & "\TempDataFile.xml")
                'Display Questions in Question panel
                'Get lastQuestion no
                QuestionNo = GetLastQuestion() + 1
                CurrentQuestion = QuestionNo
                Question_no.Text = QuestionNo.ToString
                CurrQst.Text = CurrentQuestion
                ARB.Checked = True
                Return True
            Catch ex As Exception
                MessageBox.Show("Error In Loading QuestionLoadQuestion,Questions may be Currupted")
                FileOpen = False
                FileOpend = "Nill"
                SaveState = False
                CloseReset()
                Return False
            End Try
            DLoadConnection.Close()
        Else
            MessageBox.Show("File does't Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DLoadConnection.Open()
            FileOpen = False
            FileOpend = "Nill"
            SaveState = False
            CloseReset()
            Return False
        End If
    End Function
    'Delete Question table
    Private Sub DeleteQstTable()
        SaveState = True
        Dim EDLoader As New DLoder.ExmDataLoader
        Try
            EDLoader.DeleteQuestions()
        Catch ex As Exception
        End Try
    End Sub
    'Save Questions
    Private Sub SaveQuestions(ByVal FileName As String)
        'loadQuestion
        DLoadConnection.Open()
        Try
            'Create Question
            Dim EDLoader As New DLoder.ExmDataLoader
            EDLoader.CreateQuestionTable()
            Dim DSet As New Data.DataSet
            DLoadAdapter.Fill(DSet)
            DSet.WriteXml(My.Application.Info.DirectoryPath & "\TempDataFile.xml")
            'Encryption
            Dim ENC As New Encoder.FileCrypto
            ENC.FileEncript(My.Application.Info.DirectoryPath & "\TempDataFile.xml", FileName, 2)
            'Delete Temp File
            IO.File.Delete(My.Application.Info.DirectoryPath & "\TempDataFile.xml")
        Catch ex As Exception
            MessageBox.Show("Error in Saving Questions ,restart your application or Check your security settings  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)                                           '<------------------------
        End Try
        SaveState = True
        DLoadConnection.Close()
    End Sub
    'Open panel reset
    Private Sub OpenReset()
        FileOpen = True
        SaveAsMenuFile.Enabled = True
        SaveMenuFile.Enabled = True
        CloseMenuFile.Enabled = True
        ControlPanel.Enabled = True
        MainPanel.Enabled = True
        MainPanel.Visible = True
        PanelNext.Enabled = True
        PanelBack.Enabled = False
        StartPanel.Visible = False
        ClearPanel()
        If Not QuestionNo = 1 Then
            PreviousQue.Enabled = True
        End If
        ButtonOK.Enabled = True
        Delete.Enabled = False
        ButtonUpdate.Enabled = False
        Next_1.Enabled = False
        ARB.Checked = True
        ClearToolStripMenuItem.Enabled = True
    End Sub
    'Close panel reset
    Private Sub CloseReset()
        ClearPanel()
        FileOpen = False
        SaveState = True
        FileOpend = "nill"
        StatusLabel.Text = "  eXaminer a complete examination solution  "
        CloseMenuFile.Enabled = False
        SaveAsMenuFile.Enabled = False
        SaveMenuFile.Enabled = False
        StartPanel.Visible = True
        Me.Text = "eXaminer"
        MainPanel.Visible = False
        ARB.Checked = True
        ClearToolStripMenuItem.Enabled = False
    End Sub
    'Clean Question
    Private Sub ClearPanel()
        QuestionRText.Text = ""

        ARB.Checked = True
        BRB.Checked = False
        CRB.Checked = False
        DRB.Checked = False
        ERB.Checked = False

        ATB.Text = ""
        BTB.Text = ""
        CTB.Text = ""
        DTB.Text = ""
        ETB.Text = ""

        ACB.Checked = True
        BCB.Checked = False
        CCB.Checked = False
        DCB.Checked = False
        ECB.Checked = False

        FIB1.Text = ""
        FIB2.Text = ""
        FIB3.Text = ""
        FIB4.Text = ""
        FIB5.Text = ""

        TRB.Checked = True
        FRB.Checked = False

        QuestionRText.Focus()
    End Sub
    'Methode For Aline Question Paper
    Private Sub SetQuestionPanel(ByVal QuestionType As Integer, ByVal OptionNo As Integer)
        Select Case QuestionType
            Case 1
                ' Multiple Question Single Answer 
                Blank.Visible = False
                'Check Box
                ACB.Visible = False
                BCB.Visible = False
                CCB.Visible = False
                DCB.Visible = False
                ECB.Visible = False
                'fil in the blanks
                FIB1.Visible = False
                FIB2.Visible = False
                FIB3.Visible = False
                FIB4.Visible = False
                FIB5.Visible = False
                'yes or no
                TRB.Visible = False
                FRB.Visible = False
                '------------------------------
                ATB.Visible = True
                BTB.Visible = True
                ARB.Visible = True
                BRB.Visible = True
                Select Case OptionNo
                    Case 2
                        CTB.Visible = False
                        DTB.Visible = False
                        ETB.Visible = False
                        'Readio Button
                        CRB.Visible = False
                        DRB.Visible = False
                        ERB.Visible = False
                    Case 3
                        'textbox
                        CTB.Visible = True
                        DTB.Visible = False
                        ETB.Visible = False
                        'Readio Button
                        CRB.Visible = True
                        DRB.Visible = False
                        ERB.Visible = False
                    Case 4
                        'textbox
                        CTB.Visible = True
                        DTB.Visible = True
                        ETB.Visible = False
                        'Readio Button
                        CRB.Visible = True
                        DRB.Visible = True
                        ERB.Visible = False
                    Case 5
                        'textbox
                        CTB.Visible = True
                        DTB.Visible = True
                        ETB.Visible = True
                        'Readio Button
                        CRB.Visible = True
                        DRB.Visible = True
                        ERB.Visible = True

                End Select
            Case 2                              ' Multiple Question Multiple Answer 
                Blank.Visible = False
                'Readio Button
                ARB.Visible = False
                BRB.Visible = False
                CRB.Visible = False
                DRB.Visible = False
                ERB.Visible = False
                'fil in the blanks
                FIB1.Visible = False
                FIB2.Visible = False
                FIB3.Visible = False
                FIB4.Visible = False
                FIB5.Visible = False
                'yes or no
                TRB.Visible = False
                FRB.Visible = False
                '----------------------------
                'Textbox
                ATB.Visible = True
                BTB.Visible = True
                'Check Box
                ACB.Visible = True
                BCB.Visible = True
                Select Case OptionNo

                    Case 2
                        'Textbox
                        CTB.Visible = False
                        DTB.Visible = False
                        ETB.Visible = False
                        'Check Box
                        CCB.Visible = False
                        DCB.Visible = False
                        ECB.Visible = False
                    Case 3
                        'Textbox
                        CTB.Visible = True
                        DTB.Visible = False
                        ETB.Visible = False
                        'Check Box
                        CCB.Visible = True
                        DCB.Visible = False
                        ECB.Visible = False
                    Case 4
                        'Textbox
                        CTB.Visible = True
                        DTB.Visible = True
                        ETB.Visible = False
                        'Check Box
                        CCB.Visible = True
                        DCB.Visible = True
                        ECB.Visible = False
                    Case 5
                        'Textbox
                        CTB.Visible = True
                        DTB.Visible = True
                        ETB.Visible = True
                        'Check Box
                        CCB.Visible = True
                        DCB.Visible = True
                        ECB.Visible = True
                End Select

            Case 3                                      ' Fill in the blanks 
                Blank.Visible = True
                'Textbox
                ATB.Visible = False
                BTB.Visible = False
                CTB.Visible = False
                DTB.Visible = False
                ETB.Visible = False
                'Readio Button
                ARB.Visible = False
                BRB.Visible = False
                CRB.Visible = False
                DRB.Visible = False
                ERB.Visible = False
                'Check Box
                ACB.Visible = False
                BCB.Visible = False
                CCB.Visible = False
                DCB.Visible = False
                ECB.Visible = False
                'yes or no
                TRB.Visible = False
                FRB.Visible = False
                '-----------------------------------
                'fil in the blanks
                FIB1.Visible = True
                FIB2.Visible = True
                Select Case OptionNo
                    Case 2
                        'fil in the blanks
                        FIB3.Visible = False
                        FIB4.Visible = False
                        FIB5.Visible = False
                    Case 3
                        'fil in the blanks
                        FIB3.Visible = True
                        FIB4.Visible = False
                        FIB5.Visible = False
                    Case 4
                        'fil in the blanks
                        FIB3.Visible = True
                        FIB4.Visible = True
                        FIB5.Visible = False
                    Case 5
                        'fil in the blanks
                        FIB3.Visible = True
                        FIB4.Visible = True
                        FIB5.Visible = True
                End Select
            Case 4                                              'Yes or no
                Blank.Visible = False
                TRB.Visible = True
                FRB.Visible = True
                TRB.Text = "TRUE"
                FRB.Text = "FALSE"
                TRB.Checked = True
                'clear 
                'Textbox
                ATB.Visible = False
                BTB.Visible = False
                CTB.Visible = False
                DTB.Visible = False
                ETB.Visible = False
                'Readio Button
                ARB.Visible = False
                BRB.Visible = False
                CRB.Visible = False
                DRB.Visible = False
                ERB.Visible = False
                'Check Box
                ACB.Visible = False
                BCB.Visible = False
                CCB.Visible = False
                DCB.Visible = False
                ECB.Visible = False
                'fil in the blanks
                FIB1.Visible = False
                FIB2.Visible = False
                FIB3.Visible = False
                FIB4.Visible = False
                FIB5.Visible = False
            Case 5
                Blank.Visible = False
                TRB.Visible = True
                FRB.Visible = True
                TRB.Text = "YES"
                FRB.Text = "NO"
                TRB.Checked = True
                'clear
                'Textbox
                ATB.Visible = False
                BTB.Visible = False
                CTB.Visible = False
                DTB.Visible = False
                ETB.Visible = False
                'Readio Button
                ARB.Visible = False
                BRB.Visible = False
                CRB.Visible = False
                DRB.Visible = False
                ERB.Visible = False
                'Check Box
                ACB.Visible = False
                BCB.Visible = False
                CCB.Visible = False
                DCB.Visible = False
                ECB.Visible = False
                'fil in the blanks
                FIB1.Visible = False
                FIB2.Visible = False
                FIB3.Visible = False
                FIB4.Visible = False
                FIB5.Visible = False
        End Select
    End Sub

    Private Sub AriangeQuestions(ByVal Question_NO As Integer)
        'Creation of Connection Objects and DataReaders
        Dim Connection As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb")
        Connection.Open()
        Dim DataReader As System.Data.OleDb.OleDbDataReader
        Dim select_cmd As New System.Data.OleDb.OleDbCommand("SELECT * FROM Questions WHERE QuestionNo = " & Question_NO, Connection)
        DataReader = select_cmd.ExecuteReader()
        DataReader.Read()
        'Updating data values
        'Try
        QuestionRText.Text = DataReader.Item("Question").ToString
        QuestionType = CType(DataReader.Item("QuestionType"), Integer)
        Select Case QuestionType
            Case 1
                MCSA_RB.Checked = True
            Case 2
                MCMA_RB.Checked = True
            Case 3
                FinB_RB.Checked = True
            Case 4
                TorF_RB.Checked = True
            Case 5
                YorN_RB.Checked = True
        End Select
        OptionNo = CType(DataReader.Item("OptionNo"), Integer)
        Choice.Text = OptionNo

        CAns.Text = CType(DataReader.Item("CAnswer"), Integer)
        WAns.Text = CType(DataReader.Item("WAnswer"), Integer)
        TimeAlloc.Text = CType(DataReader.Item("ExamTime"), Integer)
        'Setquestion panel
        SetQuestionPanel(QuestionType, OptionNo)
        'Enter values to panel
        Select Case QuestionType
            Case 1
                ATB.Text = DataReader.Item("OptionA").ToString
                BTB.Text = DataReader.Item("OptionB").ToString
                CTB.Text = DataReader.Item("OptionC").ToString
                DTB.Text = DataReader.Item("OptionD").ToString
                ETB.Text = DataReader.Item("OptionE").ToString
                Select Case DataReader.Item("AnswerA").ToString
                    Case "A"
                        ARB.Checked = True
                        BRB.Checked = False
                        CRB.Checked = False
                        DRB.Checked = False
                        ERB.Checked = False
                    Case "B"
                        ARB.Checked = False
                        BRB.Checked = True
                        CRB.Checked = False
                        DRB.Checked = False
                        ERB.Checked = False
                    Case "C"
                        ARB.Checked = False
                        BRB.Checked = False
                        CRB.Checked = True
                        DRB.Checked = False
                        ERB.Checked = False
                    Case "D"
                        ARB.Checked = False
                        BRB.Checked = False
                        CRB.Checked = False
                        DRB.Checked = True
                        ERB.Checked = False
                    Case "E"
                        ARB.Checked = False
                        BRB.Checked = False
                        CRB.Checked = False
                        DRB.Checked = False
                        ERB.Checked = True
                End Select
            Case 2
                ATB.Text = DataReader.Item("OptionA").ToString
                BTB.Text = DataReader.Item("OptionB").ToString
                CTB.Text = DataReader.Item("OptionC").ToString
                DTB.Text = DataReader.Item("OptionD").ToString
                ETB.Text = DataReader.Item("OptionE").ToString

                ACB.Checked = CType(DataReader.Item("AnswerA"), Boolean)
                BCB.Checked = CType(DataReader.Item("AnswerB"), Boolean)
                CCB.Checked = CType(DataReader.Item("AnswerC"), Boolean)
                DCB.Checked = CType(DataReader.Item("AnswerD"), Boolean)
                ECB.Checked = CType(DataReader.Item("AnswerE"), Boolean)
            Case 3
                FIB1.Text = DataReader.Item("AnswerA").ToString
                FIB2.Text = DataReader.Item("AnswerB").ToString
                FIB3.Text = DataReader.Item("AnswerC").ToString
                FIB4.Text = DataReader.Item("AnswerD").ToString
                FIB5.Text = DataReader.Item("AnswerE").ToString
            Case 4 Or 5
                If CType(DataReader.Item("AnswerA"), Integer) = 1 Then
                    MessageBox.Show("Yes/True")
                    TRB.Checked = True
                    FRB.Checked = False
                Else
                    MessageBox.Show("No Or False")
                    TRB.Checked = False
                    FRB.Checked = True
                End If
        End Select
        'Catch ex As Exception
        'End Try
        'closing reader and Connection
        DataReader.Close()
        Connection.Close()
        Connection.Dispose()
    End Sub

    Private Function GetLastQuestion() As Integer
        Dim Temp As Integer ' temp variable For Returning Value
        Try
            'Start Connection
            Using ODbConnection As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb")
                ODbConnection.Open()
                Dim select_cmd As New System.Data.OleDb.OleDbCommand("SELECT MAX(QuestionNo) FROM Questions", ODbConnection)
                Dim DataReader As System.Data.OleDb.OleDbDataReader
                DataReader = select_cmd.ExecuteReader()
                DataReader.Read()
                Temp = DataReader.GetInt32(0)
                'Relase Connection & DataReader Object
                DataReader.Close()
                DataReader.Dispose()
                ODbConnection.Close()
                ODbConnection.Dispose()
            End Using
            Return Temp
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function IsCamandArgs() As Boolean
        Try
            If IO.File.Exists(My.Application.CommandLineArgs(0)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As ArgumentOutOfRangeException
            Return False
        End Try
    End Function

    Private Function ValidateQuestion() As Boolean
        If QuestionRText.Text.Length = 0 Then
            QuestionRText.Focus()
            Return False
        Else
            Select Case QuestionType

                Case 1
                    Select Case OptionNo
                        Case 2
                            If ARB.Checked = True Or BRB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If
                        Case 3
                            If ARB.Checked = True Or BRB.Checked = True Or CRB.Checked = True = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If
                        Case 4
                            If ARB.Checked = True Or BRB.Checked = True Or CRB.Checked = True Or DRB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Or DTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If
                        Case 5
                            If ARB.Checked = True Or BRB.Checked = True Or CRB.Checked = True Or DRB.Checked = True Or ERB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Or DTB.Text.Length = 0 Or ETB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If
                    End Select
                Case 2
                    Select Case OptionNo

                        Case 2
                            If ACB.Checked = True Or BCB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If

                        Case 3
                            If ACB.Checked = True Or BCB.Checked = True Or CCB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If

                        Case 4
                            If ACB.Checked = True Or BCB.Checked = True Or CCB.Checked = True Or DCB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Or DTB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If

                        Case 5
                            If ACB.Checked = True Or BCB.Checked = True Or CCB.Checked = True Or DCB.Checked = True Or ECB.Checked = True Then
                                If ATB.Text.Length = 0 Or BTB.Text.Length = 0 Or CTB.Text.Length = 0 Or DTB.Text.Length = 0 Or ETB.Text.Length = 0 Then
                                    Return False
                                Else
                                    Return True
                                End If
                            End If

                    End Select

                Case 3
                    Select Case OptionNo
                        Case 2
                            If FIB1.Text.Length = 0 Or FIB2.Text.Length = 0 Then
                                Return False
                            Else
                                Return True
                            End If

                        Case 3
                            If FIB1.Text.Length = 0 Or FIB2.Text.Length = 0 Or FIB3.Text.Length = 0 Then
                                Return False
                            Else
                                Return True
                            End If

                        Case 4
                            If FIB1.Text.Length = 0 Or FIB2.Text.Length = 0 Or FIB3.Text.Length = 0 Or FIB4.Text.Length = 0 Then
                                Return False
                            Else
                                Return True
                            End If

                        Case 5
                            If FIB1.Text.Length = 0 Or FIB2.Text.Length = 0 Or FIB3.Text.Length = 0 Or FIB4.Text.Length = 0 Or FIB5.Text.Length = 0 Then
                                Return False
                            Else
                                Return True
                            End If

                    End Select
                Case 4
                    Return True
                Case 5
                    Return True
            End Select
        End If

    End Function

    Private Sub ArrangeResentDoc()
        Try

            Dim Software As RegistryKey = Registry.CurrentUser.OpenSubKey("Software")
            Dim Examiner2007 As RegistryKey = Software.OpenSubKey("Examiner2007")
            Dim ExmEditor As RegistryKey = Examiner2007.OpenSubKey("Exam-Editor", True)
            ResentDocNo = CInt(ExmEditor.GetValue("FileIndex"))

            Select Case ResentDocNo
                Case 1
                    File1ToolStripMenuItem.Visible = True
                    File1ToolStripMenuItem.Text = ExmEditor.GetValue("File0")
                    File2ToolStripMenuItem.Visible = False
                    File3ToolStripMenuItem.Visible = False
                    File4ToolStripMenuItem.Visible = False
                    File5ToolStripMenuItem.Visible = False
                    RecentMenuFile.Enabled = True
                Case 2
                    File1ToolStripMenuItem.Visible = True
                    File1ToolStripMenuItem.Text = ExmEditor.GetValue("File0")
                    File2ToolStripMenuItem.Visible = True
                    File2ToolStripMenuItem.Text = ExmEditor.GetValue("File1")
                    File3ToolStripMenuItem.Visible = False
                    File4ToolStripMenuItem.Visible = False
                    File5ToolStripMenuItem.Visible = False
                    RecentMenuFile.Enabled = True
                Case 3
                    File1ToolStripMenuItem.Visible = True
                    File1ToolStripMenuItem.Text = ExmEditor.GetValue("File0")
                    File2ToolStripMenuItem.Visible = True
                    File2ToolStripMenuItem.Text = ExmEditor.GetValue("File1")
                    File3ToolStripMenuItem.Visible = True
                    File3ToolStripMenuItem.Text = ExmEditor.GetValue("File2")
                    File4ToolStripMenuItem.Visible = False
                    File5ToolStripMenuItem.Visible = False
                    RecentMenuFile.Enabled = True
                Case 4
                    File1ToolStripMenuItem.Visible = True
                    File1ToolStripMenuItem.Text = ExmEditor.GetValue("File0")
                    File2ToolStripMenuItem.Visible = True
                    File2ToolStripMenuItem.Text = ExmEditor.GetValue("File1")
                    File3ToolStripMenuItem.Visible = True
                    File3ToolStripMenuItem.Text = ExmEditor.GetValue("File2")
                    File4ToolStripMenuItem.Visible = True
                    File4ToolStripMenuItem.Text = ExmEditor.GetValue("File3")
                    File5ToolStripMenuItem.Visible = False
                    RecentMenuFile.Enabled = True
                Case 5
                    File1ToolStripMenuItem.Visible = True
                    File1ToolStripMenuItem.Text = ExmEditor.GetValue("File0")
                    File2ToolStripMenuItem.Visible = True
                    File2ToolStripMenuItem.Text = ExmEditor.GetValue("File1")
                    File3ToolStripMenuItem.Visible = True
                    File3ToolStripMenuItem.Text = ExmEditor.GetValue("File2")
                    File4ToolStripMenuItem.Visible = True
                    File4ToolStripMenuItem.Text = ExmEditor.GetValue("File3")
                    File5ToolStripMenuItem.Visible = True
                    File5ToolStripMenuItem.Text = ExmEditor.GetValue("File4")
                    RecentMenuFile.Enabled = True
                Case 0
                    File1ToolStripMenuItem.Visible = False
                    File2ToolStripMenuItem.Visible = False
                    File3ToolStripMenuItem.Visible = False
                    File4ToolStripMenuItem.Visible = False
                    File5ToolStripMenuItem.Visible = False
                    RecentMenuFile.Enabled = False
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddResentDoc(ByVal File As String, ByVal count As Integer)
        Try
            Dim Software As RegistryKey = Registry.CurrentUser.OpenSubKey("Software")
            Dim Examiner2007 As RegistryKey = Software.OpenSubKey("Examiner2007")
            Dim ExmEditor As RegistryKey = Examiner2007.OpenSubKey("Exam-Editor", True)
            Select Case count
                Case 2
                    ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                    ExmEditor.SetValue("File0", File)
                Case 3
                    ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                    ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                    ExmEditor.SetValue("File0", File)
                Case 4
                    ExmEditor.SetValue("File3", ExmEditor.GetValue("File2"))
                    ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                    ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                    ExmEditor.SetValue("File0", File)
                Case 5
                    ExmEditor.SetValue("File4", ExmEditor.GetValue("File3"))
                    ExmEditor.SetValue("File3", ExmEditor.GetValue("File2"))
                    ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                    ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                    ExmEditor.SetValue("File0", File)
            End Select
            ArrangeResentDoc()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AddResentDoc(ByVal File As String)
        Select Case File
            'If present in resent document
            Case File1ToolStripMenuItem.Text
                'AddResentDoc(File1ToolStripMenuItem.Text, 1)
                'donothing
            Case File2ToolStripMenuItem.Text
                AddResentDoc(File2ToolStripMenuItem.Text, 2)
            Case File3ToolStripMenuItem.Text
                AddResentDoc(File3ToolStripMenuItem.Text, 3)
            Case File4ToolStripMenuItem.Text
                AddResentDoc(File4ToolStripMenuItem.Text, 4)
            Case File5ToolStripMenuItem.Text
                AddResentDoc(File5ToolStripMenuItem.Text, 5)

            Case Else
                Try
                    Dim Software As RegistryKey = Registry.CurrentUser.OpenSubKey("Software")
                    Dim Examiner2007 As RegistryKey = Software.OpenSubKey("Examiner2007")
                    Dim ExmEditor As RegistryKey = Examiner2007.OpenSubKey("Exam-Editor", True)
                    Dim Count As Integer = CInt(ExmEditor.GetValue("FileIndex"))
                    If Count < 5 Then
                        Count = Count + 1
                        ExmEditor.SetValue("FileIndex", Count.ToString)
                    End If
                    Select Case Count
                        Case 0
                            ExmEditor.SetValue("File0", File)
                        Case 1
                            ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                            ExmEditor.SetValue("File0", File)
                        Case 2
                            ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                            ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                            ExmEditor.SetValue("File0", File)
                        Case 3
                            ExmEditor.SetValue("File3", ExmEditor.GetValue("File2"))
                            ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                            ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                            ExmEditor.SetValue("File0", File)
                        Case 4
                            ExmEditor.SetValue("File4", ExmEditor.GetValue("File3"))
                            ExmEditor.SetValue("File3", ExmEditor.GetValue("File2"))
                            ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                            ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                            ExmEditor.SetValue("File0", File)
                        Case 5
                            ExmEditor.SetValue("File4", ExmEditor.GetValue("File3"))
                            ExmEditor.SetValue("File3", ExmEditor.GetValue("File2"))
                            ExmEditor.SetValue("File2", ExmEditor.GetValue("File1"))
                            ExmEditor.SetValue("File1", ExmEditor.GetValue("File0"))
                            ExmEditor.SetValue("File0", File)
                    End Select
                    ArrangeResentDoc()
                Catch ex As Exception
                    MessageBox.Show("Error call your administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End
                End Try
        End Select
    End Sub

    Private Function FileOpenRec(ByVal ExamFile As String) As Boolean
        StatusLabel.Text = "opening.."
        'Check File oppend
        If FileOpend = ExamFile Then
            Return False
        Else
            If FileOpen = True And SaveState = False Then
                Select Case MessageBox.Show("Current Questions will be closed Save your Questions ", "exam Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        Me.UseWaitCursor = True
                        StatusLabel.Text = "Saving Questions.."
                        'save questions
                        SaveQuestions(FileOpend)
                        'DeleteQst
                        DeleteQstTable()
                        'Load new  Questions
                        'Create new Question Table
                        Dim EDLoarer As New DLoder.ExmDataLoader
                        EDLoarer.CreateQuestionTable()
                        FileOpend = ExamFile
                        If LoadQuestions(ExamFile) = True Then
                            'Enable dilable 
                            ClearPanel()
                            OpenReset()
                            newFile = False
                            Me.Text = "eXaminer  " & "[ " & ExamFile & " ]"
                        End If
                        Me.UseWaitCursor = False
                        'Returing Result
                        Return True
                    Case Windows.Forms.DialogResult.No
                        Me.UseWaitCursor = True
                        StatusLabel.Text = "Clearing temporary datas.."
                        'Drop Questions
                        DeleteQstTable()
                        'Create new Question Table
                        Dim EDLoarer As New DLoder.ExmDataLoader
                        EDLoarer.CreateQuestionTable()
                        'Load new  Questions
                        FileOpend = ExamFile
                        If LoadQuestions(ExamFile) = True Then
                            'Enable dilable 
                            ClearPanel()
                            OpenReset()
                            newFile = False
                            Me.Text = "eXaminer  " & "[ " & ExamFile & " ]"
                            Me.UseWaitCursor = False
                            'Returing Result
                            Return True
                        End If
                    Case Windows.Forms.DialogResult.Cancel
                        'Returing Result
                        Return False
                End Select
            Else
                Me.UseWaitCursor = True
                'Drop Questions
                DeleteQstTable()
                'Create new Question Table
                Dim EDLoarer As New DLoder.ExmDataLoader
                EDLoarer.CreateQuestionTable()
                'Load new  Questions
                FileOpend = ExamFile
                If LoadQuestions(ExamFile) = True Then
                    'Enable dilable 
                    ClearPanel()
                    OpenReset()
                    Me.Text = "eXaminer  " & "[ " & ExamFile & " ]"
                End If
                Me.UseWaitCursor = False
                'Returing Result
                Return True
            End If
            StatusLabel.Text = "Ready.."
        End If

    End Function

#End Region
End Class





