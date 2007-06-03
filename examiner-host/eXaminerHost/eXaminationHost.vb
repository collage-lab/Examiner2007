Imports DLoder.ExmDataLoader
Imports System.Runtime.Remoting
Imports ReDataProV.RemortDataProvider
Imports ResultWriter.ResultTextWriter
Imports ResultWriter.WriteHTML

Public Class eXaminationHost


    Public Enum ExamResults
        Saved
        NotSaved
    End Enum
    Public Enum ExamState
        Running
        Waiting
        Over
    End Enum

    Public running As Boolean = False
    Public _ExamState As ExamState
    Public ResultsSaved As Boolean = False
    Public State As ExamResults = ExamResults.NotSaved
    Dim CONNECTION_STRING As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb"


#Region "           Form Events             "

    Private Sub eXaminationHost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelExamLoaded.Text = ExamOption.TextBoxFileOpen.Text
        Dim RDLoad As New ReDataProV.RemortDataProvider
        LabelStartingTime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
        LabelNoofQuestions.Text = RDLoad.GetNoOfQuestions
        TimerRefreshGrid.Enabled = True
        If RDLoad.GetExamType = 1 Then
            LabelDurationOfExam.Text = " Click Abort For Stoping Examination"
        Else
            LabelDurationOfExam.Text = RDLoad.GetExamDuration & " Minutes"
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub eXaminationHost_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        HideTool_TrayMenu.Text = "Show Host"
        e.Cancel = True
    End Sub

#End Region

#Region "           Menu Events             "

    Private Sub PButtonSaveResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonSaveResults.Click
        SaveResults.Show()
    End Sub

    Private Sub PButtonLoadNewExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonLoadNewExam.Click
        'Drop Tables 
        ExamOption.Show()
        TimerRefreshGrid.Enabled = False
        Dim EdLoader As New DLoder.ExmDataLoader
        Try
            EdLoader.DeleteExamProperties()
        Catch ex As Exception
        End Try
        Try
            EdLoader.DeleteExamTable()
        Catch ex As Exception
        End Try
        Try
            EdLoader.DeleteExamTable()
        Catch ex As Exception
        End Try
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub PButton_layout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButton_layout.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PButtonHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonHide.Click
        Me.WindowState = FormWindowState.Minimized
        HideTool_TrayMenu.Text = "Show Host"
        Me.Visible = False
    End Sub

    Private Sub PButtonStopExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonStopExam.Click
        'Set Exam Over 
        Dim RdLoader As New ReDataProV.RemortDataProvider
        Dim EDLoader As New DLoder.ExmDataLoader
        Select Case RdLoader.GetExamType
            Case 1
                If MessageBox.Show("Are you Sure to Stop exam  ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    SaveResults.Show()
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
            Case 2
                If MessageBox.Show("This Action will cause lose of data ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    'save results
                    If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        SaveResults.Show()
                    End If
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
            Case 3
                If MessageBox.Show("This Action will cause lose of data ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    'save results
                    If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        SaveResults.Show()
                    End If
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
        End Select
    End Sub

    Private Sub PButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonExit.Click
        If ResultsSaved = False Then
            If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                SaveResults.Show()
            Else
                Teminate.Show()
            End If
        ElseIf ResultsSaved = True Then
            Teminate.Show()
        End If
    End Sub

    Private Sub PButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PButtonAbout.Click
        Me.Enabled = False
        About.Visible = True
    End Sub

#End Region

#Region "           TrayIcon Events         "
    'Exit ExamHost
    Private Sub Exit_TrayMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_TrayMenu.Click
        If ResultsSaved = False Then
            If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                SaveResults.Show()
            Else
                Teminate.Show()
            End If
        ElseIf ResultsSaved = True Then
            Teminate.Show()
        End If
    End Sub
    'Min Max Windows
    Private Sub SystemTrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SystemTrayIcon.MouseDoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Minimized
            HideTool_TrayMenu.Text = "Show Host"
            Me.Visible = False
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
            HideTool_TrayMenu.Text = "Hide Host"
            Me.Visible = False
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            HideTool_TrayMenu.Text = "Show Host"
        End If
    End Sub
    'Hide Exam Host
    Private Sub HideTool_TrayMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideTool_TrayMenu.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            HideTool_TrayMenu.Text = "Hide Host"
        Else
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            HideTool_TrayMenu.Text = "Show Host"
        End If
    End Sub
    'Stopexam
    Private Sub StopExam_TrayMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopExam_TrayMenu.Click
        'Set Exam Over 
        Dim RdLoader As New ReDataProV.RemortDataProvider
        Dim EDLoader As New DLoder.ExmDataLoader
        Select Case RdLoader.GetExamType
            Case 1
                If MessageBox.Show("Are you Sure to Stop exam  ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    SaveResults.Show()
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
            Case 2
                If MessageBox.Show("This Action will cause lose of data ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    'save results
                    If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        SaveResults.Show()
                    End If
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
            Case 3
                If MessageBox.Show("This Action will cause lose of data ", "Stop Exam", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    EDLoader.SetISExamOver(True)
                    EDLoader.SetExamStart(False)
                    'Disable / Enable 
                    PButtonStopExam.Enabled = False
                    PButtonExit.Enabled = True
                    TimerRefreshGrid.Enabled = False
                    StopExam_TrayMenu.Enabled = False
                    PButtonLoadNewExam.Enabled = True
                    ToolStripMenu_newExam.Enabled = True
                    Exit_TrayMenu.Enabled = True
                    PButtonSaveResults.Enabled = True
                    State = ExamResults.Saved
                    PButtonSaveResults.Enabled = True
                    'save results
                    If MessageBox.Show("Do you want to save results ", "Save Results", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        SaveResults.Show()
                    End If
                    LabelExamStatus.Text = "Exam Over"
                    LabelEndingtime.Text = My.Computer.Clock.LocalTime.Hour & " : " & My.Computer.Clock.LocalTime.Minute
                End If
        End Select
    End Sub
#End Region

#Region "          Private Functions        "
    'Refreshes the values in the data grid
    Private Sub GridRefresh()
        '--------------------------------------------'
        Dim Sql = "SELECT * FROM Examination"
        '--------------------------------------------'
        'new OleDBDataApapter
        Dim ODBAdapter As Data.OleDb.OleDbDataAdapter = New Data.OleDb.OleDbDataAdapter(Sql, CONNECTION_STRING)
        'new DataSet
        Dim DataSet As New Data.DataSet
        'If fill = False Then
        Try
            ODBAdapter.Fill(DataSet)
            ODBAdapter.Dispose()
            DataGrid.DataSource = DataSet.Tables(0).DefaultView
            'fill = True
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show(" Check DataBase ( Examiner2007.msd ) Is in the Installed Folder")
        End Try
        DataSet.Dispose()
        ODBAdapter.Dispose()
    End Sub
#End Region

#Region "            Timer Events           "
    Private Sub TimerRefreshGrid_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRefreshGrid.Tick
        GridRefresh()
    End Sub
#End Region

#Region "Picture buttons Events "

#End Region

End Class