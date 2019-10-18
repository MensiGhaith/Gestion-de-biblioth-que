Public Class upStudent
    Dim cl As New Connection
    Private Sub upStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cl.loadbook2("select * from users order by cin", ComboBox88)
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked Then
            CheckBox22.Text = "Fullname-->"
            TextBox11.Visible = True
            Label22.Visible = True
        Else
            CheckBox22.Text = "Fullname?"

            TextBox11.Visible = False
            Label22.Visible = False
        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.Checked Then
            CheckBox33.Text = "Username-->"
            TextBox22.Visible = True
            Label33.Visible = True
        Else
            CheckBox33.Text = "Username?"
            TextBox22.Visible = False
            Label33.Visible = False
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.Checked Then
            CheckBox44.Text = "Password-->"
            TextBox33.Visible = True
            Label44.Visible = True
        Else
            CheckBox44.Text = "Password?"
            TextBox33.Visible = False
            Label44.Visible = False
        End If
    End Sub

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

    Private Sub btn_up1_Click(sender As Object, e As EventArgs) Handles btn_up1.Click
        If CheckBox22.Checked And CheckBox33.Checked = False And CheckBox44.Checked = False Then
            cl.mettre_a_jour("update users set fullname='" & TextBox11.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()

        ElseIf CheckBox33.Checked And CheckBox22.Checked = False And CheckBox44.Checked = False Then
            cl.mettre_a_jour("update users set username='" & TextBox22.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox44.Checked And CheckBox33.Checked = False And CheckBox22.Checked = False Then
            cl.mettre_a_jour("update users set password='" & TextBox33.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox22.Checked And CheckBox33.Checked And CheckBox44.Checked = False Then
            cl.mettre_a_jour("update users set fullname='" & TextBox11.Text & "',  username='" & TextBox22.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox22.Checked And CheckBox44.Checked And CheckBox33.Checked = False Then
            cl.mettre_a_jour("update users set fullname='" & TextBox11.Text & "',  password='" & TextBox33.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox22.Checked = False And CheckBox44.Checked And CheckBox33.Checked Then
            cl.mettre_a_jour("update users set  username='" & TextBox22.Text & "',  password='" & TextBox33.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()

        ElseIf CheckBox22.Checked And CheckBox33.Checked And CheckBox44.Checked Then
            cl.mettre_a_jour("update users set fullname='" & TextBox11.Text & "',  username='" & TextBox22.Text & "',  password='" & TextBox33.Text & "' where cin='" & ComboBox88.SelectedValue & "'")
            Me.Hide()
            Control.Dispose()
            Control.Show()
        ElseIf CheckBox22.Checked = False And CheckBox33.Checked = False And CheckBox44.Checked = False Then

            MsgBox("you have to match at least one checkbox")



        End If
    End Sub
End Class