Public Class Teminate

    Private Sub TimerTeminate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTeminate.Tick
        If ProgressBar.Value > 0 Then
            ProgressBar.Value = ProgressBar.Value - 20
        Else
            End
        End If
    End Sub

    Private Sub Teminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
    End Sub
    Private Sub Clear()
        eXaminationHost.SystemTrayIcon.Visible = False
        eXaminationHost.TimerRefreshGrid.Enabled = False
        StartExam.TimerCurrentTime.Enabled = False
        eXaminationHost.SystemTrayIcon.Visible = False
        StartExam.Timerstart.Enabled = False
        StartExam.TimerStop.Enabled = False
        TimerTeminate.Enabled = True
        Dim Edloader As New DLoder.ExmDataLoader
        Edloader.DeleteQuestions()
        Edloader.DeleteExamProperties()
        Edloader.DeleteExamTable()
        TimerTeminate.Enabled = True
    End Sub

End Class