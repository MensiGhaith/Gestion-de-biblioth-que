Public Class charttt
    Dim cl As New Connection

    Private Sub charttt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.charger_grid(grid1234, "select * from books ")
        charty()

    End Sub
    Sub charty()
        grid1234.Visible = False

        Dim h, d, s, autre, n, c As Integer
        For j As Integer = 0 To grid1234.RowCount - 1


            If grid1234(5, j).Value = "horror" Then
                h = h + 1
            ElseIf grid1234(5, j).Value = "drama" Then
                d = d + 1
            ElseIf grid1234(5, j).Value = "sport" Then
                s = s + 1
            ElseIf grid1234(5, j).Value = "comedy" Then
                c = c + 1

            Else
                autre = autre + 1

            End If
        Next
        n = grid1234.RowCount




        Me.Chart1.Series("Genre").Points.AddXY("drama", d)
        Me.Chart1.Series("Genre").Points.AddXY("sport", s)
        Me.Chart1.Series("Genre").Points.AddXY("horror", h)
        Me.Chart1.Series("Genre").Points.AddXY("comedy", c)

        Me.Chart1.Series("Genre").Points.AddXY("autre", autre - 1)




    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()


        User.Show()
    End Sub
End Class