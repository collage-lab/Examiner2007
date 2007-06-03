Imports ReDataProV.RemortDataProvider       '   Class For RemortDataIntaraction
Imports ResultWriter.ResultTextWriter       '   Class For Publishing Results in txt Format
Imports ResultWriter.WriteHTML              '   Class For Publishing Results in Html Format
Imports DLoder.ExmDataLoader                '   Class For Data Base Intaraction
Imports Encoder.FileCrypto


Public Class ExamOption
    'Dim _Duration As Integer
    Public _TimeManage As Integer
    Public _ExamDuration As Integer
    Dim ERProvider As New ErrorProvider

#Region "       Form Events         "
    Private Sub ExamOption_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Teminate.Show()
    End Sub
    Private Sub ExamOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TextBoxFileOpen.Text = My.Application.CommandLineArgs(0)
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "       Button Events       "
    Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click
        Dim OpenFileDig As New OpenFileDialog
        OpenFileDig.Filter = "Exam files|*.exm"
        OpenFileDig.FilterIndex = 1
        OpenFileDig.RestoreDirectory = True
        If OpenFileDig.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TextBoxFileOpen.Text = OpenFileDig.FileName
            '''''
            OpenFileDig.Dispose()
            OpenFileDig = Nothing
        End If
    End Sub
    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        If TextBoxFileOpen.Text = "" Then
            ERProvider.SetError(TextBoxFileOpen, "Enter a Valid File name")
        ElseIf RBLim.Checked = True And NumericTextBox.Text = "" Then
            ERProvider.Clear()
            ERProvider.SetError(RBLim, "Enter duration of Examination in min")
        Else
            If IO.File.Exists(TextBoxFileOpen.Text) Then
                SaveOptions()
                ERProvider.Clear()
            Else
                MessageBox.Show("Examiner couldnot open this file", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Teminate.Show()
    End Sub
#End Region

#Region "        Radio Button       "
    Private Sub RBLim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBLim.CheckedChanged
        NumericTextBox.Enabled = True
        RButtonQst.Enabled = True
        RButtonMan.Enabled = False
        RButtonAuto.Checked = True
    End Sub
    Private Sub RBU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBU.CheckedChanged
        NumericTextBox.Enabled = False
        RButtonQst.Enabled = False
        RButtonMan.Checked = True
        RButtonMan.Enabled = True
    End Sub
#End Region

#Region "       Private Methodes        "
    Private Sub SaveOptions()
        Dim EDLoader As New DLoder.ExmDataLoader
        'Check DataTable present in the data base '    if so Delete
        If CheckDataTable("Questions") = True Then
            EDLoader.DeleteQuestions()
        End If
        If CheckDataTable("ExamProperties") = True Then
            EDLoader.DeleteExamProperties()
        End If
        If CheckDataTable("Examination") = True Then
            EDLoader.DeleteExamTable()
        End If
        'Create DataBase Table
        EDLoader.CreateExamPropertiesTable()
        EDLoader.CreateExamTable()
        EDLoader.CreateQuestionTable()
        'Insert Examination Properties
        'Exam Duration                 
        If RBU.Checked = True Then
            _ExamDuration = 1000
        ElseIf RBLim.Checked = True Then
            _ExamDuration = CInt(NumericTextBox.Text)
        End If
        'Time Managing                  
        If RButtonMan.Checked = True Then
            _TimeManage = 1
        ElseIf RButtonAuto.Checked = True Then
            _TimeManage = 2
        ElseIf RButtonQst.Checked = True Then
            _TimeManage = 3
        End If
        '
        'insert Exam properties
        EDLoader.InsertExamPropeties(False, False, _TimeManage, _ExamDuration)
        'Decript File
        Dim Fcry As New Encoder.FileCrypto
        Try
            If Fcry.FileDecript(TextBoxFileOpen.Text, My.Application.Info.DirectoryPath & "\TempDataBase.xml", 2) = False Then
                MessageBox.Show("Invalid File or the file may corrupted", "Cannot Oppen File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Load Questions from File to DaataBase
                If LoadQuestions(My.Application.Info.DirectoryPath & "\TempDataBase.xml") = True Then
                    'load Exam host
                    StartExam.Show()
                    Me.Visible = False
                Else
                    MessageBox.Show("Invalid File or the file may corrupted", "Cannot Oppen File", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid File or the file may corrupted", "Cannot Oppen File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ''Delete temp file
        IO.File.Delete(My.Application.Info.DirectoryPath & "\TempDataBase.xml")
    End Sub

    Private Function CheckDataTable(ByVal DataTable As String) As Boolean
        Try
            'new OleDBDataApapter
            Dim ODBAdapter As Data.OleDb.OleDbDataAdapter = New Data.OleDb.OleDbDataAdapter("SELECT * FROM " & DataTable, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb")
            'new DataSet
            Dim DataSet As New Data.DataSet
            ODBAdapter.Fill(DataSet)
            ODBAdapter.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function LoadQuestions(ByVal FileName As String) As Boolean
        Dim DataLoader As New DLoder.ExmDataLoader
        Try
            'question table
            '''''''''''''''''''''''''''''''''''''''''''''''''' 
            ''connecting with the database  >>  ODbConnection ( Conection Object )
            ODbConnection.Open()
            'Data set
            Dim DSet As New Data.DataSet
            DSet.ReadXml(My.Application.Info.DirectoryPath & "\TempDataBase.xml")
            'Configure adapter  >>  LoadAdapter
            LoadAdapter.Update(DSet)
            ''''''''''''''''''''''
            ''''''''''''''''''''''''''''
            DSet.Dispose()
            DSet = Nothing
            ODbConnection.Close()
            Return True
        Catch ex As System.Data.OperationAbortedException
            DataLoader.DeleteQuestions()           'Delete Questions
            Return False
        End Try
        'Gcollection
    End Function
#End Region

End Class