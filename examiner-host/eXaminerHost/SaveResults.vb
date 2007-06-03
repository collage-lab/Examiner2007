'Imports ResultWriter.ResultTextWriter
'Imports ResultWriter.WriteHTML

Public Class SaveResults

    Dim RDLoad As New ReDataProV.RemortDataProvider
    Private Sub PBHtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBHtml.Click
        Dim SaveFileDig As New SaveFileDialog
        SaveFileDig.Filter = " web page |*.Html"
        SaveFileDig.FilterIndex = 1
        SaveFileDig.RestoreDirectory = True
        If SaveFileDig.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim SHTML As New ResultWriter.WriteHTML(SaveFileDig.FileName)
            Select Case RDLoad.GetExamType()
                Case 1
                    SHTML.HTMLWriter(RDLoad.GetNoOfQuestions, " NA ")
                Case 2
                    SHTML.HTMLWriter(RDLoad.GetNoOfQuestions, RDLoad.GetExamDuration.ToString & " Min ")
                Case 3
                    SHTML.HTMLWriter(RDLoad.GetNoOfQuestions, " NA ")
            End Select
            SaveFileDig.Dispose()
            SaveFileDig = Nothing
            SHTML = Nothing
            eXaminationHost.ResultsSaved = True
            Me.Hide()
        End If
    End Sub

    Private Sub PBtext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBText.Click
        Dim SaveFileDig As New SaveFileDialog
        SaveFileDig.Filter = " Text File |*.txt"
        SaveFileDig.FilterIndex = 1
        SaveFileDig.RestoreDirectory = True
        If SaveFileDig.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim STXT As New ResultWriter.ResultTextWriter(SaveFileDig.FileName)
            Select Case RDLoad.GetExamType()
                Case 1
                    STXT.TxtWriter(RDLoad.GetNoOfQuestions, " NA ")
                Case 2
                    STXT.TxtWriter(RDLoad.GetNoOfQuestions, RDLoad.GetExamDuration.ToString & " Min ")
                Case 3
                    STXT.TxtWriter(RDLoad.GetNoOfQuestions, " NA ")
            End Select
            SaveFileDig.Dispose()
            SaveFileDig = Nothing
            STXT = Nothing
            eXaminationHost.ResultsSaved = True
            Me.Hide()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCancel.Click
        Me.Close()
    End Sub

    Private Sub SaveResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        eXaminationHost.TimerRefreshGrid.Enabled = False
    End Sub






#Region " picture box "
    
    'Mouse enter
    Private Sub PBHtml_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PBHtml.MouseEnter
        PBHtml.BackgroundImage = PBHtml_2.BackgroundImage
        PBText.BackgroundImage = PBtext_1.BackgroundImage
        PBCancel.BackgroundImage = PBCancel_1.BackgroundImage
    End Sub
    Private Sub PBtext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PBText.MouseEnter
        PBHtml.BackgroundImage = PBHtml_1.BackgroundImage
        PBText.BackgroundImage = PBtext_2.BackgroundImage
        PBCancel.BackgroundImage = PBCancel_1.BackgroundImage
    End Sub
    Private Sub PBCancel_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PBCancel.MouseEnter
        PBHtml.BackgroundImage = PBHtml_1.BackgroundImage
        PBText.BackgroundImage = PBtext_1.BackgroundImage
        PBCancel.BackgroundImage = PBCancel_2.BackgroundImage
    End Sub


    'Mousedown
    Private Sub PBHtml_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBHtml.MouseDown
        PBHtml.BackgroundImage = PBHtml_3.BackgroundImage
    End Sub
    Private Sub PBtext_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBText.MouseDown
        PBText.BackgroundImage = PBtext_3.BackgroundImage
    End Sub
    Private Sub PBcancel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBCancel.MouseDown
        PBCancel.BackgroundImage = PBCancel_3.BackgroundImage
    End Sub



    Private Sub PBHtml_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBHtml.MouseUp
        PBHtml.BackgroundImage = PBHtml_2.BackgroundImage
    End Sub

    Private Sub PBcancel_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBCancel.MouseUp
        PBCancel.BackgroundImage = PBCancel_2.BackgroundImage
    End Sub
    Private Sub PBtext_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBText.MouseUp
        PBText.BackgroundImage = PBtext_2.BackgroundImage
    End Sub




#End Region












End Class