Public Class ALLbooks
    Dim cl As New Connection

    Private Sub ALLbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.charger_grid(grid123, "select * from books order by genre")
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

    Private Sub grid123_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid123.CellContentClick

    End Sub
End Class