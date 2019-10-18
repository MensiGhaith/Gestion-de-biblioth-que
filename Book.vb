Public Class Book
    Dim cl As New Connection
    Dim req As String
    Public lyoum As Date
    Public expire As Date

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.loadbook1("select * from books where dispo='oui' order by title ", ComboBox1)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cl.verif_cin("select admin from users where cin='" & cin.Text & "'")) Then


            lyoum = Date.Now.ToString("yyyy-MM-dd")
            expire = DateAdd("d", 15, lyoum).ToString("yyyy-MM-dd")
            cl.add("insert into borrowing (isbnb,bor_date,return_date,cins) values ('" & ComboBox1.SelectedValue & "','" & lyoum.ToString("yyyy-MM-dd") & "','" & expire.ToString("yyyy-MM-dd") & "','" & cin.Text & "' )")
            cl.mettre_a_jour("update books set dispo='non' where isbn='" & ComboBox1.SelectedValue & "' ")
            Me.Hide()
            thanks.Show()


        Else
            MsgBox("erreur")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If DialogResult.OK = MessageBox.Show("Do you want to leave this page", "Closing in progress ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Me.Hide()
            login.usern.Clear()
            login.psd.Clear()

            login.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

        User.Show()
    End Sub
End Class