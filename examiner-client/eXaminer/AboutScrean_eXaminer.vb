Public Class AboutScrean_eXaminer

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub AboutScrean_eXaminer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim currentUser As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Me.Owner = eXaminer
        User.Text = My.User.Name
        ComputerNam.Text = My.Computer.Name
    End Sub
End Class