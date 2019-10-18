Public Class Control
    Dim cl As New Connection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If DialogResult.OK = MessageBox.Show("Do you want to leave this page", "Closing in progress ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Me.Hide()
            login.usern.Clear()
            login.psd.Clear()

            login.Show()
        End If
    End Sub

    Private Sub ThefToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThefToolStripMenuItem.Click

    End Sub

    Private Sub grid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick, grid.CellContentClick

    End Sub
    Sub filtrer_classe()
        Dim curdate As Date = Date.Today
        cl.charger_grid(grid, "select o.isbnb as 'ISBN', b.title as 'Book Title', u.fullname as 'Fullname '  from books b,borrowing o,users u  where o.isbnb=b.isbn and u.cin=o.cins and  '" & curdate.ToString("yyyy-MM-dd") & "'> o.return_date")


    End Sub

    Private Sub Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filtrer_classe()
    End Sub

    Private Sub zone_Click(sender As Object, e As EventArgs) Handles zone.Click

    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        Me.Hide()
        addSTUDENT.Dispose()
        addSTUDENT.Show()

    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        Me.Hide()
        addbook.Dispose()
        addbook.Show()
    End Sub

    Private Sub BookToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem1.Click
        Me.Hide()
        upbook.Dispose()
        upbook.Show()
    End Sub

    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem1.Click
        Me.Hide()
        upStudent.Dispose()
        upStudent.Show()
    End Sub

    Private Sub ALLSTUDENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALLSTUDENTSToolStripMenuItem.Click
        Me.Hide()
        ALLstudent.Dispose()
        ALLstudent.Show()
    End Sub

    Private Sub ALLBOOKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALLBOOKSToolStripMenuItem.Click
        Me.Hide()
        ALLbooks.Dispose()
        ALLbooks.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        Delstudent.Dispose()
        Delstudent.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        DellBook.Dispose()
        DellBook.Show()
    End Sub
End Class