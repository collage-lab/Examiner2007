Public Class Terminate
    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Try
            ProgressBar.Value = ProgressBar.Value - 10
        Catch ex As ArgumentOutOfRangeException
            End
        End Try
    End Sub

    Private Sub Terminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Deleting temprory files
        Dim EDLoader As New DLoder.ExmDataLoader
        Try
            EDLoader.DeleteQuestions()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamTable()
        Catch ex As Exception
        End Try
        Try
            EDLoader.DeleteExamProperties()
        Catch ex As Exception
        End Try
        Try
            IO.File.Delete(My.Application.Info.DirectoryPath & "\TempDatabase.xml")
        Catch ex As Exception
        End Try
        Try
            IO.File.Delete(My.Application.Info.DirectoryPath & "\TempConfig.xml")
        Catch ex As Exception
        End Try
        Timer.Enabled = True
    End Sub
End Class