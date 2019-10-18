Public Class ALLstudent
    Dim cl As New Connection

    Private Sub ALLstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.charger_grid(grid12, "select cin as 'CIN', fullname as 'Fullname', birthday as 'Birthday', username as 'username', password as 'Password'  from users   where admin=0")

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()


        Control.Show()
    End Sub
End Class