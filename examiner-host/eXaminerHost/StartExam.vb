Imports DLoder.ExmDataLoader
Public Class StartExam
    Dim RDLoader As New ReDataProV.RemortDataProvider
    Dim _Duration As Integer = RDLoader.GetExamDuration()
    Dim counter As Integer = 0

    'Load Exam
    Private Sub StartExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RDLoader As New ReDataProV.RemortDataProvider
        If RDLoader.GetExamType = 1 Then                    'Type 1
            RadioButtonShedule.Enabled = False
            TimerCurrentTime.Enabled = True
        Else
            RadioButtonShedule.Checked = True
        End If
        TextBoxSHr.Text = My.Computer.Clock.LocalTime.Hour
        TextBoxSmin.Text = My.Computer.Clock.LocalTime.Minute
    End Sub
    'Form Closing
    Private Sub StartExam_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim EDLoader As New DLoder.ExmDataLoader
        ExamOption.Visible = True
        Me.Visible = False
        Try
            EDLoader.DeleteQuestions()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamProperties()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamTable()
        Catch ex As Exception
        End Try
        Me.Hide()
        Me.Dispose()
    End Sub


    'Radio buttons
    Private Sub RadioButtonSnow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSnow.CheckedChanged
        TextBoxSHr.Enabled = False
        TextBoxSmin.Enabled = False
    End Sub

    Private Sub RadioButtonShedule_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonShedule.CheckedChanged
        TextBoxSHr.Enabled = True
        TextBoxSmin.Enabled = True
        TextBoxSHr.Text = My.Computer.Clock.LocalTime.Hour
        TextBoxSmin.Text = My.Computer.Clock.LocalTime.Minute
    End Sub

    ' Click Ok
    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        Dim EdLoader As New DLoder.ExmDataLoader
        Label.Text = " Exam Sheduled at " & TextBoxSHr.Text & " : " & TextBoxSmin.Text
        PanelDisplay.Visible = False
        ButtonOk.Enabled = False
        ButtonRest.Enabled = True
        Dim RDLoader As New ReDataProV.RemortDataProvider
        'Start exam
        If RadioButtonSnow.Checked = True Then
            'start exam
            EdLoader.SetExamStart(True)
            eXaminationHost.Show()
            Me.Hide()
            Me.Dispose()
            If RDLoader.GetExamType = 2 Then
                'Timer For Starting Exam
                Timerstart.Enabled = True
            End If
        ElseIf RadioButtonShedule.Checked = True Then
            'Timer For Starting Exam
            Select Case RDLoader.GetExamType
                Case 1
                    TimerStop.Enabled = True
                Case 2
                    Timerstart.Enabled = True
                Case 3
                    Timerstart.Enabled = True
            End Select
        End If
    End Sub

    Private Sub ButtonRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRest.Click
        ButtonRest.Enabled = False
        ButtonOk.Enabled = True
        PanelDisplay.Visible = True
        Timerstart.Enabled = False
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        'droptable
        ExamOption.Show()
        Dim EDLoader As New DLoder.ExmDataLoader
        Try
            EDLoader.DeleteQuestions()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamProperties()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamTable()
        Catch ex As Exception
        End Try
        Timerstart.Enabled = False
        Me.Hide()
        Me.Dispose()
    End Sub

    'Timer Events
    Private Sub Timerstart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerstart.Tick
        Dim _Temp As String = My.Computer.Clock.LocalTime.Hour & My.Computer.Clock.LocalTime.Minute
        If _Temp = TextBoxSHr.Text & TextBoxSmin.Text Then
            'Disable Timer
            Timerstart.Enabled = False
            Me.Hide()
            eXaminationHost.Show()
            'Set Examstarted 
            Dim EDLOader As New DLoder.ExmDataLoader
            EDLOader.SetExamStart(True)
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Files\ExamStart.wav")
            PanelDisplay.Visible = True
            ButtonOk.Enabled = True
            ButtonRest.Enabled = False
            'Enable  'Timer For Stop Exam
            Dim RDLoader As New ReDataProV.RemortDataProvider
            Select Case RDLoader.GetExamType
                Case 2
                    TimerStop.Enabled = True
                Case 3
                    TimerStop.Enabled = True
            End Select
        End If
    End Sub

    Private Sub TimerStop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerStop.Tick
        counter += 1
        If counter >= _Duration Then
            TimerStop.Enabled = False
            'Stop Exam
            Dim EDLoader As New DLoder.ExmDataLoader
            EDLoader.SetISExamOver(True)
            EDLoader.SetExamStart(False)
            Try
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\Files\ExamOver.wav")
            Catch ex As Exception
                Beep()
                MessageBox.Show("Exam Over")
            End Try
            'Show Result
            eXaminationHost.State = eXaminationHost.ExamResults.Saved
            eXaminationHost._ExamState = eXaminationHost.ExamState.Over
            eXaminationHost.PButtonStopExam.Enabled = False
            eXaminationHost.PButtonSaveResults.Enabled = True
            eXaminationHost.PButtonExit.Enabled = True
            eXaminationHost.TimerRefreshGrid.Enabled = False
            eXaminationHost.StopExam_TrayMenu.Enabled = False
            eXaminationHost.PButtonLoadNewExam.Enabled = True
            eXaminationHost.ToolStripMenu_newExam.Enabled = True
            eXaminationHost.Exit_TrayMenu.Enabled = True
            SaveResults.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub TimerCurrentTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCurrentTime.Tick
        TextBoxSHr.Text = My.Computer.Clock.LocalTime.Hour
        TextBoxSmin.Text = My.Computer.Clock.LocalTime.Minute
    End Sub

    'Validating time Box
    Private Sub TextBoxSmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSmin.KeyPress
        If TextBoxSmin.Text.Length = 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxSHr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSHr.KeyPress
        If TextBoxSHr.Text.Length = 2 Then
            e.Handled = True
        End If
    End Sub

End Class