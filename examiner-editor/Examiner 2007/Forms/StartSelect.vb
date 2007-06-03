
Imports System.Runtime.Remoting
Imports Encoder.FileCrypto                  'Class provides Functions For the encription and decription of data
Imports ReDataProV.RemortDataProvider       'Class Provides Functions to stream Remort Data
Imports DLoder.ExmDataLoader                                     'Class For Loading Updating



Public Class StartSelector




#Region "   Picture Buttons   "

    Private Sub PictureBoxLoadExam_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxLoadExam.MouseEnter
        PictureBoxLoadExam.BackgroundImage = Loadexam2.BackgroundImage
        PictureBoxStartExam.BackgroundImage = Startexam1.BackgroundImage
        PictureBoxConfigure.BackgroundImage = Configure1.BackgroundImage
    End Sub
    Private Sub PictureBoxStartExam_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxStartExam.MouseEnter
        PictureBoxLoadExam.BackgroundImage = Loadexam1.BackgroundImage
        PictureBoxStartExam.BackgroundImage = Startexam2.BackgroundImage
        PictureBoxConfigure.BackgroundImage = Configure1.BackgroundImage
    End Sub
    Private Sub PictureBoxConfigure_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBoxConfigure.MouseEnter
        PictureBoxLoadExam.BackgroundImage = Loadexam1.BackgroundImage
        PictureBoxStartExam.BackgroundImage = Startexam1.BackgroundImage
        PictureBoxConfigure.BackgroundImage = Configure2.BackgroundImage

    End Sub

    Private Sub PictureBoxLoadExam_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxLoadExam.MouseDown
        PictureBoxLoadExam.BackgroundImage = Loadexam3.BackgroundImage
    End Sub
    Private Sub PictureBoxStartExam_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxStartExam.MouseDown
        PictureBoxStartExam.BackgroundImage = Startexam3.BackgroundImage
    End Sub
    Private Sub PictureBoxConfigure_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxConfigure.MouseDown
        PictureBoxConfigure.BackgroundImage = Configure3.BackgroundImage
    End Sub

    Private Sub PictureBoxLoadExam_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxLoadExam.MouseUp
        PictureBoxLoadExam.BackgroundImage = Loadexam2.BackgroundImage
    End Sub
    Private Sub PictureBoxStartExam_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxStartExam.MouseUp
        PictureBoxStartExam.BackgroundImage = Startexam2.BackgroundImage
    End Sub
    Private Sub PictureBoxConfigure_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxConfigure.MouseUp
        PictureBoxConfigure.BackgroundImage = Configure2.BackgroundImage
    End Sub

#End Region

#Region "   Button events   "
    Private Sub PictureBoxLoadExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxLoadExam.Click
        LoadExm()

    End Sub
    Private Sub PictureBoxStartExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxStartExam.Click
        If ConfigRemort() = True Then
            LoadExaminer()
        Else
            ReStart()
        End If
    End Sub
    Private Sub PictureBoxConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxConfigure.Click
        Me.Visible = False
        Configure.Visible = True
    End Sub
#End Region

#Region "   Form Events   "
    Private Sub StartSelector_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Terminate.Show()
    End Sub
    
#End Region
    'code for DescriptExm *   - LoadExam *  - LoadDBase *
#Region " ------->  Load Exam Form File   <------  "

    Public Sub LoadExm()
        'File Open Dialog
        Dim FilePath As String
        Dim TempFilePath As String = My.Application.Info.DirectoryPath & "\TempDatabase.xml"
        Dim OpenFileDig As New OpenFileDialog
        OpenFileDig.Filter = "Exam files|*.exm|All files|*.*"
        OpenFileDig.FilterIndex = 1
        OpenFileDig.RestoreDirectory = True
        'IF File Opened
        If OpenFileDig.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FilePath = OpenFileDig.FileName
            '''''
            OpenFileDig.Dispose()
            OpenFileDig = Nothing
            '''''
            Me.Visible = False
            LoadFromFile.Show()
            Try
                If DecriptExm(FilePath, TempFilePath) = True Then           'Decript Exm Questions
                    LoadDBase(TempFilePath)                                 'Loading database
                    examiner.Visible = True
                    LoadFromFile.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Unable to write temporary file please check your security settings", "Error in Writing files", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Visible = True
                LoadFromFile.Visible = False
            Finally
                DeleteTempFile(TempFilePath)                            'Delete Temp Xml File created
            End Try
        Else
            Me.Visible = True
            LoadFromFile.Visible = False
        End If

    End Sub

    Private Function DecriptExm(ByVal Fin As String, ByVal Fout As String) As Boolean
        Try
            Dim Fc As New Encoder.FileCrypto
            Fc.FileDecript(Fin, Fout, 2)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'DataBase opprections
    Private Sub LoadDBase(ByVal TempData As String)
        Dim DataLoader As New DLoder.ExmDataLoader
        Try
            'question table
            DataLoader.CreateQuestionTable() '                                              
            '''''''''''''''''''''''''''''''''''''''''''''''''' 
            ''connecting with the database  >>  ODbConnection ( Conection Object )
            ODbConnection.Open()
            'Data set
            Dim DSet As New Data.DataSet
            DSet.ReadXml(TempData)
            'Configure adapter  >>  LoadAdapter
            LoadAdapter.Update(DSet)
            ''''''''''''''''''''''''''''''''''''''''''''''''''
            ODbConnection.Close()
            ODbConnection.Dispose()
            ODbConnection = Nothing
            LoadAdapter.Dispose()
            LoadAdapter = Nothing
        Catch ex As System.Data.OperationAbortedException
            examiner.ShowError(3)
            DataLoader.DeleteQuestions()            'Delete Questions
        End Try
        DataLoader = Nothing    'Gcollection
    End Sub
    '  Code
#End Region
    'code for ConfigRemort *  -  LoadExaminer *
#Region " ------>    Exam From Remort Server    <------- "
    'Code
    Private Function ConfigRemort() As Boolean

        Dim ConfigFile As String = My.Application.Info.DirectoryPath & "\Configure.rcf"
        Dim TempFile As String = My.Application.Info.DirectoryPath & "\TempConfig.xml"
        Dim Coder As New Encoder.FileCrypto
        Dim IPAddress As String
        Dim Port As Integer
        Try
            'Decode Configaration File
            Coder.FileDecript(ConfigFile, TempFile, 1)
            'read IPAddress(Configure.xml)
            Dim ConRW As New CofigRW.ConfigReadWriter
            IPAddress = ConRW.GetIPAddress(TempFile)
            'read PortID 
            Port = ConRW.GetPortID(TempFile)
            'Delete Configuration File
            DeleteTempFile(TempFile)
            'Configaring Remorting
            Dim ConfigurationString As String = "tcp://" & IPAddress & ":" & Port & "/ReDataProV.rem"
            RemotingConfiguration.RegisterWellKnownClientType(GetType(ReDataProV.RemortDataProvider), ConfigurationString)
            'testing whether remorting properly configured
            Dim TestRemortObject As New ReDataProV.RemortDataProvider
            If TestRemortObject.IsServer() = True Then
                Return True
            End If
        Catch FexEx As IO.FileNotFoundException
            MessageBox.Show("Unable to write temporary file please check your security settings", "Error in Writing files", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch snsse As System.Net.Sockets.SocketException
            examiner.ShowError(1)
            Return False
        Catch Ex As Exception
            examiner.ShowError(2)
            Return False
        End Try
    End Function
#End Region

#Region "   Functions ----> DeleteTempFile   ReStart()      LoadExaminer     "
    Private Sub LoadExaminer()
        Me.Visible = False
        examiner.Visible = True
    End Sub
    Private Sub DeleteTempFile(ByVal Path As String)
        Try
            IO.File.Delete(Path)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ReStart()
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe")
            End
        Catch ex As Exception
            MessageBox.Show(My.Application.Info.DirectoryPath & My.Application.Info.AssemblyName)
        End Try

    End Sub
#End Region


 
    
End Class
