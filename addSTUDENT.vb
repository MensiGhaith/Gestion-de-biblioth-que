Public Class addSTUDENT
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cl.verif_cin("select * from users where username='" & useradd.Text & "'") = 1 Then

            MsgBox("username already exists")
        Else
            cl.add("insert into users values ('" & cina.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & passadd.Text & "','" & useradd.Text & "','0')")
            Me.Hide()
            Control.Dispose()

            Control.Show()
        End If
    End Sub

    Private Sub addSTUDENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class