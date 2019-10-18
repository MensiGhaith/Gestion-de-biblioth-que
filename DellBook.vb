Public Class DellBook
    Dim cl As New Connection
    Private Sub DellBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.loadbook1("select * from books where dispo='oui' order by title ", combo)
    End Sub

    Private Sub DEL_Click(sender As Object, e As EventArgs) Handles DEL.Click
        cl.mettre_a_jour("delete from books where isbn='" & combo.SelectedValue & "'")
        Me.Hide()

        Control.Show()
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