Public Class addbook
    Dim cl As New Connection
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

        Control.Show()
    End Sub

    Private Sub addbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bookadd_Click(sender As Object, e As EventArgs) Handles bookadd.Click

        cl.add("insert into books values ('" & isbn.Text & "','" & titre.Text & "','" & auth.Text & "','" & pubdate.Value.ToString("yyyy-MM-dd") & "','oui','" & genre.Text & "','" & price.Text & "')")
        Me.Hide()


        Control.Show()
    End Sub
End Class