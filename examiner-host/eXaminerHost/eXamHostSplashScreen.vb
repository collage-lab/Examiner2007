Imports System.Runtime.Remoting
Imports ReDataProV.RemortDataProvider       '   Class For RemortDataIntaraction
Imports ResultWriter.ResultTextWriter       '   Class For Publishing Results in txt Format
Imports ResultWriter.WriteHTML              '   Class For Publishing Results in Html Format
Imports DLoder.ExmDataLoader                '   Class For Data Base Intaraction

Public NotInheritable Class eXamHostSplashScreen
   
    
    Private Sub eXamHostSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RemotingConfiguration.RegisterWellKnownServiceType(GetType(ReDataProV.RemortDataProvider), "ReDataProV.rem", WellKnownObjectMode.SingleCall)
            System.Runtime.Remoting.Channels.ChannelServices.RegisterChannel(New System.Runtime.Remoting.Channels.Tcp.TcpServerChannel(3035))
            'eHostTimer.Enabled = True
        Catch ex As System.Net.Sockets.SocketException
            MessageBox.Show("Error in Configaration Plasse Restart your program ,Check does another examiner running on the same system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Catch Exa As Exception
            MessageBox.Show("UnExpected Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Public Sub ShowError(ByVal ErrorIndex As Integer)
        Select Case ErrorIndex
            Case 1
                MessageBox.Show("Error in Configaration Plasse Restart your program ,Check does another examiner running on the same system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Teminate.Show()
            Case 2
                MessageBox.Show("UnExpected Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Teminate.Show()
            Case 3
                MessageBox.Show("Access Denaied Check Your Security Settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Teminate.Show()
        End Select
    End Sub

End Class
