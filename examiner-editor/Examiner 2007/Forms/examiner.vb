Imports ReDataProV.RemortDataProvider
Imports System.Runtime.Remoting
Imports DLoder.ExmDataLoader


Public Class examiner


    Dim Exam As New Examination



#Region "           Delete after Testing            "
    ''delete  after testing             
   
    Private Sub PictureBoxAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxAbort.Click
        End
    End Sub

#End Region'<===================================


    '   1   Load examiner  
    Private Sub examiner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RDProvider As New ReDataProV.RemortDataProvider
        'Cheching runing from server
        If RDProvider.IsServer = True Then                        ' //// Runing from Server size
            'check Exam is charted 
            Try
                '---------------------------------------------------------
                If RDProvider.ISExamOver = False Then
                    'get exam properties
                    Exam.FromServer = True
                    Exam.ExamDuration = RDProvider.GetExamDuration()
                    Exam.NoOfQuestions = RDProvider.GetNoOfQuestions()
                    Exam.ExamType = RDProvider.GetExamType()
                    'Load exam instructions
                    ButtonIAgree.Enabled = True
                    'MessageBox.Show(RDProvider.GetExamType.ToString)
                    Select Case RDProvider.GetExamType
                        Case 1
                            PictureBoxIntro.Image = ImageType1Exam.Image
                        Case 2
                            PictureBoxIntro.Image = ImageType1Exam.Image
                        Case 3
                            PictureBoxIntro.Image = ImageType3Exam.Image
                        Case Else
                            PictureBoxIntro.Image = ImageExamover1.Image
                            ButtonIAgree.Enabled = False
                    End Select
                    '---------------------------------------------------------
                Else

                    'change WebBrowser content and inform exam not charted
                    PictureBoxIntro.Image = ImageExamover1.Image
                    PictureBoxIntro.Visible = True
                    ButtonIAgree.Enabled = False
                End If
            Catch SocEx As System.Net.Sockets.SocketException
                ShowError(1)
            Catch Ex As Exception
                ShowError(2)
            End Try
        ElseIf RDProvider.IsServer = False Then                 ' //// Runing from Client file
            'Client side DataLoader
            Dim EDLoader As New DLoder.ExmDataLoader
            Try
                'create new exam table 
                EDLoader.CreateExamPropertiesTable()
                'Insert Client Exam Properties
                EDLoader.InsertExamPropeties("Flase", "True", 1, 180)
                'Configure Client Properties
                Exam.FromServer = False
                Exam.ExamDuration = 300 '300 minutes
                Exam.NoOfQuestions = RDProvider.GetNoOfQuestions()
                Exam.ExamType = 1
                Exam.CurrentQuestion = 1
                'Create new ExamTable
                EDLoader.CreateExamTable()
                'Enter first value
                Dim RDPro As New ReDataProV.RemortDataProvider
                Exam.RegisterNo = RDPro.RegisterExam("Examiner 2007", "exm2007")
                ButtonIAgree.Text = "Start Exam"
                PictureBoxIntro.Image = ImageWelcome.Image
            Catch OledbEx As System.Data.OleDb.OleDbException
                ShowError(3)
            Catch Ex As Exception
                ShowError(2)
            End Try
        Else                                                    ' /// Error show message
            ShowError(2)
        End If
    End Sub

    '   2  I Aggre <----- Client
    Private Sub ButtonIAgree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIAgree.Click
        'PanelStart.Visible = False
        If Exam.FromServer = True Then
            '''''''''''''''''register For exam'''''''''''''''''
            PanelRegistration.Visible = True
            '''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf Exam.FromServer = False Then
            'from client
            LoadQuestions(1)
            PanelQuestion.Visible = True
            PBarQuestionIncrement()
            LabelQstAttended.Visible = True
            LabelQueNo.Visible = True
        End If
    End Sub

    '   3   Registration  
#Region "           Registration           "
    Private Sub ButtonRegistrationOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistrationOk.Click
        If TextBoxUserName.Text = "" And TextBoxRegNo.Text = "" Then
            ErrorProvider.SetError(TextBoxUserName, " This filde must be filled")
            ErrorProvider.SetError(TextBoxRegNo, "This filde must be filled")
            TextBoxUserName.Focus()
        ElseIf TextBoxUserName.Text = "" Then
            ErrorProvider.SetError(TextBoxUserName, "This filde must be filled")
            TextBoxUserName.Focus()
        ElseIf TextBoxRegNo.Text = "" Then
            ErrorProvider.SetError(TextBoxRegNo, "This filde must be filled")
            TextBoxRegNo.Focus()
        Else
            Dim RDProvider As New ReDataProV.RemortDataProvider
            If RDProvider.CheckIdExists(TextBoxRegNo.Text) = False Then
                RegisterName.Text = TextBoxUserName.Text
                RegisterNo.Text = TextBoxRegNo.Text
                'registerexam
                Try
                    Exam.RegisterNo = RDProvider.RegisterExam(TextBoxUserName.Text, TextBoxRegNo.Text)
                    RDProvider = Nothing
                Catch SerSokEx As System.Net.Sockets.SocketException
                    ShowError(1)
                Catch Exception As System.Data.OleDb.OleDbException
                    MessageBox.Show("Server Side Error Ask your System Administrator ", "Server not Responding", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Terminate.Show()
                Catch ex As Exception
                    ShowError(3)
                End Try
                PictureBoxReg.Visible = False
                PictureBoxReg2.Visible = False
                PanelReg.Visible = False
                'Wait pannel enables
                TimerExamStart.Enabled = True
            Else
                MessageBox.Show(TextBoxRegNo.Text & " is allready registred ,Check your register no")
            End If
        End If


    End Sub

    Private Sub TimerExamStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerExamStart.Tick
        'Dissable Timer
        Dim RDProvider As New ReDataProV.RemortDataProvider
        Try
            If RDProvider.IsExamStarted() = True Then
                TimerExamStart.Enabled = False
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Files\Alert.wav")
                Exam.CurrentQuestion = 1
                LoadQuestions(1)

                'Make Registration  Panel nonvisible
                PanelRegistration.Visible = False
                'Make Question  Pansel visible
                PanelQuestion.Visible = True
                If Exam.ExamType = 1 Then
                    TimerExamOver.Enabled = True
                ElseIf Exam.ExamType = 2 Then
                    TimerExamOver.Enabled = True
                    TimerTimeProgress.Enabled = True
                    LabelTime.Text = Exam.ExamDuration & " Min"
                ElseIf Exam.ExamType = 3 Then
                    TimerExamOver.Enabled = True
                    TimerQuestionsOver.Enabled = True
                    TimerTimeProgress.Enabled = True
                    LabelTime.Text = Exam.ExamDuration & " Min"
                    LabelTime.Visible = True
                End If
                ButtonIAgree.Visible = False
                LabelQstAttended.Visible = True
                LabelQueNo.Visible = True

            End If
        Catch SerSokEx As System.Net.Sockets.SocketException
            ShowError(1)
        Catch Exception As Exception
            ShowError(2)
        End Try
    End Sub

    Private Sub ButtonRegistrationCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistrationCancel.Click
        Terminate.Show()
    End Sub
#End Region ' 

    '   4 Run Examination
#Region "           Questions Events Skip & Enter            "
    Private Sub ButtonSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSkip.Click
        Exam.CurrentQuestion = Exam.CurrentQuestion + 1
        If Exam.CurrentQuestion = Exam.NoOfQuestions + 1 Then
            ButtonEnter.Enabled = False
            TimerExamOver.Enabled = False
            ExamOver()
        Else
            LoadQuestions(Exam.CurrentQuestion)
        End If
    End Sub

    Private Sub ButtonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnter.Click
        PBarQuestionIncrement()
        'post answer
        PostAnswers()
        'ClearMarked()
        Exam.CurrentQuestion = Exam.CurrentQuestion + 1
        'End Exam If over
        If Exam.CurrentQuestion = Exam.NoOfQuestions + 1 Then
            ButtonEnter.Enabled = False
            TimerExamOver.Enabled = False
            ExamOver()
        Else
            LoadQuestions(Exam.CurrentQuestion)
        End If
    End Sub

#End Region

    '   5 Exam Validation            
#Region "           Question Functions             "
    'Clear All Fields 
    Private Sub ClearMarked()
        TRB.Checked = True
        FRB.Checked = False

        FIB1.Text = ""
        FIB2.Text = ""
        FIB3.Text = ""
        FIB4.Text = ""
        FIB5.Text = ""

        ACB.Checked = True
        BCB.Checked = False
        CCB.Checked = False
        DCB.Checked = False
        ECB.Checked = False

        ARB.Checked = True
        BRB.Checked = False
        CRB.Checked = False
        DRB.Checked = False
        ERB.Checked = False
    End Sub
    'loads questions and other details in the coresponding panels <--------------------
    Private Sub LoadQuestions(ByVal QuestionNo As Integer)
        '-----------------------------------------------'
        '       get question from database              '
        '-----------------------------------------------'
        'clear Questions
        ClearMarked()
        'creating remort object
        Try
            Dim RDProvider As New ReDataProV.RemortDataProvider
            Dim Questions(10) As String
            Questions = RDProvider.GetQuestions(QuestionNo)
            ''Question
            TextBoxQuestions.Text = Questions(1)
            'Question Type
            Exam.CurrentQuestType = CInt(Questions(8))
            Exam.OptionIndex = CInt(Questions(7))
            'Asigne Timer
            If Exam.ExamType = 3 Then
                TimerQuestionsOver.Enabled = False
                TimerQuestionsOver.Interval = CType(Questions(9), Integer) * 1000
                TimerQuestionsOver.Enabled = True
                QuestionTime.Text = Questions(9) & "  Sec"
                QuestionTime.Visible = True
            End If
            'Setting Questions 
            TextBoxQuestions.Text = Questions(1)
            'Asigne values to Questions
            If Exam.CurrentQuestType = 1 Or Exam.CurrentQuestType = 2 Then
                ATB.Text = Questions(2)
                BTB.Text = Questions(3)
                CTB.Text = Questions(4)
                DTB.Text = Questions(5)
                ETB.Text = Questions(6)
            ElseIf Exam.CurrentQuestType = 3 Or Exam.CurrentQuestType = 4 Or Exam.CurrentQuestType = 5 Then
            End If
        Catch SerSokEx As System.Net.Sockets.SocketException
            ShowError(1)
        Catch Exception As Exception
            ShowError(2)
        End Try

        'Add values to Appropreate collms
        PBarQuestionIncrement()
        SetQuestionPanel(Exam.CurrentQuestType, Exam.OptionIndex)
        LabelQueNo.Text = Exam.CurrentQuestion & " of " & Exam.NoOfQuestions
    End Sub
    'Methode For Aline Question Paper
    Private Sub SetQuestionPanel(ByVal QuestionType As Integer, ByVal OptionNo As Integer)
        Select Case QuestionType
            Case 1                                   ' Multiple Question Single Answer 

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
                ARB.Checked = True
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
    'methode for posting values back                
    Private Sub PostAnswers()
        'Remort object
        Try
            Dim RDProvider As New ReDataProV.RemortDataProvider
            Select Case Exam.CurrentQuestType
                Case 1 ' Single Question Multiple answer
                    If ARB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, "A")
                    ElseIf BRB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, "B")
                    ElseIf CRB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, "C")
                    ElseIf DRB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, "D")
                    ElseIf ERB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, "E")
                    End If
                Case 2 ' Multiple Question Multiple answer
                    RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, ACB.Checked.ToString, BCB.Checked.ToString, CCB.Checked.ToString, DCB.Checked.ToString, ECB.Checked.ToString, Exam.OptionIndex)
                Case 3 ' Fill in the blanks
                    RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, FIB1.Text, FIB2.Text, FIB3.Text, FIB4.Text, FIB5.Text, Exam.OptionIndex)
                Case 4 Or 5 ' True or false /  Yes or No
                    If TRB.Checked = True Then
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, 1)
                    Else
                        RDProvider.PostAnswer(Exam.RegisterNo, Exam.CurrentQuestion, 2)
                    End If ''''''''
            End Select '''''''
            RDProvider = Nothing
        Catch SerSokEx As System.Net.Sockets.SocketException
            Select Case MessageBox.Show("Your network connection has been altered  or exam Server is not responding  ", "Do you want to continue ", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Abort
                    Terminate.Show()
                Case Windows.Forms.DialogResult.Retry
                    PostAnswers()
                Case Windows.Forms.DialogResult.Cancel
                    'Donothing
            End Select
        Catch Exception As Exception
            ShowError(2)
        End Try
    End Sub
#End Region

#Region "        Control Events          "
    Private Sub examiner_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ClearTables()
    End Sub
#End Region

#Region "       Picture Buttons     "
    'Abourt PictureButton
    Private Sub PictureBoxAbort_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxAbort.MouseEnter
        PictureBoxAbort.Image = Abourt2.Image
    End Sub
    Private Sub PictureBoxAbort_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxAbort.MouseUp
        PictureBoxAbort.Image = Abourt2.Image
    End Sub
    Private Sub PictureBoxAbort_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxAbort.MouseDown
        PictureBoxAbort.Image = Abourt3.Image
    End Sub
    Private Sub PictureBoxAbort_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxAbort.MouseLeave
        PictureBoxAbort.Image = Abourt1.Image
    End Sub
#End Region

#Region "        Timer ---- ExamOver QuestionsOvaer            "
    'Exam over
    Private Sub TimerExamOver_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerExamOver.Tick
        Try
            Dim RDProvider As New ReDataProV.RemortDataProvider
            'Checking Does Exam Over
            If RDProvider.ISExamOver = True Then
                ExamOver()
            End If
            RDProvider = Nothing
        Catch SerSokEx As System.Net.Sockets.SocketException
            ShowError(1)
        Catch Exception As Exception
            ShowError(2)
        End Try
    End Sub
    'Questions over
    Private Sub TimerQuestionsOver_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerQuestionsOver.Tick
        Exam.CurrentQuestion = Exam.CurrentQuestion + 1
        If Exam.CurrentQuestion = Exam.NoOfQuestions + 1 Then
            TimerQuestionsOver.Enabled = False
            ExamOver()
        Else
            LoadQuestions(Exam.CurrentQuestion)
        End If
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Files\Alert.wav")
    End Sub
    'Progress pabfor timer
    Private Sub TimerTimeProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeProgress.Tick
        Static ExD As Integer = Exam.ExamDuration * 7

        Static Counter As Integer
        Counter += 1


        If Counter > ExD Then
            ProgressBarTime.Size = New System.Drawing.Size(679, 9)
            TimerTimeProgress.Enabled = False
        Else
            ProgressBarTime.Size = New System.Drawing.Size(CType((Counter / Exam.ExamDuration) * 10 * 4.79, Integer), 9)
        End If


    End Sub

#End Region
    '   Private functions
#Region "      Private Function  ExamOver ShowError    "
    Private Sub ExamOver()
        'hiding the labels
        LabelQstAttended.Visible = False
        LabelQueNo.Visible = False
        LabelTime.Visible = False
        'jiding progress bars
        ProgressBarTime.Visible = False
        ProgressBarQuestion.Visible = False
        'TimerExamOver.Enabled = False
        TimerTimeProgress.Enabled = False
        TimerQuestionsOver.Enabled = False
        TimerExamOver.Enabled = False
        'Disable Question panel
        PanelQuestion.Visible = False
        ButtonIAgree.Visible = False
        'IF From File
        'set Picture message 
        If Exam.FromServer = False Then
            PictureBoxIntro.Image = ImageExamover2.Image
            'Display Result
            Dim Connector As New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb")
            Connector.Open()
            Dim DataReader As System.Data.OleDb.OleDbDataReader
            Dim OLEDB_Command As New System.Data.OleDb.OleDbCommand("SELECT * FROM Examination WHERE StudentId = 'exm2007'", Connector)
            DataReader = OLEDB_Command.ExecuteReader()
            DataReader.Read()

            QALabel.Visible = True
            CAL.Visible = True
            WAL.Visible = True
            TML.Visible = True

            LabelQAtten.Visible = True
            LabelCans.Visible = True
            LabelWAns.Visible = True
            LabelTMarks.Visible = True


            LabelTMarks.Text = DataReader.Item("TotalMarks").ToString
            LabelQAtten.Text = DataReader.Item("QuestionsAttended").ToString
            LabelCans.Text = DataReader.Item("CorrectAnswer").ToString
            LabelWAns.Text = DataReader.Item("WrongAnswers").ToString

            OLEDB_Command.Dispose()
            DataReader = Nothing
            Connector.Close()
            Connector.Dispose()


            'Delete DataBase Table
            Dim EDLoader As New DLoder.ExmDataLoader
            EDLoader.DeleteExamProperties()
            EDLoader.DeleteExamTable()
            EDLoader.DeleteQuestions()
        Else
            'Set Picture message   
            PictureBoxIntro.Image = ImageExamover1.Image
        End If
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Files\ExamOver.wav")
    End Sub

    Public Sub ShowError(ByVal ErrorIndex As Integer)
        If ErrorIndex = 1 Then
            MessageBox.Show("Server Check Exam is Running ", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearTables()
            Terminate.Show()
        ElseIf ErrorIndex = 2 Then
            MessageBox.Show("Error Examination Canot be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearTables()
            Terminate.Show()
        ElseIf ErrorIndex = 3 Then
            MessageBox.Show("Reinstall The Application Or Check The sequrity settings", "Access Denied to files", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearTables()
            Terminate.Show()
        End If
    End Sub

    Private Sub PBarQuestionIncrement()
        Try
            Dim _Decimal As Decimal
            _Decimal = (Exam.CurrentQuestion / Exam.NoOfQuestions) * 100
            LabelQstAttended.Text = Decimal.Round(_Decimal, 2) & "%"
            If _Decimal > 507 Then
                ProgressBarQuestion.Size = New System.Drawing.Size(507, 9)
            Else
                ProgressBarQuestion.Size = New System.Drawing.Size(CType(_Decimal * 5.07, Integer), 9)
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub PBarTimeIncrement()
    '    Try
    '        Dim _Decimal As Decimal
    '        _Decimal = (Exam.CurrentQuestion / Exam.ExamDuration) * 100
    '        LabelQstAttended.Text = Decimal.Round(_Decimal, 2) & "%"
    '        If _Decimal > 507 Then
    '            ProgressBarTime.Size = New System.Drawing.Size(507, 9)
    '        Else
    '            ProgressBarTime.Size = New System.Drawing.Size(CType(_Decimal * 5.07, Integer), 9)
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub ClearTables()
        Dim EXDLoader As New DLoder.ExmDataLoader
        EXDLoader.DeleteQuestions()
        EXDLoader.DeleteExamProperties()
        EXDLoader.DeleteExamTable()
    End Sub
#End Region










   
  
End Class