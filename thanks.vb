Public Class thanks
    Dim cl As Connection
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Book.cin.Clear()

        User.Dispose()
        User.Show()





    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If DialogResult.OK = MessageBox.Show("Do you want to leave this page", "Closing in progress ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Me.Hide()
            login.usern.Clear()
            login.psd.Clear()

            login.Show()
        End If
    End Sub
End Class