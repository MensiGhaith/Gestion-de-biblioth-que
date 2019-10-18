Imports MySql.Data.MySqlClient

Public Class User
    Dim cl As New Connection



    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filtrer_classe()

    End Sub
    Sub filtrer_classe()
        Dim curdate As Date = Date.Now
        lbldate.Text = "Session open in :" + curdate
        cl.charger_grid(DataGridView1, "select isbn as'ISBN', title as 'Title' , author as 'Author' , price as 'Price en DT' from books where dispo='oui' order by title")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub zone1_Click(sender As Object, e As EventArgs) Handles zone1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
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

    Private Sub BookABookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookABookToolStripMenuItem.Click
        Me.Hide()
        Book.Show()

    End Sub

    Private Sub ReturnedTheBookToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReturnABookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnABookToolStripMenuItem.Click
        Me.Hide()
        bookreturn.Dispose()

        bookreturn.Show()

    End Sub

    Private Sub ChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChartToolStripMenuItem.Click
        Me.Hide()
        charttt.Show()

    End Sub
End Class