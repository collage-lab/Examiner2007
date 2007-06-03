Imports Microsoft.Win32 'Namespace for registry operation


Public NotInheritable Class eXaminerSplashScreen


    Private Sub eXaminerSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Software As RegistryKey = Registry.CurrentUser.OpenSubKey("Software")
            Dim Examiner2007 As RegistryKey = Software.OpenSubKey("Examiner2007")
            Dim ExmEditor As RegistryKey = Examiner2007.OpenSubKey("Exam-Editor")

            If ExmEditor.GetValue("RegIndex") = "Checked" Then
                'Do noting
            Else
                CreatReg()
            End If
            Software.Close()
            Examiner2007.Close()
            ExmEditor.Close()
        Catch ex As Exception
            CreatReg()
        Finally

        End Try
       

    End Sub

    Function CreatReg() As Boolean

        
        Try
            'Creating registry values
            Dim Software As RegistryKey = Registry.CurrentUser.CreateSubKey("Software")
            Dim Examiner2007 As RegistryKey = Software.CreateSubKey("Examiner2007")
            Dim ExmEditor As RegistryKey = Examiner2007.CreateSubKey("Exam-Editor")
            'Create data for the ExamEditor
            ExmEditor.SetValue("RegIndex", "Checked")
            ExmEditor.SetValue("FileIndex", "0")
            ExmEditor.SetValue("File0", "")
            ExmEditor.SetValue("File1", "")
            ExmEditor.SetValue("File2", "")
            ExmEditor.SetValue("File3", "")
            ExmEditor.SetValue("File4", "")
            Software.Close()
            Examiner2007.Close()
            ExmEditor.Close()
        Catch ex As Exception
            MessageBox.Show("Error in accesing Windows Registry call your system administrator", "Registry Accessing Registry", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End
        Finally
            
        End Try
    End Function
End Class
