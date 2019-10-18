Public Class bookreturn
    Dim cl As New Connection
    Dim req As String
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub bookreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.loadbook1("select * from books where dispo='non' order by title ", ComboBox3)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cl.verif_cin("select cins from borrowing where cins='" & cin11.Text & "' and isbnb='" & ComboBox3.SelectedValue & "'")) Then



            cl.mettre_a_jour("delete from borrowing where  cins='" & cin11.Text & "'")
            cl.mettre_a_jour("update books set dispo='oui' where isbn='" & ComboBox3.SelectedValue & "' ")
            Me.Hide()
            thanks.Show()


        Else
            MsgBox("erreur")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If DialogResult.OK = MessageBox.Show("Do you want to leave this page", "Closing in progress ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Me.Hide()
            login.usern.Clear()
            login.psd.Clear()

            login.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

        User.Show()

    End Sub
End Class