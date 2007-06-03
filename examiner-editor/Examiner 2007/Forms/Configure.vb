Imports Encoder.FileCrypto
Imports CofigRW.ConfigReadWriter

Public Class Configure

#Region "   Events   "

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        StartSelector.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        Me.Visible = False
        StartSelector.Visible = True
        Dim ConfigFile As String = My.Application.Info.DirectoryPath & "\Configure.rcf"
        Dim TempFile As String = My.Application.Info.DirectoryPath & "\TempConfig.xml"
        Dim Coder As New Encoder.FileCrypto
        Dim IP As String = IPAddress.Text
        Try
            Dim CofRW As New CofigRW.ConfigReadWriter
            CofRW.SetConfEntrty(TempFile, IP, 3035)
            'Encode Configuration File index = 1
            Coder.FileEncript(TempFile, ConfigFile, 1)
            'Delete Temp File
            IO.File.Delete(TempFile)
        Catch Fx As IO.FileNotFoundException
            MessageBox.Show("Configuration File Missing Reinstall The product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch Sx As System.UnauthorizedAccessException
            MessageBox.Show("Unauthorized Access Check your Security settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch IOx As System.IO.IOException
            MessageBox.Show("Error in Configuration File  Reinstall The product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch ex As Exception
            MessageBox.Show("UnExpected Error ", "Error")
            End
        End Try
    End Sub

    Private Sub Configure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConfigFile As String = My.Application.Info.DirectoryPath & "\Configure.rcf"
        Dim TempFile As String = My.Application.Info.DirectoryPath & "\TempConfig.xml"
        Dim Coder As New Encoder.FileCrypto
        Try
            'Decode Configaration File
            Coder.FileDecript(ConfigFile, TempFile, 1)
            'read IPAddress(Configure.xml)
            Dim CRW As New CofigRW.ConfigReadWriter
            IPAddress.Text = CRW.GetIPAddress(TempFile)
            'Delete Configuration File
            IO.File.Delete(TempFile)
        Catch Fx As IO.FileNotFoundException
            MessageBox.Show("Configuration File Missing Reinstall The product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch Sx As System.UnauthorizedAccessException
            MessageBox.Show("Unauthorized Access ,Check your Security settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch IOx As System.IO.IOException
            MessageBox.Show("Error in Configuration File  Reinstall The product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch ex As Exception
            MessageBox.Show("UnExpected Error ", "Error")
            End
        End Try
    End Sub

#End Region

End Class