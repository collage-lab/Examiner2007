Public Class About

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        eXaminationHost.Enabled = True
        Me.Visible = False
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        User.Text = My.User.Name
        ComputerNam.Text = My.Computer.Name
        'ProdectIdLabel.Text =
    End Sub
End Class