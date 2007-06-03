Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim EDLoader As New DLoder.ExmDataLoader
        Try
            IO.File.Delete(My.Application.Info.DirectoryPath & "\TempDatabase.xml")
        Catch ex As Exception
        End Try
        Try
            IO.File.Delete(My.Application.Info.DirectoryPath & "\TempConfig.xml")
        Catch ex As Exception
        End Try
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
        If IO.File.Exists(My.Application.Info.DirectoryPath & "\Examiner2007.mdb") = True Then
        Else
            MessageBox.Show("DataBase Fileis missing Reinstall your product", "FillMissing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class