Public Class upbook
    Dim cl As New Connection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Control.Dispose()
        Control.Show()
    End Sub

    Private Sub upbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.loadbook1("select * from books where dispo='oui' order by title ", ComboBox8)
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox3.Text = "Genre  -->"
            TextBox2.Visible = True
            Label3.Visible = True
        Else
            CheckBox3.Text = "Genre?"
            TextBox2.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Text = "Author -->"
            TextBox1.Visible = True
            Label2.Visible = True
        Else
            CheckBox2.Text = "Author?"

            TextBox1.Visible = False
            Label2.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox4.Text = "Price -->"
            TextBox3.Visible = True
            Label4.Visible = True
        Else
            CheckBox4.Text = "Price?"
            TextBox3.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged

    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If CheckBox2.Checked And CheckBox3.Checked = False And CheckBox4.Checked = False Then
            cl.mettre_a_jour("update books set author='" & TextBox1.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()

        ElseIf CheckBox3.Checked And CheckBox2.Checked = False And CheckBox4.Checked = False Then
            cl.mettre_a_jour("update books set genre='" & TextBox2.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox4.Checked And CheckBox3.Checked = False And CheckBox2.Checked = False Then
            cl.mettre_a_jour("update books set price='" & TextBox3.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox2.Checked And CheckBox3.Checked And CheckBox4.Checked = False Then
            cl.mettre_a_jour("update books set author='" & TextBox1.Text & "',  genre='" & TextBox2.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox2.Checked And CheckBox4.Checked And CheckBox3.Checked = False Then
            cl.mettre_a_jour("update books set author='" & TextBox1.Text & "',  price='" & TextBox3.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox2.Checked = False And CheckBox4.Checked And CheckBox3.Checked Then
            cl.mettre_a_jour("update books set  genre='" & TextBox2.Text & "',  price='" & TextBox3.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()

        ElseIf CheckBox2.Checked And CheckBox3.Checked And CheckBox4.Checked Then
            cl.mettre_a_jour("update books set author='" & TextBox1.Text & "',  genre='" & TextBox2.Text & "',  price='" & TextBox3.Text & "' where isbn='" & ComboBox8.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False Then

            MsgBox("you have to match at least one checkbox")



        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub uutitle_Click(sender As Object, e As EventArgs) Handles uutitle.Click

    End Sub
End Class